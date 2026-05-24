using System;
using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x20006B6")]
public class Panel_Rest : Panel_AutoReferenced, IAccelerateTimeProvider
{
	[Header("Time Widget")]
	[Token(Token = "0x4004771")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_TimeWidgetPos;

	[Token(Token = "0x4004772")]
	[FieldOffset(Offset = "0x38")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4004773")]
	[FieldOffset(Offset = "0x40")]
	public int m_MaxSleepHours;

	[Token(Token = "0x4004774")]
	[FieldOffset(Offset = "0x44")]
	public int m_MinSleepHours;

	[Token(Token = "0x4004775")]
	[FieldOffset(Offset = "0x48")]
	public int m_DefaultSleepHours;

	[Token(Token = "0x4004776")]
	[FieldOffset(Offset = "0x50")]
	public Transform m_OffsetTransform;

	[Token(Token = "0x4004777")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 m_OffsetValueController;

	[Token(Token = "0x4004778")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_RestDurationLabel;

	[Token(Token = "0x4004779")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_WakeTimeLabel;

	[Token(Token = "0x400477A")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_EstimatedCaloriesBurnedLabel;

	[Token(Token = "0x400477B")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_CurrentCaloriesLabel;

	[Token(Token = "0x400477C")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_WarmthBonusLabel;

	[Token(Token = "0x400477D")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_WarmthBonusValLabel;

	[Token(Token = "0x400477E")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_RestOnlyObject;

	[Token(Token = "0x400477F")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_PassTimeOnlyObject;

	[Token(Token = "0x4004780")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_PassTimeNavButtons;

	[Token(Token = "0x4004781")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_PassTimeButtonObject;

	[Token(Token = "0x4004782")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_PassTimeCancelButtonObject;

	[Token(Token = "0x4004783")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject[] m_ObjectsToDisableDuringPassTime;

	[Token(Token = "0x4004784")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_RestNavButtons;

	[Token(Token = "0x4004785")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_SleepButton;

	[Token(Token = "0x4004786")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject m_PickUpButton;

	[Token(Token = "0x4004787")]
	[FieldOffset(Offset = "0xE0")]
	public UIButton m_DefaultSelectedButton;

	[Tooltip("If fatigue is below this below, the player cannot rest unless an affliction requires it")]
	[Token(Token = "0x4004788")]
	[FieldOffset(Offset = "0xE8")]
	public float m_AllowRestFatigueThreshold;

	[Token(Token = "0x4004789")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel m_TemperatureLabel;

	[Token(Token = "0x400478A")]
	[FieldOffset(Offset = "0xF8")]
	public UILabel m_ConditionLabel;

	[Token(Token = "0x400478B")]
	[FieldOffset(Offset = "0x100")]
	public UILabel m_ConditionDebuffLabel;

	[Token(Token = "0x400478C")]
	[FieldOffset(Offset = "0x108")]
	public UILabel m_CalorieReservesLabel;

	[Token(Token = "0x400478D")]
	[FieldOffset(Offset = "0x110")]
	public Color m_NegativeTemperatureColor;

	[Token(Token = "0x400478E")]
	[FieldOffset(Offset = "0x120")]
	private int m_SleepHours;

	[Token(Token = "0x400478F")]
	[FieldOffset(Offset = "0x124")]
	private int m_CurrentMaxSleepHours;

	[Token(Token = "0x4004790")]
	[FieldOffset(Offset = "0x128")]
	private int m_CurrentTimeHours;

	[Token(Token = "0x4004791")]
	[FieldOffset(Offset = "0x12C")]
	private int m_CurrentTimeMinutes;

	[Token(Token = "0x4004792")]
	[FieldOffset(Offset = "0x130")]
	private Bed m_Bed;

	[Token(Token = "0x4004793")]
	[FieldOffset(Offset = "0x138")]
	private bool m_SkipRestoreItemInHandsOnExit;

	[Token(Token = "0x4004794")]
	[FieldOffset(Offset = "0x139")]
	private bool m_ShowPassTime;

	[Token(Token = "0x4004795")]
	[FieldOffset(Offset = "0x13A")]
	private bool m_ShowPassTimeOnly;

	[Token(Token = "0x4004796")]
	[FieldOffset(Offset = "0x13B")]
	private bool m_ShowUIDuringPassTime;

	[Token(Token = "0x4004797")]
	[FieldOffset(Offset = "0x13C")]
	private Vector3 m_SleepButtonOrigPos;

	[Token(Token = "0x4004798")]
	[FieldOffset(Offset = "0x148")]
	private Vector3 m_SleepButtonCenteredPos;

	[Token(Token = "0x4004799")]
	[FieldOffset(Offset = "0x154")]
	private bool m_PassTimeIsAllowed;

	[Token(Token = "0x400479A")]
	[FieldOffset(Offset = "0x158")]
	public GameObject m_ButtonIncrease;

	[Token(Token = "0x400479B")]
	[FieldOffset(Offset = "0x160")]
	public GameObject m_ButtonDecrease;

	[Token(Token = "0x400479C")]
	[FieldOffset(Offset = "0x168")]
	private ButtonLegendConfigure[] m_ButtonLegendConfigureArray_Rest;

	[Token(Token = "0x400479D")]
	[FieldOffset(Offset = "0x170")]
	private ButtonLegendConfigure[] m_ButtonLegendConfigureArray_PassTime;

	[Token(Token = "0x6003AB7")]
	[Address(RVA = "0xB4D980", Offset = "0xB4C780", Length = "0x26D")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003AB8")]
	[Address(RVA = "0xB4DBF0", Offset = "0xB4C9F0", Length = "0x4A2")]
	private void Update()
	{
	}

	[Token(Token = "0x6003AB9")]
	[Address(RVA = "0xB4E0A0", Offset = "0xB4CEA0", Length = "0x8F1")]
	private void UpdateVisuals()
	{
	}

	[Token(Token = "0x6003ABA")]
	[Address(RVA = "0xB4E9A0", Offset = "0xB4D7A0", Length = "0x67")]
	public void StartRest(Bed b)
	{
	}

	[Token(Token = "0x6003ABB")]
	[Address(RVA = "0xB4EA10", Offset = "0xB4D810", Length = "0xB")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003ABC")]
	[Address(RVA = "0xB4EA20", Offset = "0xB4D820", Length = "0x7C3")]
	public void Enable(bool enable, bool passTimeOnly)
	{
	}

	[Token(Token = "0x6003ABD")]
	[Address(RVA = "0xB4F1F0", Offset = "0xB4DFF0", Length = "0x7")]
	public void SetPassTimeAllowed(bool allowed)
	{
	}

	[Token(Token = "0x6003ABE")]
	[Address(RVA = "0xB4F200", Offset = "0xB4E000", Length = "0x8")]
	public bool GetPassTimeAllowed()
	{
		return false;
	}

	[Token(Token = "0x6003ABF")]
	[Address(RVA = "0xB4F210", Offset = "0xB4E010", Length = "0x93")]
	private int GetAdjustedMaxSleep()
	{
		return 0;
	}

	[Token(Token = "0x6003AC0")]
	[Address(RVA = "0xB4F2B0", Offset = "0xB4E0B0", Length = "0xCE")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003AC1")]
	[Address(RVA = "0xB4F380", Offset = "0xB4E180", Length = "0x8F")]
	public bool IsPassingTimeOnly()
	{
		return false;
	}

	[Token(Token = "0x6003AC2")]
	[Address(RVA = "0xB4F410", Offset = "0xB4E210", Length = "0x88")]
	public void OnSelectRest()
	{
	}

	[Token(Token = "0x6003AC3")]
	[Address(RVA = "0xB4F4A0", Offset = "0xB4E2A0", Length = "0x88")]
	public void OnSelectPassTime()
	{
	}

	[Token(Token = "0x6003AC4")]
	[Address(RVA = "0xB4F530", Offset = "0xB4E330", Length = "0x11")]
	public void OnRest()
	{
	}

	[Token(Token = "0x6003AC5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void OnFullRest()
	{
	}

	[Token(Token = "0x6003AC6")]
	[Address(RVA = "0xB4F550", Offset = "0xB4E350", Length = "0x13")]
	public void OnPassTime()
	{
	}

	[Token(Token = "0x6003AC7")]
	[Address(RVA = "0xB4F570", Offset = "0xB4E370", Length = "0xBD")]
	public bool DoPassTime(float sleepHours)
	{
		return false;
	}

	[Token(Token = "0x6003AC8")]
	[Address(RVA = "0xB4F630", Offset = "0xB4E430", Length = "0x31B")]
	public void OnPickUp()
	{
	}

	[Token(Token = "0x6003AC9")]
	[Address(RVA = "0xB4F950", Offset = "0xB4E750", Length = "0x86")]
	public void OnIncreaseHours()
	{
	}

	[Token(Token = "0x6003ACA")]
	[Address(RVA = "0xB4F9E0", Offset = "0xB4E7E0", Length = "0x83")]
	public void OnDecreaseHours()
	{
	}

	[Token(Token = "0x6003ACB")]
	[Address(RVA = "0xB4FA70", Offset = "0xB4E870", Length = "0x360")]
	public static bool CheckPassTimeErrorMessage()
	{
		return false;
	}

	[Token(Token = "0x6003ACC")]
	[Address(RVA = "0xB4FDE0", Offset = "0xB4EBE0", Length = "0x77")]
	private void UpdateRestDurationLabel()
	{
	}

	[Token(Token = "0x6003ACD")]
	[Address(RVA = "0xB4FE60", Offset = "0xB4EC60", Length = "0x71")]
	private void UpdateWakeTimeLabel()
	{
	}

	[Token(Token = "0x6003ACE")]
	[Address(RVA = "0xB4FEE0", Offset = "0xB4ECE0", Length = "0x278")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[Token(Token = "0x6003ACF")]
	[Address(RVA = "0xB50160", Offset = "0xB4EF60", Length = "0x24E")]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[Token(Token = "0x6003AD0")]
	[Address(RVA = "0xB503B0", Offset = "0xB4F1B0", Length = "0x1E0")]
	private void UpdateFeelsLikeLabel()
	{
	}

	[Token(Token = "0x6003AD1")]
	[Address(RVA = "0xB505A0", Offset = "0xB4F3A0", Length = "0x340")]
	private void UpdateWarmthBonusLabel()
	{
	}

	[Token(Token = "0x6003AD2")]
	[Address(RVA = "0xB508F0", Offset = "0xB4F6F0", Length = "0x560")]
	private void DoRest(int restAmount, bool wakeUpAtFullRest)
	{
	}

	[Token(Token = "0x6003AD3")]
	[Address(RVA = "0xB50E60", Offset = "0xB4FC60", Length = "0x4EF")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003AD4")]
	[Address(RVA = "0xB51350", Offset = "0xB50150", Length = "0x116")]
	private void RefreshButtonConfigure(ButtonLegendConfigure[] buttonLegendConfigureArray)
	{
	}

	[Token(Token = "0x6003AD5")]
	[Address(RVA = "0xB51470", Offset = "0xB50270", Length = "0x12A")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x6003AD6")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x6003AD7")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6003AD8")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x6003AD9")]
	[Address(RVA = "0xB515A0", Offset = "0xB503A0", Length = "0x71")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x6003ADA")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x6003ADB")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x6003ADC")]
	[Address(RVA = "0xB51620", Offset = "0xB50420", Length = "0xC3")]
	public Panel_Rest()
	{
	}
}
