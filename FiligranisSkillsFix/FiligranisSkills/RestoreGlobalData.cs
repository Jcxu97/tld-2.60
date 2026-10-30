using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace FiligranisSkills;

[HarmonyPatch(typeof(SaveGameSystem), "RestoreGlobalData")]
internal static class RestoreGlobalData
{
	[HarmonyPriority(700)]
	internal static void Postfix(string name)
	{
		SkillsManager skillsManager = GameManager.GetSkillsManager();
		for (int i = FiligranisSkills.customSkillOffset; i < skillsManager.m_Skills.Count; i++)
		{
			Skill val = skillsManager.m_Skills[i];
			string text = ((UnityEngine.Object)val).name.Substring("Skill_".Length);
			string text2 = FiligranisSkills.Instance.ModSave.Load("skillpoint_" + text);
			if (text2 != null && int.TryParse(text2, out var result))
			{
				val.SetPoints(result, (SkillsManager.PointAssignmentMode)1);
			}
		}
		for (int j = 0; j < skillsManager.m_Skills.Count; j++)
		{
			_ = skillsManager.m_Skills[j];
		}
	}
}
