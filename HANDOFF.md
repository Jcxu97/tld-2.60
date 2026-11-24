# HANDOFF — tld-2.60
> Last updated: 2026-11-25 01:00

## 当前目标

V13.0 已发版(按 N 网反馈修 bug 的修复版),等群友和 N 网反馈。

## 已完成(本轮)

- TldHacks 13.0:删掉 MaybeFlushPlayerDamage 补丁(2.60 空函数,和 Major Miseries 补的 Hypothermia.SetWarmingUp 共用原生地址,启动栈溢出),隔离实例 A/B 实测;再删 Lock.IsLocked(沙盒版)、Panel_BreakDown.ExitInterface 两个共用地址的动态补丁;剧情版编译修好。SCPlusFix++ 2.1.0、MoreBunkers 1.5.0、RarityRework 1.2.1 一起发。
- 打包:最小包、完整版 4 卷、终极版 182 卷、剧情 1~4 章 2 卷、第五章 3 卷,全部解压比对通过;最小包和完整版的注入器改名 winhttp.dll。本地游戏已部署。
- 网盘:夸克和百度三个主文件夹改名 v13.0 并核对(1 / 4 / 183,无重复),夸克剧情两个文件夹也换了;选装里 MoreBunkers v1.5,单独版里 RarityRework、SCPlusFix++ 换新(百度那边之前没有这两个)。旧件在两边 OLD。
- N 网:162 / 164 / 168 换主文件(13.0 / 1.5.0 / 2.1.0),162 / 163 / 164 / 168 的 ModSettings 链接改成 DigitalzombieTLD,162 加了 SCPlusFix++;9 条评论回复已发并读回。
- 资料库 00 01 02 06 07 08 10 同步到 server(容器 md5 一致),鲸鲸 rules.md 加第 20 条;腾讯文档整篇覆盖到 V13.0。

## 下一步

- 等 N 网 Sieben4life 发 TraderMoving 世界重置的 Latest.log,hyuni9937 反馈 MoreBunkers 1.5.0 进地堡还空不空。
- 群里或 N 网有人报忽略上锁、快速拆解收尾不对,先看 DynamicPatch.cs 这两处改动。

## 未决问题

- TraderMoving 世界重置没复现,本版不改代码。
- MoreBunkers 空地堡是推断修复,没进游戏实测。
- 测试编 TldHacks 加 `-p:NoDeploy=true`;不要无界面启动正式游戏(TldHacks 会当成崩溃,下次进安全模式重置开关)。

## 关键文件

- `TldHacks/src/Cheats.cs`、`TldHacks/src/DynamicPatch.cs`
- `SCPlusFix/SCPlus/SettingsEn.cs`、`MoreBunkers/src/Patches.cs`
- `_tools/release/bump130.py`、`ult130_pack.py`、`kb130.py`、`bd_prep130.py`、`bd_check130.py`、`qcheck130.py`、`xz130_quark.py`、`bdxz130_prep.py`、`bdxz130_up.py`
- `_work/release/tencent_doc/bump130_doc.py`、`doc.txt`
- `D:/GameWork/tld/rarity-check-2.60/`(隔离实例和各次运行日志)
