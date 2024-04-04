param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1
. ../../polyglot/lib/spiral/lib.ps1


if (!$fast) {
    { . ../../polyglot/apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../polyglot/scripts/invoke-dib.ps1 dice_fsharp.dib`"" } | Invoke-Block -Retries 5
}

{ . ../../polyglot/apps/parser/dist/DibParser$(GetExecutableSuffix) dice_fsharp.dib fs } | Invoke-Block

{ . ../../polyglot/apps/builder/dist/Builder$(GetExecutableSuffix) dice_fsharp.fs $($fast ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Fable.Core --modules lib/spiral/common.fsx lib/spiral/sm.fsx lib/spiral/date_time.fsx lib/spiral/file_system.fsx lib/spiral/lib.fsx lib/fsharp/Common.fs } | Invoke-Block

$targetDir = "../../polyglot/target/polyglot/builder/dice_fsharp"

function Build {
    param (
        [Parameter(Mandatory)]
        [string] $Language,
        [string] $Runtime
    )
    dotnet fable $targetDir/dice_fsharp.fsproj --optimize --lang $Language --extension ".$Language" --outDir $targetDir/target/$Language $($Runtime ? @("--define", $Runtime) : @())
}

{ Build "rs" } | Invoke-Block
if (!$fast) {
    
    { Build "ts" } | Invoke-Block
    { Build "py" } | Invoke-Block
    { Build "php" } | Invoke-Block -OnError Continue
    { Build "dart" } | Invoke-Block -OnError Continue
}

(Get-Content $targetDir/target/rs/dice_fsharp.rs) `
    -replace "../../../../lib", "../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | Set-Content dice_fsharp.rs
if (!$fast) {
    Copy-Item $targetDir/target/ts/dice_fsharp.ts dice_fsharp.ts -Force
    Copy-Item $targetDir/target/py/dice_fsharp.py dice_fsharp.py -Force
    Copy-Item $targetDir/target/php/dice_fsharp.php dice_fsharp.php -Force
    Copy-Item $targetDir/target/dart/dice_fsharp.dart dice_fsharp.dart -Force
}

{ Build "rs" "WASM" } | Invoke-Block
if (!$fast) {
    
    { Build "ts" "WASM" } | Invoke-Block
    { Build "py" "WASM" } | Invoke-Block
    { Build "php" "WASM" } | Invoke-Block -OnError Continue
    { Build "dart" "WASM" } | Invoke-Block -OnError Continue
}
CopyTarget $targetDir ../../polyglot "rs" "wasm"
if (!$fast) {
    CopyTarget $targetDir ../../polyglot "ts" "wasm"
    CopyTarget $targetDir ../../polyglot "py" "wasm"
    CopyTarget $targetDir ../../polyglot "php" "wasm"
    CopyTarget $targetDir ../../polyglot "dart" "wasm"
}

(Get-Content $targetDir/target/rs/dice_fsharp.rs) `
    -replace "../../../../lib", "../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    -replace ".rs`"]", "_wasm.rs`"]" `
    | Set-Content dice_fsharp_wasm.rs

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
