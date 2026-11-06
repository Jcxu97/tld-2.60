# HANDOFF: TldHacks

> Last updated: 2026-11-06 23:15

## 当前目标
发 V12.4(悬停大图 + V12.3 之后的几处修复),网盘、腾讯文档、群资料库、B站演示视频一起更新。

## 已完成(本轮)
1. 物品生成器悬停大图 `src/ItemPreview.cs`。鼠标停在某行的生成按钮上，另一半屏幕画原生图标、名字、描述。图标顺序是 ico_GearItem__ / DecorationItem.IconReference / SCPlus 图标包，都没有就把 LOD0 网格复制到第 31 层现拍一张。只留 16 条，挤出去就释放。主菜单 GUI.Window 回调晚于 OnGUI,所以按帧号读上一帧的悬停行
2. 搜索框左边加显示图片开关，存在 Settings.SpawnerPreview。用户进游戏测过，说可以
3. V12.4 已打包(TldHacks 66fc8190,终极版 182 卷)。夸克最小包、完整版已传，群资料库 00 01 06 07 10 已同步(md5 一致),鲸鲸 rules.md 第 22 条
4. 演示视频 BV1Zs4z6CEpc 已过审，工程在 bili-game-pipeline/projects/tld-v124-preview

## 下一步
1. 夸克终极版(`release.py upload ul`)传完后跑 `browser-harness < _tools/release/bd_prep124.py`,再 `python bd_up124.py sb`、`python bd_up124.py ul`
2. 腾讯文档：tq_verify + compare 确认线上没手改，再 `bump124_doc.py`、build、tq_paste、读回比对
3. commit + push

## 未决问题
1. 启动偶发闪退(coreclr 0xc0000005,HarmonyInit 读补丁类特性，在 TldHacks 之后的 mod),继续观察
2. 进神秘湖崩溃(玩家报的)本机复现不出，等玩家的 `MelonLoader\Latest.log` 和 `Player.log`
3. 现拍图假定家具正面朝 +Z,个别会拍成侧面，用户没报
4. MoreBunkers 工作区里 10-31 的改动仍未提交

## 关键文件
1. `src/ItemPreview.cs`、`src/Menu.cs`(DrawItemSearchBox、生成器行循环)、`src/Settings.cs`
2. `src/Furniture.cs`、`src/FurnitureDatabase.cs`、`../SCPlusFix/SCPlus/SCPMain.cs`
3. `../_tools/release/release.py`、`ult124_pack.py`、`bd_prep124.py`、`bd_up124.py`、`kb124.py`
4. `../_work/release/tencent_doc/bump124_doc.py`
