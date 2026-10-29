using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using Il2Cpp;
#if !STORY_EDITION   // 2.24 无此命名空间(2.24 之后才加入游戏)
using Il2CppTLD.Interactions;
using KeroseneLampT = Il2CppTLD.Gear.KeroseneLampItem;
#else
using KeroseneLampT = Il2Cpp.KeroseneLampItem;   // 2.24 煤油灯还在根命名空间
#endif
using MelonLoader;
using UnityEngine;

namespace TldHacks;

// ═══════════════════════════════════════════════════════════════
// TT-CapFeelsLikeTemp: 体感温度上下限
// ═══════════════════════════════════════════════════════════════

internal static class Patch_CapFeelsLikeTemp
{
    // v7.7 三个 GameManager.Get*() 原先都没判 null,任一为 null(场景切换/存档加载中途)
    //   就抛 NRE。这里没有 try/catch → 异常穿出 Postfix,直接打断 vanilla 的体温计算。
    //   返回 true(= 视作靠近火源)是安全的失败方向:跳过封顶,不改 vanilla 结果。
    private static bool IsNearCampFire()
    {
        var fm = GameManager.GetFireManagerComponent();
        var tr = GameManager.GetPlayerTransform();
        var bh = GameManager.GetBodyHarvestManagerComponent();
        if (fm == null || tr == null || bh == null) return true;
        return fm.GetDistanceToClosestFire(tr.position) < bh.m_RadiusToThawFromFire;
    }

    internal static void Postfix(ref float __result)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null) return;
            var w = GameManager.GetWeatherComponent();
            if ((w && w.IsIndoorEnvironment()) || IsNearCampFire()) return;
            if (s.TT_CapFeelsHigh != 0 && __result > s.TT_CapFeelsHigh) __result = s.TT_CapFeelsHigh;
            if (s.TT_CapFeelsLow != 0 && __result < s.TT_CapFeelsLow) __result = s.TT_CapFeelsLow;
        }
        catch { }
    }
}

// ═══════════════════════════════════════════════════════════════
// TT-DeathTriggerGoat: 坠落死亡触发器无效化 + 坠落伤害倍率
// ═══════════════════════════════════════════════════════════════

internal static class Patch_FallDeathTrigger
{
    internal static void Postfix(Collider c)
    {
        try
        {
            if (c == null || !c.gameObject.CompareTag("Player")) return;
            var fd = GameManager.GetFallDamageComponent();
            if (fd != null) fd.m_DieOnNextFall = false;
        }
        catch { }
    }
}

internal static class Patch_FallDamageMultiplier
{
    internal static void Postfix()
    {
        // v7.7 修崩溃:这个 Postfix 挂在 GameManager.Awake 上,而 FallDamage 组件此时通常还没
        //   注册(GetFallDamageComponent() 返回 null),原先无 null 检查也无 try/catch →
        //   NRE 从 Postfix 抛出打断 Awake 的调用链 → 开了 TT_FallDeathGoat 就进不了游戏。
        //   现在拿不到组件就静默跳过;真正生效点是 ApplyNow()(场景 init 后补一次)。
        ApplyNow();
    }

    // v7.7 因为 Awake 时组件多半还是 null,倍率其实一直没写进去(功能形同没实现)。
    //   补一个场景加载后的施加点(ModMain.OnSceneWasInitialized 调用),开关关着时不写。
    internal static void ApplyNow()
    {
        try
        {
            if (!CheatState.TT_FallDeathGoat) return;
            var fd = GameManager.GetFallDamageComponent();
            var s = ModMain.Settings;
            if (fd != null && s != null) fd.m_DamagePerMeter = s.TT_FallDamageMult;
        }
        catch { }
    }
}

// ═══════════════════════════════════════════════════════════════
// TT-DroppedObjectOrientation: 步枪落地竖立
// ═══════════════════════════════════════════════════════════════

