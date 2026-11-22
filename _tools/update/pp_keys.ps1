$root='D:\Steam\steamapps\common\TheLongDark'
foreach ($d in 'AsmResolver.dll','AsmResolver.PE.File.dll','AsmResolver.PE.dll','AsmResolver.DotNet.dll') { Add-Type -Path (Join-Path "$root\MelonLoader\net6" $d) | Out-Null }
$p = 'C:\Users\82077\AppData\Local\Temp\tlddiff\pp_zh\PerfectPlacement.dll'
$m = [AsmResolver.DotNet.ModuleDefinition]::FromFile($p)
$t = $m.TopLevelTypes | Where-Object { $_.FullName.ToString() -eq 'PerfectPlacement.Settings' }
$ctor = $t.Methods | Where-Object { $_.Name.ToString() -eq '.ctor' -and $_.Parameters.Count -eq 0 }
$ins = $ctor.CilMethodBody.Instructions
$want = @{ 'keyTakeOnTop' = 288; 'keyTurnEach' = 292 }
$done = @()
for ($i = 1; $i -lt $ins.Count; $i++) {
  if ($ins[$i].OpCode.Code.ToString() -eq 'Stfld') {
    $f = $ins[$i].Operand.Name.ToString()
    if ($want.ContainsKey($f)) {
      $prev = $ins[$i-1]
      $done += ($f + ' was ' + $prev.GetLdcI4Constant())
      $prev.OpCode = [AsmResolver.PE.DotNet.Cil.CilOpCodes]::Ldc_I4
      $prev.Operand = [int]$want[$f]
    }
  }
}
$m.Write($p + '.new')
Write-Output ($done -join '; ')
