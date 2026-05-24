using AK.Wwise;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200065A")]
public class Panel_GenericProgressBar : Panel_AutoReferenced
{
	[Token(Token = "0x4003DE6")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003DE7")]
	[FieldOffset(Offset = "0x38")]
	public OnExitDelegate m_handler;

	[Token(Token = "0x4003DE8")]
	[FieldOffset(Offset = "0x40")]
	public Color m_FailedColor;

	[Token(Token = "0x4003DE9")]
	[FieldOffset(Offset = "0x50")]
	public UISprite m_SpriteForground;

	[Token(Token = "0x4003DEA")]
	[FieldOffset(Offset = "0x58")]
	public Transform m_CenterLocation;

	[Token(Token = "0x4003DEB")]
	[FieldOffset(Offset = "0x60")]
	public Transform m_GearItemLocation;

	[Token(Token = "0x4003DEC")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_EatingObjects;

	[Token(Token = "0x4003DED")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_DrinkingObjects;

	[Token(Token = "0x4003DEE")]
	[FieldOffset(Offset = "0x78")]
	public UIWidget m_StatusBarWidget;

	[Token(Token = "0x4003DEF")]
	[FieldOffset(Offset = "0x80")]
	public float m_StatusBarFadeTime;

	[Token(Token = "0x4003DF0")]
	[FieldOffset(Offset = "0x88")]
	public UISlider m_Slider;

	[Header("Alternates when subtitles are visible")]
	[Token(Token = "0x4003DF1")]
	[FieldOffset(Offset = "0x90")]
	public UIWidget m_SubtitleAltStatusBarWidget;

	[Token(Token = "0x4003DF2")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_SubtitleAltEatingObjects;

	[Token(Token = "0x4003DF3")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_SubtitleAltDrinkingObjects;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003DF4")]
	[FieldOffset(Offset = "0xA8")]
	private PanelReference<Panel_Diagnosis> m_Diagnosis;

	[SerializeField]
	[Token(Token = "0x4003DF5")]
	[FieldOffset(Offset = "0xB0")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x4003DF6")]
	[FieldOffset(Offset = "0xB8")]
	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	[SerializeField]
	[Token(Token = "0x4003DF7")]
	[FieldOffset(Offset = "0xC0")]
	private PanelReference<Panel_Repair> m_Repair;

	[SerializeField]
	[Token(Token = "0x4003DF8")]
	[FieldOffset(Offset = "0xC8")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x4003DF9")]
	[FieldOffset(Offset = "0xD0")]
	private Color m_OriginalColor;

	[Token(Token = "0x4003DFA")]
	[FieldOffset(Offset = "0xE0")]
	private float m_RandomFailureThreshold;

	[Token(Token = "0x4003DFB")]
	[FieldOffset(Offset = "0xE4")]
	private float m_ProgressBarDurationSeconds;

	[Token(Token = "0x4003DFC")]
	[FieldOffset(Offset = "0xE8")]
	private float m_ProgressBarElapsedSeconds;

	[Token(Token = "0x4003DFD")]
	[FieldOffset(Offset = "0xEC")]
	private bool m_DisplayFailMessage;

	[Token(Token = "0x4003DFE")]
	[FieldOffset(Offset = "0xF0")]
	private float m_DisplayFailMessageTime;

	[Token(Token = "0x4003DFF")]
	[FieldOffset(Offset = "0xF4")]
	private float m_DisplayFailMessageLifetime;

	[Token(Token = "0x4003E00")]
	[FieldOffset(Offset = "0xF8")]
	private uint m_AudioID;

	[Token(Token = "0x4003E01")]
	[FieldOffset(Offset = "0xFC")]
	private uint m_VoiceID;

	[Token(Token = "0x4003E02")]
	[FieldOffset(Offset = "0x100")]
	private bool m_SkipRestoreInHands;

	[Token(Token = "0x4003E03")]
	[FieldOffset(Offset = "0x101")]
	private bool m_TimeAccelerated;

	[Token(Token = "0x4003E04")]
	[FieldOffset(Offset = "0x104")]
	private float m_DayLengthScaleOriginal;

	[Token(Token = "0x4003E05")]
	[FieldOffset(Offset = "0x108")]
	private float m_DayLengthScaleAccelerated;

	[Token(Token = "0x4003E06")]
	[FieldOffset(Offset = "0x110")]
	private UILabel m_ProgressBarNameLabel;

	[Token(Token = "0x4003E07")]
	[FieldOffset(Offset = "0x118")]
	private float m_StatusBarFadeTimeRemaining;

	[Token(Token = "0x4003E08")]
	[FieldOffset(Offset = "0x11C")]
	private bool m_ShowedHungerThisCycle;

	[Token(Token = "0x4003E09")]
	[FieldOffset(Offset = "0x11D")]
	private bool m_ShowedThirstThisCycle;

	[Token(Token = "0x4003E0A")]
	[FieldOffset(Offset = "0x11E")]
	private bool m_MarkForCancel;

	[Token(Token = "0x60033FC")]
	[Address(RVA = "0xA53BD0", Offset = "0xA529D0", Length = "0x114")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60033FD")]
	[Address(RVA = "0xA53CF0", Offset = "0xA52AF0", Length = "0x27A")]
	private void Update()
	{
	}

	[Token(Token = "0x60033FE")]
	[Address(RVA = "0xA53F70", Offset = "0xA52D70", Length = "0x4B7")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60033FF")]
	[Address(RVA = "0xA54430", Offset = "0xA53230", Length = "0x12")]
	public bool IsFadingOutStatusBars()
	{
		return false;
	}

	[Token(Token = "0x6003400")]
	[Address(RVA = "0xA54450", Offset = "0xA53250", Length = "0x26")]
	public void ForceFadeOutComplete()
	{
	}

	[Token(Token = "0x6003401")]
	[Address(RVA = "0xA54480", Offset = "0xA53280", Length = "0x17E")]
	public void Launch(string name, float seconds, float minutes, float randomFailureThreshold, AK.Wwise.Event audioEvent, AK.Wwise.Event voiceName, bool supressHeavyBreathing, bool skipRestoreInHands, OnExitDelegate del)
	{
	}

	[Token(Token = "0x6003402")]
	[Address(RVA = "0xA54600", Offset = "0xA53400", Length = "0x15E")]
	public void Launch(string name, float seconds, float minutes, float randomFailureThreshold, string audioName, string voiceName, bool supressHeavyBreathing, bool skipRestoreInHands, OnExitDelegate del)
	{
	}

	[Token(Token = "0x6003403")]
	[Address(RVA = "0xA54760", Offset = "0xA53560", Length = "0x344")]
	private void Launch(string name, float seconds, float minutes, float randomFailureThreshold, bool skipRestoreInHands, OnExitDelegate del)
	{
	}

	[Token(Token = "0x6003404")]
	[Address(RVA = "0xA54AB0", Offset = "0xA538B0", Length = "0x155")]
	private void PlayAudio(AK.Wwise.Event audioEvent, string voiceName, bool supressHeavyBreathing)
	{
	}

	[Token(Token = "0x6003405")]
	[Address(RVA = "0xA54C10", Offset = "0xA53A10", Length = "0x155")]
	private void PlayAudio(AK.Wwise.Event audioEvent, AK.Wwise.Event voiceName, bool supressHeavyBreathing)
	{
	}

	[Token(Token = "0x6003406")]
	[Address(RVA = "0xA54D70", Offset = "0xA53B70", Length = "0x13B")]
	private void PlayAudio(string audioName, string voiceName, bool supressHeavyBreathing)
	{
	}

	[Token(Token = "0x6003407")]
	[Address(RVA = "0xA54EB0", Offset = "0xA53CB0", Length = "0x8")]
	public void MarkForCancel()
	{
	}

	[Token(Token = "0x6003408")]
	[Address(RVA = "0xA54EC0", Offset = "0xA53CC0", Length = "0x31")]
	public void Cancel()
	{
	}

	[Token(Token = "0x6003409")]
	[Address(RVA = "0xA54F00", Offset = "0xA53D00", Length = "0x21")]
	public void SetNameLabel(string name)
	{
	}

	[Token(Token = "0x600340A")]
	[Address(RVA = "0xA54F30", Offset = "0xA53D30", Length = "0x52")]
	public float GetSliderValue()
	{
		return 0f;
	}

	[Token(Token = "0x600340B")]
	[Address(RVA = "0xA54F90", Offset = "0xA53D90", Length = "0xA4")]
	public bool IsPaused()
	{
		return false;
	}

	[Token(Token = "0x600340C")]
	[Address(RVA = "0xA55040", Offset = "0xA53E40", Length = "0x8E")]
	public void Pause()
	{
	}

	[Token(Token = "0x600340D")]
	[Address(RVA = "0xA550D0", Offset = "0xA53ED0", Length = "0x8E")]
	public void Resume()
	{
	}

	[Token(Token = "0x600340E")]
	[Address(RVA = "0xA55160", Offset = "0xA53F60", Length = "0x173")]
	public bool CanUserCancelAction()
	{
		return false;
	}

	[Token(Token = "0x600340F")]
	[Address(RVA = "0xA552E0", Offset = "0xA540E0", Length = "0x210")]
	private void InitializeProgressBar()
	{
	}

	[Token(Token = "0x6003410")]
	[Address(RVA = "0xA55500", Offset = "0xA54300", Length = "0x73")]
	private void StopProgressBarAudio()
	{
	}

	[Token(Token = "0x6003411")]
	[Address(RVA = "0xA55580", Offset = "0xA54380", Length = "0x20E")]
	private void ProgressBarEnded(bool success, bool playerCancel)
	{
	}

	[Token(Token = "0x6003412")]
	[Address(RVA = "0xA55790", Offset = "0xA54590", Length = "0x374")]
	private void UpdateProgressBarInterface()
	{
	}

	[Token(Token = "0x6003413")]
	[Address(RVA = "0xA55B10", Offset = "0xA54910", Length = "0x47D")]
	private void UpdateActiveBars()
	{
	}

	[Token(Token = "0x6003414")]
	[Address(RVA = "0xA55F90", Offset = "0xA54D90", Length = "0x77")]
	private void RestoreTimeOfDay()
	{
	}

	[Token(Token = "0x6003415")]
	[Address(RVA = "0xA56010", Offset = "0xA54E10", Length = "0xDB")]
	private void AccelerateTimeOfDay(float seconds, float minutes)
	{
	}

	[Token(Token = "0x6003416")]
	[Address(RVA = "0xA560F0", Offset = "0xA54EF0", Length = "0x75")]
	private void ResumeAcceleratedTimeOfDay()
	{
	}

	[Token(Token = "0x6003417")]
	[Address(RVA = "0xA56170", Offset = "0xA54F70", Length = "0x75")]
	private void PauseAcceleratedTimeOfDay()
	{
	}

	[Token(Token = "0x6003418")]
	[Address(RVA = "0xA561F0", Offset = "0xA54FF0", Length = "0xAC")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003419")]
	[Address(RVA = "0xA562A0", Offset = "0xA550A0", Length = "0x59")]
	private void SetStatusBarWidgetAlpha(float alpha)
	{
	}

	[Token(Token = "0x600341A")]
	[Address(RVA = "0xA56300", Offset = "0xA55100", Length = "0xC3")]
	public Panel_GenericProgressBar()
	{
	}
}
