using Cpp2ILInjected;

[Token(Token = "0x2000506")]
public class CabinFeverSaveDataProxy
{
	[Token(Token = "0x4002E20")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002E21")]
	[FieldOffset(Offset = "0x11")]
	public bool m_RiskActive;

	[Token(Token = "0x4002E22")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002E23")]
	[FieldOffset(Offset = "0x18")]
	public float[] m_IndoorTimeTracked;

	[Token(Token = "0x4002E24")]
	[FieldOffset(Offset = "0x20")]
	public int m_HourLastFrame;

	[Token(Token = "0x4002E25")]
	[FieldOffset(Offset = "0x24")]
	public bool m_DoneHalloweenEventFix;

	[Token(Token = "0x6002622")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CabinFeverSaveDataProxy()
	{
	}
}
