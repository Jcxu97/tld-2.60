# HANDOFF: TldHacks

> Last updated: 2026-11-09 12:55

## 当前目标
发 V12.7(完整地堡修复、荒凉水湾地堡传送点、完全隐形只挡动物伤害、四件 mod 物品名大小写),网盘、腾讯文档、群资料库一起更新。

## 已完成(本轮)
1. 完整地堡失效根因:换区域读档时原版重建配对,入口已在场景里就当场套上空内部,只改字段太晚。改完字段 Detach+Attach 重挂(4a6a697)。用户实测九个里八个成功
2. 游戏 2.60 起九个区域各一个固定入口(BunkerLocation),PrepperHatch 随机点没了,高难度刷地堡开关没用了,说明已改。荒凉水湾入口在 (-980.19, 216.07, 550.70),传送点和 F9 备用坐标已改(d5e4cf5)
3. 完全隐形以前挡掉所有伤害,改成只挡狼熊美洲狮(65b247d);物品生成器四件 mod 物品名大小写修正;蒸汽火车卡片挪到第二列
4. V12.7 已打包(TldHacks 03c97c13,终极版 182 卷,1140 文件解压比对一致);夸克最小包和完整版、百度最小包和完整版已传且大小一致;群资料库 00 01 06 10 已同步(md5 一致),鲸鲸 rules.md 第 29 条(问怎么更新就说下载最小包覆盖)

## 下一步
1. 核对夸克和百度终极版 182 卷是否传齐,有没有重复件
2. 腾讯文档:tq_verify + compare 确认线上没手改,build.py,FORCE=1 tq_paste.py,再回读比对

## 未决问题
1. 启动偶发闪退(coreclr 0xc0000005,HarmonyInit 读补丁类特性,在 TldHacks 之后的 mod),继续观察
2. FoodsByCalorieWaltz 的 cwfemployeenote1 有数据没 prefab,是那个 mod 自己的问题
3. MoreBunkers 工作区里 10-31 的改动仍未提交

## 关键文件
1. `src/MapManagerPatches.cs`(地堡分配、F9)、`src/CheatsExtra.cs`(传送点)、`src/CheatsPatches.cs`(DamageFilter)
2. `../_tools/release/bump127.py`、`ult127.py`、`ult127_pack.py`、`kb127.py`、`bd_prep127.py`、`bd_up127.py`
3. `../_work/release/tencent_doc/bump127_doc.py`
