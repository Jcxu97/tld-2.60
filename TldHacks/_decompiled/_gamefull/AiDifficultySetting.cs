using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200013E")]
public class AiDifficultySetting : MonoBehaviour
{
	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x20")]
	public AiDifficulty m_AiDifficulty;

	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x24")]
	public AiSubType m_AiSubType;

	[Header("Struggle")]
	[Range(0f, 10f)]
	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x28")]
	public float m_StruggleTapStrengthScale;

	[Range(0f, 10f)]
	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x2C")]
	public float m_StrugglePlayerDamageReceivedIntervalScale;

	[Range(0f, 10f)]
	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0x30")]
	public float m_StrugglePlayerDamageReceivedScale;

	[Range(0f, 10f)]
	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x34")]
	public float m_StrugglePlayerClothingDamageScale;

	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B5B")]
	[Address(RVA = "0x5D3CB0", Offset = "0x5D2AB0", Length = "0x47")]
	public float GetStruggleTapStrenthScale()
	{
		return 0f;
	}

	[Token(Token = "0x6000B5C")]
	[Address(RVA = "0x5D3D00", Offset = "0x5D2B00", Length = "0x47")]
	public float GetStrugglePlayerDamageReceivedIntervalScale()
	{
		return 0f;
	}

	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x5D3D50", Offset = "0x5D2B50", Length = "0x47")]
	public float GetStrugglePlayerClothingDamageScale()
	{
		return 0f;
	}

	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x5D3DA0", Offset = "0x5D2BA0", Length = "0x47")]
	public float GetStrugglePlayerDamageReceivedScale()
	{
		return 0f;
	}

	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AiDifficultySetting()
	{
	}
}
