param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1
. ../deps/polyglot/deps/spiral/lib/spiral/lib.ps1


$projectName = "dice_ui"


$targetDir = GetTargetDir $projectName

# Rust (wasm32): the src/dice_ui.spi entry (its `main` runs `run_main`; dice_ui is native Rust only) -> src/main.rs
# (tracked) with the Spiral compiler's own Rust backend: the `dice_ui_bin` bin of the `ui` workspace member (Cargo.toml),
# next to the hand-written near model types (src/model.rs, src/model/). `cargo check --target wasm32-unknown-unknown` and,
# after the css step below, a trunk bundle of it are required: a failure stops the build. The bundle is the shipped one:
# dist/ (popup.html, the extension) is bundled from $targetDir/trunk.
if (!(BuildSpiral "src/$projectName.spi" "src/main.rs" "dice/ui")) {
    throw "RUST-FAILED dice/ui / compile"
}
# serde/borsh/Debug derives on the generated types, and the model module.
. ./rust_derive.ps1
$rustMain = (Resolve-Path "src/main.rs").Path
[IO.File]::WriteAllText($rustMain, (Add-RustDerives ([IO.File]::ReadAllText($rustMain))) + "`npub mod model;`n")
$rustCheck = & { cargo check -p $projectName --bin "$($projectName)_bin" --target wasm32-unknown-unknown --message-format short 2>&1 | ForEach-Object { "$_" } }
if ($LASTEXITCODE -ne 0) {
    $rustErrors = @($rustCheck | Where-Object { $_ -match ': error' })
    $rustErrors | Select-Object -First 20 | ForEach-Object { Write-Output "dice/ui/build.ps1 / cargo check / $_" }
    throw "RUST-FAILED dice/ui / cargo check exit code $LASTEXITCODE, $($rustErrors.Count) errors"
}
Write-Output "dice/ui/build.ps1 / cargo check ok"

if (!$fast) {
    Remove-Item $targetDir/trunk -Recurse -Force -ErrorAction Ignore
    Remove-Item ./dist -Recurse -Force -ErrorAction Ignore

    { . $(Search-Command bun) install --frozen-lockfile } | Invoke-Block
}

{ . $(Search-Command bun) --bun build-css } | Invoke-Block

# Rust wasm bundle: trunk builds the bin checked above (index.html names it) into $targetDir/trunk. The
# wasm-bindgen CLI must be the version in the workspace lock (read from it, not pinned).
$rustBindgen = [regex]::Match((Get-Content ../Cargo.lock -Raw), '(?m)^name = "wasm-bindgen"\r?\nversion = "([^"]+)"').Groups[1].Value
if (!$rustBindgen) { throw "RUST-FAILED dice/ui / no wasm-bindgen version in ../Cargo.lock" }
$trunkDir = "$targetDir/trunk"
Remove-Item $trunkDir -Recurse -Force -ErrorAction Ignore
{ trunk build $($fast ? $() : '--release') $($fast ? $() : '--minify') --dist="$trunkDir" --public-url="./" --no-sri } `
    | Invoke-Block -EnvironmentVariables @{ "TRUNK_TOOLS_WASM_BINDGEN" = $rustBindgen }
$rustWasm = Get-ChildItem $trunkDir -Filter "$projectName-*_bg.wasm" -ErrorAction Ignore | Select-Object -First 1
if (!$rustWasm -or !(Test-Path "$trunkDir/index.html")) {
    throw "RUST-FAILED dice/ui / trunk bundle: no $projectName wasm in $trunkDir"
}
Write-Output "RUST-OK dice/ui / $($rustWasm.Name) $($rustWasm.Length) B (wasm-bindgen $rustBindgen)"

$path = "$trunkDir/index.html"
$html = Get-Content $path -Raw

# wasm-bindgen >= 0.2.94 writes `init({ module_or_path: './x_bg.wasm' })`, older ones `init('./x_bg.wasm')`
$wasmFile = ($html | Select-String -Pattern "init\((?:\{\s*module_or_path:\s*)?'\./(.*?)'\s*\}?\);").Matches[0].Groups[1].Value
$jsFile = ($html | Select-String -Pattern "import init, \* as bindings from '\./(.*?)';").Matches[0].Groups[1].Value
if (!$wasmFile -or !$jsFile) { throw "RUST-FAILED dice/ui / no init wasm or bindings js in $path" }

(Get-Content "$trunkDir/$jsFile" -Raw) `
    -replace "\('.*', import.meta.url\);", "('$wasmFile', import.meta.url);" `
| Set-Content "$trunkDir/$jsFile"

Write-Output "rna:"
{ . $(Search-Command bunx) --bun @chialab/rna build --bundle --minify --assetNames "[name]" $path --output dist --target es2022 } | Invoke-Block

$path = "dist/index.html"

Move-Item $path dist/popup.html -Force
Copy-Item dist/popup.html dist/index.html -Force
Copy-Item public/manifest.json dist/manifest.json -Force

if (!$fast) {
    { . $(Search-Command bun) install --frozen-lockfile } | Invoke-Block -Location e2e
    { . $(Search-Command bun) test:e2e } | Invoke-Block -Location e2e
}

Write-Output "dice/ui/build.ps1 / `$targetDir = $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore

    Remove-Item node_modules -Recurse -Force -ErrorAction Ignore

    ClearCargoTarget "../.."
}
