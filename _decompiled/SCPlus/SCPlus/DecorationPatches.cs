using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using Il2Cpp;
using Il2CppRewired.Utils;
using Il2CppSystem.Collections.Generic;
using Il2CppTLD.PDID;
using Il2CppTLD.Placement;
using Il2CppVLB;
using MelonLoader;
using UnityEngine;

namespace SCPlus;

internal class DecorationPatches
{
	[HarmonyPatch(typeof(DecorationItem), "Start")]
	private static class DecorationInitialSetup
	{
		internal static void Postfix(ref DecorationItem __instance)
		{
			if ((bool)__instance.gameObject.GetComponentInParent<NarrativeCollectibleItem>(includeInactive: true))
			{
				return;
			}
			string value = Utility.SanitizeObjectName(__instance.name);
			if (CarryableData.blacklist.Contains(value))
			{
				__instance.m_AllowInInventory = false;
				__instance.enabled = false;
				return;
			}
			BreakDown componentInChildren = __instance.GetComponentInChildren<BreakDown>();
			if (!__instance.m_AllowInInventory)
			{
				__instance.m_AllowInInventory = true;
				SCPMain.RelevantSetupForDecorationItem(__instance, weightOnly: true);
				if ((bool)componentInChildren)
				{
					componentInChildren.m_AllowEditModePlacement = true;
				}
			}
			SCPMain.SetLayersToInteractiveProp(__instance);
		}
	}

	[HarmonyPatch(typeof(DecorationItem), "InitializeInteraction")]
	public static class TimedOutline
	{
		public static System.Collections.Generic.Dictionary<int, object> coroutines = new System.Collections.Generic.Dictionary<int, object>();

		internal static void Postfix(DecorationItem __instance)
		{
			if (Settings.options.outlineVisibility == 2)
			{
				int instanceID = __instance.GetInstanceID();
				if (coroutines.TryGetValue(instanceID, out object value))
				{
					MelonCoroutines.Stop(value);
				}
				coroutines[instanceID] = MelonCoroutines.Start(DisableOutline(__instance));
			}
		}
	}

