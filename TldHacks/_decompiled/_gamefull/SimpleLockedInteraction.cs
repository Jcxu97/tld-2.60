using Cpp2ILInjected;

[Token(Token = "0x2000573")]
public class SimpleLockedInteraction : LockedInteraction
{
	[Token(Token = "0x60029FA")]
	[Address(RVA = "0x8F7120", Offset = "0x8F5F20", Length = "0x30")]
	public override bool PerformHold()
	{
		return false;
	}

	[Token(Token = "0x60029FB")]
	[Address(RVA = "0x8F4D40", Offset = "0x8F3B40", Length = "0x7")]
	public SimpleLockedInteraction()
	{
	}
}
