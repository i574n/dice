param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../polyglot/scripts/core.ps1


{ cargo +nightly run --release } | Invoke-Block -Linux -Retries 6 -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100 }
