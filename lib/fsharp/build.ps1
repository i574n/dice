param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../deps/polyglot/scripts/core.ps1
. ../../deps/polyglot/lib/spiral/lib.ps1


$projectName = "dice_fsharp"

if (!$fast -and !$SkipNotebook) {
    { . ../../apps/spiral/dist/Supervisor$(_exe) --execute-command "../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path $ScriptDir/$projectName.dib" } | Invoke-Block -Retries 3 -Location ../../deps/polyglot/lib/fsharp
}

{ . ../../deps/polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" fs } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fs", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../deps/polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block
{ BuildFable $targetDir $projectName "ts" } | Invoke-Block
{ BuildFable $targetDir $projectName "py" } | Invoke-Block

(Get-Content "$targetDir/target/rs/polyglot/target/Builder/$projectName/$projectName.rs") `
    -replace "`"../../../../../../../../../../../../polyglot/lib", "`"../../deps/polyglot/lib" `
    -replace "`"../../../lib", "`"../../deps/polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | Set-Content "$projectName.rs"

(Get-Content "$targetDir/target/ts/polyglot/target/Builder/$projectName/$projectName.ts") `
    | FixTypeScript `
    | Set-Content "$projectName.ts"

Copy-Item "$targetDir/target/py/polyglot/target/Builder/$projectName/$projectName.py" "$projectName.py" -Force

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
