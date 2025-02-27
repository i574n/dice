param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../deps/polyglot/scripts/core.ps1
. ../../deps/polyglot/deps/spiral/lib/spiral/lib.ps1


$projectName = "dice_fsharp"

if (!$fast -and !$SkipNotebook) {
    { . ../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path "$ScriptDir/$projectName.dib" } | Invoke-Block -Retries 3 -Location ../../deps/polyglot/lib/fsharp
}

{ . ../../deps/polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" fs } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fs", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../deps/polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block
{ BuildFable $targetDir $projectName "ts" } | Invoke-Block
{ BuildFable $targetDir $projectName "py" } | Invoke-Block

$path = "$targetDir/$projectName.rs"
if (!($path | Test-Path)) {
    $path = "$targetDir/target/rs/$projectName.rs"
}
if (!($path | Test-Path)) {
    $path = "$targetDir/target/rs/polyglot/target/Builder/$projectName/$projectName.rs"
}
$target = "$projectName.rs"
Write-Output "dice/lib/fsharp/build.ps1 / path: $path / $target"
(Get-Content $path) `
    -replace "`"../../../../../../../../../../../../polyglot/lib", "`"../../deps/polyglot/deps/spiral/lib" `
    -replace "`"../../../lib", "`"../../deps/polyglot/deps/spiral/lib" `
    -replace "`"../../../../../lib", "`"../../deps/polyglot/deps/spiral/lib" `
    -replace "`"../../../../../deps/spiral", "`"../../deps/polyglot/deps/spiral" `
    -replace "`"./lib", "`"../../deps/polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | Set-Content $target

$path = "$targetDir/$projectName.ts"
if (!($path | Test-Path)) {
    $path = "$targetDir/target/ts/$projectName.ts"
}
if (!($path | Test-Path)) {
    $path = "$targetDir/target/ts/polyglot/target/Builder/$projectName/$projectName.ts"
}
$target = "$projectName.ts"
Write-Output "dice/lib/fsharp/build.ps1 / path: $path / $target"
(Get-Content $path) `
    | FixTypeScript `
    | FixTypeScriptExternal `
    | Set-Content $target

$path = "$targetDir/$projectName.py"
if (!($path | Test-Path)) {
    $path = "$targetDir/target/py/$projectName.py"
}
if (!($path | Test-Path)) {
    $path = "$targetDir/target/py/polyglot/target/Builder/$projectName/$projectName.py"
}
$target = "$projectName.py"
Write-Output "dice/lib/fsharp/build.ps1 / path: $path / $target"
Copy-Item $path $target -Force

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
