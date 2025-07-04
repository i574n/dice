from __future__ import annotations
from fable_modules.fable_library.list import (is_empty, head, tail, FSharpList, length, try_item, cons, initialize, empty)
from fable_modules.fable_library.option import (to_array, value as value_1)
from fable_modules.fable_library.seq import (cache, unfold, iterate, item as item_1, map)
from fable_modules.fable_library.string_ import (to_console, printf)
from fable_modules.fable_library.types import Array
from fable_modules.fable_library.util import (IEnumerable_1, randint)
from collections.abc import Callable
import sys
from typing import (Any, TypeVar)
from lib.fsharp.common import (trace, TraceLevel)

__A = TypeVar("__A")

def sixth_power_sequence(__unit: None=None) -> IEnumerable_1[int]:
    """## sixthPowerSequence
    """
    def generator(state: int) -> tuple[int, int] | None:
        return (state, state * 6)

    return cache(unfold(generator, 1))


def accumulate_dice_rolls(log_mut: Callable[[str], None] | None, rolls_mut: FSharpList[int], power_mut: int, acc_mut: int) -> tuple[int, FSharpList[int]] | None:
    """## accumulateDiceRolls
    """
    while True:
        (log, rolls, power, acc) = (log_mut, rolls_mut, power_mut, acc_mut)
        if power < 0:
            def action(func: Callable[[str], None], log: Any=log, rolls: Any=rolls, power: Any=power, acc: Any=acc) -> None:
                func(((("accumulateDiceRolls / power: " + str(power)) + " / acc: ") + str(acc)) + "")

            iterate(action, to_array(log))
            return (acc + 1, rolls)

        elif not is_empty(rolls):
            if head(rolls) > 1:
                value: int = ((head(rolls) - 1) * item_1(power, sixth_power_sequence())) or 0
                def action_1(func_1: Callable[[str], None], log: Any=log, rolls: Any=rolls, power: Any=power, acc: Any=acc) -> None:
                    func_1(((((((("accumulateDiceRolls / power: " + str(power)) + " / acc: ") + str(acc)) + " / roll: ") + str(head(rolls))) + " / value: ") + str(value)) + "")

                iterate(action_1, to_array(log))
                log_mut = log
                rolls_mut = tail(rolls)
                power_mut = power - 1
                acc_mut = acc + value
                continue

            else: 
                def action_2(func_2: Callable[[str], None], log: Any=log, rolls: Any=rolls, power: Any=power, acc: Any=acc) -> None:
                    func_2(((((("accumulateDiceRolls / power: " + str(power)) + " / acc: ") + str(acc)) + " / roll: ") + str(head(rolls))) + "")

                iterate(action_2, to_array(log))
                log_mut = log
                rolls_mut = tail(rolls)
                power_mut = power - 1
                acc_mut = acc
                continue


        else: 
            return None

        break


def roll_within_bounds(log: Callable[[str], None] | None, max: int, rolls: FSharpList[int]) -> int | None:
    """## rollWithinBounds
    """
    match_value: tuple[int, FSharpList[int]] | None = accumulate_dice_rolls(log, rolls, length(rolls) - 1, 0)
    (pattern_matching_result, result_1) = (None, None)
    if match_value is not None:
        def _arrow216(__unit: None=None, log: Any=log, max: Any=max, rolls: Any=rolls) -> bool:
            result: int = match_value[0] or 0
            return (result <= max) if (result >= 1) else False

        if _arrow216():
            pattern_matching_result = 0
            result_1 = match_value[0]

        else: 
            pattern_matching_result = 1


    else: 
        pattern_matching_result = 1

    if pattern_matching_result == 0:
        return result_1

    elif pattern_matching_result == 1:
        return None



random: Any = {}

def roll_dice(__unit: None=None) -> int:
    return randint(1, 7)


def rotate_number(max: int, n: int) -> int:
    """## rotateNumber
    """
    return (((n - 1) + max) % max) + 1


