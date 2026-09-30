using System;
using System.Collections.Generic;
using System.Reflection;
using Il2Cpp;
using Il2CppInterop.Runtime;
using UnityEngine;
using SceneManager = UnityEngine.SceneManagement.SceneManager;
using LoadSceneMode = UnityEngine.SceneManagement.LoadSceneMode;

namespace TldHacks;

// 传送目的地(沿用 BunkerDefaults 的 5 个坐标 + Marsh/MountainPass 占位)
internal class Waypoint
{
    public string Label;
    public string LabelEn;
    public string Scene;
    public Vector3 Pos;
    public Waypoint(string label, string scene, float x, float y, float z, string labelEn = null)
    { Label = label; Scene = scene; Pos = new Vector3(x, y, z); LabelEn = labelEn ?? label; }
    public string DisplayLabel => I18n.IsEnglish ? LabelEn : Label;
}

internal static class Teleport
{
    // 已知可用坐标(BunkerDefaults 搬来的 5 个地堡) + 全部 15 个 region 的场景名。
    // v2.7.55 按用户实测打印的坐标更新 —— 修了 8 个原 Pos=0 的地图掉入地底问题
    //   区域中文名按 2.55 官方本地化:林狼雪岭/宜人山谷/孤寂沼地/荒芜据点/断开的铁路/破碎山道
    //   Pos == Vector3.zero 才走"只 LoadScene,不 TeleportPlayer"路径
    // v2.7.55b 参照 CT 列表补 9 个 prepper 地堡 / 应急舱 / 交易地点 —— 占位 Pos=0
    //   用户在各 scene 用"★打印坐标到 log"采准精确点后,替换这些占位行
    // v2.7.57 排序:按 scene 英文名字母序分组,同区内先主建筑、再地堡、再应急舱
    public static readonly List<Waypoint> Destinations = new()
    {
        // A —— AirfieldRegion(废弃机场)
        new Waypoint("废弃机场·控制塔",    "AirfieldRegion",            81.90f, 160.30f, -455.30f, "Forsaken Airfield · Tower"),
        new Waypoint("废弃机场·应急舱",    "AirfieldRegion",          1209.80f, 304.71f, -726.11f, "Forsaken Airfield · Pod"),
        // A —— AshCanyonRegion(灰烬峡谷)
        new Waypoint("灰烬峡谷·地堡",      "AshCanyonRegion",          -42.12f, 172.95f, -796.68f, "Ash Canyon · Bunker"),
        // B —— BlackrockRegion(黑岩监狱)
        new Waypoint("黑岩监狱·地堡",      "BlackrockRegion",          705.04f, 373.98f,  816.38f, "Blackrock · Bunker"),
        // C —— CanneryRegion(荒凉水湾)
        new Waypoint("荒凉水湾·地堡",      "CanneryRegion",            328.37f, 344.50f,  833.16f, "Bleak Inlet · Bunker"),
        new Waypoint("荒凉水湾·应急舱",    "CanneryRegion",            -39.50f, 103.38f,  501.57f, "Bleak Inlet · Pod"),
        // C —— CoastalRegion(沿海公路)
        new Waypoint("沿海公路·加油站",    "CoastalRegion",            760.51f,  24.00f,  645.93f, "Coastal Hwy · Gas Station"),
        new Waypoint("沿海公路·交易地点",  "CoastalRegion",            325.76f,  26.22f,  118.83f, "Coastal Hwy · Trader Spot"),
        // C —— CrashMountainRegion(林狼雪岭)
        new Waypoint("林狼雪岭·机舱",      "CrashMountainRegion",      934.50f, 470.10f, 1174.40f, "Timberwolf Mtn · Plane"),
        new Waypoint("林狼雪岭·地堡",      "CrashMountainRegion",     1675.41f, 207.32f,  968.21f, "Timberwolf Mtn · Bunker"),
        // L —— LakeRegion(神秘湖)
        new Waypoint("神秘湖·营地办公室",  "LakeRegion",              1015.87f,  25.91f,  450.86f, "Mystery Lake · Camp Office"),
        new Waypoint("神秘湖·地堡",        "LakeRegion",              1029.06f,  91.99f,  -52.52f, "Mystery Lake · Bunker"),
        // M —— MarshRegion(孤寂沼地)
        new Waypoint("孤寂沼地",           "MarshRegion",             1116.10f,-130.60f,  969.10f, "Forlorn Muskeg"),
        new Waypoint("孤寂沼地·地堡",      "MarshRegion",              593.07f, -83.38f, -104.89f, "Forlorn Muskeg · Bunker"),
        // M —— MiningRegion(污染区)
        new Waypoint("污染区·井架",        "MiningRegion",            -169.20f, 201.80f,  231.70f, "Blackrock Mine · Rig"),
        // M —— MountainPassRegion(破碎山道)
        new Waypoint("破碎山道·气象站",    "MountainPassRegion",       532.10f, 592.10f, -601.20f, "Mountain Pass · Weather"),
        // M —— MountainTownRegion(山间小镇)
        new Waypoint("山间小镇·地堡",      "MountainTownRegion",      1828.20f, 444.39f, 1771.27f, "Milton · Bunker"),
        // R —— RiverValleyRegion(寂静河谷)
        new Waypoint("寂静河谷·地堡",      "RiverValleyRegion",        363.44f, 238.61f,  375.49f, "Hushed River Valley · Bunker"),
        new Waypoint("寂静河谷·应急舱",    "RiverValleyRegion",        171.97f, 126.65f,  731.10f, "Hushed River Valley · Pod"),
        // R —— RuralRegion(宜人山谷)
        new Waypoint("宜人山谷·农庄",      "RuralRegion",             1460.70f,  48.40f, 1032.40f, "Pleasant Valley · Farm"),
        new Waypoint("宜人山谷·地堡",      "RuralRegion",              423.89f, 177.93f, 1458.51f, "Pleasant Valley · Bunker"),
        new Waypoint("宜人山谷·应急舱",    "RuralRegion",             1113.96f,  98.49f,  140.33f, "Pleasant Valley · Pod"),
        // T —— TracksRegion(断开的铁路)
        new Waypoint("断开的铁路·维修站",  "TracksRegion",             588.20f, 199.00f,  565.50f, "Broken Railroad · Maint."),
        // W —— WhalingStationRegion(荒芜据点)
        new Waypoint("荒芜据点·孤寂灯塔",  "WhalingStationRegion",     728.00f,  46.80f,  766.60f, "Desolation Point · Lighthouse"),
    };

