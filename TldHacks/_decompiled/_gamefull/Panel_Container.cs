using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200062E")]
public class Panel_Container : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x200062F")]
	public class ContainerUIConfig
	{
		[Token(Token = "0x4003ABA")]
		[FieldOffset(Offset = "0x10")]
		public MissionUI m_MissionUIComponent;

		[Token(Token = "0x4003ABB")]
		[FieldOffset(Offset = "0x18")]
		public ContainerUI m_ContainerUIComponent;

		[Token(Token = "0x600317E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ContainerUIConfig()
		{
		}
	}

	[Token(Token = "0x2000630")]
	private enum ContainerMode
	{
		[Token(Token = "0x4003ABD")]
		Standard,
		[Token(Token = "0x4003ABE")]
		Mission
	}

	[CompilerGenerated]
	[Token(Token = "0x2000632")]
	private sealed class _003CUpdateObjectiveUI_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003AC1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003AC2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003AC3")]
		[FieldOffset(Offset = "0x20")]
		public Panel_Container _003C_003E4__this;

		[Token(Token = "0x170002E9")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003184")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EA")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003186")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6003181")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CUpdateObjectiveUI_003Ed__121(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6003182")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6003183")]
		[Address(RVA = "0x9CBBD0", Offset = "0x9CA9D0", Length = "0x182")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x6003185")]
		[Address(RVA = "0x9CBD60", Offset = "0x9CAB60", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4003A7A")]
	[FieldOffset(Offset = "0x30")]
	public ContainerUIConfig m_StandardConfig;

	[Token(Token = "0x4003A7B")]
	[FieldOffset(Offset = "0x38")]
	public ContainerUIConfig m_MissionConfig;

	[Token(Token = "0x4003A7C")]
	[FieldOffset(Offset = "0x40")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003A7D")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_Label_CarryCapacity;

	[Token(Token = "0x4003A7E")]
	[FieldOffset(Offset = "0x50")]
	public UISprite m_CapacityBarSprite;

	[Token(Token = "0x4003A7F")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_CapacityBarOutline;

	[Token(Token = "0x4003A80")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_Label_ContainerCapacity;

	[Token(Token = "0x4003A81")]
	[FieldOffset(Offset = "0x68")]
	public UIButton m_DefaultFilterButton;

	[Token(Token = "0x4003A82")]
	[FieldOffset(Offset = "0x70")]
	public UIButton m_DefaultSortButton;

	[Token(Token = "0x4003A83")]
	[FieldOffset(Offset = "0x78")]
	public UIButton[] m_SortButtons;

	[Token(Token = "0x4003A84")]
	[FieldOffset(Offset = "0x80")]
	public UIButton[] m_FilterButtons;

	[Token(Token = "0x4003A85")]
	[FieldOffset(Offset = "0x88")]
	public UILabel m_CategoryLabel;

	[Token(Token = "0x4003A86")]
	[FieldOffset(Offset = "0x90")]
	public ItemDescriptionPage m_ItemDescriptionPage;

	[Token(Token = "0x4003A87")]
	[FieldOffset(Offset = "0x98")]
	public UILabel m_NameplateLabel;

	[Range(0f, 1f)]
	[Token(Token = "0x4003A88")]
	[FieldOffset(Offset = "0xA0")]
	public float m_AlphaUnselectedSide;

	[Token(Token = "0x4003A89")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite m_FilterLeftGamepadButtonSprite;

	[Token(Token = "0x4003A8A")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite m_FilterRightGamepadButtonSprite;

	[HideInInspector]
	[Token(Token = "0x4003A8B")]
	[FieldOffset(Offset = "0xB8")]
	public bool m_EnablePauseMenuOnExit;

	[HideInInspector]
	[Token(Token = "0x4003A8C")]
	[FieldOffset(Offset = "0xC0")]
	public Container m_Container;

	[Tooltip("If only one inventory category is available, show the rest of the categories disabled")]
	[Token(Token = "0x4003A8D")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_SortLabel;

	[Token(Token = "0x4003A8E")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_SortButtonsObject;

	[Token(Token = "0x4003A8F")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject m_SelectedSpriteObj;

	[Token(Token = "0x4003A90")]
	[FieldOffset(Offset = "0xE0")]
	public TweenScale m_SelectedSpriteTweenScale;

	[Token(Token = "0x4003A91")]
	[FieldOffset(Offset = "0xE8")]
	public UIButton[] m_MoveAllToContainerButtons;

	[Token(Token = "0x4003A92")]
	[FieldOffset(Offset = "0xF0")]
	public UIButton[] m_MoveAllToInventoryButtons;

	[SerializeField]
	[Token(Token = "0x4003A93")]
	[FieldOffset(Offset = "0xF8")]
	private GenericButtonMouseSpawner m_DropAllButton;

	[SerializeField]
	[Token(Token = "0x4003A94")]
	[FieldOffset(Offset = "0x100")]
	private GenericButtonMouseSpawner m_DeployButton;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003A95")]
	[FieldOffset(Offset = "0x108")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x4003A96")]
	[FieldOffset(Offset = "0x110")]
	private PanelReference<Panel_PickUnits> m_PickUnits;

	[SerializeField]
	[Token(Token = "0x4003A97")]
	[FieldOffset(Offset = "0x118")]
	private PanelReference<Panel_PickWater> m_PickWater;

	[Token(Token = "0x4003A98")]
	[FieldOffset(Offset = "0x120")]
	private List<CategoryButton> m_CategoryButtons;

	[Token(Token = "0x4003A99")]
	[FieldOffset(Offset = "0x128")]
	private UIButton m_SelectedFilterButton;

	[Token(Token = "0x4003A9A")]
	[FieldOffset(Offset = "0x130")]
	private UIButton m_SelectedSortButton;

	[Token(Token = "0x4003A9B")]
	[FieldOffset(Offset = "0x138")]
	private string m_SelectedSortOldSprite;

	[Token(Token = "0x4003A9C")]
	[FieldOffset(Offset = "0x140")]
	private Dictionary<string, bool> m_SortFlipDictionary;

	[Token(Token = "0x4003A9D")]
	[FieldOffset(Offset = "0x148")]
	private ContainerMode m_ContainerMode;

	[Token(Token = "0x4003A9E")]
	[FieldOffset(Offset = "0x150")]
	private string m_ContainerDisplayName;

	[Token(Token = "0x4003A9F")]
	[FieldOffset(Offset = "0x158")]
	private SelectedTableEnum m_SelectedTableVal;

	[Token(Token = "0x4003AA0")]
	[FieldOffset(Offset = "0x160")]
	private string m_InventoryFilterName;

	[Token(Token = "0x4003AA1")]
	[FieldOffset(Offset = "0x168")]
	private string m_InventorySortName;

	[Token(Token = "0x4003AA2")]
	[FieldOffset(Offset = "0x170")]
	private int m_SelectedSortIndex;

	[Token(Token = "0x4003AA3")]
	[FieldOffset(Offset = "0x178")]
	private MissionUI m_MissionUIComponent;

	[Token(Token = "0x4003AA4")]
	[FieldOffset(Offset = "0x180")]
	private ContainerUI m_ContainerUIComponent;

	[Token(Token = "0x4003AA5")]
	[FieldOffset(Offset = "0x188")]
	private int m_InventorySelectedItemIndexVal;

	[Token(Token = "0x4003AA6")]
	[FieldOffset(Offset = "0x18C")]
	private int m_InventoryNumItemsDisplayed;

	[Token(Token = "0x4003AA7")]
	[FieldOffset(Offset = "0x190")]
	private int m_InventoryFirstItemDisplayedIndexVal;

	[Token(Token = "0x4003AA8")]
	[FieldOffset(Offset = "0x194")]
	private int m_ContainerSelectedItemIndexVal;

	[Token(Token = "0x4003AA9")]
	[FieldOffset(Offset = "0x198")]
	private int m_ContainerNumItemsDisplayed;

	[Token(Token = "0x4003AAA")]
	[FieldOffset(Offset = "0x19C")]
	private int m_ContainerFirstItemDisplayedIndexVal;

	[Token(Token = "0x4003AAB")]
	[FieldOffset(Offset = "0x1A0")]
	private readonly List<InventoryGridDataItem> m_FilteredInventoryList;

	[Token(Token = "0x4003AAC")]
	[FieldOffset(Offset = "0x1A8")]
	private readonly List<InventoryGridDataItem> m_FilteredContainerList;

	[Token(Token = "0x4003AAD")]
	[FieldOffset(Offset = "0x1B0")]
	private bool m_EnablePending;

	[Token(Token = "0x4003AAE")]
	[FieldOffset(Offset = "0x1B4")]
	private float m_EnableDelaySeconds;

	[Token(Token = "0x4003AAF")]
	[FieldOffset(Offset = "0x1B8")]
	private float m_EnableDelayElapsed;

	[Token(Token = "0x4003AB0")]
	[FieldOffset(Offset = "0x1BC")]
	private bool m_ShouldResetSelectedItem;

	[Token(Token = "0x4003AB1")]
	[FieldOffset(Offset = "0x1C0")]
	private int m_NumFramesPanelActive;

	[Token(Token = "0x4003AB2")]
	[FieldOffset(Offset = "0x1C4")]
	private bool m_ForceRefreshRequested;

	[Token(Token = "0x4003AB3")]
	[FieldOffset(Offset = "0x1C8")]
	private DragDropItem m_DraggedItem;

	[Token(Token = "0x4003AB4")]
	[FieldOffset(Offset = "0x1D0")]
	private Action m_OnContainerClosed;

	[Token(Token = "0x4003AB5")]
	[FieldOffset(Offset = "0x1D8")]
	public Transform m_SectionNavSelectedSprite;

	[Token(Token = "0x4003AB6")]
	[FieldOffset(Offset = "0x1E0")]
	public GameObject m_SectionNavArrowPrompts;

	[Token(Token = "0x4003AB7")]
	[FieldOffset(Offset = "0x1E8")]
	private int m_SectionNavIndex;

	[Token(Token = "0x4003AB8")]
	[FieldOffset(Offset = "0x1EC")]
	private bool m_IsInSectionNav;

	[Token(Token = "0x4003AB9")]
	[FieldOffset(Offset = "0x1ED")]
	private bool m_UpdateObjectiveUI;

	[Token(Token = "0x170002E4")]
	private SelectedTableEnum m_SelectedTable
	{
		[Token(Token = "0x6003123")]
		[Address(RVA = "0x9BB080", Offset = "0x9B9E80", Length = "0x7")]
		get
		{
			return default(SelectedTableEnum);
		}
		[Token(Token = "0x6003124")]
		[Address(RVA = "0x9BB090", Offset = "0x9B9E90", Length = "0x72")]
		set
		{
		}
	}

	[Token(Token = "0x170002E5")]
	private int m_InventorySelectedItemIndex
	{
		[Token(Token = "0x6003125")]
		[Address(RVA = "0x9BB110", Offset = "0x9B9F10", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x9BB120", Offset = "0x9B9F20", Length = "0x5C")]
		set
		{
		}
	}

	[Token(Token = "0x170002E6")]
	private int m_InventoryFirstItemDisplayedIndex
	{
		[Token(Token = "0x6003127")]
		[Address(RVA = "0x8FB9C0", Offset = "0x8FA7C0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003128")]
		[Address(RVA = "0x9BB180", Offset = "0x9B9F80", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x170002E7")]
	private int m_ContainerSelectedItemIndex
	{
		[Token(Token = "0x6003129")]
		[Address(RVA = "0x9BB1A0", Offset = "0x9B9FA0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600312A")]
		[Address(RVA = "0x9BB1B0", Offset = "0x9B9FB0", Length = "0x5C")]
		set
		{
		}
	}

	[Token(Token = "0x170002E8")]
	private int m_ContainerFirstItemDisplayedIndex
	{
		[Token(Token = "0x600312B")]
		[Address(RVA = "0x9BB210", Offset = "0x9BA010", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600312C")]
		[Address(RVA = "0x9BB220", Offset = "0x9BA020", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x600312D")]
	[Address(RVA = "0x9BB240", Offset = "0x9BA040", Length = "0xC3C")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600312E")]
	[Address(RVA = "0x9BBE80", Offset = "0x9BAC80", Length = "0x145")]
	private void UpdateSortNavigation()
	{
	}

	[Token(Token = "0x600312F")]
	[Address(RVA = "0x9BBFD0", Offset = "0x9BADD0", Length = "0x932")]
	private void Update()
	{
	}

	[Token(Token = "0x6003130")]
	[Address(RVA = "0x9BC910", Offset = "0x9BB710", Length = "0x15D")]
	private void UpdateAlpha()
	{
	}

	[Token(Token = "0x6003131")]
	[Address(RVA = "0x9BCA70", Offset = "0x9BB870", Length = "0x630")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003132")]
	[Address(RVA = "0x9BD0B0", Offset = "0x9BBEB0", Length = "0x26F")]
	private bool CanDeployDecorationItem()
	{
		return false;
	}

	[Token(Token = "0x6003133")]
	[Address(RVA = "0x9BD320", Offset = "0x9BC120", Length = "0x37B")]
	private void RefreshWeight()
	{
	}

	[Token(Token = "0x6003134")]
	[Address(RVA = "0x9BD6A0", Offset = "0x9BC4A0", Length = "0x362")]
	public int RefreshInventoryTable()
	{
		return 0;
	}

	[Token(Token = "0x6003135")]
	[Address(RVA = "0x9BDA10", Offset = "0x9BC810", Length = "0x631")]
	public int RefreshContainerTable()
	{
		return 0;
	}

	[Token(Token = "0x6003136")]
	[Address(RVA = "0x9BE050", Offset = "0x9BCE50", Length = "0x409")]
	public void RefreshTables()
	{
	}

	[Token(Token = "0x6003137")]
	[Address(RVA = "0x9BE460", Offset = "0x9BD260", Length = "0x1CA")]
	private void RefreshMoveAllButtons()
	{
	}

	[Token(Token = "0x6003138")]
	[Address(RVA = "0x9BE630", Offset = "0x9BD430", Length = "0x4BB")]
	public void HoverItem(InventoryGridItem gridItem, string displayName, bool isOver, bool isContainerItem)
	{
	}

	[Token(Token = "0x6003139")]
	[Address(RVA = "0x9BEAF0", Offset = "0x9BD8F0", Length = "0x5BA")]
	public void EnableAfterDelay(float delaySeconds)
	{
	}

	[Token(Token = "0x600313A")]
	[Address(RVA = "0x9BF0B0", Offset = "0x9BDEB0", Length = "0x1D")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600313B")]
	[Address(RVA = "0x9BF0D0", Offset = "0x9BDED0", Length = "0x912")]
	public void Enable(bool enable, bool resetFilter, Action onContainerClosed = null)
	{
	}

	[Token(Token = "0x600313C")]
	[Address(RVA = "0x9BF9F0", Offset = "0x9BE7F0", Length = "0xDC")]
	public void SetContainer(Container c, string displayName)
	{
	}

	[Token(Token = "0x600313D")]
	[Address(RVA = "0x9BFAD0", Offset = "0x9BE8D0", Length = "0x23")]
	public override bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x600313E")]
	[Address(RVA = "0x9BFB00", Offset = "0x9BE900", Length = "0x8")]
	public bool IsEnablePending()
	{
		return false;
	}

	[Token(Token = "0x600313F")]
	[Address(RVA = "0x9BFB10", Offset = "0x9BE910", Length = "0x1CB")]
	private void OnInventoryScrollbarChange()
	{
	}

	[Token(Token = "0x6003140")]
	[Address(RVA = "0x9BFCE0", Offset = "0x9BEAE0", Length = "0x195")]
	private void OnContainerScrollbarChange()
	{
	}

	[Token(Token = "0x6003141")]
	[Address(RVA = "0x9BFE80", Offset = "0x9BEC80", Length = "0x123")]
	public void OnControllerScheme(bool isController)
	{
	}

	[Token(Token = "0x6003142")]
	[Address(RVA = "0x9BFFB0", Offset = "0x9BEDB0", Length = "0x45")]
	public void OnPopupClicked()
	{
	}

	[Token(Token = "0x6003143")]
	[Address(RVA = "0x9C0000", Offset = "0x9BEE00", Length = "0x602")]
	public void OnFilterInventoryChange(UIButton filterButtonClicked)
	{
	}

	[Token(Token = "0x6003144")]
	[Address(RVA = "0x9C0610", Offset = "0x9BF410", Length = "0x6D2")]
	public void OnSortInventoryChange(UIButton sortButtonClicked)
	{
	}

	[Token(Token = "0x6003145")]
	[Address(RVA = "0x9C0CF0", Offset = "0x9BFAF0", Length = "0x18")]
	public void OnMoveItem()
	{
	}

	[Token(Token = "0x6003146")]
	[Address(RVA = "0x9C0D10", Offset = "0x9BFB10", Length = "0x15")]
	public void OnMoveAllItems()
	{
	}

	[Token(Token = "0x6003147")]
	[Address(RVA = "0x9C0D30", Offset = "0x9BFB30", Length = "0x8FF")]
	public void OnDropAllItems()
	{
	}

	[Token(Token = "0x6003148")]
	[Address(RVA = "0x9C1630", Offset = "0x9C0430", Length = "0x5F")]
	private bool CanDropAllItems()
	{
		return false;
	}

	[Token(Token = "0x6003149")]
	[Address(RVA = "0x9C1690", Offset = "0x9C0490", Length = "0x12A")]
	public void DragInventoryToContainer()
	{
	}

	[Token(Token = "0x600314A")]
	[Address(RVA = "0x9C17C0", Offset = "0x9C05C0", Length = "0x12A")]
	public void DragContainerToInventory()
	{
	}

	[Token(Token = "0x600314B")]
	[Address(RVA = "0x9C18F0", Offset = "0x9C06F0", Length = "0xF4C")]
	public void OnInventoryToContainer(bool cameFromDrag = false)
	{
	}

	[Token(Token = "0x600314C")]
	[Address(RVA = "0x9C2840", Offset = "0x9C1640", Length = "0x910")]
	public void OnContainerToInventory(bool cameFromDrag = false)
	{
	}

	[Token(Token = "0x600314D")]
	[Address(RVA = "0x9C3160", Offset = "0x9C1F60", Length = "0x2D2")]
	public bool CanMoveAllToContainer()
	{
		return false;
	}

	[Token(Token = "0x600314E")]
	[Address(RVA = "0x9C3440", Offset = "0x9C2240", Length = "0x557")]
	public void OnMoveAllToContainer()
	{
	}

	[Token(Token = "0x600314F")]
	[Address(RVA = "0x9C39A0", Offset = "0x9C27A0", Length = "0x4D4")]
	private bool CanMoveItemToContainerInMoveAll(InventoryGridDataItem dataItem)
	{
		return false;
	}

	[Token(Token = "0x6003150")]
	[Address(RVA = "0x9C3E80", Offset = "0x9C2C80", Length = "0xBA")]
	public bool CanMoveItemToContainer(InventoryGridDataItem dataItem)
	{
		return false;
	}

	[Token(Token = "0x6003151")]
	[Address(RVA = "0x9C3F40", Offset = "0x9C2D40", Length = "0x2DB")]
	public bool CanMoveAllToInventory()
	{
		return false;
	}

	[Token(Token = "0x6003152")]
	[Address(RVA = "0x9C4220", Offset = "0x9C3020", Length = "0x1A8")]
	public bool CanMoveItemToInventory(InventoryGridDataItem dataItem)
	{
		return false;
	}

	[Token(Token = "0x6003153")]
	[Address(RVA = "0x9C43D0", Offset = "0x9C31D0", Length = "0x55D")]
	public void OnMoveAllToInventory()
	{
	}

	[Token(Token = "0x6003154")]
	[Address(RVA = "0x9C4930", Offset = "0x9C3730", Length = "0xA4")]
	private void RequestObjectiveUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateObjectiveUI_003Ed__121))]
	[Token(Token = "0x6003155")]
	[Address(RVA = "0x9C49E0", Offset = "0x9C37E0", Length = "0x9A")]
	private IEnumerator UpdateObjectiveUI()
	{
		return null;
	}

	[Token(Token = "0x6003156")]
	[Address(RVA = "0x9C4A80", Offset = "0x9C3880", Length = "0x118")]
	private void ShiftFocusToInventoryItem(InventoryGridDataItem dataItem)
	{
	}

	[Token(Token = "0x6003157")]
	[Address(RVA = "0x9C4BA0", Offset = "0x9C39A0", Length = "0x383")]
	public void ShiftFocusToInventoryItem(GearItem gi)
	{
	}

	[Token(Token = "0x6003158")]
	[Address(RVA = "0x9C4F30", Offset = "0x9C3D30", Length = "0x117")]
	private void ShiftFocusToContainerItem(InventoryGridDataItem dataItem)
	{
	}

	[Token(Token = "0x6003159")]
	[Address(RVA = "0x9C5050", Offset = "0x9C3E50", Length = "0x383")]
	public void ShiftFocusToContainerItem(GearItem gi)
	{
	}

	[Token(Token = "0x600315A")]
	[Address(RVA = "0x9C53E0", Offset = "0x9C41E0", Length = "0x1A7")]
	public void SelectGridItem(InventoryGridItem gridItem, bool isInContainer)
	{
	}

	[Token(Token = "0x600315B")]
	[Address(RVA = "0x9C5590", Offset = "0x9C4390", Length = "0x8")]
	public void ForceRefresh()
	{
	}

	[Token(Token = "0x600315C")]
	[Address(RVA = "0x9C55A0", Offset = "0x9C43A0", Length = "0x7")]
	public int GetNumFramesInPanel()
	{
		return 0;
	}

	[Token(Token = "0x600315D")]
	[Address(RVA = "0x9C55B0", Offset = "0x9C43B0", Length = "0x1F5")]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[Token(Token = "0x600315E")]
	[Address(RVA = "0x9C57B0", Offset = "0x9C45B0", Length = "0x97")]
	private bool IgnoreWaterSupplyItem(WaterSupply ws)
	{
		return false;
	}

	[Token(Token = "0x600315F")]
	[Address(RVA = "0x9C5850", Offset = "0x9C4650", Length = "0x16B")]
	private bool ItemPassesFilter(DecorationItem decorationItem, string filterName)
	{
		return false;
	}

	[Token(Token = "0x6003160")]
	[Address(RVA = "0x9C59C0", Offset = "0x9C47C0", Length = "0x5AC")]
	private bool ItemPassesFilter(GearItem pi, string filterName)
	{
		return false;
	}

	[Token(Token = "0x6003161")]
	[Address(RVA = "0x9C5F70", Offset = "0x9C4D70", Length = "0x340")]
	public void OnDone()
	{
	}

	[Token(Token = "0x6003162")]
	[Address(RVA = "0x9C62C0", Offset = "0x9C50C0", Length = "0xD0")]
	private InventoryGridDataItem GetCurrentlySelectedItem()
	{
		return null;
	}

	[Token(Token = "0x6003163")]
	[Address(RVA = "0x9C63A0", Offset = "0x9C51A0", Length = "0x841")]
	private void UpdateFilteredInventoryList()
	{
	}

	[Token(Token = "0x6003164")]
	[Address(RVA = "0x9C6BF0", Offset = "0x9C59F0", Length = "0x7B1")]
	private void UpdateFilteredContainerList()
	{
	}

	[Token(Token = "0x6003165")]
	[Address(RVA = "0x9C73B0", Offset = "0x9C61B0", Length = "0x43E")]
	private void RefreshFilterIconColors()
	{
	}

	[Token(Token = "0x6003166")]
	[Address(RVA = "0x9C77F0", Offset = "0x9C65F0", Length = "0x3A6")]
	private bool FilterHasNoItemsInventory(string filterName)
	{
		return false;
	}

	[Token(Token = "0x6003167")]
	[Address(RVA = "0x9C7BA0", Offset = "0x9C69A0", Length = "0x392")]
	private bool FilterHasNoItemsContainer(string filterName)
	{
		return false;
	}

	[Token(Token = "0x6003168")]
	[Address(RVA = "0x9C7F40", Offset = "0x9C6D40", Length = "0x336")]
	public void OnDeploy()
	{
	}

	[Token(Token = "0x6003169")]
	[Address(RVA = "0x9C8280", Offset = "0x9C7080", Length = "0x210")]
	private void RefreshNoItemsLabel()
	{
	}

	[Token(Token = "0x600316A")]
	[Address(RVA = "0x9C84A0", Offset = "0x9C72A0", Length = "0xFD")]
	private void RefreshMoveButton()
	{
	}

	[Token(Token = "0x600316B")]
	[Address(RVA = "0x9C85A0", Offset = "0x9C73A0", Length = "0x335")]
	private void UpdateSortLabels()
	{
	}

	[Token(Token = "0x600316C")]
	[Address(RVA = "0x9C88E0", Offset = "0x9C76E0", Length = "0xD1E")]
	private void UpdateDragDrop()
	{
	}

	[Token(Token = "0x600316D")]
	[Address(RVA = "0x9C9600", Offset = "0x9C8400", Length = "0x1DC")]
	private void FinishDragDrop()
	{
	}

	[Token(Token = "0x600316E")]
	[Address(RVA = "0x9C97E0", Offset = "0x9C85E0", Length = "0x7F")]
	private void RefreshScrollBars()
	{
	}

	[Token(Token = "0x600316F")]
	[Address(RVA = "0x9C9860", Offset = "0x9C8660", Length = "0xFD")]
	private UIButton GetDefaultButtonFilter()
	{
		return null;
	}

	[Token(Token = "0x6003170")]
	[Address(RVA = "0x9C9960", Offset = "0x9C8760", Length = "0x2D4")]
	private UIButton GetFilterButtonFromFilterType(InventoryFilterType filter)
	{
		return null;
	}

	[Token(Token = "0x6003171")]
	[Address(RVA = "0x9C9C60", Offset = "0x9C8A60", Length = "0xA4")]
	private void DoSectionNavUpdate()
	{
	}

	[Token(Token = "0x6003172")]
	[Address(RVA = "0x9C9D10", Offset = "0x9C8B10", Length = "0x735")]
	private void DoSectionNavControls()
	{
	}

	[Token(Token = "0x6003173")]
	[Address(RVA = "0x9CA450", Offset = "0x9C9250", Length = "0x97")]
	private bool ShouldEnterSectionNav()
	{
		return false;
	}

	[Token(Token = "0x6003174")]
	[Address(RVA = "0x9CA4F0", Offset = "0x9C92F0", Length = "0x16D")]
	private void MoveSectionNavToButton(UIButton button)
	{
	}

	[Token(Token = "0x6003175")]
	[Address(RVA = "0x9CA660", Offset = "0x9C9460", Length = "0x5C")]
	private void EnterSectionNav()
	{
	}

	[Token(Token = "0x6003176")]
	[Address(RVA = "0x9CA6C0", Offset = "0x9C94C0", Length = "0xB41")]
	private void DeselectAllItems()
	{
	}

	[Token(Token = "0x6003177")]
	[Address(RVA = "0x9CB210", Offset = "0x9CA010", Length = "0x155")]
	private bool CanEnterContainerMissionMode()
	{
		return false;
	}

	[Token(Token = "0x6003178")]
	[Address(RVA = "0x9CB370", Offset = "0x9CA170", Length = "0x145")]
	private void UpdateObjectives()
	{
	}

	[Token(Token = "0x6003179")]
	[Address(RVA = "0x9CB4C0", Offset = "0x9CA2C0", Length = "0x1D1")]
	private void RefreshContainerMode()
	{
	}

	[Token(Token = "0x600317A")]
	[Address(RVA = "0x9CB6A0", Offset = "0x9CA4A0", Length = "0x20")]
	private void ApplyStandardConfig()
	{
	}

	[Token(Token = "0x600317B")]
	[Address(RVA = "0x9CB6C0", Offset = "0x9CA4C0", Length = "0x20")]
	private void ApplyMissionConfig()
	{
	}

	[Token(Token = "0x600317C")]
	[Address(RVA = "0x9CB6E0", Offset = "0x9CA4E0", Length = "0x115")]
	private void ApplyUIConfig(ContainerUIConfig containerUI)
	{
	}

	[Token(Token = "0x600317D")]
	[Address(RVA = "0x9CB800", Offset = "0x9CA600", Length = "0x387")]
	public Panel_Container()
	{
	}
}
