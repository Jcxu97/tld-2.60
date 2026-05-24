using Cpp2ILInjected;

[Token(Token = "0x20005AC")]
public class RopeAnchorPointSaveData
{
	[Token(Token = "0x4003478")]
	[FieldOffset(Offset = "0x10")]
	public bool m_RopeDeployed;

	[Token(Token = "0x4003479")]
	[FieldOffset(Offset = "0x11")]
	public bool m_RopeSnapped;

	[Token(Token = "0x400347A")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x6002BF2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RopeAnchorPointSaveData()
	{
	}
}
