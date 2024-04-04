param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1


{ . ../../polyglot/apps/spiral/dist/Supervisor$(GetExecutableSuffix) --build-file src/dice_ui.spi src/dice_ui.fsx --timeout 20000 } | Invoke-Block

(Get-Content src/dice_ui.fsx) `
    -replace "and Heap2 =", "and  Heap2 =" `
| Set-Content src/dice_ui.fsx

{ . ../../polyglot/apps/builder/dist/Builder$(GetExecutableSuffix) src/dice_ui.fsx $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) $($fast ? @("--persist-only") : @()) --packages Fable.Core --modules lib/spiral/common.fsx lib/spiral/sm.fsx lib/spiral/date_time.fsx lib/spiral/file_system.fsx lib/spiral/lib.fsx lib/fsharp/Common.fs } | Invoke-Block

$targetDir = "../../polyglot/target/polyglot/builder/dice_ui"

{ dotnet fable $targetDir/dice_ui.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/target/rs --define WASM } | Invoke-Block

(Get-Content $targetDir/target/rs/dice_ui.rs) `
    -replace "../../../../lib", "../../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    -replace ".rs`"]", "_wasm.rs`"]" `
    -replace "pub use crate::module_", "// pub use crate::module_" `
    -replace "pub struct Heap0 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize, Default)] pub struct Heap0 {" `
    -replace "pub struct Heap1 {", "#[derive(serde::Serialize)] pub struct Heap1 {" `
    -replace "pub struct Heap2 {", "#[derive(serde::Serialize)] pub struct Heap2 {" `
    -replace "pub struct Heap3 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize)] pub struct Heap3 {" `
    -replace "pub struct Heap4 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize, PartialEq, PartialOrd, Hash, Eq)] pub struct Heap4 {" `
    -replace "pub struct Heap5 {", "#[derive(PartialEq)] pub struct Heap5 {" `
    -replace "pub enum US1 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize, Default)] pub enum US1 {" `
    -replace " US1_0,", "#[default] US1_0," `
| Set-Content src/dice_ui_wasm.rs

# -replace "pub struct Heap0 {", "#[derive(serde::Serialize)] pub struct Heap0 {" `
# -replace "pub struct Heap1 {", "#[derive(serde::Serialize, serde::Deserialize)] pub struct Heap1 {" `
# -replace "pub struct Heap2 {", "#[derive(serde::Serialize)] pub struct Heap2 {" `
# -replace "pub struct Heap3 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize)] pub struct Heap3 {" `
# -replace "pub struct Heap4 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize)] pub struct Heap4 {" `

cargo fmt --
leptosfmt ./src/dice_ui_wasm.rs

if (!$fast) {
    Remove-Item $targetDir/trunk -Recurse -Force -ErrorAction Ignore
    Remove-Item ./dist -Recurse -Force -ErrorAction Ignore

    { ~/.bun/bin/bun install --frozen-lockfile } | Invoke-Block
}

{ ~/.bun/bin/bun build-css } | Invoke-Block

Write-Output "trunk:"

{ trunk build $($fast ? $() : '--release') --dist="$targetDir/trunk" --public-url="./" --no-sri --no-minification } | Invoke-Block -EnvironmentVariables @{ "TRUNK_TOOLS_WASM_BINDGEN" = "0.2.92" }
# { cargo leptos build --release } | Invoke-Block

$path = "$targetDir/trunk/index.html"
$html = Get-Content $path -Raw

$wasmFile = ($html | Select-String -Pattern "init\('\./(.*?)'\);").Matches[0].Groups[1].Value
$jsFile = ($html | Select-String -Pattern "import init, \* as bindings from '\./(.*?)';").Matches[0].Groups[1].Value

(Get-Content "$targetDir/trunk/$jsFile" -Raw) `
    -replace "\('.*', import.meta.url\);", "('$wasmFile', import.meta.url);" `
| Set-Content "$targetDir/trunk/$jsFile"

Write-Output "rna:"
{ rna build --bundle --minify --assetNames "[name]" $path --output dist } | Invoke-Block

$path = "dist/index.html"

Move-Item $path dist/popup.html -Force
Copy-Item dist/popup.html dist/index.html -Force
Copy-Item public/manifest.json dist/manifest.json -Force

if (!$fast) {
    { ~/.bun/bin/bun install --frozen-lockfile } | Invoke-Block -Location e2e
    { ~/.bun/bin/bun test:e2e } | Invoke-Block -Location e2e
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
