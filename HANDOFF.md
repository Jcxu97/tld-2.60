# HANDOFF — tld--2.55

> Last updated: 2026-10-01 03:25

## 当前目标

TraderMoving v1.0(跨场景搬无线电和交易箱,搬过去功能完整)已部署,等用户进游戏测。TldHacks v9.5 和剧情版 V1.3 已发版,细节见 `TldHacks/HANDOFF.md`。

## 已完成(本轮)

- TraderMoving 重写成 v1.0,旧版源码在 `TraderMoving/backup_v0.2.1/`
- 交易箱照 ImprovedTrader 现搭,下单送货改到搬过的箱子
- 无线电原屋子用原件,别处用原件复制的模板,读档后后台加载 DLC 场景取模板,失败退随身无线电
- 两轮代码审查共 15 处问题已修,编译 0 警告 0 错误
- 已部署到 Mods,旧 DLL 和设置备份为 `.backup-v021`,存档备份在 `Survival.backup-traderMoving-20261001`

- 01:40 后加了放下时的蓝色虚影(游戏自带摆放,`Placement.cs`)、交易箱底面对齐、装修模式里"拿起"接管(`ScPlusPickup.cs`),审查九条修了七条,已部署(备份 `.backup-v100-0140`)
- 02:30 用户实测放不下、读档后没复制到无线电:改成按场景名加载 DLC 场景,虚影整棵设忽略射线层,已部署(备份 `.backup-v100-0233`)
- TldHacks 修了设置读取崩溃(`TimeScaleInfo` 缺 `[Name]`)和信任满值不即时生效,全部包已重打

## 下一步

- 用户 02:37 到 02:52 实测:摆放、跨场景、读档复制、交易送到搬过的箱子都通了
- 已单独出包 `Desktop\TLD\TraderMoving-v1.0_搬运商人无线电和交易箱_解压到游戏根目录.zip`(DLL 5f1649fd + ModSettings + ModData + 使用说明);完整版包暂不动,用户多玩几天再决定换掉 ImprovedTrader
- 第 5 章版 TldHacksEp5 V1.0(工程 `TldHacksEp5/`,编译用 episode5 的 2.54 文件)已部署到 `tld_dlc\episode5\Mods` 并打包到 `Desktop\TLD\The Long dark 故事剧情模式_可能有bug没测试\剧情模式第五章\`,用户不测,没进过游戏

## 未决问题

- 待用户拍板:即时交易要不要跳过任务单;到来天数在入侵难度 30 到 39 不生效要不要改
- 没实测的风险见 memory `project_tld_tradermoving_v1`

## 关键文件

- TraderMoving/src/RadioClone.cs — 无线电模板复制和后台加载
- TraderMoving/src/World.cs — 每个场景摆放、藏原件、搭交易箱
- TraderMoving/src/CarryState.cs — 抱起和放下
- TraderMoving/src/TradeGuard.cs — 交易跟着箱子改送货地点
- TraderMoving/src/RemoteTrade.cs — 随身无线电下单
- TldHacks/HANDOFF.md — TldHacks v9.5 明细
