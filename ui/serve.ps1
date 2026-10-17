param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1


if (!$fast) {
    . $(Search-Command bunx) --bun ssl-serve --ssl dist
} else {
    . ../deps/polyglot/deps/spiral/lib/spiral/lib.ps1
    $rustBindgen = [regex]::Match((Get-Content ../Cargo.lock -Raw), '(?m)^name = "wasm-bindgen"\r?\nversion = "([^"]+)"').Groups[1].Value
    { trunk serve --dist="$(GetTargetDir dice_ui)/trunk-serve" --no-sri } | Invoke-Block -EnvironmentVariables @{ "TRUNK_TOOLS_WASM_BINDGEN" = $rustBindgen }
}
