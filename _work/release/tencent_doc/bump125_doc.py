p = r'D:\Github\tld--2.55\_work\release\tencent_doc\doc.txt'
raw = open(p, 'rb').read()
bom = raw.startswith(b'\xef\xbb\xbf')
s = raw.decode('utf-8-sig')

a = '当前网盘上是 TldHacks V12.4，'
assert s.count(a) == 1, s.count(a)
s = s.replace(a, '当前网盘上是 TldHacks V12.5，')
n = s.count('TldHacks-v12.4')
s = s.replace('TldHacks-v12.4', 'TldHacks-v12.5')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v12.4 names replaced:', n)