internal static class Patch_DroppedObjectOrientation
{
    internal static void Postfix()
    {
        // 剧情版整段不编:2.24 拿不到 prefab 本体(StoryShim 会实例化),改的是新复制品,不生效还每次漏 6 件在场景里
#if !STORY_EDITION
        try
        {
            string[] rifles = { "GEAR_Rifle", "GEAR_Rifle_Barbs", "GEAR_Rifle_Curators", "GEAR_Rifle_Vaughns", "GEAR_Rifle_Trader" };
            foreach (var name in rifles)
            {
#if STORY_EDITION
                var gi = StoryShim.LoadGearItemPrefab(name);
#else
                var gi = GearPrefab.Load(name);
#endif
                if (gi == null) continue;
                var posDummy = gi.gameObject.transform.FindChild("DropDummy");
                if (posDummy != null) posDummy.eulerAngles = new Vector3(0f, 0f, 270f);
            }
#if STORY_EDITION
            var matches = StoryShim.LoadGearItemPrefab("GEAR_WoodMatches");
#else
            var matches = GearPrefab.Load("GEAR_WoodMatches");
#endif
            if (matches != null)
            {
                var lod0 = matches.gameObject.transform.FindChild("OBJ_WoodMatches_LOD0");
                var lod1 = matches.gameObject.transform.FindChild("OBJ_WoodMatches_LOD1");
                if (lod0 != null)
                {
                    matches.GetComponent<Inspect>().m_Angles = new Vector3(-50f, 20f, 0f);
                    lod0.localEulerAngles = new Vector3(0f, 180f, 0f);
                    lod0.localPosition = Vector3.zero;
                }
                if (lod1 != null)
                {
                    lod1.localEulerAngles = new Vector3(0f, 180f, 0f);
                    lod1.localPosition = Vector3.zero;
                }
            }
        }
        catch { }
#endif
    }
}

// ═══════════════════════════════════════════════════════════════
// TT-ExtendedFOVSlider: FOV 滑块范围扩展 30-150
// ═══════════════════════════════════════════════════════════════

internal static class Patch_ExtendedFOV_Apply
{
    internal static void Postfix(Panel_OptionsMenu __instance)
    {
        __instance.m_FieldOfViewMax = 150f;
        __instance.m_FieldOfViewMin = 30f;
        __instance.m_FieldOfViewSlider.m_Slider.numberOfSteps = 121;
    }
}

internal static class Patch_ExtendedFOV_Display
{
    internal static void Postfix(Panel_OptionsMenu __instance)
    {
        __instance.m_FieldOfViewMax = 150f;
        __instance.m_FieldOfViewMin = 30f;
        __instance.m_FieldOfViewSlider.m_Slider.numberOfSteps = 121;
    }
}

// ═══════════════════════════════════════════════════════════════
// TT-PauseOnRadial: 开辐射轮时暂停
// ═══════════════════════════════════════════════════════════════

internal static class PauseOnRadialState
{
    public static bool IsSlowed;
    public static object Coroutine;

    public static IEnumerator LerpTimescale(float value, float speed)
    {
        float current = Time.timeScale;
        float lerp = 0f;
        while (!Mathf.Approximately(value, Time.timeScale))
        {
            Time.timeScale = GameManager.m_GlobalTimeScale = Mathf.Lerp(current, value, lerp += Time.unscaledDeltaTime * speed);
            yield return new WaitForEndOfFrame();
        }
    }
}

internal static class Patch_PauseOnRadial_Enable
{
    internal static void Prefix(bool enable)
    {
        // v7.7 修「关功能卡在 0.1 倍速」:恢复分支(!enable)不再受开关门控。
        //   原先整个方法首行就 `if (!CheatState.TT_PauseOnRadial) return;`,于是轮盘开着
        //   (timeScale 已压到 0.1)时把开关关掉 → 松开轮盘也没人把 timeScale 写回 1
        //   → 永久 10 倍慢速,只能重启游戏。现在只有「压慢」需要开关,「恢复」永远允许。
        if (!CheatState.TT_PauseOnRadial && !PauseOnRadialState.IsSlowed) return;
        if (enable && !PauseOnRadialState.IsSlowed && CheatState.TT_PauseOnRadial)
        {
            if (PauseOnRadialState.Coroutine != null) MelonCoroutines.Stop(PauseOnRadialState.Coroutine);
            PauseOnRadialState.Coroutine = MelonCoroutines.Start(PauseOnRadialState.LerpTimescale(0.1f, 1f));
            PauseOnRadialState.IsSlowed = true;
        }
        if (!enable && PauseOnRadialState.IsSlowed)
        {
            if (PauseOnRadialState.Coroutine != null) MelonCoroutines.Stop(PauseOnRadialState.Coroutine);
            PauseOnRadialState.Coroutine = MelonCoroutines.Start(PauseOnRadialState.LerpTimescale(1f, 3f));
            PauseOnRadialState.IsSlowed = false;
        }
    }
}

