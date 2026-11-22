#if !EP5_EDITION && !STORY_EDITION
using System.Collections.Generic;
using Il2Cpp;
using Il2CppTLD.IntBackedUnit;

namespace TldHacks;

// 鲸油罐和煤油油桶的单罐上限与合并。原版 LiquidItem 的容量不存档,读档时 Deserialize 原样写回油量、不按容量截,
//   只有往里倒油(AddLiquid)才按 m_LiquidCapacity 截。所以上限在生成时(Awake)和拖滑条时套到罐子上,
//   合并直接分配 m_Liquid,超过上限的老罐子不往下砍。
internal static class OilCans
{
    private const long UnitsPerLiter = 1000000000L;

    internal enum Kind { None, WhaleOil, Kerosene }

    private static readonly Dictionary<string, long> _vanillaCap = new();

    private static string Key(LiquidItem li) => (li.gameObject.name ?? "").Replace("(Clone)", "").Trim();

    internal static Kind KindOf(LiquidItem li)
    {
        var t = li?.LiquidType;
        if (t == null) return Kind.None;
        string n = t.name ?? "";
        if (n.IndexOf("WhaleOil", System.StringComparison.OrdinalIgnoreCase) >= 0) return Kind.WhaleOil;
        if (n.IndexOf("Kerosene", System.StringComparison.OrdinalIgnoreCase) >= 0) return Kind.Kerosene;
        return Kind.None;
    }

    private static float SettingL(Kind k)
    {
        var s = ModMain.Settings;
        if (s == null) return 0f;
        return k == Kind.WhaleOil ? s.OilCan_WhaleMaxL : k == Kind.Kerosene ? s.OilCan_KeroseneMaxL : 0f;
    }

    internal static bool Wanted()
    {
        var s = ModMain.Settings;
        return s != null && (s.OilCan_WhaleMaxL > 0f || s.OilCan_KeroseneMaxL > 0f);
    }

    // 0 = 原版容量
    private static long CapUnits(Kind k, LiquidItem li)
    {
        float l = SettingL(k);
        if (l > 0f) return (long)(l * UnitsPerLiter);
        return _vanillaCap.TryGetValue(Key(li), out var v) ? v : li.m_LiquidCapacity.m_Units;
    }

    internal static void Apply(LiquidItem li)
    {
        var k = KindOf(li);
        if (k == Kind.None) return;
        // 第一次碰到的罐子还没被改过,它的容量就是原版值
        string key = Key(li);
        if (!_vanillaCap.ContainsKey(key)) _vanillaCap[key] = li.m_LiquidCapacity.m_Units;
        long cap = CapUnits(k, li);
        if (li.m_LiquidCapacity.m_Units != cap) li.m_LiquidCapacity = new ItemLiquidVolume(cap);
    }

    internal static void ApplyToInventory()
    {
        try
        {
            var list = GameManager.m_Inventory?.m_Items;
            if (list == null) return;
            for (int i = 0; i < list.Count; i++)
            {
                var li = list[i]?.m_GearItem?.m_LiquidItem;
                if (li != null) Apply(li);
            }
        }
        catch { }
    }

    internal static bool RestoreDone()
    {
        ApplyToInventory();
        return true;
    }

    internal static void Merge(Kind k)
    {
        bool en = I18n.IsEnglish;
        string label = k == Kind.WhaleOil ? (en ? "whale oil cans" : "鲸油罐") : (en ? "jerrycans" : "油桶");
        try
        {
            var inv = GameManager.m_Inventory;
            var list = inv?.m_Items;
            if (list == null) { CheatState.LastActionLog = en ? "No inventory" : "没有背包"; return; }

            var cans = new List<LiquidItem>();
            long total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var li = list[i]?.m_GearItem?.m_LiquidItem;
                if (li == null || KindOf(li) != k) continue;
                Apply(li);
                cans.Add(li);
                total += li.m_Liquid.m_Units;
            }
            if (cans.Count < 2) { CheatState.LastActionLog = en ? $"Fewer than 2 {label} in the backpack" : $"背包里{label}不到 2 个"; return; }

            // 先灌最满的,倒空的罐子尽量多
            cans.Sort((a, b) => b.m_Liquid.m_Units.CompareTo(a.m_Liquid.m_Units));
            long left = total;
            int withOil = 0;
            var empty = new List<LiquidItem>();
            foreach (var li in cans)
            {
                long limit = System.Math.Max(CapUnits(k, li), li.m_Liquid.m_Units);
                long amt = System.Math.Min(limit, left);
                li.m_Liquid = new ItemLiquidVolume(amt);
                left -= amt;
                if (amt > 0) withOil++; else empty.Add(li);
            }
            int removed = 0;
            foreach (var li in empty)
            {
                if (!li.ShouldDestroyWhenEmpty) continue;
                var gi = li.GetComponent<GearItem>();
                if (gi != null) { inv.DestroyGear(gi); removed++; }
            }
            float totalL = total / (float)UnitsPerLiter;
            CheatState.LastActionLog = en
                ? $"Merged {cans.Count} {label}: {totalL:F2} L in {withOil}, {removed} empty removed"
                : $"合并了 {cans.Count} 个{label},共 {totalL:F2} 升,现在装在 {withOil} 个里,扔掉 {removed} 个空罐";
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[OilCans] merge {ex.Message}"); }
    }
}

internal static class Patch_LiquidItem_Awake
{
    public static void Postfix(LiquidItem __instance)
    {
        try { OilCans.Apply(__instance); } catch { }
    }
}
#endif
