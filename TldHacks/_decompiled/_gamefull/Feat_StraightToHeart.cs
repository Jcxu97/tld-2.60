using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x200034F")]
public class Feat_StraightToHeart : Feat
{
	[Header("Tuning")]
	[Token(Token = "0x4001D3B")]
	[FieldOffset(Offset = "0x68")]
	public List<GearItemData> m_Items;

	[Range(1f, 5000f)]
	[Token(Token = "0x4001D3C")]
	[FieldOffset(Offset = "0x70")]
	public int m_ItemConsumedCountRequired;

	[Range(1f, 100f)]
	[Token(Token = "0x4001D3D")]
	[FieldOffset(Offset = "0x74")]
	public int m_EffectiveLengthIncreasePercent;

	[Token(Token = "0x4001D3E")]
	private static int s_ItemConsumedCount;

	[Token(Token = "0x4001D3F")]
	private static float s_ItemConsumedAccumulator;

	[Token(Token = "0x4001D40")]
	private static Feat_StraightToHeartSaveData m_Feat_StraightToHeartSaveData;

	[Token(Token = "0x6001B15")]
	[Address(RVA = "0x7577D0", Offset = "0x7565D0", Length = "0x105")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001B16")]
	[Address(RVA = "0x7578E0", Offset = "0x7566E0", Length = "0xD7")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001B17")]
	[Address(RVA = "0x7579C0", Offset = "0x7567C0", Length = "0xFA")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001B18")]
	[Address(RVA = "0x757AC0", Offset = "0x7568C0", Length = "0x63")]
	public float GetEffectiveLengthModifier(GearItem gi)
	{
		return 0f;
	}

	[Token(Token = "0x6001B19")]
	[Address(RVA = "0x757B30", Offset = "0x756930", Length = "0x13D")]
	public void IncrementItemConsumed(GearItem gi, float itemFraction)
	{
	}

	[Token(Token = "0x6001B1A")]
	[Address(RVA = "0x757C70", Offset = "0x756A70", Length = "0x112")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0x757D90", Offset = "0x756B90", Length = "0xB2")]
	public override string GetShortDescription()
	{
		return null;
	}

	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x757E50", Offset = "0x756C50", Length = "0xD9")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x757F30", Offset = "0x756D30", Length = "0x5B")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x757F90", Offset = "0x756D90", Length = "0x8F")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x758020", Offset = "0x756E20", Length = "0x16E")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x758190", Offset = "0x756F90", Length = "0x2EB")]
	private bool IsHeartItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6001B21")]
	[Address(RVA = "0x758480", Offset = "0x757280", Length = "0x51")]
	public Feat_StraightToHeart()
	{
	}
}