internal static class Patch_PauseOnRadial_FoolProof
{
    internal static void Postfix()
    {
        // v7.7 同上:这是第二条恢复路径,也不能被开关挡住(它是「轮盘没正常发 Enable(false)」
        //   时的兜底)。IsSlowed==false 时立刻退出,所以功能关着时开销仍是一次 bool 判定。
        if (!PauseOnRadialState.IsSlowed) return;
        try
        {
            // v7.7 GetPanel<T>() 可能返回 null(主菜单/面板未创建),原先直接 .IsEnabled()
            //   解引用且整个方法无 try/catch,而它挂在 GameManager.Update 上(每帧)。
            var panel = InterfaceManager.GetPanel<Panel_ActionsRadial>();
            if (panel != null && panel.IsEnabled()) return;
        }
        catch { }

        // 拿不到面板 或 面板已关 → 恢复速度
        // 和 Enable(false) 一样先停旧协程并存新句柄:压速协程还没跑完就起恢复协程,两个会每帧互相覆盖 timeScale,谁也退不出
        if (PauseOnRadialState.Coroutine != null) MelonCoroutines.Stop(PauseOnRadialState.Coroutine);
        PauseOnRadialState.Coroutine = MelonCoroutines.Start(PauseOnRadialState.LerpTimescale(1f, 3f));
        PauseOnRadialState.IsSlowed = false;
    }
}

// ═══════════════════════════════════════════════════════════════
// TT-SpeedyInteractions: 交互加速
// ═══════════════════════════════════════════════════════════════

internal static class Patch_Speedy_Eating
{
    internal static void Prefix(ref GearItem gi)
    {
        float m = ModMain.Settings.TT_EatingSpeedMult;
        if (m != 1f) { gi.m_FoodItem.m_TimeToEatSeconds /= m; gi.m_FoodItem.m_TimeToOpenAndEatSeconds /= m; }
    }
    internal static void Postfix(ref GearItem gi)
    {
        float m = ModMain.Settings.TT_EatingSpeedMult;
        if (m != 1f) { gi.m_FoodItem.m_TimeToEatSeconds *= m; gi.m_FoodItem.m_TimeToOpenAndEatSeconds *= m; }
    }
}

internal static class Patch_Speedy_Smash
{
    [ThreadStatic] static int _saved;
    internal static void Prefix(ref GearItem gi)
    {
        float m = ModMain.Settings.TT_EatingSpeedMult;
        _saved = gi.m_SmashableItem.m_TimeToSmash;
        if (m != 1f) gi.m_SmashableItem.m_TimeToSmash = Mathf.FloorToInt(_saved / m);
    }
    internal static void Postfix(ref GearItem gi)
    {
        gi.m_SmashableItem.m_TimeToSmash = _saved;
    }
}

internal static class Patch_Speedy_Drink
{
    internal static void Prefix(ref WaterSupply ws)
    {
        float m = ModMain.Settings.TT_EatingSpeedMult;
        if (m != 1f) ws.m_TimeToDrinkSeconds /= m;
    }
    internal static void Postfix(ref WaterSupply ws)
    {
        float m = ModMain.Settings.TT_EatingSpeedMult;
        if (m != 1f) ws.m_TimeToDrinkSeconds *= m;
    }
}

internal static class Patch_Speedy_Refuel
{
    internal static void Prefix(Panel_Inventory_Examine __instance)
    {
        float m = ModMain.Settings.TT_GlobalSpeedMult;
        if (m != 1f) { var kli = __instance.m_GearItem.GetComponent<KeroseneLampT>(); if (kli) kli.m_RefuelTimeSeconds /= m; }
    }
    internal static void Postfix(Panel_Inventory_Examine __instance)
    {
        float m = ModMain.Settings.TT_GlobalSpeedMult;
        if (m != 1f) { var kli = __instance.m_GearItem.GetComponent<KeroseneLampT>(); if (kli) kli.m_RefuelTimeSeconds *= m; }
    }
}

internal static class Patch_Speedy_Purify
{
    internal static void Prefix(ref GearItem gi)
    {
        float m = ModMain.Settings.TT_GlobalSpeedMult;
        if (m != 1f) gi.m_PurifyWater.m_ProgressBarDurationSeconds /= m;
    }
    internal static void Postfix(ref GearItem gi)
    {
        float m = ModMain.Settings.TT_GlobalSpeedMult;
        if (m != 1f) gi.m_PurifyWater.m_ProgressBarDurationSeconds *= m;
    }
}

