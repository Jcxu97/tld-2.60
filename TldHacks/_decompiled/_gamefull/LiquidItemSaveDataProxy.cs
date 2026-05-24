using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Token(Token = "0x20004B6")]
public class LiquidItemSaveDataProxy
{
	[Token(Token = "0x4002B71")]
	[FieldOffset(Offset = "0x10")]
	public ItemLiquidVolume m_LiquidLitersProxy;

	[Token(Token = "0x4002B72")]
	[FieldOffset(Offset = "0x18")]
	public LiquidQuality m_LiquidQuality;

	[Token(Token = "0x6002407")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LiquidItemSaveDataProxy()
	{
	}
}
