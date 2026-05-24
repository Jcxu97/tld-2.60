using Cpp2ILInjected;

[Token(Token = "0x200033F")]
public class Feat_ColdFusionSaveData
{
	[Token(Token = "0x4001D06")]
	[FieldOffset(Offset = "0x10")]
	public float m_ElapsedDays;

	[Token(Token = "0x4001D07")]
	[FieldOffset(Offset = "0x14")]
	public float m_HoursAccumulator;

	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Feat_ColdFusionSaveData()
	{
	}
}
