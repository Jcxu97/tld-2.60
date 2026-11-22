# 2026-11-09 ultimate repack: list DoubleBarrelLoadFix
p = r'D:\Github\tld--2.55\_work\release\tencent_doc\doc.txt'
raw = open(p, 'rb').read()
bom = raw.startswith(b'\xef\xbb\xbf')
s = raw.decode('utf-8-sig')
crlf = '\r\n' in s
s = s.replace('\r\n', '\n')
a = '| DoubleBarrel | 双管霰弹枪 |\n'
assert s.count(a) == 1, s.count(a)
s = s.replace(a, a + '| DoubleBarrelLoadFix | 修双管霰弹枪进沿海公路、荒凉水湾时卡在读条 |\n')
if crlf:
    s = s.replace('\n', '\r\n')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok')
