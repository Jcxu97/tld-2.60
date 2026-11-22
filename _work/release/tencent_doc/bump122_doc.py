p = r'D:\Github\tld--2.55\_work\release\tencent_doc\doc.txt'
raw = open(p, 'rb').read()
bom = raw.startswith(b'\xef\xbb\xbf')
s = raw.decode('utf-8-sig')

pairs = [
    ('当前网盘上是 TldHacks V12.1，', '当前网盘上是 TldHacks V12.2，'),
    ('| 最小包 | 只有 TldHacks 修改器和它要用的几个前置 |',
     '| 最小包 | TldHacks 修改器、SCPlusFix++ 自定义安全屋，和它们要用的几个前置 |'),
    ('也能直接粘中文名 |',
     '也能直接粘中文名。家具那一栏是游戏里能摆的家具，还有炉子、铣床、弹药工作台这些器械，生成后在背包的装饰品里，拿出来自己摆。铣床、弹药工作台和炉子要装 SCPlusFix++ |'),
    ('| SafehouseCustomizationPlus | 自定义安全屋，能搬、摆、复制家具。已修好新版游戏读档后家具和灶炉消失 |',
     '| SCPlusFix++ | 自定义安全屋，原来的 SafehouseCustomizationPlus 修好以后改的名，能搬、摆、复制家具。最小包也带了。Mods 里留着原版 SafehouseCustomizationPlus.dll 不用删，SCPlusFix++ 会顶替它，老存档照常读 |'),
    ('+ 最小包只有 TldHacks，按键看下面的 TldHacks 表。',
     '+ 最小包只有 TldHacks 和 SCPlusFix++，按键看下面的 TldHacks 表，SCPlusFix++ 的按键和完整版一样。'),
    ('| 小键盘 8 | 准星对着装饰物按，复制一个 | SafehouseCustomizationPlus |',
     '| 小键盘 8 | 准星对着装饰物按，复制一个 | SCPlusFix++ |'),
    ('MoreBunkers、SafehouseCustomizationPlus、SaveManager、DeveloperConsole 的按键和完整版一样',
     'MoreBunkers、SCPlusFix++、SaveManager、DeveloperConsole 的按键和完整版一样'),
    ('| TldHacks、MoreBunkers、SafehouseCustomizationPlus、TraderMoving | 我们自己的 mod，都适配了新版 |',
     '| TldHacks、MoreBunkers、SCPlusFix++、TraderMoving | 我们自己的 mod，都适配了新版 |'),
]
for a, b in pairs:
    assert s.count(a) == 1, (a, s.count(a))
    s = s.replace(a, b)
n = s.count('TldHacks-v12.1')
s = s.replace('TldHacks-v12.1', 'TldHacks-v12.2')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v12.1 names replaced:', n)
