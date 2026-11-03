using System;
using System.Reflection;
using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TldHacks;

// 所有作弊相关的运行时状态。静态,方便 Harmony patch 里 access
// 状态写入由 Menu / Settings 触发,OnInitializeMelon 会从 Settings 同步过来
internal static class CheatState
{
    // Life / 生命
    public static bool GodMode;
    public static bool NoFallDamage;
    // Status / 状态
    public static bool AlwaysWarm;
    public static bool NoHunger;
    public static bool NoThirst;
    public static bool NoFatigue;
    // Movement / 移动(注:InfiniteCarry 去掉 —— 其他 mod 已覆盖)
    public static float SpeedMultiplier = 1f;
    // Animals / 动物
    public static bool InstantKillAnimals;
    public static bool FreezeAnimals;
    public static bool Stealth;         // 动物自动逃跑(Flee mode)
    public static bool TrueInvisible;   // 真·隐身(AI 检测不到玩家,不会主动扑也不会逃)
    // World
    public static bool ThinIceNoBreak;
    public static bool IgnoreLock;
    public static bool QuickOpenContainer;
    // Items / Fire
    public static bool InfiniteDurability;
    public static bool NoWetClothes;
    // InfiniteFireDurations 去除 —— 其他 mod 已覆盖
    // Crafting
    public static bool FreeCraft;
    public static bool QuickCraft;
    public static bool FreeRepair;
    // Weapons
    public static bool InfiniteAmmo;
    public static bool NoJam;
    public static bool NoRecoil;
    // Aiming (v2.7.84 合并:NoAimSway = 晃动+抖动+呼吸,SuperAccuracy = 零散布+关晃动)
    public static bool NoAimSway;      // 稳定瞄准(合并 sway+shake+breath)
    public static bool NoAimStamina;
    public static bool SuperAccuracy;  // 超级精准(散布归零 + 关晃动)
    // Environment / body
    public static bool NoSprainRisk;
    public static bool ImmuneAnimalDamage; // Wolf/Bear/Cougar 攻击不扣血
    public static bool NoSuffocating;      // 不会窒息
    // Skills / shortcuts
    public static bool QuickFire;          // 生火 100% 成功
    public static bool QuickClimb;         // 爬绳速度 ×5
    public static bool QuickAction;        // 采集 / 修理 / 拆解 自动时间加速
    // CT 复刻 v2.7.45+
    public static bool QuickCook;          // 秒烤肉(自带防烤焦,Ready 状态 elapsed clamp 不进 Ruined)
    public static bool NoBurn;             // 防烤焦独立开关(只锁 Ready elapsed,不秒熟)
    public static bool QuickSearch;        // 秒搜索
    public static bool QuickHarvest;       // 秒割肉
    public static bool QuickBreakDown;     // 秒打碎
    public static bool UnlockSafes;        // 解锁保险箱/门/柜子
    public static bool LampFuelNoDrain;    // 防风油灯油不减
    public static bool LampMute;           // v3.0.4 油灯静音(放置时)
    public static bool FlaskNoHeatLoss;    // 保温杯永不失温
    public static bool FlaskInfiniteVol;   // 保温杯存放无限
    public static bool FlaskAnyItem;       // 保温瓶装任意
    public static bool QuickEvolve;        // 加工秒完成
    public static bool InfiniteContainer;  // 容器无限
    public static bool FireTemp300;        // 篝火 300℃
    public static bool FireNeverDie;       // 篝火永不熄
    public static float FireMaxBurnHours;  // 篝火燃烧上限(小时)
    public static bool NoFrostbiteRisk;    // 无冻伤风险(CT: DealFrostbiteDamageToLocation=0)
    public static bool WellFedBuff;        // 饱饱 buff(CT: WellFed.Update NOP)
    public static bool FreezingBuff;       // 温度加成(CT: FreezingBuffActive=true)
    public static bool FatigueBuff;        // 疲劳加成(CT: StatusBar fatigue buff=1)
    public static bool ClearDeathPenalty;  // 清除死亡惩罚
    public static bool QuickFishing;       // 钓鱼 100%
    // v2.7.86 新增功能
    public static bool FireAnywhere;       // 随意生火(含室内)
    public static bool FreeFireFuel;       // 生火材料不减
    public static bool TechBackpack;       // 自定义背包负重(覆盖原版 30kg 上限)
    public static float TechBackpackKg = 30f;
    public static bool TorchFullValue;     // 火把满值
    // FreeSprint 已由 InfiniteStamina 覆盖,字段保留仅为 JSON 兼容
    public static bool InfiniteStamina;    // 无限体力
    // v2.7.55 商人 + 美洲狮
    public static bool TraderUnlimitedList;   // 交易清单上限 → 64
    public static bool TraderMaxTrust;        // 信任拉满
    public static bool TraderUnlockModeItems; // 解锁原版难度限制的商品
    public static bool TraderInstantExchange; // 交易秒完成
    public static bool TraderAlwaysAvailable; // 随时可联系商人
    public static bool CougarInstantActivate; // 新档首次立即激活美洲狮
    public static bool MapClickTP = true; // 双击地图图标传送
    // v2.7.58 与 ItemPicker mod 交互 —— 不让 W 键自动拾取捡回玩家自己丢的物品
    public static bool BlockAutoPickupOwnDrops;
    // v2.7.95 整合 mod
    public static bool SilentFootsteps;
    public static bool RunWithLantern;
    public static bool NoAutoEquipCharcoal;
    public static bool AutoExtinguishOnRest;
    public static bool DisableTorchLeftClick;
    public static bool DisableLampLeftClick;
    // 天气锁定
    public static bool WeatherLocked;
    public static int WeatherLockedStage;
    // HouseLights 整合
    public static bool HL_Enabled;
    public static bool HL_EnableOutside;
    public static bool HL_WhiteLights;
    public static bool HL_NoFlicker = true;
    public static bool HL_CastShadows;
    public static bool HL_LightAudio;
    public static float HL_Intensity = 2f;
    public static float HL_RangeMultiplier = 1.4f;
    public static float HL_CullDistance = 50f;
    public static float HL_InteractDistance = 2f;
    // v2.7.96 整合 Batch 2
    public static bool PauseInJournal;
    public static bool SkipIntro;
    public static bool MuteCougarMenuSound;
    public static bool VehicleKeepFov;
    public static bool DroppableUndroppables;
    public static bool RememberBreakdownTool;
    public static bool VehicleFreeLook;
    // Display
    public static string PositionText = "";
    // v2.7.29:LastActionLog 截断到 200 字符避免 UI 溢出
    private static string _lastActionLog = "";
    public static string LastActionLog
    {
        get => _lastActionLog;
        set => _lastActionLog = (value != null && value.Length > 200) ? value.Substring(0, 200) : (value ?? "");
    }

    // v2.7.60 删除:4 个 C* (CInvulnerable/CInvisible/CNoJamConsole/CNoSprain)
    //   都是 uConsole-based,release build 不 work,字段永远 false 且无人读 —— 死代码
    // ⚠ CFly 保留:`fly` 命令在用户的游戏里实际 work(F1 切换)—— 删除会误伤
    public static bool CFly;



    // ═══════════════════════════════════════════════════════════════
    // v2.8.0 批量整合 — Tab 7: QoL
    // ═══════════════════════════════════════════════════════════════
    public static bool QoL_Enabled;
    public static bool QoL_NoSaveOnSprain;
    public static bool QoL_NoSaveOnSprainFalls;
    public static bool QoL_WakeUpCall;
    public static bool QoL_AuroraSense = true;
    public static bool QoL_ShowTimeSleep;
    public static bool QoL_NoPitchBlack;
    public static bool QoL_MapTextOutline;
    public static bool QoL_BuryCorpses;
    public static bool QoL_SleepAnywhere;
    public static bool QoL_AutoSurvey;


    // ═══════════════════════════════════════════════════════════════
    // v2.8.0 批量整合 — Tab 8: Crafting & Fire
    // ═══════════════════════════════════════════════════════════════
    public static bool Craft_Anywhere;
    public static bool Craft_MoreCookingSlots;

    // ═══════════════════════════════════════════════════════════════
    // v2.8.0 批量整合 — Tab 9: World & Items
    // ═══════════════════════════════════════════════════════════════
    public static bool World_Sprainkle;
    public static int World_SprainklePreset;
    public static float World_SprainkleSlopeMin;
    public static float World_SprainkleSlopeIncrease;
    public static float World_SprainkleBaseChanceMoving;
    public static float World_SprainkleEncumberChance;
    public static float World_SprainkleExhaustionChance;
    public static float World_SprainkleSprintChance;
    public static float World_SprainkleCrouchChance;
    public static float World_SprainkleMinSecondsRisk;
    public static float World_SprainkleWristMovementChance;
    public static float World_SprainkleSprintUIOn;
    public static float World_SprainkleSprintUIOff;
    public static bool World_SprainkleAnkleEnabled;
    public static float World_SprainkleAnkleDurMin;
    public static float World_SprainkleAnkleDurMax;
    public static float World_SprainkleAnkleRestHours;
    public static float World_SprainkleAnkleFallChance;
    public static bool World_SprainkleWristEnabled;
    public static float World_SprainkleWristDurMin;
    public static float World_SprainkleWristDurMax;
    public static float World_SprainkleWristRestHours;
    public static float World_SprainkleWristFallChance;
    public static bool World_BowRepair;
    public static bool World_BowRepairDLC;
    public static bool World_CaffeinatedSodas;
    public static bool World_SodaOrangeEnabled;
    public static bool World_SodaSummitEnabled;
    public static bool World_SodaGrapeEnabled;
    public static bool World_CarcassMoving;
    public static bool World_CarcassMovingAll;
    public static bool World_ElectricTorch;

