# HANDOFF — TldHacks
> Last updated: 2026-05-13 21:40

## 当前目标
**未决 bug**:虚拟堆叠 label 视觉消失 — 用户报告"打开背包/容器,单击堆叠物品 / 滚轮滑动 / 把物品放进容器再拿出来"后,物品图标右上角的 "x5" 视觉消失,但底层 stack 数据还在。今晚 9 次尝试均失败,**已 git checkout 还原所有代码到 v6.6**。

## 已完成（本轮）
- 全部撤回:Stacking.cs `git checkout HEAD --` 回到 c432404(v6.6 commit)状态
- CheatsPatches.cs 保留 `using System.Linq;` 一行(v6.6 之后某次工作的 LINQ 用法需要,跟 stack bug 无关,不加编译报错)
- 重新编译 + 部署到 Steam Mods/

## 下一步（修 stacking bug）
**前提:必须先要用户给一张 bug 状态的截图/录屏**。今晚 9 次失败的根本原因是数据层 log 显示 `bad=0`(所有字段对、text 写进去了、active/enabled/alpha 都对),但用户视觉仍看到消失 → **"消失的 x5"很可能不是 `m_StackLabel`**,是别的 UI 元素(可能是 vanilla `m_UnitLabel` 显示的 m_Units 数量,或第三方 mod 的 label,或 NGUI 渲染层问题)。盲改没用。

## 已尝试无果的方案(下次别再走)
1. `OnLateUpdate` fast-path 加 `gameObject.SetActive(true)` — 无效
2. 改回每帧扫 + 调完整 `LabelFix.Reapply` — 卡且无效
3. 加 `Patch_Panel_Inventory_SelectGridItem` + `CellSweeper` 扫 m_TableItems — 无效(用户用的是 Panel_Container 不是 Panel_Inventory)
4. 强制 `UILabel.enabled=true` + `alpha=1` + `color.a=1` — 字段确实写对了,视觉仍消失
5. `Reapply` 在 `Counts.TryGetValue` miss 时 fall-back 到 `CountsByGi[gi.Pointer]` — 数据 OK 但用户仍报 bug
6. `OnMoveItem.Postfix` 强制重建 Counts/CountsByGi(vanilla 不一定触发 RefreshTables)— 数据 OK 但仍报 bug
7. cell 不是虚拟 stack 时主动 `SetActive(true)` `m_UnitLabel/m_UnitSprite` — **显示全乱套**(单件物品冒出多余数字)

## 关键发现(留作下次参考)
- TLD 2.55 里"按 I 打开的背包"实际是 `Panel_Container` 类(不是 `Panel_Inventory`)— log `inv=False con=True`
- vanilla `Panel_Container.RefreshTables` 之后**重新 wrap `InventoryGridDataItem` 实例**,`Counts` 字典 key(di.Pointer)在 vanilla body 之后会 stale。但 `CountsByGi`(GearItem.Pointer)稳定 — 这是 fall-back 设计的依据
- `InventoryGridItem` 的 label 字段:`m_StackLabel`(我们的)、`m_UnitLabel`+`m_UnitSprite`(vanilla 真堆叠 m_Units>1 显示)、`m_LiquidLabel`、`m_ConditionLabel`、`m_NameLabel`、`m_WeightLabel`

## 关键文件
- `TldHacks/src/Stacking.cs` — 当前是 v6.6 干净版
- `TldHacks/src/CheatsPatches.cs` — 顶部加了 `using System.Linq;`(保留)
