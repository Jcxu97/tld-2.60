using Cpp2ILInjected;

[Token(Token = "0x2000170")]
public class FlyoverDataProxy
{
	[Token(Token = "0x4000D60")]
	[FieldOffset(Offset = "0x10")]
	public float m_SecondsSinceLastFlyover;

	[Token(Token = "0x4000D61")]
	[FieldOffset(Offset = "0x14")]
	public float m_SecondsBetweenFlyovers;

	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FlyoverDataProxy()
	{
	}
}
