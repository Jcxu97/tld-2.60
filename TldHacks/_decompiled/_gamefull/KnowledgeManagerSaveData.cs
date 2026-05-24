using Cpp2ILInjected;

[Token(Token = "0x200077F")]
public class KnowledgeManagerSaveData
{
	[Token(Token = "0x400506A")]
	[FieldOffset(Offset = "0x10")]
	public string m_TrustDictSerialized;

	[Token(Token = "0x400506B")]
	[FieldOffset(Offset = "0x18")]
	public string m_KnowledgeDictSerialized;

	[Token(Token = "0x400506C")]
	[FieldOffset(Offset = "0x20")]
	public string m_NameRefDictSerialized;

	[Token(Token = "0x400506D")]
	[FieldOffset(Offset = "0x28")]
	public bool m_SnowSheltersUnlockedInStory;

	[Token(Token = "0x6004652")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public KnowledgeManagerSaveData()
	{
	}
}
