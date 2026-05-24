using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000940")]
public class Skill_CarcassHarvesting : Skill
{
	[Header("Tuning")]
	[Token(Token = "0x400604B")]
	[FieldOffset(Offset = "0x68")]
	public float m_NumHoursHarvestPerSkillPoint;

	[Token(Token = "0x400604C")]
	[FieldOffset(Offset = "0x6C")]
	public int m_LevelWhereNoInitialBarehandedHarvestLoss;

	[Token(Token = "0x400604D")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_MeatTimePercentDecrease;

	[Token(Token = "0x400604E")]
	[FieldOffset(Offset = "0x78")]
	public int[] m_HideGutTimePercentDecrease;

	[Token(Token = "0x400604F")]
	[FieldOffset(Offset = "0x80")]
	public int[] m_FrozenThresholdPercent;

	[Token(Token = "0x4006050")]
	[FieldOffset(Offset = "0x88")]
	private float m_NumHoursToConvertToSkillPoints;

	[Token(Token = "0x4006051")]
	private static Skill_CarcassHarvestingSaveData m_Skill_CarcassHarvestingSaveData;

	[Token(Token = "0x60053FC")]
	[Address(RVA = "0xE79670", Offset = "0xE78470", Length = "0x102")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60053FD")]
	[Address(RVA = "0xE79780", Offset = "0xE78580", Length = "0xF4")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60053FE")]
	[Address(RVA = "0xE79880", Offset = "0xE78680", Length = "0xA2")]
	public bool NoHarvestLossWhenDoingInitialHarvestingLoss()
	{
		return false;
	}

	[Token(Token = "0x60053FF")]
	[Address(RVA = "0xE79930", Offset = "0xE78730", Length = "0x7A")]
	public int GetFrozenThresholdPercent()
	{
		return 0;
	}

	[Token(Token = "0x6005400")]
	[Address(RVA = "0xE799B0", Offset = "0xE787B0", Length = "0x29")]
	public int GetBaseFrozenThresholdPercent()
	{
		return 0;
	}

	[Token(Token = "0x6005401")]
	[Address(RVA = "0xE799E0", Offset = "0xE787E0", Length = "0xBE")]
	public float GetMeatHarvestTimeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005402")]
	[Address(RVA = "0xE78DA0", Offset = "0xE77BA0", Length = "0xBE")]
	public float GetHideGutHarvestTimeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005403")]
	[Address(RVA = "0xE79AA0", Offset = "0xE788A0", Length = "0x26B")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x6005404")]
	[Address(RVA = "0xE79D10", Offset = "0xE78B10", Length = "0xE5")]
	public void ApplyHoursToSkill(float hours)
	{
	}

	[Token(Token = "0x6005405")]
	[Address(RVA = "0xE79E00", Offset = "0xE78C00", Length = "0x172")]
	public Skill_CarcassHarvesting()
	{
	}
}
