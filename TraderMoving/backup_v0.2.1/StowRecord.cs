using System;

namespace TraderMoving;

// 记录"东西是不是在背包里"。
//
// 为什么需要:收进背包后对象被 RemoveFromHierarchy 移出场景层级,
// SaveData.ApplyToScene 再去场景里找它就会找不到,然后把记录当成
// "还在原地"处理。这个标记让存档逻辑知道该跳过。
//
// 实际的背包内容由 SCPlus 自己的存档负责(它的 carryables_carried 条目),
// 我们只记一个布尔,不重复存物品数据 —— 两边都存会打架。
internal static class StowRecord
{
    internal static bool RadioStowed;
    internal static bool BoxStowed;

    internal static void MarkStowed(CarryKind kind)
    {
        switch (kind)
        {
            case CarryKind.Radio: RadioStowed = true; break;
            case CarryKind.ExchangeBox: BoxStowed = true; break;
        }
    }

    internal static void MarkPlaced(CarryKind kind)
    {
        switch (kind)
        {
            case CarryKind.Radio: RadioStowed = false; break;
            case CarryKind.ExchangeBox: BoxStowed = false; break;
        }
    }

    internal static bool IsStowed(CarryKind kind) => kind switch
    {
        CarryKind.Radio => RadioStowed,
        CarryKind.ExchangeBox => BoxStowed,
        _ => false,
    };

    internal static bool IsStowed(string kindName)
    {
        if (kindName == CarryKind.Radio.ToString()) return RadioStowed;
        if (kindName == CarryKind.ExchangeBox.ToString()) return BoxStowed;
        return false;
    }

    internal static void Reset()
    {
        RadioStowed = false;
        BoxStowed = false;
    }
}
