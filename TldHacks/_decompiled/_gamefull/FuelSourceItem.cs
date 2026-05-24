using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000496")]
public class FuelSourceItem : MonoBehaviour
{
	[Token(Token = "0x40029E0")]
	[FieldOffset(Offset = "0x20")]
	public float m_FireStartSkillModifier;

	[Token(Token = "0x40029E1")]
	[FieldOffset(Offset = "0x24")]
	public float m_FireStartDurationModifier;

	[Token(Token = "0x40029E2")]
	[FieldOffset(Offset = "0x28")]
	public float m_BurnDurationHours;

	[Token(Token = "0x40029E3")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HeatIncrease;

	[Token(Token = "0x40029E4")]
	[FieldOffset(Offset = "0x30")]
	public float m_HeatInnerRadius;

	[Token(Token = "0x40029E5")]
	[FieldOffset(Offset = "0x34")]
	public float m_HeatOuterRadius;

	[Token(Token = "0x40029E6")]
	[FieldOffset(Offset = "0x38")]
	public float m_FireAgeMinutesBeforeAdding;

	[Token(Token = "0x40029E7")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_IsTinder;

	[Token(Token = "0x40029E8")]
	[FieldOffset(Offset = "0x3D")]
	public bool m_IsWet;

	[Token(Token = "0x40029E9")]
	[FieldOffset(Offset = "0x3E")]
	public bool m_IsBurntInFireTracked;

	[Token(Token = "0x6002290")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x6002291")]
	[Address(RVA = "0x836850", Offset = "0x835650", Length = "0x14B")]
	public float GetModifiedBurnDurationHours(float normalizedCondition)
	{
		return 0f;
	}

	[Token(Token = "0x6002292")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FuelSourceItem()
	{
	}
}