    // 正解:PlayerManager.TeleportPlayer(Vector3, Quaternion) 是公开方法。
    // 这和 DeveloperConsole 的 `tp` 命令内部调的一样。
    public static void MovePlayerTo(Vector3 pos)
    {
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) { Log("[TP] no PlayerManager"); return; }

            // 保持当前相机朝向
            Quaternion rot = Quaternion.identity;
            try
            {
                var cam = GameManager.GetVpFPSCamera();
                if (cam != null) rot = cam.transform.rotation;
            }
            catch { }

            pm.TeleportPlayer(pos, rot);
            TeleportFallGuard.Arm();
            Log($"[TP] TeleportPlayer({pos})");
        }
        catch (Exception ex) { Log($"[TP] {ex.Message}"); }
    }

    // 跨场景传送 pending state —— OnSceneWasInitialized 触发后等几帧传送
    private static Waypoint _pendingWaypoint;
    private static int _pendingFrames = 0;

    // 正式的跨场景传送 —— 参考 FastTravel.dll 流程:
    //   1) SaveGameSystem.SaveGame() 保存当前 state
    //   2) 构造 SceneTransitionData 填 from/to scene 名
    //   3) GameManager.LoadScene(sceneName, saveName) 触发场景切换
    //   4) OnSceneWasInitialized 后再等 60 帧调 TeleportPlayer 到精确坐标
    public static void TravelTo(Waypoint w)
    {
#if STORY_GUARD
        // 剧情版:跨场景传送会强制存档 + 覆写脚本 SceneTransitionData + LoadScene,
        // 可软锁剧情线性进度并写坏脚本场景存档(分类 workflow 确认的唯一 BLOCK 传送路径)。
        // 直接拦截,不执行。UI 侧同时灰显该 Tab 的传送按钮。
        if (StoryGuard.InStory)
        {
            Log(I18n.IsEnglish
                ? "[TP] Teleport is disabled in Story mode (would break scripted progression)."
                : "[TP] 剧情模式下已禁用传送(会破坏脚本化进度)。");
            return;
        }
#endif
        try
        {
            var activeScene = SceneManager.GetActiveScene();
            bool hasExactCoord = w.Pos != Vector3.zero;

            if (activeScene.name == w.Scene || string.IsNullOrEmpty(w.Scene))
            {
                if (!hasExactCoord) { Log(I18n.IsEnglish ? $"[TP] → {w.LabelEn}: already in region, no exact coord" : $"[TP] → {w.Label}:已在本区,无精确坐标不传送"); return; }
                Log(I18n.IsEnglish ? $"[TP] → {w.LabelEn} (same region)" : $"[TP] → {w.Label}(同区)");
                MovePlayerTo(w.Pos);
                return;
            }

            Log(I18n.IsEnglish
                ? $"[TP] Cross-scene → {w.LabelEn} ({w.Scene}), saving + loading..."
                : $"[TP] 跨场景 → {w.Label} ({w.Scene}),开始保存 + 加载...");

            // 1) 存当前档 —— FastTravel 用的是 SaveGameSystem.SaveGame("autosave", currentSceneName) 有参版本
            //    反射先试 (string, string) 再 fallback 无参
            try
            {
                var sgt = typeof(SaveGameSystem);
                var saveTwoArg = sgt.GetMethod("SaveGame", BindingFlags.Static | BindingFlags.Public,
                    null, new[] { typeof(string), typeof(string) }, null);
                if (saveTwoArg != null)
                {
                    saveTwoArg.Invoke(null, new object[] { "autosave", activeScene.name });
                }
                else
                {
                    var saveNoArg = sgt.GetMethod("SaveGame", BindingFlags.Static | BindingFlags.Public, null, System.Type.EmptyTypes, null)
                                 ?? sgt.GetMethod("ForceSaveGame", BindingFlags.Static | BindingFlags.Public, null, System.Type.EmptyTypes, null);
                    saveNoArg?.Invoke(null, null);
                }
            }
            catch (Exception ex) { Log($"[TP.Save] {ex.Message}"); }

            // 2) 构造 SceneTransitionData —— 优先用 TransitionRecorder 记录的真实 save slot id
            //    DLC Tale scene 的 save slot id ≠ Unity scene 名,硬猜会让游戏把玩家 re-init 丢物品
            try
            {
                var snapTo   = TransitionRecorder.Lookup(w.Scene);         // 目标
                var snapFrom = TransitionRecorder.Lookup(activeScene.name); // 当前

                var std = new SceneTransitionData();
                std.m_SceneSaveFilenameCurrent  = (snapFrom != null && !string.IsNullOrEmpty(snapFrom.ToSaveId))
                                                      ? snapFrom.ToSaveId : activeScene.name;
                std.m_SceneSaveFilenameNextLoad = (snapTo != null && !string.IsNullOrEmpty(snapTo.ToSaveId))
                                                      ? snapTo.ToSaveId : w.Scene;
                std.m_TeleportPlayerSaveGamePosition = true;
                std.m_LastOutdoorScene = (snapTo != null && !string.IsNullOrEmpty(snapTo.LastOutdoor))
                                              ? snapTo.LastOutdoor : w.Scene;
                std.m_PosBeforeInteriorLoad = w.Pos;
                if (snapTo != null)
                {
                    #if STORY_EDITION
                    // 2.24 字段名是 m_SceneLocationLocIDToShow
                    if (!string.IsNullOrEmpty(snapTo.LocIDOverride))    std.m_SceneLocationLocIDToShow      = snapTo.LocIDOverride;
#else
                    if (!string.IsNullOrEmpty(snapTo.LocIDOverride))    std.m_SceneLocationLocIDOverride    = snapTo.LocIDOverride;
#endif
                    if (!string.IsNullOrEmpty(snapTo.SpawnPoint))       std.m_SpawnPointName                = snapTo.SpawnPoint;
                    if (!string.IsNullOrEmpty(snapTo.SpawnAudio))       std.m_SpawnPointAudio               = snapTo.SpawnAudio;
                    if (!string.IsNullOrEmpty(snapTo.ForceNextTrigger)) std.m_ForceNextSceneLoadTriggerScene = snapTo.ForceNextTrigger;
                }
                GameManager.m_SceneTransitionData = std;

                if (snapTo == null)
                    Log(I18n.IsEnglish
                        ? $"[TP.Std] ⚠ No history, fallback to scene name as save id — first visit to Tale scene may lose items"
                        : $"[TP.Std] ⚠ 无历史记录,fallback 用 scene 名当 save id — 首次去 Tale scene 可能丢物品");
                else
                    Log(I18n.IsEnglish
                        ? $"[TP.Std] Matched history transition (curId={std.m_SceneSaveFilenameCurrent}, nextId={std.m_SceneSaveFilenameNextLoad})"
                        : $"[TP.Std] 命中历史 transition(curId={std.m_SceneSaveFilenameCurrent}, nextId={std.m_SceneSaveFilenameNextLoad})");
            }
            catch (Exception ex) { Log($"[TP.Std] {ex.Message}"); }

            // 3) 标记 pending,让 OnSceneWasInitialized 在加载完后精确定位
            _pendingWaypoint = w;

            // 4) LoadScene
            try
            {
                string saveName = GetCurrentSaveName();
                GameManager.LoadScene(w.Scene, saveName);
            }
            catch (Exception ex)
            {
                Log($"[TP.Load] {ex.Message}");
                _pendingWaypoint = null;
            }
        }
        catch (Exception ex) { Log($"[TP] {ex.Message}"); }
    }

    private static string GetCurrentSaveName()
    {
        try
        {
            var m = typeof(SaveGameSystem).GetMethod("GetCurrentSaveName", BindingFlags.Static | BindingFlags.Public);
            if (m != null) { var r = m.Invoke(null, null); if (r is string s) return s; }
        }
        catch { }
        return "autosave";
    }

    // ModMain.OnSceneWasInitialized 会调这个
    public static void OnSceneLoaded(string sceneName)
    {
        if (_pendingWaypoint == null) return;
        if (sceneName != _pendingWaypoint.Scene) return;
        // 场景加载完成,等 60 帧(1 秒)让 player 生成 + 世界初始化
        _pendingFrames = 60;
    }

    // ModMain.OnUpdate 每帧调
    public static void TickPendingTeleport()
    {
        if (_pendingWaypoint == null || _pendingFrames <= 0) return;
        if (--_pendingFrames == 0)
        {
            var target = _pendingWaypoint;
            _pendingWaypoint = null;
            if (target.Pos == Vector3.zero)
            {
                Log(I18n.IsEnglish
                    ? $"[TP] Scene ready, using default landing ({target.LabelEn})"
                    : $"[TP] 场景就绪,使用默认落点({target.Label})");
                return;
            }
            MovePlayerTo(target.Pos);
            Log(I18n.IsEnglish
                ? $"[TP] Scene ready, TeleportPlayer → {target.Pos}"
                : $"[TP] 场景就绪,TeleportPlayer → {target.Pos}");
        }
    }

    private static void Log(string s) { CheatState.LastActionLog = s; ModMain.Log?.Msg(s); }
}

