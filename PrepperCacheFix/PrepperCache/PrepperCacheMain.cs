using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppTLD.Gameplay;
using Il2CppTLD.Scenes;
using Il2CppTLD.Scenes.ObjectReferences;
using MelonLoader;
using MelonLoader.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PrepperCache;

public class PrepperCacheMain : MelonMod
{
	[HarmonyPatch(typeof(UIWorldMap), "_LoadMap_b__6_0")]
	public class WorldMap_LoadMap_b__6_0
	{
		// 2026-10 更新后世界地图下多了层级不同的子节点,固定按 GetChild(1).GetChild(0) 取会越界,取不到的跳过
		private static UILabel RegionLabel(UIWorldMap map, int i)
		{
			Transform child = ((Component)map).transform.GetChild(i);
			if (child.childCount < 2 || child.GetChild(1).childCount < 1)
			{
				return null;
			}
			return ((Component)child.GetChild(1).GetChild(0)).GetComponent<UILabel>();
		}

		public static void Postfix(UIWorldMap __instance)
		{
			LogMessage("World map " + ((UnityEngine.Object)__instance).name + " _LoadMap_b__6_0.", 519, "Postfix");
			for (int i = 0; i < ((Component)__instance).transform.childCount; i++)
			{
				UILabel label = RegionLabel(__instance, i);
				if (label != null)
				{
					LogMessage($"Region {i + 1}: {label.text}", 522, "Postfix");
				}
			}
		}

		public static void Prefix(UIWorldMap __instance)
		{
			LogMessage("World map " + ((UnityEngine.Object)__instance).name + " _LoadMap_b__6_0.", 531, "Prefix");
			if (LoadPrepperCacheDictionary())
			{
				LogMessage($"Prepper cache dictionary loaded successfully with {mappingsRegion2PrepperCacheName.Count} entries.", 535, "Prefix");
				for (int i = 0; i < ((Component)__instance).transform.childCount; i++)
				{
					UILabel component = RegionLabel(__instance, i);
					if (component == null)
					{
						continue;
					}
					LogMessage($"Region {i + 1}: {component.text}", 545, "Prefix");
					string text = component.text;
					if (mappingsRegion2PrepperCacheName.TryGetValue(text, out string value))
					{
						component.text = component.text + " (" + value + ")";
					}
					else
					{
						value = null;
					}
				}
			}
			else
			{
				LogMessage("ERROR: Failed to load prepper cache dictionary.", 539, "Prefix");
			}
		}
	}

	public static float timer = 0f;

	public static Vector3 previousPosition = new Vector3(0f, 0f, 0f);

	public static bool inMenu = true;

	public const string MOD_VERSION_NUMBER = "Version 1.2.0 - 04/04/2026";

	internal const string DEFAULT_FILE_NAME = "PrepperCache.log";

	private static string Log_File_Format_Version_Number = "1.1";

	private static string logData_filename = "PrepperCache.log";

	public static string hudMessage = "undefined";

	public static System.Collections.Generic.Dictionary<string, string> mappingsRegion2PrepperCacheName = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	private static readonly System.Collections.Generic.Dictionary<string, string> mappingsPrepperCache = new System.Collections.Generic.Dictionary<string, string>
	{
		{ "PrepperCacheAEmpty", "Empty Prepper Cache A" },
		{ "PrepperCacheBEmpty", "Empty Prepper Cache B" },
		{ "PrepperCacheCEmpty", "Empty Prepper Cache C" },
		{ "PrepperCacheDEmpty", "Empty Prepper Cache D" },
		{ "PrepperCacheEEmpty", "Empty Prepper Cache E" },
		{ "PrepperCacheFEmpty", "Empty Prepper Cache F" },
		{ "PrepperCacheA", "机密地堡" },
		{ "PrepperCacheB", "储备地堡" },
		{ "PrepperCacheC", "猎人地堡" },
		{ "PrepperCacheD", "储备地堡" },
		{ "PrepperCacheE", "猎人地堡" },
		{ "PrepperCacheF", "机密地堡" },
		{ "PrepperCacheBInterloper", "入侵者专用地堡" },
		{ "PrepperCacheEmpty", "Prepper's Abandoned Cache (Pleasant Valley)" }
	};

