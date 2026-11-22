using System;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppVLB;
using UnityEngine;

namespace SCPlusPP;

internal class CarryableData
{
	public enum CarryableType
	{
		Basic,
		Stove,
		WaterSource,
		TraderRadio,
		TreeLimb,
		Forge,
		AmmoWorkbench,
		MillingMachine,
		FlareGunCase,
		Container
	}

	[Flags]
	public enum CarryableState
	{
		None = 0,
		Removed = 1,
		OnPlayer = 2,
		Dismantled = 4,
		InContainer = 8,
		ExistingDecoration = 0x10,
		Surplus = 0x20
	}

	public static float carriedObjectWeight = 0f;

	public static string[] blacklist = new string[1] { "CONTAINER_CacheStoreCommon" };

	public static string[] skipLayerChange = new string[4] { "INTERACTIVE_Forge", "OBJ_Suitcase", "CONTAINER_FirewoodBin", "CONTAINER_ForestryCrate" };

	public static Dictionary<string, ObjectToModify> carryablePrefabDefinition = new Dictionary<string, ObjectToModify>(StringComparer.OrdinalIgnoreCase)
	{
		{
			"INTERACTIVE_SURVIVAL_TraderRadio",
			new ObjectToModify
			{
				assetPath = "",
				type = CarryableType.TraderRadio,
				pickupable = false
			}
		},
		{
			"INTERACTIVE_StoveMetalA",
			new ObjectToModify
			{
				assetPath = "Assets/Prefabs/Interactive/INTERACTIVE_StoveMetalA.prefab",
				type = CarryableType.Stove
			}
		},
		{
			"INTERACTIVE_PotBellyStove",
			new ObjectToModify
			{
				assetPath = "Assets/Prefabs/Interactive/INTERACTIVE_PotBellyStove.prefab",
				type = CarryableType.Stove
			}
		},
		{
			"INTERACTIVE_StoveWoodC",
			new ObjectToModify
			{
				assetPath = "",
				type = CarryableType.Stove,
				needsReconstruction = true,
				reconstructAction = () => CarryableUniqueSetup.ReconstructStoveWood()
			}
		},
		{
			"INTERACTIVE_FireBarrel",
			new ObjectToModify
			{
				type = CarryableType.Stove,
				existingDecoration = true
			}
		},
		{
			"INTERACTIVE_RimGrill",
			new ObjectToModify
			{
				type = CarryableType.Stove,
				existingDecoration = true
			}
		},
		{
			"CONTAINER_FlareGun",
			new ObjectToModify
			{
				assetPath = "Assets/Prefabs/Containers/CONTAINER_FlareGun.prefab",
				type = CarryableType.FlareGunCase
			}
		},
		{
			"CONTAINER_ForestryCrate",
			new ObjectToModify
			{
				assetPath = "CONTAINER_ForestryCrate",
				type = CarryableType.Container
			}
		},
		{
			"CONTAINER_ForestryCrateB",
			new ObjectToModify
			{
				assetPath = "Assets/Prefabs/Containers/CONTAINER_ForestryCrateB.prefab",
				type = CarryableType.Container
			}
		},
		{
			"CONTAINER_FirewoodBin",
			new ObjectToModify
			{
				assetPath = "Assets/Prefabs/Containers/CONTAINER_FirewoodBin.prefab",
				type = CarryableType.Container
			}
		},
		{
			"CONTAINER_CoalBin",
			new ObjectToModify
			{
				assetPath = "Assets/Prefabs/Containers/CONTAINER_CoalBin.prefab",
				type = CarryableType.Container
			}
		},
		{
			"INTERACTIVE_Forge",
			new ObjectToModify
			{
				assetPath = "Assets/Prefabs/Interactive/INTERACTIVE_Forge.prefab",
				type = CarryableType.Stove
			}
		},
		{
			"INTERACTIVE_AmmoWorkBench",
			new ObjectToModify
			{
				assetPath = "Assets/Prefabs/Interactive/INTERACTIVE_AmmoWorkBench.prefab",
				type = CarryableType.AmmoWorkbench
			}
		},
		{
			"INTERACTIVE_IndustrialMillingMachine",
			new ObjectToModify
			{
				assetPath = "Assets/ArtAssets/Env/Objects/OBJ_IndustrialMillingMachine/OBJ_IndustrialMillingMachine_Prefab.prefab",
				type = CarryableType.MillingMachine
			}
		}
	};

