using Cpp2ILInjected;

[Token(Token = "0x20005A8")]
public class RockCacheDataProxy
{
	[Token(Token = "0x4003446")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x4003447")]
	[FieldOffset(Offset = "0x18")]
	public string m_RegionName;

	[Token(Token = "0x4003448")]
	[FieldOffset(Offset = "0x20")]
	public string m_SceneName;

	[Token(Token = "0x4003449")]
	[FieldOffset(Offset = "0x28")]
	public bool m_UserPlaced;

	[Token(Token = "0x6002BD7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RockCacheDataProxy()
	{
	}
}
