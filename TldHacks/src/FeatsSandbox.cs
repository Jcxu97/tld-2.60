#if !STORY_EDITION && !EP5_EDITION
using System;
using System.Reflection;
using HarmonyLib;
using Il2Cpp;

namespace TldHacks;

// 当前存档启用哪些勋章 + 改勋章加成数值。
//   启用列表是 FeatEnabledTracker.m_FeatsEnabledThisSandbox(静态,随存档读写)。
//   Feat.IsUnlockedAndEnabled 每次现查这个列表,各勋章的 Get*Bonus 也都现读自己的字段,所以改完即时生效。
internal static class FeatsSandbox
{
    internal static readonly FeatType[] Types =
    {
        FeatType.BookSmarts, FeatType.ColdFusion, FeatType.EfficientMachine, FeatType.FireMaster,
        FeatType.FreeRunner, FeatType.SnowWalker, FeatType.ExpertTrapper, FeatType.StraightToHeart,
        FeatType.BlizzardWalker, FeatType.NightWalker, FeatType.MasterHunter, FeatType.SettledMind,
        FeatType.CelestialNavigator,
    };

    private static readonly string[] _names = new string[Types.Length];
    private static IntPtr _namesFor;

    internal static bool Ready()
    {
        try
        {
            if (GameManager.IsMainMenuActive() || GameManager.IsEmptySceneActive()) return false;
            return GameManager.GetFeatsManager() != null && FeatEnabledTracker.m_FeatsEnabledThisSandbox != null;
        }
        catch { return false; }
    }

    // 显示名走游戏自己的本地化;每帧取会分配,FeatsManager 换了实例才重取
    internal static string NameAt(int i)
    {
        var fm = GameManager.GetFeatsManager();
        if (fm != null && fm.Pointer != _namesFor)
        {
            _namesFor = fm.Pointer;
            for (int k = 0; k < Types.Length; k++)
            {
                string n = null;
                try { n = fm.GetFeat(Types[k])?.DisplayName; } catch { }
                _names[k] = string.IsNullOrEmpty(n) ? Types[k].ToString() : n;
            }
        }
        return _names[i] ?? Types[i].ToString();
    }

    internal static bool IsEnabled(FeatType t)
    {
        try { return FeatEnabledTracker.m_FeatsEnabledThisSandbox?.Contains(t) == true; }
        catch { return false; }
    }

