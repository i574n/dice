param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1


{ pwsh "$ScriptDir/../lib/build.ps1" -fast $($fast ?? '') } | Invoke-Block

if (!$fast) {
    { dotnet run --configuration Release --project "$ScriptDir/../temp/dice.fsproj" } | Invoke-Block
}

{ pwsh "$ScriptDir/../contract/build.ps1" -fast 1 } | Invoke-Block

{ pwsh "$ScriptDir/../contract/tests/build.ps1" } | Invoke-Block -Retries 3

{ pwsh "$ScriptDir/../ui/build.ps1" -fast $($fast ?? '') } | Invoke-Block


{ . "$ScriptDir/../lib/fsharp/build.ps1" } | Invoke-Block

{ . "$ScriptDir/../scripts/outdated.ps1" } | Invoke-Block
