using Cpp2ILInjected;

[Token(Token = "0x20004E4")]
public class TorchItemSaveDataProxy
{
	[Token(Token = "0x4002C9E")]
	[FieldOffset(Offset = "0x10")]
	public float m_HoursPlayed;

	[Token(Token = "0x4002C9F")]
	[FieldOffset(Offset = "0x14")]
	public TorchState m_StateProxy;

	[Token(Token = "0x4002CA0")]
	[FieldOffset(Offset = "0x18")]
	public float m_ElapsedBurnMinutesProxy;

	[Token(Token = "0x4002CA1")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_Thrown;

	[Token(Token = "0x6002513")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public TorchItemSaveDataProxy()
	{
	}
}
