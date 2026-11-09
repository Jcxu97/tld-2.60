using System;
using UnityEngine;

namespace TldHacks;

internal static partial class MenuTweaks
{
    // Styles set by Menu.cs during InitStyles
    internal static GUIStyle AccentBar;
    internal static GUIStyle LabelStyle;
    internal static GUIStyle MutedLabel;
    internal static GUIStyle ValueLabel;   // 滑条数值右对齐样式(见 Menu._valueLabelStyle)
    internal static GUIStyle ToggleStyle;

    // Collapse states for detail sections
    internal static bool _foodDetailExpanded = false;
    private static bool _gearDetailExpanded = false;
    private static bool _footstepExpanded = false;
    private static bool _qolSleepExpanded = false;
    private static bool _worldSprainkleExpanded = false;
    private static bool _worldBowExpanded = false;

    // 三列卡片栅格。COL_W3 是卡片内宽,ColX(i) 是第 i 列内容的起点;卡片外框向两侧各多出 PAD。
    private const float ROW_H = 26f;
    private const float ROW_ADV = 30f;
    private const float SECTION_END_ADV = 20f;
    private const float LBL_W = 116f;
    private const float VAL_W = 60f;
    private const float PAD = Ui.CARD_PAD;
    private const float CARD_GAP = 14f;

    private static float CARD_W3 => (Menu.ContentW - 2f * CARD_GAP) / 3f;
    internal static float COL_W3 => CARD_W3 - 2f * PAD;
    internal static float COL_TOG_W3 => COL_W3;
    internal static float HALF_W => (COL_W3 - 6f) / 2f;
    internal static float HALF_OFF => HALF_W + 6f;
    internal static float THIRD_W => (COL_W3 - 12f) / 3f;
    internal static float THIRD_OFF => THIRD_W + 6f;
    private static float COL_SLD_W3 => COL_W3 - LBL_W - VAL_W - 8f;
    internal static float ColX(int i) => i * (CARD_W3 + CARD_GAP) + PAD;

    // ——— Helpers ———

    internal static float SectionCol(Func<float, float, float, float, Rect> R, float x, float y, float w, string title, string badge = null)
        => Ui.Card(x - PAD, y, w + 2f * PAD, title, badge);

    internal static float SectionCol(Func<float, float, float, float, Rect> R, float x, float y, float w, string title,
        string key, ref bool on, ref bool changed, string badge = null)
        => Ui.Card(x - PAD, y, w + 2f * PAD, title, key, ref on, ref changed, badge);

    internal static float DrawSliderCol3(Func<float, float, float, float, Rect> R, float x, float y,
        string label, float value, float min, float max, string format = "F2", string key = null)
    {
        Ui.Hover(key, R(x, y, COL_W3, ROW_H), label);
        GUI.Label(R(x, y, LBL_W, ROW_H), label, LabelStyle ?? GUI.skin.label);
        float newVal = Ui.SliderRaw(R(x + LBL_W, y + 8f, COL_SLD_W3, 12f), value, min, max);
        GUI.Label(R(x + COL_W3 - VAL_W, y, VAL_W, ROW_H), newVal.ToString(format), ValueLabel ?? MutedLabel ?? GUI.skin.label);
        return newVal;
    }

    internal static GUIStyle ExpanderStyle;

    // 折叠行:整行宽,左边名称,右边箭头
    internal static bool Expander(Func<float, float, float, float, Rect> R, float x, float y, bool open, string zh, string en)
    {
        bool click = GUI.Button(R(x, y, COL_W3, ROW_H), I18n.T(zh, en), ExpanderStyle ?? GUI.skin.button);
        GUI.Label(R(x + COL_W3 - 30f, y, 30f, ROW_H), open ? "▲" : "▼", ValueLabel ?? GUI.skin.label);
        return click ? !open : open;
    }

    // 只读的热键行:左边说明,右边当前按键
    private static float KeyRow(Func<float, float, float, float, Rect> R, float x, float y, string label, KeyCode key)
    {
        Ui.Hover("Hotkey", R(x, y, COL_W3, ROW_H));
        GUI.Label(R(x, y, COL_W3 - 110f, ROW_H), label, LabelStyle ?? GUI.skin.label);
        GUI.Label(R(x + COL_W3 - 110f, y, 110f, ROW_H), key.ToString(), ValueLabel ?? MutedLabel ?? GUI.skin.label);
        return y + ROW_ADV;
    }

    internal static readonly string[] BowModeZh = { "手修", "铣床", "都可" }, BowModeEn = { "By Hand", "Mill", "Both" };
    internal static readonly string[] AmountZh = { "少", "中", "多" }, AmountEn = { "Low", "Med", "High" };
    internal static readonly string[] SodaMinutes = { "5", "10", "15", "30" };

    // 只有几档取值的设置用分段按钮代替滑条,当前档用强调色。
    internal static int DrawChoiceCol3(Func<float, float, float, float, Rect> R, float x, float y,
        string label, int value, string[] options, string key = null)
    {
        const float lblW = 110f;
        float w = COL_TOG_W3;
        Ui.Hover(key, R(x, y, w, ROW_H), label);
        GUI.Label(R(x, y, lblW, ROW_H), label, LabelStyle ?? GUI.skin.label);
        float bw = (w - lblW) / options.Length;
        for (int i = 0; i < options.Length; i++)
        {
            var st = i == value ? (AccentBar ?? GUI.skin.button) : GUI.skin.button;
            if (GUI.Button(R(x + lblW + i * bw, y, bw - 4f, ROW_H), options[i], st)) value = i;
        }
        return value;
    }

