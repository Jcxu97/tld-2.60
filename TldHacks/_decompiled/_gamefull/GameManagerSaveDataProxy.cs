using Cpp2ILInjected;

[Token(Token = "0x200074A")]
public class GameManagerSaveDataProxy
{
	[Token(Token = "0x4004D0F")]
	[FieldOffset(Offset = "0x10")]
	public bool m_BlockAbilityToRest;

	[Token(Token = "0x4004D10")]
	[FieldOffset(Offset = "0x18")]
	public string m_BlockedRestLocID;

	[Token(Token = "0x4004D11")]
	[FieldOffset(Offset = "0x20")]
	public string m_SceneTransitionDataSerialized;

	[Token(Token = "0x4004D12")]
	[FieldOffset(Offset = "0x28")]
	public string m_StartRegion;

	[Token(Token = "0x60041FE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public GameManagerSaveDataProxy()
	{
	}
}