// 技能操作
internal static class Skills
{
    // 中文名 → SkillType。SkillType enum 在反编译里确认过
    // 英文名照游戏原文(Firestarting / Carcass Harvesting … ),v8.0 补,由 Menu 按语言取
    public static readonly (string Label, string LabelEn, SkillType Type)[] All =
    {
        ("生火",     "Firestarting",       SkillType.Firestarting),
        ("尸骸采集", "Carcass Harvesting", SkillType.CarcassHarvesting),
        ("冰面钓鱼", "Ice Fishing",        SkillType.IceFishing),
        ("烹调",     "Cooking",            SkillType.Cooking),
        ("步枪",     "Rifle",              SkillType.Rifle),
        ("弓术",     "Archery",            SkillType.Archery),
        ("修补",     "Clothing Repair",    SkillType.ClothingRepair),
        ("工具修理", "Tool Repair",        SkillType.ToolRepair),
        ("左轮手枪", "Revolver",           SkillType.Revolver),
        ("制枪术",   "Gunsmithing",        SkillType.Gunsmithing),
    };

    // 玩家可见等级(1-5)。GetCurrentTierNumber() 返回的是 SkillTiers enum 索引 0-4
    //   (Beginner=0 … Master=4),即满级返回 4 → 显示给玩家须 +1 变成 1-5。
    public static int GetTierNumber(SkillType t)
    {
        try
        {
            var sm = GameManager.GetSkillsManager();
            var skill = sm?.GetSkill(t);
            if (skill == null) return 1;
            return skill.GetCurrentTierNumber() + 1;
        }
        catch { return 1; }
    }

