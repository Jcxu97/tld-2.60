using Cpp2ILInjected;

[Token(Token = "0x2000966")]
public class SteamPipeValveSocketSaveDataProxy
{
	[Token(Token = "0x40061CE")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x40061CF")]
	[FieldOffset(Offset = "0x18")]
	public bool m_SteamPipeValveActive;

	[Token(Token = "0x60054F2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SteamPipeValveSocketSaveDataProxy()
	{
	}
}
