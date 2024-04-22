param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


Set-Location (New-Item -ItemType Directory -Path "../.." -Force)
git clone --recurse-submodules https://github.com/i574n/polyglot.git
Set-Location polyglot
git pull

pwsh scripts/init.ps1

Set-Location $ScriptDir


dotnet paket restore

. ../../polyglot/scripts/core.ps1

{ . "$ScriptDir/../../polyglot/apps/builder/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/apps/parser/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/apps/spiral/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/lib/rust/fable/build.ps1" } | Invoke-Block
{ . "$ScriptDir/../../polyglot/lib/fsharp/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/lib/spiral/build.ps1" -fast 1 } | Invoke-Block
{ . "$ScriptDir/../../polyglot/apps/dir-tree-html/build.ps1" -fast 1 } | Invoke-Block