    // 逐级 +/-。内部全程用 tier 索引(0-4),与 SetTier/GetCurrentTierNumber 同体系;
    //   显示层 GetTierNumber 再 +1。clamp 0..4 → 可降到 Beginner、升到 Master 满级。
    public static void StepTier(SkillType t, int delta)
    {
        try
        {
            var sm = GameManager.GetSkillsManager();
            if (sm == null) { Log("[Skills] no SkillsManager"); return; }
            var skill = sm.GetSkill(t);
            if (skill == null) { Log($"[Skills] skill {t} not found"); return; }
            int next = skill.GetCurrentTierNumber() + delta;
            if (next < 0) next = 0;
            if (next > 4) next = 4;
            // SetTier(int tier, PointAssignmentMode mode):反射取 mode 枚举,传 1(Normal),与 SetMax 一致
            var setT = skill.GetType().GetMethod("SetTier", BindingFlags.Instance | BindingFlags.Public);
            if (setT != null)
            {
                var pam = setT.GetParameters()[1].ParameterType;
                var modeVal = Enum.ToObject(pam, 1);
                setT.Invoke(skill, new object[] { next, modeVal });
                Log($"[Skills] {t} tier = {next}");
            }
        }
        catch (Exception ex) { Log($"[Skills] {ex.Message}"); }
    }

    public static void SetMax(SkillType t)
    {
        try
        {
            var sm = GameManager.GetSkillsManager();
            if (sm == null) { Log("[Skills] no SkillsManager"); return; }
            var skill = sm.GetSkill(t);
            if (skill == null) { Log($"[Skills] skill {t} not found"); return; }
            int max = skill.GetMaxPoints();
            // PointAssignmentMode:0 = None, 1 = Normal, 2 = ... 反射枚举值,直接传 1 比较稳
            var setP = skill.GetType().GetMethod("SetPoints", BindingFlags.Instance | BindingFlags.Public);
            if (setP != null)
            {
                var pam = setP.GetParameters()[1].ParameterType;
                var modeVal = Enum.ToObject(pam, 1);
                setP.Invoke(skill, new object[] { max, modeVal });
                Log($"[Skills] {t} = {max}");
            }
        }
        catch (Exception ex) { Log($"[Skills] {ex.Message}"); }
    }

    public static void SetAllMax()
    {
        foreach (var (_, _, t) in All) SetMax(t);
        Log(I18n.IsEnglish ? "[Skills] All skills maxed" : "[Skills] 所有技能满级");
    }

    private static void Log(string s) { CheatState.LastActionLog = s; ModMain.Log?.Msg(s); }
}

#if !STORY_EDITION
// v7.1 食谱(含 DLC):列出 RecipeBook.AllRecipes,逐个解锁,写存档
// 2.24 无 Il2CppTLD.Cooking(食谱系统 RecipeBook/RecipeData 是沙盒后加的),
// 连带只服务它的 RecipeNameZh 补译表和 Menu 里的食谱 section 一起排除。
internal static class Recipes
{
    // 缓存当前局加载的食谱;进存档/换局后用 Refresh() 重拉
    private static readonly List<Il2CppTLD.Cooking.RecipeData> _cache = new();
    // 显示名在 Refresh 时算好:GetName 每次走好几趟 IL2CPP 和本地化查表,OnGUI 每个事件都调会一直分配
    private static readonly List<string> _names = new();
    private static bool _namesEnglish;

    public static IReadOnlyList<Il2CppTLD.Cooking.RecipeData> All => _cache;

    public static string NameAt(int i)
    {
        if (_namesEnglish != I18n.IsEnglish || _names.Count != _cache.Count) RebuildNames();
        return i < _names.Count ? _names[i] : "?";
    }

    private static void RebuildNames()
    {
        _namesEnglish = I18n.IsEnglish;
        _names.Clear();
        for (int i = 0; i < _cache.Count; i++) _names.Add(GetName(_cache[i]));
    }

    // 切场景后缓存里的 RecipeData 会被销毁,托管壳还在,读 .name 抛 NRE。== null 走 Unity 重载能判出来。
    public static bool HasDestroyed()
    {
        for (int i = 0; i < _cache.Count; i++)
            if (_cache[i] == null) return true;
        return false;
    }

    // 拉取 RecipeBook.Instance.AllRecipes 到缓存。返回数量。
    // v7.6:只收"需要解锁的特殊食谱"(RecipeData.IsSpecial / UnlockRule==CodeUnlock)。
    //   AllRecipes 里混着几十条永远默认可做的基础烹饪(煮肉/烧水/化雪/泡茶,UnlockType.Unlocked),
    //   那些不该出现在"解锁食谱"页 —— 玩家反馈"应该只有十个左右",正是被这些基础项撑爆了。
    //   只留 CodeUnlock 的可学配方(DLC 派/炖菜/汤等十几条),回到该有的数量。
    public static int Refresh(bool quiet = false)
    {
        _cache.Clear();
        try
        {
            var rb = Il2CppTLD.Cooking.RecipeBook.Instance;
            if (rb == null)
            {
                if (!quiet) Log(I18n.T("[Recipe] no RecipeBook (进游戏后再试)", "[Recipe] no RecipeBook (load a save first)"));
                return 0;
            }
            var list = rb.AllRecipes;
            if (list == null) return 0;
            for (int i = 0; i < list.Count; i++)
            {
                var rd = list[i];
                if (rd == null) continue;
                if (!IsLearnable(rd)) continue;   // 过滤掉基础烹饪,只留需解锁的特殊食谱
                _cache.Add(rd);
            }
        }
        catch (Exception ex) { Log($"[Recipe] refresh {ex.Message}"); }
        RebuildNames();
        return _cache.Count;
    }

