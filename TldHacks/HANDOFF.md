# HANDOFF: TldHacks

> Last updated: 2026-11-07 01:40

## 当前目标
发 V12.5(一键清图和一键搜刮漏收斧头、猎刀、重锤、钢锯的修复),网盘、腾讯文档、群资料库一起更新。

## 已完成(本轮)
1. 根因靠解包神秘湖场景查到。刀斧锯带 BodyHarvestItem(剥皮速度数据),清图和一键搜刮误当尸体部件跳过。重锤钢锯带 MissionObjectIdentifier,m_Id 为空只有 research 分组标签,清图误当任务物品跳过。改成只有 m_Id 非空才算任务物品(9e26061),Codex 复核同意。没进游戏实测
2. V12.5 已打包(TldHacks baee8081,终极版 182 卷)。夸克三个包传齐，终极版第一次核对超时缺 14 个，用 `_tools/release/ul_fill.py` 补传后逐个比大小一致
3. 百度旧包挪进 OLD 的 1107-0132 目录，三个文件夹已改名 v12.5
4. 群资料库 00 01 06 10 已同步(md5 一致),鲸鲸 rules.md 第 23 条

## 下一步
1. 请用户进游戏清一张图，确认四样工具都收走
2. 玩家报的种植模组物品刷不出、种植盒配方丢失，等玩家说清是哪件、在哪刷、哪个配方，再要他的 Latest.log。TldHacks 里蓝图解锁、BlueprintCleaner 兼容、任意制作三处已查过，不会删配方

## 未决问题
1. 启动偶发闪退(coreclr 0xc0000005,HarmonyInit 读补丁类特性，在 TldHacks 之后的 mod),继续观察
2. 进神秘湖崩溃(玩家报的)本机复现不出，等玩家日志
3. MoreBunkers 工作区里 10-31 的改动仍未提交

## 关键文件
1. `src/MapClear.cs`、`src/GrabAll.cs`
2. `../_tools/release/bump125.py`、`ult125.py`、`ult125_pack.py`、`ul_fill.py`、`bd_prep125.py`、`bd_up125.py`、`kb125.py`
3. `../_work/release/tencent_doc/bump125_doc.py`
