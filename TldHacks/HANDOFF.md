# HANDOFF: TldHacks

> Last updated: 2026-10-29 23:45

## 当前目标
TldHacks v10.3 已发布到夸克 TLD V2.58 Hack 和百度 TLD HACK V2.58(最小包、完整版、终极版 64 分卷),腾讯文档和群资料库已同步。

## 已完成(本轮)
1. 物品生成器删掉 29 种原版食谱未烹饪半成品(`GEAR_Uncooked*`,刷出来用不了,显示名又和熟的一样)
2. 免甜点疼真正生效:`CausesHeadacheDebuff.Apply` 前缀跳过(以前只有开关没有补丁)
3. 物品 & 传送页:传送列表进内层滚动区,和物品生成器中间加可拖分割栏,高度存 `SpawnerTeleportH`
4. 开修改器时自动开 ESC 暂停菜单(`MenuPauseGame`,默认开),关修改器时只关自己开的那个
5. release.py 改成按 fid 传夸克三个编号文件夹(min / full / ul),换版自动改文件夹名;bh_quark.py 加 rename

## 下一步
1. 火车加注加不进去、勋章启用列表读档后丢,还在等用户日志
2. 百度分享链接拿到后补进腾讯文档和资料库(现在两边都没写百度链接)
3. 不捡丢物改成按 ObjectGuid 存进 ModData(键 ownDrops),等用户实测:摆火把、存档重进、一键搜刮不收;改前放的要重摆一次
3. 不捡丢物改成按 ObjectGuid 存进 ModData(键 ownDrops),等用户实测:摆火把、存档重进、一键搜刮不收;改前放的要重摆一次

## 未决问题
1. 钢锯和重锤新档不刷:10-30 拆场景包定了是原版设计。入侵者和悲惨藏常规点,入侵者专用那组按开局抽的研究方案刷(林狼雪岭钢锯 1/2/4 号,重锤 1/3/4 号),抽错方案整图没有;不用修
2. 修改器窗口盖在暂停菜单上,点按钮会不会点穿到后面的暂停菜单按钮,还没收到反馈
3. 剧情模式两个包的 MelonLoader 可能还是更新前的程序集,没查

## 关键文件
1. `src/Menu.cs`(暂停菜单、分割栏)、`src/CheatsPatches.cs`(免甜点疼)、`src/ItemDatabase.cs`
2. `src/Settings.cs`、`src/ModSettingsEnData.cs`、`src/MenuUi.cs`(说明文字)
3. `../_tools/release/release.py`(`net_folders`、`ul_dir`)、`bh_quark.py`、`bh_baidu.py`、`baidu_upload.py`
4. `../_work/release/staging/sb_full/使用说明.txt`、`staging/ultimate/使用说明.txt`
