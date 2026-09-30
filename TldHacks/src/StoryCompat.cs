// StoryCompat.cs — 剧情模式(2.24)API 补偿层。仅在 STORY_EDITION 下编译。
//
// 背景:剧情版是独立第二份安装,冻结在 2.24;沙盒是 2.55。源码共用一份,
// 编译时 against 2.24 interop。2.24 与 2.55 之间大量成员改了名 / 改了参数个数 /
// 换了类型(float ↔ ItemWeight)。逐个 call site 加 #if 会把共用文件切碎。
//
// 这里用扩展方法补形状:C# 只在"实例方法一个都不适用"时才去找扩展方法,
// 所以同名扩展方法不会遮蔽 2.55 的真方法,沙盒版编译时本文件整体不参与。
// 静态成员(CameraFade / GameManager / GearItem 的 static)无法用扩展方法补,
// 走同名 static 类 + `using static` 不可行(会与 Il2Cpp 类名冲突),因此这部分
// 在 call site 用 #if 处理,或走本文件里的 StoryShim 显式调用。
//
// 命名规则:扩展方法名 = 2.55 里的名字,参数 = 2.55 里的参数,内部映射到 2.24。
#if STORY_EDITION
using Il2Cpp;
using Il2CppTLD.IntBackedUnit;
using UnityEngine;

namespace TldHacks;

// ═══════════════════════════════════════════════════════════════
// 1) Affliction End 方法:2.24 少一个 bool/AfflictionOptions 尾参
// ═══════════════════════════════════════════════════════════════
internal static class StoryAfflictionCompat
{
    public static void HypothermiaEnd(this Hypothermia c, bool _) => c.HypothermiaEnd();
    public static void DysenteryEnd(this Dysentery c, bool _) => c.DysenteryEnd();
    public static void FoodPoisoningEnd(this FoodPoisoning c, bool _) => c.FoodPoisoningEnd();
    public static void BurnsEnd(this Burns c, bool _) => c.BurnsEnd();
    public static void IntestinalParasitesEnd(this IntestinalParasites c, bool _) => c.IntestinalParasitesEnd();

    // 2.24: (int) / 2.55: (int, AfflictionOptions)
    public static void SprainedWristEnd(this SprainedWrist c, int i, AfflictionOptions _) => c.SprainedWristEnd(i);
    public static void SprainedAnkleEnd(this SprainedAnkle c, int i, AfflictionOptions _) => c.SprainedAnkleEnd(i);
    public static void BloodLossEnd(this BloodLoss c, int i, AfflictionOptions _) => c.BloodLossEnd(i);
    public static void BrokenRibEnd(this BrokenRib c, int i, bool _) => c.BrokenRibEnd(i);

    // 2.24 Headache 没有 HasHeadache/Cure,用 GetHeadacheActive/RemoveHeadache
    public static bool HasHeadache(this Headache c) => c.GetHeadacheActive();
    public static void Cure(this Headache c) => c.RemoveHeadache();
}

// ═══════════════════════════════════════════════════════════════
// 2) GearItem:2.24 无 GearItemData(重量等直接挂在 GearItem 上),
//    SetNormalizedHP 少一个 bool,CurrentHP 是 m_CurrentHP
// ═══════════════════════════════════════════════════════════════
internal static class StoryGearCompat
{
    public static void SetNormalizedHP(this GearItem g, float n, bool _) => g.SetNormalizedHP(n);

    // 2.55 Drop(units, bool, bool, bool);2.24 少最后一个 bool
    public static GearItem Drop(this GearItem g, int units, bool a, bool b, bool _) => g.Drop(units, a, b);

    // 2.55 GearItem 把最大血量搬进 GearItemData;2.24 直接是 m_MaxHP
    public static float StoryMaxHP(this GearItem g) => g.m_MaxHP;
}

// ═══════════════════════════════════════════════════════════════
// 3) 单位:2.24 这批 API 直接返回 float,2.55 才换成 ItemWeight。
//    给 float 补 ToQuantity,让 `x.ToQuantity(1f)` 两版都编得过。
// ═══════════════════════════════════════════════════════════════
internal static class StoryUnitCompat
{
    public static float ToQuantity(this float v, float _) => v;
}

// ═══════════════════════════════════════════════════════════════
// 4) 面板成员改名 / 缺失
// ═══════════════════════════════════════════════════════════════
internal static class StoryPanelCompat
{
    // 2.55 Panel_BodyHarvest.m_HarvestTimeMinutes / m_TotalHarvestTimeSeconds;
    // 2.24 只有 m_HarvestTimeSeconds。分钟 = 秒 / 60。
    public static float get_HarvestMinutes(this Panel_BodyHarvest p) => p.m_HarvestTimeSeconds / 60f;

    // 2.55 Panel_Inventory_Examine.IsResearchItem();2.24 用 GearItem.m_ResearchItem 判定
    public static bool IsResearchItem(this Panel_Inventory_Examine p)
    {
        try { return p.m_GearItem != null && p.m_GearItem.m_ResearchItem != null; }
        catch { return false; }
    }
}

// ═══════════════════════════════════════════════════════════════
// 5) 静态成员桥:扩展方法补不了 static,这里给 call site 一个稳定入口。
// ═══════════════════════════════════════════════════════════════
internal static class StoryShim
{
    // 2.55 CameraFade.FadeIn(dur, delay, cb) / Fade(from,to,dur,delay,cb) /
    // FinishFade(bool) + m_TargetAlpha 等字段。
    // 2.24 只有 StartAlphaFade(Color, bool fadeIn, dur, delay, cb) + 一组 static getter。
    // 剧情下我们只需要"立刻变亮"和"淡入淡出黑屏"两种语义。
    public static void FadeInInstant()
    {
        // ForceScreenOverlayColor 立刻把遮罩改成全透明,不排队任何 fade
        try { CameraFade.ForceScreenOverlayColor(new Color(0f, 0f, 0f, 0f)); } catch { }
        try { CameraFade.m_FadeCompleted = true; } catch { }
        try { CameraFade.NotifyFadeFinish(); } catch { }
    }

    public static void FadeIn(float duration)
    {
        try { CameraFade.StartAlphaFade(Color.black, true, duration, 0f, (Il2CppSystem.Action)null); } catch { }
    }

    // 从当前到 target 的黑屏过渡。2.24 没有"任意 alpha"接口,
    // target>0 视作淡出到黑,target==0 视作淡入。
    public static void FadeTo(float target, float duration)
    {
        try { CameraFade.StartAlphaFade(Color.black, target <= 0f, duration, 0f, (Il2CppSystem.Action)null); } catch { }
    }

    // 2.55 GearItem.LoadGearItemPrefab(name) 返回未实例化的 prefab GearItem。
    // 2.24 无此 API,最接近的是 Utils.InstantiateGearFromPrefabName(name)
    // —— 它会真的实例化。调用方随后都会把它塞进背包或放到场景,所以语义可接受;
    // ponytail: 只用于"按名字取物品"的功能(给予物品 / 火把 / 睡袋),
    // 天花板是会多产生一个场景实例;若发现泄漏就改成 Resources 查找 prefab。
    public static GearItem LoadGearItemPrefab(string name)
    {
        try { return Utils.InstantiateGearFromPrefabName(name); } catch { return null; }
    }
}
#endif
