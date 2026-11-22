$G = 'D:\Steam\steamapps\common\TheLongDark'
$S = 'D:\Github\tld--2.55\_work\release\staging\ultimate'
$xf = @('*.backup*', '*.bak*', '*.broken-*', '*.before-*', '*.ctorfail-*', '*.disabled', '*.log', 'NorthernLightsBroadcast_ResumeAtFrame.ini', 'Latest.log')
foreach ($d in 'Mods', 'MelonLoader', 'UserData', 'UserLibs', 'Plugins') {
    $extraF = @()
    if ($d -eq 'Mods') { $extraF = @('*.pdb') }
    $xd = @("$G\Mods\_disabled", "$G\Mods\ModData", "$G\Mods\FeatSettings", "$G\MelonLoader\Logs", '_quarantine')
    robocopy "$G\$d" "$S\$d" /MIR /NFL /NDL /NJH /NP /R:1 /W:1 /XD @xd /XF @($xf + $extraF) | Select-String -Pattern 'Files :|Dirs :|ERROR'
    "$d exit=$LASTEXITCODE"
}
Copy-Item "$G\winhttp.dll" "$S\winhttp.dll" -Force
$left = Get-ChildItem $S -Recurse -File | Where-Object { $_.Name -like '*.log' -or $_.Name -like '*.backup*' -or $_.Name -like '*.bak*' -or ($_.FullName -like "$S\Mods\*" -and $_.Extension -eq '.pdb') }
"stray: $($left.Count)"
$left | ForEach-Object { $_.FullName; Remove-Item $_.FullName -Force }
