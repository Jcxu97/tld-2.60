# HANDOFF: TldHacks

> Last updated: 2026-10-05 22:40

## 当前目标
v9.7、第 5 章 V1.2、1~4 章 V1.5 于 10-05 修三个群友报的 bug 后重打上传(版本号不变),没进游戏实测。

## 已完成(本轮)
- 取炭不戴:原 Postfix 查手上时木炭还在 m_QueuedEquipItem 排队。改成 OnCharcoalHarvest / Panel_ActionPicker.TakeCharcoalCallback 开 2 秒窗口,PlayerManager.EquipItem Prefix 挡 m_CharcoalItem
- 尸骸地图图标:`MapMCorpse` 搬起删、室外放下按新位置标、BodyHarvest.BodyHarvestDestroy 前删
- 快速风干:没进过背包的(m_InPlayerInventory / m_BeenInPlayerInventory 都假)不秒,修采树苗检视时临时那根被秒干掉地上
- 部署和网盘一致:沙盒 e9117a73、第 5 章 ab9d892d、剧情 7cb69024

## 下一步
- 群友回话:采树苗多出来那根是风干的还是绿的。绿的就是操作加速(Patch_TimedHold_UpdateHoldInteraction_QuickSearch)让长按二次触发,要对已采的 Harvestable 早退
- 干肉条(GEAR_CookedBarPemmican)刷出来吃不了,要问清症状和有没有开无饥饿
- 进游戏验:取炭两条路、搬鹿后图标、地上鲜皮照常秒干

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
