using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x200028A")]
public class BloodLossEvent : MinorBruisingEvent
{
	[Token(Token = "0x4001711")]
	[FieldOffset(Offset = "0x60")]
	private RiskOfInfectionEvent m_RiskOfInfection;

	[Token(Token = "0x60015F8")]
	[Address(RVA = "0x6AE060", Offset = "0x6ACE60", Length = "0x107")]
	public override void OnExecute(BaseAi instigator)
	{
	}

	[Token(Token = "0x60015F9")]
	[Address(RVA = "0x6AE170", Offset = "0x6ACF70", Length = "0x57")]
	public override bool IsLocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60015FA")]
	[Address(RVA = "0x6AE1D0", Offset = "0x6ACFD0", Length = "0x87")]
	public BloodLossEvent()
	{
	}
}
