# HANDOFF: TldHacks

> Last updated: 2026-11-06 12:00

## 当前目标
TldHacks V12.3 已发(11-06,最小包、完整版、终极版传夸克和百度,腾讯文档、群知识库、鲸鲸第 21 条规矩已改)。这一版的改动都没进游戏实测,用户说不测直接发。

## 已完成(本轮)
0. 11-06 V12.3。家具栏原生家具摆完回屋消失:旧写法在不激活的临时物体下实例化,Placeable.Awake 没跑,AddDecoration 里的 MoveToPlayer 因 guid 为空不生效。改走游戏的 `InstantiateDecorationItemInPlayerInventory`,生成时临时关 SCPlus 的 injectPdids。主页锁 & 容器加无限负重 `InfiniteCarry`(复用 Patch_TechBackpack,上限写 99999)。终极版里 Episode5SurvivalItems / Episode5ShotgunPrototype 用 ilfix 把 `GameManager.m_ActiveScene` 改成空值安全(删存档回主菜单时它是 null,每帧抛空引用),原件在 %TEMP%\e5orig。游戏本体 11-06 07:00 更新过,包里的 Il2CppAssemblies 是旧的,玩家第一次启动会重新生成
1. 物品生成器加"家具"栏(773 条)。游戏自带装饰品组件的 762 件由 `src/Furniture.cs` 直接生成进背包装饰品;弹药工作台、铣床、锻炉、三种炉子、煤箱、柴火箱等 11 件转给 SCPlusFix++ 的 `SCPlusPP.Spawner.SpawnCarryable`(照读档重建身上器械那条路)。清单由 `_work/furniture/scan.py` 扫资源包、`gen.py` 生成 `src/FurnitureDatabase.cs`
2. SCPlusFix 改名 SCPlusFix++(作者 AKUL,2.0.0,文件 `Mods\SCPlusFix++.dll`)。命名空间换成 `SCPlusPP`,MelonPriority -1000 先注册,`SCPMain.OnEarlyInitializeMelon` 给 `MelonBase.Register` 挂前缀,拦掉程序集名是 SafehouseCustomizationPlus 的 mod(原版和旧修复版),玩家不用删原版。ModData 名字还是 SafehouseCustomizationPlus,存档两边通用。设置文件跟着程序集名变成 `SCPlusFix++.json`
3. 最小包加了 SCPlusFix++.dll、它要的 ModComponent.dll 和 AudioManager.dll、预设 SCPlusFix++.json。`release.py` 的 EXTRAS stage 改成列表
4. MoreBunkers 先找 `SCPlusPP.SCPMain` 再找 `SCPlus.SCPMain`。终极版只换了 TldHacks、MoreBunkers、SCPlusFix++ 三个(`_tools/release/ult122.py`),别的和游戏里一致

## 下一步
1. 进游戏验证:Mods 里同时放原版 dll 时日志有"SCPlusFix++ 已代替";家具栏生成铣床、炉子、煤箱后存档读档还在
2. Nexus(mod 119)要不要换成 V12.2 先问用户

## 未决问题
1. 游戏 Mods 里还留着旧的 SafehouseCustomizationPlus.dll,正好是兼容场景,没挪
2. MoreBunkers 工作区里 10-31 的改动(Bunkers、Layouts.g、Settings)仍未提交,Stock.cs 这次连同那几行一起提交了

## 关键文件
1. `src/Furniture.cs`、`src/FurnitureDatabase.cs`、`../SCPlusFix/SCPlus/Spawner.cs`、`../SCPlusFix/SCPlus/SCPMain.cs`
2. `../SCPlusFix/Properties/AssemblyInfo.cs`、`../SCPlusFix/SafehouseCustomizationPlus.csproj`
3. `../_tools/release/release.py`、`bump122.py`、`ult122.py`、`ult105.py`、`bd_prep.py`
4. `../_work/release/tencent_doc/doc.txt`、`bump122_doc.py`
