using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000285")]
public class SprainedAnkleEvent : StruggleDamageEvent
{
	[Token(Token = "0x60015E9")]
	[Address(RVA = "0x6AD610", Offset = "0x6AC410", Length = "0x7E")]
	protected override bool CanExecute()
	{
		return false;
	}

	[Token(Token = "0x60015EA")]
	[Address(RVA = "0x6AD690", Offset = "0x6AC490", Length = "0x102")]
	public override void OnExecute(BaseAi instigator)
	{
	}

	[Token(Token = "0x60015EB")]
	[Address(RVA = "0x6AD7A0", Offset = "0x6AC5A0", Length = "0x88")]
	public override bool IsLocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60015EC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SprainedAnkleEvent()
	{
	}
}