	private static readonly System.Collections.Generic.Dictionary<string, string> mappingsRegion = new System.Collections.Generic.Dictionary<string, string>
	{
		{ "AirfieldRegion", "废弃机场" },
		{ "AshCanyonRegion", "灰烬峡谷" },
		{ "BlackrockRegion", "黑岩地区" },
		{ "BlackrockTransitionZone", "守山人山隘北" },
		{ "CanneryRegion", "荒凉水湾" },
		{ "CanyonRoadTransitionZone", "守山人山隘南" },
		{ "CoastalRegion", "沿海公路" },
		{ "CrashMountainRegion", "林狼雪岭" },
		{ "DamRiverTransitionZoneB", "蜿蜒河流" },
		{ "HighwayTransitionZone", "公路废墟" },
		{ "HubRegion", "中转通道" },
		{ "LakeRegion", "神秘湖" },
		{ "LongRailTransitionZone", "远境支路" },
		{ "MarshRegion", "孤寂沼泽" },
		{ "MiningRegion", "污染区" },
		{ "MountainPassRegion", "破碎山道" },
		{ "MountainTownRegion", "山间小镇" },
		{ "RavineTransitionZone", "深谷" },
		{ "RiverValleyRegion", "寂静河谷" },
		{ "RuralRegion", "怡人山谷" },
		{ "TracksRegion", "破碎铁路" },
		{ "WhalingStationRegion", "荒芜据点" }
	};

	internal static System.Collections.Generic.HashSet<string> BunkerSceneNames { get; } = new System.Collections.Generic.HashSet<string>(StringComparer.OrdinalIgnoreCase);

	private static string GetFilePath()
	{
		return Path.GetFullPath(Path.Combine(MelonEnvironment.ModsDirectory, logData_filename));
	}

	public static void LogData(string text)
	{
		if (text != null)
		{
			if (text == "")
			{
				File.AppendAllLines(GetFilePath(), new string[1] { text });
			}
			else
			{
				File.AppendAllLines(GetFilePath(), new string[1] { text });
			}
		}
	}

	public static void LogMessage(string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string? caller = null)
	{
		try
		{
			if (message.Contains("error", StringComparison.OrdinalIgnoreCase) || message.Contains("warn", StringComparison.OrdinalIgnoreCase))
			{
				MelonLogger.Msg("." + caller + "." + lineNumber + ": " + message);
			}
		}
		catch
		{
		}
	}

	public static string SanitizeFileName(string filename)
	{
		char[] invalidChars = Path.GetInvalidFileNameChars();
		return new string(filename.Where((char c) => !((ReadOnlySpan<char>)invalidChars).Contains(c)).ToArray());
	}

	public override void OnInitializeMelon()
	{
		LogMessage("Initializing Melon, starting PrepperCache Mod: Version 1.2.0 - 04/04/2026", 189, "OnInitializeMelon");
		Settings.OnLoad();
	}

