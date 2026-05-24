using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x20004DC")]
public class StackableItem : MonoBehaviour
{
	[Token(Token = "0x4002C5B")]
	[FieldOffset(Offset = "0x20")]
	public int m_Units;

	[SerializeField]
	[FormerlySerializedAs("m_UnitsPerItem")]
	[Token(Token = "0x4002C5C")]
	[FieldOffset(Offset = "0x24")]
	private int m_DefaultUnitsInItem;

	[Token(Token = "0x4002C5D")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedSingleUnitText;

	[Token(Token = "0x4002C5E")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_LocalizedMultipleUnitText;

	[Token(Token = "0x4002C5F")]
	[FieldOffset(Offset = "0x38")]
	public StackableItem[] m_ShareStackWithGear;

	[Token(Token = "0x4002C60")]
	[FieldOffset(Offset = "0x40")]
	public string m_StackSpriteName;

	[Tooltip("Specific gear item to create, instead of this item, when adding to the player's inventory.")]
	[Token(Token = "0x4002C61")]
	[FieldOffset(Offset = "0x48")]
	public GearItem m_InstantiateStackItem;

	[Tooltip("Only stack gear items with similar conditions within this percent constraint")]
	[Range(0f, 100f)]
	[Token(Token = "0x4002C62")]
	[FieldOffset(Offset = "0x50")]
	public float m_StackConditionDifferenceConstraint;

	[Token(Token = "0x4002C63")]
	private static readonly StackableItemSaveDataProxy m_StackableItemSaveDataProxy;

	[Token(Token = "0x1700024D")]
	public string SingleUnitText
	{
		[Token(Token = "0x60024F3")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024E")]
	public string MultipleUnitText
	{
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x74FF70", Offset = "0x74ED70", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700024F")]
	public int DefaultUnitsInItem
	{
		[Token(Token = "0x60024F5")]
		[Address(RVA = "0x4AA8A0", Offset = "0x4A96A0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000250")]
	public bool IsAStackOfItems
	{
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x8707B0", Offset = "0x86F5B0", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000251")]
	public float StackMultiplier
	{
		[Token(Token = "0x60024F7")]
		[Address(RVA = "0x8707C0", Offset = "0x86F5C0", Length = "0x15")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60024F8")]
	[Address(RVA = "0x8707E0", Offset = "0x86F5E0", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60024F9")]
	[Address(RVA = "0x8708C0", Offset = "0x86F6C0", Length = "0x8C")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60024FA")]
	[Address(RVA = "0x870950", Offset = "0x86F750", Length = "0xF5")]
	public StackableItem FindBestFitForUnits(int units)
	{
		return null;
	}

	[Token(Token = "0x60024FB")]
	[Address(RVA = "0x870A50", Offset = "0x86F850", Length = "0x3C0")]
	public StackableItem FindBestFitInShareStackForUnits(int units)
	{
		return null;
	}

	[Token(Token = "0x60024FC")]
	[Address(RVA = "0x870E20", Offset = "0x86FC20", Length = "0x251")]
	public static bool CanStackItems(GearItem gearStack, GearItem gearToAdd, float stackCondition)
	{
		return false;
	}

	[Token(Token = "0x60024FD")]
	[Address(RVA = "0x871080", Offset = "0x86FE80", Length = "0xBB1")]
	public static GearItem GetClosestMatchStackable(List<GearItemObject> gearObjects, GearItem gearToAdd, float stackCondition)
	{
		return null;
	}

	[Token(Token = "0x60024FE")]
	[Address(RVA = "0x871C40", Offset = "0x870A40", Length = "0x4A")]
	public StackableItem()
	{
	}
}
