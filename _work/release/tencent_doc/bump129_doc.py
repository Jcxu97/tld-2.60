# V12.9. Run: python bump129_doc.py <ultimate volume count>
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


rep('当前网盘上是 TldHacks V12.8，', '当前网盘上是 TldHacks V12.9，')
n = s.count('TldHacks-v12.8')
s = s.replace('TldHacks-v12.8', 'TldHacks-v12.9')
if N != '182':
    rep('全部 182 个分卷 终极版材质包备份.001 到 .182，', f'全部 {N} 个分卷 终极版材质包备份.001 到 .{N}，')
    rep('文件夹，182 个分卷 终极版材质包备份.001 到 .182 |', f'文件夹，{N} 个分卷 终极版材质包备份.001 到 .{N} |')
rep('按原版烹饪时间自己变成热的熟肉，不会烤焦 |',
    '按原版烹饪时间自己变成热的熟肉。熟了还放在火边太久会烤焦，离开场景再回来照样计时 |')
rep('免费制作、快速制作、免费修理、随地制作 |', '免费制作、快速制作（工作台家具这类分段计时的也一次做完）、免费修理、随地制作 |')
rep('| 鲸油取暖器 | 装备 & 衰减的鲸油取暖器 & 油罐（第三列） | 鲸油取暖器不耗油、耗油倍率、温度加成，',
    '| 鲸油取暖器 | 装备 & 衰减的鲸油取暖器 & 油罐（第三列） | 鲸油取暖器不耗油、取暖器进轮盘（背包里的取暖器出现在营地轮盘，点一下直接放置）、耗油倍率、温度加成，')
rep('| 火把、手电、油灯 | 装备 & 衰减的火把 & 手电、煤油灯 | 火把满值和燃烧时长，手电电池续航，煤油灯油量不减和燃烧倍率 |',
    '| 火把、手电、油灯 | 装备 & 衰减的火把 & 手电、煤油灯 | 火把满值和燃烧时长，火把烧完自动换新（自动换上背包里最好的火把并点着），手电电池续航，煤油灯油量不减和燃烧倍率 |\n'
    '| 保温杯 | 装备 & 衰减的保温杯 & 衣物 | 保温杯不降温、无限容量、装任意液体，轮盘喝保温杯（喝水轮盘里点一下直接喝一杯，茶和卡路里低的先喝），保温杯火边加热（靠近点着的火热度慢慢升回满） |')
if crlf:
    s = s.replace('\n', '\r\n')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v12.8 names replaced:', n)
