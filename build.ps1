param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../polyglot/scripts/core.ps1


{ pwsh ./lib/build.ps1 } | Invoke-Block

if (!$fast) {
    { dotnet run --configuration Release --project temp/dice.fsproj } | Invoke-Block
}

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

{ pwsh ./contract/build.ps1 -fast 1 } | Invoke-Block

{ pwsh ./contract/tests/build.ps1 } | Invoke-Block

{ pwsh ./ui/build.ps1 -fast $($fast ?? '') } | Invoke-Block

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
