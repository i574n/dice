param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1


# npx -y tailwindcss -i input.css -o target/tailwind.css

if (!$fast) {
    . $(Search-Command bunx) --bun ssl-serve --ssl dist
} else {
    $targetDir = "../deps/polyglot/target/polyglot/builder/dice_ui"
    { trunk serve --dist="$targetDir/trunk" } | Invoke-Block -EnvironmentVariables @{ "TRUNK_TOOLS_WASM_BINDGEN" = "0.2.89" }
}
