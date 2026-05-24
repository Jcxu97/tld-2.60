using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Cooking;

[Token(Token = "0x20013F9")]
public class CookingToolPanelFilterButton : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4009214")]
	[FieldOffset(Offset = "0x20")]
	private List<AssetReferenceCookingPot> m_ValidTools;

	[SerializeField]
	[Token(Token = "0x4009215")]
	[FieldOffset(Offset = "0x28")]
	private LocalizedString m_FilterName;

	[Token(Token = "0x4009216")]
	[FieldOffset(Offset = "0x30")]
	private List<AsyncOperationHandle> m_ToolHandles;

	[Token(Token = "0x4009217")]
	[FieldOffset(Offset = "0x38")]
	private List<CookingPotItem> m_CookingPotItems;

	[Token(Token = "0x4009218")]
	[FieldOffset(Offset = "0x40")]
	private List<GearItemData> m_GearItemData;

	[Token(Token = "0x17000AE3")]
	public string FilterName
	{
		[Token(Token = "0x6007F59")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007F5A")]
	[Address(RVA = "0x11F30D0", Offset = "0x11F1ED0", Length = "0x71B")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6007F5B")]
	[Address(RVA = "0x11F37F0", Offset = "0x11F25F0", Length = "0x36F")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007F5C")]
	[Address(RVA = "0x11F3B60", Offset = "0x11F2960", Length = "0x80")]
	public CookingPotItem GetCookingPotItem()
	{
		return null;
	}

	[Token(Token = "0x6007F5D")]
	[Address(RVA = "0x11F3BF0", Offset = "0x11F29F0", Length = "0xE8")]
	public string GetCookingPotItemName()
	{
		return null;
	}

	[Token(Token = "0x6007F5E")]
	[Address(RVA = "0x11F3CE0", Offset = "0x11F2AE0", Length = "0x302")]
	public bool IsGearItemInFilter(GearItemData gearItemData)
	{
		return false;
	}

	[Token(Token = "0x6007F5F")]
	[Address(RVA = "0x11F3FF0", Offset = "0x11F2DF0", Length = "0x1C0")]
	public bool PassesFilter(CookableItem cookableItem)
	{
		return false;
	}

	[Token(Token = "0x6007F60")]
	[Address(RVA = "0x11F41C0", Offset = "0x11F2FC0", Length = "0x7E")]
	public bool IsValidFilter()
	{
		return false;
	}

	[Token(Token = "0x6007F61")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CookingToolPanelFilterButton()
	{
	}
}
