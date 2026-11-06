# V12.3: furniture spawned from the item spawner no longer disappears after leaving the house
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
    '【V12.3 有哪些变化】',
    '新功能',
    '- 「锁 & 容器」里新增「无限负重」开关,就在「背包负重」下面。打开后背多少都不超重。',
    '修复',
    '- 物品生成器「家具」栏生成的家具,摆好以后出门再进屋会消失。现在摆好就会存档。',
    '  旧版生成、已经消失或还在背包里的那几件存不住,删掉重新生成一件就行。',
    '',
    '【V12.2 有哪些变化】',
])

edit(os.path.join(REPO, r'TldHacks\src\ModMain.cs'), [('VERSION = "12.2"', 'VERSION = "12.3"')])
edit(os.path.join(ST, 'sb_full', '使用说明.txt'), [
    ('TldHacks V12.2 完整安装说明', 'TldHacks V12.3 完整安装说明'),
    ('(整合 34 个独立 mod, V12.2)', '(整合 34 个独立 mod, V12.3)'),
    ('【V12.2 有哪些变化】', NEW),
    ('AKUL\nV12.2\n', 'AKUL\nV12.3\n'),
])
edit(os.path.join(ST, 'ultimate', '使用说明.txt'), [('TldHacks V12.2 终极版安装说明', 'TldHacks V12.3 终极版安装说明')])
print('ok')
