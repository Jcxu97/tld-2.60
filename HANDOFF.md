# HANDOFF — tld-2.60
> Last updated: 2026-11-28 14:30

## 当前目标

V13.0 已发版,等群友和 N 网反馈。下一版要带上厄难 mod 物品散落刷新修复(PR 分支 modcomponent-misery-spawn)。

## 已完成(本轮)

- 厄难散落刷新:ModComponent 7.0.0 把厄难(模式 18)当 Other,mod 物品按朝圣者 1 倍刷(上游 master 也没修)。新工具 `_tools/mcmisery` 直接改 DLL,加 DifficultyLevel.Misery 和"厄难/极低概率"滑条,默认 0.1。全量反编译 diff 只有这几处,ILVerify 0 错误。
- release.py pack 打 sb 时调 patch_modcomponent,给游戏 Mods 和 staging 的 sb_min / sb_full / ultimate 打补丁,已打过的跳过。本地游戏和三份 staging 现在都是补丁版(md5 7119b0d9)。
- V13.0(11-25):TldHacks 13.0、SCPlusFix++ 2.1.0、MoreBunkers 1.5.0、RarityRework 1.2.1 已打包上传网盘和 N 网,资料库、腾讯文档已同步。

## 下一步

- 合并 PR 后下次 `release.py pack` 照常跑,ModComponent 补丁会自动进包。终极版走 ult*_pack.py,打包前确认 staging/ultimate 里的 ModComponent.dll 是补丁版。
- 等 N 网 Sieben4life 发 TraderMoving 世界重置的 Latest.log,hyuni9937 反馈 MoreBunkers 1.5.0 进地堡还空不空。
- 群里或 N 网有人报忽略上锁、快速拆解收尾不对,先看 DynamicPatch.cs 这两处改动。

## 未决问题

- 厄难补丁用户决定不实测,发版后看反馈。生效时 Latest.log 会打 `Spawned 'Misery' items`。原版 DLL 在 `_work/mc_misery/ModComponent.orig.dll`。厄难刷不刷枪(GetFirearmAvailability 对 18 返回 All)没查证,没动。
- TraderMoving 世界重置没复现;MoreBunkers 空地堡是推断修复,没进游戏实测。
- 测试编 TldHacks 加 `-p:NoDeploy=true`;不要无界面启动正式游戏(TldHacks 会当成崩溃,下次进安全模式重置开关)。

## 关键文件

- `_tools/mcmisery/Program.cs`、`_tools/release/release.py`(patch_modcomponent)
- `TldHacks/src/Cheats.cs`、`TldHacks/src/DynamicPatch.cs`
- `SCPlusFix/SCPlus/SettingsEn.cs`、`MoreBunkers/src/Patches.cs`
- `_tools/release/ult130_pack.py`、`bump130.py`、`kb130.py`
