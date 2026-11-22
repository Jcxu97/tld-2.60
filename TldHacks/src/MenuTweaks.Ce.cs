#if !STORY_EDITION
using System;
using UnityEngine;

namespace TldHacks;

internal static partial class MenuTweaks
{
    // 野外 / 容器 & 极光 / 死亡 & 扑倒 三张卡,每张画在 x 列、从 y 开始,返回画完后的 y
    private static bool CeTog(Func<float, float, float, float, Rect> R, string key, float x, float y, float w, ref bool field, string zh, string en)
    {
        bool b = Ui.Toggle(key, R(x, y, w, ROW_H), field, I18n.T(zh, en), ToggleStyle ?? GUI.skin.toggle);
        if (b == field) return false;
        field = b;
        return true;
    }

    internal static float CardOutdoors(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        y = SectionCol(R, x, y, COL_W3, I18n.T("野外", "Outdoors"));
        changed |= CeTog(R, "CE_SnareSure", x, y, HALF_W, ref s.CE_SnareSure, " 陷阱必中", " Sure Snares");
        Ui.Dim(!s.CE_SnareSure);
        changed |= CeTog(R, "CE_SnareInstant", x + HALF_OFF, y, HALF_W, ref s.CE_SnareInstant, " 放下就抓到", " Catch at Once");
        Ui.Dim(false);
        y += ROW_ADV;
        changed |= CeTog(R, "CE_IceHoleNoFreeze", x, y, HALF_W, ref s.CE_IceHoleNoFreeze, " 冰洞不冻上", " Holes Stay Open");
        changed |= CeTog(R, "CE_NoSlide", x + HALF_OFF, y, HALF_W, ref s.CE_NoSlide, " 坡上不打滑", " No Slope Slide");
        return y + ROW_ADV + SECTION_END_ADV;
    }

    internal static float CardContainersAurora(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        y = SectionCol(R, x, y, COL_W3, I18n.T("容器 & 极光", "Containers & Aurora"));
        changed |= CeTog(R, "CE_LootNoEmpty", x, y, HALF_W, ref s.CE_LootNoEmpty, " 容器不开空", " No Empty Loot");
        changed |= CeTog(R, "CE_LootLowerTier", x + HALF_OFF, y, HALF_W, ref s.CE_LootLowerTier, " 低一档难度", " Easier Loot");
        y += ROW_ADV;
        changed |= CeTog(R, "CE_AuroraRefill", x, y, COL_TOG_W3, ref s.CE_AuroraRefill, " 极光夜刷新空容器", " Aurora Refills Containers");
        y += ROW_ADV;
        changed |= CeTog(R, "CE_AuroraLightSteady", x, y, HALF_W, ref s.CE_AuroraLightSteady, " 电灯常亮", " Steady Lights");
        changed |= CeTog(R, "CE_AuroraMute", x + HALF_OFF, y, HALF_W, ref s.CE_AuroraMute, " 关极光音效", " Mute Aurora");
        return y + ROW_ADV + SECTION_END_ADV;
    }

    internal static float CardDeathStruggle(Func<float, float, float, float, Rect> R, TldHacksSettings s, float x, float y, ref bool changed)
    {
        y = SectionCol(R, x, y, COL_W3, I18n.T("死亡 & 扑倒", "Death & Struggle"));
        changed |= CeTog(R, "CE_NoDeath", x, y, HALF_W, ref s.CE_NoDeath, " 死亡不删档", " No Death");
        changed |= CeTog(R, "CE_NoMisery", x + HALF_OFF, y, HALF_W, ref s.CE_NoMisery, " 厄难不生成", " No Misery");
        y += ROW_ADV;
        changed |= CeTog(R, "CE_StruggleWin", x, y, HALF_W, ref s.CE_StruggleWin, " 扑倒必胜", " Win Struggles");
        changed |= CeTog(R, "CE_NoStun", x + HALF_OFF, y, HALF_W, ref s.CE_NoStun, " 扑倒不眩晕", " No Daze");
        return y + ROW_ADV + SECTION_END_ADV;
    }
}
#endif
