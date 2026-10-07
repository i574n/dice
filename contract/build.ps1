param(
    $fast,
    $SkipNotebook,
    $SkipTests,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1
. ../deps/polyglot/deps/spiral/lib/spiral/lib.ps1


$projectName = "dice_contract"

$livebook = Join-Path $ScriptDir "../deps/polyglot/deps/spiral/apps/kino/spi/run_notebook.ps1"
$notebook = Join-Path $ScriptDir "$projectName.livemd"
$spi = Join-Path $ScriptDir "$projectName.spi"
# A run writes <nb>.livemd.ipynb and <nb>.livemd.html: README and gh-pages link to them.
$ipynb = Join-Path $ScriptDir "$projectName.livemd.ipynb"
if (!$fast -and !$SkipNotebook) {
    { pwsh -NoProfile -File $livebook --path $notebook --spi-path $spi --output-path $ipynb } | Invoke-Block -Retries $($fast -or !$env:CI ? 1 : 3)
}
else {
    { pwsh -NoProfile -File $livebook --path $notebook --spi-path $spi --export-only } | Invoke-Block
}

$targetDir = GetTargetDir $projectName

# The function names a wasm module exports (its export section), to check the contract's methods are there.
function Get-WasmExports([string] $Path) {
    $bytes = [IO.File]::ReadAllBytes($Path)
    $at = @(8) # after the magic number and version; an array, so the LEB128 reader below advances it
    $leb = { $r = 0; $shift = 0; do { $b = $bytes[$at[0]++]; $r = $r -bor (($b -band 0x7f) -shl $shift); $shift += 7 } while ($b -band 0x80); $r }
    while ($at[0] -lt $bytes.Length) {
        $id = $bytes[$at[0]++]
        $size = & $leb
        $end = $at[0] + $size
        if ($id -eq 7) {
            $count = & $leb
            for ($i = 0; $i -lt $count; $i++) {
                $length = & $leb
                $name = [Text.Encoding]::UTF8.GetString($bytes, $at[0], $length)
                $at[0] += $length
                $kind = $bytes[$at[0]++]
                $null = & $leb
                if ($kind -eq 0) { $name }
            }
        }
        $at[0] = $end
    }
}

# Rust: the dice_contract.spi entry (`main` `!!!!Export`s each contract method's Spiral body, so the program is a
# library crate, and emits the NEAR shell as `global`s: `State((u32, Vector<u8>))` with explicit borsh derives, version 2
# and the `seeds` store prefix, the `OldState` migration and the #[near_bindgen] methods) -> the cdylib crate's lib with the
# Spiral compiler's own Rust backend. lib/spiral's near arms call near_sdk on wasm32 (random_seed,
# keccak512, block and account values; the store Vector is near_sdk's). Built for wasm32 with a pinned toolchain and the
# workspace's release profile (newer rustc emits wasm features the NEAR VM rejects); the workspace's lock file pins the
# dependency versions.
# dice_contract.rs (this crate's lib, Cargo.toml next to this script, a `contract` workspace member) is that output: the
# compiler writes it next to the .spi, and the workspace's Cargo.lock pins the dependencies.
# dist/dice.wasm is the contract wasm: the NEAR sandbox tests below (or tests/build.ps1, which dice/scripts/build.ps1 runs
# after this script's -SkipTests run) deploy and call it, and the README's deploy commands use it. A failed
# compile or cargo build, or a contract method missing from the wasm's exports, fails this script.
if (!(BuildSpiral "$ScriptDir/$projectName.spi" "$ScriptDir/$projectName.rs" "dice/contract")) {
    throw "RUST-FAILED dice/contract / compile"
}
{ cargo +nightly-2024-07-14 build --release --target wasm32-unknown-unknown -p $projectName } | Invoke-Block -EnvironmentVariables @{ "AUTOMATION" = "False" }
$cargoTargetDir = (cargo +nightly-2024-07-14 metadata --format-version 1 --no-deps | ConvertFrom-Json).target_directory
$rustWasm = "$cargoTargetDir/wasm32-unknown-unknown/release/$projectName.wasm"
if (!(Test-Path $rustWasm)) { throw "RUST-FAILED dice/contract / no $rustWasm" }
$rustExports = @(Get-WasmExports $rustWasm)
$contractMethods = @('new', 'contribute_seed', 'contribute_seed_borsh', 'generate_random_number', 'roll_within_bounds', 'roll_within_bounds_borsh')
$missing = @($contractMethods | Where-Object { $_ -notin $rustExports })
if ($missing) { throw "RUST-FAILED dice/contract / the wasm doesn't export $($missing -join ', ') (exports: $($rustExports -join ', '))" }
New-Item dist -ItemType Directory -Force | Out-Null
Copy-Item $rustWasm dist/dice.wasm -Force
Write-Output "RUST-COMPILED dice/contract / dist/dice.wasm $((Get-Item dist/dice.wasm).Length) B / exports $($rustExports -join ', ')"

if (!$fast -and !$SkipTests) {
    # tests/build.ps1 builds and runs the sandbox tests (Linux; through WSL on Windows).
    { pwsh tests/build.ps1 } | Invoke-Block
    Write-Output "RUST-OK dice/contract / the NEAR sandbox tests passed on dist/dice.wasm"
}

Write-Output "dice/contract/build.ps1 / `$targetDir = $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    ClearCargoTarget "../.."
}
