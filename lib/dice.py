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
import random
def spiral_try(fn, some, ex_fn):
    try:
        return some(fn())
    except Exception as e:
        return ex_fn(e)
import os
import datetime
class TraceState: trace_state = None
import math
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
def spiral_div_trunc(a, b):
    q = abs(a) // abs(b)
    return q if (a < 0) == (b < 0) else -q
def spiral_mod_trunc(a, b):
    r = abs(a) % abs(b)
    return -r if a < 0 else r
class US0_One(NamedTuple): # One
    tag = 0
US0_One_shared = US0_One()
class US0_Two(NamedTuple): # Two
    tag = 1
US0_Two_shared = US0_Two()
class US0_Three(NamedTuple): # Three
    tag = 2
US0_Three_shared = US0_Three()
class US0_Four(NamedTuple): # Four
    tag = 3
US0_Four_shared = US0_Four()
class US0_Five(NamedTuple): # Five
    tag = 4
US0_Five_shared = US0_Five()
class US0_Six(NamedTuple): # Six
    tag = 5
US0_Six_shared = US0_Six()
US0 = Union[US0_One, US0_Two, US0_Three, US0_Four, US0_Five, US0_Six]
class US1_Verbose(NamedTuple): # Verbose
    tag = 0
US1_Verbose_shared = US1_Verbose()
class US1_Debug(NamedTuple): # Debug
    tag = 1
US1_Debug_shared = US1_Debug()
class US1_Info(NamedTuple): # Info
    tag = 2
US1_Info_shared = US1_Info()
class US1_Warning(NamedTuple): # Warning
    tag = 3
US1_Warning_shared = US1_Warning()
class US1_Critical(NamedTuple): # Critical
    tag = 4
US1_Critical_shared = US1_Critical()
US1 = Union[US1_Verbose, US1_Debug, US1_Info, US1_Warning, US1_Critical]
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
    v0 : US1
class US2_Some(NamedTuple): # Some
    v0 : US1
    tag = 0
class US2_None(NamedTuple): # None
    tag = 1
US2_None_shared = US2_None()
US2 = Union[US2_Some, US2_None]
class US3_Some(NamedTuple): # Some
    v0 : i64
    tag = 0
class US3_None(NamedTuple): # None
    tag = 1
US3_None_shared = US3_None()
US3 = Union[US3_Some, US3_None]
class US4_Some(NamedTuple): # Some
    v0 : string
    tag = 0
class US4_None(NamedTuple): # None
    tag = 1
US4_None_shared = US4_None()
US4 = Union[US4_Some, US4_None]
@dataclass
class Mut5:
    v0 : i32
    v1 : US2
def closure0():
    def inner(v0 : string) -> None:
        return 
    return inner
class US5_Some(NamedTuple): # Some
    v0 : Mut0
    v1 : Mut1
    v2 : Mut2
    v3 : Mut3
    v4 : Mut4
    v5 : i64
    tag = 0
class US5_None(NamedTuple): # None
    tag = 1
US5_None_shared = US5_None()
US5 = Union[US5_Some, US5_None]
def closure1():
    def inner(v0 : string) -> None:
        print(v0)
        return 
    return inner
def go_0(v0 : i32, v1 : i64) -> i32:
    while True:
        v2 = v1 >= 4738381338321616896
        if v2:
            del v1, v2
            return v0
        else:
            del v2
            v3 = spiral_wrap(v0 + 1, 32, True)
            del v0
            v4 = spiral_wrap(v1 * 6, 64, True)
            del v1
            v0, v1 = v3, v4
            continue