    // TinyTweaks
    public static bool TT_CapFeelsEnabled;
    public static bool TT_FallDeathGoat;
    public static bool TT_DroppedOrientation;
    public static bool TT_ExtendedFOV;
    public static bool TT_PauseOnRadial;
    public static bool TT_RespawnPlants;
    public static bool TT_ShowTraderTrust;

    // v6.7.1 ClearAllAfflictions 防三方 mod "并发症 Postfix" 反补 buff
    //   现象:整合包里有 Cold/Sickness mod 把 vanilla XxxEnd 当作 Postfix 钩子触发"治愈后并发症"
    //   一键清除负面会一口气调 N 次 vanilla End → 触发 N 次"并发症 roll" → 反而加上"感冒"
    //   解决:在清除窗口内吞掉新增的 affliction(由 OnUpdate 二次扫描兜底)
    public static bool AfflictionClearInProgress;
    public static int AfflictionClearReSweepFramesLeft;  // 大于 0 时每帧扫一次

    // v6.9.5 诊断:affliction auto-cure bug 排查 — 在 Menu 里勾 "诊断:Affliction日志" 后
    // 每次 BloodLossEnd/InfectionEnd/HypothermiaEnd 被调时记录调用栈到 MelonLoader log
    public static bool DiagAfflictionLog = false;   // v7.2 起 UI 不再暴露开关(诊断方法保留待需);显式初始化消除 CS0649
}

// 工具函数:刷物品/清 affliction/天气/时间/耐久恢复
internal static class Cheats
{
    // v8.2 全关时要清哪些字段。
    //   不手写清单。下面那份手写的 DisableAllCheats 清单已经漏了 20 多个 toggle
    //   (v7.7 补过 9 个还是不全),每加一个新功能都要记得回来补一行,忘一次就变成
    //   "全部关闭之后这个功能还在生效"。反射直接跟着字段走,加功能不用改这里。
    //   跳过的 2 项不是功能开关:菜单自动缩放的记录位、
    //   以及逐件确认(那是操作习惯,不该被"全关"顺手改掉)。
    //   子选项(总开关关了就不起作用)也跳过,保留玩家的选择,重新打开总开关时照旧。
    private static readonly string[] OneClickSkip =
    {
        "MenuAutoScaled", "GrabAllNotify",
        "Craft_MoreSlots_Fireplace", "Craft_MoreSlots_Barrel", "Craft_MoreSlots_Grill",
        "World_SodaOrangeEnabled", "World_SodaSummitEnabled", "World_SodaGrapeEnabled",
        "QoL_SleepInterruptHudMsg", "QoL_SleepInterruptAllBeds",
        // QoL 总开关在 codex 菜单里没有按钮:全关时关掉它,之后在菜单里单独打开 QoL 功能也不起作用
        "QoL_Enabled",
        // 存档结构选项,不是作弊:咖啡罐/茶/胡萝卜/土豆的堆叠组件是它加的,关掉后读档组件不在,堆叠数会丢
        "Stack_AddComponent",
    };

    // true 才是原版行为的开关。全关时要把它们设成 true,设 false 反而会启用改动
    //   (隐藏哈气、关键物品重量归零、扭伤直接治愈)。
    private static readonly string[] VanillaWhenTrue =
    {
        "UT_BreathVisibility", "ImportantWeight",
        "World_SprainkleAnkleEnabled", "World_SprainkleWristEnabled",
    };

    private static int SetAllFeatureBools(TldHacksSettings s, bool value)
    {
        int n = 0;
        var fields = typeof(TldHacksSettings).GetFields(BindingFlags.Instance | BindingFlags.Public);
        for (int i = 0; i < fields.Length; i++)
        {
            var f = fields[i];
            if (f.FieldType != typeof(bool)) continue;
            if (Array.IndexOf(OneClickSkip, f.Name) >= 0) continue;
            bool target = Array.IndexOf(VanillaWhenTrue, f.Name) >= 0 ? !value : value;
            if ((bool)f.GetValue(s) == target) continue;
            f.SetValue(s, target);
            n++;
        }
        return n;
    }

