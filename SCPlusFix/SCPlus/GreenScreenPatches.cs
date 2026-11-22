using System;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Placement;
using UnityEngine;

namespace SCPlusPP;

internal class GreenScreenPatches
{
	[HarmonyPatch(typeof(PlayerManager), "StartPlaceMesh", new Type[]
	{
		typeof(GameObject),
		typeof(float),
		typeof(PlaceMeshFlags),
		typeof(PlaceMeshRules)
	})]
	private static class SetupGreenScreen
	{
		internal static bool Prefix(PlayerManager __instance, ref GameObject objectToPlace)
		{
			if (!Settings.options.devInspect || !InputManager.GetSprintDown(InputManager.m_CurrentContext))
			{
				return true;
			}
			DecorationItem component = objectToPlace.GetComponent<DecorationItem>();
			if ((bool)component)
			{
				GearItem gearItem = UnityEngine.Object.Instantiate(UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)"GEAR_Stone").WaitForCompletion().GetComponent<GearItem>());
				foreach (MeshRenderer meshRenderer in gearItem.m_MeshRenderers)
				{
					meshRenderer.enabled = false;
				}
				SCPMain.DEVInspectTempGO = UnityEngine.Object.Instantiate(component.gameObject);
				SCPMain.DEVInspectTempGO.transform.localScale = Vector3.one * 0.1f;
				GameManager.GetPlayerManagerComponent().EnterInspectGearMode(gearItem);
				SCPMain.DEVInspectTempGO.transform.SetParent(gearItem.transform);
				Collider component2 = SCPMain.DEVInspectTempGO.GetComponent<Collider>();
				SCPMain.DEVInspectTempGO.transform.position = Vector3.zero;
				SCPMain.DEVInspectTempGO.transform.localPosition = Vector3.zero;
				if ((bool)component2)
				{
					SCPMain.DEVInspectTempGO.transform.localPosition += Vector3.down * component2.bounds.extents.y / 2f;
				}
				SCPMain.DEVInspectTempGO.transform.localRotation = Quaternion.identity;
				foreach (Transform componentsInChild in SCPMain.DEVInspectTempGO.GetComponentsInChildren<Transform>())
				{
					componentsInChild.gameObject.layer = vp_Layer.InspectGear;
				}
				InterfaceManager.GetPanel<Panel_HUD>().m_InspectMode_InspectPrompts.active = false;
				InterfaceManager.GetPanel<Panel_HUD>().m_InspectMode_StatDetails.gameObject.active = false;
				InterfaceManager.GetPanel<Panel_HUD>().m_InspectMode_Description.gameObject.active = false;
				InterfaceManager.GetPanel<Panel_HUD>().m_InspectMode_Title.gameObject.active = false;
				InterfaceManager.GetPanel<Panel_HUD>().m_InspectModeItemTypeIcons[0].transform.GetParent().gameObject.active = false;
				InterfaceManager.GetPanel<Panel_HUD>().m_InspectMode_InventoryStatusSprite.gameObject.active = false;
				if (SCPMain.catalogParsed.ContainsKey(Utility.SanitizeObjectName(objectToPlace.name)) || (component.IconReference.RuntimeKeyIsValid() && component.IconReference.RuntimeKey.ToString() != SCPMain.catalogParsed["placeholder"]))
				{
					HUDMessage.AddMessage(Utility.SanitizeObjectName(objectToPlace.name) + " already has an icon!", highPriority: false, ignoreOverlayActive: true);
				}
				SCPMain.DEVInspectMode = true;
				return false;
			}
			return true;
		}
	}

	[HarmonyPatch(typeof(PlayerManager), "ExitInspectGearMode")]
	private static class StopDevInspect
	{
		internal static void Prefix(ref PlayerManager __instance)
		{
			if (Settings.options.devInspect && __instance.m_InspectModeActive && SCPMain.DEVInspectMode)
			{
				SCPMain.DEVInspectMode = false;
				SCPMain.SetupGreenscreen(GameManager.GetMainCamera(), reset: true);
				if ((bool)InterfaceManager.GetPanel<Panel_HUD>().m_InspectMode_StatDetails)
				{
					InterfaceManager.GetPanel<Panel_HUD>().m_InspectMode_StatDetails.gameObject.active = true;
				}
				if ((bool)InterfaceManager.GetPanel<Panel_HUD>().m_InspectModeItemTypeIcons[0]?.transform?.GetParent())
				{
					InterfaceManager.GetPanel<Panel_HUD>().m_InspectModeItemTypeIcons[0].transform.GetParent().gameObject.active = true;
				}
				if ((bool)InterfaceManager.GetPanel<Panel_HUD>().m_InspectMode_InventoryStatusSprite)
				{
					InterfaceManager.GetPanel<Panel_HUD>().m_InspectMode_InventoryStatusSprite.gameObject.active = true;
				}
				UnityEngine.Object.Destroy(SCPMain.DEVInspectTempGO?.transform?.parent?.gameObject);
			}
		}
	}

	[HarmonyPatch(typeof(UniStormWeatherSystem), "Update")]
	private static class DevInspectGreenscreen
	{
		internal static void Postfix()
		{
			if (SCPMain.DEVInspectMode && GameManager.GetPlayerManagerComponent().IsInspectModeActive())
			{
				SCPMain.SetupGreenscreen(GameManager.GetMainCamera());
			}
		}
	}
}
