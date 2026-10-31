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
class US0_Debug(NamedTuple): # Debug
    tag = 1
class US0_Info(NamedTuple): # Info
    tag = 2
class US0_Warning(NamedTuple): # Warning
    tag = 3
class US0_Critical(NamedTuple): # Critical
    tag = 4
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
US1 = Union[US1_Some, US1_None]
class US2_Some(NamedTuple): # Some
    v0 : i64
    tag = 0
class US2_None(NamedTuple): # None
    tag = 1
US2 = Union[US2_Some, US2_None]
class US3_Some(NamedTuple): # Some
    v0 : string
    tag = 0
class US3_None(NamedTuple): # None
    tag = 1
US3 = Union[US3_Some, US3_None]
@dataclass
class Mut5:
    v0 : i32
    v1 : US1
def closure1():
    def inner(v0 : string) -> None:
        return 
    return inner
def closure0():
    def inner(v0 : US0) -> Tuple[Mut0, Mut1, Mut2, Mut3, Mut4, i64]:
        v1, v2, v3, v4, v5, v6 = new_trace_state_0(v0)
        return v1, v2, v3, v4, v5, v6
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
US4 = Union[US4_Some, US4_None]
def closure2():
    def inner(v0 : string) -> None:
        print(v0)
        return 
    return inner
class UH0_Nil(NamedTuple): # Nil
    tag = 0
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
    v11 = US3_None()
    v12 = (v11 if v10 is None else v10)
    del v10, v11
    match v12:
        case US3_None(): # None
            del v12
            v14 = ""
            return v14
        case US3_Some(v13): # Some
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
            v7 = spiral_wrap(v3 + 1, 32, True)
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
    v13 = US0_Critical()
    v12.insert(0, (v3, v13))
    del v3, v13
    v14 = v12 
    del v12
    v15 = US0_Warning()
    v14.insert(0, (v5, v15))
    del v5, v15
    v16 = v14 
    del v14
    v17 = US0_Info()
    v16.insert(0, (v7, v17))
    del v7, v17
    v18 = v16 
    del v16
    v19 = US0_Debug()
    v18.insert(0, (v9, v19))
    del v9, v19
    v20 = v18 
    del v18
    v21 = US0_Verbose()
    v20.insert(0, (v11, v21))
    del v11, v21
    v22 = v20 
    del v20
    v23 = US0_Critical()
    v22.insert(0, (v2, v23))
    del v2, v23
    v24 = v22 
    del v22
    v25 = US0_Warning()
    v24.insert(0, (v4, v25))
    del v4, v25
    v26 = v24 
    del v24
    v27 = US0_Info()
    v26.insert(0, (v6, v27))
    del v6, v27
    v28 = v26 
    del v26
    v29 = US0_Debug()
    v28.insert(0, (v8, v29))
    del v8, v29
    v30 = v28 
    del v28
    v31 = US0_Verbose()
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
    v38 = US1_None()
    v39 = Mut5(0, v38)
    del v38
    while method4(v37, v39):
        v41 = v39.v0
        v42 = spiral_wrap(-v41, 32, True)
        v43 = spiral_wrap(v42 + v37, 32, True)
        del v42
        v44 = spiral_wrap(v43 - 1, 32, True)
        del v43
        v45 = v39.v1
        v46, v47 = spiral_array_index(v36, v44)
        del v44
        match v45:
            case US1_None(): # None
                v49 = v46 == v1 
                if v49:
                    del v49
                    v54 = US1_Some(v47)
                else:
                    del v49
                    v54 = US1_None()
            case US1_Some(_): # Some
                v54 = v45
            case t:
                raise Exception(f'Pattern matching miss. Got: {t}')
        del v45, v46, v47
        v55 = spiral_wrap(v41 + 1, 32, True)
        del v41
        v39.v0 = v55
        v39.v1 = v54
        del v54, v55
    del v1, v36, v37
    v56 = v39.v1
    del v39
    v57 = "AUTOMATION"
    v58 = get_environment_variable_2(v57)
    del v57
    v59 = "True"
    v60 = v58 != v59 
    del v58, v59
    if v60:
        v65 = US2_None()
    else:
        v62 = datetime.datetime.now()
        v63 = (v62.replace(tzinfo=None) - datetime.datetime(1970, 1, 1)) // datetime.timedelta(microseconds=1)
        del v62
        v65 = US2_Some(v63)
    del v60
    return v56, v65
