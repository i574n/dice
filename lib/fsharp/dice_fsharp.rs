#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
#![allow(unused_assignments)]
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_fc267fc3 {
    pub mod Dice {
        use super::*;
        pub mod DiceFSharp {
            use super::*;
            use crate::Polyglot::Common::TraceLevel;
            use crate::Polyglot::Common::trace;
            use fable_library_rust::List_::List;
            use fable_library_rust::List_::cons;
            use fable_library_rust::List_::empty;
            use fable_library_rust::List_::head;
            use fable_library_rust::List_::initialize;
            use fable_library_rust::List_::isEmpty;
            use fable_library_rust::List_::length;
            use fable_library_rust::List_::tail;
            use fable_library_rust::List_::tryItem;
            use fable_library_rust::Native_::Func0;
            use fable_library_rust::Native_::Func1;
            use fable_library_rust::Native_::Func2;
            use fable_library_rust::Native_::LrcPtr;
            use fable_library_rust::Native_::MutCell;
            use fable_library_rust::Native_::getZero;
            use fable_library_rust::NativeArray_::Array;
            use fable_library_rust::Option_::iterate;
            use fable_library_rust::Seq_::cache;
            use fable_library_rust::Seq_::item as item_1;
            use fable_library_rust::Seq_::map;
            use fable_library_rust::Seq_::unfold;
            use fable_library_rust::String_::printfn;
            use fable_library_rust::String_::sprintf;
            use fable_library_rust::String_::string;
            use fable_library_rust::System::Collections::Generic::IEnumerable_1;
            ///
            /// ## sixthPowerSequence
            pub fn sixthPowerSequence() -> LrcPtr<dyn IEnumerable_1<i32>> {
                cache(unfold(
                    Func1::new(move |state: i32| Some(LrcPtr::new((state, (state) * 6_i32)))),
                    1_i32,
                ))
            }
            ///
            /// ## accumulateDiceRolls
            pub fn accumulateDiceRolls(
                log: Option<Func1<string, ()>>,
                rolls: List<i32>,
                power: i32,
                acc: i32,
            ) -> Option<LrcPtr<(i32, List<i32>)>> {
                let log = MutCell::new(log.clone());
                let rolls: MutCell<List<i32>> = MutCell::new(rolls.clone());
                let power: MutCell<i32> = MutCell::new(power);
                let acc: MutCell<i32> = MutCell::new(acc);
                '_accumulateDiceRolls: loop {
                    break '_accumulateDiceRolls (if (power.get().clone()) < 0_i32 {
                        iterate(
                            {
                                let arg: string = sprintf!(
                                    "accumulateDiceRolls / power: {} / acc: {}",
                                    power.get().clone(),
                                    acc.get().clone()
                                );
                                Func1::new({
                                    let arg = arg.clone();
                                    move |func: Func1<string, ()>| func(arg.clone())
                                })
                            },
                            log.get().clone(),
                        );
                        Some(LrcPtr::new((
                            (acc.get().clone()) + 1_i32,
                            rolls.get().clone(),
                        )))
                    } else {
                        if !isEmpty(rolls.get().clone()) {
                            if (head(rolls.get().clone())) > 1_i32 {
                                let rest_1: List<i32> = tail(rolls.get().clone());
                                let roll_1: i32 = head(rolls.get().clone());
                                let value: i32 = ((roll_1) - 1_i32)
                                    * (item_1(
                                        power.get().clone(),
                                        Dice::DiceFSharp::sixthPowerSequence(),
                                    ));
                                iterate(
                                    {
                                        let arg_1: string = sprintf!(
                                            "accumulateDiceRolls / power: {} / acc: {} / roll: {} / value: {}",
                                            power.get().clone(),
                                            acc.get().clone(),
                                            roll_1,
                                            value
                                        );
                                        Func1::new({
                                            let arg_1 = arg_1.clone();
                                            move |func_1: Func1<string, ()>| func_1(arg_1.clone())
                                        })
                                    },
                                    log.get().clone(),
                                );
                                {
                                    let log_temp = log.get().clone();
                                    let rolls_temp: List<i32> = rest_1.clone();
                                    let power_temp: i32 = (power.get().clone()) - 1_i32;
                                    let acc_temp: i32 = (acc.get().clone()) + (value);
                                    log.set(log_temp);
                                    rolls.set(rolls_temp);
                                    power.set(power_temp);
                                    acc.set(acc_temp);
                                    continue '_accumulateDiceRolls;
                                }
                            } else {
                                let rest_2: List<i32> = tail(rolls.get().clone());
                                let roll_2: i32 = head(rolls.get().clone());
                                iterate(
                                    {
                                        let arg_2: string = sprintf!(
                                            "accumulateDiceRolls / power: {} / acc: {} / roll: {}",
                                            power.get().clone(),
                                            acc.get().clone(),
                                            roll_2
                                        );
                                        Func1::new({
                                            let arg_2 = arg_2.clone();
                                            move |func_2: Func1<string, ()>| func_2(arg_2.clone())
                                        })
                                    },
                                    log.get().clone(),
                                );
                                {
                                    let log_temp = log.get().clone();
                                    let rolls_temp: List<i32> = rest_2.clone();
                                    let power_temp: i32 = (power.get().clone()) - 1_i32;
                                    let acc_temp: i32 = acc.get().clone();
                                    log.set(log_temp);
                                    rolls.set(rolls_temp);
                                    power.set(power_temp);
                                    acc.set(acc_temp);
                                    continue '_accumulateDiceRolls;
                                }
                            }
                        } else {
                            None::<LrcPtr<(i32, List<i32>)>>
                        }
                    });
                }
            }
            ///
            /// ## rollWithinBounds
            pub fn rollWithinBounds(
                log: Option<Func1<string, ()>>,
                max: i32,
                rolls: List<i32>,
            ) -> Option<i32> {
                let matchValue: Option<LrcPtr<(i32, List<i32>)>> =
                    Dice::DiceFSharp::accumulateDiceRolls(
                        log,
                        rolls.clone(),
                        (length(rolls)) - 1_i32,
                        0_i32,
                    );
                if matchValue.is_some() && {
                    let result: i32 = (matchValue.clone().unwrap()).0.clone();
                    if (result) >= 1_i32 {
                        (result) <= (max)
                    } else {
                        false
                    }
                } {
                    let result_1: i32 = (matchValue.clone().unwrap()).0.clone();
                    Some(result_1)
                } else {
                    None::<i32>
                }
            }
            ///
            /// ## rollDice
            pub fn rollDice() -> i32 {
                rand::Rng::gen_range(&mut rand::thread_rng(), 1..7)
            }
            ///
            /// ## rotateNumber
            pub fn rotateNumber(max: i32, n: i32) -> i32 {
                ((((n) - 1_i32) + (max)) % (max)) + 1_i32
            }
            ///
            /// ## rotateNumbers
            pub fn rotateNumbers(
                max: i32,
                items: LrcPtr<dyn IEnumerable_1<i32>>,
            ) -> LrcPtr<dyn IEnumerable_1<i32>> {
                map(
                    Func1::new({
                        let max = max.clone();
                        move |n: i32| Dice::DiceFSharp::rotateNumber(max, n)
                    }),
                    items,
                )
            }
            ///
            /// ## createSequentialRoller
            pub fn createSequentialRoller<a: Clone + 'static>(list: List<a>) -> Func0<a> {
                let currentIndex: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(0_i32));
                Func0::new({
                    let currentIndex = currentIndex.clone();
                    let list = list.clone();
                    move || {
                        let matchValue: Option<a> =
                            tryItem(currentIndex.get().clone(), list.clone());
                        match &matchValue {
                            None => panic!("{}", string("createSequentialRoller / End of list"),),
                            Some(matchValue_0_0) => {
                                let item: a = matchValue_0_0.clone();
                                currentIndex.set((currentIndex.get().clone()) + 1_i32);
                                item
                            }
                        }
                    }
                })
            }
            ///
            /// ## rollProgressively
            pub fn rollProgressively(
                log: Option<Func1<string, ()>>,
                roll: Func0<i32>,
                reroll: bool,
                max: i32,
            ) -> i32 {
                let power: i32 = ({
                    let max_1: i32 = max;
                    let 루프 = Func2::new({
                        let log = log.clone();
                        let max_1 = max_1.clone();
                        move |n: i32, p: i32| {
                            let n: MutCell<i32> = MutCell::new(n);
                            let p: MutCell<i32> = MutCell::new(p);
                            '_루프: loop {
                                break '_루프 (if (p.get().clone()) < (max_1) {
                                    let n_temp: i32 = (n.get().clone()) + 1_i32;
                                    let p_temp: i32 = (p.get().clone()) * 6_i32;
                                    n.set(n_temp);
                                    p.set(p_temp);
                                    continue '_루프;
                                } else {
                                    iterate(
                                        {
                                            let arg: string = sprintf!(
                                                "calculateDiceCount / max: {} / n: {} / p: {}",
                                                max_1,
                                                n.get().clone(),
                                                p.get().clone()
                                            );
                                            Func1::new({
                                                let arg = arg.clone();
                                                move |func: Func1<string, ()>| func(arg.clone())
                                            })
                                        },
                                        log.clone(),
                                    );
                                    n.get().clone()
                                });
                            }
                        }
                    });
                    if (max_1) == 1_i32 {
                        1_i32
                    } else {
                        루프(0_i32, 1_i32)
                    }
                }) - 1_i32;
                let 루프_1 = Func2::new({
                    let log = log.clone();
                    let max = max.clone();
                    let power = power.clone();
                    let reroll = reroll.clone();
                    let roll = roll.clone();
                    move |rolls: List<i32>, size: i32| {
                        let rolls: MutCell<List<i32>> = MutCell::new(rolls.clone());
                        let size: MutCell<i32> = MutCell::new(size);
                        '_루프_1: loop {
                            break '_루프_1 (if (size.get().clone()) < ((power) + 1_i32) {
                                let rolls_temp: List<i32> = cons(roll(), rolls.get().clone());
                                let size_temp: i32 = (size.get().clone()) + 1_i32;
                                rolls.set(rolls_temp);
                                size.set(size_temp);
                                continue '_루프_1;
                            } else {
                                let matchValue: Option<LrcPtr<(i32, List<i32>)>> =
                                    Dice::DiceFSharp::accumulateDiceRolls(
                                        log.clone(),
                                        rolls.get().clone(),
                                        power,
                                        0_i32,
                                    );
                                {
                                    let mut matchResult: i32 = getZero::<i32>();
                                    let mut result_1: i32 = getZero::<i32>();
                                    if matchValue.is_some() {
                                        if ((matchValue.clone().unwrap()).0.clone()) <= (max) {
                                            matchResult = 0_i32;
                                            result_1 = (matchValue.clone().unwrap()).0.clone();
                                        } else {
                                            if reroll {
                                                matchResult = 1_i32;
                                            } else {
                                                matchResult = 2_i32;
                                            }
                                        }
                                    } else {
                                        if reroll {
                                            matchResult = 1_i32;
                                        } else {
                                            matchResult = 2_i32;
                                        }
                                    };
                                    match &matchResult {
                                        0_i32 => result_1.clone(),
                                        1_i32 => {
                                            let rolls_temp: List<i32> = initialize(
                                                power,
                                                Func1::new({
                                                    let roll = roll.clone();
                                                    move |_arg: i32| roll()
                                                }),
                                            );
                                            let size_temp: i32 = power;
                                            rolls.set(rolls_temp);
                                            size.set(size_temp);
                                            continue '_루프_1;
                                        }
                                        2_i32 => {
                                            let rolls_temp: List<i32> =
                                                cons(roll(), rolls.get().clone());
                                            let size_temp: i32 = (size.get().clone()) + 1_i32;
                                            rolls.set(rolls_temp);
                                            size.set(size_temp);
                                            continue '_루프_1;
                                        }
                                        _ => unreachable!(),
                                    }
                                }
                            });
                        }
                    }
                });
                루프_1(empty::<i32>(), 0_i32)
            }
            ///
            /// ## main
            pub fn main(args: Array<string>) -> i32 {
                let result: i32 = Dice::DiceFSharp::rollProgressively(
                    Some({
                        fn clo(a0: string) {
                            printfn!("{}", a0);
                        }
                        Func1::new({
                            let clo = clo.clone();
                            move |arg: string| clo(arg)
                        })
                    }),
                    Func0::new(move || Dice::DiceFSharp::rollDice()),
                    true,
                    i32::MAX / 10_i32,
                );
                trace(
                    LrcPtr::new(TraceLevel::Debug),
                    Func0::new({
                        let result = result.clone();
                        move || sprintf!("main / result: {}", result)
                    }),
                    Func0::new(move || string("")),
                );
                0_i32
            }
        }
    }
}
pub use module_fc267fc3::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/async_.rs"]
mod module_763b9e6c;
pub use module_763b9e6c::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/common.rs"]
mod module_18f1c018;
pub use module_18f1c018::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/crypto.rs"]
mod module_c0301e36;
pub use module_c0301e36::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/date_time.rs"]
mod module_e5abed0b;
pub use module_e5abed0b::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/file_system.rs"]
mod module_336d1dc9;
pub use module_336d1dc9::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/lib.rs"]
mod module_12dde172;
pub use module_12dde172::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/networking.rs"]
mod module_7e35832b;
pub use module_7e35832b::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/platform.rs"]
mod module_afd02cca;
pub use module_afd02cca::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/runtime.rs"]
mod module_a3c64389;
pub use module_a3c64389::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/sm.rs"]
mod module_8f227ecb;
pub use module_8f227ecb::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/threading.rs"]
mod module_e08c16fb;
pub use module_e08c16fb::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/trace.rs"]
mod module_702ddcb4;
pub use module_702ddcb4::*;
#[path = "../../deps/polyglot/lib/fsharp/Common.rs"]
mod module_eb7e4788;
pub use module_eb7e4788::*;
pub mod Dice {
    pub use crate::module_fc267fc3::Dice::*;
}
pub mod Polyglot {
    pub use crate::module_eb7e4788::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Dice::DiceFSharp::main(array_from(args));
}
