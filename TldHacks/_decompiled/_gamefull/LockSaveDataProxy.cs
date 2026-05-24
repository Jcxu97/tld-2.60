using Cpp2ILInjected;

[Token(Token = "0x200042E")]
public class LockSaveDataProxy
{
	[Token(Token = "0x400258E")]
	[FieldOffset(Offset = "0x10")]
	public LockState m_LockStateProxy;

	[Token(Token = "0x400258F")]
	[FieldOffset(Offset = "0x14")]
	public bool m_AttemptedToOpen;

	[Token(Token = "0x6001F61")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LockSaveDataProxy()
	{
	}
}
