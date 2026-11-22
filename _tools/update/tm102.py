import os, zipfile

DESK = r'C:\Users\82077\Desktop\TLD\零散MODS'
OLDZIP = os.path.join(DESK, 'TraderMoving-v1.0.1_搬运商人无线电和交易箱_解压到游戏根目录.zip')
NEWZIP = os.path.join(DESK, 'TraderMoving-v1.0.2_搬运商人无线电和交易箱_解压到游戏根目录.zip')
DLL = r'D:\Github\tld--2.55\TraderMoving\src\bin\Release\TraderMoving.dll'
README = 'TraderMoving使用说明.txt'

with zipfile.ZipFile(OLDZIP) as z:
    data = {n: z.read(n) for n in z.namelist() if not n.endswith('/')}
t = data[README].decode('utf-8-sig')
nl = '\r\n' if '\r\n' in t else '\n'
t = t.replace('\r\n', '\n')
reps = [('TraderMoving v1.0.1  搬运商人无线电和交易箱', 'TraderMoving v1.0.2  搬运商人无线电和交易箱'),
        ('1. 漫漫长夜 2.58(10 月 28 日铁路 DLC 更新后)', '1. 漫漫长夜 2.60(11 月 6 日热补丁后)')]
for a, b in reps:
    assert t.count(a) == 1, a
    t = t.replace(a, b)
anchor = '\n\n【v1.0.1 改了什么】'
assert t.count(anchor) == 1
t = t.replace(anchor, '\n\n【v1.0.2 改了什么】\n适配 11 月 6 日的 2.60 热补丁,修好交易箱放不下来的问题。'
              '\n同时适配 SCPlusFix++(自定义安全屋修复版),装修模式里也能拿起无线电和交易箱。'
              '\n装过旧版的,把 Mods 里的 TraderMoving.dll 换成这一版就行。' + anchor, 1)
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
    print(z.read(README).decode('utf-8-sig')[:700])
