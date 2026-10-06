using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace SCPlus;

internal class WorkbenchPatches
{
	[HarmonyPatch(typeof(Panel_HUD), "SetHoverText")]
	public class ShowButtonPrompts
	{
		public static void Prefix(ref GameObject itemUnderCrosshairs)
		{
			if (Settings.options.altWorkbenchInteraction && (bool)GameManager.GetSafehouseManager() && !GameManager.GetSafehouseManager().IsCustomizing() && !(itemUnderCrosshairs?.GetComponent<WorkBench>() == null) && (bool)InterfaceManager.GetPanel<Panel_HUD>()?.m_EquipItemPopup)
			{
				InterfaceManager.GetPanel<Panel_HUD>().m_EquipItemPopup.enabled = true;
				InterfaceManager.GetPanel<Panel_HUD>().m_EquipItemPopup.ShowGenericPopupWithDefaultActions(Localization.Get("GAMEPLAY_Crafting"), Localization.Get("GAMEPLAY_BreakDown"));
			}
		}
	}

	[HarmonyPatch(typeof(WorkBench), "InteractWithWorkbench")]
	public class WorkbenchPrimaryAction
	{
		public static bool Prefix(ref WorkBench __instance)
		{
			if (!Settings.options.altWorkbenchInteraction)
			{
				return true;
			}
			if (GameManager.GetSafehouseManager().IsCustomizing())
			{
				return true;
			}
			__instance.OnCrafting();
			return false;
		}
	}

	[HarmonyPatch(typeof(InputManager), "ExecuteAltFire")]
	public class CatchAltInteractionWithWorkbench
	{
		public static void Prefix()
		{
			if (Settings.options.altWorkbenchInteraction && (bool)GameManager.GetPlayerManagerComponent() && !GameManager.GetSafehouseManager().IsCustomizing())
			{
				GameObject interactiveGameObjectUnderCrosshair = Utility.GetInteractiveGameObjectUnderCrosshair();
				if (!(interactiveGameObjectUnderCrosshair?.GetComponent<WorkBench>() == null))
				{
					interactiveGameObjectUnderCrosshair.GetComponent<WorkBench>().OnBreakDown();
				}
			}
		}
	}
}