// v7.7 交互加速的公共快照器,修两个问题:
//   (1) 原先各 patch 用硬编码的 vanilla 常量做除法(3f/5f/2f/10f)。这些是可序列化的 panel
//       字段,难度/版本一变常量就错,会把玩家的值直接写坏而不只是"没加速"。
//       改成第一次见到该字段时记下真实值当基准(panel 是单例,基准恒定)。
//   (2) 原先写进去就永不恢复:关掉倍率 → spec 卸载 → prefix 再也不跑 → 字段永远停在改过的值。
//       现在把「还原成基准」登记下来,由 ModMain 的 0.5s tick 在倍率回到 1 时执行一次。
internal static class SpeedyGuard
{
    // key = 字段标识(patch 类名),value = vanilla 基准值。panel 是单例,基准恒定。
    private static readonly Dictionary<string, float> _bases = new();
    // 已被改写、等待还原的字段。value 是「写回基准值」的闭包。
    private static readonly Dictionary<string, System.Action> _restores = new();

    /// <summary>
    /// 按倍率写字段。首次调用时把 current 记为 vanilla 基准,之后永远从基准算(不累乘)。
    /// mult==1 时写回基准并撤销还原登记。
    /// </summary>
    public static void Apply(string key, float current, float mult, System.Action<float> set)
    {
        if (!_bases.TryGetValue(key, out float b)) { b = current; _bases[key] = b; }
        if (mult != 1f && mult > 0f)
        {
            _restores[key] = () => set(b);
            set(b / mult);
        }
        else
        {
            _restores.Remove(key);
            set(b);
        }
    }

    public static bool HasPending => _restores.Count > 0;

    /// <summary>
    /// 取该 key 的 vanilla 基准;没记过就返回 fallback。
    /// 给「另有写入者」的字段做快照时用:直接照字段当前值快照,可能快照到 SpeedyGuard 写进去的
    /// 加速值,那个功能关掉时会把加速值当原值还回去,而 SpeedyGuard 的还原登记此时可能已消耗掉
    /// (倍率先拖回 1),字段就永久停在加速值。
    /// </summary>
    public static float VanillaOr(string key, float fallback)
        => _bases.TryGetValue(key, out float b) ? b : fallback;

    // 每个 key 归哪个滑条管。只有 Breakdown 走拆解倍率,其余都走全局倍率。
    private static bool OwnerMultIsOne(string key)
    {
        var s = ModMain.Settings;
        if (s == null) return false;
        return key == "Breakdown"
            ? Mathf.Approximately(s.TT_BreakdownSpeedMult, 1f)
            : Mathf.Approximately(s.TT_GlobalSpeedMult, 1f);
    }

    // 倍率关掉后由 ModMain tick 调:把该还的字段写回 vanilla 基准。
    // v7.7 改成按 key 逐个判own倍率 —— 原先要求两个滑条同时为 1 才还,于是"只把全局倍率拖回 1、
    //   拆解倍率还没动"时,Crafting/Cook/Milling 等 spec 已卸载(prefix 不再跑)却又被这道门挡住,
    //   字段永久停在加速值,正是这次要修的问题本身。
    public static void RestoreSettled()
    {
        if (_restores.Count == 0) return;
        System.Collections.Generic.List<string> done = null;
        foreach (var kv in _restores)
        {
            if (!OwnerMultIsOne(kv.Key)) continue;
            try { kv.Value(); } catch { }
            (done ??= new System.Collections.Generic.List<string>()).Add(kv.Key);
        }
        if (done != null)
            for (int i = 0; i < done.Count; i++) _restores.Remove(done[i]);
    }

    // 场景切换:闭包里的 wrapper 可能已失效(IL2Cpp 对象被销毁),所以先试着还原再丢弃登记。
    // v8.0 原先直接 _restores.Clear() 就走 —— 但 TLD 的 Panel_* 挂在跨场景存活的 UI 根上,
    //   换区域后字段还停在加速值,而登记已经被扔掉:此时把倍率拖回 1,RestoreSettled 已经无事可做,
    //   字段就永久卡在加速值(要重启游戏才能救)。逐个 try 还原,面板真的死了就由 catch 吞掉。
    //   基准值(_bases)保留:vanilla 常量跨场景不变,重新采样反而会把加速值当基准记下来。
    public static void OnSceneChange()
    {
        if (_restores.Count == 0) return;
        foreach (var kv in _restores) { try { kv.Value(); } catch { } }
        _restores.Clear();
    }
}