    // v2.7.80 一键把所有作弊 toggle 设 false —— 修 "ModSettings Disable All 后 5 秒内还生效" 的响应性问题
    //   三步:1) Settings 所有 bool cheat 字段设 false(StackingEnabled/MenuHotkey/MenuScale 等 UI 偏好不动)
    //        2) 立即内联同步到 CheatState(比等 30 帧 SyncStateFromSettings 快)
    //        3) 立即 DynamicPatch.Reconcile() —— 动态 patch 下一帧就卸
    public static void DisableAllCheats()
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null) return;

            // ═══ 核心作弊 ═══
            s.GodMode = false;
            s.NoFallDamage = false;
            s.AlwaysWarm = false;
            s.NoHunger = false;
            s.NoThirst = false;
            s.NoFatigue = false;
            s.SpeedMultiplier = 1f;
            s.InstantKillAnimals = false;
            s.FreezeAnimals = false;
            s.Stealth = false;
            s.TrueInvisible = false;
            s.ThinIceNoBreak = false;
            s.IgnoreLock = false;
            s.QuickOpenContainer = false;
            s.InfiniteDurability = false;
            s.NoWetClothes = false;
            s.FreeCraft = false;
            s.QuickCraft = false;
            s.FreeRepair = false;
            s.InfiniteAmmo = false;
            s.NoJam = false;
            s.NoRecoil = false;
            s.NoAimSway = false;
            s.NoAimStamina = false;
            s.SuperAccuracy = false;
            s.NoSprainRisk = false;
            s.ImmuneAnimalDamage = false;
            s.NoSuffocating = false;
            s.QuickFire = false;
            s.QuickClimb = false;
            s.QuickAction = false;
            s.QuickCook = false;
            s.NoBurn = false;
            s.QuickSearch = false;
            s.QuickHarvest = false;
            s.QuickBreakDown = false;
            s.UnlockSafes = false;
            s.LampFuelNoDrain = false;
            s.FlaskNoHeatLoss = false;
            s.FlaskInfiniteVol = false;
            s.FlaskAnyItem = false;
            s.QuickEvolve = false;
            s.InfiniteContainer = false;
            s.FireTemp300 = false;
            s.FireNeverDie = false;
            s.NoFrostbiteRisk = false;
            s.WellFedBuff = false;
            s.FreezingBuff = false;
            s.FatigueBuff = false;
            s.ClearDeathPenalty = false;
            s.QuickFishing = false;
            s.FireAnywhere = false;
            s.FreeFireFuel = false;
            s.TechBackpack = false;
            s.TorchFullValue = false;
            s.FreeSprint = false;
            s.InfiniteStamina = false;
            s.TraderUnlimitedList = false;
            s.TraderMaxTrust = false;
            s.TraderUnlockModeItems = false;
            s.TraderInstantExchange = false;
            s.TraderAlwaysAvailable = false;
            s.CougarInstantActivate = false;
            s.BlockAutoPickupOwnDrops = false;
            s.CE_SnareSure = false;
            s.CE_SnareInstant = false;
            s.CE_LootNoEmpty = false;
            s.CE_LootLowerTier = false;
            s.CE_AuroraRefill = false;
            s.CE_IceHoleNoFreeze = false;
            s.CE_NoMisery = false;
            s.CE_NoDeath = false;
            s.CE_StruggleWin = false;
            s.CE_NoStun = false;
            s.CE_NoSlide = false;
            s.CE_TraderCheap = false;
            s.CE_AuroraLightSteady = false;
            s.CE_AuroraMute = false;


            // ═══ Movement Detail ═══
            s.SpeedTweaksEnabled = false;
            s.SilentFootsteps = false;
            s.JumpEnabled = false;
            s.GunZoomEnabled = false;
            s.RunWithLantern = false;
            s.NoAutoEquipCharcoal = false;
            s.AutoExtinguishOnRest = false;

            // ═══ Light Sources ═══
            s.LampMute = false;
            s.DisableTorchLeftClick = false;
            s.DisableLampLeftClick = false;

            // ═══ HouseLights ═══
            s.HL_Enabled = false;

            // ═══ QoL Batch 2 ═══
            s.PauseInJournal = false;
            s.SkipIntro = false;
            s.MuteCougarMenuSound = false;
            s.VehicleKeepFov = false;
            s.DroppableUndroppables = false;
            s.RememberBreakdownTool = false;
            s.VehicleFreeLook = false;

            // ═══ Crosshair ═══
            s.CrosshairEnabled = false;

            // ═══ QoL General ═══
            s.QoL_NoSaveOnSprain = false;
            s.QoL_NoSaveOnSprainFalls = false;
            s.QoL_WakeUpCall = false;
            s.QoL_AuroraSense = false;
            s.QoL_ShowTimeSleep = false;
            s.QoL_NoPitchBlack = false;
            s.QoL_MapTextOutlineEnabled = false;
            s.QoL_BuryCorpses = false;
            s.QoL_SleepAnywhere = false;
            s.QoL_AutoSurvey = false;

            // ═══ Crafting & Fire ═══
            s.Craft_Anywhere = false;
            s.Craft_MoreCookingSlots = false;

            // ═══ World & Items ═══
            s.World_Sprainkle = false;
            s.PlaceFromInv_Enabled = false;
            s.World_BowRepair = false;
            s.World_CaffeinatedSodas = false;
            s.World_CarcassMoving = false;
            s.World_CarcassMovingAll = false;
            s.World_ElectricTorch = false;
            s.MapClickTP = false;

            // ═══ UT 手电筒 ═══
            s.UT_FlashInfiniteBattery = false;

            // ═══ 铁路 DLC 蒸汽火车 ═══
            s.Train_NoBreak = false;
            s.Train_KeepHighGear = false;
            s.Train_FullFuel = false;
            s.Heater_NoFuel = false;
            s.Heater_FuelMult = 1f;
            s.Heater_TempBonus = 0f;
            s.OilCan_WhaleMaxL = 0f;
            s.OilCan_KeroseneMaxL = 0f;

            // ═══ StackManager ═══
            // Stack_AddComponent 不关(见 OneClickSkip):关了读档后已经堆起来的那几样会塌成 1 个
            s.Stack_UseMaxHP = false;

            // ═══ TinyTweaks ═══
            s.TT_CapFeelsEnabled = false;
            s.TT_FallDeathGoat = false;
            s.TT_PauseOnRadial = false;
            s.TT_RespawnPlants = false;
            s.TT_ShowTraderTrust = false;

            // ═══ UT 其他 ═══
            s.UT_RevolverImprovements = false;
            s.UT_ToiletWaterPotable = false;
            s.UT_RemoveHeadacheDebuff = false;
            s.UT_RockCacheIndoors = false;
            s.UT_GlowingDecals = false;

            // v7.7 补齐 9 个漏掉的总开关 —— 原先「全部关闭」后这些功能仍然生效
            s.StackingEnabled = false;
            s.MagicBullet = false;
            s.SpaceFinish_BreakDown = false;
            s.SpaceFinish_Craft = false;
            s.SpaceFinish_Harvest = false;
            s.SpaceFinish_Repair = false;
            s.QoL_HotkeysEnabled = false;
            s.TT_ExtendedFOV = false;

            // 手写清单之外的开关(JumpKing、HL 子项、准星、睡眠、UT 等)由反射补齐
            SetAllFeatureBools(s, false);

            s.Save();

            SyncCheatStateInline(s);
            DynamicPatch.Reconcile();

            CheatState.LastActionLog = I18n.T("已关闭全部功能(立即生效)", "All features disabled (immediate)");
            ModMain.Log?.Msg("[DisableAll] 所有功能 toggle 已关,CheatState 同步,动态 patch Reconcile");
        }
        catch (Exception ex) { ModMain.Log?.Error($"[DisableAll] {ex}"); }
    }

    // 内联版 Settings → CheatState(避免反射 ModMain.SyncStateFromSettings private)
    private static void SyncCheatStateInline(TldHacksSettings s)
    {
        // ═══ 核心作弊 ═══
        CheatState.GodMode = s.GodMode;
        CheatState.NoFallDamage = s.NoFallDamage;
        CheatState.AlwaysWarm = s.AlwaysWarm;
        CheatState.NoHunger = s.NoHunger;
        CheatState.NoThirst = s.NoThirst;
        CheatState.NoFatigue = s.NoFatigue;
        CheatState.SpeedMultiplier = s.SpeedMultiplier;
        CheatState.InstantKillAnimals = s.InstantKillAnimals;
        CheatState.FreezeAnimals = s.FreezeAnimals;
        CheatState.Stealth = s.Stealth;
        CheatState.TrueInvisible = s.TrueInvisible;
        CheatState.ThinIceNoBreak = s.ThinIceNoBreak;
        CheatState.IgnoreLock = s.IgnoreLock;
        CheatState.QuickOpenContainer = s.QuickOpenContainer;
        CheatState.InfiniteDurability = s.InfiniteDurability;
        CheatState.NoWetClothes = s.NoWetClothes;
        CheatState.FreeCraft = s.FreeCraft;
        CheatState.QuickCraft = s.QuickCraft;
        CheatState.FreeRepair = s.FreeRepair;
        CheatState.InfiniteAmmo = s.InfiniteAmmo;
        CheatState.NoJam = s.NoJam;
        CheatState.NoRecoil = s.NoRecoil;
        CheatState.NoAimSway = s.NoAimSway;
        CheatState.NoAimStamina = s.NoAimStamina;
        CheatState.SuperAccuracy = s.SuperAccuracy;
        CheatState.NoSprainRisk = s.NoSprainRisk;
        CheatState.ImmuneAnimalDamage = s.ImmuneAnimalDamage;
        CheatState.NoSuffocating = s.NoSuffocating;
        CheatState.QuickFire = s.QuickFire;
        CheatState.QuickClimb = s.QuickClimb;
        CheatState.QuickAction = s.QuickAction;
        CheatState.QuickCook = s.QuickCook;
        CheatState.NoBurn = s.NoBurn;
        CheatState.QuickSearch = s.QuickSearch;
        CheatState.QuickHarvest = s.QuickHarvest;
        CheatState.QuickBreakDown = s.QuickBreakDown;
        CheatState.UnlockSafes = s.UnlockSafes;
        CheatState.LampFuelNoDrain = s.LampFuelNoDrain;
        CheatState.FlaskNoHeatLoss = s.FlaskNoHeatLoss;
        CheatState.FlaskInfiniteVol = s.FlaskInfiniteVol;
        CheatState.FlaskAnyItem = s.FlaskAnyItem;
        CheatState.QuickEvolve = s.QuickEvolve;
        CheatState.InfiniteContainer = s.InfiniteContainer;
        CheatState.FireTemp300 = s.FireTemp300;
        CheatState.FireNeverDie = s.FireNeverDie;
        CheatState.FireMaxBurnHours = s.FireMaxBurnHours;
        CheatState.NoFrostbiteRisk = s.NoFrostbiteRisk;
        CheatState.WellFedBuff = s.WellFedBuff;
        CheatState.FreezingBuff = s.FreezingBuff;
        CheatState.FatigueBuff = s.FatigueBuff;
        CheatState.ClearDeathPenalty = s.ClearDeathPenalty;
        CheatState.QuickFishing = s.QuickFishing;
        CheatState.FireAnywhere = s.FireAnywhere;
        CheatState.FreeFireFuel = s.FreeFireFuel;
        CheatState.TechBackpack = s.TechBackpack;
        CheatState.TorchFullValue = s.TorchFullValue;
        CheatState.InfiniteStamina = s.InfiniteStamina;
        CheatState.MapClickTP = s.MapClickTP;
        CheatState.TraderUnlimitedList = s.TraderUnlimitedList;
        CheatState.TraderMaxTrust = s.TraderMaxTrust;
        CheatState.TraderUnlockModeItems = s.TraderUnlockModeItems;
        CheatState.TraderInstantExchange = s.TraderInstantExchange;
        CheatState.TraderAlwaysAvailable = s.TraderAlwaysAvailable;
        CheatState.CougarInstantActivate = s.CougarInstantActivate;
        CheatState.BlockAutoPickupOwnDrops = s.BlockAutoPickupOwnDrops;
        // ═══ Movement / QoL / Integrated ═══
        CheatState.SilentFootsteps = s.SilentFootsteps;
        CheatState.RunWithLantern = s.RunWithLantern;
        CheatState.NoAutoEquipCharcoal = s.NoAutoEquipCharcoal;
        CheatState.AutoExtinguishOnRest = s.AutoExtinguishOnRest;
        CheatState.DisableTorchLeftClick = s.DisableTorchLeftClick;
        CheatState.DisableLampLeftClick = s.DisableLampLeftClick;
        CheatState.LampMute = s.LampMute;
        // ═══ HouseLights ═══
        CheatState.HL_Enabled = s.HL_Enabled;
        CheatState.HL_EnableOutside = s.HL_EnableOutside;
        CheatState.HL_WhiteLights = s.HL_WhiteLights;
        CheatState.HL_NoFlicker = s.HL_NoFlicker;
        CheatState.HL_CastShadows = s.HL_CastShadows;
        CheatState.HL_LightAudio = s.HL_LightAudio;
        CheatState.HL_Intensity = s.HL_Intensity;
        CheatState.HL_RangeMultiplier = s.HL_RangeMultiplier;
        CheatState.HL_CullDistance = s.HL_CullDistance;
        CheatState.HL_InteractDistance = s.HL_InteractDistance;
        // ═══ QoL Batch 2 ═══
        CheatState.PauseInJournal = s.PauseInJournal;
        CheatState.SkipIntro = s.SkipIntro;
        CheatState.MuteCougarMenuSound = s.MuteCougarMenuSound;
        CheatState.VehicleKeepFov = s.VehicleKeepFov;
        CheatState.DroppableUndroppables = s.DroppableUndroppables;
        CheatState.RememberBreakdownTool = s.RememberBreakdownTool;
        CheatState.VehicleFreeLook = s.VehicleFreeLook;
        // ═══ QoL General ═══
        CheatState.QoL_Enabled = s.QoL_Enabled;
        bool qol = s.QoL_Enabled;   // QoL 总开关管(小改动 / 随地睡 / 自动绘图)三节
        CheatState.QoL_NoSaveOnSprain = qol && s.QoL_NoSaveOnSprain;
        CheatState.QoL_NoSaveOnSprainFalls = qol && s.QoL_NoSaveOnSprainFalls;
        CheatState.QoL_WakeUpCall = qol && s.QoL_WakeUpCall;
        CheatState.QoL_AuroraSense = qol && s.QoL_AuroraSense;
        CheatState.QoL_ShowTimeSleep = qol && s.QoL_ShowTimeSleep;
        CheatState.QoL_NoPitchBlack = qol && s.QoL_NoPitchBlack;
        CheatState.QoL_MapTextOutline = qol && s.QoL_MapTextOutlineEnabled;
        CheatState.QoL_BuryCorpses = qol && s.QoL_BuryCorpses;
        CheatState.QoL_SleepAnywhere = qol && s.QoL_SleepAnywhere;
        CheatState.QoL_AutoSurvey = qol && s.QoL_AutoSurvey;
        // ═══ Crafting & Fire ═══
        CheatState.Craft_Anywhere = s.Craft_Anywhere;
        CheatState.Craft_MoreCookingSlots = s.Craft_MoreCookingSlots;
        // ═══ World & Items ═══
        CheatState.World_Sprainkle = s.World_Sprainkle;
        CheatState.World_BowRepair = s.World_BowRepair;
        CheatState.World_BowRepairDLC = s.World_BowRepairDLC;
        CheatState.World_CaffeinatedSodas = s.World_CaffeinatedSodas;
        CheatState.World_CarcassMoving = s.World_CarcassMoving;
        CheatState.World_CarcassMovingAll = s.World_CarcassMovingAll;
        CheatState.World_ElectricTorch = s.World_ElectricTorch;
        // ═══ TinyTweaks ═══
        CheatState.TT_CapFeelsEnabled = s.TT_CapFeelsEnabled;
        CheatState.TT_FallDeathGoat = s.TT_FallDeathGoat;
        CheatState.TT_DroppedOrientation = s.TT_DroppedOrientation;
        CheatState.TT_ExtendedFOV = s.TT_ExtendedFOV;
        CheatState.TT_PauseOnRadial = s.TT_PauseOnRadial;
        CheatState.TT_RespawnPlants = s.TT_RespawnPlants;
        CheatState.TT_ShowTraderTrust = s.TT_ShowTraderTrust;

        // v7.7 魔法子弹镜像在 CheatStateESP 而不是 CheatState,原先这里没同步 →
        //   「全部关闭」后要等最长 0.5s 的 tick 才真的停。补上,和其他开关一样即时。
        CheatStateESP.MagicBullet = s.MagicBullet;
    }


    // v2.7.57 换实现 —— AddItemCONSOLE 对部分物品(DLC / 特殊)返回 null 无响应(console 守卫)
    //   稳定公开 API:GearItem.LoadGearItemPrefab(name) → PlayerManager.InstantiateItemInPlayerInventory
    //   DLC 物品、特殊物品、release build 都 work
