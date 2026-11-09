# V12.6 ultimate repack 2026-11-09 (DoubleBarrelLoadFix). Run: python kb126b.py <ultimate volume count>
import os, sys

F = r'C:\Users\82077\Desktop\TLD\files'
N = sys.argv[1]


def edit(name, pairs):
    p = os.path.join(F, name)
    raw = open(p, 'rb').read()
    bom = raw.startswith(b'\xef\xbb\xbf')
    s = raw.decode('utf-8-sig')
    for a, b in pairs:
        assert s.count(a) == 1, (name, a, s.count(a))
        s = s.replace(a, b)
    open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))


OLD08 = ('终极版开新档出生在沿海公路（海岸公路），读条到一半卡死不动，日志里没有报错，是终极版带的沿海公路巡航船（`Mods\\CoastalFulmar.dll`）引起的，'
         '11 月 7 日群友实测删掉就好。从主菜单继续一个停在沿海公路的存档也可能这样卡。删掉这个 dll 就行，存档不受影响，代价是沿海公路没有那艘船。'
         '完整版和最小包不带它，不会遇到。')
NEW08 = ('终极版进沿海公路（海岸公路）或荒凉水湾读条到一半卡死不动，开新档和读档都会，日志里没有报错，最后一行是 '
         '`Processed 3 items for loottabletideline(RadialSpawner)`。原因是终极版带的双管霰弹枪（DoubleBarrel）在加载中途重新筛海滩的掉落表，'
         '和游戏加载互相等，卡死了。11 月 9 日重传的 V12.6 终极版加了 `Mods\\DoubleBarrelLoadFix.dll` 修好了，重新下终极版整包装一遍就行，存档不受影响。'
         '之前说删 CoastalFulmar.dll（沿海公路巡航船）是判断错了，它不是原因，删了的重装终极版就回来了。完整版和最小包不带双管霰弹枪，不会遇到。')

edit('08_故障排查.md', [(OLD08, NEW08)])

edit('07_整合模组清单.md', [
    ('| DoubleBarrel | 双管霰弹枪 |\n',
     '| DoubleBarrel | 双管霰弹枪 |\n'
     '| DoubleBarrelLoadFix | 修双管霰弹枪进沿海公路、荒凉水湾时卡在读条（11 月 9 日重传的 V12.6 终极版带）。没有设置项 |\n'),
])

edit('01_下载与版本.md', [
    ('终极版在网盘 2_ 开头的文件夹里，182 个分卷', f'终极版在网盘 2_ 开头的文件夹里，{N} 个分卷'),
    ('终极版材质包备份.001 到 .182 和 终极版_安装说明.txt | V12.6 终极版分卷，每个 20MB | 182 个全',
     f'终极版材质包备份.001 到 .{N} 和 终极版_安装说明.txt | V12.6 终极版分卷，每个 20MB（11 月 9 日重传，修了沿海地图卡读条） | {N} 个全'),
])

edit('10_版本历史.md', [
    ('## 沙盒版 V12.6（2026-11-08，当前版本）\n\n',
     '## 沙盒版 V12.6（2026-11-08，当前版本）\n\n'
     '11 月 9 日重传了终极版，加了 DoubleBarrelLoadFix，修好终极版进沿海公路、荒凉水湾卡在读条。完整版和最小包没变。\n\n'),
])
print('ok')
