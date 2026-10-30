$d = Join-Path $env:TEMP 'tlddiff'
foreach ($e in 'wintermute','episode5') {
  $old = "D:\Steam\steamapps\common\TheLongDark\tld_dlc\$e\MelonLoader\Dependencies\Il2CppAssemblyGenerator\Cpp2IL\cpp2il_out"
  $new = Join-Path $env:TEMP "tldnew_$e"
  foreach ($a in (Get-ChildItem $new -Filter *.dll | Where-Object { $_.Name -match '^(Assembly-CSharp|TLD\.)' }).BaseName) {
    $o = Join-Path $old "$a.dll"; if (-not (Test-Path $o)) { "$e $a NEW"; continue }
    & pwsh -NoProfile -File "$PSScriptRoot\dump.ps1" $o "$d\$e.$a.old.txt"
    & pwsh -NoProfile -File "$PSScriptRoot\dump.ps1" (Join-Path $new "$a.dll") "$d\$e.$a.new.txt"
  }
}
