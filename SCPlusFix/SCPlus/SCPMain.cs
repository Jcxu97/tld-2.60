using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Il2Cpp;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppTLD.IntBackedUnit;
using Il2CppTLD.OptionalContent;
using Il2CppTLD.Trader;
using Il2CppVLB;
using LocalizationUtilities;
using MelonLoader;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.SceneManagement;

namespace SCPlusPP;

public class SCPMain : MelonMod
{
	public static bool isLoaded = false;

	public static bool hasTFTFTF;

	public static string modsPath;

	public static bool DEVInspectMode;

	public static float DEVInspectModeMoveStep = 0.01f;

	public static GameObject DEVInspectTempGO;

	public static IResourceLocator catalogLocator;

	public static System.Collections.Generic.Dictionary<string, string> catalogParsed = new System.Collections.Generic.Dictionary<string, string>();

	public static System.Collections.Generic.HashSet<string> iconGuidLookupList = new System.Collections.Generic.HashSet<string>();

	public static System.Collections.Generic.Dictionary<string, float> autoWeightTable = new System.Collections.Generic.Dictionary<string, float>();

	public static bool instantiatingCarryables;

	public static bool decorationJustDuped;

	public static bool decorationListPopulated;

	public static int carryableCoroutineCounter = 0;

	// 玩家 Mods 里还留着原版 SafehouseCustomizationPlus.dll(或旧的修复版)时不用删:本 mod 优先级最高先注册,
	// 这里拦掉它后面的注册,它的补丁和设置页就都不会启动。存档用的还是同一个 ModData 名字,两边存档通用
	// 11-06 实测给 MelonBase.Register 挂前缀不触发,原版照样注册。改用 MelonLoader 自己的查重:
	// 把原版的 Info 换成本 mod 的,它注册时撞上同名同作者就被拒,补丁和回调都不会挂
	public override void OnEarlyInitializeMelon()
	{
		var infoProp = typeof(MelonBase).GetProperty(nameof(MelonBase.Info));
		foreach (MelonAssembly asm in MelonAssembly.LoadedAssemblies)
		{
			if (asm.Assembly.GetName().Name != "SafehouseCustomizationPlus")
			{
				continue;
			}
			foreach (MelonBase melon in asm.LoadedMelons)
			{
				if (!melon.Registered)
				{
					infoProp.SetValue(melon, Info);
				}
			}
			MelonLogger.Msg("SCPlusFix++ 已代替 " + Path.GetFileName(asm.Location) + ",那个文件留着也没关系");
		}
	}

	public override void OnInitializeMelon()
	{
		modsPath = Path.GetFullPath(typeof(MelonMod).Assembly.Location + "/../../../Mods/");
		LocalizationManager.LoadJsonLocalization(ResourceHandler.LoadEmbeddedJSON("Localization.json"));
		Settings.OnLoad();
		ResourceHandler.ExtractFolderFromResources(modsPath + "SCPlus/", "SafehouseCustomizationPlus.Resources.DumbShield", overwrite: true);
		try
		{
			string text = modsPath + "SCPlus/Icons/catalog_SCPlusIcons.json";
			catalogLocator = Addressables.LoadContentCatalogAsync(text).WaitForCompletion();
			if (catalogLocator != null && catalogLocator.Keys != null)
			{
				for (int i = 0; i < catalogLocator.Keys.ToList().Count; i++)
				{
					string text2 = catalogLocator.Keys.ElementAt(i).ToString();
					if (Guid.TryParse(text2, out var _))
					{
						string key = catalogLocator.Keys.ElementAt(i - 1).ToString().Replace("ico__", "");
						catalogParsed[key] = text2;
						iconGuidLookupList.Add(text2);
					}
				}
			}
			else
			{
				Utility.Log(System.ConsoleColor.Red, "Catalog catalog_SCPlusIcons could not be found at " + text);
			}
		}
		catch (Exception ex)
		{
			Utility.Log(System.ConsoleColor.Red, "Catalog catalog_SCPlusIcons load failed: " + ex.ToString());
		}
	}

	public override void OnSceneWasLoaded(int buildIndex, string sceneName)
	{
		if (Utility.IsScenePlayable())
		{
			isLoaded = true;
		}
		DecorationPatches.injectPdids = false;
		if (Utility.IsMainMenu(sceneName))
		{
			hasTFTFTF = OptionalContentManager.Instance.InstalledContent.ContainsKey("2091330");
			Settings.OnInitialize();
		}
	}

