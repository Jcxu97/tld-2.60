using HarmonyLib;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace FiligranisSkills;

[HarmonyPatch(typeof(SaveGameSystem), "SaveGlobalData")]
internal static class SaveGlobalData
{
	[HarmonyPriority(700)]
	internal static void Postfix(SlotData slot)
	{
		SkillsManager skillsManager = GameManager.GetSkillsManager();
		for (int i = FiligranisSkills.customSkillOffset; i < skillsManager.m_Skills.Count; i++)
		{
			Skill val = skillsManager.m_Skills[i];
			string text = ((UnityEngine.Object)val).name.Substring("Skill_".Length);
			MelonLogger.Instance loggerInstance = ((MelonBase)FiligranisSkills.Instance).LoggerInstance;
			if (loggerInstance != null)
			{
				loggerInstance.Msg($"FSkill: Saving skill#{i} {text} {val.GetPoints()}p");
			}
			FiligranisSkills.Instance.ModSave.Save(val.GetPoints().ToString(), "skillpoint_" + text);
		}
	}
}
