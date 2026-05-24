using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using InteractiveObjects;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.OptionalContent;
using TLD.Stats;
using TLD.Trader;
using TLD.Transmitters.UI;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x200067D")]
public class Panel_Log : Panel_AutoReferenced, INotificationHandler, IMiniTopNav
{
	[Token(Token = "0x200067E")]
	private enum BackAction
	{
		[Token(Token = "0x40043BC")]
		Unknown,
		[Token(Token = "0x40043BD")]
		ReturnToMap
	}

	[Token(Token = "0x200067F")]
	public enum NavigationTabState
	{
		[Token(Token = "0x40043BF")]
		None,
		[Token(Token = "0x40043C0")]
		Journal,
		[Token(Token = "0x40043C1")]
		Missions
	}

	[Serializable]
	[Token(Token = "0x2000680")]
	public struct NavigationTabs
	{
		[Token(Token = "0x40043C2")]
		[FieldOffset(Offset = "0x0")]
		public GameObject m_Parent;

		[Token(Token = "0x40043C3")]
		[FieldOffset(Offset = "0x8")]
		public GameObject m_JournalTab;

		[Token(Token = "0x40043C4")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_MissionsTab;
	}

	[Token(Token = "0x2000681")]
	public enum CollectionsType
	{
		[Token(Token = "0x40043C6")]
		SelectScreen,
		[Token(Token = "0x40043C7")]
		General,
		[Token(Token = "0x40043C8")]
		Notes,
		[Token(Token = "0x40043C9")]
		Matchbooks,
		[Token(Token = "0x40043CA")]
		Postcards,
		[Token(Token = "0x40043CB")]
		Cairns,
		[Token(Token = "0x40043CC")]
		AuroraScreens,
		[Token(Token = "0x40043CD")]
		SurveyScreen,
		[Token(Token = "0x40043CE")]
		Mementos,
		[Token(Token = "0x40043CF")]
		Transmitters,
		[Token(Token = "0x40043D0")]
		Recipes,
		[Token(Token = "0x40043D1")]
		Photos
	}

