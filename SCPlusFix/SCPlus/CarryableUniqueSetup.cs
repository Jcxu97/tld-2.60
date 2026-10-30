using System;
using System.Collections;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppSystem.Collections.Generic;
using Il2CppTLD.AddressableAssets;
using Il2CppTLD.Interactions;
using Il2CppTLD.ModularElectrolizer;
using MelonLoader;
using UnityEngine;
using UnityEngine.Events;

namespace SCPlus;

internal class CarryableUniqueSetup
{
	public static IEnumerator PrepareMillingMachine(GameObject go)
	{
		go.name = "INTERACTIVE_IndustrialMillingMachine";
		SimpleInteraction si = go.AddComponent<SimpleInteraction>();
		si.m_DefaultHoverText = new LocalizedString
		{
			m_LocalizationID = "GAMEPLAY_MillingMachine"
		};
		MillingMachine mm = go.AddComponent<MillingMachine>();
		mm.m_IdleAudioPlay = "Play_MillingMachine";
		mm.m_IdleAudioStop = "Stop_MillingMachine";
		mm.m_RepairAudioLoop = "Play_MillingMachineRepair";
		InvokableCall call = new InvokableCall((Action)delegate
		{
			mm.InitializeInteraction(si);
		});
		si.FindOrAddEventForEventType(InteractionEventType.InitializeInteraction).AddCall(call);
		si.FindOrAddEventForEventType(InteractionEventType.InitializeInteraction).m_Calls.AddListener(call);
		call = new InvokableCall((Action)delegate
		{
			mm.PerformInteraction();
		});
		si.FindOrAddEventForEventType(InteractionEventType.PerformInteraction).AddCall(call);
		si.FindOrAddEventForEventType(InteractionEventType.PerformInteraction).m_Calls.AddListener(call);
		yield return new WaitForEndOfFrame();
		mm.InitializeInteraction(si);
		AuroraModularElectrolizer component = go.GetComponent<AuroraModularElectrolizer>();
		if ((bool)component)
		{
			component.Initialize();
			component.InitializeFlickerSet();
			component.Awake();
		}
	}

