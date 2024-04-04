param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1


function CheckToml {
    param (
        [Parameter(Position = 0, Mandatory)]
        [string] $toml,

        [Parameter(Position = 1, ValueFromRemainingArguments)]
        [Object[]]$_args
    )
    $toml = [IO.Path]::GetFullPath("$ScriptDir/$toml")
    Write-Output "`nCheckToml / toml: $toml"
    { cargo outdated -m $toml --exclude tokio @_args } | Invoke-Block
}

function CheckJson {
    param (
        [string] $json
    )
    $json = [IO.Path]::GetFullPath("$ScriptDir/$json").Replace("\", "/")
    Write-Output "`nCheckJson / json: $json"
    { ~/.bun/bin/bun --cwd $json outdated-pre } | Invoke-Block
}


{ dotnet paket outdated --include-prereleases } | Invoke-Block

CheckToml "../Cargo.toml" `-w

CheckToml "../fsharp/Cargo.toml"
CheckToml "../contract/Cargo.toml"
CheckToml "../contract/tests/Cargo.toml"
CheckToml "../ui/Cargo.toml"

CheckJson "../ui"
CheckJson "../ui/e2e"
