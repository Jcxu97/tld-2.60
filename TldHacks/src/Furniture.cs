using System;
using System.Reflection;
using Il2Cpp;
using UnityEngine;

namespace TldHacks;

// 物品生成器的"家具"栏:家具和器械直接进背包的装饰品栏,从背包里拿出来自己摆。
// 自带装饰品组件的家具这里直接生成,存档交给游戏;铣床、弹药工作台、炉子这些靠 SCPlus 自己存档,转给 SCPlusFix++ 的 Spawner
internal static class Furniture
{
#if STORY_EDITION || EP5_EDITION
    internal static int Count => 0;
    internal static void ResolveNames() { }
    internal static void Spawn(ItemEntry e, int qty) { }
#else
    internal static int Count => FurnitureDatabase.Carryables.Count + FurnitureDatabase.Native.Count;

    private static bool _looked;
    private static MethodInfo _spawnCarryable, _setupDecoration;

    private static void Look()
    {
        if (_looked) return;
        _looked = true;
        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            var t = asm.GetType("SCPlusPP.Spawner", false);
            if (t == null) continue;
            _spawnCarryable = t.GetMethod("SpawnCarryable", BindingFlags.Public | BindingFlags.Static);
            _setupDecoration = t.GetMethod("SetupDecoration", BindingFlags.Public | BindingFlags.Static);
            break;
        }
        ModMain.Log?.Msg($"[Furniture] SCPlusFix++ spawner {(_spawnCarryable != null ? "found" : "missing")}");
    }

    internal static void ResolveNames()
    {
        foreach (var e in FurnitureDatabase.Native)
        {
            e.NameZh = e.Name;
            e.NameEn = e.Name;
            try
            {
                string dn = Localization.Get(e.Remark);
                if (string.IsNullOrEmpty(dn) || dn == e.Remark) continue;
                bool zh = false;
                foreach (char c in dn) if (c >= 0x4E00 && c <= 0x9FFF) { zh = true; break; }
                if (zh) e.NameZh = dn; else e.NameEn = dn;
            }
            catch { }
        }
        foreach (var e in FurnitureDatabase.Carryables) e.NameZh = e.Name;
    }

    internal static void Spawn(ItemEntry e, int qty)
    {
        Look();
        bool carry = string.IsNullOrEmpty(e.Remark);
        if (carry && _spawnCarryable == null)
        {
            CheatState.LastActionLog = I18n.T("这件要装 SCPlusFix++(自定义安全屋修复版)才能生成", "This one needs SCPlusFix++");
            return;
        }
        int ok = 0;
        for (int i = 0; i < qty; i++)
        {
            try
            {
                if (carry ? (bool)_spawnCarryable.Invoke(null, new object[] { e.PrefabName }) : SpawnNative(e.PrefabName)) ok++;
                else break;
            }
            catch (Exception ex) { ModMain.Log?.Error($"[Furniture] {e.PrefabName} {ex.InnerException?.Message ?? ex.Message}"); break; }
        }
        string name = I18n.IsEnglish ? e.NameEn : e.NameZh;
        ModMain.Log?.Msg($"[Furniture] +{ok}/{qty} {e.PrefabName}");
        CheatState.LastActionLog = ok > 0
            ? I18n.T($"已放进背包 ×{ok} {name},在背包的装饰品里拿出来摆放", $"Added ×{ok} {name} to the decorations in your backpack")
            : I18n.T($"生成失败:{name}(看 Latest.log 里 [Furniture] 行)", $"Spawn failed: {name} (see [Furniture] in Latest.log)");
    }

    // 走游戏自己做好家具进背包的那条路(InstantiateDecorationItemInPlayerInventory):激活实例化,Placeable.Awake 先拿到 guid 登记,
    // AddDecoration 里的 MoveToPlayer 才生效,摆出去以后才进场景存档。以前在不激活的临时物体下实例化,Awake 晚到摆放时才跑,存档链断了,回屋就没了
    private static bool SpawnNative(string path)
    {
        var prefab = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)path).WaitForCompletion();
        var pdi = prefab != null ? prefab.GetComponent<DecorationItem>() : null;
        if (pdi == null) { ModMain.Log?.Warning($"[Furniture] load failed {path}"); return false; }
        bool allow = pdi.m_AllowInInventory;
        var inject = InjectPdidsField();
        object injectOld = inject?.GetValue(null);
        DecorationItem di;
        try
        {
            pdi.m_AllowInInventory = true;
            // SCPlus 的 Placeable.Awake 前缀开着时按坐标算 guid,一次生成几件都在玩家脚下会撞成同一个
            inject?.SetValue(null, false);
            di = GameManager.GetPlayerManagerComponent().InstantiateDecorationItemInPlayerInventory(pdi, PlayerManager.InventoryInstantiateFlags.None);
        }
        finally
        {
            pdi.m_AllowInInventory = allow;
            if (inject != null) inject.SetValue(null, injectOld);
        }
        if (di == null) { ModMain.Log?.Warning($"[Furniture] instantiate failed {path}"); return false; }
        int slash = path.LastIndexOf('/');
        di.gameObject.name = path.Substring(slash + 1, path.Length - slash - 1 - ".prefab".Length);
        di.m_AllowInInventory = true;
        _setupDecoration?.Invoke(null, new object[] { di });
        return true;
    }

    private static FieldInfo _inject;
    private static bool _injectLooked;
    private static FieldInfo InjectPdidsField()
    {
        if (_injectLooked) return _inject;
        _injectLooked = true;
        foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
        {
            var t = asm.GetType("SCPlusPP.DecorationPatches", false) ?? asm.GetType("SCPlus.DecorationPatches", false);
            if (t == null) continue;
            _inject = t.GetField("injectPdids", BindingFlags.Public | BindingFlags.Static);
            if (_inject != null) break;
        }
        return _inject;
    }
#endif
}
