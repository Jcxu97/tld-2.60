$root = 'D:\Steam\steamapps\common\TheLongDark'
$ml = "$root\MelonLoader\net6"
foreach ($d in 'AsmResolver.dll','AsmResolver.PE.File.dll','AsmResolver.PE.dll','AsmResolver.DotNet.dll') { Add-Type -Path (Join-Path $ml $d) | Out-Null }
$interop = "$root\MelonLoader\Il2CppAssemblies"

$asmNames = @{}
$types = @{}
$members = @{}
$loose = @{}
function Walk($t, $asm) {
  $key = "$asm|$($t.FullName)"
  $types[$key] = 1
  foreach ($m in $t.Methods) {
    $members["$asm|$($m.FullName)"] = 1
    $loose["$key|$($m.Name)|$($m.Parameters.Count)"] = 1
  }
  foreach ($f in $t.Fields) { $members["$asm|$($f.FullName)"] = 1; $loose["$key|$($f.Name)|f"] = 1 }
  foreach ($n in $t.NestedTypes) { Walk $n $asm }
}
foreach ($f in Get-ChildItem $interop -Filter *.dll) {
  $mod = [AsmResolver.DotNet.ModuleDefinition]::FromFile($f.FullName)
  $an = $mod.Assembly.Name
  $asmNames[[string]$an] = 1
  foreach ($t in $mod.TopLevelTypes) { Walk $t $an }
}

function ScopeAsm($tr) {
  $s = $tr.Scope
  while ($s -is [AsmResolver.DotNet.TypeReference]) { $s = $s.Scope }
  if ($s -is [AsmResolver.DotNet.AssemblyReference]) { return [string]$s.Name }
  return $null
}

$report = [System.Collections.Generic.List[string]]::new()
foreach ($f in Get-ChildItem "C:\Users\82077\AppData\Local\Temp\tlddiff\tmzip\Mods" -Filter *.dll) {
  try { $mod = [AsmResolver.DotNet.ModuleDefinition]::FromFile($f.FullName) } catch { $report.Add("$($f.Name)`tLOADFAIL`t$($_.Exception.Message)"); continue }
  $bad = [System.Collections.Generic.HashSet[string]]::new()
  foreach ($tr in $mod.GetImportedTypeReferences()) {
    $a = ScopeAsm $tr
    if (-not $a -or -not $asmNames.ContainsKey($a)) { continue }
    if (-not $types.ContainsKey("$a|$($tr.FullName)")) { [void]$bad.Add("TYPE $($tr.FullName)") }
  }
  foreach ($mr in $mod.GetImportedMemberReferences()) {
    $p = $mr.Parent
    $generic = $false
    if ($p -is [AsmResolver.DotNet.TypeSpecification]) { $p = $p.Signature.GetUnderlyingTypeDefOrRef(); $generic = $true }
    if (-not $mr.IsField -and $mr.Signature.GenericParameterCount -gt 0) { $generic = $true }
    if (-not ($p -is [AsmResolver.DotNet.TypeReference])) { continue }
    $a = ScopeAsm $p
    if (-not $a -or -not $asmNames.ContainsKey($a)) { continue }
    $tkey = "$a|$($p.FullName)"
    if (-not $types.ContainsKey($tkey)) { [void]$bad.Add("TYPE $($p.FullName)"); continue }
    if ($mr.IsField) { $lk = "$tkey|$($mr.Name)|f" } else { $lk = "$tkey|$($mr.Name)|$($mr.Signature.ParameterTypes.Count)" }
    if ($generic) { if (-not $loose.ContainsKey($lk)) { [void]$bad.Add("MEMBER $($mr.FullName)") }; continue }
    if (-not $members.ContainsKey("$a|$($mr.FullName)")) {
      if ($loose.ContainsKey($lk)) { [void]$bad.Add("SIG $($mr.FullName)") } else { [void]$bad.Add("MEMBER $($mr.FullName)") }
    }
  }
  foreach ($b in $bad) { $report.Add("$($f.Name)`t$b") }
}
$report | Set-Content -Encoding utf8 (Join-Path $env:TEMP 'tlddiff\modscan.tsv')
"done $($report.Count)"
