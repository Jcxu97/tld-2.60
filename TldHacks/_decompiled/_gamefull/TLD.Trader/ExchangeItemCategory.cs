using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Trader;

[CreateAssetMenu(menuName = "The Long Dark/Trader/Exchange Item Category")]
[Token(Token = "0x20013AA")]
public class ExchangeItemCategory : ScriptableObject
{
	[Token(Token = "0x4009029")]
	[FieldOffset(Offset = "0x18")]
	public LocalizedString m_CategoryName;

	[Token(Token = "0x400902A")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D m_CategoryIcon;

	[Token(Token = "0x400902B")]
	[FieldOffset(Offset = "0x28")]
	public List<AssetReferenceGearItemData> m_AllowedItems;

	[NonSerialized]
	[Token(Token = "0x400902C")]
	[FieldOffset(Offset = "0x30")]
	private AsyncOperationHandle<IList<GearItemData>> m_AllowedItemsHandle;

	[Token(Token = "0x6007DB4")]
	[Address(RVA = "0x11CDFE0", Offset = "0x11CCDE0", Length = "0x157")]
	public bool IsValidInCurrentGamemode()
	{
		return false;
	}

	[Token(Token = "0x6007DB5")]
	[Address(RVA = "0x11CE140", Offset = "0x11CCF40", Length = "0x280")]
	public bool IsMatchingType(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x6007DB6")]
	[Address(RVA = "0x11CE3D0", Offset = "0x11CD1D0", Length = "0x14F")]
	private IList<GearItemData> GetAllowedItems()
	{
		return null;
	}

	[Token(Token = "0x6007DB7")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ExchangeItemCategory()
	{
	}
}
