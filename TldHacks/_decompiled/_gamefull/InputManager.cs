using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200075D")]
public class InputManager : MonoBehaviour
{
	[Token(Token = "0x200075E")]
	public enum InputAction
	{
		[Token(Token = "0x4004ECF")]
		AnyButton,
		[Token(Token = "0x4004ED0")]
		Up,
		[Token(Token = "0x4004ED1")]
		Down,
		[Token(Token = "0x4004ED2")]
		Left,
		[Token(Token = "0x4004ED3")]
		Right,
		[Token(Token = "0x4004ED4")]
		Interact,
		[Token(Token = "0x4004ED5")]
		Sprint,
		[Token(Token = "0x4004ED6")]
		Crouch,
		[Token(Token = "0x4004ED7")]
		Reload,
		[Token(Token = "0x4004ED8")]
		Equip,
		[Token(Token = "0x4004ED9")]
		PickUp,
		[Token(Token = "0x4004EDA")]
		PutBack,
		[Token(Token = "0x4004EDB")]
		Holster,
		[Token(Token = "0x4004EDC")]
		ActionsPanel,
		[Token(Token = "0x4004EDD")]
		Inventory,
		[Token(Token = "0x4004EDE")]
		PauseMenu,
		[Token(Token = "0x4004EDF")]
		Escape,
		[Token(Token = "0x4004EE0")]
		Continue,
		[Token(Token = "0x4004EE1")]
		StartFire,
		[Token(Token = "0x4004EE2")]
		LightSource,
		[Token(Token = "0x4004EE3")]
		Decoy,
		[Token(Token = "0x4004EE4")]
		Weapon,
		[Token(Token = "0x4004EE5")]
		Menu_ToolSelect,
		[Token(Token = "0x4004EE6")]
		Inventory_Drop,
		[Token(Token = "0x4004EE7")]
		Inventory_FilterLeft,
		[Token(Token = "0x4004EE8")]
		Inventory_FilterRight,
		[Token(Token = "0x4004EE9")]
		Inventory_Equip,
		[Token(Token = "0x4004EEA")]
		Inventory_Examine,
		[Token(Token = "0x4004EEB")]
		Inventory_Sort,
		[Token(Token = "0x4004EEC")]
		Container_SelectLeftTable,
		[Token(Token = "0x4004EED")]
		Container_SelectRightTable,
		[Token(Token = "0x4004EEE")]
		Options_Confirm,
		[Token(Token = "0x4004EEF")]
		Struggle_Tap,
		[Token(Token = "0x4004EF0")]
		FeedFire_TakeTorch,
		[Token(Token = "0x4004EF1")]
		Fire,
		[Token(Token = "0x4004EF2")]
		AltFire,
		[Token(Token = "0x4004EF3")]
		SafeCrackLeft,
		[Token(Token = "0x4004EF4")]
		SafeCrackRight,
		[Token(Token = "0x4004EF5")]
		ResetAllTimeStats,
		[Token(Token = "0x4004EF6")]
		Menu_Secondary_MoveLeft,
		[Token(Token = "0x4004EF7")]
		Menu_Secondary_MoveRight,
		[Token(Token = "0x4004EF8")]
		Menu_Secondary_MoveUp,
		[Token(Token = "0x4004EF9")]
		Menu_Secondary_MoveDown,
		[Token(Token = "0x4004EFA")]
		ShowSteamControllerBindings,
		[Token(Token = "0x4004EFB")]
		OpenRadial,
		[Token(Token = "0x4004EFC")]
		Rename,
		[Token(Token = "0x4004EFD")]
		Delete,
		[Token(Token = "0x4004EFE")]
		Overwrite,
		[Token(Token = "0x4004EFF")]
		SaveJournal,
		[Token(Token = "0x4004F00")]
		Carry,
		[Token(Token = "0x4004F01")]
		Quarter,
		[Token(Token = "0x4004F02")]
		HarvestCharcoal,
		[Token(Token = "0x4004F03")]
		TabLeft,
		[Token(Token = "0x4004F04")]
		TabRight,
		[Token(Token = "0x4004F05")]
		OpenMap,
		[Token(Token = "0x4004F06")]
		Inventory_AddToSatchel,
		[Token(Token = "0x4004F07")]
		Clothing,
		[Token(Token = "0x4004F08")]
		Journal,
		[Token(Token = "0x4004F09")]
		FirstAid,
		[Token(Token = "0x4004F0A")]
		QuickSave,
		[Token(Token = "0x4004F0B")]
		QuickLoad,
		[Token(Token = "0x4004F0C")]
		Menu_HinterlandMailingList,
		[Token(Token = "0x4004F0D")]
		Menu_SkyboundInsiders,
		[Token(Token = "0x4004F0E")]
		Scroll,
		[Token(Token = "0x4004F0F")]
		Interact_ScrollDown,
		[Token(Token = "0x4004F10")]
		Interact_ScrollUp,
		[Token(Token = "0x4004F11")]
		Compass,
		[Token(Token = "0x4004F12")]
		BuyNow,
		[Token(Token = "0x4004F13")]
		QuickSelectSlot1,
		[Token(Token = "0x4004F14")]
		QuickSelectSlot2,
		[Token(Token = "0x4004F15")]
		QuickSelectSlot3,
		[Token(Token = "0x4004F16")]
		QuickSelectSlot4,
		[Token(Token = "0x4004F17")]
		FlyModeMoveSlow,
		[Token(Token = "0x4004F18")]
		FlyModeMoveFast,
		[Token(Token = "0x4004F19")]
		FlyModeMoveUp,
		[Token(Token = "0x4004F1A")]
		FlyModeMoveDown,
		[Token(Token = "0x4004F1B")]
		FlyModeLockOrientation,
		[Token(Token = "0x4004F1C")]
		FlyModeAcceptPlacement,
		[Token(Token = "0x4004F1D")]
		FlyModeCancelPlacement,
		[Token(Token = "0x4004F1E")]
		FlyModeToggleEnabled1,
		[Token(Token = "0x4004F1F")]
		FlyModeToggleEnabled2,
		[Token(Token = "0x4004F20")]
		FlyModeToggleCoords,
		[Token(Token = "0x4004F21")]
		ShowAccountPicker,
		[Token(Token = "0x4004F22")]
		ShowStatsScreen,
		[Token(Token = "0x4004F23")]
		AutoWalk,
		[Token(Token = "0x4004F24")]
		RotateClockwise,
		[Token(Token = "0x4004F25")]
		RotateCounterClockwise,
		[Token(Token = "0x4004F26")]
		Crafting,
		[Token(Token = "0x4004F27")]
		Cooking,
		[Token(Token = "0x4004F28")]
		SafehouseCustomize
	}

