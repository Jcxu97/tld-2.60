using Cpp2ILInjected;

[Token(Token = "0x2000500")]
public class WellFedSaveDataProxy
{
	[Token(Token = "0x4002DCD")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002DCE")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHoursNotStarving;

	[Token(Token = "0x60025EC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WellFedSaveDataProxy()
	{
	}
}
