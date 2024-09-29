param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1


{ pwsh ../lib/build.ps1 -fast $($fast ?? '') } | Invoke-Block

{ pwsh ../contract/build.ps1 } | Invoke-Block

{ pwsh ../contract/tests/build.ps1 } | Invoke-Block -Retries 3

{ pwsh ../ui/build.ps1 -fast $($fast ?? '') } | Invoke-Block

{ pwsh ../lib/fsharp/build.ps1 } | Invoke-Block

{ pwsh ../scripts/outdated.ps1 } | Invoke-Block
