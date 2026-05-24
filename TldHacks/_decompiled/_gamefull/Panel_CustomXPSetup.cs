using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.OptionalContent;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000643")]
public class Panel_CustomXPSetup : Panel_AutoReferenced
{
	[SerializeField]
	[Token(Token = "0x4003BE3")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x4003BE4")]
	[FieldOffset(Offset = "0x38")]
	private SandboxConfig m_CustomGameModeConfig;

	[Token(Token = "0x4003BE5")]
	[FieldOffset(Offset = "0x40")]
	public float m_ComboBoxHeight;

	[Token(Token = "0x4003BE6")]
	[FieldOffset(Offset = "0x44")]
	public float m_SectionHeaderHeight;

	[Token(Token = "0x4003BE7")]
	[FieldOffset(Offset = "0x48")]
	public string[] m_BaseXPModeCustomStrings;

	[Token(Token = "0x4003BE8")]
	[FieldOffset(Offset = "0x50")]
	public List<GameObject> m_CustomXPMenuItemOrder;

	[Token(Token = "0x4003BE9")]
	[FieldOffset(Offset = "0x58")]
	public List<GameObject> m_SectionList;

	[Token(Token = "0x4003BEA")]
	[FieldOffset(Offset = "0x60")]
	public ConsoleComboBox m_XPModePopupList;

	[Token(Token = "0x4003BEB")]
	[FieldOffset(Offset = "0x68")]
	public ConsoleComboBox m_BaseDifficultyPopupList;

	[Token(Token = "0x4003BEC")]
	[FieldOffset(Offset = "0x70")]
	public ConsoleComboBox m_StartingTODPopupList;

	[Token(Token = "0x4003BED")]
	[FieldOffset(Offset = "0x78")]
	public ConsoleComboBox m_StartingWeatherPopupList;

	[Token(Token = "0x4003BEE")]
	[FieldOffset(Offset = "0x80")]
	public ConsoleComboBox m_AllowInteriorSpawnPopupList;

	[Token(Token = "0x4003BEF")]
	[FieldOffset(Offset = "0x88")]
	public ConsoleComboBox m_AllowVoiceoverPopupList;

	[Token(Token = "0x4003BF0")]
	[FieldOffset(Offset = "0x90")]
	public ConsoleComboBox m_DayNightMultiplierPopupList;

	[Token(Token = "0x4003BF1")]
	[FieldOffset(Offset = "0x98")]
	public ConsoleComboBox m_WeatherChangeFreqPopupList;

	[Token(Token = "0x4003BF2")]
	[FieldOffset(Offset = "0xA0")]
	public ConsoleComboBox m_BlizzardFreqPopupList;

	[Token(Token = "0x4003BF3")]
	[FieldOffset(Offset = "0xA8")]
	public ConsoleComboBox m_GradualTempReductionPopupList;

	[Token(Token = "0x4003BF4")]
	[FieldOffset(Offset = "0xB0")]
	public ConsoleComboBox m_WindVariabilityPopupList;

	[Token(Token = "0x4003BF5")]
	[FieldOffset(Offset = "0xB8")]
	public ConsoleComboBox m_AuroraFreqPopupList;

	[Token(Token = "0x4003BF6")]
	[FieldOffset(Offset = "0xC0")]
	public ConsoleComboBox m_UseMinAirTempPopupList;

	[Token(Token = "0x4003BF7")]
	[FieldOffset(Offset = "0xC8")]
	public ConsoleComboBox m_CalorieBurnRatePopupList;

	[Token(Token = "0x4003BF8")]
	[FieldOffset(Offset = "0xD0")]
	public ConsoleComboBox m_ThirstIncreasePopupList;

	[Token(Token = "0x4003BF9")]
	[FieldOffset(Offset = "0xD8")]
	public ConsoleComboBox m_FatigueIncreasePopupList;

	[Token(Token = "0x4003BFA")]
	[FieldOffset(Offset = "0xE0")]
	public ConsoleComboBox m_FreezingIncreasePopupList;

	[Token(Token = "0x4003BFB")]
	[FieldOffset(Offset = "0xE8")]
	public ConsoleComboBox m_ConditionRecoveryRestPopupList;

	[Token(Token = "0x4003BFC")]
	[FieldOffset(Offset = "0xF0")]
	public ConsoleComboBox m_ConditionRecoveryAwakePopupList;

	[Token(Token = "0x4003BFD")]
	[FieldOffset(Offset = "0xF8")]
	public ConsoleComboBox m_HoursToCureHypothermiaPopupList;

	[Token(Token = "0x4003BFE")]
	[FieldOffset(Offset = "0x100")]
	public ConsoleComboBox m_FrostbiteRiskPopupList;

	[Token(Token = "0x4003BFF")]
	[FieldOffset(Offset = "0x108")]
	public ConsoleComboBox m_CabinFeverEnabledPopupList;

	[Token(Token = "0x4003C00")]
	[FieldOffset(Offset = "0x110")]
	public ConsoleComboBox m_ParasitesEnabledPopupList;

	[Token(Token = "0x4003C01")]
	[FieldOffset(Offset = "0x118")]
	public ConsoleComboBox m_DysenteryEnabledPopupList;

	[Token(Token = "0x4003C02")]
	[FieldOffset(Offset = "0x120")]
	public ConsoleComboBox m_SprainsEnabledPopupList;

	[Token(Token = "0x4003C03")]
	[FieldOffset(Offset = "0x128")]
	public ConsoleComboBox m_FoodPoisoningEnabledPopupList;

	[Token(Token = "0x4003C04")]
	[FieldOffset(Offset = "0x130")]
	public ConsoleComboBox m_BrokenRibsEnabledPopupList;

	[Token(Token = "0x4003C05")]
	[FieldOffset(Offset = "0x138")]
	public ConsoleComboBox m_LimitedRestPopupList;

	[Token(Token = "0x4003C06")]
	[FieldOffset(Offset = "0x140")]
	public ConsoleComboBox m_ScurvyDrainPopupList;

	[Token(Token = "0x4003C07")]
	[FieldOffset(Offset = "0x148")]
	public ConsoleComboBox m_AdjustFreezingNearbyFirePopupList;

	[Token(Token = "0x4003C08")]
	[FieldOffset(Offset = "0x150")]
	public ConsoleComboBox m_InterruptIfFreezingWhileSleepingPopupList;

	[Token(Token = "0x4003C09")]
	[FieldOffset(Offset = "0x158")]
	public ConsoleComboBox m_BirchBarkEnabledPopupList;

	[Token(Token = "0x4003C0A")]
	[FieldOffset(Offset = "0x160")]
	public ConsoleComboBox m_ItemDecayRatePopupList;

	[Token(Token = "0x4003C0B")]
	[FieldOffset(Offset = "0x168")]
	public ConsoleComboBox m_ItemSpawnChancePopupList;

	[Token(Token = "0x4003C0C")]
	[FieldOffset(Offset = "0x170")]
	public ConsoleComboBox m_EmptyContainerChancePopupList;

	[Token(Token = "0x4003C0D")]
	[FieldOffset(Offset = "0x178")]
	public ConsoleComboBox m_StickBranchStoneFreqPopupList;

	[Token(Token = "0x4003C0E")]
	[FieldOffset(Offset = "0x180")]
	public ConsoleComboBox m_StartingGearPopupList;

	[Token(Token = "0x4003C0F")]
	[FieldOffset(Offset = "0x188")]
	public ConsoleComboBox m_RiflesInWorldPopupList;

	[Token(Token = "0x4003C10")]
	[FieldOffset(Offset = "0x190")]
	public ConsoleComboBox m_RevolversInWorldPopupList;

	[Token(Token = "0x4003C11")]
	[FieldOffset(Offset = "0x198")]
	public ConsoleComboBox m_PlantSpawnFreqPopupList;

	[Token(Token = "0x4003C12")]
	[FieldOffset(Offset = "0x1A0")]
	public ConsoleComboBox m_ReduceMaxItemsInContainersPopupList;

	[Token(Token = "0x4003C13")]
	[FieldOffset(Offset = "0x1A8")]
	public ConsoleComboBox m_StrugglePlayerStrengthBonusPopupList;

	[Token(Token = "0x4003C14")]
	[FieldOffset(Offset = "0x1B0")]
	public ConsoleComboBox m_StruggleDamageReceivedModifierPopupList;

	[Token(Token = "0x4003C15")]
	[FieldOffset(Offset = "0x1B8")]
	public ConsoleComboBox m_StruggleClothingDamagePopupList;

	[Token(Token = "0x4003C16")]
	[FieldOffset(Offset = "0x1C0")]
	public ConsoleComboBox m_CougarDifficultyPopupList;

	[Token(Token = "0x4003C17")]
	[FieldOffset(Offset = "0x1C8")]
	public ConsoleComboBox m_WolfSpawnDistancePopupList;

	[Token(Token = "0x4003C18")]
	[FieldOffset(Offset = "0x1D0")]
	public ConsoleComboBox m_WolfFleeChancePopupList;

	[Token(Token = "0x4003C19")]
	[FieldOffset(Offset = "0x1D8")]
	public ConsoleComboBox m_TimberWolfPackFearPopupList;

	[Token(Token = "0x4003C1A")]
	[FieldOffset(Offset = "0x1E0")]
	public ConsoleComboBox m_WildlifeDetectionRangePopupList;

	[Token(Token = "0x4003C1B")]
	[FieldOffset(Offset = "0x1E8")]
	public ConsoleComboBox m_WildlifeInterruptRestPopupList;

	[Token(Token = "0x4003C1C")]
	[FieldOffset(Offset = "0x1F0")]
	public ConsoleComboBox m_StruggleDamageEventSeverityPopupList;

	[Token(Token = "0x4003C1D")]
	[FieldOffset(Offset = "0x1F8")]
	public ConsoleComboBox m_WildlifeSmellRangePopupList;

	[Token(Token = "0x4003C1E")]
	[FieldOffset(Offset = "0x200")]
	public ConsoleComboBox m_SmellIncreaseBloodPopupList;

	[Token(Token = "0x4003C1F")]
	[FieldOffset(Offset = "0x208")]
	public ConsoleComboBox m_WolfSpawnChancePopupList;

	[Token(Token = "0x4003C20")]
	[FieldOffset(Offset = "0x210")]
	public ConsoleComboBox m_TimberWolfSpawnChancePopupList;

	[Token(Token = "0x4003C21")]
	[FieldOffset(Offset = "0x218")]
	public ConsoleComboBox m_DeerSpawnChancePopupList;

	[Token(Token = "0x4003C22")]
	[FieldOffset(Offset = "0x220")]
	public ConsoleComboBox m_RabbitSpawnChancePopupList;

	[Token(Token = "0x4003C23")]
	[FieldOffset(Offset = "0x228")]
	public ConsoleComboBox m_BearSpawnChancePopupList;

	[Token(Token = "0x4003C24")]
	[FieldOffset(Offset = "0x230")]
	public ConsoleComboBox m_MooseSpawnChancePopupList;

	[Token(Token = "0x4003C25")]
	[FieldOffset(Offset = "0x238")]
	public ConsoleComboBox m_WildlifeRespawnFreqPopupList;

	[Token(Token = "0x4003C26")]
	[FieldOffset(Offset = "0x240")]
	public ConsoleComboBox m_ReduceWildlifePopOverTimePopupList;

	[Token(Token = "0x4003C27")]
	[FieldOffset(Offset = "0x248")]
	public ConsoleComboBox m_WildlifeNotAttackUnprovokedPopupList;

	[Token(Token = "0x4003C28")]
	[FieldOffset(Offset = "0x250")]
	public ConsoleComboBox m_NoPredatorsFirstDayPopupList;

	[Token(Token = "0x4003C29")]
	[FieldOffset(Offset = "0x258")]
	public ConsoleComboBox m_EndlessNightPopupList;

	[Token(Token = "0x4003C2A")]
	[FieldOffset(Offset = "0x260")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003C2B")]
	[FieldOffset(Offset = "0x268")]
	public GameObject m_Scrollbar;

	[Token(Token = "0x4003C2C")]
	[FieldOffset(Offset = "0x270")]
	public UIPanel m_ScrollPanel;

	[Token(Token = "0x4003C2D")]
	[FieldOffset(Offset = "0x278")]
	public Transform m_ScrollPanelOffsetTransform;

	[Token(Token = "0x4003C2E")]
	[FieldOffset(Offset = "0x280")]
	public UILabel m_TooltipLabel;

	[Token(Token = "0x4003C2F")]
	[FieldOffset(Offset = "0x288")]
	public GameObject m_ShareExperiencePopupObj;

	[Token(Token = "0x4003C30")]
	[FieldOffset(Offset = "0x290")]
	public UILabel m_ShareExperiencePopupLabel;

	[Header("DLC References")]
	[SerializeField]
	[Token(Token = "0x4003C31")]
	[FieldOffset(Offset = "0x298")]
	private OptionalContentConfig m_ExpansionPassConfig;

	[Token(Token = "0x4003C32")]
	[FieldOffset(Offset = "0x2A0")]
	private CustomExperienceMode m_CustomMode;

	[Token(Token = "0x4003C33")]
	[FieldOffset(Offset = "0x2A8")]
	private int m_CustomXPSelectedButtonIndex;

	[Token(Token = "0x4003C34")]
	[FieldOffset(Offset = "0x2B0")]
	private string m_CachedCustomModeString;

	[Token(Token = "0x4003C35")]
	[FieldOffset(Offset = "0x2B8")]
	private uint m_CachedMaxLength;

	[Token(Token = "0x4003C36")]
	[FieldOffset(Offset = "0x2C0")]
	private string m_CachedKeyboardDesc;

	[Token(Token = "0x4003C37")]
	[FieldOffset(Offset = "0x2C8")]
	private Vector2 m_MousePositionLastFrame;

	[Token(Token = "0x4003C38")]
	[FieldOffset(Offset = "0x2D0")]
	private float m_ScrollPanelHeight;

	[Token(Token = "0x4003C39")]
	private static readonly string[] m_XPModeStringList;

	[Token(Token = "0x4003C3A")]
	private static readonly string[] m_StartTODStringList;

	[Token(Token = "0x4003C3B")]
	private static readonly string[] m_StartWeatherStringList;

	[Token(Token = "0x4003C3C")]
	private static readonly string[] m_YesNoStringList;

	[Token(Token = "0x4003C3D")]
	private static readonly string[] m_DayNightMultiplierStringList;

	[Token(Token = "0x4003C3E")]
	private static readonly string[] m_DistanceStringList;

	[Token(Token = "0x4003C3F")]
	private static readonly string[] m_TunableLMHStringList;

	[Token(Token = "0x4003C40")]
	private static readonly string[] m_TunableNLHStringList;

	[Token(Token = "0x4003C41")]
	private static readonly string[] m_TunableOMHStringList;

	[Token(Token = "0x4003C42")]
	private static readonly string[] m_TunableLMHVStringList;

	[Token(Token = "0x4003C43")]
	private static readonly string[] m_TunableNLMHStringList;

	[Token(Token = "0x4003C44")]
	private static readonly string[] m_TunableNLMHVStringList;

	[Token(Token = "0x4003C45")]
	[FieldOffset(Offset = "0x2D4")]
	private bool m_HasDLC;

	[Token(Token = "0x6003252")]
	[Address(RVA = "0x9E7B90", Offset = "0x9E6990", Length = "0x158")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003253")]
	[Address(RVA = "0x9E7CF0", Offset = "0x9E6AF0", Length = "0x491")]
	private void Update()
	{
	}

	[Token(Token = "0x6003254")]
	[Address(RVA = "0x9E8190", Offset = "0x9E6F90", Length = "0x4B")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003255")]
	[Address(RVA = "0x9E81E0", Offset = "0x9E6FE0", Length = "0x173")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003256")]
	[Address(RVA = "0x9E8360", Offset = "0x9E7160", Length = "0x310")]
	public void OnContinue()
	{
	}

	[Token(Token = "0x6003257")]
	[Address(RVA = "0x9E8680", Offset = "0x9E7480", Length = "0x128")]
	public void OnShareExperiencePopup()
	{
	}

	[Token(Token = "0x6003258")]
	[Address(RVA = "0x9E87B0", Offset = "0x9E75B0", Length = "0x31F")]
	public void OnEnterCode()
	{
	}

	[Token(Token = "0x6003259")]
	[Address(RVA = "0x9E8AD0", Offset = "0x9E78D0", Length = "0x131")]
	public void OnEnterCodePopupConfirmed()
	{
	}

	[Token(Token = "0x600325A")]
	[Address(RVA = "0x9E8C10", Offset = "0x9E7A10", Length = "0x105")]
	public void OnEnterCodePopupCancelled(bool wasCancelled)
	{
	}

	[Token(Token = "0x600325B")]
	[Address(RVA = "0x9E8D20", Offset = "0x9E7B20", Length = "0x55")]
	public void OnScrollbarChange()
	{
	}

	[Token(Token = "0x600325C")]
	[Address(RVA = "0x9E8D80", Offset = "0x9E7B80", Length = "0xCC")]
	private string AddDashesToCustomModeString(string customString)
	{
		return null;
	}

	[Token(Token = "0x600325D")]
	[Address(RVA = "0x9E8E50", Offset = "0x9E7C50", Length = "0x6EA")]
	public void SetUIFromCurrentCustomXP()
	{
	}

	[Token(Token = "0x600325E")]
	[Address(RVA = "0x9E9540", Offset = "0x9E8340", Length = "0x7A")]
	private void SetCustomModeString(string modeString)
	{
	}

	[Token(Token = "0x600325F")]
	[Address(RVA = "0x9E95C0", Offset = "0x9E83C0", Length = "0x15F")]
	private void DoScroll(float scrollAmount)
	{
	}

	[Token(Token = "0x6003260")]
	[Address(RVA = "0x9E9720", Offset = "0x9E8520", Length = "0x2B6")]
	private void UpdateSlider()
	{
	}

	[Token(Token = "0x6003261")]
	[Address(RVA = "0x9E99E0", Offset = "0x9E87E0", Length = "0x1B9")]
	private void UpdateButtonLegendMainScreen()
	{
	}

	[Token(Token = "0x6003262")]
	[Address(RVA = "0x9E9BA0", Offset = "0x9E89A0", Length = "0x9D")]
	private void UpdateButtonLegendSharePopup()
	{
	}

	[Token(Token = "0x6003263")]
	[Address(RVA = "0x9E9C40", Offset = "0x9E8A40", Length = "0xF13")]
	private void SetCustomXPSettingsFromUI()
	{
	}

	[Token(Token = "0x6003264")]
	[Address(RVA = "0x9EAB60", Offset = "0x9E9960", Length = "0x1727")]
	private void InitializeCustomXPMenuItems()
	{
	}

	[Token(Token = "0x6003265")]
	[Address(RVA = "0x9EC290", Offset = "0x9EB090", Length = "0xC3")]
	private void SetValuesToMatchXPMode()
	{
	}

	[Token(Token = "0x6003266")]
	[Address(RVA = "0x9EC360", Offset = "0x9EB160", Length = "0x106")]
	private void SetXPModePopupListString()
	{
	}

	[Token(Token = "0x6003267")]
	[Address(RVA = "0x9EC470", Offset = "0x9EB270", Length = "0x1F")]
	private void UpdateAfterTunableChange()
	{
	}

	[Token(Token = "0x6003268")]
	[Address(RVA = "0x9EC490", Offset = "0x9EB290", Length = "0x203")]
	private void ResetToDefault()
	{
	}

	[Token(Token = "0x6003269")]
	[Address(RVA = "0x9EC6A0", Offset = "0x9EB4A0", Length = "0x16A7")]
	private void UpdateMenuNavigation(ref int index, List<GameObject> menuItems)
	{
	}

	[Token(Token = "0x600326A")]
	[Address(RVA = "0x9EDD50", Offset = "0x9ECB50", Length = "0x130")]
	private void SetConsoleComboBoxIndex(ConsoleComboBox comboBox, int index)
	{
	}

	[Token(Token = "0x600326B")]
	[Address(RVA = "0x9EDE90", Offset = "0x9ECC90", Length = "0x2D4")]
	private void DoMainScreenControls()
	{
	}

	[Token(Token = "0x600326C")]
	[Address(RVA = "0x9EE170", Offset = "0x9ECF70", Length = "0x23")]
	private void RefreshEndlessNightOption()
	{
	}

	[Token(Token = "0x600326D")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	private bool IsEndlessNightOptionUnlocked()
	{
		return false;
	}

	[Token(Token = "0x600326E")]
	[Address(RVA = "0x9EE1A0", Offset = "0x9ECFA0", Length = "0xD2")]
	public Panel_CustomXPSetup()
	{
	}
}
