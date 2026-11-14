# V12.8. Run: python bump128_doc.py <ultimate volume count>
import sys
N = sys.argv[1]
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


rep('当前网盘上是 TldHacks V12.7，', '当前网盘上是 TldHacks V12.8，')
n = s.count('TldHacks-v12.7')
s = s.replace('TldHacks-v12.7', 'TldHacks-v12.8')
rep('全部 182 个分卷 终极版材质包备份.001 到 .182，', f'全部 {N} 个分卷 终极版材质包备份.001 到 .{N}，')
rep('文件夹，182 个分卷 终极版材质包备份.001 到 .182 |', f'文件夹，{N} 个分卷 终极版材质包备份.001 到 .{N} |')
rep('| 火车 | 装备 & 衰减的蒸汽火车 | 火车不坏、保持二档、燃料和水一直满，鲸油取暖器不耗油、耗油倍率、温度加成，',
    '| 火车 | 装备 & 衰减的蒸汽火车 | 火车不坏、保持二档、燃料和水一直满，默认都是原版 |\n'
    '| 鲸油取暖器 | 装备 & 衰减的鲸油取暖器 & 油罐（第三列） | 鲸油取暖器不耗油、耗油倍率、温度加成，')
rep('随机词条模式默认关，在 Mod Settings 里打开 |',
    '随机词条模式默认关，在 Mod Settings 里打开，六档各自的出现概率也在那里调。'
    'V12.8 起词条加强，神话档翻倍，物品说明里每条写原来的值和现在的值 |')
if crlf:
    s = s.replace('\n', '\r\n')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v12.7 names replaced:', n)
