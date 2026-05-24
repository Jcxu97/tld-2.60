using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x2000618")]
public class Panel_ChallengeComplete : Panel_Base
{
	[Flags]
	[Token(Token = "0x2000619")]
	public enum Options
	{
		[Token(Token = "0x4003991")]
		None = 0,
		[Token(Token = "0x4003992")]
		Succeeded = 1,
		[Token(Token = "0x4003993")]
		ToBeContinued = 2,
		[Token(Token = "0x4003994")]
		ShowFailTimeSurvived = 4,
		[Token(Token = "0x4003995")]
		ShowFailStatInfo = 8
	}

	[Token(Token = "0x400395A")]
	private static string[] SPECIAL_SLOT_PREFIXES;

	[Token(Token = "0x400395B")]
	private static string[] SPECIAL_SLOT_LOCIDS;

	[Token(Token = "0x400395C")]
	private static int[] SPECIAL_SLOT_LIMITS;

	[Token(Token = "0x400395D")]
	[FieldOffset(Offset = "0x28")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400395E")]
	[FieldOffset(Offset = "0x30")]
	public float m_SecondsBeforeShowMenuSuccess;

	[Token(Token = "0x400395F")]
	[FieldOffset(Offset = "0x34")]
	public float m_SecondsBeforeShowMenuFail;

	[Token(Token = "0x4003960")]
	[FieldOffset(Offset = "0x38")]
	public float m_SecondsBeforeShowMenuToBeContinued;

	[Range(1f, 5f)]
	[Token(Token = "0x4003961")]
	[FieldOffset(Offset = "0x3C")]
	public int m_MaxSavesToDisplay;

	[Token(Token = "0x4003962")]
	[FieldOffset(Offset = "0x40")]
	public GameObject[] m_ButtonObjects;

	[Token(Token = "0x4003963")]
	[FieldOffset(Offset = "0x48")]
	public Animator m_SuccessAnimator;

	[Token(Token = "0x4003964")]
	[FieldOffset(Offset = "0x50")]
	public Animator m_FailAnimator;

	[Token(Token = "0x4003965")]
	[FieldOffset(Offset = "0x58")]
	public UITexture m_BadgeTexture;

	[Token(Token = "0x4003966")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_ChallengeNameLabel;

	[Token(Token = "0x4003967")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_SurvivedTimeLabel;

	[Token(Token = "0x4003968")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_BestTimeLabel;

	[Token(Token = "0x4003969")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_TryAgainButtonParent;

	[Token(Token = "0x400396A")]
	[FieldOffset(Offset = "0x80")]
	public UILabel m_FailReasonLabel;

	[Token(Token = "0x400396B")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_BasicMenuRoot;

	[Token(Token = "0x400396C")]
	[FieldOffset(Offset = "0x90")]
	public UtilsPanelChoose.DetailsObjets m_DetailObjects;

	[Token(Token = "0x400396D")]
	[FieldOffset(Offset = "0x98")]
	public UILabel m_EpisodeValue;

	[Token(Token = "0x400396E")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel m_ProgressValue;

	[Token(Token = "0x400396F")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel m_MostRecentSavesLabel;

	[Token(Token = "0x4003970")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_FailInfoGroup;

	[Token(Token = "0x4003971")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel m_FailSurvivedTimeLabel;

	[Token(Token = "0x4003972")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_FailSurvivedTimeHeader;

	[Token(Token = "0x4003973")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel m_FailStatLabel;

	[Header("Nowhere to Hide Complete Screen")]
	[Token(Token = "0x4003974")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_NowhereToHideRoot;

	[Token(Token = "0x4003975")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel m_SurvivedTimeLabelN2H;

	[Token(Token = "0x4003976")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel m_BestTimeLabelN2H;

	[Token(Token = "0x4003977")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel m_CollectibleCountLabelN2H;

	[Token(Token = "0x4003978")]
	[FieldOffset(Offset = "0xF0")]
	public Animator m_GameOverAnimatorN2H;

	[Token(Token = "0x4003979")]
	[FieldOffset(Offset = "0xF8")]
	public Animator m_BadgeAnimatorN2H;

	[Token(Token = "0x400397A")]
	[FieldOffset(Offset = "0x100")]
	public GameObject m_FailInfoGroupN2H;

	[Token(Token = "0x400397B")]
	[FieldOffset(Offset = "0x108")]
	public string m_NowhereToHideAudioEvent;

	[Token(Token = "0x400397C")]
	[FieldOffset(Offset = "0x110")]
	public UILabel m_DeathDescriptionN2H;

	[Token(Token = "0x400397D")]
	[FieldOffset(Offset = "0x118")]
	public LocalizedString m_DevouredTextN2H;

	[Token(Token = "0x400397E")]
	[FieldOffset(Offset = "0x120")]
	public Animator m_SuccessAnimatorN2H;

	[Token(Token = "0x400397F")]
	[FieldOffset(Offset = "0x128")]
	public UILabel m_SuccessSurvivedTimeLabelN2H;

	[Token(Token = "0x4003980")]
	[FieldOffset(Offset = "0x130")]
	public UILabel m_SuccessBestTimeLabelN2H;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003981")]
	[FieldOffset(Offset = "0x138")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4003982")]
	[FieldOffset(Offset = "0x140")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x4003983")]
	[FieldOffset(Offset = "0x148")]
	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	[Token(Token = "0x4003984")]
	[FieldOffset(Offset = "0x150")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x4003985")]
	[FieldOffset(Offset = "0x158")]
	private SaveSlotInfo m_LastSaveSlotInfo;

	[Token(Token = "0x4003986")]
	[FieldOffset(Offset = "0x160")]
	private SaveSlotInfo m_LastCheckpointSlotInfo;

	[Token(Token = "0x4003987")]
	[FieldOffset(Offset = "0x168")]
	private Dictionary<string, int> m_SaveSlotMapping;

	[Token(Token = "0x4003988")]
	[FieldOffset(Offset = "0x170")]
	private UILabel m_TryAgainButtonLabel;

	[Token(Token = "0x4003989")]
	[FieldOffset(Offset = "0x178")]
	private float m_FinalScreenCountdownSeconds;

	[Token(Token = "0x400398A")]
	[FieldOffset(Offset = "0x17C")]
	private int m_AnimParameter_ShowFailScreen;

	[Token(Token = "0x400398B")]
	[FieldOffset(Offset = "0x180")]
	private int m_AnimParameter_ShowSuccessScreen;

	[Token(Token = "0x400398C")]
	[FieldOffset(Offset = "0x184")]
	private int m_AnimParameter_ShowToBeContinued;

	[Token(Token = "0x400398D")]
	[FieldOffset(Offset = "0x188")]
	private bool m_ShowTimeSurvived;

	[Token(Token = "0x400398E")]
	[FieldOffset(Offset = "0x189")]
	private bool m_ShowStatInfo;

	[Token(Token = "0x400398F")]
	[FieldOffset(Offset = "0x18A")]
	private bool m_N2HAudioTriggered;

	[Token(Token = "0x600303E")]
	[Address(RVA = "0x9A3F70", Offset = "0x9A2D70", Length = "0x2FB")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600303F")]
	[Address(RVA = "0x9A4270", Offset = "0x9A3070", Length = "0x41D")]
	private void Update()
	{
	}

	[Token(Token = "0x6003040")]
	[Address(RVA = "0x9A4690", Offset = "0x9A3490", Length = "0xC73")]
	public void ShowPanel(Options panelOptions)
	{
	}

	[Token(Token = "0x6003041")]
	[Address(RVA = "0x9A5310", Offset = "0x9A4110", Length = "0x2C2")]
	public void DisablePanel()
	{
	}

	[Token(Token = "0x6003042")]
	[Address(RVA = "0x9A55E0", Offset = "0x9A43E0", Length = "0x78")]
	public void EnableLoadList(bool enable)
	{
	}

	[Token(Token = "0x6003043")]
	[Address(RVA = "0x9A5660", Offset = "0x9A4460", Length = "0x20")]
	public void DisableReloadCheckpointButton()
	{
	}

	[Token(Token = "0x6003044")]
	[Address(RVA = "0x9A5690", Offset = "0x9A4490", Length = "0x222")]
	public void OnMainMenu()
	{
	}

	[Token(Token = "0x6003045")]
	[Address(RVA = "0x9A58C0", Offset = "0x9A46C0", Length = "0x45")]
	public void OnLoadOther()
	{
	}

	[Token(Token = "0x6003046")]
	[Address(RVA = "0x9A5910", Offset = "0x9A4710", Length = "0x2F8")]
	public void OnTryAgain()
	{
	}

	[Token(Token = "0x6003047")]
	[Address(RVA = "0x9A5C10", Offset = "0x9A4A10", Length = "0x14E")]
	public void OnFinalScreenShown()
	{
	}

	[Token(Token = "0x6003048")]
	[Address(RVA = "0x9A5D60", Offset = "0x9A4B60", Length = "0x85F")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003049")]
	[Address(RVA = "0x9A65C0", Offset = "0x9A53C0", Length = "0x35C")]
	private string GetDescriptionLabelForSlot(SaveSlotInfo slotInfo)
	{
		return null;
	}

	[Token(Token = "0x600304A")]
	[Address(RVA = "0x9A6920", Offset = "0x9A5720", Length = "0x22D")]
	private void SetTimeSurvivedLabel(UILabel label)
	{
	}

	[Token(Token = "0x600304B")]
	[Address(RVA = "0x9A6B50", Offset = "0x9A5950", Length = "0x18A")]
	private static float GetElapsedTimeInHours()
	{
		return 0f;
	}

	[Token(Token = "0x600304C")]
	[Address(RVA = "0x9A6CE0", Offset = "0x9A5AE0", Length = "0x35D")]
	private void UpdateProfileAfterChallengeComplete(bool success, UILabel bestTimeLabel)
	{
	}

	[Token(Token = "0x600304D")]
	[Address(RVA = "0x9A7040", Offset = "0x9A5E40", Length = "0x272")]
	private AssetReferenceTexture2D GetBadgeForCurrentChallenge()
	{
		return null;
	}

	[Token(Token = "0x600304E")]
	[Address(RVA = "0x9A72C0", Offset = "0x9A60C0", Length = "0x227")]
	private void UpdateLabels()
	{
	}

	[Token(Token = "0x600304F")]
	[Address(RVA = "0x9A74F0", Offset = "0x9A62F0", Length = "0x6E")]
	private void ReloadSlot(SaveSlotInfo slotInfo)
	{
	}

	[Token(Token = "0x6003050")]
	[Address(RVA = "0x9A7560", Offset = "0x9A6360", Length = "0x6F0")]
	private void AddSavesOfTypeToMenu(string[] slotPrefixes, string[] displayLocIds = null, int[] limits = null, bool showTimeSinceSave = false)
	{
	}

	[Token(Token = "0x6003051")]
	[Address(RVA = "0x9A7C60", Offset = "0x9A6A60", Length = "0x16B")]
	private void OnSlotClicked()
	{
	}

	[Token(Token = "0x6003052")]
	[Address(RVA = "0x9A7DD0", Offset = "0x9A6BD0", Length = "0x51")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x6003053")]
	[Address(RVA = "0x9A7E30", Offset = "0x9A6C30", Length = "0xBA")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Token(Token = "0x6003054")]
	[Address(RVA = "0x9A7EF0", Offset = "0x9A6CF0", Length = "0x228")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[Token(Token = "0x6003055")]
	[Address(RVA = "0x9A8120", Offset = "0x9A6F20", Length = "0x319")]
	public void SetStatInfoText(string locId, string stat1MarkerValue, int stat1ValueValue, string stat2MarkerValue, int stat2ValueValue)
	{
	}

	[Token(Token = "0x6003056")]
	[Address(RVA = "0x9A8440", Offset = "0x9A7240", Length = "0x1ED")]
	public Panel_ChallengeComplete()
	{
	}
}
