using System;
using Il2Cpp;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;

namespace TraderMoving;

// 挂在被搬运对象上,负责处理放下和异常中断。
// 照 TldHacks/src/IntegratedPatches4.cs 的 CarcassMovingBehaviour 写法。
// 只在搬运期间存在(Drop 里 Destroy 掉),所以 Update 的开销不常驻。
internal class CarryBehaviour : MonoBehaviour
{
    static CarryBehaviour() => ClassInjector.RegisterTypeInIl2Cpp<CarryBehaviour>();
    public CarryBehaviour(IntPtr ptr) : base(ptr) { }

    void Update()
    {
        // 放下后需要存一次档,把新位置落盘。存档不能在 Drop 里直接调
        // (Drop 可能在 patch 回调栈里),推到下一帧。
        if (CarryState.SaveTrigger)
        {
            CarryState.SaveTrigger = false;
            try
            {
                GearManager.UpdateAll();
                GameManager.TriggerSurvivalSaveAndDisplayHUDMessage();
            }
            catch { }
        }

        if (GameManager.m_IsPaused || !CarryState.IsCarrying) return;

        // 运行中被用户关掉开关 → 立刻放下,别留半搬状态
        if (!CarryState.KindEnabled(CarryState.Kind)) { CarryState.Drop(); return; }

        CarryState.DisplayDropHint();

        bool dropKey = false;
        try
        {
            var s = ModMain.Settings;
            if (s != null && s.CarryKey != KeyCode.None && Input.GetKeyDown(s.CarryKey))
                dropKey = true;
        }
        catch { }

        // 抱起后 0.5 秒内忽略右键,避免抱起的那一下立刻又放下
        bool rightClick = Input.GetMouseButtonDown(1) && Time.time - CarryState.PickUpTime > 0.5f;

        bool forced = false;
        try
        {
            forced = CarryState.HasInjuryPreventing()
                  || GameManager.GetPlayerStruggleComponent().InStruggle();
        }
        catch { }

        if (dropKey || rightClick || forced)
            CarryState.Drop();
    }
}