	[HarmonyPatch(typeof(DecorationItem), "OnStartCustomization")]
	private static class StartCustomizationOnItem
	{
		internal static bool Prefix(ref DecorationItem __instance)
		{
			if ((bool)__instance.gameObject.GetComponentInParent<NarrativeCollectibleItem>(includeInactive: true))
			{
				return true;
			}
			SCPMain.DisableNormalInteraction(__instance);
			int num = 0;
			Il2CppSystem.Collections.Generic.List<Renderer>.Enumerator enumerator = __instance.GetRenderers().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Renderer current = enumerator.Current;
				if (((bool)current && (current.isPartOfStaticBatch || current.IsNullOrDestroyed())) || !current)
				{
					num++;
					__instance.TryGetComponent<BreakDown>(out var component);
					if ((!component || !component.isActiveAndEnabled) && (bool)current)
					{
						current.SetPropertyBlock(null);
					}
				}
			}
			if (num == __instance.GetRenderers().Count)
			{
				__instance.enabled = false;
			}
			if (__instance.TryGetComponent<Placeable>(out var component2) && string.IsNullOrEmpty(component2.m_Guid))
			{
				component2.Awake();
			}
			__instance.RefreshInteractionSetup();
			if (Settings.options.outlineVisibility > 0)
			{
				return false;
			}
			return true;
		}
	}

	[HarmonyPatch(typeof(DecorationItem), "OnStopCustomization")]
	private static class StopCustomizationOnItem
	{
		internal static void Postfix(ref DecorationItem __instance)
		{
			if (!__instance.gameObject.GetComponentInParent<NarrativeCollectibleItem>(includeInactive: true))
			{
				SCPMain.RestoreNormalInteraction(__instance);
			}
		}
	}

	[HarmonyPatch(typeof(DecorationItem), "OnPickup")]
	private static class PreventPickingUp
	{
		internal static bool Prefix(ref DecorationItem __instance)
		{
			string text = Utility.SanitizeObjectName(__instance.name);
			if (text.Contains("CONTAINER_FlareGun"))
			{
				__instance.RemoveFromHierarchy();
				GameManager.GetInventoryComponent().AddDecoration(__instance);
				return false;
			}
			WoodStove componentInChildren = __instance.GetComponentInChildren<WoodStove>();
			if ((bool)componentInChildren && componentInChildren.Fire.IsBurning())
			{
				GameAudioManager.PlayGUIError();
				HUDMessage.AddMessage(Localization.Get("SCP_Action_CantPickupHot"), highPriority: false, ignoreOverlayActive: true);
				__instance.m_ActionPicker.TrySetEnabled(enable: false);
				return false;
			}
			if (CarryableData.carryablePrefabDefinition.ContainsKey(text) && !CarryableData.carryablePrefabDefinition[text].pickupable)
			{
				GameAudioManager.PlayGUIError();
				HUDMessage.AddMessage(Localization.Get("SCP_Action_CantPickupPeriod"), highPriority: false, ignoreOverlayActive: true);
				__instance.m_ActionPicker.TrySetEnabled(enable: false);
				return false;
			}
			CarryableData.SetupCarryable(__instance, enlist: true);
			if (__instance.IconReference == null || !__instance.IconReference.RuntimeKeyIsValid())
			{
				SCPMain.RelevantSetupForDecorationItem(__instance);
			}
			return true;
		}
	}

	[HarmonyPatch(typeof(DecorationItem), "SetupInteraction")]
	private static class AddBreakDownToActions
	{
		internal static void Postfix(ref DecorationItem __instance)
		{
			BreakDown bd = __instance.GetComponentInChildren<BreakDown>();
			BreakDown breakDown = bd;
			if ((object)breakDown != null && breakDown.isActiveAndEnabled)
			{
				Action action = delegate
				{
					bd.PerformInteraction();
				};
				__instance.m_ItemData.Add(new ActionPickerItemData("ico_harvest", "GAMEPLAY_BreakDown", action));
			}
		}
	}

	[HarmonyPatch(typeof(Inventory), "MaybeAdd")]
	private static class InitialSetupForDecorationsInInventory
	{
		internal static void Postfix(ref Inventory __instance, ref GameObject go)
		{
			go.TryGetComponent<DecorationItem>(out var component);
			if ((bool)component && (component.IconReference == null || !component.IconReference.RuntimeKeyIsValid()))
			{
				SCPMain.RelevantSetupForDecorationItem(component);
			}
		}
	}

	[HarmonyPatch(typeof(Container), "Deserialize")]
	private static class InitialSetupForDecorationsInContainer
	{
		internal static void Postfix(ref Container __instance)
		{
			Il2CppSystem.Collections.Generic.List<DecorationItem>.Enumerator enumerator = __instance.m_DecorationItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DecorationItem current = enumerator.Current;
				if (current.IconReference == null || !current.IconReference.RuntimeKeyIsValid())
				{
					SCPMain.RelevantSetupForDecorationItem(current);
				}
			}
		}
	}

	[HarmonyPatch(typeof(Placeable), "Awake")]
	private static class InjectGuidsBeforeTheyRealize
	{
		internal static void Prefix(ref Placeable __instance)
		{
			if (!__instance.gameObject.GetComponentInParent<NarrativeCollectibleItem>(includeInactive: true) && injectPdids && !__instance.GetComponent<ObjectGuid>())
			{
				ObjectGuid orAddComponent = __instance.GetOrAddComponent<ObjectGuid>();
				if (string.IsNullOrEmpty(__instance.m_Guid) && !Utility.WithinDistance(__instance.transform.position, Vector3.zero))
				{
					Guid guid = Utility.GenerateSeededGuid(Utility.SeedFromCoords(__instance.transform.position));
					Utility.Log(PdidTable.GetGameObject(orAddComponent.m_Guid) ? ConsoleColor.Green : ConsoleColor.Gray, $"name {__instance.name} | PDID {orAddComponent.m_RuntimeCachedPdid} | seed {Utility.SeedFromCoords(__instance.transform.position)} | coords {__instance.transform.position.ToString("F4")}");
					PdidTable.RuntimeAddOrReplace(orAddComponent, guid.ToString());
				}
			}
		}
	}

	public static bool injectPdids;

	public static IEnumerator DisableOutline(DecorationItem di)
	{
		yield return new WaitForSeconds(1.5f);
		while (di.GetInstanceID() == GetDecorationIDUnderCrosshair())
		{
			if (!di || !GameManager.GetSafehouseManager().IsCustomizing())
			{
				yield break;
			}
			yield return new WaitForSeconds(1.5f);
		}
		if (GameManager.GetPlayerManagerComponent().m_ObjectToPlaceDecorationItem != di)
		{
			Il2Cpp.Utils.ResetPropertyBlockOnRenderers(di.GetRenderers());
		}
		TimedOutline.coroutines.Remove(di.GetInstanceID());
	}

	public static int GetDecorationIDUnderCrosshair()
	{
		if (Physics.Raycast(GameManager.GetMainCamera().ScreenPointToRay(Input.mousePosition), out var hitInfo, 3f, 787009))
		{
			DecorationItem componentInParent = hitInfo.collider.GetComponentInParent<DecorationItem>();
			if ((bool)componentInParent)
			{
				return componentInParent.GetInstanceID();
			}
		}
		return 0;
	}
}
