$old = 'D:\Steam\steamapps\common\TheLongDark\MelonLoader\Dependencies\Il2CppAssemblyGenerator\Cpp2IL\cpp2il_out'
$new = Join-Path $env:TEMP 'tldnew_dump'
$d = Join-Path $env:TEMP 'tlddiff'
$names = (Get-ChildItem $new -Filter *.dll | Where-Object { $_.Name -match '^(Assembly-CSharp|TLD\.)' }).BaseName
foreach ($a in $names) {
  $o = Join-Path $old "$a.dll"; if (-not (Test-Path $o)) { "$a NEW ASSEMBLY"; continue }
  & pwsh -NoProfile -File "$PSScriptRoot\dump.ps1" $o "$d\$a.old.txt"
  & pwsh -NoProfile -File "$PSScriptRoot\dump.ps1" (Join-Path $new "$a.dll") "$d\$a.new.txt"
}
$names
