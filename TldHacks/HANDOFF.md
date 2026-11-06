# HANDOFF: TldHacks

> Last updated: 2026-11-06 21:40

## 当前目标
修 V12.3 发出去后的几个 bug,修完重新打包上传(还没打包，没上传)。

## 已完成(本轮)
1. 刷出来的铣床、锻炉等器械存档读档后丢失。原因是原版 SCPlus 和 SCPlusFix++ 同时在跑，存档里写的是原版类型名 `SCPlus.CarryableSaveDataProxy`,SCPlusFix++ 读档时 InvalidCast 整段失败。`SCPlusFix/SCPlus/SaveLoadPatches.cs` 读档前把 `SCPlus.` 换成 `SCPlusPP.`(3632518)
2. SCPlusFix++ 挂在 `MelonBase.Register` 上的前缀从没触发，原版照常注册。改成把原版 melon 的 Info 换成本 mod 的，借 MelonLoader 同名同作者查重拒掉它(0495aa0)
3. ilfix 对修过的 dll 重跑会克隆出第二个 TldFixCalls,Architect 加载报 Duplicate type。现在先换掉旧克隆。ilfix 改成 net6 编译，以前 net8 版克隆进去的 System.Runtime 8.0 引用在重跑时改回 6.0。Architect、PerfectPlacement、Episode5ShotgunPrototype、Episode5SurvivalItems 已重新处理(0495aa0)
4. 以上新 dll 已放进游戏 Mods 和 `_work/release/staging` 的 sb_full、sb_min、ultimate。原件备份在 `%TEMP%\ilfix_net6_backup_20261106`

## 下一步
1. 进游戏核对：日志有 `SCPlusFix++ 已代替` 和原版 `same Name and Author` 警告，没有 `System.Runtime, Version=8` 报错;刷铣床放身上，存档读档后还在
2. 用户说可以打包上传后跑 `_tools/release/release.py pack / upload`
3. 进神秘湖崩溃(玩家报的，卡特大坝走出去或传送都崩)本机复现不出，等玩家的 `MelonLoader\Latest.log` 和 `Player.log`

## 未决问题
1. 启动偶发闪退(11-06 10:35、18:31、21:08),coreclr 0xc0000005,崩在 HarmonyInit 读补丁类特性，位置在 TldHacks 之后那几个 mod。转储没堆数据，定不到 mod。换了 net6 版第五章移植后再观察
2. MoreBunkers 工作区里 10-31 的改动仍未提交

## 关键文件
1. `../SCPlusFix/SCPlus/SCPMain.cs`、`../SCPlusFix/SCPlus/SaveLoadPatches.cs`
2. `../_tools/ilfix/Program.cs`、`../_tools/ilfix/ilfix.csproj`
3. `src/Furniture.cs`、`src/FurnitureDatabase.cs`、`../SCPlusFix/SCPlus/Spawner.cs`
4. `../_tools/release/release.py`
