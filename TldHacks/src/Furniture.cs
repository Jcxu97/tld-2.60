using System;
using System.Reflection;
using Il2Cpp;
using UnityEngine;

namespace TldHacks;

// 物品生成器的"家具"栏:家具和器械直接进背包的装饰品栏,从背包里拿出来自己摆。
// 自带装饰品组件的家具这里直接生成,存档交给游戏;铣床、弹药工作台、炉子这些靠 SCPlus 自己存档,转给 SCPlus.Spawner
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
            var t = asm.GetType("SCPlus.Spawner", false);
            if (t == null) continue;
            _spawnCarryable = t.GetMethod("SpawnCarryable", BindingFlags.Public | BindingFlags.Static);
            _setupDecoration = t.GetMethod("SetupDecoration", BindingFlags.Public | BindingFlags.Static);
            break;
        }
        ModMain.Log?.Msg($"[Furniture] SCPlus spawner {(_spawnCarryable != null ? "found" : "missing")}");
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
            CheatState.LastActionLog = I18n.T("这件要装整合包里的自定义安全屋(SCPlus)才能生成", "This one needs the bundled SafehouseCustomizationPlus");
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

    // 和读档重建背包里的装饰品一样:先挂在不激活的临时物体下实例化,AddDecoration 会把它收进背包
    private static bool SpawnNative(string path)
    {
        var temp = new GameObject("TldHacksFurnitureTemp");
        temp.SetActive(false);
        try
        {
            var prefab = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)path).WaitForCompletion();
            if (prefab == null) { ModMain.Log?.Warning($"[Furniture] load failed {path}"); return false; }
            var go = UnityEngine.Object.Instantiate(prefab, temp.transform);
            var di = go.GetComponent<DecorationItem>();
            if (di == null) { UnityEngine.Object.Destroy(go); return false; }
            int slash = path.LastIndexOf('/');
            go.name = path.Substring(slash + 1, path.Length - slash - 1 - ".prefab".Length);
            di.m_AllowInInventory = true;
            _setupDecoration?.Invoke(null, new object[] { di });
            GameManager.GetInventoryComponent().AddDecoration(di);
            go.SetActive(false);
            return true;
        }
        finally { UnityEngine.Object.Destroy(temp); }
    }
#endif
}
