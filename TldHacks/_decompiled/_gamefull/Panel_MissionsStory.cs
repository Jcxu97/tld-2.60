using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.GameplayTags;
using TLD.OptionalContent;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;

[Token(Token = "0x20006A5")]
public class Panel_MissionsStory : Panel_AutoReferenced, INotificationHandler, IMiniTopNav
{
	[Token(Token = "0x20006A6")]
	private enum NavArea
	{
		[Token(Token = "0x4004603")]
		Category,
		[Token(Token = "0x4004604")]
		Missions
	}

	[Token(Token = "0x20006A7")]
	private enum PanelState
	{
		[Token(Token = "0x4004606")]
		Main,
		[Token(Token = "0x4004607")]
		Side,
		[Token(Token = "0x4004608")]
		Completed
	}

	[Token(Token = "0x40045B3")]
	public static int OBJECT_POOL_SIZE;

	[Header("Object References")]
	[Token(Token = "0x40045B4")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40045B5")]
	[FieldOffset(Offset = "0x38")]
	public MiniTopNav m_MiniTopNav;

	[Token(Token = "0x40045B6")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_MainTitleString;

	[Token(Token = "0x40045B7")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_TalesTitleString;

	[Token(Token = "0x40045B8")]
	[FieldOffset(Offset = "0x50")]
	public LocalizedString m_TalesObjectivesString;

	[Token(Token = "0x40045B9")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_MainTitleLabel;

	[Token(Token = "0x40045BA")]
	[FieldOffset(Offset = "0x60")]
	public ScrollList m_MainMissionScrollList;

	[Token(Token = "0x40045BB")]
	[FieldOffset(Offset = "0x68")]
	public ScrollList m_SideMissionScrollList;

	[Token(Token = "0x40045BC")]
	[FieldOffset(Offset = "0x70")]
	public ScrollList m_CompletedMissionScrollList;

	[Token(Token = "0x40045BD")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_MissionListScrollbar;

	[Token(Token = "0x40045BE")]
	[FieldOffset(Offset = "0x80")]
	public UITexture m_EpisodeOnePoster;

	[Token(Token = "0x40045BF")]
	[FieldOffset(Offset = "0x88")]
	public UITexture m_EpisodeTwoPoster;

	[Token(Token = "0x40045C0")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_SectionNavSelected;

	[Token(Token = "0x40045C1")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_TabsMainObject;

	[Token(Token = "0x40045C2")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_TabsSideObject;

	[Token(Token = "0x40045C3")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_TabsCompletedObject;

	[Token(Token = "0x40045C4")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_RightPageObject;

	[Token(Token = "0x40045C5")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_MissionObjectivePrefab;

	[Token(Token = "0x40045C6")]
	[FieldOffset(Offset = "0xC0")]
	public Transform m_MissionObjetivePoolParent;

	[Token(Token = "0x40045C7")]
	[FieldOffset(Offset = "0xC8")]
	public Transform m_MissionObjetiveActiveObjects;

	[Token(Token = "0x40045C8")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel m_SelectedMissionName;

	[Token(Token = "0x40045C9")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel m_TimerLabel;

	[Token(Token = "0x40045CA")]
	[FieldOffset(Offset = "0xE0")]
	public UISprite m_TimerBGSprite;

	[Token(Token = "0x40045CB")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject m_TimerObject;

	[Token(Token = "0x40045CC")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel m_SideMissionDescLabel;

	[Token(Token = "0x40045CD")]
	[FieldOffset(Offset = "0xF8")]
	public UILabel m_CompletedMissionDescLabel;

	[Token(Token = "0x40045CE")]
	[FieldOffset(Offset = "0x100")]
	public UIPanel m_MissionDescPanel;

	[Token(Token = "0x40045CF")]
	[FieldOffset(Offset = "0x108")]
	public Transform m_MissionDescPanelOffset;

	[Token(Token = "0x40045D0")]
	[FieldOffset(Offset = "0x110")]
	public GameObject m_MissionDescScrollbar;

	[Token(Token = "0x40045D1")]
	[FieldOffset(Offset = "0x118")]
	public UIButton[] m_FilterButtons;

	[Token(Token = "0x40045D2")]
	[FieldOffset(Offset = "0x120")]
	public GameObject m_Button_Back;

	[Token(Token = "0x40045D3")]
	[FieldOffset(Offset = "0x128")]
	public GameObject m_Button_SeeMap;

	[Token(Token = "0x40045D4")]
	[FieldOffset(Offset = "0x130")]
	public GameObject m_Button_Main;

	[Token(Token = "0x40045D5")]
	[FieldOffset(Offset = "0x138")]
	public GameObject m_Button_Side;

	[Token(Token = "0x40045D6")]
	[FieldOffset(Offset = "0x140")]
	public GameObject m_Button_Completed;

	[Token(Token = "0x40045D7")]
	[FieldOffset(Offset = "0x148")]
	public UITexture m_MissionArtTexture;

	[SerializeField]
	[Token(Token = "0x40045D8")]
	[FieldOffset(Offset = "0x150")]
	private OptionalContentConfig m_ExpansionPassConfig;

	[SerializeField]
	[Token(Token = "0x40045D9")]
	[FieldOffset(Offset = "0x158")]
	private GameplayTag m_TalesAvailable;

	[Token(Token = "0x40045DA")]
	[FieldOffset(Offset = "0x168")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Header("Tunables")]
	[Tooltip("If the remaining time / total time is less than this value, use the low time color")]
	[Token(Token = "0x40045DB")]
	[FieldOffset(Offset = "0x170")]
	public float m_LowTimeValue;

	[Token(Token = "0x40045DC")]
	[FieldOffset(Offset = "0x174")]
	public int m_PixelBufferDescAndObjectives;

	[Token(Token = "0x40045DD")]
	[FieldOffset(Offset = "0x178")]
	public int m_PixelBufferTimer;

	[Token(Token = "0x40045DE")]
	[FieldOffset(Offset = "0x17C")]
	public Color m_TimerColorNormal;

	[Token(Token = "0x40045DF")]
	[FieldOffset(Offset = "0x18C")]
	public Color m_TimerColorLowTime;

	[Header("Notification Flag")]
	[Token(Token = "0x40045E0")]
	[FieldOffset(Offset = "0x1A0")]
	public GameObject m_ButtonMainNotificationFlag;

	[Token(Token = "0x40045E1")]
	[FieldOffset(Offset = "0x1A8")]
	public GameObject m_ButtonSideNotificationFlag;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40045E2")]
	[FieldOffset(Offset = "0x1B0")]
	private PanelReference<Panel_Clothing> m_Clothing;

	[SerializeField]
	[Token(Token = "0x40045E3")]
	[FieldOffset(Offset = "0x1B8")]
	private PanelReference<Panel_Crafting> m_CraftingPanel;

	[SerializeField]
	[Token(Token = "0x40045E4")]
	[FieldOffset(Offset = "0x1C0")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x40045E5")]
	[FieldOffset(Offset = "0x1C8")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x40045E6")]
	[FieldOffset(Offset = "0x1D0")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x40045E7")]
	[FieldOffset(Offset = "0x1D8")]
	private PanelReference<Panel_Map> m_Map;

	[NonSerialized]
	[Token(Token = "0x40045E8")]
	[FieldOffset(Offset = "0x1E0")]
	public bool m_HasBeenUpdated;

	[Token(Token = "0x40045E9")]
	[FieldOffset(Offset = "0x1E8")]
	private readonly List<StoryMissionInfo> m_MissionsToShowScrollList;

	[Token(Token = "0x40045EA")]
	[FieldOffset(Offset = "0x1F0")]
	private readonly List<StoryMissionObjective> m_ObjectivesToShowRightPage;

	[Token(Token = "0x40045EB")]
	[FieldOffset(Offset = "0x1F8")]
	private readonly List<StoryMissionListEntry> m_MissionScrollListEntries;

	[Token(Token = "0x40045EC")]
	[FieldOffset(Offset = "0x200")]
	private int m_CurrentMissionIndex;

	[Token(Token = "0x40045ED")]
	[FieldOffset(Offset = "0x204")]
	private float m_MissionDescPanelHeight;

	[Token(Token = "0x40045EE")]
	[FieldOffset(Offset = "0x208")]
	private readonly List<string> m_QueueNotificationHeaders;

	[Token(Token = "0x40045EF")]
	[FieldOffset(Offset = "0x210")]
	private readonly List<string> m_QueueNotificationBodies;

	[Token(Token = "0x40045F0")]
	[FieldOffset(Offset = "0x218")]
	private ScrollList m_MissionScrollList;

	[Token(Token = "0x40045F1")]
	[FieldOffset(Offset = "0x220")]
	private UILabel m_MissionDescLabel;

	[Token(Token = "0x40045F2")]
	[FieldOffset(Offset = "0x228")]
	private UISlider m_MissionListScrollbarSlider;

	[Token(Token = "0x40045F3")]
	[FieldOffset(Offset = "0x230")]
	private UISlider m_MissionDescScrollbarSlider;

	[Token(Token = "0x40045F4")]
	[FieldOffset(Offset = "0x238")]
	private ScrollbarThumbResizer m_MissionListScrollbarThumbResizer;

	[Token(Token = "0x40045F5")]
	[FieldOffset(Offset = "0x240")]
	private ScrollbarThumbResizer m_MissionDescScrollbarThumbResizer;

	[Token(Token = "0x40045F6")]
	[FieldOffset(Offset = "0x248")]
	private readonly List<CategoryButton> m_CategoryButtons;

	[Token(Token = "0x40045F7")]
	[FieldOffset(Offset = "0x250")]
	private int m_SectionNavIndex;

	[Token(Token = "0x40045F8")]
	[FieldOffset(Offset = "0x258")]
	private UIButton m_ButtonMain;

	[Token(Token = "0x40045F9")]
	[FieldOffset(Offset = "0x260")]
	private UIButton m_ButtonSide;

	[Token(Token = "0x40045FA")]
	[FieldOffset(Offset = "0x268")]
	private readonly List<NotificationFlagInfo> m_MissionNewEntry;

	[Token(Token = "0x40045FB")]
	[FieldOffset(Offset = "0x270")]
	private NotificationFlag m_NotificationFlag;

	[Token(Token = "0x40045FC")]
	[FieldOffset(Offset = "0x278")]
	private Transform[] m_NotificationFlagChildren;

	[Token(Token = "0x40045FD")]
	[FieldOffset(Offset = "0x280")]
	private UIButton m_ButtonCompleted;

	[Token(Token = "0x40045FE")]
	[FieldOffset(Offset = "0x288")]
	private NavArea m_CurrentNavArea;

	[Token(Token = "0x40045FF")]
	[FieldOffset(Offset = "0x28C")]
	private PanelState m_PanelState;

	[Token(Token = "0x4004600")]
	private static AssetBundleRef s_MissionTexturesBundle;

	[Token(Token = "0x14000009")]
	public event Action<string, NotificationFlagInfo> m_ItemSelected
	{
		[CompilerGenerated]
		[Token(Token = "0x60038FF")]
		[Address(RVA = "0xB36D20", Offset = "0xB35B20", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003900")]
		[Address(RVA = "0xB36E90", Offset = "0xB35C90", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6003901")]
	[Address(RVA = "0xB37000", Offset = "0xB35E00", Length = "0xD52")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003902")]
	[Address(RVA = "0xB37D60", Offset = "0xB36B60", Length = "0x22D")]
	private void Update()
	{
	}

	[Token(Token = "0x6003903")]
	[Address(RVA = "0xB37F90", Offset = "0xB36D90", Length = "0xA98")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003904")]
	[Address(RVA = "0xB38A30", Offset = "0xB37830", Length = "0xBA")]
	public void DeselectAllMissions()
	{
	}

	[Token(Token = "0x6003905")]
	[Address(RVA = "0xB38AF0", Offset = "0xB378F0", Length = "0x128")]
	public void SelectMissionListEntry(string missionID)
	{
	}

	[Token(Token = "0x6003906")]
	[Address(RVA = "0xB38C20", Offset = "0xB37A20", Length = "0x6B")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003907")]
	[Address(RVA = "0xB38C90", Offset = "0xB37A90", Length = "0x1082")]
	public void OnNavigationChanged(UIButton button)
	{
	}

	[Token(Token = "0x6003908")]
	[Address(RVA = "0xB39D20", Offset = "0xB38B20", Length = "0x251")]
	public void OnMissionListEntrySelected(int index)
	{
	}

	[Token(Token = "0x6003909")]
	[Address(RVA = "0xB39F80", Offset = "0xB38D80", Length = "0x16F")]
	public void MaybeShowNotificationsInQueue()
	{
	}

	[Token(Token = "0x600390A")]
	[Address(RVA = "0xB3A0F0", Offset = "0xB38EF0", Length = "0x173")]
	public void OnScrollbarMissionDescUp()
	{
	}

	[Token(Token = "0x600390B")]
	[Address(RVA = "0xB3A270", Offset = "0xB39070", Length = "0x173")]
	public void OnScrollbarMissionDescDown()
	{
	}

	[Token(Token = "0x600390C")]
	[Address(RVA = "0xB3A3F0", Offset = "0xB391F0", Length = "0x55")]
	public void OnScrollbarMissionDescChange()
	{
	}

	[Token(Token = "0x600390D")]
	[Address(RVA = "0xB3A450", Offset = "0xB39250", Length = "0x38")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[Token(Token = "0x600390E")]
	[Address(RVA = "0xB3A490", Offset = "0xB39290", Length = "0x1A8")]
	public void OnMapNav()
	{
	}

	[Token(Token = "0x600390F")]
	[Address(RVA = "0xB3A640", Offset = "0xB39440", Length = "0xCD")]
	public void OnDailyLogButton()
	{
	}

	[Token(Token = "0x6003910")]
	[Address(RVA = "0xB3A710", Offset = "0xB39510", Length = "0xCD")]
	public void OnStatsButton()
	{
	}

	[Token(Token = "0x6003911")]
	[Address(RVA = "0xB3A7E0", Offset = "0xB395E0", Length = "0xCD")]
	public void OnCollectibleButton()
	{
	}

	[Token(Token = "0x6003912")]
	[Address(RVA = "0xB3A8B0", Offset = "0xB396B0", Length = "0xCD")]
	public void OnRockCachesButton()
	{
	}

	[Token(Token = "0x6003913")]
	[Address(RVA = "0xB3A980", Offset = "0xB39780", Length = "0xCD")]
	public void OnSkillsButton()
	{
	}

	[Token(Token = "0x6003914")]
	[Address(RVA = "0xB3AA50", Offset = "0xB39850", Length = "0xD0")]
	public void OnCraftingButton()
	{
	}

	[Token(Token = "0x6003915")]
	[Address(RVA = "0x54A2C0", Offset = "0x5490C0", Length = "0x8")]
	public List<StoryMissionObjective> GetObjectivesToShow()
	{
		return null;
	}

	[Token(Token = "0x6003916")]
	[Address(RVA = "0xB3AB30", Offset = "0xB39930", Length = "0xAB")]
	public string GetCurrentMissionId()
	{
		return null;
	}

	[Token(Token = "0x6003917")]
	[Address(RVA = "0xB3ABE0", Offset = "0xB399E0", Length = "0x2D9")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003918")]
	[Address(RVA = "0xB3AEC0", Offset = "0xB39CC0", Length = "0x405")]
	private void UpdateGamepadControls()
	{
	}

	[Token(Token = "0x6003919")]
	[Address(RVA = "0xB3B2D0", Offset = "0xB3A0D0", Length = "0x15C")]
	private void UpdateScrollControls()
	{
	}

	[Token(Token = "0x600391A")]
	[Address(RVA = "0xB3B430", Offset = "0xB3A230", Length = "0x238")]
	private void HandleVerticalMovement(float movement)
	{
	}

	[Token(Token = "0x600391B")]
	[Address(RVA = "0xB3B670", Offset = "0xB3A470", Length = "0x25")]
	private void HandleVerticalRightStick(float verticalRS)
	{
	}

	[Token(Token = "0x600391C")]
	[Address(RVA = "0xB3B6A0", Offset = "0xB3A4A0", Length = "0x7")]
	private void OnBack()
	{
	}

	[Token(Token = "0x600391D")]
	[Address(RVA = "0xB3B6B0", Offset = "0xB3A4B0", Length = "0x94B")]
	private void RefreshScrollList()
	{
	}

	[Token(Token = "0x600391E")]
	[Address(RVA = "0xB3C000", Offset = "0xB3AE00", Length = "0x10E")]
	public void OnScrollbarMissionListChanged()
	{
	}

	[Token(Token = "0x600391F")]
	[Address(RVA = "0xB3C110", Offset = "0xB3AF10", Length = "0x19E")]
	public void UpdateMissionListScrollingForCurrentIndex()
	{
	}

	[Token(Token = "0x6003920")]
	[Address(RVA = "0xB3C2B0", Offset = "0xB3B0B0", Length = "0x21A")]
	public void NavigateToMissionById(string missionId)
	{
	}

	[Token(Token = "0x6003921")]
	[Address(RVA = "0xB3C4D0", Offset = "0xB3B2D0", Length = "0xE5")]
	private int GetMissionListScrollIndex()
	{
		return 0;
	}

	[Token(Token = "0x6003922")]
	[Address(RVA = "0xB3C5C0", Offset = "0xB3B3C0", Length = "0xEFE")]
	private void RefreshDescriptionPage()
	{
	}

	[Token(Token = "0x6003923")]
	[Address(RVA = "0xB3D4C0", Offset = "0xB3C2C0", Length = "0x4DE")]
	private void RefreshMissionsToShow()
	{
	}

	[Token(Token = "0x6003924")]
	[Address(RVA = "0xB3D9A0", Offset = "0xB3C7A0", Length = "0x2E7")]
	public void RefreshObjectivesToShow(string missionID)
	{
	}

	[Token(Token = "0x6003925")]
	[Address(RVA = "0xB3DC90", Offset = "0xB3CA90", Length = "0x492")]
	public void ResetNotificationsData()
	{
	}

	[Token(Token = "0x6003926")]
	[Address(RVA = "0xB3E130", Offset = "0xB3CF30", Length = "0x9A")]
	public void HandleOnNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x6003927")]
	[Address(RVA = "0xB3E1D0", Offset = "0xB3CFD0", Length = "0x6D")]
	public void HandleOnSubcategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x6003928")]
	[Address(RVA = "0xB3E240", Offset = "0xB3D040", Length = "0x5C")]
	public void ShowPanelMissionSubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[Token(Token = "0x6003929")]
	[Address(RVA = "0xB3E2A0", Offset = "0xB3D0A0", Length = "0x7E")]
	public void AddNewMissionEntry(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x600392A")]
	[Address(RVA = "0xB3E320", Offset = "0xB3D120", Length = "0x298")]
	public bool AreTalesAvailable()
	{
		return false;
	}

	[Token(Token = "0x600392B")]
	[Address(RVA = "0xB3E5C0", Offset = "0xB3D3C0", Length = "0x106")]
	public bool IsChallengeMode()
	{
		return false;
	}

	[Token(Token = "0x600392C")]
	[Address(RVA = "0xB3E6D0", Offset = "0xB3D4D0", Length = "0x2B")]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[Token(Token = "0x600392D")]
	[Address(RVA = "0xB3E700", Offset = "0xB3D500", Length = "0x137")]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[Token(Token = "0x600392E")]
	[Address(RVA = "0xB3E840", Offset = "0xB3D640", Length = "0x1A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600392F")]
	[Address(RVA = "0xB3E9F0", Offset = "0xB3D7F0", Length = "0x1A9")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003930")]
	[Address(RVA = "0xB3EBA0", Offset = "0xB3D9A0", Length = "0x1EE")]
	private void QueueMissionNotification(string header, string body)
	{
	}

	[Token(Token = "0x6003931")]
	[Address(RVA = "0xB3ED90", Offset = "0xB3DB90", Length = "0x126")]
	private int GetMissionListEntryIndex(string missionID)
	{
		return 0;
	}

	[Token(Token = "0x6003932")]
	[Address(RVA = "0xB3EEC0", Offset = "0xB3DCC0", Length = "0x12B")]
	private void SetupMissionDescScrollbar(float pixelHeightRightSide)
	{
	}

	[Token(Token = "0x6003933")]
	[Address(RVA = "0xB3EFF0", Offset = "0xB3DDF0", Length = "0x153")]
	private void UpdateMissionDescScrollbar()
	{
	}

	[Token(Token = "0x6003934")]
	[Address(RVA = "0xB3F150", Offset = "0xB3DF50", Length = "0x46")]
	private void FSMForceRefresh()
	{
	}

	[Token(Token = "0x6003935")]
	[Address(RVA = "0xB3F1A0", Offset = "0xB3DFA0", Length = "0xED")]
	private void RefreshGamepadButtons()
	{
	}

	[Token(Token = "0x6003936")]
	[Address(RVA = "0xB3F290", Offset = "0xB3E090", Length = "0x14B")]
	private void UpdateTabsObjects()
	{
	}

	[Token(Token = "0x6003937")]
	[Address(RVA = "0xB3F3E0", Offset = "0xB3E1E0", Length = "0x27")]
	private void SetPanelState(PanelState panelState)
	{
	}

	[Token(Token = "0x6003938")]
	[Address(RVA = "0xB3F410", Offset = "0xB3E210", Length = "0x126")]
	private static void MaybeLoadMissionTexturesAssetBundle()
	{
	}

	[Token(Token = "0x6003939")]
	[Address(RVA = "0xB3F540", Offset = "0xB3E340", Length = "0xD9")]
	private void MaybeShowNewMissionEntryNotificationFlagIcon()
	{
	}

	[Token(Token = "0x600393A")]
	[Address(RVA = "0xB3F620", Offset = "0xB3E420", Length = "0xA8")]
	private void RemoveNewMissionEntry(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x600393B")]
	[Address(RVA = "0xB3F6D0", Offset = "0xB3E4D0", Length = "0x1C3")]
	private void CacheComponents()
	{
	}

	[Token(Token = "0x600393C")]
	[Address(RVA = "0xB3F8A0", Offset = "0xB3E6A0", Length = "0x4BF")]
	public Panel_MissionsStory()
	{
	}
}
