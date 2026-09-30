using System;
using Il2Cpp;
using UnityEngine;

namespace TraderMoving;

// 放下时用游戏自己的摆放(和装修模式、放物品一样的蓝色虚影)。
//
// 交给游戏摆的是一个只有外形的预览物体,没有交互组件;左键放好以后记下它的位置和朝向,
// 删掉预览,再照常摆出真的无线电或交易箱。右键取消就接着抱着。
// 等按下去的键松开再进摆放,免得游戏把这次按键当成放下或取消。
internal static class Placement
{
    private static GameObject _preview;
    private static int _startFrame = -1;
    private static bool _active;
    private static bool _placed;
    private static bool _captured;
    private static Vector3 _pos;
    private static float _yaw;
    private static Vector3 _startPos;
    private static int _activeFrame;
    private static bool _seen;
    private static int _endFrame = -1;
    private static string _lastCategory;
    private const int IgnoreRaycastLayer = 2;

    internal static bool Busy => _startFrame >= 0 || _active;

    internal static void Begin()
    {
        if (Busy) return;
        _startFrame = Time.frameCount + 1;
    }

    internal static void Tick()
    {
        if (_startFrame >= 0)
        {
            // 按下去那个键没松开就进摆放,游戏会把松开当成取消
            if (Time.frameCount < _startFrame) return;
            if (Time.frameCount < _startFrame + 120 && (Input.GetMouseButton(1) || Input.GetMouseButton(0) || KeyHeld())) return;
            _startFrame = -1;
            Start();
            return;
        }
        if (!_active) return;

        PlayerManager pm = null;
        bool mine = false;
        try
        {
            pm = GameManager.GetPlayerManagerComponent();
            mine = pm != null && pm.IsInPlacementMode() && IsOurs(pm.GetObjectToPlace());
        }
        catch { }
        if (mine)
        {
            _seen = true;
            _endFrame = -1;
            if (Input.GetMouseButtonDown(0))
            {
                try { _lastCategory = pm.m_MeshLocationCategory.ToString(); } catch { }
            }
            return;
        }
        // 游戏可能晚一两帧才进摆放
        if (!_seen && Time.frameCount - _activeFrame < 10) return;
        // 取消时游戏在本帧末尾才删掉预览,多等一帧再看它还在不在
        if (_endFrame < 0) { _endFrame = Time.frameCount + 1; return; }
        if (Time.frameCount < _endFrame) return;
        Finish();
    }

    private static void Finish()
    {
        _active = false;
        bool alive = _preview != null;
        if (alive)
        {
            _pos = _preview.transform.position;
            _yaw = _preview.transform.eulerAngles.y;
        }
        // 放下以后预览留在原地;取消时游戏删掉它(DestroyOnCancel),就算没删也会先挪回摆放前的位置
        bool placed = _placed || (alive && (_pos - _startPos).sqrMagnitude > 0.0001f);
        ModMain.Log?.Msg($"[TraderMoving] 摆放结束: 进过摆放 {_seen} 放下钩子 {_captured}/{_placed} 预览还在 {alive} 位置 {_pos} 最后一次左键时的判定 {_lastCategory ?? "没按"} → {(placed ? "放下" : "取消")}");
        _placed = false;
        DestroyPreview();
        if (placed) CarryState.DropAt(_pos, _yaw);
        else if (!_seen)
        {
            ModMain.Log?.Warning("[TraderMoving] 游戏没进摆放,直接放在脚前");
            CarryState.Drop();
        }
        else HUDMessage.AddMessage("没放下,还抱着", false, false);
    }

    private static bool IsOurs(GameObject go) => go != null && _preview != null && go.Pointer == _preview.Pointer;

    private static bool KeyHeld()
    {
        var s = ModMain.Settings;
        return s != null && s.CarryKey != KeyCode.None && Input.GetKey(s.CarryKey);
    }

    private static void Start()
    {
        var kind = CarryState.Kind;
        _preview = World.MakePreview(kind, SaveData.Of(kind));
        if (_preview == null)
        {
            ModMain.Log?.Warning("[TraderMoving] 预览模型做不出来,直接放在脚前");
            CarryState.Drop();
            return;
        }
        // 游戏只把最外层改到忽略射线的层,子物体上的碰撞体还会挡住摆放射线,虚影就一直往镜头跳、永远不合法
        foreach (var t in _preview.GetComponentsInChildren<Transform>(true)) t.gameObject.layer = IgnoreRaycastLayer;
        _startPos = _preview.transform.position;
        bool ok = false;
        try { ok = GameManager.GetPlayerManagerComponent().StartPlaceMesh(_preview, PlaceMeshFlags.DestroyOnCancel); }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 进入摆放失败: {ex.Message}"); }
        ModMain.Log?.Msg($"[TraderMoving] 进入摆放 {kind}: {(ok ? "成功" : "失败")}");
        if (!ok)
        {
            DestroyPreview();
            CarryState.Drop();
            return;
        }
        _active = true;
        _activeFrame = Time.frameCount;
        _seen = false;
        _endFrame = -1;
        _lastCategory = null;
        _placed = false;
        _captured = false;
        HUDMessage.AddMessage("左键放下,右键取消,滚轮转方向", false, false);
    }

    // 前缀先记位置(游戏放好以后可能会删掉它),后缀确认真的放下了才算数
    internal static void BeforePlaceMeshInWorld(PlayerManager pm)
    {
        if (!_active || _preview == null) return;
        try
        {
            if (pm != null && !IsOurs(pm.GetObjectToPlace())) return;
            _pos = _preview.transform.position;
            _yaw = _preview.transform.eulerAngles.y;
            _captured = true;
        }
        catch { }
    }

    // 游戏只在确定放下时才调这个方法,调完才退出摆放,所以这里不再看是否还在摆放
    internal static void AfterPlaceMeshInWorld(PlayerManager pm)
    {
        if (!_active || !_captured) return;
        try
        {
            if (_preview != null)
            {
                _pos = _preview.transform.position;
                _yaw = _preview.transform.eulerAngles.y;
            }
            _placed = true;
        }
        catch { }
    }

    // 受伤、搏斗这些要马上放下的情况
    internal static void Abort() => Reset();

    internal static void Reset()
    {
        if (_active)
        {
            try
            {
                var pm = GameManager.GetPlayerManagerComponent();
                if (pm != null && pm.IsInPlacementMode() && IsOurs(pm.GetObjectToPlace())) pm.CancelPlacementMode();
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 退出摆放失败: {ex.Message}"); }
        }
        _startFrame = -1;
        _active = false;
        _placed = false;
        _captured = false;
        _seen = false;
        _endFrame = -1;
        DestroyPreview();
    }

    private static void DestroyPreview()
    {
        if (_preview != null) UnityEngine.Object.Destroy(_preview);
        _preview = null;
    }
}
