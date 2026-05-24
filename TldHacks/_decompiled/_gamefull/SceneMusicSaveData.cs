using Cpp2ILInjected;

[Token(Token = "0x20007D4")]
public class SceneMusicSaveData
{
	[Token(Token = "0x400540B")]
	[FieldOffset(Offset = "0x10")]
	public bool m_HasBeenPlayed;

	[Token(Token = "0x400540C")]
	[FieldOffset(Offset = "0x11")]
	public bool m_SupressExploreMusic;

	[Token(Token = "0x6004A12")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SceneMusicSaveData()
	{
	}
}
