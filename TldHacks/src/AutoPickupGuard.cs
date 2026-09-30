using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace TldHacks;

// v2.7.58 / v2.7.59 —— 拦截 ItemPicker mod 自动 W 键拾取玩家刚丢的物品
//   思路:Drop 时记 Pointer → Time;ItemPicker.OnUpdate 跑时置 InAutoPickup=true;
//        PlayerManager.ProcessPickupItemInteraction Prefix 在 InAutoPickup + dict 命中时 skip
internal static class AutoPickupGuard
{
    private const string HARMONY_ID = "TldHacks.AutoPickupGuard.Dynamic";
    private static HarmonyLib.Harmony _h;
    private static bool _itemPickerPatched;

    public static readonly Dictionary<IntPtr, float> DroppedAt = new Dictionary<IntPtr, float>();
    public static bool InAutoPickup;

    // v7.7 给 DroppedAt 加上界。原先只在场景切换/开关关掉时整体 Clear,单场景内一直丢东西
    //   就一直涨(记录了时间戳却从没读过 → 条目永久有效)。
    //   注意:这里不能改成"超时自动过期",那会让"丢过的东西过一阵子又被自动捡走",是行为变更。
    //   只做容量上界:超过 CAP 时按时间戳丢掉最老的一半。真实玩法下单场景不会丢到 512 件,
    //   所以对现有行为无感知;附带好处是减少 stale IntPtr 被新对象复用导致的误拦。
    // ponytail: O(n log n) 排序剪枝,只在越界那一次跑;若以后要精确 LRU 再换有序结构。
    private const int DroppedAtCap = 512;

    public static void PruneDroppedAt()
    {
        if (DroppedAt.Count <= DroppedAtCap) return;
        try
        {
            var oldest = DroppedAt.OrderBy(kv => kv.Value)
                                  .Take(DroppedAt.Count - DroppedAtCap / 2)
                                  .Select(kv => kv.Key)
                                  .ToList();
            foreach (var k in oldest) DroppedAt.Remove(k);
            ModMain.Log?.Msg($"[AutoPickupGuard] DroppedAt 越界剪枝 → {DroppedAt.Count}");
        }
        catch { }
    }

    // 诊断用:每个 patch 触发 & hook 成功 只打一次 log
    internal static bool _logDrop;
    internal static bool _logDropPM;
    internal static bool _logOnUpdate;
    internal static bool _logSkip;

    private static HarmonyLib.Harmony H { get { if (_h == null) _h = new HarmonyLib.Harmony(HARMONY_ID); return _h; } }