	public override void OnSceneWasInitialized(int buildIndex, string sceneName)
	{
		if (!Utility.IsScenePlayable())
		{
			return;
		}
		Scene sceneByName = UnityEngine.SceneManagement.SceneManager.GetSceneByName(sceneName);
		if (sceneName.EndsWith("_SANDBOX"))
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Il2CppSystem.Collections.Generic.List<WoodStove>.Enumerator enumerator = Il2Cpp.Utils.FindObjectsOfTypeInScene<WoodStove>(sceneByName).GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (Utility.TryGetCarryableRoot(enumerator.Current.transform, out GameObject go))
				{
					MakeIntoDecoration(go);
				}
			}
			Il2CppSystem.Collections.Generic.List<MillingMachine>.Enumerator enumerator2 = Il2Cpp.Utils.FindObjectsOfTypeInScene<MillingMachine>(sceneByName).GetEnumerator();
			while (enumerator2.MoveNext())
			{
				if (Utility.TryGetCarryableRoot(enumerator2.Current.transform, out GameObject go2))
				{
					MakeIntoDecoration(go2);
				}
			}
			Il2CppSystem.Collections.Generic.List<AmmoWorkBench>.Enumerator enumerator3 = Il2Cpp.Utils.FindObjectsOfTypeInScene<AmmoWorkBench>(sceneByName).GetEnumerator();
			while (enumerator3.MoveNext())
			{
				if (Utility.TryGetCarryableRoot(enumerator3.Current.transform, out GameObject go3))
				{
					MakeIntoDecoration(go3);
				}
			}
			Il2CppSystem.Collections.Generic.List<ObjectAnim>.Enumerator enumerator4 = Il2Cpp.Utils.FindObjectsOfTypeInScene<ObjectAnim>(sceneByName).GetEnumerator();
			while (enumerator4.MoveNext())
			{
				if (Utility.TryGetCarryableRoot(enumerator4.Current.transform, out GameObject go4))
				{
					MakeIntoDecoration(go4);
				}
			}
			stopwatch.Stop();
			Utility.Log(System.ConsoleColor.Blue, $"SC+ Lookup pass 2: {stopwatch.ElapsedMilliseconds} ms ({stopwatch.ElapsedTicks} ticks)");
		}
		else if (sceneName.EndsWith("_DLC01"))
		{
			Il2CppSystem.Collections.Generic.List<TraderRadio>.Enumerator enumerator5 = Il2Cpp.Utils.FindObjectsOfTypeInScene<TraderRadio>(sceneByName).GetEnumerator();
			while (enumerator5.MoveNext())
			{
				if (Utility.TryGetCarryableRoot(enumerator5.Current.transform, out GameObject go5))
				{
					MakeIntoDecoration(go5);
				}
			}
		}
		else
		{
			if (sceneName.Contains("_"))
			{
				return;
			}
			Stopwatch stopwatch2 = new Stopwatch();
			stopwatch2.Start();
			Il2CppSystem.Collections.Generic.List<WoodStove>.Enumerator enumerator = Il2Cpp.Utils.FindObjectsOfTypeInScene<WoodStove>(sceneByName).GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (Utility.TryGetCarryableRoot(enumerator.Current.transform, out GameObject go6))
				{
					MakeIntoDecoration(go6);
				}
			}
			stopwatch2.Stop();
			Utility.Log(System.ConsoleColor.Blue, $"SC+ Lookup pass 1: {stopwatch2.ElapsedMilliseconds} ms ({stopwatch2.ElapsedTicks} ticks)");
		}
	}

	public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
	{
		DecorationPatches.injectPdids = true;
	}

	public static void SetupGreenscreen(Camera cam, bool reset = false)
	{
		if (reset)
		{
			GameManager.GetMainCamera().cullingMask = 490708959;
			GameManager.GetMainCamera().clearFlags = CameraClearFlags.Skybox;
		}
		else
		{
			GameManager.GetMainCamera().cullingMask = 0;
			GameManager.GetMainCamera().clearFlags = CameraClearFlags.Color;
			GameManager.GetMainCamera().backgroundColor = new Color(0.15f, 0.6f, 0.25f, 1f);
		}
	}

	public static string TakeScreenshot()
	{
		DecorationItem componentInChildren = GameManager.GetPlayerManagerComponent().GearItemBeingInspected().transform.GetComponentInChildren<DecorationItem>();
		string text = "Couldn't get object name, took screenshot anyways";
		string text2 = "";
		if ((bool)componentInChildren)
		{
			text2 = Utility.SanitizeObjectName(componentInChildren.name);
		}
		string text3 = Directory.CreateDirectory(modsPath + "SCPlus/Screenshots/").FullName;
		if (text2 == "")
		{
			text2 = Il2Cpp.Utils.GetGuid();
		}
		if (catalogParsed.ContainsKey(text2) || (componentInChildren.IconReference.RuntimeKeyIsValid() && componentInChildren.IconReference.RuntimeKey.ToString() != catalogParsed["placeholder"]))
		{
			text3 += "!";
			text = "Duplicate screenshot for " + text2;
		}
		text3 += text2;
		text3 += ".png";
		text = ((!File.Exists(text3)) ? ("Took screenshot for " + text2) : ("Overwritten screenshot for " + text2));
		ScreenCapture.CaptureScreenshot(text3);
		MelonCoroutines.Start(Utility.DelayedHUDMessage(text, 0.5f));
		return text3;
	}

	public static void RelevantSetupForDecorationItem(DecorationItem di, bool weightOnly = false)
	{
		if (!di)
		{
			return;
		}
		float num = 1f;
		float num2 = 2f;
		float num3 = 1f;
		string text = Utility.SanitizeObjectName(di.name);
		bool flag = true;
		if (CarryableData.decorationOverrideData.ContainsKey(text) && CarryableData.decorationOverrideData[text].weight != 0f)
		{
			num = CarryableData.decorationOverrideData[text].weight * Settings.options.globalWeightModifier;
		}
		else if (di.name.ToLower().StartsWith("obj_curtain"))
		{
			num = 0.5f;
		}
		else if (autoWeightTable.ContainsKey(text))
		{
			num = autoWeightTable[text];
		}
		else if (Settings.options.doWeightCalculation)
		{
			switch (di.tag)
			{
			case "Wood":
				num = num2 * 0.66f;
				break;
			case "Metal":
				num = num2 * 2f;
				if (di.name.ToLower().Contains("barrel"))
				{
					num *= 0.5f;
				}
				break;
			case "Rug":
				num = num2 * 0.25f;
				break;
			case "Glass":
				num = num2 * 0.5f;
				break;
			default:
				num = num2;
				break;
			}
			if (num == num2)
			{
				if (di.name.ToLower().Contains("wood"))
				{
					num *= 0.66f;
				}
				if (di.name.ToLower().Contains("metal"))
				{
					num *= 2f;
				}
				if (di.name.ToLower().Contains("sack"))
				{
					num *= 0.25f;
				}
				if (di.name.ToLower().Contains("computer"))
				{
					num *= 0.5f;
				}
				if (di.name.ToLower().Contains("lamp"))
				{
					num *= 0.25f;
				}
			}
			foreach (Collider componentsInChild in di.GetComponentsInChildren<Collider>())
			{
				num3 += componentsInChild.bounds.GetVolumeCubic();
			}
			num = Mathf.Round(num3 * num * 100f / 25f) * 25f / 100f;
			num = Mathf.Clamp(num, 0.1f, 30f);
			num *= Settings.options.autoWeightMultiplier;
			num *= Settings.options.globalWeightModifier;
			Utility.Log(System.ConsoleColor.Blue, $"Approx. for {text}: weight: {num}, volume: {num3}");
			autoWeightTable.Add(text, num);
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			di.m_Weight = ItemWeight.FromKilograms(num);
		}
		if (weightOnly)
		{
			return;
		}
		if (catalogParsed.ContainsKey(text))
		{
			di.m_IconReference = new AssetReferenceTexture2D(catalogParsed[text]);
			if (!di.m_IconReference.RuntimeKeyIsValid())
			{
				Utility.Log(System.ConsoleColor.Red, "Inconsistent icon GUID for decoration: " + text + ". Reverting to placeholder");
				di.m_IconReference = new AssetReferenceTexture2D(catalogParsed["placeholder"]);
			}
		}
		else
		{
			di.m_IconReference = new AssetReferenceTexture2D(catalogParsed["placeholder"]);
			Utility.Log(System.ConsoleColor.Magenta, "Missing icon for decoration: " + text);
		}
	}

	public static void SetLayersToInteractiveProp(DecorationItem di)
	{
		string[] skipLayerChange = CarryableData.skipLayerChange;
		foreach (string text in skipLayerChange)
		{
			if (di.name.ToLower().StartsWith(text.ToLower()))
			{
				return;
			}
		}
		foreach (Collider componentsInChild in di.GetComponentsInChildren<Collider>())
		{
			if (componentsInChild.gameObject.layer == vp_Layer.Default || componentsInChild.gameObject.layer == vp_Layer.TerrainObject)
			{
				componentsInChild.gameObject.layer = vp_Layer.InteractiveProp;
			}
		}
		if (di.gameObject.layer == vp_Layer.Default || di.gameObject.layer == vp_Layer.TerrainObject)
		{
			di.gameObject.layer = vp_Layer.InteractiveProp;
		}
	}

	public static void DisableNormalInteraction(DecorationItem di)
	{
		if ((bool)di.GetComponent<TraderRadio>())
		{
			di.GetComponent<TraderRadio>().enabled = false;
			di.GetComponent<BlockPlacement>().m_BlockDecorationItemPlacement = false;
		}
		if ((bool)di.GetComponent<BreakDown>())
		{
			di.GetComponent<BreakDown>().m_AllowEditModePlacement = true;
		}
		if (di.name.ToLower().Contains("forge"))
		{
			di.gameObject.layer = vp_Layer.InteractiveProp;
		}
		if ((bool)di.GetComponent<WoodStove>())
		{
			di.GetComponent<WoodStove>().enabled = false;
		}
	}

	public static void RestoreNormalInteraction(DecorationItem di)
	{
		if ((bool)di.GetComponent<TraderRadio>())
		{
			di.GetComponent<TraderRadio>().enabled = true;
		}
		if (di.name.ToLower().Contains("forge"))
		{
			di.gameObject.layer = vp_Layer.TerrainObject;
		}
		if ((bool)di.GetComponent<WoodStove>())
		{
			di.GetComponent<WoodStove>().enabled = true;
		}
	}

	public static DecorationItem? MakeIntoDecoration(GameObject go)
	{
		if ((bool)go && !go.GetComponentInChildren<DecorationItem>())
		{
			string text = Utility.SanitizeObjectName(go.name);
			LocalizedString displayName = Utility.TryGetLocalizedName(go);
			DecorationItem decorationItem = go.AddComponent<DecorationItem>();
			SetLayersToInteractiveProp(decorationItem);
			decorationItem.m_DecorationPrefab = new AssetReferenceDecorationItem(text);
			decorationItem.GetDecorationPrefab();
			decorationItem.m_DisplayName = displayName;
			decorationItem.GetCraftingDisplayName();
			if (text.ToLower().Contains("container"))
			{
				decorationItem.m_PlacementRules = Utility.boxPlacementRules;
			}
			else
			{
				decorationItem.m_PlacementRules = Utility.genericPlacementRules;
			}
			RelevantSetupForDecorationItem(decorationItem);
			if (!GameManager.GetSafehouseManager().IsCustomizing())
			{
				RestoreNormalInteraction(decorationItem);
			}
			return decorationItem;
		}
		return go.GetComponentInChildren<DecorationItem>();
	}

	public override void OnUpdate()
	{
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.U) && Settings.options.debugLog && InterfaceManager.GetPanel<Panel_Inventory>().isActiveAndEnabled)
		{
			DecorationItem decorationItem = InterfaceManager.GetPanel<Panel_Inventory>().GetCurrentlySelectedItem().m_DecorationItem;
			if ((bool)decorationItem)
			{
				MelonLogger.Msg(System.ConsoleColor.Blue, $"{{\"{Utility.SanitizeObjectName(decorationItem.name)}\", new() {{ weight = {decorationItem.Weight.ToQuantity(1f).ToString().Replace(',', '.')}f }} }},");
				HUDMessage.AddMessage("Check console", highPriority: false, ignoreOverlayActive: true);
			}
			else
			{
				HUDMessage.AddMessage("This is not a decoration item...", highPriority: false, ignoreOverlayActive: true);
			}
		}
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.options.dupeKey))
		{
			if (!GameManager.GetSafehouseManager().IsCustomizing())
			{
				return;
			}
			GameObject interactiveGameObjectUnderCrosshair = Utility.GetInteractiveGameObjectUnderCrosshair();
			DecorationItem decorationItem2 = interactiveGameObjectUnderCrosshair?.GetComponent<DecorationItem>();
			if (decorationItem2 != null)
			{
				string text = Utility.SanitizeObjectName(decorationItem2.name);
				if (CarryableData.carryablePrefabDefinition.ContainsKey(text) && !CarryableData.carryablePrefabDefinition[text].pickupable)
				{
					GameAudioManager.PlayGUIError();
					HUDMessage.AddMessage(Localization.Get("SCP_Action_CantDuplicate"), highPriority: false, ignoreOverlayActive: true);
					return;
				}
				GameObject gameObject = UnityEngine.Object.Instantiate(interactiveGameObjectUnderCrosshair);
				gameObject.name = text;
				decorationJustDuped = true;
				GameManager.GetPlayerManagerComponent().StartPlaceMesh(gameObject, PlaceMeshFlags.DestroyOnCancel, decorationItem2.m_PlacementRules);
			}
		}
		if (!DEVInspectMode)
		{
			return;
		}
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.UpArrow) && GameManager.GetPlayerManagerComponent().IsInspectModeActive())
		{
			if (InputManager.GetSprintDown(InputManager.m_CurrentContext))
			{
				DEVInspectModeMoveStep = 0.002f;
			}
			GameManager.GetPlayerManagerComponent().GearItemBeingInspected().transform.transform.localPosition += Vector3.up * DEVInspectModeMoveStep;
		}
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.DownArrow) && GameManager.GetPlayerManagerComponent().IsInspectModeActive())
		{
			if (InputManager.GetSprintDown(InputManager.m_CurrentContext))
			{
				DEVInspectModeMoveStep = 0.002f;
			}
			GameManager.GetPlayerManagerComponent().GearItemBeingInspected().transform.transform.localPosition += Vector3.down * DEVInspectModeMoveStep;
		}
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.LeftArrow) && GameManager.GetPlayerManagerComponent().IsInspectModeActive())
		{
			if (InputManager.GetSprintDown(InputManager.m_CurrentContext))
			{
				DEVInspectModeMoveStep = 0.002f;
			}
			GameManager.GetPlayerManagerComponent().GearItemBeingInspected().transform.transform.localPosition += Vector3.left * DEVInspectModeMoveStep;
		}
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.RightArrow) && GameManager.GetPlayerManagerComponent().IsInspectModeActive())
		{
			if (InputManager.GetSprintDown(InputManager.m_CurrentContext))
			{
				DEVInspectModeMoveStep = 0.002f;
			}
			GameManager.GetPlayerManagerComponent().GearItemBeingInspected().transform.transform.localPosition += Vector3.right * DEVInspectModeMoveStep;
		}
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.Equals) && GameManager.GetPlayerManagerComponent().IsInspectModeActive())
		{
			if (InputManager.GetSprintDown(InputManager.m_CurrentContext))
			{
				DEVInspectModeMoveStep = 0.002f;
			}
			GameManager.GetPlayerManagerComponent().GearItemBeingInspected().transform.transform.localScale += Vector3.one * DEVInspectModeMoveStep * 5f;
		}
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.Minus) && GameManager.GetPlayerManagerComponent().IsInspectModeActive())
		{
			if (InputManager.GetSprintDown(InputManager.m_CurrentContext))
			{
				DEVInspectModeMoveStep = 0.002f;
			}
			GameManager.GetPlayerManagerComponent().GearItemBeingInspected().transform.transform.localScale -= Vector3.one * DEVInspectModeMoveStep * 5f;
		}
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.Comma) && GameManager.GetPlayerManagerComponent().IsInspectModeActive())
		{
			if (InputManager.GetSprintDown(InputManager.m_CurrentContext))
			{
				DEVInspectModeMoveStep = 0.06f;
			}
			GameManager.GetInspectModeLight().transform.transform.localEulerAngles += Vector3.up * DEVInspectModeMoveStep * 200f;
		}
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.Period) && GameManager.GetPlayerManagerComponent().IsInspectModeActive())
		{
			if (InputManager.GetSprintDown(InputManager.m_CurrentContext))
			{
				DEVInspectModeMoveStep = 0.06f;
			}
			GameManager.GetInspectModeLight().transform.transform.localEulerAngles += Vector3.down * DEVInspectModeMoveStep * 200f;
		}
		if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.Alpha0) && GameManager.GetPlayerManagerComponent().IsInspectModeActive())
		{
			TakeScreenshot();
		}
	}
}
