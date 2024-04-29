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
    { . apps/spiral/dist/Supervisor$(_exe) --execute-command "pwsh -c `"scripts/invoke-dib.ps1 ../$projectName/lib/$projectName.dib`"" } | Invoke-Block -Retries 5 -Location ../../polyglot
}

{ . ../../polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

{ . ../../polyglot/apps/spiral/dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" --timeout 60000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block
{ BuildFable $targetDir $projectName "ts" } | Invoke-Block
if (!$fast) {
    { BuildFable $targetDir $projectName "py" } | Invoke-Block
}
(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../../lib", "../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | Set-Content "$projectName.rs"

(Get-Content "$targetDir/target/ts/$projectName.ts") `
    | FixTypeScript `
    | Set-Content "$projectName.ts"

if (!$fast) {
    Copy-Item "$targetDir/target/py/$projectName.py" "$projectName.py" -Force
}

{ BuildFable $targetDir $projectName "rs" "CONTRACT" } | Invoke-Block
(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../../lib", "../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    -replace ".rs`"]", "_contract.rs`"]" `
    | FixRust `
    | Set-Content "$($projectName)_contract.rs"

cargo fmt --
{ cargo fmt -- } | Invoke-Block -Location contract

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
