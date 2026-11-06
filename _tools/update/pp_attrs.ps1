# 用法: pwsh pp_attrs.ps1 <输入 PerfectPlacement.dll> <输出 PerfectPlacement.dll>
# 2.60 起设置页标签由游戏原生 UILocalize 取文字,绕过了 PerfectPlacement 给 Localization.Get 打的补丁,
# 标签全显示成模板行的 "INDOOR SPAWNS PERMITTED"。这里把设置特性上的 PERFECTPLACEMENT_ 键直接换成中文并关掉 Localize
param([string]$src, [string]$dst)
$root = 'D:\Steam\steamapps\common\TheLongDark'
foreach ($d in 'AsmResolver.dll','AsmResolver.PE.File.dll','AsmResolver.PE.dll','AsmResolver.DotNet.dll') { Add-Type -Path (Join-Path "$root\MelonLoader\net6" $d) | Out-Null }
$zh = Get-Content -Raw -Encoding utf8 (Join-Path $PSScriptRoot 'pp_zh.json') | ConvertFrom-Json -AsHashtable
$prefix = 'PERFECTPLACEMENT_'
$m = [AsmResolver.DotNet.ModuleDefinition]::FromFile($src)
$n = 0; $miss = @()
foreach ($t in $m.GetAllTypes()) {
  foreach ($f in $t.Fields) {
    foreach ($ca in $f.CustomAttributes) {
      $an = $ca.Constructor.DeclaringType.FullName.ToString()
      if ($an -notin 'ModSettings.NameAttribute','ModSettings.SectionAttribute','ModSettings.ChoiceAttribute','ModSettings.DescriptionAttribute') { continue }
      $sig = $ca.Signature
      if ($sig.FixedArguments.Count -eq 0) { continue }
      $els = $sig.FixedArguments[0].Elements
      $hit = $false
      for ($i = 0; $i -lt $els.Count; $i++) {
        $s = "$($els[$i].ToString())"
        if (-not $s.StartsWith($prefix)) { continue }
        $k = $s.Substring($prefix.Length)
        if ($zh.ContainsKey($k)) { $els[$i] = [AsmResolver.Utf8String]::new($zh[$k]); $hit = $true; $n++ } else { $miss += $k }
      }
      if ($hit) {
        foreach ($na in $sig.NamedArguments) {
          if ($na.MemberName.ToString() -eq 'Localize') { $na.Argument.Elements[0] = $false }
        }
      }
    }
  }
}
New-Item -ItemType Directory -Force (Split-Path $dst) | Out-Null
$m.Write($dst)
Write-Output ("replaced $n, missing: " + ($miss -join ','))