def read_2(v0 : i32, v1 : i64, v2 : i64) -> i64:
    while True:
        v3 = v0 <= 0
        if v3:
            del v0, v1, v3
            return v2
        else:
            del v3
            v4 = random.randrange(0, 6)
            v5 = 0 == v4
            if v5:
                v20 = US0_One_shared
            else:
                v7 = 1 == v4
                if v7:
                    del v7
                    v20 = US0_Two_shared
                else:
                    del v7
                    v9 = 2 == v4
                    if v9:
                        del v9
                        v20 = US0_Three_shared
                    else:
                        del v9
                        v11 = 3 == v4
                        if v11:
                            del v11
                            v20 = US0_Four_shared
                        else:
                            del v11
                            v13 = 4 == v4
                            if v13:
                                del v13
                                v20 = US0_Five_shared
                            else:
                                del v13
                                v20 = US0_Six_shared
            del v4, v5
            v21 = spiral_wrap(v0 - 1, 32, True)
            del v0
            v22 = spiral_wrap(v1 * 6, 64, True)
            v23 = v20.tag
            del v20
            v24 = spiral_wrap(int(v23), 64, True)
            del v23
            v25 = spiral_wrap(v24 * v1, 64, True)
            del v1, v24
            v26 = spiral_wrap(v2 + v25, 64, True)
            del v2, v25
            v0, v1, v2 = v21, v22, v26
            continue
def roll_fresh_1(v0 : i64, v1 : i32) -> i64:
    while True:
        v2 = 1
        v3 = 0
        v4 = read_2(v1, v2, v3)
        del v2, v3
        v5 = v4 < v0
        if v5:
            del v0, v1, v5
            v6 = spiral_wrap(v4 + 1, 64, True)
            del v4
            return v6
        else:
            del v4, v5
            v0, v1 = v0, v1
            continue
def get_environment_variable_5(v0 : string) -> string:
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
        v8 = US4_Some(v7)
        del v7
        v9 = v8 
        del v8
        v10 = v9
    del v3, v5
    v11 = v10 is None
    if v11:
        v14 = US4_None_shared
    else:
        v13 = v10
        v14 = v13
    del v10, v11
    match v14:
        case US4_None(): # None
            del v14
            v16 = ""
            return v16
        case US4_Some(v15): # Some
            del v14
            return v15
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method6(v0 : 'list', v1 : i32, v2 : cp.ndarray, v3 : i32) -> cp.ndarray:
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
def method7(v0 : Mut5) -> bool:
    v1 = v0.v0
    del v0
    v2 = v1 > 0
    del v1
    return v2
def method4() -> Tuple[US2, US3]:
    v0 = "TRACE_LEVEL"
    v1 = get_environment_variable_5(v0)
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
    v13 = US1_Critical_shared
    v14 = ([(v3, v13)] + v12)
    del v3, v12, v13
    v15 = US1_Warning_shared
    v16 = ([(v5, v15)] + v14)
    del v5, v14, v15
    v17 = US1_Info_shared
    v18 = ([(v7, v17)] + v16)
    del v7, v16, v17
    v19 = US1_Debug_shared
    v20 = ([(v9, v19)] + v18)
    del v9, v18, v19
    v21 = US1_Verbose_shared
    v22 = ([(v11, v21)] + v20)
    del v11, v20, v21
    v23 = US1_Critical_shared
    v24 = ([(v2, v23)] + v22)
    del v2, v22, v23
    v25 = US1_Warning_shared
    v26 = ([(v4, v25)] + v24)
    del v4, v24, v25
    v27 = US1_Info_shared
    v28 = ([(v6, v27)] + v26)
    del v6, v26, v27
    v29 = US1_Debug_shared
    v30 = ([(v8, v29)] + v28)
    del v8, v28, v29
    v31 = US1_Verbose_shared
    v32 = ([(v10, v31)] + v30)
    del v10, v30, v31
    v33 = len(v32)
    v34 = __import__("numpy").empty(v33, dtype=object)
    v35 = 0
    v36 = method6(v32, v33, v34, v35)
    del v32, v33, v34, v35
    v37 = v36.size
    v38 = US2_None_shared
    v39 = Mut5(v37, v38)
    del v37, v38
    while method7(v39):
        v41 = v39.v0
        v42 = spiral_wrap(v41 - 1, 32, True)
        del v41
        v43 = v39.v1
        v44, v45 = spiral_array_index(v36, v42)
        match v43:
            case US2_None(): # None
                v47 = v44 == v1 
                if v47:
                    del v47
                    v52 = US2_Some(v45)
                else:
                    del v47
                    v52 = US2_None_shared
            case US2_Some(_): # Some
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
    v55 = get_environment_variable_5(v54)
    del v54
    v56 = "True"
    v57 = v55 != v56 
    del v55, v56
    if v57:
        v62 = US3_None_shared
    else:
        v59 = datetime.datetime.now()
        v60 = (v59.replace(tzinfo=None) - datetime.datetime(1970, 1, 1)) // datetime.timedelta(microseconds=1)
        del v59
        v62 = US3_Some(v60)
    del v57
    return v53, v62
