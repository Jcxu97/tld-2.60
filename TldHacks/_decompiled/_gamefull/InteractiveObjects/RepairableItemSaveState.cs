using Cpp2ILInjected;

namespace InteractiveObjects;

[Token(Token = "0x200131F")]
public class RepairableItemSaveState
{
	[Token(Token = "0x4008D57")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x4008D58")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsRepaired;

	[Token(Token = "0x6007A95")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RepairableItemSaveState()
	{
	}
}
