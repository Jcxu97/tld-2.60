using System;
using System.Globalization;
using System.IO;
using MelonLoader;
using ModData;
using NLBIni;
using UnityEngine;

namespace NorthernLightsBroadcast;

public static class SaveLoad
{
	public static IniDataParser iniDataParser;

	public static IniData thisIniData;

	public static ModDataManager dataManager;

	public static string moddataString;

	public static bool reloadPending = true;

	public static void LoadTheTVs()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		if (reloadPending)
		{
			MelonLogger.Msg("Loading TV data");
			iniDataParser = new IniDataParser();
			thisIniData = new IniData();
			dataManager = new ModDataManager("NorthernLightsBroadcast", false);
			iniDataParser.Configuration.AllowCreateSectionsOnFly = true;
			iniDataParser.Configuration.SkipInvalidLines = true;
			iniDataParser.Configuration.OverrideDuplicateKeys = true;
			iniDataParser.Configuration.AllowDuplicateKeys = false;
			moddataString = dataManager.Load();
			thisIniData = iniDataParser.Parse(moddataString);
			reloadPending = false;
		}
	}

	public static void MaybeAddTV(string TVID)
	{
		if (!thisIniData.Sections.ContainsSection(TVID))
		{
			thisIniData.Sections.AddSection(TVID);
		}
	}

	public static string GetFolder(string TVID)
	{
		if (thisIniData == null)
		{
			return Application.dataPath + "/../Mods";
		}
		if (TVID == null || !thisIniData[TVID].ContainsKey("currentFolder"))
		{
			return Application.dataPath + "/../Mods";
		}
		if (!Directory.Exists(thisIniData[TVID]["currentFolder"]))
		{
			return Application.dataPath + "/../Mods";
		}
		return thisIniData[TVID]["currentFolder"];
	}

	public static void SetFolder(string TVID, string folder)
	{
		if (thisIniData != null && TVID != "")
		{
			thisIniData[TVID].AddKey("currentFolder");
			thisIniData[TVID]["currentFolder"] = folder;
		}
	}

	public static float GetVolume(string TVID)
	{
		// v2.1.1: 补 thisIniData null 判断(同文件 GetFolder 一直有,这三个漏了)。
		// 手搓的电视走 GearItem.Awake 那条路进来时可能还没人调过 LoadTheTVs → NRE,这台电视废掉。
		// 数字也按固定区域解析,免得德语系统上 "0,5" 解析失败。
		if (thisIniData == null || TVID == null || !thisIniData[TVID].ContainsKey("volume"))
		{
			return 0.5f;
		}
		if (!float.TryParse(thisIniData[TVID]["volume"], NumberStyles.Float, CultureInfo.InvariantCulture, out float v))
		{
			return 0.5f;
		}
		return Mathf.Clamp01(v);
	}

	public static void SetVolume(string TVID, float volume)
	{
		if (thisIniData != null && !string.IsNullOrEmpty(TVID))
		{
			thisIniData[TVID].AddKey("volume");
			thisIniData[TVID]["volume"] = volume.ToString(CultureInfo.InvariantCulture);
		}
	}

	public static string GetLastPlayed(string TVID)
	{
		if (thisIniData == null || TVID == null || !thisIniData[TVID].ContainsKey("lastPlayed"))
		{
			return "";
		}
		return thisIniData[TVID]["lastPlayed"];
	}

	public static void SetLastPlayed(string TVID, string lastPlayed)
	{
		if (thisIniData != null && TVID != "")
		{
			thisIniData[TVID].AddKey("lastPlayed");
			thisIniData[TVID]["lastPlayed"] = lastPlayed;
		}
	}

	public static TVManager.TVState GetState(string TVID)
	{
		// v2.1.1: 补 null 判断 + Enum.Parse 换 TryParse(存档里的脏字符串会让 Parse 抛,认不出就当关机)
		if (thisIniData == null || TVID == null || !thisIniData[TVID].ContainsKey("state"))
		{
			return TVManager.TVState.Off;
		}
		if (!Enum.TryParse<TVManager.TVState>(thisIniData[TVID]["state"], out var state))
		{
			return TVManager.TVState.Off;
		}
		return state;
	}

	public static void SetState(string TVID, TVManager.TVState state)
	{
		if (thisIniData != null && !string.IsNullOrEmpty(TVID))
		{
			thisIniData[TVID].AddKey("state");
			thisIniData[TVID]["state"] = state.ToString();
		}
	}

	public static void SaveTheTVs()
	{
		// v2.1.1: 这个挂在 SaveGameSystem.SaveSceneData 的后置补丁上,抛了就是在存档路径上抛。
		// 主菜单存档等还没进过场景的情况下这俩是 null。
		if (dataManager == null || thisIniData == null) return;
		try
		{
			dataManager.Save(thisIniData.ToString());
		}
		catch (Exception ex)
		{
			MelonLogger.Warning("[NLB] 保存电视数据失败: " + ex.Message);
		}
	}
}