	[Token(Token = "0x200075F")]
	public enum InputState
	{
		[Token(Token = "0x4004F2A")]
		Pressed,
		[Token(Token = "0x4004F2B")]
		Released
	}

	[Token(Token = "0x2000760")]
	public enum InputAxis
	{
		[Token(Token = "0x4004F2D")]
		Move,
		[Token(Token = "0x4004F2E")]
		MouseCamera,
		[Token(Token = "0x4004F2F")]
		JoystickCamera,
		[Token(Token = "0x4004F30")]
		Scroll
	}

	[Token(Token = "0x2000761")]
	public enum InputAxisState
	{
		[Token(Token = "0x4004F32")]
		AtRest,
		[Token(Token = "0x4004F33")]
		HasInput
	}

	[Token(Token = "0x2000762")]
	public enum ScreenshotOptions
	{
		[Token(Token = "0x4004F35")]
		None,
		[Token(Token = "0x4004F36")]
		Debug,
		[Token(Token = "0x4004F37")]
		HDR,
		[Token(Token = "0x4004F38")]
		HighRes
	}

	[Token(Token = "0x2000763")]
	private enum CursorState
	{
		[Token(Token = "0x4004F3A")]
		None,
		[Token(Token = "0x4004F3B")]
		Show,
		[Token(Token = "0x4004F3C")]
		ShowPending,
		[Token(Token = "0x4004F3D")]
		ShowReady,
		[Token(Token = "0x4004F3E")]
		Hide
	}

	[Token(Token = "0x2000764")]
	private enum LightSource
	{
		[Token(Token = "0x4004F40")]
		Flashlight,
		[Token(Token = "0x4004F41")]
		RedFlare,
		[Token(Token = "0x4004F42")]
		BlueFlare,
		[Token(Token = "0x4004F43")]
		Lamp,
		[Token(Token = "0x4004F44")]
		Torch,
		[Token(Token = "0x4004F45")]
		Match,
		[Token(Token = "0x4004F46")]
		None
	}

	[Token(Token = "0x2000765")]
	private delegate GearItem OnDelegate();

	[Token(Token = "0x2000766")]
	public enum ControllerType
	{
		[Token(Token = "0x4004F48")]
		Keyboard,
		[Token(Token = "0x4004F49")]
		Gamepad,
		[Token(Token = "0x4004F4A")]
		Both
	}

	[Token(Token = "0x4004E9C")]
	public static Dictionary<string, string> s_ButtonMapDesktop;

	[Token(Token = "0x4004E9D")]
	public static Dictionary<string, string> s_ButtonMapSteam;

	[Token(Token = "0x4004E9E")]
	public static Dictionary<string, string> s_ButtonMapPS4;

	[Token(Token = "0x4004E9F")]
	public static Dictionary<string, string> s_ButtonMapXbox;

	[Token(Token = "0x4004EA0")]
	public static Dictionary<string, string> s_ButtonMapSwitch;

	[Token(Token = "0x4004EA1")]
	public static InputManager instance;

	[Token(Token = "0x4004EA2")]
	public static InputSystemRewired m_InputSystem;

	[Token(Token = "0x4004EA3")]
	public static bool m_TouchControlsEnabled;

	[Token(Token = "0x4004EA4")]
	public static bool m_DebugShortcutsEnabled;

	[Token(Token = "0x4004EA5")]
	public static int m_LastCursorLockCounter;

	[Token(Token = "0x4004EA6")]
	public static bool m_IsRumbleEnabled;

	[Token(Token = "0x4004EA7")]
	public static bool s_IgnoreInput;

	[Token(Token = "0x4004EA8")]
	public static bool m_ShowResetBindingsConfirmation;

	[Token(Token = "0x4004EA9")]
	private static CursorState m_CursorState;

	[Token(Token = "0x4004EAA")]
	private static bool m_RestoreHudDisplayMode;

	[Token(Token = "0x4004EAB")]
	private static HudDisplayMode m_PendingScreenshotRestoreHudMode;

	[Token(Token = "0x4004EAC")]
	private static bool m_InteractedWithItemThisFrame;

	[Token(Token = "0x4004EAD")]
	private static int m_debugScreenshotCountdown;

	[Token(Token = "0x4004EAE")]
	private static int m_highResScreenshotCountdown;

	[Token(Token = "0x4004EAF")]
	private static int m_HDRScreenshotCountdown;

	[Token(Token = "0x4004EB0")]
	private static float m_ConsoleUnlockTime;

	[Token(Token = "0x4004EB1")]
	private static bool m_IsShowingControllerDisconnectedPanel;

	[Token(Token = "0x4004EB2")]
	private static float m_MoterIntensityLeft;

	[Token(Token = "0x4004EB3")]
	private static float m_MoterIntensityLeftTrigger;

	[Token(Token = "0x4004EB4")]
	private static float m_MoterIntensityRight;

	[Token(Token = "0x4004EB5")]
	private static float m_MoterIntensityRightTrigger;

	[Token(Token = "0x4004EB6")]
	private static EmergencyStim m_EmergencyStimUsed;

	[Token(Token = "0x4004EB7")]
	private static CameraGlobalRT m_CameraRenderTexture;

	[Token(Token = "0x4004EB8")]
	public static bool m_InputDebugEnabled;

	[Token(Token = "0x4004EB9")]
	private static bool m_HasFocus;

	[Token(Token = "0x4004EBA")]
	private static StringBuilder s_DebugStringBuilder;

