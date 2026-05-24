using Cpp2ILInjected;

[Token(Token = "0x20007ED")]
public class SteamPipeSaveData
{
	[Token(Token = "0x400549E")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x400549F")]
	[FieldOffset(Offset = "0x18")]
	public string m_SerializedData;

	[Token(Token = "0x6004AA7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SteamPipeSaveData()
	{
	}
}
