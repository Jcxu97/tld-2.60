using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200093E")]
public class Skill_Archery : Skill
{
	[Header("Tuning")]
	[Token(Token = "0x4006042")]
	[FieldOffset(Offset = "0x68")]
	public int[] m_CriticalHitChanceIncrease;

	[Token(Token = "0x4006043")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_DamageIncrease;

	[Token(Token = "0x4006044")]
	[FieldOffset(Offset = "0x78")]
	public int[] m_ConditionDegradeOnUseReduction;

	[Token(Token = "0x4006045")]
	[FieldOffset(Offset = "0x80")]
	public int[] m_SwayReduction;

	[Token(Token = "0x4006046")]
	[FieldOffset(Offset = "0x88")]
	public int[] m_BleedOutTimeReduction;

	[Token(Token = "0x4006047")]
	[FieldOffset(Offset = "0x90")]
	public int m_LevelWhereCanFireFromCrouch;

	[Token(Token = "0x4006048")]
	private static Skill_ArcherySaveData m_Skill_ArcherySaveData;

	[Token(Token = "0x60053F0")]
	[Address(RVA = "0xE78A90", Offset = "0xE77890", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60053F1")]
	[Address(RVA = "0xE78B70", Offset = "0xE77970", Length = "0xE6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60053F2")]
	[Address(RVA = "0xE78C60", Offset = "0xE77A60", Length = "0x91")]
	public float GetCriticalHitChanceScale()
	{
		return 0f;
	}

	[Token(Token = "0x60053F3")]
	[Address(RVA = "0xE78D00", Offset = "0xE77B00", Length = "0x91")]
	public float GetArcheryDamageScale()
	{
		return 0f;
	}

	[Token(Token = "0x60053F4")]
	[Address(RVA = "0xE78DA0", Offset = "0xE77BA0", Length = "0xBE")]
	public float GetConditionDegradeScale()
	{
		return 0f;
	}

	[Token(Token = "0x60053F5")]
	[Address(RVA = "0xE78E60", Offset = "0xE77C60", Length = "0xB0")]
	public float GetSwayScale()
	{
		return 0f;
	}

	[Token(Token = "0x60053F6")]
	[Address(RVA = "0xE78F20", Offset = "0xE77D20", Length = "0xBD")]
	public float GetBleedOutTimeScale()
	{
		return 0f;
	}

	[Token(Token = "0x60053F7")]
	[Address(RVA = "0xE78FE0", Offset = "0xE77DE0", Length = "0xB1")]
	public bool CanFireBowWhileCrouched()
	{
		return false;
	}

	[Token(Token = "0x60053F8")]
	[Address(RVA = "0xE790A0", Offset = "0xE77EA0", Length = "0x2D7")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x60053F9")]
	[Address(RVA = "0xE79380", Offset = "0xE78180", Length = "0x232")]
	public Skill_Archery()
	{
	}
}
