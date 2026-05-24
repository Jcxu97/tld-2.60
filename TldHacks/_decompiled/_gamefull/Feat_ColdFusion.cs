using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000340")]
public class Feat_ColdFusion : Feat
{
	[Header("Tuning")]
	[Range(1f, 1000f)]
	[Token(Token = "0x4001D08")]
	[FieldOffset(Offset = "0x68")]
	public int m_NumDaysRequired;

	[Range(1f, 10f)]
	[Token(Token = "0x4001D09")]
	[FieldOffset(Offset = "0x6C")]
	public int m_TemperatureCelsiusBenefit;

	[Token(Token = "0x4001D0A")]
	private static float m_ElapsedDays;

	[Token(Token = "0x4001D0B")]
	private static float m_HoursAccumulator;

	[Token(Token = "0x4001D0C")]
	private static Feat_ColdFusionSaveData m_Feat_ColdFusionSaveData;

	[Token(Token = "0x6001A9F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x752700", Offset = "0x751500", Length = "0x105")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x752810", Offset = "0x751610", Length = "0xDB")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0x7528F0", Offset = "0x7516F0", Length = "0x101")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001AA3")]
	[Address(RVA = "0x752A00", Offset = "0x751800", Length = "0x25")]
	public int GetTemperatureCelsiusBonus()
	{
		return 0;
	}

	[Token(Token = "0x6001AA4")]
	[Address(RVA = "0x752A30", Offset = "0x751830", Length = "0x15D")]
	public void IncrementHours(float hours)
	{
	}

	[Token(Token = "0x6001AA5")]
	[Address(RVA = "0x752B90", Offset = "0x751990", Length = "0x12D")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AA6")]
	[Address(RVA = "0x752CC0", Offset = "0x751AC0", Length = "0xB2")]
	public override string GetShortDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AA7")]
	[Address(RVA = "0x752D80", Offset = "0x751B80", Length = "0xF4")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AA8")]
	[Address(RVA = "0x752E80", Offset = "0x751C80", Length = "0xAC")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x752F30", Offset = "0x751D30", Length = "0x87")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001AAA")]
	[Address(RVA = "0x752FC0", Offset = "0x751DC0", Length = "0x134")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Feat_ColdFusion()
	{
	}
}
