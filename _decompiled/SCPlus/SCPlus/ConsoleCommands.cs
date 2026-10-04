using System;
using System.Collections;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using Il2CppSystem.Collections.Generic;
using Il2CppTLD.AddressableAssets;
using MelonLoader;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SCPlus;

internal class ConsoleCommands
{
	[HarmonyPatch(typeof(ConsoleManager), "Initialize")]
	private static class AddCommands
	{
		internal static void Postfix()
		{
			if (!SCPMain.decorationListPopulated)
			{
				SCPMain.decorationListPopulated = true;
				MelonCoroutines.Start(CONSOLE_PopulateDecortionsListEnum());
			}
			if (!uConsole.CommandIsRegistered("decoration_spawn"))
			{
				uConsole.RegisterCommand("decoration_spawn", (Action)CONSOLE_TrySpawnDecoration);
				uConsole.RegisterCommand("decoration_search", (Action)CONSOLE_SearchDecoration);
				uConsole.RegisterCommand("decoration_destroy", (Action)CONSOLE_DestroyDecoration);
				uConsole.RegisterCommand("decoration_list_repopulate", (Action)delegate
				{
					MelonCoroutines.Start(CONSOLE_PopulateDecortionsListEnum());
				});
			}
		}
	}

	[HarmonyPatch(typeof(uConsoleHistory), "Add")]
	private static class SkipAddingToHistory
	{
		internal static bool Prefix(string text)
		{
			if (text.StartsWith("decoration_destroy"))
			{
				return false;
			}
			return true;
		}
	}

	public static System.Collections.Generic.Dictionary<string, AssetReference> allVanillaDecorations = new System.Collections.Generic.Dictionary<string, AssetReference>(StringComparer.InvariantCultureIgnoreCase);

	public static void CONSOLE_TrySpawnDecoration()
	{
		string text = uConsole.GetString();
		if (string.IsNullOrEmpty(text))
		{
			uConsoleLog.Add("Specify Decoration name");
			return;
		}
		GameObject gameObject = (allVanillaDecorations.ContainsKey(text) ? AssetHelper.SafeInstantiateAssetAsync(allVanillaDecorations[text].m_AssetGUID).WaitForCompletion() : null);
		if (CarryableData.carryablePrefabDefinition.ContainsKey(text) && CarryableData.carryablePrefabDefinition[text].pickupable)
		{
			if (CarryableData.carryablePrefabDefinition[text].needsReconstruction)
			{
				gameObject = CarryableData.carryablePrefabDefinition[text].reconstructAction();
			}
			if ((bool)gameObject && text.ToLower().Contains("millingmachine"))
			{
				MelonCoroutines.Start(CarryableUniqueSetup.PrepareMillingMachine(gameObject));
			}
			if ((bool)gameObject && text.ToLower().Contains("forge") && (bool)gameObject.GetComponentInChildren<CapsuleCollider>())
			{
				gameObject.GetComponentInChildren<CapsuleCollider>().radius = 0.06f;
			}
		}
		if (gameObject == null)
		{
			gameObject = AssetHelper.SafeInstantiateAssetAsync(text.Trim()).WaitForCompletion();
			if (gameObject == null)
			{
				uConsoleLog.Add("Could not load " + text);
				return;
			}
		}
		SCPMain.decorationJustDuped = true;
		GameManager.GetPlayerManagerComponent().StartPlaceMesh(gameObject, PlaceMeshFlags.DestroyOnCancel, Utility.genericPlacementRules);
		uConsole.TurnOff();
	}

	public static void CONSOLE_SearchDecoration()
	{
		string value = uConsole.GetString();
		if (string.IsNullOrEmpty(value))
		{
			uConsoleLog.Add("Specify Decoration name");
			return;
		}
		System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();
		foreach (System.Collections.Generic.KeyValuePair<string, AssetReference> allVanillaDecoration in allVanillaDecorations)
		{
			if (allVanillaDecoration.Key.ToLowerInvariant().Contains(value))
			{
				list.Add(allVanillaDecoration.Key);
			}
		}
		if (list.Count <= 0)
		{
			return;
		}
		uConsoleLog.Add("   Matching Names:");
		foreach (string item in list)
		{
			uConsoleLog.Add(item);
		}
	}