    // ═══════════════════════════════════════════════════════════════════════
    // Tab 3 人物 & 操作:c1 移动/跳跃 | c2 交互&感知/时间加速/搬运猎物 | c3 睡觉/扭伤/空格/面板快捷键
    // ═══════════════════════════════════════════════════════════════════════
    internal static float DrawCharacterAndQoLTab(Func<float, float, float, float, Rect> R, TldHacksSettings s)
    {
        float c1 = ColX(0), c2 = ColX(1), c3 = ColX(2);
        float subTogW = HALF_W;
        float c2Sub = c2 + HALF_OFF;
        float c1Sub = c1 + HALF_OFF;
        float c3Sub = c3 + HALF_OFF;
        float y1 = 6f, y2 = 6f, y3 = 6f;
        bool changed = false;
        float v;
        bool b;

        // ——— Column 2: 交互 & 感知 + QoL 快捷键 + 时间加速 ———

        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("交互 & 感知", "Interaction & Senses"));
        v = DrawSliderCol3(R, c2, y2, I18n.T("拾取距离", "Pickup Range"), s.PickupRange, 1f, 5f, "F1", key: "PickupRange");
        if (v != s.PickupRange) { s.PickupRange = v; changed = true; }
        y2 += ROW_ADV;
        bool silent = Ui.Toggle("SilentFootsteps", R(c2,    y2, subTogW, ROW_H), s.SilentFootsteps, I18n.T(" 脚步静音", " Silent"), ToggleStyle ?? GUI.skin.toggle);
        bool gunZoom = Ui.Toggle("GunZoomEnabled", R(c2Sub, y2, subTogW, ROW_H), s.GunZoomEnabled,  I18n.T(" 滚轮缩放", " Scroll Zoom"), ToggleStyle ?? GUI.skin.toggle);
        if (silent != s.SilentFootsteps) { s.SilentFootsteps = silent; CheatState.SilentFootsteps = silent; changed = true; }
        if (gunZoom != s.GunZoomEnabled) { s.GunZoomEnabled = gunZoom; changed = true; }
        y2 += ROW_ADV;
        _footstepExpanded = Expander(R, c2, y2, _footstepExpanded, "材质音量", "Volume Detail");
        y2 += ROW_ADV;
        if (_footstepExpanded)
        {
            v = DrawSliderCol3(R, c2, y2, I18n.T("金属声音%", "Metal Vol%"), (float)s.InvWeightMetalVol, 0f, 100f, "F0", key: "InvWeightMetalVol");
            if ((int)v != s.InvWeightMetalVol) { s.InvWeightMetalVol = (int)v; changed = true; }
            y2 += ROW_ADV;
            v = DrawSliderCol3(R, c2, y2, I18n.T("木材声音%", "Wood Vol%"), (float)s.InvWeightWoodVol, 0f, 100f, "F0", key: "InvWeightWoodVol");
            if ((int)v != s.InvWeightWoodVol) { s.InvWeightWoodVol = (int)v; changed = true; }
            y2 += ROW_ADV;
            v = DrawSliderCol3(R, c2, y2, I18n.T("水声音%", "Water Vol%"), (float)s.InvWeightWaterVol, 0f, 100f, "F0", key: "InvWeightWaterVol");
            if ((int)v != s.InvWeightWaterVol) { s.InvWeightWaterVol = (int)v; changed = true; }
            y2 += ROW_ADV;
            v = DrawSliderCol3(R, c2, y2, I18n.T("其他声音%", "General Vol%"), (float)s.InvWeightGeneralVol, 0f, 100f, "F0", key: "InvWeightGeneralVol");
            if ((int)v != s.InvWeightGeneralVol) { s.InvWeightGeneralVol = (int)v; changed = true; }
            y2 += ROW_ADV;
        }
        bool rwl = Ui.Toggle("RunWithLantern", R(c2,    y2, subTogW, ROW_H), s.RunWithLantern,    I18n.T(" 油灯可跑", " Run w/ Lantern"), ToggleStyle ?? GUI.skin.toggle);
        bool noCharcoal = Ui.Toggle("NoAutoEquipCharcoal", R(c2Sub, y2, subTogW, ROW_H), s.NoAutoEquipCharcoal, I18n.T(" 取炭不戴", " No Auto Charcoal"), ToggleStyle ?? GUI.skin.toggle);
        if (rwl != s.RunWithLantern) { s.RunWithLantern = rwl; CheatState.RunWithLantern = rwl; changed = true; }
        if (noCharcoal != s.NoAutoEquipCharcoal) { s.NoAutoEquipCharcoal = noCharcoal; CheatState.NoAutoEquipCharcoal = noCharcoal; changed = true; }
        y2 += ROW_ADV;
        bool autoExt = Ui.Toggle("AutoExtinguishOnRest", R(c2, y2, subTogW, ROW_H), s.AutoExtinguishOnRest, I18n.T(" 休息熄灯", " Auto-Extinguish"), ToggleStyle ?? GUI.skin.toggle);
        if (autoExt != s.AutoExtinguishOnRest) { s.AutoExtinguishOnRest = autoExt; CheatState.AutoExtinguishOnRest = autoExt; changed = true; }
        y2 += ROW_ADV;
        v = DrawSliderCol3(R, c2, y2, I18n.T("开门幅度", "Door Angle"), s.DoorSwingAngle, 0.03f, 0.6f, "F2", key: "DoorSwingAngle");
        if (v != s.DoorSwingAngle) { s.DoorSwingAngle = v; changed = true; }
        y2 += ROW_ADV;
        v = DrawSliderCol3(R, c2, y2, I18n.T("开门速度", "Door Speed"), s.DoorSwingSpeed, 0f, 1f, "F2", key: "DoorSwingSpeed");
        if (v != s.DoorSwingSpeed) { s.DoorSwingSpeed = v; changed = true; }
        y2 += ROW_ADV + SECTION_END_ADV;

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("移动速度", "Movement Speed"), "SpeedTweaksEnabled", ref s.SpeedTweaksEnabled, ref changed);
        v = DrawSliderCol3(R, c1, y1, I18n.T("蹲行", "Crouch"), s.CrouchSpeed, 0.5f, 5f, "F2", key: "CrouchSpeed");
        if (v != s.CrouchSpeed) { s.CrouchSpeed = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("步行", "Walk"), s.WalkSpeed, 0.5f, 5f, "F2", key: "WalkSpeed");
        if (v != s.WalkSpeed) { s.WalkSpeed = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("冲刺", "Sprint"), s.SprintSpeed, 0.5f, 5f, "F2", key: "SprintSpeed");
        if (v != s.SprintSpeed) { s.SprintSpeed = v; changed = true; }
        y1 += ROW_ADV + SECTION_END_ADV;

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("跳跃", "Jump"), "JumpEnabled", ref s.JumpEnabled, ref changed,
            I18n.T($"热键 {s.JumpKey}", $"Key {s.JumpKey}"));
        v = DrawSliderCol3(R, c1, y1, I18n.T("跳跃高度", "Height"), s.JumpHeight, 15f, 42f, "F0", key: "JumpHeight");
        if (v != s.JumpHeight) { s.JumpHeight = v; changed = true; }
        y1 += ROW_ADV;
        bool jk = Ui.Toggle("JumpKing", R(c1, y1, COL_TOG_W3, ROW_H), s.JumpKing,
            I18n.T(" 无限制跳", " Jump King"), ToggleStyle ?? GUI.skin.toggle);
        if (jk != s.JumpKing) { s.JumpKing = jk; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("负重上限(kg)", "Weight Limit"), s.JumpWeightLimit, 10f, 50f, "F0", key: "JumpWeightLimit");
        if (v != s.JumpWeightLimit) { s.JumpWeightLimit = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("卡路里消耗", "Cal Cost"), s.JumpCalorieCost, 0f, 50f, "F0", key: "JumpCalorieCost");
        if (v != s.JumpCalorieCost) { s.JumpCalorieCost = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("体力消耗", "Stam Cost"), s.JumpStaminaCost, 0f, 20f, "F0", key: "JumpStaminaCost");
        if (v != s.JumpStaminaCost) { s.JumpStaminaCost = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("疲劳消耗(%)", "Fatigue Cost"), s.JumpFatigueCost, 0f, 10f, "F1", key: "JumpFatigueCost");
        if (v != s.JumpFatigueCost) { s.JumpFatigueCost = v; changed = true; }
        y1 += ROW_ADV + SECTION_END_ADV;

        // —— 空格代点击(按 Space = 鼠标左键点对应面板的主操作按钮) ——
        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("空格代替左键", "Space as Left Click"));
        b = Ui.Toggle("SpaceFinish_BreakDown", R(c1, y1, subTogW, ROW_H), s.SpaceFinish_BreakDown,
            I18n.T(" 拆解", " Break Down"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.SpaceFinish_BreakDown) { s.SpaceFinish_BreakDown = b; changed = true; }
        b = Ui.Toggle("SpaceFinish_Harvest", R(c1Sub, y1, subTogW, ROW_H), s.SpaceFinish_Harvest,
            I18n.T(" 采集", " Harvest"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.SpaceFinish_Harvest) { s.SpaceFinish_Harvest = b; changed = true; }
        y1 += ROW_ADV;
        b = Ui.Toggle("SpaceFinish_Craft", R(c1, y1, subTogW, ROW_H), s.SpaceFinish_Craft,
            I18n.T(" 制作", " Craft"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.SpaceFinish_Craft) { s.SpaceFinish_Craft = b; changed = true; }
        b = Ui.Toggle("SpaceFinish_Repair", R(c1Sub, y1, subTogW, ROW_H), s.SpaceFinish_Repair,
            I18n.T(" 修理", " Repair"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.SpaceFinish_Repair) { s.SpaceFinish_Repair = b; changed = true; }
        y1 += ROW_ADV + SECTION_END_ADV;

        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("时间加速", "Time Scale"),
            I18n.T($"按住 {s.TimeScaleKey1} / {s.TimeScaleKey2}", $"Hold {s.TimeScaleKey1} / {s.TimeScaleKey2}"));
        v = DrawSliderCol3(R, c2, y2, I18n.T("时间加速1", "TimeScale1"), s.TimeScale1, 0.1f, 50f, "F1", key: "TimeScale1");
        if (v != s.TimeScale1) { s.TimeScale1 = v; changed = true; }
        y2 += ROW_ADV;
        v = DrawSliderCol3(R, c2, y2, I18n.T("时间加速2", "TimeScale2"), s.TimeScale2, 0.1f, 50f, "F1", key: "TimeScale2");
        if (v != s.TimeScale2) { s.TimeScale2 = v; changed = true; }
        y2 += ROW_ADV + SECTION_END_ADV;

        // —— 搬运猎物(v9.0 从「物资 & 世界」挪来,单独一块并写清怎么用) ——
        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("搬运猎物", "Carry Carcass"));
#if STORY_GUARD
        // 剧情版:改 BodyHarvest 持久态会写坏剧情存档,整块禁用灰显
        bool _carryBlocked = StoryGuard.InStory;
        if (_carryBlocked) GUI.enabled = false;
#endif
        b = Ui.Toggle("World_CarcassMoving", R(c2, y2, subTogW, ROW_H), s.World_CarcassMoving,
            I18n.T(" 搬运猎物", " Carry Carcass"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.World_CarcassMoving) { s.World_CarcassMoving = b; CheatState.World_CarcassMoving = b; changed = true; }
        b = Ui.Toggle("World_CarcassMovingAll", R(c2Sub, y2, subTogW, ROW_H), s.World_CarcassMovingAll,
            I18n.T(" 搬运全部", " Carry All"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.World_CarcassMovingAll) { s.World_CarcassMovingAll = b; CheatState.World_CarcassMovingAll = b; changed = true; }
#if STORY_GUARD
        if (_carryBlocked) GUI.enabled = true;
#endif
        y2 += ROW_ADV + SECTION_END_ADV;

        // ——— Column 3: 体力 + 睡眠 + 扭伤 + 面板快捷键 ———

        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("体力", "Stamina"));
        v = DrawSliderCol3(R, c3, y3, I18n.T("体力恢复", "Stamina Regen"), s.StaminaRecharge, 0.5f, 10f, "F1", key: "StaminaRecharge");
        if (v != s.StaminaRecharge) { s.StaminaRecharge = v; changed = true; }
        y3 += ROW_ADV;
        v = DrawSliderCol3(R, c3, y3, I18n.T("体力消耗", "Stamina Drain"), s.StaminaDrain, 0.1f, 2f, "F2", key: "StaminaDrain");
        if (v != s.StaminaDrain) { s.StaminaDrain = v; changed = true; }
        y3 += ROW_ADV;
        v = DrawSliderCol3(R, c3, y3, I18n.T("恢复延迟倍率", "Recovery Delay"), s.StaminaRecoveryDelay, 0f, 2f, "F2", key: "StaminaRecoveryDelay");
        if (v != s.StaminaRecoveryDelay) { s.StaminaRecoveryDelay = v; changed = true; }
        y3 += ROW_ADV + SECTION_END_ADV;

        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("随地睡觉", "Sleep Anywhere"), "QoL_SleepAnywhere", ref s.QoL_SleepAnywhere, ref changed);
        _qolSleepExpanded = Expander(R, c3, y3, _qolSleepExpanded, "睡眠参数", "Sleep Params");
        y3 += ROW_ADV;
        if (_qolSleepExpanded)
        {
            v = DrawSliderCol3(R, c3, y3, I18n.T("疲劳恢复率", "Fatigue Recov"), s.QoL_SleepFatigueRecovery, 0.15f, 1f, "F2", key: "QoL_SleepFatigueRecovery");
            if (v != s.QoL_SleepFatigueRecovery) { s.QoL_SleepFatigueRecovery = v; changed = true; }
            y3 += ROW_ADV;
            v = DrawSliderCol3(R, c3, y3, I18n.T("状态恢复率", "Cond Recov"), s.QoL_SleepConditionRecovery, 0.05f, 1f, "F2", key: "QoL_SleepConditionRecovery");
            if (v != s.QoL_SleepConditionRecovery) { s.QoL_SleepConditionRecovery = v; changed = true; }
            y3 += ROW_ADV;
            v = DrawSliderCol3(R, c3, y3, I18n.T("失温倍率", "Freezing Rate"), s.QoL_SleepFreezingScale, 0f, 5f, "F2", key: "QoL_SleepFreezingScale");
            if (v != s.QoL_SleepFreezingScale) { s.QoL_SleepFreezingScale = v; changed = true; }
            y3 += ROW_ADV;
            bool intF = Ui.Toggle("QoL_SleepInterrupt", R(c3, y3, COL_TOG_W3, ROW_H), s.QoL_SleepInterrupt,
                I18n.T(" 冷醒机制", " Freeze Interrupt"), ToggleStyle ?? GUI.skin.toggle);
            if (intF != s.QoL_SleepInterrupt) { s.QoL_SleepInterrupt = intF; changed = true; }
            y3 += ROW_ADV;
            Ui.Dim(!s.QoL_SleepInterrupt);
            v = DrawSliderCol3(R, c3, y3, I18n.T("冷醒阈值", "Interrupt Thr"), s.QoL_SleepInterruptThreshold, 0.05f, 0.2f, "F2", key: "QoL_SleepInterruptThreshold");
            if (v != s.QoL_SleepInterruptThreshold) { s.QoL_SleepInterruptThreshold = v; changed = true; }
            Ui.Dim(false);
            y3 += ROW_ADV;
        }
        y3 += SECTION_END_ADV;

        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("扭伤系统", "Sprain System"), "World_Sprainkle", ref s.World_Sprainkle, ref changed);
        _worldSprainkleExpanded = Expander(R, c3, y3, _worldSprainkleExpanded, "扭伤参数", "Sprain Params");
        y3 += ROW_ADV;
        if (_worldSprainkleExpanded)
        {
            v = DrawSliderCol3(R, c3, y3, I18n.T("最小坡度(°)", "Min Slope"), s.World_SprainkleSlopeMin, 10f, 60f, "F0", key: "World_SprainkleSlopeMin");
            if (v != s.World_SprainkleSlopeMin) { s.World_SprainkleSlopeMin = v; changed = true; }
            y3 += ROW_ADV;
            v = DrawSliderCol3(R, c3, y3, I18n.T("移动概率%", "Move%"), s.World_SprainkleBaseChanceMoving, 0f, 50f, "F1", key: "World_SprainkleBaseChanceMoving");
            if (v != s.World_SprainkleBaseChanceMoving) { s.World_SprainkleBaseChanceMoving = v; changed = true; }
            y3 += ROW_ADV;
            v = DrawSliderCol3(R, c3, y3, I18n.T("负重加成", "Encumber+"), s.World_SprainkleEncumberChance, 0f, 1f, "F2", key: "World_SprainkleEncumberChance");
            if (v != s.World_SprainkleEncumberChance) { s.World_SprainkleEncumberChance = v; changed = true; }
            y3 += ROW_ADV;
            v = DrawSliderCol3(R, c3, y3, I18n.T("疲劳加成", "Exhaust+"), s.World_SprainkleExhaustionChance, 0f, 1f, "F2", key: "World_SprainkleExhaustionChance");
            if (v != s.World_SprainkleExhaustionChance) { s.World_SprainkleExhaustionChance = v; changed = true; }
            y3 += ROW_ADV;
            v = DrawSliderCol3(R, c3, y3, I18n.T("冲刺加成", "Sprint+"), s.World_SprainkleSprintChance, 0f, 10f, "F1", key: "World_SprainkleSprintChance");
            if (v != s.World_SprainkleSprintChance) { s.World_SprainkleSprintChance = v; changed = true; }
            y3 += ROW_ADV;
            b = Ui.Toggle("World_SprainkleAnkleEnabled", R(c3, y3, COL_TOG_W3, ROW_H), s.World_SprainkleAnkleEnabled,
                I18n.T(" 脚踝扭伤", " Ankle Sprain"), ToggleStyle ?? GUI.skin.toggle);
            if (b != s.World_SprainkleAnkleEnabled) { s.World_SprainkleAnkleEnabled = b; changed = true; }
            y3 += ROW_ADV;
            b = Ui.Toggle("World_SprainkleWristEnabled", R(c3, y3, COL_TOG_W3, ROW_H), s.World_SprainkleWristEnabled,
                I18n.T(" 手腕扭伤", " Wrist Sprain"), ToggleStyle ?? GUI.skin.toggle);
            if (b != s.World_SprainkleWristEnabled) { s.World_SprainkleWristEnabled = b; changed = true; }
            y3 += ROW_ADV;
        }
        y3 += SECTION_END_ADV;

        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("面板快捷键", "Panel Hotkeys"), "QoL_HotkeysEnabled", ref s.QoL_HotkeysEnabled, ref changed);
        y3 = KeyRow(R, c3, y3, I18n.T("丢弃", "Drop"), s.QoL_DropKey);
        y3 = KeyRow(R, c3, y3, I18n.T("按住再丢弃 = 整堆", "Hold + Drop = Whole Stack"), s.QoL_BulkKey);
        y3 = KeyRow(R, c3, y3, I18n.T("关闭面板", "Close Panel"), s.QoL_BackKey);
        y3 += SECTION_END_ADV;

        if (changed) s.RequestSave();
        return Mathf.Max(y1, Mathf.Max(y2, y3));
    }

    // ═══════════════════════════════════════════════════════════════════════
    // 装备 & 衰减:c1 衰减(通用/装备/食物) | c2 物品&界面/交互速度/保温杯&衣物 | c3 弓修理/火把&手电/煤油灯
    // ═══════════════════════════════════════════════════════════════════════
    internal static float DrawGearTab(Func<float, float, float, float, Rect> R, TldHacksSettings s)
    {
        float c1 = ColX(0), c2 = ColX(1), c3 = ColX(2);
        float subTogW = HALF_W;
        float c2Sub = c2 + HALF_OFF;
        float c3Sub = c3 + HALF_OFF;
        float y1 = 6f, y2 = 6f, y3 = 6f;
        bool changed = false;
        float v;
        bool b;

        // ——— Column 1: 衰减 ———

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("衰减·通用", "Decay·General"));
        bool infDur = Ui.Toggle("InfiniteDurability", R(c1, y1, COL_TOG_W3, ROW_H), s.InfiniteDurability,
            I18n.T(" 无限耐久", " Infinite Durability"), ToggleStyle ?? GUI.skin.toggle);
        if (infDur != s.InfiniteDurability) { s.InfiniteDurability = infDur; CheatState.InfiniteDurability = infDur; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("通用衰减", "General"), s.GeneralDecay, 0f, 2f, "F2", key: "GeneralDecay");
        if (v != s.GeneralDecay) { s.GeneralDecay = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("拾取前衰减", "Pre-Pickup"), s.DecayBeforePickup, 0f, 2f, "F2", key: "DecayBeforePickup");
        if (v != s.DecayBeforePickup) { s.DecayBeforePickup = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("使用时衰减", "On-Use"), s.OnUseDecay, 0f, 2f, "F2", key: "OnUseDecay");
        if (v != s.OnUseDecay) { s.OnUseDecay = v; changed = true; }
        y1 += ROW_ADV + SECTION_END_ADV;

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("衰减·装备", "Decay·Gear"));
        v = DrawSliderCol3(R, c1, y1, I18n.T("衣物", "Clothing"), s.ClothingDecayRate, 0f, 2f, "F2", key: "ClothingDecayRate");
        if (v != s.ClothingDecayRate) { s.ClothingDecayRate = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("枪械", "Gun"), s.GunDecay, 0f, 2f, "F2", key: "GunDecay");
        if (v != s.GunDecay) { s.GunDecay = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("弓箭", "Bow"), s.BowDecay, 0f, 2f, "F2", key: "BowDecay");
        if (v != s.BowDecay) { s.BowDecay = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("工具", "Tools"), s.ToolsDecay, 0f, 2f, "F2", key: "ToolsDecay");
        if (v != s.ToolsDecay) { s.ToolsDecay = v; changed = true; }
        y1 += ROW_ADV;
        _gearDetailExpanded = Expander(R, c1, y1, _gearDetailExpanded, "装备细分", "Gear Detail");
        y1 += ROW_ADV;
        if (_gearDetailExpanded)
        {
            v = DrawSliderCol3(R, c1, y1, I18n.T("睡袋", "Bedroll"), s.BedrollDecay, 0f, 2f, "F2", key: "BedrollDecay");
            if (v != s.BedrollDecay) { s.BedrollDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("雪橇", "Travois"), s.TravoisDecay, 0f, 2f, "F2", key: "TravoisDecay");
            if (v != s.TravoisDecay) { s.TravoisDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("箭矢", "Arrow"), s.ArrowDecay, 0f, 2f, "F2", key: "ArrowDecay");
            if (v != s.ArrowDecay) { s.ArrowDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("陷阱", "Snare"), s.SnareDecay, 0f, 2f, "F2", key: "SnareDecay");
            if (v != s.SnareDecay) { s.SnareDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("生火工具", "Firestart"), s.FirestartingDecay, 0f, 2f, "F2", key: "FirestartingDecay");
            if (v != s.FirestartingDecay) { s.FirestartingDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("兽皮/尸骸", "Hide/Gut"), s.HideDecay, 0f, 2f, "F2", key: "HideDecay");
            if (v != s.HideDecay) { s.HideDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("急救品", "First Aid"), s.FirstAidDecay, 0f, 2f, "F2", key: "FirstAidDecay");
            if (v != s.FirstAidDecay) { s.FirstAidDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("净水片", "Purifier"), s.WaterPurifierDecay, 0f, 2f, "F2", key: "WaterPurifierDecay");
            if (v != s.WaterPurifierDecay) { s.WaterPurifierDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("锅具", "Cook Pot"), s.CookingPotDecay, 0f, 2f, "F2", key: "CookingPotDecay");
            if (v != s.CookingPotDecay) { s.CookingPotDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("信号枪弹药", "Flare Ammo"), s.FlareGunAmmoDecay, 0f, 2f, "F2", key: "FlareGunAmmoDecay");
            if (v != s.FlareGunAmmoDecay) { s.FlareGunAmmoDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("磨刀石", "Whetstone"), s.WhetstoneDecay, 0f, 2f, "F2", key: "WhetstoneDecay");
            if (v != s.WhetstoneDecay) { s.WhetstoneDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("开罐器", "Can Opener"), s.CanOpenerDecay, 0f, 2f, "F2", key: "CanOpenerDecay");
            if (v != s.CanOpenerDecay) { s.CanOpenerDecay = v; changed = true; }
            y1 += ROW_ADV;
            v = DrawSliderCol3(R, c1, y1, I18n.T("撬棍", "Prybar"), s.PrybarDecay, 0f, 2f, "F2", key: "PrybarDecay");
            if (v != s.PrybarDecay) { s.PrybarDecay = v; changed = true; }
            y1 += ROW_ADV;
        }
        y1 += SECTION_END_ADV;

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("衰减·食物", "Decay·Food"));
        void FoodSlider(string zh, string en, ref float val, string key)
        {
            float nv = DrawSliderCol3(R, c1, y1, I18n.T(zh, en), val, 0f, 2f, "F2", key: key);
            if (nv != val) { val = nv; changed = true; }
            y1 += ROW_ADV;
        }
        FoodSlider("食物(总)", "Food Total", ref s.FoodDecay, "FoodDecay");
        FoodSlider("生肉", "Raw Meat", ref s.RawMeatDecay, "RawMeatDecay");
        FoodSlider("熟肉", "Cooked Meat", ref s.CookedMeatDecay, "CookedMeatDecay");
        FoodSlider("饮品", "Drinks", ref s.DrinksDecay, "DrinksDecay");
        _foodDetailExpanded = Expander(R, c1, y1, _foodDetailExpanded, "食物细分", "Food Detail");
        y1 += ROW_ADV;
        if (_foodDetailExpanded)
        {
            FoodSlider("腌肉", "Cured Meat", ref s.CuredMeatDecay, "CuredMeatDecay");
            FoodSlider("生鱼", "Raw Fish", ref s.RawFishDecay, "RawFishDecay");
            FoodSlider("熟鱼", "Cooked Fish", ref s.CookedFishDecay, "CookedFishDecay");
            FoodSlider("罐头", "Canned", ref s.CannedFoodDecay, "CannedFoodDecay");
            FoodSlider("咖啡/茶", "Coffee/Tea", ref s.CoffeeTeaDecay, "CoffeeTeaDecay");
            FoodSlider("包装食品", "Packaged", ref s.PackagedFoodDecay, "PackagedFoodDecay");
            FoodSlider("油脂", "Fat", ref s.FatDecay, "FatDecay");
            FoodSlider("腌鱼", "Cured Fish", ref s.CuredFishDecay, "CuredFishDecay");
            FoodSlider("食材", "Ingredients", ref s.IngredientsDecay, "IngredientsDecay");
            FoodSlider("其他食品", "Other Food", ref s.OtherFoodDecay, "OtherFoodDecay");
        }
        y1 += SECTION_END_ADV;

        // ——— Column 2: 物品 & 界面 + 交互速度 + 保温杯 & 衣物 + 蒸汽火车 ———

        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("物品 & 界面", "Items & UI"));
        bool pauseJ = Ui.Toggle("PauseInJournal", R(c2,    y2, subTogW, ROW_H), s.PauseInJournal, I18n.T(" 日志暂停", " Pause Journal"), ToggleStyle ?? GUI.skin.toggle);
        bool muteCougar = Ui.Toggle("MuteCougarMenuSound", R(c2Sub, y2, subTogW, ROW_H), s.MuteCougarMenuSound,  I18n.T(" 静音狮吼", " Mute Cougar"), ToggleStyle ?? GUI.skin.toggle);
        if (pauseJ != s.PauseInJournal) { s.PauseInJournal = pauseJ; changed = true; }
        if (muteCougar != s.MuteCougarMenuSound) { s.MuteCougarMenuSound = muteCougar; changed = true; }
        y2 += ROW_ADV;
