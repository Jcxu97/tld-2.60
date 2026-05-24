# HANDOFF — TldHacks
> Last updated: 2026-05-18 19:32

## 当前目标
v6.8.3 已编译部署:移除保温瓶增强整合(原 mod 与 2.55 不兼容)

## 已完成(本轮)
- v6.8.3 删除 ImprovedFlasks 整合 —— 原版 ImprovedFlasks 1.2.3 假设保温瓶里装 GearItem(咖啡杯/茶杯),TLD 2.55 改成液体容器(AddLiquid/RemoveLiquid),整合代码 GetAllItems 永远返回空 → 报 empty + radial 没选项 + 不能直接喝。删 IntegratedPatches_ImprovedFlasks.cs + 8 个 DynamicPatch Spec + Cheats/Settings/MenuTweaks 的 QoL_ImprovedFlasks 字段
- v6.8.2 修复堆叠材料制作秒吞光:删 Patch_CraftingOp_Update Prefix 里 m_HoursToSpendCrafting=100 一行,vanilla ConsumeMaterials 不再被 200 倍放大

## 下一步
- 用户验证 v6.8.3:Tab QoL 第三列底部"保温瓶增强"应已消失,vanilla Panel_InsulatedFlask UI 仍可用
- 用户验证 v6.8.2:堆叠材料(信号棒/箭/熊皮 stacked)制作消耗按配方所需扣

## 未决问题
- 无 —— 保温瓶 vanilla UI 在 2.55 自带工作,玩家走 Panel_InsulatedFlask 仍能用

## 关键文件
- D:\Github\tld--2.55\TldHacks\src\IntegratedPatches_ImprovedFlasks.cs (已删)
- D:\Github\tld--2.55\TldHacks\src\DynamicPatch.cs (line 560 Spec 段已清)
- D:\Github\tld--2.55\TldHacks\src\Cheats.cs (QoL_ImprovedFlasks 字段+sync 删)
- D:\Github\tld--2.55\TldHacks\src\Settings.cs (字段删)
- D:\Github\tld--2.55\TldHacks\src\MenuTweaks.cs (toggle UI 删)
- D:\Github\tld--2.55\TldHacks\src\CheatsPatches.cs (Patch_CraftingOp_Update v6.8.2 修)
- D:\Github\tld--2.55\TldHacks\src\TldHacks.csproj (Version=6.8.3)
- D:\Github\tld--2.55\TldHacks\src\ModMain.cs / Menu.cs (版本号同步)
