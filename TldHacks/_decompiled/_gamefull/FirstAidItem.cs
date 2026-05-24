using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000482")]
public class FirstAidItem : MonoBehaviour
{
	[Token(Token = "0x40028DB")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedProgressBarMessage;

	[Token(Token = "0x40028DC")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedRemedyText;

	[Token(Token = "0x40028DD")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_LocalizedInspectModeUseText;

	[Token(Token = "0x40028DE")]
	[FieldOffset(Offset = "0x38")]
	public float m_HPIncrease;

	[Token(Token = "0x40028DF")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_ProvidesAntibiotics;

	[Token(Token = "0x40028E0")]
	[FieldOffset(Offset = "0x3D")]
	public bool m_KillsPain;

	[Token(Token = "0x40028E1")]
	[FieldOffset(Offset = "0x3E")]
	public bool m_AppliesBandage;

	[Token(Token = "0x40028E2")]
	[FieldOffset(Offset = "0x3F")]
	public bool m_AppliesSutures;

	[Token(Token = "0x40028E3")]
	[FieldOffset(Offset = "0x40")]
	public bool m_StabalizesSprains;

	[Token(Token = "0x40028E4")]
	[FieldOffset(Offset = "0x41")]
	public bool m_CleansWounds;

	[Token(Token = "0x40028E5")]
	[FieldOffset(Offset = "0x44")]
	public float m_TimeToUseSeconds;

	[Token(Token = "0x40028E6")]
	[FieldOffset(Offset = "0x48")]
	public string m_UseAudio;

	[Token(Token = "0x40028E7")]
	[FieldOffset(Offset = "0x50")]
	public int m_UnitsPerUse;

	[Token(Token = "0x40028E8")]
	[FieldOffset(Offset = "0x58")]
	private GearItem m_GearItem;

	[Token(Token = "0x6002205")]
	[Address(RVA = "0x825420", Offset = "0x824220", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002206")]
	[Address(RVA = "0x8254B0", Offset = "0x8242B0", Length = "0x1CC")]
	public float DeductHealing(float neededHP)
	{
		return 0f;
	}

	[Token(Token = "0x6002207")]
	[Address(RVA = "0x825680", Offset = "0x824480", Length = "0x5A")]
	private float GetRemainingHealing()
	{
		return 0f;
	}

	[Token(Token = "0x6002208")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FirstAidItem()
	{
	}
}
