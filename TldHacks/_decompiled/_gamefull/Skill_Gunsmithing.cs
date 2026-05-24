using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000948")]
public class Skill_Gunsmithing : Skill
{
	[Serializable]
	[Token(Token = "0x2000949")]
	public struct SkillTier
	{
		[Range(0f, 100f)]
		[Token(Token = "0x400606D")]
		[FieldOffset(Offset = "0x0")]
		public int m_CraftedAmmoCondition;

		[Range(0f, 100f)]
		[Token(Token = "0x400606E")]
		[FieldOffset(Offset = "0x4")]
		public float m_HarvestAmmoSuccessChance;

		[Range(0f, 100f)]
		[Token(Token = "0x400606F")]
		[FieldOffset(Offset = "0x8")]
		public float m_MillingRepairSuccessChance;

		[Range(0f, 100f)]
		[Token(Token = "0x4006070")]
		[FieldOffset(Offset = "0xC")]
		public float m_MillingRepairCondition;
	}

	[Token(Token = "0x400606C")]
	[FieldOffset(Offset = "0x68")]
	public List<SkillTier> m_SkillTiers;

	[Token(Token = "0x600542A")]
	[Address(RVA = "0xE7BB70", Offset = "0xE7A970", Length = "0xBD")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600542B")]
	[Address(RVA = "0xE7BC30", Offset = "0xE7AA30", Length = "0xE6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600542C")]
	[Address(RVA = "0xE7BD20", Offset = "0xE7AB20", Length = "0x24D")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x600542D")]
	[Address(RVA = "0xE7BF70", Offset = "0xE7AD70", Length = "0x1B")]
	public int GetAmmoCraftingCondition()
	{
		return 0;
	}

	[Token(Token = "0x600542E")]
	[Address(RVA = "0xE7BF90", Offset = "0xE7AD90", Length = "0x1E")]
	public float GetMillingRepairCondition()
	{
		return 0f;
	}

	[Token(Token = "0x600542F")]
	[Address(RVA = "0xE7BFB0", Offset = "0xE7ADB0", Length = "0x1E")]
	public float GetMillingRepairSuccessChance()
	{
		return 0f;
	}

	[Token(Token = "0x6005430")]
	[Address(RVA = "0xE7BFD0", Offset = "0xE7ADD0", Length = "0x6D")]
	public bool RollAmmoHarvestSuccess()
	{
		return false;
	}

	[Token(Token = "0x6005431")]
	[Address(RVA = "0xE7C040", Offset = "0xE7AE40", Length = "0x6D")]
	public bool RollMillingRepairSuccess()
	{
		return false;
	}

	[Token(Token = "0x6005432")]
	[Address(RVA = "0xE7C0B0", Offset = "0xE7AEB0", Length = "0xF6")]
	private SkillTier GetCurrentTier()
	{
		return default(SkillTier);
	}

	[Token(Token = "0x6005433")]
	[Address(RVA = "0xE7C1B0", Offset = "0xE7AFB0", Length = "0x7")]
	public Skill_Gunsmithing()
	{
	}
}
