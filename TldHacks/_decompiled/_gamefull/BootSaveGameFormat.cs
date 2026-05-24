using Cpp2ILInjected;

[Token(Token = "0x200092F")]
public class BootSaveGameFormat
{
	[Token(Token = "0x4005F54")]
	[FieldOffset(Offset = "0x10")]
	public string m_SceneName;

	[Token(Token = "0x60053C4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BootSaveGameFormat()
	{
	}
}
