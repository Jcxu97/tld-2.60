using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Token(Token = "0x2000511")]
public class DysenterySaveDataProxy
{
	[Token(Token = "0x4002E63")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002E64")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002E65")]
	[FieldOffset(Offset = "0x18")]
	public float m_DurationHours;

	[Token(Token = "0x4002E66")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_AntibioticsTaken;

	[Token(Token = "0x4002E67")]
	[FieldOffset(Offset = "0x20")]
	public float m_ElapsedRest;

	[Token(Token = "0x4002E68")]
	[FieldOffset(Offset = "0x28")]
	public ItemLiquidVolume m_CleanWaterConsumedLiters;

	[Token(Token = "0x6002676")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DysenterySaveDataProxy()
	{
	}
}
