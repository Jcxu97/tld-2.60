using Cpp2ILInjected;

[Token(Token = "0x2000A34")]
public class ReplaceMaterialSaveDataProxy
{
	[Token(Token = "0x4006681")]
	[FieldOffset(Offset = "0x10")]
	public int m_NewMatIndex;

	[Token(Token = "0x4006682")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x6005915")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ReplaceMaterialSaveDataProxy()
	{
	}
}
