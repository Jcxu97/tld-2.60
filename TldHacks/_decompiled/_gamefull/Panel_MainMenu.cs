using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.GameplayTags;
using TLD.IO;
using TLD.News;
using TLD.OptionalContent;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200068B")]
public class Panel_MainMenu : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x200068C")]
	public class MainMenuItem
	{
		[Token(Token = "0x200068D")]
		public enum MainMenuItemType
		{
			[Token(Token = "0x400447D")]
			Sandbox,
			[Token(Token = "0x400447E")]
			Story,
			[Token(Token = "0x400447F")]
			TFTFTUpsell,
			[Token(Token = "0x4004480")]
			Quit,
			[Token(Token = "0x4004481")]
			Debug
		}

		[Token(Token = "0x4004477")]
		[FieldOffset(Offset = "0x10")]
		public MainMenuItemType m_Type;

		[Token(Token = "0x4004478")]
		[FieldOffset(Offset = "0x18")]
		public string m_LabelLocalizationId;

		[Header("Override Tint")]
		[Token(Token = "0x4004479")]
		[FieldOffset(Offset = "0x20")]
		public bool m_UseOverrideTint;

		[Token(Token = "0x400447A")]
		[FieldOffset(Offset = "0x24")]
		public Color m_OverrideTintNormal;

		[Token(Token = "0x400447B")]
		[FieldOffset(Offset = "0x34")]
		public Color m_OverrideTintHighlight;

		[Token(Token = "0x6003816")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public MainMenuItem()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200068E")]
	private class CommunicationButton
	{
		[Token(Token = "0x4004482")]
		[FieldOffset(Offset = "0x10")]
		public UIButton m_Button;

		[Token(Token = "0x4004483")]
		[FieldOffset(Offset = "0x18")]
		public string m_URL;

		[Token(Token = "0x6003817")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public CommunicationButton()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200068F")]
	private class GameEditionArt
	{
		[Token(Token = "0x4004484")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_Title;

		[Token(Token = "0x4004485")]
		[FieldOffset(Offset = "0x18")]
		public GameObject m_Background;

		[Token(Token = "0x4004486")]
		[FieldOffset(Offset = "0x20")]
		public StartSettings m_TimeAndWeatherSettings;

		[Token(Token = "0x6003818")]
		[Address(RVA = "0xAEB860", Offset = "0xAEA660", Length = "0x44")]
		public void SetActive(bool value)
		{
		}

		[Token(Token = "0x6003819")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public GameEditionArt()
		{
		}
	}

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004404")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Badges> m_Badges;

	[SerializeField]
	[Token(Token = "0x4004405")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_Challenges> m_Challenges;

	[SerializeField]
	[Token(Token = "0x4004406")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_ChooseChallenge> m_ChooseChallenge;

	[SerializeField]
	[Token(Token = "0x4004407")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_ChooseSandbox> m_ChooseSandbox;

	[SerializeField]
	[Token(Token = "0x4004408")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x4004409")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Credits> m_Credits;

	[SerializeField]
	[Token(Token = "0x400440A")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_CustomXPSetup> m_CustomXPSetup;

	[SerializeField]
	[Token(Token = "0x400440B")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_Debug> m_Debug;

	[SerializeField]
	[Token(Token = "0x400440C")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_Extras> m_Extras;

	[SerializeField]
	[Token(Token = "0x400440D")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x400440E")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x400440F")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	[SerializeField]
	[Token(Token = "0x4004410")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_Sandbox> m_Sandbox;

	[SerializeField]
	[Token(Token = "0x4004411")]
	[FieldOffset(Offset = "0x98")]
	private PanelReference<Panel_SelectChallengeType> m_SelectChallengeType;

	[SerializeField]
	[Token(Token = "0x4004412")]
	[FieldOffset(Offset = "0xA0")]
	private PanelReference<Panel_SelectExperience> m_SelectExperience;

	[SerializeField]
	[Token(Token = "0x4004413")]
	[FieldOffset(Offset = "0xA8")]
	private PanelReference<Panel_SelectRegion_Map> m_SelectRegion_Map;

	[SerializeField]
	[Token(Token = "0x4004414")]
	[FieldOffset(Offset = "0xB0")]
	private PanelReference<Panel_SelectSurvivor> m_SelectSurvivor;

	[SerializeField]
	[Token(Token = "0x4004415")]
	[FieldOffset(Offset = "0xB8")]
	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	[SerializeField]
	[Token(Token = "0x4004416")]
	[FieldOffset(Offset = "0xC0")]
	private PanelReference<Panel_SelectWorldMap> m_SelectWorld;

	[SerializeField]
	[Token(Token = "0x4004417")]
	[FieldOffset(Offset = "0xC8")]
	private PanelReference<Panel_SurvivalSettings> m_SurvivalSettings;

	[SerializeField]
	[Token(Token = "0x4004418")]
	[FieldOffset(Offset = "0xD0")]
	private PanelReference<Panel_SaveMigration> m_SaveMigration;

	[Space]
	[Token(Token = "0x4004419")]
	[FieldOffset(Offset = "0xD8")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400441A")]
	[FieldOffset(Offset = "0xE0")]
	public UIPanel m_MainPanel;

	[Token(Token = "0x400441B")]
	[FieldOffset(Offset = "0xE8")]
	public AK.Wwise.Event m_StartMusic;

	[Token(Token = "0x400441C")]
	[FieldOffset(Offset = "0xF0")]
	public AK.Wwise.Event m_StopMusic;

	[Token(Token = "0x400441D")]
	[FieldOffset(Offset = "0xF8")]
	public UILabel m_VersionLabel;

	[Token(Token = "0x400441E")]
	[FieldOffset(Offset = "0x100")]
	public GameObject m_AllObjects;

	[Token(Token = "0x400441F")]
	[FieldOffset(Offset = "0x108")]
	public bool m_StartFadedOut;

	[Token(Token = "0x4004420")]
	[FieldOffset(Offset = "0x10C")]
	public float m_FadeOutTimeSeconds;

	[Token(Token = "0x4004421")]
	[FieldOffset(Offset = "0x110")]
	public float m_FadeInTimeSeconds;

	[Token(Token = "0x4004422")]
	[FieldOffset(Offset = "0x114")]
	public float m_MinDOFFocalLength;

	[Token(Token = "0x4004423")]
	[FieldOffset(Offset = "0x118")]
	public float m_MaxDOFFocalLength;

	[Token(Token = "0x4004424")]
	[FieldOffset(Offset = "0x11C")]
	public float m_NoInputTimeBeforeFading;

	[Token(Token = "0x4004425")]
	[FieldOffset(Offset = "0x120")]
	public WeatherStage m_DefaultWeather;

	[Token(Token = "0x4004426")]
	[FieldOffset(Offset = "0x124")]
	public int m_DefaultTODStartHour;

	[Token(Token = "0x4004427")]
	[FieldOffset(Offset = "0x128")]
	public int m_DefaultTODStartMinutes;

	[Token(Token = "0x4004428")]
	[FieldOffset(Offset = "0x12C")]
	public WindDirection m_DefaultWindDirection;

	[Token(Token = "0x4004429")]
	[FieldOffset(Offset = "0x130")]
	public WindStrength m_DefaultWindStrength;

	[Token(Token = "0x400442A")]
	[FieldOffset(Offset = "0x138")]
	public GameObject m_MainWindow;

	[Token(Token = "0x400442B")]
	[FieldOffset(Offset = "0x140")]
	public GameObject m_SelectFeatWindow;

	[Token(Token = "0x400442C")]
	[FieldOffset(Offset = "0x148")]
	public GameObject m_DefaultSelectedButtonMainMenu;

	[Token(Token = "0x400442D")]
	[FieldOffset(Offset = "0x150")]
	public GameObject m_XboxUserPopup;

	[Token(Token = "0x400442E")]
	[FieldOffset(Offset = "0x158")]
	public UILabel m_XboxUserNameLabel;

	[Token(Token = "0x400442F")]
	[FieldOffset(Offset = "0x160")]
	public UILabel m_TrialModeTimer;

	[Token(Token = "0x4004430")]
	[FieldOffset(Offset = "0x168")]
	public UILabel m_SaveErrorMessage;

	[Token(Token = "0x4004431")]
	[FieldOffset(Offset = "0x170")]
	public GameObject m_BuyNowObject;

	[Token(Token = "0x4004432")]
	[FieldOffset(Offset = "0x178")]
	public float m_InitialScreenFadeInDuration;

	[Token(Token = "0x4004433")]
	[FieldOffset(Offset = "0x180")]
	public UISprite m_Sprite_FadeOverlay;

	[Token(Token = "0x4004434")]
	[FieldOffset(Offset = "0x188")]
	public GameObject m_HalloweenObject;

	[Token(Token = "0x4004435")]
	[FieldOffset(Offset = "0x190")]
	public UILabel m_4DONDayLabel;

	[Token(Token = "0x4004436")]
	[FieldOffset(Offset = "0x198")]
	public UILabel m_4DONDailyTimerLabel;

	[SerializeField]
	[Token(Token = "0x4004437")]
	[FieldOffset(Offset = "0x1A0")]
	private GameplayTag m_UseSpecialHalloweenTOD;

	[Token(Token = "0x4004438")]
	public static bool m_IsRestarting;

	[Token(Token = "0x4004439")]
	[FieldOffset(Offset = "0x1B0")]
	private uint m_MusicPlayingID;

	[Token(Token = "0x400443A")]
	[FieldOffset(Offset = "0x1B4")]
	private bool m_Quit;

	[Token(Token = "0x400443B")]
	[FieldOffset(Offset = "0x1B5")]
	private bool m_StartSettingsApplied;

	[Token(Token = "0x400443C")]
	[FieldOffset(Offset = "0x1B8")]
	private float m_PanelAlpha;

	[Token(Token = "0x400443D")]
	[FieldOffset(Offset = "0x1BC")]
	private float m_PanelAlphaTarget;

	[Token(Token = "0x400443E")]
	[FieldOffset(Offset = "0x1C0")]
	private float m_TimeNoInput;

	[Token(Token = "0x400443F")]
	[FieldOffset(Offset = "0x1C4")]
	private float m_ScreenElapsedTime;

	[Header("Paths")]
	[Token(Token = "0x4004440")]
	[FieldOffset(Offset = "0x1C8")]
	public PlatformPath m_IntroMovieFilename;

	[SerializeField]
	[Token(Token = "0x4004441")]
	[FieldOffset(Offset = "0x1D0")]
	private PlatformPath m_StoryModeApplicationPath;

	[SerializeField]
	[Token(Token = "0x4004442")]
	[FieldOffset(Offset = "0x1D8")]
	private PlatformPath m_Episode5ApplicationPath;

	[SerializeField]
	[Range(-1f, 15f)]
	[Token(Token = "0x4004443")]
	[FieldOffset(Offset = "0x1E0")]
	private int m_SwitchStoryModeIndex;

	[SerializeField]
	[Range(-1f, 15f)]
	[Token(Token = "0x4004444")]
	[FieldOffset(Offset = "0x1E4")]
	private int m_SwitchEpisode5Index;

	[Header("Menu")]
	[Token(Token = "0x4004445")]
	[FieldOffset(Offset = "0x1E8")]
	public string m_TitleLocalizationId;

	[Token(Token = "0x4004446")]
	[FieldOffset(Offset = "0x1F0")]
	public GameObject m_BasicMenuRoot;

	[Token(Token = "0x4004447")]
	[FieldOffset(Offset = "0x1F8")]
	public List<MainMenuItem> m_MenuItems;

	[Header("Steam Cloud")]
	[Token(Token = "0x4004448")]
	[FieldOffset(Offset = "0x200")]
	public UILabel m_CloudMessageLabel;

	[Header("Communication Buttons")]
	[SerializeField]
	[Token(Token = "0x4004449")]
	[FieldOffset(Offset = "0x208")]
	private GameObject m_CommunicationButtonsParent;

	[SerializeField]
	[Token(Token = "0x400444A")]
	[FieldOffset(Offset = "0x210")]
	private List<CommunicationButton> m_CommunicationButtons;

	[SerializeField]
	[Token(Token = "0x400444B")]
	[FieldOffset(Offset = "0x218")]
	private GameObject m_CommunicationSelect;

	[SerializeField]
	[Token(Token = "0x400444C")]
	[FieldOffset(Offset = "0x220")]
	private GameObject m_CommunicationDeselect;

	[Header("News")]
	[SerializeField]
	[Token(Token = "0x400444D")]
	[FieldOffset(Offset = "0x228")]
	private NewsCarousel m_NewsCarousel;

	[Header("Edition Art")]
	[SerializeField]
	[Token(Token = "0x400444E")]
	[FieldOffset(Offset = "0x230")]
	private GameEditionArt m_BaseEditionArt;

	[SerializeField]
	[Token(Token = "0x400444F")]
	[FieldOffset(Offset = "0x238")]
	private GameEditionArt m_WintermuteEditionArt;

	[SerializeField]
	[Token(Token = "0x4004450")]
	[FieldOffset(Offset = "0x240")]
	private GameEditionArt m_ExpansionPassEditionArt;

	[Header("DLC")]
	[SerializeField]
	[Token(Token = "0x4004451")]
	[FieldOffset(Offset = "0x248")]
	private OptionalContentConfig m_ExpansionPassConfig;

	[SerializeField]
	[Token(Token = "0x4004452")]
	[FieldOffset(Offset = "0x250")]
	private OptionalContentConfig m_WintermuteConfig;

	[Token(Token = "0x4004453")]
	private const bool BYPASS_WM_OWNERSHIP_CHECK = false;

	[Token(Token = "0x4004454")]
	[FieldOffset(Offset = "0x258")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x4004455")]
	[FieldOffset(Offset = "0x260")]
	private int m_CommunicationButtonSelectedIndex;

	[Token(Token = "0x4004456")]
	[FieldOffset(Offset = "0x264")]
	private float m_WaitingForProfileToLoadTimer;

	[Token(Token = "0x4004457")]
	[FieldOffset(Offset = "0x268")]
	private int m_HoldMovieForD3D9Frames;

	[Token(Token = "0x4004458")]
	[FieldOffset(Offset = "0x26C")]
	private bool m_PlayedIntroMovie;

	[Token(Token = "0x4004459")]
	[FieldOffset(Offset = "0x26D")]
	private bool m_DoneFourDaysOfNightDeleteCheck;

	[Token(Token = "0x400445A")]
	private static float m_AdjustedFadeInDuration;

	[Token(Token = "0x400445B")]
	private static bool m_HasMainMenuFadedIn;

	[Token(Token = "0x400445C")]
	[FieldOffset(Offset = "0x26E")]
	private bool m_SyncSaveStarted;

	[Token(Token = "0x400445D")]
	[FieldOffset(Offset = "0x270")]
	private string m_VersionLabelString;

	[Token(Token = "0x400445E")]
	[FieldOffset(Offset = "0x278")]
	private List<BoxCollider> m_ButtonColliders;

	[Token(Token = "0x400445F")]
	[FieldOffset(Offset = "0x280")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Header("Feat Selection")]
	[SerializeField]
	[Token(Token = "0x4004460")]
	[FieldOffset(Offset = "0x288")]
	private BadgeUISettings m_BadgeUISettings;

	[Token(Token = "0x4004461")]
	[FieldOffset(Offset = "0x290")]
	public ScrollList m_FeatSelectionScrollList;

	[Token(Token = "0x4004462")]
	[FieldOffset(Offset = "0x298")]
	public GameObject m_FeatSelectionButtonLeft;

	[Token(Token = "0x4004463")]
	[FieldOffset(Offset = "0x2A0")]
	public GameObject m_FeatSelectionButtonRight;

	[Token(Token = "0x4004464")]
	[FieldOffset(Offset = "0x2A8")]
	public UISprite m_ProgressBarSprite;

	[Token(Token = "0x4004465")]
	[FieldOffset(Offset = "0x2B0")]
	public UILabel m_ProgressLabel;

	[Token(Token = "0x4004466")]
	[FieldOffset(Offset = "0x2B8")]
	public UILabel m_FeatNameLabel;

	[Token(Token = "0x4004467")]
	[FieldOffset(Offset = "0x2C0")]
	public UILabel m_FeatDescLabel;

	[Token(Token = "0x4004468")]
	[FieldOffset(Offset = "0x2C8")]
	public UISprite m_FeatDescLinebreak;

	[Token(Token = "0x4004469")]
	[FieldOffset(Offset = "0x2D0")]
	public GameObject m_ActionButtonObject;

	[Token(Token = "0x400446A")]
	[FieldOffset(Offset = "0x2D8")]
	public UILabel m_ActionButtonLabelMouse;

	[Token(Token = "0x400446B")]
	[FieldOffset(Offset = "0x2E0")]
	public UILabel m_ActionButtonLabelGamepad;

	[Token(Token = "0x400446C")]
	[FieldOffset(Offset = "0x2E8")]
	public UISprite m_ActionButtonSpriteGamepad;

	[Token(Token = "0x400446D")]
	[FieldOffset(Offset = "0x2F0")]
	public GameObject[] m_ActiveFeatObjects;

	[Token(Token = "0x400446E")]
	[FieldOffset(Offset = "0x2F8")]
	public float m_ActiveFeatCenteredX;

	[Token(Token = "0x400446F")]
	[FieldOffset(Offset = "0x2FC")]
	public float m_ActiveFeatSpacing;

	[Token(Token = "0x4004470")]
	[FieldOffset(Offset = "0x300")]
	public UILabel m_FeatBenefitHeaderLabel;

	[Token(Token = "0x4004471")]
	[FieldOffset(Offset = "0x308")]
	public UILabel m_FeatBenefitDescriptionLabel;

	[Token(Token = "0x4004472")]
	[FieldOffset(Offset = "0x310")]
	private readonly List<BadgeInfo> m_Feats;

	[Token(Token = "0x4004473")]
	[FieldOffset(Offset = "0x318")]
	private readonly List<string> m_SelectedFeats;

	[Token(Token = "0x4004474")]
	[FieldOffset(Offset = "0x320")]
	private string m_ActionButtonLocID;

	[Token(Token = "0x4004475")]
	[FieldOffset(Offset = "0x328")]
	private bool m_ActionButtonEnabled;

	[Token(Token = "0x4004476")]
	[FieldOffset(Offset = "0x330")]
	private readonly Dictionary<object, AsyncOperationHandle<Texture2D>> m_SpriteAssets;

	[Token(Token = "0x60037BC")]
	[Address(RVA = "0xADF7C0", Offset = "0xADE5C0", Length = "0x87C")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60037BD")]
	[Address(RVA = "0xAE0040", Offset = "0xADEE40", Length = "0x105")]
	public Action GetActionFromType(MainMenuItem.MainMenuItemType type)
	{
		return null;
	}

	[Token(Token = "0x60037BE")]
	[Address(RVA = "0xAE0150", Offset = "0xADEF50", Length = "0xF")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60037BF")]
	[Address(RVA = "0xAE0160", Offset = "0xADEF60", Length = "0x88")]
	public void OnMainMenuTop()
	{
	}

	[Token(Token = "0x60037C0")]
	[Address(RVA = "0xAE01F0", Offset = "0xADEFF0", Length = "0x2E5")]
	public bool IsSubMenuEnabled()
	{
		return false;
	}

	[Token(Token = "0x60037C1")]
	[Address(RVA = "0xAE04E0", Offset = "0xADF2E0", Length = "0x168C")]
	private void Update()
	{
	}

	[Token(Token = "0x60037C2")]
	[Address(RVA = "0xAE1B70", Offset = "0xAE0970", Length = "0xB4")]
	private void MaybeDoSteamSynchronization()
	{
	}

	[Token(Token = "0x60037C3")]
	[Address(RVA = "0xAE1C30", Offset = "0xAE0A30", Length = "0x13E")]
	private void UpdateMainWindow()
	{
	}

	[Token(Token = "0x60037C4")]
	[Address(RVA = "0xAE1D70", Offset = "0xAE0B70", Length = "0x5D5")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60037C5")]
	[Address(RVA = "0xAE2350", Offset = "0xAE1150", Length = "0x15C")]
	public void OnSandbox()
	{
	}

	[Token(Token = "0x60037C6")]
	[Address(RVA = "0xAE24B0", Offset = "0xAE12B0", Length = "0x10E")]
	private bool HasValidStoryModeApplicationExecutable()
	{
		return false;
	}

	[Token(Token = "0x60037C7")]
	[Address(RVA = "0xAE25C0", Offset = "0xAE13C0", Length = "0x10E")]
	private bool HasValidEpisode5ApplicationExecutable()
	{
		return false;
	}

	[Token(Token = "0x60037C8")]
	[Address(RVA = "0xAE26D0", Offset = "0xAE14D0", Length = "0x304")]
	public void OnStory()
	{
	}

	[Token(Token = "0x60037C9")]
	[Address(RVA = "0xAE29E0", Offset = "0xAE17E0", Length = "0x99")]
	private void OnWintermuteStory()
	{
	}

	[Token(Token = "0x60037CA")]
	[Address(RVA = "0xAE2A80", Offset = "0xAE1880", Length = "0x199")]
	private void OnEpisode5Story()
	{
	}

	[Token(Token = "0x60037CB")]
	[Address(RVA = "0xAE2C20", Offset = "0xAE1A20", Length = "0x67")]
	private bool CanUseStoryContent()
	{
		return false;
	}

	[Token(Token = "0x60037CC")]
	[Address(RVA = "0xAE2C90", Offset = "0xAE1A90", Length = "0xA3")]
	public void OnTFTFTUpsell()
	{
	}

	[Token(Token = "0x60037CD")]
	[Address(RVA = "0xAE2D40", Offset = "0xAE1B40", Length = "0x200")]
	public void OnLoadSaveSlot(SaveSlotType saveSlotType, int slotIndex)
	{
	}

	[Token(Token = "0x60037CE")]
	[Address(RVA = "0xAE2F40", Offset = "0xAE1D40", Length = "0x4E8")]
	public void OnLoadGame(SaveSlotType saveSlotType, int slotIndex)
	{
	}

	[Token(Token = "0x60037CF")]
	[Address(RVA = "0xAE3430", Offset = "0xAE2230", Length = "0x16A")]
	public void OnLogs()
	{
	}

	[Token(Token = "0x60037D0")]
	[Address(RVA = "0xAE35A0", Offset = "0xAE23A0", Length = "0xAB")]
	public void OnDebugPanel()
	{
	}

	[Token(Token = "0x60037D1")]
	[Address(RVA = "0xAE3650", Offset = "0xAE2450", Length = "0x5D")]
	public void OnQuit()
	{
	}

	[Token(Token = "0x60037D2")]
	[Address(RVA = "0xAE36B0", Offset = "0xAE24B0", Length = "0x131")]
	public void OnSelectSurvivorBack()
	{
	}

	[Token(Token = "0x60037D3")]
	[Address(RVA = "0xAE37F0", Offset = "0xAE25F0", Length = "0x12E")]
	public void OnSelectSurvivorContinue()
	{
	}

	[Token(Token = "0x60037D4")]
	[Address(RVA = "0xAE3920", Offset = "0xAE2720", Length = "0x30B")]
	private string NameSandboxGame(SaveSlotType saveSlotType)
	{
		return null;
	}

	[Token(Token = "0x60037D5")]
	[Address(RVA = "0xAE3C30", Offset = "0xAE2A30", Length = "0x16D")]
	private void ShowSurvivalSettings()
	{
	}

	[Token(Token = "0x60037D6")]
	[Address(RVA = "0xAE3DA0", Offset = "0xAE2BA0", Length = "0xD3")]
	private void OnShowSurvivalSettingsBack()
	{
	}

	[Token(Token = "0x60037D7")]
	[Address(RVA = "0xAE3E80", Offset = "0xAE2C80", Length = "0x207")]
	private void ShowNameSaveSlotPopup()
	{
	}

	[Token(Token = "0x60037D8")]
	[Address(RVA = "0xAE4090", Offset = "0xAE2E90", Length = "0x16C")]
	private void OnRenameNewSandboxComplete()
	{
	}

	[Token(Token = "0x60037D9")]
	[Address(RVA = "0xAE4200", Offset = "0xAE3000", Length = "0x24D")]
	private void OnRenameNewSandboxCancel(bool wasCancelled)
	{
	}

	[Token(Token = "0x60037DA")]
	[Address(RVA = "0xAE4090", Offset = "0xAE2E90", Length = "0x16C")]
	public void OnSelectSlotNameContinue()
	{
	}

	[Token(Token = "0x60037DB")]
	[Address(RVA = "0xAE4450", Offset = "0xAE3250", Length = "0x102")]
	public void PlayMainMenuMusic()
	{
	}

	[Token(Token = "0x60037DC")]
	[Address(RVA = "0xAE4560", Offset = "0xAE3360", Length = "0xF9")]
	public void StopMainMenuMusic()
	{
	}

	[Token(Token = "0x60037DD")]
	[Address(RVA = "0xAE4660", Offset = "0xAE3460", Length = "0x3D")]
	private void DisableMainMenuButtons()
	{
	}

	[Token(Token = "0x60037DE")]
	[Address(RVA = "0xAE46A0", Offset = "0xAE34A0", Length = "0x58")]
	private void EnableMainMenuButtons()
	{
	}

	[Token(Token = "0x60037DF")]
	[Address(RVA = "0xAE4700", Offset = "0xAE3500", Length = "0x151")]
	private void DisableMainMenuButtonColliders()
	{
	}

	[Token(Token = "0x60037E0")]
	[Address(RVA = "0xAE4860", Offset = "0xAE3660", Length = "0x2B2")]
	private void EnableMainMenuButtonColliders()
	{
	}

	[Token(Token = "0x60037E1")]
	[Address(RVA = "0xAE4B20", Offset = "0xAE3920", Length = "0x411")]
	public void UpdateFading()
	{
	}

	[Token(Token = "0x60037E2")]
	[Address(RVA = "0xAE4F40", Offset = "0xAE3D40", Length = "0xB")]
	private void FadeInPanel()
	{
	}

	[Token(Token = "0x60037E3")]
	[Address(RVA = "0xAE4F50", Offset = "0xAE3D50", Length = "0xB")]
	private void FadeOutPanel()
	{
	}

	[Token(Token = "0x60037E4")]
	[Address(RVA = "0xAE4F60", Offset = "0xAE3D60", Length = "0x1D8")]
	private void SetPanelAlpha(float alpha)
	{
	}

	[Token(Token = "0x60037E5")]
	[Address(RVA = "0xAE5140", Offset = "0xAE3F40", Length = "0x62F")]
	private void SelectWindow(GameObject windowToSelect)
	{
	}

	[Token(Token = "0x60037E6")]
	[Address(RVA = "0xAE5770", Offset = "0xAE4570", Length = "0x5A")]
	private bool ShouldDisableMainMenuButtons()
	{
		return false;
	}

	[Token(Token = "0x60037E7")]
	[Address(RVA = "0xAE57D0", Offset = "0xAE45D0", Length = "0x45")]
	public void OnBuyNow()
	{
	}

	[Token(Token = "0x60037E8")]
	[Address(RVA = "0xAE5820", Offset = "0xAE4620", Length = "0xF6")]
	private void WarmUpSmokeTrails()
	{
	}

	[Token(Token = "0x60037E9")]
	[Address(RVA = "0xAE5920", Offset = "0xAE4720", Length = "0x2F9")]
	private void MaybeShowResetBindingsConfirmation()
	{
	}

	[Token(Token = "0x60037EA")]
	[Address(RVA = "0xAE5C20", Offset = "0xAE4A20", Length = "0x17B")]
	private void ResetBindings()
	{
	}

	[Token(Token = "0x60037EB")]
	[Address(RVA = "0xAE5DA0", Offset = "0xAE4BA0", Length = "0x106")]
	private void SetVersionLabel()
	{
	}

	[Token(Token = "0x60037EC")]
	[Address(RVA = "0xAE5EB0", Offset = "0xAE4CB0", Length = "0xA9")]
	private void LoadAllSlots()
	{
	}

	[Token(Token = "0x60037ED")]
	[Address(RVA = "0xAE5F60", Offset = "0xAE4D60", Length = "0x8D")]
	private bool ProfileIsLoading()
	{
		return false;
	}

	[Token(Token = "0x60037EE")]
	[Address(RVA = "0xAE5FF0", Offset = "0xAE4DF0", Length = "0x17E")]
	private void PlayIntroMovie()
	{
	}

	[Token(Token = "0x60037EF")]
	[Address(RVA = "0xAE6170", Offset = "0xAE4F70", Length = "0x2F0")]
	private void AddMenuItem(MainMenuItem mainMenuItem, int itemIndex)
	{
	}

	[Token(Token = "0x60037F0")]
	[Address(RVA = "0xAE6470", Offset = "0xAE5270", Length = "0x429")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x60037F1")]
	[Address(RVA = "0xAE68A0", Offset = "0xAE56A0", Length = "0x180")]
	private void SetGameEditionArt()
	{
	}

	[Token(Token = "0x60037F2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Token(Token = "0x60037F3")]
	[Address(RVA = "0xAE6A30", Offset = "0xAE5830", Length = "0xBC")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60037F4")]
	[Address(RVA = "0xAE6AF0", Offset = "0xAE58F0", Length = "0x3C")]
	public bool HasFadedIn()
	{
		return false;
	}

	[Token(Token = "0x60037F5")]
	[Address(RVA = "0xAE6B30", Offset = "0xAE5930", Length = "0x9")]
	public float GetAlpha()
	{
		return 0f;
	}

	[Token(Token = "0x60037F6")]
	[Address(RVA = "0xAE6B40", Offset = "0xAE5940", Length = "0x6F")]
	public void Reset()
	{
	}

	[Token(Token = "0x60037F7")]
	[Address(RVA = "0xAE6BB0", Offset = "0xAE59B0", Length = "0x112")]
	private static void EnableCamera(bool isEnabled)
	{
	}

	[Token(Token = "0x60037F8")]
	[Address(RVA = "0xAE6CD0", Offset = "0xAE5AD0", Length = "0x182")]
	private void SetCommunicationButtonsFocus(bool communicationFocused)
	{
	}

	[Token(Token = "0x60037F9")]
	[Address(RVA = "0xAE6E60", Offset = "0xAE5C60", Length = "0x295")]
	private void UpdateCommunicationButtons()
	{
	}

	[Token(Token = "0x60037FA")]
	[Address(RVA = "0xAE7100", Offset = "0xAE5F00", Length = "0x9E")]
	private void OnClickCommunicationButton(CommunicationButton button)
	{
	}

	[Token(Token = "0x60037FB")]
	[Address(RVA = "0xAE71A0", Offset = "0xAE5FA0", Length = "0xF0")]
	private void RefreshGamepadButtons()
	{
	}

	[Token(Token = "0x60037FC")]
	[Address(RVA = "0xAE72A0", Offset = "0xAE60A0", Length = "0xC2")]
	private bool ShouldShowFeatSelection()
	{
		return false;
	}

	[Token(Token = "0x60037FD")]
	[Address(RVA = "0xAE7370", Offset = "0xAE6170", Length = "0x1F")]
	protected void UpdateSelectFeatWindow()
	{
	}

	[Token(Token = "0x60037FE")]
	[Address(RVA = "0xAE7390", Offset = "0xAE6190", Length = "0x317")]
	private void UpdateSelectFeatVisuals()
	{
	}

	[Token(Token = "0x60037FF")]
	[Address(RVA = "0xAE76B0", Offset = "0xAE64B0", Length = "0x93")]
	protected void FeatSelectWindowSelected()
	{
	}

	[Token(Token = "0x6003800")]
	[Address(RVA = "0xAE7750", Offset = "0xAE6550", Length = "0x267")]
	public void OnSelectFeatsContinue()
	{
	}

	[Token(Token = "0x6003801")]
	[Address(RVA = "0xAE79C0", Offset = "0xAE67C0", Length = "0xA2")]
	public void OnSelectFeatsBack()
	{
	}

	[Token(Token = "0x6003802")]
	[Address(RVA = "0xAE7A70", Offset = "0xAE6870", Length = "0x262")]
	public void OnToggleFeatActive()
	{
	}

	[Token(Token = "0x6003803")]
	[Address(RVA = "0xAE7CE0", Offset = "0xAE6AE0", Length = "0x10B")]
	public void FeatSelectionNext()
	{
	}

	[Token(Token = "0x6003804")]
	[Address(RVA = "0xAE7DF0", Offset = "0xAE6BF0", Length = "0x10B")]
	public void FeatSelectionPrev()
	{
	}

	[Token(Token = "0x6003805")]
	[Address(RVA = "0xAE7F00", Offset = "0xAE6D00", Length = "0x9C")]
	public void FeatSelectionIndexSelected(int index)
	{
	}

	[Token(Token = "0x6003806")]
	[Address(RVA = "0xAE7FA0", Offset = "0xAE6DA0", Length = "0x59C")]
	private void SetupFeatScrollList()
	{
	}

	[Token(Token = "0x6003807")]
	[Address(RVA = "0xAE8540", Offset = "0xAE7340", Length = "0x2EA")]
	private void CleanupFeatScrollList()
	{
	}

	[Token(Token = "0x6003808")]
	[Address(RVA = "0xAE8830", Offset = "0xAE7630", Length = "0x139")]
	private void AddFeatToList(Feat f)
	{
	}

	[Token(Token = "0x6003809")]
	[Address(RVA = "0xAE8970", Offset = "0xAE7770", Length = "0x722")]
	private void UpdateSelectedFeats()
	{
	}

	[Token(Token = "0x600380A")]
	[Address(RVA = "0xAE90A0", Offset = "0xAE7EA0", Length = "0x5F2")]
	private void LoadFeatureIcon(UITexture targetTexture, AssetReferenceTexture2D spriteReference)
	{
	}

	[Token(Token = "0x600380B")]
	[Address(RVA = "0xAE96A0", Offset = "0xAE84A0", Length = "0x223")]
	private void CleanupSelectedFeats()
	{
	}

	[Token(Token = "0x600380C")]
	[Address(RVA = "0xAE98D0", Offset = "0xAE86D0", Length = "0x2EF")]
	private void ReleaseSpriteAssets()
	{
	}

	[Token(Token = "0x600380D")]
	[Address(RVA = "0xAE9BC0", Offset = "0xAE89C0", Length = "0x2F4")]
	private void UpdateFeatProgressBar()
	{
	}

	[Token(Token = "0x600380E")]
	[Address(RVA = "0xAE9EC0", Offset = "0xAE8CC0", Length = "0x379")]
	private void UpdateFeatActionButton()
	{
	}

	[Token(Token = "0x600380F")]
	[Address(RVA = "0xAEA240", Offset = "0xAE9040", Length = "0x42A")]
	private void UpdateFeatMarkerSprites()
	{
	}

	[Token(Token = "0x6003810")]
	[Address(RVA = "0xAEA670", Offset = "0xAE9470", Length = "0x3AE")]
	private void UpdateFeatControls()
	{
	}

	[Token(Token = "0x6003811")]
	[Address(RVA = "0xAEAA20", Offset = "0xAE9820", Length = "0x118")]
	private void UpdateFeatButtonLegend()
	{
	}

	[Token(Token = "0x6003812")]
	[Address(RVA = "0xAEAB40", Offset = "0xAE9940", Length = "0x639")]
	private void UpdateFeatLabels()
	{
	}

	[Token(Token = "0x6003813")]
	[Address(RVA = "0xAEB180", Offset = "0xAE9F80", Length = "0x186")]
	public int GetNumFeatsForXPMode()
	{
		return 0;
	}

	[Token(Token = "0x6003814")]
	[Address(RVA = "0xAEB310", Offset = "0xAEA110", Length = "0x262")]
	private int GetNumUnlockedFeats()
	{
		return 0;
	}

	[Token(Token = "0x6003815")]
	[Address(RVA = "0xAEB580", Offset = "0xAEA380", Length = "0x2D1")]
	public Panel_MainMenu()
	{
	}
}
