using System;
using System.Linq;
using System.Text.RegularExpressions;
using Il2Cpp;
using Il2CppTLD.Utility;
using Il2CppVLB;
using MelonLoader;
using UnityEngine;

namespace SCPlusPP;

[RegisterTypeInIl2Cpp]
internal class SCPlusCarryable : MonoBehaviour
{
	public string objectName = "";

	public CarryableData.CarryableType type;

	public string nativeScene = "";

	public Vector3 originalPos = Vector3.zero;

	public string additionalData = "";

	public bool isInstance;

	public bool isDuped;

	public SCPlusCarryable(IntPtr intPtr)
		: base(intPtr)
	{
	}

	public void OnDestroy()
	{
		CarryableManager.Remove(this);
	}

	public CarryableSaveDataProxy ToProxy(bool shorten = false)
	{
		CarryableData.CarryableState state = GetState();
		string dataToSave = "";
		bool flag = type == CarryableData.CarryableType.Container && (!base.gameObject.activeInHierarchy || (Utility.CurrentlyInNativeScene(nativeScene) && !isInstance));
		if ((state & CarryableData.CarryableState.Removed) == 0 && !flag)
		{
			dataToSave = ((!string.IsNullOrEmpty(additionalData)) ? additionalData : GetAdditionalDataToSave());
		}
		if (shorten)
		{
			return new CarryableSaveDataProxy
			{
				name = objectName,
				type = type,
				dataToSave = dataToSave,
				guid = Utility.TryGetGuid(base.gameObject),
				state = CarryableData.CarryableState.ExistingDecoration
			};
		}
		string containerGuid = "";
		int containerIndex = 0;
		if (!base.gameObject.active && base.transform.parent.TryGetComponentInParent<Container>(out var component))
		{
			ObjectGuid component2;
			if (component.TryGetGuid(out string guid))
			{
				containerGuid = guid;
			}
			else if (component.gameObject.TryGetComponentInParent<ObjectGuid>(out component2))
			{
				containerGuid = component2.PDID;
				Container[] array = component2.GetComponentsInChildren<Container>(includeInactive: false);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == component)
					{
						containerIndex = i + 1;
						break;
					}
				}
			}
			else
			{
				containerGuid = Utility.missingGuid;
			}
		}
		return new CarryableSaveDataProxy
		{
			name = objectName,
			type = type,
			nativeScene = nativeScene,
			currentScene = ((base.gameObject.scene.name == "DontDestroyOnLoad") ? "" : base.gameObject.scene.name),
			originalPos = (isDuped ? Vector3.zero : originalPos),
			currentPos = base.transform.position,
			currentRot = base.transform.rotation,
			dataToSave = dataToSave,
			containerGuid = containerGuid,
			containerIndex = containerIndex,
			state = state
		};
	}

	public void FromProxy(CarryableSaveDataProxy proxy, bool full, bool ignoreAdditionalData = false, bool ignorePosition = false)
	{
		objectName = proxy.name;
		type = proxy.type;
		additionalData = (ignoreAdditionalData ? "" : proxy.dataToSave);
		if (full)
		{
			nativeScene = proxy.nativeScene;
			originalPos = proxy.originalPos;
			if (!ignorePosition)
			{
				base.transform.position = proxy.currentPos;
			}
			if (!ignorePosition)
			{
				base.transform.rotation = proxy.currentRot;
			}
			if ((proxy.state & CarryableData.CarryableState.Surplus) != CarryableData.CarryableState.None)
			{
				isDuped = true;
			}
		}
	}

	public string GetAdditionalDataToSave()
	{
		string text = "";
		switch (type)
		{
		case CarryableData.CarryableType.FlareGunCase:
			text = "0000000000";
			foreach (GearPlacePoint componentsInChild in GetComponentsInChildren<GearPlacePoint>(includeInactive: true))
			{
				int.TryParse(Regex.Replace(componentsInChild.name, "[^0-9]", ""), out var result);
				if ((bool)componentsInChild.m_PlacedGear || (bool)componentsInChild.FindGearAtPlacePoint())
				{
					text = text.Remove(result, 1).Insert(result, "1");
				}
			}
			if (base.gameObject.active && GetComponentInChildren<OpenClose>().IsOpen())
			{
				text = text.Remove(9, 1).Insert(9, "1");
			}
			break;
		case CarryableData.CarryableType.Stove:
		{
			WoodStove componentInChildren2 = GetComponentInChildren<WoodStove>();
			if ((bool)componentInChildren2 && (bool)componentInChildren2.Fire)
			{
				text = Utility.CompressDeflate(componentInChildren2.Fire.Serialize());
			}
			break;
		}
		case CarryableData.CarryableType.AmmoWorkbench:
		{
			WoodStove componentInChildren = GetComponentInChildren<WoodStove>();
			if ((bool)componentInChildren && (bool)componentInChildren.Fire)
			{
				text = Utility.CompressDeflate(componentInChildren.Fire.Serialize());
			}
			foreach (Container componentsInChild2 in GetComponentsInChildren<Container>())
			{
				text = text + "_|_" + Utility.CompressDeflate(componentsInChild2.Serialize());
			}
			break;
		}
		case CarryableData.CarryableType.Container:
		{
			bool flag = true;
			foreach (Container componentsInChild3 in GetComponentsInChildren<Container>())
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					text += "_|_";
				}
				text += Utility.CompressDeflate(componentsInChild3.Serialize());
			}
			break;
		}
		}
		return text;
	}

	public void RetrieveAdditionalData(string data = "")
	{
		if (string.IsNullOrEmpty(data))
		{
			if (string.IsNullOrEmpty(additionalData))
			{
				return;
			}
			data = additionalData;
		}
		switch (type)
		{
		case CarryableData.CarryableType.FlareGunCase:
		{
			int num = 0;
			string text = "";
			foreach (GearPlacePoint componentsInChild in GetComponentsInChildren<GearPlacePoint>(includeInactive: true))
			{
				componentsInChild.m_AddToHierarchy = true;
				componentsInChild.gameObject.GetOrAddComponent<ObjectGuid>().MaybeRuntimeRegister();
				if (data[num] == '1' && !componentsInChild.m_PlacedGear)
				{
					text = ((!componentsInChild.name.Contains(num.ToString())) ? "GEAR_FlareGun" : "GEAR_FlareGunAmmoSingle");
					componentsInChild.PlaceGear(componentsInChild.FindGearAtPlacePoint() ?? GearItem.InstantiateGearItem(text), reposition: true);
				}
				num++;
			}
			if (data[9] == '1')
			{
				GetComponentInChildren<OpenClose>().Start();
				GetComponentInChildren<OpenClose>().m_ForceOpenOnUpdate = true;
			}
			break;
		}
		case CarryableData.CarryableType.Stove:
		{
			WoodStove componentInChildren = GetComponentInChildren<WoodStove>();
			if ((bool)componentInChildren && (bool)componentInChildren.Fire)
			{
				componentInChildren.Fire.Deserialize(Utility.DecompressDeflate(data));
			}
			break;
		}
		case CarryableData.CarryableType.AmmoWorkbench:
		{
			string[] array = data.Split("_|_");
			WoodStove componentInChildren2 = GetComponentInChildren<WoodStove>();
			if ((bool)componentInChildren2 && (bool)componentInChildren2.Fire)
			{
				componentInChildren2.Fire.Deserialize(Utility.DecompressDeflate(array[0]));
			}
			Container[] array3 = GetComponentsInChildren<Container>();
			for (int j = 0; j < array3.Count(); j++)
			{
				if (array.Length > j)
				{
					array3[j].Deserialize(Utility.DecompressDeflate(array[j + 1]), null);
				}
			}
			break;
		}
		case CarryableData.CarryableType.Container:
		{
			string[] array = data.Split("_|_");
			Container[] array2 = GetComponentsInChildren<Container>();
			for (int i = 0; i < array2.Count(); i++)
			{
				if (array.Length > i)
				{
					array2[i].Deserialize(Utility.DecompressDeflate(array[i]), null);
				}
			}
			break;
		}
		}
		additionalData = string.Empty;
	}

	public CarryableData.CarryableState GetState()
	{
		CarryableData.CarryableState carryableState = CarryableData.CarryableState.None;
		if (isDuped)
		{
			carryableState |= CarryableData.CarryableState.Surplus;
		}
		if (!base.gameObject.activeInHierarchy)
		{
			carryableState = ((base.gameObject.scene.name == "DontDestroyOnLoad") ? (carryableState | CarryableData.CarryableState.OnPlayer) : ((!base.transform.parent.TryGetComponentInParent<Container>(out var _)) ? (carryableState | CarryableData.CarryableState.Removed) : (carryableState | CarryableData.CarryableState.InContainer)));
		}
		return carryableState;
	}
}
