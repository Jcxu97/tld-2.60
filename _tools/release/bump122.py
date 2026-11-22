# V12.2: furniture tab in the item spawner, SafehouseCustomizationPlus becomes SCPlusFix++ (also in the minimal package)
import os, shutil
ST = r'D:\Github\tld--2.55\_work\release\staging'
GAME = r'D:\Steam\steamapps\common\TheLongDark'


def edit(p, pairs):
    raw = open(p, 'rb').read()
    s = raw.decode('utf-8-sig')
    for a, b in pairs:
        assert s.count(a) == 1, (p, a, s.count(a))
        s = s.replace(a, b)
    open(p, 'wb').write(b'\xef\xbb\xbf' + s.encode('utf-8'))


NL = '\r\n'
NEW = NL.join([
    '【V12.2 有哪些变化】',
    '新功能',
    '- 物品生成器新增「家具」栏。点生成就放进背包的装饰品里,从背包拿出来自己摆。游戏里能摆的家具都在,',
    '  工匠地堡里的铣床和弹药工作台,还有锻炉、大肚炉、铁灶、双灶炉、煤箱、柴火箱、林业箱也能生成。',
    '- 时间流速的两个滑块最低能调到 0.1 倍(V12.1)。',
    '改动',
    '- 自定义安全屋换成 SCPlusFix++(SafehouseCustomizationPlus 的修复版),最小安装包里也带上了。',
    '  Mods 里原来的 SafehouseCustomizationPlus.dll 不用删,SCPlusFix++ 会顶替它,老存档照常读。',
    '  设置页的名字变成「SCPlusFix++ 自定义安全屋」,以前在原版里改过的设置要重新调一次。',
    '',
    '【V12 有哪些变化】',
])

full = os.path.join(ST, 'sb_full', '使用说明.txt')
edit(full, [
    ('TldHacks V12 完整安装说明', 'TldHacks V12.2 完整安装说明'),
    ('(整合 34 个独立 mod, V12)', '(整合 34 个独立 mod, V12.2)'),
    ('   * SafehouseCustomizationPlus.dll     自定义安全屋(已修复新版游戏读档后家具/灶炉消失)',
     '   * SCPlusFix++.dll                    自定义安全屋修复版(原 SafehouseCustomizationPlus,留着原版也不冲突)'),
    ('【V12 有哪些变化】', NEW),
    ('AKUL\nV12\n', 'AKUL\nV12.2\n'),
])
edit(os.path.join(ST, 'ultimate', '使用说明.txt'), [('TldHacks V12.1 终极版安装说明', 'TldHacks V12.2 终极版安装说明')])

# sb_full: the new DLL replaces the old one (release.py copies SCPlusFix++.dll in); the settings file follows the assembly name
fm = os.path.join(ST, 'sb_full', 'Mods')
os.remove(os.path.join(fm, 'SafehouseCustomizationPlus.dll'))
os.replace(os.path.join(fm, 'SafehouseCustomizationPlus.json'), os.path.join(fm, 'SCPlusFix++.json'))
# sb_min: SCPlusFix++ needs ModComponent, and ModComponent needs AudioManager
mm = os.path.join(ST, 'sb_min', 'Mods')
for f in ('ModComponent.dll', 'AudioManager.dll', 'SCPlusFix++.json'):
    shutil.copy2(os.path.join(fm, f), os.path.join(mm, f))
# keep the settings the user already set in the game
gm = os.path.join(GAME, 'Mods')
if not os.path.exists(os.path.join(gm, 'SCPlusFix++.json')):
    shutil.copy2(os.path.join(gm, 'SafehouseCustomizationPlus.json'), os.path.join(gm, 'SCPlusFix++.json'))
print('ok')
