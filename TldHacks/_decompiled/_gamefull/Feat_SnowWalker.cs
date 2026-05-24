using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200034D")]
public class Feat_SnowWalker : Feat
{
	[Header("Tuning")]
	[Range(1f, 5000f)]
	[Token(Token = "0x4001D34")]
	[FieldOffset(Offset = "0x68")]
	public int m_NumKilometersRequired;

	[Range(1f, 100f)]
	[Token(Token = "0x4001D35")]
	[FieldOffset(Offset = "0x6C")]
	public int m_StaminaRechargeFasterPercent;

	[Token(Token = "0x4001D36")]
	private static float m_ElapsedKilometers;

	[Token(Token = "0x4001D37")]
	private static float m_MetersAccumulator;

	[Token(Token = "0x4001D38")]
	private static Feat_SnowWalkerSaveData m_Feat_SnowWalkerSaveData;

	[Token(Token = "0x6001B06")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B07")]
	[Address(RVA = "0x756A10", Offset = "0x755810", Length = "0x105")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001B08")]
	[Address(RVA = "0x756B20", Offset = "0x755920", Length = "0xDB")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001B09")]
	[Address(RVA = "0x756C00", Offset = "0x755A00", Length = "0x101")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001B0A")]
	[Address(RVA = "0x751C80", Offset = "0x750A80", Length = "0x40")]
	public float GetStaminaRechargeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6001B0B")]
	[Address(RVA = "0x756D10", Offset = "0x755B10", Length = "0x15D")]
	public void IncrementMeters(float meters)
	{
	}

	[Token(Token = "0x6001B0C")]
	[Address(RVA = "0x756E70", Offset = "0x755C70", Length = "0x2CC")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001B0D")]
	[Address(RVA = "0x757140", Offset = "0x755F40", Length = "0x267")]
	public override string GetShortDescription()
	{
		return null;
	}

	[Token(Token = "0x6001B0E")]
	[Address(RVA = "0x7573B0", Offset = "0x7561B0", Length = "0xD9")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[Token(Token = "0x6001B0F")]
	[Address(RVA = "0x757490", Offset = "0x756290", Length = "0xAC")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001B10")]
	[Address(RVA = "0x757540", Offset = "0x756340", Length = "0x87")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001B11")]
	[Address(RVA = "0x7575D0", Offset = "0x7563D0", Length = "0x134")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001B12")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Feat_SnowWalker()
	{
	}
}
