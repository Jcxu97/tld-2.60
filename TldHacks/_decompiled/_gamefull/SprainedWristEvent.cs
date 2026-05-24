using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000286")]
public class SprainedWristEvent : StruggleDamageEvent
{
	[Token(Token = "0x60015ED")]
	[Address(RVA = "0x6AD830", Offset = "0x6AC630", Length = "0xAA")]
	protected override bool CanExecute()
	{
		return false;
	}

	[Token(Token = "0x60015EE")]
	[Address(RVA = "0x6AD8E0", Offset = "0x6AC6E0", Length = "0x121")]
	public override void OnExecute(BaseAi instigator)
	{
	}

	[Token(Token = "0x60015EF")]
	[Address(RVA = "0x6ADA10", Offset = "0x6AC810", Length = "0x85")]
	public override bool IsLocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60015F0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SprainedWristEvent()
	{
	}
}