#if STORY_EDITION
    // 2.24 没有 GearItem.LoadGearItemPrefab 也没有 InventoryInstantiateFlags。
    // 它有按名字直接进背包的重载 InstantiateItemInPlayerInventory(name, count, bool),
    // 语义等价且更短,失败再退回 AddItemCONSOLE(name, count)(2.24 只有 2 参)。
    public static void SpawnItem(string prefabName, int quantity)
    {
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) { ModMain.Log?.Warning("[Spawn] PlayerManager not ready"); return; }

            int spawned = 0;
            for (int i = 0; i < quantity; i++)
                try { if (pm.InstantiateItemInPlayerInventory(prefabName, 1, false) != null) spawned++; } catch { }
            if (spawned == 0)
                for (int i = 0; i < quantity; i++)
                    try { if (pm.AddItemCONSOLE(prefabName, 1) != null) spawned++; } catch { }

            if (spawned > 0)
            {
                ModMain.Log?.Msg($"[Spawn] +{spawned} {prefabName}");
                CheatState.LastActionLog = I18n.IsEnglish
                    ? $"Spawned ×{spawned} {prefabName}"
                    : $"已刷 ×{spawned} {prefabName}";
            }
            else
            {
                ModMain.Log?.Error($"[Spawn] prefab not found: {prefabName}");
                CheatState.LastActionLog = I18n.IsEnglish
                    ? $"Spawn failed: {prefabName} (prefab not found)"
                    : $"刷物品失败:{prefabName}(prefab 未找到)";
            }
        }
        catch (Exception ex) { ModMain.Log?.Error($"[Spawn] {ex.Message}"); }
    }
#else
    public static void SpawnItem(string prefabName, int quantity)
    {
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) { ModMain.Log?.Warning("[Spawn] PlayerManager not ready"); return; }

            GearItem prefab = null;
            try { prefab = GearPrefab.Load(prefabName); } catch { }

            if (prefab == null)
            {
                // fallback: loop AddItemCONSOLE one at a time
                int added = 0;
                for (int i = 0; i < quantity; i++)
                {
                    try { if (pm.AddItemCONSOLE(prefabName, 1, 100f) != null) added++; } catch { }
                }
                if (added > 0)
                {
                    ModMain.Log?.Msg($"[Spawn] CONSOLE fallback +{added} {prefabName}");
                    CheatState.LastActionLog = I18n.IsEnglish
                        ? $"Spawned ×{added} {prefabName}"
                        : $"已刷 ×{added} {prefabName}";
                    return;
                }
                ModMain.Log?.Error($"[Spawn] prefab not found: {prefabName}");
                CheatState.LastActionLog = I18n.IsEnglish
                    ? $"Spawn failed: {prefabName} (prefab not found)"
                    : $"刷物品失败:{prefabName}(prefab 未找到)";
                return;
            }

            // loop one at a time — some items silently fail with quantity>1
            int spawned = 0;
            for (int i = 0; i < quantity; i++)
            {
                try
                {
                    pm.InstantiateItemInPlayerInventory(prefab, 1, 100f, PlayerManager.InventoryInstantiateFlags.None);
                    spawned++;
                }
                catch { }
            }
            if (spawned > 0)
            {
                ModMain.Log?.Msg($"[Spawn] +{spawned} {prefabName}");
                CheatState.LastActionLog = I18n.IsEnglish
                    ? $"Spawned ×{spawned} {prefabName}"
                    : $"已刷 ×{spawned} {prefabName}";
            }
            else
            {
                ModMain.Log?.Error($"[Spawn] InstantiateItem failed for {prefabName}");
                // last resort CONSOLE fallback
                for (int i = 0; i < quantity; i++)
                    try { pm.AddItemCONSOLE(prefabName, 1, 100f); } catch { }
            }
        }
        catch (Exception ex) { ModMain.Log?.Error($"[Spawn] {ex.Message}"); }
    }
