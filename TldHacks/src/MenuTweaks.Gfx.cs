using System;
using UnityEngine;

namespace TldHacks;

internal static partial class MenuTweaks
{
    // 灯火 & 视觉 tab 的视觉部分:ca 列放室内灯光 + 准星,cb 列放视角 & FOV。
    internal static bool DrawVisualCards(Func<float, float, float, float, Rect> R, TldHacksSettings s,
        float ca, float cb, ref float ya, ref float yb)
    {
        float subTogW = HALF_W;
        float caSub = ca + HALF_OFF;
        float cbSub = cb + HALF_OFF;
        bool changed = false;
        float v;
        bool b;

        ya = SectionCol(R, ca, ya, COL_W3, I18n.T("室内灯光", "House Lights"), "HL_Enabled", ref s.HL_Enabled, ref changed);
        b = Ui.Toggle("HL_EnableOutside", R(ca,    ya, subTogW, ROW_H), s.HL_EnableOutside, I18n.T(" 室外也启用", " Outdoors"), ToggleStyle ?? GUI.skin.toggle);
        bool hlW = Ui.Toggle("HL_WhiteLights", R(caSub, ya, subTogW, ROW_H), s.HL_WhiteLights,  I18n.T(" 白光模式", " White Light"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.HL_EnableOutside) { s.HL_EnableOutside = b; changed = true; }
        if (hlW != s.HL_WhiteLights) { s.HL_WhiteLights = hlW; changed = true; }
        ya += ROW_ADV;
        b = Ui.Toggle("HL_NoFlicker", R(ca,    ya, subTogW, ROW_H), s.HL_NoFlicker,    I18n.T(" 禁止闪烁", " No Flicker"), ToggleStyle ?? GUI.skin.toggle);
        bool hlS = Ui.Toggle("HL_CastShadows", R(caSub, ya, subTogW, ROW_H), s.HL_CastShadows, I18n.T(" 投射阴影", " Shadows"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.HL_NoFlicker) { s.HL_NoFlicker = b; changed = true; }
        if (hlS != s.HL_CastShadows) { s.HL_CastShadows = hlS; changed = true; }
        ya += ROW_ADV;
        b = Ui.Toggle("HL_LightAudio", R(ca, ya, subTogW, ROW_H), s.HL_LightAudio, I18n.T(" 灯光音效", " Audio"), ToggleStyle ?? GUI.skin.toggle);
        if (b != s.HL_LightAudio) { s.HL_LightAudio = b; changed = true; }
        ya += ROW_ADV;
        v = DrawSliderCol3(R, ca, ya, I18n.T("亮度", "Intensity"), s.HL_Intensity, 0f, 3f, "F1", key: "HL_Intensity");
        if (v != s.HL_Intensity) { s.HL_Intensity = v; changed = true; }
        ya += ROW_ADV;
        v = DrawSliderCol3(R, ca, ya, I18n.T("范围倍率", "Range"), s.HL_RangeMultiplier, 0f, 5f, "F1", key: "HL_RangeMultiplier");
        if (v != s.HL_RangeMultiplier) { s.HL_RangeMultiplier = v; changed = true; }
        ya += ROW_ADV;
        v = DrawSliderCol3(R, ca, ya, I18n.T("裁剪距离(m)", "Cull Dist"), s.HL_CullDistance, 10f, 75f, "F0", key: "HL_CullDistance");
        if (v != s.HL_CullDistance) { s.HL_CullDistance = v; changed = true; }
        ya += ROW_ADV;
        v = DrawSliderCol3(R, ca, ya, I18n.T("交互距离(m)", "Interact"), s.HL_InteractDistance, 1f, 3f, "F1", key: "HL_InteractDistance");
        if (v != s.HL_InteractDistance) { s.HL_InteractDistance = v; changed = true; }
        ya += ROW_ADV + SECTION_END_ADV;

        ya = SectionCol(R, ca, ya, COL_W3, I18n.T("准星", "Crosshair"), "CrosshairEnabled", ref s.CrosshairEnabled, ref changed);
        v = DrawSliderCol3(R, ca, ya, I18n.T("透明度", "Alpha"), s.CrosshairAlpha, 0f, 1f, "F2", key: "CrosshairAlpha");
        if (v != s.CrosshairAlpha) { s.CrosshairAlpha = v; changed = true; }
        ya += ROW_ADV;
        bool csStone = Ui.Toggle("CrosshairStone", R(ca, ya, THIRD_W, ROW_H), s.CrosshairStone, I18n.T(" 投掷石块", " Stone"), ToggleStyle ?? GUI.skin.toggle);
        bool csRifle = Ui.Toggle("CrosshairRifle", R(ca + THIRD_OFF, ya, THIRD_W, ROW_H), s.CrosshairRifle, I18n.T(" 步枪瞄准", " Rifle"), ToggleStyle ?? GUI.skin.toggle);
        bool csBow = Ui.Toggle("CrosshairBow", R(ca + 2f * THIRD_OFF, ya, THIRD_W, ROW_H), s.CrosshairBow, I18n.T(" 弓箭瞄准", " Bow"), ToggleStyle ?? GUI.skin.toggle);
        if (csStone != s.CrosshairStone) { s.CrosshairStone = csStone; changed = true; }
        if (csRifle != s.CrosshairRifle) { s.CrosshairRifle = csRifle; changed = true; }
        if (csBow != s.CrosshairBow) { s.CrosshairBow = csBow; changed = true; }
        ya += ROW_ADV + SECTION_END_ADV;

        yb = SectionCol(R, cb, yb, COL_W3, I18n.T("视角 & FOV", "View & FOV"));
        bool fovExt = Ui.Toggle("TT_ExtendedFOV", R(cb, yb, COL_TOG_W3, ROW_H), s.TT_ExtendedFOV,
            I18n.T(" FOV 上限扩展 (30-150)", " Extended FOV (30-150)"), ToggleStyle ?? GUI.skin.toggle);
        if (fovExt != s.TT_ExtendedFOV) { s.TT_ExtendedFOV = fovExt; CheatState.TT_ExtendedFOV = fovExt; changed = true; }
        yb += ROW_ADV;
        bool vFov  = Ui.Toggle("VehicleKeepFov", R(cb,    yb, subTogW, ROW_H), s.VehicleKeepFov,  I18n.T(" 车内保持FOV", " Car Keep FOV"), ToggleStyle ?? GUI.skin.toggle);
        bool vFree = Ui.Toggle("VehicleFreeLook", R(cbSub, yb, subTogW, ROW_H), s.VehicleFreeLook, I18n.T(" 车内自由视角", " Car Free Look"), ToggleStyle ?? GUI.skin.toggle);
        if (vFov != s.VehicleKeepFov) { s.VehicleKeepFov = vFov; changed = true; }
        if (vFree != s.VehicleFreeLook) { s.VehicleFreeLook = vFree; changed = true; }
        yb += ROW_ADV;
        Ui.Dim(!s.VehicleFreeLook);
        v = DrawSliderCol3(R, cb, yb, I18n.T("水平转头(°)", "Yaw"), s.VehicleFreeLookYaw, 30f, 180f, "F0", key: "VehicleFreeLookYaw");
        if (v != s.VehicleFreeLookYaw) { s.VehicleFreeLookYaw = v; changed = true; }
        yb += ROW_ADV;
        v = DrawSliderCol3(R, cb, yb, I18n.T("上下抬头(°)", "Pitch"), s.VehicleFreeLookPitch, 20f, 90f, "F0", key: "VehicleFreeLookPitch");
        if (v != s.VehicleFreeLookPitch) { s.VehicleFreeLookPitch = v; changed = true; }
        Ui.Dim(false);
        yb += ROW_ADV + SECTION_END_ADV;

        return changed;
    }
}