    // 判断是否"可学习/需解锁"的特殊食谱。优先用游戏的 IsSpecial(cooking 面板的 special 标记同源),
    //   退回 UnlockRule==CodeUnlock。二者任一为真即算。取属性异常时保守返回 false(不显示,避免撑爆列表)。
    private static bool IsLearnable(Il2CppTLD.Cooking.RecipeData rd)
    {
        try { if (rd.IsSpecial) return true; } catch { }
        try { if (rd.UnlockRule == Il2CppTLD.Cooking.RecipeData.UnlockType.CodeUnlock) return true; } catch { }
        return false;
    }

    // 食谱名跟随 mod 语言配置(非游戏 UI 语言):中配=中文名,英配=英文名。
    //   游戏语言码用 Steam 命名(English 已由 kDefaultLanguage 证实);中文码运行时
    //   从 GetLanguages() 里匹配 "chinese" 解析,退回 "Schinese"。只解析一次缓存。
    // 游戏真实中文码(实证自 localization bundle)是 "Simplified Chinese" / "Traditional Chinese"
    // (带空格全称),不是 Steam 的 "Schinese"。优先精确匹配简体全称,显式排除繁体,
    // 再退回任意含 chinese 的项,最后 fallback 简体全称。
    private static string _zhLangCode;
    private static string ResolveZhLangCode()
    {
        if (_zhLangCode != null) return _zhLangCode;
        try
        {
            var langs = Localization.GetLanguages();
            if (langs != null)
            {
                // 1. 精确简体:含 chinese 且(含 simplified 或不含 traditional)
                for (int i = 0; i < langs.Count; i++)
                {
                    string l = langs[i];
                    if (string.IsNullOrEmpty(l)) continue;
                    string lo = l.ToLowerInvariant();
                    if (lo.Contains("chinese") && lo.Contains("simplified"))
                    { _zhLangCode = l; return _zhLangCode; }
                }
                // 2. 退而求其次:任意含 chinese 但不是繁体
                for (int i = 0; i < langs.Count; i++)
                {
                    string l = langs[i];
                    if (string.IsNullOrEmpty(l)) continue;
                    string lo = l.ToLowerInvariant();
                    if (lo.Contains("chinese") && !lo.Contains("traditional"))
                    { _zhLangCode = l; return _zhLangCode; }
                }
            }
        }
        catch { }
        _zhLangCode = "Simplified Chinese";
        return _zhLangCode;
    }

    // 判断一个本地化结果是不是"其实没翻译成中文"(纯 ASCII/无 CJK)——
    // 游戏官方简体表缺译某些(多为 DLC)食谱时会回落英文,据此触发我们的补译兜底。
    private static bool LooksEnglish(string sv)
    {
        if (string.IsNullOrEmpty(sv)) return false;
        for (int i = 0; i < sv.Length; i++)
            if (sv[i] >= 0x4E00 && sv[i] <= 0x9FFF) return false; // 含 CJK 即视为已中文
        return true;
    }

    // 取可读食谱名:按 mod 语言配置取对应语言的本地化短名,退回 LocalizationID,再退回 SO 名
    public static string GetName(Il2CppTLD.Cooking.RecipeData rd)
    {
        try
        {
            string stem = rd.name;   // Unity 对象名,如 RECIPE_PieMeat(RECIPE_ 前缀 + 帕斯卡),补译兜底键
            // 运行时实测:这批可学食谱 ShortName.m_LocalizationID 全为空 ""(游戏基础表无 DLC 短名键),
            //   只有 Name.m_LocalizationID 是可解析的 GAMEPLAY_* 键。故取二者首个非空,空则回落 Name。
            string sid = null, nid = null;
            try { sid = rd.ShortName?.m_LocalizationID; } catch { }
            try { nid = rd.Name?.m_LocalizationID; } catch { }
            string id = !string.IsNullOrEmpty(sid) ? sid : nid;

            if (I18n.IsEnglish)
            {
                if (!string.IsNullOrEmpty(id))
                {
                    string en = Localization.GetForLang(id, "English");
                    if (!string.IsNullOrEmpty(en) && en != id) return en;
                    en = Localization.Get(id);
                    if (!string.IsNullOrEmpty(en) && en != id) return en;
                    return id;
                }
                return stem;
            }

            // 中配:先按最稳定的 stem/id 精确补译(DLC 特殊食谱的 ShortName loc key 游戏基础表查不到,
            //   会回落成裸 id;这些只能靠 stem 精确补)。LookupExact 只精确命中,不做关键词兜底,
            //   所以基础食谱在这一步必然 miss(返回 null),不会被误覆盖,照常走下面的官方解析。
            string patched = RecipeNameZh.LookupExact(stem, id);
            if (!string.IsNullOrEmpty(patched)) return patched;

            if (!string.IsNullOrEmpty(id))
            {
                // 基础食谱:官方简体表能正常解析,取官方译名
                string zh = Localization.GetForLang(id, ResolveZhLangCode());
                if (!string.IsNullOrEmpty(zh) && zh != id && !LooksEnglish(zh)) return zh;
                zh = Localization.Get(id);
                if (!string.IsNullOrEmpty(zh) && zh != id && !LooksEnglish(zh)) return zh;
                // 官方也缺译 → 才用关键词模糊兜底(此时覆盖无损)
                patched = RecipeNameZh.LookupFuzzy(id, zh ?? id);
                if (!string.IsNullOrEmpty(patched)) return patched;
                if (!string.IsNullOrEmpty(zh) && zh != id) return zh;
                return id;
            }
            return stem;
        }
        catch { return "?"; }   // 别在这里再读 rd.name:对象已销毁时会从 catch 里再抛一次
    }

