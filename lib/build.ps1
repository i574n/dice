param(
    $fast,
    $SkipNotebook,
    $SkipTs,
    $SkipPy,
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

$livebook = Join-Path $ResolvedScriptDir "../deps/polyglot/deps/spiral/apps/kino/spi/run_notebook.ps1"
$notebook = Join-Path $ResolvedScriptDir "$projectName.livemd"
$spi = Join-Path $ResolvedScriptDir "$projectName.spi"
$ipynb = Join-Path $ResolvedScriptDir "$projectName.livemd.ipynb"
if (!$fast -and !$SkipNotebook) {
    { pwsh -NoProfile -File $livebook --path $notebook --spi-path $spi --output-path $ipynb } | Invoke-Block -Retries 3
}
else {
    { pwsh -NoProfile -File $livebook --path $notebook --spi-path $spi --export-only } | Invoke-Block
}

if (!(BuildSpiral "$projectName.spi" "$projectName.fsx" "dice/lib" -Backend Fsharp)) {
    throw "FSHARP-FAILED dice/lib / compile"
}

$maxResult = [decimal]4738381338321616896
function Assert-DiceRun([string] $Tag, [string] $Kind, [string[]] $Output, [int] $ExitCode) {
    $Output | ForEach-Object { Write-Output "dice/lib/build.ps1 / $Kind run / $_" }
    $result = $Output | ForEach-Object { if ($_ -match 'dice\.main / \{ result = (-?\d+) \}') { $Matches[1] } } | Select-Object -Last 1
    if ($ExitCode -ne 0 -or !$result -or [decimal]$result -lt 1 -or [decimal]$result -gt $maxResult) {
        throw "$Tag-FAILED dice/lib / run exit code $ExitCode, result '$result': expected a dice.main trace with a result in 1..$maxResult"
    }
    Write-Output "$Tag-OK dice/lib / result $result"
}

$runtime = $fast -or $env:CI ? ($IsWindows ? "win-x64" : "linux-x64") : $null
if (!(PublishFsharp "$projectName.fsx" -Runtime $runtime)) {
    throw "FSHARP-FAILED dice/lib / dotnet publish"
}
$fsharpOutput = & "dist/$projectName$(_exe)" 2>&1 | ForEach-Object { "$_" }
Assert-DiceRun "FSHARP" "F#" $fsharpOutput $LASTEXITCODE

$targetDir = GetTargetDir $projectName

if (!(BuildSpiral "$projectName.spi" "$projectName.rs" "dice/lib")) {
    throw "RUST-FAILED dice/lib / compile"
}
{ cargo +nightly-2025-11-01 build --release -p dice_lib } | Invoke-Block
$cargoTarget = (cargo metadata --format-version 1 --no-deps | ConvertFrom-Json).target_directory
$rustOutput = & "$cargoTarget/release/$projectName$(_exe)" 2>&1 | ForEach-Object { "$_" }
Assert-DiceRun "RUST" "Rust" $rustOutput $LASTEXITCODE

if (!$SkipTs) {
    if (!(BuildSpiral "$projectName.spi" "$projectName.ts" "dice/lib" -Backend "TypeScript")) {
        throw "TYPESCRIPT-FAILED dice/lib / compile"
    }
    $tsFable = @(Select-String -Path "$projectName.ts" -Pattern 'Fable\.' | ForEach-Object { "$($_.LineNumber): $($_.Line.Trim())" })
    if ($tsFable) {
        throw "TYPESCRIPT-FAILED dice/lib / $projectName.ts contains Fable text: $($tsFable | Select-Object -First 5)"
    }
    $tsOutput = & (Search-Command bun) run "$projectName.ts" 2>&1 | ForEach-Object { "$_" }
    Assert-DiceRun "TYPESCRIPT" "TypeScript" $tsOutput $LASTEXITCODE
}

if (!$SkipPy) {
    if (!(BuildSpiral "$projectName.spi" "$projectName.py" "dice/lib" -Backend "Python + Cuda")) {
        throw "PYTHON-FAILED dice/lib / compile"
    }
    $pyOutput = & ($IsWindows ? "python" : "python3") "$projectName.py" 2>&1 | ForEach-Object { "$_" }
    Assert-DiceRun "PYTHON" "Python" $pyOutput $LASTEXITCODE
}

Write-Output "dice/lib/build.ps1 / `$targetDir = $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore

    ClearCargoTarget "../.."
}
