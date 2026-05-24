using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000946")]
public class Skill_Firestarting : Skill
{
	[Header("Tuning")]
	[Token(Token = "0x4006066")]
	[FieldOffset(Offset = "0x68")]
	public int m_LevelWhereTinderNotRequired;

	[Token(Token = "0x4006067")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_BaseSuccessChance;

	[Token(Token = "0x4006068")]
	[FieldOffset(Offset = "0x78")]
	public int[] m_DurationPercentIncrease;

	[Token(Token = "0x4006069")]
	[FieldOffset(Offset = "0x80")]
	public int[] m_StartPercentIncrease;

	[Token(Token = "0x400606A")]
	private static Skill_FirestartingSaveData m_Skill_FirestartingSaveData;

	[Token(Token = "0x6005420")]
	[Address(RVA = "0xE7B330", Offset = "0xE7A130", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6005421")]
	[Address(RVA = "0xE7B410", Offset = "0xE7A210", Length = "0x118")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6005422")]
	[Address(RVA = "0xE7A200", Offset = "0xE79000", Length = "0x7A")]
	public int GetBaseChanceSuccess()
	{
		return 0;
	}

	[Token(Token = "0x6005423")]
	[Address(RVA = "0xE7B530", Offset = "0xE7A330", Length = "0x91")]
	public float GetDurationScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005424")]
	[Address(RVA = "0xE7B5D0", Offset = "0xE7A3D0", Length = "0xBD")]
	public float GetStartTimeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005425")]
	[Address(RVA = "0xE7B690", Offset = "0xE7A490", Length = "0x1F0")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x6005426")]
	[Address(RVA = "0xE7B890", Offset = "0xE7A690", Length = "0xA2")]
	public bool TinderRequired()
	{
		return false;
	}

	[Token(Token = "0x6005427")]
	[Address(RVA = "0xE7B940", Offset = "0xE7A740", Length = "0x172")]
	public Skill_Firestarting()
	{
	}
}
