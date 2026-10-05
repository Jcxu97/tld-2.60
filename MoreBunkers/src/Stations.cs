using System;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppInterop.Runtime;
using Il2CppTLD.Interactions;
using UnityEngine;
using UnityEngine.Events;

namespace MoreBunkers;

// 工匠地堡里的器械。位置由 Layouts 定,这里只管接上交互。铣床只有模型,交互是自己拼的
internal static class Stations
{
    private static readonly HashSet<IntPtr> _mills = new();
    private static readonly List<BaseInteraction> _hover = new();
    private static float _lastOpen;

    internal static bool IsOurMill(MillingMachine m) => m != null && _mills.Contains(m.Pointer);

    internal static void Reset()
    {
        _mills.Clear();
        _hover.Clear();
    }

    // 摆好以后过一帧再设提示文字,不然会被交互组件自己的 Start 盖掉
    internal static void AfterStart()
    {
        string text = MillText();
        foreach (var bi in _hover)
        {
            try
            {
                if (bi == null) continue;
                bi.m_DefaultHoverText = new LocalizedString { m_LocalizationID = text };
                bi.HoverText = text;
                bi.m_CanInteract = true;
            }
            catch { }
        }
    }

    private static string MillText()
    {
        foreach (var k in new[] { "GAMEPLAY_MillingMachine", "GAMEPLAY_IndustrialMillingMachine", "GAMEPLAY_Milling" })
        {
            try { var t = Localization.Get(k); if (!string.IsNullOrEmpty(t) && t != k) return t; } catch { }
        }
        return ModMain.T("铣床", "Milling Machine");
    }

    private static string NothingText()
    {
        foreach (var k in new[] { "GAMEPLAY_NoItemsToRepair", "GAMEPLAY_NothingToRepair", "GAMEPLAY_NoRepairableItems" })
        {
            try { var t = Localization.Get(k); if (!string.IsNullOrEmpty(t) && t != k) return t; } catch { }
        }
        return ModMain.T("身上没有能在铣床上修复的物品", "You have nothing to repair at the milling machine");
    }

    internal static void OpenMill(MillingMachine mm)
    {
        if (Time.realtimeSinceStartup - _lastOpen < 0.5f) return;
        _lastOpen = Time.realtimeSinceStartup;
        try
        {
            var p = InterfaceManager.GetPanel<Panel_Milling>();
            if (p == null) { ModMain.Log?.Warning("[MoreBunkers] milling panel not found"); return; }
            p.Enable(mm);
            // 身上没有能修复的东西时,面板会显示一套占位内容;这时关掉面板只给提示
            int n = p.m_Millables != null ? p.m_Millables.Count : 0;
            // 群友报身上有东西也提示没东西修:面板刚打开时清单可能还没填,先让它重算一次,再自己数背包确认
            if (n == 0)
            {
                try { p.DetermineRepairables(); p.RefreshAll(); } catch { }
                n = p.m_Millables != null ? p.m_Millables.Count : 0;
            }
            int mine = MillablesInInventory();
            ModMain.Log?.Msg($"[MoreBunkers] mill open: panel {n}, inventory {mine}");
            if (n == 0 && mine == 0)
            {
                p.Disable();
                HUDMessage.AddMessage(NothingText(), 3f, false, false);
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] open mill {ex.Message}"); }
    }

    private static int MillablesInInventory()
    {
        int n = 0;
        try
        {
            var inv = GameManager.GetInventoryComponent();
            if (inv == null || inv.m_Items == null) return 0;
            for (int i = 0; i < inv.m_Items.Count; i++)
            {
                var gi = inv.m_Items[i]?.m_GearItem;
                if (gi != null && gi.m_Millable != null) n++;
            }
        }
        catch { }
        return n;
    }

    internal static void Wire(BunkerDef b, string id, GameObject go)
    {
        ModMain.Log?.Msg($"[MoreBunkers] {id} parts: {Parts(go)}");
        if (id != "mill") return;
        // 提示文字那里要找交互物体上的编号,根物体没有会报空引用
        if (go.GetComponent<ObjectGuid>() == null) ObjectGuid.MaybeAttachObjectGuidAddOrReplace(go, MakeGuid(b.Guid + "/mill"));
        var mm = go.AddComponent<MillingMachine>();
        _mills.Add(mm.Pointer);
        var bi = go.GetComponentInChildren<BaseInteraction>(true);
        if (bi == null)
        {
            var mc = go.GetComponentInChildren<MeshCollider>(true);
            bi = (mc != null ? mc.gameObject : go).AddComponent<SimpleInteraction>();
        }
        if (bi.GetComponent<ObjectGuid>() == null) ObjectGuid.MaybeAttachObjectGuidAddOrReplace(bi.gameObject, MakeGuid(b.Guid + "/mill/i"));
        try { bi.m_DefaultHoverText = new LocalizedString { m_LocalizationID = MillText() }; } catch { }
        try { mm.InitializeInteraction(bi); } catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] mill init {ex.Message}"); }
        try
        {
            var cb = DelegateSupport.ConvertDelegate<UnityAction<BaseInteraction>>(new Action<BaseInteraction>(_ => OpenMill(mm)));
            bi.AddEventCallback(InteractionEventType.PerformInteraction, cb);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] mill callback {ex.Message}"); }
        _hover.Add(bi);
    }

    internal static string MakeGuid(string s)
    {
        using var md5 = System.Security.Cryptography.MD5.Create();
        return new Guid(md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(s))).ToString();
    }

    private static string Parts(GameObject go)
    {
        var names = new List<string>();
        foreach (var m in go.GetComponentsInChildren<MonoBehaviour>(true))
        {
            if (m == null) continue;
            var n = m.GetIl2CppType().Name;
            if (!names.Contains(n)) names.Add(n);
        }
        return string.Join(",", names);
    }
}

[HarmonyLib.HarmonyPatch(typeof(MillingMachine), nameof(MillingMachine.PerformInteraction))]
internal static class Patch_MillingMachine_Perform
{
    private static bool Prefix(MillingMachine __instance)
    {
        if (!Stations.IsOurMill(__instance)) return true;
        Stations.OpenMill(__instance);
        return false;
    }
}
