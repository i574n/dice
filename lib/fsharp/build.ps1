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
    { . ../../../polyglot/apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../../polyglot/scripts/invoke-dib.ps1 $projectName.dib`"" } | Invoke-Block -Retries 5
}

{ . ../../../polyglot/apps/parser/dist/DibParser$(GetExecutableSuffix) "$projectName.dib" fs } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fs", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../../polyglot/apps/builder/dist/Builder$(GetExecutableSuffix) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block
if (!$fast) {
    
    { BuildFable $targetDir $projectName "ts" } | Invoke-Block
    { BuildFable $targetDir $projectName "py" } | Invoke-Block
    { BuildFable $targetDir $projectName "php" } | Invoke-Block -OnError Continue
    { BuildFable $targetDir $projectName "dart" } | Invoke-Block -OnError Continue
}

(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../../lib", "../../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | Set-Content "$projectName.rs"
if (!$fast) {
    Copy-Item "$targetDir/target/ts/$projectName.ts" "$projectName.ts" -Force
    Copy-Item "$targetDir/target/py/$projectName.py" "$projectName.py" -Force
    Copy-Item "$targetDir/target/php/$projectName.php" "$projectName.php" -Force
    Copy-Item "$targetDir/target/dart/$projectName.dart" "$projectName.dart" -Force
}

{ BuildFable $targetDir $projectName "rs" "WASM" } | Invoke-Block
if (!$fast) {
    
    { BuildFable $targetDir $projectName "ts" "WASM" } | Invoke-Block
    { BuildFable $targetDir $projectName "py" "WASM" } | Invoke-Block
    { BuildFable $targetDir $projectName "php" "WASM" } | Invoke-Block -OnError Continue
    { BuildFable $targetDir $projectName "dart" "WASM" } | Invoke-Block -OnError Continue
}

(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../../lib", "../../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    -replace ".rs`"]", "_wasm.rs`"]" `
    | Set-Content "$($projectName)_wasm.rs"

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
