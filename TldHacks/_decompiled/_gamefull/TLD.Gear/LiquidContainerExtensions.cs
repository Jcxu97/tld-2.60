using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using TLD.IntBackedUnit;

namespace TLD.Gear;

[Token(Token = "0x2001421")]
public static class LiquidContainerExtensions
{
	[Token(Token = "0x40092E5")]
	private const string LineSectionSeparator = "========";

	[Token(Token = "0x40092E6")]
	public static bool s_ShowDebug;

	[Token(Token = "0x6008050")]
	[Address(RVA = "0x1206060", Offset = "0x1204E60", Length = "0x14F")]
	public static ItemLiquidVolume TransferTo(this ILiquidContainer source, ILiquidContainer target, ItemLiquidVolume volumeLitres)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6008051")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public static string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x6008052")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void AppendDebugText(StringBuilder builder)
	{
	}

	[Token(Token = "0x6008053")]
	[Address(RVA = "0x12061B0", Offset = "0x1204FB0", Length = "0xA19")]
	private static void AppendLiquidContainerGearFromList(StringBuilder builder, List<GearItem> gearItems)
	{
	}

	[Token(Token = "0x6008054")]
	[Address(RVA = "0x1206BD0", Offset = "0x12059D0", Length = "0x12C")]
	private static string GetLiquidNameSafe(LiquidType liquidType)
	{
		return null;
	}
}
