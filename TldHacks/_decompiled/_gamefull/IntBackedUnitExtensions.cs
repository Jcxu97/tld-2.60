using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Token(Token = "0x2000A12")]
public static class IntBackedUnitExtensions
{
	[Token(Token = "0x4006608")]
	private static readonly LocalizedString s_UnitKG;

	[Token(Token = "0x4006609")]
	private static readonly LocalizedString s_UnitLBS;

	[Token(Token = "0x400660A")]
	private static readonly LocalizedString s_UnitL;

	[Token(Token = "0x400660B")]
	private static readonly LocalizedString s_UnitGAL;

	[Token(Token = "0x400660C")]
	private static readonly LocalizedString s_UnitOZ;

	[Token(Token = "0x400660D")]
	private static readonly ItemLiquidVolume s_OuncesLimit;

	[Token(Token = "0x6005862")]
	[Address(RVA = "0xEE7570", Offset = "0xEE6370", Length = "0xF9")]
	public static string ToFormattedString(this ItemWeight itemWeight, uint decimalPlaces = 2u)
	{
		return null;
	}

	[Token(Token = "0x6005863")]
	[Address(RVA = "0xEE7670", Offset = "0xEE6470", Length = "0x163")]
	public static string ToFormattedStringWithUnits(this ItemWeight itemWeight, uint decimalPlaces = 2u)
	{
		return null;
	}

	[Token(Token = "0x6005864")]
	[Address(RVA = "0xEE77E0", Offset = "0xEE65E0", Length = "0x16B")]
	public static string ToFormattedString(this ItemLiquidVolume itemLiquidVolume, uint decimalPlaces = 2u)
	{
		return null;
	}

	[Token(Token = "0x6005865")]
	[Address(RVA = "0xEE7950", Offset = "0xEE6750", Length = "0xF9")]
	public static string ToFormattedStringNoOunces(this ItemLiquidVolume itemLiquidVolume, uint decimalPlaces = 2u)
	{
		return null;
	}

	[Token(Token = "0x6005866")]
	[Address(RVA = "0xEE7A50", Offset = "0xEE6850", Length = "0x1D1")]
	public static string ToFormattedStringWithUnits(this ItemLiquidVolume itemLiquidVolume, uint decimalPlaces = 2u)
	{
		return null;
	}

	[Token(Token = "0x6005867")]
	[Address(RVA = "0xEE7C30", Offset = "0xEE6A30", Length = "0x1BE")]
	public static string ToFormattedStringWithUnitsNoOunces(this ItemLiquidVolume itemLiquidVolume, uint decimalPlaces = 2u)
	{
		return null;
	}
}
