$root='D:\Steam\steamapps\common\TheLongDark'
foreach ($d in 'AsmResolver.dll','AsmResolver.PE.File.dll','AsmResolver.PE.dll','AsmResolver.DotNet.dll') { Add-Type -Path (Join-Path "$root\MelonLoader\net6" $d) | Out-Null }
$src = 'C:\Users\82077\AppData\Local\Temp\tlddiff\pp_fix\PerfectPlacement.dll'
$dst = 'C:\Users\82077\AppData\Local\Temp\tlddiff\pp_zh\PerfectPlacement.dll'
New-Item -ItemType Directory -Force (Split-Path $dst) | Out-Null
$zh = Get-Content -Raw -Encoding utf8 (Join-Path $PSScriptRoot 'pp_zh.json') | ConvertFrom-Json -AsHashtable
$m = [AsmResolver.DotNet.ModuleDefinition]::FromFile($src)
$t = $m.TopLevelTypes | Where-Object { $_.FullName.ToString() -eq 'PerfectPlacement.Texts' }
$cc = $t.Methods | Where-Object { $_.Name.ToString() -eq '.cctor' }
$lds = @($cc.CilMethodBody.Instructions | Where-Object { $_.OpCode.Code.ToString() -eq 'Ldstr' })
$n = 0; $miss = @()
for ($i = 0; $i + 2 -lt $lds.Count + 0; $i += 3) {
  $k = [string]$lds[$i].Operand
  if ($zh.ContainsKey($k)) { $lds[$i+2].Operand = $zh[$k]; $n++ } else { $miss += $k }
}
$main = $m.TopLevelTypes | Where-Object { $_.FullName.ToString() -eq 'PerfectPlacement.Main' }
$nm = 0
foreach ($me in $main.Methods) { if ($me.CilMethodBody) { foreach ($ins in $me.CilMethodBody.Instructions) { if ($ins.OpCode.Code.ToString() -eq 'Ldstr' -and [string]$ins.Operand -eq 'Perfect Placement') { $ins.Operand = 'Perfect Placement / 完美摆放'; $nm++ } } } }
$m.Write($dst)
Write-Output ("replaced $n, name $nm, missing: " + ($miss -join ','))
