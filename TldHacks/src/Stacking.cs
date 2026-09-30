#if !STORY_EDITION
// 2.24 无 Il2Cpp.InventoryGridDataItem —— 整套背包网格数据模型在 2.24 之后重做,
// 本文件(堆叠显示/去重/标签重贴)全部依赖它,逐点手术会切碎 8 个 patch 类且留下
// 功能已死却仍付 Harmony bridge 开销的空壳,所以整文件排除。调用点在 ModMain.OnLateUpdate。
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.IntBackedUnit;

namespace TldHacks;

internal static class Stacking
{
    // OnLateUpdate 在所有 MonoBehaviour.Update 之后跑。
    // 核心改动(v2.7.0,per GPT 诊断):
    // Unity UI 的 InventoryGridItem 会被复用(滚动/切分类时同一 cell GameObject 被重新绑到新 dataItem)。
    // 如果盲目用 SeenItems 里缓存的 (item, di) reapply,会把旧 count 写到新 gi 上 —— 表现为"部分堆叠视觉失效"。
    // 修正:每次 reapply 前 VERIFY item 当前 m_GearItem 还是我们当初 hook 时缓存的 gi。
    // 如果 cell 已经被复用到别的 gear,跳过本次,等 RefreshDataItem Postfix 重新登记。
    // v2.7.32 改回每帧 —— t1 bug:hover 时 label 被游戏重置为 "1",4 帧延迟肉眼可见(67ms)
    //   每帧 reapply SeenItems 里只有 panel 打开时活跃的 cell(几十个),字符串比较非 set,开销可忽略
    private static int _lateFrame;
    private static readonly System.Collections.Generic.List<System.IntPtr> _staleList = new();

    public static void OnLateUpdate()
    {
        // v2.7.60 性能:stacking toggle 关时不跑
        if (ModMain.Settings != null && !ModMain.Settings.StackingEnabled) return;
        // v6.1 性能:每 3 帧扫一次(~50ms),HoverItem/SelectGridItem/Refresh Postfix 覆盖实时操作
        if (++_lateFrame % 3 != 0) return;
        try
        {
            if (StackState.TotalCount == 0) return;
            if (StackState.SeenItems.Count == 0) return;

            // v2.7.75 关键性能:panel 都关着时 SeenItems 是 stale(RefreshTable Clear 但 Close 不 Clear),
            //   每帧遍历 40+ cell × 3 次 IL2Cpp bridge(Pointer / m_GearItem / Reapply)= 每秒 ~7000 bridge。
            //   先 check 两个 panel 的 isActiveAndEnabled,都关了就 Clear + return。
            var inv = StackState.LastInventoryPanel;
            var con = StackState.LastContainerPanel;
            bool active = false;
            try { if (inv != null && inv.isActiveAndEnabled) active = true; } catch { }
            if (!active) { try { if (con != null && con.isActiveAndEnabled) active = true; } catch { } }
            if (!active)
            {
                StackState.ClearAll();
                return;
            }

            _staleList.Clear();

            foreach (var kv in StackState.SeenItems)
            {
                var (item, cachedDi, cachedGiPtr) = kv.Value;
                if (item == null || item.Pointer == System.IntPtr.Zero)
                { _staleList.Add(kv.Key); continue; }

                // 快速过滤：count ≤ 1 的不需要显示堆叠标签,跳过 IL2Cpp 访问
                if (!StackState.TryGetCount(cachedDi.Pointer, out int cachedCount) || cachedCount <= 1)
                    continue;

                Il2Cpp.GearItem curGi = null;
                try { curGi = item.m_GearItem; } catch { _staleList.Add(kv.Key); continue; }
                if (curGi == null) continue;

                if (curGi.Pointer == cachedGiPtr)
                {
                    var label = item.m_StackLabel;
                    if (label != null) label.text = CountStr.Get(cachedCount);
                    // v8.1.1 重量也要每轮跟上。之前这里只补 xN,重量只在
                    // RefreshDataItem / HoverItem / SelectGridItem / OnMoveItem 这几个 Postfix 里写,
                    // 首次渲染之后就没人再写了 —— 表现为要点一下物品才从单件重变成总重
                    LabelFix.ApplyWeightFromDataItem(item, cachedDi, cachedCount);
                }
                else
                {
                    if (StackState.TryGetCountByGi(curGi.Pointer, out int c) && c > 1)
                    {
                        var label = item.m_StackLabel;
                        if (label != null) label.text = CountStr.Get(c);
                        LabelFix.ApplyWeightFromGear(item, curGi, c);
                    }
                }
            }

            for (int i = 0; i < _staleList.Count; i++) StackState.SeenItems.Remove(_staleList[i]);
        }
        catch (System.Exception ex)
        {
            ModMain.Log?.Error($"[OnLateUpdate] {ex}");
        }
    }
}

