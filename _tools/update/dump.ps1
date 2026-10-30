param($dll, $out)
$ml = 'D:\Steam\steamapps\common\TheLongDark\MelonLoader\net6'
foreach ($d in 'AsmResolver.dll','AsmResolver.PE.File.dll','AsmResolver.PE.dll','AsmResolver.DotNet.dll') { Add-Type -Path (Join-Path $ml $d) | Out-Null }
$mod = [AsmResolver.DotNet.ModuleDefinition]::FromFile($dll)
$lines = [System.Collections.Generic.List[string]]::new()
function Walk($t) {
  $tn = ($t.FullName -replace ' ', '')
  $lines.Add("T`t$tn`t$tn")
  foreach ($m in $t.Methods) { $lines.Add("M`t$tn`t" + ($m.FullName -replace ' ', '')) }
  foreach ($f in $t.Fields) { $lines.Add("F`t$tn`t" + ($f.FullName -replace ' ', '')) }
  foreach ($n in $t.NestedTypes) { Walk $n }
}
foreach ($t in $mod.TopLevelTypes) { Walk $t }
$lines | Sort-Object -Unique | Set-Content -Encoding utf8 $out
