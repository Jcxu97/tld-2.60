using System;
using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace TraderMoving;

// ═══════════════════════════════════════════════════════════════
// Harmony patch 层
//
// patch 选取照 TldHacks/src/DynamicPatch.cs:504-531 的 CarcassMoving 那 13 条 spec。
// 但这里用普通 attribute patch,不用 DynamicPatch 的动态挂载 —— 那套是为 TldHacks
// 几百个 toggle 的 IL2Cpp bridge 开销服务的,这个 mod 只有两个开关,常挂即可,
// 且每个 patch 体第一行就按开关短路,不搬东西时开销可忽略。
//
// 所有和存档相关的 patch 都加 [HarmonyPriority(Priority.Last)],确保跑在 SCPlus
// 之后 —— SCPlus 的 SaveGameSystem patch 没写优先级,而它读档时会把原生物件
// active=false 再用 prefab 重建,我们要在它折腾完之后再摆位置。
// ═══════════════════════════════════════════════════════════════

// —— 抱起:准星指向无线电/交易箱时按热键 ——
// 挂在 PlayerManager.Update 上不划算(每帧都跑),改为 ModMain.OnUpdate 里轮询按键,
// 只在按下热键的那一帧才做射线检测。见 ModMain.TryPickUpUnderCrosshair()。

// —— 跨场景:切场景前保住对象 ——
// LoadScene.Activate 有两个重载(Activate() 和 Activate(bool)),必须显式指定
// 无参那个,否则 Harmony 因歧义抛异常 → 整个 mod 挂不上。
// TldHacks 的 CarcassMoving 同样用 Type.EmptyTypes 指定(DynamicPatch.cs:514)。
[HarmonyPatch(typeof(LoadScene), "Activate", new Type[0])]
internal static class Patch_LoadScene_Activate
{
    [HarmonyPriority(Priority.Last)]
    internal static void Postfix()
    {
        if (!CarryState.IsCarrying || CarryState.CarriedObj == null) return;
        try
        {
            // DontDestroyOnLoad 保住整棵树,否则旧场景卸载时对象跟着没
            var root = ((Component)CarryState.CarriedObj.transform.root).gameObject;
            UnityEngine.Object.DontDestroyOnLoad(root);
            ModMain.Log?.Msg($"[TraderMoving] 跨场景:{CarryState.Kind} 已保住");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] LoadScene.Activate: {ex.Message}"); }
    }
}

// —— 新场景落地 ——
[HarmonyPatch(typeof(GameManager), "SetAudioModeForLoadedScene")]
internal static class Patch_SceneLoaded
{
    [HarmonyPriority(Priority.Last)]
    internal static void Postfix()
    {
        try
        {
            // 搬着东西进新场景:对象还在 DontDestroyOnLoad 里,等玩家放下时
            // Drop() 会 MoveGameObjectToScene 移交给当前场景
            if (CarryState.IsCarrying)
            {
                if (CarryState.CarriedObj == null) { CarryState.Reset(); return; }
                CarryState.SaveTrigger = true;
                return;
            }

            // 没搬东西:把存档记录里属于本场景的对象摆到记录位置
            SaveData.ApplyToScene();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] SceneLoaded: {ex.Message}"); }
    }
}

// —— 存档前:把搬着的对象移到玩家位置并归属当前场景 ——
[HarmonyPatch(typeof(GameManager), "TriggerSurvivalSaveAndDisplayHUDMessage")]
internal static class Patch_BeforeSave
{
    [HarmonyPriority(Priority.Last)]
    internal static void Prefix()
    {
        if (!CarryState.IsCarrying || CarryState.CarriedObj == null) return;
        try
        {
            // 只挪位置,【不碰 collider / renderer】。
            // CarcassMoving 的 bug #4 就是存档时为了存数据把 collider 打开在玩家脚下,
            // 存完忘了藏回去,导致进室内后全局交互失效。存档只需要位置和场景归属。
            CarryState.MoveToPlayer();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] BeforeSave: {ex.Message}"); }
    }
}

