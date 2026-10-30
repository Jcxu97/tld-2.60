using System;
using System.Collections.Generic;
using System.Linq;
using Il2Cpp;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using ModData;
using UnityEngine;

namespace FiligranisSkills;

public class FiligranisSkills : MelonMod
{
	internal static System.Collections.Generic.Dictionary<string, int> skills = new System.Collections.Generic.Dictionary<string, int>();

	internal static System.Collections.Generic.List<SkillDefinition> defs = new System.Collections.Generic.List<SkillDefinition>();

	internal static int customSkillOffset;

	public static FiligranisSkills Instance { get; private set; }

	internal ModDataManager ModSave { get; private set; } = new ModDataManager("FiligranisSkills");

	public override void OnEarlyInitializeMelon()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got Unknown
		Instance = this;
		customSkillOffset = -1;
		SkillType[] values = Enum.GetValues<SkillType>();
		foreach (SkillType val in values)
		{
			if ((int)val > customSkillOffset)
			{
				customSkillOffset = (int)val;
			}
		}
	}

	public override void OnInitializeMelon()
	{
		uConsole.RegisterCommand("fskills_saved", (uConsole.DebugCommand)((Action)delegate
		{
			for (int i = customSkillOffset; i < GameManager.GetSkillsManager().m_Skills.Count; i++)
			{
				string text = ((UnityEngine.Object)GameManager.GetSkillsManager().m_Skills[i]).name.Substring("Skill_".Length);
				MelonLogger.Instance loggerInstance = ((MelonBase)Instance).LoggerInstance;
				if (loggerInstance != null)
				{
					loggerInstance.Msg("FSkill: " + text + " " + Instance.ModSave.Load("skillpoint_" + text));
				}
			}
		}));
		uConsole.RegisterCommand("fskills_add_point", (uConsole.DebugCommand)((Action)delegate
		{
			var allParameters = uConsole.GetAllParameters();
			if (allParameters != null)
			{
				if (allParameters.Count < 2)
				{
					uConsole.Log("[skillname, points]");
				}
				if (int.TryParse(allParameters[1], out var result))
				{
					IncreaseSkillPoints(allParameters[0], result);
				}
				else
				{
					uConsole.Log("points must be a number");
				}
			}
		}));
		uConsole.RegisterCommand("fskills_set_point", (uConsole.DebugCommand)((Action)delegate
		{
			var allParameters = uConsole.GetAllParameters();
			if (allParameters != null)
			{
				if (allParameters.Count < 2)
				{
					uConsole.Log("[skillname, points]");
				}
				Skill val = null;
				if (skills.TryGetValue(allParameters[0], out var value))
				{
					val = GameManager.GetSkillsManager().m_Skills[customSkillOffset + value];
					if (int.TryParse(allParameters[1], out var result))
					{
						val.SetPoints(result, (SkillsManager.PointAssignmentMode)1);
					}
					else
					{
						uConsole.Log("points must be a number");
					}
				}
				else
				{
					uConsole.Log("skill not found");
				}
			}
		}));
	}

	public static bool IsRegistered(string skillName)
	{
		if (!skills.ContainsKey(skillName))
		{
			return defs.Any((SkillDefinition d) => d.Name == skillName);
		}
		return true;
	}

	public static (int points, int tier) GetPointsAndTiers(string skillName)
	{
		Il2CppSystem.Collections.Generic.List<Skill> list = GameManager.GetSkillsManager().m_Skills;
		int index = customSkillOffset + skills[skillName];
		if (index < 0 || index >= list.Count)
		{
			return (points: 0, tier: 0);
		}
		Skill val = list[index];
		return (points: val.GetPoints(), tier: val.GetCurrentTierNumber());
	}

	public static void IncreaseSkillPoints(string skillName, int points)
	{
		SkillsManager skillsManager = GameManager.GetSkillsManager();
		Skill val = skillsManager.m_Skills[customSkillOffset + skills[skillName]];
		int currentTierNumber = val.GetCurrentTierNumber();
		int points2 = val.GetPoints();
		val.IncrementPoints(points, (SkillsManager.PointAssignmentMode)0);
		int currentTierNumber2 = val.GetCurrentTierNumber();
		if (currentTierNumber != currentTierNumber2)
		{
			GameManager.GetSkillNotify().MaybeShowLevelUp(val.m_SkillIcon, val.m_DisplayName, skillsManager.GetTierName(currentTierNumber2), currentTierNumber2 + 1);
		}
		else
		{
			GameManager.GetSkillNotify().MaybeShowPointIncrease(val.m_SkillIcon);
		}
		MelonLogger.Instance loggerInstance = ((MelonBase)Instance).LoggerInstance;
		if (loggerInstance != null)
		{
			loggerInstance.Msg($"{skillName} | T{currentTierNumber} ({points2}+{points}) -> T{currentTierNumber2 + 1} ({val.GetPoints()})");
		}
	}

	public static void RegisterSkill(SkillDefinition def)
	{
		if (IsRegistered(def.Name))
		{
			MelonLogger.Instance loggerInstance = ((MelonBase)Instance).LoggerInstance;
			if (loggerInstance != null)
			{
				loggerInstance.Error("Some mod is trying to regsiter a skill " + def.Name + " which the name is already used, it won't be registered, please report to the mod authors.");
			}
		}
		else
		{
			defs.Add(def);
		}
	}
}
