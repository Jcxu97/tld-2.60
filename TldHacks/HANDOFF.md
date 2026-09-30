# HANDOFF: TldHacks

> Last updated: 2026-10-01 00:20

## 当前目标
v9.5 / 剧情 V1.3 已发版。规矩是每次改完都部署到游戏,再重打桌面 `TLD\` 的最小包(中英两个 zip)、完整版分卷和 `游戏材质包_backup.bin`,改到剧情版就连剧情包一起打。

## 已完成(本轮)
- 商人:信任满值和滑条走原版 `AddTrust`(第一次满格解锁 DLC 成就),`TraderTrust.HealOnce` 补旧存档;即时交易 `Patch_TraderManager_CloseTrade` 关箱后补调 `CompleteTrade` 并清冷却;商人常驻 `Patch_TraderRadio_IsTraderAvailable`。室内灯光按状态缓存(`HLSource`)。QoL 总开关接上。版本 9.5。
- 物品生成器加 `GEAR_CougarWrap`(美洲狮皮护套),美洲狮几样的重量按资源实测改过。
- 逐件确认跳过 `GEAR_Stick` / `GEAR_Stone`(`GrabAll.IsStickOrStone`),一次全收不变。
- Mod Settings:删掉 `OneClickDisableAll`(pre-flight 把它列进 `RetiredSettingKeys`,老 json 里这行静默去掉、不留 broken 备份);111 个 `[Name]` 改成和游戏内菜单一样,新写的 26 条说明补了英文;`SuperAccuracy` / `TimeScaleInfo` / `LampBurnMultiplier` 用 `SetFieldVisible` 隐藏,字段保留。菜单上两个写错的标签改了(恢复延迟倍率、绘制间隔)。
- 部署:沙盒 d258d36f,剧情 bb3ae457。回退用 `Mods\TldHacks.dll.backup-v95-2300`、`tld_dlc\wintermute\Mods\TldHacksStory.dll.backup-v13-2300`;v9.0 原版在桌面 `TLD\OLD\` 的 zip 里(之前的 `backup-20260930` 已经不在了)。

## 下一步
- 用户进游戏确认 Mod Settings 名字和逐件确认。

## 未决问题
- ItemPicker 查过没坏:每次按 W 都在扫,扫到 0 是 25 米内没东西(同时刻一键搜刮 50 米内只有 0 到 11 件,09-27 的 v9.0 日志也一样)。它只在按下 W 的那一下捡一次,按住不连续捡。
- 两个诊断开关是 internal,pre-flight 只认 public 字段,所以手写进 json 也会被当孤儿清掉,等于用不了。没修。
- 英文 Mod Settings 的名字没对齐菜单(菜单英文是缩写,Mod Settings 是全称)。
- 关掉商人常驻或到来天数后,电台记下的(商人可用)要等挂断或换场景才重算,没修。
- `知识库/data/配置字段默认值_TldHacks.json.csv` 是老 json 生成的,没重做。

## 关键文件
- `src/Settings.cs`:Mod Settings 字段、名字、`HideRetiredFields`。
- `src/ModMain.cs`:pre-flight `RetiredSettingKeys`、即时交易定时检查。
- `src/GrabAll.cs`:一键搜刮、逐件确认。
- `src/CheatsPatches.cs`:商人补丁、`TraderTrust`。
- `src/IntegratedPatches9.cs`:室内灯光 `HLSource`。
- `src/ModSettingsEnData.cs`:英文名字和说明。
- `src/DynamicPatch.cs`:补丁挂载与收尾。
