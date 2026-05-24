using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x200026F")]
public class PlayerDamageEventProxy
{
	[Token(Token = "0x4001632")]
	[FieldOffset(Offset = "0x10")]
	public string m_IconName;

	[Token(Token = "0x4001633")]
	[FieldOffset(Offset = "0x18")]
	public string m_BackgroundName;

	[Token(Token = "0x4001634")]
	[FieldOffset(Offset = "0x20")]
	public string m_DamageType;

	[Token(Token = "0x4001635")]
	[FieldOffset(Offset = "0x28")]
	public string m_DamageName;

	[Token(Token = "0x4001636")]
	[FieldOffset(Offset = "0x30")]
	public float m_DisplayTime;

	[Token(Token = "0x4001637")]
	[FieldOffset(Offset = "0x34")]
	public float m_FadeOutTime;

	[Token(Token = "0x4001638")]
	[FieldOffset(Offset = "0x38")]
	public float m_TimeActive;

	[Token(Token = "0x4001639")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_FadeOut;

	[Token(Token = "0x6001551")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayerDamageEventProxy()
	{
	}
}
