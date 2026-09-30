using Il2Cpp;
using UnityEngine;

namespace TldHacks;

/// <summary>
/// Runtime tick: decay sync + torch prefab.
/// Movement speed handled by Harmony patch on vp_FPSController.GetSlopeMultiplier.
/// Stamina handled by Harmony patch on PlayerMovement.Update.
/// </summary>
internal static class TweaksRuntime
{
    private static int _frameCount;
    private static bool _torchPrefabSet;
    // v7.7 已写进 prefab 的燃烧分钟数;滑条改动后需要重写 prefab(见 Tick)
    private static float _torchPrefabMinutes = float.NaN;

    public static void Tick()
    {
        var s = ModMain.Settings;
        if (s == null) return;

        _frameCount++;

        if (_frameCount % 60 == 3) SyncDecayState(s);

        // v7.7 性能修 + 行为修,两件事:
        //   (1) 原先是 `if (!_torchPrefabSet) SetTorchPrefab(s);` —— 每帧调一次资源加载 API。
        //       主菜单里 prefab 恒为 null 所以标记永不置位,等于在主菜单永久每帧 60 次
        //       LoadGearItemPrefab。降到 60 帧一次 + 只在游戏场景里试。
        //   (2) 原先 prefab 一旦写成功就永不复位(ResetTorchPrefab 零调用者),
        //       进游戏后拖"火把燃烧分钟"滑条 → 新造的火把还是旧值。
        //       改成记住已写入的值,滑条一变就重写一次 prefab。
        if (_frameCount % 60 == 17)
        {
            bool needWrite = !_torchPrefabSet
                          || !Mathf.Approximately(_torchPrefabMinutes, s.TorchBurnMinutes);
            if (needWrite && InGameplay()) SetTorchPrefab(s);
        }
    }

    // 主菜单 / 空场景里 prefab 拿不到,别白试
    private static bool InGameplay()
    {
        try { return !GameManager.IsMainMenuActive() && !GameManager.IsEmptySceneActive(); }
        catch { return false; }
    }

    private static void SetTorchPrefab(TldHacksSettings s)
    {
        try
        {
#if STORY_EDITION
            // 2.24 拿不到 prefab 本体(StoryShim 会实例化一支新火把),改它不影响之后生成的火把,还会漏一支在场景里
            _torchPrefabSet = true;
            _torchPrefabMinutes = s.TorchBurnMinutes;
#else
            var prefab = GearItem.LoadGearItemPrefab("GEAR_Torch");
            if (prefab == null) return;
            var torch = prefab.GetComponent<TorchItem>();
            if (torch != null)
            {
                torch.m_BurnLifetimeMinutes = s.TorchBurnMinutes;
                _torchPrefabSet = true;
                _torchPrefabMinutes = s.TorchBurnMinutes;
            }
#endif
        }
        catch { }
    }

    public static void ResetTorchPrefab() { _torchPrefabSet = false; _torchPrefabMinutes = float.NaN; }

    internal static void SyncDecayState(TldHacksSettings s)
    {
        try
        {
            DecayState.GeneralDecay = s.GeneralDecay;
            DecayState.DecayBeforePickup = s.DecayBeforePickup;
            DecayState.OnUseDecay = s.OnUseDecay;
            DecayState.FoodDecay = s.FoodDecay;
            DecayState.RawMeatDecay = s.RawMeatDecay;
            DecayState.CookedMeatDecay = s.CookedMeatDecay;
            DecayState.DrinksDecay = s.DrinksDecay;
            DecayState.ClothingDecayRate = s.ClothingDecayRate;
            DecayState.GunDecay = s.GunDecay;
            DecayState.BowDecay = s.BowDecay;
            DecayState.ToolsDecay = s.ToolsDecay;
            DecayState.BedrollDecay = s.BedrollDecay;
            DecayState.TravoisDecay = s.TravoisDecay;
            DecayState.ArrowDecay = s.ArrowDecay;
            DecayState.SnareDecay = s.SnareDecay;
            DecayState.FirestartingDecay = s.FirestartingDecay;
            DecayState.CuredMeatDecay = s.CuredMeatDecay;
            DecayState.RawFishDecay = s.RawFishDecay;
            DecayState.CookedFishDecay = s.CookedFishDecay;
            DecayState.CannedFoodDecay = s.CannedFoodDecay;
            DecayState.CoffeeTeaDecay = s.CoffeeTeaDecay;
            DecayState.PackagedFoodDecay = s.PackagedFoodDecay;
            DecayState.OtherFoodDecay = s.OtherFoodDecay;
            DecayState.FatDecay = s.FatDecay;
            DecayState.CuredFishDecay = s.CuredFishDecay;
            DecayState.IngredientsDecay = s.IngredientsDecay;
            DecayState.HideDecay = s.HideDecay;
            DecayState.FirstAidDecay = s.FirstAidDecay;
            DecayState.WaterPurifierDecay = s.WaterPurifierDecay;
            DecayState.CookingPotDecay = s.CookingPotDecay;
            DecayState.FlareGunAmmoDecay = s.FlareGunAmmoDecay;
            DecayState.WhetstoneDecay = s.WhetstoneDecay;
            DecayState.CanOpenerDecay = s.CanOpenerDecay;
            DecayState.PrybarDecay = s.PrybarDecay;
            DecayState.BodyHarvestDecay = s.BodyHarvestDecay;
            MeatState.DeerMin = s.DeerMeatMultMin;
            MeatState.DeerMax = s.DeerMeatMultMax;
        }
        catch { }
    }
}

