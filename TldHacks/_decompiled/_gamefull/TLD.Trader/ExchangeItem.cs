using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Trader;

[Serializable]
[Token(Token = "0x20013A9")]
public class ExchangeItem
{
	[Token(Token = "0x400901A")]
	[FieldOffset(Offset = "0x10")]
	public ExchangeItemType m_ExchangeItemType;

	[Token(Token = "0x400901B")]
	[FieldOffset(Offset = "0x18")]
	public AssetReferenceGearItemData m_GearItemData;

	[Token(Token = "0x400901C")]
	[FieldOffset(Offset = "0x20")]
	public AssetReferenceExchangeItemCategory m_ItemCategory;

	[Token(Token = "0x400901D")]
	[FieldOffset(Offset = "0x28")]
	public AssetReferencePowderType m_PowderType;

	[Token(Token = "0x400901E")]
	[FieldOffset(Offset = "0x30")]
	public AssetReferenceLiquidType m_LiquidType;

	[Min(1f)]
	[Token(Token = "0x400901F")]
	[FieldOffset(Offset = "0x38")]
	public int m_Amount;

	[Token(Token = "0x4009020")]
	[FieldOffset(Offset = "0x40")]
	public ItemWeight m_Weight;

	[Token(Token = "0x4009021")]
	[FieldOffset(Offset = "0x48")]
	public ItemLiquidVolume m_LiquidVolume;

	[Token(Token = "0x4009022")]
	[FieldOffset(Offset = "0x50")]
	public int m_ExchangedAmount;

	[Token(Token = "0x4009023")]
	[FieldOffset(Offset = "0x58")]
	public ItemWeight m_ExchangedWeight;

	[Token(Token = "0x4009024")]
	[FieldOffset(Offset = "0x60")]
	public ItemLiquidVolume m_ExchangedLiquidVolume;

	[Token(Token = "0x4009025")]
	[FieldOffset(Offset = "0x68")]
	private AsyncOperationHandle<GearItemData> m_GearItemDataHandle;

	[Token(Token = "0x4009026")]
	[FieldOffset(Offset = "0x80")]
	private AsyncOperationHandle<ExchangeItemCategory> m_CategoryHandle;

	[Token(Token = "0x4009027")]
	[FieldOffset(Offset = "0x98")]
	private AsyncOperationHandle<PowderType> m_PowderTypeHandle;

	[Token(Token = "0x4009028")]
	[FieldOffset(Offset = "0xB0")]
	private AsyncOperationHandle<LiquidType> m_LiquidTypeHandle;

