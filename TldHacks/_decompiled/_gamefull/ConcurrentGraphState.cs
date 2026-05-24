using Cpp2ILInjected;
using NodeCanvas.Framework;

[Token(Token = "0x200082D")]
public class ConcurrentGraphState
{
	[Token(Token = "0x40055C7")]
	[FieldOffset(Offset = "0x10")]
	public GraphOwner m_GraphOwner;

	[Token(Token = "0x40055C8")]
	[FieldOffset(Offset = "0x18")]
	public string m_GraphId;

	[Token(Token = "0x40055C9")]
	[FieldOffset(Offset = "0x20")]
	public string m_StateId;

	[Token(Token = "0x40055CA")]
	[FieldOffset(Offset = "0x28")]
	public string m_SerializedBlackboard;

	[Token(Token = "0x40055CB")]
	[FieldOffset(Offset = "0x30")]
	public string m_SerializedGlobalBlackboard;

	[Token(Token = "0x6004BD3")]
	[Address(RVA = "0xD5BEA0", Offset = "0xD5ACA0", Length = "0x62")]
	public ConcurrentGraphState()
	{
	}
}
