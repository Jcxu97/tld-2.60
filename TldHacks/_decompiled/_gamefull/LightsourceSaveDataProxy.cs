using Cpp2ILInjected;

[Token(Token = "0x2000591")]
public class LightsourceSaveDataProxy
{
	[Token(Token = "0x4003352")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x4003353")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsOn;

	[Token(Token = "0x6002AF5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LightsourceSaveDataProxy()
	{
	}
}
