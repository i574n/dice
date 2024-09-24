param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1


function CheckToml {
    param (
        [Parameter(Position = 0, Mandatory)]
        [string] $toml,

        [Parameter(Position = 1, ValueFromRemainingArguments)]
        [Object[]]$_args
    )
    $toml = [IO.Path]::GetFullPath("$ScriptDir/$toml")
    Write-Output "`nCheckToml / toml: $toml / _args: $_args"
    { cargo outdated -m $toml @_args } | Invoke-Block -OnError Continue
}

function CheckJson {
    param (
        [string] $json
    )
    $json = [IO.Path]::GetFullPath("$ScriptDir/$json").Replace("\", "/")
    Write-Output "`nCheckJson / json: $json"
    { ~/.bun/bin/bun --bun --cwd $json outdated-pre } | Invoke-Block -OnError Continue
}


CheckToml "../Cargo.toml" `-w

CheckToml "../lib/Cargo.toml"
CheckToml "../lib/contract/Cargo.toml"
CheckToml "../lib/fsharp/Cargo.toml"
CheckToml "../contract/Cargo.toml"
CheckToml "../contract/tests/Cargo.toml"
CheckToml "../ui/Cargo.toml"

CheckJson "../ui"
CheckJson "../ui/e2e"
