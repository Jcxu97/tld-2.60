using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using TLD.UI.Scroll;
using UnityEngine;

[Token(Token = "0x2000637")]
public class Panel_Crafting : Panel_AutoReferenced, INotificationHandler, IAccelerateTimeProvider, IMiniTopNav, IScrollModel
{
	[Token(Token = "0x2000638")]
	private enum NavArea
	{
		[Token(Token = "0x4003B89")]
		Category,
		[Token(Token = "0x4003B8A")]
		Blueprint
	}

	[Token(Token = "0x2000639")]
	private enum Filter
	{
		[Token(Token = "0x4003B8C")]
		All,
		[Token(Token = "0x4003B8D")]
		Anywhere,
		[Token(Token = "0x4003B8E")]
		Fire,
		[Token(Token = "0x4003B8F")]
		WorkBench,
		[Token(Token = "0x4003B90")]
		Forge,
		[Token(Token = "0x4003B91")]
		AmmoWorkBench,
		[Token(Token = "0x4003B92")]
		FurnitureWorkBench,
		[Token(Token = "0x4003B93")]
		Count
	}

	[Token(Token = "0x200063A")]
	private enum Category
	{
		[Token(Token = "0x4003B95")]
		All,
		[Token(Token = "0x4003B96")]
		FireStarting,
		[Token(Token = "0x4003B97")]
		FirstAid,
		[Token(Token = "0x4003B98")]
		Clothing,
		[Token(Token = "0x4003B99")]
		Tools,
		[Token(Token = "0x4003B9A")]
		Decoration,
		[Token(Token = "0x4003B9B")]
		FoodAndDrink,
		[Token(Token = "0x4003B9C")]
		Furniture
	}

	[Token(Token = "0x4003B4D")]
	[FieldOffset(Offset = "0x30")]
	public MiniTopNav m_MiniTopNav;

	[Header("General")]
	[Token(Token = "0x4003B4E")]
	[FieldOffset(Offset = "0x38")]
	public UIButton m_CraftButton;

	[Token(Token = "0x4003B4F")]
	[FieldOffset(Offset = "0x40")]
	public UIButton m_OpenContainerButton;

	[SerializeField]
	[Token(Token = "0x4003B50")]
	[FieldOffset(Offset = "0x48")]
	private UIGrid m_ButtonGrid;

	[Token(Token = "0x4003B51")]
	[FieldOffset(Offset = "0x50")]
	public float m_CraftingDisplayTimeSeconds;

	[Token(Token = "0x4003B52")]
	[FieldOffset(Offset = "0x58")]
	public CategoryButtonNavigation m_CategoryNavigation;

	[Token(Token = "0x4003B53")]
	[FieldOffset(Offset = "0x60")]
	public List<UIButton> m_FilterButtons;