	public static Dictionary<string, OverrideData> decorationOverrideData = new Dictionary<string, OverrideData>(StringComparer.OrdinalIgnoreCase)
	{
		{
			"INTERACTIVE_SURVIVAL_TraderRadio",
			new OverrideData
			{
				nameLocID = "SCP_Deco_TraderRadio",
				weight = 4f
			}
		},
		{
			"CONTAINER_FlareGun",
			new OverrideData
			{
				nameLocID = "SCP_Deco_FlareGunCase",
				weight = 4f
			}
		},
		{
			"INTERACTIVE_AmmoWorkBench",
			new OverrideData
			{
				nameLocID = "SCP_Deco_AmmoWorkbench",
				weight = 40f,
				placementOffset = Vector3.up * 0.8f
			}
		},
		{
			"INTERACTIVE_FireBarrel",
			new OverrideData
			{
				weight = 10f
			}
		},
		{
			"INTERACTIVE_PotBellyStove",
			new OverrideData
			{
				weight = 30f
			}
		},
		{
			"INTERACTIVE_StoveWoodC",
			new OverrideData
			{
				weight = 30f
			}
		},
		{
			"INTERACTIVE_StoveMetalA",
			new OverrideData
			{
				weight = 50f
			}
		},
		{
			"INTERACTIVE_Forge",
			new OverrideData
			{
				nameLocID = "SCP_Deco_Forge",
				weight = 50f
			}
		},
		{
			"INTERACTIVE_IndustrialMillingMachine",
			new OverrideData
			{
				weight = 50f,
				placementOffset = Vector3.up * 1.2f
			}
		},
		{
			"CONTAINER_ForestryCrate",
			new OverrideData
			{
				weight = 10f
			}
		},
		{
			"CONTAINER_ForestryCrateB",
			new OverrideData
			{
				weight = 10f
			}
		},
		{
			"CONTAINER_FirewoodBin",
			new OverrideData
			{
				weight = 10f
			}
		},
		{
			"CONTAINER_CoalBin",
			new OverrideData
			{
				weight = 10f
			}
		},
		{
			"CONTAINER_CacheStoreCommon",
			new OverrideData
			{
				weight = 0.5f
			}
		},
		{
			"OBJ_Piano_Prefab",
			new OverrideData
			{
				weight = 40f
			}
		},
		{
			"OBJ_CurtainStage_Prefab",
			new OverrideData
			{
				weight = 10f
			}
		},
		{
			"OBJ_ClothesHanger_Prefab",
			new OverrideData
			{
				weight = 0.1f
			}
		},
		{
			"CONTAINER_LockBoxB",
			new OverrideData
			{
				weight = 0.8f
			}
		}
	};

	public static Dictionary<string, HashSet<BlacklistObject>> blacklistSpecific = new Dictionary<string, HashSet<BlacklistObject>>(StringComparer.OrdinalIgnoreCase);

	public static SCPlusCarryable? SetupCarryable(DecorationItem di, bool enlist)
	{
		foreach (KeyValuePair<string, ObjectToModify> item in carryablePrefabDefinition)
		{
			if (!di.name.ToLower().Contains(item.Key.ToLower()))
			{
				continue;
			}
			SCPlusCarryable orAddComponent = di.GetOrAddComponent<SCPlusCarryable>();
			if (string.IsNullOrEmpty(orAddComponent.objectName))
			{
				orAddComponent.objectName = Utility.SanitizeObjectName(di.name);
			}
			if (orAddComponent.originalPos == Vector3.zero)
			{
				if (di.transform.position == Vector3.zero)
				{
					orAddComponent.isDuped = true;
				}
				else
				{
					orAddComponent.originalPos = di.transform.position;
				}
			}
			if (string.IsNullOrEmpty(orAddComponent.nativeScene))
			{
				orAddComponent.nativeScene = di.gameObject.scene.name;
			}
			orAddComponent.type = item.Value.type;
			if (enlist)
			{
				CarryableManager.Add(orAddComponent);
			}
			return orAddComponent;
		}
		return null;
	}
}
