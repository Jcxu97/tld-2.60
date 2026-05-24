using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using TLD.Events;
using TLD.Gameplay;
using TLD.IntBackedUnit;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Timeline;

[Token(Token = "0x200060E")]
public class Panel_BodyHarvest : Panel_AutoReferenced, IAccelerateTimeProvider
{
	[Token(Token = "0x200060F")]
	private enum HarvestCarcass
	{
		[Token(Token = "0x40038E5")]
		Meat,
		[Token(Token = "0x40038E6")]
		Hide,
		[Token(Token = "0x40038E7")]
		Gut
	}

	[Token(Token = "0x2000610")]
	private enum HarvestAction
	{
		[Token(Token = "0x40038E9")]
		None,
		[Token(Token = "0x40038EA")]
		Harvesting,
		[Token(Token = "0x40038EB")]
		Quartering
	}

	[Token(Token = "0x2000611")]
	private enum HarvestTab
	{
		[Token(Token = "0x40038ED")]
		Harvest,
		[Token(Token = "0x40038EE")]
		Quarter
	}

	[SerializeField]
	[Token(Token = "0x4003884")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x4003885")]
	[FieldOffset(Offset = "0x38")]
	private BodyHarvestSettings m_Settings;

	[Token(Token = "0x4003886")]
	[FieldOffset(Offset = "0x40")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Titles")]
	[Token(Token = "0x4003887")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_Title;

	[Token(Token = "0x4003888")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_Title_Frozen;

	[Token(Token = "0x4003889")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_Label_Title_Frozen;

	[Token(Token = "0x400388A")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_Label_Title;

	[Token(Token = "0x400388B")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_Label_FrozenInfo;

	[Token(Token = "0x400388C")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_Label_AmountToHarvest;

	[Header("Quarter")]
	[Token(Token = "0x400388D")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_QuarterPanel;

	[Token(Token = "0x400388E")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_QuarterTabButtonLeft;

	[Token(Token = "0x400388F")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_QuarterTabButtonRight;

	[Header("Quarter Settings")]
	[Token(Token = "0x4003890")]
	[FieldOffset(Offset = "0x90")]
	public float m_PrefabSpawnHeightOffset;

	[Token(Token = "0x4003891")]
	[FieldOffset(Offset = "0x94")]
	public float m_PrefabSpawnRandomFudge;

	[Token(Token = "0x4003892")]
	[FieldOffset(Offset = "0x98")]
	public int m_QuarterSpawnRaycasts;

	[Token(Token = "0x4003893")]
	[FieldOffset(Offset = "0x9C")]
	public int m_GutsHideSpawnRaycasts;

	[Token(Token = "0x4003894")]
	[FieldOffset(Offset = "0xA0")]
	public float m_GutsHideRadiusModifier;

	[Header("Harvest")]
	[Token(Token = "0x4003895")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_HarvestPanel;

	[Token(Token = "0x4003896")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_HarvestTabButtonLeft;

	[Token(Token = "0x4003897")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_HarvestTabButtonRight;

	[Header("Gamepad Sprites")]
	[Token(Token = "0x4003898")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite m_GamepadTabLeft_Harvest;

	[Token(Token = "0x4003899")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite m_GamepadTabRight_Harvest;

	[Token(Token = "0x400389A")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite m_GamepadTabLeft_Quarter;

	[Token(Token = "0x400389B")]
	[FieldOffset(Offset = "0xD8")]
	public UISprite m_GamepadTabRight_Quarter;

	[Header("General")]
	[SerializeField]
	[Token(Token = "0x400389C")]
	[FieldOffset(Offset = "0xE0")]
	private UILabel m_Label_EstimatedTime;

	[SerializeField]
	[Token(Token = "0x400389D")]
	[FieldOffset(Offset = "0xE8")]
	private UILabel m_Label_EstimatedCalories;

	[Token(Token = "0x400389E")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel m_Label_CurrentCalories;

	[Token(Token = "0x400389F")]
	[FieldOffset(Offset = "0xF8")]
	public UILabel m_Label_CurrentCaloriesAmount;

	[Token(Token = "0x40038A0")]
	[FieldOffset(Offset = "0x100")]
	public GameObject m_HarvestAmount_Button_Increase;

	[Token(Token = "0x40038A1")]
	[FieldOffset(Offset = "0x108")]
	public GameObject m_HarvestAmount_Button_Decrease;

	[Token(Token = "0x40038A2")]
	[FieldOffset(Offset = "0x110")]
	public UITexture m_GearItemTexture;

	[Token(Token = "0x40038A3")]
	[FieldOffset(Offset = "0x118")]
	public Panel_BodyHarvest_MenuItem m_MenuItem_Meat;

	[Token(Token = "0x40038A4")]
	[FieldOffset(Offset = "0x120")]
	public Panel_BodyHarvest_MenuItem m_MenuItem_Hide;

	[Token(Token = "0x40038A5")]
	[FieldOffset(Offset = "0x128")]
	public Panel_BodyHarvest_MenuItem m_MenuItem_Gut;

	[Token(Token = "0x40038A6")]
	[FieldOffset(Offset = "0x130")]
	public GameObject m_Mouse_Button_Harvest;

	[Token(Token = "0x40038A7")]
	[FieldOffset(Offset = "0x138")]
	public GameObject m_Mouse_Button_Quarter;

	[Token(Token = "0x40038A8")]
	[FieldOffset(Offset = "0x140")]
	public UITexture m_ToolTexture;

	[Token(Token = "0x40038A9")]
	[FieldOffset(Offset = "0x148")]
	public UILabel m_Label_ToolName;

	[Token(Token = "0x40038AA")]
	[FieldOffset(Offset = "0x150")]
	public GameObject m_ChangeToolButtons;

	[Token(Token = "0x40038AB")]
	[FieldOffset(Offset = "0x158")]
	public UILabel m_ToolConditionLabel;

	[Token(Token = "0x40038AC")]
	[FieldOffset(Offset = "0x160")]
	public UISprite m_ToolConditionIcon;

	[Header("Intro Lerp")]
	[SerializeField]
	[Token(Token = "0x40038AD")]
	[FieldOffset(Offset = "0x168")]
	private float m_IntroLerpTime;

	[SerializeField]
	[Token(Token = "0x40038AE")]
	[FieldOffset(Offset = "0x170")]
	private AnimationCurve m_IntroLerpCurve;

	[Header("Time Bar")]
	[SerializeField]
	[Token(Token = "0x40038AF")]
	[FieldOffset(Offset = "0x178")]
	private UISprite m_TimeBar;

	[SerializeField]
	[Token(Token = "0x40038B0")]
	[FieldOffset(Offset = "0x180")]
	private float m_MaxTimeHours;

	[SerializeField]
	[Token(Token = "0x40038B1")]
	[FieldOffset(Offset = "0x184")]
	private float m_TimeBarOffset;

	[SerializeField]
	[Token(Token = "0x40038B2")]
	[FieldOffset(Offset = "0x188")]
	private Color m_TimeBarErrorColor;

	[Header("Game Event")]
	[SerializeField]
	[Token(Token = "0x40038B3")]
	[FieldOffset(Offset = "0x198")]
	private GameEvent m_BodyHarvestedEvent;

	[SerializeField]
	[Token(Token = "0x40038B4")]
	[FieldOffset(Offset = "0x1A0")]
	private GameEvent m_ResetBloodSplatterEvent;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40038B5")]
	[FieldOffset(Offset = "0x1A8")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40038B6")]
	[FieldOffset(Offset = "0x1B0")]
	private HarvestTab m_TabSelected;

	[Token(Token = "0x40038B7")]
	[FieldOffset(Offset = "0x1B4")]
	private HarvestTab m_TabRequested;

	[Token(Token = "0x40038B8")]
	[FieldOffset(Offset = "0x1B8")]
	private float m_HarvestTimeSeconds;

	[Token(Token = "0x40038B9")]
	[FieldOffset(Offset = "0x1BC")]
	private float m_TotalHarvestTimeSeconds;

	[Token(Token = "0x40038BA")]
	[FieldOffset(Offset = "0x1C0")]
	private float m_HarvestTimeMinutes;

	[Token(Token = "0x40038BB")]
	[FieldOffset(Offset = "0x1C4")]
	private float m_DayLengthScaleBeforeHarvest;

	[Token(Token = "0x40038BC")]
	[FieldOffset(Offset = "0x1C8")]
	private ItemWeight m_MeatHarvestAmountBefore;

	[Token(Token = "0x40038BD")]
	[FieldOffset(Offset = "0x1D0")]
	private int m_HideHarvestAmountBefore;

	[Token(Token = "0x40038BE")]
	[FieldOffset(Offset = "0x1D4")]
	private int m_GutHarvestAmountBefore;

	[Token(Token = "0x40038BF")]
	[FieldOffset(Offset = "0x1D8")]
	private uint m_ProgressBarAudio;

	[Token(Token = "0x40038C0")]
	[FieldOffset(Offset = "0x1DC")]
	private bool m_TimeAccelerated;

	[Token(Token = "0x40038C1")]
	[FieldOffset(Offset = "0x1E0")]
	private ComingFromScreenCategory m_ComingFromScreenCategory;

	[Token(Token = "0x40038C2")]
	[FieldOffset(Offset = "0x1E4")]
	private HarvestAction m_CurrentHarvestAction;

	[Token(Token = "0x40038C3")]
	[FieldOffset(Offset = "0x1E8")]
	private float m_MinutesSpentOnMostRecentHarvest;

	[Token(Token = "0x40038C4")]
	[FieldOffset(Offset = "0x1EC")]
	private float m_TimeForToolToBreak;

	[Token(Token = "0x40038C5")]
	[FieldOffset(Offset = "0x1F0")]
	private int m_SelectedToolItemIndex;

	[Token(Token = "0x40038C6")]
	[FieldOffset(Offset = "0x1F8")]
	private BodyHarvest m_BodyHarvest;

	[Token(Token = "0x40038C7")]
	[FieldOffset(Offset = "0x200")]
	private int m_SelectedButtonIndex;

	[Token(Token = "0x40038C8")]
	[FieldOffset(Offset = "0x208")]
	private List<Panel_BodyHarvest_MenuItem> m_MenuItems;

	[Token(Token = "0x40038C9")]
	[FieldOffset(Offset = "0x210")]
	private List<GearItem> m_Tools;

	[Token(Token = "0x40038CA")]
	[FieldOffset(Offset = "0x218")]
	private bool m_PlayBookEndAnimation;

	[Token(Token = "0x40038CB")]
	[FieldOffset(Offset = "0x220")]
	private BodyHarvest.BodyHarvestTimelineData m_BodyHarvestTimelineData;

	[Token(Token = "0x40038CC")]
	[FieldOffset(Offset = "0x228")]
	private AsyncOperationHandle<TimelineAsset> m_TimelineHandle;

	[Token(Token = "0x40038CD")]
	[FieldOffset(Offset = "0x240")]
	private List<TLD_TimelineDirector.BindingInfo> m_TimelineBindings;

	[Token(Token = "0x40038CE")]
	[FieldOffset(Offset = "0x248")]
	private GameObject m_CreatedFPAnchor;

	[Token(Token = "0x40038CF")]
	[FieldOffset(Offset = "0x250")]
	private Action m_OnTimelineDonePlaying;

	[Token(Token = "0x40038D0")]
	[FieldOffset(Offset = "0x258")]
	private AsyncOperationHandle<TimelineAsset> m_LoopTimelineHandle;

	[Token(Token = "0x40038D1")]
	[FieldOffset(Offset = "0x270")]
	private TimelineAsset m_LoopTimeline;

	[Token(Token = "0x40038D2")]
	[FieldOffset(Offset = "0x278")]
	private PlayerAnimation.CameraLayer m_CameraLayer;

	[Token(Token = "0x40038D3")]
	[FieldOffset(Offset = "0x27C")]
	private float m_CameraStartFOV;

	[Token(Token = "0x40038D4")]
	[FieldOffset(Offset = "0x280")]
	private Vector3 m_CameraStartPosition;

	[Token(Token = "0x40038D5")]
	[FieldOffset(Offset = "0x28C")]
	private Quaternion m_CameraStartRotation;

	[Token(Token = "0x40038D6")]
	[FieldOffset(Offset = "0x29C")]
	private bool m_WasCrouched;

	[Token(Token = "0x40038D7")]
	[FieldOffset(Offset = "0x29D")]
	private bool m_DoingIntroLerp;

	[Token(Token = "0x40038D8")]
	[FieldOffset(Offset = "0x2A0")]
	private float m_IntroTimer;

	[Token(Token = "0x40038D9")]
	private static readonly Collider[] s_PossibleColliders;

	[Header("Error Messages")]
	[Token(Token = "0x40038DA")]
	[FieldOffset(Offset = "0x2A8")]
	public UILabel m_Label_Error;

	[Token(Token = "0x40038DB")]
	[FieldOffset(Offset = "0x2B0")]
	public float m_ErrorDisplayDuration;

	[Token(Token = "0x40038DC")]
	[FieldOffset(Offset = "0x2B4")]
	private float m_DisplayErrorTimer;

	[Token(Token = "0x40038DD")]
	[FieldOffset(Offset = "0x2B8")]
	private float m_ErrorDisplayFadingDuration;

	[Token(Token = "0x40038DE")]
	[FieldOffset(Offset = "0x2BC")]
	private float m_FadeInStartAlpha;

	[Token(Token = "0x40038DF")]
	[FieldOffset(Offset = "0x2C0")]
	private float m_ErrorDisplayFadeOutTimer;

	[Token(Token = "0x40038E0")]
	[FieldOffset(Offset = "0x2C4")]
	private float m_ErrorDisplayFadeInTimer;

	[Token(Token = "0x40038E1")]
	[FieldOffset(Offset = "0x2C8")]
	private bool m_FadeOutErrorRequested;

	[Token(Token = "0x40038E2")]
	[FieldOffset(Offset = "0x2C9")]
	private bool m_FadeInErrorRequested;

	[Token(Token = "0x40038E3")]
	[FieldOffset(Offset = "0x2CA")]
	private bool m_DisplayErrorRequested;

	[Token(Token = "0x170002DC")]
	private bool HarvestTimeUnderLimit
	{
		[Token(Token = "0x6002F69")]
		[Address(RVA = "0x98A100", Offset = "0x988F00", Length = "0x1B")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002DD")]
	private bool IsUsingTimelines
	{
		[Token(Token = "0x6002F6A")]
		[Address(RVA = "0x98A120", Offset = "0x988F20", Length = "0xC")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6002F6B")]
	[Address(RVA = "0x98A130", Offset = "0x988F30", Length = "0x225")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002F6C")]
	[Address(RVA = "0x98A360", Offset = "0x989160", Length = "0xCB")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002F6D")]
	[Address(RVA = "0x98A430", Offset = "0x989230", Length = "0x572")]
	private void Update()
	{
	}

	[Token(Token = "0x6002F6E")]
	[Address(RVA = "0x98A9B0", Offset = "0x9897B0", Length = "0x55")]
	public void OnBack()
	{
	}

	[Token(Token = "0x6002F6F")]
	[Address(RVA = "0x98AA10", Offset = "0x989810", Length = "0xC6")]
	public void InterruptIfActive()
	{
	}

	[Token(Token = "0x6002F70")]
	[Address(RVA = "0x98AAE0", Offset = "0x9898E0", Length = "0x176")]
	private void SelectMenuItem(int index)
	{
	}

	[Token(Token = "0x6002F71")]
	[Address(RVA = "0x98AC60", Offset = "0x989A60", Length = "0x1C2")]
	private void UpdateHarvestMenuNavigation()
	{
	}

	[Token(Token = "0x6002F72")]
	[Address(RVA = "0x98AE30", Offset = "0x989C30", Length = "0x3C8")]
	private void UpdateMenuNavigation()
	{
	}

	[Token(Token = "0x6002F73")]
	[Address(RVA = "0x98B200", Offset = "0x98A000", Length = "0xA66")]
	public bool CanEnable(BodyHarvest bodyHarvest)
	{
		return false;
	}

	[Token(Token = "0x6002F74")]
	[Address(RVA = "0x98BC70", Offset = "0x98AA70", Length = "0x136")]
	public bool IsCurrent(BodyHarvest bodyHarvest)
	{
		return false;
	}

	[Token(Token = "0x6002F75")]
	[Address(RVA = "0x98BDB0", Offset = "0x98ABB0", Length = "0x10")]
	private void EnableTabs()
	{
	}

	[Token(Token = "0x6002F76")]
	[Address(RVA = "0x98BDC0", Offset = "0x98ABC0", Length = "0x19F")]
	private void MaybeDestroyDepletedGearItem()
	{
	}

	[Token(Token = "0x6002F77")]
	[Address(RVA = "0x98BF60", Offset = "0x98AD60", Length = "0x1F")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002F78")]
	[Address(RVA = "0x98BF80", Offset = "0x98AD80", Length = "0xE16")]
	public void Enable(bool enable, BodyHarvest bh, bool playBookEndAnim, ComingFromScreenCategory comingFrom)
	{
	}

	[Token(Token = "0x6002F79")]
	[Address(RVA = "0x98CDA0", Offset = "0x98BBA0", Length = "0x16F")]
	private void ExitBodyHarvestPanel()
	{
	}

	[Token(Token = "0x6002F7A")]
	[Address(RVA = "0x98CF10", Offset = "0x98BD10", Length = "0x19F")]
	private void MaybeHandleItemInHands()
	{
	}

	[Token(Token = "0x6002F7B")]
	[Address(RVA = "0x98D0B0", Offset = "0x98BEB0", Length = "0x70")]
	private void MaybeRestoreItemInHands()
	{
	}

	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0x98D130", Offset = "0x98BF30", Length = "0x9DC")]
	private void MaybeHandleGearItemPlacement(bool setEnabled)
	{
	}

	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0x98DB10", Offset = "0x98C910", Length = "0x54B")]
	private void CleanupTimelinePlaying()
	{
	}

	[Token(Token = "0x6002F7E")]
	[Address(RVA = "0x98E060", Offset = "0x98CE60", Length = "0xB")]
	public bool IsHarvesting()
	{
		return false;
	}

	[Token(Token = "0x6002F7F")]
	[Address(RVA = "0x98E070", Offset = "0x98CE70", Length = "0xB")]
	public bool IsQuartering()
	{
		return false;
	}

	[Token(Token = "0x6002F80")]
	[Address(RVA = "0x98E080", Offset = "0x98CE80", Length = "0xB")]
	public bool IsHarvestingOrQuartering()
	{
		return false;
	}

	[Token(Token = "0x6002F81")]
	[Address(RVA = "0x98E090", Offset = "0x98CE90", Length = "0x45")]
	public void OnPopupClicked()
	{
	}

	[Token(Token = "0x6002F82")]
	[Address(RVA = "0x98E0E0", Offset = "0x98CEE0", Length = "0x3DD")]
	public void OnHarvest()
	{
	}

	[Token(Token = "0x6002F83")]
	[Address(RVA = "0x98E4C0", Offset = "0x98D2C0", Length = "0x24")]
	public bool CanQuarter()
	{
		return false;
	}

	[Token(Token = "0x6002F84")]
	[Address(RVA = "0x98E4F0", Offset = "0x98D2F0", Length = "0x56")]
	public void OnTabQuarterSelected()
	{
	}

	[Token(Token = "0x6002F85")]
	[Address(RVA = "0x98E550", Offset = "0x98D350", Length = "0x56")]
	public void OnTabHarvestSelected()
	{
	}

	[Token(Token = "0x6002F86")]
	[Address(RVA = "0x98E5B0", Offset = "0x98D3B0", Length = "0x526")]
	public void OnQuarter()
	{
	}

	[Token(Token = "0x6002F87")]
	[Address(RVA = "0x98EAE0", Offset = "0x98D8E0", Length = "0x71")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6002F88")]
	[Address(RVA = "0x98EB60", Offset = "0x98D960", Length = "0x242")]
	public bool HasNoHarvestingTool()
	{
		return false;
	}

	[Token(Token = "0x6002F89")]
	[Address(RVA = "0x98EDB0", Offset = "0x98DBB0", Length = "0x1A1")]
	public void DisplayCarcassTooFrozenMessage()
	{
	}

	[Token(Token = "0x6002F8A")]
	[Address(RVA = "0x98EF60", Offset = "0x98DD60", Length = "0x71")]
	public void DisplayCarcassFreshBodyMessage()
	{
	}

	[Token(Token = "0x6002F8B")]
	[Address(RVA = "0x98EFE0", Offset = "0x98DDE0", Length = "0x71")]
	public void DisplayOnThinIceMessage()
	{
	}

	[Token(Token = "0x6002F8C")]
	[Address(RVA = "0x98F060", Offset = "0x98DE60", Length = "0x1C6")]
	public static bool CheckIfResourcesLeft(BodyHarvest bodyHarvest)
	{
		return false;
	}

	[Token(Token = "0x6002F8D")]
	[Address(RVA = "0x98F230", Offset = "0x98E030", Length = "0x30")]
	public void OnIncreaseMeatHarvest()
	{
	}

	[Token(Token = "0x6002F8E")]
	[Address(RVA = "0x98F270", Offset = "0x98E070", Length = "0x30")]
	public void OnDecreaseMeatHarvest()
	{
	}

	[Token(Token = "0x6002F8F")]
	[Address(RVA = "0x98F2B0", Offset = "0x98E0B0", Length = "0x32")]
	public void OnIncreaseHideHarvest()
	{
	}

	[Token(Token = "0x6002F90")]
	[Address(RVA = "0x98F2F0", Offset = "0x98E0F0", Length = "0x32")]
	public void OnDecreaseHideHarvest()
	{
	}

	[Token(Token = "0x6002F91")]
	[Address(RVA = "0x98F330", Offset = "0x98E130", Length = "0x32")]
	public void OnIncreaseGutHarvest()
	{
	}

	[Token(Token = "0x6002F92")]
	[Address(RVA = "0x98F370", Offset = "0x98E170", Length = "0x32")]
	public void OnDecreaseGutHarvest()
	{
	}

	[Token(Token = "0x6002F93")]
	[Address(RVA = "0x98F3B0", Offset = "0x98E1B0", Length = "0x30E")]
	private void StartHarvest(int durationMinutes, string harvestAudio)
	{
	}

	[Token(Token = "0x6002F94")]
	[Address(RVA = "0x98F6C0", Offset = "0x98E4C0", Length = "0x278")]
	private void StartQuarter(int durationMinutes, string quarterAudio)
	{
	}

	[Token(Token = "0x6002F95")]
	[Address(RVA = "0x98F940", Offset = "0x98E740", Length = "0x246")]
	private void DetermineTimeForToolBreak(int duration)
	{
	}

	[Token(Token = "0x6002F96")]
	[Address(RVA = "0x98FB90", Offset = "0x98E990", Length = "0x22")]
	private float GetQuarterDurationMinutes()
	{
		return 0f;
	}

	[Token(Token = "0x6002F97")]
	[Address(RVA = "0x98FBC0", Offset = "0x98E9C0", Length = "0x2FE")]
	private float GetHarvestDurationMinutes()
	{
		return 0f;
	}

	[Token(Token = "0x6002F98")]
	[Address(RVA = "0x98FEC0", Offset = "0x98ECC0", Length = "0x1E")]
	private string GetHarvestAudio()
	{
		return null;
	}

	[Token(Token = "0x6002F99")]
	[Address(RVA = "0x98FEE0", Offset = "0x98ECE0", Length = "0x21")]
	private string GetQuarterAudio()
	{
		return null;
	}

	[Token(Token = "0x6002F9A")]
	[Address(RVA = "0x98FF10", Offset = "0x98ED10", Length = "0x21")]
	private GameObject GetQuarterObjectPrefab()
	{
		return null;
	}

	[Token(Token = "0x6002F9B")]
	[Address(RVA = "0x98FF40", Offset = "0x98ED40", Length = "0x43")]
	private void SpawnOrRefreshCarcassSite()
	{
	}

	[Token(Token = "0x6002F9C")]
	[Address(RVA = "0x98FF90", Offset = "0x98ED90", Length = "0x1231")]
	private void SpawnQuarters()
	{
	}

	[Token(Token = "0x6002F9D")]
	[Address(RVA = "0x9911D0", Offset = "0x98FFD0", Length = "0xCD5")]
	private void SpawnHideAndGutsAfterQuarter()
	{
	}

	[Token(Token = "0x6002F9E")]
	[Address(RVA = "0x991EB0", Offset = "0x990CB0", Length = "0x28D")]
	private void MaybeGiveBonusItemsOnHarvest()
	{
	}

	[Token(Token = "0x6002F9F")]
	[Address(RVA = "0x992140", Offset = "0x990F40", Length = "0x38A")]
	private void MaybeCollectSpentArrows()
	{
	}

	[Token(Token = "0x6002FA0")]
	[Address(RVA = "0x9924D0", Offset = "0x9912D0", Length = "0x2C4")]
	private bool TryFindPositionOnSlope(Vector3 desiredPosition, float heightOffset, out Vector3 actualPosition, out Vector3 slopeNormal)
	{
		actualPosition = default(Vector3);
		slopeNormal = default(Vector3);
		return false;
	}

	[Token(Token = "0x6002FA1")]
	[Address(RVA = "0x9927A0", Offset = "0x9915A0", Length = "0x24A")]
	private void RandomRotateQuarter(Transform transform)
	{
	}

	[Token(Token = "0x6002FA2")]
	[Address(RVA = "0x9929F0", Offset = "0x9917F0", Length = "0x126")]
	private void RandomRotateGutsOrHide(Transform transform)
	{
	}

	[Token(Token = "0x6002FA3")]
	[Address(RVA = "0x992B20", Offset = "0x991920", Length = "0x167")]
	private void TransferMeatFromCarcassToInventory()
	{
	}

	[Token(Token = "0x6002FA4")]
	[Address(RVA = "0x992C90", Offset = "0x991A90", Length = "0x5C1")]
	private void TransferGearFromCarcassToInventoryByWeight(GameObject prefab, ItemWeight weightToAdd)
	{
	}

	[Token(Token = "0x6002FA5")]
	[Address(RVA = "0x993260", Offset = "0x992060", Length = "0x56A")]
	private void TransferHideFromCarcassToInventory()
	{
	}

	[Token(Token = "0x6002FA6")]
	[Address(RVA = "0x9937D0", Offset = "0x9925D0", Length = "0x4C0")]
	private void TransferGutFromCarcassToInventory()
	{
	}

	[Token(Token = "0x6002FA7")]
	[Address(RVA = "0x993CA0", Offset = "0x992AA0", Length = "0x119")]
	private void ApplyWearToTool()
	{
	}

	[Token(Token = "0x6002FA8")]
	[Address(RVA = "0x993DC0", Offset = "0x992BC0", Length = "0x27D")]
	private void QuarterSuccessful()
	{
	}

	[Token(Token = "0x6002FA9")]
	[Address(RVA = "0x994040", Offset = "0x992E40", Length = "0x787")]
	private void HarvestSuccessful()
	{
	}

	[Token(Token = "0x6002FAA")]
	[Address(RVA = "0x9947D0", Offset = "0x9935D0", Length = "0x1A9")]
	private bool ShouldApplyInitialBarehandedHarvestLoss()
	{
		return false;
	}

	[Token(Token = "0x6002FAB")]
	[Address(RVA = "0x994980", Offset = "0x993780", Length = "0xE8")]
	private void OnBodyHarvested()
	{
	}

	[Token(Token = "0x6002FAC")]
	[Address(RVA = "0x994A70", Offset = "0x993870", Length = "0x75")]
	private void CleanUpOnExit()
	{
	}

	[Token(Token = "0x6002FAD")]
	[Address(RVA = "0x994AF0", Offset = "0x9938F0", Length = "0x314")]
	private void RefreshTitle()
	{
	}

	[Token(Token = "0x6002FAE")]
	[Address(RVA = "0x994E10", Offset = "0x993C10", Length = "0xD1")]
	private void RefreshLabels()
	{
	}

	[Token(Token = "0x6002FAF")]
	[Address(RVA = "0x994EF0", Offset = "0x993CF0", Length = "0x1CB")]
	private void RefreshTimeBar()
	{
	}

	[Token(Token = "0x6002FB0")]
	[Address(RVA = "0x9950C0", Offset = "0x993EC0", Length = "0xDF")]
	private void RefreshTextures()
	{
	}

	[Token(Token = "0x6002FB1")]
	[Address(RVA = "0x9951A0", Offset = "0x993FA0", Length = "0x125")]
	private static void UpdateMenuItemTexture(Panel_BodyHarvest_MenuItem menuItem, GameObject harvestPrefab, float condition)
	{
	}

	[Token(Token = "0x6002FB2")]
	[Address(RVA = "0x9952D0", Offset = "0x9940D0", Length = "0x243")]
	private void RefreshEstimatedTimeLabel()
	{
	}

	[Token(Token = "0x6002FB3")]
	[Address(RVA = "0x995520", Offset = "0x994320", Length = "0xB")]
	private bool IsTabHarvestSelected()
	{
		return false;
	}

	[Token(Token = "0x6002FB4")]
	[Address(RVA = "0x995530", Offset = "0x994330", Length = "0xB")]
	private bool IsTabQuarterSelected()
	{
		return false;
	}

	[Token(Token = "0x6002FB5")]
	[Address(RVA = "0x995540", Offset = "0x994340", Length = "0x3D8")]
	private void RefreshCalorieLabels()
	{
	}

	[Token(Token = "0x6002FB6")]
	[Address(RVA = "0x995920", Offset = "0x994720", Length = "0x4D2")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6002FB7")]
	[Address(RVA = "0x995E00", Offset = "0x994C00", Length = "0xF8")]
	private void UpdateTabs()
	{
	}

	[Token(Token = "0x6002FB8")]
	[Address(RVA = "0x995F00", Offset = "0x994D00", Length = "0x57")]
	private void StopProgressBarAudio()
	{
	}

	[Token(Token = "0x6002FB9")]
	[Address(RVA = "0x995F60", Offset = "0x994D60", Length = "0x1CD")]
	private void UpdateHarvest()
	{
	}

	[Token(Token = "0x6002FBA")]
	[Address(RVA = "0x996130", Offset = "0x994F30", Length = "0x125")]
	private void UpdateQuarter()
	{
	}

	[Token(Token = "0x6002FBB")]
	[Address(RVA = "0x996260", Offset = "0x995060", Length = "0xAF")]
	private void AccelerateTimeOfDay(int minutes)
	{
	}

	[Token(Token = "0x6002FBC")]
	[Address(RVA = "0x996310", Offset = "0x995110", Length = "0x8A")]
	private void RestoreTimeOfDay()
	{
	}

	[Token(Token = "0x6002FBD")]
	[Address(RVA = "0x9963A0", Offset = "0x9951A0", Length = "0xA4")]
	private void MakeDefaultSelections()
	{
	}

	[Token(Token = "0x6002FBE")]
	[Address(RVA = "0x996450", Offset = "0x995250", Length = "0x14E")]
	private bool IsCarcassTooFrozenToQuarter()
	{
		return false;
	}

	[Token(Token = "0x6002FBF")]
	[Address(RVA = "0x9965A0", Offset = "0x9953A0", Length = "0xE7")]
	private void InterruptQuarter()
	{
	}

	[Token(Token = "0x6002FC0")]
	[Address(RVA = "0x996690", Offset = "0x995490", Length = "0x21B")]
	private void InterruptHarvest()
	{
	}

	[Token(Token = "0x6002FC1")]
	[Address(RVA = "0x9968B0", Offset = "0x9956B0", Length = "0xAE")]
	public void OnToolPrev()
	{
	}

	[Token(Token = "0x6002FC2")]
	[Address(RVA = "0x996960", Offset = "0x995760", Length = "0xB5")]
	public void OnToolNext()
	{
	}

	[Token(Token = "0x6002FC3")]
	[Address(RVA = "0x996A20", Offset = "0x995820", Length = "0x9B")]
	private GearItem GetSelectedTool()
	{
		return null;
	}

	[Token(Token = "0x6002FC4")]
	[Address(RVA = "0x996AC0", Offset = "0x9958C0", Length = "0x4B6")]
	private void RefreshTools(BodyHarvest bodyHarvest)
	{
	}

	[Token(Token = "0x6002FC5")]
	[Address(RVA = "0x996F80", Offset = "0x995D80", Length = "0x721")]
	private void RefreshToolSelection()
	{
	}

	[Token(Token = "0x6002FC6")]
	[Address(RVA = "0x9976B0", Offset = "0x9964B0", Length = "0x884")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6002FC7")]
	[Address(RVA = "0x997F40", Offset = "0x996D40", Length = "0x1A1")]
	private void DisplayCarcassTooFrozenToQuarterMessage()
	{
	}

	[Token(Token = "0x6002FC8")]
	[Address(RVA = "0x9980F0", Offset = "0x996EF0", Length = "0x3F7")]
	private void UpdateControllerInputForTabs()
	{
	}

	[Token(Token = "0x6002FC9")]
	[Address(RVA = "0x9984F0", Offset = "0x9972F0", Length = "0x387")]
	private static void ComputeBoundsFromColliders(Transform t, ref Bounds b)
	{
	}

	[Token(Token = "0x6002FCA")]
	[Address(RVA = "0x998880", Offset = "0x997680", Length = "0x7FC")]
	private static void CollectArrows(BodyHarvest bh)
	{
	}

	[Token(Token = "0x6002FCB")]
	[Address(RVA = "0x999080", Offset = "0x997E80", Length = "0x20")]
	private void ResetBloodSplatter()
	{
	}

	[Token(Token = "0x6002FCC")]
	[Address(RVA = "0x9990B0", Offset = "0x997EB0", Length = "0x27F")]
	private void InitializeTimelineData()
	{
	}

	[Token(Token = "0x6002FCD")]
	[Address(RVA = "0x999330", Offset = "0x998130", Length = "0xB4")]
	private void PlayIntroTimeline()
	{
	}

	[Token(Token = "0x6002FCE")]
	[Address(RVA = "0x9993F0", Offset = "0x9981F0", Length = "0x245")]
	private void PlayLoopTimeline()
	{
	}

	[Token(Token = "0x6002FCF")]
	[Address(RVA = "0x999640", Offset = "0x998440", Length = "0x24E")]
	private void LoadAndPlayTimeline(AssetReferenceTimeline timelineAssetReference, Action onDonePlaying, DirectorWrapMode wrapMode = DirectorWrapMode.None)
	{
	}

	[Token(Token = "0x6002FD0")]
	[Address(RVA = "0x999890", Offset = "0x998690", Length = "0x8E5")]
	private void PlayTimeline(TimelineAsset timelineAsset, Action onDonePlaying, DirectorWrapMode wrapMode = DirectorWrapMode.None)
	{
	}

	[Token(Token = "0x6002FD1")]
	[Address(RVA = "0x99A180", Offset = "0x998F80", Length = "0x68")]
	private void HandleOnTimelineDonePlaying()
	{
	}

	[Token(Token = "0x6002FD2")]
	[Address(RVA = "0x99A1F0", Offset = "0x998FF0", Length = "0xB1")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x6002FD3")]
	[Address(RVA = "0x99A2B0", Offset = "0x9990B0", Length = "0xCD")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x6002FD4")]
	[Address(RVA = "0x99A380", Offset = "0x999180", Length = "0x3B")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6002FD5")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x6002FD6")]
	[Address(RVA = "0x99A3C0", Offset = "0x9991C0", Length = "0x71")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x6002FD7")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x6002FD8")]
	[Address(RVA = "0x99A440", Offset = "0x999240", Length = "0xC")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x6002FD9")]
	[Address(RVA = "0x99A450", Offset = "0x999250", Length = "0x113")]
	private void RequestFadeInErrorMessage()
	{
	}

	[Token(Token = "0x6002FDA")]
	[Address(RVA = "0x99A570", Offset = "0x999370", Length = "0x14")]
	private void RequestFadeoutError()
	{
	}

	[Token(Token = "0x6002FDB")]
	[Address(RVA = "0x99A590", Offset = "0x999390", Length = "0x193")]
	private void DisplayErrorMessage(string text)
	{
	}

	[Token(Token = "0x6002FDC")]
	[Address(RVA = "0x99A730", Offset = "0x999530", Length = "0x161")]
	private void HandleMessageErrorFadeout()
	{
	}

	[Token(Token = "0x6002FDD")]
	[Address(RVA = "0x99A8A0", Offset = "0x9996A0", Length = "0x158")]
	private void HandleMessageErrorFadein()
	{
	}

	[Token(Token = "0x6002FDE")]
	[Address(RVA = "0x99AA00", Offset = "0x999800", Length = "0x30A")]
	private void UpdateErrorMessage()
	{
	}

	[Token(Token = "0x6002FDF")]
	[Address(RVA = "0x99AD10", Offset = "0x999B10", Length = "0x51")]
	private void ResetErrorMessage()
	{
	}

	[Token(Token = "0x6002FE0")]
	[Address(RVA = "0x99AD70", Offset = "0x999B70", Length = "0x24B")]
	public Panel_BodyHarvest()
	{
	}
}
