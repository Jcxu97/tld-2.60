using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001416")]
public class DrinkItem : MonoBehaviour, ILiquidContainer
{
	[SerializeField]
	[Token(Token = "0x40092AB")]
	[FieldOffset(Offset = "0x20")]
	private LiquidType m_LiquidType;

	[SerializeField]
	[Token(Token = "0x40092AC")]
	[FieldOffset(Offset = "0x28")]
	private GearItem m_GearItem;

	[SerializeField]
	[Token(Token = "0x40092AD")]
	[FieldOffset(Offset = "0x30")]
	private FoodItem m_FoodItem;

	[Token(Token = "0x17000AEE")]
	public LiquidType LiquidType
	{
		[Token(Token = "0x6007FFF")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AEF")]
	public bool ShouldDestroyWhenEmpty
	{
		[Token(Token = "0x6008000")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6008001")]
	[Address(RVA = "0x1201E00", Offset = "0x1200C00", Length = "0x1EC")]
	public ItemLiquidVolume GetVolumeLitres()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6008002")]
	[Address(RVA = "0x1201FF0", Offset = "0x1200DF0", Length = "0x1FF")]
	public ItemLiquidVolume GetCapacityLitres()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6008003")]
	[Address(RVA = "0x12021F0", Offset = "0x1200FF0", Length = "0xEE")]
	public float GetHeatPercent()
	{
		return 0f;
	}

	[Token(Token = "0x6008004")]
	[Address(RVA = "0x12022E0", Offset = "0x12010E0", Length = "0xED")]
	public void SetHeatPercent(float heatPercent)
	{
	}

	[Token(Token = "0x6008005")]
	[Address(RVA = "0x12023D0", Offset = "0x12011D0", Length = "0x3C5")]
	public ItemLiquidVolume AddLiquid(LiquidType type, ItemLiquidVolume volumeLitres, float heatPercent)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6008006")]
	[Address(RVA = "0x12027A0", Offset = "0x12015A0", Length = "0x151")]
	public ItemLiquidVolume RemoveLiquid(ItemLiquidVolume volumeLitres, out float heatPercent)
	{
		heatPercent = default(float);
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6008007")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DrinkItem()
	{
	}
}
