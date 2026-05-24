using Cpp2ILInjected;

[Token(Token = "0x2000665")]
public class LocationRevealQueueInfo
{
	[Token(Token = "0x4003FE1")]
	[FieldOffset(Offset = "0x10")]
	public string m_Text;

	[Token(Token = "0x4003FE2")]
	[FieldOffset(Offset = "0x18")]
	public string m_SubText;

	[Token(Token = "0x4003FE3")]
	[FieldOffset(Offset = "0x20")]
	public bool m_ShowNewLocation;

	[Token(Token = "0x60034CC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LocationRevealQueueInfo()
	{
	}
}
