param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1
. ../deps/polyglot/lib/spiral/lib.ps1


$projectName = "dice"

if (!$fast -and !$SkipNotebook) {
    { . apps/spiral/dist/Supervisor$(_exe) --execute-command "deps/spiral/workspace/target/release/spiral$(_exe) dib --path $ScriptDir/$projectName.dib" } | Invoke-Block -Retries 3 -Location ../deps/polyglot
}

{ . ../deps/polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

{ . ../deps/polyglot/apps/spiral/dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" --timeout 60000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../deps/polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block
{ BuildFable $targetDir $projectName "ts" } | Invoke-Block
{ BuildFable $targetDir $projectName "py" } | Invoke-Block

(Get-Content "$targetDir/target/rs/polyglot/target/Builder/$projectName/$projectName.rs") `
    -replace "../../../lib", "../deps/polyglot/lib" `
    -replace "../../../../../../../../../../../../polyglot", "../deps/polyglot" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | Set-Content "$projectName.rs"

(Get-Content "$targetDir/target/ts/polyglot/target/Builder/$projectName/$projectName.ts") `
    | FixTypeScript `
    | Set-Content "$projectName.ts"

Copy-Item "$targetDir/target/py/polyglot/target/Builder/$projectName/$projectName.py" "$projectName.py" -Force

{ BuildFable $targetDir $projectName "rs" "CONTRACT" } | Invoke-Block
(Get-Content "$targetDir/target/rs/polyglot/target/Builder/$projectName/$projectName.rs") `
    -replace "../../../lib", "../deps/polyglot/lib" `
    -replace "../../../../../../../../../../../../polyglot", "../deps/polyglot" `
    -replace ".fsx`"]", ".rs`"]" `
    -replace ".rs`"]", "_contract.rs`"]" `
    -replace "use fable_library_rust::DateTime_::DateTime;", "type DateTime = ();" `
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
