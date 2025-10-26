param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


$url = git config --get remote.origin.url
$owner = ($url -split '/' | Select-Object -Last 1) -replace '\.git$', ''

Set-Location (New-Item -ItemType Directory -Path "../.." -Force)
git clone --recurse-submodules https://github.com/$owner/polyglot.git # --branch gh-pages
Set-Location polyglot
git pull
Set-Location $ScriptDir

. ../../polyglot/scripts/core.ps1

EnsureSymbolicLink -Path "../deps/polyglot" -Target "../../polyglot"

{ pwsh ../../polyglot/scripts/init.ps1 -fast $($fast ?? '') } | Invoke-Block

{ pwsh ../../polyglot/apps/builder/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../../polyglot/apps/parser/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../../polyglot/apps/spiral/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../../polyglot/deps/spiral/apps/spiral/build.ps1 -fast 1 -SkipFsx 1 } | Invoke-Block
{ pwsh ../../polyglot/deps/spiral/apps/wasm/build.ps1 -SkipFsx 1 } | Invoke-Block
{ pwsh ../../polyglot/apps/dir-tree-html/build.ps1 -fast 1 } | Invoke-Block
