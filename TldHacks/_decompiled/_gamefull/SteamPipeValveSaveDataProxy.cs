using Cpp2ILInjected;

[Token(Token = "0x2000964")]
public class SteamPipeValveSaveDataProxy
{
	[Token(Token = "0x40061B4")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x40061B5")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsFrozen;

	[Token(Token = "0x40061B6")]
	[FieldOffset(Offset = "0x19")]
	public bool m_IsOpen;

	[Token(Token = "0x60054DE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SteamPipeValveSaveDataProxy()
	{
	}
}
