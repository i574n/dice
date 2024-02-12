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
