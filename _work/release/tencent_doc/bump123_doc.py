p = r'D:\Github\tld--2.55\_work\release\tencent_doc\doc.txt'
raw = open(p, 'rb').read()
bom = raw.startswith(b'\xef\xbb\xbf')
s = raw.decode('utf-8-sig')

pairs = [
    ('当前网盘上是 TldHacks V12.2，', '当前网盘上是 TldHacks V12.3，'),
    ('| 开锁和容器 | 主页的锁 & 容器 | 忽略上锁、无限容量 |',
     '| 开锁和容器 | 主页的锁 & 容器 | 忽略上锁、无限容量、自定义背包负重、无限负重（背多少都不超重） |'),
]
for a, b in pairs:
    assert s.count(a) == 1, (a, s.count(a))
    s = s.replace(a, b)
n = s.count('TldHacks-v12.2')
s = s.replace('TldHacks-v12.2', 'TldHacks-v12.3')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v12.2 names replaced:', n)
