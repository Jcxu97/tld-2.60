using UnityEngine;
using Il2Cpp;

namespace TldHacks;

internal static class CheatStateESP
{
    public static float RecoilScale = 1f;
    public static bool MagicBullet;
}

// 直接用游戏自己的动物名单。原来每 0.5s FindObjectsOfType<BaseAi> 扫全场景,
//   大地图一次 17~19ms(PerfProbe 10-31 实测),魔法子弹开着就每半秒顿一下
internal static class AiCache
{
    public static Il2CppSystem.Collections.Generic.List<BaseAi> Get() => BaseAiManager.m_BaseAis;
}

// 魔法子弹:开枪即对准星前方最近的动物直接施加伤害(命中无视弹道/落点)
internal static class MagicBulletSystem
{
    private static BaseAi _previewTarget;
    private static float _lastPreview = -999f;
    public static BaseAi PreviewTarget => _previewTarget;

    // 每帧从 OnUpdate 调用(已被 MagicBullet 开关 gate),内部降频 0.25s
    public static void UpdatePreview()
    {
        if (!CheatStateESP.MagicBullet) { _previewTarget = null; return; }
        float t = Time.time;
        if (t - _lastPreview < 0.25f) return;
        _lastPreview = t;
        _previewTarget = FindNearest();
    }

    public static void OnFired()
    {
        if (!CheatStateESP.MagicBullet) return;
        var target = FindNearest();
        if (target == null) return;
        try
        {
            float dmg = CheatState.InstantKillAnimals ? target.m_MaxHP + 100f : 80f;
            target.ApplyDamage(dmg, 0f, DamageSource.Player, "");
        }
        catch { }
    }

    private static BaseAi FindNearest()
    {
        var cam = GameManager.GetVpFPSCamera();
        if (cam == null) return null;
        var camPos = cam.transform.position;
        var camFwd = cam.transform.forward;
        var ais = AiCache.Get();
        if (ais == null) return null;
        BaseAi best = null;
        float bestDist = 200f;
        for (int i = 0; i < ais.Count; i++)
        {
            var ai = ais[i];
            if (ai == null) continue;
            var go = ai.gameObject;
            if (go == null || !go.activeSelf) continue;
            try { if (ai.m_CurrentHP <= 0) continue; } catch { }
            var toTarget = go.transform.position - camPos;
            float dist = toTarget.magnitude;
            if (dist > bestDist) continue;
            if (Vector3.Dot(camFwd, toTarget.normalized) < 0.5f) continue;
            bestDist = dist;
            best = ai;
        }
        return best;
    }
}

// 魔法子弹锁定目标的紫色准星预览(仅在开关开启且有目标时绘制)
internal static class MagicBulletOverlay
{
    private static GUIStyle _labelStyle;
    private static Texture2D _whiteTex;
    private static readonly Color MagicColor = new Color(0.9f, 0.3f, 1f, 0.9f);

    public static void OnGUI()
    {
        if (Event.current.type != EventType.Repaint) return;
        if (!CheatStateESP.MagicBullet) return;
        var target = MagicBulletSystem.PreviewTarget;
        if (target == null) return;
        var cam = Camera.main;
        if (cam == null) return;
        EnsureResources();
        try
        {
            var go = target.gameObject;
            if (go == null || !go.activeSelf) return;
            var pos = go.transform.position + Vector3.up * 0.8f;
            var sp = cam.WorldToScreenPoint(pos);
            if (sp.z <= 0) return;
            float sx = sp.x, sy = Screen.height - sp.y;
            float sz = 12f;
            FillRect(sx - sz, sy - 1f, sz * 2, 2f, MagicColor);
            FillRect(sx - 1f, sy - sz, 2f, sz * 2, MagicColor);
            float d = sz * 0.7f;
            FillRect(sx - d, sy - d, 2f, d * 0.6f, MagicColor);
            FillRect(sx - d, sy - d, d * 0.6f, 2f, MagicColor);
            FillRect(sx + d - 2f, sy - d, 2f, d * 0.6f, MagicColor);
            FillRect(sx + d - d * 0.6f, sy - d, d * 0.6f, 2f, MagicColor);
            FillRect(sx - d, sy + d - 2f, d * 0.6f, 2f, MagicColor);
            FillRect(sx - d, sy + d - d * 0.6f, 2f, d * 0.6f, MagicColor);
            FillRect(sx + d - d * 0.6f, sy + d - 2f, d * 0.6f, 2f, MagicColor);
            FillRect(sx + d - 2f, sy + d - d * 0.6f, 2f, d * 0.6f, MagicColor);
            GUI.Label(new Rect(sx + sz + 4, sy - 8, 120, 16), "[MAGIC]", _labelStyle);
        }
        catch { }
        GUI.color = Color.white;
    }

    private static void EnsureResources()
    {
        if (_labelStyle == null)
        {
            _labelStyle = new GUIStyle(GUI.skin.label) { fontSize = 12 };
            _labelStyle.normal.textColor = Color.white;
        }
        if (_whiteTex == null)
        {
            _whiteTex = new Texture2D(1, 1);
            _whiteTex.SetPixel(0, 0, Color.white);
            _whiteTex.Apply();
        }
    }

    private static void FillRect(float x, float y, float w, float h, Color c)
    {
        GUI.color = c;
        GUI.DrawTexture(new Rect(x, y, w, h), _whiteTex);
    }
}
