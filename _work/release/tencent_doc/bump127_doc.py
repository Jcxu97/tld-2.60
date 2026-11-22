# V12.7. Run: python bump127_doc.py <ultimate volume count>
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


rep('当前网盘上是 TldHacks V12.6，', '当前网盘上是 TldHacks V12.7，')
n = s.count('TldHacks-v12.6')
s = s.replace('TldHacks-v12.6', 'TldHacks-v12.7')
rep('全部 182 个分卷 终极版材质包备份.001 到 .182，', f'全部 {N} 个分卷 终极版材质包备份.001 到 .{N}，')
rep('| 动物 | 主页的动物 | 一击必杀 |',
    '| 动物 | 主页的动物 | 一击必杀。完全隐形是动物看不见你，只挡狼、熊、美洲狮的伤害，冻僵、失温照常掉血，要全部免伤开无敌模式 |')
rep('完整地堡让每个地堡随机变成六种完整版里的一种。入侵者和厄难也刷地堡 |',
    '完整地堡让每个地堡随机变成六种完整版里的一种。游戏 2.60 起九个区域各有一个固定入口，任何难度都在，'
    '入侵者和厄难的地堡进去基本是空的，开完整地堡就有物资 |')
rep('! 只想更新 TldHacks\n老用户只想换本体，解出来只拿 Mods\\TldHacks.dll 覆盖就行，别的都不用动。'
    '10 月 28 日游戏更新后包里好几个别的 mod 也修了，从旧版升上来的建议整包重新装一遍。\n',
    '! 怎么更新到新版\n下载最新的最小安装包，解压到游戏根目录覆盖即可。\n')
if crlf:
    s = s.replace('\n', '\r\n')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v12.6 names replaced:', n)
