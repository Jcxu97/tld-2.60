using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200033D")]
public class Feat_BookSmarts : Feat
{
	[Header("Tuning")]
	[Range(1f, 1000f)]
	[Token(Token = "0x4001D00")]
	[FieldOffset(Offset = "0x68")]
	public int m_NumHoursRequired;

	[Range(0f, 100f)]
	[Token(Token = "0x4001D01")]
	[FieldOffset(Offset = "0x6C")]
	public int m_PercentBenefit;

	[Token(Token = "0x4001D02")]
	private static int m_ElapsedHours;

	[Token(Token = "0x4001D03")]
	private static Feat_BookSmartsSaveData m_Feat_BookSmartsSaveData;

	[Token(Token = "0x6001A87")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001A88")]
	[Address(RVA = "0x751A10", Offset = "0x750810", Length = "0xE4")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001A89")]
	[Address(RVA = "0x751B00", Offset = "0x750900", Length = "0xB6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001A8A")]
	[Address(RVA = "0x751BC0", Offset = "0x7509C0", Length = "0xBA")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001A8B")]
	[Address(RVA = "0x751C80", Offset = "0x750A80", Length = "0x40")]
	public float GetSkillPointsScale()
	{
		return 0f;
	}

	[Token(Token = "0x6001A8C")]
	[Address(RVA = "0x751CC0", Offset = "0x750AC0", Length = "0xE1")]
	public void IncrementHours(int hours)
	{
	}

	[Token(Token = "0x6001A8D")]
	[Address(RVA = "0x751DB0", Offset = "0x750BB0", Length = "0x112")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001A8E")]
	[Address(RVA = "0x751ED0", Offset = "0x750CD0", Length = "0xB2")]
	public override string GetShortDescription()
	{
		return null;
	}

	[Token(Token = "0x6001A8F")]
	[Address(RVA = "0x751F90", Offset = "0x750D90", Length = "0xD9")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[Token(Token = "0x6001A90")]
	[Address(RVA = "0x752070", Offset = "0x750E70", Length = "0x5B")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001A91")]
	[Address(RVA = "0x7520D0", Offset = "0x750ED0", Length = "0x8A")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001A92")]
	[Address(RVA = "0x752160", Offset = "0x750F60", Length = "0x16E")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Feat_BookSmarts()
	{
	}
}
