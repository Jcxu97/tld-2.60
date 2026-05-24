using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay.Fishing;

[Token(Token = "0x20014C6")]
public class IceFishingSelectionRow : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40095F2")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_SelectedBackground;

	[SerializeField]
	[Token(Token = "0x40095F3")]
	[FieldOffset(Offset = "0x28")]
	private UITexture m_Sprite;

	[SerializeField]
	[Token(Token = "0x40095F4")]
	[FieldOffset(Offset = "0x30")]
	private UITexture m_NoSelectionSprite;

	[SerializeField]
	[Token(Token = "0x40095F5")]
	[FieldOffset(Offset = "0x38")]
	private UILabel m_Label;

	[SerializeField]
	[Token(Token = "0x40095F6")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_ButtonIncrease;

	[SerializeField]
	[Token(Token = "0x40095F7")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_ButtonDecrease;

	[Token(Token = "0x40095F8")]
	[FieldOffset(Offset = "0x50")]
	private List<GearItem> m_Items;

	[Token(Token = "0x40095F9")]
	[FieldOffset(Offset = "0x58")]
	private int m_SelectedIndex;

	[Token(Token = "0x17000B61")]
	public GearItem SelectedItem
	{
		[Token(Token = "0x6008305")]
		[Address(RVA = "0x12403C0", Offset = "0x123F1C0", Length = "0x68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008306")]
	[Address(RVA = "0x1240430", Offset = "0x123F230", Length = "0x67A")]
	public void RefreshRow(Predicate<GearItem> validationPredicate)
	{
	}

	[Token(Token = "0x6008307")]
	[Address(RVA = "0x1240AB0", Offset = "0x123F8B0", Length = "0xAC")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6008308")]
	[Address(RVA = "0x1240B60", Offset = "0x123F960", Length = "0xC")]
	public void DecreaseSelection()
	{
	}

	[Token(Token = "0x6008309")]
	[Address(RVA = "0x1240B70", Offset = "0x123F970", Length = "0xC")]
	public void IncreaseSelection()
	{
	}

	[Token(Token = "0x600830A")]
	[Address(RVA = "0x1240B80", Offset = "0x123F980", Length = "0x79")]
	private void ChangeSelectedGearItem(int indexChange)
	{
	}

	[Token(Token = "0x600830B")]
	[Address(RVA = "0x1240C00", Offset = "0x123FA00", Length = "0x3AD")]
	private void UpdateSelection()
	{
	}

	[Token(Token = "0x600830C")]
	[Address(RVA = "0x1240FB0", Offset = "0x123FDB0", Length = "0xE3")]
	public IceFishingSelectionRow()
	{
	}
}