	public static void CONSOLE_DestroyDecoration()
	{
		if (!GameManager.GetSafehouseManager().IsCustomizing())
		{
			uConsoleLog.Add("Enable customization mode to use this command");
			return;
		}
		string text = uConsole.GetString();
		if (string.IsNullOrEmpty(text))
		{
			uConsoleLog.Add("Usage(to prevent accidents): decoration_destroy fr");
		}
		else if (text == "fr")
		{
			GameObject interactiveGameObjectUnderCrosshair = Utility.GetInteractiveGameObjectUnderCrosshair();
			string text2 = Utility.SanitizeObjectName(interactiveGameObjectUnderCrosshair.name);
			if (CarryableData.carryablePrefabDefinition.ContainsKey(text2) && !CarryableData.carryablePrefabDefinition[text2].pickupable)
			{
				uConsoleLog.Add("You don't want to do that");
			}
			else if (interactiveGameObjectUnderCrosshair?.GetComponent<DecorationItem>() != null)
			{
				uConsoleLog.Add("Destroyed " + text2);
				UnityEngine.Object.Destroy(interactiveGameObjectUnderCrosshair);
			}
			else
			{
				uConsoleLog.Add("No decoration found under crosshairs");
			}
		}
	}

	public static IEnumerator CONSOLE_PopulateDecortionsListEnum()
	{
		uConsoleLog.Add("Populating decoration list...");
		allVanillaDecorations.Clear();
		int i = 0;
		Il2CppSystem.Collections.Generic.List<AssetReference>.Enumerator enumerator = DecorationItemVerificationList.Load().m_DecorationPrefabs.GetEnumerator();
		while (enumerator.MoveNext())
		{
			AssetReference current = enumerator.Current;
			i++;
			if (!current.RuntimeKeyIsValid())
			{
				continue;
			}
			GameObject gameObject = AssetHelper.SafeLoadAssetAsync<GameObject>(current.m_AssetGUID).WaitForCompletion();
			if ((bool)gameObject)
			{
				string text = gameObject.name;
				while (allVanillaDecorations.ContainsKey(text))
				{
					text = text.Replace("_Prefab", "") + "_Alt";
				}
				allVanillaDecorations[text] = current;
				if (i > 30)
				{
					i = 0;
					yield return new WaitForEndOfFrame();
				}
			}
		}
		foreach (System.Collections.Generic.KeyValuePair<string, ObjectToModify> item in CarryableData.carryablePrefabDefinition)
		{
			if (item.Value.pickupable && !item.Value.existingDecoration)
			{
				if (!item.Value.needsReconstruction)
				{
					allVanillaDecorations[item.Key] = new AssetReference(item.Value.assetPath);
				}
				else
				{
					allVanillaDecorations[item.Key] = new AssetReference();
				}
			}
		}
		uConsoleLog.Add($"SC+ decoration list populated with {allVanillaDecorations.Count} entries");
		uConsoleCommandParameterSet uConsoleCommandParameterSet = null;
		Il2CppSystem.Collections.Generic.List<uConsoleCommandParameterSet>.Enumerator enumerator3 = uConsoleAutoComplete.m_CommandParameterSets.GetEnumerator();
		while (enumerator3.MoveNext())
		{
			uConsoleCommandParameterSet current3 = enumerator3.Current;
			if (current3.m_Commands.Contains("decoration_spawn"))
			{
				current3.m_AllowedParameters.Clear();
				uConsoleCommandParameterSet = current3;
			}
		}
		if (uConsoleCommandParameterSet == null)
		{
			uConsoleCommandParameterSet = new uConsoleCommandParameterSet
			{
				m_Commands = new Il2CppSystem.Collections.Generic.List<string>(),
				m_AllowedParameters = new Il2CppSystem.Collections.Generic.List<string>()
			};
			uConsoleCommandParameterSet.m_Commands.Add("decoration_spawn");
		}
		foreach (System.Collections.Generic.KeyValuePair<string, AssetReference> allVanillaDecoration in allVanillaDecorations)
		{
			if (!uConsoleCommandParameterSet.m_AllowedParameters.Contains(allVanillaDecoration.Key))
			{
				uConsoleCommandParameterSet.m_AllowedParameters.Add(allVanillaDecoration.Key);
				uConsoleCommandParameterSet.m_AllowedParameters.Add(allVanillaDecoration.Key.ToLowerInvariant());
			}
		}
		uConsoleAutoComplete.m_CommandParameterSets.Add(uConsoleCommandParameterSet);
	}
}
