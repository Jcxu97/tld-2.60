using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x20004B7")]
public class LiquidItem : MonoBehaviour, ILiquidContainer
{
	[SerializeField]
	[Token(Token = "0x4002B73")]
	[FieldOffset(Offset = "0x20")]
	private LiquidType m_LiquidType;

	[Token(Token = "0x4002B74")]
	[FieldOffset(Offset = "0x28")]
	public ItemLiquidVolume m_Liquid;

	[Token(Token = "0x4002B75")]
	[FieldOffset(Offset = "0x30")]
	public ItemLiquidVolume m_LiquidCapacity;

	[SerializeField]
	[Token(Token = "0x4002B76")]
	[FieldOffset(Offset = "0x38")]
	private ItemLiquidVolume m_Minimum;

	[SerializeField]
	[Token(Token = "0x4002B77")]
	[FieldOffset(Offset = "0x40")]
	private ItemLiquidVolume m_Maximum;

	[Token(Token = "0x4002B78")]
	[FieldOffset(Offset = "0x48")]
	public ItemLiquidVolume m_AmountPerUseVolume;

	[Token(Token = "0x4002B79")]
	private static readonly LiquidItemSaveDataProxy m_LiquidItemSaveDataProxy;

	[Token(Token = "0x17000244")]
	public LiquidType LiquidType
	{
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000245")]
	public bool ShouldDestroyWhenEmpty
	{
		[Token(Token = "0x600240A")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000246")]
	public LiquidQuality LiquidQuality
	{
		[Token(Token = "0x600240B")]
		[Address(RVA = "0x860A90", Offset = "0x85F890", Length = "0xF0")]
		get
		{
			return default(LiquidQuality);
		}
	}

	[Token(Token = "0x600240C")]
	[Address(RVA = "0x860B90", Offset = "0x85F990", Length = "0x72")]
	public void Awake()
	{
	}

	[Token(Token = "0x600240D")]
	[Address(RVA = "0x860C10", Offset = "0x85FA10", Length = "0x112")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600240E")]
	[Address(RVA = "0x860D30", Offset = "0x85FB30", Length = "0xDD")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600240F")]
	[Address(RVA = "0x860E10", Offset = "0x85FC10", Length = "0x292")]
	private bool IsWaterBottle()
	{
		return false;
	}

	[Token(Token = "0x6002410")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public ItemLiquidVolume GetVolumeLitres()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6002411")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	public ItemLiquidVolume GetCapacityLitres()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6002412")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	public float GetHeatPercent()
	{
		return 0f;
	}

	[Token(Token = "0x6002413")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void SetHeatPercent(float _)
	{
	}

	[Token(Token = "0x6002414")]
	[Address(RVA = "0x8610B0", Offset = "0x85FEB0", Length = "0xBA")]
	public ItemLiquidVolume RemoveLiquid(ItemLiquidVolume volumeLitres, out float heatPercent)
	{
		heatPercent = default(float);
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6002415")]
	[Address(RVA = "0x861170", Offset = "0x85FF70", Length = "0x1D2")]
	public ItemLiquidVolume AddLiquid(LiquidType type, ItemLiquidVolume volumeLitres, float _)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6002416")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LiquidItem()
	{
	}
}