    public static bool IsUnlocked(Il2CppTLD.Cooking.RecipeData rd)
    {
        try
        {
            var rb = Il2CppTLD.Cooking.RecipeBook.Instance;
            return rb != null && rb.IsRecipeUnlocked(rd);
        }
        catch { return false; }
    }

    public static void Unlock(Il2CppTLD.Cooking.RecipeData rd)
    {
        try
        {
            var rb = Il2CppTLD.Cooking.RecipeBook.Instance;
            if (rb == null) { Log("[Recipe] no RecipeBook"); return; }
            rb.UnlockRecipe(rd);
            Log($"[Recipe] unlocked {GetName(rd)}");
        }
        catch (Exception ex) { Log($"[Recipe] {ex.Message}"); }
    }

    public static void UnlockAll()
    {
        if (_cache.Count == 0 || HasDestroyed()) Refresh();
        int n = 0;
        foreach (var rd in _cache) { Unlock(rd); n++; }
        Log(I18n.IsEnglish ? $"[Recipe] unlocked {n} recipes" : $"[Recipe] 解锁 {n} 个食谱");
    }

    private static void Log(string s) { CheatState.LastActionLog = s; ModMain.Log?.Msg(s); }
}

// 食谱中文补译兜底 —— 游戏官方简体表缺译的(多为 DLC)食谱,这里按
// LocalizationID 或英文名里的关键词补中文名。匹配用小写子串包含,
// 鲁棒于 id 前后缀差异;先精确 id,再英文名关键词。命中返回中文,否则返回 null。
internal static class RecipeNameZh
{
    // v7.6:精确英文名 → 中文(取自游戏官方简体表 zh-Hans 的真值,离线提取自 resources.assets)。
    //   官方简体表运行时对这些 DLC 食谱回落英文时,用这张表精确补回中文,不再显示英文。
    //   键是游戏给的短名英文原文(区分具体菜名,含专有名词如"搬运工浓汤")。
    // v7.6:特殊(DLC)食谱的 ShortName 用的是 DLC 专用 loc key,游戏基础语言表查不到,
    //   运行时回落成裸 id(菜单里显示 GAMEPLAY_xxx 这种"英文 xxx_xxx")。基础食谱(bannock/broth/
    //   stew* 等)官方表能正常解析,不受影响。所以只对这 9 个特殊食谱按最稳定的标识补中文:
    //   优先按 RecipeData 的 Unity 对象名 stem(rd.name,如 pieMeat,100% 稳定),
    //   次按全名 loc id(GAMEPLAY_*)。中文取自游戏内食谱书截图的官方短名,与游戏完全一致。
    private static readonly System.Collections.Generic.Dictionary<string, string> _byStem =
        new(StringComparer.OrdinalIgnoreCase)
    {
        { "pieMeat",        "布雷耶豪斯馅饼" },   // Breyerhouse Pie
        { "pancakePeach",   "莉莉的薄煎饼" },     // Lily's Pancakes
        { "piePredator",    "潜行者馅饼" },       // Stalker's Pie
        { "stewVegetables", "汤姆逊·炖菜" },      // Thomson Family Stew
        { "stewMeat",       "护林员炖菜" },       // Ranger Stew
        { "fishcakes",      "海滨鱼饼" },         // Coastal Fishcakes
        { "pieFishermans",  "码头工人馅饼" },     // Dockworker's Pie
        { "porridgeFruit",  "翼面糊" },           // Camber Flight Porridge
        { "pieForagers",    "生存者馅饼" },       // Prepper's Pie
    };

    private static readonly System.Collections.Generic.Dictionary<string, string> _byId =
        new(StringComparer.OrdinalIgnoreCase)
    {
        { "GAMEPLAY_MeatPie",       "布雷耶豪斯馅饼" },
        { "GAMEPLAY_PeachPancake",  "莉莉的薄煎饼" },
        { "GAMEPLAY_PredatorPie",   "潜行者馅饼" },
        { "GAMEPLAY_VegetableStew", "汤姆逊·炖菜" },
        { "GAMEPLAY_MeatStew",      "护林员炖菜" },
        { "GAMEPLAY_Fishcakes",     "海滨鱼饼" },
        { "GAMEPLAY_Fishcake",      "海滨鱼饼" },
        { "GAMEPLAY_FishermansPie", "码头工人馅饼" },
        { "GAMEPLAY_FruitPorridge", "翼面糊" },
        { "GAMEPLAY_ForagersPie",   "生存者馅饼" },
    };

