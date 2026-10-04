using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.AddressableAssets;
using Il2CppTLD.PDID;
using Il2CppTLD.Placement;
using MelonLoader;
using TLD.TinyJSON;
using UnityEngine;

namespace SCPlus;

internal class SaveLoadPatches
{
	[HarmonyPatch(typeof(GameManager), "ResetLists")]
	private static class ClearCarryablesOnSceneChange
	{
		internal static void Postfix()
		{
			CarryableManager.Reset();
		}
	}

	[HarmonyPatch(typeof(SaveGameSystem), "SaveSceneData")]
	private static class SaveOmittedData
	{
		internal static void Postfix(ref string sceneSaveName)
		{
			Utility.dataManager.Save(CarryableManager.SerializeAll(carried: false), Utility.movablesSaveDataTag + "_" + sceneSaveName);
			Utility.dataManager.Save(CarryableManager.SerializeAll(carried: true), Utility.movablesSaveDataTag + "_carried");
		}
	}

	[HarmonyPatch(typeof(SaveGameSystem), "LoadSceneData")]
	private static class MakeStuffMovable
	{
		internal static void Postfix(ref string sceneSaveName)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			string text = Utility.dataManager.Load(Utility.movablesSaveDataTag + "_" + sceneSaveName);
			string text2 = Utility.dataManager.Load(Utility.movablesSaveDataTag + "_carried");
			List<CarryableSaveDataProxy> item = new List<CarryableSaveDataProxy>();
			if (!string.IsNullOrEmpty(text))
			{
				JSON.MakeInto<List<CarryableSaveDataProxy>>(JSON.Load(text), out item);
			}
			List<CarryableSaveDataProxy> item2 = new List<CarryableSaveDataProxy>();
			if (!string.IsNullOrEmpty(text2))
			{
				JSON.MakeInto<List<CarryableSaveDataProxy>>(JSON.Load(text2), out item2);
			}
			for (int num = item.Count - 1; num >= 0; num--)
			{
				CarryableSaveDataProxy carryableSaveDataProxy = item[num];
				if ((carryableSaveDataProxy.state & CarryableData.CarryableState.ExistingDecoration) != CarryableData.CarryableState.None && !string.IsNullOrEmpty(carryableSaveDataProxy.guid))
				{
					GameObject gameObject = PdidTable.GetGameObject(carryableSaveDataProxy.guid);
					if ((bool)gameObject && !string.IsNullOrEmpty(carryableSaveDataProxy.dataToSave))
					{
						SCPlusCarryable sCPlusCarryable = gameObject.AddComponent<SCPlusCarryable>();
						CarryableManager.Add(sCPlusCarryable);
						sCPlusCarryable.FromProxy(carryableSaveDataProxy, full: false);
						sCPlusCarryable.RetrieveAdditionalData(carryableSaveDataProxy.dataToSave);
						item.RemoveAt(num);
					}
				}
				if (carryableSaveDataProxy.nativeScene.Contains(sceneSaveName) && Utility.FindCarryableAtPosition(carryableSaveDataProxy.name, carryableSaveDataProxy.originalPos, 1f, out GameObject go))
				{
					SCPlusCarryable sCPlusCarryable2 = go.AddComponent<SCPlusCarryable>();
					CarryableManager.Add(sCPlusCarryable2);
					sCPlusCarryable2.FromProxy(carryableSaveDataProxy, full: true);
					if (CarryableData.carryablePrefabDefinition.TryGetValue(carryableSaveDataProxy.name, out ObjectToModify value) && !value.pickupable)
					{
						go.transform.SetPositionAndRotation(carryableSaveDataProxy.currentPos, carryableSaveDataProxy.currentRot);
						item.RemoveAt(num);
						Utility.Log(ConsoleColor.Gray, $"Moving {carryableSaveDataProxy.name} in scene | native: {carryableSaveDataProxy.nativeScene} current: {carryableSaveDataProxy.currentScene}");
					}
					else
					{
						go.active = false;
						Utility.Log(ConsoleColor.Gray, $"Disabling {carryableSaveDataProxy.name} in scene | native: {carryableSaveDataProxy.nativeScene} current: {carryableSaveDataProxy.currentScene}");
						if ((carryableSaveDataProxy.state & CarryableData.CarryableState.Removed) != CarryableData.CarryableState.None)
						{
							item.RemoveAt(num);
						}
					}
				}
			}
			item = item.Concat(item2).ToList();
			stopwatch.Stop();
			Utility.Log(ConsoleColor.Blue, $"SC+ Prep pass: {stopwatch.ElapsedMilliseconds} ms ({stopwatch.ElapsedTicks} ticks)");
			if (item.Count == 0)
			{
				return;
			}
			stopwatch.Restart();
			SCPMain.instantiatingCarryables = true;
			GameObject gameObject2 = new GameObject("CarryableTemp");
			gameObject2.SetActive(value: false);
			foreach (CarryableSaveDataProxy item3 in item)
			{
				CarryableData.carryablePrefabDefinition.TryGetValue(item3.name, out ObjectToModify value2);
				if (value2 == null)
				{
					continue;
				}
				GameObject gameObject3 = AssetHelper.SafeInstantiateAssetAsync(value2.existingDecoration ? item3.name : value2.assetPath, gameObject2.transform).WaitForCompletion();
				if (value2.needsReconstruction)
				{
					gameObject3 = value2.reconstructAction();
				}
				switch (item3.type)
				{
				case CarryableData.CarryableType.FlareGunCase:
					foreach (PrefabSpawn componentsInChild in gameObject3.GetComponentsInChildren<PrefabSpawn>())
					{
						componentsInChild.m_SpawnComplete = true;
					}
					break;
				case CarryableData.CarryableType.MillingMachine:
					MelonCoroutines.Start(CarryableUniqueSetup.PrepareMillingMachine(gameObject3));
					break;
				case CarryableData.CarryableType.AmmoWorkbench:
				case CarryableData.CarryableType.Container:
					foreach (Container componentsInChild2 in gameObject3.GetComponentsInChildren<Container>())
					{
						componentsInChild2.m_DisableSerialization = true;
					}
					break;
				}
				if (gameObject3 != null)
				{
					gameObject3.name = item3.name;
					DecorationItem di = SCPMain.MakeIntoDecoration(gameObject3);
					SCPlusCarryable sCPlusCarryable3 = gameObject3.AddComponent<SCPlusCarryable>();
					sCPlusCarryable3.isInstance = true;
					bool flag = false;
					if ((item3.state & CarryableData.CarryableState.OnPlayer) != CarryableData.CarryableState.None)
					{
						Utility.Log(ConsoleColor.Gray, $"Instantiating {item3.name} in inventory | native: {item3.nativeScene} current: {item3.currentScene}");
						GameManager.GetInventoryComponent().AddDecoration(di);
						gameObject3.SetActive(value: false);
					}
					else if ((bool)item3.TryGetContainer())
					{
						Utility.Log(ConsoleColor.Gray, $"Instantiating {item3.name} in container | native: {item3.nativeScene} current: {item3.currentScene}");
						item3.TryGetContainer().AddDecorationItem(di);
						gameObject3.SetActive(value: false);
					}
					else
					{
						Utility.Log(ConsoleColor.Gray, $"Instantiating {item3.name} in scene | native: {item3.nativeScene} current: {item3.currentScene}");
						GameObject gameObject4 = PlaceableManager.FindOrCreateCategoryRoot();
						gameObject3.transform.SetParent(gameObject4.transform);
						flag = true;
					}
					CarryableManager.Add(sCPlusCarryable3);
					sCPlusCarryable3.FromProxy(item3, full: true);
					if (flag)
					{
						sCPlusCarryable3.RetrieveAdditionalData();
					}
				}
				else
				{
					Utility.Log(ConsoleColor.Red, "Failed to instantiate " + item3.name + ", check path: " + value2.assetPath);
				}
			}
			UnityEngine.Object.Destroy(gameObject2);
			SCPMain.instantiatingCarryables = false;
			stopwatch.Stop();
			Utility.Log(ConsoleColor.Blue, $"SC+ Init pass: {stopwatch.ElapsedMilliseconds} ms ({stopwatch.ElapsedTicks} ticks)");
		}
	}
}