def new_trace_state_3(v0 : US1) -> Tuple[Mut0, Mut1, Mut2, Mut3, Mut4, i64]:
    v1, v2 = method4()
    v3 = Mut0(1)
    v4 = closure0()
    v5 = Mut1(v4)
    del v4
    v6 = Mut2(True)
    v7 = ""
    v8 = Mut3(v7)
    del v7
    match v1:
        case US2_None(): # None
            v11 = v0
        case US2_Some(v9): # Some
            v11 = v9
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v0, v1
    v12 = Mut4(v11)
    del v11
    match v2:
        case US3_None(): # None
            v15 = None
            v17 = v15
        case US3_Some(v13): # Some
            v14 = v13 # some' 
            del v13
            v17 = v14
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v2
    return v3, v5, v6, v8, v12, v17
def method10(v0 : string, v1 : i32, v2 : i32) -> i32:
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
def method11(v0 : string, v1 : i32) -> i32:
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
def method9(v0 : string) -> string:
    v1 = spiral_string_length(v0)
    v2 = 0
    v3 = method10(v0, v1, v2)
    del v2
    v4 = spiral_wrap(v1 - 1, 32, True)
    del v1
    v5 = spiral_string_slice(v0, v3, v4)
    del v0, v3, v4
    v6 = spiral_string_length(v5)
    v7 = method11(v5, v6)
    del v6
    v8 = spiral_string_slice(v5, 0, v7)
    del v5, v7
    return v8
def method13(v0 : 'datetime.datetime') -> 'datetime.datetime':
    return v0
def time_12(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64) -> string:
    del v0, v1, v2, v3, v4
    v6 = None
    v7 = v5 == v6 
    del v6
    if v7:
        v8 = None
        v12 = v8
    else:
        v9 = v5 
        v10 = US3_Some(v9)
        del v9
        v11 = v10 
        del v10
        v12 = v11
    del v5, v7
    v13 = v12 is None
    if v13:
        v16 = US3_None_shared
    else:
        v15 = v12
        v16 = v15
    del v12, v13
    match v16:
        case US3_None(): # None
            v32 = datetime.datetime.now()
            v34 = v32
        case US3_Some(v17): # Some
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
    v35 = method13(v34)
    del v34
    v36 = "%H:%M:%S"
    v37 = v35.strftime(v36)
    del v35, v36
    return v37
def method15(v0 : Mut3, v1 : string) -> None:
    v2 = v0.v0
    v3 = v2 + v1
    del v1, v2
    v0.v0 = v3
    del v0, v3
    return 
def format_real_14(v0 : i64) -> string:
    v1 = ""
    v2 = Mut3(v1)
    del v1
    v3 = f"{v0}"
    del v0
    method15(v2, v3)
    del v3
    v4 = v2.v0
    del v2
    return v4
def level_str_16() -> string:
    v0 = "\u001b[94m"
    v1 = v0 + "d"
    del v0
    v2 = "\u001b[0m"
    v3 = v1 + v2
    del v1, v2
    return v3
