using System;
using System.Reflection;
using System.Text;
using Il2Cpp;
using Il2CppTLD.Trader;
using UnityEngine;

namespace TraderMoving;

// 诊断:按诊断键(默认 F9)把当前状态全部打进日志。
// 用来定位"收进背包却找不到"这类问题 —— 与其静态推断,不如直接读运行时真值。
internal static class Diagnose
{
    private const BindingFlags Inst = BindingFlags.NonPublic | BindingFlags.Instance
                                    | BindingFlags.Public;

    internal static void Dump()
    {
        var sb = new StringBuilder();
        sb.AppendLine("═══ TraderMoving 诊断 ═══");
        sb.AppendLine($"场景: {SafeStr(() => GameManager.m_ActiveScene)}");
        sb.AppendLine($"桥接: Available={ScPlusBridge.Available} 版本={ScPlusBridge.DetectedVersion}"
                    + $" 失败原因={(string.IsNullOrEmpty(ScPlusBridge.FailReason) ? "无" : ScPlusBridge.FailReason)}");
        sb.AppendLine($"pickupable 当前值: {ScPlusBridge.CurrentPickupable()} (正常应为 False)");
        sb.AppendLine($"收纳标记: 无线电={StowRecord.RadioStowed} 交易箱={StowRecord.BoxStowed}");
        sb.AppendLine($"抱着走: IsCarrying={CarryState.IsCarrying} Kind={CarryState.Kind}");
        sb.AppendLine($"待收纳: Armed={StowMode.Armed}");

        // 场景里的无线电
        TraderRadio radio = null;
        try { radio = UnityEngine.Object.FindObjectOfType<TraderRadio>(); } catch { }
        sb.AppendLine($"场景内 TraderRadio: {(radio != null ? "找到" : "没找到")}");

        if (radio != null)
        {
            var go = ((Component)radio).gameObject;
            sb.AppendLine($"  名字: {go.name}");
            sb.AppendLine($"  activeInHierarchy: {go.activeInHierarchy}");
            sb.AppendLine($"  所在场景: {go.scene.name}");
            sb.AppendLine($"  层: {go.layer}");
            sb.AppendLine($"  位置: {go.transform.position}");
            sb.AppendLine($"  TraderRadio.enabled: {((Behaviour)radio).enabled}");
            DumpDecoration(sb, go);
        }

        // 背包里的装饰品清单 —— 这是"找不到"最直接的证据
        DumpInventory(sb);

        // 交易状态
        sb.AppendLine($"进行中交易: {TradeGuard.HasActiveTrade()}");
        try
        {
            var tm = GameManager.GetTraderManager();
            if (tm != null)
                sb.AppendLine($"信任度: {tm.CurrentTrust}/{tm.MaxTrust}");
        }
        catch { }

        sb.AppendLine("═══════════════════════");
        ModMain.Log?.Msg(sb.ToString());
        HUDMessage.AddMessage("诊断信息已写入日志", false, false);
    }

    private static void DumpDecoration(StringBuilder sb, GameObject go)
    {
        var di = go.GetComponent<DecorationItem>() ?? go.GetComponentInChildren<DecorationItem>();
        if (di == null) { sb.AppendLine("  DecorationItem: 无(背包收纳链进不去)"); return; }

        sb.AppendLine("  DecorationItem: 有");
        var t = di.GetType();
        // Il2CppInterop 把 IL2Cpp 字段包装成属性,所以先读属性再退回字段
        foreach (var n in new[] { "m_AllowInInventory", "m_Category", "m_Weight", "m_PlacementRules" })
            sb.AppendLine($"    {n} = {ReadMember(t, di, n)}");
        try
        {
            sb.AppendLine($"    AllowInInventory(只读属性) = {di.AllowInInventory}");
        }
        catch { }
        // 图标走反射读,避免为一行诊断输出引入 Unity.Addressables 依赖
        try
        {
            var pi = t.GetProperty("IconReference", Inst);
            var icon = pi?.GetValue(di);
            sb.AppendLine($"    图标: {(icon != null ? "有" : "无")}");
        }
        catch { }
    }

    private static void DumpInventory(StringBuilder sb)
    {
        try
        {
            var inv = GameManager.GetInventoryComponent();
            if (inv == null) { sb.AppendLine("背包组件: null"); return; }

            var list = inv.m_DecorationItems;
            if (list == null) { sb.AppendLine("背包装饰品列表: null"); return; }

            sb.AppendLine($"背包装饰品数量: {list.Count}");
            for (int i = 0; i < list.Count; i++)
            {
                var d = list[i];
                if (d == null) { sb.AppendLine($"  [{i}] null"); continue; }
                bool isRadio = false;
                try { isRadio = ((Component)d).GetComponentInChildren<TraderRadio>() != null; } catch { }
                sb.AppendLine($"  [{i}] {((UnityEngine.Object)d).name}"
                            + $" allowInInv={SafeBool(d)}"
                            + (isRadio ? "  ← 无线电在这里" : ""));
            }
        }
        catch (Exception ex) { sb.AppendLine($"背包读取失败: {ex.Message}"); }
    }

    private static string SafeBool(DecorationItem d)
        => ReadMember(d.GetType(), d, "m_AllowInInventory");

    // 属性优先、字段后备(Il2CppInterop 把字段包装成属性)
    private static string ReadMember(Type t, object inst, string name)
    {
        try
        {
            var p = t.GetProperty(name, Inst);
            if (p != null) return p.GetValue(inst)?.ToString() ?? "null";
            var f = t.GetField(name, Inst);
            if (f != null) return f.GetValue(inst)?.ToString() ?? "null";
            return "成员不存在";
        }
        catch (Exception ex) { return "读取异常:" + ex.GetType().Name; }
    }

    private static string SafeStr(Func<string> f)
    {
        try { return f() ?? "null"; }
        catch { return "读取失败"; }
    }
}
