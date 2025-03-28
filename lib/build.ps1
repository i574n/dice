param(
    $fast,
    $SkipNotebook,
    $SkipRust,
    $SkipTypeScript,
    $SkipPython,
    $ScriptDir = $PSScriptRoot
)
$ScriptDir | Set-Location
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1
. ../deps/polyglot/deps/spiral/lib/spiral/lib.ps1

$ResolvedScriptDir = ResolveLink $ScriptDir
$ResolvedScriptDir | Set-Location

Write-Output "dice/lib/build.ps1 / ScriptDir: $ScriptDir / ResolvedScriptDir: $ResolvedScriptDir"

$projectName = "dice"

if (!$fast -and !$SkipNotebook) {
    { . deps/spiral/workspace/target/release/spiral$(_exe) dib --path "$ResolvedScriptDir/$projectName.dib" } | Invoke-Block -Retries 3 -Location ../deps/polyglot
}

{ . ../deps/polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

{ . ../deps/polyglot/apps/spiral/dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" --timeout 180000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../deps/polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

if (!$SkipRust) {
    { BuildFable $targetDir $projectName "rs" } | Invoke-Block

    $Path = "$targetDir/target/rs/$projectName.rs"
    if (!($Path | Test-Path)) {
        $Path = "$targetDir/target/rs/polyglot/target/Builder/$projectName/$projectName.rs"
    }
    $Target = "$projectName.rs"
    Write-Output "dice/lib/build.ps1 / Path: $Path / Target: $Target"
    (Get-Content $Path) `
        -replace "`"./lib", "`"../deps/polyglot/lib" `
        -replace "`"../../../../../deps/spiral", "`"../deps/polyglot/deps/spiral" `
        -replace "../../../lib", "../deps/polyglot/deps/spiral/lib" `
        -replace "../../../../../../../../../../../../polyglot", "../deps/polyglot" `
        -replace "../../../deps/polyglot", "../deps/polyglot" `
        -replace ".fsx`"]", ".rs`"]" `
        | FixRust `
        | Set-Content $Target
}

if (!$SkipTypeScript) {
    { BuildFable $targetDir $projectName "ts" } | Invoke-Block

    $Path = "$targetDir/target/ts/$projectName.ts"
    if (!($Path | Test-Path)) {
        $Path = "$targetDir/target/ts/polyglot/target/Builder/$projectName/$projectName.ts"
    }
    $Target = "$projectName.ts"
    Write-Output "dice/lib/build.ps1 / Path: $Path / Target: $Target"
    (Get-Content $Path) `
        | FixTypeScript `
        | FixTypeScriptExternal `
        | Set-Content $Target
}

if (!$SkipPython) {
    { BuildFable $targetDir $projectName "py" } | Invoke-Block

    $Path = "$targetDir/target/py/$projectName.py"
    if (!($Path | Test-Path)) {
        $Path = "$targetDir/target/py/polyglot/target/Builder/$projectName/$projectName.py"
    }
    $Target = "$projectName.py"
    Write-Output "dice/lib/build.ps1 / Path: $Path / Target: $Target"
    Copy-Item $Path $Target -Force

    { BuildFable $targetDir $projectName "rs" "CONTRACT" } | Invoke-Block
}

if (!$SkipRust) {
    $Path = "$targetDir/target/rs/$projectName.rs"
    if (!($Path | Test-Path)) {
        $Path = "$targetDir/target/rs/polyglot/target/Builder/$projectName/$projectName.rs"
    }
    $Target = "$($projectName)_contract.rs"
    Write-Output "dice/lib/build.ps1 / Path: $Path / Target: $Target"
    (Get-Content $Path) `
        -replace "`"../../../../../lib", "`"../deps/polyglot/deps/spiral/lib" `
        -replace "`"./lib", "`"../deps/polyglot/lib" `
        -replace "`"../../../../../deps/spiral", "`"../deps/polyglot/deps/spiral" `
        -replace "../../../../../../../../../../../../polyglot", "../deps/polyglot" `
        -replace "../../../deps/polyglot", "../deps/polyglot" `
        -replace ".fsx`"]", ".rs`"]" `
        -replace ".rs`"]", "_contract.rs`"]" `
        -replace "use fable_library_rust::DateTime_::DateTime;", "type DateTime = ();" `
        | FixRust `
        | Set-Content $Target

    cargo fmt --
    { cargo fmt -- } | Invoke-Block -Location contract

    if (!$fast) {
        { cargo run --release } | Invoke-Block
    }
}

Write-Output "dice/lib/build.ps1 / `$targetDir = $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
