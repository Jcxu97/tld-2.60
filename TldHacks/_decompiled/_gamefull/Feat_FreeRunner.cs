using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000348")]
public class Feat_FreeRunner : Feat
{
	[Header("Tuning")]
	[Range(1f, 500f)]
	[Token(Token = "0x4001D20")]
	[FieldOffset(Offset = "0x68")]
	public int m_NumKilometersRequired;

	[Range(1f, 100f)]
	[Token(Token = "0x4001D21")]
	[FieldOffset(Offset = "0x6C")]
	public int m_CalorieReductionBenefit;

	[Token(Token = "0x4001D22")]
	private static float m_ElapsedKilometers;

	[Token(Token = "0x4001D23")]
	private static float m_MetersAccumulator;

	[Token(Token = "0x4001D24")]
	private static Feat_FreeRunnerSaveData m_Feat_FreeRunnerSaveData;

	[Token(Token = "0x6001ADB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001ADC")]
	[Address(RVA = "0x7551A0", Offset = "0x753FA0", Length = "0x105")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001ADD")]
	[Address(RVA = "0x7552B0", Offset = "0x7540B0", Length = "0xDB")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001ADE")]
	[Address(RVA = "0x755390", Offset = "0x754190", Length = "0x101")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001ADF")]
	[Address(RVA = "0x7534C0", Offset = "0x7522C0", Length = "0x66")]
	public float GetSprintCalorieBurnScale()
	{
		return 0f;
	}

	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x7554A0", Offset = "0x7542A0", Length = "0x15D")]
	public void IncrementMeters(float meters)
	{
	}

	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0x755600", Offset = "0x754400", Length = "0x2CC")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x7558D0", Offset = "0x7546D0", Length = "0x267")]
	public override string GetShortDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AE3")]
	[Address(RVA = "0x755B40", Offset = "0x754940", Length = "0xD9")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AE4")]
	[Address(RVA = "0x755C20", Offset = "0x754A20", Length = "0xAC")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x755CD0", Offset = "0x754AD0", Length = "0x87")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x755D60", Offset = "0x754B60", Length = "0x134")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Feat_FreeRunner()
	{
	}
}