internal static class CountStr
{
    private static readonly string[] _cache = new string[64];
    static CountStr()
    {
        for (int i = 0; i < _cache.Length; i++) _cache[i] = "x" + i;
    }
    public static string Get(int count) => (uint)count < (uint)_cache.Length ? _cache[count] : "x" + count;
}

internal static class StackState
{
    // v6.9.4 根因修复:count 拆成 Inv(背包侧)/Con(容器侧)两套。
    // 容器面板同时显示两个列表、各自 populate(UpdateFilteredInventoryList /
    // UpdateFilteredContainerList),共用一套字典会被对方 clear 清空。
    // 拆开后各 Postfix 只 clear+重填自己这一侧。di.Pointer/gi.Pointer 在两侧不碰撞(不同实例),
    // 所以读点合并查两套即可。

    // Key = representative InventoryGridDataItem.Pointer, Value = count in that group
    public static Dictionary<System.IntPtr, int> CountsInv = new();
    public static Dictionary<System.IntPtr, int> CountsCon = new();

    // 镜像 map:gi.Pointer → count。click/toggle 回调没有 dataItem 参数时用这个
    public static Dictionary<System.IntPtr, int> CountsByGiInv = new();
    public static Dictionary<System.IntPtr, int> CountsByGiCon = new();

    // 合并查 helper(读点统一走这俩,不直接碰底层字典)
    public static bool TryGetCount(System.IntPtr diPtr, out int count)
        => CountsInv.TryGetValue(diPtr, out count) || CountsCon.TryGetValue(diPtr, out count);
    public static bool TryGetCountByGi(System.IntPtr giPtr, out int count)
        => CountsByGiInv.TryGetValue(giPtr, out count) || CountsByGiCon.TryGetValue(giPtr, out count);
    public static int TotalCount => CountsInv.Count + CountsCon.Count;
    public static void ClearAll()
    {
        CountsInv.Clear(); CountsCon.Clear();
        CountsByGiInv.Clear(); CountsByGiCon.Clear();
        SeenItems.Clear();
        LabelFix.ClearWeightCache();
    }

    // 面板活跃检测:维护轮盘/装备槽/制作面板等会复用同一个 InventoryGridItem cell 池,
    // 但它们不属于我们 Dedupe 过的背包/容器列表。仅当背包或容器面板真正活跃时才允许写堆叠标签;
    // 否则 stale count(IL2Cpp 释放后指针复用,旧 99-stack 的地址被新 gi 占用)会把 "xN"
    // 漏到无关 cell 上(实测:猎枪维护轮盘出现 "x99ITEM NAME")。
    public static bool AnyTrackedPanelActive()
    {
        try { var p = LastInventoryPanel; if (p != null && p.isActiveAndEnabled) return true; } catch { }
        try { var c = LastContainerPanel; if (c != null && c.isActiveAndEnabled) return true; } catch { }
        return false;
    }

    // OnUpdate tick 用来知道要扫哪个 panel 的 m_TableItems
    public static Panel_Inventory LastInventoryPanel;
    public static Panel_Container LastContainerPanel;

