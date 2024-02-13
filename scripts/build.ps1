param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1


{ . "$ScriptDir/../../polyglot/apps/builder/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/apps/parser/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/lib/fsharp/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/apps/spiral/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/lib/spiral/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/apps/spiral/temp/test/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/apps/dir-tree-html/build.ps1" -fast 1 } | Invoke-Block

{ pwsh "$ScriptDir/../lib/build.ps1" } | Invoke-Block

if (!$fast) {
    { dotnet run --configuration Release --project "$ScriptDir/../temp/dice.fsproj" } | Invoke-Block
}

{ pwsh "$ScriptDir/../contract/build.ps1" -fast 1 } | Invoke-Block

{ pwsh "$ScriptDir/../contract/tests/build.ps1" } | Invoke-Block

{ pwsh "$ScriptDir/../ui/build.ps1" -fast $($fast ?? '') } | Invoke-Block


{ . "$ScriptDir/../fsharp/build.ps1" } | Invoke-Block

{ . "$ScriptDir/../scripts/outdated.ps1" } | Invoke-Block
