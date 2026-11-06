# V12.4: carried stations survive reload, original SCPlus is really blocked, ilfix'd mods load on net6
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
    '【V12.4 有哪些变化】',
    '修复',
    '- 物品生成器「家具」栏刷出的铣床、弹药工作台、锻炉、炉子这类器械,放进背包后存档再读档会消失。现在读档后还在。',
    '  之前已经丢掉的找不回来,重新刷一件就行。',
    '- Mods 里留着原版 SafehouseCustomizationPlus.dll 时,原版会和 SCPlusFix++ 一起运行。现在原版会被自动停用,文件留着也没关系。',
    '- 建筑(Architect)加载失败,现在恢复正常。',
    '- 完美摆放、建筑等几个修过的 mod 一用到修补代码就报找不到 System.Runtime 8.0,现在不再报错。',
    '- 完美摆放在 Mod Settings 里的选项名全显示成 INDOOR SPAWNS PERMITTED,现在显示中文。',
    '- 动物雷达(MotionTrackerLite)扫不到海滩拾荒点,现在能扫到。',
    '',
    '【V12.3 有哪些变化】',
])

edit(os.path.join(REPO, r'TldHacks\src\ModMain.cs'), [('VERSION = "12.3"', 'VERSION = "12.4"')])
edit(os.path.join(ST, 'sb_full', '使用说明.txt'), [
    ('TldHacks V12.3 完整安装说明', 'TldHacks V12.4 完整安装说明'),
    ('(整合 34 个独立 mod, V12.3)', '(整合 34 个独立 mod, V12.4)'),
    ('【V12.3 有哪些变化】', NEW),
    ('AKUL\nV12.3\n', 'AKUL\nV12.4\n'),
])
edit(os.path.join(ST, 'ultimate', '使用说明.txt'), [('TldHacks V12.3 终极版安装说明', 'TldHacks V12.4 终极版安装说明')])
print('ok')