// v7.7 注意:这一个**不能**走 SpeedyGuard,保持原来的相对写法(/= m)。
//   m_ProgressBarTimeSeconds 不是 panel 常量,而是 vanilla 每次动作前重新赋的运行时值
//   (同一个 Panel_Inventory_Examine 要服务修理/采集/阅读,各自时长不同)。
//   SpeedyGuard 的语义是"首次见到的值就是 vanilla 基准且恒定",套在这里会把第一次动作的
//   时长永久固定成基准 → 之后读 1 小时的书和 5 小时的书变成同一时长。
//   也正因为 vanilla 每次都重赋值,这里不需要还原登记:倍率拖回 1 后下一次动作自然是原值。
internal static class Patch_Speedy_Examine
{
    internal static void Prefix(Panel_Inventory_Examine __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            float m = __instance.IsResearchItem() ? s.TT_ReadingSpeedMult : s.TT_GlobalSpeedMult;
            if (m != 1f && m > 0f) __instance.m_ProgressBarTimeSeconds /= m;
        }
        catch { }
    }
}

// RockCache 的两个字段是 int,单独处理(基准同样取首见值,不再硬编码 2f)
internal static class Patch_Speedy_RockCacheBuild
{
    private static int _base = -1;
    internal static void Prefix(RockCache __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            if (_base < 0) _base = __instance.m_BuildRealSecondsElapsed;
            float m = s.TT_GlobalSpeedMult;
            __instance.m_BuildRealSecondsElapsed =
                (m != 1f && m > 0f) ? Mathf.Max(1, Mathf.CeilToInt(_base / m)) : _base;
        }
        catch { }
    }
}

internal static class Patch_Speedy_RockCacheDismantle
{
    private static int _base = -1;
    internal static void Prefix(RockCache __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            if (_base < 0) _base = __instance.m_DismantleRealSecondsElapsed;
            float m = s.TT_GlobalSpeedMult;
            __instance.m_DismantleRealSecondsElapsed =
                (m != 1f && m > 0f) ? Mathf.Max(1, Mathf.CeilToInt(_base / m)) : _base;
        }
        catch { }
    }
}

internal static class Patch_Speedy_Breakdown
{
    internal static void Prefix(Panel_BreakDown __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            // v7.7 m_SecondsToBreakDown 另有两个写入者(秒拆解写 0.2、快速交互每 180 帧写 0),
            //   它们可能先跑 → 首次取基准会把 0.2/0 当成 vanilla 值永久固化,倍率拖回 1 时
            //   反而主动把面板写成 0.2。这两个功能开着时干脆不动:它们本身就是"瞬间完成",
            //   再叠一层加速倍率没有意义,而且各自有自己的快照还原路径。
            if (CheatState.QuickBreakDown || CheatState.QuickAction) return;
            SpeedyGuard.Apply("Breakdown", __instance.m_SecondsToBreakDown, s.TT_BreakdownSpeedMult,
                v => __instance.m_SecondsToBreakDown = v);
        }
        catch { }
    }
}

internal static class Patch_Speedy_Crafting
{
    internal static void Prefix(Panel_Crafting __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            SpeedyGuard.Apply("Crafting", __instance.m_CraftingDisplayTimeSeconds, s.TT_GlobalSpeedMult,
                v => __instance.m_CraftingDisplayTimeSeconds = v);
        }
        catch { }
    }
}

internal static class Patch_Speedy_Cook1
{
    internal static void Prefix(Panel_Cooking __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
#if STORY_EDITION
            // 2.24 Panel_Cooking 无 m_RecipePreparationDisplayTimeSeconds(食谱系统是 2.55 加的),
            // 加速改走 m_MinutesToBoilWaterPerLiter 那组是另一件事,这里直接不做。
#else
            SpeedyGuard.Apply("Cook", __instance.m_RecipePreparationDisplayTimeSeconds, s.TT_GlobalSpeedMult,
                v => __instance.m_RecipePreparationDisplayTimeSeconds = v);
#endif
        }
        catch { }
    }
}

// 和 Cook1 同一个字段,共用同一个 key(否则两个 key 会互相把改过的值当基准)
internal static class Patch_Speedy_Cook2
{
    internal static void Prefix(Panel_Cooking __instance) => Patch_Speedy_Cook1.Prefix(__instance);
}

internal static class Patch_Speedy_Milling
{
    internal static void Prefix(Panel_Milling __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            SpeedyGuard.Apply("Milling", __instance.m_RepairRealTimeSeconds, s.TT_GlobalSpeedMult,
                v => __instance.m_RepairRealTimeSeconds = v);
        }
        catch { }
    }
}

