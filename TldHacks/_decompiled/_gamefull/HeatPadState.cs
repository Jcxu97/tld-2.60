using Cpp2ILInjected;

[Token(Token = "0x20004AF")]
public class HeatPadState
{
	[Token(Token = "0x4002B4F")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Activated;

	[Token(Token = "0x4002B50")]
	[FieldOffset(Offset = "0x14")]
	public float m_HoursElapsed;

	[Token(Token = "0x60023DD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HeatPadState()
	{
	}
}
