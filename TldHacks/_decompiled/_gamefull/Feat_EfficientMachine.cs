using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000342")]
public class Feat_EfficientMachine : Feat
{
	[Header("Tuning")]
	[Range(1f, 500f)]
	[Token(Token = "0x4001D0F")]
	[FieldOffset(Offset = "0x68")]
	public int m_NumDaysRequired;

	[Range(1f, 100f)]
	[Token(Token = "0x4001D10")]
	[FieldOffset(Offset = "0x6C")]
	public int m_CalorieReductionBenefit;

	[Token(Token = "0x4001D11")]
	private static float m_ElapsedHours;

	[Token(Token = "0x4001D12")]
	private static float m_HoursAccumulator;

	[Token(Token = "0x4001D13")]
	private static Feat_EfficientMachineSaveData m_Feat_EfficientMachineSaveData;

	[Token(Token = "0x6001AAE")]
	[Address(RVA = "0x7531C0", Offset = "0x751FC0", Length = "0x105")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001AAF")]
	[Address(RVA = "0x7532D0", Offset = "0x7520D0", Length = "0xDB")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001AB0")]
	[Address(RVA = "0x7533B0", Offset = "0x7521B0", Length = "0x101")]
	public void ValidateSaveData(string text)
	{
	}

	[Token(Token = "0x6001AB1")]
	[Address(RVA = "0x7534C0", Offset = "0x7522C0", Length = "0x66")]
	public float ReduceCaloriesScale()
	{
		return 0f;
	}

	[Token(Token = "0x6001AB2")]
	[Address(RVA = "0x753530", Offset = "0x752330", Length = "0x17B")]
	public void IncrementElapsedHours(float hours)
	{
	}

	[Token(Token = "0x6001AB3")]
	[Address(RVA = "0x7536B0", Offset = "0x7524B0", Length = "0x112")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AB4")]
	[Address(RVA = "0x7537D0", Offset = "0x7525D0", Length = "0xB2")]
	public override string GetShortDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AB5")]
	[Address(RVA = "0x753890", Offset = "0x752690", Length = "0xD9")]
	public override string GetBonusDescription()
	{
		return null;
	}

	[Token(Token = "0x6001AB6")]
	[Address(RVA = "0x753970", Offset = "0x752770", Length = "0x107")]
	public override bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001AB7")]
	[Address(RVA = "0x753A80", Offset = "0x752880", Length = "0xE5")]
	public override float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001AB8")]
	[Address(RVA = "0x753B70", Offset = "0x752970", Length = "0x18A")]
	public override void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001AB9")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Feat_EfficientMachine()
	{
	}
}
