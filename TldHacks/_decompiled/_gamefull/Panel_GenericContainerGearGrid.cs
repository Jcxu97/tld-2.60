using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using TLD.UI.Scroll;
using UnityEngine;

[Token(Token = "0x2000245")]
public abstract class Panel_GenericContainerGearGrid : Panel_GenericGearGrid, IScrollModel
{
	[Token(Token = "0x400140C")]
	protected const string GAMEPLAY_NO_ITEMS_INVENTORY = "GAMEPLAY_NoItemsInventory";

	[Token(Token = "0x400140D")]
	protected const string GAMEPLAY_NO_ITEMS_OF_TYPE_INVENTORY = "GAMEPLAY_NoItemsOfTypeInventory";

	[Token(Token = "0x400140E")]
	protected const string GAMEPLAY_BACKPACK = "GAMEPLAY_Backpack";

	[Header("Inventory Info")]
	[SerializeField]
	[Token(Token = "0x400140F")]
	[FieldOffset(Offset = "0x58")]
	protected UILabel m_CarryCapacityLabel;

	[SerializeField]
	[Token(Token = "0x4001410")]
	[FieldOffset(Offset = "0x60")]
	protected UISprite m_CarryCapacityBarSprite;

	[SerializeField]
	[Token(Token = "0x4001411")]
	[FieldOffset(Offset = "0x68")]
	protected UISprite m_CarryCapacityBarOutline;

	[Header("Container Elements")]
	[SerializeField]
	[Token(Token = "0x4001412")]
	[FieldOffset(Offset = "0x70")]
	private List<Collider> m_DragDropColliders;

	[SerializeField]
	[Token(Token = "0x4001413")]
	[FieldOffset(Offset = "0x78")]
	protected ScrollBehaviour m_InventoryTable;

	[SerializeField]
	[Token(Token = "0x4001414")]
	[FieldOffset(Offset = "0x80")]
	protected ScrollBehaviour m_ContainerTable;

	[SerializeField]
	[Token(Token = "0x4001415")]
	[FieldOffset(Offset = "0x88")]
	protected UILabel m_NoItemsInInventoryLabel;

	[SerializeField]
	[Token(Token = "0x4001416")]
	[FieldOffset(Offset = "0x90")]
	protected UILabel m_NoItemsInContainerLabel;

	[Header("Focus Visualization")]
	[SerializeField]
	[Token(Token = "0x4001417")]
	[FieldOffset(Offset = "0x98")]
	private UIWidget m_InventoryWidget;

	[SerializeField]
	[Token(Token = "0x4001418")]
	[FieldOffset(Offset = "0xA0")]
	private UIWidget m_ContainerWidget;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4001419")]
	[FieldOffset(Offset = "0xA8")]
	protected float m_AlphaUnselectedSide;

	[SerializeField]
	[Token(Token = "0x400141A")]
	[FieldOffset(Offset = "0xB0")]
	private UISprite m_ArrowButtonSprite;

	[Header("Sorting & Filtering")]
	[SerializeField]
	[Token(Token = "0x400141B")]
	[FieldOffset(Offset = "0xB8")]
	private List<GenericGearGridSortButton> m_SortButtons;

	[SerializeField]
	[Token(Token = "0x400141C")]
	[FieldOffset(Offset = "0xC0")]
	private List<GenericGearGridFilterButton> m_FilterButtons;

	[SerializeField]
	[Token(Token = "0x400141D")]
	[FieldOffset(Offset = "0xC8")]
	private UILabel m_CategoryLabel;

	[SerializeField]
	[Token(Token = "0x400141E")]
	[FieldOffset(Offset = "0xD0")]
	private GameObject m_FilterSelectionElements;

	[SerializeField]
	[Token(Token = "0x400141F")]
	[FieldOffset(Offset = "0xD8")]
	private GameObject m_SelectedFilterSprite;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001420")]
	[FieldOffset(Offset = "0xE0")]
	protected PanelReference<Panel_Inventory> m_Inventory;

	[Token(Token = "0x4001421")]
	[FieldOffset(Offset = "0xE8")]
	private readonly List<GamepadButtonSprite> m_GamepadButtonSprites;

	[Token(Token = "0x4001422")]
	[FieldOffset(Offset = "0xF0")]
	protected bool m_IsSelectingFilter;

	[Token(Token = "0x4001423")]
	[FieldOffset(Offset = "0xF4")]
	private int m_FilterButtonIndex;

	[Token(Token = "0x4001424")]
	[FieldOffset(Offset = "0xF8")]
	protected InventoryFilterType m_CurrentFilter;

	[Token(Token = "0x4001425")]
	[FieldOffset(Offset = "0xFC")]
	private Sorting m_CurrentSorting;

	[Token(Token = "0x4001426")]
	[FieldOffset(Offset = "0x100")]
	private readonly Dictionary<Sorting, bool> m_SortFlipDictionary;

	[Token(Token = "0x4001427")]
	[FieldOffset(Offset = "0x108")]
	protected readonly List<GearItem> m_FilteredInventoryList;

	[Token(Token = "0x4001428")]
	[FieldOffset(Offset = "0x110")]
	protected readonly List<GearItem> m_FilteredContainerList;

	[Token(Token = "0x4001429")]
	[FieldOffset(Offset = "0x118")]
	private GenericGearGridItem m_SelectedItem;

