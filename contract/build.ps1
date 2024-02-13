param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1


{ cargo build --release --target wasm32-unknown-unknown --features wasm } | Invoke-Block
New-Item dist -ItemType Directory -Force | Out-Null
Copy-Item ../target/wasm32-unknown-unknown/release/dice_contract.wasm dist/dice.wasm -Force

if (!$fast) {
    { ../target/release/dice_contract_tests } | Invoke-Block -Linux -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100 }
}