#endif

    public static void ClearAllAfflictions()
    {
        // v6.7.1 修:整合包里有第三方 Cold/Sickness mod 把 vanilla End 方法当 Postfix 触发"并发症 roll"
        //   一口气清完 → 触发 N 次"治愈后并发症"判定 → 反被加上"感冒/Influenza"
        // 防御:全程设旗 + 排队 5s 内每帧再扫一次 → 第三方 mod 加上的也会被立即清掉
        CheatState.AfflictionClearInProgress = true;
        try
        {
            ClearAllAfflictionsInternal();
        }
        finally
        {
            CheatState.AfflictionClearInProgress = false;
            // 让 OnUpdate 接下来 ~5 秒(60fps × 5 = 300 帧)持续二次扫
            // 三方 Postfix 通常会在 vanilla End 返回后立刻 / 隔几 tick 内补 affliction —— 这个窗口足够大
            CheatState.AfflictionClearReSweepFramesLeft = 300;
        }
    }

    // v6.7.1 抽出本体,供 OnUpdate 二次清扫复用(共用同一套 component-by-component 逻辑)
    public static void ClearAllAfflictionsInternal()
    {
        int cleared = 0;
        var log = new System.Text.StringBuilder();
        // v2.7.11:放弃依赖 End() —— 许多 End 方法要求"满足治愈条件"才真正清除。
        // 直接用 wrapper 类型 setter 强置内部状态为 default,外加 End() 走一遍音效/UI 刷新。

        // —— Hypothermia ——
        // v6.9.2: HypothermiaEnd 仅在 had=true 时调,避免 ReSweep 5s 窗口内反复 trigger 第三方 Postfix
        // (CatchColdMod 等 mod 在 HypothermiaEnd Postfix 里 schedule ApplyCold() → ColdPhase++ → ≥3 升级肺炎)
        try { var c = GameManager.GetHypothermiaComponent(); if (c != null) {
            bool had = c.HasHypothermia();
            try { c.m_Active = false; } catch { }
            try { c.m_ElapsedHours = 0f; } catch { }
            try { c.m_ElapsedWarmTime = 0f; } catch { }
            try { c.m_StartHasBeenCalled = false; } catch { }
            if (had) {
                try { c.m_SuppressHypothermia = true; c.HypothermiaEnd(true); c.m_SuppressHypothermia = false; } catch { }
                cleared++; log.Append(I18n.T("低温; ", "Hypothermia; "));
            }
        }} catch (Exception ex) { log.Append(I18n.T($"低温-err:{ex.Message}; ", $"Hypothermia-err:{ex.Message}; ")); }

        // —— Frostbite ——
        try { var c = GameManager.GetFrostbiteComponent(); if (c != null) {
            bool had = c.HasFrostbite();
            try { c.FrostbiteEnd(); } catch { }
            try { c.m_SuppressFrostbite = true; } catch { }
            if (had) { cleared++; log.Append(I18n.T("冻伤; ", "Frostbite; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"冻伤-err:{ex.Message}; ", $"Frostbite-err:{ex.Message}; ")); }

        // —— CabinFever ——
        try { var c = GameManager.GetCabinFeverComponent(); if (c != null) {
            bool had = c.HasCabinFever();
            try { c.m_Active = false; } catch { }
            try { c.CabinFeverEnd(); c.ClearCabinFeverRisk(); } catch { }
            if (had) { cleared++; log.Append(I18n.T("幽闭症; ", "Cabin Fever; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"幽闭症-err:{ex.Message}; ", $"CabinFever-err:{ex.Message}; ")); }

        // —— Dysentery ——
        try { var c = GameManager.GetDysenteryComponent(); if (c != null) {
            bool had = c.HasDysentery();
            try { c.m_Active = false; } catch { }
            try { c.DysenteryEnd(true); } catch { }
            if (had) { cleared++; log.Append(I18n.T("痢疾; ", "Dysentery; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"痢疾-err:{ex.Message}; ", $"Dysentery-err:{ex.Message}; ")); }

        // —— FoodPoisoning ——
        try { var c = GameManager.GetFoodPoisoningComponent(); if (c != null) {
            bool had = c.HasFoodPoisoning();
            try { c.m_Active = false; } catch { }
            try { c.FoodPoisoningEnd(true); } catch { }
            if (had) { cleared++; log.Append(I18n.T("食物中毒; ", "Food Poisoning; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"食物中毒-err:{ex.Message}; ", $"FoodPoisoning-err:{ex.Message}; ")); }

        // —— SprainedWrist / Ankle ——
        try { var c = GameManager.GetSprainedWristComponent(); if (c != null) {
            bool had = c.HasSprainedWrist();
            // 不再 SetForceNoSprainWrist(true):这个标记写进存档且没人复位,点一次清除就永远不会扭伤手腕。
            //   防扭伤 / 防坠落开关的强制关闭统一由 ExtraOneShot.TickSprainRisk 管。
            // 没 Active 字段,直接 End(0)
            try { c.SprainedWristEnd(0, (AfflictionOptions)0); } catch { }
            try { c.SprainedWristEnd(1, (AfflictionOptions)0); } catch { } // 另一只手
            if (had) { cleared++; log.Append(I18n.T("扭腕; ", "Sprained Wrist; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"扭腕-err:{ex.Message}; ", $"Wrist-err:{ex.Message}; ")); }

        try { var c = GameManager.GetSprainedAnkleComponent(); if (c != null) {
            bool had = c.HasSprainedAnkle();
            try { c.SprainedAnkleEnd(0, (AfflictionOptions)0); } catch { }
            try { c.SprainedAnkleEnd(1, (AfflictionOptions)0); } catch { }
            if (had) { cleared++; log.Append(I18n.T("扭踝; ", "Sprained Ankle; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"扭踝-err:{ex.Message}; ", $"Ankle-err:{ex.Message}; ")); }

#if !STORY_EDITION
        // —— SevereLacerations (严重撕裂伤,美洲虎扑击) —— v9.6 新增;放在出血前,Cure 后残留伤口由下面出血清理兜底
        // 伤口(ApplyWound / ApplyChestWound)可能单独挂着,HasAffliction 看不到,两样都查
        try { var c = GameManager.GetSevereLacerations(); if (c != null) {
            bool had = c.HasAffliction() || c.HaveAnyActiveWounds();
            if (had) {
                try { c.Cure((AfflictionOptions)0); } catch { }
                cleared++; log.Append(I18n.T("严重撕裂伤; ", "Severe Lacerations; "));
            }
        }} catch (Exception ex) { log.Append(I18n.T($"严重撕裂伤-err:{ex.Message}; ", $"Lacerations-err:{ex.Message}; ")); }

        // —— 欺骗死亡(自定义难度死后复活留下的负面)——
        try { var c = GameManager.GetCheatDeathAffliction(); if (c != null && c.HasAffliction) {
            try { c.Cure((AfflictionOptions)0); } catch { }
            cleared++; log.Append(I18n.T("欺骗死亡; ", "Cheat Death; "));
        }} catch (Exception ex) { log.Append(I18n.T($"欺骗死亡-err:{ex.Message}; ", $"CheatDeath-err:{ex.Message}; ")); }
#endif

        // —— BloodLoss ——
        try { var c = GameManager.GetBloodLossComponent(); if (c != null) {
            bool had = c.HasBloodLoss();
            // 对每个身体部位都 End
            for (int i = 0; i < 6; i++) try { c.BloodLossEnd(i, (AfflictionOptions)0); } catch { }
            if (had) { cleared++; log.Append(I18n.T("出血; ", "Blood Loss; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"出血-err:{ex.Message}; ", $"BloodLoss-err:{ex.Message}; ")); }

        // —— Infection ——
        try { var c = GameManager.GetInfectionComponent(); if (c != null) {
            bool had = c.HasInfection();
            for (int i = 0; i < 6; i++) try { c.InfectionEnd(i); } catch { }
            if (had) { cleared++; log.Append(I18n.T("感染; ", "Infection; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"感染-err:{ex.Message}; ", $"Infection-err:{ex.Message}; ")); }

        // —— BrokenRib ——
        try { var c = GameManager.GetBrokenRibComponent(); if (c != null) {
            bool had = c.HasBrokenRib();
            for (int i = 0; i < 6; i++) try { c.BrokenRibEnd(i, true); } catch { }
            if (had) { cleared++; log.Append(I18n.T("骨折; ", "Broken Rib; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"骨折-err:{ex.Message}; ", $"BrokenRib-err:{ex.Message}; ")); }

        // —— SprainPain (扭伤疼痛 / "疼痛"主来源) —— v2.7.21 新增
        try { var c = GameManager.GetSprainPainComponent(); if (c != null) {
            bool had = c.HasSprainPain();
            try { c.Cure(); } catch { }
            if (had) { cleared++; log.Append(I18n.T("疼痛; ", "Pain; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"疼痛-err:{ex.Message}; ", $"Pain-err:{ex.Message}; ")); }

        // —— Headache (头痛) —— v2.7.21 新增
        try { var c = GameManager.GetHeadacheComponent(); if (c != null) {
            bool had = c.HasHeadache();
            try { c.Cure(); } catch { }
            if (had) { cleared++; log.Append(I18n.T("头痛; ", "Headache; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"头痛-err:{ex.Message}; ", $"Headache-err:{ex.Message}; ")); }

        // —— Burns (烧伤) —— v2.7.21 新增
        try { var c = GameManager.GetBurnsComponent(); if (c != null) {
            bool had = c.HasBurns();
            try { c.m_Active = false; } catch { }
            try { c.BurnsEnd(true); } catch { }
            if (had) { cleared++; log.Append(I18n.T("烧伤; ", "Burns; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"烧伤-err:{ex.Message}; ", $"Burns-err:{ex.Message}; ")); }

        // —— IntestinalParasites (肠寄生虫) —— v2.7.21 新增
        try { var c = GameManager.GetIntestinalParasitesComponent(); if (c != null) {
            bool had = c.HasIntestinalParasites();
            try { c.m_HasParasites = false; c.m_HasParasiteRisk = false; } catch { }
            try { c.IntestinalParasitesEnd(true); } catch { }
            if (had) { cleared++; log.Append(I18n.T("肠寄生虫; ", "Intestinal Parasites; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"肠寄生虫-err:{ex.Message}; ", $"Parasites-err:{ex.Message}; ")); }

#if !STORY_EDITION
        // —— Scurvy (坏血病) —— v3.0.7 新增,Cure() 同时清 affliction + risk
        // 2.24 无坏血病系统(GameManager.GetScurvyComponent 不存在)
        try { var c = GameManager.GetScurvyComponent(); if (c != null) {
            bool had = false;
            try { had = c.HasAffliction() || c.HasRisk(); } catch { }
            try { c.Cure(); } catch { }
            if (had) { cleared++; log.Append(I18n.T("坏血病; ", "Scurvy; ")); }
        }} catch (Exception ex) { log.Append(I18n.T($"坏血病-err:{ex.Message}; ", $"Scurvy-err:{ex.Message}; ")); }
#endif

        // v9.6 新增:以下几项之前清单里没有。毒雾/窒息/恐惧这类环境触发的,人还在原地会被游戏重新挂上,ReSweep 窗口内会再清
        try { var c = GameManager.GetBurnsElectricComponent(); if (c != null && c.HasBurnsElectric()) {
#if STORY_EDITION
            try { c.BurnsElectricEnd(); } catch { }
#else
            try { c.BurnsElectricEnd(true); } catch { }
#endif
            cleared++; log.Append(I18n.T("电击烧伤; ", "Electric Burns; "));
        }} catch (Exception ex) { log.Append(I18n.T($"电击烧伤-err:{ex.Message}; ", $"BurnsElectric-err:{ex.Message}; ")); }

#if !STORY_EDITION
        // 2.24 没有化学中毒和失眠
        try { var c = GameManager.GetChemicalPoisoningComponent(); if (c != null) {
            bool had = false;
            try { had = c.HasAffliction() || c.HasRisk(); } catch { }
            if (had) {
                try { c.CureAll(); } catch { }
                cleared++; log.Append(I18n.T("化学中毒; ", "Chemical Poisoning; "));
            }
        }} catch (Exception ex) { log.Append(I18n.T($"化学中毒-err:{ex.Message}; ", $"ChemPoison-err:{ex.Message}; ")); }

        try { var c = GameManager.GetInsomniaComponent(); if (c != null) {
            bool had = false;
            try { had = c.HasInsomniaAffliction() || c.HasInsomniaRisk(); } catch { }
            if (had) {
                try { c.RemoveInsomniaAll(); } catch { }
                cleared++; log.Append(I18n.T("失眠; ", "Insomnia; "));
            }
        }} catch (Exception ex) { log.Append(I18n.T($"失眠-err:{ex.Message}; ", $"Insomnia-err:{ex.Message}; ")); }
#endif

#if !STORY_EDITION
        CeX.CureMisery(log, ref cleared);
#endif

        try { var c = GameManager.GetThirstComponent(); if (c != null && c.IsDehydrated()) {
            try { c.m_CurrentThirst = 0f; } catch { }
            cleared++; log.Append(I18n.T("脱水; ", "Dehydration; "));
        }} catch (Exception ex) { log.Append(I18n.T($"脱水-err:{ex.Message}; ", $"Dehydration-err:{ex.Message}; ")); }

        try { var c = GameManager.GetAnxietyComponent(); if (c != null && c.HasAffliction()) {
            try { c.StopAffliction(true); } catch { }
            cleared++; log.Append(I18n.T("焦虑; ", "Anxiety; "));
        }} catch (Exception ex) { log.Append(I18n.T($"焦虑-err:{ex.Message}; ", $"Anxiety-err:{ex.Message}; ")); }

        try { var c = GameManager.GetFearComponent(); if (c != null && c.HasAffliction()) {
            try { c.StopAffliction(true); } catch { }
            cleared++; log.Append(I18n.T("恐惧; ", "Fear; "));
        }} catch (Exception ex) { log.Append(I18n.T($"恐惧-err:{ex.Message}; ", $"Fear-err:{ex.Message}; ")); }

        try { var c = GameManager.GetToxicFogComponent(); if (c != null && c.HasAffliction()) {
            try { c.StopAffliction(); } catch { }
            cleared++; log.Append(I18n.T("毒雾; ", "Toxic Fog; "));
        }} catch (Exception ex) { log.Append(I18n.T($"毒雾-err:{ex.Message}; ", $"ToxicFog-err:{ex.Message}; ")); }

        try { var c = GameManager.GetSuffocatingComponent(); if (c != null && c.IsSuffocating()) {
            try { c.ForceStopSuffocating(true); } catch { }
            cleared++; log.Append(I18n.T("窒息; ", "Suffocating; "));
        }} catch (Exception ex) { log.Append(I18n.T($"窒息-err:{ex.Message}; ", $"Suffocating-err:{ex.Message}; ")); }

        try { var c = GameManager.GetInfectionRiskComponent(); if (c != null && c.HasInfectionRisk()) {
            try { c.Cure(); } catch { }
            cleared++; log.Append(I18n.T("感染风险; ", "Infection Risk; "));
        }} catch (Exception ex) { log.Append(I18n.T($"感染风险-err:{ex.Message}; ", $"InfectionRisk-err:{ex.Message}; ")); }

        // —— 第三方 mod 通过 AfflictionComponent 框架追加的 CustomAffliction —— v6.9.1 新增
        // 用户报告:OxygenLevels(高原反应)、Minor Miseries、TLDev(肺炎)等用 AfflictionComponent 框架挂在
        // AfflictionManager.m_Afflictions[],vanilla End()/Cure() 路径碰不到 → 清完仍残留
        // 修法:全反射动态找 AfflictionManager(用户没装 AfflictionComponent 框架自动跳过,zero coupling)
        try
        {
            Type afmType = null;
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                afmType = asm.GetType("AfflictionComponent.Components.AfflictionManager")
                        ?? asm.GetType("AfflictionComponent.AfflictionManager")
                        ?? asm.GetType("AfflictionManager");
                if (afmType != null) break;
            }
            if (afmType != null)
            {
                var getInstance = afmType.GetMethod("GetAfflictionManagerInstance", BindingFlags.Public | BindingFlags.Static);
                var afm = getInstance?.Invoke(null, null);
                if (afm != null)
                {
                    var listField = afm.GetType().GetField("m_Afflictions");
                    if (listField != null)
                    {
                        var list = listField.GetValue(afm);
                        if (list != null)
                        {
                            var listType = list.GetType();
                            var countProp = listType.GetProperty("Count");
                            var indexer = listType.GetProperty("Item");
                            if (countProp != null && indexer != null)
                            {
                                int n = (int)countProp.GetValue(list);
                                // 倒序避免 Cure 时集合修改导致索引偏移
                                for (int i = n - 1; i >= 0; i--)
                                {
                                    try
                                    {
                                        var ca = indexer.GetValue(list, new object[] { i });
                                        if (ca == null) continue;
                                        string typeName = ca.GetType().Name;
                                        var cureMethod = ca.GetType().GetMethod("Cure", new[] { typeof(bool) });
                                        if (cureMethod != null)
                                        {
                                            cureMethod.Invoke(ca, new object[] { true });
                                            cleared++;
                                            log.Append($"{typeName}; ");
                                        }
                                    }
                                    catch (Exception exItem) { log.Append(I18n.T($"模组负面项-err:{exItem.Message}; ", $"ModItem-err:{exItem.Message}; ")); }
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex) { log.Append(I18n.T($"模组负面扫-err:{ex.Message}; ", $"ModAfflictionScan-err:{ex.Message}; ")); }

        // v6.7.1: 二次扫(AfflictionClearInProgress=false 时调用)只在真清掉东西时输出,避免覆盖首次 summary
        if (CheatState.AfflictionClearInProgress)
        {
            string summary = cleared > 0
                ? (I18n.IsEnglish ? $"Cleared {cleared} afflictions: {log}" : $"已清 {cleared} 项: {log}")
                : (I18n.IsEnglish ? $"No active affliction; tried: {log}" : $"未检测到活跃负面; 尝试过: {log}");
            ModMain.Log?.Msg($"[Cheats] {summary}");
            CheatState.LastActionLog = summary;
        }
        else if (cleared > 0)
        {
            // 二次扫真的捞到了 → 说明三方 mod 反补了 buff,记一行
            string extra = I18n.IsEnglish
                ? $"[ReSweep] Caught {cleared} re-added: {log}"
                : $"[二次扫] 抓到 {cleared} 个反补: {log}";
            ModMain.Log?.Msg($"[Cheats] {extra}");
            CheatState.LastActionLog = extra;
        }
    }

    // 真正切天气:直接调 GameManager.GetWeatherTransitionComponent()
    public static void SetWeatherStage(int stage)
    {
        try
        {
            var wt = GameManager.GetWeatherTransitionComponent();
            if (wt == null)
            {
                ModMain.Log?.Warning("[Weather] WeatherTransition not found");
                CheatState.LastActionLog = I18n.IsEnglish
                    ? "[Weather] No WeatherTransition found"
                    : "[Weather] 没找到 WeatherTransition";
                return;
            }

            WeatherStage stageEnum = (WeatherStage)stage;
            // 暴风雪:清除 suppress 标志,否则某些难度下会被静默拦截
            if (stageEnum == WeatherStage.Blizzard)
                WeatherTransition.m_SuppressBlizzards = false;
            wt.ActivateWeatherSetImmediate(stageEnum);
            CheatState.WeatherLocked = true;
            CheatState.WeatherLockedStage = stage;
            ModMain.Log?.Msg($"[Weather] ActivateWeatherSetImmediate({stageEnum}) + locked");
            CheatState.LastActionLog = $"[Weather] → {stageEnum} (locked)";
        }
        catch (Exception ex) { ModMain.Log?.Error($"[Weather] {ex.Message}"); }
    }

    // tick 用:静默刷新天气(不改 Locked 状态,不输出日志)
    public static void SetWeatherStageInternal(int stage)
    {
        try
        {
            // 已经是锁定的那档就不重建天气组。原先每秒无条件 ActivateWeatherSetImmediate 一次,雾、粒子、风声每秒跳一下
            var w = GameManager.GetWeatherComponent();
            if (w != null && (int)w.GetWeatherStage() == stage) return;
            var wt = GameManager.GetWeatherTransitionComponent();
            if (wt == null) return;
            WeatherStage stageEnum = (WeatherStage)stage;
            if (stageEnum == WeatherStage.Blizzard)
                WeatherTransition.m_SuppressBlizzards = false;
            wt.ActivateWeatherSetImmediate(stageEnum);
        }
        catch { }
    }

    public static void SetTimeOfDay(float hour)
    {
        try
        {
            var tod = GameManager.GetTimeOfDayComponent();
            if (tod == null) { ModMain.Log?.Error("[Cheats.Time] ToD null"); return; }
            float norm = Mathf.Clamp01(hour / 24f);
            var m1 = tod.GetType().GetMethod("SetNormalizedTime", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(float) }, null);
            if (m1 != null) { m1.Invoke(tod, new object[] { norm }); }
            else
            {
                var m2 = tod.GetType().GetMethod("SetNormalizedTime", BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(float), typeof(bool) }, null);
                if (m2 == null) { ModMain.Log?.Error("[Cheats.Time] no SetNormalizedTime"); return; }
                m2.Invoke(tod, new object[] { norm, false });
            }
            ModMain.Log?.Msg($"[Cheats] Time → {hour:F1}h");
        }
        catch (Exception ex) { ModMain.Log?.Error($"[Cheats.Time] {ex.Message}"); }
    }

    // 每 300 帧扫一次 GearItem 刷耐久(需要 InfiniteDurability toggle on 才走 tick)
    // 手动按钮不调这个,改调 RestoreAllSceneGear 并记录 count 到 LastActionLog
    public static void TickInfiniteDurability()
    {
        try
        {
            // v2.7.93 改用注册表,避免每 5s FindObjectsOfType<GearItem> 大地图 spike
            var gears = GearItemRegistry.Known;
            foreach (var g in gears) { if (g != null) RestoreDurability(g); }
        }
        catch { }
    }

    // 手动按钮:恢复场景所有 GearItem + 背包内所有 + 结果写 LastActionLog
    public static void RestoreAllSceneGear()
    {
        int scene = 0, bag = 0, fail = 0;
        try
        {
            var gears = UnityEngine.Object.FindObjectsOfType<GearItem>();
            if (gears != null)
                foreach (var g in gears) { if (RestoreDurability(g)) scene++; else fail++; }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[RestoreAll.Scene] {ex.Message}"); }

        try
        {
            var inv = GameManager.m_Inventory;
            if (inv?.m_Items != null)
            {
                for (int i = 0; i < inv.m_Items.Count; i++)
                {
                    try
                    {
                        var obj = inv.m_Items[i];
                        if (obj == null) continue;
                        var gi = obj.m_GearItem;
                        if (gi != null) { if (RestoreDurability(gi)) bag++; else fail++; }
                    }
                    catch { fail++; }
                }
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[RestoreAll.Bag] {ex.Message}"); }

        string msg = I18n.IsEnglish
            ? $"Restored scene {scene} + bag {bag} to full (failed {fail})"
            : $"场景 {scene} 件 + 背包 {bag} 件 恢复满 (失败 {fail})";
        CheatState.LastActionLog = msg;
        ModMain.Log?.Msg($"[RestoreAll] {msg}");
    }

    // v2.7.14:用游戏官方 SetNormalizedHP(1f) 替代直接写 m_CurrentHP —— 更可靠
    internal static bool RestoreDurability(GearItem gear)
    {
        if (gear == null) return false;
        try
        {
            gear.SetNormalizedHP(1f, true);
            return true;
        }
        catch { }
        // fallback 直接字段 —— 钳到该物品自身 MaxHP(衣物 MaxHP 常<100,直接写 100f 会显示 >100%)
        try
        {
            float maxHp = 100f;
#if STORY_EDITION
            // 2.24 无 GearItemData,MaxHP 直接挂在 GearItem 上
            try { maxHp = gear.m_MaxHP; } catch { }
#else
            try { var d = gear.GearItemData; if (d != null) maxHp = d.MaxHP; } catch { }
#endif
            gear.m_CurrentHP = maxHp;
            return true;
        }
        catch { }
        return false;
    }

    // 修复玩家当前手持物品 —— 一键
    public static void RepairItemInHands()
    {
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) { CheatState.LastActionLog = I18n.IsEnglish ? "[Repair] no PM" : "[修复手持] no PM"; return; }
            var item = pm.m_ItemInHands;
            if (item == null) { CheatState.LastActionLog = I18n.IsEnglish ? "[Repair] Nothing in hands" : "[修复手持] 手上没东西"; return; }
            bool ok = RestoreDurability(item);
            CheatState.LastActionLog = ok
                ? (I18n.IsEnglish ? $"[Repair] {item.name} → 100%" : $"[修复手持] {item.name} → 100%")
                : (I18n.IsEnglish ? $"[Repair failed] {item.name}" : $"[修复手持失败] {item.name}");
            ModMain.Log?.Msg($"[Repair.Hands] {item.name} ok={ok}");
        }
        catch (Exception ex)
        {
            CheatState.LastActionLog = I18n.IsEnglish
                ? $"[Repair error] {ex.Message}"
                : $"[修复手持异常] {ex.Message}";
            ModMain.Log?.Warning($"[Repair.Hands] {ex.Message}");
        }
    }

    // v2.7.29 删:RestoreClothingDurability 无调用点且反射 GetField 对 Il2Cpp property 无效

    // 扫场景所有 BaseAi 实例直接调 DebugKill / ApplyDamage —— 比 SendMessage 可靠
    public static void ScanAndKillAnimals()
    {
        try
        {
            var ais = UnityEngine.Object.FindObjectsOfType<BaseAi>();
            if (ais == null) return;
            int kills = 0;
            foreach (var ai in ais)
            {
                if (ai == null) continue;
                try
                {
                    // v2.7.29:BaseAi 是 Il2Cpp MonoBehaviour,直接 .gameObject 访问即可(避免 (Component) 转型在 Il2CppInterop 下抛 InvalidCastException)
                    var go = ai.gameObject;
                    if (go == null || !go.activeInHierarchy) continue;
                    // 优先 DebugKill(一步到位),失败了 fallback 到 ApplyDamage 9999
                    bool killed = false;
#if !STORY_EDITION
                    // 2.24 无 BaseAi.DebugKill,直接走下面的 ApplyDamage
                    try { ai.DebugKill(); killed = true; } catch { }
#endif
                    if (!killed)
                    {
                        try { ai.ApplyDamage(9999f, 0f, DamageSource.Player, ""); killed = true; } catch { }
                    }
                    if (!killed)
                    {
                        try { ai.EnterDead(); killed = true; } catch { }
                    }
                    if (killed) kills++;
                    if (kills > 30) break;
                }
                catch { }
            }
            if (kills > 0) ModMain.Log?.Msg($"[Cheats.Kill] killed {kills}");
            CheatState.LastActionLog = I18n.IsEnglish ? $"Killed {kills}" : $"已击杀 {kills} 只";
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[Cheats.Kill] {ex.Message}"); }
    }

    public static void RevealFullMap()
    {
        ConsoleBridge.Run("map_reveal");
        CheatState.LastActionLog = I18n.IsEnglish ? "Map revealed" : "地图已全开";
    }

#if !STORY_EDITION
    // 死后余生的"火堆"= TotalLives(m_Tunables.m_AvailableLives) - LivesUsed;
    // LivesUsed 只有 getter,实际读 m_LifeAfterDeathState.m_LivesUsed,随存档序列化
    public static void RestoreLives()
    {
        try
        {
            var mgr = GameManager.m_LifeAfterDeathManager;
            var state = mgr?.m_LifeAfterDeathState;
            if (mgr == null || state == null || !mgr.IsSystemEnabled)
            {
                CheatState.LastActionLog = I18n.T("当前模式没有火堆(死后余生)机制", "This mode has no campfire lives");
                return;
            }
            int total = mgr.TotalLives;
            int before = total - state.m_LivesUsed;
            state.m_LivesUsed = 0;
            CheatState.LastActionLog = I18n.T($"火堆已恢复 {before}/{total} → {total}/{total}",
                $"Campfires restored {before}/{total} → {total}/{total}");
        }
        catch (Exception ex)
        {
            CheatState.LastActionLog = I18n.T("恢复火堆失败(见日志)", "Restore campfires failed (see log)");
            ModMain.Log?.Warning($"[RestoreLives] {ex}");
        }
    }
#endif

    public static void ClearWellFedBuff()
    {
        try
        {
            var wf = GameManager.GetWellFedComponent();
            if (wf != null) wf.m_Active = false;
        }
        catch { }
    }

    public static void ClearFatigueBuff()
    {
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm != null) pm.m_FatigueBuffHoursRemaining = 0f;
        }
        catch { }
    }

    // 玩家位置,每 10 帧更新。PositionText 给 Menu 显示用
    // v2.7.29:去反射,直接调强类型 GameManager.GetPlayerTransform()
    //   之前反射 pm.GetType().GetMethod("GetControlledGameObject") 对 Il2Cpp wrapper 抛 NotSupportedException
    public static void UpdatePlayerPosition()
    {
        try
        {
            var tr = GameManager.GetPlayerTransform();
            if (tr != null)
            {
                var p = tr.position;
                CheatState.PositionText = $"X:{p.x:F1}  Y:{p.y:F1}  Z:{p.z:F1}";
            }
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[UpdatePos] {ex.Message}"); }
    }

    // v2.7.55:在当前场景写一条 POS-MARK 到 Latest.log —— 用于采集传送坐标
    //   mod 作者事后 grep `\[POS-MARK\]` 就能拿到场景名 + 精确坐标
    public static void PrintPositionToLog()
    {
        try
        {
            var tr = GameManager.GetPlayerTransform();
            if (tr == null) { ModMain.Log?.Warning("[POS-MARK] player transform null"); return; }
            var p = tr.position;
            string scene = "?";
            try { scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name; } catch { }
            ModMain.Log?.Msg($"[POS-MARK] Scene={scene} X={p.x:F2} Y={p.y:F2} Z={p.z:F2}");
            CheatState.PositionText = $"X:{p.x:F1}  Y:{p.y:F1}  Z:{p.z:F1}";
            CheatState.LastActionLog = $"POS-MARK {scene} ({p.x:F1},{p.y:F1},{p.z:F1})";
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[POS-MARK] {ex.Message}"); }
    }
}

// —————————————— Harmony patches ——————————————

// v2.7.25 FPS 修:删了 Condition/Fatigue/Hunger/Thirst/Freezing 的每帧 Update Postfix
// 这些本是主要 FPS 杀手 —— 每帧 5 次 Harmony detour(native→managed→native 跳转)
// 现在改成 TickStats() 每 60 帧(1s)统一 tick 写一次字段,配合 Condition.AddHealth Prefix 拦负 HP 无遗漏
// 保留 Hunger.UpdateCalorieReserves Prefix(低频方法)和 PlayerManager.MaybeFlushPlayerDamage 等

// v2.7.62 删除 Patch_Hunger_UpdateCalorieReserves 的 Prefix return false —— 会让整个 Hunger 循环
//   跳过,吃东西的 AddCalorieReserve 累加、UI 显示都受影响。改走 TickStatus 压值方案(见 TickStatus)

[HarmonyPatch(typeof(PlayerManager), "MaybeFlushPlayerDamage")]
internal static class Patch_PM_FlushDamage
{
    private static bool Prefix() => !CheatState.GodMode;
}

[HarmonyPatch(typeof(Hypothermia), "HypothermiaStart")]
internal static class Patch_Hypothermia_Start
{
    private static bool Prefix() => !(CheatState.GodMode || CheatState.AlwaysWarm);

    // v6.9.1 IL2CPP double-insurance
    private static void Postfix(Hypothermia __instance)
    {
        if (!(CheatState.GodMode || CheatState.AlwaysWarm)) return;
        try
        {
            if (__instance.HasHypothermia())
            {
                __instance.HypothermiaEnd();
                ModMain.Log?.Msg("[AfflictionGuard] Hypothermia started despite Prefix block — cleared via Postfix");
            }
        }
        catch { }
    }
}

[HarmonyPatch(typeof(SprainedWrist), "SprainedWristStart")]
internal static class Patch_SprainedWrist_Start
{
    private static bool Prefix() => !(CheatState.GodMode || CheatState.NoSprainRisk || CheatState.NoFallDamage);
}

[HarmonyPatch(typeof(SprainedAnkle), "SprainedAnkleStart")]
internal static class Patch_SprainedAnkle_Start
{
    private static bool Prefix() => !(CheatState.GodMode || CheatState.NoSprainRisk || CheatState.NoFallDamage);
}

[HarmonyPatch(typeof(BloodLoss), "BloodLossStart")]
internal static class Patch_BloodLoss_Start
{
    private static bool Prefix() => !(CheatState.GodMode || CheatState.ImmuneAnimalDamage);

    // v6.9.1 IL2CPP double-insurance: Prefix return false is unreliable on IL2CPP (same pattern as sprains)
    // If blood loss started despite the Prefix block, immediately end it to prevent game state corruption
    private static void Postfix(BloodLoss __instance)
    {
        if (!(CheatState.GodMode || CheatState.ImmuneAnimalDamage)) return;
        try
        {
            if (__instance.HasBloodLoss())
            {
                for (int i = 0; i < 6; i++)
                    try { __instance.BloodLossEnd(i, (AfflictionOptions)0); } catch { }
                ModMain.Log?.Msg("[AfflictionGuard] BloodLoss started despite Prefix block — cleared via Postfix");
            }
        }
        catch { }
    }
}

[HarmonyPatch(typeof(BloodLoss), "BloodLossStartOverrideArea")]
internal static class Patch_BloodLoss_StartOverride
{
    private static bool Prefix() => !(CheatState.GodMode || CheatState.ImmuneAnimalDamage);

    private static void Postfix(BloodLoss __instance)
    {
        if (!(CheatState.GodMode || CheatState.ImmuneAnimalDamage)) return;
        try
        {
            if (__instance.HasBloodLoss())
            {
                for (int i = 0; i < 6; i++)
                    try { __instance.BloodLossEnd(i, (AfflictionOptions)0); } catch { }
                ModMain.Log?.Msg("[AfflictionGuard] BloodLoss(Override) started despite Prefix block — cleared via Postfix");
            }
        }
        catch { }
    }
}

[HarmonyPatch(typeof(Infection), "InfectionStart")]
internal static class Patch_Infection_Start
{
    private static bool Prefix() => !CheatState.GodMode;

    private static void Postfix(Infection __instance)
    {
        if (!CheatState.GodMode) return;
        try
        {
            if (__instance.HasInfection())
            {
                for (int i = 0; i < 6; i++)
                    try { __instance.InfectionEnd(i); } catch { }
                ModMain.Log?.Msg("[AfflictionGuard] Infection started despite Prefix block — cleared via Postfix");
            }
        }
        catch { }
    }
}

// v6.9.5 诊断:记录谁调了 affliction End — 用于定位 "auto-cure bug" 的真正来源
// 开启方法:菜单里勾 "诊断:Affliction日志",然后触发 bug 后看 MelonLoader/Latest.log
[HarmonyPatch(typeof(BloodLoss), "BloodLossEnd")]
internal static class Patch_BloodLossEnd_Diag
{
    // v6.9.6 修:原参数名 localIndex 不存在(真实签名 BloodLossEnd(int index,...)),
    //   Harmony 按名注入失败 → IL Compile Error → patch 每次启动报错且永不生效。
    //   改用位置参数 __0,绕过 IL2Cpp 名称匹配。
    private static void Prefix(int __0)
    {
        if (!CheatState.DiagAfflictionLog) return;
        var st = new System.Diagnostics.StackTrace(2, false);
        ModMain.Log?.Warning($"[AfflictionDiag] BloodLossEnd(loc={__0}) called! Stack:\n{st}");
    }
}

[HarmonyPatch(typeof(Hypothermia), "HypothermiaEnd")]
internal static class Patch_HypothermiaEnd_Diag
{
    private static void Prefix()
    {
        if (!CheatState.DiagAfflictionLog) return;
        var st = new System.Diagnostics.StackTrace(2, false);
        ModMain.Log?.Warning($"[AfflictionDiag] HypothermiaEnd called! Stack:\n{st}");
    }
}

[HarmonyPatch(typeof(Infection), "InfectionEnd")]
internal static class Patch_InfectionEnd_Diag
{
    private static void Prefix()
    {
        if (!CheatState.DiagAfflictionLog) return;
        var st = new System.Diagnostics.StackTrace(2, false);
        ModMain.Log?.Warning($"[AfflictionDiag] InfectionEnd called! Stack:\n{st}");
    }
}

[HarmonyPatch(typeof(FoodPoisoning), "FoodPoisoningEnd")]
internal static class Patch_FoodPoisoningEnd_Diag
{
    private static void Prefix()
    {
        if (!CheatState.DiagAfflictionLog) return;
        var st = new System.Diagnostics.StackTrace(2, false);
        ModMain.Log?.Warning($"[AfflictionDiag] FoodPoisoningEnd called! Stack:\n{st}");
    }
}

[HarmonyPatch(typeof(Dysentery), "DysenteryEnd")]
internal static class Patch_DysenteryEnd_Diag
{
    private static void Prefix()
    {
        if (!CheatState.DiagAfflictionLog) return;
        var st = new System.Diagnostics.StackTrace(2, false);
        ModMain.Log?.Warning($"[AfflictionDiag] DysenteryEnd called! Stack:\n{st}");
    }
}

// v2.7.15:ManualUpdate Postfix 强制 100 太粗暴 —— 用户要的是"不衰减",不是"自动满"
// 删掉 Postfix,只靠 Degrade / WearOut / DegradeOnUse 3 个 Prefix 拦衰减源头
// 想一次性拉满用"恢复全部耐久"按钮 / "修复背包物品"按钮

// v2.7.75 DynamicPatch: 去 [HarmonyPatch] attribute —— GearItem.Degrade 等每帧多次调用,
// 即便 Prefix 第一行 return true,Harmony wrapper 本身就是每帧数百次 bridge 的开销
// Patch_GearItem_Degrade 已合并到 Patch_GearDegrade (CheatsPatches.cs) —— 避免同一方法两个 spec 冲突

internal static class Patch_GearItem_WearOut
{
    internal static bool Prefix() => !CheatState.InfiniteDurability;
}

internal static class Patch_GearItem_DegradeOnUse
{
    internal static bool Prefix() => !CheatState.InfiniteDurability;
}

// Patch_GearItem_Awake 也删 —— 同样是'强制到 100',不符合用户'不损耗'要求

// —— 猎物出肉量倍率状态(目前只改鹿) ——
// 原版鹿净肉 6-9kg,真实世界骡鹿/白尾鹿净肉约 18-25kg。给鹿尸体初始肉量乘一个 [Min,Max] 区间内的随机倍率。
// 倍率默认 1=原版。只在新鲜击杀(InitializeResourcesAndConditions)时乘一次,存档恢复不触发,无累乘。
internal static class MeatState
{
    public static float DeerMin = 1f;
    public static float DeerMax = 1f;
    public static bool Enabled() => Mathf.Abs(DeerMin - 1f) > 0.001f || Mathf.Abs(DeerMax - 1f) > 0.001f;
}

// Patch_Inventory_MaybeAdd / Patch_Inventory_AddGear 已去除(InfiniteCarry 功能交给其他 mod)