    private static readonly System.Collections.Generic.Dictionary<string, string> _exact =
        new(StringComparer.OrdinalIgnoreCase)
    {
        { "Acorn Bannock",           "橡实薄饼" },
        { "Acorn Pancakes",          "橡实薄煎饼" },
        { "Bannock",                 "薄饼" },
        { "Birch Bark Tea",          "桦树皮茶" },
        { "Breyerhouse Pie",         "布雷耶豪斯馅饼" },
        { "Broth",                   "肉汤" },
        { "Burdock Tea",             "牛蒡茶" },
        { "Camber Flight Porridge",  "“翼面弧”燕麦粥" },
        { "Coastal Fishcakes",       "海滨鱼饼" },
        { "Cooking Oil",             "食用油" },
        { "Cup of Acorn Coffee",     "一杯橡实咖啡" },
        { "Cup of Coffee",           "一杯咖啡" },
        { "Cup of Herbal Tea",       "一杯花茶" },
        { "Dockworker's Pie",        "码头工人的馅饼" },
        { "Fruit Porridge",          "水果燕麦粥" },
        { "Last Resort Soup",        "“最后手段”汤" },
        { "Lily's Pancakes",         "莉莉的薄煎饼" },
        { "Pancakes",                "薄煎饼" },
        { "Peach Pancakes",          "桃肉薄煎饼" },
        { "Peach Pie",               "桃肉馅饼" },
        { "Pemmican Bar",            "干肉条" },
        { "Porridge",                "燕麦粥" },
        { "Porter's Soup",           "搬运工浓汤" },
        { "Prepper's Pie",           "生存者的馅饼" },
        { "Ptarmigan Pie",           "松鸡肉馅饼" },
        { "Ptarmigan Stew",          "炖松鸡" },
        { "Pumpkin Pie",             "南瓜派" },
        { "Rabbit Pie",              "兔肉馅饼" },
        { "Rabbit Stew",             "煮兔肉" },
        { "Ranger Stew",             "护林员炖菜" },
        { "Reishi Tea",              "灵芝茶" },
        { "Rose Hip Pie",            "玫瑰果馅饼" },
        { "Rose Hip Tea",            "玫瑰茶" },
        { "Stalker's Pie",           "潜行者的馅饼" },
        { "Thomson Family Stew",     "汤姆逊家族炖菜" },
        { "Tomato Soup",             "番茄汤" },
        { "Trout Stew",              "炖鳟鱼" },
        { "Vagabond Soup",           "流浪汉肉汤" },
        { "Venison Pie",             "鹿肉馅饼" },
        { "Venison Stew",            "炖鹿肉" },
    };

    // 英文名/ID 关键词 → 中文兜底(精确表没命中才用)。具体词放前面(fishcake 先于 fish/cake)。
    private static readonly (string key, string zh)[] _map =
    {
        ("fishcake",        "鱼饼"),
        ("fish cake",       "鱼饼"),
        ("acorn bannock",   "橡实薄饼"),
        ("bannock",         "薄饼"),
        ("birch bark tea",  "桦树皮茶"),
        ("birch",           "桦树皮茶"),
        ("rose hip tea",    "玫瑰果茶"),
        ("rosehip",         "玫瑰果茶"),
        ("reishi",          "灵芝茶"),
        ("burdock",         "牛蒡茶"),
        ("pumpkin pie",     "南瓜派"),
        ("pemmican",        "干肉条"),
        ("porridge",        "燕麦粥"),
        ("pancake",         "薄煎饼"),
        ("broth",           "肉汤"),
        ("cooking oil",     "食用油"),
        ("cattail",         "香蒲"),
        ("coffee",          "咖啡"),
        // 兜底通用词(放最后,前面没命中才用)
        ("stew",            "炖菜"),
        ("soup",            "汤"),
        ("tea",             "茶"),
        ("pie",             "馅饼"),
    };

    // 精确补译:只按 SO 名 stem / 全名 loc id 精确命中,无则返回 null。
    //   用在官方 Localization 解析之前:DLC 特殊食谱的 ShortName loc key 游戏基础表查不到会回落裸 id,
    //   这里按最稳定的 stem 精确补;基础食谱 stem/id 不在表里 → 返回 null → 交给官方解析(不会被误覆盖)。
    //   关键:此处绝不做关键词子串兜底,否则 GAMEPLAY_VenisonMeatStew 会被 "stew" 误判成通用"炖菜",
    //   把正确的官方名(炖鹿肉)覆盖掉。子串兜底只留给 LookupFuzzy(官方解析失败后才用)。
    public static string LookupExact(string soStem, string id)
    {
        if (!string.IsNullOrEmpty(soStem) && _byStem.TryGetValue(soStem.Trim(), out var byStem))
            return byStem;
        if (!string.IsNullOrEmpty(id) && _byId.TryGetValue(id.Trim(), out var byId))
            return byId;
        return null;
    }

    // 模糊补译:精确英文名 → 关键词子串兜底。只在官方解析已失败后调用(此时覆盖也无损)。
    public static string LookupFuzzy(string id, string enText)
    {
        if (!string.IsNullOrEmpty(enText) && _exact.TryGetValue(enText.Trim(), out var exact))
            return exact;
        string a = (id ?? "").ToLowerInvariant();
        string b = (enText ?? "").ToLowerInvariant();
        for (int i = 0; i < _map.Length; i++)
        {
            string k = _map[i].key;
            if (a.Contains(k) || b.Contains(k)) return _map[i].zh;
        }
        return null;
    }
}
#endif