internal static class DecayState
{
    // v3.0.3: 所有默认 = 1.0(原版),保证 HasNonDefault 默认 false → patch 不挂载
    public static float GeneralDecay = 1f;
    public static float DecayBeforePickup = 1f;
    public static float OnUseDecay = 1f;
    public static float FoodDecay = 1f;
    public static float RawMeatDecay = 1f;
    public static float CookedMeatDecay = 1f;
    public static float DrinksDecay = 1f;
    public static float ClothingDecayRate = 1f;
    public static float GunDecay = 1f;
    public static float BowDecay = 1f;
    public static float ToolsDecay = 1f;
    public static float BedrollDecay = 1f;
    public static float TravoisDecay = 1f;
    public static float ArrowDecay = 1f;
    public static float SnareDecay = 1f;
    public static float FirestartingDecay = 1f;
    public static float CuredMeatDecay = 1f;
    public static float RawFishDecay = 1f;
    public static float CookedFishDecay = 1f;
    public static float CannedFoodDecay = 1f;
    public static float CoffeeTeaDecay = 1f;
    public static float PackagedFoodDecay = 1f;
    public static float OtherFoodDecay = 1f;
    public static float FatDecay = 1f;
    public static float CuredFishDecay = 1f;
    public static float IngredientsDecay = 1f;
    public static float HideDecay = 1f;
    public static float FirstAidDecay = 1f;
    public static float WaterPurifierDecay = 1f;
    public static float CookingPotDecay = 1f;
    public static float FlareGunAmmoDecay = 1f;
    public static float WhetstoneDecay = 1f;
    public static float CanOpenerDecay = 1f;
    public static float PrybarDecay = 1f;
    public static float BodyHarvestDecay = 1f;

    // v3.0.3: 扩展到全部细分字段(之前只检查 10 个,导致细分 slider 不挂载 patch)
    public static bool HasNonDefaultMultiplier()
    {
        const float e = 0.001f;
        return Mathf.Abs(GeneralDecay - 1f) > e || Mathf.Abs(DecayBeforePickup - 1f) > e
            || Mathf.Abs(OnUseDecay - 1f) > e || Mathf.Abs(FoodDecay - 1f) > e
            || Mathf.Abs(RawMeatDecay - 1f) > e || Mathf.Abs(CookedMeatDecay - 1f) > e
            || Mathf.Abs(DrinksDecay - 1f) > e || Mathf.Abs(ClothingDecayRate - 1f) > e
            || Mathf.Abs(GunDecay - 1f) > e || Mathf.Abs(BowDecay - 1f) > e
            || Mathf.Abs(ToolsDecay - 1f) > e || Mathf.Abs(BedrollDecay - 1f) > e
            || Mathf.Abs(TravoisDecay - 1f) > e || Mathf.Abs(ArrowDecay - 1f) > e
            || Mathf.Abs(SnareDecay - 1f) > e || Mathf.Abs(FirestartingDecay - 1f) > e
            || Mathf.Abs(CuredMeatDecay - 1f) > e || Mathf.Abs(RawFishDecay - 1f) > e
            || Mathf.Abs(CookedFishDecay - 1f) > e || Mathf.Abs(CannedFoodDecay - 1f) > e
            || Mathf.Abs(CoffeeTeaDecay - 1f) > e || Mathf.Abs(PackagedFoodDecay - 1f) > e
            || Mathf.Abs(OtherFoodDecay - 1f) > e || Mathf.Abs(FatDecay - 1f) > e
            || Mathf.Abs(CuredFishDecay - 1f) > e || Mathf.Abs(IngredientsDecay - 1f) > e
            || Mathf.Abs(HideDecay - 1f) > e || Mathf.Abs(FirstAidDecay - 1f) > e
            || Mathf.Abs(WaterPurifierDecay - 1f) > e || Mathf.Abs(CookingPotDecay - 1f) > e
            || Mathf.Abs(FlareGunAmmoDecay - 1f) > e || Mathf.Abs(WhetstoneDecay - 1f) > e
            || Mathf.Abs(CanOpenerDecay - 1f) > e || Mathf.Abs(PrybarDecay - 1f) > e
            || Mathf.Abs(BodyHarvestDecay - 1f) > e;
    }
}
