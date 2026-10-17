param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../deps/polyglot/scripts/core.ps1


{ cargo run --timings --release } | Invoke-Block -Linux -Retries 6 -EnvironmentVariables @{ "NEAR_RPC_TIMEOUT_SECS" = 100 }
