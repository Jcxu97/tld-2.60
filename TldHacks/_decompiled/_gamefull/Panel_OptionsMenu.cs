using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.SaveState;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006A8")]
public class Panel_OptionsMenu : Panel_AutoReferenced
{
	[Token(Token = "0x20006A9")]
	private enum ControllerDiagram
	{
		[Token(Token = "0x40046CE")]
		Unknown,
		[Token(Token = "0x40046CF")]
		Xbox,
		[Token(Token = "0x40046D0")]
		Steam,
		[Token(Token = "0x40046D1")]
		PS4,
		[Token(Token = "0x40046D2")]
		PS5,
		[Token(Token = "0x40046D3")]
		Switch
	}

	[Serializable]
	[Token(Token = "0x20006AA")]
	public class OptionTopMenuItem
	{
		[Token(Token = "0x20006AB")]
		public enum MenuType
		{
			[Token(Token = "0x40046D7")]
			Accessibility,
			[Token(Token = "0x40046D8")]
			Display,
			[Token(Token = "0x40046D9")]
			Quality,
			[Token(Token = "0x40046DA")]
			Brightness,
			[Token(Token = "0x40046DB")]
			Audio,
			[Token(Token = "0x40046DC")]
			Controls,
			[Token(Token = "0x40046DD")]
			KeyBinding,
			[Token(Token = "0x40046DE")]
			Autosave,
			[Token(Token = "0x40046DF")]
			Privacy,
			[Token(Token = "0x40046E0")]
			ControlDiagram,
			[Token(Token = "0x40046E1")]
			Visuals,
			[Token(Token = "0x40046E2")]
			AdvancedVisuals
		}

		[Token(Token = "0x40046D4")]
		[FieldOffset(Offset = "0x10")]
		public MenuType m_Type;

		[Token(Token = "0x40046D5")]
		[FieldOffset(Offset = "0x18")]
		public string m_LabelLocalizationId;

