using Cpp2ILInjected;

[Token(Token = "0x200047F")]
public class EvolveItemSaveData
{
	[Token(Token = "0x40028C3")]
	[FieldOffset(Offset = "0x10")]
	public float m_HoursPlayed;

	[Token(Token = "0x40028C4")]
	[FieldOffset(Offset = "0x14")]
	public float m_TimeSpentEvolvingGameHours;

	[Token(Token = "0x40028C5")]
	[FieldOffset(Offset = "0x18")]
	public bool m_ForceNoAutoEvolve;

	[Token(Token = "0x60021F2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public EvolveItemSaveData()
	{
	}
}
