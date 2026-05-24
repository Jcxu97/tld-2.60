using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000942")]
public class Skill_ClothingRepair : Skill
{
	[Tooltip("These items will also be considered clothing when repairing (eg. bedrolls)")]
	[Token(Token = "0x4006053")]
	[FieldOffset(Offset = "0x68")]
	public GearItem[] m_ConsiderClothing;

	[Header("Tuning")]
	[Token(Token = "0x4006054")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_BaseSuccessChance;

	[Token(Token = "0x4006055")]
	[FieldOffset(Offset = "0x78")]
	public int[] m_RepairTimePercentDecrease;

	[Token(Token = "0x4006056")]
	[FieldOffset(Offset = "0x80")]
	public int[] m_ItemConditionPercentIncrease;

	[Token(Token = "0x4006057")]
	[FieldOffset(Offset = "0x88")]
	public int[] m_SewingToolDegradeDecrease;

	[Token(Token = "0x4006058")]
	private static Skill_ClothingRepairSaveData m_Skill_ClothingRepairSaveData;

	[Token(Token = "0x6005408")]
	[Address(RVA = "0xE7A030", Offset = "0xE78E30", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6005409")]
	[Address(RVA = "0xE7A110", Offset = "0xE78F10", Length = "0xE6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600540A")]
	[Address(RVA = "0xE7A200", Offset = "0xE79000", Length = "0x7A")]
	public int GetBaseChanceSuccess()
	{
		return 0;
	}

	[Token(Token = "0x600540B")]
	[Address(RVA = "0xE78DA0", Offset = "0xE77BA0", Length = "0xBE")]
	public float GetRepairTimeScale()
	{
		return 0f;
	}

	[Token(Token = "0x600540C")]
	[Address(RVA = "0xE7A280", Offset = "0xE79080", Length = "0x91")]
	public float GetItemConditionScale()
	{
		return 0f;
	}

	[Token(Token = "0x600540D")]
	[Address(RVA = "0xE78F20", Offset = "0xE77D20", Length = "0xBD")]
	public float GetSewingKitDegradeScale()
	{
		return 0f;
	}

	[Token(Token = "0x600540E")]
	[Address(RVA = "0xE7A320", Offset = "0xE79120", Length = "0x25C")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x600540F")]
	[Address(RVA = "0xE7A580", Offset = "0xE79380", Length = "0x1D2")]
	public Skill_ClothingRepair()
	{
	}
}
