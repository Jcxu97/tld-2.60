using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace NorthernLightsBroadcast;

[HarmonyPatch(typeof(PlayerManager), "AddItemToPlayerInventory")]
public class tvTurnOffOnStow
{
	public static void Prefix(ref PlayerManager __instance, ref GearItem gi, ref bool trackItemLooted, ref bool enableNotificationFlag)
	{
		// v2.1.1: 这是挂在「物品进背包」上的前置补丁,抛了会影响捡东西。
		// gi 可能是 null,TVManager 也可能还没挂上(比如 Awake 提前 return 的电视)。
		if (gi == null) return;
		if (((Object)gi).name.Contains("GEAR_TV_LCD") || ((Object)gi).name.Contains("GEAR_TV_CRT") || ((Object)gi).name.Contains("GEAR_TV_WALL"))
		{
			TVManager component = ((Component)gi).gameObject.GetComponent<TVManager>();
			if ((Object)(object)component != (Object)null && component.currentState != 0)
			{
				component.SavePlaytime();
				component.SwitchState(TVManager.TVState.Off);
				SaveLoad.SetState(component.thisGuid, component.currentState);
			}
		}
	}
}
