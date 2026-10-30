$ml='D:\Steam\steamapps\common\TheLongDark\MelonLoader\net6'
foreach ($d in 'AsmResolver.dll','AsmResolver.PE.File.dll','AsmResolver.PE.dll','AsmResolver.DotNet.dll') { Add-Type -Path (Join-Path $ml $d) | Out-Null }
function Dump($p){ $m=[AsmResolver.DotNet.ModuleDefinition]::FromFile($p); $o=[System.Collections.Generic.List[string]]::new(); foreach($t in $m.GetAllTypes()){ foreach($x in $t.Methods){$o.Add($x.FullName)}; foreach($f in $t.Fields){$o.Add($f.FullName)} }; $o }
$b="$env:TEMP\tld_update_20261030"
foreach($a in 'Assembly-CSharp','Il2CppTLD.Platform','Il2CppTLD.OptionalContent'){
 $old=Dump "$b\interop_old\$a.dll"; $new=Dump "D:\Steam\steamapps\common\TheLongDark\MelonLoader\Il2CppAssemblies\$a.dll"
 $r=Compare-Object $old $new | % { "$($_.SideIndicator) $($_.InputObject)" }
 "== $a $($r.Count)"; $r | Select-Object -First 80
}