internal static class Patch_Speedy_SnowShelterBuild
{
    internal static void Prefix(Panel_SnowShelterBuild __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            SpeedyGuard.Apply("SnowShelterBuild", __instance.m_RealtimeSecondsToBuild, s.TT_GlobalSpeedMult,
                v => __instance.m_RealtimeSecondsToBuild = v);
        }
        catch { }
    }
}

internal static class Patch_Speedy_SnowShelterInteract
{
    internal static void Prefix(Panel_SnowShelterInteract __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            SpeedyGuard.Apply("SnowShelterInteract", __instance.m_RealtimeSecondsToRepairOrDismantle,
                s.TT_GlobalSpeedMult, v => __instance.m_RealtimeSecondsToRepairOrDismantle = v);
        }
        catch { }
    }
}

internal static class Patch_Speedy_PickWater
{
    internal static void Prefix(Panel_PickWater __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            SpeedyGuard.Apply("PickWater", __instance.m_ProgressBarDurationSecondsBase, s.TT_GlobalSpeedMult,
                v => __instance.m_ProgressBarDurationSecondsBase = v);
        }
        catch { }
    }
}

internal static class Patch_Speedy_IceFishing
{
    internal static void Prefix(Panel_IceFishingHoleClear __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            SpeedyGuard.Apply("IceFishing", __instance.m_ProgressBarSeconds, s.TT_GlobalSpeedMult,
                v => __instance.m_ProgressBarSeconds = v);
        }
        catch { }
    }
}

internal static class Patch_Speedy_Affliction1
{
    internal static void Postfix(ref float __result)
    {
        var s = ModMain.Settings;
        if (s == null) return;
        float m = s.TT_GlobalSpeedMult;
        if (m != 1f && m > 0f) __result /= m;
    }
}

internal static class Patch_Speedy_Affliction2
{
    internal static void Postfix(ref float __result)
    {
        var s = ModMain.Settings;
        if (s == null) return;
        float m = s.TT_GlobalSpeedMult;
        if (m != 1f && m > 0f) __result /= m;
    }
}

#if !STORY_EDITION
// 2.24 无 Il2CppTLD.Interactions.TimedHoldInteraction(交互系统在 2.24 之后重构)。
// 连带 Patch_Speedy_ResetDict(只负责清这个字典)一起排除。
internal static class Patch_Speedy_HoldInteraction
{
    public static Dictionary<TimedHoldInteraction, (float baseValue, float lastValue, float lastModifier)> Data = new();

    internal static void Prefix(TimedHoldInteraction __instance)
    {
        // v7.7 先让秒搜刮的还原快照记下真值,再写加速值 —— 本 prefix(BeginHold)比
        //   Patch_TimedHold_UpdateHoldInteraction_QuickSearch(UpdateHoldInteraction)先跑,
        //   不先存的话那边读到的就是下面写的 0.01,"还原"会把加速值当 vanilla 写回去。
        if (CheatState.QuickSearch)
        {
            Patch_TimedHold_UpdateHoldInteraction_QuickSearch.CaptureVanilla(__instance);
            __instance.HoldTime = 0.01f;
            return;
        }
        float m = ModMain.Settings.TT_InteractionSpeedMult;
        if (m == 1f)
        {
            if (Data.TryGetValue(__instance, out var restore))
            {
                __instance.HoldTime = restore.baseValue;
                Data.Remove(__instance);
            }
            return;
        }
        float currentValue = __instance.HoldTime;
        if (!Data.ContainsKey(__instance))
        {
            __instance.HoldTime = currentValue / m;
            Data.Add(__instance, (currentValue, __instance.HoldTime, m));
            return;
        }
        var entry = Data[__instance];
        if (Math.Abs(currentValue - entry.lastValue) > 0.0001f)
        {
            __instance.HoldTime /= m;
            entry.baseValue = currentValue;
        }
        else if (entry.lastModifier != m)
        {
            __instance.HoldTime = entry.baseValue / m;
        }
        entry.lastValue = __instance.HoldTime;
        entry.lastModifier = m;
        Data[__instance] = entry;
    }
}

internal static class Patch_Speedy_ResetDict
{
    internal static void Postfix()
    {
        Patch_Speedy_HoldInteraction.Data.Clear();
    }
}
#endif

// ═══════════════════════════════════════════════════════════════
// TT-RespawnablePlants: 植物重生
// ═══════════════════════════════════════════════════════════════

internal class RegrowSaveData
{
    public Dictionary<string, Dictionary<string, float>> dictionarySaveProxy { get; set; }
}

