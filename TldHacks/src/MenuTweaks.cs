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
    // Tab 3 人物 & 操作:c1 移动/跳跃 | c2 交互&感知/QoL 快捷键/时间加速 | c3 睡觉/测绘/扭伤/空格
    // ═══════════════════════════════════════════════════════════════════════
    internal static float DrawCharacterAndQoLTab(Func<float, float, float, float, Rect> R, TldHacksSettings s)
    {
        float c1 = ColX(0), c2 = ColX(1), c3 = ColX(2);
        float subTogW = HALF_W;
        float c2Sub = c2 + HALF_OFF;
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
        bool aom = Ui.Toggle("QoL_AutoOpenMapOnExit", R(c2Sub, y2, subTogW, ROW_H), s.QoL_AutoOpenMapOnExit,
            I18n.T(" 出门开小地图", " Minimap Outside"), ToggleStyle ?? GUI.skin.toggle);
        if (aom != s.QoL_AutoOpenMapOnExit) { s.QoL_AutoOpenMapOnExit = aom; changed = true; }
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

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("体力", "Stamina"));
        v = DrawSliderCol3(R, c1, y1, I18n.T("体力恢复", "Stamina Regen"), s.StaminaRecharge, 0.5f, 10f, "F1", key: "StaminaRecharge");
        if (v != s.StaminaRecharge) { s.StaminaRecharge = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("体力消耗", "Stamina Drain"), s.StaminaDrain, 0.1f, 2f, "F2", key: "StaminaDrain");
        if (v != s.StaminaDrain) { s.StaminaDrain = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("恢复延迟倍率", "Recovery Delay"), s.StaminaRecoveryDelay, 0f, 2f, "F2", key: "StaminaRecoveryDelay");
        if (v != s.StaminaRecoveryDelay) { s.StaminaRecoveryDelay = v; changed = true; }
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

        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("面板快捷键", "Panel Hotkeys"), "QoL_HotkeysEnabled", ref s.QoL_HotkeysEnabled, ref changed);
        y2 = KeyRow(R, c2, y2, I18n.T("丢弃", "Drop"), s.QoL_DropKey);
        y2 = KeyRow(R, c2, y2, I18n.T("按住再丢弃 = 整堆", "Hold + Drop = Whole Stack"), s.QoL_BulkKey);
        y2 = KeyRow(R, c2, y2, I18n.T("关闭面板", "Close Panel"), s.QoL_BackKey);
        y2 += SECTION_END_ADV;

        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("时间加速", "Time Scale"),
            I18n.T($"按住 {s.TimeScaleKey1} / {s.TimeScaleKey2}", $"Hold {s.TimeScaleKey1} / {s.TimeScaleKey2}"));
        v = DrawSliderCol3(R, c2, y2, I18n.T("时间加速1", "TimeScale1"), s.TimeScale1, 1f, 50f, "F0", key: "TimeScale1");
        if (v != s.TimeScale1) { s.TimeScale1 = v; changed = true; }
        y2 += ROW_ADV;
        v = DrawSliderCol3(R, c2, y2, I18n.T("时间加速2", "TimeScale2"), s.TimeScale2, 1f, 50f, "F0", key: "TimeScale2");
        if (v != s.TimeScale2) { s.TimeScale2 = v; changed = true; }
        y2 += ROW_ADV + SECTION_END_ADV;

        // ——— Column 3: 睡眠 + 测绘 + 扭伤 + 空格 ———

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

        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("自动测绘", "Auto Survey"), "QoL_AutoSurvey", ref s.QoL_AutoSurvey, ref changed);
        v = DrawSliderCol3(R, c3, y3, I18n.T("绘制间隔(秒)", "Interval"), s.QoL_AutoSurveyDelay, 1f, 60f, "F0", key: "QoL_AutoSurveyDelay");
        if (v != s.QoL_AutoSurveyDelay) { s.QoL_AutoSurveyDelay = v; changed = true; }
        y3 += ROW_ADV;
        v = DrawSliderCol3(R, c3, y3, I18n.T("范围倍率", "Range"), s.QoL_AutoSurveyRange, 0.1f, 10f, "F1", key: "QoL_AutoSurveyRange");
        if (v != s.QoL_AutoSurveyRange) { s.QoL_AutoSurveyRange = v; changed = true; }
        y3 += ROW_ADV;
        bool unl = Ui.Toggle("QoL_AutoSurveyUnlock", R(c3, y3, COL_TOG_W3, ROW_H), s.QoL_AutoSurveyUnlock,
            I18n.T(" 无视天气限制", " Ignore Weather"), ToggleStyle ?? GUI.skin.toggle);
        if (unl != s.QoL_AutoSurveyUnlock) { s.QoL_AutoSurveyUnlock = unl; changed = true; }
        y3 += ROW_ADV + SECTION_END_ADV;

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

        // —— 空格代点击(按 Space = 鼠标左键点对应面板的主操作按钮) ——
        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("空格代替左键", "Space as Left Click"));
        b = Ui.Toggle("SpaceFinish_BreakDown", R(c3, y3, subTogW, ROW_H), s.SpaceFinish_BreakDown,
            I18n.T(" 拆解", " Break Down"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.SpaceFinish_BreakDown) { s.SpaceFinish_BreakDown = b; changed = true; }
        b = Ui.Toggle("SpaceFinish_Harvest", R(c3Sub, y3, subTogW, ROW_H), s.SpaceFinish_Harvest,
            I18n.T(" 采集", " Harvest"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.SpaceFinish_Harvest) { s.SpaceFinish_Harvest = b; changed = true; }
        y3 += ROW_ADV;
        b = Ui.Toggle("SpaceFinish_Craft", R(c3, y3, subTogW, ROW_H), s.SpaceFinish_Craft,
            I18n.T(" 制作", " Craft"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.SpaceFinish_Craft) { s.SpaceFinish_Craft = b; changed = true; }
        b = Ui.Toggle("SpaceFinish_Repair", R(c3Sub, y3, subTogW, ROW_H), s.SpaceFinish_Repair,
            I18n.T(" 修理", " Repair"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.SpaceFinish_Repair) { s.SpaceFinish_Repair = b; changed = true; }
        y3 += ROW_ADV + SECTION_END_ADV;

        // —— 搬运猎物(v9.0 从「物资 & 世界」挪来,单独一块并写清怎么用) ——
        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("搬运猎物", "Carry Carcass"));
#if STORY_GUARD
        // 剧情版:改 BodyHarvest 持久态会写坏剧情存档,整块禁用灰显
        bool _carryBlocked = StoryGuard.InStory;
        if (_carryBlocked) GUI.enabled = false;
#endif
        b = Ui.Toggle("World_CarcassMoving", R(c3, y3, subTogW, ROW_H), s.World_CarcassMoving,
            I18n.T(" 搬运猎物", " Carry Carcass"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.World_CarcassMoving) { s.World_CarcassMoving = b; CheatState.World_CarcassMoving = b; changed = true; }
        b = Ui.Toggle("World_CarcassMovingAll", R(c3Sub, y3, subTogW, ROW_H), s.World_CarcassMovingAll,
            I18n.T(" 搬运全部", " Carry All"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.World_CarcassMovingAll) { s.World_CarcassMovingAll = b; CheatState.World_CarcassMovingAll = b; changed = true; }
#if STORY_GUARD
        if (_carryBlocked) GUI.enabled = true;
#endif
        y3 += ROW_ADV + SECTION_END_ADV;

        if (changed) s.RequestSave();
        return Mathf.Max(y1, Mathf.Max(y2, y3));
    }

    // ═══════════════════════════════════════════════════════════════════════
    // Tab 4 物资 & 世界:c1 衰减/弓修理 | c2 物品&界面/其他便利/交互速度 | c3 商人&美洲狮/高级微调
    // ═══════════════════════════════════════════════════════════════════════
    internal static float DrawGearAndWorldTab(Func<float, float, float, float, Rect> R, TldHacksSettings s)
    {
        float c1 = ColX(0), c2 = ColX(1), c3 = ColX(2);
        float subTogW = HALF_W;
        float c2Sub = c2 + HALF_OFF;
        float c3Sub = c3 + HALF_OFF;
        float y1 = 6f, y2 = 6f, y3 = 6f;
        bool changed = false;
        float v;
        bool b;

        // ——— Column 1: 衰减 + 弓修理 ———

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("衰减·通用", "Decay·General"));
        bool infDur = Ui.Toggle("InfiniteDurability", R(c1, y1, COL_TOG_W3, ROW_H), s.InfiniteDurability,
            I18n.T(" 无限耐久", " Infinite Durability"), ToggleStyle ?? GUI.skin.toggle);
        if (infDur != s.InfiniteDurability) { s.InfiniteDurability = infDur; changed = true; }
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

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("弓修理", "Bow Repair"), "World_BowRepair", ref s.World_BowRepair, ref changed);
        b = Ui.Toggle("World_BowRepairDLC", R(c1, y1, COL_TOG_W3, ROW_H), s.World_BowRepairDLC,
            I18n.T(" DLC弓启用", " DLC Bows"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.World_BowRepairDLC) { s.World_BowRepairDLC = b; changed = true; }
        y1 += ROW_ADV;
        _worldBowExpanded = Expander(R, c1, y1, _worldBowExpanded, "弓参数", "Bow Params");
        y1 += ROW_ADV;
        if (_worldBowExpanded)
        {
            bool en = I18n.IsEnglish;
            var modes = en ? BowModeEn : BowModeZh;
            var amounts = en ? AmountEn : AmountZh;
            string matLbl = I18n.T("  材料用量", "  Material");
            int iv = DrawChoiceCol3(R, c1, y1, I18n.T("生存弓", "Survival Bow"), s.World_BowRepairMode, modes, "BowMode");
            if (iv != s.World_BowRepairMode) { s.World_BowRepairMode = iv; changed = true; }
            y1 += ROW_ADV;
            iv = DrawChoiceCol3(R, c1, y1, matLbl, s.World_BowMaterialNeed, amounts, "BowMat");
            if (iv != s.World_BowMaterialNeed) { s.World_BowMaterialNeed = iv; changed = true; }
            y1 += ROW_ADV;
            bool prevEnabled = GUI.enabled;
            if (!s.World_BowRepairDLC) GUI.enabled = false;
            iv = DrawChoiceCol3(R, c1, y1, I18n.T("运动弓", "Sport Bow"), s.World_SportBowRepairMode, modes, "BowModeDLC");
            if (iv != s.World_SportBowRepairMode) { s.World_SportBowRepairMode = iv; changed = true; }
            y1 += ROW_ADV;
            iv = DrawChoiceCol3(R, c1, y1, matLbl, s.World_SportBowMaterialNeed, amounts, "BowMat");
            if (iv != s.World_SportBowMaterialNeed) { s.World_SportBowMaterialNeed = iv; changed = true; }
            y1 += ROW_ADV;
            iv = DrawChoiceCol3(R, c1, y1, I18n.T("木弓", "Woodwright Bow"), s.World_WoodBowRepairMode, modes, "BowModeDLC");
            if (iv != s.World_WoodBowRepairMode) { s.World_WoodBowRepairMode = iv; changed = true; }
            y1 += ROW_ADV;
            iv = DrawChoiceCol3(R, c1, y1, matLbl, s.World_WoodBowMaterialNeed, amounts, "BowMat");
            if (iv != s.World_WoodBowMaterialNeed) { s.World_WoodBowMaterialNeed = iv; changed = true; }
            y1 += ROW_ADV;
            iv = DrawChoiceCol3(R, c1, y1, I18n.T("灌木弓", "Bushcraft Bow"), s.World_BushBowRepairMode, modes, "BowModeDLC");
            if (iv != s.World_BushBowRepairMode) { s.World_BushBowRepairMode = iv; changed = true; }
            y1 += ROW_ADV;
            iv = DrawChoiceCol3(R, c1, y1, matLbl, s.World_BushBowMaterialNeed, amounts, "BowMat");
            if (iv != s.World_BushBowMaterialNeed) { s.World_BushBowMaterialNeed = iv; changed = true; }
            y1 += ROW_ADV;
            GUI.enabled = prevEnabled;
        }
        y1 += SECTION_END_ADV;

        // ——— Column 2: 物品 & 界面 + 其他便利 + 交互速度 ———

        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("物品 & 界面", "Items & UI"));
        bool pauseJ = Ui.Toggle("PauseInJournal", R(c2,    y2, subTogW, ROW_H), s.PauseInJournal, I18n.T(" 日志暂停", " Pause Journal"), ToggleStyle ?? GUI.skin.toggle);
        bool skipI  = Ui.Toggle("SkipIntro", R(c2Sub, y2, subTogW, ROW_H), s.SkipIntro,      I18n.T(" 跳过片头", " Skip Intro"), ToggleStyle ?? GUI.skin.toggle);
        if (pauseJ != s.PauseInJournal) { s.PauseInJournal = pauseJ; changed = true; }
        if (skipI != s.SkipIntro) { s.SkipIntro = skipI; changed = true; }
        y2 += ROW_ADV;
        bool muteCougar = Ui.Toggle("MuteCougarMenuSound", R(c2,    y2, subTogW, ROW_H), s.MuteCougarMenuSound,  I18n.T(" 静音狮吼", " Mute Cougar"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        // 剧情版:任意丢弃可丢任务/剧情物品 → 死锁风险,禁用灰显(静音狮吼保留)。
        bool _dropBlocked = StoryGuard.InStory;
        if (_dropBlocked) GUI.enabled = false;
#endif
        bool droppable  = Ui.Toggle("DroppableUndroppables", R(c2Sub, y2, subTogW, ROW_H), s.DroppableUndroppables, I18n.T(" 任意丢弃", " Drop Any"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        if (_dropBlocked) GUI.enabled = true;
#endif
        if (muteCougar != s.MuteCougarMenuSound) { s.MuteCougarMenuSound = muteCougar; changed = true; }
        if (droppable != s.DroppableUndroppables) { s.DroppableUndroppables = droppable; changed = true; }
        y2 += ROW_ADV;
        bool impW    = Ui.Toggle("ImportantWeight", R(c2,    y2, subTogW, ROW_H), s.ImportantWeight, I18n.T(" 关键重量", " Key Weight"), ToggleStyle ?? GUI.skin.toggle);
        bool allNote = Ui.Toggle("AllNote", R(c2Sub, y2, subTogW, ROW_H), s.AllNote,         I18n.T(" 笔记可丢", " Drop Notes"), ToggleStyle ?? GUI.skin.toggle);
        if (impW != s.ImportantWeight) { s.ImportantWeight = impW; changed = true; }
        if (allNote != s.AllNote) { s.AllNote = allNote; changed = true; }
        y2 += ROW_ADV;
        // v9.0 随地制作挪到主页「制作 & 修理」,这里空出来的位置给更多可堆叠占上
        bool remTool = Ui.Toggle("RememberBreakdownTool", R(c2,    y2, subTogW, ROW_H), s.RememberBreakdownTool, I18n.T(" 记忆工具", " Remember Tool"), ToggleStyle ?? GUI.skin.toggle);
        b = Ui.Toggle("Stack_AddComponent", R(c2Sub, y2, subTogW, ROW_H), s.Stack_AddComponent, I18n.T(" 更多可堆叠", " More Stacking"), ToggleStyle ?? GUI.skin.toggle);
        if (remTool != s.RememberBreakdownTool) { s.RememberBreakdownTool = remTool; changed = true; }
        if (b != s.Stack_AddComponent) { s.Stack_AddComponent = b; changed = true; }
        y2 += ROW_ADV;
        bool maxHp = Ui.Toggle("Stack_UseMaxHP", R(c2,    y2, subTogW, ROW_H), s.Stack_UseMaxHP, I18n.T(" 合并取最高", " Merge at Max HP"), ToggleStyle ?? GUI.skin.toggle);
        if (maxHp != s.Stack_UseMaxHP) { s.Stack_UseMaxHP = maxHp; changed = true; }
        y2 += ROW_ADV + SECTION_END_ADV;

        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("其他便利功能", "Misc QoL"));
        bool mapOn  = Ui.Toggle("QoL_MapTextOutlineEnabled", R(c2,    y2, subTogW, ROW_H), s.QoL_MapTextOutlineEnabled, I18n.T(" 地图描边", " Map Outline"), ToggleStyle ?? GUI.skin.toggle);
        bool noSave = Ui.Toggle("QoL_NoSaveOnSprain", R(c2Sub, y2, subTogW, ROW_H), s.QoL_NoSaveOnSprain,        I18n.T(" 扭伤不存", " No Save Sprain"), ToggleStyle ?? GUI.skin.toggle);
        if (mapOn != s.QoL_MapTextOutlineEnabled) { s.QoL_MapTextOutlineEnabled = mapOn; changed = true; }
        if (noSave != s.QoL_NoSaveOnSprain) { s.QoL_NoSaveOnSprain = noSave; changed = true; }
        y2 += ROW_ADV;
        bool noFallSpr = Ui.Toggle("QoL_NoSaveOnSprainFalls", R(c2,    y2, subTogW, ROW_H), s.QoL_NoSaveOnSprainFalls, I18n.T(" 含坠扭伤", " Include Falls"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        // 剧情版:埋葬尸体挂 SaveGameSystem.Save/LoadSceneData,写持久场景存档 → 禁用灰显。
        bool _buryBlocked = StoryGuard.InStory;
        if (_buryBlocked) GUI.enabled = false;
#endif
        bool bury      = Ui.Toggle("QoL_BuryCorpses", R(c2Sub, y2, subTogW, ROW_H), s.QoL_BuryCorpses,         I18n.T(" 埋葬尸体", " Bury Corpses"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        if (_buryBlocked) GUI.enabled = true;
#endif
        if (noFallSpr != s.QoL_NoSaveOnSprainFalls) { s.QoL_NoSaveOnSprainFalls = noFallSpr; changed = true; }
        if (bury != s.QoL_BuryCorpses) { s.QoL_BuryCorpses = bury; changed = true; }
        y2 += ROW_ADV;
        bool wakeUp = Ui.Toggle("QoL_WakeUpCall", R(c2,    y2, subTogW, ROW_H), s.QoL_WakeUpCall,  I18n.T(" 睡眠中可醒", " Wake Option"), ToggleStyle ?? GUI.skin.toggle);
        bool aurora = Ui.Toggle("QoL_AuroraSense", R(c2Sub, y2, subTogW, ROW_H), s.QoL_AuroraSense, I18n.T(" 极光时叫醒", " Aurora Wake"), ToggleStyle ?? GUI.skin.toggle);
        if (wakeUp != s.QoL_WakeUpCall) { s.QoL_WakeUpCall = wakeUp; changed = true; }
        if (aurora != s.QoL_AuroraSense) { s.QoL_AuroraSense = aurora; changed = true; }
        y2 += ROW_ADV;
        bool showT = Ui.Toggle("QoL_ShowTimeSleep", R(c2,    y2, subTogW, ROW_H), s.QoL_ShowTimeSleep, I18n.T(" 睡眠显示时间", " Sleep Clock"), ToggleStyle ?? GUI.skin.toggle);
        bool noPB  = Ui.Toggle("QoL_NoPitchBlack", R(c2Sub, y2, subTogW, ROW_H), s.QoL_NoPitchBlack,  I18n.T(" 不要纯黑", " No Pitch Black"), ToggleStyle ?? GUI.skin.toggle);
        if (showT != s.QoL_ShowTimeSleep) { s.QoL_ShowTimeSleep = showT; changed = true; }
        if (noPB != s.QoL_NoPitchBlack) { s.QoL_NoPitchBlack = noPB; changed = true; }
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

        // ——— Column 3: 商人 & 美洲狮 + 高级微调 ———

        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("商人 & 美洲狮", "Trader & Cougar"));
#if STORY_GUARD
        // 剧情版:整套无线电商人 + 美洲狮到货是沙盒专属系统,剧情里目标对象不存在。
        // 灰显整段(仍可见,便于用户理解为何禁用),StoryGuard 已在后台强制清零对应开关。
        bool _traderBlocked = StoryGuard.InStory;
        if (_traderBlocked) GUI.enabled = false;
#endif
        bool tul = Ui.Toggle("TraderUnlimitedList", R(c3,    y3, subTogW, ROW_H), s.TraderUnlimitedList,   I18n.T(" 交易扩充", " More Trades"), ToggleStyle ?? GUI.skin.toggle);
        bool tmt = Ui.Toggle("TraderMaxTrust", R(c3Sub, y3, subTogW, ROW_H), s.TraderMaxTrust,       I18n.T(" 信任满值", " Max Trust"), ToggleStyle ?? GUI.skin.toggle);
        y3 += ROW_ADV;
        bool tix = Ui.Toggle("TraderInstantExchange", R(c3,    y3, subTogW, ROW_H), s.TraderInstantExchange, I18n.T(" 即时交易", " Instant Trade"), ToggleStyle ?? GUI.skin.toggle);
        bool taa = Ui.Toggle("TraderAlwaysAvailable", R(c3Sub, y3, subTogW, ROW_H), s.TraderAlwaysAvailable, I18n.T(" 商人常驻", " Always Online"), ToggleStyle ?? GUI.skin.toggle);
        y3 += ROW_ADV;
        bool cia = Ui.Toggle("CougarInstantActivate", R(c3,    y3, subTogW, ROW_H), s.CougarInstantActivate, I18n.T(" 召唤美洲狮", " Spawn Cougar"), ToggleStyle ?? GUI.skin.toggle);
        bool stt = Ui.Toggle("TT_ShowTraderTrust", R(c3Sub, y3, subTogW, ROW_H), s.TT_ShowTraderTrust,   I18n.T(" 显示信任度", " Show Trust"), ToggleStyle ?? GUI.skin.toggle);
        y3 += ROW_ADV;
        float td = DrawSliderCol3(R, c3, y3, I18n.T("到来(天)", "Arrival"), s.TraderArrivalDays, 1f, 40f, "F0", key: "TraderArrivalDays");
        if ((int)td != (int)s.TraderArrivalDays) { s.TraderArrivalDays = (int)td; changed = true; }
        y3 += ROW_ADV;
        int curTrust = 0;
        float trustMin = 0f, trustMax = 500f;
#if !STORY_EDITION
        // 2.24 无商人系统(GameManager.GetTraderManager 不存在);StoryGuard 已强制关掉整组
        // 商人开关,这里滑条读不到值就固定显示 0,UI 结构保持一致不动。
        try
        {
            var tm2 = Il2Cpp.GameManager.GetTraderManager();
            if (tm2?.m_CurrentState != null)
            {
                curTrust = tm2.m_CurrentState.m_CurrentTrust;
                trustMin = tm2.m_MinTrustLevel; trustMax = tm2.m_MaxTrustLevel;
                // 信任满值一打开就拉满,不等下次打开交易清单,滑条也立刻跟着变
                if (tmt && curTrust < tm2.m_MaxTrustLevel)
                {
                    TraderTrust.HealOnce(tm2);
                    TraderTrust.Set(tm2, tm2.m_MaxTrustLevel);
                    curTrust = tm2.m_CurrentState.m_CurrentTrust;
                }
            }
        }
        catch { }
#endif
        // 信任满值开着时滑条拖不动,不然拖下去下次打开交易清单又被拉回满值
        bool guiWas = GUI.enabled;
        if (tmt) GUI.enabled = false;
        float trustSlider = DrawSliderCol3(R, c3, y3, I18n.T("信任值", "Trust"), curTrust, trustMin, trustMax, "F0");
        GUI.enabled = guiWas;
        if (!tmt && (int)trustSlider != curTrust)
        {
            // 历史最高只升不降、升上去时补对应的解锁,都照原版(见 TraderTrust)
#if !STORY_EDITION
            try
            {
                var tm2 = Il2Cpp.GameManager.GetTraderManager();
                if (tm2?.m_CurrentState != null) { TraderTrust.HealOnce(tm2); TraderTrust.Set(tm2, (int)trustSlider); }
            }
            catch { }
#endif
        }
        y3 += ROW_ADV + SECTION_END_ADV;
        if (tul != s.TraderUnlimitedList || tmt != s.TraderMaxTrust
            || tix != s.TraderInstantExchange || taa != s.TraderAlwaysAvailable
            || cia != s.CougarInstantActivate || stt != s.TT_ShowTraderTrust)
        {
            s.TraderUnlimitedList = tul; s.TraderMaxTrust = tmt;
            s.TraderInstantExchange = tix; s.TraderAlwaysAvailable = taa;
            s.CougarInstantActivate = cia; s.TT_ShowTraderTrust = stt;
            CheatState.TraderUnlimitedList = tul; CheatState.TraderMaxTrust = tmt;
            CheatState.TraderInstantExchange = tix; CheatState.TraderAlwaysAvailable = taa;
            CheatState.CougarInstantActivate = cia; CheatState.TT_ShowTraderTrust = stt;
            changed = true;
        }
#if STORY_GUARD
        if (_traderBlocked) GUI.enabled = true;   // 恢复,勿影响后续控件
#endif

        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("高级微调", "Advanced Tweaks"));
        bool pauseRad = Ui.Toggle("TT_PauseOnRadial", R(c3,    y3, subTogW, ROW_H), s.TT_PauseOnRadial, I18n.T(" 开轮盘减速", " Radial Slowmo"), ToggleStyle ?? GUI.skin.toggle);
        bool dropOri  = Ui.Toggle("TT_DroppedOrientation", R(c3Sub, y3, subTogW, ROW_H), s.TT_DroppedOrientation, I18n.T(" 步枪落地竖放", " Rifle Upright"), ToggleStyle ?? GUI.skin.toggle);
        if (pauseRad != s.TT_PauseOnRadial) { s.TT_PauseOnRadial = pauseRad; CheatState.TT_PauseOnRadial = pauseRad; changed = true; }
        if (dropOri != s.TT_DroppedOrientation) { s.TT_DroppedOrientation = dropOri; CheatState.TT_DroppedOrientation = dropOri; changed = true; }
        y3 += ROW_ADV;

        bool deathGoat = Ui.Toggle("TT_FallDeathGoat", R(c3, y3, COL_TOG_W3, ROW_H), s.TT_FallDeathGoat, I18n.T(" 无视坠落即死墙", " Ignore Fall Death Walls"), ToggleStyle ?? GUI.skin.toggle);
        if (deathGoat != s.TT_FallDeathGoat) { s.TT_FallDeathGoat = deathGoat; CheatState.TT_FallDeathGoat = deathGoat; changed = true; }
        y3 += ROW_ADV;
        v = DrawSliderCol3(R, c3, y3, I18n.T("坠落伤害/米", "Fall Dmg/m"), (float)s.TT_FallDamageMult, 1f, 12f, "F0", key: "TT_FallDamageMult");
        if ((int)v != s.TT_FallDamageMult) { s.TT_FallDamageMult = (int)v; changed = true; }
        y3 += ROW_ADV;

        bool capFeels = Ui.Toggle("TT_CapFeelsEnabled", R(c3, y3, COL_TOG_W3, ROW_H), s.TT_CapFeelsEnabled, I18n.T(" 限制体感温度", " Cap Feels-Like Temp"), ToggleStyle ?? GUI.skin.toggle);
        if (capFeels != s.TT_CapFeelsEnabled) { s.TT_CapFeelsEnabled = capFeels; CheatState.TT_CapFeelsEnabled = capFeels; changed = true; }
        y3 += ROW_ADV;
        Ui.Dim(!s.TT_CapFeelsEnabled);
        v = DrawSliderCol3(R, c3, y3, I18n.T("体感上限(℃)", "High Cap(℃)"), (float)s.TT_CapFeelsHigh, -10f, 50f, "F0", key: "TT_CapFeelsHigh");
        if ((int)v != s.TT_CapFeelsHigh) { s.TT_CapFeelsHigh = (int)v; changed = true; }
        y3 += ROW_ADV;
        v = DrawSliderCol3(R, c3, y3, I18n.T("体感下限(℃)", "Low Cap(℃)"), (float)s.TT_CapFeelsLow, -50f, 10f, "F0", key: "TT_CapFeelsLow");
        if ((int)v != s.TT_CapFeelsLow) { s.TT_CapFeelsLow = (int)v; changed = true; }
        Ui.Dim(false);
        y3 += ROW_ADV;

#if STORY_GUARD
        // 剧情版:植物重生挂 SaveGameSystem.Save/LoadSceneData,写持久场景存档 → 禁用灰显。
        bool _respawnBlocked = StoryGuard.InStory;
        if (_respawnBlocked) GUI.enabled = false;
#endif
        bool respawn = Ui.Toggle("TT_RespawnPlants", R(c3, y3, COL_TOG_W3, ROW_H), s.TT_RespawnPlants, I18n.T(" 植物重生", " Respawn Plants"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        if (_respawnBlocked) GUI.enabled = true;
#endif
        if (respawn != s.TT_RespawnPlants) { s.TT_RespawnPlants = respawn; CheatState.TT_RespawnPlants = respawn; changed = true; }
        y3 += ROW_ADV;
        Ui.Dim(!s.TT_RespawnPlants);
        v = DrawSliderCol3(R, c3, y3, I18n.T("重生天数", "Respawn Days"), (float)s.TT_PlantRespawnDays, 1f, 365f, "F0", key: "TT_PlantRespawnDays");
        if ((int)v != s.TT_PlantRespawnDays) { s.TT_PlantRespawnDays = (int)v; changed = true; }
        Ui.Dim(false);
        y3 += ROW_ADV + SECTION_END_ADV;

        if (changed) s.RequestSave();
        return Mathf.Max(y1, Mathf.Max(y2, y3));
    }

    // ═══════════════════════════════════════════════════════════════════════
    // Tab 5 灯火 & 视觉:c1 火把&手电/煤油灯 | c2 室内灯光/准星 | c3 视角&FOV/杂项开关
    // ═══════════════════════════════════════════════════════════════════════
    internal static float DrawLightAndCraftTab(Func<float, float, float, float, Rect> R, TldHacksSettings s)
    {
        float c1 = ColX(0), c2 = ColX(1), c3 = ColX(2);
        float subTogW = HALF_W;
        float c1Sub = c1 + HALF_OFF;
        float c3Sub = c3 + HALF_OFF;
        float y1 = 6f, y2 = 6f, y3 = 6f;
        bool changed = false;
        float v;
        bool b;

        // ——— c1: 火把 & 手电 + 煤油灯 | c2/c3: 视觉(MenuTweaks.Gfx.cs)| c3: 杂项开关 ———

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("火把 & 手电", "Torch & Flashlight"));
        v = DrawSliderCol3(R, c1, y1, I18n.T("燃烧时间(分)", "Burn Time"), s.TorchBurnMinutes, 1f, 2880f, "F0", key: "TorchBurnMinutes");
        if (v != s.TorchBurnMinutes) { s.TorchBurnMinutes = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("最小状态", "Min Cond"), s.TorchMinCondition, 0f, 1f, "F2", key: "TorchMinCondition");
        if (v != s.TorchMinCondition) { s.TorchMinCondition = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("最大状态", "Max Cond"), s.TorchMaxCondition, 0f, 1f, "F2", key: "TorchMaxCondition");
        if (v != s.TorchMaxCondition) { s.TorchMaxCondition = v; changed = true; }
        y1 += ROW_ADV;
        bool dtlc = Ui.Toggle("DisableTorchLeftClick", R(c1,    y1, subTogW, ROW_H), s.DisableTorchLeftClick, I18n.T(" 锁火把键", " Lock Torch"), ToggleStyle ?? GUI.skin.toggle);
        bool flashInf = Ui.Toggle("UT_FlashInfiniteBattery", R(c1Sub, y1, subTogW, ROW_H), s.UT_FlashInfiniteBattery, I18n.T(" 手电无限电", " Inf. Battery"), ToggleStyle ?? GUI.skin.toggle);
        if (dtlc != s.DisableTorchLeftClick) { s.DisableTorchLeftClick = dtlc; CheatState.DisableTorchLeftClick = dtlc; changed = true; }
        if (flashInf != s.UT_FlashInfiniteBattery) { s.UT_FlashInfiniteBattery = flashInf; changed = true; }
        y1 += ROW_ADV + SECTION_END_ADV;

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("煤油灯", "Kerosene Lamp"));
        v = DrawSliderCol3(R, c1, y1, I18n.T("放置消耗", "Placed"), s.LampPlacedBurnMult, 0f, 2f, "F2", key: "LampPlacedBurnMult");
        if (v != s.LampPlacedBurnMult) { s.LampPlacedBurnMult = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("手持消耗", "Held"), s.LampHeldBurnMult, 0f, 2f, "F2", key: "LampHeldBurnMult");
        if (v != s.LampHeldBurnMult) { s.LampHeldBurnMult = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("开启耗损%", "TurnOn"), s.LampTurnOnDecay, 0f, 2f, "F2", key: "LampTurnOnDecay");
        if (v != s.LampTurnOnDecay) { s.LampTurnOnDecay = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("持续耗损%/h", "OverTime"), s.LampOverTimeDecay, 0f, 1f, "F2", key: "LampOverTimeDecay");
        if (v != s.LampOverTimeDecay) { s.LampOverTimeDecay = v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("惩罚阈值HP%", "Penalty"), (float)s.LampConditionThreshold, 0f, 100f, "F0", key: "LampConditionThreshold");
        if ((int)v != s.LampConditionThreshold) { s.LampConditionThreshold = (int)v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("最大惩罚%", "MaxPenalty"), (float)s.LampMaxPenalty, 0f, 200f, "F0", key: "LampMaxPenalty");
        if ((int)v != s.LampMaxPenalty) { s.LampMaxPenalty = (int)v; changed = true; }
        y1 += ROW_ADV;
        v = DrawSliderCol3(R, c1, y1, I18n.T("光照范围", "Light Range"), s.LampRangeMultiplier, 0.5f, 5f, "F2", key: "LampRangeMultiplier");
        if (v != s.LampRangeMultiplier) { s.LampRangeMultiplier = v; changed = true; }
        y1 += ROW_ADV;
        bool lmute = Ui.Toggle("LampMute", R(c1,    y1, subTogW, ROW_H), s.LampMute, I18n.T(" 放置静音", " Mute Placed"), ToggleStyle ?? GUI.skin.toggle);
        bool dllc = Ui.Toggle("DisableLampLeftClick", R(c1Sub, y1, subTogW, ROW_H), s.DisableLampLeftClick, I18n.T(" 锁油灯键", " Lock Lamp"), ToggleStyle ?? GUI.skin.toggle);
        if (lmute != s.LampMute) { s.LampMute = lmute; CheatState.LampMute = lmute; changed = true; }
        if (dllc != s.DisableLampLeftClick) { s.DisableLampLeftClick = dllc; CheatState.DisableLampLeftClick = dllc; changed = true; }
        y1 += ROW_ADV + SECTION_END_ADV;

        changed |= DrawVisualCards(R, s, c2, c3, ref y2, ref y3);

        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("杂项开关", "Misc Toggles"));
        b = Ui.Toggle("UT_BreathVisibility", R(c3,    y3, subTogW, ROW_H), s.UT_BreathVisibility,    I18n.T(" 哈气特效", " Breath"), ToggleStyle ?? GUI.skin.toggle);
        bool bb = Ui.Toggle("UT_FeatProgressInCustom", R(c3Sub, y3, subTogW, ROW_H), s.UT_FeatProgressInCustom, I18n.T(" 难度徽章", " Feat Custom"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_BreathVisibility) { s.UT_BreathVisibility = b; changed = true; }
        if (bb != s.UT_FeatProgressInCustom) { s.UT_FeatProgressInCustom = bb; changed = true; }
        y3 += ROW_ADV;
        b  = Ui.Toggle("UT_RandomizedItemRotation", R(c3,    y3, subTogW, ROW_H), s.UT_RandomizedItemRotation, I18n.T(" 随机朝向", " Random Rot"), ToggleStyle ?? GUI.skin.toggle);
        bb = Ui.Toggle("UT_RevolverImprovements", R(c3Sub, y3, subTogW, ROW_H), s.UT_RevolverImprovements,   I18n.T(" 左轮可走", " Revolver Walk"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_RandomizedItemRotation) { s.UT_RandomizedItemRotation = b; changed = true; }
        if (bb != s.UT_RevolverImprovements) { s.UT_RevolverImprovements = bb; changed = true; }
        y3 += ROW_ADV;
        b  = Ui.Toggle("UT_RemoveHeadacheDebuff", R(c3,    y3, subTogW, ROW_H), s.UT_RemoveHeadacheDebuff, I18n.T(" 免甜点疼", " No Pie Ache"), ToggleStyle ?? GUI.skin.toggle);
        bb = Ui.Toggle("UT_RockCacheIndoors", R(c3Sub, y3, subTogW, ROW_H), s.UT_RockCacheIndoors,     I18n.T(" 室内贮石", " Indoor Rocks"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_RemoveHeadacheDebuff) { s.UT_RemoveHeadacheDebuff = b; changed = true; }
        if (bb != s.UT_RockCacheIndoors) { s.UT_RockCacheIndoors = bb; changed = true; }
        y3 += ROW_ADV;
        b  = Ui.Toggle("UT_GlowingDecals", R(c3,    y3, subTogW, ROW_H), s.UT_GlowingDecals,             I18n.T(" 高亮喷漆", " Glow Decals"), ToggleStyle ?? GUI.skin.toggle);
        bb = Ui.Toggle("UT_TravoisOverrideMovement", R(c3Sub, y3, subTogW, ROW_H), s.UT_TravoisOverrideMovement,   I18n.T(" 雪橇可动", " Travois Move"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_GlowingDecals) { s.UT_GlowingDecals = b; changed = true; }
        if (bb != s.UT_TravoisOverrideMovement) { s.UT_TravoisOverrideMovement = bb; changed = true; }
        y3 += ROW_ADV;
        b  = Ui.Toggle("UT_TravoisOverrideInteraction", R(c3,    y3, subTogW, ROW_H), s.UT_TravoisOverrideInteraction, I18n.T(" 雪橇可拿", " Travois Int"), ToggleStyle ?? GUI.skin.toggle);
        bb = Ui.Toggle("UT_ToiletWaterPotable", R(c3Sub, y3, subTogW, ROW_H), s.UT_ToiletWaterPotable,         I18n.T(" 马桶可饮", " Toilet Potable"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_TravoisOverrideInteraction) { s.UT_TravoisOverrideInteraction = b; changed = true; }
        if (bb != s.UT_ToiletWaterPotable) { s.UT_ToiletWaterPotable = bb; changed = true; }
        y3 += ROW_ADV;
        // v9.0 搬运猎物 / 搬运全部 挪到「人物 & 操作」单独成块,极光点火补到这一行右格
        b  = Ui.Toggle("UT_ConsistantDressingWeight", R(c3,    y3, subTogW, ROW_H), s.UT_ConsistantDressingWeight, I18n.T(" 绷带统重", " Bandage Weight"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.UT_ConsistantDressingWeight) { s.UT_ConsistantDressingWeight = b; changed = true; }
#if STORY_GUARD
        // 剧情版:极光点火挂 MissionServicesManager 任务注册 → 禁用灰显
        bool _worldBlocked = StoryGuard.InStory;
        if (_worldBlocked) GUI.enabled = false;
#endif
        bb = Ui.Toggle("World_ElectricTorch", R(c3Sub, y3, subTogW, ROW_H), s.World_ElectricTorch, I18n.T(" 极光点火", " Aurora Torch"), ToggleStyle ?? GUI.skin.toggle);
#if STORY_GUARD
        if (_worldBlocked) GUI.enabled = true;
#endif
        if (bb != s.World_ElectricTorch) { s.World_ElectricTorch = bb; CheatState.World_ElectricTorch = bb; changed = true; }
        y3 += ROW_ADV + SECTION_END_ADV;

        if (changed) s.RequestSave();
        return Mathf.Max(y1, Mathf.Max(y2, y3));
    }
}
