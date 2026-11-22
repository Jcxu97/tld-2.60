# V12.7: full bunkers work again, Bleak Inlet bunker waypoint, Full Invisible only blocks animal damage, mod item name case
import os
REPO = r'D:\Github\tld--2.55'
ST = os.path.join(REPO, r'_work\release\staging')


def edit(p, pairs, bom=True):
    raw = open(p, 'rb').read()
    s = raw.decode('utf-8-sig')
    for a, b in pairs:
        assert s.count(a) == 1, (p, a, s.count(a))
        s = s.replace(a, b)
    open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))


NEW = '\n'.join([
    '【V12.7 有哪些变化】',
    '修复',
    '- 完整地堡开关失效了,换个区域再进地堡还是空版。现在九个地堡都会换成完整版。',
    '- 荒凉水湾地堡的传送点是旧坐标,传过去看不到入口。现在传到新入口旁边。',
    '  显示地堡热键(F9)也改成直接找场景里的入口。',
    '- 完全隐形以前会顺带挡掉所有伤害,冻僵、失温、冻伤都不掉血。现在只挡狼、熊、美洲狮的伤害,',
    '  要全部免伤请开无敌模式。',
    '- 物品生成器里大嘴鲈鱼、生水饺、煮水饺、金块四件 mod 物品刷不出来,现在修好了。',
    '调整',
    '- 蒸汽火车这块设置从第三列挪到第二列。',
    '- 游戏 2.60 起九个区域各有一个固定地堡入口,任何难度都在,高难度刷地堡这个开关已经没有作用。',
    '  入侵者和厄难的地堡进去基本是空的,要物资请开完整地堡。',
    '',
    '【V12.6 有哪些变化】',
])

edit(os.path.join(REPO, r'TldHacks\src\ModMain.cs'), [('VERSION = "12.6"', 'VERSION = "12.7"')])
edit(os.path.join(ST, 'sb_full', '使用说明.txt'), [
    ('TldHacks V12.6 完整安装说明', 'TldHacks V12.7 完整安装说明'),
    ('(整合 34 个独立 mod, V12.6)', '(整合 34 个独立 mod, V12.7)'),
    ('【V12.6 有哪些变化】', NEW),
    ('AKUL\nV12.6\n', 'AKUL\nV12.7\n'),
])
edit(os.path.join(ST, 'ultimate', '使用说明.txt'), [('TldHacks V12.6 终极版安装说明', 'TldHacks V12.7 终极版安装说明')])
print('ok')
