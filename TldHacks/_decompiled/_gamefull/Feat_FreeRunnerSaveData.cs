using Cpp2ILInjected;

[Token(Token = "0x2000347")]
public class Feat_FreeRunnerSaveData
{
	[Token(Token = "0x4001D1E")]
	[FieldOffset(Offset = "0x10")]
	public float m_ElapsedKilometers;

	[Token(Token = "0x4001D1F")]
	[FieldOffset(Offset = "0x14")]
	public float m_MetersAccumulator;

	[Token(Token = "0x6001ADA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Feat_FreeRunnerSaveData()
	{
	}
}
