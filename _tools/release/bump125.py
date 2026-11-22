# V12.5: Map Clear and Grab All pick up hatchets, knives, hammers and hacksaws
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
    '【V12.5 有哪些变化】',
    '修复',
    '- 一键清图扫完后,地图上还能找到斧头、猎刀、重锤、钢锯。现在这四样都会收进背包。',
    '  一键搜刮以前也收不到刀和斧头,现在一起修好了。',
    '- 一键清图以前还会漏掉一批被游戏标了分组的普通物品(神秘湖约 50 件),现在也会收。',
    '',
    '【V12.4 有哪些变化】',
])

edit(os.path.join(REPO, r'TldHacks\src\ModMain.cs'), [('VERSION = "12.4"', 'VERSION = "12.5"')])
edit(os.path.join(ST, 'sb_full', '使用说明.txt'), [
    ('TldHacks V12.4 完整安装说明', 'TldHacks V12.5 完整安装说明'),
    ('(整合 34 个独立 mod, V12.4)', '(整合 34 个独立 mod, V12.5)'),
    ('【V12.4 有哪些变化】', NEW),
    ('AKUL\nV12.4\n', 'AKUL\nV12.5\n'),
])
edit(os.path.join(ST, 'ultimate', '使用说明.txt'), [('TldHacks V12.4 终极版安装说明', 'TldHacks V12.5 终极版安装说明')])
print('ok')
