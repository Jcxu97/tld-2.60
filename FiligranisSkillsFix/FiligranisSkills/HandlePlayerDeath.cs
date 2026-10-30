using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace FiligranisSkills;

[HarmonyPatch(typeof(GameManager), "HandlePlayerDeath")]
internal static class HandlePlayerDeath
{
	internal static void Postfix()
	{
		SkillsManager skillsManager = GameManager.GetSkillsManager();
		for (int i = FiligranisSkills.customSkillOffset; i < skillsManager.m_Skills.Count; i++)
		{
			string text = ((UnityEngine.Object)skillsManager.m_Skills[i]).name.Substring("Skill_".Length);
			FiligranisSkills.Instance.ModSave.Save("", "skillpoint_" + text);
		}
	}
}
