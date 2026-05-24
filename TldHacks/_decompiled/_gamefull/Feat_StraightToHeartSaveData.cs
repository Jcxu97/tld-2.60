using Cpp2ILInjected;

[Token(Token = "0x200034E")]
public class Feat_StraightToHeartSaveData
{
	[Token(Token = "0x4001D39")]
	[FieldOffset(Offset = "0x10")]
	public int m_ItemConsumedCount;

	[Token(Token = "0x4001D3A")]
	[FieldOffset(Offset = "0x14")]
	public float m_ItemConsumedAccumulator;

	[Token(Token = "0x6001B14")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Feat_StraightToHeartSaveData()
	{
	}
}
