using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace FiligranisSkills;

[HarmonyPatch(typeof(Panel_Log), "RefreshSelectedSkillDescriptionView")]
public static class Panel_Log_Initialize
{
	public static void Postfix(Panel_Log __instance)
	{
		SkillsManager skillsManager = GameManager.GetSkillsManager();
		for (int i = 0; i < skillsManager.m_Skills.Count; i++)
		{
			_ = skillsManager.m_Skills[i];
		}
		if (!((UnityEngine.Object)(object)((UIWidget)__instance.m_SkillImageLarge).mainTexture == (Object)null))
		{
			return;
		}
		Skill skill = __instance.m_SkillsDisplayList[__instance.m_SkillListSelectedIndex].m_Skill;
		if (!((UnityEngine.Object)(object)skill == (Object)null))
		{
			string key = ((UnityEngine.Object)skill).name.Substring("Skill_".Length);
			Texture2D image = FiligranisSkills.defs[FiligranisSkills.skills[key]].Image;
			if ((UnityEngine.Object)(object)image != (Object)null)
			{
				((UIWidget)__instance.m_SkillImageLarge).mainTexture = (Texture)(object)image;
			}
		}
	}
}
