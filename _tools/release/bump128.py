# V12.8: Drop to Cook, map icons for regrown plants, heater card in column 3, RarityRework 1.2.0
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
    '【V12.8 有哪些变化】',
    '新功能',
    '- 丢地烹饪(主页快速操作栏,默认关)。生肉生鱼丢在燃着的火堆或炉子 2 米内,',
    '  按原版烹饪时间自己变成热的熟肉,不会烤焦,不用守在火边。',
    '- 物品稀有度更新到 1.2.0(只在完整版和终极版里)。随机词条六档各自的出现概率可以在设置里调。',
    '  词条加强了,神话档翻倍,优秀到传说加强 30% 到 60%,减少类的词条最多减 90%,老存档里的装备也跟着变强。',
    '  衣服原本没有的属性不再抽到词条。词条每行写出原来的值和现在的值,括号里是百分比。',
    '修复',
    '- 植物全采完以后地图上的图标会消失,重新长出来也不回来。现在长出来后图标会重新显示。',
    '调整',
    '- 鲸油取暖器和油罐这块设置单独成块,放在第三列。',
    '',
    '【V12.7 有哪些变化】',
])

edit(os.path.join(REPO, r'TldHacks\src\ModMain.cs'), [('VERSION = "12.7"', 'VERSION = "12.8"')])
edit(os.path.join(ST, 'sb_full', '使用说明.txt'), [
    ('TldHacks V12.7 完整安装说明', 'TldHacks V12.8 完整安装说明'),
    ('(整合 34 个独立 mod, V12.7)', '(整合 34 个独立 mod, V12.8)'),
    ('【V12.7 有哪些变化】', NEW),
    ('AKUL\nV12.7\n', 'AKUL\nV12.8\n'),
])
edit(os.path.join(ST, 'ultimate', '使用说明.txt'), [('TldHacks V12.7 终极版安装说明', 'TldHacks V12.8 终极版安装说明')])
print('ok')