// —— 存档写入 ——
// 签名:private static void SaveSceneData(SlotData slot, string sceneSaveName)
[HarmonyPatch(typeof(SaveGameSystem), "SaveSceneData", new Type[] { typeof(SlotData), typeof(string) })]
internal static class Patch_SaveSceneData
{
    [HarmonyPriority(Priority.Last)]
    internal static void Postfix()
    {
        try { SaveData.Save(); }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] SaveSceneData: {ex.Message}"); }
    }
}

// —— 读档 ——
// 签名:private static bool LoadSceneData(string name, string sceneSaveName)
// 注意还有个 LoadSceneDataAdditive(string,string),名字不同不会撞。
[HarmonyPatch(typeof(SaveGameSystem), "LoadSceneData", new Type[] { typeof(string), typeof(string) })]
internal static class Patch_LoadSceneData
{
    [HarmonyPriority(Priority.Last)]
    internal static void Postfix()
    {
        try
        {
            SaveData.Load();
            SaveData.ApplyToScene();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] LoadSceneData: {ex.Message}"); }
    }
}

// —— 搬运时不许冲刺 ——
[HarmonyPatch(typeof(PlayerManager), "PlayerCanSprint")]
internal static class Patch_NoSprint
{
    internal static void Postfix(ref bool __result)
    {
        if (CarryState.IsCarrying) __result = false;
    }
}

// —— 搬运时不许装备物品 ——
[HarmonyPatch(typeof(PlayerManager), "EquipItem", new Type[] { typeof(GearItem), typeof(bool) })]
internal static class Patch_NoEquip
{
    internal static bool Prefix()
    {
        if (!CarryState.IsCarrying) return true;
        try
        {
            GameAudioManager.PlayGUIError();
            HUDMessage.AddMessage("搬运时无法装备物品", false, false);
        }
        catch { }
        return false;
    }
}

// —— 负重:体力消耗 ——
[HarmonyPatch(typeof(Fatigue), "CalculateFatigueIncrease", new Type[] { typeof(float) })]
internal static class Patch_Fatigue
{
    internal static void Postfix(ref float __result)
    {
        if (CarryState.IsCarrying)
            __result *= 1f + CarryState.Weight * 0.05f;
    }
}

// —— 负重:热量消耗 ——
[HarmonyPatch(typeof(PlayerManager), "CalculateModifiedCalorieBurnRate", new Type[] { typeof(float) })]
internal static class Patch_Calorie
{
    internal static void Postfix(ref float __result)
    {
        if (CarryState.IsCarrying)
            __result += CarryState.Weight * 15f;
    }
}

// —— 攀绳时强制放下 ——
[HarmonyPatch(typeof(RopeClimbPoint), "OnRopeTransition", new Type[] { typeof(bool) })]
internal static class Patch_RopeDrop
{
    internal static void Postfix()
    {
        if (CarryState.IsCarrying) CarryState.Drop();
    }
}

// —— 从背包放出来:清掉收纳标记 ——
// SCPlus 的放置走 PlayerManager.StartPlaceMesh → AttemptToPlaceMesh 落地。
// 这里在落地后确认场景里是否真出现了无线电/箱子,出现了就清标记。
// 不直接信"放置动作发生了"—— 玩家可能放的是别的装饰品。
[HarmonyPatch(typeof(PlayerManager), "AttemptToPlaceMesh")]
internal static class Patch_AfterPlace
{
    [HarmonyPriority(Priority.Last)]
    internal static void Postfix()
    {
        try
        {
            if (StowRecord.RadioStowed && SaveData.FindInScene(CarryKind.Radio.ToString()) != null)
            {
                StowRecord.MarkPlaced(CarryKind.Radio);
                ModMain.Log?.Msg("[TraderMoving] 无线电已从背包放置,清除收纳标记");
            }
            if (StowRecord.BoxStowed && SaveData.FindInScene(CarryKind.ExchangeBox.ToString()) != null)
            {
                StowRecord.MarkPlaced(CarryKind.ExchangeBox);
                ModMain.Log?.Msg("[TraderMoving] 交易箱已从背包放置,清除收纳标记");
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] AfterPlace: {ex.Message}"); }
    }
}
