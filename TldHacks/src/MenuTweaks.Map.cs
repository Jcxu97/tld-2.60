using System;
using UnityEngine;

namespace TldHacks;

internal static partial class MenuTweaks
{
    private static readonly string[] OutlineZh = { "黑字棕描边", "黑字白描边", "米白字黑描边", "白字黑描边" };
    private static readonly string[] OutlineEn = { "Black on brown", "Black on white", "Cream on black", "White on black" };

#if !STORY_EDITION
    private static string NeedMapM(TldHacksSettings s) => s.MapM_Enabled ? null : I18n.T("要先开地图管理", "Needs Map Manager");
#endif

    // 地图 & 界面页的地图卡片,每组画在 x 列、从 y 开始,返回画完后的 y
    // 第 1 组:地图管理 + 地图显示
    internal static float MapCardsManage(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        float subTogW = HALF_W, xSub = x + HALF_OFF;
        bool b;
        var ts = ToggleStyle ?? GUI.skin.toggle;

#if !STORY_EDITION
        y = SectionCol(R, x, y, COL_W3, I18n.T("地图管理", "Map Manager"), "MapM_Enabled", ref s.MapM_Enabled, ref changed,
            MapM.StandaloneLoaded ? I18n.T("先删独立版", "Remove old mod") : null);
        b = Ui.Toggle("MapM_PlayerArrow", R(x, y, subTogW, ROW_H), s.MapM_PlayerArrow, I18n.T(" 玩家箭头", " Player Arrow"), ts);
        if (b != s.MapM_PlayerArrow) { s.MapM_PlayerArrow = b; changed = true; }
        b = Ui.Toggle("MapM_CenterOnPlayer", R(xSub, y, subTogW, ROW_H), s.MapM_CenterOnPlayer, I18n.T(" 以玩家居中", " Center on Me"), ts);
        if (b != s.MapM_CenterOnPlayer) { s.MapM_CenterOnPlayer = b; changed = true; }
        y += ROW_ADV;
        b = Ui.Toggle("MapM_RevealVista", R(x, y, subTogW, ROW_H), s.MapM_RevealVista, I18n.T(" 显示远景点", " Show Vistas"), ts);
        if (b != s.MapM_RevealVista) { s.MapM_RevealVista = b; changed = true; }
        b = Ui.Toggle("MapM_VistaNoPolaroid", R(xSub, y, subTogW, ROW_H), s.MapM_VistaNoPolaroid, I18n.T(" 不用宝丽来", " No Polaroid"), ts);
        if (b != s.MapM_VistaNoPolaroid) { s.MapM_VistaNoPolaroid = b; changed = true; }
        y += ROW_ADV;
        b = Ui.Toggle("MapM_CorpseOnMap", R(x, y, subTogW, ROW_H), s.MapM_CorpseOnMap, I18n.T(" 尸体上地图", " Corpses on Map"), ts);
        if (b != s.MapM_CorpseOnMap) { s.MapM_CorpseOnMap = b; changed = true; }
        b = Ui.Toggle("MapM_HideHarvested", R(xSub, y, subTogW, ROW_H), s.MapM_HideHarvested, I18n.T(" 采完图标消失", " Hide Harvested"), ts);
        if (b != s.MapM_HideHarvested) { s.MapM_HideHarvested = b; changed = true; }
        y += ROW_ADV;
        y = KeyRow(R, x, y, I18n.T("当前区域全开", "Reveal Region"), s.MapM_RevealKey);
        y += SECTION_END_ADV;
#endif

        y = SectionCol(R, x, y, COL_W3, I18n.T("地图显示", "Map Display"));
        b = Ui.Toggle("QoL_MapTextOutlineEnabled", R(x, y, subTogW, ROW_H), s.QoL_MapTextOutlineEnabled, I18n.T(" 地图描边", " Map Outline"), ts);
        bool outlineChanged = false;
        if (b != s.QoL_MapTextOutlineEnabled) { s.QoL_MapTextOutlineEnabled = b; changed = outlineChanged = true; }
        b = Ui.Toggle("QoL_AutoOpenMapOnExit", R(xSub, y, subTogW, ROW_H), s.QoL_AutoOpenMapOnExit, I18n.T(" 出门开小地图", " Minimap Outside"), ts);
        if (b != s.QoL_AutoOpenMapOnExit) { s.QoL_AutoOpenMapOnExit = b; changed = true; }
        y += ROW_ADV;
        Ui.Dim(!s.QoL_MapTextOutlineEnabled);
        Ui.Hover("QoL_MapTextOutline", R(x, y, COL_W3, ROW_H));
        GUI.Label(R(x, y, LBL_W, ROW_H), I18n.T("文字样式", "Text Style"), LabelStyle ?? GUI.skin.label);
        int style = Mathf.Clamp(s.QoL_MapTextOutline, 0, OutlineZh.Length - 1);
        if (GUI.Button(R(x + LBL_W, y, COL_W3 - LBL_W, ROW_H), (I18n.IsEnglish ? OutlineEn : OutlineZh)[style]))
        { s.QoL_MapTextOutline = (style + 1) % OutlineZh.Length; changed = outlineChanged = true; }
        Ui.Dim(false);
        if (outlineChanged)
        {
            CheatState.QoL_MapTextOutline = s.QoL_Enabled && s.QoL_MapTextOutlineEnabled;
            Patch_MapTextOutline.Apply();
        }
        y += ROW_ADV + SECTION_END_ADV;
        return y;
    }

