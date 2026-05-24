using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Token(Token = "0x20005C0")]
public class WaterSourceSaveDataProxy
{
	[Token(Token = "0x4003519")]
	[FieldOffset(Offset = "0x10")]
	public ItemLiquidVolume m_CurrentLiters;

	[Token(Token = "0x400351A")]
	[FieldOffset(Offset = "0x18")]
	public LiquidQuality m_CurrentLiquidQuality;

	[Token(Token = "0x400351B")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_RolledSpawnChance;

	[Token(Token = "0x6002C7B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WaterSourceSaveDataProxy()
	{
	}
}
