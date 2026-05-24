using Cpp2ILInjected;

[Token(Token = "0x200095D")]
public class SteamPipeSaveDataProxy
{
	[Token(Token = "0x400615F")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x4006160")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsFrozen;

	[Token(Token = "0x60054AF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SteamPipeSaveDataProxy()
	{
	}
}