    // 所有最近刷新过的 (InventoryGridItem, 它当时绑的 InventoryGridDataItem, 当时的 gi.Pointer)
    // OnLateUpdate 逐帧 verify+reapply。giPtr 是 cell-reuse 侦测的锚 ——
    // 如果 item.m_GearItem.Pointer 已经变了,就说明 cell 被复用到别的 gear 上,不能用缓存 di reapply。
    public static Dictionary<System.IntPtr, (InventoryGridItem item, InventoryGridDataItem di, System.IntPtr giPtr)> SeenItems = new();

    // 这些 prefab 明确排除 —— 让游戏 / StackManager 原版处理,避免冲突
    public static readonly HashSet<string> ExcludePrefabs = new HashSet<string>
    {
        "GEAR_MashedPotatoes",
        "GEAR_WaterPurificationTablets",
        "GEAR_CigarettePackMarlboro",
        "GEAR_CigarettePackOld",
    };

    // 前缀匹配:凡是 prefab 名以这些开头的都跳过
    public static readonly string[] ExcludePrefixes =
    {
        "GEAR_cc",  // 卡牌收集 mod 所有 card
    };
}

internal static class Dedupe
{
    private static readonly Dictionary<string, (System.IntPtr di, System.IntPtr gi)> _firstOfGroup = new(64);

    // v6.9.4:counts/countsByGi 由调用方传入(Inv 侧或 Con 侧),不再写死全局。
    // 调用方在调本方法前已 Clear 这两个字典。
    public static void Process(
        Il2CppSystem.Collections.Generic.List<InventoryGridDataItem> list,
        Dictionary<System.IntPtr, int> counts,
        Dictionary<System.IntPtr, int> countsByGi)
    {
        if (list == null || list.Count <= 1) return;
        if (ModMain.Settings != null && !ModMain.Settings.StackingEnabled) return;

        // key → (dataItem.Pointer, gi.Pointer) 代表
        _firstOfGroup.Clear();
        var firstOfGroup = _firstOfGroup;
        var keep = new Il2CppSystem.Collections.Generic.List<InventoryGridDataItem>();

        for (int i = 0; i < list.Count; i++)
        {
            var di = list[i];
            var gi = di?.m_GearItem;

            if (gi == null) { keep.Add(di); continue; }

            // Skip liquids/Soda — vanilla handles
            if (gi.GetComponent<LiquidItem>() != null) { keep.Add(di); continue; }

            // 已真合并的 stackable(m_Units>1)由原版/StackManager 显示 × N,我们让路。
            // 只挂组件但 m_Units=1 的(如整合包给 DryMilkPacket / MixedNuts 加的),
            // 实际没被合,我们仍做 UI 堆叠
            var stackable = gi.GetComponent<StackableItem>();
            if (stackable != null && stackable.m_Units > 1) { keep.Add(di); continue; }

            // 必须用 GameObject.name(每个 prefab 独立),不能用 m_GearItemData.name —
            // 整合包里多个 mod 加的物品可能共用同一个 GearItemData asset,name 相同,
            // 会导致不同 prefab 被误合并(曾见 roastedAlmonds 吞并多种食物)
            string prefab = gi.name ?? "";
            // Unity 实例化 prefab 后 GameObject.name 可能带 "(Clone)" 后缀
            int cloneIdx = prefab.IndexOf("(Clone)");
            if (cloneIdx >= 0) prefab = prefab.Substring(0, cloneIdx).TrimEnd();
            if (StackState.ExcludePrefabs.Contains(prefab)) { keep.Add(di); continue; }
            bool prefixHit = false;
            for (int p = 0; p < StackState.ExcludePrefixes.Length; p++)
            {
                if (prefab.StartsWith(StackState.ExcludePrefixes[p])) { prefixHit = true; break; }
            }
            if (prefixHit) { keep.Add(di); continue; }

            string key = MakeKey(gi, prefab);
            if (firstOfGroup.TryGetValue(key, out var rep))
            {
                counts[rep.di] = counts[rep.di] + 1;
                countsByGi[rep.gi] = countsByGi[rep.gi] + 1;
            }
            else
            {
                firstOfGroup[key] = (di.Pointer, gi.Pointer);
                counts[di.Pointer] = 1;
                countsByGi[gi.Pointer] = 1;
                keep.Add(di);
            }
        }

        if (keep.Count == list.Count) return;  // nothing to dedupe

        list.Clear();
        for (int i = 0; i < keep.Count; i++) list.Add(keep[i]);
    }

