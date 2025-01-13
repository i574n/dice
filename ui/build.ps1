param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1
. ../deps/polyglot/lib/spiral/lib.ps1


$projectName = "dice_ui"

{ . ../deps/polyglot/apps/spiral/dist/Supervisor$(_exe) --build-file "src/$projectName.spi" "src/$projectName.fsx" --timeout 40000 } | Invoke-Block

(Get-Content "src/$projectName.fsx") `
    -replace "and Heap2 =", "and  Heap2 =" `
| Set-Content "src/$projectName.fsx"

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("src/$projectName.fsx", "--persist-only", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../deps/polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" "WASM" } | Invoke-Block

$path = "$targetDir/target/rs/$projectName.rs"
if (!(Test-Path $path)) {
    $path = "$targetDir/target/rs/polyglot/target/Builder/$projectName/$projectName.rs"
}
Write-Output "dice/ui/build.ps1 / path: $path"
(Get-Content $path) `
    -replace "`"../../../../../../../../../../../../polyglot", "`"../../deps/polyglot" `
    -replace "`"../../../lib", "`"../../deps/polyglot/lib" `
    -replace "`"../../../../../lib", "`"../../deps/polyglot/lib" `
    -replace "`"./lib", "`"../../deps/polyglot/lib" `
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
    | FixRust `
| Set-Content "src/$($projectName)_wasm.rs"

# -replace "pub struct Heap0 {", "#[derive(serde::Serialize)] pub struct Heap0 {" `
# -replace "pub struct Heap1 {", "#[derive(serde::Serialize, serde::Deserialize)] pub struct Heap1 {" `
# -replace "pub struct Heap2 {", "#[derive(serde::Serialize)] pub struct Heap2 {" `
# -replace "pub struct Heap3 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize)] pub struct Heap3 {" `
# -replace "pub struct Heap4 {", "#[derive(serde::Serialize, serde::Deserialize, borsh::BorshSerialize, borsh::BorshDeserialize)] pub struct Heap4 {" `

cargo fmt --
leptosfmt (ResolveLink (GetFullPath "./src/$($projectName)_wasm.rs"))

if (!$fast) {
    Remove-Item $targetDir/trunk -Recurse -Force -ErrorAction Ignore
    Remove-Item ./dist -Recurse -Force -ErrorAction Ignore

    { ~/.bun/bin/bun install --frozen-lockfile } | Invoke-Block
}

{ ~/.bun/bin/bun --bun build-css } | Invoke-Block

Write-Output "trunk:"

{ trunk build $($fast ? $() : '--release') --dist="$targetDir/trunk" --public-url="./" --no-sri } | Invoke-Block -EnvironmentVariables @{ "TRUNK_TOOLS_WASM_BINDGEN" = "0.2.93" }
# { cargo leptos build --release } | Invoke-Block

$path = "$targetDir/trunk/index.html"
$html = Get-Content $path -Raw

$wasmFile = ($html | Select-String -Pattern "init\('\./(.*?)'\);").Matches[0].Groups[1].Value
$jsFile = ($html | Select-String -Pattern "import init, \* as bindings from '\./(.*?)';").Matches[0].Groups[1].Value

(Get-Content "$targetDir/trunk/$jsFile" -Raw) `
    -replace "\('.*', import.meta.url\);", "('$wasmFile', import.meta.url);" `
| Set-Content "$targetDir/trunk/$jsFile"

Write-Output "rna:"
{ ~/.bun/bin/bunx --bun @chialab/rna build --bundle --minify --assetNames "[name]" $path --output dist --target es2022 } | Invoke-Block

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
