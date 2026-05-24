using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200094F")]
public class Skill_Rifle : Skill
{
	[Header("Tuning")]
	[Token(Token = "0x4006081")]
	[FieldOffset(Offset = "0x68")]
	public int[] m_CriticalHitChanceIncrease;

	[Token(Token = "0x4006082")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_ConditionRepairBonus;

	[Token(Token = "0x4006083")]
	[FieldOffset(Offset = "0x78")]
	public int[] m_ConditionDegradeOnUseReduction;

	[Token(Token = "0x4006084")]
	[FieldOffset(Offset = "0x80")]
	public int[] m_AccuracyRangeIncrease;

	[Token(Token = "0x4006085")]
	[FieldOffset(Offset = "0x88")]
	public int[] m_DamageIncrease;

	[Token(Token = "0x4006086")]
	[FieldOffset(Offset = "0x90")]
	public int[] m_StabilityBonus;

	[Token(Token = "0x4006087")]
	[FieldOffset(Offset = "0x98")]
	public int[] m_EffectiveRange;

	[Token(Token = "0x4006088")]
	[FieldOffset(Offset = "0xA0")]
	public float[] m_AimAssistAngleDegrees;

	[Token(Token = "0x4006089")]
	[FieldOffset(Offset = "0xA8")]
	public string[] m_AimAssistTierText;

	[Token(Token = "0x400608A")]
	private static Skill_RifleSaveData m_Skill_RifleSaveData;

	[Token(Token = "0x600544C")]
	[Address(RVA = "0xE7D430", Offset = "0xE7C230", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600544D")]
	[Address(RVA = "0xE7D510", Offset = "0xE7C310", Length = "0xE6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600544E")]
	[Address(RVA = "0xE78C60", Offset = "0xE77A60", Length = "0x91")]
	public float GetCriticalHitChanceScale()
	{
		return 0f;
	}

	[Token(Token = "0x600544F")]
	[Address(RVA = "0xE7A200", Offset = "0xE79000", Length = "0x7A")]
	public int GetConditionRepairBonus()
	{
		return 0;
	}

	[Token(Token = "0x6005450")]
	[Address(RVA = "0xE7A280", Offset = "0xE79080", Length = "0x91")]
	public float GetAccuracyRangeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005451")]
	[Address(RVA = "0xE7D600", Offset = "0xE7C400", Length = "0x91")]
	public float GetRifleDamageScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005452")]
	[Address(RVA = "0xE7AA70", Offset = "0xE79870", Length = "0x87")]
	public float GetStabilityBonus()
	{
		return 0f;
	}

	[Token(Token = "0x6005453")]
	[Address(RVA = "0xE7D6A0", Offset = "0xE7C4A0", Length = "0x36")]
	public float GetBestStabilityBonus()
	{
		return 0f;
	}

	[Token(Token = "0x6005454")]
	[Address(RVA = "0xE7D6E0", Offset = "0xE7C4E0", Length = "0x7F")]
	public float GetEffectiveRange()
	{
		return 0f;
	}

	[Token(Token = "0x6005455")]
	[Address(RVA = "0xE78DA0", Offset = "0xE77BA0", Length = "0xBE")]
	public float GetConditionDegradeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005456")]
	[Address(RVA = "0xE7D760", Offset = "0xE7C560", Length = "0x7C")]
	public float GetAimAssistAngleDegrees()
	{
		return 0f;
	}

	[Token(Token = "0x6005457")]
	[Address(RVA = "0xE7D7E0", Offset = "0xE7C5E0", Length = "0x395")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x6005458")]
	[Address(RVA = "0xE7DB80", Offset = "0xE7C980", Length = "0x3D2")]
	public Skill_Rifle()
	{
	}
}
