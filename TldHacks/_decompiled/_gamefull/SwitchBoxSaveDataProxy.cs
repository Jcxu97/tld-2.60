using Cpp2ILInjected;

[Token(Token = "0x20005B6")]
public class SwitchBoxSaveDataProxy
{
	[Token(Token = "0x40034C4")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x40034C5")]
	[FieldOffset(Offset = "0x18")]
	public SwitchToggleState m_SwitchToggleState;

	[Token(Token = "0x40034C6")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_IsLocked;

	[Token(Token = "0x6002C31")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SwitchBoxSaveDataProxy()
	{
	}
}
