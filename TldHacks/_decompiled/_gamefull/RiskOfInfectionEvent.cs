using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000284")]
public class RiskOfInfectionEvent : StruggleDamageEvent
{
	[Token(Token = "0x60015E6")]
	[Address(RVA = "0x6AD4D0", Offset = "0x6AC2D0", Length = "0xD4")]
	public override void OnExecute(BaseAi instigator)
	{
	}

	[Token(Token = "0x60015E7")]
	[Address(RVA = "0x6AD5B0", Offset = "0x6AC3B0", Length = "0x57")]
	public override bool IsLocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60015E8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RiskOfInfectionEvent()
	{
	}
}