    private static string MakeKey(GearItem gi, string prefab)
    {
        var food = gi.GetComponent<FoodItem>();
        char opened = food != null ? (food.m_Opened ? 'O' : 'C') : '_';
        return string.Concat(prefab, "|", opened.ToString());
    }
}

// v6.9.4 根因修复 ——————————————————————————————————————————————
// 旧版只在 RefreshTable/RefreshTables 的 Prefix 跑 Dedupe。但"把物品移到另一个容器"
// 走的是 OnInventoryToContainer/OnContainerToInventory → 直接调私有 UpdateFiltered*List
// 重填列表 + 渲染,绕过 RefreshTables → Dedupe 没跑 → 列表是完整 N 项 → 渲染成 N 个独立格子,
// 每格 count≤1 → label 代码正确地不显示 xN(所以旧调试 bad=0)。视觉散开、数据还在。
//
// 修法:把 Dedupe 下沉到 UpdateFiltered*List(填充 m_Filtered*List 的最内层方法)的 Postfix。
// 所有刷新路径(开箱/筛选/排序/移动/取出)都必经此处 → 免疫路径绕过。
// 在 Postfix 里:先 Clear 本侧字典,再 Dedupe(去重 + 重填 count),最后 Clear SeenItems
// (di 指针已变,旧缓存全 stale;RefreshDataItem.Postfix 会随渲染重新登记)。
//
// 注:Panel_Inventory.UpdateFilteredInventoryList 是 public,Panel_Container 的两个是 private
// (Harmony 按字符串名 patch private 在本库有先例)。

// 独立背包面板(按 I 打开,在 TLD 2.55 实际是 Panel_Inventory)
[HarmonyPatch(typeof(Panel_Inventory), "UpdateFilteredInventoryList")]
internal static class Patch_Inventory_UpdateFilteredList
{
    private static void Postfix(Panel_Inventory __instance)
    {
        try
        {
            if (ModMain.Settings != null && !ModMain.Settings.StackingEnabled) return;
            StackState.LastInventoryPanel = __instance;
            StackState.LastContainerPanel = null;
            StackState.CountsInv.Clear();
            StackState.CountsByGiInv.Clear();
            StackState.SeenItems.Clear();
            Dedupe.Process(__instance.m_FilteredInventoryList, StackState.CountsInv, StackState.CountsByGiInv);
        }
        catch (System.Exception ex)
        {
            ModMain.Log.Error($"[Inventory.UpdateFilteredList.Postfix] {ex}");
        }
    }
}

// 容器面板的背包侧列表
[HarmonyPatch(typeof(Panel_Container), "UpdateFilteredInventoryList")]
internal static class Patch_Container_UpdateFilteredInventoryList
{
    private static void Postfix(Panel_Container __instance)
    {
        try
        {
            if (ModMain.Settings != null && !ModMain.Settings.StackingEnabled) return;
            StackState.LastContainerPanel = __instance;
            StackState.LastInventoryPanel = null;
            StackState.CountsInv.Clear();
            StackState.CountsByGiInv.Clear();
            // SeenItems 是两侧共用的;只在背包侧清,容器侧 Postfix 紧随其后会重填自己的 cell。
            // 两侧 populate 在同一刷新里先后调用,清一次足够;清早了容器侧 cell 也会被 RefreshDataItem 重登记。
            StackState.SeenItems.Clear();
            Dedupe.Process(__instance.m_FilteredInventoryList, StackState.CountsInv, StackState.CountsByGiInv);
        }
        catch (System.Exception ex)
        {
            ModMain.Log.Error($"[Container.UpdateFilteredInventoryList.Postfix] {ex}");
        }
    }
}

