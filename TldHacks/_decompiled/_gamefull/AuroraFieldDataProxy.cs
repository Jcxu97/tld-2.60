using Cpp2ILInjected;

[Token(Token = "0x20001C0")]
public class AuroraFieldDataProxy
{
	[Token(Token = "0x4000F4D")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsActive;

	[Token(Token = "0x4000F4E")]
	[FieldOffset(Offset = "0x11")]
	public bool m_CanRollChance;

	[Token(Token = "0x6001025")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public AuroraFieldDataProxy()
	{
	}
}
