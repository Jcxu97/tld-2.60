# V13.0: update the group bot knowledge base. Run: python kb130.py
import os

F = os.environ.get('KB_DIR', r'C:\Users\82077\Desktop\TLD\files')


def edit(name, pairs):
    p = os.path.join(F, name)
    raw = open(p, 'rb').read()
    bom = raw.startswith(b'\xef\xbb\xbf')
    s = raw.decode('utf-8-sig')
    crlf = '\r\n' in s
    s = s.replace('\r\n', '\n')
    for a, b, *cnt in pairs:
        want = cnt[0] if cnt else 1
        assert s.count(a) == want, (name, a, s.count(a))
        s = s.replace(a, b)
    if crlf:
        s = s.replace('\n', '\r\n')
    open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))


NEWS = ('V13.0 是修复版：和 Major Miseries 一起装时启动就闪退修了；最小包和完整版的 MelonLoader 注入器从 version.dll 改名成 winhttp.dll'
        '（根目录还有旧的 version.dll 要删掉，两个只留一个）；物品稀有度 1.2.1 让步枪伤害、装填、卡壳、生火、拆解这些词条真的生效，'
        '撬棍这类工具不再抽到用不上的词条；SCPlusFix++ 2.1.0 修了 The scene is invalid 报错、游戏是英文时设置页显示英文；'
        'MoreBunkers 1.5.0 修了 2.60 进新地堡可能是空的；剧情版跟着重新打包。')

edit('00_索引与回答口径.md', [
    ('当前发布版本：TldHacks V12.9（最小安装包、完整版、终极版，2026-11-18，',
     '当前发布版本：TldHacks V13.0（最小安装包、完整版、终极版，2026-11-24，' + NEWS + 'V12.9（2026-11-18）'),
    ('默认按 V12.9 和游戏 2.60 回答', '默认按 V13.0 和游戏 2.60 回答'),
    ('先让他整包换 V12.9 再看', '先让他整包换 V13.0 再看'),
    ('| 08 最上面一节，整包换 V12.9 |', '| 08 最上面一节，整包换 V13.0 |'),
    ('换 V12.9 里的 SCPlusFix++', '换 V13.0 里的 SCPlusFix++'),
])

edit('01_下载与版本.md', [
    ('下面按 V12.9 写', '下面按 V13.0 写'),
    ('1_TldHacks-v12.9最小安装包_只有修改器 | TldHacks-v12.9-最小安装包', '1_TldHacks-v13.0最小安装包_只有修改器 | TldHacks-v13.0-最小安装包'),
    ('| 1_TldHacks-v12.9完整版_带其他mods例如地图 | 材质包备份.001 .002 .003 .004 | V12.9 完整版分卷',
     '| 1_TldHacks-v13.0完整版_带其他mods例如地图 | 材质包备份.001 .002 .003 .004 | V13.0 完整版分卷'),
    ('| 2_TldHacks-v12.9终极版_更多MOD食物衣服_适配最新铁路DLC | 终极版材质包备份.001 到 .182 和 终极版_安装说明.txt | V12.9 终极版分卷',
     '| 2_TldHacks-v13.0终极版_更多MOD食物衣服_适配最新铁路DLC | 终极版材质包备份.001 到 .182 和 终极版_安装说明.txt | V13.0 终极版分卷'),
    ('| MoreBunkers-v1.4_更多地堡三个新地堡_适配2.59_解压到游戏根目录.zip | 更多地堡 v1.4 |',
     '| MoreBunkers-v1.5_更多地堡三个新地堡_适配2.60_解压到游戏根目录.zip | 更多地堡 v1.5 |'),
    ('当前发给群里的是 TldHacks V12.9（11 月 18 日），适配游戏 2.60 版（11 月 6 日的热补丁）。',
     '当前发给群里的是 TldHacks V13.0（11 月 24 日），适配游戏 2.60 版（11 月 6 日的热补丁）。' + NEWS + 'V12.9（11 月 18 日）'),
    ('群友说找不到 V12.8、V12.7 是正常的，让他下 V12.9。', '群友说找不到 V12.9、V12.8 是正常的，让他下 V13.0。'),
    ('还在用旧包的先整包换成 V12.9。', '还在用旧包的先整包换成 V13.0。'),
])