// 容器面板的容器侧列表
[HarmonyPatch(typeof(Panel_Container), "UpdateFilteredContainerList")]
internal static class Patch_Container_UpdateFilteredContainerList
{
    private static void Postfix(Panel_Container __instance)
    {
        try
        {
            if (ModMain.Settings != null && !ModMain.Settings.StackingEnabled) return;
            StackState.LastContainerPanel = __instance;
            StackState.LastInventoryPanel = null;
            StackState.CountsCon.Clear();
            StackState.CountsByGiCon.Clear();
            Dedupe.Process(__instance.m_FilteredContainerList, StackState.CountsCon, StackState.CountsByGiCon);
        }
        catch (System.Exception ex)
        {
            ModMain.Log.Error($"[Container.UpdateFilteredContainerList.Postfix] {ex}");
        }
    }
}

internal static class LabelFix
{
    // v8.1.1 单位后缀 —— ToStringMetric/ToStringImperial 只保证给出数字,
    // 游戏原本写在 label 上的单位词("公斤" / "kg" / "lb")不一定被带出来,
    // 带出来也不保证跟当前语言一致。所以每次都从 label 现有文本里取后缀再接回去。
    // label 偶尔会是空的(游戏还没填),用上一次见到的后缀兜底。
    private static string _unitSuffix = "";

    // "0.35 公斤" → " 公斤";"0.77 lb" → " lb";"1.05" → ""
    private static string UnitSuffix(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";
        int i = 0;
        while (i < s.Length && (char.IsDigit(s[i]) || s[i] == '.' || s[i] == ',' || s[i] == '-' || s[i] == '+')) i++;
        return i < s.Length ? s.Substring(i) : "";
    }

    public static string ApplyWeight(UILabel weightLabel, ItemWeight total)
    {
        if (weightLabel == null) return null;
        string cur = weightLabel.text;
        string curSuffix = UnitSuffix(cur);
        if (curSuffix.Length != 0) _unitSuffix = curSuffix;

        string unit = curSuffix.Length != 0 ? curSuffix : _unitSuffix;
        bool imperial = unit.Contains("lb");
        string want = imperial ? total.ToStringImperial(2u) : total.ToStringMetric(2u);
        if (UnitSuffix(want).Length == 0 && unit.Length != 0) want += unit;

        if (cur != want) weightLabel.text = want;
        return want;
    }

    // 每 3 帧那轮补写用:同一格子、同一物品、同一数量时总重文本不变,直接拿上次算好的比。
    //   仍然读一次标签,游戏把它重置回单件重量时照样写回;省掉的是取重量、格式化和拼单位(每格每轮 4 次分配)。
    private static readonly System.Collections.Generic.Dictionary<System.IntPtr, (System.IntPtr di, int count, string want)> _weightDone = new();
    internal static void ClearWeightCache() => _weightDone.Clear();

    public static void ApplyWeightFromDataItem(InventoryGridItem item, InventoryGridDataItem di, int count)
    {
        try
        {
            if (item == null || di == null) return;
            var wl = item.m_WeightLabel;
            if (wl == null) return;
            if (_weightDone.TryGetValue(item.Pointer, out var done) && done.di == di.Pointer && done.count == count)
            {
                if (wl.text != done.want) wl.text = done.want;
                return;
            }
            string want = ApplyWeight(wl, di.GetItemWeight(false) * count);
            // 标签还没填、单位没取到时别缓存,不然之后一直写回不带单位的文本
            if (want != null && UnitSuffix(want).Length != 0) _weightDone[item.Pointer] = (di.Pointer, count, want);
        }
        catch { }
    }

    // Refresh(GearItem, int) 这条路没 dataItem,重量取 GearItem 自身的
    public static void ApplyWeightFromGear(InventoryGridItem item, GearItem gi, int count)
    {
        try
        {
            if (item == null || gi == null) return;
            ApplyWeight(item.m_WeightLabel, gi.GetItemWeightKG() * count);
        }
        catch { }
    }

