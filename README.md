# dice

<https://i574n.github.io/dice>

[![깃허브 코드스페이스](https://github.com/codespaces/badge.svg)](https://github.com/codespaces/new?hide_repo_select=true&ref=main&repo=756477988)

A fair die-based random number generator, written once in Spiral and shipped as a library, a NEAR smart contract and a WASM web UI. It is the full-stack sample of the Spiral toolchain: one source of truth, several backends, and tests at every layer.

## How it rolls fairly

To draw a number in `1..max` from six-sided dice, `lib/dice.spi` rolls `k` dice, where `k` is the smallest count with `6^k >= max` (`calculate_dice_count`). It reads the rolls as a base-6 number plus one. Each roll `r` contributes `(r - 1) * 6^p` (`accumulate_dice_rolls`), so the result runs over `1..6^k`. A result above `max` is rejected and the dice are rolled again (`roll_within_bounds`, `roll_progressively`).

This is fair because the map from roll sequences to results is one-to-one. Every accepted value is reached by exactly one sequence, so every value in `1..max` is equally likely. The test `every_two_roll_sequence_maps_to_one_value_so_accepted_rolls_are_uniform` checks this exhaustively for two dice and `max = 20`: all 36 sequences are enumerated, each of 1..20 appears exactly once, and the other 16 are rejected.

## Layers

| Folder | What it is |
| --- | --- |
| `lib/` | the dice library in Spiral (`dice.spi`) |
| `contract/` | the NEAR smart contract, compiled from `dice_contract.spi` to Rust and WASM (`dist/dice.wasm`); `contract/tests` runs it in the NEAR sandbox |
| `ui/` | the rolls-history web UI, Rust compiled to WASM with trunk, with end-to-end tests in `ui/e2e` (Playwright) |

## A caveat on on-chain randomness

The contract mixes NEAR's `random_seed` with block and account data and the caller's key and proof (`generate_random_number`). On NEAR, the block producer knows `random_seed` before the block is final, so a validator could predict or bias a roll. Don't bet on it as is: for stakes, use a commit-reveal scheme or a verifiable random function.

## Getting started

```powershell
git clone https://github.com/i574n/dice.git
cd dice
pwsh scripts/workflow.ps1
```

`scripts/init.ps1` clones [spiral](https://github.com/i574n/spiral) next to this repository and runs its toolchain setup; `scripts/workflow.ps1` builds and tests every layer.

## Links

- Repository file tree: <https://i574n.github.io/dice>
- Dice library: <https://i574n.github.io/dice/lib/dice.spi.html>
- Smart contract notebook: <https://i574n.github.io/dice/contract/dice_contract.spi.html>
- Rolls history UI: <https://i574n.github.io/dice/ui/dist>

## Contributing

See [CONTRIBUTING.md](https://github.com/i574n/.github/blob/main/CONTRIBUTING.md).

## License

AGPL v3; see [LICENSE](LICENSE).
