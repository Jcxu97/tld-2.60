# Save or restore the user's clipboard around automated copy/paste. Usage: pwsh -sta -File clipguard.ps1 save|restore
param([Parameter(Mandatory)][ValidateSet('save','restore')]$Mode)
Add-Type -AssemblyName System.Windows.Forms, System.Drawing
$C = [System.Windows.Forms.Clipboard]
$dir = Join-Path $env:TEMP 'clipguard'
if ($Mode -eq 'save') {
    Remove-Item $dir -Recurse -Force -ErrorAction SilentlyContinue
    New-Item $dir -ItemType Directory | Out-Null
    if ($C::ContainsFileDropList()) { $C::GetFileDropList() | Set-Content "$dir\files.txt" -Encoding utf8 }
    if ($C::ContainsImage()) { $C::GetImage().Save("$dir\image.png", [System.Drawing.Imaging.ImageFormat]::Png) }
    if ($C::ContainsText([System.Windows.Forms.TextDataFormat]::Html)) { [IO.File]::WriteAllText("$dir\html.txt", $C::GetText([System.Windows.Forms.TextDataFormat]::Html)) }
    if ($C::ContainsText()) { [IO.File]::WriteAllText("$dir\text.txt", $C::GetText()) }
    New-Item "$dir\saved" -ItemType File | Out-Null
    exit
}
if (-not (Test-Path "$dir\saved")) { Write-Error 'no saved clipboard'; exit 1 }
$d = New-Object System.Windows.Forms.DataObject
if (Test-Path "$dir\files.txt") {
    $fl = New-Object System.Collections.Specialized.StringCollection
    Get-Content "$dir\files.txt" -Encoding utf8 | ForEach-Object { [void]$fl.Add($_) }
    $d.SetFileDropList($fl)
}
if (Test-Path "$dir\image.png") {
    $ms = New-Object IO.MemoryStream (, [IO.File]::ReadAllBytes("$dir\image.png"))
    $d.SetImage([System.Drawing.Image]::FromStream($ms))
}
if (Test-Path "$dir\html.txt") { $d.SetText([IO.File]::ReadAllText("$dir\html.txt"), [System.Windows.Forms.TextDataFormat]::Html) }
if (Test-Path "$dir\text.txt") { $d.SetText([IO.File]::ReadAllText("$dir\text.txt"), [System.Windows.Forms.TextDataFormat]::UnicodeText) }
if ($d.GetFormats().Count -eq 0) { $C::Clear() } else { $C::SetDataObject($d, $true) }
Remove-Item $dir -Recurse -Force
