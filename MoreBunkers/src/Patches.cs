using HarmonyLib;
using Il2Cpp;

namespace MoreBunkers;

// 走进新地堡的舱口时记下是哪个;在新地堡里走出口时,把出口的目标改回地堡所在的图
internal static class DoorHook
{
    // 所有门都走这里,异常不能漏进游戏
    internal static void Before(LoadScene door)
    {
        try
        {
            if (door == null) return;
            var b = Bunkers.ByDoor(door);
            if (b != null)
            {
                Bunkers.KeepGuid(door, b);
                Bunkers.Inside = b;
                Bunkers.JustEntered = b;
                Bunkers.JustEnteredAt = UnityEngine.Time.realtimeSinceStartup;
                return;
            }
            // 走了别的门,刚才进舱口那一下作废,免得把同一张图上的原版地堡认成新地堡
            Bunkers.JustEntered = null;
            var inside = Bunkers.Inside;
            // 出地堡前先记下箱子里的东西,不靠游戏换场景时有没有存档
            if (inside != null) { try { Stock.SaveBoxes(); } catch { } }
            if (inside != null && door.m_ExitPointName == Bunkers.HatchExit)
            {
                Bunkers.LeftAt = UnityEngine.Time.realtimeSinceStartup;
                string region = Bunkers.SpotOf(inside).Region;
                if (door.m_SceneToLoad != region)
                {
                    ModMain.Log?.Msg($"[MoreBunkers] exit {inside.Id}: {door.m_SceneToLoad} -> {region}");
                    door.m_SceneToLoad = region;
                }
            }
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] door {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(LoadScene), nameof(LoadScene.Activate), new[] { typeof(bool) })]
internal static class Patch_LoadScene_Activate
{
    private static void Prefix(LoadScene __instance) => DoorHook.Before(__instance);
}

// 2.60 的 LoadScene.Start 会把门的编号换掉,建好门之后马上写回来,地堡内部才认得出是新地堡
[HarmonyPatch(typeof(LoadScene), nameof(LoadScene.Start))]
internal static class Patch_LoadScene_Start
{
    private static void Postfix(LoadScene __instance)
    {
        try
        {
            var b = Bunkers.ByDoor(__instance);
            if (b != null) Bunkers.KeepGuid(__instance, b);
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] door start {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(LoadScene), nameof(LoadScene.PerformSceneLoad))]
internal static class Patch_LoadScene_PerformSceneLoad
{
    private static void Prefix(LoadScene __instance) => DoorHook.Before(__instance);
}

// PrepperCache 模组按键显示的"地堡分布"后面接上三个新地堡
[HarmonyPatch(typeof(HUDMessage), nameof(HUDMessage.AddMessage), new[] { typeof(string), typeof(float), typeof(bool), typeof(bool) })]
internal static class Patch_HUDMessage_BunkerList
{
    private static void Prefix(ref string message)
    {
        try
        {
            if (message == null || !message.StartsWith("地堡分布") || message.Contains("工匠地堡") || !Bunkers.Active()) return;
            message = message.TrimEnd('\n') + "\n" + Bunkers.DescribeShort();
        }
        catch { }
    }
}

// 游戏写场景存档前,把我们箱子里的东西一起记下(这些箱子是运行时摆的,游戏自己不存)
[HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.PrepareSaveData), new[] { typeof(SlotData), typeof(string) })]
internal static class Patch_SaveGameSystem_PrepareSaveData
{
    private static void Prefix()
    {
        try { Stock.SaveBoxes(); } catch { }
    }
}
