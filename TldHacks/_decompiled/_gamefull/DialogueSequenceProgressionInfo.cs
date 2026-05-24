using Cpp2ILInjected;

[Token(Token = "0x2000791")]
public class DialogueSequenceProgressionInfo
{
	[Token(Token = "0x40050EF")]
	[FieldOffset(Offset = "0x10")]
	public string m_UniqueId;

	[Token(Token = "0x40050F0")]
	[FieldOffset(Offset = "0x18")]
	public int m_CurrentProgressionIndex;

	[Token(Token = "0x60046B2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DialogueSequenceProgressionInfo()
	{
	}
}
