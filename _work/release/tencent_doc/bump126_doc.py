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


rep('当前网盘上是 TldHacks V12.5，', '当前网盘上是 TldHacks V12.6，')
n = s.count('TldHacks-v12.5')
s = s.replace('TldHacks-v12.5', 'TldHacks-v12.6')
a = '| BlueprintCleaner | 整理制作界面的蓝图清单，按 H 在原版和整理后的界面之间切换 |\n'
rep(a, a + '| BlueprintIconFix | 配方图标补全。mod 加的配方在制作界面里没有图标的，用做出来那件物品的图标补上 |\n')
rep('| ImprovedFirstAidPanel | 急救面板更清楚好用 |\n',
    '| HutDoorTorch | 钓鱼小屋门和壁挂火把。工作台做小屋门，装在没门的钓鱼小屋门框上，关门挡风。工作台做壁挂火把，挂墙上一直亮 |\n'
    '| ImprovedFirstAidPanel | 急救面板更清楚好用 |\n')
a = '| ModSettingsQuickNav | Mod Settings 里快速跳到某个 mod 的设置页 | 终极版 |\n'
rep(a, a + '| BlueprintIconFix | 制作界面里 mod 配方没图标时补上图标 | 完整版、终极版 |\n'
           '| HutDoorTorch | 钓鱼小屋门和壁挂火把 | 终极版 |\n')
if crlf:
    s = s.replace('\n', '\r\n')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v12.5 names replaced:', n)
