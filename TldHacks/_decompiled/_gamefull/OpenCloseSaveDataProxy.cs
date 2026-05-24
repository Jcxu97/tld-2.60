using Cpp2ILInjected;

[Token(Token = "0x2000597")]
public class OpenCloseSaveDataProxy
{
	[Token(Token = "0x400337F")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x4003380")]
	[FieldOffset(Offset = "0x18")]
	public bool m_Open;

	[Token(Token = "0x4003381")]
	[FieldOffset(Offset = "0x20")]
	public string m_LockSerialized;

	[Token(Token = "0x4003382")]
	[FieldOffset(Offset = "0x28")]
	public string m_SafeSerialized;

	[Token(Token = "0x6002B21")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public OpenCloseSaveDataProxy()
	{
	}
}