def new_trace_state_0(v0 : US0) -> Tuple[Mut0, Mut1, Mut2, Mut3, Mut4, i64]:
    v1, v2 = method1()
    v3 = Mut0(1)
    v4 = closure1()
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
    v13 = US2_None()
    v14 = (v13 if v12 is None else v12)
    del v12, v13
    match v14:
        case US2_None(): # None
            v25 = datetime.datetime.now()
            v27 = v25
        case US2_Some(v15): # Some
            v16 = datetime.datetime.now()
            v17 = (v16.replace(tzinfo=None) - datetime.datetime(1970, 1, 1)) // datetime.timedelta(microseconds=1)
            del v16
            v18 = spiral_wrap(v17 - v15, 64, True)
            del v15, v17
            v19 = datetime.timedelta(microseconds=v18)
            del v18
            v20 = v19.seconds // 3600
            v21 = (v19.seconds // 60) % 60
            v22 = v19.seconds % 60
            v23 = v19.microseconds // 1000
            del v19
            v24 = datetime.datetime(1, 1, 1, v20, v21, v22, v23 * 1000)
            del v20, v21, v22, v23
            v27 = v24
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v14
    v28 = method6(v27)
    del v27
    v29 = "%H:%M:%S"
    v30 = v28.strftime(v29)
    del v28, v29
    return v30
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
    v9 = " "
    v10 = v6 + v9 
    del v6
    v11 = format_real_14(v8)
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
    v19 = ""
    v20 = v19 + v19 
    del v19
    v21 = "max"
    v22 = v20 + v21 
    del v20, v21
    v23 = " = "
    v24 = v22 + v23 
    del v22
    v25 = 4738381338321616896
    v26 = format_real_14(v25)
    del v25
    v27 = v24 + v26 
    del v24, v26
    v28 = "; "
    v29 = v27 + v28 
    del v27
    v30 = "p"
    v31 = v29 + v30 
    del v29, v30
    v32 = v31 + v23 
    del v31
    v33 = 4738381338321616896
    v34 = format_real_14(v33)
    del v33
    v35 = v32 + v34 
    del v32, v34
    v36 = v35 + v28 
    del v28, v35
    v37 = "n"
    v38 = v36 + v37 
    del v36, v37
    v39 = v38 + v23 
    del v23, v38
    v40 = 24
    v41 = format_real_15(v40)
    del v40
    v42 = v39 + v41 
    del v39, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v18 + v46 
    del v18, v46
    return method11(v47)
def roll_dice_17() -> u8:
    v0 = random.randrange(1, 7)
    return v0
def method43(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : i64) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = -1
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "result"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_14(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
def method42(v0 : UH0, v1 : i64) -> US5:
    v2 = spiral_wrap(v1 + 1, 64, True)
    v3 = closure0()
    v4 = US0_Verbose()
    if TraceState.trace_state is None: TraceState.trace_state = v3(v4)
    del v4
    v5, v6, v7, v8, v9, v10 = TraceState.trace_state
    del v5, v6, v8, v10
    v11 = v9.v0
    del v9
    match v11:
        case US0_Critical(): # Critical
            v16 = 50
        case US0_Debug(): # Debug
            v16 = 20
        case US0_Info(): # Info
            v16 = 30
        case US0_Verbose(): # Verbose
            v16 = 10
        case US0_Warning(): # Warning
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
        v45 = US4_None()
    else:
        v23 = US0_Verbose()
        if TraceState.trace_state is None: TraceState.trace_state = v3(v23)
        del v23
        v24, v25, v26, v27, v28, v29 = TraceState.trace_state
        v30 = method5(v24, v25, v26, v27, v28, v29)
        v31 = method7()
        v32 = method43(v24, v25, v26, v27, v28, v29, v30, v31, v1, v2)
        del v24, v25, v26, v27, v28, v29, v30, v31
        v33 = US0_Verbose()
        if TraceState.trace_state is None: TraceState.trace_state = v3(v33)
        del v33
        v34, v35, v36, v37, v38, v39 = TraceState.trace_state
        v40 = v34.v0
        v41 = spiral_wrap(v40 + 1, 64, True)
        del v40
        v34.v0 = v41
        del v41
        v42 = closure2()
        v42(v32)
        del v42
        v43 = v35.v0
        v43(v32)
        del v32, v43
        v45 = US4_Some(v34, v35, v36, v37, v38, v39)
    del v1, v3, v21, v45
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
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 0
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method46(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 0
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v8 = closure0()
                v9 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v8(v9)
                del v9
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
                    v50 = US4_None()
                else:
                    v28 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v8(v28)
                    del v28
                    v29, v30, v31, v32, v33, v34 = TraceState.trace_state
                    v35 = method5(v29, v30, v31, v32, v33, v34)
                    v36 = method7()
                    v37 = method44(v29, v30, v31, v32, v33, v34, v35, v36, v1, v3, v7)
                    del v29, v30, v31, v32, v33, v34, v35, v36
                    v38 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v8(v38)
                    del v38
                    v39, v40, v41, v42, v43, v44 = TraceState.trace_state
                    v45 = v39.v0
                    v46 = spiral_wrap(v45 + 1, 64, True)
                    del v45
                    v39.v0 = v46
                    del v46
                    v47 = closure2()
                    v47(v37)
                    del v47
                    v48 = v40.v0
                    v48(v37)
                    del v37, v48
                    v50 = US4_Some(v39, v40, v41, v42, v43, v44)
                del v3, v8, v26, v50
                v51 = spiral_wrap(v1 + v7, 64, True)
                del v1, v7
                return method42(v4, v51)
            else:
                del v5
                v53 = closure0()
                v54 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v53(v54)
                del v54
                v55, v56, v57, v58, v59, v60 = TraceState.trace_state
                del v55, v56, v58, v60
                v61 = v59.v0
                del v59
                match v61:
                    case US0_Critical(): # Critical
                        v66 = 50
                    case US0_Debug(): # Debug
                        v66 = 20
                    case US0_Info(): # Info
                        v66 = 30
                    case US0_Verbose(): # Verbose
                        v66 = 10
                    case US0_Warning(): # Warning
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
                    v95 = US4_None()
                else:
                    v73 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v53(v73)
                    del v73
                    v74, v75, v76, v77, v78, v79 = TraceState.trace_state
                    v80 = method5(v74, v75, v76, v77, v78, v79)
                    v81 = method7()
                    v82 = method46(v74, v75, v76, v77, v78, v79, v80, v81, v1, v3)
                    del v74, v75, v76, v77, v78, v79, v80, v81
                    v83 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v53(v83)
                    del v83
                    v84, v85, v86, v87, v88, v89 = TraceState.trace_state
                    v90 = v84.v0
                    v91 = spiral_wrap(v90 + 1, 64, True)
                    del v90
                    v84.v0 = v91
                    del v91
                    v92 = closure2()
                    v92(v82)
                    del v92
                    v93 = v85.v0
                    v93(v82)
                    del v82, v93
                    v95 = US4_Some(v84, v85, v86, v87, v88, v89)
                del v3, v53, v71, v95
                return method42(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method47(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 1
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method48(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 1
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method47(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method41(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method48(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method41(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method49(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 2
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method50(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 2
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method49(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method40(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method50(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method40(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method51(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 3
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method52(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 3
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method51(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method39(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method52(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method39(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method53(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 4
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method54(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 4
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method53(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method38(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method54(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method38(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method55(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 5
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method56(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 5
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method55(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method37(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method56(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method37(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method57(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 6
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method58(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 6
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method57(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method36(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method58(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method36(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method59(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 7
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method60(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 7
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method59(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method35(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method60(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method35(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method61(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 8
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method62(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 8
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method61(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method34(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method62(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method34(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method63(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 9
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method64(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 9
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method63(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method33(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method64(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method33(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method65(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 10
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method66(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 10
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method65(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method32(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method66(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method32(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method67(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 11
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method68(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 11
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method67(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method31(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method68(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method31(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method69(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 12
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method70(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 12
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method69(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method30(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method70(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method30(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method71(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 13
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method72(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 13
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method71(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method29(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method72(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method29(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method73(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 14
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method74(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 14
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method73(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method28(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method74(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method28(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method75(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 15
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method76(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 15
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method75(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method27(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method76(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method27(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method77(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 16
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method78(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 16
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method77(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method26(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method78(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method26(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method79(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 17
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method80(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 17
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method79(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method25(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method80(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method25(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method81(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 18
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method82(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 18
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method81(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method24(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method82(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method24(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method83(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 19
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method84(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 19
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method83(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method23(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method84(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method23(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method85(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 20
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method86(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 20
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method85(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method22(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method86(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method22(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method87(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 21
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method88(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 21
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method87(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method21(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method88(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method21(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method89(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 22
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method90(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 22
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method89(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method20(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method90(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method20(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method91(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8, v10 : i64) -> string:
    del v1, v2, v3, v4, v5
    v11 = v0.v0
    del v0
    v12 = " "
    v13 = v6 + v12 
    del v6
    v14 = format_real_14(v11)
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
    v22 = ""
    v23 = v22 + v22 
    del v22
    v24 = "power"
    v25 = v23 + v24 
    del v23, v24
    v26 = " = "
    v27 = v25 + v26 
    del v25
    v28 = 23
    v29 = format_real_15(v28)
    del v28
    v30 = v27 + v29 
    del v27, v29
    v31 = "; "
    v32 = v30 + v31 
    del v30
    v33 = "acc"
    v34 = v32 + v33 
    del v32, v33
    v35 = v34 + v26 
    del v34
    v36 = format_real_14(v8)
    del v8
    v37 = v35 + v36 
    del v35, v36
    v38 = v37 + v31 
    del v37
    v39 = "roll"
    v40 = v38 + v39 
    del v38, v39
    v41 = v40 + v26 
    del v40
    v42 = format_real_45(v9)
    del v9
    v43 = v41 + v42 
    del v41, v42
    v44 = v43 + v31 
    del v31, v43
    v45 = "value"
    v46 = v44 + v45 
    del v44, v45
    v47 = v46 + v26 
    del v26, v46
    v48 = format_real_14(v10)
    del v10
    v49 = v47 + v48 
    del v47, v48
    v50 = "{ "
    v51 = v50 + v49 
    del v49, v50
    v52 = " }"
    v53 = v51 + v52 
    del v51, v52
    v54 = v21 + v53 
    del v21, v53
    return method11(v54)
def method92(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : string, v7 : string, v8 : i64, v9 : u8) -> string:
    del v1, v2, v3, v4, v5
    v10 = v0.v0
    del v0
    v11 = " "
    v12 = v6 + v11 
    del v6
    v13 = format_real_14(v10)
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
    v21 = ""
    v22 = v21 + v21 
    del v21
    v23 = "power"
    v24 = v22 + v23 
    del v22, v23
    v25 = " = "
    v26 = v24 + v25 
    del v24
    v27 = 23
    v28 = format_real_15(v27)
    del v27
    v29 = v26 + v28 
    del v26, v28
    v30 = "; "
    v31 = v29 + v30 
    del v29
    v32 = "acc"
    v33 = v31 + v32 
    del v31, v32
    v34 = v33 + v25 
    del v33
    v35 = format_real_14(v8)
    del v8
    v36 = v34 + v35 
    del v34, v35
    v37 = v36 + v30 
    del v30, v36
    v38 = "roll"
    v39 = v37 + v38 
    del v37, v38
    v40 = v39 + v25 
    del v25, v39
    v41 = format_real_45(v9)
    del v9
    v42 = v40 + v41 
    del v40, v41
    v43 = "{ "
    v44 = v43 + v42 
    del v42, v43
    v45 = " }"
    v46 = v44 + v45 
    del v44, v45
    v47 = v20 + v46 
    del v20, v46
    return method11(v47)
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
                v9 = closure0()
                v10 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v9(v10)
                del v10
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
                    v51 = US4_None()
                else:
                    v29 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v29)
                    del v29
                    v30, v31, v32, v33, v34, v35 = TraceState.trace_state
                    v36 = method5(v30, v31, v32, v33, v34, v35)
                    v37 = method7()
                    v38 = method91(v30, v31, v32, v33, v34, v35, v36, v37, v1, v3, v8)
                    del v30, v31, v32, v33, v34, v35, v36, v37
                    v39 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v9(v39)
                    del v39
                    v40, v41, v42, v43, v44, v45 = TraceState.trace_state
                    v46 = v40.v0
                    v47 = spiral_wrap(v46 + 1, 64, True)
                    del v46
                    v40.v0 = v47
                    del v47
                    v48 = closure2()
                    v48(v38)
                    del v48
                    v49 = v41.v0
                    v49(v38)
                    del v38, v49
                    v51 = US4_Some(v40, v41, v42, v43, v44, v45)
                del v3, v9, v27, v51
                v52 = spiral_wrap(v1 + v8, 64, True)
                del v1, v8
                return method19(v4, v52)
            else:
                del v5
                v54 = closure0()
                v55 = US0_Verbose()
                if TraceState.trace_state is None: TraceState.trace_state = v54(v55)
                del v55
                v56, v57, v58, v59, v60, v61 = TraceState.trace_state
                del v56, v57, v59, v61
                v62 = v60.v0
                del v60
                match v62:
                    case US0_Critical(): # Critical
                        v67 = 50
                    case US0_Debug(): # Debug
                        v67 = 20
                    case US0_Info(): # Info
                        v67 = 30
                    case US0_Verbose(): # Verbose
                        v67 = 10
                    case US0_Warning(): # Warning
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
                    v96 = US4_None()
                else:
                    v74 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v74)
                    del v74
                    v75, v76, v77, v78, v79, v80 = TraceState.trace_state
                    v81 = method5(v75, v76, v77, v78, v79, v80)
                    v82 = method7()
                    v83 = method92(v75, v76, v77, v78, v79, v80, v81, v82, v1, v3)
                    del v75, v76, v77, v78, v79, v80, v81, v82
                    v84 = US0_Verbose()
                    if TraceState.trace_state is None: TraceState.trace_state = v54(v84)
                    del v84
                    v85, v86, v87, v88, v89, v90 = TraceState.trace_state
                    v91 = v85.v0
                    v92 = spiral_wrap(v91 + 1, 64, True)
                    del v91
                    v85.v0 = v92
                    del v92
                    v93 = closure2()
                    v93(v83)
                    del v93
                    v94 = v86.v0
                    v94(v83)
                    del v83, v94
                    v96 = US4_Some(v85, v86, v87, v88, v89, v90)
                del v3, v54, v72, v96
                return method19(v4, v1)
        case UH0_Nil(): # Nil
            del v0, v1
            return US5_None()
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
                        v35 = UH0_Nil()
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
                    v85 = UH0_Nil()
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
    v10 = " "
    v11 = v6 + v10 
    del v6
    v12 = format_real_14(v9)
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
    v20 = ""
    v21 = v20 + v20 
    del v20
    v22 = "result"
    v23 = v21 + v22 
    del v21, v22
    v24 = " = "
    v25 = v23 + v24 
    del v23, v24
    v26 = format_real_14(v8)
    del v8
    v27 = v25 + v26 
    del v25, v26
    v28 = "{ "
    v29 = v28 + v27 
    del v27, v28
    v30 = " }"
    v31 = v29 + v30 
    del v29, v30
    v32 = v19 + v31 
    del v19, v31
    return method11(v32)
def main():
    v0 = "Python"
    None # backend.backend_switch / record_type_try_find / key: v0 
    None # backend.backend_switch / record_type_try_find / key: v0 
    None # backend.backend_switch / record_type_try_find / key: v0 
    None # backend.backend_switch / record_type_try_find / key: v0 
    del v0
    v1 = spiral_object_array()
    del v1
    v2 = closure0()
    v3 = US0_Verbose()
    if TraceState.trace_state is None: TraceState.trace_state = v2(v3)
    del v3
    v4, v5, v6, v7, v8, v9 = TraceState.trace_state
    del v4, v5, v7, v9
    v10 = v8.v0
    del v8
    match v10:
        case US0_Critical(): # Critical
            v15 = 50
        case US0_Debug(): # Debug
            v15 = 20
        case US0_Info(): # Info
            v15 = 30
        case US0_Verbose(): # Verbose
            v15 = 10
        case US0_Warning(): # Warning
            v15 = 40
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v10
    v16 = v6.v0
    del v6
    v17 = v16 == False
    del v16
    if v17:
        v19 = False
    else:
        v18 = 20 >= v15
        v19 = v18
    del v15, v17
    v20 = v19 == False
    del v19
    if v20:
        v44 = US4_None()
    else:
        v22 = US0_Verbose()
        if TraceState.trace_state is None: TraceState.trace_state = v2(v22)
        del v22
        v23, v24, v25, v26, v27, v28 = TraceState.trace_state
        v29 = method5(v23, v24, v25, v26, v27, v28)
        v30 = method7()
        v31 = method10(v23, v24, v25, v26, v27, v28, v29, v30)
        del v23, v24, v25, v26, v27, v28, v29, v30
        v32 = US0_Verbose()
        if TraceState.trace_state is None: TraceState.trace_state = v2(v32)
        del v32
        v33, v34, v35, v36, v37, v38 = TraceState.trace_state
        v39 = v33.v0
        v40 = spiral_wrap(v39 + 1, 64, True)
        del v39
        v33.v0 = v40
        del v40
        v41 = closure2()
        v41(v31)
        del v41
        v42 = v34.v0
        v42(v31)
        del v31, v42
        v44 = US4_Some(v33, v34, v35, v36, v37, v38)
    del v20, v44
    v45 = UH0_Nil()
    v46 = 0
    v47 = method16(v45, v46)
    del v45, v46
    v48 = US0_Verbose()
    if TraceState.trace_state is None: TraceState.trace_state = v2(v48)
    del v48
    v49, v50, v51, v52, v53, v54 = TraceState.trace_state
    del v49, v50, v52, v54
    v55 = v53.v0
    del v53
    match v55:
        case US0_Critical(): # Critical
            v60 = 50
        case US0_Debug(): # Debug
            v60 = 20
        case US0_Info(): # Info
            v60 = 30
        case US0_Verbose(): # Verbose
            v60 = 10
        case US0_Warning(): # Warning
            v60 = 40
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v55
    v61 = v51.v0
    del v51
    v62 = v61 == False
    del v61
    if v62:
        v64 = False
    else:
        v63 = 20 >= v60
        v64 = v63
    del v60, v62
    v65 = v64 == False
    del v64
    if v65:
        v89 = US4_None()
    else:
        v67 = US0_Verbose()
        if TraceState.trace_state is None: TraceState.trace_state = v2(v67)
        del v67
        v68, v69, v70, v71, v72, v73 = TraceState.trace_state
        v74 = method5(v68, v69, v70, v71, v72, v73)
        v75 = method7()
        v76 = method93(v68, v69, v70, v71, v72, v73, v74, v75, v47)
        del v68, v69, v70, v71, v72, v73, v74, v75
        v77 = US0_Verbose()
        if TraceState.trace_state is None: TraceState.trace_state = v2(v77)
        del v77
        v78, v79, v80, v81, v82, v83 = TraceState.trace_state
        v84 = v78.v0
        v85 = spiral_wrap(v84 + 1, 64, True)
        del v84
        v78.v0 = v85
        del v85
        v86 = closure2()
        v86(v76)
        del v86
        v87 = v79.v0
        v87(v76)
        del v76, v87
        v89 = US4_Some(v78, v79, v80, v81, v82, v83)
    del v2, v47, v65, v89
    return 

if __name__ == '__main__': main()