	public override void OnUpdate()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		if (!Settings.enablePrepperCacheDataCapture)
		{
			return;
		}
		if (IsGameScene())
		{
			inMenu = false;
			if ((GameManager.GetVpFPSPlayer() == null) || inMenu || !InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.options.captureKey))
			{
				return;
			}
			string text = "K";
			try
			{
				ExperienceModeType? val = ExperienceModeManager.GetCurrentExperienceModeType();
				LogMessage("Current experience mode type: " + ((val.HasValue ? ((object)val.GetValueOrDefault()/*cast due to .constrained prefix*/).ToString() : null) ?? "<null>"), 233, "OnUpdate");
				LogMessage("Current localized game mode: " + (ExperienceModeManager.s_CurrentGameMode.m_ModeName.m_LocalizationID ?? "<null>"), 235, "OnUpdate");
				if (!val.HasValue)
				{
					return;
				}
				ExperienceModeManager experienceModeManagerComponent = GameManager.GetExperienceModeManagerComponent();
				Il2CppSystem.Collections.Generic.IList<GameModeConfig> val2 = ((experienceModeManagerComponent != null) ? experienceModeManagerComponent.GetAvailableGameModes() : null);
				if (val2 == null)
				{
					LogMessage("ERROR: Failed to get available game modes from ExperienceModeManager.", 246, "OnUpdate");
					return;
				}
				Il2CppSystem.Collections.Generic.List<GameModeConfig> val3 = null;
				val3 = ((Il2CppObjectBase)val2).Cast<Il2CppSystem.Collections.Generic.List<GameModeConfig>>();
				if (val3 == null)
				{
					LogMessage("ERROR: Failed to convert uncastConfigs (IList) to configs (List).", 254, "OnUpdate");
					return;
				}
				LogMessage($"Available game mode configs: {val3.Count}", 258, "OnUpdate");
				Il2CppSystem.Collections.Generic.List<GameModeConfig> val4 = val3;
				LogMessage($"Available game modes count: {val4?.Count ?? 0}", 265, "OnUpdate");
				if (val4 == null)
				{
					LogMessage("WARNING: Available game modes list is null.", 269, "OnUpdate");
					return;
				}
				GameModeConfig val5 = null;
				for (int i = 0; i < val4.Count; i++)
				{
					GameModeConfig val6 = val4[i];
					if ((UnityEngine.Object)(object)val6 != (UnityEngine.Object)null && ((UnityEngine.Object)val6).name == ((object)val.Value/*cast due to .constrained prefix*/).ToString())
					{
						val5 = val6;
						break;
					}
				}
				if ((UnityEngine.Object)(object)val5 == (UnityEngine.Object)null)
				{
					LogMessage("ERROR: Current experience mode not found in available modes.", 287, "OnUpdate");
					return;
				}
				LogMessage("Found current experience mode: " + ((UnityEngine.Object)val5).name, 291, "OnUpdate");
				GameModeConfig gameModeFromName = ExperienceModeManager.GetGameModeFromName(((UnityEngine.Object)val5).name);
				SandboxConfig val7 = ((gameModeFromName != null) ? ((Il2CppObjectBase)gameModeFromName).Cast<SandboxConfig>() : null);
				if ((UnityEngine.Object)(object)val7 == (UnityEngine.Object)null)
				{
					LogMessage("ERROR: Failed to get SandboxConfig.", 301, "OnUpdate");
					return;
				}
				BunkerDistributor bunkerSetup = val7.m_BunkerSetup;
				if ((UnityEngine.Object)(object)bunkerSetup == (UnityEngine.Object)null)
				{
					LogMessage("ERROR: Bunker setup is null.", 309, "OnUpdate");
					return;
				}
				float hoursPlayedNotPaused = GameManager.GetTimeOfDayComponent().GetHoursPlayedNotPaused();
				if (hoursPlayedNotPaused == 0f)
				{
					LogMessage("WARNING: Detected gameTime of zero likely due to scene change timing.  No action taken.", 318, "OnUpdate");
					return;
				}
				if (!File.Exists(GetFilePath()))
				{
					LogData("; Data file format version: " + Log_File_Format_Version_Number);
					LogData("; PrepperCache Mod: Version 1.2.0 - 04/04/2026");
					LogData(";");
					LogData("; Fields are separated by the \"|\" character:");
					LogData(";   irlDateTime: Real-world date and time when the data was recorded (MM/DD/YYYY HH:MM:SS)");
					LogData(";   gameTime: In-game hours played (float)");
					LogData(";   experienceMode: Experience mode for this game (Pilgrim, Voyageur, etc)");
					LogData(";   gameName: User name for this game");
					LogData(";      bunkerNumber.m_Interior.name: Bunker interior name (i.e. PrepperCacheC)");
					LogData(";      bunkerNumber.m_Interior.name: User-friendly bunker interior name (i.e. (Hunter Prepper Cache)");
					LogData(";      bunkerNumber.m_LocationReference.SceneName: Name of the scene for this replacement bunker (i.e. BlackrockRegion_SANDBOX)");
					LogData(";      bunkerNumber.m_LocationReference.SceneName: User-friendly name of the scene for this replacement bunker (i.e. Blackrock)");
					LogData(";   triggerCode: Code indicating what triggered the data capture (K=Keypress)");
					LogData(";");
					string text2 = ";irlDateTime|gameTime|experienceMode|gameName";
					for (int j = 0; j <= 8 && j <= 8; j++)
					{
						text2 += $"|bunkerName.{j}|bunkerFriendlyName.{j}|sceneName.{j}|sceneNameFriendly.{j}";
					}
					text2 += "|triggerCode";
					LogData(text2);
				}
				string text3 = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
				Il2CppReferenceArray<BunkerInteriorSpecification> bunkerInteriors = bunkerSetup.m_BunkerInteriors;
				Il2CppSystem.Collections.Generic.List<BunkerDistributor.BunkerLocationInteriorPair> replacements = bunkerSetup.m_Replacements;
				if (bunkerInteriors != null && replacements != null)
				{
					LogMessage("Saved game name: " + SaveGameSystem.GetNewestSaveSlotForActiveGame().m_UserDefinedName, 381, "OnUpdate");
					LogMessage($"Bunker interior count: {((Il2CppArrayBase<BunkerInteriorSpecification>)(object)bunkerInteriors)?.Count ?? 0}, Bunker replacement count: {replacements?.Count ?? 0}", 382, "OnUpdate");
					string text4 = text3 + $"|{hoursPlayedNotPaused:F10}" + "|" + ((UnityEngine.Object)val5).name + "|" + SaveGameSystem.GetNewestSaveSlotForActiveGame().m_UserDefinedName;
					for (int k = 0; k < ((Il2CppArrayBase<BunkerInteriorSpecification>)(object)bunkerInteriors).Count && k < replacements.Count; k++)
					{
						text4 += $"|{((UnityEngine.Object)((Il2CppArrayBase<BunkerInteriorSpecification>)(object)bunkerInteriors)[k].m_Interior).name}|{TranslatePrepperCacheName(((UnityEngine.Object)((Il2CppArrayBase<BunkerInteriorSpecification>)(object)bunkerInteriors)[k].m_Interior).name)}|{((SceneObjectReference)replacements[k].m_LocationReference).SceneName}|{GetHumanFriendlyRegionName(((SceneObjectReference)replacements[k].m_LocationReference).SceneName)}";
						LogMessage($"Bunker #{k}: name=\"{((UnityEngine.Object)((Il2CppArrayBase<BunkerInteriorSpecification>)(object)bunkerInteriors)[k].m_Interior).name}\" ({TranslatePrepperCacheName(((UnityEngine.Object)((Il2CppArrayBase<BunkerInteriorSpecification>)(object)bunkerInteriors)[k].m_Interior).name)}), replacement=\"{((SceneObjectReference)replacements[k].m_LocationReference).SceneName}\" ({GetHumanFriendlyRegionName(((SceneObjectReference)replacements[k].m_LocationReference).SceneName)})", 399, "OnUpdate");
					}
					text4 = text4 + "|" + text;
					LogData(text4);
					hudMessage = "地堡分布: (" + SaveGameSystem.GetNewestSaveSlotForActiveGame().m_UserDefinedName + ")\n";
					string[] array = new string[2] { "Interloper", "Misery" };
					string[] array2 = new string[3] { "Pilgrim", "Voyageur", "Stalker" };
					mappingsRegion2PrepperCacheName.Clear();
					if (((ReadOnlySpan<string>)array).Contains(((UnityEngine.Object)val5).name))
					{
						hudMessage += $"储备地堡->{GetHumanFriendlyRegionName(((SceneObjectReference)replacements[0].m_LocationReference).SceneName)}\n猎人地堡->{GetHumanFriendlyRegionName(((SceneObjectReference)replacements[3].m_LocationReference).SceneName)}\n机密地堡->{GetHumanFriendlyRegionName(((SceneObjectReference)replacements[6].m_LocationReference).SceneName)}";
					}
					else if (((ReadOnlySpan<string>)array2).Contains(((UnityEngine.Object)val5).name))
					{
						hudMessage += $"储备地堡->{GetHumanFriendlyRegionName(((SceneObjectReference)replacements[6].m_LocationReference).SceneName)}\n猎人地堡->{GetHumanFriendlyRegionName(((SceneObjectReference)replacements[7].m_LocationReference).SceneName)}\n机密地堡->{GetHumanFriendlyRegionName(((SceneObjectReference)replacements[8].m_LocationReference).SceneName)}";
					}
					LogMessage(hudMessage, 446, "OnUpdate");
					if (Settings.enablePrepperCacheHUDDisplay && Settings.hudDisplayDuration > 0)
					{
						HUDMessage.AddMessage(hudMessage, (float)Settings.hudDisplayDuration, false, true);
					}
				}
				return;
			}
			catch (Exception value)
			{
				LogMessage($"Error creating BunkerDistributor: {value}", 453, "OnUpdate");
				return;
			}
		}
		inMenu = true;
	}

	public static string TranslatePrepperCacheName(string key)
	{
		if (mappingsPrepperCache.TryGetValue(key, out string value))
		{
			return value;
		}
		return key;
	}

	public static string GetHumanFriendlyRegionName(string regionName)
	{
		foreach (string key in mappingsRegion.Keys)
		{
			if (regionName.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
			{
				return mappingsRegion[key];
			}
		}
		return regionName;
	}

	public static bool IsGameScene(string? sceneName = null)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		string text;
		if (!string.IsNullOrEmpty(sceneName))
		{
			text = sceneName.ToLowerInvariant();
		}
		else
		{
			Scene activeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
			text = activeScene.name.ToLowerInvariant();
		}
		sceneName = text;
		if (string.IsNullOrEmpty(sceneName) || GameManager.EMPTY.ToLowerInvariant() == sceneName || GameManager.GetTargetMainMenuSceneName().ToLowerInvariant() == sceneName)
		{
			return false;
		}
		return true;
	}

	public static bool LoadPrepperCacheDictionary()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			LogMessage("Current save game name: " + SaveGameSystem.GetNewestSaveSlotForActiveGame().m_UserDefinedName, 584, "LoadPrepperCacheDictionary");
			LogMessage("Current localized game mode: " + ExperienceModeManager.s_CurrentGameMode.m_ModeName.m_LocalizationID, 586, "LoadPrepperCacheDictionary");
			ExperienceModeType? val = ExperienceModeManager.GetCurrentExperienceModeType();
			LogMessage("Current experience mode type: " + ((val.HasValue ? ((object)val.GetValueOrDefault()/*cast due to .constrained prefix*/).ToString() : null) ?? "<null>"), 590, "LoadPrepperCacheDictionary");
			if (!val.HasValue)
			{
				LogMessage("ERROR: No current experience mode type found.", 593, "LoadPrepperCacheDictionary");
				return false;
			}
			ExperienceModeManager experienceModeManagerComponent = GameManager.GetExperienceModeManagerComponent();
			Il2CppSystem.Collections.Generic.IList<GameModeConfig> val2 = ((experienceModeManagerComponent != null) ? experienceModeManagerComponent.GetAvailableGameModes() : null);
			if (val2 == null)
			{
				return false;
			}
			Il2CppSystem.Collections.Generic.List<GameModeConfig> val3 = ((Il2CppObjectBase)val2).Cast<Il2CppSystem.Collections.Generic.List<GameModeConfig>>();
			if (val3 == null)
			{
				return false;
			}
			LogMessage($"Available game mode configs: {val3.Count}", 611, "LoadPrepperCacheDictionary");
			Il2CppSystem.Collections.Generic.List<GameModeConfig> val4 = val3;
			if (val4 == null)
			{
				LogMessage("Available game modes list is null.", 616, "LoadPrepperCacheDictionary");
				return false;
			}
			GameModeConfig val5 = null;
			for (int i = 0; i < val4?.Count; i++)
			{
				GameModeConfig val6 = val4[i];
				if ((UnityEngine.Object)(object)val6 != (UnityEngine.Object)null && ((UnityEngine.Object)val6).name == ((object)val.Value/*cast due to .constrained prefix*/).ToString())
				{
					val5 = val6;
					break;
				}
			}
			if ((UnityEngine.Object)(object)val5 == (UnityEngine.Object)null)
			{
				LogMessage("Current experience mode not found in available modes.", 633, "LoadPrepperCacheDictionary");
				return false;
			}
			LogMessage("Found current experience mode: " + ((UnityEngine.Object)val5).name, 637, "LoadPrepperCacheDictionary");
			GameModeConfig gameModeFromName = ExperienceModeManager.GetGameModeFromName(((UnityEngine.Object)val5).name);
			SandboxConfig val7 = ((gameModeFromName != null) ? ((Il2CppObjectBase)gameModeFromName).Cast<SandboxConfig>() : null);
			if ((UnityEngine.Object)(object)val7 == (UnityEngine.Object)null)
			{
				LogMessage("Failed to get SandboxConfig.", 646, "LoadPrepperCacheDictionary");
				return false;
			}
			BunkerDistributor bunkerSetup = val7.m_BunkerSetup;
			if ((UnityEngine.Object)(object)bunkerSetup == (UnityEngine.Object)null)
			{
				LogMessage("Bunker setup is null.", 653, "LoadPrepperCacheDictionary");
				return false;
			}
			Il2CppReferenceArray<BunkerInteriorSpecification> bunkerInteriors = bunkerSetup.m_BunkerInteriors;
			Il2CppSystem.Collections.Generic.List<BunkerDistributor.BunkerLocationInteriorPair> replacements = bunkerSetup.m_Replacements;
			if (bunkerInteriors == null || replacements == null)
			{
				LogMessage("Bunker interiors or replacements are null.", 661, "LoadPrepperCacheDictionary");
				return false;
			}
			string[] array = new string[2] { "Interloper", "Misery" };
			string[] array2 = new string[3] { "Pilgrim", "Voyageur", "Stalker" };
			mappingsRegion2PrepperCacheName.Clear();
			if (((ReadOnlySpan<string>)array).Contains(((UnityEngine.Object)val5).name))
			{
				mappingsRegion2PrepperCacheName[GetHumanFriendlyRegionName(((SceneObjectReference)replacements[0].m_LocationReference).SceneName)] = "储备地堡";
				mappingsRegion2PrepperCacheName[GetHumanFriendlyRegionName(((SceneObjectReference)replacements[3].m_LocationReference).SceneName)] = "猎人地堡";
				mappingsRegion2PrepperCacheName[GetHumanFriendlyRegionName(((SceneObjectReference)replacements[6].m_LocationReference).SceneName)] = "机密地堡";
			}
			else if (((ReadOnlySpan<string>)array2).Contains(((UnityEngine.Object)val5).name))
			{
				mappingsRegion2PrepperCacheName[GetHumanFriendlyRegionName(((SceneObjectReference)replacements[6].m_LocationReference).SceneName)] = "储备地堡";
				mappingsRegion2PrepperCacheName[GetHumanFriendlyRegionName(((SceneObjectReference)replacements[7].m_LocationReference).SceneName)] = "猎人地堡";
				mappingsRegion2PrepperCacheName[GetHumanFriendlyRegionName(((SceneObjectReference)replacements[8].m_LocationReference).SceneName)] = "机密地堡";
			}
		}
		catch (Exception value)
		{
			LogMessage($"Error determining Prepper Cache Inventory: {value}", 693, "LoadPrepperCacheDictionary");
			return false;
		}
		return true;
	}
}
