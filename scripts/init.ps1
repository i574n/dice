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
git clone --recurse-submodules https://$domain/$owner/spiral.git
Set-Location spiral
git pull
Set-Location $ScriptDir

. ../../spiral/scripts/core.ps1

{ pwsh ../../spiral/scripts/init.ps1 -fast $($fast ?? '') } | Invoke-Block
EnsureSymbolicLink -Path "../deps/spiral" -Target "../../spiral"

if (!(Test-Path ../deps/hyperui/public/component.css)) {
    git clone --depth 1 https://github.com/markmead/hyperui.git ../deps/hyperui
    if ($LASTEXITCODE -ne 0) { throw "init.ps1 / git clone hyperui failed (exit code $LASTEXITCODE)" }
}

{ pwsh ../../spiral/apps/spiral/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../../spiral/apps/wasm/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../../spiral/scripts/dir-tree-html.ps1 } | Invoke-Block