	[Token(Token = "0x2000682")]
	public class LogMissionInfo
	{
		[Token(Token = "0x40043D2")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40043D3")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		[Token(Token = "0x40043D4")]
		[FieldOffset(Offset = "0x20")]
		public string[] checklistKeys;

		[Token(Token = "0x40043D5")]
		[FieldOffset(Offset = "0x28")]
		public string[] checklistValues;

		[Token(Token = "0x40043D6")]
		[FieldOffset(Offset = "0x30")]
		public bool[] checklistBools;

		[Token(Token = "0x60037A8")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public LogMissionInfo()
		{
		}
	}

	[Token(Token = "0x2000683")]
	public enum WhatIKnowType
	{
		[Token(Token = "0x40043D8")]
		SelectScreen,
		[Token(Token = "0x40043D9")]
		People,
		[Token(Token = "0x40043DA")]
		Actions,
		[Token(Token = "0x40043DB")]
		Places,
		[Token(Token = "0x40043DC")]
		Things
	}

	[HideInInspector]
	[Token(Token = "0x4004229")]
	[FieldOffset(Offset = "0x30")]
	public bool m_EnableDiaryOnExit;

	[Token(Token = "0x400422A")]
	[FieldOffset(Offset = "0x38")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400422B")]
	[FieldOffset(Offset = "0x40")]
	public Color m_BoldColor;

	[Token(Token = "0x400422C")]
	[FieldOffset(Offset = "0x50")]
	public MiniTopNav m_MiniTopNav;

	[Token(Token = "0x400422D")]
	[FieldOffset(Offset = "0x58")]
	public MiniTopNav m_MiniTopNavChallengeMode;

	[Token(Token = "0x400422E")]
	[FieldOffset(Offset = "0x60")]
	private NavigationTabState m_NavigationTabState;

	[Header("Scroll Lists")]
	[Token(Token = "0x400422F")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_PageHeader;

	[Token(Token = "0x4004230")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_ScrollListHeader;

	[Token(Token = "0x4004231")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_LogGridItemPrefab;

	[Token(Token = "0x4004232")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_GridItemParent;

	[Token(Token = "0x4004233")]
	[FieldOffset(Offset = "0x88")]
	public Vector2 m_GridItemSpacing;

	[Token(Token = "0x4004234")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_SelectedSpriteObj;

	[Token(Token = "0x4004235")]
	[FieldOffset(Offset = "0x98")]
	public TweenScale m_SelectedSpriteTweenScale;

	[Header("Sorting Objects")]
	[Token(Token = "0x4004236")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_MainLogObject;

	[Token(Token = "0x4004237")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_NotesSectionObject;

	[Token(Token = "0x4004238")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_LogSectionObject;

	[Token(Token = "0x4004239")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_CollectibleSectionObject;

	[Token(Token = "0x400423A")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_PhotoAlbumSectionObject;

	[Token(Token = "0x400423B")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_NotesObject;

	[Token(Token = "0x400423C")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_RockCachesSectionObject;

	[Token(Token = "0x400423D")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject m_CartographySectionObject;

	[Token(Token = "0x400423E")]
	[FieldOffset(Offset = "0xE0")]
	public TransmitterSiteUIController m_TransmittersSectionObject;

	[Token(Token = "0x400423F")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject m_TraderSectionObject;

	[Token(Token = "0x4004240")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject m_DailyLogObject;

	[Token(Token = "0x4004241")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject m_TOCObject;

	[Token(Token = "0x4004242")]
	[FieldOffset(Offset = "0x100")]
	public GameObject m_DailyStatsPageObject;

	[Token(Token = "0x4004243")]
	[FieldOffset(Offset = "0x108")]
	public GameObject m_NoDataMessageObject;

	[Token(Token = "0x4004244")]
	[FieldOffset(Offset = "0x110")]
	public GameObject m_ExamineObject;

	[Token(Token = "0x4004245")]
	[FieldOffset(Offset = "0x118")]
	public GameObject m_TabsObject;

	[Token(Token = "0x4004246")]
	[FieldOffset(Offset = "0x120")]
	public GameObject m_TabsNotesObject;

	[Token(Token = "0x4004247")]
	[FieldOffset(Offset = "0x128")]
	public GameObject m_StatsPages;

	[Token(Token = "0x4004248")]
	[FieldOffset(Offset = "0x130")]
	public GameObject m_DailyScrollbar;

	[Header("Stats Page")]
	[Token(Token = "0x4004249")]
	[FieldOffset(Offset = "0x138")]
	public UILabel m_CurrentGameLabel;

	[Token(Token = "0x400424A")]
	[FieldOffset(Offset = "0x140")]
	public UILabel m_StatsDayLabel;

	[Token(Token = "0x400424B")]
	[FieldOffset(Offset = "0x148")]
	public UILabel m_StatsExploredLabel;

	[Token(Token = "0x400424C")]
	[FieldOffset(Offset = "0x150")]
	public UILabel m_StatsRestedLabel;

	[Token(Token = "0x400424D")]
	[FieldOffset(Offset = "0x158")]
	public UILabel m_StatsConditionLabel;

	[Token(Token = "0x400424E")]
	[FieldOffset(Offset = "0x160")]
	public UILabel m_StatsCalorieLabel;

	[Token(Token = "0x400424F")]
	[FieldOffset(Offset = "0x168")]
	public UILabel m_StatsInjuriesLabel;

	[Token(Token = "0x4004250")]
	[FieldOffset(Offset = "0x170")]
	public UILabel m_StatsNumLocationsLabel;

	[Token(Token = "0x4004251")]
	[FieldOffset(Offset = "0x178")]
	public UIGrid m_StatsLocationGrid;

	[Token(Token = "0x4004252")]
	[FieldOffset(Offset = "0x180")]
	public GameObject m_StatsLocationPrefab;

	[Token(Token = "0x4004253")]
	[FieldOffset(Offset = "0x188")]
	public TextInputField m_NotesTextField;

	[Token(Token = "0x4004254")]
	[FieldOffset(Offset = "0x190")]
	public UIPanel m_NotesTextPanel;

	[Token(Token = "0x4004255")]
	[FieldOffset(Offset = "0x198")]
	public GenericButtonMouseSpawner m_NotesButtonWrite;

	[Header("Collectibles")]
	[Token(Token = "0x4004256")]
	[FieldOffset(Offset = "0x1A0")]
	public UILabel m_CollectibleNameLabel;

	[Token(Token = "0x4004257")]
	[FieldOffset(Offset = "0x1A8")]
	public UILabel m_CollectibleDescLabel;

	[Token(Token = "0x4004258")]
	[FieldOffset(Offset = "0x1B0")]
	public UITexture m_CollectibleBigIcon;

	[Token(Token = "0x4004259")]
	[FieldOffset(Offset = "0x1B8")]
	public UILabel m_CollectibleNameExamineLabel;

	[Token(Token = "0x400425A")]
	[FieldOffset(Offset = "0x1C0")]
	public UILabel m_CollectibleReadTextLabel;

	[Token(Token = "0x400425B")]
	[FieldOffset(Offset = "0x1C8")]
	public GameObject m_DescriptionPageObject;

	[Token(Token = "0x400425C")]
	[FieldOffset(Offset = "0x1D0")]
	public GameObject m_NoCollectiblesObject;

	[Token(Token = "0x400425D")]
	[FieldOffset(Offset = "0x1D8")]
	public UIPanel m_ExamineCollectibleTextPanel;

	[Token(Token = "0x400425E")]
	[FieldOffset(Offset = "0x1E0")]
	public GameObject m_ButtonExamineCollectible;

	[Token(Token = "0x400425F")]
	[FieldOffset(Offset = "0x1E8")]
	public UITexture m_CollectibleItemTexture;

	[Token(Token = "0x4004260")]
	[FieldOffset(Offset = "0x1F0")]
	public UITexture m_PhotoExamineTexture;

	[Header("Camera Photos")]
	[Token(Token = "0x4004261")]
	[FieldOffset(Offset = "0x1F8")]
	public GameObject m_PhotoAlbumPreviewPageObject;

	[Token(Token = "0x4004262")]
	[FieldOffset(Offset = "0x200")]
	public UILabel m_PhotoAlbumDayNumber;

	[Token(Token = "0x4004263")]
	[FieldOffset(Offset = "0x208")]
	public UILabel m_PhotoAlbumLocation;

	[Token(Token = "0x4004264")]
	[FieldOffset(Offset = "0x210")]
	public UILabel m_PhotoAlbumAnnotation;

	[Token(Token = "0x4004265")]
	[FieldOffset(Offset = "0x218")]
	public UITexture m_PhotoAlbumPhotoPreview;

	[Token(Token = "0x4004266")]
	[FieldOffset(Offset = "0x220")]
	public UITexture m_PhotoAlbumPhotoPreviewBackground;

	[Token(Token = "0x4004267")]
	[FieldOffset(Offset = "0x228")]
	public GameObject m_PhotoAlbumMouseButtons;

	[Token(Token = "0x4004268")]
	[FieldOffset(Offset = "0x230")]
	public AnimationCurve m_PhotoDevelopProgressCurve;

	[Header("Scroll Bars")]
	[Token(Token = "0x4004269")]
	[FieldOffset(Offset = "0x238")]
	public GameObject m_ScrollbarDays;

	[Token(Token = "0x400426A")]
	[FieldOffset(Offset = "0x240")]
	public GameObject m_ScrollbarStats;

	[Token(Token = "0x400426B")]
	[FieldOffset(Offset = "0x248")]
	public GameObject m_ScrollbarNotes;

	[Token(Token = "0x400426C")]
	[FieldOffset(Offset = "0x250")]
	public GameObject m_ScrollbarCollectibles;

	[Token(Token = "0x400426D")]
	[FieldOffset(Offset = "0x258")]
	public GameObject m_ScrollbarExamineCollectible;

	[Token(Token = "0x400426E")]
	[FieldOffset(Offset = "0x260")]
	public GameObject m_ScrollbarDetailedStats;

	[Token(Token = "0x400426F")]
	[FieldOffset(Offset = "0x268")]
	public GameObject m_ScrollbarPhotos;

	[Header("Navigation")]
	[Token(Token = "0x4004270")]
	[FieldOffset(Offset = "0x270")]
	public GameObject m_SectionNav;

	[Token(Token = "0x4004271")]
	[FieldOffset(Offset = "0x278")]
	public Transform m_SectionNavSelectedSprite;

	[Token(Token = "0x4004272")]
	[FieldOffset(Offset = "0x280")]
	public Transform m_SectionNavButtonStartPosition;

	[Token(Token = "0x4004273")]
	[FieldOffset(Offset = "0x288")]
	public Vector3 m_SectionNavButtonSpacing;

	[Token(Token = "0x4004274")]
	[FieldOffset(Offset = "0x298")]
	public UIButton m_DailyLogButton;

	[Token(Token = "0x4004275")]
	[FieldOffset(Offset = "0x2A0")]
	public UIButton m_StatsButton;

	[Token(Token = "0x4004276")]
	[FieldOffset(Offset = "0x2A8")]
	public UIButton m_CollectiblesButton;

	[Token(Token = "0x4004277")]
	[FieldOffset(Offset = "0x2B0")]
	public UIButton m_GeneralNotesButton;

	[Token(Token = "0x4004278")]
	[FieldOffset(Offset = "0x2B8")]
	public UIButton m_RockCachesButton;

	[Token(Token = "0x4004279")]
	[FieldOffset(Offset = "0x2C0")]
	public UIButton m_CartographyButton;

	[Token(Token = "0x400427A")]
	[FieldOffset(Offset = "0x2C8")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Header("Table Of Contents Page")]
	[Token(Token = "0x400427B")]
	[FieldOffset(Offset = "0x2D0")]
	public UILabel m_SandboxHeader;

	[Header("Top Navigation")]
	[Token(Token = "0x400427C")]
	[FieldOffset(Offset = "0x2D8")]
	public PanelLogState[] m_PanelLogStateOrder;

	[Token(Token = "0x400427D")]
	[FieldOffset(Offset = "0x2E0")]
	public GameObject[] m_TopNavButtonOrder;

	[Token(Token = "0x400427E")]
	[FieldOffset(Offset = "0x2E8")]
	public GameObject m_SectionNavArrowPrompts;

	[Token(Token = "0x400427F")]
	[FieldOffset(Offset = "0x2F0")]
	public Transform m_SectionNavBottomArrow;

	[Token(Token = "0x4004280")]
	[FieldOffset(Offset = "0x2F8")]
	public float m_SectionNavBottomArrowOffset;

	[Header("Notification Flag")]
	[Token(Token = "0x4004281")]
	[FieldOffset(Offset = "0x300")]
	public GameObject m_KnowledgeNotificationPrefab;

	[Token(Token = "0x4004282")]
	[FieldOffset(Offset = "0x308")]
	public GameObject m_CollectionsNotificationPrefab;

	[HideInInspector]
	[Token(Token = "0x4004283")]
	[FieldOffset(Offset = "0x310")]
	public Log m_Log;

	[Token(Token = "0x4004284")]
	[FieldOffset(Offset = "0x318")]
	private PanelLogState m_State;

	[Token(Token = "0x4004285")]
	[FieldOffset(Offset = "0x320")]
	private List<GearItem> m_CollectibleGearItems;

	[Token(Token = "0x4004286")]
	[FieldOffset(Offset = "0x328")]
	private List<CairnInfo> m_CollectibleCairnItems;

	[Token(Token = "0x4004287")]
	[FieldOffset(Offset = "0x330")]
	private List<AuroraScreenInfo> m_CollectibleAuroraScreenItems;

	[Token(Token = "0x4004288")]
	[FieldOffset(Offset = "0x338")]
	private float m_StatsPanelHeight;

	[Token(Token = "0x4004289")]
	[FieldOffset(Offset = "0x33C")]
	private float m_NotesPanelHeight;

	[Token(Token = "0x400428A")]
	[FieldOffset(Offset = "0x340")]
	private float m_ExamineCollectiblePanelHeight;

	[Token(Token = "0x400428B")]
	[FieldOffset(Offset = "0x348")]
	private string m_CachedNotesString;

	[Token(Token = "0x400428C")]
	[FieldOffset(Offset = "0x350")]
	private int m_PrevCursorPosition;

	[Token(Token = "0x400428D")]
	[FieldOffset(Offset = "0x354")]
	private bool m_ViewNotesToggle;

	[Token(Token = "0x400428E")]
	[FieldOffset(Offset = "0x355")]
	private bool m_ReadyForInput;

	[Token(Token = "0x400428F")]
	[FieldOffset(Offset = "0x356")]
	private bool m_WasRenamingInMouseScheme;

	[Token(Token = "0x4004290")]
	[FieldOffset(Offset = "0x357")]
	private bool m_WasRenamingLastFrame;

	[Token(Token = "0x4004291")]
	[FieldOffset(Offset = "0x358")]
	private UICamera.ControlScheme m_CachedScheme;

	[Token(Token = "0x4004292")]
	[FieldOffset(Offset = "0x35C")]
	private bool m_FadeInProgress;

	[Token(Token = "0x4004293")]
	[FieldOffset(Offset = "0x35D")]
	private bool m_OverwriteView;

	[Token(Token = "0x4004294")]
	[FieldOffset(Offset = "0x35E")]
	private bool m_HasSavedJournal;

	[Token(Token = "0x4004295")]
	[FieldOffset(Offset = "0x360")]
	private NotificationFlag m_NotificationFlag;

	[Token(Token = "0x4004296")]
	[FieldOffset(Offset = "0x368")]
	private Transform[] m_NotificationFlagChildren;

	[Token(Token = "0x4004297")]
	[FieldOffset(Offset = "0x370")]
	private Transform[] m_KnowledgeChildren;

	[Token(Token = "0x4004298")]
	[FieldOffset(Offset = "0x378")]
	private Transform[] m_CollectionChildren;

	[HideInInspector]
	[Token(Token = "0x400429A")]
	[FieldOffset(Offset = "0x388")]
	public bool m_EnabledFromMainMenu;

	[Token(Token = "0x400429B")]
	[FieldOffset(Offset = "0x390")]
	public SummaryStatsView m_SummaryStatsView;

	[Token(Token = "0x400429C")]
	[FieldOffset(Offset = "0x398")]
	public DetailedStatsView m_DetailedStatsView;

	[Token(Token = "0x400429D")]
	[FieldOffset(Offset = "0x3A0")]
	public UIGrid m_MouseButtonGrid;

	[Token(Token = "0x400429E")]
	[FieldOffset(Offset = "0x3A8")]
	public GameObject m_Button_SaveJournal;

	[Token(Token = "0x400429F")]
	[FieldOffset(Offset = "0x3B0")]
	public GameObject m_Button_View;

	[Token(Token = "0x40042A0")]
	[FieldOffset(Offset = "0x3B8")]
	public GameObject m_Button_Overwrite;

	[Token(Token = "0x40042A1")]
	[FieldOffset(Offset = "0x3C0")]
	public GameObject m_Button_Delete;

	[Token(Token = "0x40042A2")]
	[FieldOffset(Offset = "0x3C8")]
	public GameObject m_Button_Rename;

	[Token(Token = "0x40042A3")]
	[FieldOffset(Offset = "0x3D0")]
	public GameObject m_Button_ResetAllTimeStats;

	[Token(Token = "0x40042A4")]
	[FieldOffset(Offset = "0x3D8")]
	public GameObject m_Button_Back;

	[Token(Token = "0x40042A5")]
	[FieldOffset(Offset = "0x3E0")]
	private bool m_LeftStickUpNonZeroOnEnter;

	[Header("Audio")]
	[Token(Token = "0x40042A6")]
	[FieldOffset(Offset = "0x3E8")]
	public string m_OpenLogAudio;

	[Token(Token = "0x40042A7")]
	[FieldOffset(Offset = "0x3F0")]
	public string m_CloseLogAudio;

	[Token(Token = "0x40042A8")]
	[FieldOffset(Offset = "0x3F8")]
	public string m_CloseJournalSelectAudio;

	[Header("Examine Notes Anchors")]
	[SerializeField]
	[Token(Token = "0x40042A9")]
	[FieldOffset(Offset = "0x400")]
	private int m_ExamineNotesAnchorLeft;

	[SerializeField]
	[Token(Token = "0x40042AA")]
	[FieldOffset(Offset = "0x404")]
	private int m_ExamineNotesAnchorRight;

	[SerializeField]
	[Token(Token = "0x40042AB")]
	[FieldOffset(Offset = "0x408")]
	private int m_ExamineNotesAnchorTop;

	[SerializeField]
	[Token(Token = "0x40042AC")]
	[FieldOffset(Offset = "0x40C")]
	private int m_ExamineNotesAnchorBottom;

	[Header("Examine Buffer Memories Anchors")]
	[SerializeField]
	[Token(Token = "0x40042AD")]
	[FieldOffset(Offset = "0x410")]
	private int m_ExamineBufferMemoryAnchorLeft;

	[SerializeField]
	[Token(Token = "0x40042AE")]
	[FieldOffset(Offset = "0x414")]
	private int m_ExamineBufferMemoryAnchorRight;

	[SerializeField]
	[Token(Token = "0x40042AF")]
	[FieldOffset(Offset = "0x418")]
	private int m_ExamineBufferMemoryAnchorTop;

	[SerializeField]
	[Token(Token = "0x40042B0")]
	[FieldOffset(Offset = "0x41C")]
	private int m_ExamineBufferMemoryAnchorBottom;

	[Header("Examine Photo Anchors")]
	[SerializeField]
	[Token(Token = "0x40042B1")]
	[FieldOffset(Offset = "0x420")]
	private int m_ExaminePhotoFrameAnchorLeft;

	[SerializeField]
	[Token(Token = "0x40042B2")]
	[FieldOffset(Offset = "0x424")]
	private int m_ExaminePhotoFrameAnchorRight;

	[SerializeField]
	[Token(Token = "0x40042B3")]
	[FieldOffset(Offset = "0x428")]
	private int m_ExaminePhotoFrameAnchorTop;

	[SerializeField]
	[Token(Token = "0x40042B4")]
	[FieldOffset(Offset = "0x42C")]
	private int m_ExaminePhotoFrameAnchorBottom;

	[SerializeField]
	[Token(Token = "0x40042B5")]
	[FieldOffset(Offset = "0x430")]
	private int m_ExaminePhotoAnchorLeft;

	[SerializeField]
	[Token(Token = "0x40042B6")]
	[FieldOffset(Offset = "0x434")]
	private int m_ExaminePhotoAnchorRight;

	[SerializeField]
	[Token(Token = "0x40042B7")]
	[FieldOffset(Offset = "0x438")]
	private int m_ExaminePhotoAnchorTop;

	[SerializeField]
	[Token(Token = "0x40042B8")]
	[FieldOffset(Offset = "0x43C")]
	private int m_ExaminePhotoAnchorBottom;

	[Header("Panel Depth")]
	[SerializeField]
	[Token(Token = "0x40042B9")]
	[FieldOffset(Offset = "0x440")]
	private int m_DefaultPanelDepth;

	[SerializeField]
	[Token(Token = "0x40042BA")]
	[FieldOffset(Offset = "0x444")]
	private int m_RenderOverOtherScreensPanelDepth;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40042BB")]
	[FieldOffset(Offset = "0x448")]
	private PanelReference<Panel_Actions> m_ActionsPanel;

	[SerializeField]
	[Token(Token = "0x40042BC")]
	[FieldOffset(Offset = "0x450")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x40042BD")]
	[FieldOffset(Offset = "0x458")]
	private PanelReference<Panel_Clothing> m_Clothing;

	[SerializeField]
	[Token(Token = "0x40042BE")]
	[FieldOffset(Offset = "0x460")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x40042BF")]
	[FieldOffset(Offset = "0x468")]
	private PanelReference<Panel_Crafting> m_CraftingPanel;

	[SerializeField]
	[Token(Token = "0x40042C0")]
	[FieldOffset(Offset = "0x470")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x40042C1")]
	[FieldOffset(Offset = "0x478")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x40042C2")]
	[FieldOffset(Offset = "0x480")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x40042C3")]
	[FieldOffset(Offset = "0x488")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x40042C4")]
	[FieldOffset(Offset = "0x490")]
	private PanelReference<Panel_Map> m_Map;

	[SerializeField]
	[Token(Token = "0x40042C5")]
	[FieldOffset(Offset = "0x498")]
	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	[SerializeField]
	[Token(Token = "0x40042C6")]
	[FieldOffset(Offset = "0x4A0")]
	private PanelReference<Panel_LifeAfterDeath> m_LifeAfterDeath;

	[Header("DLC")]
	[SerializeField]
	[Token(Token = "0x40042C7")]
	[FieldOffset(Offset = "0x4A8")]
	private OptionalContentConfig m_ExpansionPassConfig;

	[Token(Token = "0x40042C8")]
	[FieldOffset(Offset = "0x4B0")]
	private List<CategoryButton> m_TopCategoryButtons;

	[Token(Token = "0x40042C9")]
	[FieldOffset(Offset = "0x4B8")]
	private List<LogGridItem> m_LogGridItemList;

	[Token(Token = "0x40042CA")]
	[FieldOffset(Offset = "0x4C0")]
	private int m_NumColumns;

	[Token(Token = "0x40042CB")]
	[FieldOffset(Offset = "0x4C4")]
	private int m_NumRows;

	[Token(Token = "0x40042CC")]
	[FieldOffset(Offset = "0x4C8")]
	private int m_NumGridItemsVisible;

	[Token(Token = "0x40042CD")]
	[FieldOffset(Offset = "0x4CC")]
	private int m_LogGridItemIndex;

	[Token(Token = "0x40042CE")]
	[FieldOffset(Offset = "0x4D0")]
	private int m_LogGridNumRowsScrolled;

	[Token(Token = "0x40042CF")]
	[FieldOffset(Offset = "0x4D4")]
	private int m_SectionNavIndex;

	[Token(Token = "0x40042D0")]
	[FieldOffset(Offset = "0x4D8")]
	private PanelLogState m_SectionNavCacheState;

	[Token(Token = "0x40042D1")]
	[FieldOffset(Offset = "0x4E0")]
	private List<PanelLogState> m_ActiveStates;

	[Token(Token = "0x40042D2")]
	[FieldOffset(Offset = "0x4E8")]
	private uint m_OpenCloseAudioID;

	[Token(Token = "0x40042D3")]
	[FieldOffset(Offset = "0x4EC")]
	private BackAction m_BackAction;

	[Token(Token = "0x40042D4")]
	[FieldOffset(Offset = "0x4F0")]
	private readonly Dictionary<GameplayTag, PanelLogState> m_EnableFromRadialTags;

	[Token(Token = "0x40042D5")]
	[FieldOffset(Offset = "0x4F8")]
	private readonly Dictionary<PanelLogState, GameplayTag> m_RetainInJournalTags;

	[Header("Sandbox Records")]
	[SerializeField]
	[Token(Token = "0x40042D6")]
	[FieldOffset(Offset = "0x500")]
	private int m_MaxJournals;

	[SerializeField]
	[Token(Token = "0x40042D7")]
	[FieldOffset(Offset = "0x508")]
	private SandboxRecordList m_SandboxRecordList;

	[SerializeField]
	[Token(Token = "0x40042D8")]
	[FieldOffset(Offset = "0x510")]
	private GameObject m_TOCContent;

	[SerializeField]
	[Token(Token = "0x40042D9")]
	[FieldOffset(Offset = "0x518")]
	private GameObject m_NoTOCContent;

	[SerializeField]
	[Token(Token = "0x40042DA")]
	[FieldOffset(Offset = "0x520")]
	private UIGrid m_TocButtonGrid;

	[Token(Token = "0x40042DB")]
	[FieldOffset(Offset = "0x528")]
	private SandboxRecordData m_SandboxRecordAtDeath;

	[Token(Token = "0x40042DC")]
	public static bool m_MarkFalseBlizzards;

	[Header("Almanac")]
	[Token(Token = "0x40042DD")]
	[FieldOffset(Offset = "0x530")]
	public GameObject m_AlmanacSectionObject;

	[Token(Token = "0x40042DE")]
	[FieldOffset(Offset = "0x538")]
	public UIButton m_AlmanacButton;

	[Token(Token = "0x40042DF")]
	[FieldOffset(Offset = "0x540")]
	public UIGrid m_AlmanacGrid;

	[Token(Token = "0x40042E0")]
	[FieldOffset(Offset = "0x548")]
	public GameObject m_AlmanacGridItemPrefab;

	[Token(Token = "0x40042E1")]
	[FieldOffset(Offset = "0x550")]
	public UILabel m_CatFiveLabel;

	[Token(Token = "0x40042E2")]
	[FieldOffset(Offset = "0x558")]
	public UILabel m_CatFiveChanceLabel;

	[Token(Token = "0x40042E3")]
	[FieldOffset(Offset = "0x560")]
	public int m_NumDaysShown;

	[Tooltip("If a day has more than X hours of blizzard, it will be rated Cat4")]
	[Token(Token = "0x40042E4")]
	[FieldOffset(Offset = "0x564")]
	public float m_ThresholdHoursCat4;

	[Tooltip("If a day has more than X hours of blizzard, it will be rated Cat3")]
	[Token(Token = "0x40042E5")]
	[FieldOffset(Offset = "0x568")]
	public float m_ThresholdHoursCat3;

	[Tooltip("If a day has more than X hours of blizzard, it will be rated Cat2")]
	[Token(Token = "0x40042E6")]
	[FieldOffset(Offset = "0x56C")]
	public float m_ThresholdHoursCat2;

	[Token(Token = "0x40042E7")]
	[FieldOffset(Offset = "0x570")]
	public int m_MinNumberFalseBlizzards;

	[Token(Token = "0x40042E8")]
	[FieldOffset(Offset = "0x574")]
	public int m_MaxNumberFalseBlizzards;

	[Tooltip("The first X days will not show a false blizzard")]
	[Token(Token = "0x40042E9")]
	[FieldOffset(Offset = "0x578")]
	public int m_DaysToBlockFalseBlizzard;

	[Tooltip("This is an out of ten rating, so 7 would be 70%")]
	[Token(Token = "0x40042EA")]
	[FieldOffset(Offset = "0x57C")]
	public int m_MaxChanceShownForFalseBlizard;

	[Tooltip("This is an out of ten rating, so 7 would be 70%")]
	[Token(Token = "0x40042EB")]
	[FieldOffset(Offset = "0x580")]
	public int m_MinChanceShownForTrueBlizard;

	[Token(Token = "0x40042EC")]
	[FieldOffset(Offset = "0x588")]
	private List<AlmanacGridItem> m_AlmanacGridItems;

	[Header("Cartography/Survey")]
	[Token(Token = "0x40042ED")]
	[FieldOffset(Offset = "0x590")]
	public List<SurveyRegionListItem> m_SurveyRegionDisplayList;

	[Token(Token = "0x40042EE")]
	[FieldOffset(Offset = "0x598")]
	public GameObject m_SurveyListRegionScrollbar;

	[Token(Token = "0x40042EF")]
	[FieldOffset(Offset = "0x5A0")]
	public List<SurveyListItem> m_SurveyDisplayList;

	[Token(Token = "0x40042F0")]
	[FieldOffset(Offset = "0x5A8")]
	public GameObject m_SurveyListScrollbar;

	[Token(Token = "0x40042F1")]
	[FieldOffset(Offset = "0x5B0")]
	public GameObject m_ForceRevealButton;

	[Token(Token = "0x40042F2")]
	[FieldOffset(Offset = "0x5B8")]
	public List<Texture> m_SurveyRegionButtonTextures;

	[Token(Token = "0x40042F3")]
	[FieldOffset(Offset = "0x5C0")]
	private List<SurveyRegionInfo> m_SurveyRegionList;

	[Token(Token = "0x40042F4")]
	[FieldOffset(Offset = "0x5C8")]
	private int m_CurrentSurveyRegionIndex;

	[Token(Token = "0x40042F5")]
	[FieldOffset(Offset = "0x5CC")]
	private int m_CurrentSurveyAchievementIndex;

	[Token(Token = "0x40042F6")]
	[FieldOffset(Offset = "0x5D0")]
	private int m_SurveyRegionIndexOffset;

	[Token(Token = "0x40042F7")]
	[FieldOffset(Offset = "0x5D4")]
	private int m_SurvayAchievementIndexOffset;

	[Token(Token = "0x40042F8")]
	[FieldOffset(Offset = "0x5D8")]
	private PanelLogSurveyStates m_SurveyState;

	[Token(Token = "0x40042F9")]
	[FieldOffset(Offset = "0x5DC")]
	private int m_SurveyedLocations;

	[Token(Token = "0x40042FA")]
	[FieldOffset(Offset = "0x5E0")]
	private int m_TotalSurveyLocations;

	[Token(Token = "0x40042FB")]
	[FieldOffset(Offset = "0x5E4")]
	private bool m_ForceReveal;

	[Token(Token = "0x40042FC")]
	private const string LOC_FILTER_SURVEYSCREEN = "GAMEPLAY_CollectionFilterSurveyScreen";

	[Token(Token = "0x40042FD")]
	private const string LOC_FILTER_NOTES = "GAMEPLAY_CollectionFilterNotes";

	[Token(Token = "0x40042FE")]
	private const string LOC_FILTER_MATCHBOOKS = "GAMEPLAY_CollectionFilterMatchbooks";

	[Token(Token = "0x40042FF")]
	private const string LOC_FILTER_POSTCARDS = "GAMEPLAY_CollectionFilterPostcards";

	[Token(Token = "0x4004300")]
	private const string LOC_FILTER_MEMENTOS = "GAMEPLAY_Mementos";

	[Token(Token = "0x4004301")]
	private const string LOC_FILTER_CAIRNS = "GAMEPLAY_CollectionFilterCairns";

	[Token(Token = "0x4004302")]
	private const string LOC_FILTER_AURORASCREENS = "GAMEPLAY_CollectionFilterAuroraScreens";

	[Token(Token = "0x4004303")]
	private const string LOC_FILTER_TRANSMITTERS = "GAMEPLAY_CollectionTransmitters";

	[Token(Token = "0x4004304")]
	private const string LOC_FILTER_RECIPES = "GAMEPLAY_CollectionRecipes";

	[Token(Token = "0x4004305")]
	private const string LOC_DESC_NOTES = "GAMEPLAY_CollectionNotesDescription";

	[Token(Token = "0x4004306")]
	private const string LOC_DESC_MATCHBOOKS = "GAMEPLAY_CollectionMatchbooksDescription";

	[Token(Token = "0x4004307")]
	private const string LOC_DESC_POSTCARDS = "GAMEPLAY_CollectionPostcardsDescription";

	[Token(Token = "0x4004308")]
	private const string LOC_DESC_MEMENTOS = "GAMEPLAY_MementosFound";

	[Token(Token = "0x4004309")]
	private const string LOC_DESC_CAIRNS = "GAMEPLAY_CollectionCairnsDescription";

	[Token(Token = "0x400430A")]
	private const string LOC_DESC_AURORASCREENS = "GAMEPLAY_CollectionAuroraScreensDescription";

	[Token(Token = "0x400430B")]
	private const string LOC_DESC_SURVEYSCREEN = "GAMEPLAY_CollectionSurveyScreenDescription";

	[Token(Token = "0x400430C")]
	private const string LOC_DESC_TRANSMITTERS = "GAMEPLAY_CollectionTransmittersDescription";

	[Token(Token = "0x400430D")]
	private const string LOC_DESC_RECIPES = "GAMEPLAY_CollectionRecipesDescription";

	[Token(Token = "0x400430E")]
	private const string LOC_COLLECTIONS = "GAMEPLAY_Collections";

	[Token(Token = "0x400430F")]
	private const string LOC_SELECT = "GAMEPLAY_Select";

	[Token(Token = "0x4004310")]
	private const string ACTION_CONTINUE = "Continue";

	[Token(Token = "0x4004311")]
	private const string ACTION_ESCAPE = "Escape";

	[Header("Collections")]
	[Token(Token = "0x4004312")]
	[FieldOffset(Offset = "0x5E8")]
	public GameObject m_CollectiblesSubSectionObject;

	[Token(Token = "0x4004313")]
	[FieldOffset(Offset = "0x5F0")]
	public GameObject m_CollectionsSubSectionObject;

	[Token(Token = "0x4004314")]
	[FieldOffset(Offset = "0x5F8")]
	public ScrollList m_CollectionsScrollList;

	[Token(Token = "0x4004315")]
	[FieldOffset(Offset = "0x600")]
	public UITexture m_CollectionsImage;

	[Token(Token = "0x4004316")]
	[FieldOffset(Offset = "0x608")]
	public UILabel m_CollectionsNameLabel;

	[Token(Token = "0x4004317")]
	[FieldOffset(Offset = "0x610")]
	public UILabel m_CollectionsDescLabel;

	[Token(Token = "0x4004318")]
	[FieldOffset(Offset = "0x618")]
	public GameObject m_NoCollectionsOfType;

	[Token(Token = "0x4004319")]
	[FieldOffset(Offset = "0x620")]
	public GameObject m_CollectionSelectSubScreenButton;

	[Token(Token = "0x400431A")]
	[FieldOffset(Offset = "0x628")]
	public GameObject m_NoCollectionObject;

	[Token(Token = "0x400431B")]
	[FieldOffset(Offset = "0x630")]
	public int m_TotalNumNoteCollectibles;

	[Token(Token = "0x400431C")]
	[FieldOffset(Offset = "0x634")]
	public int m_TotalNumMatchbookCollectibles;

	[Token(Token = "0x400431D")]
	[FieldOffset(Offset = "0x638")]
	public int m_TotalNumCairnCollectibles;

	[Token(Token = "0x400431E")]
	[FieldOffset(Offset = "0x63C")]
	public int m_TotalNumAuroraScreenCollectibles;

	[Token(Token = "0x400431F")]
	[FieldOffset(Offset = "0x640")]
	public string m_NotesSpriteNameSmall;

	[Token(Token = "0x4004320")]
	[FieldOffset(Offset = "0x648")]
	public string m_NotesSpriteNameBig;

	[Token(Token = "0x4004321")]
	[FieldOffset(Offset = "0x650")]
	public string m_MatchbooksSpriteNameSmall;

	[Token(Token = "0x4004322")]
	[FieldOffset(Offset = "0x658")]
	public string m_MatchbooksSpriteNameBig;

	[Token(Token = "0x4004323")]
	[FieldOffset(Offset = "0x660")]
	public string m_CairnsSpriteNameSmall;

	[Token(Token = "0x4004324")]
	[FieldOffset(Offset = "0x668")]
	public string m_CairnsSpriteNameBig;

	[Token(Token = "0x4004325")]
	[FieldOffset(Offset = "0x670")]
	public string m_AuroraScreensSpriteNameSmall;

	[Token(Token = "0x4004326")]
	[FieldOffset(Offset = "0x678")]
	public string m_AuroraScreensSpriteNameBig;

	[Token(Token = "0x4004327")]
	[FieldOffset(Offset = "0x680")]
	public string m_SurveyScreenSpriteNameSmall;

	[Token(Token = "0x4004328")]
	[FieldOffset(Offset = "0x688")]
	public string m_SurveyScreenSpriteNameBig;

	[Header("Postcards")]
	[Token(Token = "0x4004329")]
	[FieldOffset(Offset = "0x690")]
	public AssetLabelReference m_PostcardLabel;

	[Token(Token = "0x400432A")]
	[FieldOffset(Offset = "0x698")]
	public string m_PostcardsSpriteNameSmall;

	[Token(Token = "0x400432B")]
	[FieldOffset(Offset = "0x6A0")]
	public string m_PostcardsSpriteNameBig;

	[Header("Momentos")]
	[Token(Token = "0x400432C")]
	[FieldOffset(Offset = "0x6A8")]
	public AssetLabelReference m_MementoLabel;

	[Token(Token = "0x400432D")]
	[FieldOffset(Offset = "0x6B0")]
	public string m_MementosSpriteNameSmall;

	[Token(Token = "0x400432E")]
	[FieldOffset(Offset = "0x6B8")]
	public string m_MementosSpriteNameBig;

	[Header("Transmitters")]
	[Token(Token = "0x400432F")]
	[FieldOffset(Offset = "0x6C0")]
	public string m_TransmitterSpriteSmall;

	[Token(Token = "0x4004330")]
	[FieldOffset(Offset = "0x6C8")]
	public string m_TransmitterSpriteBig;

	[Header("Recipes")]
	[Token(Token = "0x4004331")]
	[FieldOffset(Offset = "0x6D0")]
	public string m_RecipesSpriteSmall;

	[Token(Token = "0x4004332")]
	[FieldOffset(Offset = "0x6D8")]
	public string m_RecipesSpriteBig;

	[Token(Token = "0x4004333")]
	[FieldOffset(Offset = "0x6E0")]
	private bool m_CollectionsToggle;

	[Token(Token = "0x4004334")]
	[FieldOffset(Offset = "0x6E4")]
	private CollectionsType m_CollectionsCurrType;

	[Token(Token = "0x4004335")]
	[FieldOffset(Offset = "0x6E8")]
	private readonly List<CollectionListItem> m_CollectionList;

	[Token(Token = "0x4004336")]
	[FieldOffset(Offset = "0x6F0")]
	private int m_CollectionListSelectedIndex;

	[Token(Token = "0x4004337")]
	[FieldOffset(Offset = "0x6F4")]
	private int m_CurrNumNoteCollectibles;

	[Token(Token = "0x4004338")]
	[FieldOffset(Offset = "0x6F8")]
	private int m_CurrNumMatchbookCollectibles;

	[Token(Token = "0x4004339")]
	[FieldOffset(Offset = "0x6FC")]
	private int m_CurrNumPostcardCollectibles;

	[Token(Token = "0x400433A")]
	[FieldOffset(Offset = "0x700")]
	private int m_CurrNumCairnCollectibles;

	[Token(Token = "0x400433B")]
	[FieldOffset(Offset = "0x704")]
	private int m_CurrNumAuroraScreenCollectibles;

	[Token(Token = "0x400433C")]
	[FieldOffset(Offset = "0x708")]
	private int m_CurrNumMementoCollectibles;

	[Token(Token = "0x400433D")]
	[FieldOffset(Offset = "0x710")]
	private readonly List<CollectionListItemInfo> m_CollectionDataList;

	[Token(Token = "0x400433E")]
	[FieldOffset(Offset = "0x718")]
	private readonly List<NotificationFlagInfo> m_CollectionsNewEntry;

	[Token(Token = "0x400433F")]
	[FieldOffset(Offset = "0x720")]
	private readonly List<NarrativeCollectibleItem> m_AvailablePostcards;

	[Token(Token = "0x4004340")]
	[FieldOffset(Offset = "0x728")]
	private readonly List<NarrativeCollectibleItem> m_AvailableMementoItems;

	[Token(Token = "0x4004341")]
	[FieldOffset(Offset = "0x730")]
	private bool m_CollectionsAddressablesLoaded;

	[Header("Missions")]
	[Token(Token = "0x4004342")]
	[FieldOffset(Offset = "0x738")]
	public GameObject m_MissionsSectionObject;

	[Token(Token = "0x4004343")]
	[FieldOffset(Offset = "0x740")]
	public UILabel m_MissionNameLabel;

	[Token(Token = "0x4004344")]
	[FieldOffset(Offset = "0x748")]
	public UILabel m_MissionNameHeaderLabel;

	[Token(Token = "0x4004345")]
	[FieldOffset(Offset = "0x750")]
	public UILabel m_MissionDescriptionLabel;

	[Token(Token = "0x4004346")]
	[FieldOffset(Offset = "0x758")]
	public Transform m_ObjectiveTransform;

	[Token(Token = "0x4004347")]
	[FieldOffset(Offset = "0x760")]
	public UILabel m_MainObjectiveLabel;

	[Token(Token = "0x4004348")]
	[FieldOffset(Offset = "0x768")]
	public ChallengeChecklistEntry[] m_ChecklistEntries;

	[Token(Token = "0x4004349")]
	[FieldOffset(Offset = "0x770")]
	public float m_ChallengeChecklistOffsetY;

	[Token(Token = "0x400434A")]
	[FieldOffset(Offset = "0x774")]
	public float m_ChallengeChecklistVerticalSpacing;

	[Token(Token = "0x400434B")]
	[FieldOffset(Offset = "0x778")]
	public GameObject m_TimerObject;

	[Token(Token = "0x400434C")]
	[FieldOffset(Offset = "0x780")]
	public UILabel m_TimerLabel;

	[Token(Token = "0x400434D")]
	[FieldOffset(Offset = "0x788")]
	public UITexture m_ChallengeTexture;

	[Token(Token = "0x400434E")]
	[FieldOffset(Offset = "0x790")]
	public UIButton m_MissionsButton;

	[Token(Token = "0x400434F")]
	[FieldOffset(Offset = "0x798")]
	public int m_PixelBufferTimer;

	[Token(Token = "0x4004350")]
	[FieldOffset(Offset = "0x7A0")]
	public UISprite m_MainObjectiveSprite;

	[Header("Gameplay Tags")]
	[SerializeField]
	[Token(Token = "0x4004351")]
	[FieldOffset(Offset = "0x7A8")]
	private GameplayTag m_UpdateMissionInfoFromPrefab;

	[SerializeField]
	[Token(Token = "0x4004352")]
	[FieldOffset(Offset = "0x7B8")]
	private GameplayTag m_UseMissionTimerTextFromActionsRadial;

	[SerializeField]
	[Token(Token = "0x4004353")]
	[FieldOffset(Offset = "0x7C8")]
	private GameplayTag m_ActivateObjectiveTransform;

	[Token(Token = "0x4004354")]
	[FieldOffset(Offset = "0x7D8")]
	private StoryMissionInfo m_CurrentMissionInfo;

	[Token(Token = "0x4004355")]
	[FieldOffset(Offset = "0x7E0")]
	private List<StoryMissionObjective> m_ObjectivesToShow;

	[Token(Token = "0x4004356")]
	[FieldOffset(Offset = "0x7E8")]
	private List<LogMissionInfo> m_MissionsInfoList;

	[Header("Photos")]
	[SerializeField]
	[Token(Token = "0x4004357")]
	[FieldOffset(Offset = "0x7F0")]
	private GameObject m_NoPhotosStateRoot;

	[Header("RockCaches")]
	[Token(Token = "0x4004358")]
	[FieldOffset(Offset = "0x7F8")]
	public List<RockCacheListItem> m_RockCacheRegionDisplayList;

	[Token(Token = "0x4004359")]
	[FieldOffset(Offset = "0x800")]
	public GameObject m_RockCacheRegionsScrollbar;

	[Token(Token = "0x400435A")]
	[FieldOffset(Offset = "0x808")]
	public List<RockCacheListItem> m_RockCacheItemDisplayList;

	[Token(Token = "0x400435B")]
	[FieldOffset(Offset = "0x810")]
	public GameObject m_RockCacheItemsScrollbar;

	[Token(Token = "0x400435C")]
	[FieldOffset(Offset = "0x818")]
	public GameObject m_RockCacheDetails;

	[Token(Token = "0x400435D")]
	[FieldOffset(Offset = "0x820")]
	public UILabel m_RockCacheNameLabel;

	[Token(Token = "0x400435E")]
	[FieldOffset(Offset = "0x828")]
	public GameObject m_RockCacheMapButton;

	[Token(Token = "0x400435F")]
	[FieldOffset(Offset = "0x830")]
	public TextInputField m_RockCacheNoteTextField;

	[Token(Token = "0x4004360")]
	[FieldOffset(Offset = "0x838")]
	public UIInput m_RockCacheNoteUIInput;

	[Token(Token = "0x4004361")]
	[FieldOffset(Offset = "0x840")]
	public GameObject m_RockCacheNoteScrollbar;

	[Token(Token = "0x4004362")]
	[FieldOffset(Offset = "0x848")]
	public UIPanel m_RockCacheNoteTextPanel;

	[Token(Token = "0x4004363")]
	[FieldOffset(Offset = "0x850")]
	public float m_RockCacheNotePanelHeight;

	[Token(Token = "0x4004364")]
	[FieldOffset(Offset = "0x854")]
	public int m_RockCacheNotePrevCursorPosition;

	[Token(Token = "0x4004365")]
	[FieldOffset(Offset = "0x858")]
	private List<RegionInfo> m_RegionNameList;

	[Token(Token = "0x4004366")]
	[FieldOffset(Offset = "0x860")]
	private Dictionary<string, List<RockCacheInfo>> m_RockCacheListByRegion;

	[Token(Token = "0x4004367")]
	[FieldOffset(Offset = "0x868")]
	private int m_CurrentRockCacheRegionIndex;

	[Token(Token = "0x4004368")]
	[FieldOffset(Offset = "0x86C")]
	private int m_CurrentRockCacheItemIndex;

	[Token(Token = "0x4004369")]
	[FieldOffset(Offset = "0x870")]
	private int m_RockCacheRegionIndexOffset;

	[Token(Token = "0x400436A")]
	[FieldOffset(Offset = "0x874")]
	private int m_RockCacheItemIndexOffset;

	[Token(Token = "0x400436B")]
	[FieldOffset(Offset = "0x878")]
	private PanelLogRockCacheStates m_RockCacheState;

	[Token(Token = "0x400436C")]
	[FieldOffset(Offset = "0x87C")]
	private bool m_CanShowOnMap;

	[Token(Token = "0x400436D")]
	[FieldOffset(Offset = "0x880")]
	private string m_SelectButtonString;

	[Token(Token = "0x400436E")]
	[FieldOffset(Offset = "0x888")]
	private string m_RockCacheNoteString;

	[Token(Token = "0x400436F")]
	[FieldOffset(Offset = "0x890")]
	private string m_CurrentRockCacheGuid;

	[Token(Token = "0x4004370")]
	[FieldOffset(Offset = "0x898")]
	private bool m_NoteTakingStart;

	[Header("Skills")]
	[Token(Token = "0x4004371")]
	[FieldOffset(Offset = "0x8A0")]
	public List<SkillListItem> m_SkillsDisplayList;

	[Token(Token = "0x4004372")]
	[FieldOffset(Offset = "0x8A8")]
	public GameObject m_SkillsScrollbar;

	[Token(Token = "0x4004373")]
	[FieldOffset(Offset = "0x8B0")]
	public GameObject m_SkillsSectionObject;

	[Token(Token = "0x4004374")]
	[FieldOffset(Offset = "0x8B8")]
	public GameObject m_SkillBenefitPrefab;

	[Token(Token = "0x4004375")]
	[FieldOffset(Offset = "0x8C0")]
	public GameObject m_SkillBenefitsStartDummy;

	[Token(Token = "0x4004376")]
	[FieldOffset(Offset = "0x8C8")]
	public int m_SkillBenefitLabelOffsetY;

	[Token(Token = "0x4004377")]
	[FieldOffset(Offset = "0x8CC")]
	public int m_SkillBenefitSpacingY;

	[Token(Token = "0x4004378")]
	[FieldOffset(Offset = "0x8D0")]
	public int m_DescriptionOffsetY;

	[Token(Token = "0x4004379")]
	[FieldOffset(Offset = "0x8D8")]
	public ScrollList m_SkillsScrollList;

	[Token(Token = "0x400437A")]
	[FieldOffset(Offset = "0x8E0")]
	public UITexture m_SkillImageLarge;

	[Token(Token = "0x400437B")]
	[FieldOffset(Offset = "0x8E8")]
	public UILabel m_SkillName;

	[Token(Token = "0x400437C")]
	[FieldOffset(Offset = "0x8F0")]
	public UILabel m_SkillLevelName;

	[Token(Token = "0x400437D")]
	[FieldOffset(Offset = "0x8F8")]
	public UILabel m_SkillLevelIconLargeLabel;

	[Token(Token = "0x400437E")]
	[FieldOffset(Offset = "0x900")]
	public UILabel m_SkillDescription;

	[Token(Token = "0x400437F")]
	[FieldOffset(Offset = "0x908")]
	public UIButton m_SkillsButton;

	[Token(Token = "0x4004380")]
	private const int MAX_SKILL_BENEFITS = 10;

	[Token(Token = "0x4004381")]
	[FieldOffset(Offset = "0x910")]
	private List<GameObject> m_SkillBenefitLines;

	[Token(Token = "0x4004382")]
	[FieldOffset(Offset = "0x918")]
	private int m_SkillListSelectedIndex;

	[Token(Token = "0x4004383")]
	[FieldOffset(Offset = "0x91C")]
	private int m_SkillListOffset;

	[Token(Token = "0x4004384")]
	[FieldOffset(Offset = "0x920")]
	private bool m_SkillsAddressablesLoaded;

	[Header("Trader")]
	[SerializeField]
	[Token(Token = "0x4004385")]
	[FieldOffset(Offset = "0x928")]
	private TraderLogItem m_ActiveTradeLogItem;

	[SerializeField]
	[Token(Token = "0x4004386")]
	[FieldOffset(Offset = "0x930")]
	private TraderLogItem m_SpecialRequestLogItem;

	[SerializeField]
	[Token(Token = "0x4004387")]
	[FieldOffset(Offset = "0x938")]
	private float m_LogItemOffset;

	[SerializeField]
	[Token(Token = "0x4004388")]
	[FieldOffset(Offset = "0x940")]
	private GameObject m_NoTraderStateRoot;

	[SerializeField]
	[Token(Token = "0x4004389")]
	[FieldOffset(Offset = "0x948")]
	private GameObject m_TradeExchangeRoot;

	[SerializeField]
	[Token(Token = "0x400438A")]
	[FieldOffset(Offset = "0x950")]
	private TraderHUD m_TraderHUD;

	[SerializeField]
	[Token(Token = "0x400438B")]
	[FieldOffset(Offset = "0x958")]
	private GameObject m_SpecialRequestDetailsRoot;

	[SerializeField]
	[Token(Token = "0x400438C")]
	[FieldOffset(Offset = "0x960")]
	private UILabel m_SpecialRequestDetailsHeader;

	[SerializeField]
	[Token(Token = "0x400438D")]
	[FieldOffset(Offset = "0x968")]
	private UILabel m_SpecialRequestDetailsDescription;

	[Header("Trader Scroll")]
	[SerializeField]
	[Token(Token = "0x400438E")]
	[FieldOffset(Offset = "0x970")]
	private int m_TraderScrollLeftMargin;

	[SerializeField]
	[Token(Token = "0x400438F")]
	[FieldOffset(Offset = "0x974")]
	private int m_TraderScrollTopBottomMargin;

	[SerializeField]
	[Token(Token = "0x4004390")]
	[FieldOffset(Offset = "0x978")]
	private UIScrollBar m_TraderHUDScrollBar;

	[SerializeField]
	[Token(Token = "0x4004391")]
	[FieldOffset(Offset = "0x980")]
	private UIWidget m_TraderHUDScrollAreaWidget;

	[SerializeField]
	[Token(Token = "0x4004392")]
	[FieldOffset(Offset = "0x988")]
	private UIWidget m_TraderHUDScrollBarWidget;

	[Token(Token = "0x4004393")]
	[FieldOffset(Offset = "0x990")]
	private TraderLogItem m_SelectedTraderLogItem;

	[Token(Token = "0x4004394")]
	[FieldOffset(Offset = "0x998")]
	private float m_TraderMaxScroll;

	[Header("What I Know")]
	[Token(Token = "0x4004395")]
	[FieldOffset(Offset = "0x9A0")]
	public GameObject m_WhatIKnowSectionObject;

	[Token(Token = "0x4004396")]
	[FieldOffset(Offset = "0x9A8")]
	public ScrollList m_WhatIKnowScrollList;

	[Token(Token = "0x4004397")]
	[FieldOffset(Offset = "0x9B0")]
	public UITexture m_WhatIKnowImage;

	[Token(Token = "0x4004398")]
	[FieldOffset(Offset = "0x9B8")]
	public UILabel m_WhatIKnowNameLabel;

	[Token(Token = "0x4004399")]
	[FieldOffset(Offset = "0x9C0")]
	public UILabel m_WhatIKnowDescLabel;

	[Token(Token = "0x400439A")]
	[FieldOffset(Offset = "0x9C8")]
	public UIButton m_WhatIKnowButton;

	[Token(Token = "0x400439B")]
	[FieldOffset(Offset = "0x9D0")]
	public GameObject m_SelectSubScreenButton;

	[Token(Token = "0x400439C")]
	[FieldOffset(Offset = "0x9D8")]
	public GameObject m_SelectScreenOnly;

	[Token(Token = "0x400439D")]
	[FieldOffset(Offset = "0x9E0")]
	public GameObject m_SubScreenOnly;

	[Token(Token = "0x400439E")]
	[FieldOffset(Offset = "0x9E8")]
	public UILabel m_SubscreenHeaderLabel;

	[Token(Token = "0x400439F")]
	[FieldOffset(Offset = "0x9F0")]
	public GameObject m_ScrollbarWhatIKnow;

	[Token(Token = "0x40043A0")]
	[FieldOffset(Offset = "0x9F8")]
	public GameObject m_ScrollbarWhatIKnowDesc;

	[Token(Token = "0x40043A1")]
	[FieldOffset(Offset = "0xA00")]
	public UIPanel m_WhatIKnowDescPanel;

	[Token(Token = "0x40043A2")]
	[FieldOffset(Offset = "0xA08")]
	public int m_TotalNumKnowledgePeople;

	[Token(Token = "0x40043A3")]
	[FieldOffset(Offset = "0xA0C")]
	public int m_TotalNumKnowledgePlaces;

	[Token(Token = "0x40043A4")]
	[FieldOffset(Offset = "0xA10")]
	public int m_TotalNumKnowledgeThings;

	[Token(Token = "0x40043A5")]
	[FieldOffset(Offset = "0xA14")]
	public int m_TotalNumKnowledgeActions;

	[Token(Token = "0x40043A6")]
	[FieldOffset(Offset = "0xA18")]
	public string m_PeopleSpriteNameSmall;

	[Token(Token = "0x40043A7")]
	[FieldOffset(Offset = "0xA20")]
	public string m_PeopleSpriteNameBig;

	[Token(Token = "0x40043A8")]
	[FieldOffset(Offset = "0xA28")]
	public string m_PlacesSpriteNameSmall;

	[Token(Token = "0x40043A9")]
	[FieldOffset(Offset = "0xA30")]
	public string m_PlacesSpriteNameBig;

	[Token(Token = "0x40043AA")]
	[FieldOffset(Offset = "0xA38")]
	public string m_ThingsSpriteNameSmall;

	[Token(Token = "0x40043AB")]
	[FieldOffset(Offset = "0xA40")]
	public string m_ThingsSpriteNameBig;

	[Token(Token = "0x40043AC")]
	[FieldOffset(Offset = "0xA48")]
	public string m_ActionsSpriteNameSmall;

	[Token(Token = "0x40043AD")]
	[FieldOffset(Offset = "0xA50")]
	public string m_ActionsSpriteNameBig;

	[Token(Token = "0x40043AE")]
	[FieldOffset(Offset = "0xA58")]
	private WhatIKnowType m_WhatIKnowCurrType;

	[Token(Token = "0x40043AF")]
	[FieldOffset(Offset = "0xA60")]
	private List<CollectionListItem> m_WhatIKnowList;

	[Token(Token = "0x40043B0")]
	[FieldOffset(Offset = "0xA68")]
	private int m_WhatIKnowListSelectedIndex;

	[Token(Token = "0x40043B1")]
	[FieldOffset(Offset = "0xA6C")]
	private float m_WhatIKnowDescPanelHeight;

	[Token(Token = "0x40043B2")]
	[FieldOffset(Offset = "0xA70")]
	private List<CollectionListItemInfo> m_WhatIKnowDataList;

	[Token(Token = "0x40043B3")]
	[FieldOffset(Offset = "0xA78")]
	private List<string> m_ListKnowledgeUnlockedPeople;

	[Token(Token = "0x40043B4")]
	[FieldOffset(Offset = "0xA80")]
	private List<string> m_ListKnowledgeUnlockedPlaces;

	[Token(Token = "0x40043B5")]
	[FieldOffset(Offset = "0xA88")]
	private List<string> m_ListKnowledgeUnlockedThings;

	[Token(Token = "0x40043B6")]
	[FieldOffset(Offset = "0xA90")]
	private List<string> m_ListKnowledgeUnlockedActions;

	[Token(Token = "0x40043B7")]
	[FieldOffset(Offset = "0xA98")]
	private bool m_WasQuickSelectActivated;

	[Token(Token = "0x40043B8")]
	[FieldOffset(Offset = "0xAA0")]
	private List<NotificationFlagInfo> m_KnowledgeNewEntry;

	[Token(Token = "0x40043B9")]
	[FieldOffset(Offset = "0xAA8")]
	private Dictionary<string, bool> m_subCategories;

	[Token(Token = "0x40043BA")]
	[FieldOffset(Offset = "0xAB0")]
	private bool m_WhatIKnowAddressablesLoaded;

	[Token(Token = "0x17000301")]
	private bool FadeInProgress
	{
		[Token(Token = "0x6003683")]
		[Address(RVA = "0xAA2250", Offset = "0xAA1050", Length = "0x42")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000302")]
	private int TotalNumPostcardCollectibles
	{
		[Token(Token = "0x600373A")]
		[Address(RVA = "0xABF0F0", Offset = "0xABDEF0", Length = "0x44")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000303")]
	private int TotalNumMementoCollectibles
	{
		[Token(Token = "0x600373B")]
		[Address(RVA = "0xABF140", Offset = "0xABDF40", Length = "0x44")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x14000008")]
	public event Action<string, NotificationFlagInfo> m_ItemSelected
	{
		[CompilerGenerated]
		[Token(Token = "0x6003681")]
		[Address(RVA = "0xAA1F70", Offset = "0xAA0D70", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003682")]
		[Address(RVA = "0xAA20E0", Offset = "0xAA0EE0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6003684")]
	[Address(RVA = "0xAA22A0", Offset = "0xAA10A0", Length = "0x398")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003685")]
	[Address(RVA = "0xAA2640", Offset = "0xAA1440", Length = "0x761")]
	private void Update()
	{
	}

	[Token(Token = "0x6003686")]
	[Address(RVA = "0xAA2DB0", Offset = "0xAA1BB0", Length = "0x167")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003687")]
	[Address(RVA = "0xAA2F20", Offset = "0xAA1D20", Length = "0xCF")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6003688")]
	[Address(RVA = "0xAA2FF0", Offset = "0xAA1DF0", Length = "0x63C")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003689")]
	[Address(RVA = "0x7F6DB0", Offset = "0x7F5BB0", Length = "0x13")]
	public void Disable()
	{
	}

	[Token(Token = "0x600368A")]
	[Address(RVA = "0xAA3630", Offset = "0xAA2430", Length = "0x392")]
	public void EnableFromRadial(PanelLogState state)
	{
	}

	[Token(Token = "0x600368B")]
	[Address(RVA = "0xAA39D0", Offset = "0xAA27D0", Length = "0x10E")]
	public void EnableRockCacheStateFromMap(string sceneName, string rockCacheCustomName)
	{
	}

	[Token(Token = "0x600368C")]
	[Address(RVA = "0xAA3AE0", Offset = "0xAA28E0", Length = "0xE6")]
	public void EnableFromMissionsStory(PanelLogState state)
	{
	}

	[Token(Token = "0x600368D")]
	[Address(RVA = "0xAA3BD0", Offset = "0xAA29D0", Length = "0x1AB")]
	public void EnableFromMap(string missionId)
	{
	}

	[Token(Token = "0x600368E")]
	[Address(RVA = "0xAA3D80", Offset = "0xAA2B80", Length = "0x1A1")]
	public void EnableFromObjective(string missionId)
	{
	}

	[Token(Token = "0x600368F")]
	[Address(RVA = "0xAA3F30", Offset = "0xAA2D30", Length = "0xD9")]
	public void EnableDailyView()
	{
	}

	[Token(Token = "0x6003690")]
	[Address(RVA = "0xAA4010", Offset = "0xAA2E10", Length = "0xF2")]
	public void EnableStatsView()
	{
	}

	[Token(Token = "0x6003691")]
	[Address(RVA = "0xAA4110", Offset = "0xAA2F10", Length = "0x17D")]
	public void EnableDeathView()
	{
	}

	[Token(Token = "0x6003692")]
	[Address(RVA = "0xAA4290", Offset = "0xAA3090", Length = "0x2D")]
	public void OnDoneFadingOutDeathView()
	{
	}

	[Token(Token = "0x6003693")]
	[Address(RVA = "0xAA42C0", Offset = "0xAA30C0", Length = "0x401")]
	private void ToggleButtonColliders(Transform transform, bool enabled)
	{
	}

	[Token(Token = "0x6003694")]
	[Address(RVA = "0xAA46D0", Offset = "0xAA34D0", Length = "0x556")]
	public void OnBack()
	{
	}

	[Token(Token = "0x6003695")]
	[Address(RVA = "0xAA4C30", Offset = "0xAA3A30", Length = "0xA4")]
	public void LogGridItemCallback(int entryNum)
	{
	}

	[Token(Token = "0x6003696")]
	[Address(RVA = "0xAA4CE0", Offset = "0xAA3AE0", Length = "0x2A3")]
	public void LogListItemCallback(int indexClicked)
	{
	}

	[Token(Token = "0x6003697")]
	[Address(RVA = "0xAA4F90", Offset = "0xAA3D90", Length = "0x63")]
	public void OnWriteButton()
	{
	}

	[Token(Token = "0x6003698")]
	[Address(RVA = "0xAA5000", Offset = "0xAA3E00", Length = "0xD3")]
	public void OnStatus()
	{
	}

	[Token(Token = "0x6003699")]
	[Address(RVA = "0xAA50E0", Offset = "0xAA3EE0", Length = "0x59")]
	public void OnInventory()
	{
	}

	[Token(Token = "0x600369A")]
	[Address(RVA = "0xAA5140", Offset = "0xAA3F40", Length = "0xC7")]
	public void OnScrollbarDaysUp()
	{
	}

	[Token(Token = "0x600369B")]
	[Address(RVA = "0xAA5210", Offset = "0xAA4010", Length = "0xBF")]
	public void OnScrollbarDaysDown()
	{
	}

	[Token(Token = "0x600369C")]
	[Address(RVA = "0xAA52D0", Offset = "0xAA40D0", Length = "0x154")]
	public void OnScrollbarDaysChange()
	{
	}

	[Token(Token = "0x600369D")]
	[Address(RVA = "0xAA5430", Offset = "0xAA4230", Length = "0x20")]
	public void OnScrollbarStatsChange()
	{
	}

	[Token(Token = "0x600369E")]
	[Address(RVA = "0xAA5460", Offset = "0xAA4260", Length = "0x20")]
	public void OnScrollbarStatsUp()
	{
	}

	[Token(Token = "0x600369F")]
	[Address(RVA = "0xAA5490", Offset = "0xAA4290", Length = "0x20")]
	public void OnScrollbarStatsDown()
	{
	}

	[Token(Token = "0x60036A0")]
	[Address(RVA = "0xAA54C0", Offset = "0xAA42C0", Length = "0xC7")]
	public void OnScrollbarCollectiblesUp()
	{
	}

	[Token(Token = "0x60036A1")]
	[Address(RVA = "0xAA5590", Offset = "0xAA4390", Length = "0xBF")]
	public void OnScrollbarCollectiblesDown()
	{
	}

	[Token(Token = "0x60036A2")]
	[Address(RVA = "0xAA5650", Offset = "0xAA4450", Length = "0x154")]
	public void OnScrollbarCollectiblesChange()
	{
	}

	[Token(Token = "0x60036A3")]
	[Address(RVA = "0xAA57B0", Offset = "0xAA45B0", Length = "0x1E1")]
	public void OnScrollbarDayStatsUp()
	{
	}

	[Token(Token = "0x60036A4")]
	[Address(RVA = "0xAA59A0", Offset = "0xAA47A0", Length = "0x1E1")]
	public void OnScrollbarDayStatsDown()
	{
	}

	[Token(Token = "0x60036A5")]
	[Address(RVA = "0xAA5B90", Offset = "0xAA4990", Length = "0x55")]
	public void OnScrollbarStatsDaysChange()
	{
	}

	[Token(Token = "0x60036A6")]
	[Address(RVA = "0xAA5BF0", Offset = "0xAA49F0", Length = "0x1AA")]
	public void OnScrollbarNotesUp()
	{
	}

	[Token(Token = "0x60036A7")]
	[Address(RVA = "0xAA5DA0", Offset = "0xAA4BA0", Length = "0x1AA")]
	public void OnScrollbarNotesDown()
	{
	}

	[Token(Token = "0x60036A8")]
	[Address(RVA = "0xAA5F50", Offset = "0xAA4D50", Length = "0x55")]
	public void OnScrollbarNotesChange()
	{
	}

	[Token(Token = "0x60036A9")]
	[Address(RVA = "0xAA5FB0", Offset = "0xAA4DB0", Length = "0x1AA")]
	public void OnScrollbarExamineCollectibleUp()
	{
	}

	[Token(Token = "0x60036AA")]
	[Address(RVA = "0xAA6160", Offset = "0xAA4F60", Length = "0x1AA")]
	public void OnScrollbarExamineCollectibleDown()
	{
	}

	[Token(Token = "0x60036AB")]
	[Address(RVA = "0xAA6310", Offset = "0xAA5110", Length = "0x55")]
	public void OnScrollbarExamineCollectibleChange()
	{
	}

	[Token(Token = "0x60036AC")]
	[Address(RVA = "0xAA6370", Offset = "0xAA5170", Length = "0x5A")]
	public void OnEnterGeneralNotes()
	{
	}

	[Token(Token = "0x60036AD")]
	[Address(RVA = "0xAA63D0", Offset = "0xAA51D0", Length = "0x74")]
	public void NotesToggle()
	{
	}

	[Token(Token = "0x60036AE")]
	[Address(RVA = "0xAA6450", Offset = "0xAA5250", Length = "0x11")]
	public void OnEnterNoteTaking()
	{
	}

	[Token(Token = "0x60036AF")]
	[Address(RVA = "0xAA6470", Offset = "0xAA5270", Length = "0x11")]
	public void OnShowDayStats()
	{
	}

	[Token(Token = "0x60036B0")]
	[Address(RVA = "0xAA6490", Offset = "0xAA5290", Length = "0x314")]
	public void NoteTakingStart()
	{
	}

	[Token(Token = "0x60036B1")]
	[Address(RVA = "0xAA67B0", Offset = "0xAA55B0", Length = "0x3F")]
	public void OnReadText()
	{
	}

	[Token(Token = "0x60036B2")]
	[Address(RVA = "0xAA67F0", Offset = "0xAA55F0", Length = "0x5A")]
	public void OnDailyLogButton()
	{
	}

	[Token(Token = "0x60036B3")]
	[Address(RVA = "0xAA6850", Offset = "0xAA5650", Length = "0x5A")]
	public void OnStatsButton()
	{
	}

	[Token(Token = "0x60036B4")]
	[Address(RVA = "0xAA68B0", Offset = "0xAA56B0", Length = "0x64")]
	public void OnCollectibleButton()
	{
	}

	[Token(Token = "0x60036B5")]
	[Address(RVA = "0xAA6920", Offset = "0xAA5720", Length = "0x5A")]
	public void OnRockCachesButton()
	{
	}

	[Token(Token = "0x60036B6")]
	[Address(RVA = "0xAA6980", Offset = "0xAA5780", Length = "0x5A")]
	public void OnCartographyButton()
	{
	}

	[Token(Token = "0x60036B7")]
	[Address(RVA = "0xAA69E0", Offset = "0xAA57E0", Length = "0x5A")]
	public void OnPhotoAlbumButton()
	{
	}

	[Token(Token = "0x60036B8")]
	[Address(RVA = "0xAA6A40", Offset = "0xAA5840", Length = "0x5A")]
	public void OnTraderButton()
	{
	}

	[Token(Token = "0x60036B9")]
	[Address(RVA = "0xAA6AA0", Offset = "0xAA58A0", Length = "0x5A")]
	public void OnTransmittersButton()
	{
	}

	[Token(Token = "0x60036BA")]
	[Address(RVA = "0xAA6B00", Offset = "0xAA5900", Length = "0x5A")]
	public void OnExamineCollectible()
	{
	}

	[Token(Token = "0x60036BB")]
	[Address(RVA = "0xAA6B60", Offset = "0xAA5960", Length = "0x268")]
	public void Reset()
	{
	}

	[Token(Token = "0x60036BC")]
	[Address(RVA = "0xAA6DD0", Offset = "0xAA5BD0", Length = "0xD0")]
	public void OnCraftingNav()
	{
	}

	[Token(Token = "0x60036BD")]
	[Address(RVA = "0xAA6EB0", Offset = "0xAA5CB0", Length = "0xE2")]
	public void OnMapNav()
	{
	}

	[Token(Token = "0x60036BE")]
	[Address(RVA = "0xAA6FA0", Offset = "0xAA5DA0", Length = "0x5A")]
	public void OnJournalNav()
	{
	}

	[Token(Token = "0x60036BF")]
	[Address(RVA = "0xAA7000", Offset = "0xAA5E00", Length = "0x5A")]
	public void OnMissionsNav()
	{
	}

	[Token(Token = "0x60036C0")]
	[Address(RVA = "0xAA7060", Offset = "0xAA5E60", Length = "0x17E")]
	public void HandleOnNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x60036C1")]
	[Address(RVA = "0xAA71E0", Offset = "0xAA5FE0", Length = "0xC2")]
	public void HandleOnSubcategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x60036C2")]
	[Address(RVA = "0xAA72B0", Offset = "0xAA60B0", Length = "0x1A")]
	public void HandleOnMainCategoryNotificationRemoved(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x60036C3")]
	[Address(RVA = "0xAA72D0", Offset = "0xAA60D0", Length = "0x9C")]
	public void ShowPanelLogMainCategoryNotificationIcon(MainCategory mainCategory, bool enable)
	{
	}

	[Token(Token = "0x60036C4")]
	[Address(RVA = "0xAA7370", Offset = "0xAA6170", Length = "0x16C")]
	private void Refresh()
	{
	}

	[Token(Token = "0x60036C5")]
	[Address(RVA = "0xAA7520", Offset = "0xAA6320", Length = "0x21")]
	public void ExitInterfaceOnDeath()
	{
	}

	[Token(Token = "0x60036C6")]
	[Address(RVA = "0xAA7550", Offset = "0xAA6350", Length = "0x1BA")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x60036C7")]
	[Address(RVA = "0xAA7710", Offset = "0xAA6510", Length = "0x1D6")]
	public void OnQuitToMainMenu()
	{
	}

	[Token(Token = "0x60036C8")]
	[Address(RVA = "0xAA78F0", Offset = "0xAA66F0", Length = "0x7")]
	public void ForceQuit()
	{
	}

	[Token(Token = "0x60036C9")]
	[Address(RVA = "0xAA7900", Offset = "0xAA6700", Length = "0x82")]
	public void ReallyQuitToMainMenu()
	{
	}

	[Token(Token = "0x60036CA")]
	[Address(RVA = "0xAA7990", Offset = "0xAA6790", Length = "0xB")]
	public bool IsInSectionNav()
	{
		return false;
	}

	[Token(Token = "0x60036CB")]
	[Address(RVA = "0xAA79A0", Offset = "0xAA67A0", Length = "0xAA")]
	private bool QuitToMainMenuOnBack()
	{
		return false;
	}

	[Token(Token = "0x60036CC")]
	[Address(RVA = "0xAA7A50", Offset = "0xAA6850", Length = "0x113")]
	private string GetOnBackText()
	{
		return null;
	}

	[Token(Token = "0x60036CD")]
	[Address(RVA = "0xAA7B70", Offset = "0xAA6970", Length = "0xC")]
	private void SelectSandbox(int index)
	{
	}

	[Token(Token = "0x60036CE")]
	[Address(RVA = "0xAA7B80", Offset = "0xAA6980", Length = "0x71")]
	private bool AreTalesAvailable()
	{
		return false;
	}

	[Token(Token = "0x60036CF")]
	[Address(RVA = "0xAA7C00", Offset = "0xAA6A00", Length = "0xF7")]
	private bool IsChallengeMode()
	{
		return false;
	}

	[Token(Token = "0x60036D0")]
	[Address(RVA = "0xAA7D00", Offset = "0xAA6B00", Length = "0x7C8")]
	private void EnterState(PanelLogState newState)
	{
	}

	[Token(Token = "0x60036D1")]
	[Address(RVA = "0xAA8510", Offset = "0xAA7310", Length = "0x7DE")]
	public void ResetNotificationsData()
	{
	}

	[Token(Token = "0x60036D2")]
	[Address(RVA = "0xAA8CF0", Offset = "0xAA7AF0", Length = "0xD9A")]
	private void UpdateDailyStatsPage()
	{
	}

	[Token(Token = "0x60036D3")]
	[Address(RVA = "0xAA9A90", Offset = "0xAA8890", Length = "0x341")]
	private void UpdateStatsSlider()
	{
	}

	[Token(Token = "0x60036D4")]
	[Address(RVA = "0xAA9DE0", Offset = "0xAA8BE0", Length = "0x4CB")]
	private void UpdateNotesPage()
	{
	}

	[Token(Token = "0x60036D5")]
	[Address(RVA = "0xAAA2B0", Offset = "0xAA90B0", Length = "0x312")]
	private void UpdateExamineCollectibleSlider()
	{
	}

	[Token(Token = "0x60036D6")]
	[Address(RVA = "0xAAA5D0", Offset = "0xAA93D0", Length = "0x312")]
	private void UpdateNotesSlider()
	{
	}

	[Token(Token = "0x60036D7")]
	[Address(RVA = "0xAAA8F0", Offset = "0xAA96F0", Length = "0x93B")]
	private void CheckForNotesChange()
	{
	}

	[Token(Token = "0x60036D8")]
	[Address(RVA = "0xAAB230", Offset = "0xAAA030", Length = "0x651")]
	private void UpdateCollectibleList()
	{
	}

	[Token(Token = "0x60036D9")]
	[Address(RVA = "0xAAB890", Offset = "0xAAA690", Length = "0x1131")]
	private void UpdateExamineCollectible()
	{
	}

	[Token(Token = "0x60036DA")]
	[Address(RVA = "0xAAC9D0", Offset = "0xAAB7D0", Length = "0x18A")]
	private void BuildStatsView()
	{
	}

	[Token(Token = "0x60036DB")]
	[Address(RVA = "0xAACB60", Offset = "0xAAB960", Length = "0x5E5")]
	private void BuildDailyList(bool doSelectionReset)
	{
	}

	[Token(Token = "0x60036DC")]
	[Address(RVA = "0xAAD150", Offset = "0xAABF50", Length = "0x137A")]
	private void BuildCollectibleList(bool doSelectionReset)
	{
	}

	[Token(Token = "0x60036DD")]
	[Address(RVA = "0xAAE4D0", Offset = "0xAAD2D0", Length = "0x8EA")]
	private void ClearGrid(UIGrid gridToClear)
	{
	}

	[Token(Token = "0x60036DE")]
	[Address(RVA = "0xAAEDC0", Offset = "0xAADBC0", Length = "0x14")]
	private bool ShouldShowNotes()
	{
		return false;
	}

	[Token(Token = "0x60036DF")]
	[Address(RVA = "0xAAEDE0", Offset = "0xAADBE0", Length = "0x75")]
	private bool CanEditJournal()
	{
		return false;
	}

	[Token(Token = "0x60036E0")]
	[Address(RVA = "0xAAEE60", Offset = "0xAADC60", Length = "0x10A")]
	private bool CanSaveJournal()
	{
		return false;
	}

	[Token(Token = "0x60036E1")]
	[Address(RVA = "0xAAEF70", Offset = "0xAADD70", Length = "0x166")]
	private void ScrollListMovement(int moveVal)
	{
	}

	[Token(Token = "0x60036E2")]
	[Address(RVA = "0xAAF0E0", Offset = "0xAADEE0", Length = "0xD7")]
	private void DoScrollListScrollLeft()
	{
	}

	[Token(Token = "0x60036E3")]
	[Address(RVA = "0xAAF1C0", Offset = "0xAADFC0", Length = "0xC2")]
	private void DoScrollListScrolLRight()
	{
	}

	[Token(Token = "0x60036E4")]
	[Address(RVA = "0xAAF290", Offset = "0xAAE090", Length = "0x548")]
	private void DoControlsCollectibleList()
	{
	}

	[Token(Token = "0x60036E5")]
	[Address(RVA = "0xAAF7E0", Offset = "0xAAE5E0", Length = "0x42D")]
	private void DoControlsDailyListStats()
	{
	}

	[Token(Token = "0x60036E6")]
	[Address(RVA = "0xAAFC10", Offset = "0xAAEA10", Length = "0x54E")]
	private void DoControlsStats()
	{
	}

	[Token(Token = "0x60036E7")]
	[Address(RVA = "0xAB0160", Offset = "0xAAEF60", Length = "0xE2")]
	private void DoControlsTransmitters()
	{
	}

	[Token(Token = "0x60036E8")]
	[Address(RVA = "0xAB0250", Offset = "0xAAF050", Length = "0x1A1")]
	public void OnResetAllTimeStats()
	{
	}

	[Token(Token = "0x60036E9")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[Token(Token = "0x60036EA")]
	[Address(RVA = "0xAB0400", Offset = "0xAAF200", Length = "0x88")]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[Token(Token = "0x60036EB")]
	[Address(RVA = "0xAB0490", Offset = "0xAAF290", Length = "0x365")]
	private void DoControlsExamineCollectible()
	{
	}

	[Token(Token = "0x60036EC")]
	[Address(RVA = "0xAB0800", Offset = "0xAAF600", Length = "0x4BA")]
	private void DoSectionNavControls()
	{
	}

	[Token(Token = "0x60036ED")]
	[Address(RVA = "0xAB0CC0", Offset = "0xAAFAC0", Length = "0x3FA")]
	private void RefreshActivePanelStates()
	{
	}

	[Token(Token = "0x60036EE")]
	[Address(RVA = "0xAB10C0", Offset = "0xAAFEC0", Length = "0xB1")]
	private void DisableAllMouseButtons()
	{
	}

	[Token(Token = "0x60036EF")]
	[Address(RVA = "0xAB1180", Offset = "0xAAFF80", Length = "0x624")]
	private void DoControls()
	{
	}

	[Token(Token = "0x60036F0")]
	[Address(RVA = "0xAB17F0", Offset = "0xAB05F0", Length = "0x2CA")]
	private void DoMouseScrollControls()
	{
	}

	[Token(Token = "0x60036F1")]
	[Address(RVA = "0xAB1AC0", Offset = "0xAB08C0", Length = "0x10A")]
	private void UpdateNavigationButtons()
	{
	}

	[Token(Token = "0x60036F2")]
	[Address(RVA = "0xAB1BD0", Offset = "0xAB09D0", Length = "0x4C7")]
	private void SetUpTopNav()
	{
	}

	[Token(Token = "0x60036F3")]
	[Address(RVA = "0xAB20A0", Offset = "0xAB0EA0", Length = "0x1A6")]
	private void UpdateCurrentGameLabel()
	{
	}

	[Token(Token = "0x60036F4")]
	[Address(RVA = "0xAB2250", Offset = "0xAB1050", Length = "0x3CE")]
	private void UpdateScrollbarThumbSize()
	{
	}

	[Token(Token = "0x60036F5")]
	[Address(RVA = "0xAB2620", Offset = "0xAB1420", Length = "0x106")]
	private void UpdateScrollbarThumbSizeIndividual(UISlider slider, int numVisible, int total)
	{
	}

	[Token(Token = "0x60036F6")]
	[Address(RVA = "0xAB2730", Offset = "0xAB1530", Length = "0xC5")]
	private void DoMainNavControls()
	{
	}

	[Token(Token = "0x60036F7")]
	[Address(RVA = "0xAB2800", Offset = "0xAB1600", Length = "0x5E")]
	private bool ShouldRenderOverOtherScreens()
	{
		return false;
	}

	[Token(Token = "0x60036F8")]
	[Address(RVA = "0xAB2860", Offset = "0xAB1660", Length = "0x8C")]
	private void ActivateBackButton()
	{
	}

	[Token(Token = "0x60036F9")]
	[Address(RVA = "0xAB28F0", Offset = "0xAB16F0", Length = "0x2FF")]
	private void InstantiateLogGridItems()
	{
	}

	[Token(Token = "0x60036FA")]
	[Address(RVA = "0xAB2BF0", Offset = "0xAB19F0", Length = "0x1F5")]
	private void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[Token(Token = "0x60036FB")]
	[Address(RVA = "0xAB2DF0", Offset = "0xAB1BF0", Length = "0xA3")]
	private bool ShouldEnterSectionNav()
	{
		return false;
	}

	[Token(Token = "0x60036FC")]
	[Address(RVA = "0xAB2EA0", Offset = "0xAB1CA0", Length = "0x2C")]
	private void MoveSectionNavToButton(PanelLogState buttonState)
	{
	}

	[Token(Token = "0x60036FD")]
	[Address(RVA = "0xAB3700", Offset = "0xAB2500", Length = "0x3F5")]
	private void MoveGridSelection(int horizontal, int vertical)
	{
	}

	[Token(Token = "0x60036FE")]
	[Address(RVA = "0xAB3B00", Offset = "0xAB2900", Length = "0x2D")]
	private int GetNumGridItemsShowing()
	{
		return 0;
	}

	[Token(Token = "0x60036FF")]
	[Address(RVA = "0xAB3B30", Offset = "0xAB2930", Length = "0x2C9")]
	private int GetTotalNumGridItems()
	{
		return 0;
	}

	[Token(Token = "0x6003700")]
	[Address(RVA = "0xAB3E00", Offset = "0xAB2C00", Length = "0x8A")]
	private void SetLogGridItemIndex(int index)
	{
	}

	[Token(Token = "0x6003701")]
	[Address(RVA = "0xAB3E90", Offset = "0xAB2C90", Length = "0x14")]
	private int GetCollectibleListTrueIndex()
	{
		return 0;
	}

	[Token(Token = "0x6003702")]
	[Address(RVA = "0xAB3EB0", Offset = "0xAB2CB0", Length = "0x1D")]
	private bool StateIsShowing(PanelLogState state)
	{
		return false;
	}

	[Token(Token = "0x6003703")]
	[Address(RVA = "0xAB1AC0", Offset = "0xAB08C0", Length = "0x10A")]
	private void UpdateSectionNavButtonColors()
	{
	}

	[Token(Token = "0x6003704")]
	[Address(RVA = "0xAB3ED0", Offset = "0xAB2CD0", Length = "0x1D6")]
	private void DoSectionNavUpdate()
	{
	}

	[Token(Token = "0x6003705")]
	[Address(RVA = "0xAB40B0", Offset = "0xAB2EB0", Length = "0x230")]
	private void EnterSectionNav()
	{
	}

	[Token(Token = "0x6003706")]
	[Address(RVA = "0xAB4300", Offset = "0xAB3100", Length = "0x376")]
	private void DeselectLogGridItems()
	{
	}

	[Token(Token = "0x6003707")]
	[Address(RVA = "0xAB4680", Offset = "0xAB3480", Length = "0xC9")]
	private void EnableAllLBRBButtons(bool shouldEnable)
	{
	}

	[Token(Token = "0x6003708")]
	[Address(RVA = "0xAB4750", Offset = "0xAB3550", Length = "0x71")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[Token(Token = "0x6003709")]
	[Address(RVA = "0xAB47D0", Offset = "0xAB35D0", Length = "0x10F")]
	private void SetActiveTab(NavigationTabState state)
	{
	}

	[Token(Token = "0x600370A")]
	[Address(RVA = "0xAB48E0", Offset = "0xAB36E0", Length = "0xFF")]
	private void SetActive(GameObject go, bool enable)
	{
	}

	[Token(Token = "0x600370B")]
	[Address(RVA = "0xAB49E0", Offset = "0xAB37E0", Length = "0x433")]
	private void CacheComponents()
	{
	}

	[Token(Token = "0x600370C")]
	[Address(RVA = "0xAB4E20", Offset = "0xAB3C20", Length = "0x29")]
	private void ReleaseTempResources()
	{
	}

	[Token(Token = "0x600370D")]
	[Address(RVA = "0xAB4E50", Offset = "0xAB3C50", Length = "0x390")]
	private bool HasEnableFromRadialOverride(out PanelLogState overrideState)
	{
		overrideState = default(PanelLogState);
		return false;
	}

	[Token(Token = "0x600370E")]
	[Address(RVA = "0xAB51F0", Offset = "0xAB3FF0", Length = "0x1DC")]
	private void MaybeRemoveJournalState(GameModeConfig gameMode, PanelLogState state)
	{
	}

	[Token(Token = "0x600370F")]
	[Address(RVA = "0xAB53D0", Offset = "0xAB41D0", Length = "0x965")]
	private void InitializeGameplayTagLookups()
	{
	}

	[Token(Token = "0x6003710")]
	[Address(RVA = "0xAB5D40", Offset = "0xAB4B40", Length = "0xA0")]
	private void UpdateTOCSelection()
	{
	}

	[Token(Token = "0x6003711")]
	[Address(RVA = "0xAB5DF0", Offset = "0xAB4BF0", Length = "0x7FF")]
	private void UncacheSandboxRecord(SandboxRecordData record)
	{
	}

	[Token(Token = "0x6003712")]
	[Address(RVA = "0xAB65F0", Offset = "0xAB53F0", Length = "0x5E")]
	public void ViewSandbox()
	{
	}

	[Token(Token = "0x6003713")]
	[Address(RVA = "0xAB6650", Offset = "0xAB5450", Length = "0x257")]
	public void OnDeleteSandbox()
	{
	}

	[Token(Token = "0x6003714")]
	[Address(RVA = "0xAB68B0", Offset = "0xAB56B0", Length = "0x123")]
	public void OnDeleteSandboxConfirmed()
	{
	}

	[Token(Token = "0x6003715")]
	[Address(RVA = "0xAB69E0", Offset = "0xAB57E0", Length = "0x259")]
	public void OnRenameSandbox()
	{
	}

	[Token(Token = "0x6003716")]
	[Address(RVA = "0xAB6C40", Offset = "0xAB5A40", Length = "0x188")]
	public void OnRenameSandboxConfirmed()
	{
	}

	[Token(Token = "0x6003717")]
	[Address(RVA = "0xAB6DD0", Offset = "0xAB5BD0", Length = "0x70")]
	public void OnRenameSandboxCancelled(bool wasCancelled)
	{
	}

	[Token(Token = "0x6003718")]
	[Address(RVA = "0xAB6E50", Offset = "0xAB5C50", Length = "0x289")]
	public void OnOverwriteSandbox()
	{
	}

	[Token(Token = "0x6003719")]
	[Address(RVA = "0xAB70E0", Offset = "0xAB5EE0", Length = "0x157")]
	private void OnOverwriteSandboxConfirmed()
	{
	}

	[Token(Token = "0x600371A")]
	[Address(RVA = "0xAB7240", Offset = "0xAB6040", Length = "0x165")]
	private void OnSandboxLimitNotification()
	{
	}

	[Token(Token = "0x600371B")]
	[Address(RVA = "0xAB73B0", Offset = "0xAB61B0", Length = "0x11")]
	private void OnSandboxLimitNotificationConfirmed()
	{
	}

	[Token(Token = "0x600371C")]
	[Address(RVA = "0xAB73D0", Offset = "0xAB61D0", Length = "0x23B")]
	public void OnSaveJournal()
	{
	}

	[Token(Token = "0x600371D")]
	[Address(RVA = "0xAB7610", Offset = "0xAB6410", Length = "0xEA")]
	private void ReallySaveJournal(int insertIndex)
	{
	}

	[Token(Token = "0x600371E")]
	[Address(RVA = "0xAB7700", Offset = "0xAB6500", Length = "0x2A8")]
	public void EnableTableOfContentsView()
	{
	}

	[Token(Token = "0x600371F")]
	[Address(RVA = "0xAB79B0", Offset = "0xAB67B0", Length = "0x166")]
	private void CreateLogObject()
	{
	}

	[Token(Token = "0x6003720")]
	[Address(RVA = "0xAB7B20", Offset = "0xAB6920", Length = "0x1DA")]
	private void UpdateTocViewButtons()
	{
	}

	[Token(Token = "0x6003721")]
	[Address(RVA = "0xAB7D00", Offset = "0xAB6B00", Length = "0x146")]
	private void DoControlsTOCView()
	{
	}

	[Token(Token = "0x6003722")]
	[Address(RVA = "0xAB7E50", Offset = "0xAB6C50", Length = "0x1A5")]
	private void BuildTOCList()
	{
	}

	[Token(Token = "0x6003723")]
	[Address(RVA = "0xAB8000", Offset = "0xAB6E00", Length = "0x1DA")]
	private void UpdateTocViewOverwriteButtons()
	{
	}

	[Token(Token = "0x6003724")]
	[Address(RVA = "0xAB81E0", Offset = "0xAB6FE0", Length = "0x191")]
	private void DoControlsTOCViewOverwrite()
	{
	}

	[Token(Token = "0x6003725")]
	[Address(RVA = "0xAB8380", Offset = "0xAB7180", Length = "0x84D")]
	private SandboxRecordData CreateSandboxRecord()
	{
		return null;
	}

	[Token(Token = "0x6003726")]
	[Address(RVA = "0xAB8BD0", Offset = "0xAB79D0", Length = "0x33C")]
	private void StoreNoteCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[Token(Token = "0x6003727")]
	[Address(RVA = "0xAB8F10", Offset = "0xAB7D10", Length = "0x5ED")]
	private void StoreCairnCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[Token(Token = "0x6003728")]
	[Address(RVA = "0xAB9500", Offset = "0xAB8300", Length = "0x4FC")]
	private void StoreAuroraScreenCollectiblesInRecord(SandboxRecordData record)
	{
	}

	[Token(Token = "0x6003729")]
	[Address(RVA = "0xAB9A00", Offset = "0xAB8800", Length = "0x6E7")]
	private void UpdateAlmanacPage()
	{
	}

	[Token(Token = "0x600372A")]
	[Address(RVA = "0xABA0F0", Offset = "0xAB8EF0", Length = "0x5A")]
	public void OnAlmanacButton()
	{
	}

	[Token(Token = "0x600372B")]
	[Address(RVA = "0xABA150", Offset = "0xAB8F50", Length = "0x14E")]
	public void DoControlsAlmanac()
	{
	}

	[Token(Token = "0x600372C")]
	[Address(RVA = "0xABA2A0", Offset = "0xAB90A0", Length = "0x81F")]
	private void InstantiateGridItems()
	{
	}

	[Token(Token = "0x600372D")]
	[Address(RVA = "0xABAAC0", Offset = "0xAB98C0", Length = "0x1CD")]
	public Texture GetRegionButtonTexture(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x600372E")]
	[Address(RVA = "0xABAC90", Offset = "0xAB9A90", Length = "0xDC1")]
	private void UpdateCartographyPage()
	{
	}

	[Token(Token = "0x600372F")]
	[Address(RVA = "0xABBA60", Offset = "0xABA860", Length = "0x820")]
	private void RefreshAchievementListForSelectedRegion(bool newRegion)
	{
	}

	[Token(Token = "0x6003730")]
	[Address(RVA = "0xABC290", Offset = "0xABB090", Length = "0x1B8")]
	protected void OnSurveyRegionClicked(int index)
	{
	}

	[Token(Token = "0x6003731")]
	[Address(RVA = "0xABC450", Offset = "0xABB250", Length = "0x5A6")]
	public void DoControlsCartography()
	{
	}

	[Token(Token = "0x6003732")]
	[Address(RVA = "0xABCA00", Offset = "0xABB800", Length = "0x65")]
	public void OnForceRevealHiddenDetailsToggle()
	{
	}

	[Token(Token = "0x6003733")]
	[Address(RVA = "0xABCA70", Offset = "0xABB870", Length = "0x11F")]
	private void OnSurveyBack()
	{
	}

	[Token(Token = "0x6003734")]
	[Address(RVA = "0xABCB90", Offset = "0xABB990", Length = "0x108")]
	protected void OnSurveyClicked(int index)
	{
	}

	[Token(Token = "0x6003735")]
	[Address(RVA = "0xABCCA0", Offset = "0xABBAA0", Length = "0x158")]
	public void OnSurveyRegionScrollbarChange()
	{
	}

	[Token(Token = "0x6003736")]
	[Address(RVA = "0xABCE00", Offset = "0xABBC00", Length = "0x158")]
	public void OnSurveyAchievementScrollbarChange()
	{
	}

	[Token(Token = "0x6003737")]
	[Address(RVA = "0xABCF60", Offset = "0xABBD60", Length = "0x2F0")]
	public void HandleSurveyScrollbar(float amount)
	{
	}

	[Token(Token = "0x6003738")]
	[Address(RVA = "0xABD260", Offset = "0xABC060", Length = "0x1FB")]
	private void HandleSurveyVerticalNavigation(float amount)
	{
	}

	[Token(Token = "0x6003739")]
	[Address(RVA = "0xABD460", Offset = "0xABC260", Length = "0x1C80")]
	private void BuildCartographyRegionList()
	{
	}

	[Token(Token = "0x600373C")]
	[Address(RVA = "0xABF190", Offset = "0xABDF90", Length = "0x25B")]
	private void UpdateCollectionsPage()
	{
	}

	[Token(Token = "0x600373D")]
	[Address(RVA = "0xABF3F0", Offset = "0xABE1F0", Length = "0x18D")]
	private void ReleaseTempResources_Collections()
	{
	}

	[Token(Token = "0x600373E")]
	[Address(RVA = "0x60BBE0", Offset = "0x60A9E0", Length = "0x3")]
	public void OnCollectiblesTab()
	{
	}

	[Token(Token = "0x600373F")]
	[Address(RVA = "0x60BBE0", Offset = "0x60A9E0", Length = "0x3")]
	public void OnCollectionsTab()
	{
	}

	[Token(Token = "0x6003740")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void DoCollectionsToggle()
	{
	}

	[Token(Token = "0x6003741")]
	[Address(RVA = "0xABF580", Offset = "0xABE380", Length = "0x421")]
	public void DoControlsCollectionList()
	{
	}

	[Token(Token = "0x6003742")]
	[Address(RVA = "0xABF9B0", Offset = "0xABE7B0", Length = "0x145")]
	public void OnCollectionsSubScreen()
	{
	}

	[Token(Token = "0x6003743")]
	[Address(RVA = "0xABFB00", Offset = "0xABE900", Length = "0x200")]
	private void BuildCollectionsList()
	{
	}

	[Token(Token = "0x6003744")]
	[Address(RVA = "0xABFD10", Offset = "0xABEB10", Length = "0x2F0")]
	private void UpdateAvailablePostCards()
	{
	}

	[Token(Token = "0x6003745")]
	[Address(RVA = "0xAC0010", Offset = "0xABEE10", Length = "0x326")]
	private void UpdateAvailableMementos()
	{
	}

	[Token(Token = "0x6003746")]
	[Address(RVA = "0xAC0340", Offset = "0xABF140", Length = "0x1AD")]
	private void AddEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[Token(Token = "0x6003747")]
	[Address(RVA = "0xAC04F0", Offset = "0xABF2F0", Length = "0x11D")]
	private void UpdateCollectionListSelectionScroll(int moveVal, ref int index)
	{
	}

	[Token(Token = "0x6003748")]
	[Address(RVA = "0xAC0610", Offset = "0xABF410", Length = "0xC0")]
	private void UpdateCollectionListItemsColor()
	{
	}

	[Token(Token = "0x6003749")]
	[Address(RVA = "0xAC06E0", Offset = "0xABF4E0", Length = "0x1ABF")]
	private void GenerateCollectionSelectScreenDummyData(List<CollectionListItemInfo> dummyDataList)
	{
	}

	[Token(Token = "0x600374A")]
	[Address(RVA = "0xAC21A0", Offset = "0xAC0FA0", Length = "0x22E")]
	private int CountDiscoveredTransmitters(IList<TransmitterData> allTransmitters)
	{
		return 0;
	}

	[Token(Token = "0x600374B")]
	[Address(RVA = "0xAC23D0", Offset = "0xAC11D0", Length = "0x18")]
	private bool IsInCollectionsSelectScreen()
	{
		return false;
	}

	[Token(Token = "0x600374C")]
	[Address(RVA = "0xAC23F0", Offset = "0xAC11F0", Length = "0x2C0")]
	private void SetCollectionSubscreenNameLabel()
	{
	}

	[Token(Token = "0x600374D")]
	[Address(RVA = "0xAC26E0", Offset = "0xAC14E0", Length = "0x400")]
	private void RefreshCollectibleCounters()
	{
	}

	[Token(Token = "0x600374E")]
	[Address(RVA = "0xAC2AF0", Offset = "0xAC18F0", Length = "0xA8")]
	private void RemoveNewCollectionEntry(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x600374F")]
	[Address(RVA = "0xAC2BA0", Offset = "0xAC19A0", Length = "0xD9")]
	private void MaybeShowNotificationFlagForNewCollectionEntry()
	{
	}

	[Token(Token = "0x6003750")]
	[Address(RVA = "0xAC2C80", Offset = "0xAC1A80", Length = "0x14AF")]
	private void UpdateMissionsPage()
	{
	}

	[Token(Token = "0x6003751")]
	[Address(RVA = "0xAC4130", Offset = "0xAC2F30", Length = "0x1B2")]
	private void SetChallengeTextureAsync(ChallengeConfig challengeConfig)
	{
	}

	[Token(Token = "0x6003752")]
	[Address(RVA = "0xAC42F0", Offset = "0xAC30F0", Length = "0x3F5")]
	public void UpdateMissionInfo(string name, string description, string[] checklistKeys, string[] checklistValues, bool[] checklistBools)
	{
	}

	[Token(Token = "0x6003753")]
	[Address(RVA = "0xAC46F0", Offset = "0xAC34F0", Length = "0x115")]
	public void RemoveMission(string name)
	{
	}

	[Token(Token = "0x6003754")]
	[Address(RVA = "0xAC4810", Offset = "0xAC3610", Length = "0x9F")]
	public void ClearMissions()
	{
	}

	[Token(Token = "0x6003755")]
	[Address(RVA = "0xAC48B0", Offset = "0xAC36B0", Length = "0x5A")]
	public void OnMissionsButton()
	{
	}

	[Token(Token = "0x6003756")]
	[Address(RVA = "0xAC4910", Offset = "0xAC3710", Length = "0x3CB")]
	public void DoControlsMissions()
	{
	}

	[Token(Token = "0x6003757")]
	[Address(RVA = "0xAC4CE0", Offset = "0xAC3AE0", Length = "0x65E")]
	private void UpdateMissionInfoFromPrefab()
	{
	}

	[Token(Token = "0x6003758")]
	[Address(RVA = "0xAC5340", Offset = "0xAC4140", Length = "0x24D")]
	public void OnDeletePhoto()
	{
	}

	[Token(Token = "0x6003759")]
	[Address(RVA = "0xAC5590", Offset = "0xAC4390", Length = "0x2D6")]
	public void OnAnnotatePhoto()
	{
	}

	[Token(Token = "0x600375A")]
	[Address(RVA = "0xAC5870", Offset = "0xAC4670", Length = "0xC7")]
	public void OnScrollbarPhotoAlbumUp()
	{
	}

	[Token(Token = "0x600375B")]
	[Address(RVA = "0xAC5940", Offset = "0xAC4740", Length = "0xBF")]
	public void OnScrollbarPhotoAlbumDown()
	{
	}

	[Token(Token = "0x600375C")]
	[Address(RVA = "0xAC5A00", Offset = "0xAC4800", Length = "0x154")]
	public void OnScrollbarPhotoAlbumChange()
	{
	}

	[Token(Token = "0x600375D")]
	[Address(RVA = "0xAC5B60", Offset = "0xAC4960", Length = "0x47F")]
	private void BuildPhotoAlbum(bool resetSelection)
	{
	}

	[Token(Token = "0x600375E")]
	[Address(RVA = "0xAC5FE0", Offset = "0xAC4DE0", Length = "0x61A")]
	private void DoControlsPhotoAlbum()
	{
	}

	[Token(Token = "0x600375F")]
	[Address(RVA = "0xAC6600", Offset = "0xAC5400", Length = "0x3BD")]
	private void UpdatePhotoAlbum()
	{
	}

	[Token(Token = "0x6003760")]
	[Address(RVA = "0xAC69C0", Offset = "0xAC57C0", Length = "0x1CB")]
	private void OnAnnotatePhotoConfirmed()
	{
	}

	[Token(Token = "0x6003761")]
	[Address(RVA = "0xAC6B90", Offset = "0xAC5990", Length = "0x164")]
	private void OnDeletePhotoConfirmed()
	{
	}

	[Token(Token = "0x6003762")]
	[Address(RVA = "0xAC6D00", Offset = "0xAC5B00", Length = "0xD32")]
	private void BuildRockCacheRegionScrollList()
	{
	}

	[Token(Token = "0x6003763")]
	[Address(RVA = "0xAC7A40", Offset = "0xAC6840", Length = "0x2A3")]
	private void SetRegionAndRockCacheSelected(string sceneName, string rockCacheName)
	{
	}

	[Token(Token = "0x6003764")]
	[Address(RVA = "0xAC7CF0", Offset = "0xAC6AF0", Length = "0xFBF")]
	private void RefreshRockCacheListForSelectedRegion(bool newRegion)
	{
	}

	[Token(Token = "0x6003765")]
	[Address(RVA = "0xAC8CB0", Offset = "0xAC7AB0", Length = "0x102")]
	private int GetNumberOfRockCachesInCurrentRegion()
	{
		return 0;
	}

	[Token(Token = "0x6003766")]
	[Address(RVA = "0xAC8DC0", Offset = "0xAC7BC0", Length = "0x158")]
	public void OnRockCacheRegionScrollbarChange()
	{
	}

	[Token(Token = "0x6003767")]
	[Address(RVA = "0xAC8F20", Offset = "0xAC7D20", Length = "0x158")]
	public void OnRockCacheItemScrollbarChange()
	{
	}

	[Token(Token = "0x6003768")]
	[Address(RVA = "0xAC9080", Offset = "0xAC7E80", Length = "0x327")]
	public void OnRockCacheRenameButton()
	{
	}

	[Token(Token = "0x6003769")]
	[Address(RVA = "0xAC93B0", Offset = "0xAC81B0", Length = "0x227")]
	private void OnRenameRockCacheConfirmed()
	{
	}

	[Token(Token = "0x600376A")]
	[Address(RVA = "0xAC95E0", Offset = "0xAC83E0", Length = "0x185")]
	public void OnRockCacheEditNoteClicked()
	{
	}

	[Token(Token = "0x600376B")]
	[Address(RVA = "0xAC9770", Offset = "0xAC8570", Length = "0x26C")]
	public void OnRockCacheNoteScrollbarUp()
	{
	}

	[Token(Token = "0x600376C")]
	[Address(RVA = "0xAC99E0", Offset = "0xAC87E0", Length = "0x271")]
	public void OnRockCacheNoteScrollbarDown()
	{
	}

	[Token(Token = "0x600376D")]
	[Address(RVA = "0xAC9C60", Offset = "0xAC8A60", Length = "0x55")]
	public void OnRockCacheNoteScrollbarChange()
	{
	}

	[Token(Token = "0x600376E")]
	[Address(RVA = "0xAC9CC0", Offset = "0xAC8AC0", Length = "0x312")]
	private void UpdateRockCacheNoteSlider()
	{
	}

	[Token(Token = "0x600376F")]
	[Address(RVA = "0xAC9FE0", Offset = "0xAC8DE0", Length = "0x29D")]
	public void RockCacheNoteTakingStart()
	{
	}

	[Token(Token = "0x6003770")]
	[Address(RVA = "0xACA280", Offset = "0xAC9080", Length = "0x179")]
	private void MaybeUpdateNote()
	{
	}

	[Token(Token = "0x6003771")]
	[Address(RVA = "0xACA400", Offset = "0xAC9200", Length = "0x7EA")]
	public void MaybeUpdateRockCacheNoteView()
	{
	}

	[Token(Token = "0x6003772")]
	[Address(RVA = "0xACABF0", Offset = "0xAC99F0", Length = "0x7F8")]
	private void DoControlsRockCaches()
	{
	}

	[Token(Token = "0x6003773")]
	[Address(RVA = "0xACB3F0", Offset = "0xACA1F0", Length = "0x1C8")]
	private void OnRockCacheBack()
	{
	}

	[Token(Token = "0x6003774")]
	[Address(RVA = "0xACB5C0", Offset = "0xACA3C0", Length = "0x2C1")]
	public void HandleScrollbar(float amount)
	{
	}

	[Token(Token = "0x6003775")]
	[Address(RVA = "0xACB890", Offset = "0xACA690", Length = "0x226")]
	private void HandleVerticalNavigation(float amount)
	{
	}

	[Token(Token = "0x6003776")]
	[Address(RVA = "0xACBAC0", Offset = "0xACA8C0", Length = "0x186")]
	protected void OnRockCacheRegionClicked(int index)
	{
	}

	[Token(Token = "0x6003777")]
	[Address(RVA = "0xACBC50", Offset = "0xACAA50", Length = "0x41D")]
	protected void OnRockCacheItemClicked(int index)
	{
	}

	[Token(Token = "0x6003778")]
	[Address(RVA = "0xACC070", Offset = "0xACAE70", Length = "0x388")]
	public void OnRockCacheShowOnMapClicked()
	{
	}

	[Token(Token = "0x6003779")]
	[Address(RVA = "0xACC400", Offset = "0xACB200", Length = "0xB65")]
	private void GenerateRockCacheScreenData()
	{
	}

	[Token(Token = "0x600377A")]
	[Address(RVA = "0xACCF70", Offset = "0xACBD70", Length = "0x29")]
	private void UpdateSkillsPage()
	{
	}

	[Token(Token = "0x600377B")]
	[Address(RVA = "0xACCFA0", Offset = "0xACBDA0", Length = "0x18D")]
	private void ReleaseTempResources_Skills()
	{
	}

	[Token(Token = "0x600377C")]
	[Address(RVA = "0xACD130", Offset = "0xACBF30", Length = "0x5A")]
	public void OnSkillsButton()
	{
	}

	[Token(Token = "0x600377D")]
	[Address(RVA = "0xACD190", Offset = "0xACBF90", Length = "0x34F")]
	public void DoControlsSkillsListStats()
	{
	}

	[Token(Token = "0x600377E")]
	[Address(RVA = "0xACD4E0", Offset = "0xACC2E0", Length = "0x208")]
	private void HandleSkillVerticalNavigation(float amount)
	{
	}

	[Token(Token = "0x600377F")]
	[Address(RVA = "0xACD6F0", Offset = "0xACC4F0", Length = "0x143")]
	private void HandleSkillScrollbar(float amount)
	{
	}

	[Token(Token = "0x6003780")]
	[Address(RVA = "0xACD840", Offset = "0xACC640", Length = "0x1A5")]
	public void OnScrollbarSkillsChange()
	{
	}

	[Token(Token = "0x6003781")]
	[Address(RVA = "0xACD9F0", Offset = "0xACC7F0", Length = "0xF8")]
	protected void OnSkillItemClicked(int index)
	{
	}

	[Token(Token = "0x6003782")]
	[Address(RVA = "0xACDAF0", Offset = "0xACC8F0", Length = "0x5C8")]
	private void RefreshSkillsList()
	{
	}

	[Token(Token = "0x6003783")]
	[Address(RVA = "0xACE0C0", Offset = "0xACCEC0", Length = "0x12AC")]
	private void RefreshSelectedSkillDescriptionView()
	{
	}

	[Token(Token = "0x6003784")]
	[Address(RVA = "0xACF370", Offset = "0xACE170", Length = "0x50E")]
	private void BuildSkillsList()
	{
	}

	[Token(Token = "0x6003785")]
	[Address(RVA = "0xACF880", Offset = "0xACE680", Length = "0xC0")]
	private void UpdateSkillListItemsColor()
	{
	}

	[Token(Token = "0x6003786")]
	[Address(RVA = "0xACF950", Offset = "0xACE750", Length = "0x1FA")]
	private void InitializeTrader()
	{
	}

	[Token(Token = "0x6003787")]
	[Address(RVA = "0xACFB50", Offset = "0xACE950", Length = "0x538")]
	private void BuildTrader()
	{
	}

	[Token(Token = "0x6003788")]
	[Address(RVA = "0xAD0090", Offset = "0xACEE90", Length = "0x15A")]
	public void OnTraderLogItemSelected(TraderLogItem traderLogItem)
	{
	}

	[Token(Token = "0x6003789")]
	[Address(RVA = "0xAD01F0", Offset = "0xACEFF0", Length = "0x787")]
	private void SetSelectedTraderLogItem(TraderLogItem traderLogItem)
	{
	}

	[Token(Token = "0x600378A")]
	[Address(RVA = "0xAD0980", Offset = "0xACF780", Length = "0x4D3")]
	public void DoControlsTrader()
	{
	}

	[Token(Token = "0x600378B")]
	[Address(RVA = "0xAD0E60", Offset = "0xACFC60", Length = "0x16D")]
	private void OnScrollBarChange()
	{
	}

	[Token(Token = "0x600378C")]
	[Address(RVA = "0xAD0FD0", Offset = "0xACFDD0", Length = "0x45")]
	private void OnScrollBarDragFinished()
	{
	}

	[Token(Token = "0x600378D")]
	[Address(RVA = "0xAD1020", Offset = "0xACFE20", Length = "0x42C")]
	private void UpdateWhatIKnowPage()
	{
	}

	[Token(Token = "0x600378E")]
	[Address(RVA = "0xAD1450", Offset = "0xAD0250", Length = "0x18D")]
	private void ReleaseTempResources_WhatIKnow()
	{
	}

	[Token(Token = "0x600378F")]
	[Address(RVA = "0xAD15E0", Offset = "0xAD03E0", Length = "0x5A")]
	public void OnWhatIKnowButton()
	{
	}

	[Token(Token = "0x6003790")]
	[Address(RVA = "0xAD1640", Offset = "0xAD0440", Length = "0x591")]
	public void DoControlsWhatIKnowList()
	{
	}

	[Token(Token = "0x6003791")]
	[Address(RVA = "0xAD1BE0", Offset = "0xAD09E0", Length = "0x124")]
	private void SetWhatIKnowListSelectedToEntry(string nameLocID)
	{
	}

	[Token(Token = "0x6003792")]
	[Address(RVA = "0xAD1D10", Offset = "0xAD0B10", Length = "0x193")]
	private void PointToWhatIKnowEntryOnQuickKeyActive(KnowledgeCateogry category, string nameLocID)
	{
	}

	[Token(Token = "0x6003793")]
	[Address(RVA = "0xAD1EB0", Offset = "0xAD0CB0", Length = "0xD0")]
	public void OnWhatIKnowSubScreen()
	{
	}

	[Token(Token = "0x6003794")]
	[Address(RVA = "0xAD1F90", Offset = "0xAD0D90", Length = "0x13D")]
	public void OnWhatIKnowScrollbarChange()
	{
	}

	[Token(Token = "0x6003795")]
	[Address(RVA = "0xAD20D0", Offset = "0xAD0ED0", Length = "0x19E")]
	public void OnScrollbarWhatIKnowDescUp()
	{
	}

	[Token(Token = "0x6003796")]
	[Address(RVA = "0xAD2270", Offset = "0xAD1070", Length = "0x19E")]
	public void OnScrollbarWhatIKnowDescDown()
	{
	}

	[Token(Token = "0x6003797")]
	[Address(RVA = "0xAD2410", Offset = "0xAD1210", Length = "0x55")]
	public void OnWhatIKnowDescScrollbarChange()
	{
	}

	[Token(Token = "0x6003798")]
	[Address(RVA = "0xAD2470", Offset = "0xAD1270", Length = "0xD5")]
	public void ShowPanelLogSubCategoryNotificationIcon(SubCategory subCategory, bool enable)
	{
	}

	[Token(Token = "0x6003799")]
	[Address(RVA = "0xAD2550", Offset = "0xAD1350", Length = "0x391")]
	private void UpdateWhatIKnowDescScrollbar()
	{
	}

	[Token(Token = "0x600379A")]
	[Address(RVA = "0xAD28F0", Offset = "0xAD16F0", Length = "0x44E")]
	private void BuildWhatIKnowList()
	{
	}

	[Token(Token = "0x600379B")]
	[Address(RVA = "0xAD2D40", Offset = "0xAD1B40", Length = "0x1AD")]
	private void AddWhatIKnowEntryToList(int scrollIndex, CollectionListItemInfo itemInfo)
	{
	}

	[Token(Token = "0x600379C")]
	[Address(RVA = "0xAD2EF0", Offset = "0xAD1CF0", Length = "0x224")]
	private void UpdateWhatIKnowListSelectionScroll(int moveVal, ref int index)
	{
	}

	[Token(Token = "0x600379D")]
	[Address(RVA = "0xAD3120", Offset = "0xAD1F20", Length = "0xC0")]
	private void UpdateWhatIKnowListItemsColor()
	{
	}

	[Token(Token = "0x600379E")]
	[Address(RVA = "0xAD31F0", Offset = "0xAD1FF0", Length = "0xD29")]
	private void GenerateSelectScreenData()
	{
	}

	[Token(Token = "0x600379F")]
	[Address(RVA = "0xAD3F20", Offset = "0xAD2D20", Length = "0x2A4")]
	private void GenerateSubscreenData(List<string> knowledgeList)
	{
	}

	[Token(Token = "0x60037A0")]
	[Address(RVA = "0xAD41D0", Offset = "0xAD2FD0", Length = "0x2C8")]
	private void RefreshCachedKnowledgeUnlocks()
	{
	}

	[Token(Token = "0x60037A1")]
	[Address(RVA = "0xAD44A0", Offset = "0xAD32A0", Length = "0xC8")]
	private void MaybeShowNotificationFlagForNewKnowledgeEntry()
	{
	}

	[Token(Token = "0x60037A2")]
	[Address(RVA = "0xAD4570", Offset = "0xAD3370", Length = "0xFB")]
	private void MaybeShowNotificationFlagForKnowledgeSubCategories()
	{
	}

	[Token(Token = "0x60037A3")]
	[Address(RVA = "0xAD4670", Offset = "0xAD3470", Length = "0xA8")]
	private void RemoveNewKnowledgeEntry(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x60037A4")]
	[Address(RVA = "0xAD4720", Offset = "0xAD3520", Length = "0xBB")]
	private void AddNotificationToKnowledgeSubCategory(string descId)
	{
	}

	[Token(Token = "0x60037A5")]
	[Address(RVA = "0xAD47E0", Offset = "0xAD35E0", Length = "0xBB")]
	private void RemoveNotificationFromKnowledgeSubCategory(string descId)
	{
	}

	[Token(Token = "0x60037A6")]
	[Address(RVA = "0xAD48A0", Offset = "0xAD36A0", Length = "0x10F6")]
	public Panel_Log()
	{
	}
}
