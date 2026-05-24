using Cpp2ILInjected;
using TLD.IntBackedUnit;

namespace TLD.Gear;

[Token(Token = "0x2001420")]
public interface ILiquidContainer
{
	[Token(Token = "0x17000B13")]
	LiquidType LiquidType
	{
		[Token(Token = "0x6008048")]
		get;
	}

	[Token(Token = "0x17000B14")]
	bool ShouldDestroyWhenEmpty
	{
		[Token(Token = "0x6008049")]
		get;
	}

	[Token(Token = "0x600804A")]
	ItemLiquidVolume GetVolumeLitres();

	[Token(Token = "0x600804B")]
	ItemLiquidVolume GetCapacityLitres();

	[Token(Token = "0x600804C")]
	float GetHeatPercent();

	[Token(Token = "0x600804D")]
	void SetHeatPercent(float heatPercent);

	[Token(Token = "0x600804E")]
	ItemLiquidVolume RemoveLiquid(ItemLiquidVolume volumeLitres, out float heatPercent);

	[Token(Token = "0x600804F")]
	ItemLiquidVolume AddLiquid(LiquidType type, ItemLiquidVolume volumeLitres, float heatPercent);
}