def rotate_numbers(max: int, items: IEnumerable_1[int]) -> IEnumerable_1[int]:
    """## rotateNumbers
    """
    def mapping(n: int, max: Any=max, items: Any=items) -> int:
        return rotate_number(max, n)

    return map(mapping, items)


def create_sequential_roller(list_1: FSharpList[Any]) -> Callable[[], __A]:
    """## createSequentialRoller
    """
    current_index: int = 0
    def _arrow217(__unit: None=None, list_1: Any=list_1) -> __A:
        nonlocal current_index
        match_value: __A | None = try_item(current_index, list_1)
        if match_value is None:
            raise Exception("createSequentialRoller / End of list")

        else: 
            item: __A = value_1(match_value)
            current_index = (current_index + 1) or 0
            return item


    return _arrow217


def roll_progressively(log: Callable[[str], None] | None, roll: Callable[[], int], reroll: bool, max: int) -> int:
    """## rollProgressively
    """
    def _arrow218(__unit: None=None, log: Any=log, roll: Any=roll, reroll: Any=reroll, max: Any=max) -> int:
        max_1: int = max or 0
        def 루프(n_mut: int, p_mut: int) -> int:
            while True:
                (n, p) = (n_mut, p_mut)
                if p < max_1:
                    n_mut = n + 1
                    p_mut = p * 6
                    continue

                else: 
                    def action(func: Callable[[str], None], n: Any=n, p: Any=p) -> None:
                        func(((((("calculateDiceCount / max: " + str(max_1)) + " / n: ") + str(n)) + " / p: ") + str(p)) + "")

                    iterate(action, to_array(log))
                    return n

                break

        return 1 if (max_1 == 1) else 루프(0, 1)

    power: int = (_arrow218() - 1) or 0
    def 루프_1(rolls_mut: FSharpList[int], size_mut: int, log: Any=log, roll: Any=roll, reroll: Any=reroll, max: Any=max) -> int:
        while True:
            (rolls, size) = (rolls_mut, size_mut)
            if size < (power + 1):
                rolls_mut = cons(roll(None), rolls)
                size_mut = size + 1
                continue

            else: 
                match_value: tuple[int, FSharpList[int]] | None = accumulate_dice_rolls(log, rolls, power, 0)
                (pattern_matching_result, result_1) = (None, None)
                if match_value is not None:
                    if match_value[0] <= max:
                        pattern_matching_result = 0
                        result_1 = match_value[0]

                    elif reroll:
                        pattern_matching_result = 1

                    else: 
                        pattern_matching_result = 2


                elif reroll:
                    pattern_matching_result = 1

                else: 
                    pattern_matching_result = 2

                if pattern_matching_result == 0:
                    return result_1

                elif pattern_matching_result == 1:
                    def _arrow219(_arg: int, rolls: Any=rolls, size: Any=size) -> int:
                        return roll(None)

                    rolls_mut = initialize(power, _arrow219)
                    size_mut = power
                    continue

                elif pattern_matching_result == 2:
                    rolls_mut = cons(roll(None), rolls)
                    size_mut = size + 1
                    continue


            break

    return 루프_1(empty(), 0)


def main(args: Array[str]) -> int:
    """## main
    """
    def _arrow221(__unit: None=None, args: Any=args) -> Callable[[str], None]:
        clo: Callable[[str], None] = to_console(printf("%s"))
        def _arrow220(arg: str) -> None:
            clo(arg)

        return _arrow220

    def _arrow222(__unit: None=None, args: Any=args) -> int:
        return roll_dice()

    result: int = roll_progressively(_arrow221(), _arrow222, True, 2147483647 // 10) or 0
    def _arrow223(__unit: None=None, args: Any=args) -> str:
        return ("main / result: " + str(result)) + ""

    def _arrow224(__unit: None=None, args: Any=args) -> str:
        return ""

    trace(TraceLevel(1), _arrow223, _arrow224)
    return 0


if __name__ == "__main__":
    main(sys.argv[1:])


