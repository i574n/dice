param(
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

{ . "$ScriptDir/../build.ps1" } | Invoke-Block
{ . "$ScriptDir/../fsharp/build.ps1" } | Invoke-Block
