# HANDOFF: TldHacks

> Last updated: 2026-11-05 09:30

## 当前目标
TldHacks V12 已发(最小包、完整版、终极版传夸克和百度,腾讯文档、群知识库、鲸鲸第 14 条规矩已改),等玩家反馈。新功能都没进游戏实测,用户说相信直接发。

## 已完成(本轮)
0. 11-05 物品生成器加"家具"栏(773 条,没进游戏测)。游戏自带装饰品组件的 762 件由 `src/Furniture.cs` 直接生成进背包装饰品;弹药工作台、铣床、锻炉、三种炉子、煤箱、柴火箱等 11 件转给 SCPlusFix 新加的 `SCPlus.Spawner.SpawnCarryable`(照读档重建身上器械那条路),SCPlus 补了煤箱定义。清单由 `_work/furniture/scan.py` 扫资源包、`gen.py` 生成 `src/FurnitureDatabase.cs`
1. 商人新开关"解锁原版限制"(`TraderUnlockModeItems`,商人卡片单独一行)。原版 `FilterExchangeData` 调 `IsGainedItemValidInCurrentGamemode`,它问预制体 `ShouldDisableForCurrentMode(GameObject)`,入侵者和悲惨模式里斧子、步枪、精工箭被滤掉,和信任无关(原版设计)。开着时只在这次调用里放行模式检查;奖励在 `ExchangeBox.PrepareAndShowRewards` 后去掉 `DisableObjectForXPMode`,防扔地上消失
2. 火车卡片新增鲸油取暖器三项(不耗油、耗油倍率、温度加成,`SteamTrainCheats.cs`)和鲸油罐上限、油桶上限(0 到 2000 升,0 是原版 5 升和 4 升)加两个合并按钮(`OilCans.cs`)。油桶上限管 `LIQUID_Kerosene` 的所有容器,原版生锈油桶已从解包数据核对
3. V12 同时带出 10-31 那批没提交的改动(DoubleBarrel 后坐力和空弹壳、空地堡日志刷屏、mod 技能进技能页、mod 枪弹归武器类),commit cd1ae17
4. 终极版按用户要求带上 10-31 新装的 CoastalFulmar、DoubleBarrel、Episode5ShotgunPrototype、Episode5SurvivalItems,182 卷;网盘文件夹名去掉了 _ZHAOCHUN授权同款。照旧不带 TldHacks.json、ItemPicker.json、PerfFix
5. `release.py` 找分卷的通配符从 `.0*` 改成 `.[0-9]*`,原来超过 99 卷时 .100 以后会漏传

## 下一步
1. Nexus(mod 119)要不要换成 V12 先问用户
2. 背包检查面板里的"添加燃料"动作这次做成菜单按钮;原版加燃料按钮按煤油灯/取暖器组件硬编码,要接进去得进游戏边看边改

## 未决问题
1. 用户截图里 2000 升的鲸油罐来源不明,TldHacks 之前没有改液体容量的代码
2. v10.6 到 V12 的修复和新功能都还没收到实测反馈
3. MoreBunkers 工作区改动仍未提交

## 关键文件
1. `src/CheatsPatches.cs`(商人段)、`src/DynamicPatch.cs`(商人和铁路 DLC 段的 Spec)
2. `src/SteamTrainCheats.cs`、`src/OilCans.cs`、`src/MenuTweaks.Cards.cs`(CardTrader、CardSteamTrain)
3. `../_tools/release/release.py`、`ult105.py`、`bd_prep.py`、`bd_prep_ul.py`、`bump12.py`
4. `../_work/release/tencent_doc/doc.txt`、`bump12_doc.py`
