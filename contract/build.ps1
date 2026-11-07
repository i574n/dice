param(
    $fast,
    $SkipNotebook,
    $SkipTests,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/spiral/scripts/core.ps1
. ../deps/spiral/lib/spiral/lib.ps1


$projectName = "dice_contract"

$livebook = Join-Path $ScriptDir "../deps/spiral/apps/cells/spi/run_notebook.ps1"
$spi = Join-Path $ScriptDir "$projectName.spi"
$ipynb = Join-Path $ScriptDir "$projectName.spi.ipynb"
if (!$fast -and !$SkipNotebook) {
    { pwsh -NoProfile -File $livebook --path $spi --livemd --output-path $ipynb } | Invoke-Block -Retries $($fast -or !$env:CI ? 1 : 3)
}

$targetDir = GetTargetDir $projectName

function Get-WasmExports([string] $Path) {
    $bytes = [IO.File]::ReadAllBytes($Path)
    $at = @(8)
    $leb = { $r = 0; $shift = 0; do { $b = $bytes[$at[0]++]; $r = $r -bor (($b -band 0x7f) -shl $shift); $shift += 7 } while ($b -band 0x80); $r }
    while ($at[0] -lt $bytes.Length) {
        $id = $bytes[$at[0]++]
        $size = & $leb
        $end = $at[0] + $size
        if ($id -eq 7) {
            $count = & $leb
            for ($i = 0; $i -lt $count; $i++) {
                $length = & $leb
                $name = [Text.Encoding]::UTF8.GetString($bytes, $at[0], $length)
                $at[0] += $length
                $kind = $bytes[$at[0]++]
                $null = & $leb
                if ($kind -eq 0) { $name }
            }
        }
        $at[0] = $end
    }
}

if (!(BuildSpiral "$ScriptDir/$projectName.spi" "$ScriptDir/$projectName.rs" "dice/contract")) {
    throw "RUST-FAILED dice/contract / compile"
}
{ cargo build --release --target wasm32-unknown-unknown -p $projectName } | Invoke-Block -EnvironmentVariables @{ "AUTOMATION" = "False"; "SPIRAL_TRACE_FLOOR" = "Debug" }
$cargoTargetDir = (cargo metadata --format-version 1 --no-deps | ConvertFrom-Json).target_directory
$rustWasm = "$cargoTargetDir/wasm32-unknown-unknown/release/$projectName.wasm"
if (!(Test-Path $rustWasm)) { throw "RUST-FAILED dice/contract / no $rustWasm" }
New-Item dist -ItemType Directory -Force | Out-Null
$nearWasmFeatures = @('--enable-bulk-memory', '--enable-sign-ext', '--enable-mutable-globals', '--enable-nontrapping-float-to-int', '--enable-reference-types')
{ wasm-opt -Oz @nearWasmFeatures --strip-debug --strip-producers $rustWasm -o dist/dice.wasm } | Invoke-Block
$rustExports = @(Get-WasmExports (Join-Path $ScriptDir dist/dice.wasm))
$contractMethods = @('new', 'migrate', 'contribute_seed', 'contribute_seed_borsh', 'generate_random_number', 'roll_within_bounds', 'roll_within_bounds_borsh')
$missing = @($contractMethods | Where-Object { $_ -notin $rustExports })
if ($missing) { throw "RUST-FAILED dice/contract / the wasm doesn't export $($missing -join ', ') (exports: $($rustExports -join ', '))" }
Write-Output "RUST-COMPILED dice/contract / dist/dice.wasm $((Get-Item dist/dice.wasm).Length) B / exports $($rustExports -join ', ')"

if (!$fast -and !$SkipTests) {
    { pwsh tests/build.ps1 } | Invoke-Block
    Write-Output "RUST-OK dice/contract / the NEAR sandbox tests passed on dist/dice.wasm"
}

Write-Output "dice/contract/build.ps1 / `$targetDir = $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    ClearCargoTarget ".."
}
