using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000344")]
public class Feat_ExpertTrapper : Feat
{
	[Header("Tuning")]
	[Range(1f, 500f)]
	[Token(Token = "0x4001D15")]
	[FieldOffset(Offset = "0x68")]
	public int m_NumSnaredRabbitsRequired;

	[Range(1f, 100f)]
	[Token(Token = "0x4001D16")]
	[FieldOffset(Offset = "0x6C")]
	public int m_ChanceIncreaseToCatchRabbitsPercent;

	[Token(Token = "0x4001D17")]
	private static int s_RabbitSnaredCount;

	[Token(Token = "0x4001D18")]
	private static Feat_ExpertTrapperSaveData m_Feat_ExpertTrapperSaveData;

	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0x753DC0", Offset = "0x752BC0", Length = "0xE4")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x753EB0", Offset = "0x752CB0", Length = "0xB6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001ABF")]
	[Address(RVA = "0x753F70", Offset = "0x752D70", Length = "0xBA")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x751C80", Offset = "0x750A80", Length = "0x40")]
	public float GetRabbitChanceCaughtModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x754030", Offset = "0x752E30", Length = "0xA9")]
	public void IncrementRabbitSnaredCount()
	{
	}

	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x7540E0", Offset = "0x752EE0", Length = "0x112")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x754200", Offset = "0x753000", Length = "0xB2")]
	public override string GetShortDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x7542C0", Offset = "0x7530C0", Length = "0xD9")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x7543A0", Offset = "0x7531A0", Length = "0x5B")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x754400", Offset = "0x753200", Length = "0x8A")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x754490", Offset = "0x753290", Length = "0x16E")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x754600", Offset = "0x753400", Length = "0x51")]
	public Feat_ExpertTrapper()
	{
	}
}
