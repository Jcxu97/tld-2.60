using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000644")]
public class Panel_Debug : Panel_AutoReferenced
{
	[Token(Token = "0x2000645")]
	public class DebugElement
	{
		[Token(Token = "0x4003C54")]
		[FieldOffset(Offset = "0x10")]
		public string m_Name;

		[Token(Token = "0x4003C55")]
		[FieldOffset(Offset = "0x18")]
		public string m_SetName;

		[Token(Token = "0x4003C56")]
		[FieldOffset(Offset = "0x20")]
		public string m_Initial;

		[Token(Token = "0x4003C57")]
		[FieldOffset(Offset = "0x28")]
		public string[] m_Options;

		[Token(Token = "0x4003C58")]
		[FieldOffset(Offset = "0x30")]
		private Func<ConsoleComboBox, bool> m_OnApplyDelegate;

		[Token(Token = "0x4003C59")]
		[FieldOffset(Offset = "0x38")]
		private Func<string[]> m_PopulateOptionsDelegate;

		[Token(Token = "0x4003C5A")]
		[FieldOffset(Offset = "0x40")]
		private Func<string> m_GetInitialValueDelegate;

		[Token(Token = "0x4003C5B")]
		[FieldOffset(Offset = "0x48")]
		private ConsoleComboBox m_ConsoleComboBox;

