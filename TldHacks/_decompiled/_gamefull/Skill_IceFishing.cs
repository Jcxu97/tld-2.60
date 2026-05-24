using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200094B")]
public class Skill_IceFishing : Skill
{
	[Header("Tuning")]
	[Token(Token = "0x4006072")]
	[FieldOffset(Offset = "0x68")]
	public int[] m_LineBreakOnCatchChance;

	[Token(Token = "0x4006073")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_ReduceFishingTimePercent;

	[Token(Token = "0x4006074")]
	[FieldOffset(Offset = "0x78")]
	public int[] m_IncreaseFishWeightPercent;

	[Token(Token = "0x4006075")]
	private static Skill_IceFishingSaveData m_Skill_IceFishingSaveData;

	[Token(Token = "0x6005435")]
	[Address(RVA = "0xE7C1C0", Offset = "0xE7AFC0", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6005436")]
	[Address(RVA = "0xE7C2A0", Offset = "0xE7B0A0", Length = "0xE6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6005437")]
	[Address(RVA = "0xE7C390", Offset = "0xE7B190", Length = "0x7F")]
	public float GetLineBreakOnChancePercent()
	{
		return 0f;
	}

	[Token(Token = "0x6005438")]
	[Address(RVA = "0xE7C410", Offset = "0xE7B210", Length = "0x2B")]
	public float GetBaseLineBreakOnChancePercent()
	{
		return 0f;
	}

	[Token(Token = "0x6005439")]
	[Address(RVA = "0xE799E0", Offset = "0xE787E0", Length = "0xBE")]
	public float ReduceFishingTimeScale()
	{
		return 0f;
	}

	[Token(Token = "0x600543A")]
	[Address(RVA = "0xE7B530", Offset = "0xE7A330", Length = "0x91")]
	public float GetFishWeightScale()
	{
		return 0f;
	}

	[Token(Token = "0x600543B")]
	[Address(RVA = "0xE7C440", Offset = "0xE7B240", Length = "0x1FF")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x600543C")]
	[Address(RVA = "0xE7C640", Offset = "0xE7B440", Length = "0x172")]
	public Skill_IceFishing()
	{
	}
}