#if STORY_GUARD
        // 剧情版:任意丢弃可丢任务/剧情物品 → 死锁风险,禁用灰显(静音狮吼保留)。
        bool _dropBlocked = StoryGuard.InStory;
        if (_dropBlocked) GUI.enabled = false;
#endif
        bool droppable  = Ui.Toggle("DroppableUndroppables", R(c2, y2, subTogW, ROW_H), s.DroppableUndroppables, I18n.T(" 任意丢弃", " Drop Any"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        if (_dropBlocked) GUI.enabled = true;
#endif
        bool impW    = Ui.Toggle("ImportantWeight", R(c2Sub, y2, subTogW, ROW_H), s.ImportantWeight, I18n.T(" 关键重量", " Key Weight"), ToggleStyle ?? GUI.skin.toggle);
        if (droppable != s.DroppableUndroppables) { s.DroppableUndroppables = droppable; changed = true; }
        if (impW != s.ImportantWeight) { s.ImportantWeight = impW; changed = true; }
        y2 += ROW_ADV;
        // v9.0 随地制作挪到主页「制作 & 修理」,这里空出来的位置给更多可堆叠占上
        bool allNote = Ui.Toggle("AllNote", R(c2,    y2, subTogW, ROW_H), s.AllNote,         I18n.T(" 笔记可丢", " Drop Notes"), ToggleStyle ?? GUI.skin.toggle);
        bool remTool = Ui.Toggle("RememberBreakdownTool", R(c2Sub, y2, subTogW, ROW_H), s.RememberBreakdownTool, I18n.T(" 记忆工具", " Remember Tool"), ToggleStyle ?? GUI.skin.toggle);
        if (allNote != s.AllNote) { s.AllNote = allNote; changed = true; }
        if (remTool != s.RememberBreakdownTool) { s.RememberBreakdownTool = remTool; changed = true; }
        y2 += ROW_ADV;
        b = Ui.Toggle("Stack_AddComponent", R(c2, y2, subTogW, ROW_H), s.Stack_AddComponent, I18n.T(" 更多可堆叠", " More Stacking"), ToggleStyle ?? GUI.skin.toggle);
        bool maxHp = Ui.Toggle("Stack_UseMaxHP", R(c2Sub, y2, subTogW, ROW_H), s.Stack_UseMaxHP, I18n.T(" 合并取最高", " Merge at Max HP"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.Stack_AddComponent) { s.Stack_AddComponent = b; changed = true; }
        if (maxHp != s.Stack_UseMaxHP) { s.Stack_UseMaxHP = maxHp; changed = true; }
        y2 += ROW_ADV;
        // UI 堆叠、不捡丢物从主页挪来
        b = Ui.Toggle("StackingEnabled", R(c2, y2, subTogW, ROW_H), s.StackingEnabled, I18n.T(" UI 堆叠", " UI Stacking"), ToggleStyle ?? GUI.skin.toggle);
        bool bnop = Ui.Toggle("BlockAutoPickupOwnDrops", R(c2Sub, y2, subTogW, ROW_H), s.BlockAutoPickupOwnDrops, I18n.T(" 不捡丢物", " Skip Own Drops"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.StackingEnabled) { s.StackingEnabled = b; changed = true; }
        if (bnop != s.BlockAutoPickupOwnDrops) { s.BlockAutoPickupOwnDrops = bnop; CheatState.BlockAutoPickupOwnDrops = bnop; changed = true; }
        y2 += ROW_ADV + SECTION_END_ADV;

        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("交互速度", "Interaction Speed"));
        v = DrawSliderCol3(R, c2, y2, I18n.T("通用动作", "Actions"), s.TT_GlobalSpeedMult, 0.2f, 6f, "F1", key: "TT_GlobalSpeedMult");
        if (v != s.TT_GlobalSpeedMult) { s.TT_GlobalSpeedMult = v; changed = true; }
        y2 += ROW_ADV;
        v = DrawSliderCol3(R, c2, y2, I18n.T("开容器", "Containers"), s.TT_InteractionSpeedMult, 0.2f, 6f, "F1", key: "TT_InteractionSpeedMult");
        if (v != s.TT_InteractionSpeedMult) { s.TT_InteractionSpeedMult = v; changed = true; }
        y2 += ROW_ADV;
        v = DrawSliderCol3(R, c2, y2, I18n.T("进食/喝水", "Eating"), s.TT_EatingSpeedMult, 0.2f, 6f, "F1", key: "TT_EatingSpeedMult");
        if (v != s.TT_EatingSpeedMult) { s.TT_EatingSpeedMult = v; changed = true; }
        y2 += ROW_ADV;
        v = DrawSliderCol3(R, c2, y2, I18n.T("拆解物品", "Breakdown"), s.TT_BreakdownSpeedMult, 0.2f, 6f, "F1", key: "TT_BreakdownSpeedMult");
        if (v != s.TT_BreakdownSpeedMult) { s.TT_BreakdownSpeedMult = v; changed = true; }
        y2 += ROW_ADV;
        v = DrawSliderCol3(R, c2, y2, I18n.T("阅读研究", "Reading"), s.TT_ReadingSpeedMult, 0.2f, 6f, "F1", key: "TT_ReadingSpeedMult");
        if (v != s.TT_ReadingSpeedMult) { s.TT_ReadingSpeedMult = v; changed = true; }
        y2 += ROW_ADV + SECTION_END_ADV;

        // 保温杯三项和衣物防潮从主页挪来
        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("保温杯 & 衣物", "Flask & Clothing"));
        bool flsk1 = Ui.Toggle("FlaskNoHeatLoss", R(c2, y2, subTogW, ROW_H), s.FlaskNoHeatLoss, I18n.T(" 保温杯不降温", " Flask Keep Hot"), ToggleStyle ?? GUI.skin.toggle);
        bool flsk2 = Ui.Toggle("FlaskInfiniteVol", R(c2Sub, y2, subTogW, ROW_H), s.FlaskInfiniteVol, I18n.T(" 保温杯无限容量", " Flask No Limit"), ToggleStyle ?? GUI.skin.toggle);
        if (flsk1 != s.FlaskNoHeatLoss) { s.FlaskNoHeatLoss = flsk1; CheatState.FlaskNoHeatLoss = flsk1; changed = true; }
        if (flsk2 != s.FlaskInfiniteVol) { s.FlaskInfiniteVol = flsk2; CheatState.FlaskInfiniteVol = flsk2; changed = true; }
        y2 += ROW_ADV;
        bool flsk3 = Ui.Toggle("FlaskAnyItem", R(c2, y2, subTogW, ROW_H), s.FlaskAnyItem, I18n.T(" 保温杯装任意液体", " Flask Any Liquid"), ToggleStyle ?? GUI.skin.toggle);
        bool wet = Ui.Toggle("NoWetClothes", R(c2Sub, y2, subTogW, ROW_H), s.NoWetClothes, I18n.T(" 衣物防潮", " Dry Clothes"), ToggleStyle ?? GUI.skin.toggle);
        if (flsk3 != s.FlaskAnyItem) { s.FlaskAnyItem = flsk3; CheatState.FlaskAnyItem = flsk3; changed = true; }
        if (wet != s.NoWetClothes) { s.NoWetClothes = wet; CheatState.NoWetClothes = wet; changed = true; }
        y2 += ROW_ADV + SECTION_END_ADV;

        // ——— Column 3: 弓修理 + 火把 & 手电 + 煤油灯 ———
        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("弓修理", "Bow Repair"), "World_BowRepair", ref s.World_BowRepair, ref changed);
        b = Ui.Toggle("World_BowRepairDLC", R(c3, y3, COL_TOG_W3, ROW_H), s.World_BowRepairDLC,
            I18n.T(" DLC弓启用", " DLC Bows"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.World_BowRepairDLC) { s.World_BowRepairDLC = b; changed = true; }
        y3 += ROW_ADV;
        _worldBowExpanded = Expander(R, c3, y3, _worldBowExpanded, "弓参数", "Bow Params");
        y3 += ROW_ADV;
        if (_worldBowExpanded)
        {
            bool en = I18n.IsEnglish;
            var modes = en ? BowModeEn : BowModeZh;
            var amounts = en ? AmountEn : AmountZh;
            string matLbl = I18n.T("  材料用量", "  Material");
            int iv = DrawChoiceCol3(R, c3, y3, I18n.T("生存弓", "Survival Bow"), s.World_BowRepairMode, modes, "BowMode");
            if (iv != s.World_BowRepairMode) { s.World_BowRepairMode = iv; changed = true; }
            y3 += ROW_ADV;
            iv = DrawChoiceCol3(R, c3, y3, matLbl, s.World_BowMaterialNeed, amounts, "BowMat");
            if (iv != s.World_BowMaterialNeed) { s.World_BowMaterialNeed = iv; changed = true; }
            y3 += ROW_ADV;
            bool prevEnabled = GUI.enabled;
            if (!s.World_BowRepairDLC) GUI.enabled = false;
            iv = DrawChoiceCol3(R, c3, y3, I18n.T("运动弓", "Sport Bow"), s.World_SportBowRepairMode, modes, "BowModeDLC");
            if (iv != s.World_SportBowRepairMode) { s.World_SportBowRepairMode = iv; changed = true; }
            y3 += ROW_ADV;
            iv = DrawChoiceCol3(R, c3, y3, matLbl, s.World_SportBowMaterialNeed, amounts, "BowMat");
            if (iv != s.World_SportBowMaterialNeed) { s.World_SportBowMaterialNeed = iv; changed = true; }
            y3 += ROW_ADV;
            iv = DrawChoiceCol3(R, c3, y3, I18n.T("木弓", "Woodwright Bow"), s.World_WoodBowRepairMode, modes, "BowModeDLC");
            if (iv != s.World_WoodBowRepairMode) { s.World_WoodBowRepairMode = iv; changed = true; }
            y3 += ROW_ADV;
            iv = DrawChoiceCol3(R, c3, y3, matLbl, s.World_WoodBowMaterialNeed, amounts, "BowMat");
            if (iv != s.World_WoodBowMaterialNeed) { s.World_WoodBowMaterialNeed = iv; changed = true; }
            y3 += ROW_ADV;
            iv = DrawChoiceCol3(R, c3, y3, I18n.T("灌木弓", "Bushcraft Bow"), s.World_BushBowRepairMode, modes, "BowModeDLC");
            if (iv != s.World_BushBowRepairMode) { s.World_BushBowRepairMode = iv; changed = true; }
            y3 += ROW_ADV;
            iv = DrawChoiceCol3(R, c3, y3, matLbl, s.World_BushBowMaterialNeed, amounts, "BowMat");
            if (iv != s.World_BushBowMaterialNeed) { s.World_BushBowMaterialNeed = iv; changed = true; }
            y3 += ROW_ADV;
            GUI.enabled = prevEnabled;
        }
        y3 += SECTION_END_ADV;
        y3 = CardTorch(R, s, c3, y3, ref changed);
        y3 = CardLamp(R, s, c3, y3, ref changed);
#if !EP5_EDITION && !STORY_EDITION
        y2 = CardSteamTrain(R, s, c2, y2, ref changed);
#endif

        if (changed) s.RequestSave();
        return Mathf.Max(y1, Mathf.Max(y2, y3));
    }

    // ═══════════════════════════════════════════════════════════════════════
    // 地图 & 界面:c1 地图管理/地图显示/收藏品/地堡 | c2 木炭绘图/自动测绘/视角&FOV/其他便利 | c3 室内灯光/准星/杂项开关
    // ═══════════════════════════════════════════════════════════════════════
    internal static float DrawMapUiTab(Func<float, float, float, float, Rect> R, TldHacksSettings s)
    {
        float c1 = ColX(0), c2 = ColX(1), c3 = ColX(2);
        float y1 = 6f, y2 = 6f, y3 = 6f;
        bool changed = false;

        y1 = MapCardsManage(R, s, c1, y1, ref changed);
        y1 = CardBunkers(R, s, c1, y1, ref changed);
        y1 = CardMiscQoL(R, s, c1, y1, ref changed);
        y2 = MapCardsSurvey(R, s, c2, y2, ref changed);
        y2 = CardCollectibles(R, s, c2, y2, ref changed);
        // 室内灯光 + 准星画在 c3,视角 & FOV 接在 c2 的地图卡下面
        changed |= DrawVisualCards(R, s, c3, c2, ref y3, ref y2);
        y3 = CardMiscToggles(R, s, c3, y3, ref changed);

        if (changed) s.RequestSave();
        return Mathf.Max(y1, Mathf.Max(y2, y3));
    }
}
