param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1
. ../../polyglot/lib/spiral/lib.ps1


$projectName = "dice_contract"

if (!$fast -and !$SkipNotebook) {
    { . apps/spiral/dist/Supervisor$(_exe) --execute-command "workspace/target/release/spiral_builder$(_exe) dib --path ../dice/contract/$projectName.dib --retries $($fast -or !$env:CI ? 1 : 5)" } | Invoke-Block -Location ../../polyglot
}

{ . ../../polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

{ . ../../polyglot/apps/spiral/dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" --timeout 60000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" "CONTRACT" } | Invoke-Block

(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../lib", "../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    -replace ".rs`"]", "_contract.rs`"]" `
    | FixRust `
    | Set-Content "$projectName.rs"

cargo fmt --

{ cargo build --release --target wasm32-unknown-unknown } | Invoke-Block -EnvironmentVariables @{ "AUTOMATION" = "False" }
New-Item dist -ItemType Directory -Force | Out-Null
Copy-Item ../target/wasm32-unknown-unknown/release/dice_contract.wasm dist/dice.wasm -Force

if (!$fast) {
    { ../target/release/dice_contract_tests } | Invoke-Block -Linux -Retries 6 -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100 }
}
