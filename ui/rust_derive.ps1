function Add-RustDerives([string] $text) {
    $base = 'bool i8 i16 i32 i64 i128 u8 u16 u32 u64 u128 usize isize f32 f64 char std string String str rc Rc Option Vec collections HashMap BTreeMap Result' -split ' '
    $signals = 'leptos prelude ArcRwSignal RwSignal ReadSignal ArcReadSignal ArcMemo Memo' -split ' '
    $allow = [ordered]@{
        'Debug'                       = $base + $signals + ('cell RefCell WriteSignal ArcWriteSignal leptos_router location Url __reexports send_wrapper SendWrapper sync Arc' -split ' ')
        'serde::Serialize'            = $base + $signals + ('cell RefCell' -split ' ')
        'serde::Deserialize'          = $base + ('cell RefCell leptos prelude ArcRwSignal' -split ' ')
        'borsh::BorshSerialize'       = $base
        'borsh::BorshDeserialize'     = $base
    }
    $nonClone = 'Fragment AnyView View RequestBuilder Rexie Box Pin MutexGuard Command Child ChildStdin ChildStdout ChildStderr File JoinHandle' -split ' '
    $nl = if ($text.Contains("`r`n")) { "`r`n" } else { "`n" }
    $types = [ordered]@{}
    foreach ($m in [regex]::Matches($text, '(?m)^struct (?<name>Heap\d+) \{ (?<fields>.*) \}\r?$')) {
        $types[$m.Groups['name'].Value] = @{ kind = 'struct'; fields = $m.Groups['fields'].Value; derives = @() }
    }
    foreach ($m in [regex]::Matches($text, '(?ms)^#\[derive\(Clone\)\]\r?\nenum (?<name>U[SH]\d+) \{\r?\n(?<body>.*?)^\}')) {
        $types[$m.Groups['name'].Value] = @{ kind = 'enum'; fields = $m.Groups['body'].Value; derives = @('Clone') }
    }
    $idents = @{}
    foreach ($k in $types.Keys) {
        $ids = [regex]::Matches(($types[$k].fields -replace '\bl\d+:', '' -replace '\b(U[SH]\d+)_\d+\b', ''), '[A-Za-z_][A-Za-z0-9_]*') | ForEach-Object Value
        $idents[$k] = @($ids | Sort-Object -Unique)
    }
    $isGenerated = { param($id) $id -match '^(Heap|US|UH|Mut)\d+$' }
    $result = [ordered]@{}
    foreach ($k in $types.Keys) { $result[$k] = [Collections.Generic.List[string]]::new() }
    $traits = @('Clone') + @($allow.Keys)
    foreach ($trait in $traits) {
        $ok = [Collections.Generic.HashSet[string]]::new([string[]] @($types.Keys))
        $changed = $true
        while ($changed) {
            $changed = $false
            foreach ($k in @($ok)) {
                $good = $trait -eq 'Clone' -or !$types[$k].fields.Contains('&')
                foreach ($id in $idents[$k]) {
                    if (!$good) { break }
                    if (& $isGenerated $id) { if (!$ok.Contains($id)) { $good = $false; break } }
                    elseif ($trait -eq 'Clone') { if ($id -in $nonClone) { $good = $false; break } }
                    elseif ($id -in 'dyn', 'Fn', 'FnMut', 'FnOnce', 'impl') { $good = $false; break }
                    elseif ($id -notin $allow[$trait]) { $good = $false; break }
                }
                if (!$good) { [void] $ok.Remove($k); $changed = $true }
            }
        }
        foreach ($k in $ok) { $result[$k].Add($trait) }
    }
    foreach ($k in $types.Keys) {
        $derives = @($result[$k])
        if ($types[$k].kind -eq 'struct') {
            if ($derives.Count -gt 0) {
                $text = [regex]::Replace($text, "(?m)^struct $k \{", "#[derive($($derives -join ', '))]$nl" + "struct $k {")
            }
        } elseif ($derives.Count -gt 1) {
            $text = [regex]::Replace($text, "(?m)^#\[derive\(Clone\)\](\r?\nenum $k \{)", "#[derive($($derives -join ', '))]`$1")
        }
    }
    $text
}