// 壮举解锁 —— 直接设内部进度字段到满值(仿 CT 做法)
internal static class Feats
{
    public static void UnlockAllFeats()
    {
        try
        {
            int ok = 0, fail = 0;
            var fm = GameManager.GetFeatsManager();
            if (fm == null) { Log("[Feats] FeatsManager null"); return; }
            int total = fm.GetNumFeats();
            Log($"[Feats] Starting unlock, {total} feats found");

            for (int i = 0; i < total; i++)
            {
                try
                {
                    var feat = fm.GetFeatFromIndex(i);
                    if (feat == null) { fail++; continue; }
                    string name = ((UnityEngine.Object)feat).name;

                    // 强制 SetNormalizedProgress(1) — 不管是否已 unlocked
                    feat.SetNormalizedProgress(1.0f);

                    // 额外：布尔型 feat 直接设 m_Unlocked 字段
                    var unlockField = feat.GetType().GetField("m_Unlocked",
                        BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                    if (unlockField != null)
                        unlockField.SetValue(feat, true);

                    // 触发 HandleOnFeatUnlocked 显示 UI 通知
                    try
                    {
                        var handler = typeof(Feat).GetMethod("HandleOnFeatUnlocked",
                            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                        if (handler != null) handler.Invoke(feat, null);
                    }
                    catch { }

                    ok++;
                    ModMain.Log?.Msg($"[Feats] #{i} {name} → SetProgress(1) + unlocked={feat.IsUnlocked()}");
                }
                catch (Exception ex) { fail++; ModMain.Log?.Warning($"[Feats] #{i} failed: {ex.Message}"); }
            }
            Log(I18n.IsEnglish ? $"[Feats] Done: {ok} ok, {fail} failed" : $"[Feats] 完成: {ok} 成功, {fail} 失败");
        }
        catch (Exception ex) { Log($"[Feats] {ex.Message}"); }
    }

    private static void Log(string s) { CheatState.LastActionLog = s; ModMain.Log?.Msg(s); }
}

// 环境 / 身体 相关的"持续保持"类(每帧或每 tick 应用,每 tick 间隔游戏自己会重写)
internal static class ExtraOneShot
{
    private static bool _wristHeld;   // 本进程里是我们把强制标记设成了 true

    public static void TickSprainRisk()
    {
        // Wrist 有内建 force-off;Ankle 没有,靠 Harmony patch SprainedAnkleStart 拦
        // 这个标记会写进存档(SprainedWristSaveDataProxy.m_IsNoSprainWristForced)。
        //   防扭伤和防坠落两个开关只在这里管它:任一开着就设,都关了就放回,否则这个存档永远不会扭伤手腕。
        //   只放回自己设过的,不碰游戏自己设的。
        try
        {
            var wrist = GameManager.GetSprainedWristComponent();
            if (wrist == null) return;   // 主菜单拿不到,别先记成已设
            if (CheatState.NoSprainRisk || CheatState.NoFallDamage)
            {
                if (!wrist.IsNoSprainWristForced()) wrist.SetForceNoSprainWrist(true);
                _wristHeld = true;
            }
            else if (_wristHeld)
            {
                wrist.SetForceNoSprainWrist(false);
                _wristHeld = false;
            }
        }
        catch { }
    }
}

// 物品 / 蓝图 / 治愈 等一次性操作
internal static class QuickActions
{
    // 一键修复所有背包物品耐久到满
    public static void RepairAllInventory()
    {
        int ok = 0, fail = 0, total = 0;
        try
        {
            var inv = GameManager.m_Inventory;
            if (inv == null) { CheatState.LastActionLog = I18n.IsEnglish ? "[RepairBag] No inventory?" : "[修复背包] 没有背包?"; return; }
            var list = inv.m_Items;
            if (list == null) { CheatState.LastActionLog = I18n.IsEnglish ? "[RepairBag] m_Items=null" : "[修复背包] m_Items=null"; return; }
            total = list.Count;
            for (int i = 0; i < total; i++)
            {
                try
                {
                    var obj = list[i];
                    if (obj == null) continue;
                    var gi = obj.m_GearItem;
                    if (gi != null) { if (Cheats.RestoreDurability(gi)) ok++; else fail++; }
                }
                catch { fail++; }
            }
            CheatState.LastActionLog = I18n.IsEnglish
                ? $"[RepairBag] ok {ok} / total {total} (failed {fail})"
                : $"[修复背包] 成功 {ok} / 总 {total} (失败 {fail})";
            ModMain.Log?.Msg($"[Repair] ok={ok} fail={fail} total={total}");
        }
        catch (Exception ex)
        {
            CheatState.LastActionLog = I18n.IsEnglish
                ? $"[RepairBag error] {ex.Message}"
                : $"[修复背包异常] {ex.Message}";
            ModMain.Log?.Warning($"[Repair] {ex.Message}");
        }
    }

    // 解锁蓝图 —— 反射找 BlueprintManager / BluePrintItem,设它们的 IsKnown / m_RequiresResearch
    public static void UnlockAllBlueprints()
    {
        try
        {
            int n = 0;
            var asm = typeof(GameManager).Assembly;
            // 找 BluePrintItem / BlueprintItem 类
            Type bpType = null;
            foreach (var t in asm.GetTypes())
            {
                if (t.Name == "BluePrintItem" || t.Name == "BlueprintItem") { bpType = t; break; }
            }
            if (bpType == null) { Log("[BP] BluePrintItem type not found"); return; }

            var all = UnityEngine.Object.FindObjectsOfType(Il2CppType.From(bpType));
            foreach (var bp in all)
            {
                try
                {
                    foreach (var fn in new[] { "m_RequiresResearch", "m_KnownByDefault", "m_IsKnown" })
                    {
                        var f = bpType.GetField(fn, BindingFlags.Instance | BindingFlags.Public);
                        if (f != null && f.FieldType == typeof(bool))
                            f.SetValue(bp, fn == "m_RequiresResearch" ? (object)false : (object)true);
                    }
                    n++;
                }
                catch { }
            }
            Log(I18n.IsEnglish ? $"[BP] Processed {n} blueprints" : $"[BP] 处理 {n} 个蓝图");
        }
        catch (Exception ex) { Log($"[BP] {ex.Message}"); }
    }

    // 获取特定武器:沿用 Cheats.SpawnItem
    public static void GiveWeapon(string prefab) { Cheats.SpawnItem(prefab, 1); Log($"[Give] {prefab}"); }

    // 固定温度 —— 简化版:调 Weather 的 SetTemperature(反射)
    public static void SetFixedTemperature(float celsius)
    {
        try
        {
            var w = GameManager.GetWeatherComponent();
            if (w == null) return;
            var m = w.GetType().GetMethod("SetTemperature", BindingFlags.Instance | BindingFlags.Public);
            m?.Invoke(w, new object[] { celsius });
            Log($"[Temp] {celsius:F0}°C");
        }
        catch (Exception ex) { Log($"[Temp] {ex.Message}"); }
    }

    private static void Log(string s) { CheatState.LastActionLog = s; ModMain.Log?.Msg(s); }
}
