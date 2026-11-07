# V12.6: update the group bot knowledge base. Run: python kb126.py <ultimate volume count>
import os, re, sys

F = r'C:\Users\82077\Desktop\TLD\files'
N = sys.argv[1]


def edit(name, pairs):
    p = os.path.join(F, name)
    raw = open(p, 'rb').read()
    bom = raw.startswith(b'\xef\xbb\xbf')
    s = raw.decode('utf-8-sig')
    for a, b, *cnt in pairs:
        want = cnt[0] if cnt else 1
        assert s.count(a) == want, (name, a, s.count(a))
        s = s.replace(a, b)
    open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))


NEWS = ('V12.6 新加 BlueprintIconFix（完整版和终极版带），制造界面里 mod 加的配方没图标的会用做出来那件物品的图标补上，'
        '还修了咖啡罐、茶包这类一件带好几份的物品在背包里不叠成一格，物品生成器里原版没用上的那条鱼线 GEAR_FishingLine 名字后面带（游戏废案），'
        '终极版加了钓鱼小屋门和壁挂火把 HutDoorTorch，')

edit('00_索引与回答口径.md', [
    ('当前发布版本：TldHacks V12.5（最小安装包、完整版、终极版，2026-11-07，V12.5 修了',
     '当前发布版本：TldHacks V12.6（最小安装包、完整版、终极版，2026-11-08，' + NEWS + 'V12.5 修了'),
    ('默认按 V12.5 和游戏 2.60 回答', '默认按 V12.6 和游戏 2.60 回答'),
    ('先让他整包换 V12.5 再看', '先让他整包换 V12.6 再看'),
    ('| 08 最上面一节，整包换 V12.5 |', '| 08 最上面一节，整包换 V12.6 |'),
    ('换 V12.5 里的 SCPlusFix++', '换 V12.6 里的 SCPlusFix++'),
])

edit('01_下载与版本.md', [
    ('下面按 V12.5 写', '下面按 V12.6 写'),
    ('1_TldHacks-v12.5最小安装包_只有修改器 | TldHacks-v12.5-最小安装包', '1_TldHacks-v12.6最小安装包_只有修改器 | TldHacks-v12.6-最小安装包'),
    ('| 1_TldHacks-v12.5完整版_带其他mods例如地图 | 材质包备份.001 .002 .003 .004 | V12.5 完整版分卷',
     '| 1_TldHacks-v12.6完整版_带其他mods例如地图 | 材质包备份.001 .002 .003 .004 | V12.6 完整版分卷'),
    ('| 2_TldHacks-v12.5终极版_更多MOD食物衣服_适配最新铁路DLC | 终极版材质包备份.001 到 .182 和 终极版_安装说明.txt | V12.5 终极版分卷，每个 20MB | 182 个全',
     f'| 2_TldHacks-v12.6终极版_更多MOD食物衣服_适配最新铁路DLC | 终极版材质包备份.001 到 .{N} 和 终极版_安装说明.txt | V12.6 终极版分卷，每个 20MB | {N} 个全'),
    ('| OLD文件，不用管，V2.55老版本的东西在里面 | 旧版本 |', '| OLD | 旧版本 |'),
    ('当前发给群里的是 TldHacks V12.5（11 月 7 日），适配游戏 2.60 版（11 月 6 日的热补丁）。V12.5 修了',
     '当前发给群里的是 TldHacks V12.6（11 月 8 日），适配游戏 2.60 版（11 月 6 日的热补丁）。'
     'V12.6 新加 BlueprintIconFix 补配方图标，修了咖啡罐茶包不堆叠，物品生成器里没用上的那条鱼线标了（游戏废案），终极版加了 HutDoorTorch。V12.5 修了'),
    ('V12.4 和更早的包都挪进了 OLD 文件夹，群友说找不到 V12.4、V12.3 是正常的，让他下 V12.5。',
     'V12.5 和更早的包都挪进了 OLD 文件夹，群友说找不到 V12.5、V12.4 是正常的，让他下 V12.6。'),
    ('还在用旧包的先整包换成 V12.5。', '还在用旧包的先整包换成 V12.6。'),
])

edit('06_功能清单.md', [('内容是 V12.5。', '内容是 V12.6。')])

edit('07_整合模组清单.md', [
    ('| BlueprintCleaner | 整理制作界面的蓝图清单，按 H 在原版和整理后的界面之间切换 |\n',
     '| BlueprintCleaner | 整理制作界面的蓝图清单，按 H 在原版和整理后的界面之间切换 |\n'
     '| BlueprintIconFix | 配方图标补全（V12.6 新加）。mod 加的配方很多在制造界面里没有图标（ZC8787 那几个配方包、食物包、双管枪这些），'
     '现在用做出来那件物品的背包图标补上，彩色的，和原版白色的配方图样子不一样。没有设置项 |\n'),
    ('| ModSettingsQuickNav | Mod Settings 里快速跳到某个 mod 的设置页 | 终极版 |\n',
     '| ModSettingsQuickNav | Mod Settings 里快速跳到某个 mod 的设置页 | 终极版 |\n'
     '| BlueprintIconFix | 制造界面里 mod 配方没图标时补上图标 | 完整版、终极版 |\n'
     '| HutDoorTorch | 钓鱼小屋门和壁挂火把（V12.6 起终极版带）。工作台做小屋门（10 根冷杉或 10 根雪松），只能装在没门的钓鱼小屋门框上，关上挡风；'
     '工作台做壁挂火把（2 根树枝加 1 根冷杉或雪松加 1 支火把），是家具，挂墙上一直亮，换场景回来还亮。亮度、闪烁在 Mod Settings 里调 | 终极版 |\n'),
])

edit('24_装备与制作.md', [
    ('物品生成器里有两样东西都显示成鱼线，别搞混。',
     '物品生成器里有两样东西都显示成鱼线，别搞混。V12.6 起物品生成器里 GEAR_FishingLine 那条名字后面带（游戏废案），刷的时候认准不带的那条。'),
])

edit('10_版本历史.md', [
    ('## 沙盒版 V12.5（2026-11-07，当前版本）',
     '## 沙盒版 V12.6（2026-11-08，当前版本）\n\n'
     '新加 BlueprintIconFix，完整版和终极版带。制造界面里 mod 加的配方很多没有图标，现在用做出来那件物品的背包图标补上。'
     '修了咖啡罐、茶包这类一件就带好几份的物品在背包里不叠成一格。物品生成器里有两样都叫鱼线，原版没用上的那条 GEAR_FishingLine 现在名字后面带（游戏废案），'
     '它做不了钓鱼用具。终极版加了 HutDoorTorch（钓鱼小屋门和壁挂火把），完整版和最小包不带。\n\n'
     '## 沙盒版 V12.5（2026-11-07）'),
])
print('ok')