		[Token(Token = "0x6003A36")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public OptionTopMenuItem()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x20006AC")]
	private sealed class _003CStartForceTempResolutionChangeCo_003Ed__273 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40046E3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40046E4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40046E5")]
		[FieldOffset(Offset = "0x20")]
		private Panel_OptionsMenu _003Cpanel_003E5__2;

		[Token(Token = "0x17000307")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003A3A")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000308")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003A3C")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6003A37")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CStartForceTempResolutionChangeCo_003Ed__273(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6003A38")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6003A39")]
		[Address(RVA = "0xB3FDA0", Offset = "0xB3EBA0", Length = "0x242")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x6003A3B")]
		[Address(RVA = "0xB3FFF0", Offset = "0xB3EDF0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Accessibility")]
	[Token(Token = "0x4004609")]
	[FieldOffset(Offset = "0x30")]
	public ConsoleComboBox m_InteractionTypePopupList;

	[Token(Token = "0x400460A")]
	[FieldOffset(Offset = "0x38")]
	public ConsoleComboBox m_ReduceCameraMotionPopupList;

	[Token(Token = "0x400460B")]
	[FieldOffset(Offset = "0x40")]
	public ConsoleComboBox m_SubtitleSizePopupList;

	[Token(Token = "0x400460C")]
	[FieldOffset(Offset = "0x48")]
	public ConsoleComboBox m_StruggleTypePopupList;

	[Token(Token = "0x400460D")]
	[FieldOffset(Offset = "0x50")]
	public ConsoleComboBox m_AutoRunPopupList;

	[Token(Token = "0x400460E")]
	[FieldOffset(Offset = "0x58")]
	public ConsoleComboBox m_MisophoniaFilterPopupList;

	[Token(Token = "0x400460F")]
	[FieldOffset(Offset = "0x60")]
	public ConsoleComboBox m_SwearFilterPopupList;

	[Token(Token = "0x4004610")]
	[FieldOffset(Offset = "0x68")]
	public LocalizedString m_InteractionTypeSwitchString;

	[Token(Token = "0x4004611")]
	[FieldOffset(Offset = "0x70")]
	private int m_AccessibilitySelectedButtonIndex;

	[Token(Token = "0x4004612")]
	[FieldOffset(Offset = "0x74")]
	private int m_NumFramesInAccessibilityTab;

	[Token(Token = "0x4004613")]
	[FieldOffset(Offset = "0x78")]
	private List<GameObject> m_AccessibilityMenuItems;

	[Header("Advanced Visuals")]
	[SerializeField]
	[Token(Token = "0x4004614")]
	[FieldOffset(Offset = "0x80")]
	private ConsoleSlider m_RockDrawDistanceSlider;

	[SerializeField]
	[Token(Token = "0x4004615")]
	[FieldOffset(Offset = "0x88")]
	private ConsoleSlider m_SceneDrawDistanceSlider;

	[SerializeField]
	[Token(Token = "0x4004616")]
	[FieldOffset(Offset = "0x90")]
	private ConsoleSlider m_ShadowDrawDistanceSlider;

	[SerializeField]
	[Token(Token = "0x4004617")]
	[FieldOffset(Offset = "0x98")]
	private ConsoleSlider m_TerrainDetailsDrawDistanceSlider;

	[SerializeField]
	[Token(Token = "0x4004618")]
	[FieldOffset(Offset = "0xA0")]
	private ConsoleSlider m_TerrainDetailsDensitySlider;

	[SerializeField]
	[Token(Token = "0x4004619")]
	[FieldOffset(Offset = "0xA8")]
	private ConsoleSlider m_TreeDrawDistanceSlider;

	[SerializeField]
	[Token(Token = "0x400461A")]
	[FieldOffset(Offset = "0xB0")]
	private ConsoleComboBox m_AdditionalShadowsStructuresPopupList;

	[SerializeField]
	[Token(Token = "0x400461B")]
	[FieldOffset(Offset = "0xB8")]
	private ConsoleComboBox m_AdditionalShadowsTerrainPopupList;

	[SerializeField]
	[Token(Token = "0x400461C")]
	[FieldOffset(Offset = "0xC0")]
	private ConsoleComboBox m_TerrainBlendingPopupList;

	[Token(Token = "0x400461D")]
	[FieldOffset(Offset = "0xC8")]
	private int m_AdvancedVisualsSelectedButtonIndex;

	[Token(Token = "0x400461E")]
	[FieldOffset(Offset = "0xD0")]
	private readonly List<GameObject> m_AdvancedVisualsMenuItems;

	[Token(Token = "0x400461F")]
	[FieldOffset(Offset = "0xD8")]
	private int m_NumFramesInAdvancedVisualsTab;

	[Token(Token = "0x4004620")]
	private const int FIXED_SLIDER_STEPS = 101;

	[Header("Audio")]
	[Token(Token = "0x4004621")]
	[FieldOffset(Offset = "0xE0")]
	public ConsoleSlider m_MasterSlider;

	[Token(Token = "0x4004622")]
	[FieldOffset(Offset = "0xE8")]
	public ConsoleSlider m_SoundSlider;

	[Token(Token = "0x4004623")]
	[FieldOffset(Offset = "0xF0")]
	public ConsoleSlider m_MusicSlider;

	[Token(Token = "0x4004624")]
	[FieldOffset(Offset = "0xF8")]
	public ConsoleSlider m_VoiceSlider;

	[Token(Token = "0x4004625")]
	[FieldOffset(Offset = "0x100")]
	public ConsoleComboBox m_PanningRuleList;

	[Token(Token = "0x4004626")]
	[FieldOffset(Offset = "0x108")]
	public float m_MasterVolumeDefault;

	[Token(Token = "0x4004627")]
	[FieldOffset(Offset = "0x10C")]
	public float m_SoundVolumeDefault;

	[Token(Token = "0x4004628")]
	[FieldOffset(Offset = "0x110")]
	public float m_MusicVolumeDefault;

	[Token(Token = "0x4004629")]
	[FieldOffset(Offset = "0x114")]
	public float m_VoiceVolumeDefault;

	[Token(Token = "0x400462A")]
	[FieldOffset(Offset = "0x118")]
	public PanningRule m_PanningRuleDefault;

	[Token(Token = "0x400462B")]
	private const string PANNING_RULE_HEADPHONES = "GAMEPLAY_PanningRuleHeadphones";

	[Token(Token = "0x400462C")]
	private const string PANNING_RULE_SPEAKERS = "GAMEPLAY_PanningRuleSpeakers";

	[Token(Token = "0x400462D")]
	[FieldOffset(Offset = "0x11C")]
	private int m_AudioSelectedButtonIndex;

	[Token(Token = "0x400462E")]
	[FieldOffset(Offset = "0x120")]
	private int m_NumFramesInAudioTab;

	[Token(Token = "0x400462F")]
	[FieldOffset(Offset = "0x128")]
	private List<GameObject> m_AudioMenuItems;

	[Header("Autosave")]
	[Token(Token = "0x4004630")]
	[FieldOffset(Offset = "0x130")]
	public ConsoleSlider m_AutosaveMinutesSlider;

	[Header("Autosave Minutes Slider Ranges")]
	[Range(1f, 1500f)]
	[Token(Token = "0x4004631")]
	[FieldOffset(Offset = "0x138")]
	public float m_AutosaveMinutesDefault;

	[Range(1f, 1500f)]
	[Token(Token = "0x4004632")]
	[FieldOffset(Offset = "0x13C")]
	public float m_AutosaveMinutesMin;

	[Range(1f, 1500f)]
	[Token(Token = "0x4004633")]
	[FieldOffset(Offset = "0x140")]
	public float m_AutosaveMinutesMax;

	[Token(Token = "0x4004634")]
	[FieldOffset(Offset = "0x144")]
	private int m_AutosaveSelectedButtonIndex;

	[Token(Token = "0x4004635")]
	[FieldOffset(Offset = "0x148")]
	private int m_NumFramesInAutosaveTab;

	[Token(Token = "0x4004636")]
	[FieldOffset(Offset = "0x150")]
	private List<GameObject> m_AutosaveMenuItems;

	[Header("Brightness")]
	[Token(Token = "0x4004637")]
	[FieldOffset(Offset = "0x158")]
	public GameObject m_BrightnessStandardRoot;

	[Token(Token = "0x4004638")]
	[FieldOffset(Offset = "0x160")]
	public GameObject m_BrightnessHDRRoot;

	[Token(Token = "0x4004639")]
	[FieldOffset(Offset = "0x168")]
	public ConsoleSlider m_BrightnessSlider;

	[Token(Token = "0x400463A")]
	[FieldOffset(Offset = "0x170")]
	public ConsoleSlider m_HDRBrightnessSlider;

	[Token(Token = "0x400463B")]
	[FieldOffset(Offset = "0x178")]
	public GameObject m_BrightnessFirstTimeButton;

	[Token(Token = "0x400463C")]
	[FieldOffset(Offset = "0x180")]
	public GameObject[] m_ObjectsToDisableOnBrightnessTab;

	[Token(Token = "0x400463D")]
	[FieldOffset(Offset = "0x188")]
	private List<GameObject> m_BrightnessMenuItems;

	[Token(Token = "0x400463E")]
	[FieldOffset(Offset = "0x190")]
	private int m_BrightnessSelectedButtonIndex;

	[Token(Token = "0x400463F")]
	[FieldOffset(Offset = "0x194")]
	private int m_NumFramesInBrightnessTab;

	[Token(Token = "0x4004640")]
	[FieldOffset(Offset = "0x198")]
	private string m_BrightnessSavedWeatherState;

	[Token(Token = "0x4004641")]
	[FieldOffset(Offset = "0x1A0")]
	private string m_BrightnessSavedTODState;

	[Token(Token = "0x4004642")]
	[FieldOffset(Offset = "0x1A8")]
	private string m_BrightnessSavedWindState;

	[Token(Token = "0x4004643")]
	[FieldOffset(Offset = "0x1B0")]
	private bool m_IsShowingBrightnessCalibration;

	[Header("Controls")]
	[Token(Token = "0x4004644")]
	[FieldOffset(Offset = "0x1B8")]
	public GameObject m_ControllerLayoutSwitchHandheld;

	[Token(Token = "0x4004645")]
	[FieldOffset(Offset = "0x1C0")]
	public GameObject m_ControllerLayoutSwitchJoycons;

	[Token(Token = "0x4004646")]
	[FieldOffset(Offset = "0x1C8")]
	public GameObject m_ControllerLayoutSwitchPro;

	[Header("Controls")]
	[Token(Token = "0x4004647")]
	[FieldOffset(Offset = "0x1D0")]
	public ConsoleComboBox m_EnableGamepadToggle;

	[Token(Token = "0x4004648")]
	[FieldOffset(Offset = "0x1D8")]
	public ConsoleComboBox m_InvertYToggle;

	[Token(Token = "0x4004649")]
	[FieldOffset(Offset = "0x1E0")]
	public ConsoleSlider m_MouseSensitivitySlider;

	[Token(Token = "0x400464A")]
	[FieldOffset(Offset = "0x1E8")]
	public ConsoleSlider m_ZoomSensitivitySlider;

	[Token(Token = "0x400464B")]
	[FieldOffset(Offset = "0x1F0")]
	public ConsoleSlider m_AnalogSticksSensitivitySlider;

	[Token(Token = "0x400464C")]
	[FieldOffset(Offset = "0x1F8")]
	public ConsoleComboBox m_LockMouseToScreenToggle;

	[Token(Token = "0x400464D")]
	[FieldOffset(Offset = "0x200")]
	public ConsoleComboBox m_MouseSmoothingToggle;

	[Token(Token = "0x400464E")]
	[FieldOffset(Offset = "0x208")]
	public GameObject m_ControllerLayoutXboxOne;

	[Token(Token = "0x400464F")]
	[FieldOffset(Offset = "0x210")]
	public GameObject m_ControllerLayoutPS4;

	[Token(Token = "0x4004650")]
	[FieldOffset(Offset = "0x218")]
	public GameObject m_ControllerLayoutPS5;

	[Token(Token = "0x4004651")]
	[FieldOffset(Offset = "0x220")]
	public ConsoleComboBox m_GyroModeToggle;

	[Token(Token = "0x4004652")]
	[FieldOffset(Offset = "0x228")]
	public ConsoleSlider m_GyroLookHorizontalSensitivitySlider;

	[Token(Token = "0x4004653")]
	[FieldOffset(Offset = "0x230")]
	public ConsoleSlider m_GyroLookVerticalSensitivitySlider;

	[Token(Token = "0x4004654")]
	[FieldOffset(Offset = "0x238")]
	public ConsoleSlider m_GyroAimHorizontalSensitivitySlider;

	[Token(Token = "0x4004655")]
	[FieldOffset(Offset = "0x240")]
	public ConsoleSlider m_GryoAimVerticalSensitivitySlider;

	[Token(Token = "0x4004656")]
	[FieldOffset(Offset = "0x248")]
	private int m_ControlsSelectedButtonIndex;

	[Token(Token = "0x4004657")]
	[FieldOffset(Offset = "0x24C")]
	private int m_NumFramesInControlsTab;

	[Token(Token = "0x4004658")]
	[FieldOffset(Offset = "0x250")]
	private List<GameObject> m_ControlsMenuItems;

	[Header("Common")]
	[Token(Token = "0x4004659")]
	[FieldOffset(Offset = "0x258")]
	public GameObject m_ConfirmButton;

	[Token(Token = "0x400465A")]
	[FieldOffset(Offset = "0x260")]
	public GameObject m_BackButton;

	[Token(Token = "0x400465B")]
	[FieldOffset(Offset = "0x268")]
	public UILabel m_OptionDescriptionLabel;

	[Token(Token = "0x400465C")]
	[FieldOffset(Offset = "0x270")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[SerializeField]
	[Token(Token = "0x400465D")]
	[FieldOffset(Offset = "0x278")]
	private float m_DescriptionLabelHorizontalPosition;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400465E")]
	[FieldOffset(Offset = "0x280")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x400465F")]
	[FieldOffset(Offset = "0x288")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4004660")]
	[FieldOffset(Offset = "0x290")]
	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	[SerializeField]
	[Token(Token = "0x4004661")]
	[FieldOffset(Offset = "0x298")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[SerializeField]
	[Token(Token = "0x4004662")]
	[FieldOffset(Offset = "0x2A0")]
	private PanelReference<Panel_Sandbox> m_Sandbox;

	[HideInInspector]
	[Token(Token = "0x4004663")]
	[FieldOffset(Offset = "0x2A8")]
	public bool m_ForceCloseOnConfirm;

	[Token(Token = "0x4004664")]
	[FieldOffset(Offset = "0x2B0")]
	private PanelReference m_ReturnToPanel;

	[Token(Token = "0x4004665")]
	[FieldOffset(Offset = "0x2B8")]
	private bool m_SettingsNeedConfirmation;

	[Token(Token = "0x4004666")]
	[FieldOffset(Offset = "0x2B9")]
	private bool m_SettingsNeedRestart;

	[Header("Display")]
	[Token(Token = "0x4004667")]
	[FieldOffset(Offset = "0x2C0")]
	public ConsoleComboBox m_GraphicsResolutionPopupList;

	[Token(Token = "0x4004668")]
	[FieldOffset(Offset = "0x2C8")]
	public ConsoleComboBox m_GraphicsModePopupList;

	[Token(Token = "0x4004669")]
	[FieldOffset(Offset = "0x2D0")]
	public ConsoleComboBox m_DisplayNumberPopupList;

	[Token(Token = "0x400466A")]
	[FieldOffset(Offset = "0x2D8")]
	public ConsoleComboBox m_UnitsPopupList;

	[Token(Token = "0x400466B")]
	[FieldOffset(Offset = "0x2E0")]
	public ConsoleComboBox m_HudSizePopupList;

	[Token(Token = "0x400466C")]
	[FieldOffset(Offset = "0x2E8")]
	public ConsoleComboBox m_HudTypePopupList;

	[Token(Token = "0x400466D")]
	[FieldOffset(Offset = "0x2F0")]
	public ConsoleComboBox m_WolfMoraleMeterPopupList;

	[Token(Token = "0x400466E")]
	[FieldOffset(Offset = "0x2F8")]
	public ConsoleComboBox m_VsyncPopupList;

	[Token(Token = "0x400466F")]
	[FieldOffset(Offset = "0x300")]
	public ConsoleComboBox m_SubtitlesPopupList;

	[Token(Token = "0x4004670")]
	[FieldOffset(Offset = "0x308")]
	public ConsoleComboBox m_LanguagePopupList;

	[Token(Token = "0x4004671")]
	[FieldOffset(Offset = "0x310")]
	public ConsoleSlider m_FieldOfViewSlider;

	[Token(Token = "0x4004672")]
	[FieldOffset(Offset = "0x318")]
	public ConsoleComboBox m_ImageFilterPopupList;

	[Token(Token = "0x4004673")]
	[FieldOffset(Offset = "0x320")]
	public ConsoleComboBox m_FramerateTargetPopupList;

	[Token(Token = "0x4004674")]
	[FieldOffset(Offset = "0x328")]
	public ConsoleComboBox m_FramerateCapPopupList;

	[Token(Token = "0x4004675")]
	[FieldOffset(Offset = "0x330")]
	public ConsoleSlider m_FramerateCapSlider;

	[Header("Display Slider Ranges")]
	[Range(1f, 179f)]
	[Token(Token = "0x4004676")]
	[FieldOffset(Offset = "0x338")]
	public float m_FieldOfViewDefault;

	[Range(1f, 179f)]
	[Token(Token = "0x4004677")]
	[FieldOffset(Offset = "0x33C")]
	public float m_FieldOfViewMin;

	[Range(1f, 179f)]
	[Token(Token = "0x4004678")]
	[FieldOffset(Offset = "0x340")]
	public float m_FieldOfViewMax;

	[Range(1f, 179f)]
	[Token(Token = "0x4004679")]
	[FieldOffset(Offset = "0x344")]
	public float m_FieldOfViewIndoor;

	[Token(Token = "0x400467A")]
	[FieldOffset(Offset = "0x348")]
	private int m_DisplaySelectedButtonIndex;

	[Token(Token = "0x400467B")]
	[FieldOffset(Offset = "0x34C")]
	private int m_NumFramesInDisplayTab;

	[Token(Token = "0x400467C")]
	[FieldOffset(Offset = "0x350")]
	private readonly List<GameObject> m_DisplayMenuItems;

	[Token(Token = "0x400467D")]
	[FieldOffset(Offset = "0x358")]
	private readonly List<Resolution> m_Resolutions;

	[Token(Token = "0x400467E")]
	[FieldOffset(Offset = "0x360")]
	private readonly List<DisplayInfo> m_Displays;

	[Token(Token = "0x400467F")]
	[FieldOffset(Offset = "0x368")]
	private Resolution m_ResolutionAtStartup;

	[Token(Token = "0x4004680")]
	[FieldOffset(Offset = "0x378")]
	private bool m_HasAppliedCommandLineParameters;

	[Token(Token = "0x4004681")]
	[FieldOffset(Offset = "0x379")]
	private bool m_FullScreenAtStartup;

	[Token(Token = "0x4004682")]
	[FieldOffset(Offset = "0x37A")]
	private bool m_RefreshDisplayBasedSettings;

	[Token(Token = "0x4004683")]
	[FieldOffset(Offset = "0x37C")]
	private int m_RestoreResolutionIndex;

	[Token(Token = "0x4004684")]
	[FieldOffset(Offset = "0x380")]
	private bool m_DeferSwitchToFullscreen;

	[Token(Token = "0x4004685")]
	private const int FRAMECAP_UNLIMITED = -1;

	[Token(Token = "0x4004686")]
	private const int FRAMECAP_MINIMUM = 30;

	[Token(Token = "0x4004687")]
	[FieldOffset(Offset = "0x384")]
	private GraphicsMode m_ModeAtLastResolutionRefresh;

	[Header("Generic")]
	[Token(Token = "0x4004688")]
	[FieldOffset(Offset = "0x388")]
	public float m_SliderTimeToMaxScroll;

	[Token(Token = "0x4004689")]
	[FieldOffset(Offset = "0x38C")]
	public float m_SliderTimerMin;

	[Token(Token = "0x400468A")]
	[FieldOffset(Offset = "0x390")]
	public float m_SliderTimerMax;

	[Token(Token = "0x400468B")]
	[FieldOffset(Offset = "0x394")]
	public float m_MenuItemSpacing;

	[Token(Token = "0x400468C")]
	[FieldOffset(Offset = "0x398")]
	private float m_SliderStickValueLastFrame;

	[Token(Token = "0x400468D")]
	[FieldOffset(Offset = "0x39C")]
	private float m_SliderMaxScrollTime;

	[Token(Token = "0x400468E")]
	[FieldOffset(Offset = "0x3A0")]
	private float m_SliderNextSlideTime;

	[Token(Token = "0x400468F")]
	[FieldOffset(Offset = "0x3A4")]
	private int m_NumFramesInOptions;

	[Token(Token = "0x4004690")]
	[FieldOffset(Offset = "0x3A8")]
	private int m_FrameLastPopupClick;

	[Header("Key Rebinding")]
	[Token(Token = "0x4004691")]
	[FieldOffset(Offset = "0x3B0")]
	public Collider m_KeyRebindPopup;

	[Token(Token = "0x4004692")]
	[FieldOffset(Offset = "0x3B8")]
	public GameObject m_AutoWalkKeyBinding;

	[Token(Token = "0x4004693")]
	[FieldOffset(Offset = "0x3C0")]
	private GameObject m_CurrentKeyRebindButton;

	[Token(Token = "0x4004694")]
	[FieldOffset(Offset = "0x3C8")]
	private int m_KeyRebindSelectedButtonIndex;

	[Token(Token = "0x4004695")]
	[FieldOffset(Offset = "0x3CC")]
	private bool m_WaitForKeyRebindInput;

	[Token(Token = "0x4004696")]
	[FieldOffset(Offset = "0x3D0")]
	private int m_RebindDelayFramesRemaining;

	[Header("Privacy")]
	[Token(Token = "0x4004697")]
	[FieldOffset(Offset = "0x3D8")]
	public ConsoleComboBox m_SendErrorReports;

	[Token(Token = "0x4004698")]
	[FieldOffset(Offset = "0x3E0")]
	public ConsoleComboBox m_SendTelemetryData;

	[Token(Token = "0x4004699")]
	[FieldOffset(Offset = "0x3E8")]
	public UIButton m_ViewPrivacyPolicy;

	[Token(Token = "0x400469A")]
	[FieldOffset(Offset = "0x3F0")]
	public UIButton m_ManagePrivacyData;

	[Token(Token = "0x400469B")]
	[FieldOffset(Offset = "0x3F8")]
	public string m_PrivacyPolicyURL;

	[Token(Token = "0x400469C")]
	[FieldOffset(Offset = "0x400")]
	private int m_PrivacySelectedButtonIndex;

	[Token(Token = "0x400469D")]
	[FieldOffset(Offset = "0x408")]
	private List<GameObject> m_PrivacyMenuItems;

	[Header("Quality")]
	[Token(Token = "0x400469E")]
	[FieldOffset(Offset = "0x410")]
	public ConsoleComboBox m_QualityPopupList;

	[Token(Token = "0x400469F")]
	[FieldOffset(Offset = "0x418")]
	public ConsoleComboBox m_ShadowsPopupList;

	[Token(Token = "0x40046A0")]
	[FieldOffset(Offset = "0x420")]
	public ConsoleComboBox m_ShadowQualityPopupList;

	[Token(Token = "0x40046A1")]
	[FieldOffset(Offset = "0x428")]
	public ConsoleComboBox m_ShadowResolutionPopupList;

	[Token(Token = "0x40046A2")]
	[FieldOffset(Offset = "0x430")]
	public ConsoleComboBox m_TextureQualityPopupList;

	[Token(Token = "0x40046A3")]
	[FieldOffset(Offset = "0x438")]
	public ConsoleComboBox m_TextureStreamingPopupList;

	[Token(Token = "0x40046A4")]
	[FieldOffset(Offset = "0x440")]
	public ConsoleComboBox m_TerrainLodQualityPopupList;

	[Token(Token = "0x40046A5")]
	[FieldOffset(Offset = "0x448")]
	public ConsoleComboBox m_LodBiasPopupList;

	[Token(Token = "0x40046A6")]
	[FieldOffset(Offset = "0x450")]
	public ConsoleComboBox m_GraphicsSSAOPopupList;

	[Token(Token = "0x40046A7")]
	[FieldOffset(Offset = "0x458")]
	public ConsoleComboBox m_AnisotropyPopupList;

	[Token(Token = "0x40046A8")]
	[FieldOffset(Offset = "0x460")]
	public ConsoleComboBox m_PostFxPopupList;

	[Token(Token = "0x40046A9")]
	[FieldOffset(Offset = "0x468")]
	public ConsoleComboBox m_AntiAliasingPopupList;

	[Token(Token = "0x40046AA")]
	[FieldOffset(Offset = "0x470")]
	public ConsoleComboBox m_MotionBlurPopupList;

	[Token(Token = "0x40046AB")]
	[FieldOffset(Offset = "0x478")]
	public ConsoleComboBox m_FootprintsPopupList;

	[Token(Token = "0x40046AC")]
	[FieldOffset(Offset = "0x480")]
	public ConsoleComboBox m_AmbientEffectsPopupList;

	[Token(Token = "0x40046AD")]
	[FieldOffset(Offset = "0x488")]
	public LocalizedString m_ApplyChangesMessage;

	[Token(Token = "0x40046AE")]
	[FieldOffset(Offset = "0x490")]
	private int m_QualitySelectedButtonIndex;

	[Token(Token = "0x40046AF")]
	[FieldOffset(Offset = "0x494")]
	private int m_NumFramesInQualityTab;

	[Token(Token = "0x40046B0")]
	[FieldOffset(Offset = "0x498")]
	private List<GameObject> m_QualityMenuItems;

	[Token(Token = "0x40046B1")]
	[FieldOffset(Offset = "0x4A0")]
	private List<GameObject> m_QualityOptionOnlyMenuItems;

	[Token(Token = "0x40046B2")]
	[FieldOffset(Offset = "0x4A8")]
	private Quality m_LastRefreshedQuality;

	[Token(Token = "0x40046B3")]
	[FieldOffset(Offset = "0x4AC")]
	private bool m_UnconfirmedCustomQualitySettingsPopulated;

	[Token(Token = "0x40046B4")]
	[FieldOffset(Offset = "0x4B0")]
	private QualityLevelSettings m_UnconfirmedCustomQualitySettings;

	[Token(Token = "0x40046B5")]
	[FieldOffset(Offset = "0x4B8")]
	private QualityLevelSettings m_SnapsotOfOriginalQualitySettings;

	[Token(Token = "0x40046B6")]
	[FieldOffset(Offset = "0x4C0")]
	private QualityLevelSettings m_SnapsotOfCurrentQualitySettings;

	[Header("Tabs")]
	[Token(Token = "0x40046B7")]
	[FieldOffset(Offset = "0x4C8")]
	public GameObject m_MainTab;

	[Token(Token = "0x40046B8")]
	[FieldOffset(Offset = "0x4D0")]
	public GameObject m_AccessibilityTab;

	[Token(Token = "0x40046B9")]
	[FieldOffset(Offset = "0x4D8")]
	public GameObject m_VisualsTab;

	[Token(Token = "0x40046BA")]
	[FieldOffset(Offset = "0x4E0")]
	public GameObject m_DisplayTab;

	[Token(Token = "0x40046BB")]
	[FieldOffset(Offset = "0x4E8")]
	public GameObject m_QualityTab;

	[Token(Token = "0x40046BC")]
	[FieldOffset(Offset = "0x4F0")]
	public GameObject m_AdvancedVisualsTab;

	[Token(Token = "0x40046BD")]
	[FieldOffset(Offset = "0x4F8")]
	public GameObject m_AudioTab;

	[Token(Token = "0x40046BE")]
	[FieldOffset(Offset = "0x500")]
	public GameObject m_ControlsTab;

	[Token(Token = "0x40046BF")]
	[FieldOffset(Offset = "0x508")]
	public GameObject m_ControlsDiagramTab;

	[Token(Token = "0x40046C0")]
	[FieldOffset(Offset = "0x510")]
	public GameObject m_RebindingTab;

	[Token(Token = "0x40046C1")]
	[FieldOffset(Offset = "0x518")]
	public GameObject m_BrightnessTab;

	[Token(Token = "0x40046C2")]
	[FieldOffset(Offset = "0x520")]
	public GameObject m_AutosaveTab;

	[Token(Token = "0x40046C3")]
	[FieldOffset(Offset = "0x528")]
	public GameObject m_PrivacyTab;

	[Header("Top Menu prefab")]
	[Token(Token = "0x40046C4")]
	[FieldOffset(Offset = "0x530")]
	public string m_TitleLocalizationId;

	[Token(Token = "0x40046C5")]
	[FieldOffset(Offset = "0x538")]
	public GameObject m_BasicMenuRoot;

	[Token(Token = "0x40046C6")]
	[FieldOffset(Offset = "0x540")]
	public List<OptionTopMenuItem> m_MenuItems;

	[Header("Top Menu")]
	[Token(Token = "0x40046C7")]
	[FieldOffset(Offset = "0x548")]
	public UIButton m_MainMenuItem_OptionsHeader;

	[Token(Token = "0x40046C8")]
	[FieldOffset(Offset = "0x550")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x40046C9")]
	[FieldOffset(Offset = "0x558")]
	private readonly List<GameObject> m_Tabs;

	[Header("Visuals")]
	[SerializeField]
	[Token(Token = "0x40046CA")]
	[FieldOffset(Offset = "0x560")]
	private List<OptionTopMenuItem> m_VisualsMenuItems;

	[SerializeField]
	[Token(Token = "0x40046CB")]
	[FieldOffset(Offset = "0x568")]
	private GameObject m_VisualsMenuRoot;

	[Token(Token = "0x40046CC")]
	[FieldOffset(Offset = "0x570")]
	private BasicMenu m_VisualsMenu;

	[Token(Token = "0x17000306")]
	private SettingsState State
	{
		[Token(Token = "0x600397D")]
		[Address(RVA = "0xB15350", Offset = "0xB14150", Length = "0x5B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600393E")]
	[Address(RVA = "0xB0DA10", Offset = "0xB0C810", Length = "0xB99")]
	private void InitializeAccessibilityMenuItems()
	{
	}

	[Token(Token = "0x600393F")]
	[Address(RVA = "0xB0E5B0", Offset = "0xB0D3B0", Length = "0x461")]
	private void RefreshAccessibilitySettings()
	{
	}

	[Token(Token = "0x6003940")]
	[Address(RVA = "0xB0EA20", Offset = "0xB0D820", Length = "0x4F8")]
	private void OnConfirmAccessibility()
	{
	}

	[Token(Token = "0x6003941")]
	[Address(RVA = "0xB0EF20", Offset = "0xB0DD20", Length = "0x2EC")]
	public void ApplyAccessibilityOptions()
	{
	}

	[Token(Token = "0x6003942")]
	[Address(RVA = "0xB0F210", Offset = "0xB0E010", Length = "0x26")]
	private void OnAccessibilityTab()
	{
	}

	[Token(Token = "0x6003943")]
	[Address(RVA = "0xB0F240", Offset = "0xB0E040", Length = "0x1A6")]
	private void ProcessAccessibilityMenu()
	{
	}

	[Token(Token = "0x6003944")]
	[Address(RVA = "0xB0F3F0", Offset = "0xB0E1F0", Length = "0x9DE")]
	private void InitializeAdvancedVisualsMenuItems()
	{
	}

	[Token(Token = "0x6003945")]
	[Address(RVA = "0xB0FDD0", Offset = "0xB0EBD0", Length = "0x2C")]
	private void OnAdvancedVisualsTab()
	{
	}

	[Token(Token = "0x6003946")]
	[Address(RVA = "0xB0FE00", Offset = "0xB0EC00", Length = "0x1C2")]
	private void ProcessAdvancedVisualsMenu()
	{
	}

	[Token(Token = "0x6003947")]
	[Address(RVA = "0xB0FFD0", Offset = "0xB0EDD0", Length = "0xBA")]
	private void RefreshAdvancedVisualsSliderLabels()
	{
	}

	[Token(Token = "0x6003948")]
	[Address(RVA = "0xB10090", Offset = "0xB0EE90", Length = "0x85")]
	public void OnGroundDetailsDrawDistanceChanged()
	{
	}

	[Token(Token = "0x6003949")]
	[Address(RVA = "0xB10120", Offset = "0xB0EF20", Length = "0x80")]
	public void OnGroundDetailsDensityChanged()
	{
	}

	[Token(Token = "0x600394A")]
	[Address(RVA = "0xB101A0", Offset = "0xB0EFA0", Length = "0x85")]
	public void OnRockDrawDistanceChanged()
	{
	}

	[Token(Token = "0x600394B")]
	[Address(RVA = "0xB10230", Offset = "0xB0F030", Length = "0x85")]
	public void OnSceneDrawDistanceChanged()
	{
	}

	[Token(Token = "0x600394C")]
	[Address(RVA = "0xB102C0", Offset = "0xB0F0C0", Length = "0x85")]
	public void OnShadowDrawDistanceChanged()
	{
	}

	[Token(Token = "0x600394D")]
	[Address(RVA = "0xB10350", Offset = "0xB0F150", Length = "0x85")]
	public void OnTreeDrawDistanceChanged()
	{
	}

	[Token(Token = "0x600394E")]
	[Address(RVA = "0xB103E0", Offset = "0xB0F1E0", Length = "0x77")]
	private static int DetermineNumSliderSteps(float min, float max)
	{
		return 0;
	}

	[Token(Token = "0x600394F")]
	[Address(RVA = "0xB10460", Offset = "0xB0F260", Length = "0x3D")]
	public void ApplyVolumeSettings()
	{
	}

	[Token(Token = "0x6003950")]
	[Address(RVA = "0xB104A0", Offset = "0xB0F2A0", Length = "0x11")]
	public void OnAudioSliderChanged()
	{
	}

	[Token(Token = "0x6003951")]
	[Address(RVA = "0xB104C0", Offset = "0xB0F2C0", Length = "0x2C")]
	public void OnAudioTab()
	{
	}

	[Token(Token = "0x6003952")]
	[Address(RVA = "0xB104F0", Offset = "0xB0F2F0", Length = "0xC5")]
	private void ApplyMasterVolume()
	{
	}

	[Token(Token = "0x6003953")]
	[Address(RVA = "0xB105C0", Offset = "0xB0F3C0", Length = "0xC5")]
	private void ApplySoundVolume()
	{
	}

	[Token(Token = "0x6003954")]
	[Address(RVA = "0xB10690", Offset = "0xB0F490", Length = "0xC5")]
	private void ApplyMusicVolume()
	{
	}

	[Token(Token = "0x6003955")]
	[Address(RVA = "0xB10760", Offset = "0xB0F560", Length = "0xC5")]
	private void ApplyVoiceVolume()
	{
	}

	[Token(Token = "0x6003956")]
	[Address(RVA = "0xB10830", Offset = "0xB0F630", Length = "0x157")]
	private void ApplyPanningRule()
	{
	}

	[Token(Token = "0x6003957")]
	[Address(RVA = "0xB10990", Offset = "0xB0F790", Length = "0x228")]
	private void RefreshAudioSettings()
	{
	}

	[Token(Token = "0x6003958")]
	[Address(RVA = "0xB10BC0", Offset = "0xB0F9C0", Length = "0x3F6")]
	private void OnConfirmAudio()
	{
	}

	[Token(Token = "0x6003959")]
	[Address(RVA = "0xB10FC0", Offset = "0xB0FDC0", Length = "0x569")]
	private void InitializeAudioMenuItems()
	{
	}

	[Token(Token = "0x600395A")]
	[Address(RVA = "0xB11530", Offset = "0xB10330", Length = "0x1B8")]
	private void ProcessAudioMenu()
	{
	}

	[Token(Token = "0x600395B")]
	[Address(RVA = "0xB116F0", Offset = "0xB104F0", Length = "0x143")]
	private void RefreshAudioSliderLabels()
	{
	}

	[Token(Token = "0x600395C")]
	[Address(RVA = "0xB11840", Offset = "0xB10640", Length = "0x2C")]
	public void OnAutosaveTab()
	{
	}

	[Token(Token = "0x600395D")]
	[Address(RVA = "0xB11870", Offset = "0xB10670", Length = "0x38")]
	public void OnAutosaveMinutesChanged()
	{
	}

	[Token(Token = "0x600395E")]
	[Address(RVA = "0xB118B0", Offset = "0xB106B0", Length = "0xDD")]
	private void RefreshAutosaveSettings()
	{
	}

	[Token(Token = "0x600395F")]
	[Address(RVA = "0xB11990", Offset = "0xB10790", Length = "0x16F")]
	private void OnConfirmAutosaveMinutes()
	{
	}

	[Token(Token = "0x6003960")]
	[Address(RVA = "0xB11990", Offset = "0xB10790", Length = "0x16F")]
	private void OnConfirmAutosave()
	{
	}

	[Token(Token = "0x6003961")]
	[Address(RVA = "0xB11B00", Offset = "0xB10900", Length = "0x1FE")]
	private void ApplyAutosaveMinutes()
	{
	}

	[Token(Token = "0x6003962")]
	[Address(RVA = "0xB11D00", Offset = "0xB10B00", Length = "0x21A")]
	private void InitializeAutosaveMenuItems()
	{
	}

	[Token(Token = "0x6003963")]
	[Address(RVA = "0xB11F20", Offset = "0xB10D20", Length = "0x1B8")]
	private void ProcessAutosaveMenu()
	{
	}

	[Token(Token = "0x6003964")]
	[Address(RVA = "0xB120E0", Offset = "0xB10EE0", Length = "0x25")]
	private void RefreshAutosaveSliderLabels()
	{
	}

	[Token(Token = "0x6003965")]
	[Address(RVA = "0xB12110", Offset = "0xB10F10", Length = "0x3F5")]
	public void OnBrightnessChanged()
	{
	}

	[Token(Token = "0x6003966")]
	[Address(RVA = "0xB12510", Offset = "0xB11310", Length = "0x29")]
	public void OnConfirmBrightnessSettings()
	{
	}

	[Token(Token = "0x6003967")]
	[Address(RVA = "0xB12540", Offset = "0xB11340", Length = "0x115")]
	public void OnBrightnessTab()
	{
	}

	[Token(Token = "0x6003968")]
	[Address(RVA = "0xB12660", Offset = "0xB11460", Length = "0x12B")]
	private void RefreshBrightnessSettings()
	{
	}

	[Token(Token = "0x6003969")]
	[Address(RVA = "0xB12790", Offset = "0xB11590", Length = "0x1B7")]
	private void OnConfirmBrightness()
	{
	}

	[Token(Token = "0x600396A")]
	[Address(RVA = "0xB12950", Offset = "0xB11750", Length = "0x29B")]
	private void InitializeBrightnessMenuItems()
	{
	}

	[Token(Token = "0x600396B")]
	[Address(RVA = "0xB12BF0", Offset = "0xB119F0", Length = "0x1FD")]
	private void ProcessBrightnessMenu()
	{
	}

	[Token(Token = "0x600396C")]
	[Address(RVA = "0xB12DF0", Offset = "0xB11BF0", Length = "0x2E9")]
	private void ToggleGameCameraForBrightness(bool toggle)
	{
	}

	[Token(Token = "0x600396D")]
	[Address(RVA = "0xB130E0", Offset = "0xB11EE0", Length = "0x138")]
	public void OnControllerDiagramTab()
	{
	}

	[Token(Token = "0x600396E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdateControllerDiagram()
	{
	}

	[Token(Token = "0x600396F")]
	[Address(RVA = "0xB13220", Offset = "0xB12020", Length = "0x62")]
	public void ProcessControllerDiagram()
	{
	}

	[Token(Token = "0x6003970")]
	[Address(RVA = "0xB13290", Offset = "0xB12090", Length = "0x11")]
	public void OnControlsSliderChanged()
	{
	}

	[Token(Token = "0x6003971")]
	[Address(RVA = "0xB132B0", Offset = "0xB120B0", Length = "0x2C")]
	public void OnControlsTab()
	{
	}

	[Token(Token = "0x6003972")]
	[Address(RVA = "0xB132E0", Offset = "0xB120E0", Length = "0x455")]
	private void RefreshControlsSettings()
	{
	}

	[Token(Token = "0x6003973")]
	[Address(RVA = "0xB13740", Offset = "0xB12540", Length = "0x6E2")]
	private void OnConfirmControls()
	{
	}

	[Token(Token = "0x6003974")]
	[Address(RVA = "0xB13E30", Offset = "0xB12C30", Length = "0x91")]
	private void ApplyMouseSensitivity()
	{
	}

	[Token(Token = "0x6003975")]
	[Address(RVA = "0xB13ED0", Offset = "0xB12CD0", Length = "0x89")]
	private void ApplyZoomSensitivity()
	{
	}

	[Token(Token = "0x6003976")]
	[Address(RVA = "0xB13F60", Offset = "0xB12D60", Length = "0x86")]
	private void ApplyAnalogSticksSensitivity()
	{
	}

	[Conditional("UNITY_SWITCH")]
	[Token(Token = "0x6003977")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnConfirmGyro()
	{
	}

	[Token(Token = "0x6003978")]
	[Address(RVA = "0xB13FF0", Offset = "0xB12DF0", Length = "0x87A")]
	private void InitializeControlsMenuItems()
	{
	}

	[Token(Token = "0x6003979")]
	[Address(RVA = "0xB14870", Offset = "0xB13670", Length = "0x3E2")]
	private void ProcessControlsMenu()
	{
	}

	[Token(Token = "0x600397A")]
	[Address(RVA = "0xB14C60", Offset = "0xB13A60", Length = "0x61")]
	private void RefreshControlsSliderLabels()
	{
	}

	[Token(Token = "0x600397B")]
	[Address(RVA = "0xB14CD0", Offset = "0xB13AD0", Length = "0x48C")]
	private void UpdateControlsMenuItems()
	{
	}

	[Token(Token = "0x600397C")]
	[Address(RVA = "0xB15160", Offset = "0xB13F60", Length = "0x1E9")]
	private ControllerDiagram GetActiveControllerDiagram()
	{
		return default(ControllerDiagram);
	}

	[Token(Token = "0x600397E")]
	[Address(RVA = "0xB153B0", Offset = "0xB141B0", Length = "0x3C8")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600397F")]
	[Address(RVA = "0xB15780", Offset = "0xB14580", Length = "0x121")]
	public void SetPanelToReturnToOnExit(PanelReference panel)
	{
	}

	[Token(Token = "0x6003980")]
	[Address(RVA = "0xB158B0", Offset = "0xB146B0", Length = "0x222")]
	private void UpdateActiveMenuItems()
	{
	}

	[Token(Token = "0x6003981")]
	[Address(RVA = "0xB15AE0", Offset = "0xB148E0", Length = "0x60F")]
	private void Update()
	{
	}

	[Token(Token = "0x6003982")]
	[Address(RVA = "0xB160F0", Offset = "0xB14EF0", Length = "0x495")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003983")]
	[Address(RVA = "0xB16590", Offset = "0xB15390", Length = "0x25C")]
	private bool IsSelectButtonActive()
	{
		return false;
	}

	[Token(Token = "0x6003984")]
	[Address(RVA = "0xB167F0", Offset = "0xB155F0", Length = "0x18")]
	private void ClearConfirmSettings()
	{
	}

	[Token(Token = "0x6003985")]
	[Address(RVA = "0xB16810", Offset = "0xB15610", Length = "0x185")]
	public void ApplyDefaultSettingsToState(SettingsState settingsState)
	{
	}

	[Token(Token = "0x6003986")]
	[Address(RVA = "0xB169A0", Offset = "0xB157A0", Length = "0x53A")]
	public void ApplyCommandLineParameters()
	{
	}

	[Token(Token = "0x6003987")]
	[Address(RVA = "0xB16EE0", Offset = "0xB15CE0", Length = "0x17C")]
	public void ApplyAllOptions(bool applyGraphicsModeAndResolution)
	{
	}

	[Token(Token = "0x6003988")]
	[Address(RVA = "0xB17060", Offset = "0xB15E60", Length = "0x250")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003989")]
	[Address(RVA = "0xB172C0", Offset = "0xB160C0", Length = "0x43")]
	public bool IsInBrightnessCalibration()
	{
		return false;
	}

	[Token(Token = "0x600398A")]
	[Address(RVA = "0xB17310", Offset = "0xB16110", Length = "0x22A")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x600398B")]
	[Address(RVA = "0xB17540", Offset = "0xB16340", Length = "0x8")]
	public void SettingsNeedConfirmation()
	{
	}

	[Token(Token = "0x600398C")]
	[Address(RVA = "0xB17550", Offset = "0xB16350", Length = "0xB6")]
	public void OnOptionsClicked()
	{
	}

	[Token(Token = "0x600398D")]
	[Address(RVA = "0xB17610", Offset = "0xB16410", Length = "0x4A4")]
	public void OnConfirmSettings()
	{
	}

	[Token(Token = "0x600398E")]
	[Address(RVA = "0xB17AC0", Offset = "0xB168C0", Length = "0x1EB")]
	private void ExitOptions()
	{
	}

	[Token(Token = "0x600398F")]
	[Address(RVA = "0xB17CB0", Offset = "0xB16AB0", Length = "0x4DB")]
	private void RefreshSettings()
	{
	}

	[Token(Token = "0x6003990")]
	[Address(RVA = "0xB18190", Offset = "0xB16F90", Length = "0x2B9")]
	private void RefreshSliderLabels()
	{
	}

	[Token(Token = "0x6003991")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void DisableMenuItemsBasedOnPlatform()
	{
	}

	[Token(Token = "0x6003992")]
	[Address(RVA = "0xB18450", Offset = "0xB17250", Length = "0x139")]
	private float CommandLineParameterValue(string arg)
	{
		return 0f;
	}

	[Token(Token = "0x6003993")]
	[Address(RVA = "0xB18590", Offset = "0xB17390", Length = "0x25C")]
	private void MaybeShowOptionDescriptionLabel(GameObject go)
	{
	}

	[Token(Token = "0x6003994")]
	[Address(RVA = "0xB187F0", Offset = "0xB175F0", Length = "0x345")]
	private void ShowOptionDescriptionLabel(GameObject menuItem, string text)
	{
	}

	[Token(Token = "0x6003995")]
	[Address(RVA = "0xB18B40", Offset = "0xB17940", Length = "0x5F")]
	public void SetStartupDisplayValues()
	{
	}

	[Token(Token = "0x6003996")]
	[Address(RVA = "0xB18BA0", Offset = "0xB179A0", Length = "0x38")]
	public void OnFOVChanged()
	{
	}

	[Token(Token = "0x6003997")]
	[Address(RVA = "0xB18BE0", Offset = "0xB179E0", Length = "0x89")]
	public void OnFramerateCapChanged()
	{
	}

	[Token(Token = "0x6003998")]
	[Address(RVA = "0xB18C70", Offset = "0xB17A70", Length = "0x129")]
	public void OnFramerateCapToggleChanged()
	{
	}

	[Token(Token = "0x6003999")]
	[Address(RVA = "0xB18DA0", Offset = "0xB17BA0", Length = "0x2C")]
	public void OnDisplayTab()
	{
	}

	[Token(Token = "0x600399A")]
	[Address(RVA = "0xB18DD0", Offset = "0xB17BD0", Length = "0x4D6")]
	public void ApplyFOV()
	{
	}

	[Token(Token = "0x600399B")]
	[Address(RVA = "0xB192B0", Offset = "0xB180B0", Length = "0x292")]
	public void ApplyHudSize()
	{
	}

	[Token(Token = "0x600399C")]
	[Address(RVA = "0xB19550", Offset = "0xB18350", Length = "0x11E")]
	public void ApplyHudType()
	{
	}

	[Token(Token = "0x600399D")]
	[Address(RVA = "0xB19670", Offset = "0xB18470", Length = "0x5B0")]
	public void ApplyBrightness()
	{
	}

	[Token(Token = "0x600399E")]
	[Address(RVA = "0xB19C30", Offset = "0xB18A30", Length = "0x2D")]
	private void ApplyFrameLimits()
	{
	}

	[Token(Token = "0x600399F")]
	[Address(RVA = "0xB19C60", Offset = "0xB18A60", Length = "0x261")]
	private void ApplyFrameLimitsForDynamicRes()
	{
	}

	[Token(Token = "0x60039A0")]
	[Address(RVA = "0xB19ED0", Offset = "0xB18CD0", Length = "0x259")]
	private void ApplyFrameLimitsFromState()
	{
	}

	[Token(Token = "0x60039A1")]
	[Address(RVA = "0xB1A130", Offset = "0xB18F30", Length = "0x69")]
	private int GetVsyncCount()
	{
		return 0;
	}

	[Token(Token = "0x60039A2")]
	[Address(RVA = "0xB1A1A0", Offset = "0xB18FA0", Length = "0x150")]
	private int GetTargetFramerate()
	{
		return 0;
	}

	[Token(Token = "0x60039A3")]
	[Address(RVA = "0xB1A300", Offset = "0xB19100", Length = "0x263")]
	private bool ApplyDisplayNumber()
	{
		return false;
	}

	[Token(Token = "0x60039A4")]
	[Address(RVA = "0xB1A570", Offset = "0xB19370", Length = "0x81")]
	private bool CopyDisplayNumber(int pendingDisplayNumber)
	{
		return false;
	}

	[Token(Token = "0x60039A5")]
	[Address(RVA = "0xB1A600", Offset = "0xB19400", Length = "0x1A3")]
	private int GetCurrentDisplayNumber()
	{
		return 0;
	}

	[Token(Token = "0x60039A6")]
	[Address(RVA = "0xB1A7B0", Offset = "0xB195B0", Length = "0xE7")]
	private void RefreshDisplays()
	{
	}

	[Token(Token = "0x60039A7")]
	[Address(RVA = "0xB1A8A0", Offset = "0xB196A0", Length = "0xB77")]
	public void ApplyGraphicsModeAndResolution(bool applyDisplayNumber)
	{
	}

	[Token(Token = "0x60039A8")]
	[Address(RVA = "0xB1B420", Offset = "0xB1A220", Length = "0x789")]
	private void RefreshDisplaySettings()
	{
	}

	[Token(Token = "0x60039A9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void RefreshConsoleDisplaySettings()
	{
	}

	[Token(Token = "0x60039AA")]
	[Address(RVA = "0xB1BBB0", Offset = "0xB1A9B0", Length = "0x754")]
	private void RefreshDesktopDisplaySettings()
	{
	}

	[Token(Token = "0x60039AB")]
	[Address(RVA = "0xB1C310", Offset = "0xB1B110", Length = "0x30E")]
	private void CopyGraphicModeAndResolution()
	{
	}

	[Token(Token = "0x60039AC")]
	[Address(RVA = "0xB1C620", Offset = "0xB1B420", Length = "0x22")]
	private void ApplyGraphicMode()
	{
	}

	[Token(Token = "0x60039AD")]
	[Address(RVA = "0xB1C650", Offset = "0xB1B450", Length = "0x1C8")]
	private void OnConfirmGraphicsOptions()
	{
	}

	[Token(Token = "0x60039AE")]
	[Address(RVA = "0xB1C820", Offset = "0xB1B620", Length = "0x2D")]
	private void OnConfirmFrameLimits()
	{
	}

	[Token(Token = "0x60039AF")]
	[Address(RVA = "0xB1C850", Offset = "0xB1B650", Length = "0x1C5")]
	private void OnConfirmFrameLimitsForDynamicRes()
	{
	}

	[Token(Token = "0x60039B0")]
	[Address(RVA = "0xB1CA20", Offset = "0xB1B820", Length = "0x292")]
	private void OnConfirmFrameLimitsForStandalone()
	{
	}

	[Token(Token = "0x60039B1")]
	[Address(RVA = "0xB1CCC0", Offset = "0xB1BAC0", Length = "0x4C7")]
	private void PopulateFramerateTargetPopupList()
	{
	}

	[Token(Token = "0x60039B2")]
	[Address(RVA = "0xB1D190", Offset = "0xB1BF90", Length = "0xCE")]
	private int GetFramerateTargetFromString(string text)
	{
		return 0;
	}

	[Token(Token = "0x60039B3")]
	[Address(RVA = "0xB1D260", Offset = "0xB1C060", Length = "0x75")]
	private string GetFramerateTargetString(int framerateTarget)
	{
		return null;
	}

	[Token(Token = "0x60039B4")]
	[Address(RVA = "0xB1D2E0", Offset = "0xB1C0E0", Length = "0x8B")]
	private int DetermineVsyncCount()
	{
		return 0;
	}

	[Token(Token = "0x60039B5")]
	[Address(RVA = "0xB1D370", Offset = "0xB1C170", Length = "0xCD")]
	private bool IsDynamicResolutionSupported()
	{
		return false;
	}

	[Token(Token = "0x60039B6")]
	[Address(RVA = "0xB1D440", Offset = "0xB1C240", Length = "0x193")]
	private void OnConfirmSubtitles()
	{
	}

	[Token(Token = "0x60039B7")]
	[Address(RVA = "0xB1D5E0", Offset = "0xB1C3E0", Length = "0x171")]
	private void OnConfirmLanguage()
	{
	}

	[Token(Token = "0x60039B8")]
	[Address(RVA = "0xB1D760", Offset = "0xB1C560", Length = "0x12C")]
	private void OnConfirmFOV()
	{
	}

	[Token(Token = "0x60039B9")]
	[Address(RVA = "0xB1D890", Offset = "0xB1C690", Length = "0x150")]
	private void OnConfirmUnits()
	{
	}

	[Token(Token = "0x60039BA")]
	[Address(RVA = "0xB1D9F0", Offset = "0xB1C7F0", Length = "0x189")]
	private void OnConfirmHudSize()
	{
	}

	[Token(Token = "0x60039BB")]
	[Address(RVA = "0xB1DB80", Offset = "0xB1C980", Length = "0x189")]
	private void OnConfirmHudType()
	{
	}

	[Token(Token = "0x60039BC")]
	[Address(RVA = "0xB1DD10", Offset = "0xB1CB10", Length = "0x14A")]
	private void OnConfirmWolfMoraleMeter()
	{
	}

	[Token(Token = "0x60039BD")]
	[Address(RVA = "0xB1DE60", Offset = "0xB1CC60", Length = "0x139")]
	private void OnConfirmImageFilter()
	{
	}

	[Token(Token = "0x60039BE")]
	[Address(RVA = "0xB1DFA0", Offset = "0xB1CDA0", Length = "0x685")]
	private void OnConfirmDisplay()
	{
	}

	[Token(Token = "0x60039BF")]
	[Address(RVA = "0xB1E630", Offset = "0xB1D430", Length = "0x1323")]
	private void InitializeDisplayMenuItems()
	{
	}

	[Token(Token = "0x60039C0")]
	[Address(RVA = "0xB1F960", Offset = "0xB1E760", Length = "0x22C")]
	public void RestoreResolution()
	{
	}

	[Token(Token = "0x60039C1")]
	[Address(RVA = "0xB1FB90", Offset = "0xB1E990", Length = "0x6BE")]
	private void ProcessDisplayMenu()
	{
	}

	[Token(Token = "0x60039C2")]
	[Address(RVA = "0xB20250", Offset = "0xB1F050", Length = "0x402")]
	private void PopulateDisplayNumberPopupList()
	{
	}

	[Token(Token = "0x60039C3")]
	[Address(RVA = "0xB20660", Offset = "0xB1F460", Length = "0x2D1")]
	private bool ModeAndResolutionDifferentThanCurrent()
	{
		return false;
	}

	[Token(Token = "0x60039C4")]
	[Address(RVA = "0xB20940", Offset = "0xB1F740", Length = "0x8E")]
	private string GetDisplayNumberString(int displayNumber)
	{
		return null;
	}

	[Token(Token = "0x60039C5")]
	[Address(RVA = "0xB209D0", Offset = "0xB1F7D0", Length = "0x3C2")]
	private int GetDisplayNumberFromString(string text)
	{
		return 0;
	}

	[Token(Token = "0x60039C6")]
	[Address(RVA = "0xB20DA0", Offset = "0xB1FBA0", Length = "0x18")]
	private FullScreenMode GetFullScreenFromGraphicsMode(GraphicsMode gmode)
	{
		return default(FullScreenMode);
	}

	[Token(Token = "0x60039C7")]
	[Address(RVA = "0xB20DC0", Offset = "0xB1FBC0", Length = "0x1D")]
	private GraphicsMode GetGraphicsFromFullScreenMode(FullScreenMode fsmode)
	{
		return default(GraphicsMode);
	}

	[Token(Token = "0x60039C8")]
	[Address(RVA = "0xB20DE0", Offset = "0xB1FBE0", Length = "0xCB")]
	private GraphicsMode GetGraphicsModeFromString(string text)
	{
		return default(GraphicsMode);
	}

	[Token(Token = "0x60039C9")]
	[Address(RVA = "0xB20EB0", Offset = "0xB1FCB0", Length = "0x97")]
	private string GetStringFromGraphicsMode(GraphicsMode mode)
	{
		return null;
	}

	[Token(Token = "0x60039CA")]
	[Address(RVA = "0xB20F50", Offset = "0xB1FD50", Length = "0x123")]
	private int GetScreenResolutionIndexFromString(string text)
	{
		return 0;
	}

	[Token(Token = "0x60039CB")]
	[Address(RVA = "0xB21080", Offset = "0xB1FE80", Length = "0x64")]
	private string GetResolutionString(int width, int height)
	{
		return null;
	}

	[Token(Token = "0x60039CC")]
	[Address(RVA = "0xB210F0", Offset = "0xB1FEF0", Length = "0x14F")]
	private void SetDefaultVsync()
	{
	}

	[Token(Token = "0x60039CD")]
	[Address(RVA = "0xB21240", Offset = "0xB20040", Length = "0x12A")]
	public void ForceTempResolutionChange()
	{
	}

	[IteratorStateMachine(typeof(_003CStartForceTempResolutionChangeCo_003Ed__273))]
	[Token(Token = "0x60039CE")]
	[Address(RVA = "0xB21370", Offset = "0xB20170", Length = "0x3D")]
	public static IEnumerator StartForceTempResolutionChangeCo()
	{
		return null;
	}

	[Token(Token = "0x60039CF")]
	[Address(RVA = "0xB213B0", Offset = "0xB201B0", Length = "0x46")]
	private void RefreshDisplaySliderLabels()
	{
	}

	[Token(Token = "0x60039D0")]
	[Address(RVA = "0xB21400", Offset = "0xB20200", Length = "0x9F")]
	private bool IsResolutionSupported(GraphicsMode mode, int width, int height)
	{
		return false;
	}

	[Token(Token = "0x60039D1")]
	[Address(RVA = "0xB214A0", Offset = "0xB202A0", Length = "0xBF")]
	private Resolution GetClosestSupportedResolution(GraphicsMode mode, int width, int height)
	{
		return default(Resolution);
	}

	[Token(Token = "0x60039D2")]
	[Address(RVA = "0xB21560", Offset = "0xB20360", Length = "0x10")]
	private bool ResolutionCompatibleWithGraphicsMode(GraphicsMode mode, int width, int height)
	{
		return false;
	}

	[Token(Token = "0x60039D3")]
	[Address(RVA = "0xB21570", Offset = "0xB20370", Length = "0x188")]
	private Resolution GetHighestCompatibleResolutionForGraphicsMode(GraphicsMode mode)
	{
		return default(Resolution);
	}

	[Token(Token = "0x60039D4")]
	[Address(RVA = "0xB21700", Offset = "0xB20500", Length = "0x5F4")]
	private void RefreshResolutionsStandalone(GraphicsMode mode)
	{
	}

	[Token(Token = "0x60039D5")]
	[Address(RVA = "0xB21D00", Offset = "0xB20B00", Length = "0x8")]
	private void RefreshResolutions(GraphicsMode mode)
	{
	}

	[Token(Token = "0x60039D6")]
	[Address(RVA = "0xB21D10", Offset = "0xB20B10", Length = "0x95")]
	private static void CopyScreenResolution(ref Resolution dest)
	{
	}

	[Token(Token = "0x60039D7")]
	[Address(RVA = "0xB21DB0", Offset = "0xB20BB0", Length = "0x17")]
	private void CopyResolution(ref Resolution dest, Resolution source)
	{
	}

	[Token(Token = "0x60039D8")]
	[Address(RVA = "0xB21DD0", Offset = "0xB20BD0", Length = "0x19E")]
	private bool CanChangeFovOption()
	{
		return false;
	}

	[Token(Token = "0x60039D9")]
	[Address(RVA = "0xB21F70", Offset = "0xB20D70", Length = "0x2A3")]
	private void UpdateDisplayMenuItems()
	{
	}

	[Token(Token = "0x60039DA")]
	[Address(RVA = "0xB22220", Offset = "0xB21020", Length = "0x69")]
	public void OnPopupClicked()
	{
	}

	[Token(Token = "0x60039DB")]
	[Address(RVA = "0xB22290", Offset = "0xB21090", Length = "0x4ED")]
	private void OnTabCommon(GameObject tab, List<GameObject> menuItems, int buttonIndex)
	{
	}

	[Token(Token = "0x60039DC")]
	[Address(RVA = "0xB22780", Offset = "0xB21580", Length = "0xF02")]
	private void UpdateMenuNavigationGeneric(ref int index, List<GameObject> menuItems)
	{
	}

	[Token(Token = "0x60039DD")]
	[Address(RVA = "0xB23690", Offset = "0xB22490", Length = "0x251")]
	private float GetGenericSliderMovementHorizontal()
	{
		return 0f;
	}

	[Token(Token = "0x60039DE")]
	[Address(RVA = "0xB238F0", Offset = "0xB226F0", Length = "0x267")]
	private void DisableMenuBackgrounds(List<GameObject> menu)
	{
	}

	[Token(Token = "0x60039DF")]
	[Address(RVA = "0xB23B60", Offset = "0xB22960", Length = "0x25")]
	private float GetNormalizedValue(float min, float max, float val)
	{
		return 0f;
	}

	[Token(Token = "0x60039E0")]
	[Address(RVA = "0xB23B90", Offset = "0xB22990", Length = "0x334")]
	private int SetupMenuPositions(List<GameObject> menuItems)
	{
		return 0;
	}

	[Token(Token = "0x60039E1")]
	[Address(RVA = "0xB23ED0", Offset = "0xB22CD0", Length = "0x194")]
	private void InitSlider(ConsoleSlider slider, int numSteps)
	{
	}

	[Token(Token = "0x60039E2")]
	[Address(RVA = "0xB24070", Offset = "0xB22E70", Length = "0x85")]
	private void OnSliderChanged(ConsoleSlider slider, float min, float max, int numFramesInTab)
	{
	}

	[Token(Token = "0x60039E3")]
	[Address(RVA = "0xB24100", Offset = "0xB22F00", Length = "0x85")]
	private void OnSliderChangedScalar(ConsoleSlider slider, float min, float max, int numFramesInTab)
	{
	}

	[Token(Token = "0x60039E4")]
	[Address(RVA = "0xB24190", Offset = "0xB22F90", Length = "0x194")]
	private void UpdateSliderLabelWithFormat(ConsoleSlider slider, string format, float min, float max, int numFramesInTab)
	{
	}

	[Token(Token = "0x60039E5")]
	[Address(RVA = "0xB24330", Offset = "0xB23130", Length = "0x239")]
	private void RefreshSliderLabel(UISlider slider)
	{
	}

	[Token(Token = "0x60039E6")]
	[Address(RVA = "0xB24570", Offset = "0xB23370", Length = "0x47E")]
	private bool IsHoveringOverGameObject(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x60039E7")]
	[Address(RVA = "0xB249F0", Offset = "0xB237F0", Length = "0x80")]
	public void OnResetKeyBindings()
	{
	}

	[Token(Token = "0x60039E8")]
	[Address(RVA = "0xB24A70", Offset = "0xB23870", Length = "0x1A7")]
	public void OnKeyRebindButtonPress(GameObject buttonPressed)
	{
	}

	[Token(Token = "0x60039E9")]
	[Address(RVA = "0xB24C20", Offset = "0xB23A20", Length = "0x5D")]
	public void OnRebindingTab()
	{
	}

	[Token(Token = "0x60039EA")]
	[Address(RVA = "0xB24C80", Offset = "0xB23A80", Length = "0x2C2")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60039EB")]
	[Address(RVA = "0xB24F50", Offset = "0xB23D50", Length = "0x69")]
	private void ProcessKeyRebindMenu()
	{
	}

	[Token(Token = "0x60039EC")]
	[Address(RVA = "0xB24FC0", Offset = "0xB23DC0", Length = "0x36")]
	private bool UpdateKeyBindings()
	{
		return false;
	}

	[Token(Token = "0x60039ED")]
	[Address(RVA = "0xB25000", Offset = "0xB23E00", Length = "0xF9")]
	private void CancelRebindPopup()
	{
	}

	[Token(Token = "0x60039EE")]
	[Address(RVA = "0xB25100", Offset = "0xB23F00", Length = "0xD37")]
	public static string GetLanguageStringFromSystemLang()
	{
		return null;
	}

	[Token(Token = "0x60039EF")]
	[Address(RVA = "0xB25E40", Offset = "0xB24C40", Length = "0x583")]
	private void RefreshLanguage()
	{
	}

	[Token(Token = "0x60039F0")]
	[Address(RVA = "0xB263D0", Offset = "0xB251D0", Length = "0x5D1")]
	private void SetLanguage(string langState)
	{
	}

	[Token(Token = "0x60039F1")]
	[Address(RVA = "0xB269B0", Offset = "0xB257B0", Length = "0x2B6")]
	private string GetLangIDFromName(string langName)
	{
		return null;
	}

	[Token(Token = "0x60039F2")]
	[Address(RVA = "0xB26C70", Offset = "0xB25A70", Length = "0x2C")]
	public void OnPrivacyTab()
	{
	}

	[Token(Token = "0x60039F3")]
	[Address(RVA = "0xB26CA0", Offset = "0xB25AA0", Length = "0xAE")]
	public void OnViewPrivacyPolicy()
	{
	}

	[Token(Token = "0x60039F4")]
	[Address(RVA = "0xB26D50", Offset = "0xB25B50", Length = "0xA1")]
	private static void OnManagePrivacyDataFailed(string reason)
	{
	}

	[Token(Token = "0x60039F5")]
	[Address(RVA = "0xB26E00", Offset = "0xB25C00", Length = "0xD8")]
	public void OnManagePrivacyData()
	{
	}

	[Token(Token = "0x60039F6")]
	[Address(RVA = "0xB26EE0", Offset = "0xB25CE0", Length = "0x3E5")]
	private void InitializePrivacyMenuItems()
	{
	}

	[Token(Token = "0x60039F7")]
	[Address(RVA = "0xB272D0", Offset = "0xB260D0", Length = "0x52E")]
	private void ProcessPrivacyMenu()
	{
	}

	[Token(Token = "0x60039F8")]
	[Address(RVA = "0xB27800", Offset = "0xB26600", Length = "0x160")]
	private void RefreshPrivacySettings()
	{
	}

	[Token(Token = "0x60039F9")]
	[Address(RVA = "0xB27970", Offset = "0xB26770", Length = "0x1A2")]
	private void OnConfirmPrivacySettings()
	{
	}

	[Token(Token = "0x60039FA")]
	[Address(RVA = "0xB27B20", Offset = "0xB26920", Length = "0x2C")]
	public void OnQualityTab()
	{
	}

	[Token(Token = "0x60039FB")]
	[Address(RVA = "0xB27B50", Offset = "0xB26950", Length = "0x1822")]
	private void InitializeQualityMenuItems()
	{
	}

	[Token(Token = "0x60039FC")]
	[Address(RVA = "0xB29380", Offset = "0xB28180", Length = "0x1C2")]
	private void ProcessQualityMenu()
	{
	}

	[Token(Token = "0x60039FD")]
	[Address(RVA = "0xB29550", Offset = "0xB28350", Length = "0x288")]
	private string GetQualityLevelString(Quality quality)
	{
		return null;
	}

	[Token(Token = "0x60039FE")]
	[Address(RVA = "0xB29820", Offset = "0xB28620", Length = "0x160")]
	private string GetPostFxQualityLevelString(QualityPostFx quality)
	{
		return null;
	}

	[Token(Token = "0x60039FF")]
	[Address(RVA = "0xB29980", Offset = "0xB28780", Length = "0x135")]
	private string GetAntiAliasingQualityLevelString(QualityAntiAliasing quality)
	{
		return null;
	}

	[Token(Token = "0x6003A00")]
	[Address(RVA = "0xB29AC0", Offset = "0xB288C0", Length = "0x135")]
	private string GetMotionBlurQualityLevelString(QualityMotionBlur quality)
	{
		return null;
	}

	[Token(Token = "0x6003A01")]
	[Address(RVA = "0xB29C00", Offset = "0xB28A00", Length = "0x231")]
	private QualityPostFx GetPostFxQualityLevelFromString(string quality)
	{
		return default(QualityPostFx);
	}

	[Token(Token = "0x6003A02")]
	[Address(RVA = "0xB29E40", Offset = "0xB28C40", Length = "0x160")]
	private string GetAnisotropicQualityLevelString(QualityAnisotropy quality)
	{
		return null;
	}

	[Token(Token = "0x6003A03")]
	[Address(RVA = "0xB29FA0", Offset = "0xB28DA0", Length = "0x178")]
	private string GetFootprintQualityLevelString(QualityFootprints quality)
	{
		return null;
	}

	[Token(Token = "0x6003A04")]
	[Address(RVA = "0xB2A130", Offset = "0xB28F30", Length = "0x231")]
	private QualityFootprints GetFootprintQualityLevelFromString(string quality)
	{
		return default(QualityFootprints);
	}

	[Token(Token = "0x6003A05")]
	[Address(RVA = "0xB2A370", Offset = "0xB29170", Length = "0x160")]
	private string GetSSAOLevelString(QualitySSAO quality)
	{
		return null;
	}

	[Token(Token = "0x6003A06")]
	[Address(RVA = "0xB2A4D0", Offset = "0xB292D0", Length = "0x254")]
	private QualityAnisotropy GetAnisotropicFilteringFromString(string quality)
	{
		return default(QualityAnisotropy);
	}

	[Token(Token = "0x6003A07")]
	[Address(RVA = "0xB2A730", Offset = "0xB29530", Length = "0x231")]
	private QualitySSAO GetSSAOLevelFromString(string quality)
	{
		return default(QualitySSAO);
	}

	[Token(Token = "0x6003A08")]
	[Address(RVA = "0xB2A970", Offset = "0xB29770", Length = "0xB4")]
	private string GetShadowQualityString(QualityShadows quality)
	{
		return null;
	}

	[Token(Token = "0x6003A09")]
	[Address(RVA = "0xB2AAE0", Offset = "0xB298E0", Length = "0x231")]
	private QualityShadows GetShadowQualityFromString(string res)
	{
		return default(QualityShadows);
	}

	[Token(Token = "0x6003A0A")]
	[Address(RVA = "0xB2AD20", Offset = "0xB29B20", Length = "0x135")]
	private string GetShadowResolutionString(ShadowResolution res)
	{
		return null;
	}

	[Token(Token = "0x6003A0B")]
	[Address(RVA = "0xB2AE60", Offset = "0xB29C60", Length = "0x1D4")]
	private ShadowResolution GetShadowResolutionFromString(string res)
	{
		return default(ShadowResolution);
	}

	[Token(Token = "0x6003A0C")]
	[Address(RVA = "0xB2B040", Offset = "0xB29E40", Length = "0x1D8")]
	private QualityAntiAliasing GetAntiAliasingQualityFromString(string res)
	{
		return default(QualityAntiAliasing);
	}

	[Token(Token = "0x6003A0D")]
	[Address(RVA = "0xB2B220", Offset = "0xB2A020", Length = "0x1D8")]
	private QualityMotionBlur GetMotionBlurQualityFromString(string res)
	{
		return default(QualityMotionBlur);
	}

	[Token(Token = "0x6003A0E")]
	[Address(RVA = "0xB2B400", Offset = "0xB2A200", Length = "0x1CF")]
	private void SetTextureStreamingFromString(string setting, out bool enabled, out int budget)
	{
		enabled = default(bool);
		budget = default(int);
	}

	[Token(Token = "0x6003A0F")]
	[Address(RVA = "0xB2B5D0", Offset = "0xB2A3D0", Length = "0xE0")]
	private string GetTextureStreamingString(bool enabled, int budget)
	{
		return null;
	}

	[Token(Token = "0x6003A10")]
	[Address(RVA = "0xB2B6B0", Offset = "0xB2A4B0", Length = "0x10A")]
	private string GetTextureResolutionString(int textureLimit)
	{
		return null;
	}

	[Token(Token = "0x6003A11")]
	[Address(RVA = "0xB2B7C0", Offset = "0xB2A5C0", Length = "0x17B")]
	private int GetTextureResolutionFromString(string textureLimit)
	{
		return 0;
	}

	[Token(Token = "0x6003A12")]
	[Address(RVA = "0xB2B940", Offset = "0xB2A740", Length = "0x135")]
	private string GetTerrainLodQualityString(QualityTerrainLod quality)
	{
		return null;
	}

	[Token(Token = "0x6003A13")]
	[Address(RVA = "0xB2BA80", Offset = "0xB2A880", Length = "0x1D4")]
	private QualityTerrainLod GetTerrainLodQualityFromString(string quality)
	{
		return default(QualityTerrainLod);
	}

	[Token(Token = "0x6003A14")]
	[Address(RVA = "0xB2BC60", Offset = "0xB2AA60", Length = "0x135")]
	private string GetLodBiasQualityString(QualityLodBias quality)
	{
		return null;
	}

	[Token(Token = "0x6003A15")]
	[Address(RVA = "0xB2BDA0", Offset = "0xB2ABA0", Length = "0x1D4")]
	private QualityLodBias GetLodBiasQualityFromString(string quality)
	{
		return default(QualityLodBias);
	}

	[Token(Token = "0x6003A16")]
	[Address(RVA = "0xB2BF80", Offset = "0xB2AD80", Length = "0x5FB")]
	private Quality GetQualityLevelFromString(string level)
	{
		return default(Quality);
	}

	[Token(Token = "0x6003A17")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void RefreshQualitySliderLabels()
	{
	}

	[Token(Token = "0x6003A18")]
	[Address(RVA = "0xB2C580", Offset = "0xB2B380", Length = "0x30E")]
	private void OnBeforeSerialization(SettingsState settingsState)
	{
	}

	[Token(Token = "0x6003A19")]
	[Address(RVA = "0xB2C890", Offset = "0xB2B690", Length = "0x37C")]
	private void OnAfterDeserialization(SettingsState settingsState)
	{
	}

	[Token(Token = "0x6003A1A")]
	[Address(RVA = "0xB2CC10", Offset = "0xB2BA10", Length = "0x633")]
	private void ValidateSettingsState(SettingsState settingsState)
	{
	}

	[Token(Token = "0x6003A1B")]
	[Address(RVA = "0xB2D250", Offset = "0xB2C050", Length = "0x3A3")]
	private void DoSafetyChecksOnCurrentState(SettingsState settingsState)
	{
	}

	[Token(Token = "0x6003A1C")]
	[Address(RVA = "0xB2D600", Offset = "0xB2C400", Length = "0x2CA")]
	private void MaybeSwitchToCustomQuality(QualityLevelSettings preset, QualityLevelSettings current)
	{
	}

	[Token(Token = "0x6003A1D")]
	[Address(RVA = "0xB2D8D0", Offset = "0xB2C6D0", Length = "0x14F")]
	private void OnConfirmSharedQualitySettings()
	{
	}

	[Token(Token = "0x6003A1E")]
	[Address(RVA = "0xB2D8D0", Offset = "0xB2C6D0", Length = "0x14F")]
	private void ApplyQualitySettings()
	{
	}

	[Token(Token = "0x6003A1F")]
	[Address(RVA = "0xB2DA20", Offset = "0xB2C820", Length = "0x12D")]
	private void ProcessSharedQualityMenu()
	{
	}

	[Token(Token = "0x6003A20")]
	[Address(RVA = "0xB2DB50", Offset = "0xB2C950", Length = "0x121")]
	private void RefreshSharedQualitySettings()
	{
	}

	[Token(Token = "0x6003A21")]
	[Address(RVA = "0xB2DB50", Offset = "0xB2C950", Length = "0x121")]
	private void ApplyRefreshQualitySettings()
	{
	}

	[Token(Token = "0x6003A22")]
	[Address(RVA = "0xB2DC80", Offset = "0xB2CA80", Length = "0x672")]
	private void SetQualitySettingsFromUi(QualityLevelSettings settings)
	{
	}

	[Token(Token = "0x6003A23")]
	[Address(RVA = "0xB2E300", Offset = "0xB2D100", Length = "0x122C")]
	private void SetUiFromQualitySetting(QualityLevelSettings settings)
	{
	}

	[Token(Token = "0x6003A24")]
	[Address(RVA = "0xB2F560", Offset = "0xB2E360", Length = "0xE8")]
	private void InitializeTopMenu()
	{
	}

	[Token(Token = "0x6003A25")]
	[Address(RVA = "0xB2F650", Offset = "0xB2E450", Length = "0x330")]
	private void InitializeTabs()
	{
	}

	[Token(Token = "0x6003A26")]
	[Address(RVA = "0xB2F990", Offset = "0xB2E790", Length = "0x7")]
	private void InitializeTopMenuItems()
	{
	}

	[Token(Token = "0x6003A27")]
	[Address(RVA = "0xB2F9A0", Offset = "0xB2E7A0", Length = "0x123")]
	private void ProcessTopMenu()
	{
	}

	[Token(Token = "0x6003A28")]
	[Address(RVA = "0xB2FAD0", Offset = "0xB2E8D0", Length = "0x25E")]
	private Action GetActionFromType(OptionTopMenuItem.MenuType type)
	{
		return null;
	}

	[Token(Token = "0x6003A29")]
	[Address(RVA = "0xB2FD30", Offset = "0xB2EB30", Length = "0x266")]
	private void AddMenuItem(int itemIndex, BasicMenu menu, List<OptionTopMenuItem> menuItems)
	{
	}

	[Token(Token = "0x6003A2A")]
	[Address(RVA = "0xB2FFA0", Offset = "0xB2EDA0", Length = "0x29")]
	private int GetTabSelectedIndex()
	{
		return 0;
	}

	[Token(Token = "0x6003A2B")]
	[Address(RVA = "0xB2FFD0", Offset = "0xB2EDD0", Length = "0x358")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003A2C")]
	[Address(RVA = "0xB30330", Offset = "0xB2F130", Length = "0x22C")]
	private void MainMenuTabOnEnable()
	{
	}

	[Token(Token = "0x6003A2D")]
	[Address(RVA = "0xB30560", Offset = "0xB2F360", Length = "0x171")]
	private void SetAllTabsActive(bool active)
	{
	}

	[Token(Token = "0x6003A2E")]
	[Address(RVA = "0xB306E0", Offset = "0xB2F4E0", Length = "0x1FB")]
	private void SetTabActive(GameObject go)
	{
	}

	[Token(Token = "0x6003A2F")]
	[Address(RVA = "0xB308E0", Offset = "0xB2F6E0", Length = "0xE8")]
	private void InitializeVisualsMenuItems()
	{
	}

	[Token(Token = "0x6003A30")]
	[Address(RVA = "0xB309D0", Offset = "0xB2F7D0", Length = "0x24F")]
	private void OnVisualsTab()
	{
	}

	[Token(Token = "0x6003A31")]
	[Address(RVA = "0xB30C20", Offset = "0xB2FA20", Length = "0x2F")]
	private void BackToVisualsMenu()
	{
	}

	[Token(Token = "0x6003A32")]
	[Address(RVA = "0xB30C50", Offset = "0xB2FA50", Length = "0x123")]
	private void ProcessVisualsMenu()
	{
	}

	[Token(Token = "0x6003A33")]
	[Address(RVA = "0xB30D80", Offset = "0xB2FB80", Length = "0x1E9")]
	private void ConfigureVisualsMenu()
	{
	}

	[Token(Token = "0x6003A34")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	private bool ShowExpandedVisualsMenu()
	{
		return false;
	}

	[Token(Token = "0x6003A35")]
	[Address(RVA = "0xB30F70", Offset = "0xB2FD70", Length = "0xAAA")]
	public Panel_OptionsMenu()
	{
	}
}
