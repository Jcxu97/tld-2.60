using Cpp2ILInjected;

[Token(Token = "0x200034C")]
public class Feat_SnowWalkerSaveData
{
	[Token(Token = "0x4001D32")]
	[FieldOffset(Offset = "0x10")]
	public float m_ElapsedKilometers;

	[Token(Token = "0x4001D33")]
	[FieldOffset(Offset = "0x14")]
	public float m_MetersAccumulator;

	[Token(Token = "0x6001B05")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Feat_SnowWalkerSaveData()
	{
	}
}