    public static void ReapplyStackLabelOnly(InventoryGridItem item, InventoryGridDataItem di)
    {
        try
        {
            if (item == null || di == null) return;
            if (!StackState.TryGetCount(di.Pointer, out int count)) return;
            if (count <= 1) return;
            var label = item.m_StackLabel;
            if (label == null) return;
            // 无条件写 — 避免读 label.text(读操作会分配托管字符串)
            label.text = CountStr.Get(count);
            // unitLabel/unitSprite 已在 RefreshDataItem/HoverItem Postfix 里处理,
            // 游戏不会在帧间自动 un-hide 它们,不需要每帧检查
        }
        catch { }
    }

    public static void Reapply(InventoryGridItem item, InventoryGridDataItem di)
    {
        try
        {
            if (item == null || di == null) return;
            if (!StackState.TryGetCount(di.Pointer, out int count)) return;
            if (count <= 1) return;

            // v2.7.35 t1 修:UnitLabel/UnitSprite 是"stackable m_Units 显示" ——
            //   hover 时游戏刷新这俩显示 m_Units=1(因为我们 Dedupe 的是 m_Units=1 的虚拟堆叠)
            //   会压住 StackLabel 显示 "1"。force 隐藏掉
            var unitLabel = item.m_UnitLabel;
            if (unitLabel != null && unitLabel.gameObject != null && unitLabel.gameObject.activeSelf)
                unitLabel.gameObject.SetActive(false);
            var unitSprite = item.m_UnitSprite;
            if (unitSprite != null && unitSprite.gameObject != null && unitSprite.gameObject.activeSelf)
                unitSprite.gameObject.SetActive(false);

            // stack label —— 只在需要变化时写 text(避免每帧字符串分配)
            var label = item.m_StackLabel;
            if (label != null)
            {
                string want = CountStr.Get(count);
                if (label.text != want) label.text = want;
                if (label.gameObject != null && !label.gameObject.activeSelf)
                    label.gameObject.SetActive(true);
            }

            // weight label —— 只在 text 不是已经是预期值时重算
            ApplyWeightFromDataItem(item, di, count);
        }
        catch (System.Exception ex)
        {
            ModMain.Log.Error($"[LabelFix.Reapply] {ex}");
        }
    }
}

[HarmonyPatch(typeof(InventoryGridItem), nameof(InventoryGridItem.RefreshDataItem))]
internal static class Patch_RefreshDataItem
{
    private static void Postfix(InventoryGridItem __instance, InventoryGridDataItem dataItem, int index)
    {
        try
        {
            if (dataItem == null) return;
            // 仅在背包/容器面板活跃时登记+写标签,避免漏到维护轮盘等复用 cell
            if (!StackState.AnyTrackedPanelActive()) return;

            // 记录 (item, 此次绑的 dataItem, 此次的 gi.Pointer) 到 SeenItems。
            // OnLateUpdate 每帧 verify(靠 giPtr 对比当前绑定)+ reapply;复用后 gi 变,verify 会 skip。
            if (__instance != null)
            {
                var gi = dataItem.m_GearItem;
                System.IntPtr giPtr = gi != null ? gi.Pointer : System.IntPtr.Zero;
                StackState.SeenItems[__instance.Pointer] = (__instance, dataItem, giPtr);
            }

            LabelFix.Reapply(__instance, dataItem);
        }
        catch (System.Exception ex)
        {
            ModMain.Log.Error($"[RefreshDataItem.Postfix] {ex}");
        }
    }
}

