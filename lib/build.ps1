param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1
. ../../polyglot/lib/spiral/lib.ps1


if (!$fast) {
    { . ../../polyglot/apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../polyglot/scripts/invoke-dib.ps1 dice.dib`"" } | Invoke-Block -Retries 5
}

{ . ../../polyglot/apps/parser/dist/DibParser$(GetExecutableSuffix) dice.dib spi } | Invoke-Block

{ . ../../polyglot/apps/spiral/dist/Supervisor$(GetExecutableSuffix) --build-file dice.spi dice.fsx --timeout 60000 } | Invoke-Block

{ . ../../polyglot/apps/builder/dist/Builder$(GetExecutableSuffix) dice.fsx $($fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Fable.Core --modules lib/spiral/common.fsx lib/spiral/sm.fsx lib/spiral/date_time.fsx lib/spiral/file_system.fsx lib/spiral/lib.fsx lib/fsharp/Common.fs } | Invoke-Block

$targetDir = "../../polyglot/target/polyglot/builder/dice"

function Build {
    param (
        [Parameter(Mandatory)]
        [string] $Language,
        [string] $Runtime
    )
    dotnet fable $targetDir/dice.fsproj --optimize --lang $Language --extension ".$Language" --outDir $targetDir/target/$Language $($Runtime ? @("--define", $Runtime) : @())
}

{ Build "rs" } | Invoke-Block
{ Build "ts" } | Invoke-Block
if (!$fast) {
    { Build "py" } | Invoke-Block
    { Build "php" } | Invoke-Block -OnError Continue
    { Build "dart" } | Invoke-Block -OnError Continue
}
CopyTarget $targetDir ../../polyglot "rs"
CopyTarget $targetDir ../../polyglot "ts"
if (!$fast) {
    CopyTarget $targetDir ../../polyglot "py"
    CopyTarget $targetDir ../../polyglot "php"
    CopyTarget $targetDir ../../polyglot "dart"
}
(Get-Content $targetDir/target/rs/dice.rs) `
    -replace "../../../../lib", "../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | Set-Content dice.rs
if (!$fast) {
    Copy-Item $targetDir/target/ts/dice.ts dice.ts -Force
    Copy-Item $targetDir/target/py/dice.py dice.py -Force
    Copy-Item $targetDir/target/php/dice.php dice.php -Force
    Copy-Item $targetDir/target/dart/dice.dart dice.dart -Force
}

{ Build "rs" "CONTRACT" } | Invoke-Block
{ Build "ts" "CONTRACT" } | Invoke-Block
if (!$fast) {
    
    { Build "py" "CONTRACT" } | Invoke-Block
    { Build "php" "CONTRACT" } | Invoke-Block -OnError Continue
    { Build "dart" "CONTRACT" } | Invoke-Block -OnError Continue
}
CopyTarget $targetDir ../../polyglot "rs" "contract"
CopyTarget $targetDir ../../polyglot "ts" "contract"
if (!$fast) {
    CopyTarget $targetDir ../../polyglot "py" "contract"
    CopyTarget $targetDir ../../polyglot "php" "contract"
    CopyTarget $targetDir ../../polyglot "dart" "contract"
}
(Get-Content $targetDir/target/rs/dice.rs) `
    -replace "../../../../lib", "../../polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    -replace ".rs`"]", "_contract.rs`"]" `
    | Set-Content dice_contract.rs

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