    // 第 2 组:木炭绘图 + 自动测绘
    internal static float MapCardsSurvey(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        float v;
        bool b;
        var ts = ToggleStyle ?? GUI.skin.toggle;

#if !STORY_EDITION
        y = SectionCol(R, x, y, COL_W3, I18n.T("木炭绘图", "Charcoal Mapping"), NeedMapM(s));
        Ui.Dim(!s.MapM_Enabled);
        v = DrawSliderCol3(R, x, y, I18n.T("绘图范围", "Range"), s.MapM_SurveyRange, 1f, 25f, "F1", key: "MapM_SurveyRange");
        if (v != s.MapM_SurveyRange) { s.MapM_SurveyRange = v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("绘图时间", "Time"), s.MapM_SurveyTime, 0.1f, 5f, "F2", key: "MapM_SurveyTime");
        if (v != s.MapM_SurveyTime) { s.MapM_SurveyTime = v; changed = true; }
        y += ROW_ADV;
        b = Ui.Toggle("MapM_UnlockSurvey", R(x, y, COL_TOG_W3, ROW_H), s.MapM_UnlockSurvey, I18n.T(" 随时能绘图", " Survey Anytime"), ts);
        if (b != s.MapM_UnlockSurvey) { s.MapM_UnlockSurvey = b; changed = true; }
        Ui.Dim(false);
        y += ROW_ADV + SECTION_END_ADV;
#endif

        y = SectionCol(R, x, y, COL_W3, I18n.T("自动测绘", "Auto Survey"), "QoL_AutoSurvey", ref s.QoL_AutoSurvey, ref changed);
        v = DrawSliderCol3(R, x, y, I18n.T("绘制间隔(秒)", "Interval"), s.QoL_AutoSurveyDelay, 1f, 60f, "F0", key: "QoL_AutoSurveyDelay");
        if (v != s.QoL_AutoSurveyDelay) { s.QoL_AutoSurveyDelay = v; changed = true; }
        y += ROW_ADV;
        v = DrawSliderCol3(R, x, y, I18n.T("范围倍率", "Range"), s.QoL_AutoSurveyRange, 0.1f, 10f, "F1", key: "QoL_AutoSurveyRange");
        if (v != s.QoL_AutoSurveyRange) { s.QoL_AutoSurveyRange = v; changed = true; }
        y += ROW_ADV;
        b = Ui.Toggle("QoL_AutoSurveyUnlock", R(x, y, COL_TOG_W3, ROW_H), s.QoL_AutoSurveyUnlock, I18n.T(" 无视天气限制", " Ignore Weather"), ts);
        if (b != s.QoL_AutoSurveyUnlock) { s.QoL_AutoSurveyUnlock = b; changed = true; }
        y += ROW_ADV + SECTION_END_ADV;
        return y;
    }

    internal static float CardCollectibles(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
#if !STORY_EDITION && !EP5_EDITION
        float subTogW = HALF_W, xSub = x + HALF_OFF;
        bool b;
        var ts = ToggleStyle ?? GUI.skin.toggle;
        y = SectionCol(R, x, y, COL_W3, I18n.T("收藏品地图", "Collectibles Map"), "Coll_Enabled", ref s.Coll_Enabled, ref changed);
        b = Ui.Toggle("Coll_Cairn", R(x, y, subTogW, ROW_H), s.Coll_Cairn, I18n.T(" 石堆", " Cairns"), ts);
        if (b != s.Coll_Cairn) { s.Coll_Cairn = b; changed = true; }
        b = Ui.Toggle("Coll_Note", R(xSub, y, subTogW, ROW_H), s.Coll_Note, I18n.T(" 纸条和日志", " Notes"), ts);
        if (b != s.Coll_Note) { s.Coll_Note = b; changed = true; }
        y += ROW_ADV;
        b = Ui.Toggle("Coll_Polaroid", R(x, y, subTogW, ROW_H), s.Coll_Polaroid, I18n.T(" 拍立得", " Polaroids"), ts);
        if (b != s.Coll_Polaroid) { s.Coll_Polaroid = b; changed = true; }
        b = Ui.Toggle("Coll_ShowCollected", R(xSub, y, subTogW, ROW_H), s.Coll_ShowCollected, I18n.T(" 收过的也标", " Show Collected"), ts);
        if (b != s.Coll_ShowCollected) { s.Coll_ShowCollected = b; changed = true; }
        y += ROW_ADV + SECTION_END_ADV;
#endif

        return y;
    }

    internal static float CardBunkers(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
#if !STORY_EDITION
        float subTogW = HALF_W, xSub = x + HALF_OFF;
        bool b;
        var ts = ToggleStyle ?? GUI.skin.toggle;
        y = SectionCol(R, x, y, COL_W3, I18n.T("地堡", "Bunkers"), NeedMapM(s));
        Ui.Dim(!s.MapM_Enabled);
        b = Ui.Toggle("MapM_FillEmptyBunkers", R(x, y, subTogW, ROW_H), s.MapM_FillEmptyBunkers, I18n.T(" 完整地堡", " Full Bunkers"), ts);
        if (b != s.MapM_FillEmptyBunkers) { s.MapM_FillEmptyBunkers = b; changed = true; }
        b = Ui.Toggle("MapM_InterloperBunker", R(xSub, y, subTogW, ROW_H), s.MapM_InterloperBunker, I18n.T(" 高难度刷地堡", " Bunkers on Hard"), ts);
        if (b != s.MapM_InterloperBunker) { s.MapM_InterloperBunker = b; changed = true; }
        y += ROW_ADV;
        y = KeyRow(R, x, y, I18n.T("显示地堡", "Show Bunkers"), s.MapM_BunkerKey);
        Ui.Dim(false);
        y += SECTION_END_ADV;
#endif
        return y;
    }
}
