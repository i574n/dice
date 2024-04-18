param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1
. ../../polyglot/lib/spiral/lib.ps1


$projectName = "dice"

if (!$fast -and !$SkipNotebook) {
    { . apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"scripts/invoke-dib.ps1 ../$projectName/lib/$projectName.dib`"" } | Invoke-Block -Retries 5 -Location ../../polyglot
}

{ . ../../polyglot/apps/parser/dist/DibParser$(GetExecutableSuffix) "$projectName.dib" spi } | Invoke-Block

{ . ../../polyglot/apps/spiral/dist/Supervisor$(GetExecutableSuffix) --build-file "$projectName.spi" "$projectName.fsx" --timeout 60000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../polyglot/apps/builder/dist/Builder$(GetExecutableSuffix) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block
{ BuildFable $targetDir $projectName "ts" } | Invoke-Block
if (!$fast) {
    { BuildFable $targetDir $projectName "py" } | Invoke-Block
    { BuildFable $targetDir $projectName "php" } | Invoke-Block -OnError Continue
    { BuildFable $targetDir $projectName "dart" } | Invoke-Block -OnError Continue
}
(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../../lib", "../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | Set-Content "$projectName.rs"
if (!$fast) {
    Copy-Item "$targetDir/target/ts/$projectName.ts" "$projectName.ts" -Force
    Copy-Item "$targetDir/target/py/$projectName.py" "$projectName.py" -Force
    Copy-Item "$targetDir/target/php/$projectName.php" "$projectName.php" -Force
    Copy-Item "$targetDir/target/dart/$projectName.dart" "$projectName.dart" -Force
}

{ BuildFable $targetDir $projectName "rs" "CONTRACT" } | Invoke-Block
{ BuildFable $targetDir $projectName "ts" "CONTRACT" } | Invoke-Block
if (!$fast) {
    
    { BuildFable $targetDir $projectName "py" "CONTRACT" } | Invoke-Block
    { BuildFable $targetDir $projectName "php" "CONTRACT" } | Invoke-Block -OnError Continue
    { BuildFable $targetDir $projectName "dart" "CONTRACT" } | Invoke-Block -OnError Continue
}
(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../../lib", "../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    -replace ".rs`"]", "_contract.rs`"]" `
    | FixRust `
    | Set-Content "$($projectName)_contract.rs"

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
