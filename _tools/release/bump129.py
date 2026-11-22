# V12.9: torch auto swap, flask and heater in radial, flask heats near fire, drop cook across scenes and burning,
# quick craft finishes timed furniture, restore clears the worn-out mark
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
    '【V12.9 有哪些变化】',
    '新功能(都默认关)',
    '- 火把烧完自动换新(装备 & 衰减页的 火把 & 手电)。手上的火把烧完,自动换上背包里状态最好的火把并点着,',
    '  烧完的那根留在背包。',
    '- 轮盘喝保温杯(装备 & 衰减页的 保温杯 & 衣物)。装着东西的保温杯出现在喝水轮盘里,点一下直接喝一杯,',
    '  茶优先,卡路里低的先喝,喝的时候是杯子当时的热度。',
    '- 保温杯火边加热(同上)。带着保温杯靠近点着的火,杯子的热度慢慢升回满,从冷到满大约游戏内 15 分钟。',
    '- 取暖器进轮盘(装备 & 衰减页的 鲸油取暖器 & 油罐)。背包里的鲸油取暖器出现在营地轮盘(生火、休息那一页),点一下直接放置。',
    '调整',
    '- 丢地烹饪离开场景再回来不会重新计时,回来时火还燃着,离开的时间也算进去。',
    '  熟了还放在火边太久会烤焦(耐久变 0),火灭了暂停,捡起来重新计时。',
    '修复',
    '- 快速制作做工作台家具这类分段计时的东西,现在一次做完。',
    '- 无限耐久和一键恢复会清掉腐坏标记,修到 100% 以后不再显示腐坏红叉。',
    '',
    '【V12.8 有哪些变化】',
])

edit(os.path.join(REPO, r'TldHacks\src\ModMain.cs'), [('VERSION = "12.8"', 'VERSION = "12.9"')])
edit(os.path.join(ST, 'sb_full', '使用说明.txt'), [
    ('TldHacks V12.8 完整安装说明', 'TldHacks V12.9 完整安装说明'),
    ('(整合 34 个独立 mod, V12.8)', '(整合 34 个独立 mod, V12.9)'),
    ('【V12.8 有哪些变化】', NEW),
    ('AKUL\nV12.8\n', 'AKUL\nV12.9\n'),
])
edit(os.path.join(ST, 'ultimate', '使用说明.txt'), [('TldHacks V12.8 终极版安装说明', 'TldHacks V12.9 终极版安装说明')])
print('ok')
