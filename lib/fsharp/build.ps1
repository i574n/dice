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

# The notebook (F# only: its export is dice_fsharp.fs, not Spiral, hence --no-spi) runs through Kino.
# A run writes <nb>.livemd.ipynb and <nb>.livemd.html.
$livebook = Join-Path $ScriptDir "../../deps/polyglot/deps/spiral/apps/kino/spi/run_notebook.ps1"
$notebook = Join-Path $ScriptDir "$projectName.livemd"
if (!$fast -and !$SkipNotebook) {
    $ipynb = Join-Path $ScriptDir "$projectName.livemd.ipynb"
    { pwsh -NoProfile -File $livebook --path $notebook --output-path $ipynb --no-spi } | Invoke-Block -Retries 3
}

# dice_fsharp.fs: the notebook's F# module (--fs-path).
{ pwsh -NoProfile -File $livebook --path $notebook --no-spi --fs-path "$ScriptDir/$projectName.fs" --export-only } | Invoke-Block

# F# (.NET): dice_fsharp.fs with the spiral lib modules and polyglot's Common.fs, published to dist/ (lib.ps1
# PublishFsharp) and run: exit code 0 and a `main / result: N` trace with N in 1..Int32.MaxValue / 10 (the bound
# `main` rolls up to; it rolls random dice, so the value can't be compared exactly).
$runtime = $fast -or $env:CI ? ($IsWindows ? "win-x64" : "linux-x64") : $null
$modules = @(GetFsxModulePaths) + "../../deps/polyglot/lib/fsharp/Common.fs"
if (!(PublishFsharp "$projectName.fs" -Modules $modules -Runtime $runtime)) {
    throw "FSHARP-FAILED dice/lib/fsharp / dotnet publish"
}

$output = & "dist/$projectName$(_exe)" 2>&1 | ForEach-Object { "$_" }
$exitCode = $LASTEXITCODE
$output | ForEach-Object { Write-Output "dice/lib/fsharp/build.ps1 / run / $_" }
$maxResult = [int]::MaxValue / 10
$result = $output | ForEach-Object { if ($_ -match '\bmain / result: (-?\d+)') { $Matches[1] } } | Select-Object -Last 1
if ($exitCode -ne 0 -or !$result -or [decimal]$result -lt 1 -or [decimal]$result -gt $maxResult) {
    throw "FSHARP-FAILED dice/lib/fsharp / run exit code $exitCode, result '$result': expected a main trace with a result in 1..$maxResult"
}
Write-Output "FSHARP-OK dice/lib/fsharp / result $result"

$targetDir = GetTargetDir $projectName

Write-Output "dice/lib/fsharp/build.ps1 / `$targetDir = $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
