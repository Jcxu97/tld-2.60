# V13.0: Major Miseries startup crash, story build, winhttp.dll in minimal and full, RarityRework 1.2.1,
# SCPlusFix++ 2.1.0, MoreBunkers 1.5.0
import os
REPO = r'D:\Github\tld--2.55'
ST = os.path.join(REPO, r'_work\release\staging')


def edit(p, pairs, bom=True):
    raw = open(p, 'rb').read()
    s = raw.decode('utf-8-sig')
    crlf = '\r\n' in s
    s = s.replace('\r\n', '\n')
    for a, b in pairs:
        assert s.count(a) == 1, (p, a, s.count(a))
        s = s.replace(a, b)
    if crlf:
        s = s.replace('\n', '\r\n')
    open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))


NEW = '\n'.join([
    '【V13.0 有哪些变化】',
    '修复',
    '- 和 Major Miseries 一起装时,游戏启动到一半就闪退。',
    '- 安装包里的 MelonLoader 注入器从 version.dll 改名成 winhttp.dll,有些电脑认不到 version.dll,菜单打不开。',
    '  游戏根目录要是还有旧的 version.dll,把它删掉,两个只留一个。',
    '- 物品稀有度更新到 1.2.1。步枪伤害、装填时间、卡壳几率、生火时间、拆解时间这些词条现在真的生效。',
    '  撬棍这类不能采集尸骸、不能拆解的工具不再抽到这些词条,旧存档里已有的读档时自动清掉,档位和其他词条不变。',
    '- 自定义安全屋(SCPlusFix++ 2.1.0)进出场景时偶尔报 "The scene is invalid" 的错误修了。',
    '  游戏语言是英文时,它的设置页显示英文。',
    '- 更多地堡(MoreBunkers 1.5.0)建舱口出错时不再留下半个舱口。',
    '  游戏 2.60 会换掉新舱口的门编号,现在马上改回来,进新地堡能认出来并补货。',
    '- 剧情版(第一章到第四章)重新打包,跟上这一版的修复。',
    '',
    '【V12.9 有哪些变化】',
])

edit(os.path.join(REPO, r'TldHacks\src\ModMain.cs'), [('VERSION = "12.9"', 'VERSION = "13.0"')])
edit(os.path.join(ST, 'sb_full', '使用说明.txt'), [
    ('TldHacks V12.9 完整安装说明', 'TldHacks V13.0 完整安装说明'),
    ('   解压后会有: version.dll / MelonLoader/ / Mods/ 三样,直接整体拖过去',
     '   解压后会有: winhttp.dll / MelonLoader/ / Mods/ 三样,直接整体拖过去\n'
     '   游戏根目录要是还有旧版留下的 version.dll,把它删掉(这一版用 winhttp.dll,两个只留一个)'),
    ('- version.dll        MelonLoader 注入器', '- winhttp.dll        MelonLoader 注入器'),
    ('(整合 34 个独立 mod, V12.9)', '(整合 34 个独立 mod, V13.0)'),
    ('更多地堡 v1.4:', '更多地堡 v1.5:'),
    ('【V12.9 有哪些变化】', NEW),
    ('AKUL\nV12.9\n', 'AKUL\nV13.0\n'),
])
edit(os.path.join(ST, 'ultimate', '使用说明.txt'), [('TldHacks V12.9 终极版安装说明', 'TldHacks V13.0 终极版安装说明')])
print('ok')
