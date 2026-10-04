#if !STORY_EDITION
using System;
using UnityEngine;

namespace TldHacks;

internal static partial class MenuTweaks
{
    // 物资 & 世界页最下面一排:c1 野外 | c2 容器 & 极光 | c3 死亡 & 扑倒
    internal static float DrawCeCards(Func<float, float, float, float, Rect> R, TldHacksSettings s, float y0)
    {
        float c1 = ColX(0), c2 = ColX(1), c3 = ColX(2);
        float y1 = y0, y2 = y0, y3 = y0;
        bool changed = false;
        var ts = ToggleStyle ?? GUI.skin.toggle;

        void Tog(string key, float x, float y, float w, ref bool field, string zh, string en)
        {
            bool b = Ui.Toggle(key, R(x, y, w, ROW_H), field, I18n.T(zh, en), ts);
            if (b != field) { field = b; changed = true; }
        }

        y1 = SectionCol(R, c1, y1, COL_W3, I18n.T("野外", "Outdoors"));
        Tog("CE_SnareSure", c1, y1, HALF_W, ref s.CE_SnareSure, " 陷阱必中", " Sure Snares");
        Ui.Dim(!s.CE_SnareSure);
        Tog("CE_SnareInstant", c1 + HALF_OFF, y1, HALF_W, ref s.CE_SnareInstant, " 放下就抓到", " Catch at Once");
        Ui.Dim(false);
        y1 += ROW_ADV;
        Tog("CE_IceHoleNoFreeze", c1, y1, HALF_W, ref s.CE_IceHoleNoFreeze, " 冰洞不冻上", " Holes Stay Open");
        Tog("CE_NoSlide", c1 + HALF_OFF, y1, HALF_W, ref s.CE_NoSlide, " 坡上不打滑", " No Slope Slide");
        y1 += ROW_ADV + SECTION_END_ADV;

        y2 = SectionCol(R, c2, y2, COL_W3, I18n.T("容器 & 极光", "Containers & Aurora"));
        Tog("CE_LootNoEmpty", c2, y2, HALF_W, ref s.CE_LootNoEmpty, " 容器不开空", " No Empty Loot");
        Tog("CE_LootLowerTier", c2 + HALF_OFF, y2, HALF_W, ref s.CE_LootLowerTier, " 低一档难度", " Easier Loot");
        y2 += ROW_ADV;
        Tog("CE_AuroraRefill", c2, y2, COL_TOG_W3, ref s.CE_AuroraRefill, " 极光夜刷新空容器", " Aurora Refills Containers");
        y2 += ROW_ADV;
        Tog("CE_AuroraLightSteady", c2, y2, HALF_W, ref s.CE_AuroraLightSteady, " 电灯常亮", " Steady Lights");
        Tog("CE_AuroraMute", c2 + HALF_OFF, y2, HALF_W, ref s.CE_AuroraMute, " 关极光音效", " Mute Aurora");
        y2 += ROW_ADV + SECTION_END_ADV;

        y3 = SectionCol(R, c3, y3, COL_W3, I18n.T("死亡 & 扑倒", "Death & Struggle"));
        Tog("CE_NoDeath", c3, y3, HALF_W, ref s.CE_NoDeath, " 死亡不删档", " No Death");
        Tog("CE_NoMisery", c3 + HALF_OFF, y3, HALF_W, ref s.CE_NoMisery, " 厄难不生成", " No Misery");
        y3 += ROW_ADV;
        Tog("CE_StruggleWin", c3, y3, HALF_W, ref s.CE_StruggleWin, " 扑倒必胜", " Win Struggles");
        Tog("CE_NoStun", c3 + HALF_OFF, y3, HALF_W, ref s.CE_NoStun, " 扑倒不眩晕", " No Daze");
        y3 += ROW_ADV + SECTION_END_ADV;

        if (changed) s.RequestSave();
        return Mathf.Max(y1, Mathf.Max(y2, y3));
    }
}
#endif
