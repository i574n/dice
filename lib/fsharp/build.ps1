param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../polyglot/scripts/core.ps1
. ../../../polyglot/lib/spiral/lib.ps1


$projectName = "dice_fsharp"

if (!$fast -and !$SkipNotebook) {
    { . ../../apps/spiral/dist/Supervisor$(_exe) --execute-command "../../target/release/spiral_builder$(_exe) dib --path ../../../dice/lib/fsharp/$projectName.dib" } | Invoke-Block -Retries 3 -Location ../../../polyglot/lib/fsharp
}

{ . ../../../polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" fs } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fs", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../../polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block
if (!$fast) {

    { BuildFable $targetDir $projectName "ts" } | Invoke-Block
    { BuildFable $targetDir $projectName "py" } | Invoke-Block
}

(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../../lib", "../../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | Set-Content "$projectName.rs"
if (!$fast) {
    (Get-Content "$targetDir/target/ts/$projectName.ts") `
        | FixTypeScript `
        | Set-Content "$projectName.ts"
    Copy-Item "$targetDir/target/py/$projectName.py" "$projectName.py" -Force
}

cargo +nightly fmt --

if (!$fast) {
    { cargo +nightly run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
