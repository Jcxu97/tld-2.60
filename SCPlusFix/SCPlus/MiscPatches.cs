using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using Il2CppSystem.Collections.Generic;
using Il2CppTLD.BigCarry;
using Il2CppTLD.IntBackedUnit;
using Il2CppTLD.Placement;
using Il2CppVLB;
using UnityEngine;

namespace SCPlusPP;

internal class MiscPatches
{
	[HarmonyPatch(typeof(Il2Cpp.Utils), "ApplyPropertyBlockToRenderers")]
	public static class SkipOutline
	{
		public static System.Collections.Generic.List<int> inProximity = new System.Collections.Generic.List<int>();

		internal static bool Prefix(Il2CppSystem.Collections.Generic.List<Renderer> renderers, ref MaterialPropertyBlock propertyBlock)
		{
			if (Settings.options.outlineVisibility == 1 && propertyBlock != null)
			{
				int instanceID = renderers[0].GetInstanceID();
				if (!inProximity.Contains(instanceID) && !propertyBlock.HasColor("_Color"))
				{
					propertyBlock = null;
				}
			}
			if (Settings.options.outlineVisibility == 3 && propertyBlock != null)
			{
				return false;
			}
			return true;
		}
	}

	[HarmonyPatch(typeof(Container), "Deserialize")]
	private static class InitDecoInContainers
	{
		internal static void Postfix(ref Container __instance)
		{
			Il2CppSystem.Collections.Generic.List<DecorationItem>.Enumerator enumerator = __instance.m_DecorationItems.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DecorationItem current = enumerator.Current;
				if (!current)
				{
					continue;
				}
				BreakDown componentInChildren = __instance.GetComponentInChildren<BreakDown>();
				if (!current.m_AllowInInventory)
				{
					current.m_AllowInInventory = true;
					SCPMain.RelevantSetupForDecorationItem(current, weightOnly: true);
					if ((bool)componentInChildren)
					{
						componentInChildren.m_AllowEditModePlacement = true;
					}
				}
			}
		}
	}

	[HarmonyPatch(typeof(SafehouseManager), "Awake")]
	private static class OutlineThings
	{
		internal static void Postfix(ref SafehouseManager __instance)
		{
			__instance.m_OutlineColor = Utility.outlineColor.HueAdjust(Settings.options.outlineHue).AlphaAdjust(Settings.options.outlineAlpha);
			__instance.m_OnHoverColor = Utility.outlineColor.HueAdjust(Settings.options.outlineHue);
			__instance.m_OnHoverPropertyBlock.SetColor("_Color", __instance.m_OnHoverColor);
			__instance.m_OutlineThickness = Settings.options.outlineThickness;
		}
	}

	[HarmonyPatch(typeof(SafehouseManager), "StartCustomizing")]
	private static class AddBall
	{
		internal static void Postfix()
		{
			if (Settings.options.outlineVisibility == 1)
			{
				GameManager.GetPlayerTransform().gameObject.GetOrAddComponent<SCPlusDecorationDetector>();
			}
		}
	}

	[HarmonyPatch(typeof(SafehouseManager), "StopCustomizing")]
	private static class RemoveBall
	{
		internal static void Postfix()
		{
			if (Settings.options.outlineVisibility == 1 && GameManager.GetPlayerTransform().TryGetComponent<SCPlusDecorationDetector>(out var component))
			{
				UnityEngine.Object.Destroy(component);
			}
		}
	}

	[HarmonyPatch(typeof(SafehouseManager), "InCustomizableSafehouse")]
	private static class AlwaysCustomizable
	{
		internal static void Postfix(ref SafehouseManager __instance, ref bool __result)
		{
			__result = true;
		}
	}

	[HarmonyPatch(typeof(SafehouseManager), "TryStartCustomizing")]
	private static class NoCustomizationWithTravois
	{
		internal static bool Prefix(ref SafehouseManager __instance, ref bool __result)
		{
			if (GameManager.GetPlayerAnimationComponent().m_Animator.GetCurrentAnimatorClipInfo(0)[0].clip.name.ToLower().Contains("travois"))
			{
				GameAudioManager.PlayGUIError();
				HUDMessage.AddMessage(Localization.Get("SCP_Action_NoCustomizationWithTravois"), highPriority: true, ignoreOverlayActive: true);
				__result = false;
				return false;
			}
			return true;
		}
	}

	[HarmonyPatch(typeof(BigCarryItem), "PerformInteraction")]
	private static class NoTravoisWhenCustomizing
	{
		internal static bool Prefix(ref BigCarryItem __instance, ref bool __result)
		{
			if (GameManager.GetSafehouseManager().IsCustomizing() && __instance.name.ToLower().Contains("travois"))
			{
				GameAudioManager.PlayGUIError();
				HUDMessage.AddMessage(Localization.Get("SCP_Action_NoTravoisWhenCustomizing"), highPriority: true, ignoreOverlayActive: true);
				__result = false;
				return false;
			}
			return true;
		}
	}

	[HarmonyPatch(typeof(Panel_HUD), "UpdateSafehouse")]
	private static class HideIconWhenNotCustomizing
	{
		internal static void Postfix(ref Panel_HUD __instance)
		{
			if (Settings.options.hideIcon > 0)
			{
				if (Settings.options.hideIcon == 1 && !GameManager.GetSafehouseManager().IsCustomizing())
				{
					__instance.m_SafehouseRoot.active = false;
				}
				if (Settings.options.hideIcon == 2)
				{
					__instance.m_SafehouseRoot.active = false;
				}
			}
		}
	}

	[HarmonyPatch(typeof(Inventory), "GetExtraWeightKG")]
	private static class AddDecorationToOverallCarriedWeight
	{
		internal static void Postfix(ref ItemWeight __result)
		{
			if (GameManager.GetPlayerManagerComponent().IsInMeshPlacementMode() && (bool)GameManager.GetPlayerManagerComponent().m_ObjectToPlaceDecorationItem)
			{
				__result = ItemWeight.FromKilograms(__result.ToQuantity(1f) + CarryableData.carriedObjectWeight);
			}
		}
	}

	[HarmonyPatch(typeof(PlayerManager), "StartPlaceMesh", new Type[]
	{
		typeof(GameObject),
		typeof(float),
		typeof(PlaceMeshFlags),
		typeof(PlaceMeshRules)
	})]
	private static class ManagePlacement
	{
		public static Vector3 offset = Vector3.zero;

		internal static bool Prefix(PlayerManager __instance, ref GameObject objectToPlace, ref bool __result)
		{
			objectToPlace.TryGetComponent<DecorationItem>(out var component);
			if (!component)
			{
				foreach (System.Collections.Generic.KeyValuePair<string, ObjectToModify> item in CarryableData.carryablePrefabDefinition)
				{
					if (objectToPlace.name.ToLower().Contains(item.Key.ToLower()))
					{
						component = SCPMain.MakeIntoDecoration(objectToPlace);
					}
				}
			}
			if ((bool)component)
			{
				string text = Utility.SanitizeObjectName(component.name);
				Il2CppSystem.Collections.Generic.List<Renderer>.Enumerator enumerator2 = component.GetRenderers().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Renderer current2 = enumerator2.Current;
					if ((bool)current2)
					{
						current2.enabled = true;
						if (current2.name.EndsWith("_Shadow"))
						{
							current2.gameObject.active = false;
						}
					}
				}
				Il2CppSystem.Collections.Generic.List<DecorationItem> list = new Il2CppSystem.Collections.Generic.List<DecorationItem>();
				Il2CppSystem.Collections.Generic.List<DecorationItem>.Enumerator enumerator3 = component.DecorationChildren.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DecorationItem current3 = enumerator3.Current;
					if ((bool)current3)
					{
						current3.gameObject.active = true;
						list.Add(current3);
					}
				}
				component.m_DecorationChildren = list;
				WoodStove componentInChildren = objectToPlace.GetComponentInChildren<WoodStove>(includeInactive: true);
				if ((bool)componentInChildren)
				{
					Fire fire = componentInChildren.Fire;
					if ((object)fire != null && fire.IsBurning())
					{
						GameAudioManager.PlayGUIError();
						HUDMessage.AddMessage(Localization.Get("SCP_Action_CantMoveHot"));
						__instance.CancelPlaceMesh();
						__result = false;
						return false;
					}
				}
				bool flag = component.gameObject.scene.name != "DontDestroyOnLoad" && !Settings.options.ignorePlaceWeight && !SCPMain.decorationJustDuped;
				bool flag2 = component.gameObject.scene.name == "DontDestroyOnLoad" || GameManager.GetInventoryComponent().m_DecorationItems.Contains(component);
				Container[] array = objectToPlace.GetComponentsInChildren<Container>();
				if (array.Length != 0)
				{
					CarryableData.carriedObjectWeight = 0f;
					Container[] array2 = array;
					foreach (Container container in array2)
					{
						if (flag)
						{
							CarryableData.carriedObjectWeight += container.GetTotalWeightKG().ToQuantity(1f);
						}
						if (SCPMain.decorationJustDuped || flag2)
						{
							container.MakeEmpty();
						}
					}
					if (flag)
					{
						CarryableData.carriedObjectWeight += component.Weight.ToQuantity(1f);
						Utility.Log(ConsoleColor.Gray, "Moving in-scene container, weight: " + CarryableData.carriedObjectWeight);
						if (CarryableData.carriedObjectWeight + GameManager.GetEncumberComponent().GetGearWeightKG().ToQuantity(1f) > GameManager.GetEncumberComponent().GetNoWalkCarryCapacityKG().ToQuantity(1f))
						{
							GameAudioManager.PlayGUIError();
							HUDMessage.AddMessage(Localization.Get("SCP_Action_CantMoveHeavy"));
							__instance.CancelPlaceMesh();
							__result = false;
							return false;
						}
					}
				}
				else if (flag)
				{
					CarryableData.carriedObjectWeight = component.Weight.ToQuantity(1f);
					if (CarryableData.carriedObjectWeight + GameManager.GetEncumberComponent().GetGearWeightKG().ToQuantity(1f) > GameManager.GetEncumberComponent().GetNoWalkCarryCapacityKG().ToQuantity(1f))
					{
						GameAudioManager.PlayGUIError();
						HUDMessage.AddMessage(Localization.Get("SCP_Action_CantMoveHeavy"));
						__instance.CancelPlaceMesh();
						__result = false;
						return false;
					}
				}
				SCPlusCarryable sCPlusCarryable = CarryableData.SetupCarryable(component, enlist: false);
				if (sCPlusCarryable != null)
				{
					if (SCPMain.decorationJustDuped)
					{
						sCPlusCarryable.isInstance = true;
					}
					sCPlusCarryable.RetrieveAdditionalData();
				}
				if (component.name.ToLower().Contains("curtain"))
				{
					component.name = text;
				}
				offset = Vector3.zero;
				if (CarryableData.decorationOverrideData.TryGetValue(text, out OverrideData value) && value.placementOffset != Vector3.zero)
				{
					offset = value.placementOffset;
				}
			}
			return true;
		}
	}

	[HarmonyPatch(typeof(PlayerManager), "UpdatePlaceMesh")]
	private static class PlacementOffset
	{
		internal static void Postfix(ref PlayerManager __instance)
		{
			if (ManagePlacement.offset != Vector3.zero && __instance.IsInMeshPlacementMode() && __instance.m_ObjectToPlace != null)
			{
				__instance.m_ObjectToPlace.transform.position += ManagePlacement.offset;
			}
		}
	}

	[HarmonyPatch(typeof(PlayerManager), "AttemptToPlaceMesh")]
	private static class ResetOffset
	{
		internal static void Prefix(ref PlayerManager __instance)
		{
			if (__instance.CanPlaceCurrentPlaceable())
			{
				ManagePlacement.offset = Vector3.zero;
			}
		}
	}

	[HarmonyPatch(typeof(PlayerManager), "DoPositionCheck")]
	private static class OverridePositionCheck
	{
		internal static void Postfix(ref PlayerManager __instance, ref MeshLocationCategory __result)
		{
			if ((bool)__instance.m_ObjectToPlaceDecorationItem && InputManager.GetSprintDown(InputManager.m_CurrentContext) && (__result != MeshLocationCategory.Valid || __result != MeshLocationCategory.ValidOutOfRange || __result != MeshLocationCategory.ValidOutOfRangeFar))
			{
				float num = Vector3.Distance(__instance.m_ObjectToPlace.transform.position, GameManager.GetPlayerTransform().position);
				if (num > __instance.m_PlacementDistanceFar)
				{
					__result = MeshLocationCategory.ValidOutOfRangeFar;
				}
				else if (num > __instance.m_PlacementDistance)
				{
					__result = MeshLocationCategory.ValidOutOfRange;
				}
				else
				{
					__result = MeshLocationCategory.Valid;
				}
			}
		}
	}

	[HarmonyPatch(typeof(PlayerManager), "ExitMeshPlacement")]
	private static class ExitPlacement
	{
		private static DecorationItem di;

		internal static void Prefix(ref PlayerManager __instance)
		{
			di = __instance.m_ObjectToPlaceDecorationItem;
		}

		internal static void Postfix()
		{
			SCPMain.decorationJustDuped = false;
			DecorationItem decorationItem = di;
			if ((object)decorationItem == null || !decorationItem.isActiveAndEnabled)
			{
				return;
			}
			Il2CppSystem.Collections.Generic.List<Renderer>.Enumerator enumerator = di.GetRenderers().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Renderer current = enumerator.Current;
				if ((bool)current && current.name.EndsWith("_Shadow"))
				{
					current.gameObject.active = true;
				}
			}
			di.TryGetComponent<SCPlusCarryable>(out var component);
			if ((bool)component)
			{
				CarryableManager.Add(component);
			}
		}
	}

	[HarmonyPatch(typeof(InventoryGridItem), "RefreshDecorationItem")]
	private static class RefreshInventoryGridIndicationIcon
	{
		internal static void Postfix(ref InventoryGridItem __instance)
		{
			DecorationItem decorationItem = __instance.GetDecorationItem();
			if ((bool)decorationItem)
			{
				if (SCPMain.iconGuidLookupList.Contains(decorationItem.IconReference.RuntimeKey.ToString()))
				{
					__instance.m_DecorationIndicator.GetComponent<UISprite>().spriteName = "ico_SafehouseCustomization";
				}
				else
				{
					__instance.m_DecorationIndicator.GetComponent<UISprite>().spriteName = "ico_Safehouse";
				}
			}
		}
	}

	[HarmonyPatch(typeof(ItemDescriptionPage), "UpdateDecorationItemDescription")]
	private static class ChangeCarryableInventoryLabel
	{
		internal static void Postfix(ref ItemDescriptionPage __instance, ref DecorationItem di)
		{
			if (SCPMain.iconGuidLookupList.Contains(di.IconReference.RuntimeKey.ToString()))
			{
				if ((bool)di.GetComponent<SCPlusCarryable>())
				{
					__instance.m_ItemNotesLabel.text = Localization.Get("SCP_Label_Carryable");
				}
				else
				{
					__instance.m_ItemNotesLabel.text = Localization.Get("SCP_Label_Decoration");
				}
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Container), "OnInventoryToContainer")]
	private static class PreventStoringCarryablesInCarryables
	{
		internal static bool Prefix(ref Panel_Container __instance)
		{
			InventoryGridDataItem currentlySelectedItem = __instance.GetCurrentlySelectedItem();
			if (!currentlySelectedItem.m_DecorationItem)
			{
				return true;
			}
			SCPlusCarryable component = currentlySelectedItem.m_DecorationItem.GetComponent<SCPlusCarryable>();
			SCPlusCarryable componentInParent = __instance.m_Container.GetComponentInParent<SCPlusCarryable>();
			if ((bool)component && (bool)componentInParent)
			{
				GameAudioManager.PlayGUIError();
				HUDMessage.AddMessage(Localization.Get("SCP_Action_CantStoreCarryableInCarryable"), highPriority: false, ignoreOverlayActive: true);
				return false;
			}
			return true;
		}
	}

	[HarmonyPatch(typeof(Panel_Container), "OnContainerToInventory")]
	private static class PreventTakingUnfinishedDecorations
	{
		internal static bool Prefix(ref Panel_Container __instance)
		{
			InventoryGridDataItem currentlySelectedItem = __instance.GetCurrentlySelectedItem();
			if (!currentlySelectedItem.m_DecorationItem)
			{
				return true;
			}
			if ((bool)currentlySelectedItem.m_DecorationItem.GetComponent<InProgressCraftItem>())
			{
				GameAudioManager.PlayGUIError();
				HUDMessage.AddMessage(Localization.Get("Gameplay_DecorationNotAllowedInInventory"), highPriority: false, ignoreOverlayActive: true);
				return false;
			}
			return true;
		}
	}
}
