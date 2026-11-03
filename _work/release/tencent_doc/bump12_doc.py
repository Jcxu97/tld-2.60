import sys
p = r'D:\Github\tld--2.55\_work\release\tencent_doc\doc.txt'
vols = int(sys.argv[1])
raw = open(p, 'rb').read()
bom = raw.startswith(b'\xef\xbb\xbf')
s = raw.decode('utf-8-sig')
pairs = [
    ('当前网盘上是 TldHacks V11，', '当前网盘上是 TldHacks V12，'),
    ('| 火车不坏、保持二档、燃料和水一直满，默认关 |',
     '| 火车不坏、保持二档、燃料和水一直满，鲸油取暖器不耗油、耗油倍率、温度加成，鲸油罐和油桶一罐最多装多少升（最高 2000 升）、一键合并背包里的油，默认都是原版 |'),
    ('| 即时交易、商人常驻、信任满值、交易扩充、显示信任度、商人打折、刷新商品 |',
     '| 即时交易、商人常驻、信任满值、交易扩充、显示信任度、商人打折、刷新商品、解锁原版限制（入侵者和悲惨模式里原版不卖的斧子、步枪、精工箭也能换到） |'),
]
for a, b in pairs:
    assert s.count(a) == 1, (a, s.count(a))
    s = s.replace(a, b)
n = s.count('v11')
s = s.replace('v11', 'v12')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v11 replaced', n)