    internal static void SetEnabled(FeatType t, bool on)
    {
        try
        {
            var list = FeatEnabledTracker.m_FeatsEnabledThisSandbox;
            var feat = GameManager.GetFeatsManager()?.GetFeat(t);
            if (list == null || feat == null) return;
            if (!on) { while (list.Contains(t)) list.Remove(t); return; }
            // 没解锁的先解锁(SetNormalizedProgress(1) 会顺手 SaveProfile),否则进了列表也不生效
            if (!feat.IsUnlocked()) feat.SetNormalizedProgress(1f);
            if (!list.Contains(t)) list.Add(t);
            // 生火大师只在开局抬一次生火等级,中途启用要补一次
            if (t == FeatType.FireMaster) feat.TryCast<Feat_FireMaster>()?.MaybeUpdateFireStartingSkillLevel();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[FeatsSandbox] {t}: {ex.Message}"); }
    }

    internal static void SetAll(bool on)
    {
        foreach (var t in Types) SetEnabled(t, on);
    }

    // ——— 启用列表另存一份进存档 ———
    // 原版只靠 GlobalSaveGameFormat.m_FeatsEnabledSerialized,游戏里中途改的读档后会丢。
    //   每次存场景把当前列表写进 ModData(键 featsEnabled),载入场景时写回。没有这份数据的老存档不动。
    //   "v1:" 前缀用来区分"全部取消(空列表)"和"没有数据"。
    private const string DataKey = "featsEnabled";
    private static string _savedList, _savedSlot;

    private static string CurrentSlot()
    {
        try { return SaveGameSystem.GetCurrentSaveName(); } catch { return null; }
    }

    internal static void SaveList()
    {
        try
        {
            var list = FeatEnabledTracker.m_FeatsEnabledThisSandbox;
            if (list == null) return;
            var names = new System.Collections.Generic.List<string>();
            for (int i = 0; i < list.Count; i++) names.Add(list[i].ToString());
            _savedList = "v1:" + string.Join(",", names);
            _savedSlot = CurrentSlot();
            RespawnablePlantsState.DataManager.Save(_savedList, DataKey);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[FeatsSandbox.Save] {ex.Message}"); }
    }

    internal static void LoadList()
    {
        try
        {
            _savedList = RespawnablePlantsState.DataManager.Load(DataKey);
            _savedSlot = CurrentSlot();
            ApplyList(_savedList);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[FeatsSandbox.Load] {ex.Message}"); }
    }

    private static void ApplyList(string data)
    {
        if (data == null || !data.StartsWith("v1:")) return;
        var list = FeatEnabledTracker.m_FeatsEnabledThisSandbox;
        if (list == null) return;
        list.Clear();
        foreach (var n in data.Substring(3).Split(',', StringSplitOptions.RemoveEmptyEntries))
            if (Enum.TryParse(n, out FeatType t) && !list.Contains(t)) list.Add(t);
    }

    // ——— 加成数值 ———
    // Settings 里对应字段 < 0 表示不改,用原版值。原版值第一次读到时记下,恢复时写回。
    internal sealed class Param
    {
        public string Key, Zh, En, Fmt;
        public FeatType Type;
        public float Min, Max;
        public bool IsInt;
        public Func<Feat, float> Get;
        public Action<Feat, float> Set;
        public float Original = float.NaN;
        public FieldInfo Field;
    }

    private static Param P(string key, FeatType t, string zh, string en, float min, float max, bool isInt,
        Func<Feat, float> get, Action<Feat, float> set, string fmt = "F0")
        => new Param
        {
            Key = key, Type = t, Zh = zh, En = en, Min = min, Max = max, IsInt = isInt, Get = get, Set = set, Fmt = fmt,
            Field = typeof(TldHacksSettings).GetField(key, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public),
        };

    private static T C<T>(Feat f) where T : Feat => f.TryCast<T>();

    internal static readonly Param[] Params =
    {
        P("FeatV_BookSmarts", FeatType.BookSmarts, "研究加成%", "Research %", 0f, 200f, true,
            f => C<Feat_BookSmarts>(f).m_PercentBenefit, (f, v) => C<Feat_BookSmarts>(f).m_PercentBenefit = (int)v),
        P("FeatV_ColdFusion", FeatType.ColdFusion, "体感温度℃", "Warmth °C", 0f, 20f, true,
            f => C<Feat_ColdFusion>(f).m_TemperatureCelsiusBenefit, (f, v) => C<Feat_ColdFusion>(f).m_TemperatureCelsiusBenefit = (int)v),
        P("FeatV_EfficientMachine", FeatType.EfficientMachine, "少耗热量%", "Calories -%", 0f, 90f, true,
            f => C<Feat_EfficientMachine>(f).m_CalorieReductionBenefit, (f, v) => C<Feat_EfficientMachine>(f).m_CalorieReductionBenefit = (int)v),
        P("FeatV_FireMaster", FeatType.FireMaster, "初始生火等级", "Fire Start Lv", 1f, 5f, true,
            f => C<Feat_FireMaster>(f).m_DefaultFireStartingSkillLevel, (f, v) => C<Feat_FireMaster>(f).m_DefaultFireStartingSkillLevel = (int)v),
        P("FeatV_FreeRunner", FeatType.FreeRunner, "奔跑少耗热量%", "Sprint Cal -%", 0f, 90f, true,
            f => C<Feat_FreeRunner>(f).m_CalorieReductionBenefit, (f, v) => C<Feat_FreeRunner>(f).m_CalorieReductionBenefit = (int)v),
        P("FeatV_SnowWalker", FeatType.SnowWalker, "体力恢复%", "Stamina +%", 0f, 200f, true,
            f => C<Feat_SnowWalker>(f).m_StaminaRechargeFasterPercent, (f, v) => C<Feat_SnowWalker>(f).m_StaminaRechargeFasterPercent = (int)v),
        P("FeatV_ExpertTrapper", FeatType.ExpertTrapper, "捕兔几率%", "Snare +%", 0f, 100f, true,
            f => C<Feat_ExpertTrapper>(f).m_ChanceIncreaseToCatchRabbitsPercent, (f, v) => C<Feat_ExpertTrapper>(f).m_ChanceIncreaseToCatchRabbitsPercent = (int)v),
        P("FeatV_StraightToHeart", FeatType.StraightToHeart, "提神时长%", "Duration +%", 0f, 300f, true,
            f => C<Feat_StraightToHeart>(f).m_EffectiveLengthIncreasePercent, (f, v) => C<Feat_StraightToHeart>(f).m_EffectiveLengthIncreasePercent = (int)v),
        P("FeatV_BlizzardWalker", FeatType.BlizzardWalker, "逆风减速-%", "Wind Slow -%", 0f, 100f, true,
            f => C<Feat_BlizzardWalker>(f).m_WalkingSpeedInWindReductionPercent, (f, v) => C<Feat_BlizzardWalker>(f).m_WalkingSpeedInWindReductionPercent = (int)v),
        P("FeatV_NightWalkerDay", FeatType.NightWalker, "白天疲劳倍率", "Day Fatigue x", 0f, 5f, false,
            f => C<Feat_NightWalker>(f).m_FatigueScaleDayMultiplier, (f, v) => C<Feat_NightWalker>(f).m_FatigueScaleDayMultiplier = v, "F2"),
        P("FeatV_NightWalkerNight", FeatType.NightWalker, "夜间疲劳倍率", "Night Fatigue x", 0f, 2f, false,
            f => C<Feat_NightWalker>(f).m_FatigueScaleNightMultiplier, (f, v) => C<Feat_NightWalker>(f).m_FatigueScaleNightMultiplier = v, "F2"),
        // 猎人大师 Awake 把百分比除以 100 缓存到 m_SightScale 等,Get*RangeScale 读的是缓存,两处都写
        P("FeatV_MasterHunterSight", FeatType.MasterHunter, "动物视觉%", "AI Sight %", 0f, 100f, false,
            f => C<Feat_MasterHunter>(f).m_AiSightRangeScale,
            (f, v) => { var h = C<Feat_MasterHunter>(f); h.m_AiSightRangeScale = v; h.m_SightScale = v / 100f; }),
        P("FeatV_MasterHunterSmell", FeatType.MasterHunter, "动物嗅觉%", "AI Smell %", 0f, 100f, false,
            f => C<Feat_MasterHunter>(f).m_AiSmellRangeScale,
            (f, v) => { var h = C<Feat_MasterHunter>(f); h.m_AiSmellRangeScale = v; h.m_SmellScale = v / 100f; }),
        P("FeatV_MasterHunterSound", FeatType.MasterHunter, "动物听觉%", "AI Hearing %", 0f, 100f, false,
            f => C<Feat_MasterHunter>(f).m_AiSoundRangeScale,
            (f, v) => { var h = C<Feat_MasterHunter>(f); h.m_AiSoundRangeScale = v; h.m_SoundScale = v / 100f; }),
        P("FeatV_SettledMind", FeatType.SettledMind, "读书加速%", "Reading +%", 0f, 100f, false,
            f => C<Feat_SettledMind>(f).m_ReadSpeedBoostPercent, (f, v) => C<Feat_SettledMind>(f).m_ReadSpeedBoostPercent = v),
        P("FeatV_CelestialNavigator", FeatType.CelestialNavigator, "夜行加速%", "Night Walk +%", 0f, 100f, false,
            f => C<Feat_CelestialNavigator>(f).m_WalkingSpeedBoostPercent, (f, v) => C<Feat_CelestialNavigator>(f).m_WalkingSpeedBoostPercent = v),
    };

    internal static float GetSetting(Param p, TldHacksSettings s) => (float)p.Field.GetValue(s);
    internal static void PutSetting(Param p, TldHacksSettings s, float v) => p.Field.SetValue(s, v);

    // 菜单上显示的值:改过的显示设置值,没改过的显示游戏当前值
    internal static float Shown(Param p, TldHacksSettings s)
    {
        float v = GetSetting(p, s);
        if (v >= 0f) return v;
        try
        {
            var f = GameManager.GetFeatsManager()?.GetFeat(p.Type);
            if (f != null) return p.Get(f);
        }
        catch { }
        return p.Min;
    }

    internal static void ApplyOne(Param p, TldHacksSettings s)
    {
        try
        {
            var f = GameManager.GetFeatsManager()?.GetFeat(p.Type);
            if (f == null) return;
            if (float.IsNaN(p.Original)) p.Original = p.Get(f);
            float v = GetSetting(p, s);
            p.Set(f, v >= 0f ? v : p.Original);
            if (p.Type == FeatType.FireMaster && v >= 0f) f.TryCast<Feat_FireMaster>()?.MaybeUpdateFireStartingSkillLevel();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[FeatsSandbox] {p.Key}: {ex.Message}"); }
    }

    // 勋章实例挂在每个场景的 GameManager 上,换场景会重建,进场景后重写一遍改过的值
    internal static void OnSceneInitialized(TldHacksSettings s)
    {
        // 原版恢复全局数据可能晚于 LoadSceneData,进场景后按本存档那份再写一次
        try
        {
            if (GameManager.IsMainMenuActive()) _savedList = _savedSlot = null;
            else if (_savedList != null && _savedSlot == CurrentSlot()) ApplyList(_savedList);
        }
        catch { }
        if (s == null) return;
        foreach (var p in Params)
            if (GetSetting(p, s) >= 0f) ApplyOne(p, s);
    }

    internal static void ResetAll(TldHacksSettings s)
    {
        foreach (var p in Params)
        {
            bool was = GetSetting(p, s) >= 0f;
            PutSetting(p, s, -1f);
            if (was) ApplyOne(p, s);
        }
    }
}

// 启用列表跟存档走,DynamicPatch 常挂
internal static class Patch_Feats_SaveScene
{
    internal static void Postfix() => FeatsSandbox.SaveList();
}

internal static class Patch_Feats_LoadScene
{
    internal static void Postfix() => FeatsSandbox.LoadList();
}

// 开新档时勋章能选满(原版按难度限制数量)
// 上限是界面里的槽位数 m_ActiveFeatObjects,超过它 UpdateSelectedFeats 每帧数组越界,选择界面停在占位文字
[HarmonyPatch(typeof(Panel_MainMenu), nameof(Panel_MainMenu.GetNumFeatsForXPMode))]
internal static class Patch_MainMenu_AllFeats
{
    private static void Postfix(Panel_MainMenu __instance, ref int __result)
    {
        if (ModMain.Settings?.Feat_AllAtNewGame != true) return;
        int slots = __instance.m_ActiveFeatObjects?.Length ?? __result;
        __result = Math.Min(FeatsSandbox.Types.Length, slots);
    }
}
#endif
