# HANDOFF: TldHacks

> Last updated: 2026-10-04 10:00

## 当前目标
v9.7(沙盒)、剧情第 5 章 V1.2、1~4 章 V1.5 已打包上传,等用户进游戏测。三份说明的"改了什么"写的是 v9.6 首发以后的全部改动(地图管理、收藏品地图、完整地堡、CE 14 项、菜单重排等)。

## 已完成(本轮)
- 完整地堡存档改名 `MapManagerPatches.FixSave`:BunkerLocationSaveData 是值类型,改完写回列表。存档补丁挂到 `RestoreDone` 把复制品全换回原版才卸,找不到原版的跳过不挡后面的
- CE:陷阱必中先存已抓数再加回;扑倒的三个值第一次进来记原值,关开关时 `Patch_CE_StruggleUpdate.RestoreDone` 写回;放下就抓到只推一个判定间隔
- 一键清图:容器收完一律标已搜刮(修再开多一份);剧情里不能用清任务物品(StoryGuard)
- 清除负面也清美洲狮伤口(HaveAnyActiveWounds)和欺骗死亡;传送前存档和新场景数据都用当前的 m_SceneSaveFilenameCurrent(MoreBunkers 地堡同一内部场景各有编号)
- 语言自动跟游戏(I18n.GameReady 后读 Localization.Language);地图管理第 5 章默认关、全开热键默认不绑;收藏品地图去掉钥匙和外域传说任务纸条(`_work/collect/gen_cs.py` 的 QUEST)
- 部署和网盘一致:沙盒 80d1a39c、第 5 章 9d4f83a8、剧情 37d1824e

## 下一步
- 用户进游戏看:`[DynPatch]` 有没有挂失败;关完整地堡开关后日志 `[MapM] N bunkers set back`;CE 扑倒关开关后数值回原样;语言自动
- 陷阱必中和放下就抓到同时开时,每进一次图已放的陷阱会再提前判定一次(`_pushed` 按实例指针记,换场景就变),要不要改看用户

## 未决问题
- 刷动物按钮缺灰狼、饥饿狼、极光狼熊美洲狮(`Menu.cs:1063`);免动物伤害不挡驼鹿;吓跑模式排除列表缺 `AiMode.Disabled`
- 两个诊断开关是 internal,pre-flight 只认 public 字段
- 网盘 OLD 里有两个"替换下来的"文件夹可以删(删网盘文件要先问用户)

## 关键文件
- `src/MapManagerPatches.cs`:地图管理和完整地堡
- `src/CeFeatures.cs`、`src/MenuTweaks.Ce.cs`:CE 14 项
- `src/MapClear.cs`:一键清图
- `src/Cheats.cs`、`src/CheatsPatches.cs`:清除负面、伤病守卫
- `src/CheatsExtra.cs`:快速传送
- `src/DynamicPatch.cs`:补丁挂载表
- `../_tools/release/release.py`、`bh_quark.py`:发版脚本和网盘接口
