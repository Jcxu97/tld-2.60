using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace FiligranisSkills;

[HarmonyPatch(typeof(SkillsManager), "Awake")]
public static class SkillsManagerInitialize
{
	public static void Postfix(SkillsManager __instance)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		FiligranisSkills.skills.Clear();
		// 原版用 SkillType 最大值当起点,2026-10 加了 Shotgun 后对不上列表,AlcoholMod 每次读技能都越界;改成按自定义技能实际插入的位置
		FiligranisSkills.customSkillOffset = __instance.m_Skills.Count;
		for (int i = 0; i < FiligranisSkills.defs.Count; i++)
		{
			SkillDefinition skillDefinition = FiligranisSkills.defs[i];
			Skill_IceFishing val = new GameObject
			{
				name = "Skill_" + skillDefinition.Name
			}.AddComponent<Skill_IceFishing>();
			((Skill)val).m_LocalizedDisplayName = skillDefinition.DisplayNameLocalized;
			((Skill)val).m_SkillIcon = skillDefinition.IconId;
			((Skill)val).m_SkillIconBackground = skillDefinition.IconBackgroundId;
			((Skill)val).m_SkillImage = skillDefinition.ImageId;
			((Skill)val).m_SkillType = (SkillType)(-1);
			((Skill)val).m_TierLocalizedDescriptions = new Il2CppReferenceArray<LocalizedString>(skillDefinition.TiersDescriptionLocalized);
			((Skill)val).m_TierLocalizedBenefits = new Il2CppReferenceArray<LocalizedString>(skillDefinition.TiersBenefitsLocalized);
			((Skill)val).m_TierPoints = new Il2CppStructArray<int>(skillDefinition.TierThresholds);
			FiligranisSkills.skills[skillDefinition.Name] = i;
			__instance.m_Skills.Add((Skill)(object)val);
		}
	}
}
