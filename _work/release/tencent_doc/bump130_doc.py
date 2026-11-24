# V13.0. Run: python bump130_doc.py
p = r'D:\Github\tld--2.55\_work\release\tencent_doc\doc.txt'
raw = open(p, 'rb').read()
bom = raw.startswith(b'\xef\xbb\xbf')
s = raw.decode('utf-8-sig')
crlf = '\r\n' in s
s = s.replace('\r\n', '\n')


def rep(a, b):
    global s
    assert s.count(a) == 1, (a, s.count(a))
    s = s.replace(a, b)


rep('当前网盘上是 TldHacks V12.9，', '当前网盘上是 TldHacks V13.0，')
n = s.count('TldHacks-v12.9')
s = s.replace('TldHacks-v12.9', 'TldHacks-v13.0')
rep('| MoreBunkers-v1.4_更多地堡三个新地堡_适配2.59_解压到游戏根目录.zip |', '| MoreBunkers-v1.5_更多地堡三个新地堡_适配2.60_解压到游戏根目录.zip |')
rep('解压到游戏根目录.zip，里面是 version.dll、MelonLoader、Mods 三样。', '解压到游戏根目录.zip，里面是 winhttp.dll、MelonLoader、Mods 三样。')
rep('打开它，把里面的 version.dll、MelonLoader、Mods 三样拖进游戏根目录，选覆盖。', '打开它，把里面的 winhttp.dll、MelonLoader、Mods 三样拖进游戏根目录，选覆盖。')
rep('旧完整版用的是 version.dll，终极版用的是 winhttp.dll，两个只留一个。',
    'V13.0 起三个包都用 winhttp.dll，以前的最小包和完整版用的是 version.dll。游戏根目录里两个只留一个，旧的 version.dll 删掉。')
rep('| MoreBunkers | 更多地堡 v1.4。', '| MoreBunkers | 更多地堡 v1.5。')
rep('游戏能启动但 mod 管理器没起来，把游戏根目录的 version.dll 改名成 winhttp.dll 试试。',
    '游戏能启动但 mod 管理器没起来，看游戏根目录是不是 version.dll 和 winhttp.dll 都在，删掉 version.dll 只留 winhttp.dll；只有 version.dll 的，把它改名成 winhttp.dll 试试。'
    '装了 Major Miseries 一启动就闪退的，换 V13.0，旧版 TldHacks 和它冲突。')
if crlf:
    s = s.replace('\n', '\r\n')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v12.9 names replaced:', n)
