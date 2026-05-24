using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x200028B")]
public class ClothingDamageEvent : StruggleDamageEvent
{
	[Token(Token = "0x4001712")]
	[FieldOffset(Offset = "0x58")]
	public float m_RipClothingDamageMin;

	[Token(Token = "0x4001713")]
	[FieldOffset(Offset = "0x5C")]
	public float m_RipClothingDamageMax;

	[Token(Token = "0x60015FB")]
	[Address(RVA = "0x6AE260", Offset = "0x6AD060", Length = "0x2A9")]
	public override void OnExecute(BaseAi instigator)
	{
	}

	[Token(Token = "0x60015FC")]
	[Address(RVA = "0x6AE510", Offset = "0x6AD310", Length = "0x19D")]
	public override bool IsLocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60015FD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ClothingDamageEvent()
	{
	}
}