	[Token(Token = "0x17000AAC")]
	private bool IsSpecificItem
	{
		[Token(Token = "0x6007D99")]
		[Address(RVA = "0x11CB3D0", Offset = "0x11CA1D0", Length = "0x11")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AAD")]
	private bool IsCategory
	{
		[Token(Token = "0x6007D9A")]
		[Address(RVA = "0x11CB3F0", Offset = "0x11CA1F0", Length = "0x12")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AAE")]
	private bool IsAmount
	{
		[Token(Token = "0x6007D9B")]
		[Address(RVA = "0xFB8400", Offset = "0xFB7200", Length = "0x11")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AAF")]
	public bool IsWeight
	{
		[Token(Token = "0x6007D9C")]
		[Address(RVA = "0x11CB410", Offset = "0x11CA210", Length = "0x17")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007D9D")]
	[Address(RVA = "0x11CB430", Offset = "0x11CA230", Length = "0x3E4")]
	~ExchangeItem()
	{
	}

	[Token(Token = "0x6007D9E")]
	[Address(RVA = "0x11CB820", Offset = "0x11CA620", Length = "0x251")]
	public bool IsValidInCurrentGamemode()
	{
		return false;
	}

	[Token(Token = "0x6007D9F")]
	[Address(RVA = "0x11CBA80", Offset = "0x11CA880", Length = "0x10F")]
	private bool IsGearItemValidInCurrentGamemode()
	{
		return false;
	}

	[Token(Token = "0x6007DA0")]
	[Address(RVA = "0x11CBB90", Offset = "0x11CA990", Length = "0x31A")]
	public Texture2D GetExchangeItemIcon()
	{
		return null;
	}

	[Token(Token = "0x6007DA1")]
	[Address(RVA = "0x11CBEB0", Offset = "0x11CACB0", Length = "0x2F7")]
	public string GetExchangeItemName()
	{
		return null;
	}

	[Token(Token = "0x6007DA2")]
	[Address(RVA = "0x11CC1B0", Offset = "0x11CAFB0", Length = "0x23E")]
	public string GetFormattedString(int multiplier)
	{
		return null;
	}

	[Token(Token = "0x6007DA3")]
	[Address(RVA = "0x11CC3F0", Offset = "0x11CB1F0", Length = "0x1B7")]
	public string GetFormattedStringWithExchanged()
	{
		return null;
	}

	[Token(Token = "0x6007DA4")]
	[Address(RVA = "0x11CC5B0", Offset = "0x11CB3B0", Length = "0xD7")]
	public bool HasAnyExchanges()
	{
		return false;
	}

	[Token(Token = "0x6007DA5")]
	[Address(RVA = "0x11CC690", Offset = "0x11CB490", Length = "0xD5")]
	public bool IsFullyExchanged()
	{
		return false;
	}

	[Token(Token = "0x6007DA6")]
	[Address(RVA = "0x11CC770", Offset = "0x11CB570", Length = "0x131")]
	public float CalculateExchangedRatio()
	{
		return 0f;
	}

	[Token(Token = "0x6007DA7")]
	[Address(RVA = "0x11CC8B0", Offset = "0x11CB6B0", Length = "0xE4")]
	private bool HasExchangeRequirement()
	{
		return false;
	}

	[Token(Token = "0x6007DA8")]
	[Address(RVA = "0x11CC9A0", Offset = "0x11CB7A0", Length = "0x64")]
	public void UpdateExchanged(List<GearItemObject> exchangedItems)
	{
	}

	[Token(Token = "0x6007DA9")]
	[Address(RVA = "0x11CCA10", Offset = "0x11CB810", Length = "0x2FC")]
	private int CalculateAmountExchanged(List<GearItemObject> exchangedItems)
	{
		return 0;
	}

	[Token(Token = "0x6007DAA")]
	[Address(RVA = "0x11CCD10", Offset = "0x11CBB10", Length = "0x2D9")]
	private ItemWeight CalculateWeightExchanged(List<GearItemObject> exchangedItems)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6007DAB")]
	[Address(RVA = "0x11CCFF0", Offset = "0x11CBDF0", Length = "0x400")]
	private ItemLiquidVolume CalculateLiquidExchanged(List<GearItemObject> exchangedItems)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6007DAC")]
	[Address(RVA = "0x11CD400", Offset = "0x11CC200", Length = "0x85D")]
	public bool IsMatchingType(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x6007DAD")]
	[Address(RVA = "0x11CDC60", Offset = "0x11CCA60", Length = "0x234")]
	public ExchangeItem CloneForActiveTrade(int numExchangesMultiplier)
	{
		return null;
	}

	[Token(Token = "0x6007DAE")]
	[Address(RVA = "0x11CDEA0", Offset = "0x11CCCA0", Length = "0x46")]
	private GearItemData GetGearItemDataIfValid()
	{
		return null;
	}

	[Token(Token = "0x6007DAF")]
	[Address(RVA = "0x11CDEF0", Offset = "0x11CCCF0", Length = "0x49")]
	private ExchangeItemCategory GetExchangeItemCategoryIfValid()
	{
		return null;
	}

	[Token(Token = "0x6007DB0")]
	[Address(RVA = "0x11CDF40", Offset = "0x11CCD40", Length = "0x49")]
	private PowderType GetPowderTypeIfValid()
	{
		return null;
	}

	[Token(Token = "0x6007DB1")]
	[Address(RVA = "0x11CDF90", Offset = "0x11CCD90", Length = "0x49")]
	private LiquidType GetLiquidTypeIfValid()
	{
		return null;
	}

	[Token(Token = "0x6007DB2")]
	[Address(RVA = "0x18D6510", Offset = "0x18D5310", Length = "0x15E")]
	private T GetLoadedAssetIfValid<T>(AssetReferenceT<T> reference, ref AsyncOperationHandle<T> handle) where T : ScriptableObject
	{
		return null;
	}

	[Token(Token = "0x6007DB3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ExchangeItem()
	{
	}
}
