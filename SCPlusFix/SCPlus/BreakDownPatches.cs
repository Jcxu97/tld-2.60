using System;
using HarmonyLib;
using Il2Cpp;

namespace SCPlusPP;

internal class BreakDownPatches
{
	[HarmonyPatch(typeof(ActionPickerItem), "OnClick")]
	private static class EnableBreakdownPanelFromSCpre
	{
		public static bool toggle;

		internal static void Prefix(ref ActionPickerItem __instance)
		{
			if (GameManager.GetSafehouseManager().IsCustomizing() && __instance.m_Sprite.spriteName == "ico_harvest")
			{
				toggle = true;
			}
		}
	}

	[HarmonyPatch(typeof(Panel_BreakDown), "ShowRelevantGroups")]
	private static class EnableBreakdownPanelFromSC
	{
		internal static void Prefix()
		{
			if (EnableBreakdownPanelFromSCpre.toggle)
			{
				GameManager.GetSafehouseManager().m_IsCustomizing = false;
			}
		}
	}

	[HarmonyPatch(typeof(BreakDown), "RequiresTool")]
	private static class ToolReqWhenBreakdownPanelFromSC
	{
		internal static void Postfix(ref BreakDown __instance, ref bool __result)
		{
			if (EnableBreakdownPanelFromSCpre.toggle)
			{
				__result = __instance.m_RequiresTool;
			}
		}
	}

	[HarmonyPatch(typeof(Panel_BreakDown), "Enable")]
	private static class NoMoreBreakdownPanelFromSC
	{
		internal static void Prefix(ref bool enable)
		{
			if (enable && EnableBreakdownPanelFromSCpre.toggle)
			{
				GameManager.GetSafehouseManager().m_IsCustomizing = false;
			}
		}

		internal static void Postfix(ref Panel_BreakDown __instance, ref bool enable)
		{
			if (!enable && EnableBreakdownPanelFromSCpre.toggle)
			{
				EnableBreakdownPanelFromSCpre.toggle = false;
				GameManager.GetSafehouseManager().m_IsCustomizing = true;
			}
		}
	}

	[HarmonyPatch(typeof(BreakDown), "PerformInteraction")]
	private static class PreventDestroy
	{
		internal static bool Prefix(ref BreakDown __instance)
		{
			if (__instance.m_EditModeDestroyOnly)
			{
				WoodStove component = __instance.GetComponent<WoodStove>();
				if ((bool)component && component.Fire.IsBurning())
				{
					GameAudioManager.PlayGUIError();
					HUDMessage.AddMessage(Localization.Get("SCP_Action_CantDestroyHot"), highPriority: false, ignoreOverlayActive: true);
					__instance.GetComponent<DecorationItem>()?.m_ActionPicker.TrySetEnabled(enable: false);
					return false;
				}
			}
			return true;
		}
	}

	[HarmonyPatch(typeof(BreakDown), "Awake")]
	private static class EnableBreakdown
	{
		internal static void Prefix(ref BreakDown __instance)
		{
			if (!__instance.isActiveAndEnabled)
			{
				if (__instance.m_YieldObject != null && __instance.m_YieldObject.Length > 0)
				{
					__instance.enabled = true;
				}
				else
				{
					Utility.Log(ConsoleColor.Gray, "BreakDown exists but doesn't have yields: " + __instance.name);
				}
			}
		}

		internal static void Postfix(ref BreakDown __instance)
		{
			if (__instance.gameObject.layer == vp_Layer.Default)
			{
				__instance.gameObject.layer = vp_Layer.InteractiveProp;
			}
		}
	}
}
