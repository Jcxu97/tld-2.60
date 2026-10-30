import io, os, zipfile

DESK = r'C:\Users\82077\Desktop\TLD\零散MODS'
OLDZIP = os.path.join(DESK, 'TraderMoving-v1.0_搬运商人无线电和交易箱_解压到游戏根目录.zip')
NEWZIP = os.path.join(DESK, 'TraderMoving-v1.0.1_搬运商人无线电和交易箱_解压到游戏根目录.zip')
DLL = r'D:\Github\tld--2.55\TraderMoving\src\bin\Release\TraderMoving.dll'
README = 'TraderMoving使用说明.txt'

with zipfile.ZipFile(OLDZIP) as z:
    names = z.namelist()
    data = {n: z.read(n) for n in names if not n.endswith('/')}
txt_key = [n for n in data if n.endswith('.txt')][0]
t = data[txt_key].decode('utf-8-sig')
nl = '\r\n' if '\r\n' in t else '\n'
t = t.replace('\r\n', '\n')
reps = [('TraderMoving v1.0  搬运商人无线电和交易箱\n=============================================',
         'TraderMoving v1.0.1  搬运商人无线电和交易箱\n=============================================='),
        ('1. 漫漫长夜 2.55,要有远疆 DLC', '1. 漫漫长夜 2.58(10 月 28 日铁路 DLC 更新后),要有远疆 DLC')]
for a, b in reps:
    assert t.count(a) == 1, a
    t = t.replace(a, b)
anchor = '\n\n【需要什么】'
assert t.count(anchor) == 1
t = t.replace(anchor, '\n\n【v1.0.1 改了什么】\n适配 10 月 28 日游戏更新。v1.0 在新版游戏里把交易箱放到别的场景时会出错,'
              '\n游戏删了 v1.0 用到的一个方法。装过 v1.0 的,把 Mods 里的 TraderMoving.dll 换成这一版就行。' + anchor, 1)
out = ('\ufeff' + t).replace('\n', nl).encode('utf-8')

with zipfile.ZipFile(NEWZIP, 'w', zipfile.ZIP_DEFLATED) as z:
    z.writestr(zipfile.ZipInfo('Mods/'), b'')
    z.write(DLL, 'Mods/TraderMoving.dll')
    z.writestr('Mods/ModSettings.dll', data['Mods/ModSettings.dll'])
    z.writestr('Mods/ModData.dll', data['Mods/ModData.dll'])
    z.writestr(README, out)

with zipfile.ZipFile(NEWZIP) as z:
    print(z.namelist())
    assert z.read('Mods/TraderMoving.dll') == open(DLL, 'rb').read()
    print(z.read(README).decode('utf-8-sig')[:420])
