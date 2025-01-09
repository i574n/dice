param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


if (!$fast) {
    Set-Location (New-Item -ItemType Directory -Path "../.." -Force)
    git clone --recurse-submodules https://github.com/i574n/polyglot.git # --branch gh-pages
    Set-Location polyglot
    git pull
    Set-Location $ScriptDir
}

. ../../polyglot/scripts/core.ps1

EnsureSymbolicLink -Path "../deps/polyglot" -Target "../../polyglot"

{ pwsh ../../polyglot/scripts/init.ps1 -fast $($fast ?? '') } | Invoke-Block

{ pwsh ../deps/polyglot/apps/builder/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../deps/polyglot/apps/parser/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../deps/polyglot/apps/spiral/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../deps/polyglot/deps/spiral/apps/wasm/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../deps/polyglot/apps/dir-tree-html/build.ps1 -fast 1 } | Invoke-Block