// t1 bug v2.7.34 —— 容器 hover 堆叠变 1 仍未修好
// v2.7.30 加了 InventoryGridItem.OnHover/ToggleSelection Postfix 不 work
//   说明 hover 时游戏的 label 重置路径不经这俩方法
// 核心路径实际是 Panel_Container.HoverItem(gridItem, displayName, isOver, isContainerItem)
//   它可能调用 InventoryGridItem.Refresh 重置 cell —— patch 这个 Postfix
[HarmonyPatch(typeof(Panel_Container), nameof(Panel_Container.HoverItem))]
internal static class Patch_Panel_Container_HoverItem
{
    private static void Postfix(InventoryGridItem gridItem)
    {
        try
        {
            if (gridItem == null) return;
            if (StackState.SeenItems.TryGetValue(gridItem.Pointer, out var seen))
                LabelFix.Reapply(gridItem, seen.di);
        }
        catch { }
    }
}

// v2.7.89 点击堆叠物品后视觉 label 消失修复 ——
// SelectGridItem 内部刷新 cell 时重置 StackLabel;Postfix 对所有 SeenItems 重新 reapply。
[HarmonyPatch(typeof(Panel_Container), nameof(Panel_Container.SelectGridItem))]
internal static class Patch_Panel_Container_SelectGridItem
{
    private static void Postfix(Panel_Container __instance)
    {
        try
        {
            foreach (var kv in StackState.SeenItems)
            {
                var (item, di, giPtr) = kv.Value;
                if (item == null || item.Pointer == System.IntPtr.Zero) continue;
                try
                {
                    var curGi = item.m_GearItem;
                    if (curGi == null || curGi.Pointer != giPtr) continue;
                }
                catch { continue; }
                LabelFix.Reapply(item, di);
            }
        }
        catch { }
    }
}

[HarmonyPatch(typeof(Panel_Container), nameof(Panel_Container.OnMoveItem))]
internal static class Patch_Panel_Container_OnMoveItem
{
    private static void Postfix(Panel_Container __instance)
    {
        try
        {
            foreach (var kv in StackState.SeenItems)
            {
                var (item, di, giPtr) = kv.Value;
                if (item == null || item.Pointer == System.IntPtr.Zero) continue;
                try
                {
                    var curGi = item.m_GearItem;
                    if (curGi == null || curGi.Pointer != giPtr) continue;
                }
                catch { continue; }
                LabelFix.Reapply(item, di);
            }
        }
        catch { }
    }
}

// Panel_Inventory 没有 HoverItem 方法,只 patch Panel_Container + InventoryGridItem.Update

// v2.7.75 删 InventoryGridItem.Update Postfix —— 每帧每 cell × 40 cell × 60fps = 2400 次/秒
// Harmony bridge 是主要 FPS 杀手(和 v2.7.18 删 ClothingItem.Update 同理)。
// OnLateUpdate 已经每帧 reapply SeenItems 里所有 cell,功能覆盖。
// 如果 hover 闪 1 bug 回归,看 Stacking.OnLateUpdate 是否正常触发。

// Refresh(GearItem, int) 是另一个 cell-bind 路径(跳过 dataItem 直接绑 gi)——
// 一些 panel (slot / equipment) 走这条。我们从 CountsByGi 拿 count。
[HarmonyPatch(typeof(InventoryGridItem), nameof(InventoryGridItem.Refresh))]
internal static class Patch_InventoryGridItem_Refresh
{
    private static void Postfix(InventoryGridItem __instance, GearItem gi, int index)
    {
        try
        {
            if (__instance == null || gi == null) return;
            // 仅在背包/容器面板活跃时写标签,避免漏到维护轮盘/装备槽等复用 cell
            if (!StackState.AnyTrackedPanelActive()) return;
            if (!StackState.TryGetCountByGi(gi.Pointer, out int count) || count <= 1) return;

            var label = __instance.m_StackLabel;
            if (label != null)
            {
                string want = CountStr.Get(count);
                if (label.text != want) label.text = want;
                if (label.gameObject != null && !label.gameObject.activeSelf)
                    label.gameObject.SetActive(true);
            }
            LabelFix.ApplyWeightFromGear(__instance, gi, count);
        }
        catch (System.Exception ex)
        {
            ModMain.Log.Error($"[InventoryGridItem.Refresh.Postfix] {ex}");
        }
    }
}
#endif
