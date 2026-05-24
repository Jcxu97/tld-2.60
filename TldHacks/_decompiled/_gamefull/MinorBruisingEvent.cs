using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000287")]
public class MinorBruisingEvent : StruggleDamageEvent
{
	[Token(Token = "0x400170D")]
	[FieldOffset(Offset = "0x58")]
	public float m_DamageMin;

	[Token(Token = "0x400170E")]
	[FieldOffset(Offset = "0x5C")]
	public float m_DamageMax;

	[Token(Token = "0x60015F1")]
	[Address(RVA = "0x6ADAA0", Offset = "0x6AC8A0", Length = "0xBD")]
	public override void OnExecute(BaseAi instigator)
	{
	}

	[Token(Token = "0x60015F2")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public override bool IsLocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60015F3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public MinorBruisingEvent()
	{
	}
}
