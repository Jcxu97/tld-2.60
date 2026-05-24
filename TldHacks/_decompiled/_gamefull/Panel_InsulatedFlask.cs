using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200066A")]
public class Panel_InsulatedFlask : Panel_AutoReferenced
{
	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004027")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[Header("UI Setup")]
	[SerializeField]
	[Token(Token = "0x4004028")]
	[FieldOffset(Offset = "0x38")]
	private ContainerUI m_ContainerUI;

	[SerializeField]
	[Token(Token = "0x4004029")]
	[FieldOffset(Offset = "0x40")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[SerializeField]
	[Token(Token = "0x400402A")]
	[FieldOffset(Offset = "0x48")]
	private UILabel m_Label_CarryCapacity;

	[SerializeField]
	[Token(Token = "0x400402B")]
	[FieldOffset(Offset = "0x50")]
	private UISprite m_CapacityBarSprite;

	[SerializeField]
	[Token(Token = "0x400402C")]
	[FieldOffset(Offset = "0x58")]
	private UISprite m_CapacityBarOutline;

	[SerializeField]
	[Token(Token = "0x400402D")]
	[FieldOffset(Offset = "0x60")]
	private UILabel m_Label_ContainerCapacity;

	[SerializeField]
	[Token(Token = "0x400402E")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_SelectedSpriteGameObject;

	[SerializeField]
	[Token(Token = "0x400402F")]
	[FieldOffset(Offset = "0x70")]
	private UILabel m_NameplateLabel;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4004030")]
	[FieldOffset(Offset = "0x78")]
	private float m_AlphaUnselectedSide;

	[SerializeField]
	[Token(Token = "0x4004031")]
	[FieldOffset(Offset = "0x80")]
	private UIButton[] m_MoveAllToContainerButtons;

	[SerializeField]
	[Token(Token = "0x4004032")]
	[FieldOffset(Offset = "0x88")]
	private UIButton[] m_MoveAllToInventoryButtons;

	[Header("L10n")]
	[SerializeField]
	[Token(Token = "0x4004033")]
	[FieldOffset(Offset = "0x90")]
	private LocalizedString m_EmptyInventoryText;

	[SerializeField]
	[Token(Token = "0x4004034")]
	[FieldOffset(Offset = "0x98")]
	private LocalizedString m_EmptyFlaskText;

	[Token(Token = "0x4004035")]
	[FieldOffset(Offset = "0xA0")]
	private readonly List<GearItem> m_InventoryList;

	[Token(Token = "0x4004036")]
	[FieldOffset(Offset = "0xA8")]
	private readonly List<GearItem> m_InsulatedFlaskList;

	[Token(Token = "0x4004037")]
	[FieldOffset(Offset = "0xB0")]
	private int m_InventorySelectedItemIndexVal;

	[Token(Token = "0x4004038")]
	[FieldOffset(Offset = "0xB4")]
	private int m_InventoryNumItemsDisplayed;

	[Token(Token = "0x4004039")]
	[FieldOffset(Offset = "0xB8")]
	private int m_InventoryFirstItemDisplayedIndexVal;

	[Token(Token = "0x400403A")]
	[FieldOffset(Offset = "0xBC")]
	private int m_ContainerSelectedItemIndexVal;

	[Token(Token = "0x400403B")]
	[FieldOffset(Offset = "0xC0")]
	private int m_ContainerNumItemsDisplayed;

	[Token(Token = "0x400403C")]
	[FieldOffset(Offset = "0xC4")]
	private int m_ContainerFirstItemDisplayedIndexVal;

	[Token(Token = "0x400403D")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_ShouldResetSelectedItem;

	[Token(Token = "0x400403E")]
	[FieldOffset(Offset = "0xC9")]
	private bool m_ForceRefreshRequested;

	[Token(Token = "0x400403F")]
	[FieldOffset(Offset = "0xD0")]
	private InsulatedFlask m_InsulatedFlask;

	[Token(Token = "0x4004040")]
	[FieldOffset(Offset = "0xD8")]
	private DragDropItem m_DraggedItem;

	[Token(Token = "0x4004041")]
	[FieldOffset(Offset = "0xE0")]
	private int m_NumFramesPanelActive;

	[Token(Token = "0x170002F4")]
	[field: Token(Token = "0x4004042")]
	[field: FieldOffset(Offset = "0xE8")]
	public Action OnDisable
	{
		[Token(Token = "0x6003503")]
		[Address(RVA = "0x502630", Offset = "0x501430", Length = "0x8")]
		get;
		[Token(Token = "0x6003504")]
		[Address(RVA = "0xA73DF0", Offset = "0xA72BF0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x170002F5")]
	private SelectedTableEnum SelectedTable
	{
		[Token(Token = "0x6003505")]
		[Address(RVA = "0xA73E50", Offset = "0xA72C50", Length = "0x2F")]
		get
		{
			return default(SelectedTableEnum);
		}
		[Token(Token = "0x6003506")]
		[Address(RVA = "0xA73E80", Offset = "0xA72C80", Length = "0x69")]
		set
		{
		}
	}

	[Token(Token = "0x170002F6")]
	private int InventorySelectedItemIndex
	{
		[Token(Token = "0x6003507")]
		[Address(RVA = "0x5DEE90", Offset = "0x5DDC90", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003508")]
		[Address(RVA = "0xA73EF0", Offset = "0xA72CF0", Length = "0x6C")]
		set
		{
		}
	}

	[Token(Token = "0x170002F7")]
	private int InventoryFirstItemDisplayedIndex
	{
		[Token(Token = "0x6003509")]
		[Address(RVA = "0x5DD350", Offset = "0x5DC150", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600350A")]
		[Address(RVA = "0xA73F60", Offset = "0xA72D60", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x170002F8")]
	private int ContainerSelectedItemIndex
	{
		[Token(Token = "0x600350B")]
		[Address(RVA = "0xA73F80", Offset = "0xA72D80", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600350C")]
		[Address(RVA = "0xA73F90", Offset = "0xA72D90", Length = "0x6C")]
		set
		{
		}
	}

	[Token(Token = "0x170002F9")]
	private int ContainerFirstItemDisplayedIndex
	{
		[Token(Token = "0x600350D")]
		[Address(RVA = "0x7F92F0", Offset = "0x7F80F0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600350E")]
		[Address(RVA = "0xA74000", Offset = "0xA72E00", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x600350F")]
	[Address(RVA = "0x74C070", Offset = "0x74AE70", Length = "0x7")]
	public int GetNumFramesInPanel()
	{
		return 0;
	}

	[Token(Token = "0x6003510")]
	[Address(RVA = "0xA74020", Offset = "0xA72E20", Length = "0x40F")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003511")]
	[Address(RVA = "0xA74430", Offset = "0xA73230", Length = "0x653")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003512")]
	[Address(RVA = "0xA74A90", Offset = "0xA73890", Length = "0x182")]
	public void SetInsulatedFlask(InsulatedFlask flask)
	{
	}

	[Token(Token = "0x6003513")]
	[Address(RVA = "0xA74C20", Offset = "0xA73A20", Length = "0x102")]
	public void SelectGridItem(InventoryGridItem gridItem, bool isInContainer)
	{
	}

	[Token(Token = "0x6003514")]
	[Address(RVA = "0xA74D30", Offset = "0xA73B30", Length = "0x45D")]
	public void HoverItem(InventoryGridItem gridItem, string displayName, bool isOver, bool isContainerItem)
	{
	}

	[Token(Token = "0x6003515")]
	[Address(RVA = "0xA75190", Offset = "0xA73F90", Length = "0x118")]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[Token(Token = "0x6003516")]
	[Address(RVA = "0xA752B0", Offset = "0xA740B0", Length = "0x107")]
	public void OnDone()
	{
	}

	[Token(Token = "0x6003517")]
	[Address(RVA = "0xA753C0", Offset = "0xA741C0", Length = "0x3E")]
	public void OnMoveItem()
	{
	}

	[Token(Token = "0x6003518")]
	[Address(RVA = "0xA75400", Offset = "0xA74200", Length = "0x3B")]
	public void OnMoveAllItems()
	{
	}

	[Token(Token = "0x6003519")]
	[Address(RVA = "0xA75440", Offset = "0xA74240", Length = "0x3DE")]
	public void OnMoveAllToInventory()
	{
	}

	[Token(Token = "0x600351A")]
	[Address(RVA = "0xA75820", Offset = "0xA74620", Length = "0x3F6")]
	public void OnMoveAllToContainer()
	{
	}

	[Token(Token = "0x600351B")]
	[Address(RVA = "0xA75C20", Offset = "0xA74A20", Length = "0x11B")]
	public void DragInventoryToContainer()
	{
	}

	[Token(Token = "0x600351C")]
	[Address(RVA = "0xA75D40", Offset = "0xA74B40", Length = "0x11B")]
	public void DragContainerToInventory()
	{
	}

	[Token(Token = "0x600351D")]
	[Address(RVA = "0xA75E60", Offset = "0xA74C60", Length = "0x7A9")]
	private void Update()
	{
	}

	[Token(Token = "0x600351E")]
	[Address(RVA = "0xA76610", Offset = "0xA75410", Length = "0x16D")]
	private void UpdateAlpha()
	{
	}

	[Token(Token = "0x600351F")]
	[Address(RVA = "0xA76780", Offset = "0xA75580", Length = "0xB1B")]
	private void DeselectAllItems()
	{
	}

	[Token(Token = "0x6003520")]
	[Address(RVA = "0xA772A0", Offset = "0xA760A0", Length = "0x116")]
	private bool IsCompatibleDrink(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x6003521")]
	[Address(RVA = "0xA773C0", Offset = "0xA761C0", Length = "0x1BF")]
	private void OnInventoryScrollbarChanged()
	{
	}

	[Token(Token = "0x6003522")]
	[Address(RVA = "0xA77580", Offset = "0xA76380", Length = "0x189")]
	private void OnContainerScrollbarChanged()
	{
	}

	[Token(Token = "0x6003523")]
	[Address(RVA = "0xA77710", Offset = "0xA76510", Length = "0x2F8")]
	public void OnInventoryToContainer(bool cameFromDrag = false)
	{
	}

	[Token(Token = "0x6003524")]
	[Address(RVA = "0xA77A10", Offset = "0xA76810", Length = "0x2C1")]
	private void OnContainerToInventory(bool cameFromDrag = false)
	{
	}

	[Token(Token = "0x6003525")]
	[Address(RVA = "0xA77CE0", Offset = "0xA76AE0", Length = "0x2AB")]
	private void UpdateInsulatedFlaskList()
	{
	}

	[Token(Token = "0x6003526")]
	[Address(RVA = "0xA77F90", Offset = "0xA76D90", Length = "0x1A1")]
	private void UpdateInventoryList()
	{
	}

	[Token(Token = "0x6003527")]
	[Address(RVA = "0xA78140", Offset = "0xA76F40", Length = "0x38E")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003528")]
	[Address(RVA = "0xA784D0", Offset = "0xA772D0", Length = "0xDE")]
	private GearItem GetCurrentlySelectedGearItem()
	{
		return null;
	}

	[Token(Token = "0x6003529")]
	[Address(RVA = "0xA785B0", Offset = "0xA773B0", Length = "0x7C")]
	private void RefreshScrollBars()
	{
	}

	[Token(Token = "0x600352A")]
	[Address(RVA = "0xA78630", Offset = "0xA77430", Length = "0x382")]
	private void ShiftFocusToInventoryItem(GearItem gi)
	{
	}

	[Token(Token = "0x600352B")]
	[Address(RVA = "0xA789C0", Offset = "0xA777C0", Length = "0x372")]
	private void ShiftFocusToContainerItem(GearItem gi)
	{
	}

	[Token(Token = "0x600352C")]
	[Address(RVA = "0xA78D40", Offset = "0xA77B40", Length = "0x36B")]
	private void RefreshWeight()
	{
	}

	[Token(Token = "0x600352D")]
	[Address(RVA = "0xA790B0", Offset = "0xA77EB0", Length = "0x35C")]
	private int RefreshInventoryTable()
	{
		return 0;
	}

	[Token(Token = "0x600352E")]
	[Address(RVA = "0xA79410", Offset = "0xA78210", Length = "0x619")]
	private int RefreshContainerTable()
	{
		return 0;
	}

	[Token(Token = "0x600352F")]
	[Address(RVA = "0xA79A30", Offset = "0xA78830", Length = "0x364")]
	private void RefreshMoveAllButtons()
	{
	}

	[Token(Token = "0x6003530")]
	[Address(RVA = "0xA79DA0", Offset = "0xA78BA0", Length = "0x48")]
	private bool CanMoveAllToInventory()
	{
		return false;
	}

	[Token(Token = "0x6003531")]
	[Address(RVA = "0xA79DF0", Offset = "0xA78BF0", Length = "0x15F")]
	private bool CanMoveAllToFlask()
	{
		return false;
	}

	[Token(Token = "0x6003532")]
	[Address(RVA = "0xA79F50", Offset = "0xA78D50", Length = "0x91")]
	private void RefreshNoItemsLabel()
	{
	}

	[Token(Token = "0x6003533")]
	[Address(RVA = "0xA79FF0", Offset = "0xA78DF0", Length = "0x30F")]
	private void RefreshTables()
	{
	}

	[Token(Token = "0x6003534")]
	[Address(RVA = "0xA7A300", Offset = "0xA79100", Length = "0x99E")]
	private void UpdateDragDrop()
	{
	}

	[Token(Token = "0x6003535")]
	[Address(RVA = "0xA7ACA0", Offset = "0xA79AA0", Length = "0x1D1")]
	private void FinishDragDrop()
	{
	}

	[Token(Token = "0x6003536")]
	[Address(RVA = "0xA7AE80", Offset = "0xA79C80", Length = "0x1DF")]
	public Panel_InsulatedFlask()
	{
	}
}
