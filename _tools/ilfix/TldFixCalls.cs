using Il2Cpp;
using Il2CppTLD.Gameplay;
using Il2CppTLD.Scenes;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TldIlFix;

// 2026-10-28 游戏更新删掉的方法,按原签名在这里补一份;Program 把这个类克隆进目标 mod,再把调用改指过来
internal static class TldFixCalls
{
    internal static GearItem LoadGearItemPrefab(string name)
    {
        try
        {
            GameObject go = Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)name).WaitForCompletion();
            return go != null ? go.GetComponent<GearItem>() : null;
        }
        catch
        {
            return null;
        }
    }

    internal static bool IsBootSceneActive() => false;

    // 2026-11-06 删存档后回到主菜单 m_ActiveScene 是 null,第五章两个 mod 每帧 .Contains 抛空引用刷日志
    internal static string ActiveScene() => GameManager.m_ActiveScene ?? "";

    // 2.60 删了 ObjectAnim.Start,同样的初始化还在 Initialize 里
    internal static void ObjectAnimStart(ObjectAnim oa) => oa?.Initialize();

    // 2.58 只留了按名字和 AssetReference 生成的重载
    internal static GearItem InstantiateItemAtLocation(PlayerManager pm, GearItem prefab, int numUnits, Vector3 position, bool stickToGround)
    {
        if (pm == null || prefab == null) return null;
        return pm.InstantiateItemAtLocation(prefab.name.Replace("(Clone)", "").Trim(), numUnits, position, stickToGround);
    }

    private static GameObject s_RemovedPanel;

    // 游戏删了安全屋装修的修理面板,mod 只拿它来 SetActive(false),给一个隐藏的空物体
    internal static GameObject get_m_SafehouseCustomizationRepairPanel(Panel_Inventory_Examine panel)
    {
        if (s_RemovedPanel == null)
        {
            s_RemovedPanel = new GameObject("TldFix_RemovedPanel");
            s_RemovedPanel.SetActive(false);
            Object.DontDestroyOnLoad(s_RemovedPanel);
        }
        return s_RemovedPanel;
    }

    internal static RegionSpecification GetRandomRegionFromAllAvailable()
    {
        SandboxBaseConfig cfg = ExperienceModeManager.GetCurrentGameModeConfig()?.TryCast<SandboxBaseConfig>();
        return cfg != null ? cfg.GetRandomStartingRegion() : null;
    }
}
