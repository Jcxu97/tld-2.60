using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005CE")]
public class ContainerUI : MonoBehaviour
{
	[Token(Token = "0x400358B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_ContainerTitle;

	[Token(Token = "0x400358C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_ContainerTableObject;

	[Token(Token = "0x400358D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_ContainerCapacityBarSprite;

	[Token(Token = "0x400358E")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_ContainerCapacityBarOutline;

	[Token(Token = "0x400358F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_ContainerScrollbarObject;

	[Token(Token = "0x4003590")]
	[FieldOffset(Offset = "0x48")]
	public GameObject[] m_DragDropContainers;

	[Token(Token = "0x4003591")]
	[FieldOffset(Offset = "0x50")]
	public int m_MaxItemsDisplayAtOnceContainer;

	[Token(Token = "0x4003592")]
	[FieldOffset(Offset = "0x54")]
	public int m_TableConNumColumns;

	[Token(Token = "0x4003593")]
	[FieldOffset(Offset = "0x58")]
	public float m_TableConSpacingHorizontal;

	[Token(Token = "0x4003594")]
	[FieldOffset(Offset = "0x5C")]
	public float m_TableConSpacingVertical;

	[Token(Token = "0x4003595")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_ContainerGridBackground;

	[Token(Token = "0x4003596")]
	[FieldOffset(Offset = "0x68")]
	public UIWidget m_ContainerSideWidget;

	[Token(Token = "0x4003597")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_LabelNoItemsContainer;

	[Header("Inventory")]
	[Token(Token = "0x4003598")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_InventoryTableObject;

	[Token(Token = "0x4003599")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_InventoryScrollbarObject;

	[Token(Token = "0x400359A")]
	[FieldOffset(Offset = "0x88")]
	public UIWidget m_InventorySideWidget;

	[Token(Token = "0x400359B")]
	[FieldOffset(Offset = "0x90")]
	public int m_MaxItemsDisplayAtOnceInventory;

	[Token(Token = "0x400359C")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_InventoryGridBackground;

	[Token(Token = "0x400359D")]
	[FieldOffset(Offset = "0xA0")]
	public int m_TableInvNumColumns;

	[Token(Token = "0x400359E")]
	[FieldOffset(Offset = "0xA4")]
	public float m_TableInvSpacingHorizontal;

	[Token(Token = "0x400359F")]
	[FieldOffset(Offset = "0xA8")]
	public float m_TableInvSpacingVertical;

	[Token(Token = "0x40035A0")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel m_LabelNoItemsInventory;

	[Header("Button Move")]
	[Token(Token = "0x40035A1")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_ButtonMoveItem;

	[Token(Token = "0x40035A2")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite m_ArrowButtonSprite;

	[Token(Token = "0x40035A3")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject InventoryItemPrefab;

	[NonSerialized]
	[Token(Token = "0x40035A4")]
	[FieldOffset(Offset = "0xD0")]
	public InventoryGridItem[] m_ContainerTableItems;

	[NonSerialized]
	[Token(Token = "0x40035A5")]
	[FieldOffset(Offset = "0xD8")]
	public InventoryGridItem[] m_InventoryTableItems;

	[NonSerialized]
	[Token(Token = "0x40035A6")]
	[FieldOffset(Offset = "0xE0")]
	public UISlider m_InventoryScrollbarSlider;

	[NonSerialized]
	[Token(Token = "0x40035A7")]
	[FieldOffset(Offset = "0xE8")]
	public UISlider m_ContainerScrollbarSlider;

	[Token(Token = "0x40035A8")]
	[FieldOffset(Offset = "0xF0")]
	private Action m_OnScrollbarInventoryChanged;

	[Token(Token = "0x40035A9")]
	[FieldOffset(Offset = "0xF8")]
	private Action m_OnScrollbarContainerChanged;

	[Token(Token = "0x40035AA")]
	[FieldOffset(Offset = "0x100")]
	private Action m_OnMoveItemAction;

	[Token(Token = "0x40035AB")]
	[FieldOffset(Offset = "0x108")]
	private Action m_OnDragInventoryToContainer;

	[Token(Token = "0x40035AC")]
	[FieldOffset(Offset = "0x110")]
	private Action m_OnDragContainerToInventory;

	[Token(Token = "0x40035AD")]
	[FieldOffset(Offset = "0x118")]
	private ScrollbarThumbResizer m_InventoryScrollbarThumbResizer;

	[Token(Token = "0x40035AE")]
	[FieldOffset(Offset = "0x120")]
	private ScrollbarThumbResizer m_ContainerScrollbarThumbResizer;

	[Token(Token = "0x6002D02")]
	[Address(RVA = "0x93ED70", Offset = "0x93DB70", Length = "0x249")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6002D03")]
	[Address(RVA = "0x93EFC0", Offset = "0x93DDC0", Length = "0xB2")]
	public void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002D04")]
	[Address(RVA = "0x93F080", Offset = "0x93DE80", Length = "0xAA")]
	public void SetScrollbarChangeActions(Action onScrollbarInventoryChanged, Action onScrollbarContainerChanged)
	{
	}

	[Token(Token = "0x6002D05")]
	[Address(RVA = "0x814E60", Offset = "0x813C60", Length = "0xAA")]
	public void SetDragAndDropActions(Action onDragInventoryToContainer, Action onDragContainerToInventory)
	{
	}

	[Token(Token = "0x6002D06")]
	[Address(RVA = "0x7F4BD0", Offset = "0x7F39D0", Length = "0x52")]
	public void SetMoveItemAction(Action onMoveAction)
	{
	}

	[Token(Token = "0x6002D07")]
	[Address(RVA = "0x93F130", Offset = "0x93DF30", Length = "0x19")]
	public void OnDragInventoryToContainer()
	{
	}

	[Token(Token = "0x6002D08")]
	[Address(RVA = "0x93F150", Offset = "0x93DF50", Length = "0x19")]
	public void OnDragContainerToInventory()
	{
	}

	[Token(Token = "0x6002D09")]
	[Address(RVA = "0x93F170", Offset = "0x93DF70", Length = "0x454")]
	public void InstantiateContainerTableItems()
	{
	}

	[Token(Token = "0x6002D0A")]
	[Address(RVA = "0x93F5D0", Offset = "0x93E3D0", Length = "0x431")]
	public void InstantiateInventoryTableItems()
	{
	}

	[Token(Token = "0x6002D0B")]
	[Address(RVA = "0x93FA10", Offset = "0x93E810", Length = "0x19")]
	public void OnScrollbarInventoryChange()
	{
	}

	[Token(Token = "0x6002D0C")]
	[Address(RVA = "0x93FA30", Offset = "0x93E830", Length = "0x19")]
	public void OnScrollbarContainerChange()
	{
	}

	[Token(Token = "0x6002D0D")]
	[Address(RVA = "0x93FA50", Offset = "0x93E850", Length = "0x19")]
	public void OnMoveItem()
	{
	}

	[Token(Token = "0x6002D0E")]
	[Address(RVA = "0x93FA70", Offset = "0x93E870", Length = "0xB6")]
	public void UpdateScrollbarThumbSize(int inventoryItemCount, int containerItemCount)
	{
	}

	[Token(Token = "0x6002D0F")]
	[Address(RVA = "0x93FB30", Offset = "0x93E930", Length = "0x176")]
	public void RefreshScrollBars(int inventoryFirstItemDisplayedIndexVal, int containerFirstItemDisplayedIndexVal, int inventoryItemCount, int containerItemCount)
	{
	}

	[Token(Token = "0x6002D10")]
	[Address(RVA = "0x93FCB0", Offset = "0x93EAB0", Length = "0x26")]
	public SelectedTableEnum GetTableSelected()
	{
		return default(SelectedTableEnum);
	}

	[Token(Token = "0x6002D11")]
	[Address(RVA = "0x93FCE0", Offset = "0x93EAE0", Length = "0x60")]
	public void SetTableSelected(SelectedTableEnum selectedTable)
	{
	}

	[Token(Token = "0x6002D12")]
	[Address(RVA = "0x93FD50", Offset = "0x93EB50", Length = "0x66")]
	public void UpdateMoveButton(bool enabled)
	{
	}

	[Token(Token = "0x6002D13")]
	[Address(RVA = "0x93FDC0", Offset = "0x93EBC0", Length = "0x9B")]
	public void SetInventoryItemSelectedIndex(int inventorySelectedItemIndexVal, SelectedTableEnum selectedTable, int newIndex)
	{
	}

	[Token(Token = "0x6002D14")]
	[Address(RVA = "0x93FE60", Offset = "0x93EC60", Length = "0x9C")]
	public void SetContainerItemSelectedIndex(int containerSelectedItemIndexVal, SelectedTableEnum selectedTable, int newIndex)
	{
	}

	[Token(Token = "0x6002D15")]
	[Address(RVA = "0x93FF00", Offset = "0x93ED00", Length = "0x9F")]
	public bool HasSelectedGridItem()
	{
		return false;
	}

	[Token(Token = "0x6002D16")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ContainerUI()
	{
	}
}
