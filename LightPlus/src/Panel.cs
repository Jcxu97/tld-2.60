using System;
using System.IO;
using System.Text.Json;
using Il2Cpp;
using UnityEngine;

namespace LightPlus;

// In-game settings panel: F7 opens it, every change applies at once and is saved to LightPlus.json.
public partial class Mod
{
    const int PanelId = 0x4C50;
    const float RowH = 34f, LabelW = 150f, ValueW = 60f, PanelW = 560f;
    static readonly Cfg Defaults = new();

    bool panelOpen, pausedByPanel, cursorSaved, prevCursorVisible, dirty;
    CursorLockMode prevCursorLock;
    float saveAt;
    Rect panelRect = new(40f, 120f, PanelW, 100f);
    float y;

    void TogglePanel()
    {
        if (panelOpen) { ClosePanel(); return; }
        prevCursorVisible = Cursor.visible;
        prevCursorLock = Cursor.lockState;
        cursorSaved = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        panelOpen = true;
        // without the pause menu the mouse keeps turning the camera while a slider is dragged
        try
        {
            var p = InterfaceManager.GetPanel<Panel_PauseMenu>();
            if (inWorld && !GameManager.m_IsPaused && InputManager.CanInvokePauseMenu() && p != null && !p.isActiveAndEnabled) { p.Enable(true); pausedByPanel = true; }
        }
        catch (Exception e) { LoggerInstance.Warning("panel pause: " + e.Message); }
    }

    void ClosePanel()
    {
        panelOpen = false;
        if (dirty) SaveCfg();
        if (pausedByPanel)
        {
            pausedByPanel = false;
            try { var p = InterfaceManager.GetPanel<Panel_PauseMenu>(); if (p != null && p.isActiveAndEnabled) p.OnDone(); } catch { }
        }
        if (cursorSaved) { Cursor.visible = prevCursorVisible; Cursor.lockState = prevCursorLock; cursorSaved = false; }
    }

    void SaveCfg()
    {
        dirty = false;
        try
        {
            File.WriteAllText(CfgPath, JsonSerializer.Serialize(C, Json));
            // our own write must not count as an outside edit, or the reload would rebuild the SSR volume
            cfgTime = File.GetLastWriteTimeUtc(CfgPath);
        }
        catch (Exception e) { LoggerInstance.Warning("config save failed: " + e.Message); }
    }

    void PanelUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F7)) TogglePanel();
        if (panelOpen && dirty && Time.realtimeSinceStartup > saveAt) SaveCfg();
    }

    public override void OnGUI()
    {
        if (!panelOpen) return;
        float s = Mathf.Max(Screen.height / 1080f, 0.5f);
        GUI.matrix = Matrix4x4.Scale(new Vector3(s, s, 1f));
        panelRect = GUI.Window(PanelId, panelRect, (GUI.WindowFunction)DrawPanel, "LightPlus 光影设置   (F7 关闭)");
        GUI.matrix = Matrix4x4.identity;
    }

    void DrawPanel(int id)
    {
        y = 32f;
        bool wasOn = on;
        on = Check("总开关 (F8 也能开关)", on);
        if (on != wasOn) LoggerInstance.Msg(on ? "effects ON" : "effects OFF");

        C.Grade = Check("调色", C.Grade);
        C.GradeMix = Slide("调色强度", C.GradeMix, 0f, 1f);
        C.GradeSplit = Slide("冷暖对比", C.GradeSplit, 0f, 3f);
        C.GradeContrast = Slide("明暗对比", C.GradeContrast, 0f, 1f);
        C.GradeSunBoost = Slide("阳光提亮", C.GradeSunBoost, 0f, 1.5f);
        C.GradeVibrance = Slide("鲜艳度", C.GradeVibrance, 0.5f, 1.6f);
        C.GradeVignette = Slide("四角暗角", C.GradeVignette, 0f, 1.5f);
        C.GradeSunGlow = Slide("太阳辉光", C.GradeSunGlow, 0f, 1f);
        y += 8f;
        C.Reflect = Check("冰面和水面倒影", C.Reflect);
        C.ReflectStrength = Slide("倒影强度", C.ReflectStrength, 0f, 1f);
        y += 8f;
        C.SunIntensity = Slide("太阳强度", C.SunIntensity, 0.5f, 2f);
        C.AmbientIntensity = Slide("环境光", C.AmbientIntensity, 0.5f, 1.5f);
        y += 8f;
        C.Shafts = Check("光束 (较吃 CPU)", C.Shafts);
        C.ShaftStrength = Slide("光束强度", C.ShaftStrength, 0f, 3f);
        C.Relight = Check("重新打光", C.Relight);
        C.RelightContrast = Slide("重新打光强度", C.RelightContrast, 0f, 4f);
        y += 10f;

        if (GUI.Button(new Rect(12f, y, 160f, RowH - 4f), "恢复默认"))
        {
            C.Grade = Defaults.Grade; C.GradeMix = Defaults.GradeMix; C.GradeSplit = Defaults.GradeSplit;
            C.GradeContrast = Defaults.GradeContrast; C.GradeSunBoost = Defaults.GradeSunBoost; C.GradeVibrance = Defaults.GradeVibrance;
            C.GradeVignette = Defaults.GradeVignette; C.GradeSunGlow = Defaults.GradeSunGlow;
            C.SunIntensity = Defaults.SunIntensity; C.AmbientIntensity = Defaults.AmbientIntensity;
            C.Reflect = Defaults.Reflect; C.ReflectStrength = Defaults.ReflectStrength;
            C.Shafts = false; C.ShaftStrength = 1f; C.Relight = false; C.RelightContrast = Defaults.RelightContrast;
            Changed();
        }
        if (GUI.Button(new Rect(PanelW - 172f, y, 160f, RowH - 4f), "关闭")) ClosePanel();
        y += RowH + 6f;
        panelRect.height = y;
        GUI.DragWindow(new Rect(0f, 0f, PanelW, 26f));
    }

    bool Check(string label, bool v)
    {
        bool n = GUI.Toggle(new Rect(12f, y, PanelW - 24f, RowH - 6f), v, " " + label);
        y += RowH;
        if (n != v) Changed();
        return n;
    }

    float Slide(string label, float v, float min, float max)
    {
        GUI.Label(new Rect(28f, y, LabelW, RowH), label);
        float n = GUI.HorizontalSlider(new Rect(28f + LabelW, y + 9f, PanelW - LabelW - ValueW - 52f, RowH), v, min, max);
        n = Mathf.Round(n * 100f) / 100f;
        GUI.Label(new Rect(PanelW - ValueW - 12f, y, ValueW, RowH), n.ToString("0.00"));
        y += RowH;
        if (Math.Abs(n - v) > 1e-4f) Changed();
        return n;
    }

    void Changed()
    {
        dirty = true;
        saveAt = Time.realtimeSinceStartup + 1f;
    }
}
