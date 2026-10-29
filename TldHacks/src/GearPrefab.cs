using Il2Cpp;
using UnityEngine;

namespace TldHacks;

internal static class GearPrefab
{
    // 2026-10 游戏更新删了 GearItem.LoadGearItemPrefab,沙盒改走 Addressables 同步取 prefab;第五章那套游戏还留着原接口。
    // ponytail: 不存在的 key 会让 Addressables 往 Player.log 打一条 InvalidKeyException,调用方都按 null 处理;刷屏了再先查 ResourceLocators。
    // 霰弹枪这类只登记了 GearItemData_ 的物品,模型只在第五章的资源包里,沙盒怎么找都取不到,别再加后备路径
    internal static GearItem Load(string name)
    {
#if EP5_EDITION
        try { return GearItem.LoadGearItemPrefab(name); } catch { return null; }
#else
        try
        {
            var go = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)name).WaitForCompletion();
            return go != null ? go.GetComponent<GearItem>() : null;
        }
        catch { return null; }
#endif
    }
}
