using Cpp2ILInjected;

[Token(Token = "0x200018C")]
public class WolfDenSaveDataProxy
{
	[Token(Token = "0x4000E64")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsDestroyed;

	[Token(Token = "0x6000F12")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WolfDenSaveDataProxy()
	{
	}
}