	[Token(Token = "0x400142A")]
	[FieldOffset(Offset = "0x120")]
	protected GenericGearGridItem m_DraggedItem;

	[Token(Token = "0x400142B")]
	[FieldOffset(Offset = "0x128")]
	protected bool m_ShiftFocusToMovedItem;

	[Token(Token = "0x170001CB")]
	protected bool IsInventoryTableSelected
	{
		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x6793D0", Offset = "0x6781D0", Length = "0x134")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60013F7")]
	[Address(RVA = "0x679510", Offset = "0x678310", Length = "0xAB")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60013F8")]
	public abstract void ClosePanel();

	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x6795C0", Offset = "0x6783C0", Length = "0x602")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60013FA")]
	[Address(RVA = "0x679BD0", Offset = "0x6789D0", Length = "0x50")]
	public void ToggleFilterSelection(bool selectingFilter)
	{
	}

	[Token(Token = "0x60013FB")]
	[Address(RVA = "0x679C30", Offset = "0x678A30", Length = "0x9E")]
	public virtual void HandleOnFilterButtonPressed(GenericGearGridFilterButton filterButton)
	{
	}

	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x679CD0", Offset = "0x678AD0", Length = "0x594")]
	private void SelectFilter(InventoryFilterType filter)
	{
	}

	[Token(Token = "0x60013FD")]
	[Address(RVA = "0x67A290", Offset = "0x679090", Length = "0x16D")]
	private void HandleOnToggleSortPressed()
	{
	}

	[Token(Token = "0x60013FE")]
	[Address(RVA = "0x67A400", Offset = "0x679200", Length = "0x96")]
	public void HandleOnSortButtonPressed(GenericGearGridSortButton sortButton)
	{
	}

	[Token(Token = "0x60013FF")]
	[Address(RVA = "0x67A4A0", Offset = "0x6792A0", Length = "0x206")]
	private void SelectSorting(Sorting sorting)
	{
	}

	[Token(Token = "0x6001400")]
	[Address(RVA = "0x67A6B0", Offset = "0x6794B0", Length = "0x158")]
	protected void SortItems(List<GearItem> gearItems)
	{
	}

	[Token(Token = "0x6001401")]
	[Address(RVA = "0x67A810", Offset = "0x679610", Length = "0x55")]
	protected virtual void ResetSelectedIndex()
	{
	}

	[Token(Token = "0x6001402")]
	[Address(RVA = "0x67A870", Offset = "0x679670", Length = "0x63")]
	protected override void SetSelectedTable(ScrollBehaviour selectedTable, bool focusNewTable)
	{
	}

	[Token(Token = "0x6001403")]
	[Address(RVA = "0x67A8E0", Offset = "0x6796E0", Length = "0x33")]
	public void DragItemToInventory()
	{
	}

	[Token(Token = "0x6001404")]
	[Address(RVA = "0x67A920", Offset = "0x679720", Length = "0x33")]
	public void DragItemToContainer()
	{
	}

	[Token(Token = "0x6001405")]
	protected abstract void RefreshTables();

	[Token(Token = "0x6001406")]
	public abstract void MoveItem();

	[Token(Token = "0x6001407")]
	[Address(RVA = "0x67A960", Offset = "0x679760", Length = "0xF8")]
	protected void ShiftFocusToMovedItem(GearItem movedItem)
	{
	}

	[Token(Token = "0x6001408")]
	[Address(RVA = "0x67AA60", Offset = "0x679860", Length = "0x321")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6001409")]
	[Address(RVA = "0x67AD90", Offset = "0x679B90", Length = "0x160")]
	protected virtual void UpdateAlpha()
	{
	}

	[Token(Token = "0x600140A")]
	[Address(RVA = "0x67AF00", Offset = "0x679D00", Length = "0x6F1")]
	protected virtual void UpdateGamepadControls()
	{
	}

	[Token(Token = "0x600140B")]
	[Address(RVA = "0x67B600", Offset = "0x67A400", Length = "0x3D2")]
	private void UpdateDragDrop()
	{
	}

	[Token(Token = "0x600140C")]
	[Address(RVA = "0x67B9E0", Offset = "0x67A7E0", Length = "0x227")]
	private void FinishDragDrop()
	{
	}

	[Token(Token = "0x600140D")]
	[Address(RVA = "0x67BC10", Offset = "0x67AA10", Length = "0x192")]
	protected void HandleOnHoverInventory(GenericGearGridItem gridItem)
	{
	}

	[Token(Token = "0x600140E")]
	[Address(RVA = "0x67BDB0", Offset = "0x67ABB0", Length = "0x192")]
	protected void HandleOnHoverContainer(GenericGearGridItem gridItem)
	{
	}

	[Token(Token = "0x600140F")]
	[Address(RVA = "0x67BF50", Offset = "0x67AD50", Length = "0x11")]
	protected void HandleOnItemDoubleClick(GenericGearGridItem gridItem)
	{
	}

	[Token(Token = "0x6001410")]
	public abstract void BuildItem(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem item, int index);

	[Token(Token = "0x6001411")]
	[Address(RVA = "0x67BF70", Offset = "0x67AD70", Length = "0x652")]
	public void UpdateSelected(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem selectedItem, int selectedIndex)
	{
	}

	[Token(Token = "0x6001412")]
	[Address(RVA = "0x67C5D0", Offset = "0x67B3D0", Length = "0x474")]
	protected Panel_GenericContainerGearGrid()
	{
	}
}
