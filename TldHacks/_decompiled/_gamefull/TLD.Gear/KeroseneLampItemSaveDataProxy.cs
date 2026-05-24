using Cpp2ILInjected;
using TLD.IntBackedUnit;

namespace TLD.Gear;

[Token(Token = "0x2001427")]
public class KeroseneLampItemSaveDataProxy
{
	[Token(Token = "0x40092FF")]
	[FieldOffset(Offset = "0x10")]
	public float m_HoursPlayed;

	[Token(Token = "0x4009300")]
	[FieldOffset(Offset = "0x18")]
	public ItemLiquidVolume m_CurrentFuelLitersProxy;

	[Token(Token = "0x4009301")]
	[FieldOffset(Offset = "0x20")]
	public bool m_OnProxy;

	[Token(Token = "0x600808E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public KeroseneLampItemSaveDataProxy()
	{
	}
}
