using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Gameplay;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(DoubleBarrelLoadFix.Mod), "DoubleBarrelLoadFix", "1.0.0", "Akul")]
[assembly: MelonGame("Hinterland", "TheLongDark")]

namespace DoubleBarrelLoadFix;

// DoubleBarrel 在 ModComponent 往掉落表加东西后立刻调 FilterEntries。海滩刷新点的表是在场景加载中途
// (RadialObjectSpawner.Awake)加的,这时 FilterEntries 等资源、资源等场景加载完,主线程永久卡死。
// 这里把它的 postfix 拦下来,等过两帧场景加载完再补筛。
public sealed class Mod : MelonMod
{
    private static readonly List<LootTableData> Pending = new();
    private static int _readyFrame;

    public override void OnLateInitializeMelon()
    {
        var target = AccessTools.Method("Shotgun.ShotgunAvailabilityPatches+LootTableManager_RefilterWithModes:Postfix");
        if (target == null)
        {
            LoggerInstance.Msg("没找到 DoubleBarrel 的掉落表补丁,不处理");
            return;
        }
        HarmonyInstance.Patch(target, prefix: new HarmonyMethod(typeof(Mod), nameof(DeferPrefix)));
        LoggerInstance.Msg("已把 DoubleBarrel 掉落表重筛改到场景加载完以后");
    }

    private static bool DeferPrefix(LootTableData lootTableData, int __state)
    {
        var entries = lootTableData?.m_BaseEntries;
        if (entries == null || entries.Count == __state) return false;
        Pending.Add(lootTableData!);
        _readyFrame = Time.frameCount + 2;
        return false;
    }

    public override void OnUpdate()
    {
        if (Pending.Count == 0 || Time.frameCount < _readyFrame) return;
        if (InterfaceManager.IsPanelEnabled<Panel_Loading>()) return;
        foreach (var t in Pending)
        {
            try { if (t != null) t.FilterEntries(); }
            catch (System.Exception e) { MelonLogger.Warning($"重筛掉落表失败: {e.Message}"); }
        }
        MelonLogger.Msg($"补筛掉落表 {Pending.Count} 张");
        Pending.Clear();
    }
}