	[SerializeField]
	[Token(Token = "0x4004EBB")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Actions> m_ActionsPanel;

	[SerializeField]
	[Token(Token = "0x4004EBC")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x4004EBD")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Clothing> m_ClothingPanel;

	[SerializeField]
	[Token(Token = "0x4004EBE")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_Crafting> m_CraftingPanel;

	[SerializeField]
	[Token(Token = "0x4004EBF")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_RecipeBook> m_RecipeBookPanel;

	[SerializeField]
	[Token(Token = "0x4004EC0")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_Debug> m_DebugPanel;

	[SerializeField]
	[Token(Token = "0x4004EC1")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_FirstAid> m_FirstAidPanel;

	[SerializeField]
	[Token(Token = "0x4004EC2")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_GearSelect> m_GearSelect;

	[SerializeField]
	[Token(Token = "0x4004EC3")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4004EC4")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4004EC5")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x4004EC6")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_Loading> m_LoadingPanel;

	[SerializeField]
	[Token(Token = "0x4004EC7")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_Log> m_LogPanel;

	[SerializeField]
	[Token(Token = "0x4004EC8")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_Map> m_MapPanel;

	[SerializeField]
	[Token(Token = "0x4004EC9")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	[SerializeField]
	[Token(Token = "0x4004ECA")]
	[FieldOffset(Offset = "0x98")]
	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	[Token(Token = "0x4004ECB")]
	private static List<MonoBehaviour> m_InputContexts;

	[Token(Token = "0x4004ECC")]
	private static float m_InputDisableTime;

	[Token(Token = "0x4004ECD")]
	private static MonoBehaviour m_CurrentContext;

	[Token(Token = "0x60043C5")]
	[Address(RVA = "0xC60060", Offset = "0xC5EE60", Length = "0x1FC")]
	public void Awake()
	{
	}

	[Token(Token = "0x60043C6")]
	[Address(RVA = "0xC60260", Offset = "0xC5F060", Length = "0x267")]
	public void Start()
	{
	}

	[Token(Token = "0x60043C7")]
	[Address(RVA = "0xC604D0", Offset = "0xC5F2D0", Length = "0x255")]
	public void Update()
	{
	}

	[Token(Token = "0x60043C8")]
	[Address(RVA = "0xC60730", Offset = "0xC5F530", Length = "0x57")]
	public static bool GetApplicationHasFocus()
	{
		return false;
	}

	[Token(Token = "0x60043C9")]
	[Address(RVA = "0xC60790", Offset = "0xC5F590", Length = "0x5C")]
	public void OnApplicationFocus(bool focusStatus)
	{
	}

	[Token(Token = "0x60043CA")]
	[Address(RVA = "0xC607F0", Offset = "0xC5F5F0", Length = "0x135")]
	public static bool HasPressedKey()
	{
		return false;
	}

	[Token(Token = "0x60043CB")]
	[Address(RVA = "0xC60930", Offset = "0xC5F730", Length = "0xEC")]
	public static void Process(MonoBehaviour context)
	{
	}

	[Token(Token = "0x60043CC")]
	[Address(RVA = "0xC60A20", Offset = "0xC5F820", Length = "0x414")]
	public static void ProcessScreenshotInput()
	{
	}

	[Token(Token = "0x60043CD")]
	[Address(RVA = "0xC60E40", Offset = "0xC5FC40", Length = "0xAD")]
	public static void ProcessTimeGatedUnlocks()
	{
	}

	[Token(Token = "0x60043CE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ProcessDebugInput()
	{
	}

	[Token(Token = "0x60043CF")]
	[Address(RVA = "0xC60EF0", Offset = "0xC5FCF0", Length = "0x17E")]
	public static void MaybeTakeScreenshot()
	{
	}

	[Token(Token = "0x60043D0")]
	[Address(RVA = "0xC61070", Offset = "0xC5FE70", Length = "0x7A")]
	public static float GetAxisRawMouseX(MonoBehaviour context)
	{
		return 0f;
	}

	[Token(Token = "0x60043D1")]
	[Address(RVA = "0xC610F0", Offset = "0xC5FEF0", Length = "0x7A")]
	public static float GetAxisRawMouseY(MonoBehaviour context)
	{
		return 0f;
	}

	[Token(Token = "0x60043D2")]
	[Address(RVA = "0xC61170", Offset = "0xC5FF70", Length = "0xEF")]
	public static float GetAxisMouseX(MonoBehaviour context)
	{
		return 0f;
	}

	[Token(Token = "0x60043D3")]
	[Address(RVA = "0xC61260", Offset = "0xC60060", Length = "0xEF")]
	public static float GetAxisMouseY(MonoBehaviour context)
	{
		return 0f;
	}

	[Token(Token = "0x60043D4")]
	[Address(RVA = "0xC61350", Offset = "0xC60150", Length = "0x7A")]
	public static float GetAxisScrollWheel(MonoBehaviour context)
	{
		return 0f;
	}

	[Token(Token = "0x60043D5")]
	[Address(RVA = "0xC613D0", Offset = "0xC601D0", Length = "0x129")]
	public static float GetScroll(MonoBehaviour context)
	{
		return 0f;
	}

	[Token(Token = "0x60043D6")]
	[Address(RVA = "0xC61500", Offset = "0xC60300", Length = "0xA9")]
	public static bool GetKeyDown(MonoBehaviour context, KeyCode key)
	{
		return false;
	}

	[Token(Token = "0x60043D7")]
	[Address(RVA = "0xC615B0", Offset = "0xC603B0", Length = "0x442")]
	public static bool CanInvokePauseMenu()
	{
		return false;
	}

	[Token(Token = "0x60043D8")]
	[Address(RVA = "0xC61A00", Offset = "0xC60800", Length = "0xC5")]
	public static void PauseGame()
	{
	}

	[Token(Token = "0x60043D9")]
	[Address(RVA = "0xC61AD0", Offset = "0xC608D0", Length = "0x278E")]
	private static void ProcessInput(MonoBehaviour context)
	{
	}

	[Token(Token = "0x60043DA")]
	[Address(RVA = "0xC64260", Offset = "0xC63060", Length = "0x595")]
	private static void OpenRadialMenu()
	{
	}

	[Token(Token = "0x60043DB")]
	[Address(RVA = "0xC64800", Offset = "0xC63600", Length = "0xBF2")]
	private static void ProcessFireAction(MonoBehaviour context, Panel_HUD hud)
	{
	}

	[Token(Token = "0x60043DC")]
	[Address(RVA = "0xC65400", Offset = "0xC64200", Length = "0x1D5")]
	private static void ProcessReleaseFireAction()
	{
	}

	[Token(Token = "0x60043DD")]
	[Address(RVA = "0xC655E0", Offset = "0xC643E0", Length = "0x160")]
	public static bool IsClickHoldActive()
	{
		return false;
	}

	[Token(Token = "0x60043DE")]
	[Address(RVA = "0xC65750", Offset = "0xC64550", Length = "0x167")]
	public static bool MaybeCancelClickHold(bool forceCancel = false)
	{
		return false;
	}

	[Token(Token = "0x60043DF")]
	[Address(RVA = "0xC658C0", Offset = "0xC646C0", Length = "0x6BD")]
	private static void ExecuteInventoryAction()
	{
	}

	[Token(Token = "0x60043E0")]
	[Address(RVA = "0xC65F80", Offset = "0xC64D80", Length = "0x362")]
	private static void ExecuteCraftingAction()
	{
	}

	[Token(Token = "0x60043E1")]
	[Address(RVA = "0xC662F0", Offset = "0xC650F0", Length = "0x362")]
	private static void ExecuteCookingAction()
	{
	}

	[Token(Token = "0x60043E2")]
	[Address(RVA = "0xC66660", Offset = "0xC65460", Length = "0x3D6")]
	private static void ExecuteClothingAction()
	{
	}

	[Token(Token = "0x60043E3")]
	[Address(RVA = "0xC66A40", Offset = "0xC65840", Length = "0x384")]
	private static void ExecuteJournalAction()
	{
	}

	[Token(Token = "0x60043E4")]
	[Address(RVA = "0xC66DD0", Offset = "0xC65BD0", Length = "0x301")]
	private static void ExecuteJournalActionFromMap(string missionId)
	{
	}

	[Token(Token = "0x60043E5")]
	[Address(RVA = "0xC670E0", Offset = "0xC65EE0", Length = "0x3A6")]
	private static void ExecuteJournalActionFromObjective(string missionId)
	{
	}

	[Token(Token = "0x60043E6")]
	[Address(RVA = "0xC67490", Offset = "0xC66290", Length = "0x362")]
	private static void ExecuteFirstAidAction()
	{
	}

	[Token(Token = "0x60043E7")]
	[Address(RVA = "0xC67800", Offset = "0xC66600", Length = "0x390")]
	private static void ExecuteOpenMapAction()
	{
	}

	[Token(Token = "0x60043E8")]
	[Address(RVA = "0xC67BA0", Offset = "0xC669A0", Length = "0x3B2")]
	private static void ExecuteOpenMapActionFromObjective(string missionId)
	{
	}

	[Token(Token = "0x60043E9")]
	[Address(RVA = "0xC67F60", Offset = "0xC66D60", Length = "0x6CB")]
	private static bool CanExecutePanelActivateAction()
	{
		return false;
	}

	[Token(Token = "0x60043EA")]
	[Address(RVA = "0xC68630", Offset = "0xC67430", Length = "0x516")]
	private static void MaybeClosePanelDueToHotkey()
	{
	}

	[Token(Token = "0x60043EB")]
	[Address(RVA = "0xC68B50", Offset = "0xC67950", Length = "0x1A4")]
	public static void ExecuteStrikeMatchAction()
	{
	}

	[Token(Token = "0x60043EC")]
	[Address(RVA = "0xC68D00", Offset = "0xC67B00", Length = "0x305")]
	private static LightSource GetCurrentLightSourceType()
	{
		return default(LightSource);
	}

	[Token(Token = "0x60043ED")]
	[Address(RVA = "0xC69010", Offset = "0xC67E10", Length = "0xF2")]
	public static void ExecuteLightSourceAction()
	{
	}

	[Token(Token = "0x60043EE")]
	[Address(RVA = "0xC69110", Offset = "0xC67F10", Length = "0x35C")]
	public static void ExecuteDecoyAction()
	{
	}

	[Token(Token = "0x60043EF")]
	[Address(RVA = "0xC69470", Offset = "0xC68270", Length = "0x127")]
	public static void ExecuteFirearmAction()
	{
	}

	[Token(Token = "0x60043F0")]
	[Address(RVA = "0xC695A0", Offset = "0xC683A0", Length = "0x1CB")]
	public static bool CanStartFireIndoors()
	{
		return false;
	}

	[Token(Token = "0x60043F1")]
	[Address(RVA = "0xC69770", Offset = "0xC68570", Length = "0x320")]
	public static bool ExecuteStartFireAction()
	{
		return false;
	}

	[Token(Token = "0x60043F2")]
	[Address(RVA = "0xC69AA0", Offset = "0xC688A0", Length = "0x331")]
	public static bool CanExecuteCrouchAction(bool playGUIError)
	{
		return false;
	}

	[Token(Token = "0x60043F3")]
	[Address(RVA = "0xC69DE0", Offset = "0xC68BE0", Length = "0x570")]
	private static void ExecuteSurvivalPanelAction()
	{
	}

	[Token(Token = "0x60043F4")]
	[Address(RVA = "0xC6A360", Offset = "0xC69160", Length = "0xC2")]
	private static void ExecuteSafehouseCustomizeAction()
	{
	}

	[Token(Token = "0x60043F5")]
	[Address(RVA = "0xC6A430", Offset = "0xC69230", Length = "0x17D")]
	private static bool IsInSurvivalPanelSubMenu()
	{
		return false;
	}

	[Token(Token = "0x60043F6")]
	[Address(RVA = "0xC6A5B0", Offset = "0xC693B0", Length = "0x219")]
	private static void DisableActiveSubMenu()
	{
	}

	[Token(Token = "0x60043F7")]
	[Address(RVA = "0xC6A7D0", Offset = "0xC695D0", Length = "0x313")]
	private static void ExecuteInteractAction()
	{
	}

	[Token(Token = "0x60043F8")]
	[Address(RVA = "0xC6AAF0", Offset = "0xC698F0", Length = "0x8CA")]
	private static void ExecuteAltFire()
	{
	}

	[Token(Token = "0x60043F9")]
	[Address(RVA = "0xC6B3C0", Offset = "0xC6A1C0", Length = "0x270")]
	private static void OnTorchMidSwing()
	{
	}

	[Token(Token = "0x60043FA")]
	[Address(RVA = "0xC6B640", Offset = "0xC6A440", Length = "0x369")]
	private static void ExecuteHolsterAction()
	{
	}

	[Token(Token = "0x60043FB")]
	[Address(RVA = "0xC6B9B0", Offset = "0xC6A7B0", Length = "0xB3")]
	private static void ExecuteCrouchAction()
	{
	}

	[Token(Token = "0x60043FC")]
	[Address(RVA = "0xC6BA70", Offset = "0xC6A870", Length = "0x56E")]
	private static void ExecuteReloadAction()
	{
	}

	[Token(Token = "0x60043FD")]
	[Address(RVA = "0xC6BFE0", Offset = "0xC6ADE0", Length = "0x45")]
	private static void ExecuteQuickSaveAction()
	{
	}

	[Token(Token = "0x60043FE")]
	[Address(RVA = "0xC6C030", Offset = "0xC6AE30", Length = "0x45")]
	private static void ExecuteQuickLoadAction()
	{
	}

	[Token(Token = "0x60043FF")]
	[Address(RVA = "0xC6C080", Offset = "0xC6AE80", Length = "0x9F")]
	private static bool WaitingForScreenshot()
	{
		return false;
	}

	[Token(Token = "0x6004400")]
	[Address(RVA = "0xC6C120", Offset = "0xC6AF20", Length = "0x157")]
	private static void TakeDebugScreenshot()
	{
	}

	[Token(Token = "0x6004401")]
	[Address(RVA = "0xC6C280", Offset = "0xC6B080", Length = "0x307")]
	private static void TakeHDRScreenshot()
	{
	}

	[Token(Token = "0x6004402")]
	[Address(RVA = "0xC6C590", Offset = "0xC6B390", Length = "0x117")]
	private static void TakeNormalResolutionScreenshot()
	{
	}

	[Token(Token = "0x6004403")]
	[Address(RVA = "0xC6C6B0", Offset = "0xC6B4B0", Length = "0x307")]
	private static void TakeHighResolutionScreenshot()
	{
	}

	[Token(Token = "0x6004404")]
	[Address(RVA = "0xC6C9C0", Offset = "0xC6B7C0", Length = "0xD9E")]
	private static void TakeScreenshot(ScreenshotOptions options)
	{
	}

	[Token(Token = "0x6004405")]
	[Address(RVA = "0xC6D760", Offset = "0xC6C560", Length = "0x84")]
	private static void RestoreHudDisplayMode()
	{
	}

	[Token(Token = "0x6004406")]
	[Address(RVA = "0xC6D7F0", Offset = "0xC6C5F0", Length = "0x64")]
	public static void ResetControllerState()
	{
	}

	[Token(Token = "0x6004407")]
	[Address(RVA = "0xC6D860", Offset = "0xC6C660", Length = "0xA5")]
	public static bool AnyInput()
	{
		return false;
	}

	[Token(Token = "0x6004408")]
	[Address(RVA = "0xC6D910", Offset = "0xC6C710", Length = "0x64")]
	public static bool AnyButtonsOrKeysPressed()
	{
		return false;
	}

	[Token(Token = "0x6004409")]
	[Address(RVA = "0xC6D980", Offset = "0xC6C780", Length = "0x64")]
	public static bool AnyMouseOrStickMovement()
	{
		return false;
	}

	[Token(Token = "0x600440A")]
	[Address(RVA = "0xC6D9F0", Offset = "0xC6C7F0", Length = "0x6A")]
	public static void SetInInteractiveDisplay(bool inInteractiveDisplay)
	{
	}

	[Token(Token = "0x600440B")]
	[Address(RVA = "0xC6DA60", Offset = "0xC6C860", Length = "0xE4")]
	public static bool GetGamepadEnabled()
	{
		return false;
	}

	[Token(Token = "0x600440C")]
	[Address(RVA = "0xC6DB50", Offset = "0xC6C950", Length = "0xF5")]
	public static void SetGamepadEnabled(bool enabled)
	{
	}

	[Token(Token = "0x600440D")]
	[Address(RVA = "0xC6DC50", Offset = "0xC6CA50", Length = "0x9A")]
	public static bool GetRadialButton(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600440E")]
	[Address(RVA = "0xC6DCF0", Offset = "0xC6CAF0", Length = "0x9A")]
	public static bool GetRadialButtonHeldDown(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600440F")]
	[Address(RVA = "0xC6DD90", Offset = "0xC6CB90", Length = "0x64")]
	public static bool CheckForActiveController()
	{
		return false;
	}

	[Token(Token = "0x6004410")]
	[Address(RVA = "0xC6DE00", Offset = "0xC6CC00", Length = "0x61")]
	public static int GetActiveUserID()
	{
		return 0;
	}

	[Token(Token = "0x6004411")]
	[Address(RVA = "0xC6DE70", Offset = "0xC6CC70", Length = "0x5E")]
	public static ulong GetActiveJoystickID()
	{
		return 0uL;
	}

	[Token(Token = "0x6004412")]
	[Address(RVA = "0xC6DED0", Offset = "0xC6CCD0", Length = "0x1BF")]
	public static void OnPlayerControllerDisconnected()
	{
	}

	[Token(Token = "0x6004413")]
	[Address(RVA = "0xC6E090", Offset = "0xC6CE90", Length = "0x54")]
	public static void OnPlayerControllerDisconnectedEnd()
	{
	}

	[Token(Token = "0x6004414")]
	[Address(RVA = "0xC6E0F0", Offset = "0xC6CEF0", Length = "0x112")]
	public static bool IsShowingControllerDisconnectedPanel()
	{
		return false;
	}

	[Token(Token = "0x6004415")]
	[Address(RVA = "0xC6E210", Offset = "0xC6D010", Length = "0x8A")]
	public static bool IsShowingSteamControllerDisconnectedPanel()
	{
		return false;
	}

	[Token(Token = "0x6004416")]
	[Address(RVA = "0xC6E2A0", Offset = "0xC6D0A0", Length = "0x8A")]
	public static bool IsShowingPS4ControllerDisconnectedPanel()
	{
		return false;
	}

	[Token(Token = "0x6004417")]
	[Address(RVA = "0xC6E330", Offset = "0xC6D130", Length = "0x62")]
	public static bool HasReconnectedJoystick()
	{
		return false;
	}

	[Token(Token = "0x6004418")]
	[Address(RVA = "0xC6E3A0", Offset = "0xC6D1A0", Length = "0x2EA")]
	public static bool HasContext(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004419")]
	[Address(RVA = "0xC6E690", Offset = "0xC6D490", Length = "0x1DC")]
	public static void PushContext(MonoBehaviour context)
	{
	}

	[Token(Token = "0x600441A")]
	[Address(RVA = "0xC6E870", Offset = "0xC6D670", Length = "0x30B")]
	public static void PopContext(MonoBehaviour context)
	{
	}

	[Token(Token = "0x600441B")]
	[Address(RVA = "0xC6EB80", Offset = "0xC6D980", Length = "0xD3")]
	public static Vector2 GetPlayerMovement(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600441C")]
	[Address(RVA = "0xC6EC60", Offset = "0xC6DA60", Length = "0xD3")]
	public static Vector2 GetCameraMovementMouse(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600441D")]
	[Address(RVA = "0xC6ED40", Offset = "0xC6DB40", Length = "0xD3")]
	public static Vector2 GetCameraMovementGamepad(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600441E")]
	[Address(RVA = "0xC6EE20", Offset = "0xC6DC20", Length = "0x8F")]
	public static Vector2 GetGamepadGyroMovement(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600441F")]
	[Address(RVA = "0xC6EEB0", Offset = "0xC6DCB0", Length = "0x9A")]
	public static bool GetInteractPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004420")]
	[Address(RVA = "0xC6EF50", Offset = "0xC6DD50", Length = "0x69")]
	public static bool GetInteractReleased(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004421")]
	[Address(RVA = "0xC6EFC0", Offset = "0xC6DDC0", Length = "0xAD")]
	public static bool GetSprintDown(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004422")]
	[Address(RVA = "0xC6F070", Offset = "0xC6DE70", Length = "0x9A")]
	public static bool GetAutoWalkDown(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004423")]
	[Address(RVA = "0xC6F110", Offset = "0xC6DF10", Length = "0x9A")]
	public static bool GetCompassPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004424")]
	[Address(RVA = "0xC6F1B0", Offset = "0xC6DFB0", Length = "0x9A")]
	public static bool GetCrouchPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004425")]
	[Address(RVA = "0xC6F250", Offset = "0xC6E050", Length = "0x9A")]
	public static bool GetReloadPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004426")]
	[Address(RVA = "0xC6F2F0", Offset = "0xC6E0F0", Length = "0x9A")]
	public static bool GetEquipPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004427")]
	[Address(RVA = "0xC6F390", Offset = "0xC6E190", Length = "0x95")]
	public static bool GetPickupPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004428")]
	[Address(RVA = "0xC6F430", Offset = "0xC6E230", Length = "0x95")]
	public static bool GetPutBackPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004429")]
	[Address(RVA = "0xC6F4D0", Offset = "0xC6E2D0", Length = "0x9A")]
	public static bool GetHolsterPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600442A")]
	[Address(RVA = "0xC6F570", Offset = "0xC6E370", Length = "0x9A")]
	public static bool GetOpenActionsPanelPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600442B")]
	[Address(RVA = "0xC6F610", Offset = "0xC6E410", Length = "0x9A")]
	public static bool GetOpenActionsPanelHeldDown(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600442C")]
	[Address(RVA = "0xC6F6B0", Offset = "0xC6E4B0", Length = "0x9A")]
	public static bool GetOpenInventoryPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600442D")]
	[Address(RVA = "0xC6F750", Offset = "0xC6E550", Length = "0x9A")]
	public static bool GetOpenClothingPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600442E")]
	[Address(RVA = "0xC6F7F0", Offset = "0xC6E5F0", Length = "0x9A")]
	public static bool GetOpenJournalPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600442F")]
	[Address(RVA = "0xC6F890", Offset = "0xC6E690", Length = "0x9A")]
	public static bool GetOpenFirstAidPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004430")]
	[Address(RVA = "0xC6F930", Offset = "0xC6E730", Length = "0x9A")]
	public static bool GetOpenMapPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004431")]
	[Address(RVA = "0xC6F9D0", Offset = "0xC6E7D0", Length = "0x9A")]
	public static bool GetPauseMenuTogglePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004432")]
	[Address(RVA = "0xC6FA70", Offset = "0xC6E870", Length = "0x9A")]
	public static bool GetEscapePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004433")]
	[Address(RVA = "0xC6FB10", Offset = "0xC6E910", Length = "0x9A")]
	public static bool GetContinuePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004434")]
	[Address(RVA = "0xC6FBB0", Offset = "0xC6E9B0", Length = "0x9A")]
	public static bool GetCarryPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004435")]
	[Address(RVA = "0xC6FC50", Offset = "0xC6EA50", Length = "0x9A")]
	public static bool GetQuarterPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004436")]
	[Address(RVA = "0xC6FCF0", Offset = "0xC6EAF0", Length = "0x9A")]
	public static bool GetHarvestCharcoalPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004437")]
	[Address(RVA = "0xC6FD90", Offset = "0xC6EB90", Length = "0x9A")]
	public static bool GetStartFirePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004438")]
	[Address(RVA = "0xC6FE30", Offset = "0xC6EC30", Length = "0x9A")]
	public static bool GetEquipLightSourcePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004439")]
	[Address(RVA = "0xC6FED0", Offset = "0xC6ECD0", Length = "0x9A")]
	public static bool GetDeployDecoyPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600443A")]
	[Address(RVA = "0xC6FF70", Offset = "0xC6ED70", Length = "0x9A")]
	public static bool GetEquipWeaponPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600443B")]
	[Address(RVA = "0xC70010", Offset = "0xC6EE10", Length = "0x9A")]
	public static bool GetMenuToolSelectPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600443C")]
	[Address(RVA = "0xC700B0", Offset = "0xC6EEB0", Length = "0x9A")]
	public static bool GetMenuBuyNowPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600443D")]
	[Address(RVA = "0xC70150", Offset = "0xC6EF50", Length = "0xD3")]
	public static Vector2 GetMenuNavigationPrimary(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600443E")]
	[Address(RVA = "0xC70230", Offset = "0xC6F030", Length = "0x164")]
	public static Vector2 GetMenuNavigationSecondary(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600443F")]
	[Address(RVA = "0xC703A0", Offset = "0xC6F1A0", Length = "0x9A")]
	public static bool GetInventoryDropPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004440")]
	[Address(RVA = "0xC70440", Offset = "0xC6F240", Length = "0x9A")]
	public static bool GetInventoryDropHeldDown(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004441")]
	[Address(RVA = "0xC704E0", Offset = "0xC6F2E0", Length = "0x69")]
	public static bool GetInventoryDropReleased(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004442")]
	[Address(RVA = "0xC70550", Offset = "0xC6F350", Length = "0x9A")]
	public static bool GetInventoryFilterLeftPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004443")]
	[Address(RVA = "0xC705F0", Offset = "0xC6F3F0", Length = "0x9A")]
	public static bool GetInventoryFilterRightPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004444")]
	[Address(RVA = "0xC70690", Offset = "0xC6F490", Length = "0x9A")]
	public static bool GetInventoryEquipPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004445")]
	[Address(RVA = "0xC70730", Offset = "0xC6F530", Length = "0x9A")]
	public static bool GetInventoryExaminePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004446")]
	[Address(RVA = "0xC707D0", Offset = "0xC6F5D0", Length = "0x9A")]
	public static bool GetInventorySortPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004447")]
	[Address(RVA = "0xC70870", Offset = "0xC6F670", Length = "0x9A")]
	public static bool GetInventoryAddToSatchelPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004448")]
	[Address(RVA = "0xC70910", Offset = "0xC6F710", Length = "0x9A")]
	public static bool GetContainerSelectLeftTablePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004449")]
	[Address(RVA = "0xC709B0", Offset = "0xC6F7B0", Length = "0x9A")]
	public static bool GetContainerSelectRightTablePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600444A")]
	[Address(RVA = "0xC70A50", Offset = "0xC6F850", Length = "0x9A")]
	public static bool GetOptionsConfirmPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600444B")]
	[Address(RVA = "0xC70AF0", Offset = "0xC6F8F0", Length = "0x122")]
	public static bool GetStruggleTapPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600444C")]
	[Address(RVA = "0xC70C20", Offset = "0xC6FA20", Length = "0x122")]
	public static bool GetStruggleTapHeldDown(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600444D")]
	[Address(RVA = "0xC70D50", Offset = "0xC6FB50", Length = "0x9A")]
	public static bool GetFeedFireTakeTorchePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600444E")]
	[Address(RVA = "0xC70DF0", Offset = "0xC6FBF0", Length = "0x9A")]
	public static bool GetQuickSelect1Pressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600444F")]
	[Address(RVA = "0xC70E90", Offset = "0xC6FC90", Length = "0x9A")]
	public static bool GetQuickSelect2Pressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004450")]
	[Address(RVA = "0xC70F30", Offset = "0xC6FD30", Length = "0x9A")]
	public static bool GetQuickSelect3Pressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004451")]
	[Address(RVA = "0xC70FD0", Offset = "0xC6FDD0", Length = "0x9A")]
	public static bool GetQuickSelect4Pressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004452")]
	[Address(RVA = "0xC71070", Offset = "0xC6FE70", Length = "0x122")]
	public static bool GetTabLeftPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004453")]
	[Address(RVA = "0xC711A0", Offset = "0xC6FFA0", Length = "0x122")]
	public static bool GetTabRightPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004454")]
	[Address(RVA = "0xC712D0", Offset = "0xC700D0", Length = "0x122")]
	public static bool GetFirePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004455")]
	[Address(RVA = "0xC71400", Offset = "0xC70200", Length = "0xF0")]
	public static bool GetFireReleased(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004456")]
	[Address(RVA = "0xC71500", Offset = "0xC70300", Length = "0x9A")]
	public static bool GetAltFirePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004457")]
	[Address(RVA = "0xC715A0", Offset = "0xC703A0", Length = "0x9A")]
	public static bool GetAltFire(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004458")]
	[Address(RVA = "0xC71640", Offset = "0xC70440", Length = "0x69")]
	public static bool GetAltFireReleased(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004459")]
	[Address(RVA = "0xC716B0", Offset = "0xC704B0", Length = "0x9D")]
	public static float GetFlyModeMoveSlowMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x600445A")]
	[Address(RVA = "0xC71750", Offset = "0xC70550", Length = "0x9D")]
	public static float GetFlyModeMoveFastMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x600445B")]
	[Address(RVA = "0xC717F0", Offset = "0xC705F0", Length = "0x69")]
	public static bool GetFlyModeMoveUpDown()
	{
		return false;
	}

	[Token(Token = "0x600445C")]
	[Address(RVA = "0xC71860", Offset = "0xC70660", Length = "0x69")]
	public static bool GetFlyModeMoveDownDown()
	{
		return false;
	}

	[Token(Token = "0x600445D")]
	[Address(RVA = "0xC718D0", Offset = "0xC706D0", Length = "0x69")]
	public static bool GetFlyModeLockOrientationDown()
	{
		return false;
	}

	[Token(Token = "0x600445E")]
	[Address(RVA = "0xC71940", Offset = "0xC70740", Length = "0x69")]
	public static bool GetFlyModeAcceptPlacementPressed()
	{
		return false;
	}

	[Token(Token = "0x600445F")]
	[Address(RVA = "0xC719B0", Offset = "0xC707B0", Length = "0x69")]
	public static bool GetFlyModeCancelPlacementPressed()
	{
		return false;
	}

	[Token(Token = "0x6004460")]
	[Address(RVA = "0xC71A20", Offset = "0xC70820", Length = "0xB6")]
	public static bool GetFlyModeToggleEnabled()
	{
		return false;
	}

	[Token(Token = "0x6004461")]
	[Address(RVA = "0xC71AE0", Offset = "0xC708E0", Length = "0x69")]
	public static bool GetFlyModeToggleCoords()
	{
		return false;
	}

	[Token(Token = "0x6004462")]
	[Address(RVA = "0xC71B50", Offset = "0xC70950", Length = "0x9A")]
	public static bool GetSafeCrackingLeft(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004463")]
	[Address(RVA = "0xC71BF0", Offset = "0xC709F0", Length = "0x9A")]
	public static bool GetSafeCrackingRight(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004464")]
	[Address(RVA = "0xC71C90", Offset = "0xC70A90", Length = "0xA9")]
	public static float GetSafeCrackingMovementDirection(MonoBehaviour context)
	{
		return 0f;
	}

	[Token(Token = "0x6004465")]
	[Address(RVA = "0xC71D40", Offset = "0xC70B40", Length = "0x138")]
	public static bool GetDebugMenuTogglePressed()
	{
		return false;
	}

	[Token(Token = "0x6004466")]
	[Address(RVA = "0xC71E80", Offset = "0xC70C80", Length = "0x9A")]
	public static bool GetShowAccountPickerPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004467")]
	[Address(RVA = "0xC71F20", Offset = "0xC70D20", Length = "0x9A")]
	public static bool GetShowStatsScreenPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004468")]
	[Address(RVA = "0xC71FC0", Offset = "0xC70DC0", Length = "0x9A")]
	public static bool ResetAllTimeStatsPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004469")]
	[Address(RVA = "0xC72060", Offset = "0xC70E60", Length = "0x9A")]
	public static bool GetRenamePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600446A")]
	[Address(RVA = "0xC72100", Offset = "0xC70F00", Length = "0x9A")]
	public static bool GetDeletePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600446B")]
	[Address(RVA = "0xC721A0", Offset = "0xC70FA0", Length = "0x9A")]
	public static bool GetOverwritePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600446C")]
	[Address(RVA = "0xC72240", Offset = "0xC71040", Length = "0x9A")]
	public static bool GetSaveJournalPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600446D")]
	[Address(RVA = "0xC722E0", Offset = "0xC710E0", Length = "0x9A")]
	public static bool GetQuickSavePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600446E")]
	[Address(RVA = "0xC72380", Offset = "0xC71180", Length = "0x9A")]
	public static bool GetQuickLoadPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600446F")]
	[Address(RVA = "0xC72420", Offset = "0xC71220", Length = "0x9A")]
	public static bool GetHinterlandMailingListPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004470")]
	[Address(RVA = "0xC724C0", Offset = "0xC712C0", Length = "0x9A")]
	public static bool GetSkyboundInsidersPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004471")]
	[Address(RVA = "0xC72560", Offset = "0xC71360", Length = "0x9A")]
	public static bool GetScrollDownPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004472")]
	[Address(RVA = "0xC72600", Offset = "0xC71400", Length = "0x9A")]
	public static bool GetScrollUpPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004473")]
	[Address(RVA = "0xC726A0", Offset = "0xC714A0", Length = "0x9A")]
	public static bool GetScrollDownHeld(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004474")]
	[Address(RVA = "0xC72740", Offset = "0xC71540", Length = "0x9A")]
	public static bool GetScrollUpHeld(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004475")]
	[Address(RVA = "0xC727E0", Offset = "0xC715E0", Length = "0x9A")]
	public static bool GetShowSteamControllerBindingsPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004476")]
	[Address(RVA = "0xC72880", Offset = "0xC71680", Length = "0xA9")]
	public static bool GetMouseButtonDown(MonoBehaviour context, int button)
	{
		return false;
	}

	[Token(Token = "0x6004477")]
	[Address(RVA = "0xC72930", Offset = "0xC71730", Length = "0x9A")]
	public static bool GetLeftPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004478")]
	[Address(RVA = "0xC729D0", Offset = "0xC717D0", Length = "0x9A")]
	public static bool GetRightPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x6004479")]
	[Address(RVA = "0xC72A70", Offset = "0xC71870", Length = "0x9A")]
	public static bool GetRotateClockwiseHeld(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600447A")]
	[Address(RVA = "0xC72B10", Offset = "0xC71910", Length = "0x9A")]
	public static bool GetRotateCounterClockwiseHeld(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600447B")]
	[Address(RVA = "0xC72BB0", Offset = "0xC719B0", Length = "0x9A")]
	public static bool GetCraftingPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600447C")]
	[Address(RVA = "0xC72C50", Offset = "0xC71A50", Length = "0x9A")]
	public static bool GetCookingPressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600447D")]
	[Address(RVA = "0xC72CF0", Offset = "0xC71AF0", Length = "0x9A")]
	public static bool GetSafehouseCustomizePressed(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600447E")]
	[Address(RVA = "0xC72D90", Offset = "0xC71B90", Length = "0x64")]
	public static void SaveRemapping()
	{
	}

	[Token(Token = "0x600447F")]
	[Address(RVA = "0xC72E00", Offset = "0xC71C00", Length = "0x64")]
	public static void LoadRemapping()
	{
	}

	[Token(Token = "0x6004480")]
	[Address(RVA = "0xC72E70", Offset = "0xC71C70", Length = "0x64")]
	public static void UpdateKeyBindingTable()
	{
	}

	[Token(Token = "0x6004481")]
	[Address(RVA = "0xC72EE0", Offset = "0xC71CE0", Length = "0x5C")]
	public static void ApplyRemapping()
	{
	}

	[Token(Token = "0x6004482")]
	[Address(RVA = "0xC72F40", Offset = "0xC71D40", Length = "0x64")]
	public static void ResetKeybindingsToDefault()
	{
	}

	[Token(Token = "0x6004483")]
	[Address(RVA = "0xC72FB0", Offset = "0xC71DB0", Length = "0x5C")]
	public static void InitializeDefaultKeybindings()
	{
	}

	[Token(Token = "0x6004484")]
	[Address(RVA = "0xC73010", Offset = "0xC71E10", Length = "0xD8")]
	public static float GetMouseSensitivity()
	{
		return 0f;
	}

	[Token(Token = "0x6004485")]
	[Address(RVA = "0xC730F0", Offset = "0xC71EF0", Length = "0xD8")]
	public static float GetZoomSensitivity()
	{
		return 0f;
	}

	[Token(Token = "0x6004486")]
	[Address(RVA = "0xC731D0", Offset = "0xC71FD0", Length = "0xD8")]
	public static float GetGamepadCameraSensitivity()
	{
		return 0f;
	}

	[Token(Token = "0x6004487")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	public static float GetGyroHorizontalLookSensitivity()
	{
		return 0f;
	}

	[Token(Token = "0x6004488")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	public static float GetGyroVerticalLookSensitivity()
	{
		return 0f;
	}

	[Token(Token = "0x6004489")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	public static float GetGyroHorizontalAimSensitivity()
	{
		return 0f;
	}

	[Token(Token = "0x600448A")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	public static float GetGyroVerticalAimSensitivity()
	{
		return 0f;
	}

	[Token(Token = "0x600448B")]
	[Address(RVA = "0xC732B0", Offset = "0xC720B0", Length = "0x94")]
	public static string GetButtonNameForAction(ControllerType controllerType, string action, bool convertKeycodes = true)
	{
		return null;
	}

	[Token(Token = "0x600448C")]
	[Address(RVA = "0xC73350", Offset = "0xC72150", Length = "0x92")]
	private static float GetSensititivyFromSlider(float sliderValue, float min, float mid, float max)
	{
		return 0f;
	}

	[Token(Token = "0x600448D")]
	[Address(RVA = "0xC733F0", Offset = "0xC721F0", Length = "0x44")]
	public static bool GetKeycodeCanBeBound(KeyCode keycode)
	{
		return false;
	}

	[Token(Token = "0x600448E")]
	[Address(RVA = "0xC73460", Offset = "0xC72260", Length = "0x5B2")]
	public static string ConvertKeycodeToLabel(string keycode)
	{
		return null;
	}

	[Token(Token = "0x600448F")]
	[Address(RVA = "0xC73A20", Offset = "0xC72820", Length = "0x7D")]
	public static bool WaitingCursor()
	{
		return false;
	}

	[Token(Token = "0x6004490")]
	[Address(RVA = "0xC73AA0", Offset = "0xC728A0", Length = "0x26A")]
	public static void ShowCursor(bool show)
	{
	}

	[Token(Token = "0x6004491")]
	[Address(RVA = "0xC73D10", Offset = "0xC72B10", Length = "0xFE")]
	private static void MaybeRestoreHudDisplayMode()
	{
	}

	[Token(Token = "0x6004492")]
	[Address(RVA = "0xC73E10", Offset = "0xC72C10", Length = "0x64")]
	public static bool IsSteamControllerActive()
	{
		return false;
	}

	[Token(Token = "0x6004493")]
	[Address(RVA = "0xC73E80", Offset = "0xC72C80", Length = "0x195")]
	public static void ShowSteamControllerBindingPanel()
	{
	}

	[Token(Token = "0x6004494")]
	[Address(RVA = "0xC74020", Offset = "0xC72E20", Length = "0x64")]
	public static void StopVibration()
	{
	}

	[Token(Token = "0x6004495")]
	[Address(RVA = "0xC74090", Offset = "0xC72E90", Length = "0x203")]
	public static void SetVibration(float motor0, float motor1)
	{
	}

	[Token(Token = "0x6004496")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool IsGyroCameraMovementEnabled()
	{
		return false;
	}

	[Token(Token = "0x6004497")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool IsGyroCameraMovementOnlyOnAim()
	{
		return false;
	}

	[Token(Token = "0x6004498")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void SetGamepadGyroHorizontalLookSensitivity(float sensitivity)
	{
	}

	[Token(Token = "0x6004499")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void SetGamepadGyroVerticalLookSensitivity(float sensitivity)
	{
	}

	[Token(Token = "0x600449A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void SetGamepadGyroHorizontalAimSensitivity(float sensitivity)
	{
	}

	[Token(Token = "0x600449B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void SetGamepadGyroVerticalAimSensitivity(float sensitivity)
	{
	}

	[Token(Token = "0x600449C")]
	[Address(RVA = "0xC742A0", Offset = "0xC730A0", Length = "0x54")]
	public static bool HasInteractedThisFrame()
	{
		return false;
	}

	[Token(Token = "0x600449D")]
	[Address(RVA = "0xC74300", Offset = "0xC73100", Length = "0x138")]
	public static bool HasPressedSkip(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x600449E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InputManager()
	{
	}
}