def method8(v0 : Mut0, v1 : Mut1, v2 : Mut2, v3 : Mut3, v4 : Mut4, v5 : i64, v6 : Mut0, v7 : Mut1, v8 : Mut2, v9 : Mut3, v10 : Mut4, v11 : i64, v12 : i64) -> string:
    del v1, v2, v3, v4, v5
    v13 = v0.v0
    del v0
    v14 = time_12(v6, v7, v8, v9, v10, v11)
    del v6, v7, v8, v9, v10, v11
    v15 = v14 + " "
    del v14
    v16 = format_real_14(v13)
    del v13
    v17 = v15 + v16
    del v15, v16
    v18 = level_str_16()
    v19 = v17 + v18
    del v17, v18
    v20 = v19 + " "
    del v19
    v21 = v20 + "dice.main"
    del v20
    v22 = v21 + " / "
    del v21
    v23 = format_real_14(v12)
    del v12
    v24 = "result = " + v23
    del v23
    v25 = "{ " + v24
    del v24
    v26 = v25 + " }"
    del v25
    v27 = v22 + v26
    del v22, v26
    return method9(v27)
def main():
    v0 = "Python"
    None # backend.backend_switch / record_type_try_find / key: v0 
    None # backend.backend_switch / record_type_try_find / key: v0 
    None # backend.backend_switch / record_type_try_find / key: v0 
    None # backend.backend_switch / record_type_try_find / key: v0 
    del v0
    v1 = spiral_object_array()
    del v1
    v2 = 0
    v3 = 1
    v4 = go_0(v2, v3)
    del v2, v3
    v5 = 4738381338321616896
    v6 = roll_fresh_1(v5, v4)
    del v4, v5
    v7 = TraceState.trace_state is None
    if v7:
        v8 = US1_Verbose_shared
        v9, v10, v11, v12, v13, v14 = new_trace_state_3(v8)
        del v8
        TraceState.trace_state = (v9, v10, v11, v12, v13, v14) 
        del v9, v10, v11, v12, v13, v14
    else:
        pass
    del v7
    v15, v16, v17, v18, v19, v20 = TraceState.trace_state
    del v15, v16, v18, v20
    v21 = v19.v0
    del v19
    match v21:
        case US1_Critical(): # Critical
            v26 = 50
        case US1_Debug(): # Debug
            v26 = 20
        case US1_Info(): # Info
            v26 = 30
        case US1_Verbose(): # Verbose
            v26 = 10
        case US1_Warning(): # Warning
            v26 = 40
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
    del v21
    v27 = v17.v0
    del v17
    v28 = v27 == False
    del v27
    if v28:
        v30 = False
    else:
        v29 = 20 >= v26
        v30 = v29
    del v26, v28
    v31 = v30 == False
    del v30
    if v31:
        v67 = US5_None_shared
    else:
        v33 = TraceState.trace_state is None
        if v33:
            v34 = US1_Verbose_shared
            v35, v36, v37, v38, v39, v40 = new_trace_state_3(v34)
            del v34
            TraceState.trace_state = (v35, v36, v37, v38, v39, v40) 
            del v35, v36, v37, v38, v39, v40
        else:
            pass
        del v33
        v41, v42, v43, v44, v45, v46 = TraceState.trace_state
        v47 = method8(v41, v42, v43, v44, v45, v46, v41, v42, v43, v44, v45, v46, v6)
        del v41, v42, v43, v44, v45, v46
        v48 = TraceState.trace_state is None
        if v48:
            v49 = US1_Verbose_shared
            v50, v51, v52, v53, v54, v55 = new_trace_state_3(v49)
            del v49
            TraceState.trace_state = (v50, v51, v52, v53, v54, v55) 
            del v50, v51, v52, v53, v54, v55
        else:
            pass
        del v48
        v56, v57, v58, v59, v60, v61 = TraceState.trace_state
        v62 = v56.v0
        v63 = spiral_wrap(v62 + 1, 64, True)
        del v62
        v56.v0 = v63
        del v63
        v64 = closure1()
        v64(v47)
        del v64
        v65 = v57.v0
        v65(v47)
        del v47, v65
        v67 = US5_Some(v56, v57, v58, v59, v60, v61)
    del v6, v31, v67
    return 

if __name__ == '__main__': main()
