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

$livebook = Join-Path $ResolvedScriptDir "../deps/polyglot/deps/spiral/apps/kino/spi/livebook_dib.ps1"
$notebook = Join-Path $ResolvedScriptDir "$projectName.livemd"
$spi = Join-Path $ResolvedScriptDir "$projectName.spi"
# The run's outputs keep the .dib route's names (<nb>.dib.ipynb, <nb>.dib.html): README and gh-pages link to them.
$ipynb = Join-Path $ResolvedScriptDir "$projectName.dib.ipynb"
if (!$fast -and !$SkipNotebook) {
    { pwsh -NoProfile -File $livebook --path $notebook --spi-path $spi --output-path $ipynb } | Invoke-Block -Retries 3
}
else {
    { pwsh -NoProfile -File $livebook --path $notebook --spi-path $spi --export-only } | Invoke-Block
}

{ . ../deps/polyglot/apps/spiral/dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" --timeout 300000 } | Invoke-Block

# Every backend's build of the same entry (its `main` has an arm per backend that runs `main args`) must pass the same
# run check: exit code 0 and a dice.main trace with a result in 1..6^24, the bound `main` rolls up to (the largest an
# i64 supports; catches wraparound/signedness bugs). `main` rolls random dice, so the value can't be compared exactly.
$maxResult = [decimal]4738381338321616896
function Assert-DiceRun([string] $Tag, [string] $Kind, [string[]] $Output, [int] $ExitCode) {
    $Output | ForEach-Object { Write-Output "dice/lib/build.ps1 / $Kind run / $_" }
    $result = $Output | ForEach-Object { if ($_ -match 'dice\.main / \{ result = (-?\d+) \}') { $Matches[1] } } | Select-Object -Last 1
    if ($ExitCode -ne 0 -or !$result -or [decimal]$result -lt 1 -or [decimal]$result -gt $maxResult) {
        throw "$Tag-FAILED dice/lib / run exit code $ExitCode, result '$result': expected a dice.main trace with a result in 1..$maxResult"
    }
    Write-Output "$Tag-OK dice/lib / result $result"
}

# F# (.NET): dice.fsx (the compiler's F# output) with the spiral lib modules and polyglot's Common.fs, published by the
# Builder to dist/ and run.
$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", $runtime, "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../deps/polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block
$fsharpOutput = & "dist/$projectName$(_exe)" 2>&1 | ForEach-Object { "$_" }
Assert-DiceRun "FSHARP" "F#" $fsharpOutput $LASTEXITCODE

$targetDir = GetTargetDir $projectName

# Native Rust: the same dice.spi entry -> dice.rs (tracked) with the Spiral compiler's own Rust backend; dice.rs is the
# dice_lib crate's `dice` bin (Cargo.toml, a member of the dice workspace), built in place.
if (!(BuildNativeRust "$projectName.spi" "$projectName.rs" "dice/lib")) {
    throw "NATIVE-RUST-FAILED dice/lib / compile"
}
{ cargo +nightly-2025-11-01 build --release -p dice_lib } | Invoke-Block
$cargoTarget = (cargo metadata --format-version 1 --no-deps | ConvertFrom-Json).target_directory
$nativeOutput = & "$cargoTarget/release/$projectName$(_exe)" 2>&1 | ForEach-Object { "$_" }
Assert-DiceRun "NATIVE-RUST" "native" $nativeOutput $LASTEXITCODE

if (!$SkipTs) {
    # Native TypeScript: dice.spi -> dice.ts (tracked) with the Spiral compiler's own TypeScript backend, run by bun (which
    # runs .ts directly; node needs --experimental-strip-types, from 22.6). The output must not contain F# text meant for
    # Fable (`Fable.`), which a lib function without a TypeScript arm would emit.
    if (!(BuildNativeRust "$projectName.spi" "$projectName.ts" "dice/lib" -Backend "TypeScript")) {
        throw "NATIVE-TYPESCRIPT-FAILED dice/lib / compile"
    }
    $tsFable = @(Select-String -Path "$projectName.ts" -Pattern 'Fable\.' | ForEach-Object { "$($_.LineNumber): $($_.Line.Trim())" })
    if ($tsFable) {
        throw "NATIVE-TYPESCRIPT-FAILED dice/lib / $projectName.ts contains Fable text: $($tsFable | Select-Object -First 5)"
    }
    $tsOutput = & (Search-Command bun) run "$projectName.ts" 2>&1 | ForEach-Object { "$_" }
    Assert-DiceRun "NATIVE-TYPESCRIPT" "native typescript" $tsOutput $LASTEXITCODE
}

if (!$SkipPy) {
    # Native Python + Cuda: dice.spi -> dice.py (tracked) with the Spiral compiler's own Python backend.
    if (!(BuildNativeRust "$projectName.spi" "$projectName.py" "dice/lib" -Backend "Python + Cuda")) {
        throw "NATIVE-PYTHON-FAILED dice/lib / compile"
    }
    $pyOutput = & ($IsWindows ? "python" : "python3") "$projectName.py" 2>&1 | ForEach-Object { "$_" }
    Assert-DiceRun "NATIVE-PYTHON" "native python" $pyOutput $LASTEXITCODE
}

Write-Output "dice/lib/build.ps1 / `$targetDir = $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore

    ClearCargoTarget "../.."
}
