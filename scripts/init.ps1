param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


$url = git ls-remote --get-url
$owner = ($url -split '/' | Select-Object -Last 2 | Select-Object -First 1) -replace '\.git$', '' ?? $env:GITHUB_REPOSITORY_OWNER
$domain = ($url -split '/' | Select-Object -Last 3 | Select-Object -First 1) ?? $env:GITHUB_SERVER_URL -replace 'https?://', ''
Write-Output "init.ps1 / url: $url / owner: $owner / domain: $domain"

Set-Location (New-Item -ItemType Directory -Path "../.." -Force)
git clone --recurse-submodules https://$domain/$owner/polyglot.git
Set-Location polyglot
git pull
Set-Location $ScriptDir

. ../../polyglot/scripts/core.ps1

# TODO: SPIRAL-INDEPENDENT dice still reaches spiral through polyglot (deps/polyglot/deps/spiral, polyglot core.ps1);
#     lab/SPIRAL-INDEPENDENT/rewrite-deps.ps1 moves 22 files of dice + alphabet to deps/spiral, Common.fs keeps polyglot
EnsureSymbolicLink -Path "../deps/polyglot" -Target "../../polyglot"

{ pwsh ../../polyglot/scripts/init.ps1 -fast $($fast ?? '') } | Invoke-Block

{ pwsh ../../polyglot/apps/parser/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../../polyglot/deps/spiral/apps/spiral/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../../polyglot/deps/spiral/apps/wasm/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../../polyglot/deps/spiral/scripts/dir-tree-html.ps1 } | Invoke-Block
