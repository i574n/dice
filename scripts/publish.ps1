param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/spiral/scripts/core.ps1


{ pwsh ../deps/spiral/scripts/publish-tree.ps1 -Root .. -Include '*.spi.html,*.spi.ipynb,*.spi.livemd' -Exclude 'target,deps,_build,node_modules' } | Invoke-Block
$ui = Join-Path $ScriptDir '../ui/dist'
if (Test-Path (Join-Path $ui 'index.html')) {
    $target = Join-Path $ScriptDir '../dist/ui/dist'
    New-Item -ItemType Directory -Force $target | Out-Null
    Copy-Item (Join-Path $ui '*') $target -Recurse -Force
    Write-Output "publish.ps1 / ui: $(@(Get-ChildItem $target -Recurse -File).Count) files -> dist/ui/dist"
}
