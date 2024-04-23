param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1


{ . ../lib/build.ps1 -fast $($fast ?? '') } | Invoke-Block -Location $ScriptDir

if (!$fast) {
    { dotnet run --configuration Release --project ../temp/dice.fsproj } | Invoke-Block -Location $ScriptDir
}

{ . ../contract/build.ps1 -fast 1 } | Invoke-Block -Location $ScriptDir

{ . ../contract/tests/build.ps1} | Invoke-Block -Retries 3 -Location $ScriptDir

{ . ../ui/build.ps1 -fast $($fast ?? '') } | Invoke-Block -Location $ScriptDir


{ . ../lib/fsharp/build.ps1 } | Invoke-Block -Location $ScriptDir

{ . ../scripts/outdated.ps1 } | Invoke-Block -Location $ScriptDir