		[Token(Token = "0x60032C2")]
		[Address(RVA = "0x9F9750", Offset = "0x9F8550", Length = "0x114")]
		private DebugElement(string name, string setName, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[Token(Token = "0x60032C3")]
		[Address(RVA = "0x9F9870", Offset = "0x9F8670", Length = "0xD4")]
		public DebugElement(string name, string setName, string initial, string[] options, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[Token(Token = "0x60032C4")]
		[Address(RVA = "0x9F9950", Offset = "0x9F8750", Length = "0xD4")]
		public DebugElement(string name, string setName, string initial, Func<string[]> populateOptionsDelegate, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[Token(Token = "0x60032C5")]
		[Address(RVA = "0x9F9A30", Offset = "0x9F8830", Length = "0xD4")]
		public DebugElement(string name, string setName, Func<string> getInitialValueDelegate, string[] options, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[Token(Token = "0x60032C6")]
		[Address(RVA = "0x9F9B10", Offset = "0x9F8910", Length = "0xD4")]
		public DebugElement(string name, string setName, Func<string> getInitialValueDelegate, Func<string[]> populateOptionsDelegate, Func<ConsoleComboBox, bool> onApplyDelegate)
		{
		}

		[Token(Token = "0x60032C7")]
		[Address(RVA = "0x9F9BF0", Offset = "0x9F89F0", Length = "0x302")]
		public void AssignComboBox(ConsoleComboBox comboBox)
		{
		}

		[Token(Token = "0x60032C8")]
		[Address(RVA = "0x9F9F00", Offset = "0x9F8D00", Length = "0x103")]
		public bool OnApply()
		{
			return false;
		}
	}

	[Token(Token = "0x2000646")]
	public class Location
	{
		[Token(Token = "0x4003C5C")]
		[FieldOffset(Offset = "0x10")]
		public string m_Scene;

		[Token(Token = "0x4003C5D")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 m_Coordinates;

		[Token(Token = "0x4003C5E")]
		[FieldOffset(Offset = "0x28")]
		public string m_LocId;

		[Token(Token = "0x4003C5F")]
		[FieldOffset(Offset = "0x30")]
		public string m_EnglishLocationName;

		[Token(Token = "0x60032C9")]
		[Address(RVA = "0x9FA010", Offset = "0x9F8E10", Length = "0x10F")]
		public Location(string scene, Vector3 coordinates, string locId, string englishLocaitonName)
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2000647")]
	private sealed class _003CApplySetObjectHPPercentCoroutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003C60")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003C61")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003C62")]
		[FieldOffset(Offset = "0x20")]
		public float percentage;

		[Token(Token = "0x170002EF")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60032CD")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F0")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60032CF")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60032CA")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CApplySetObjectHPPercentCoroutine_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60032CB")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60032CC")]
		[Address(RVA = "0x9FA120", Offset = "0x9F8F20", Length = "0xF3")]
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
		[Token(Token = "0x60032CE")]
		[Address(RVA = "0x9FA220", Offset = "0x9F9020", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003C46")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x4003C47")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_Map> m_Map;

	[SerializeField]
	[Token(Token = "0x4003C48")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	[SerializeField]
	[Token(Token = "0x4003C49")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_OptionsMenu> m_Options;

	[Space]
	[Token(Token = "0x4003C4A")]
	[FieldOffset(Offset = "0x50")]
	public Texture m_DebugAiBackgroundTexture;

	[Token(Token = "0x4003C4B")]
	[FieldOffset(Offset = "0x58")]
	private bool m_ResumeGameOnExit;

	[Token(Token = "0x4003C4C")]
	private static Panel_Debug s_Instance;

	[Token(Token = "0x4003C4D")]
	[FieldOffset(Offset = "0x60")]
	public ConsoleComboBox[] m_ComboBoxes;

	[Token(Token = "0x4003C4E")]
	[FieldOffset(Offset = "0x68")]
	private List<DebugElement> m_Elements;

	[Token(Token = "0x4003C4F")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<string, List<DebugElement>> m_SetDictionary;

	[Token(Token = "0x4003C50")]
	[FieldOffset(Offset = "0x78")]
	private List<string> m_SetNames;

	[Token(Token = "0x4003C51")]
	[FieldOffset(Offset = "0x80")]
	public float m_MenuItemSpacing;

	[Token(Token = "0x4003C52")]
	[FieldOffset(Offset = "0x88")]
	public List<string> m_LocationList;

	[Token(Token = "0x4003C53")]
	[FieldOffset(Offset = "0x90")]
	public Dictionary<string, List<Location>> m_LocationLookup;

	[Token(Token = "0x6003270")]
	[Address(RVA = "0x9EEF50", Offset = "0x9EDD50", Length = "0x1CA2")]
	private void InitializeOptions()
	{
	}

	[Token(Token = "0x6003271")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void InitializeSet()
	{
	}

	[Token(Token = "0x6003272")]
	[Address(RVA = "0x9F0C00", Offset = "0x9EFA00", Length = "0x97")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6003273")]
	[Address(RVA = "0x9F0CA0", Offset = "0x9EFAA0", Length = "0x11")]
	private void Update()
	{
	}

	[Token(Token = "0x6003274")]
	[Address(RVA = "0x9F0CC0", Offset = "0x9EFAC0", Length = "0xE3")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003275")]
	[Address(RVA = "0x9F0DB0", Offset = "0x9EFBB0", Length = "0xA7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003276")]
	[Address(RVA = "0x9F0E60", Offset = "0x9EFC60", Length = "0x94")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003277")]
	[Address(RVA = "0x9F0F00", Offset = "0x9EFD00", Length = "0x45")]
	public void OnBack()
	{
	}

	[Token(Token = "0x6003278")]
	[Address(RVA = "0x9F0E60", Offset = "0x9EFC60", Length = "0x94")]
	private void ExitDebugPanel()
	{
	}

	[Token(Token = "0x6003279")]
	[Address(RVA = "0x9F0F50", Offset = "0x9EFD50", Length = "0x75")]
	public void OnDebugPanelNav()
	{
	}

	[Token(Token = "0x600327A")]
	[Address(RVA = "0x9F0FD0", Offset = "0x9EFDD0", Length = "0x203")]
	private void SetLineActive(int index, bool state)
	{
	}

	[Token(Token = "0x600327B")]
	[Address(RVA = "0x9F11E0", Offset = "0x9EFFE0", Length = "0xE9")]
	private bool ApplyTerrainTrees(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600327C")]
	[Address(RVA = "0x9F12D0", Offset = "0x9F00D0", Length = "0x187")]
	private bool ApplyInstanceTrees(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600327D")]
	[Address(RVA = "0x9F1460", Offset = "0x9F0260", Length = "0x1F9")]
	private bool ApplyRenderObjectInstances(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600327E")]
	[Address(RVA = "0x9F1660", Offset = "0x9F0460", Length = "0x174")]
	private bool ApplyAiFrustimCulling(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600327F")]
	[Address(RVA = "0x9F17E0", Offset = "0x9F05E0", Length = "0x177")]
	private bool ApplyFilterWorldLightsForFp(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003280")]
	[Address(RVA = "0x9F1960", Offset = "0x9F0760", Length = "0x17D")]
	private bool ApplyShadows(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003281")]
	[Address(RVA = "0x9F1AE0", Offset = "0x9F08E0", Length = "0x180")]
	private bool ApplySpecular(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003282")]
	[Address(RVA = "0x9F1C70", Offset = "0x9F0A70", Length = "0xA0")]
	private bool ApplyDebugTerrain(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003283")]
	[Address(RVA = "0x9F1D20", Offset = "0x9F0B20", Length = "0x121")]
	private bool ApplyTerrainPixelError(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003284")]
	[Address(RVA = "0x9F1E50", Offset = "0x9F0C50", Length = "0x150")]
	private bool ApplyToggleVsync(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003285")]
	[Address(RVA = "0x9F1FB0", Offset = "0x9F0DB0", Length = "0x106")]
	private static string[] PopulateAchievements()
	{
		return null;
	}

	[Token(Token = "0x6003286")]
	[Address(RVA = "0x9F20C0", Offset = "0x9F0EC0", Length = "0x367")]
	private bool UnlockAchievement(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003287")]
	[Address(RVA = "0x9F2430", Offset = "0x9F1230", Length = "0x2AB")]
	private static bool UnlockEpisode(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003288")]
	[Address(RVA = "0x9F26E0", Offset = "0x9F14E0", Length = "0x231")]
	private bool ApplySurvey(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003289")]
	[Address(RVA = "0x9F2920", Offset = "0x9F1720", Length = "0x210")]
	private static string[] PopulateSetObjectHPPercent()
	{
		return null;
	}

	[Token(Token = "0x600328A")]
	[Address(RVA = "0x9F2B40", Offset = "0x9F1940", Length = "0x3CA")]
	private static string[] PopulateDecorationItems()
	{
		return null;
	}

	[Token(Token = "0x600328B")]
	[Address(RVA = "0x9F2F10", Offset = "0x9F1D10", Length = "0x1EF")]
	private bool ApplySetObjectHPPercent(ConsoleComboBox comboBox)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CApplySetObjectHPPercentCoroutine_003Ed__41))]
	[Token(Token = "0x600328C")]
	[Address(RVA = "0x9F3100", Offset = "0x9F1F00", Length = "0x4F")]
	private IEnumerator ApplySetObjectHPPercentCoroutine(float percentage)
	{
		return null;
	}

	[Token(Token = "0x600328D")]
	[Address(RVA = "0x9F3150", Offset = "0x9F1F50", Length = "0xDB")]
	private bool ApplySpawnDecorationItem(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600328E")]
	[Address(RVA = "0x9F3230", Offset = "0x9F2030", Length = "0xBE")]
	private bool ApplySpawnNextDecorationItem(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600328F")]
	[Address(RVA = "0x9F32F0", Offset = "0x9F20F0", Length = "0xDB")]
	private bool ApplyVitaminC(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003290")]
	[Address(RVA = "0x9F33D0", Offset = "0x9F21D0", Length = "0x1F8")]
	private bool ApplyToggleEnableScurvy(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x6003291")]
	[Address(RVA = "0x9F35D0", Offset = "0x9F23D0", Length = "0x3CB")]
	private string[] PopulateLoadZoneOptions()
	{
		return null;
	}

	[Token(Token = "0x6003292")]
	[Address(RVA = "0x9F39A0", Offset = "0x9F27A0", Length = "0xFEF")]
	private string[] PopulateLoadInteriorOptions()
	{
		return null;
	}

	[Token(Token = "0x6003293")]
	[Address(RVA = "0x9F4990", Offset = "0x9F3790", Length = "0x8DC")]
	private void GenerateLocationLookup()
	{
	}

	[Token(Token = "0x6003294")]
	[Address(RVA = "0x9F5270", Offset = "0x9F4070", Length = "0x582")]
	public void GenerateLocationList()
	{
	}

	[Token(Token = "0x6003295")]
	[Address(RVA = "0x9F5800", Offset = "0x9F4600", Length = "0xF7")]
	private string GetCurrentRegion()
	{
		return null;
	}

	[Token(Token = "0x6003296")]
	[Address(RVA = "0x9F5900", Offset = "0x9F4700", Length = "0x49")]
	public string[] PopulateTimelineOptionsToArray()
	{
		return null;
	}

	[Token(Token = "0x6003297")]
	[Address(RVA = "0x9F5950", Offset = "0x9F4750", Length = "0x36A")]
	public static List<string> PopulateTimelineOptions()
	{
		return null;
	}

	[Token(Token = "0x6003298")]
	[Address(RVA = "0x9F5CC0", Offset = "0x9F4AC0", Length = "0x4C")]
	private string[] PopulateLoadLocationOptions()
	{
		return null;
	}

	[Token(Token = "0x6003299")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	private bool ApplyLoadLocationLoad(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600329A")]
	[Address(RVA = "0x9F5D10", Offset = "0x9F4B10", Length = "0x1C2")]
	private bool ApplyShowTODSlider(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600329B")]
	[Address(RVA = "0x9F5EE0", Offset = "0x9F4CE0", Length = "0x45")]
	private string[] PopulateMovieOptions()
	{
		return null;
	}

	[Token(Token = "0x600329C")]
	[Address(RVA = "0x9F5F30", Offset = "0x9F4D30", Length = "0x150")]
	private bool ApplyPlayMovie(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600329D")]
	[Address(RVA = "0x9F6080", Offset = "0x9F4E80", Length = "0x1E6")]
	private bool ApplyPlayTimeline(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600329E")]
	[Address(RVA = "0x9F6270", Offset = "0x9F5070", Length = "0x206")]
	private bool ApplyShowDaysSurvived(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x600329F")]
	[Address(RVA = "0x9F6480", Offset = "0x9F5280", Length = "0xFE")]
	private bool Toggle4DON(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032A0")]
	[Address(RVA = "0x9F6580", Offset = "0x9F5380", Length = "0x10F")]
	private bool OverrideDay4DON(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032A1")]
	[Address(RVA = "0x9F6690", Offset = "0x9F5490", Length = "0x82")]
	private bool TransitionToDay4DON(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032A2")]
	[Address(RVA = "0x9F6720", Offset = "0x9F5520", Length = "0xC6")]
	private bool CompleteTimer4DON(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032A3")]
	[Address(RVA = "0x9F67F0", Offset = "0x9F55F0", Length = "0xC6")]
	private bool ResetBadgeProgress4DON(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032A4")]
	[Address(RVA = "0x9F68C0", Offset = "0x9F56C0", Length = "0xA6")]
	private bool DisableAimBreathing(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032A5")]
	[Address(RVA = "0x9F6970", Offset = "0x9F5770", Length = "0xA6")]
	private bool DisableAimSway(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032A6")]
	[Address(RVA = "0x9F6A20", Offset = "0x9F5820", Length = "0xA6")]
	private bool DisableAimStamina(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032A7")]
	[Address(RVA = "0x9F6AD0", Offset = "0x9F58D0", Length = "0xA6")]
	private bool DisableAimShake(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032A8")]
	[Address(RVA = "0x9F6B80", Offset = "0x9F5980", Length = "0xA6")]
	private bool DisableAmbientSway(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032A9")]
	[Address(RVA = "0x9F6C30", Offset = "0x9F5A30", Length = "0x1B6")]
	private bool DisableAimDepthOfField(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032AA")]
	[Address(RVA = "0x9F6DF0", Offset = "0x9F5BF0", Length = "0xC2")]
	private bool DisableAllAimingMotion(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032AB")]
	[Address(RVA = "0x9F6EC0", Offset = "0x9F5CC0", Length = "0x82")]
	private bool ChangeSteamControllerMenuScrollSensitivity(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032AC")]
	[Address(RVA = "0x9F6F50", Offset = "0x9F5D50", Length = "0x2F6")]
	private string[] PopulateSaveFiles()
	{
		return null;
	}

	[Token(Token = "0x60032AD")]
	[Address(RVA = "0x9F7250", Offset = "0x9F6050", Length = "0x294")]
	private bool LoadSelectedSave(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032AE")]
	[Address(RVA = "0x9F74F0", Offset = "0x9F62F0", Length = "0xB1")]
	private bool DeleteSelectedSave(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032AF")]
	[Address(RVA = "0x9F75B0", Offset = "0x9F63B0", Length = "0x10E")]
	private bool OverwriteSelectedSave(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032B0")]
	[Address(RVA = "0x9F76C0", Offset = "0x9F64C0", Length = "0xAE")]
	private bool ApplyListKnownDLC(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032B1")]
	[Address(RVA = "0x9F7770", Offset = "0x9F6570", Length = "0xAE")]
	private bool ApplyListAvailableDLC(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032B2")]
	[Address(RVA = "0x9F7820", Offset = "0x9F6620", Length = "0x321")]
	private bool UnlockAllRegionsDLC(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032B3")]
	[Address(RVA = "0x9F7B50", Offset = "0x9F6950", Length = "0xA7")]
	private bool ApplyTraderDebug(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032B4")]
	[Address(RVA = "0x9F7C00", Offset = "0x9F6A00", Length = "0xA7")]
	private bool ApplyTraderResetDrawnExchanges(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032B5")]
	[Address(RVA = "0x9F7CB0", Offset = "0x9F6AB0", Length = "0x24A")]
	private string[] PopulateTraderTrustSetOptions()
	{
		return null;
	}

	[Token(Token = "0x60032B6")]
	[Address(RVA = "0x9F7F00", Offset = "0x9F6D00", Length = "0x172")]
	private bool ApplyTraderTrustSet(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032B7")]
	[Address(RVA = "0x9F8080", Offset = "0x9F6E80", Length = "0x172")]
	private bool ApplyTraderTrustAdd(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032B8")]
	[Address(RVA = "0x9F8200", Offset = "0x9F7000", Length = "0x3DF")]
	private string[] PopulateTraderUnlockExchangeOptions()
	{
		return null;
	}

	[Token(Token = "0x60032B9")]
	[Address(RVA = "0x9F85E0", Offset = "0x9F73E0", Length = "0x173")]
	private bool ApplyTraderUnlockExchange(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032BA")]
	[Address(RVA = "0x9F8760", Offset = "0x9F7560", Length = "0x5E2")]
	private string[] PopulateTraderUnlockConversationOptions()
	{
		return null;
	}

	[Token(Token = "0x60032BB")]
	[Address(RVA = "0x9F8D50", Offset = "0x9F7B50", Length = "0x173")]
	private bool ApplyTraderUnlockConversation(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032BC")]
	[Address(RVA = "0x9F8ED0", Offset = "0x9F7CD0", Length = "0x299")]
	private string[] PopulateTraderUnlockImprovementOptions()
	{
		return null;
	}

	[Token(Token = "0x60032BD")]
	[Address(RVA = "0x9F9170", Offset = "0x9F7F70", Length = "0x173")]
	private bool ApplyTraderUnlockImprovement(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032BE")]
	[Address(RVA = "0x9F92F0", Offset = "0x9F80F0", Length = "0xA7")]
	private bool ApplyTraderTradeForceCompleted(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032BF")]
	[Address(RVA = "0x9F93A0", Offset = "0x9F81A0", Length = "0xA7")]
	private bool ApplyTraderTradeForceCompletedPerfectly(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032C0")]
	[Address(RVA = "0x9F9450", Offset = "0x9F8250", Length = "0x148")]
	private bool ApplyTraderTradeCancel(ConsoleComboBox comboBox)
	{
		return false;
	}

	[Token(Token = "0x60032C1")]
	[Address(RVA = "0x9F95A0", Offset = "0x9F83A0", Length = "0x1A1")]
	public Panel_Debug()
	{
	}
}