	[Token(Token = "0x4003B54")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_FilterLabel;

	[Token(Token = "0x4003B55")]
	[FieldOffset(Offset = "0x70")]
	public Color m_RequirementsNotMetTint;

	[Token(Token = "0x4003B56")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_Root;

	[Token(Token = "0x4003B57")]
	[FieldOffset(Offset = "0x88")]
	public float m_SkillIncreaseChanceOnFailure;

	[Token(Token = "0x4003B58")]
	[FieldOffset(Offset = "0x8C")]
	public float m_SkillIncreaseChanceOnSuccess;

	[Header("Blueprints")]
	[SerializeField]
	[Token(Token = "0x4003B59")]
	[FieldOffset(Offset = "0x90")]
	private ScrollBehaviour m_ScrollBehaviour;

	[Header("Selected Blueprint Details")]
	[Token(Token = "0x4003B5A")]
	[FieldOffset(Offset = "0x98")]
	public UILabel m_SelectedDescription;

	[Token(Token = "0x4003B5B")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel m_SelectedName;

	[Token(Token = "0x4003B5C")]
	[FieldOffset(Offset = "0xA8")]
	public UITexture m_SelectedImage;

	[Header("Selected Item Stats")]
	[Token(Token = "0x4003B5D")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_ClothingStatsRoot;

	[Token(Token = "0x4003B5E")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel m_ClothingMobility;

	[Token(Token = "0x4003B5F")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel m_ClothingToughness;

	[Token(Token = "0x4003B60")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel m_ClothingWarmth;

	[Token(Token = "0x4003B61")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel m_ClothingWaterproof;

	[Token(Token = "0x4003B62")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel m_ClothingWindproof;

	[Token(Token = "0x4003B63")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_ItemStatsRoot;

	[Token(Token = "0x4003B64")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel m_ItemCondition;

	[Token(Token = "0x4003B65")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel m_ItemWeight;

	[Token(Token = "0x4003B66")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject m_SelectedDetailsRoot;

	[SerializeField]
	[Token(Token = "0x4003B67")]
	[FieldOffset(Offset = "0x100")]
	private GameObject m_WoodWorkingContainerInfo;

	[Header("Requirements")]
	[Token(Token = "0x4003B68")]
	[FieldOffset(Offset = "0x108")]
	public CraftingRequirementContainer m_RequirementContainer;

	[SerializeField]
	[Token(Token = "0x4003B69")]
	[FieldOffset(Offset = "0x110")]
	private PowderType m_Gunpowder;

	[Header("Button Legend")]
	[Token(Token = "0x4003B6A")]
	[FieldOffset(Offset = "0x118")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003B6B")]
	[FieldOffset(Offset = "0x120")]
	public ButtonLegendContainer m_FilterButtonLegendContainer;

	[Header("Audio")]
	[Token(Token = "0x4003B6C")]
	[FieldOffset(Offset = "0x128")]
	public string m_CloseCraftingFromPanelAudio;

	[Header("Icons")]
	[Token(Token = "0x4003B6D")]
	[FieldOffset(Offset = "0x130")]
	public string m_IconAccelerateTime;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003B6E")]
	[FieldOffset(Offset = "0x138")]
	private PanelReference<Panel_Clothing> m_Clothing;

	[SerializeField]
	[Token(Token = "0x4003B6F")]
	[FieldOffset(Offset = "0x140")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4003B70")]
	[FieldOffset(Offset = "0x148")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4003B71")]
	[FieldOffset(Offset = "0x150")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x4003B72")]
	[FieldOffset(Offset = "0x158")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x4003B73")]
	[FieldOffset(Offset = "0x160")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x4003B74")]
	[FieldOffset(Offset = "0x168")]
	private PanelReference<Panel_Map> m_Map;

	[Token(Token = "0x4003B77")]
	[FieldOffset(Offset = "0x180")]
	private CraftingLocationInterface m_CurrentLocation;

	[Token(Token = "0x4003B78")]
	[FieldOffset(Offset = "0x188")]
	private CraftingLocationInterface m_PreviousLocation;

	[Token(Token = "0x4003B79")]
	[FieldOffset(Offset = "0x190")]
	private int m_FrameCountSinceClosing;

	[Token(Token = "0x4003B7A")]
	[FieldOffset(Offset = "0x198")]
	private readonly List<BlueprintData> m_Blueprints;

	[Token(Token = "0x4003B7B")]
	[FieldOffset(Offset = "0x1A0")]
	private readonly List<BlueprintData> m_FilteredBlueprints;

	[Token(Token = "0x4003B7C")]
	[FieldOffset(Offset = "0x1A8")]
	private bool m_NeedsUpdate;

	[Token(Token = "0x4003B7D")]
	[FieldOffset(Offset = "0x1B0")]
	private readonly CraftingOperation m_CraftingOperation;

	[Token(Token = "0x4003B7E")]
	[FieldOffset(Offset = "0x1B8")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Token(Token = "0x4003B7F")]
	[FieldOffset(Offset = "0x1C0")]
	private bool m_FromPanelOpen;

	[Token(Token = "0x4003B80")]
	[FieldOffset(Offset = "0x1C8")]
	private readonly List<NotificationFlagInfo> m_BlueprintNewEntry;

	[Token(Token = "0x4003B81")]
	[FieldOffset(Offset = "0x1D0")]
	private NotificationFlag m_NotificationFlag;

	[Token(Token = "0x4003B82")]
	[FieldOffset(Offset = "0x1D8")]
	private Transform[] m_NotificationFlagChildren;

	[Token(Token = "0x4003B83")]
	[FieldOffset(Offset = "0x1E0")]
	private readonly List<HighlightButton> m_HighlightButtons;

	[Token(Token = "0x4003B84")]
	[FieldOffset(Offset = "0x1E8")]
	private NavArea m_CurrentNavArea;

	[Token(Token = "0x4003B85")]
	[FieldOffset(Offset = "0x1EC")]
	private Filter m_CurrentFilter;

	[Token(Token = "0x4003B86")]
	[FieldOffset(Offset = "0x1F0")]
	private Category m_CurrentCategory;

	[Token(Token = "0x170002EC")]
	[field: Token(Token = "0x4003B75")]
	[field: FieldOffset(Offset = "0x170")]
	public BlueprintData SelectedBPI
	{
		[Token(Token = "0x60031EC")]
		[Address(RVA = "0x9DC820", Offset = "0x9DB620", Length = "0x8")]
		get;
		[Token(Token = "0x60031ED")]
		[Address(RVA = "0x9DC830", Offset = "0x9DB630", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170002ED")]
	[field: Token(Token = "0x4003B76")]
	[field: FieldOffset(Offset = "0x178")]
	public InProgressCraftItem SelectedWIP
	{
		[Token(Token = "0x60031EE")]
		[Address(RVA = "0x9DC890", Offset = "0x9DB690", Length = "0x8")]
		get;
		[Token(Token = "0x60031EF")]
		[Address(RVA = "0x9DC8A0", Offset = "0x9DB6A0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x14000006")]
	public event Action<string, NotificationFlagInfo> m_ItemSelected
	{
		[CompilerGenerated]
		[Token(Token = "0x60031F0")]
		[Address(RVA = "0x9DC900", Offset = "0x9DB700", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60031F1")]
		[Address(RVA = "0x9DCA70", Offset = "0x9DB870", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x60031F2")]
	[Address(RVA = "0x9DCBE0", Offset = "0x9DB9E0", Length = "0xD41")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60031F3")]
	[Address(RVA = "0x9DD930", Offset = "0x9DC730", Length = "0x153")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60031F4")]
	[Address(RVA = "0x9DDA90", Offset = "0x9DC890", Length = "0x7B")]
	public void OnControllerScheme(bool isController)
	{
	}

	[Token(Token = "0x60031F5")]
	[Address(RVA = "0x9DDB10", Offset = "0x9DC910", Length = "0x185")]
	private void Update()
	{
	}

	[Token(Token = "0x60031F6")]
	[Address(RVA = "0x9DDCA0", Offset = "0x9DCAA0", Length = "0x100")]
	public void UpdateLastLocations()
	{
	}

	[Token(Token = "0x60031F7")]
	[Address(RVA = "0x9DDDB0", Offset = "0x9DCBB0", Length = "0x90")]
	public bool CanCraftBlueprint(BlueprintData bpi)
	{
		return false;
	}

	[Token(Token = "0x60031F8")]
	[Address(RVA = "0x9DDE50", Offset = "0x9DCC50", Length = "0x1D1")]
	public bool CanCraftSelectedBlueprint()
	{
		return false;
	}

	[Token(Token = "0x60031F9")]
	[Address(RVA = "0x9DE030", Offset = "0x9DCE30", Length = "0xB")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60031FA")]
	[Address(RVA = "0x9DE040", Offset = "0x9DCE40", Length = "0x5DC")]
	public void Enable(bool enable, bool fromPanel)
	{
	}

	[Token(Token = "0x60031FB")]
	[Address(RVA = "0x9DE640", Offset = "0x9DD440", Length = "0x334")]
	public void ResetNotificationsData()
	{
	}

	[Token(Token = "0x60031FC")]
	[Address(RVA = "0x9DE980", Offset = "0x9DD780", Length = "0x51")]
	public CraftingLocation GetCurrentCraftingLocation()
	{
		return default(CraftingLocation);
	}

	[Token(Token = "0x60031FD")]
	[Address(RVA = "0x9DE9E0", Offset = "0x9DD7E0", Length = "0x34E")]
	private int GetModifiedCraftingDuration(int baseMinutes)
	{
		return 0;
	}

	[Token(Token = "0x60031FE")]
	[Address(RVA = "0x9DED30", Offset = "0x9DDB30", Length = "0x205")]
	public int GetAdjustedCraftingTime()
	{
		return 0;
	}

	[Token(Token = "0x60031FF")]
	[Address(RVA = "0x9DEF40", Offset = "0x9DDD40", Length = "0x22F")]
	public int GetFinalCraftingTimeWithAllModifiers()
	{
		return 0;
	}

	[Token(Token = "0x6003200")]
	[Address(RVA = "0x9DF170", Offset = "0x9DDF70", Length = "0x197")]
	public void OnBackButton()
	{
	}

	[Token(Token = "0x6003201")]
	[Address(RVA = "0x9DF310", Offset = "0x9DE110", Length = "0x10E")]
	public void OnOpenCraftingContainer()
	{
	}

	[Token(Token = "0x6003202")]
	[Address(RVA = "0x9DF420", Offset = "0x9DE220", Length = "0x3A9")]
	public void OnBeginCrafting()
	{
	}

	[Token(Token = "0x6003203")]
	[Address(RVA = "0x9DF7D0", Offset = "0x9DE5D0", Length = "0x23")]
	public void OnCancelCrafting()
	{
	}

	[Token(Token = "0x6003204")]
	[Address(RVA = "0x9DF800", Offset = "0x9DE600", Length = "0x44")]
	public void OnCategoryChanged(int index)
	{
	}

	[Token(Token = "0x6003205")]
	[Address(RVA = "0x9DF850", Offset = "0x9DE650", Length = "0x8")]
	public void OnSelectedToolChanged()
	{
	}

	[Token(Token = "0x6003206")]
	[Address(RVA = "0x9DF860", Offset = "0x9DE660", Length = "0x1C1")]
	public void OnFilterChange(UIButton button)
	{
	}

	[Token(Token = "0x6003207")]
	[Address(RVA = "0x9DFA30", Offset = "0x9DE830", Length = "0xBB")]
	public void EnableCraftingAtLocation(CraftingLocationInterface location)
	{
	}

	[Token(Token = "0x6003208")]
	[Address(RVA = "0x9DFAF0", Offset = "0x9DE8F0", Length = "0x9A")]
	public void HandleOnNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x6003209")]
	[Address(RVA = "0x9DFB90", Offset = "0x9DE990", Length = "0x1A")]
	public void HandleOnSubcategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x600320A")]
	[Address(RVA = "0x9DFBB0", Offset = "0x9DE9B0", Length = "0x160")]
	public void ShowPanelCraftingSubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[Token(Token = "0x600320B")]
	[Address(RVA = "0x9DF850", Offset = "0x9DE650", Length = "0x8")]
	public void OnSelectedQuantityChanged()
	{
	}

	[Token(Token = "0x600320C")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[Token(Token = "0x600320D")]
	[Address(RVA = "0x9DFD30", Offset = "0x9DEB30", Length = "0x8E")]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[Token(Token = "0x600320E")]
	[Address(RVA = "0x9DFDC0", Offset = "0x9DEBC0", Length = "0x5D4")]
	private void ApplyFilter()
	{
	}

	[Token(Token = "0x600320F")]
	[Address(RVA = "0x9E03B0", Offset = "0x9DF1B0", Length = "0x4AC")]
	private bool ItemPassesFilter(BlueprintData bpi)
	{
		return false;
	}

	[Token(Token = "0x6003210")]
	[Address(RVA = "0x9E0880", Offset = "0x9DF680", Length = "0x93")]
	private void CraftingEnd()
	{
	}

	[Token(Token = "0x6003211")]
	[Address(RVA = "0x9E0920", Offset = "0x9DF720", Length = "0x469")]
	private void CraftingStart()
	{
	}

	[Token(Token = "0x6003212")]
	[Address(RVA = "0x9E0D90", Offset = "0x9DFB90", Length = "0x104")]
	private void OnCraftingInterrupted(CraftingInterruptReason reason)
	{
	}

	[Token(Token = "0x6003213")]
	[Address(RVA = "0x9E0EA0", Offset = "0x9DFCA0", Length = "0x625")]
	private void OnCraftingSuccess()
	{
	}

	[Token(Token = "0x6003214")]
	[Address(RVA = "0x9E14D0", Offset = "0x9E02D0", Length = "0x538")]
	private void UpdateControllerButtons()
	{
	}

	[Token(Token = "0x6003215")]
	[Address(RVA = "0x9E1A10", Offset = "0x9E0810", Length = "0x1D8")]
	private void UpdateMouseKeyboardButtons()
	{
	}

	[Token(Token = "0x6003216")]
	[Address(RVA = "0x9E1BF0", Offset = "0x9E09F0", Length = "0xDB")]
	private bool ShowOpenContainerButton()
	{
		return false;
	}

	[Token(Token = "0x6003217")]
	[Address(RVA = "0x9B6190", Offset = "0x9B4F90", Length = "0x38")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[Token(Token = "0x6003218")]
	[Address(RVA = "0x9E1CD0", Offset = "0x9E0AD0", Length = "0x5D4")]
	private InProgressCraftItem GetInProgressItem(BlueprintData bpi)
	{
		return null;
	}

	[Token(Token = "0x6003219")]
	[Address(RVA = "0x9E22B0", Offset = "0x9E10B0", Length = "0x4C7")]
	private void HandleInput()
	{
	}

	[Token(Token = "0x600321A")]
	[Address(RVA = "0x9E2780", Offset = "0x9E1580", Length = "0x3D")]
	private bool ShouldAllowForSurvivalMode(BlueprintData bp)
	{
		return false;
	}

	[Token(Token = "0x600321B")]
	[Address(RVA = "0x9E27C0", Offset = "0x9E15C0", Length = "0x37")]
	private bool ShouldAllowForStoryMode(BlueprintData bp)
	{
		return false;
	}

	[Token(Token = "0x600321C")]
	[Address(RVA = "0x9E2800", Offset = "0x9E1600", Length = "0x11C")]
	private static bool IsBirchBarkTea(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x600321D")]
	[Address(RVA = "0x9E2920", Offset = "0x9E1720", Length = "0x202")]
	private bool ShouldBlockBasedOnCustomMode(BlueprintData bp)
	{
		return false;
	}

	[Token(Token = "0x600321E")]
	[Address(RVA = "0x9E2B30", Offset = "0x9E1930", Length = "0x171")]
	private void RefreshAvailableBlueprints()
	{
	}

	[Token(Token = "0x600321F")]
	[Address(RVA = "0x9E2CB0", Offset = "0x9E1AB0", Length = "0xA3F")]
	private void RefreshSelectedBlueprint(int index)
	{
	}

	[Token(Token = "0x6003220")]
	[Address(RVA = "0x9E36F0", Offset = "0x9E24F0", Length = "0x132")]
	private string CreateNegativePercentageText(float pct)
	{
		return null;
	}

	[Token(Token = "0x6003221")]
	[Address(RVA = "0x9E3830", Offset = "0x9E2630", Length = "0xAA")]
	private void ResetLastLocations()
	{
	}

	[Token(Token = "0x6003222")]
	[Address(RVA = "0x9E38E0", Offset = "0x9E26E0", Length = "0xDC")]
	private void SetFilter(Filter filter)
	{
	}

	[Token(Token = "0x6003223")]
	[Address(RVA = "0x9E39C0", Offset = "0x9E27C0", Length = "0x5C")]
	private void SetNavigationArea(NavArea target)
	{
	}

	[Token(Token = "0x6003224")]
	[Address(RVA = "0x9E3A20", Offset = "0x9E2820", Length = "0x2B7")]
	private void RemoveNewBlueprintEntry(BlueprintData blueprintData)
	{
	}

	[Token(Token = "0x6003225")]
	[Address(RVA = "0x9E3CE0", Offset = "0x9E2AE0", Length = "0x1C3")]
	private void CacheComponents()
	{
	}

	[Token(Token = "0x6003226")]
	[Address(RVA = "0x9E3EB0", Offset = "0x9E2CB0", Length = "0xA8")]
	private Filter GetFilterFromLocation()
	{
		return default(Filter);
	}

	[Token(Token = "0x6003227")]
	[Address(RVA = "0x9E3F80", Offset = "0x9E2D80", Length = "0x64B")]
	public void BuildItem(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem item, int index)
	{
	}

	[Token(Token = "0x6003228")]
	[Address(RVA = "0x9E45D0", Offset = "0x9E33D0", Length = "0x19D")]
	public void UpdateSelected(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem selectedItem, int selectedIndex)
	{
	}

	[Token(Token = "0x6003229")]
	[Address(RVA = "0x9E4770", Offset = "0x9E3570", Length = "0xB7")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x600322A")]
	[Address(RVA = "0x9E4830", Offset = "0x9E3630", Length = "0x5D")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x600322B")]
	[Address(RVA = "0x8E67C0", Offset = "0x8E55C0", Length = "0x8")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x600322C")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x600322D")]
	[Address(RVA = "0x9E4890", Offset = "0x9E3690", Length = "0x71")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x600322E")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x600322F")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x6003230")]
	[Address(RVA = "0x9E4910", Offset = "0x9E3710", Length = "0x44F")]
	public Panel_Crafting()
	{
	}
}
