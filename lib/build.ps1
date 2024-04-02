param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../polyglot/scripts/core.ps1


if (!$fast) {
    { . ../../polyglot/apps/spiral/dist/Supervisor$(GetExecutableSuffix) --execute-command "pwsh -c `"../../polyglot/scripts/invoke-dib.ps1 dice.dib`"" } | Invoke-Block -Retries 5
}

{ . ../../polyglot/apps/parser/dist/DibParser$(GetExecutableSuffix) dice.dib spi } | Invoke-Block

{ . ../../polyglot/apps/spiral/dist/Supervisor$(GetExecutableSuffix) --build-file dice.spi dice.fsx --timeout 60000 } | Invoke-Block

{ . ../../polyglot/apps/builder/dist/Builder$(GetExecutableSuffix) dice.fsx $($fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()) --packages Fable.Core --modules lib/spiral/common.fsx lib/spiral/sm.fsx lib/spiral/date_time.fsx lib/spiral/file_system.fsx lib/spiral/lib.fsx lib/fsharp/Common.fs } | Invoke-Block

$targetDir = "../../polyglot/target/polyglot/builder/dice"

{ dotnet fable $targetDir/dice.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/rs } | Invoke-Block

if (!$fast) {
    { dotnet fable $targetDir/dice.fsproj --optimize --lang ts --extension .ts --outDir $targetDir/ts } | Invoke-Block

    { dotnet fable $targetDir/dice.fsproj --optimize --lang py --extension .py --outDir $targetDir/py } | Invoke-Block

    { dotnet fable $targetDir/dice.fsproj --optimize --lang php --extension .php --outDir $targetDir/php } | Invoke-Block -OnError Continue
    { dotnet fable $targetDir/dice.fsproj --optimize --lang dart --extension .dart --outDir $targetDir/dart } | Invoke-Block -OnError Continue
}

Copy-Item $targetDir/rs/lib/fsharp/Common.rs ../../polyglot/lib/fsharp/Common.rs -Force
Copy-Item $targetDir/rs/lib/spiral/common.rs ../../polyglot/lib/spiral/common.rs -Force
Copy-Item $targetDir/rs/lib/spiral/sm.rs ../../polyglot/lib/spiral/sm.rs -Force
Copy-Item $targetDir/rs/lib/spiral/date_time.rs ../../polyglot/lib/spiral/date_time.rs -Force
Copy-Item $targetDir/rs/lib/spiral/file_system.rs ../../polyglot/lib/spiral/file_system.rs -Force
Copy-Item $targetDir/rs/lib/spiral/lib.rs ../../polyglot/lib/spiral/lib.rs -Force
if (!$fast) {
    Copy-Item $targetDir/ts/lib/fsharp/Common.ts ../../polyglot/lib/fsharp/Common.ts -Force
    Copy-Item $targetDir/py/lib/fsharp/common.py ../../polyglot/lib/fsharp/common.py -Force
    Copy-Item $targetDir/php/lib/fsharp/Common.php ../../polyglot/lib/fsharp/Common.php -Force
    Copy-Item $targetDir/dart/lib/fsharp/Common.dart ../../polyglot/lib/fsharp/Common.dart -Force
}

(Get-Content $targetDir/rs/dice.rs) `
    -replace "../../../lib/fsharp", "../polyglot/lib/fsharp" `
    -replace "../../../lib/spiral", "../polyglot/lib/spiral" `
    -replace ".fsx`"]", ".rs`"]" `
    | Set-Content dice.rs
if (!$fast) {
    Copy-Item $targetDir/ts/dice.ts dice.ts -Force
    Copy-Item $targetDir/py/dice.py dice.py -Force
    Copy-Item $targetDir/php/dice.php dice.php -Force
    Copy-Item $targetDir/dart/dice.dart dice.dart -Force
}

{ dotnet fable $targetDir/dice.fsproj --optimize --lang rs --extension .rs --outDir $targetDir/rs --define WASM } | Invoke-Block

Copy-Item $targetDir/rs/lib/fsharp/Common.rs ../../polyglot/lib/fsharp/CommonWasm.rs -Force

(Get-Content $targetDir/rs/dice.rs) `
    -replace "../../../lib/fsharp", "../polyglot/lib/fsharp" `
    -replace "../../../lib/spiral", "../polyglot/lib/spiral" `
    -replace "/Common.rs", "/CommonWasm.rs" `
    -replace ".fsx`"]", ".rs`"]" `
    -replace "date_time.rs`"]", "date_time_wasm.rs`"]" `
    | Set-Content dice_wasm.rs

cargo fmt --

if (!$fast) {
    { cargo run --release } | Invoke-Block
}

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
