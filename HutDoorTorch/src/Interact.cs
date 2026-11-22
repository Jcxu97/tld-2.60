using Il2Cpp;
using UnityEngine;

namespace HutDoorTorch;

// 看着门时的提示和按键。短按交互键开关门,长按拆下;
// 背包里有门、正对着没门的小屋门框时,按交互键装门。
internal static class Interact
{
    private const float Range = 3f;
    private const float HoldSeconds = 1.2f;

    private static string _hover;
    private static GameObject _hoverGo;
    private static float _pressTime = -1f;
    private static object _pressTarget;
    private static bool _holdDone;
    private static float _diagAt;

    internal static void Reset()
    {
        _hover = null;
        _hoverGo = null;
        _pressTime = -1f;
        _pressTarget = null;
    }

    internal static void Tick()
    {
        _hover = null;
        _hoverGo = null;
        var cam = GameManager.GetMainCamera();
#if HDT_TEST
        if (Time.realtimeSinceStartup > _diagAt)
        {
            _diagAt = Time.realtimeSinceStartup + 3f;
            Transform dw = cam != null ? Huts.DoorwayInView(cam, 3f) : null;
            ModMain.Log.Msg($"诊断 浮层 {InterfaceManager.IsOverlayActiveImmediate()}/{InterfaceManager.IsOverlayActiveCached()} 鼠标 {Cursor.lockState} 相机 {(cam != null ? cam.name : "无")} 门框 {(dw != null ? dw.name : "无")} 背包门 {Gear.CountInInventory(Gear.Door)} 屋 {Huts.DoorlessCount}");
        }
#endif
        if (InterfaceManager.IsOverlayActiveImmediate()) { _pressTime = -1f; return; }
        if (cam == null) return;

        HutDoor door = null;
        Transform doorway = null;
        var ray = new Ray(cam.transform.position, cam.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, Range, Physics.DefaultRaycastLayers, QueryTriggerInteraction.Ignore))
        {
            door = Huts.DoorFromCollider(hit.collider);
        }
        if (door == null && Gear.CountInInventory(Gear.Door) > 0)
            doorway = Huts.DoorwayInView(cam, 3f);

        object target = (object)door ?? doorway;
        var pm = GameManager.GetPlayerManagerComponent();
        bool pressed = InputManager.GetInteractPressed(pm) || Input.GetMouseButtonDown(0);
        bool released = InputManager.GetInteractReleased(pm) || Input.GetMouseButtonUp(0);
        if (pressed || released)
            ModMain.Log.Msg($"交互键 {(pressed ? "按下" : "松开")} 准星 {(hit.collider != null ? hit.collider.name : "空")} 门 {(door != null)} 门框 {(doorway != null ? doorway.name : "无")} 背包门 {Gear.CountInInventory(Gear.Door)} 屋 {Huts.DoorlessCount}");

        if (pressed && target != null) { _pressTime = Time.time; _pressTarget = target; _holdDone = false; }
        bool holding = _pressTime >= 0f && _pressTarget == target && target != null;
        float held = holding ? Time.time - _pressTime : 0f;

        if (door != null)
        {
            _hoverGo = door.DoorGo;
            _hover = (door.IsOpen ? "关门" : "开门") + Progress(held, "长按拆下");
            if (holding && !_holdDone && held >= HoldSeconds) { _holdDone = true; _pressTime = -1f; Huts.Remove(door); return; }
            if (released && holding && !_holdDone) Huts.Toggle(door);
        }
        else if (doorway != null)
        {
            _hover = "装上钓鱼小屋门";
            if (released && holding) Huts.Install(doorway);
        }
        if (released) _pressTime = -1f;
    }

    private static string Progress(float held, string label)
    {
        if (held <= 0.15f) return "\n(" + label + ")";
        int pct = Mathf.Clamp(Mathf.RoundToInt(held / HoldSeconds * 100f), 0, 100);
        return $"\n({label} {pct}%)";
    }

    internal static void LateTick()
    {
        if (_hover == null) return;
        try
        {
            var hud = InterfaceManager.GetPanel<Panel_HUD>();
            hud?.SetHoverText(_hover, _hoverGo, HoverTextState.CanInteract);
        }
        catch { }
    }
}
