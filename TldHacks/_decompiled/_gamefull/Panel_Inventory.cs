using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;

[Token(Token = "0x200066B")]
public class Panel_Inventory : Panel_AutoReferenced, INotificationHandler, IMiniTopNav
{
	[Serializable]
	[Token(Token = "0x200066C")]
	public struct BackpackDisplayInfo
	{
		[Token(Token = "0x40040C3")]
		[FieldOffset(Offset = "0x0")]
		public LocalizedString m_DisplayName;

		[Token(Token = "0x40040C4")]
		[FieldOffset(Offset = "0x8")]
		public GearItemData m_GearItemData;

		[Token(Token = "0x40040C5")]
		[FieldOffset(Offset = "0x10")]
		public string m_IconName;

		[Token(Token = "0x40040C6")]
		[FieldOffset(Offset = "0x18")]
		public bool m_IsDefault;
	}

	[Token(Token = "0x200066D")]
	private delegate void ScrollDelegate(int itemIndex);

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004043")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Actions> m_ActionsPanel;

	[SerializeField]
	[Token(Token = "0x4004044")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadialPanel;

	[SerializeField]
	[Token(Token = "0x4004045")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_Affliction> m_AfflictionPanel;

	[SerializeField]
	[Token(Token = "0x4004046")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	[SerializeField]
	[Token(Token = "0x4004047")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_Clothing> m_ClothingPanel;

	[SerializeField]
	[Token(Token = "0x4004048")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Crafting> m_CraftingPanel;

	[SerializeField]
	[Token(Token = "0x4004049")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_FirstAid> m_FirstAidPanel;

	[SerializeField]
	[Token(Token = "0x400404A")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBarPanel;

	[SerializeField]
	[Token(Token = "0x400404B")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_Harvest> m_HarvestPanel;

	[SerializeField]
	[Token(Token = "0x400404C")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	[SerializeField]
	[Token(Token = "0x400404D")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_Log> m_LogPanel;

	[SerializeField]
	[Token(Token = "0x400404E")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_Map> m_MapPanel;

	[SerializeField]
	[Token(Token = "0x400404F")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_PickUnits> m_PickUnits;

	[SerializeField]
	[Token(Token = "0x4004050")]
	[FieldOffset(Offset = "0x98")]
	private PanelReference<Panel_PickWater> m_PickWater;

	[SerializeField]
	[Token(Token = "0x4004051")]
	[FieldOffset(Offset = "0xA0")]
	private PanelReference<Panel_Repair> m_RepairPanel;

	[Token(Token = "0x4004052")]
	[FieldOffset(Offset = "0xA8")]
	public MiniTopNav m_MiniTopNav;

	[Token(Token = "0x4004053")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject TableObject;

	[Token(Token = "0x4004054")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject InventoryItemPrefab;

	[Token(Token = "0x4004055")]
	[FieldOffset(Offset = "0xC0")]
	public int m_MaxItemsDisplayAtOnce;

	[Token(Token = "0x4004056")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel m_Label_CarryCapacity;

	[Token(Token = "0x4004057")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_MouseButtonBack;

	[Token(Token = "0x4004058")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject m_MouseButtonSelect;

	[Token(Token = "0x4004059")]
	[FieldOffset(Offset = "0xE0")]
	public UISprite m_CapacityBarOutline;

	[Token(Token = "0x400405A")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite m_CapacityBarSprite;

	[Token(Token = "0x400405B")]
	[FieldOffset(Offset = "0xF0")]
	public Color m_CapacityNormalColor;

	[Token(Token = "0x400405C")]
	[FieldOffset(Offset = "0x100")]
	public Color m_CapacityOverloadColor;

	[Token(Token = "0x400405D")]
	[FieldOffset(Offset = "0x110")]
	public Color m_CapacityBuffColor;

	[Token(Token = "0x400405E")]
	[FieldOffset(Offset = "0x120")]
	public UIButton m_DefaultFilterButton;

	[Token(Token = "0x400405F")]
	[FieldOffset(Offset = "0x128")]
	public UIButton m_DefaultSortButton;

	[Token(Token = "0x4004060")]
	[FieldOffset(Offset = "0x130")]
	public UIButton[] m_SortButtons;

	[Token(Token = "0x4004061")]
	[FieldOffset(Offset = "0x138")]
	public UIButton[] m_FilterButtons;

	[Token(Token = "0x4004062")]
	[FieldOffset(Offset = "0x140")]
	public UILabel m_CategoryLabel;

	[Token(Token = "0x4004063")]
	[FieldOffset(Offset = "0x148")]
	public GameObject m_ScrollbarObject;

	[Token(Token = "0x4004064")]
	[FieldOffset(Offset = "0x150")]
	public Color m_LowConditionColor;

	[Token(Token = "0x4004065")]
	[FieldOffset(Offset = "0x160")]
	public Color m_MediumConditionColor;

	[Token(Token = "0x4004066")]
	[FieldOffset(Offset = "0x170")]
	public Color m_HighConditionColor;

	[Range(0f, 1f)]
	[Token(Token = "0x4004067")]
	[FieldOffset(Offset = "0x180")]
	public float m_AlphaWhenInBackground;

	[Token(Token = "0x4004068")]
	[FieldOffset(Offset = "0x188")]
	public GameObject m_InteractionBlocker;

	[Token(Token = "0x4004069")]
	[FieldOffset(Offset = "0x190")]
	public GameObject m_ButtonBack;

	[Token(Token = "0x400406A")]
	[FieldOffset(Offset = "0x198")]
	public UILabel m_LabelNoItems;

	[Token(Token = "0x400406B")]
	[FieldOffset(Offset = "0x1A0")]
	public Color m_ColorFilterSelected;

	[Token(Token = "0x400406C")]
	[FieldOffset(Offset = "0x1B0")]
	public Color m_ColorFilterSelectedHover;

	[Token(Token = "0x400406D")]
	[FieldOffset(Offset = "0x1C0")]
	public Color m_ColorFilterUnselectedEmpty;

	[Token(Token = "0x400406E")]
	[FieldOffset(Offset = "0x1D0")]
	public Color m_ColorFilterUnselectedEmptyHover;

	[Token(Token = "0x400406F")]
	[FieldOffset(Offset = "0x1E0")]
	public Color m_ColorFilterUnselectedNonempty;

	[Token(Token = "0x4004070")]
	[FieldOffset(Offset = "0x1F0")]
	public Color m_ColorFilterUnselectedNonemptyHover;

	[Token(Token = "0x4004071")]
	[FieldOffset(Offset = "0x200")]
	public Color m_ColorDisabled;

	[Token(Token = "0x4004072")]
	[FieldOffset(Offset = "0x210")]
	public GameObject m_Stats;

	[Token(Token = "0x4004073")]
	[FieldOffset(Offset = "0x218")]
	public UILabel m_AirTempLabel;

	[Token(Token = "0x4004074")]
	[FieldOffset(Offset = "0x220")]
	public UILabel m_AirTempHeaderLabel;

	[Token(Token = "0x4004075")]
	[FieldOffset(Offset = "0x228")]
	public UILabel m_WindChillLabel;

	[Token(Token = "0x4004076")]
	[FieldOffset(Offset = "0x230")]
	public UILabel m_WindChillHeaderLabel;

	[Token(Token = "0x4004077")]
	[FieldOffset(Offset = "0x238")]
	public UILabel m_ClothingWarmthLabel;

	[Token(Token = "0x4004078")]
	[FieldOffset(Offset = "0x240")]
	public UILabel m_ClothingWarmthHeaderLabel;

	[Token(Token = "0x4004079")]
	[FieldOffset(Offset = "0x248")]
	public UILabel m_ClothingWindproofLabel;

	[Token(Token = "0x400407A")]
	[FieldOffset(Offset = "0x250")]
	public UILabel m_ClothingWindproofHeaderLabel;

	[Token(Token = "0x400407B")]
	[FieldOffset(Offset = "0x258")]
	public UILabel m_TemperatureLabel;

	[Token(Token = "0x400407C")]
	[FieldOffset(Offset = "0x260")]
	public GameObject m_SelectedSpriteObj;

	[Token(Token = "0x400407D")]
	[FieldOffset(Offset = "0x268")]
	public TweenScale m_SelectedSpriteTweenScale;

	[Token(Token = "0x400407E")]
	[FieldOffset(Offset = "0x270")]
	public UILabel m_CategoryWeightLabel;

	[Token(Token = "0x400407F")]
	[FieldOffset(Offset = "0x278")]
	public GameObject m_CategoryWeightBG;

	[Token(Token = "0x4004080")]
	[FieldOffset(Offset = "0x280")]
	public UILabel m_ClothingWeightLabel;

	[Token(Token = "0x4004081")]
	[FieldOffset(Offset = "0x288")]
	public GameObject m_ClothingWeightBG;

	[Token(Token = "0x4004082")]
	[FieldOffset(Offset = "0x290")]
	public float m_SecondsBetweenMove;

	[Header("Table Spacing Values")]
	[Token(Token = "0x4004083")]
	[FieldOffset(Offset = "0x294")]
	public int m_TableNumColumns;

	[Token(Token = "0x4004084")]
	[FieldOffset(Offset = "0x298")]
	public float m_TableSpacingHorizontal;

	[Token(Token = "0x4004085")]
	[FieldOffset(Offset = "0x29C")]
	public float m_TableSpacingVertical;

	[Header("Item Description")]
	[Token(Token = "0x4004086")]
	[FieldOffset(Offset = "0x2A0")]
	public GameObject m_ItemDescriptionGameObject;

	[Token(Token = "0x4004087")]
	[FieldOffset(Offset = "0x2A8")]
	public UILabel m_RuinedLabel;

	[Token(Token = "0x4004088")]
	[FieldOffset(Offset = "0x2B0")]
	public GameObject m_ItemDescriptionPageDummy;

	[Token(Token = "0x4004089")]
	[FieldOffset(Offset = "0x2B8")]
	public GameObject m_ItemDescriptionPagePrefab;

	[Token(Token = "0x400408A")]
	[FieldOffset(Offset = "0x2C0")]
	public GameObject m_GearItemCoverflowLocation;

	[Token(Token = "0x400408B")]
	[FieldOffset(Offset = "0x2C8")]
	public GameObject m_GearItemCoverflowPrefab;

	[Header("Sort")]
	[Token(Token = "0x400408C")]
	[FieldOffset(Offset = "0x2D0")]
	public GameObject m_SortLabel;

	[Token(Token = "0x400408D")]
	[FieldOffset(Offset = "0x2D8")]
	public GameObject m_SortButtonsObject;

	[Header("Place")]
	[Range(0.01f, 1f)]
	[Token(Token = "0x400408E")]
	[FieldOffset(Offset = "0x2E0")]
	public float m_PlaceObjectHoldDuration;

	[Header("Button Legend")]
	[Token(Token = "0x400408F")]
	[FieldOffset(Offset = "0x2E8")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4004090")]
	[FieldOffset(Offset = "0x2F0")]
	public ButtonLegendContainer m_SortButtonLegendContainer;

	[Header("Notification Flag")]
	[Token(Token = "0x4004091")]
	[FieldOffset(Offset = "0x2F8")]
	public List<GameObject> m_NotificationFlagsFilterButtons;

	[Header("Selected additional effect")]
	[Token(Token = "0x4004092")]
	[FieldOffset(Offset = "0x300")]
	public GameObject m_SelectedEffect;

	[HideInInspector]
	[Token(Token = "0x4004093")]
	[FieldOffset(Offset = "0x308")]
	public bool m_EnableDiaryOnExit;

	[Header("Backpack Info")]
	[Token(Token = "0x4004094")]
	[FieldOffset(Offset = "0x310")]
	public List<BackpackDisplayInfo> m_BackpackDisplays;

	[Token(Token = "0x4004095")]
	[FieldOffset(Offset = "0x318")]
	public UIButton m_FilterAllButton;

	[Token(Token = "0x4004096")]
	[FieldOffset(Offset = "0x320")]
	public UILabel m_TitleLabel;

	[Header("Common Liquids")]
	[SerializeField]
	[Token(Token = "0x4004097")]
	[FieldOffset(Offset = "0x328")]
	private LiquidType m_Kerosene;

	[Token(Token = "0x4004098")]
	[FieldOffset(Offset = "0x330")]
	private UISlider m_ScrollbarSlider;

	[Token(Token = "0x4004099")]
	[FieldOffset(Offset = "0x338")]
	private UIButton m_SelectedFilterButton;

	[Token(Token = "0x400409A")]
	[FieldOffset(Offset = "0x340")]
	private UIButton m_SelectedSortButton;

	[Token(Token = "0x400409B")]
	[FieldOffset(Offset = "0x348")]
	private string m_SelectedSortOldSprite;

	[Token(Token = "0x400409C")]
	[FieldOffset(Offset = "0x350")]
	private string m_FilterName;

	[Token(Token = "0x400409D")]
	[FieldOffset(Offset = "0x358")]
	private string m_SortName;

	[Token(Token = "0x400409E")]
	[FieldOffset(Offset = "0x360")]
	private Dictionary<string, bool> m_SortFlipDictionary;

	[Token(Token = "0x400409F")]
	[FieldOffset(Offset = "0x368")]
	private int m_SelectedSortIndex;

	[Token(Token = "0x40040A0")]
	[FieldOffset(Offset = "0x36C")]
	private int m_SelectedFilterIndex;

	[Token(Token = "0x40040A1")]
	[FieldOffset(Offset = "0x370")]
	private int m_SelectedItemIndexVal;

	[Token(Token = "0x40040A2")]
	[FieldOffset(Offset = "0x374")]
	private int m_NumItemsDisplayed;

	[Token(Token = "0x40040A3")]
	[FieldOffset(Offset = "0x378")]
	private int m_FirstItemDisplayedIndexVal;

	[Token(Token = "0x40040A4")]
	[FieldOffset(Offset = "0x37C")]
	private int m_NumFramesInPanel;

	[Token(Token = "0x40040A5")]
	[FieldOffset(Offset = "0x380")]
	private uint m_OpenCloseAudioID;

	[Token(Token = "0x40040A6")]
	[FieldOffset(Offset = "0x388")]
	private InventoryGridDataItem m_LastSelectedItem;

	[Token(Token = "0x40040A7")]
	[FieldOffset(Offset = "0x390")]
	private float m_SecondsToNextMove;

	[Token(Token = "0x40040A8")]
	[FieldOffset(Offset = "0x394")]
	private int m_NumColumns;

	[Token(Token = "0x40040A9")]
	[FieldOffset(Offset = "0x398")]
	private readonly List<InventoryGridDataItem> m_FilteredInventoryList;

	[Token(Token = "0x40040AA")]
	[FieldOffset(Offset = "0x3A0")]
	private InventoryGridItem[] m_TableItems;

	[Token(Token = "0x40040AB")]
	[FieldOffset(Offset = "0x3A8")]
	private GearItem m_LastDroppedSingleGearItem;

	[Token(Token = "0x40040AC")]
	[FieldOffset(Offset = "0x3B0")]
	private bool m_IsDirty;

	[Token(Token = "0x40040AD")]
	[FieldOffset(Offset = "0x3B1")]
	private bool m_ForceSelectionUpdate;

	[Token(Token = "0x40040AE")]
	[FieldOffset(Offset = "0x3B8")]
	private ItemDescriptionPage m_ItemDescriptionPage;

	[Token(Token = "0x40040AF")]
	[FieldOffset(Offset = "0x3C0")]
	private GearItemCoverflow m_GearItemCoverflow;

	[Token(Token = "0x40040B0")]
	[FieldOffset(Offset = "0x3C8")]
	private bool m_PausedAndHidden;

	[Token(Token = "0x40040B2")]
	[FieldOffset(Offset = "0x3D0")]
	private Action<GameObject> m_OnItemSelected;

	[Token(Token = "0x40040B3")]
	[FieldOffset(Offset = "0x3D8")]
	public Transform m_SectionNavSelectedSprite;

	[Token(Token = "0x40040B4")]
	[FieldOffset(Offset = "0x3E0")]
	public GameObject m_SectionNavArrowPrompts;

	[Token(Token = "0x40040B5")]
	[FieldOffset(Offset = "0x3E8")]
	private int m_SectionNavIndex;

	[HideInInspector]
	[Token(Token = "0x40040B6")]
	[FieldOffset(Offset = "0x3EC")]
	public bool m_IsInSectionNav;

	[Token(Token = "0x40040B7")]
	[FieldOffset(Offset = "0x3F0")]
	private List<CategoryButton> m_SectionButtons;

	[Token(Token = "0x40040B8")]
	[FieldOffset(Offset = "0x3F8")]
	private float m_DropButtonHeldTime;

	[Token(Token = "0x40040B9")]
	private static readonly bool ENABLE_QUICK_PLACEMENT;

	[Token(Token = "0x40040BA")]
	[FieldOffset(Offset = "0x400")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Token(Token = "0x40040BB")]
	[FieldOffset(Offset = "0x408")]
	private List<GearItem> m_SpecialCarryCapacityBuffItems;

	[Token(Token = "0x40040BC")]
	[FieldOffset(Offset = "0x410")]
	private List<NotificationFlagInfo> m_InventoryNewEntry;

	[Token(Token = "0x40040BD")]
	[FieldOffset(Offset = "0x418")]
	private NotificationFlag m_NotificationFlag;

	[Token(Token = "0x40040BE")]
	[FieldOffset(Offset = "0x420")]
	private Transform[] m_NotificationFlagChildren;

	[Token(Token = "0x40040C0")]
	[FieldOffset(Offset = "0x430")]
	private bool m_MovementPressedOnEnable;

	[Token(Token = "0x40040C1")]
	private const int NUM_SLOTS = 4;

	[Token(Token = "0x40040C2")]
	[FieldOffset(Offset = "0x438")]
	private GameObject[] m_SlotLabels;

	[Token(Token = "0x170002FA")]
	private int m_SelectedItemIndex
	{
		[Token(Token = "0x6003537")]
		[Address(RVA = "0xA7B060", Offset = "0xA79E60", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003538")]
		[Address(RVA = "0xA7B070", Offset = "0xA79E70", Length = "0xAD")]
		set
		{
		}
	}

	[Token(Token = "0x170002FB")]
	private int m_FirstItemDisplayedIndex
	{
		[Token(Token = "0x6003539")]
		[Address(RVA = "0xA7B120", Offset = "0xA79F20", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600353A")]
		[Address(RVA = "0xA7B130", Offset = "0xA79F30", Length = "0x131")]
		set
		{
		}
	}

	[Token(Token = "0x170002FC")]
	[field: Token(Token = "0x40040B1")]
	[field: FieldOffset(Offset = "0x3C9")]
	public bool IsInSelectMode
	{
		[Token(Token = "0x600353B")]
		[Address(RVA = "0xA7B270", Offset = "0xA7A070", Length = "0x8")]
		get;
		[Token(Token = "0x600353C")]
		[Address(RVA = "0xA7B280", Offset = "0xA7A080", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x14000007")]
	public event Action<string, NotificationFlagInfo> m_ItemSelected
	{
		[CompilerGenerated]
		[Token(Token = "0x600353D")]
		[Address(RVA = "0xA7B290", Offset = "0xA7A090", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600353E")]
		[Address(RVA = "0xA7B400", Offset = "0xA7A200", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x600353F")]
	[Address(RVA = "0xA7B570", Offset = "0xA7A370", Length = "0x9F7")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003540")]
	[Address(RVA = "0xA7BF70", Offset = "0xA7AD70", Length = "0xB81")]
	private void Update()
	{
	}

	[Token(Token = "0x6003541")]
	[Address(RVA = "0xA7CB00", Offset = "0xA7B900", Length = "0x152")]
	private void UpdateSortNavigation()
	{
	}

	[Token(Token = "0x6003542")]
	[Address(RVA = "0xA7CC60", Offset = "0xA7BA60", Length = "0x17D")]
	private void UpdateFilterNavigation()
	{
	}

	[Token(Token = "0x6003543")]
	[Address(RVA = "0xA7CDE0", Offset = "0xA7BBE0", Length = "0x40F")]
	private void UpdateButtonTriggers()
	{
	}

	[Token(Token = "0x6003544")]
	[Address(RVA = "0xA7D1F0", Offset = "0xA7BFF0", Length = "0x58")]
	private void MaybeFlagMovmentPressedOnEnable()
	{
	}

	[Token(Token = "0x6003545")]
	[Address(RVA = "0xA7D250", Offset = "0xA7C050", Length = "0x70")]
	private bool ShouldIgnoreNavigationInput()
	{
		return false;
	}

	[Token(Token = "0x6003546")]
	[Address(RVA = "0xA7D2C0", Offset = "0xA7C0C0", Length = "0x4B4")]
	public static bool Navigate(MonoBehaviour context, ref int refSelectedIndex, ref int refFirstItemIndex, int itemCount, int tableLength, int numColumns)
	{
		return false;
	}

	[Token(Token = "0x6003547")]
	[Address(RVA = "0xA7D780", Offset = "0xA7C580", Length = "0x6B")]
	private int ClampIndexToFilteredItemsCount(int index)
	{
		return 0;
	}

	[Token(Token = "0x6003548")]
	[Address(RVA = "0xA7D7F0", Offset = "0xA7C5F0", Length = "0xA2")]
	public void ScrollDown()
	{
	}

	[Token(Token = "0x6003549")]
	[Address(RVA = "0xA7D8A0", Offset = "0xA7C6A0", Length = "0x3B")]
	public void ScrollUp()
	{
	}

	[Token(Token = "0x600354A")]
	[Address(RVA = "0xA7D8E0", Offset = "0xA7C6E0", Length = "0x285")]
	private string GetRefuelButtonText(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x600354B")]
	[Address(RVA = "0xA7DB70", Offset = "0xA7C970", Length = "0x87D")]
	private void UpdateButtonStates()
	{
	}

	[Token(Token = "0x600354C")]
	[Address(RVA = "0xA7E3F0", Offset = "0xA7D1F0", Length = "0x101")]
	private void UpdateSelectModeButtons()
	{
	}

	[Token(Token = "0x600354D")]
	[Address(RVA = "0xA7E500", Offset = "0xA7D300", Length = "0x35D")]
	public void RefreshTable()
	{
	}

	[Token(Token = "0x600354E")]
	[Address(RVA = "0xA7E860", Offset = "0xA7D660", Length = "0xB")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600354F")]
	[Address(RVA = "0xA7E870", Offset = "0xA7D670", Length = "0x985")]
	public void Enable(bool enable, bool resetFilter = true)
	{
	}

	[Token(Token = "0x6003550")]
	[Address(RVA = "0xA7F200", Offset = "0xA7E000", Length = "0x64")]
	public void ShowInSelectMode(Action<GameObject> onItemSelected)
	{
	}

	[Token(Token = "0x6003551")]
	[Address(RVA = "0xA7F270", Offset = "0xA7E070", Length = "0x426")]
	public void ResetNotificationsData()
	{
	}

	[Token(Token = "0x6003552")]
	[Address(RVA = "0xA7F6A0", Offset = "0xA7E4A0", Length = "0x8")]
	public void MarkDirty()
	{
	}

	[Token(Token = "0x6003553")]
	[Address(RVA = "0xA7F6B0", Offset = "0xA7E4B0", Length = "0x20")]
	public void SelectGridItem(InventoryGridItem gridItem)
	{
	}

	[Token(Token = "0x6003554")]
	[Address(RVA = "0xA7F6E0", Offset = "0xA7E4E0", Length = "0x23")]
	public override bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6003555")]
	[Address(RVA = "0xA7F710", Offset = "0xA7E510", Length = "0x8")]
	public bool IsPausedAndHidden()
	{
		return false;
	}

	[Token(Token = "0x6003556")]
	[Address(RVA = "0xA7F720", Offset = "0xA7E520", Length = "0x45")]
	public void OnPopupClicked()
	{
	}

	[Token(Token = "0x6003557")]
	[Address(RVA = "0xA7F770", Offset = "0xA7E570", Length = "0xCB")]
	public void OnStatus()
	{
	}

	[Token(Token = "0x6003558")]
	[Address(RVA = "0xA7F840", Offset = "0xA7E640", Length = "0xC3")]
	public void OnLog()
	{
	}

	[Token(Token = "0x6003559")]
	[Address(RVA = "0xA7F910", Offset = "0xA7E710", Length = "0x170")]
	public void OnScrollbarChange()
	{
	}

	[Token(Token = "0x600355A")]
	[Address(RVA = "0xA7FA90", Offset = "0xA7E890", Length = "0x27")]
	public void ResetFilter()
	{
	}

	[Token(Token = "0x600355B")]
	[Address(RVA = "0xA7FAC0", Offset = "0xA7E8C0", Length = "0x41D")]
	public void OnFilterChange(UIButton filterButtonClicked)
	{
	}

	[Token(Token = "0x600355C")]
	[Address(RVA = "0xA7FEE0", Offset = "0xA7ECE0", Length = "0x60C")]
	public void OnSortChange(UIButton sortButtonClicked)
	{
	}

	[Token(Token = "0x600355D")]
	[Address(RVA = "0xA804F0", Offset = "0xA7F2F0", Length = "0x18B")]
	private bool AllowUseAtZeroHP(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600355E")]
	[Address(RVA = "0xA80680", Offset = "0xA7F480", Length = "0x512")]
	public void OnEquip()
	{
	}

	[Token(Token = "0x600355F")]
	[Address(RVA = "0xA80BA0", Offset = "0xA7F9A0", Length = "0x3E1")]
	public void OnExamine()
	{
	}

	[Token(Token = "0x6003560")]
	[Address(RVA = "0xA80F90", Offset = "0xA7FD90", Length = "0xA8")]
	private void PauseAndHide()
	{
	}

	[Token(Token = "0x6003561")]
	[Address(RVA = "0xA81040", Offset = "0xA7FE40", Length = "0x1A1")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x6003562")]
	[Address(RVA = "0xA811F0", Offset = "0xA7FFF0", Length = "0x987")]
	public void OnDrop()
	{
	}

	[Token(Token = "0x6003563")]
	[Address(RVA = "0xA81B80", Offset = "0xA80980", Length = "0x284")]
	private void OnDropDecoration(DecorationItem di)
	{
	}

	[Token(Token = "0x6003564")]
	[Address(RVA = "0xA81E10", Offset = "0xA80C10", Length = "0x23B")]
	public void OnPlace()
	{
	}

	[Token(Token = "0x6003565")]
	[Address(RVA = "0xA82050", Offset = "0xA80E50", Length = "0x649")]
	public void OnRefuel()
	{
	}

	[Token(Token = "0x6003566")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void OnOtherAction()
	{
	}

	[Token(Token = "0x6003567")]
	[Address(RVA = "0xA826A0", Offset = "0xA814A0", Length = "0x196")]
	public void OnHarvest()
	{
	}

	[Token(Token = "0x6003568")]
	[Address(RVA = "0xA82840", Offset = "0xA81640", Length = "0x196")]
	public void OnRepair()
	{
	}

	[Token(Token = "0x6003569")]
	[Address(RVA = "0xA829E0", Offset = "0xA817E0", Length = "0xE6")]
	public void ExitInterface(bool restoreItemInHands)
	{
	}

	[Token(Token = "0x600356A")]
	[Address(RVA = "0xA82AD0", Offset = "0xA818D0", Length = "0x97")]
	private bool IgnoreWaterSupplyItem(WaterSupply ws)
	{
		return false;
	}

	[Token(Token = "0x600356B")]
	[Address(RVA = "0xA82B70", Offset = "0xA81970", Length = "0xFF")]
	private bool IsPausedFlare(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600356C")]
	[Address(RVA = "0xA82C70", Offset = "0xA81A70", Length = "0x16B")]
	private bool ItemPassesFilter(DecorationItem decorationItem, string filterName)
	{
		return false;
	}

	[Token(Token = "0x600356D")]
	[Address(RVA = "0xA82DE0", Offset = "0xA81BE0", Length = "0x5EA")]
	private bool ItemPassesFilter(GearItem pi, string filterName)
	{
		return false;
	}

	[Token(Token = "0x600356E")]
	[Address(RVA = "0xA833D0", Offset = "0xA821D0", Length = "0x10B")]
	public void OnBack()
	{
	}

	[Token(Token = "0x600356F")]
	[Address(RVA = "0xA834E0", Offset = "0xA822E0", Length = "0xEE")]
	public void OnAddToSatchel()
	{
	}

	[Token(Token = "0x6003570")]
	[Address(RVA = "0xA835D0", Offset = "0xA823D0", Length = "0x17F")]
	public void OnControllerScheme(bool isController)
	{
	}

	[Token(Token = "0x6003571")]
	[Address(RVA = "0xA83750", Offset = "0xA82550", Length = "0x4A")]
	public void ReturnFromAddToSatchel()
	{
	}

	[Token(Token = "0x6003572")]
	[Address(RVA = "0xA837A0", Offset = "0xA825A0", Length = "0x156")]
	public bool CanBeAddedToSatchel(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6003573")]
	[Address(RVA = "0xA83900", Offset = "0xA82700", Length = "0x7")]
	public int GetNumFramesInPanel()
	{
		return 0;
	}

	[Token(Token = "0x6003574")]
	[Address(RVA = "0xA83910", Offset = "0xA82710", Length = "0x1FC")]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[Token(Token = "0x6003575")]
	[Address(RVA = "0xA83B10", Offset = "0xA82910", Length = "0xB9")]
	private InventoryGridDataItem GetCurrentlySelectedItem()
	{
		return null;
	}

	[Token(Token = "0x6003576")]
	[Address(RVA = "0xA83BD0", Offset = "0xA829D0", Length = "0x43D")]
	private void InstantiateInventoryTableItems()
	{
	}

	[Token(Token = "0x6003577")]
	[Address(RVA = "0xA84010", Offset = "0xA82E10", Length = "0x5B2")]
	private void InstantiateItemDescriptionPage()
	{
	}

	[Token(Token = "0x6003578")]
	[Address(RVA = "0xA845D0", Offset = "0xA833D0", Length = "0x148")]
	public static int CompareGearByName(GearItem g1, GearItem g2)
	{
		return 0;
	}

	[Token(Token = "0x6003579")]
	[Address(RVA = "0xA84720", Offset = "0xA83520", Length = "0x2A7")]
	public static int CompareGearByNameTorchesLast(GearItem g1, GearItem g2)
	{
		return 0;
	}

	[Token(Token = "0x600357A")]
	[Address(RVA = "0xA849D0", Offset = "0xA837D0", Length = "0x418")]
	public static int CompareGearByNameHarvestableLast(GearItem g1, GearItem g2)
	{
		return 0;
	}

	[Token(Token = "0x600357B")]
	[Address(RVA = "0xA84DF0", Offset = "0xA83BF0", Length = "0x11E")]
	public static int CompareGearByCondition(GearItem g1, GearItem g2)
	{
		return 0;
	}

	[Token(Token = "0x600357C")]
	[Address(RVA = "0xA84F10", Offset = "0xA83D10", Length = "0x117")]
	public static int CompareGearByWeight(GearItem g1, GearItem g2)
	{
		return 0;
	}

	[Token(Token = "0x600357D")]
	[Address(RVA = "0xA85030", Offset = "0xA83E30", Length = "0xE0")]
	public static int CompareDataItemByName(InventoryGridDataItem d1, InventoryGridDataItem d2)
	{
		return 0;
	}

	[Token(Token = "0x600357E")]
	[Address(RVA = "0xA85120", Offset = "0xA83F20", Length = "0xE2")]
	public static int CompareDataItemByCondition(InventoryGridDataItem d1, InventoryGridDataItem d2)
	{
		return 0;
	}

	[Token(Token = "0x600357F")]
	[Address(RVA = "0xA85210", Offset = "0xA84010", Length = "0x14D")]
	public static int CompareDataItemByWeight(InventoryGridDataItem d1, InventoryGridDataItem d2)
	{
		return 0;
	}

	[Token(Token = "0x6003580")]
	[Address(RVA = "0xA85360", Offset = "0xA84160", Length = "0x119B")]
	public void UpdateFilteredInventoryList()
	{
	}

	[Token(Token = "0x6003581")]
	[Address(RVA = "0xA86500", Offset = "0xA85300", Length = "0x9A")]
	public void HandleOnNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x6003582")]
	[Address(RVA = "0xA865A0", Offset = "0xA853A0", Length = "0x1A")]
	public void HandleOnSubcategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x6003583")]
	[Address(RVA = "0xA865C0", Offset = "0xA853C0", Length = "0x397")]
	public void HandleOnInventoryItemRemoved(GearItem gi)
	{
	}

	[Token(Token = "0x6003584")]
	[Address(RVA = "0xA86960", Offset = "0xA85760", Length = "0x17C")]
	public void ShowPanelInventorySubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[Token(Token = "0x6003585")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[Token(Token = "0x6003586")]
	[Address(RVA = "0xA86B00", Offset = "0xA85900", Length = "0x8B")]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[Token(Token = "0x6003587")]
	[Address(RVA = "0xA86B90", Offset = "0xA85990", Length = "0x11E")]
	private bool SelectLastSelectedItem()
	{
		return false;
	}

	[Token(Token = "0x6003588")]
	[Address(RVA = "0xA86CB0", Offset = "0xA85AB0", Length = "0xF1")]
	private void ScrollToBottom()
	{
	}

	[Token(Token = "0x6003589")]
	[Address(RVA = "0xA86DB0", Offset = "0xA85BB0", Length = "0x207")]
	private void RefreshFilterIconColors()
	{
	}

	[Token(Token = "0x600358A")]
	[Address(RVA = "0xA86FC0", Offset = "0xA85DC0", Length = "0x31D")]
	private bool FilterHasNoItems(string filterName)
	{
		return false;
	}

	[Token(Token = "0x600358B")]
	[Address(RVA = "0xA872E0", Offset = "0xA860E0", Length = "0x114")]
	private void RefreshNoItemsLabel()
	{
	}

	[Token(Token = "0x600358C")]
	[Address(RVA = "0xA87400", Offset = "0xA86200", Length = "0x1B4")]
	private void UpdateSortLabels()
	{
	}

	[Token(Token = "0x600358D")]
	[Address(RVA = "0xA875C0", Offset = "0xA863C0", Length = "0xC0")]
	private void UpdateScrollbarThumbSize()
	{
	}

	[Token(Token = "0x600358E")]
	[Address(RVA = "0xA87690", Offset = "0xA86490", Length = "0x91")]
	private void EnableGearStatsBlock(bool enabled)
	{
	}

	[Token(Token = "0x600358F")]
	[Address(RVA = "0xA87730", Offset = "0xA86530", Length = "0x4C9")]
	private void UpdateGearStatsBlock()
	{
	}

	[Token(Token = "0x6003590")]
	[Address(RVA = "0xA87C00", Offset = "0xA86A00", Length = "0xA4")]
	private void DoSectionNavUpdate()
	{
	}

	[Token(Token = "0x6003591")]
	[Address(RVA = "0xA87CB0", Offset = "0xA86AB0", Length = "0x519")]
	private void DoSectionNavControls()
	{
	}

	[Token(Token = "0x6003592")]
	[Address(RVA = "0xA881D0", Offset = "0xA86FD0", Length = "0x97")]
	private bool ShouldEnterSectionNav()
	{
		return false;
	}

	[Token(Token = "0x6003593")]
	[Address(RVA = "0xA88270", Offset = "0xA87070", Length = "0x16D")]
	private void MoveSectionNavToButton(UIButton button)
	{
	}

	[Token(Token = "0x6003594")]
	[Address(RVA = "0xA883E0", Offset = "0xA871E0", Length = "0x200")]
	private void EnterSectionNav()
	{
	}

	[Token(Token = "0x6003595")]
	[Address(RVA = "0xA885F0", Offset = "0xA873F0", Length = "0x306")]
	private void DeselectAllItems()
	{
	}

	[Token(Token = "0x6003596")]
	[Address(RVA = "0xA88900", Offset = "0xA87700", Length = "0x3B")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[Token(Token = "0x6003597")]
	[Address(RVA = "0xA88940", Offset = "0xA87740", Length = "0x5C9")]
	private void RefreshBackpackDisplay()
	{
	}

	[Token(Token = "0x6003598")]
	[Address(RVA = "0xA88F10", Offset = "0xA87D10", Length = "0xBA")]
	private void MaybeShowNotificationFlagForNewInventoryEntry()
	{
	}

	[Token(Token = "0x6003599")]
	[Address(RVA = "0xA88FD0", Offset = "0xA87DD0", Length = "0xA8")]
	private void RemoveNewInventoryEntry(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x600359A")]
	[Address(RVA = "0xA89080", Offset = "0xA87E80", Length = "0x1C3")]
	private void CacheComponents()
	{
	}

	[Token(Token = "0x600359B")]
	[Address(RVA = "0xA89250", Offset = "0xA88050", Length = "0xA")]
	public void OnAssignSlot0()
	{
	}

	[Token(Token = "0x600359C")]
	[Address(RVA = "0xA89260", Offset = "0xA88060", Length = "0xC")]
	public void OnAssignSlot1()
	{
	}

	[Token(Token = "0x600359D")]
	[Address(RVA = "0xA89270", Offset = "0xA88070", Length = "0xC")]
	public void OnAssignSlot2()
	{
	}

	[Token(Token = "0x600359E")]
	[Address(RVA = "0xA89280", Offset = "0xA88080", Length = "0xC")]
	public void OnAssignSlot3()
	{
	}

	[Token(Token = "0x600359F")]
	[Address(RVA = "0xA89290", Offset = "0xA88090", Length = "0x17B")]
	private void InitQuickSelect()
	{
	}

	[Token(Token = "0x60035A0")]
	[Address(RVA = "0xA89410", Offset = "0xA88210", Length = "0x2F")]
	private void UpdateQuickSelect()
	{
	}

	[Token(Token = "0x60035A1")]
	[Address(RVA = "0xA89440", Offset = "0xA88240", Length = "0x444")]
	private void UpdateSlotLabel(int slotIndex)
	{
	}

	[Token(Token = "0x60035A2")]
	[Address(RVA = "0xA89890", Offset = "0xA88690", Length = "0x5FD")]
	private void AssignSlot(int slotIndex)
	{
	}

	[Token(Token = "0x60035A3")]
	[Address(RVA = "0xA89E90", Offset = "0xA88C90", Length = "0x4A1")]
	public Panel_Inventory()
	{
	}
}
