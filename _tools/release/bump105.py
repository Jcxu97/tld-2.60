import os
ST = r'D:\Github\tld--2.55\_work\release\staging'

def edit(p, pairs):
    raw = open(p, 'rb').read()
    s = raw.decode('utf-8-sig')
    for a, b in pairs:
        assert s.count(a) == 1, (p, a)
        s = s.replace(a, b)
    open(p, 'wb').write(b'\xef\xbb\xbf' + s.encode('utf-8'))

edit(os.path.join(ST, 'sb_full', '使用说明.txt'), [
    ('TldHacks v10.3 完整安装说明', 'TldHacks v10.5 完整安装说明'),
    ('(整合 34 个独立 mod, v10.3)', '(整合 34 个独立 mod, v10.5)'),
    ('【v10.3 有哪些变化】\n', '''【v10.5 有哪些变化】
修复
- 「不捡丢物」开着时,自己丢在地上或右键摆好的东西(比如挂在墙上的火把),
  以前存档重进或换地图以后就不认了,一键搜刮会把它们收走。现在这份记录跟着存档走,
  重进游戏、换地图以后一键搜刮和 ItemPicker 自动拾取都还会跳过它们。
  自己再捡回背包的东西就不再算,扔出去以后照样能搜回来。
- 这版之前就摆好的东西没有记录,要捡起来重新摆一次。

【v10.3 有哪些变化】
'''),
    ('\nv10.3', '\nv10.5'),
])
edit(os.path.join(ST, 'ultimate', '使用说明.txt'), [
    ('TldHacks v10.3 终极版安装说明', 'TldHacks v10.5 终极版安装说明'),
])
print('ok')
