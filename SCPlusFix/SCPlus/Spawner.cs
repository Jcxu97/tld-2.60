using System;
using Il2Cpp;
using Il2CppTLD.AddressableAssets;
using MelonLoader;
using UnityEngine;

namespace SCPlusPP;

// TldHacks 物品生成器用反射调这里,把 SC+ 自己存档的器械直接放进背包。
// 和读档时重建"在玩家身上"的那条路一样,存档也就跟收起来的那些一样走 SC+ 的 carried 列表
public static class Spawner
{
	public static bool SpawnCarryable(string name)
	{
		if (!CarryableData.carryablePrefabDefinition.TryGetValue(name, out ObjectToModify def) || !def.pickupable || def.existingDecoration)
		{
			return false;
		}
		GameObject temp = new GameObject("CarryableSpawnTemp");
		temp.SetActive(false);
		GameObject go = null;
		try
		{
			SCPMain.instantiatingCarryables = true;
			go = def.needsReconstruction ? def.reconstructAction() : AssetHelper.SafeInstantiateAssetAsync(def.assetPath, temp.transform).WaitForCompletion();
			if (go == null)
			{
				return false;
			}
			switch (def.type)
			{
			case CarryableData.CarryableType.FlareGunCase:
				foreach (PrefabSpawn ps in go.GetComponentsInChildren<PrefabSpawn>(true))
				{
					ps.m_SpawnComplete = true;
				}
				break;
			case CarryableData.CarryableType.MillingMachine:
				MelonCoroutines.Start(CarryableUniqueSetup.PrepareMillingMachine(go));
				break;
			case CarryableData.CarryableType.AmmoWorkbench:
			case CarryableData.CarryableType.Container:
				foreach (Container c in go.GetComponentsInChildren<Container>(true))
				{
					c.m_DisableSerialization = true;
				}
				break;
			}
			go.name = name;
			DecorationItem di = SCPMain.MakeIntoDecoration(go);
			SCPlusCarryable sc = go.AddComponent<SCPlusCarryable>();
			sc.objectName = name;
			sc.type = def.type;
			sc.isInstance = true;
			sc.isDuped = true;
			GameManager.GetInventoryComponent().AddDecoration(di);
			go.SetActive(false);
			CarryableManager.Add(sc);
			return true;
		}
		catch (Exception ex)
		{
			MelonLogger.Error("SC+ spawn " + name + " failed: " + ex);
			if (go != null)
			{
				UnityEngine.Object.Destroy(go);
			}
			return false;
		}
		finally
		{
			SCPMain.instantiatingCarryables = false;
			UnityEngine.Object.Destroy(temp);
		}
	}

	public static void SetupDecoration(DecorationItem di)
	{
		SCPMain.RelevantSetupForDecorationItem(di);
	}
}