	public static GameObject ReconstructStoveWood()
	{
		GameObject gameObject = new GameObject("INTERACTIVE_StoveWoodC");
		gameObject.active = false;
		GameObject gameObject2 = AssetHelper.SafeInstantiateAssetAsync("Assets/ArtAssets/Env/Objects/OBJ_StoveWoodC/OBJ_StoveWoodCMain.FBX", gameObject.transform).WaitForCompletion();
		GameObject gameObject3 = new GameObject("Stove");
		gameObject3.transform.parent = gameObject.transform;
		GameObject gameObject4 = new GameObject("Hinge");
		gameObject4.transform.parent = gameObject3.transform;
		gameObject4.transform.localPosition = new Vector3(0.3374f, 0.4804f, -0.3461f);
		GameObject gameObject5 = AssetHelper.SafeInstantiateAssetAsync("Assets/ArtAssets/Env/Objects/OBJ_StoveWoodC/OBJ_StoveWoodCDoor.FBX", gameObject4.transform).WaitForCompletion();
		gameObject.AddComponent<MeshCollider>().sharedMesh = AssetHelper.SafeLoadAssetAsync<Mesh>("Assets/ArtAssets/Env/Objects/OBJ_StoveWoodC/OBJ_StoveWoodCMain_Col.FBX").WaitForCompletion();
		Material sharedMaterial = AssetHelper.SafeLoadAssetAsync<Material>("Assets/ArtAssets/Env/Objects/Materials/OBJ_StoveWoodB_Dif.mat").WaitForCompletion();
		Renderer[] array = new Renderer[2]
		{
			gameObject2.GetComponent<MeshRenderer>(),
			gameObject5.GetComponent<MeshRenderer>()
		};
		for (int i = 0; i < array.Length; i++)
		{
			array[i].sharedMaterial = sharedMaterial;
		}
		gameObject4.AddComponent<iTweenEvent>().Initialize("open", -0.083f);
		gameObject4.AddComponent<iTweenEvent>().Initialize("close", 0.083f);
		ObjectAnim objectAnim = gameObject3.AddComponent<ObjectAnim>();
		objectAnim.Initialize(gameObject4);
		GameObject gameObject6 = AssetHelper.SafeInstantiateAssetAsync("Assets/Prefabs/Interactive/INTERACTIVE_PotBellyStove.prefab").WaitForCompletion();
		Transform transform = UnityEngine.Object.Instantiate(gameObject6.transform.Find("Fire"), gameObject3.transform);
		transform.name = "Fire";
		GameObject gameObject7 = gameObject6.transform.Find("PlacePoints/Cylinder").gameObject;
		gameObject7.transform.localPosition = Vector3.zero;
		UnityEngine.Object.Destroy(gameObject6);
		transform.localPosition = new Vector3(0.06f, 0f, 0.001f);
		Vector3 localPosition = new Vector3(0f, 0.2f, -0.2f);
		foreach (Transform componentsInChild in transform.GetComponentsInChildren<Transform>(includeInactive: true))
		{
			if (componentsInChild.name.ToLower().StartsWith("fx_stage"))
			{
				componentsInChild.localPosition = localPosition;
				componentsInChild.localScale = new Vector3(2f, 0.4f, 1f);
				componentsInChild.Find("Flame core 2")?.gameObject.SetActive(value: false);
			}
		}
		Fire component = transform.GetComponent<Fire>();
		MelonCoroutines.Start(SetupStoveLight(transform.transform.Find("FX_Lighting")));
		WoodStove woodStove = gameObject3.AddComponent<WoodStove>();
		woodStove.m_StoveCloseSound = "Play_SndMechWoodstove02Close";
		woodStove.m_StoveOpenSound = "Play_SndMechWoodstove02Open";
		woodStove.Fire = component;
		woodStove.m_ObjectAnim = objectAnim;
		woodStove.m_DefaultHoverText = new LocalizedString
		{
			m_LocalizationID = "GAMEPLAY_WoodStove"
		};
		ActiveBurner activeBurner = gameObject2.AddComponent<ActiveBurner>();
		activeBurner.m_Fire = component;
		activeBurner.m_OpacityRange = new MinMax(0f, 1f);
		Transform transform2 = new GameObject("PlacePoints").transform;
		transform2.parent = gameObject.transform;
		GameObject gameObject8 = new GameObject("Left");
		gameObject8.transform.parent = transform2;
		gameObject8.transform.localPosition = new Vector3(-0.217f, 0.8275f, -0.09f);
		GameObject gameObject9 = new GameObject("Right");
		gameObject9.transform.parent = transform2;
		gameObject9.transform.localPosition = new Vector3(0.205f, 0.8275f, -0.085f);
		GameObject[] obj = new GameObject[2] { gameObject8, gameObject9 };
		System.Collections.Generic.List<CookingSlot> list = new System.Collections.Generic.List<CookingSlot>();
		System.Collections.Generic.List<Renderer> list2 = new System.Collections.Generic.List<Renderer>();
		GameObject[] array2 = obj;
		foreach (GameObject gameObject10 in array2)
		{
			GearPlacePoint gearPlacePoint = gameObject10.AddComponent<GearPlacePoint>();
			gearPlacePoint.m_AllowedGear = new();
			gearPlacePoint.m_AllowAllCookingItems = true;
			gearPlacePoint.m_FireToAttach = component;
			GameObject gameObject11 = UnityEngine.Object.Instantiate(gameObject7, gameObject10.transform);
			gameObject11.name = "Indicator";
			gameObject11.transform.localScale = new Vector3(0.2451f, 0.0026f, 0.2451f);
			CookingSlot component2 = gameObject11.GetComponent<CookingSlot>();
			component2.m_GearPlacePoint = gearPlacePoint;
			component2.SetFireplaceHost(woodStove);
			list.Add(component2);
			list2.Add(gameObject11.GetComponent<Renderer>());
		}
		UnityEngine.Object.Destroy(gameObject7);
		transform2.gameObject.AddComponent<PlacePoints>().m_PlacePoints = list2.ToArray();
		woodStove.m_CookingSlots = list.ToArray();
		woodStove.enabled = true;
		gameObject.active = true;
		return gameObject;
	}

	public static IEnumerator SetupStoveLight(Transform lightRoot)
	{
		yield return new WaitForEndOfFrame();
		lightRoot.localPosition = Vector3.zero;
		Light component = lightRoot.GetChild(0).GetComponent<Light>();
		Light component2 = lightRoot.GetChild(1).GetComponent<Light>();
		LightDancing component3 = lightRoot.GetChild(2).GetComponent<LightDancing>();
		LightDancing component4 = lightRoot.GetChild(3).GetComponent<LightDancing>();
		component2.range = 0.5f;
		component2.transform.localPosition = Vector3.up * 0.45f;
		component3.originalPosition = new Vector3(-0.05f, 0.4725f, -0.3f);
		component3.shiftRate = 4f;
		component3.GetComponent<LightFadeFire>().originalBrightness = 2.5f;
		component4.originalPosition = new Vector3(0.05f, 0.4725f, -0.3f);
		component4.shiftRate = 3f;
		component4.GetComponent<LightFadeFire>().originalBrightness = 1f;
		component4.GetComponent<Light>().range = 5f;
		component.transform.localPosition = new Vector3(-0.0029f, 0.4737f, -0.338f);
		component.cookie = AssetHelper.SafeLoadAssetAsync<Texture2D>("Assets/ArtAssets/Textures/FX/FX_LightCookieA_Dif.tga").WaitForCompletion();
		component.spotAngle = 100f;
		component.innerSpotAngle = 80f;
	}

	public static GameObject ReconstructTraderRadio()
	{
		GameObject gameObject = new GameObject("INTERACTIVE_SURVIVAL_TraderRadio");
		AssetHelper.SafeInstantiateAssetAsync("Assets/ArtAssets/Characters/NPC/Props/Survival_TraderRadio.prefab", gameObject.transform).WaitForCompletion().transform.parent = gameObject.transform;
		BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
		boxCollider.center = new Vector3(0f, 0.085f, 0f);
		boxCollider.size = new Vector3(0.7f, 0.17f, 0.4f);
		return gameObject;
	}
}
