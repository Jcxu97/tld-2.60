# 对比 TLD 2.55(沙盒) 与 2.24(剧情/wintermute) 的 Assembly-CSharp dummy dll,
# 判断 TldHacks 的 Harmony patch 目标在 2.24 里还存不存在。
# dummy dll 无方法体，只读元数据，用 MelonLoader 自带的 AsmResolver。
$ErrorActionPreference = 'Stop'

$ml   = 'D:\Steam\steamapps\common\TheLongDark\MelonLoader\net6'
$gen  = '\MelonLoader\Dependencies\Il2CppAssemblyGenerator\Cpp2IL\cpp2il_out\Assembly-CSharp.dll'
$root = 'D:\Steam\steamapps\common\TheLongDark'
$a255 = $root + $gen
$a224 = $root + '\tld_dlc\wintermute' + $gen

foreach ($d in 'AsmResolver.dll','AsmResolver.PE.File.dll','AsmResolver.PE.dll','AsmResolver.DotNet.dll') {
    Add-Type -Path (Join-Path $ml $d) | Out-Null
}

# Cpp2IL 输出的 dummy dll 里字符串堆是 UTF-16，AsmResolver 按单字节读，
# 高位字节 0x00 被当成 U+0020，于是 "CougarManager" 读成 "C o u g a r M a n a g e r"。
# 标识符本身不含空格，整串剥掉空格即还原真名。
function Clean([string]$s) { $s -replace ' ', '' }

function Read-Api($path) {
    $mod = [AsmResolver.DotNet.ModuleDefinition]::FromFile($path)
    $api = @{}
    $all = [System.Collections.Generic.List[object]]::new()
    function Walk($t) { $all.Add($t); foreach ($n in $t.NestedTypes) { Walk $n } }
    foreach ($t in $mod.TopLevelTypes) { Walk $t }
    foreach ($t in $all) {
        if (-not $t.Name) { continue }
        $methods = @{}
        foreach ($m in $t.Methods) {
            # 存成 "arity,arity" 字符串，避开 PS hashtable 取值时把 List 变成定长数组
            $n = Clean $m.Name
            $c = [string]$m.Parameters.Count
            if ($methods.ContainsKey($n)) { $methods[$n] = $methods[$n] + ',' + $c }
            else { $methods[$n] = $c }
        }
        $ns = Clean $t.Namespace
        $full = if ($ns) { "$ns." + (Clean $t.Name) } else { Clean $t.Name }
        $api[$full] = $methods
    }
    $api
}

Write-Host "reading 2.55 ..." -NoNewline
$A = Read-Api $a255; Write-Host " $($A.Count) types"
Write-Host "reading 2.24 ..." -NoNewline
$B = Read-Api $a224; Write-Host " $($B.Count) types"

# 短名索引：dummy dll 的命名空间和源码里的 Il2Cpp* 前缀不一致，按短名匹配
function Index-Short($api) {
    $idx = @{}
    foreach ($full in $api.Keys) {
        $short = ($full -split '\.')[-1]
        if (-not $idx.ContainsKey($short)) { $idx[$short] = [System.Collections.Generic.List[string]]::new() }
        $idx[$short].Add($full)
    }
    $idx
}
$iA = Index-Short $A; $iB = Index-Short $B

# 从源码刨 patch 目标: typeof(X), "Method"
$src = Get-ChildItem 'D:\Github\tld--2.55\TldHacks\src' -Filter *.cs -Recurse |
       Where-Object { $_.FullName -notmatch '\\(obj|bin)\\' }
$targets = [System.Collections.Generic.HashSet[string]]::new()
$rx = [regex]'typeof\(\s*([\w\.]+)\s*\)\s*,\s*"([^"]+)"'
foreach ($f in $src) {
    $txt = Get-Content $f.FullName -Raw
    foreach ($m in $rx.Matches($txt)) {
        $ty = ($m.Groups[1].Value -split '\.')[-1]
        [void]$targets.Add("$ty|$($m.Groups[2].Value)")
    }
}
Write-Host "`n源码提取 patch 目标: $($targets.Count)"

$missType = @(); $missMethod = @(); $arity = @(); $ok = 0
$notGameType = 0; $notAMethod = 0
foreach ($t in ($targets | Sort-Object)) {
    $ty, $me = $t -split '\|', 2
    if (-not $iA.ContainsKey($ty)) { $notGameType++; continue }  # 非 Assembly-CSharp 类型
    $mA = $A[$iA[$ty][0]]
    # 第二个字符串参数不一定是方法名(可能是字段/属性/loc key)，2.55 里都不是方法就不算 patch 目标
    if (-not $mA.ContainsKey($me)) { $notAMethod++; continue }
    if (-not $iB.ContainsKey($ty)) { $missType += "$ty.$me"; continue }
    $mB = $B[$iB[$ty][0]]
    if (-not $mB.ContainsKey($me)) { $missMethod += "$ty.$me"; continue }
    $pa = (($mA[$me] -split ',') | Sort-Object) -join ','
    $pb = (($mB[$me] -split ',') | Sort-Object) -join ','
    if ($pa -ne $pb) { $arity += "$ty.$me  2.55=[$pa] 2.24=[$pb]"; continue }
    $ok++
}

Write-Host "`n=== 类型在 2.24 不存在: $($missType.Count) ==="
$missType | ForEach-Object { "  $_" }
Write-Host "`n=== 类型在但方法没了: $($missMethod.Count) ==="
$missMethod | ForEach-Object { "  $_" }
Write-Host "`n=== 参数个数变了: $($arity.Count) ==="
$arity | ForEach-Object { "  $_" }
Write-Host "`n=== 兼容: $ok ==="
Write-Host "(跳过: 非游戏类型 $notGameType, 第二参数非方法名 $notAMethod)"

$broken = $missType.Count + $missMethod.Count + $arity.Count
$total = $broken + $ok
if ($total -gt 0) {
    $pct = [math]::Round($broken / $total * 100)
    Write-Host "`n判定: $broken/$total 个 patch 目标在 2.24 对不上 ($pct%)"
}

# 顺带给出整体类型层面的差异规模
$only255 = @($A.Keys | Where-Object { -not $B.ContainsKey($_) })
$only224 = @($B.Keys | Where-Object { -not $A.ContainsKey($_) })
Write-Host "整体: 仅2.55有 $($only255.Count) 类型, 仅2.24有 $($only224.Count) 类型"