    public static void ReconcileItemPickerPatch()
    {
        try
        {
            bool wanted = CheatState.BlockAutoPickupOwnDrops;
            if (wanted == _itemPickerPatched) return;

            var target = Patch_ItemPicker_OnUpdate_Guard.ResolveTargetMethod();
            if (target == null) return;

            if (wanted)
            {
                H.Patch(target,
                    new HarmonyMethod(AccessTools.Method(typeof(Patch_ItemPicker_OnUpdate_Guard), "Prefix")),
                    new HarmonyMethod(AccessTools.Method(typeof(Patch_ItemPicker_OnUpdate_Guard), "Postfix")));
                _itemPickerPatched = true;
                ModMain.Log?.Msg("[AutoPickupGuard] ON ItemPickerMain.OnUpdate");
            }
            else
            {
                H.Unpatch(target, HarmonyPatchType.All, HARMONY_ID);
                _itemPickerPatched = false;
                InAutoPickup = false;
                DroppedAt.Clear();
                ModMain.Log?.Msg("[AutoPickupGuard] OFF ItemPickerMain.OnUpdate");
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[AutoPickupGuard.Dynamic] {ex.Message}"); }
    }
}

// ——— 1) GearItem.Drop(int, bool, bool[, bool]) → GearItem ———
// 2.24 是 Drop(numUnits, playSound, stickToFeet),没有第四个 bool。类型数组写错会让
// Harmony PatchAll 在初始化时抛异常(整个 PatchAll 批次一起挂),所以按版本分开写。
#if STORY_EDITION
[HarmonyPatch(typeof(GearItem), "Drop", new System.Type[] { typeof(int), typeof(bool), typeof(bool) })]
#else
[HarmonyPatch(typeof(GearItem), "Drop", new System.Type[] { typeof(int), typeof(bool), typeof(bool), typeof(bool) })]
#endif
internal static class Patch_GearItem_Drop_Track
{
    private static void Postfix(GearItem __instance, GearItem __result)
    {
        try
        {
            if (!CheatState.BlockAutoPickupOwnDrops) return;
            float t = Time.time;
            if (__instance != null) AutoPickupGuard.DroppedAt[__instance.Pointer] = t;
            if (__result != null)   AutoPickupGuard.DroppedAt[__result.Pointer]   = t;
            AutoPickupGuard.PruneDroppedAt();
            if (!AutoPickupGuard._logDrop)
            {
                AutoPickupGuard._logDrop = true;
                ModMain.Log?.Msg($"[AutoPickupGuard.GIDrop] hook 生效,记录第一个 drop (ptrs={AutoPickupGuard.DroppedAt.Count})");
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[AutoPickupGuard.GIDrop] {ex.Message}"); }
    }
}

// ——— 2) PlayerManager.Drop(GameObject, bool) 第二条 drop 路径 ———
[HarmonyPatch(typeof(PlayerManager), "Drop", new System.Type[] { typeof(GameObject), typeof(bool) })]
internal static class Patch_PlayerManager_Drop_Track
{
    private static void Prefix(GameObject go)
    {
        try
        {
            if (!CheatState.BlockAutoPickupOwnDrops) return;
            if (go == null) return;
            var gi = go.GetComponent<GearItem>();
            if (gi == null) return;
            AutoPickupGuard.DroppedAt[gi.Pointer] = Time.time;
            AutoPickupGuard.PruneDroppedAt();
            if (!AutoPickupGuard._logDropPM)
            {
                AutoPickupGuard._logDropPM = true;
                ModMain.Log?.Msg("[AutoPickupGuard.PMDrop] hook 生效");
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[AutoPickupGuard.PMDrop] {ex.Message}"); }
    }
}

// ——— 2b) 右键放置(PlaceMesh)落地 ———
// 放置不走上面两条 Drop 路径(手持油灯右键放下、PlaceFromInventory 从背包右键放),
//   所以放下的东西没进记录,一键搜刮会把它收回去。放置完成统一走 PlaceMeshInWorld。
//   Prepare 找不到方法就跳过本类,不影响其他 patch。
[HarmonyPatch]
internal static class Patch_PlayerManager_PlaceMesh_Track
{
    private static MethodBase TargetMethod() => AccessTools.Method(typeof(PlayerManager), "PlaceMeshInWorld");
    private static bool Prepare() => TargetMethod() != null;

    private static GearItem Placing(PlayerManager pm)
    {
        var gi = pm.m_ObjectToPlaceGearItem;
        if (gi == null && pm.m_ObjectToPlace != null) gi = pm.m_ObjectToPlace.GetComponent<GearItem>();
        return gi;
    }

    private static void Prefix(PlayerManager __instance, out IntPtr __state)
    {
        __state = IntPtr.Zero;
        try
        {
            if (!CheatState.BlockAutoPickupOwnDrops || __instance == null) return;
            var gi = Placing(__instance);
            if (gi != null) __state = gi.Pointer;
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[AutoPickupGuard.Place] {ex.Message}"); }
    }

    private static void Postfix(PlayerManager __instance, IntPtr __state)
    {
        try
        {
            if (!CheatState.BlockAutoPickupOwnDrops) return;
            float t = Time.time;
            if (__state != IntPtr.Zero) AutoPickupGuard.DroppedAt[__state] = t;
            var gi = __instance != null ? Placing(__instance) : null;
            if (gi != null) AutoPickupGuard.DroppedAt[gi.Pointer] = t;
            AutoPickupGuard.PruneDroppedAt();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[AutoPickupGuard.Place] {ex.Message}"); }
    }
}

// ——— 3) 动态解析 ItemPickerMain.OnUpdate,置 InAutoPickup flag ———
internal static class Patch_ItemPicker_OnUpdate_Guard
{
    private static bool _resolved;
    private static MethodBase _target;

    internal static MethodBase ResolveTargetMethod()
    {
        if (_resolved) return _target;
        try
        {
            var asm = AppDomain.CurrentDomain.GetAssemblies()
                .FirstOrDefault(a => a.GetName().Name == "ItemPicker");
            if (asm == null) return null;

            var t = asm.GetType("ItemPicker.ItemPickerMain")
                 ?? asm.GetType("ItemPickerMain")
                 ?? asm.GetTypes().FirstOrDefault(x => x.Name == "ItemPickerMain");
            if (t == null)
            {
                ModMain.Log?.Warning("[AutoPickupGuard] ItemPickerMain type 没找到");
                _resolved = true;
                return null;
            }
            _target = t.GetMethod("OnUpdate", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            _resolved = true;
            ModMain.Log?.Msg(_target != null
                ? $"[AutoPickupGuard] hooked ItemPickerMain.OnUpdate (declaringType={t.FullName})"
                : "[AutoPickupGuard] ItemPickerMain.OnUpdate 方法没找到");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[AutoPickupGuard.Target] {ex.Message}"); }
        return _target;
    }

    private static void Prefix()
    {
        AutoPickupGuard.InAutoPickup = true;
        if (!AutoPickupGuard._logOnUpdate)
        {
            AutoPickupGuard._logOnUpdate = true;
            ModMain.Log?.Msg($"[AutoPickupGuard.IPUpdate] 第一次进 OnUpdate,dict 大小={AutoPickupGuard.DroppedAt.Count}");
        }
    }
    private static void Postfix() { AutoPickupGuard.InAutoPickup = false; }
}

// ——— 4) 拦截 pickup:InAutoPickup + 命中 dict 时 skip ———
// 2.24: ProcessPickupItemInteraction(item, forceEquip, skipAudio) —— 少一个尾 bool
#if STORY_EDITION
[HarmonyPatch(typeof(PlayerManager), "ProcessPickupItemInteraction",
    new System.Type[] { typeof(GearItem), typeof(bool), typeof(bool) })]
#else
[HarmonyPatch(typeof(PlayerManager), "ProcessPickupItemInteraction",
    new System.Type[] { typeof(GearItem), typeof(bool), typeof(bool), typeof(bool) })]
#endif
internal static class Patch_PlayerManager_ProcessPickup_BlockOwnDrops
{
    private static bool Prefix(GearItem item)
    {
        try
        {
            if (!CheatState.BlockAutoPickupOwnDrops) return true;
            if (!AutoPickupGuard.InAutoPickup)      return true;
            if (item == null)                       return true;
            if (AutoPickupGuard.DroppedAt.ContainsKey(item.Pointer))
            {
                if (!AutoPickupGuard._logSkip)
                {
                    AutoPickupGuard._logSkip = true;
                    ModMain.Log?.Msg($"[AutoPickupGuard.Skip] 第一次阻止 pickup (ptr命中,dict 大小={AutoPickupGuard.DroppedAt.Count})");
                }
                return false;
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[AutoPickupGuard.Skip] {ex.Message}"); }
        return true;
    }
}
