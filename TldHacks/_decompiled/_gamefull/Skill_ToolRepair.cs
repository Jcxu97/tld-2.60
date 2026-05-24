using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000951")]
public class Skill_ToolRepair : Skill
{
	[Header("Tuning")]
	[Token(Token = "0x400608C")]
	[FieldOffset(Offset = "0x68")]
	public int[] m_BaseSuccessChance;

	[Token(Token = "0x400608D")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_RepairTimePercentDecrease;

	[Token(Token = "0x400608E")]
	[FieldOffset(Offset = "0x78")]
	public int[] m_ItemConditionPercentIncrease;

	[Token(Token = "0x400608F")]
	private static Skill_ToolRepairSaveData m_Skill_ToolRepairSaveData;

	[Token(Token = "0x600545B")]
	[Address(RVA = "0xE7E010", Offset = "0xE7CE10", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600545C")]
	[Address(RVA = "0xE7E0F0", Offset = "0xE7CEF0", Length = "0xE6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600545D")]
	[Address(RVA = "0xE7E1E0", Offset = "0xE7CFE0", Length = "0x7A")]
	public int GetBaseChanceSuccess()
	{
		return 0;
	}

	[Token(Token = "0x600545E")]
	[Address(RVA = "0xE799E0", Offset = "0xE787E0", Length = "0xBE")]
	public float GetRepairTimeScale()
	{
		return 0f;
	}

	[Token(Token = "0x600545F")]
	[Address(RVA = "0xE7B530", Offset = "0xE7A330", Length = "0x91")]
	public float GetItemConditionScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005460")]
	[Address(RVA = "0xE7E260", Offset = "0xE7D060", Length = "0x1ED")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x6005461")]
	[Address(RVA = "0xE7E450", Offset = "0xE7D250", Length = "0x172")]
	public Skill_ToolRepair()
	{
	}
}