edit('02_安装_沙盒.md', [
    ('   - version.dll\n', '   - winhttp.dll（V12.9 和更早的包是 version.dll）\n'),
    ('装对了以后 version.dll 和 tld.exe 是同一级。',
     '装对了以后 winhttp.dll 和 tld.exe 是同一级。根目录还有旧包留下的 version.dll 要删掉，两个只留一个。'),
    ('  version.dll              ← 新拖进来的', '  winhttp.dll              ← 新拖进来的'),
    ('Steam 更新有可能覆盖掉 version.dll。菜单突然不出来就先看根目录还有没有 version.dll，缺了重新拖一次。游戏能启动但 mod 管理器没起来的，把 version.dll 改名成 winhttp.dll 试试。',
     'Steam 更新有可能覆盖掉 winhttp.dll（旧包是 version.dll）。菜单突然不出来就先看根目录还有没有它，缺了重新拖一次。还在用旧包、游戏能启动但 mod 管理器没起来的，把 version.dll 改名成 winhttp.dll 试试。'),
])

edit('08_故障排查.md', [
    ('1. 根目录有没有 version.dll，它必须和 tld.exe 同一级，不能在 MelonLoader 文件夹里面。',
     '1. 根目录有没有 winhttp.dll（V12.9 和更早的最小包、完整版是 version.dll），它必须和 tld.exe 同一级，不能在 MelonLoader 文件夹里面。'),
    ('根目录里 version.dll 和 winhttp.dll 只留一个，终极版用的就是 winhttp.dll。',
     '根目录里 version.dll 和 winhttp.dll 只留一个。V13.0 起三个包都用 winhttp.dll。\n\n'
     '装了 Major Miseries 一启动就闪退（MelonLoader 黑框走到一半游戏没了）：V12.9 和更早的 TldHacks 和它冲突，换 V13.0 就好。'),
])

edit('07_整合模组清单.md', [
    ('| MoreBunkers | 更多地堡 v1.4（10 月 26 日起进完整版）。', '| MoreBunkers | 更多地堡 v1.5（10 月 26 日起进完整版）。'),
    ('| MoreBunkers v1.4 |', '| MoreBunkers v1.5 |'),
])

edit('06_功能清单.md', [
    ('内容是 V12.9。', '内容是 V13.0。'),
])

edit('10_版本历史.md', [
    ('## 沙盒版 V12.9（2026-11-18，当前版本）\n',
     '## 沙盒版 V13.0（2026-11-24，当前版本）\n\n'
     '修复版，按 N 网和群里的反馈修。和 Major Miseries 一起装时启动就闪退（TldHacks 挂在一个空函数上的补丁和它的补丁落在同一个地址，互相调用）。'
     '另外两个挂在共用地址上的补丁（忽略上锁、快速拆解收尾）换成别的补丁，功能不变。'
     '最小包和完整版的 MelonLoader 注入器改名 winhttp.dll，旧的 version.dll 要删掉。'
     '物品稀有度 1.2.1：步枪伤害、装填时间、卡壳几率、生火时间、拆解时间的词条真的生效，撬棍这类不能采集尸骸和拆解的工具不再抽到这些词条，旧存档里已有的读档时清掉。'
     'SCPlusFix++ 2.1.0 修了进出场景偶尔报 The scene is invalid，游戏是英文时设置页显示英文。'
     'MoreBunkers 1.5.0：2.60 会换掉新舱口的门编号，现在改回来，进新地堡能补货；建舱口出错不再留下半个舱口。剧情版重新打包。\n\n'
     '## 沙盒版 V12.9（2026-11-18）\n'),
])
print('ok')