internal static class RespawnablePlantsState
{
    public static Dictionary<string, Dictionary<string, float>> HarvestedPlants = new();
    public static Dictionary<string, float> RetroactivePending = new();
    private static string _lastScene = "";
    public static object Routine;

    public static readonly ModData.ModDataManager DataManager = new("TldHacks");

    public static IEnumerator CheckRespawn()
    {
        while (true)
        {
            for (float t = 0f; t < 30f; t += Time.deltaTime)
            {
                // null = 等一帧。原先每帧 new WaitForEndOfFrame 是一个 Il2Cpp 对象,这个协程整局都在跑
                yield return null;
            }
            // v7.7 修「关掉功能后植物还在重生」:这个协程原先 while(true) 无任何开关判定,
            //   唯一的 Stop 在 Patch_RespawnPlants_Load 里,而那个 patch 会随开关卸载 →
            //   关掉 TT_RespawnPlants 后协程继续按已关闭的设置刷新植物。
            if (!CheatState.TT_RespawnPlants) continue;
            var s = ModMain.Settings;
            if (s == null) continue;
            if (string.IsNullOrEmpty(GameManager.m_ActiveScene)) continue;
            if (HarvestedPlants == null || HarvestedPlants.Count < 1) continue;
            string scene = GameManager.m_ActiveScene;
            if (!HarvestedPlants.ContainsKey(scene)) continue;
            // v7.7 主菜单里 TimeOfDay 组件为 null,原先直接解引用会抛异常;协程体内没有
            //   try/catch,一抛就整个协程静默死掉,之后重开功能也不会恢复(句柄指向死协程)。
            var tod = GameManager.GetTimeOfDayComponent();
            if (tod == null) continue;
            float now = tod.GetHoursPlayedNotPaused();
            float hours = s.TT_PlantRespawnDays * 24f;
            var toRemove = new List<string>();
            foreach (var entry in HarvestedPlants[scene])
            {
                if (entry.Value + hours < now)
                {
                    var h = HarvestableManager.FindHarvestableByGuid(entry.Key);
                    if (h != null) { h.gameObject.SetActive(true); h.m_Harvested = false; }
                    toRemove.Add(entry.Key);
                }
            }
            foreach (var k in toRemove) HarvestedPlants[scene].Remove(k);
        }
    }

    public static void AddRetroactive()
    {
        if (RetroactivePending.Count == 0) return;
        string scene = GameManager.m_ActiveScene;
        if (!HarvestedPlants.ContainsKey(scene)) HarvestedPlants[scene] = new();
        foreach (var entry in RetroactivePending)
            if (!HarvestedPlants[scene].ContainsKey(entry.Key))
                HarvestedPlants[scene][entry.Key] = entry.Value;
        RetroactivePending.Clear();
    }

    public static void OnSceneLoaded() => RetroactivePending.Clear();
    public static void UpdateLastScene(string scene) { if (_lastScene != scene) { _lastScene = scene; RetroactivePending.Clear(); } }
}

internal static class Patch_RespawnPlants_Awake
{
    internal static void Prefix(ref Harvestable __instance)
    {
#if STORY_EDITION
        // 2.24 Harvestable 无 RegisterAsPlantsHaversted(植物重生注册是 2.55 加的)。
        // StoryGuard 已把 TT_RespawnPlants 强制关掉,这三个 patch 在剧情下永不启用,
        // 只需让它们编译得过 → 直接早退。
        return;
#else
        if (__instance == null || !__instance.RegisterAsPlantsHaversted) return;
#endif
        __instance.m_DestroyObjectOnHarvest = false;
    }
}

internal static class Patch_RespawnPlants_Harvest
{
    internal static void Postfix(ref Harvestable __instance)
    {
#if STORY_EDITION
        return;   // 见 Patch_RespawnPlants_Awake:2.24 无此系统
#else
        if (__instance.m_Harvested && __instance.RegisterAsPlantsHaversted)
        {
            string scene = GameManager.m_ActiveScene;
            if (!RespawnablePlantsState.HarvestedPlants.ContainsKey(scene))
                RespawnablePlantsState.HarvestedPlants[scene] = new();
            string guid = ObjectGuid.GetGuidFromGameObject(__instance.gameObject);
            RespawnablePlantsState.HarvestedPlants[scene][guid] = GameManager.GetTimeOfDayComponent().GetHoursPlayedNotPaused();
        }
#endif
    }
}

