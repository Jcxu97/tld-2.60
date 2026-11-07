using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace ItemPicker;

[HarmonyPatch(typeof(PlayerManager), "InteractiveObjectsProcessInteraction")]
public class ExecuteInteractAction
{
	public static bool Prefix(ref PlayerManager __instance)
	{
		if (Settings.options.skipInspect && __instance.HasInteractiveObjectUnderCrossHair())
		{
			GameObject interactiveObjectUnderCrosshairs = __instance.GetInteractiveObjectUnderCrosshairs(20f);
			// 2026-10 更新后火车上的拉杆这类交互,前面说有东西、这里却取不到;不判空会让整次交互报错失效
			if ((Object)interactiveObjectUnderCrosshairs == (Object)null)
			{
				return true;
			}
			if (Settings.options.skipInspectAll)
			{
				if (((Object)interactiveObjectUnderCrosshairs).name.Contains("GEAR_") && !((Object)interactiveObjectUnderCrosshairs).name.Contains("CardGame"))
				{
					GameManager.GetPlayerManagerComponent().ProcessPickupItemInteraction(interactiveObjectUnderCrosshairs.GetComponent<GearItem>(), false, false, false);
					return false;
				}
			}
			else if (((Object)interactiveObjectUnderCrosshairs).name.Contains("GEAR_Stick") || ((Object)interactiveObjectUnderCrosshairs).name.Contains("GEAR_Stone"))
			{
				GameManager.GetPlayerManagerComponent().ProcessPickupItemInteraction(interactiveObjectUnderCrosshairs.GetComponent<GearItem>(), false, false, false);
				return false;
			}
		}
		return true;
	}
}
