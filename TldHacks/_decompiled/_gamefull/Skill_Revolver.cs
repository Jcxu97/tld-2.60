using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200094D")]
public class Skill_Revolver : Skill
{
	[Header("Tuning")]
	[Token(Token = "0x4006077")]
	[FieldOffset(Offset = "0x68")]
	public int[] m_CriticalHitChanceIncrease;

	[Token(Token = "0x4006078")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_ConditionRepairBonus;

	[Token(Token = "0x4006079")]
	[FieldOffset(Offset = "0x78")]
	public int[] m_ConditionDegradeOnUseReduction;

	[Token(Token = "0x400607A")]
	[FieldOffset(Offset = "0x80")]
	public int[] m_DamageIncrease;

	[Tooltip("Recoil is reduced by this amount (ie. 20% compensation means 80% of baseline recoil applied).")]
	[Token(Token = "0x400607B")]
	[FieldOffset(Offset = "0x88")]
	public int[] m_RecoilCompensation;

	[Token(Token = "0x400607C")]
	[FieldOffset(Offset = "0x90")]
	public float[] m_AimAssistAngleDegrees;

	[Token(Token = "0x400607D")]
	[FieldOffset(Offset = "0x98")]
	public int[] m_StruggleBonus;

	[Token(Token = "0x400607E")]
	[FieldOffset(Offset = "0xA0")]
	public string[] m_AimAssistTierText;

	[Token(Token = "0x400607F")]
	private static Skill_RevolverSaveData m_Skill_RevolverSaveData;

	[Token(Token = "0x600543F")]
	[Address(RVA = "0xE7C870", Offset = "0xE7B670", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6005440")]
	[Address(RVA = "0xE7C950", Offset = "0xE7B750", Length = "0xE6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6005441")]
	[Address(RVA = "0xE78C60", Offset = "0xE77A60", Length = "0x91")]
	public float GetCriticalHitChanceScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005442")]
	[Address(RVA = "0xE7A200", Offset = "0xE79000", Length = "0x7A")]
	public int GetConditionRepairBonus()
	{
		return 0;
	}

	[Token(Token = "0x6005443")]
	[Address(RVA = "0xE7CA40", Offset = "0xE7B840", Length = "0x95")]
	public float GetRecoilScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005444")]
	[Address(RVA = "0xE7A280", Offset = "0xE79080", Length = "0x91")]
	public float GetRevolverDamageScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005445")]
	[Address(RVA = "0xE78DA0", Offset = "0xE77BA0", Length = "0xBE")]
	public float GetConditionDegradeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005446")]
	[Address(RVA = "0xE7CAE0", Offset = "0xE7B8E0", Length = "0x7C")]
	public float GetAimAssistAngleDegrees()
	{
		return 0f;
	}

	[Token(Token = "0x6005447")]
	[Address(RVA = "0xE7CB60", Offset = "0xE7B960", Length = "0x87")]
	public float GetStruggleBonus()
	{
		return 0f;
	}

	[Token(Token = "0x6005448")]
	[Address(RVA = "0xE7CBF0", Offset = "0xE7B9F0", Length = "0x401")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x6005449")]
	[Address(RVA = "0xE7D000", Offset = "0xE7BE00", Length = "0x372")]
	public Skill_Revolver()
	{
	}
}