internal static class Patch_RespawnPlants_Deserialize
{
    [ThreadStatic] static bool _hadData;
    internal static void Prefix(ref Harvestable __instance, string text)
    {
        _hadData = !string.IsNullOrEmpty(text);
    }
    internal static void Postfix(ref Harvestable __instance)
    {
        RespawnablePlantsState.UpdateLastScene(GameManager.m_ActiveScene);
#if !STORY_EDITION
        if (__instance.m_Harvested && __instance.RegisterAsPlantsHaversted && _hadData)
        {
            string guid = ObjectGuid.GetGuidFromGameObject(__instance.gameObject);
            RespawnablePlantsState.RetroactivePending[guid] = GameManager.GetTimeOfDayComponent().GetHoursPlayedNotPaused();
        }
#endif
    }
}

internal static class Patch_RespawnPlants_Save
{
    internal static void Postfix()
    {
        try
        {
            var data = new RegrowSaveData { dictionarySaveProxy = RespawnablePlantsState.HarvestedPlants };
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { IncludeFields = true });
            RespawnablePlantsState.DataManager.Save(json, "regrowPlants");
        }
        catch { }
    }
}

internal static class Patch_RespawnPlants_Load
{
    internal static void Postfix()
    {
        try
        {
            string json = RespawnablePlantsState.DataManager.Load("regrowPlants");
            if (!string.IsNullOrEmpty(json))
            {
                var data = JsonSerializer.Deserialize<RegrowSaveData>(json, new JsonSerializerOptions { IncludeFields = true });
                if (data?.dictionarySaveProxy != null)
                    RespawnablePlantsState.HarvestedPlants = data.dictionarySaveProxy;
            }
            if (RespawnablePlantsState.Routine != null) MelonCoroutines.Stop(RespawnablePlantsState.Routine);
            RespawnablePlantsState.Routine = MelonCoroutines.Start(RespawnablePlantsState.CheckRespawn());
            RespawnablePlantsState.AddRetroactive();
        }
        catch { }
    }
}

#if !STORY_EDITION
// ═══════════════════════════════════════════════════════════════
// ShowTraderTrust: 商人信任度 HUD 显示
// 2.24 无 Il2CppTLD.Trader(商人系统是沙盒后加的功能,剧情模式本就没有商人)。
// ═══════════════════════════════════════════════════════════════

internal static class ShowTraderTrustHelper
{
    private static Il2CppTLD.Trader.TraderRadio _radio;
    private static string _text;
    private static bool _visible;
    private static int _nextSearchFrame;
    private static int _lastTrust = -1, _lastMax = -1;

    public static void Tick()
    {
        if (!CheatState.TT_ShowTraderTrust) { _visible = false; return; }
        try
        {
            if (!GameManager.GetWeatherComponent().IsIndoorEnvironment()) { _visible = false; return; }
            if (_radio == null)
            {
                _visible = false;
                // 进场景时电台可能还没加载出来:找不到就隔 10 秒左右再找一次,别整个场景都放弃
                if (Time.frameCount < _nextSearchFrame) return;
                _radio = UnityEngine.Object.FindObjectOfType<Il2CppTLD.Trader.TraderRadio>();
                if (_radio == null) { _nextSearchFrame = Time.frameCount + 600; return; }
            }

            int state = (int)_radio.m_CurrentState;
            if (state >= 1 && state <= 6)   // PlayingTimeline..PlayingVoiceLine,挂断(7)和关机(0)不显示
            {
                var tm = GameManager.GetTraderManager();
                if (tm == null) { _visible = false; return; }
                int cur = tm.CurrentTrust, max = tm.MaxTrust;
                if (cur != _lastTrust || max != _lastMax)
                {
                    _lastTrust = cur; _lastMax = max;
                    _text = I18n.T($"信任度: {cur} / {max}", $"Trust: {cur} / {max}");
                }
                _visible = true;
            }
            else
            {
                _visible = false;
            }
        }
        catch { _visible = false; }
    }

    private static GUIStyle _style;

    public static void DrawGUI()
    {
        if (!CheatState.TT_ShowTraderTrust || !_visible || string.IsNullOrEmpty(_text)) return;
        if (_style == null)
        {
            _style = new GUIStyle(GUI.skin.label)
            {
                fontSize = 20,
                alignment = TextAnchor.LowerCenter,
                normal = { textColor = Color.white }
            };
        }
        GUI.Label(new Rect(Screen.width / 2f - 150f, Screen.height - 60f, 300f, 40f), _text, _style);
    }

    public static void OnSceneChange() { _radio = null; _visible = false; _nextSearchFrame = 0; }
}
#endif
