#if !EP5_EDITION && !STORY_EDITION
using Il2Cpp;
using Il2CppTLD.Gameplay;
using Il2CppTLD.SteamTrain;
using UnityEngine;

namespace TldHacks;

// 2026-10 铁路 DLC 的蒸汽火车。部件状态是 0 到 100(修理表里 m_ConditionRepaired 是 int)。
// 游戏自己不会降档,离开二档只有刹车、下车、撞停和锅炉爆炸;二档跑不动是因为蒸汽压力不够,所以保持二档就是压力保持满。
internal static class Patch_SteamTrain_Update
{
    public static void Postfix(SteamTrain __instance)
    {
        var s = ModMain.Settings;
        if (s == null || __instance == null) return;
        try
        {
            if (s.Train_NoBreak)
            {
                Repair(__instance.Boiler);
                Repair(__instance.BrakeShoe);
                Repair(__instance.CowCatcher);
                Repair(__instance.Wheels);
            }
            if (s.Train_FullFuel)
            {
                Fill(__instance.FuelSource);
                Fill(__instance.WaterSource);
            }
            if (s.Train_KeepHighGear)
            {
                var e = __instance.Engine;
                var b = __instance.Boiler;
                var st = e != null ? e.CurrentState : null;
                // 只补到正常上限,超压(过烧)是玩家自己选的,不往下压
                if (st != null && b != null && b.BoilerIsOn && st.m_SteamPressure < e.m_MaxSteamPressure)
                    st.m_SteamPressure = e.m_MaxSteamPressure;
            }
            Diag(__instance);
        }
        catch { }
    }

    private static float _nextDiag;

    // ponytail: 临时诊断,用户报火车不耗油,查清后删掉。锅炉点着时每 30 秒一条
    private static void Diag(SteamTrain t)
    {
        if (Time.realtimeSinceStartup < _nextDiag) return;
        var b = t.Boiler;
        if (b == null || !b.BoilerIsOn) return;
        _nextDiag = Time.realtimeSinceStartup + 30f;
        var f = t.FuelSource;
        var w = t.Wheels;
        ModMain.Log?.Msg($"[Train.diag] fuel={(f != null ? f.CurrentVolume.ToQuantity(1f) : -1f):F3}/{(f != null ? f.Capacity.ToQuantity(1f) : -1f):F1}L "
            + $"burnPerMin={b.m_FuelBurnedPerMinute.ToQuantity(1f):F4}L water={(t.WaterSource != null ? t.WaterSource.CurrentVolume.ToQuantity(1f) : -1f):F2}L "
            + $"wheels={(w != null ? w.Condition : -1f):F0} oilMod={(w != null ? w.GetOilConsumedModifier() : -1f):F2} temp={b.Temperature:F0} speed={t.Velocity:F1}");
    }

    private static void Repair(SteamTrainComponent c)
    {
        if (c == null) return;
        float cap = c.GetRepairConditionCap();
        if (c.Condition < cap) c.SetCondition(cap);
    }

    private static void Fill(GenericLiquidContainer c)
    {
        if (c != null && !c.IsFull) c.Set(c.Capacity);
    }
}

// ponytail: 临时诊断,用户报加不进油和水、关掉开关也不行、重新读档才好。查清后和 Train.diag 一起删
internal static class Patch_TrainIntake_Diag
{
    private static float L(Il2CppTLD.IntBackedUnit.ItemLiquidVolume v) => v.ToQuantity(1f);

    public static void Perform(SteamTrainTankIntake __instance, bool __result)
    {
        try
        {
            var c = __instance.GetContainer();
            var lt = __instance.GetShownLiquidType();
            ModMain.Log?.Msg($"[Train.intake] {__instance.GetType().Name} result={__result} tank={(c != null ? L(c.CurrentVolume) : -1f):F2}/{(c != null ? L(c.Capacity) : -1f):F1}L "
                + $"room={(c != null ? L(c.RemainingEmptyVolume) : -1f):F2}L inv={L(__instance.GetInventoryVolume()):F2}L liquid={(lt != null ? lt.name : "null")} step={L(__instance.m_VolumeIncrement):F2}L");
        }
        catch (System.Exception ex) { ModMain.Log?.Msg($"[Train.intake] perform err {ex.Message}"); }
    }

    public static void WaterInit(SteamTrainWaterTankIntake __instance)
    {
        try
        {
            var lt = __instance.m_TransferrableLiquidType;
            ModMain.Log?.Msg($"[Train.intake] water init inv={L(__instance.m_TransferrableVolume):F2}L type={(lt != null ? lt.name : "null")}");
        }
        catch (System.Exception ex) { ModMain.Log?.Msg($"[Train.intake] water init err {ex.Message}"); }
    }

    public static void OnTransfer(Il2CppTLD.IntBackedUnit.ItemLiquidVolume volume)
    {
        ModMain.Log?.Msg($"[Train.intake] transfer to train {L(volume):F2}L");
    }

    public static void Execute(Panel_TransferTrainTowerLiquid __instance)
    {
        try
        {
            var t = __instance.m_TransferSettings;
            ModMain.Log?.Msg($"[Train.intake] execute action={__instance.m_Action} selTrain={L(__instance.m_SelectedLitersTrain):F2}L selInv={L(__instance.m_SelectedLitersInventory):F2}L "
                + $"canTrain={t.m_CanTransferToTrain} canInv={t.m_CanTransferToInventory} maxTrain={L(t.m_MaxTrainCapacityLiters):F2}L total={L(t.m_TotalCapacityLiters):F2}L cb={(t.m_OnTransferLiquid != null)}");
        }
        catch (System.Exception ex) { ModMain.Log?.Msg($"[Train.intake] execute err {ex.Message}"); }
    }

    public static void Transferred(bool success, bool playerCancel, float progress)
    {
        ModMain.Log?.Msg($"[Train.intake] progress end success={success} cancel={playerCancel} progress={progress:F2}");
    }
}

internal static class Patch_SteamTrain_NoBreak
{
    public static bool Skip() => false;

    public static void NoRisk(ref SteamTrainBoiler.BoilerExplosionRiskLevel __result)
    {
        __result = SteamTrainBoiler.BoilerExplosionRiskLevel.None;
    }
}
#endif
