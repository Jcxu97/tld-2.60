using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired;
using Steamworks;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000767")]
public class InputSystemRewired
{
	[Token(Token = "0x2000768")]
	private enum ActiveControllerType
	{
		[Token(Token = "0x4004F78")]
		None,
		[Token(Token = "0x4004F79")]
		Steam,
		[Token(Token = "0x4004F7A")]
		Ps4,
		[Token(Token = "0x4004F7B")]
		XboxOne,
		[Token(Token = "0x4004F7C")]
		Switch
	}

	[Token(Token = "0x2000769")]
	private class InputActionComparer : IEqualityComparer<InputManager.InputAction>
	{
		[Token(Token = "0x4004F7D")]
		public static readonly InputActionComparer Comparer;

		[Token(Token = "0x6004562")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		private InputActionComparer()
		{
		}

		[Token(Token = "0x6004563")]
		[Address(RVA = "0x5DC750", Offset = "0x5DB550", Length = "0x7")]
		public bool Equals(InputManager.InputAction x, InputManager.InputAction y)
		{
			return false;
		}

		[Token(Token = "0x6004564")]
		[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
		public int GetHashCode(InputManager.InputAction x)
		{
			return 0;
		}
	}

	[Token(Token = "0x200076A")]
	private class InputAxisComparer : IEqualityComparer<InputManager.InputAxis>
	{
		[Token(Token = "0x4004F7E")]
		public static readonly InputAxisComparer Comparer;

		[Token(Token = "0x6004566")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		private InputAxisComparer()
		{
		}

		[Token(Token = "0x6004567")]
		[Address(RVA = "0x5DC750", Offset = "0x5DB550", Length = "0x7")]
		public bool Equals(InputManager.InputAxis x, InputManager.InputAxis y)
		{
			return false;
		}

		[Token(Token = "0x6004568")]
		[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
		public int GetHashCode(InputManager.InputAxis x)
		{
			return 0;
		}
	}

	[Token(Token = "0x200076B")]
	private class InputController_ButtonState
	{
		[Token(Token = "0x4004F7F")]
		[FieldOffset(Offset = "0x10")]
		public InputDigitalActionHandle_t m_Handle;

		[Token(Token = "0x4004F80")]
		[FieldOffset(Offset = "0x18")]
		public bool m_Value;

		[Token(Token = "0x4004F81")]
		[FieldOffset(Offset = "0x19")]
		public bool m_PreviousValue;

		[Token(Token = "0x4004F82")]
		[FieldOffset(Offset = "0x1A")]
		public bool m_RequiresUpForReset;

		[Token(Token = "0x600456A")]
		[Address(RVA = "0xC88080", Offset = "0xC86E80", Length = "0x17")]
		public bool GetButtonPressed()
		{
			return false;
		}

		[Token(Token = "0x600456B")]
		[Address(RVA = "0xC880A0", Offset = "0xC86EA0", Length = "0xE")]
		public bool GetButtonUp()
		{
			return false;
		}

		[Token(Token = "0x600456C")]
		[Address(RVA = "0xC880B0", Offset = "0xC86EB0", Length = "0x5")]
		public bool GetButtonValue()
		{
			return false;
		}

		[Token(Token = "0x600456D")]
		[Address(RVA = "0xC880C0", Offset = "0xC86EC0", Length = "0xB")]
		public bool GetButtonValueChanged()
		{
			return false;
		}

		[Token(Token = "0x600456E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public InputController_ButtonState()
		{
		}
	}

	[Token(Token = "0x200076C")]
	private class InputController_AxisState
	{
		[Token(Token = "0x4004F83")]
		[FieldOffset(Offset = "0x10")]
		public InputAnalogActionHandle_t m_Handle;

		[Token(Token = "0x4004F84")]
		[FieldOffset(Offset = "0x18")]
		public bool m_Active;

		[Token(Token = "0x4004F85")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 m_Value;

		[Token(Token = "0x4004F86")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 m_PreviousValue;

		[Token(Token = "0x4004F87")]
		[FieldOffset(Offset = "0x2C")]
		public EInputSourceMode m_EMode;

		[Token(Token = "0x600456F")]
		[Address(RVA = "0xC880D0", Offset = "0xC86ED0", Length = "0x13")]
		public Vector2 GetAxis()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6004570")]
		[Address(RVA = "0xC880F0", Offset = "0xC86EF0", Length = "0x2F")]
		public bool ValueChanged()
		{
			return false;
		}

		[Token(Token = "0x6004571")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public InputController_AxisState()
		{
		}
	}

	[Token(Token = "0x4004F4B")]
	[FieldOffset(Offset = "0x10")]
	public float m_MouseSensitivityMin;

	[Token(Token = "0x4004F4C")]
	[FieldOffset(Offset = "0x14")]
	public float m_MouseSensitivityMid;

	[Token(Token = "0x4004F4D")]
	[FieldOffset(Offset = "0x18")]
	public float m_MouseSensitivityMax;

	[Token(Token = "0x4004F4E")]
	[FieldOffset(Offset = "0x1C")]
	public float m_ZoomSensitivityMin;

	[Token(Token = "0x4004F4F")]
	[FieldOffset(Offset = "0x20")]
	public float m_ZoomSensitivityMid;

	[Token(Token = "0x4004F50")]
	[FieldOffset(Offset = "0x24")]
	public float m_ZoomSensitivityMax;

	[Token(Token = "0x4004F51")]
	[FieldOffset(Offset = "0x28")]
	public float m_GamepadCameraSensitivityMin;

	[Token(Token = "0x4004F52")]
	[FieldOffset(Offset = "0x2C")]
	public float m_GamepadCameraSensitivityMid;

	[Token(Token = "0x4004F53")]
	[FieldOffset(Offset = "0x30")]
	public float m_GamepadCameraSensitivityMax;

	[Token(Token = "0x4004F54")]
	[FieldOffset(Offset = "0x34")]
	private int playerId;

	[Token(Token = "0x4004F55")]
	[FieldOffset(Offset = "0x38")]
	public Player m_Player;

	[Token(Token = "0x4004F56")]
	[FieldOffset(Offset = "0x40")]
	private ControllerMap m_CachedControllerMap;

	[Token(Token = "0x4004F57")]
	[FieldOffset(Offset = "0x48")]
	private bool m_HasReconnectedJoystick;

	[Token(Token = "0x4004F58")]
	[FieldOffset(Offset = "0x49")]
	private bool m_HasReconnectedJoystickPS4;

	[Token(Token = "0x4004F59")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[Token(Token = "0x4004F5A")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	[Token(Token = "0x4004F5B")]
	private const int AUTOREPEAT_PERSISTENCE = 1;

	[Token(Token = "0x4004F5C")]
	private const int AUTOREPEAT_PERSISTENCE_MASK = 1;

	[Token(Token = "0x4004F5D")]
	[FieldOffset(Offset = "0x60")]
	private int keyLeftMask;

	[Token(Token = "0x4004F5E")]
	[FieldOffset(Offset = "0x64")]
	private int keyRightMask;

	[Token(Token = "0x4004F5F")]
	[FieldOffset(Offset = "0x68")]
	private int keyUpMask;

	[Token(Token = "0x4004F60")]
	[FieldOffset(Offset = "0x6C")]
	private int keyDownMask;

	[Token(Token = "0x4004F61")]
	[FieldOffset(Offset = "0x70")]
	private int keySprintMask;

	[Token(Token = "0x4004F62")]
	[FieldOffset(Offset = "0x74")]
	private ActiveControllerType m_LastActiveController;

	[Token(Token = "0x4004F63")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<InputManager.InputAction, int> m_ActionToActionId;

	[Token(Token = "0x4004F64")]
	private static float m_MenuNavigationDeadzone;

	[Token(Token = "0x4004F65")]
	[FieldOffset(Offset = "0x80")]
	private Vector2 m_MousePosLastFrame;

	[Token(Token = "0x4004F66")]
	private const float STEAM_INPUT_SENSITIVITY = 0.118f;

	[Token(Token = "0x4004F67")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[Token(Token = "0x4004F68")]
	[FieldOffset(Offset = "0x90")]
	private int m_ActiveSteamControllerIndex;

	[Token(Token = "0x4004F69")]
	[FieldOffset(Offset = "0x94")]
	private bool m_SteamControllerInitialized;

	[Token(Token = "0x4004F6A")]
	[FieldOffset(Offset = "0x95")]
	private bool m_SteamAvailable;

	[Token(Token = "0x4004F6B")]
	[FieldOffset(Offset = "0x96")]
	private bool m_InInteractiveDisplay;

	[Token(Token = "0x4004F6C")]
	[FieldOffset(Offset = "0x98")]
	private InputActionSetHandle_t m_ActionSetHandleGameplay;

	[Token(Token = "0x4004F6D")]
	[FieldOffset(Offset = "0xA0")]
	private InputActionSetHandle_t m_ActionSetHandleInterface;

	[Token(Token = "0x4004F6E")]
	[FieldOffset(Offset = "0xA8")]
	private InputActionSetHandle_t m_ActionSetHandleInteractiveDisplay;

	[Token(Token = "0x4004F6F")]
	[FieldOffset(Offset = "0xB0")]
	private readonly InputActionSetHandle_t INVALID_ACTION_SETHANDLE;

	[Token(Token = "0x4004F70")]
	[FieldOffset(Offset = "0xB8")]
	private readonly InputHandle_t[] m_TempControllerHandles;

	[Token(Token = "0x4004F71")]
	[FieldOffset(Offset = "0xC0")]
	private readonly EInputActionOrigin[] m_InputOrigins;

	[Token(Token = "0x4004F72")]
	[FieldOffset(Offset = "0xC8")]
	private readonly Dictionary<InputManager.InputAction, InputController_ButtonState> m_SteamControllerButtonState;

	[Token(Token = "0x4004F73")]
	[FieldOffset(Offset = "0xD0")]
	private readonly Dictionary<InputManager.InputAxis, InputController_AxisState> m_SteamControllerAxisState;

	[Token(Token = "0x4004F74")]
	[FieldOffset(Offset = "0xD8")]
	private readonly List<InputActionSetHandle_t> m_InactiveActionSets;

	[Token(Token = "0x4004F75")]
	private static readonly InputManager.InputAction[] s_ButtonEnums;

	[Token(Token = "0x4004F76")]
	private static readonly InputManager.InputAxis[] s_AxisEnums;

	[Token(Token = "0x60044A4")]
	[Address(RVA = "0xC787F0", Offset = "0xC775F0", Length = "0x155F")]
	private string PrintJoystickDebugInfo(int joystickIndex)
	{
		return null;
	}

	[Token(Token = "0x60044A5")]
	[Address(RVA = "0xC79D50", Offset = "0xC78B50", Length = "0x916")]
	private string PrintPlayerDebugInfo(int playerIndex)
	{
		return null;
	}

	[Token(Token = "0x60044A6")]
	[Address(RVA = "0xC7A670", Offset = "0xC79470", Length = "0x281")]
	private void PrintDebugInfo()
	{
	}

	[Token(Token = "0x60044A7")]
	[Address(RVA = "0xC7A900", Offset = "0xC79700", Length = "0x36B")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60044A8")]
	[Address(RVA = "0xC7AC70", Offset = "0xC79A70", Length = "0x10D")]
	public void Update()
	{
	}

	[Token(Token = "0x60044A9")]
	[Address(RVA = "0xC7AD80", Offset = "0xC79B80", Length = "0x5A5")]
	public void ResetControllerState()
	{
	}

	[Token(Token = "0x60044AA")]
	[Address(RVA = "0xC7B330", Offset = "0xC7A130", Length = "0x470")]
	public void SaveRemapping()
	{
	}

	[Token(Token = "0x60044AB")]
	[Address(RVA = "0xC7B7B0", Offset = "0xC7A5B0", Length = "0x129F")]
	private void PatchControllerMapping()
	{
	}

	[Token(Token = "0x60044AC")]
	[Address(RVA = "0xC7CA50", Offset = "0xC7B850", Length = "0x185")]
	private bool CheckForExistingKeyboardMapping(KeyCode keycode)
	{
		return false;
	}

	[Token(Token = "0x60044AD")]
	[Address(RVA = "0xC7CBE0", Offset = "0xC7B9E0", Length = "0x2F4")]
	public void LoadRemapping()
	{
	}

	[Token(Token = "0x60044AE")]
	[Address(RVA = "0xC7CEE0", Offset = "0xC7BCE0", Length = "0x1D1")]
	public bool AnyButtonsOrKeysPressed()
	{
		return false;
	}

	[Token(Token = "0x60044AF")]
	[Address(RVA = "0xC7D0C0", Offset = "0xC7BEC0", Length = "0x17F")]
	public bool GetAnyMouseOrStickMovement()
	{
		return false;
	}

	[Token(Token = "0x60044B0")]
	[Address(RVA = "0xC7D240", Offset = "0xC7C040", Length = "0x1F6")]
	public bool CheckForActiveController()
	{
		return false;
	}

	[Token(Token = "0x60044B1")]
	[Address(RVA = "0xC7D440", Offset = "0xC7C240", Length = "0xAC")]
	public float GetScroll()
	{
		return 0f;
	}

	[Token(Token = "0x60044B2")]
	[Address(RVA = "0xC7D4F0", Offset = "0xC7C2F0", Length = "0x6")]
	public int GetActiveUserID()
	{
		return 0;
	}

	[Token(Token = "0x60044B3")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public ulong GetActiveJoystickID()
	{
		return 0uL;
	}

	[Token(Token = "0x60044B4")]
	[Address(RVA = "0xC7D500", Offset = "0xC7C300", Length = "0x1E4")]
	private Vector2 GetAxis(InputManager.InputAxis axis, int axisXActionId, int axisYactionId)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60044B5")]
	[Address(RVA = "0xC7D6F0", Offset = "0xC7C4F0", Length = "0x11A")]
	private bool GetRewiredButtonPressed(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x60044B6")]
	[Address(RVA = "0xC7D810", Offset = "0xC7C610", Length = "0x1EA")]
	private bool GetButtonPressed(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x60044B7")]
	[Address(RVA = "0xC7DA00", Offset = "0xC7C800", Length = "0xB9")]
	private bool GetRewiredButtonUnpressed(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x60044B8")]
	[Address(RVA = "0xC7DAC0", Offset = "0xC7C8C0", Length = "0x1BC")]
	private bool GetButtonUnpressed(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x60044B9")]
	[Address(RVA = "0xC7DC80", Offset = "0xC7CA80", Length = "0x11A")]
	private bool GetRewiredButton(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x60044BA")]
	[Address(RVA = "0xC7DDA0", Offset = "0xC7CBA0", Length = "0x206")]
	private bool GetButton(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x60044BB")]
	[Address(RVA = "0xC7DFB0", Offset = "0xC7CDB0", Length = "0xBA")]
	private float GetRewiredActionAsAxis(InputManager.InputAction action)
	{
		return 0f;
	}

	[Token(Token = "0x60044BC")]
	[Address(RVA = "0xC7E070", Offset = "0xC7CE70", Length = "0xB5")]
	public Vector2 GetPlayerMovementKeyboard()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60044BD")]
	[Address(RVA = "0xC7E130", Offset = "0xC7CF30", Length = "0x8")]
	public bool WasLastControllerActiveSteam()
	{
		return false;
	}

	[Token(Token = "0x60044BE")]
	[Address(RVA = "0xC7E140", Offset = "0xC7CF40", Length = "0x8")]
	public bool WasLastControllerActivePS4()
	{
		return false;
	}

	[Token(Token = "0x60044BF")]
	[Address(RVA = "0xC7E150", Offset = "0xC7CF50", Length = "0x8")]
	public bool WasLastControllerActiveSwitch()
	{
		return false;
	}

	[Token(Token = "0x60044C0")]
	[Address(RVA = "0xC7E160", Offset = "0xC7CF60", Length = "0x9C")]
	public Vector2 GetPlayerMovement()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60044C1")]
	[Address(RVA = "0xC7E200", Offset = "0xC7D000", Length = "0x457")]
	public Vector2 GetCameraMovementMouse()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60044C2")]
	[Address(RVA = "0xC7E660", Offset = "0xC7D460", Length = "0x198")]
	public Vector2 GetCameraMovementGamepad()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60044C3")]
	[Address(RVA = "0xC7E800", Offset = "0xC7D600", Length = "0xC")]
	public bool GetInteractPressed()
	{
		return false;
	}

	[Token(Token = "0x60044C4")]
	[Address(RVA = "0xC7E810", Offset = "0xC7D610", Length = "0xC")]
	public bool GetInteractReleased()
	{
		return false;
	}

	[Token(Token = "0x60044C5")]
	[Address(RVA = "0xC7E820", Offset = "0xC7D620", Length = "0x2A")]
	public bool GetSprintDown()
	{
		return false;
	}

	[Token(Token = "0x60044C6")]
	[Address(RVA = "0xC7E850", Offset = "0xC7D650", Length = "0xC")]
	public bool GetAutoWalkDown()
	{
		return false;
	}

	[Token(Token = "0x60044C7")]
	[Address(RVA = "0xC7E860", Offset = "0xC7D660", Length = "0xC")]
	public bool GetCompassPressed()
	{
		return false;
	}

	[Token(Token = "0x60044C8")]
	[Address(RVA = "0xC7E870", Offset = "0xC7D670", Length = "0xC")]
	public bool GetCrouchPressed()
	{
		return false;
	}

	[Token(Token = "0x60044C9")]
	[Address(RVA = "0xC7E880", Offset = "0xC7D680", Length = "0xC")]
	public bool GetReloadPressed()
	{
		return false;
	}

	[Token(Token = "0x60044CA")]
	[Address(RVA = "0xC7E890", Offset = "0xC7D690", Length = "0xC")]
	public bool GetEquipPressed()
	{
		return false;
	}

	[Token(Token = "0x60044CB")]
	[Address(RVA = "0xC7E8A0", Offset = "0xC7D6A0", Length = "0x1FB")]
	public bool GetPickupPressed()
	{
		return false;
	}

	[Token(Token = "0x60044CC")]
	[Address(RVA = "0xC7EAA0", Offset = "0xC7D8A0", Length = "0x1E1")]
	public bool GetPutBackPressed()
	{
		return false;
	}

	[Token(Token = "0x60044CD")]
	[Address(RVA = "0xC7EC90", Offset = "0xC7DA90", Length = "0xC")]
	public bool GetHolsterPressed()
	{
		return false;
	}

	[Token(Token = "0x60044CE")]
	[Address(RVA = "0xC7ECA0", Offset = "0xC7DAA0", Length = "0xC")]
	public bool GetOpenActionsPanelPressed()
	{
		return false;
	}

	[Token(Token = "0x60044CF")]
	[Address(RVA = "0xC7ECB0", Offset = "0xC7DAB0", Length = "0xC")]
	public bool GetOpenActionsPanelHeldDown()
	{
		return false;
	}

	[Token(Token = "0x60044D0")]
	[Address(RVA = "0xC7ECC0", Offset = "0xC7DAC0", Length = "0xC")]
	public bool GetOpenInventoryPressed()
	{
		return false;
	}

	[Token(Token = "0x60044D1")]
	[Address(RVA = "0xC7ECD0", Offset = "0xC7DAD0", Length = "0xC")]
	public bool GetOpenClothingPressed()
	{
		return false;
	}

	[Token(Token = "0x60044D2")]
	[Address(RVA = "0xC7ECE0", Offset = "0xC7DAE0", Length = "0xC")]
	public bool GetOpenJournalPressed()
	{
		return false;
	}

	[Token(Token = "0x60044D3")]
	[Address(RVA = "0xC7ECF0", Offset = "0xC7DAF0", Length = "0xC")]
	public bool GetOpenFirstAidPressed()
	{
		return false;
	}

	[Token(Token = "0x60044D4")]
	[Address(RVA = "0xC7ED00", Offset = "0xC7DB00", Length = "0xC")]
	public bool GetOpenMapPressed()
	{
		return false;
	}

	[Token(Token = "0x60044D5")]
	[Address(RVA = "0xC7ED10", Offset = "0xC7DB10", Length = "0xC")]
	public bool GetPauseMenuTogglePressed()
	{
		return false;
	}

	[Token(Token = "0x60044D6")]
	[Address(RVA = "0xC7ED20", Offset = "0xC7DB20", Length = "0xC")]
	public bool GetEscapePressed()
	{
		return false;
	}

	[Token(Token = "0x60044D7")]
	[Address(RVA = "0xC7ED30", Offset = "0xC7DB30", Length = "0xC")]
	public bool GetCarryPressed()
	{
		return false;
	}

	[Token(Token = "0x60044D8")]
	[Address(RVA = "0xC7ED40", Offset = "0xC7DB40", Length = "0xC")]
	public bool GetQuarterPressed()
	{
		return false;
	}

	[Token(Token = "0x60044D9")]
	[Address(RVA = "0xC7ED50", Offset = "0xC7DB50", Length = "0xC")]
	public bool GetHarvestCharcoalPressed()
	{
		return false;
	}

	[Token(Token = "0x60044DA")]
	[Address(RVA = "0xC7ED60", Offset = "0xC7DB60", Length = "0xC")]
	public bool GetContinuePressed()
	{
		return false;
	}

	[Token(Token = "0x60044DB")]
	[Address(RVA = "0xC7ED70", Offset = "0xC7DB70", Length = "0xC")]
	public bool GetStartFirePressed()
	{
		return false;
	}

	[Token(Token = "0x60044DC")]
	[Address(RVA = "0xC7ED80", Offset = "0xC7DB80", Length = "0xC")]
	public bool GetEquipLightSourcePressed()
	{
		return false;
	}

	[Token(Token = "0x60044DD")]
	[Address(RVA = "0xC7ED90", Offset = "0xC7DB90", Length = "0xC")]
	public bool GetDeployDecoyPressed()
	{
		return false;
	}

	[Token(Token = "0x60044DE")]
	[Address(RVA = "0xC7EDA0", Offset = "0xC7DBA0", Length = "0xC")]
	public bool GetEquipWeaponPressed()
	{
		return false;
	}

	[Token(Token = "0x60044DF")]
	[Address(RVA = "0xC7EDB0", Offset = "0xC7DBB0", Length = "0xC")]
	public bool GetMenuToolSelectPressed()
	{
		return false;
	}

	[Token(Token = "0x60044E0")]
	[Address(RVA = "0xC7EDC0", Offset = "0xC7DBC0", Length = "0xC")]
	public bool GetMenuBuyNowPressed()
	{
		return false;
	}

	[Token(Token = "0x60044E1")]
	[Address(RVA = "0xC7EDD0", Offset = "0xC7DBD0", Length = "0xC")]
	public bool GetQuickSavePressed()
	{
		return false;
	}

	[Token(Token = "0x60044E2")]
	[Address(RVA = "0xC7EDE0", Offset = "0xC7DBE0", Length = "0xC")]
	public bool GetQuickLoadPressed()
	{
		return false;
	}

	[Token(Token = "0x60044E3")]
	[Address(RVA = "0xC7EDF0", Offset = "0xC7DBF0", Length = "0xC")]
	public bool GetHinterlandMailingListPressed()
	{
		return false;
	}

	[Token(Token = "0x60044E4")]
	[Address(RVA = "0xC7EE00", Offset = "0xC7DC00", Length = "0xC")]
	public bool GetSkyboundInsidersPressed()
	{
		return false;
	}

	[Token(Token = "0x60044E5")]
	[Address(RVA = "0xC7EE10", Offset = "0xC7DC10", Length = "0xC")]
	public bool GetScrollDownPressed()
	{
		return false;
	}

	[Token(Token = "0x60044E6")]
	[Address(RVA = "0xC7EE20", Offset = "0xC7DC20", Length = "0xC")]
	public bool GetScrollUpPressed()
	{
		return false;
	}

	[Token(Token = "0x60044E7")]
	[Address(RVA = "0xC7EE30", Offset = "0xC7DC30", Length = "0xC")]
	public bool GetScrollDownHeld()
	{
		return false;
	}

	[Token(Token = "0x60044E8")]
	[Address(RVA = "0xC7EE40", Offset = "0xC7DC40", Length = "0xC")]
	public bool GetScrollUpHeld()
	{
		return false;
	}

	[Token(Token = "0x60044E9")]
	[Address(RVA = "0xC7EE50", Offset = "0xC7DC50", Length = "0x2BB")]
	public Vector2 GetMenuNavigationPrimary()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60044EA")]
	[Address(RVA = "0xC7F110", Offset = "0xC7DF10", Length = "0x9A")]
	public Vector2 GetMenuNavigationSecondary()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60044EB")]
	[Address(RVA = "0xC7F1B0", Offset = "0xC7DFB0", Length = "0xC")]
	public bool GetRadialButtonHeldDown()
	{
		return false;
	}

	[Token(Token = "0x60044EC")]
	[Address(RVA = "0xC7F1C0", Offset = "0xC7DFC0", Length = "0xC")]
	public bool GetRadialButton()
	{
		return false;
	}

	[Token(Token = "0x60044ED")]
	[Address(RVA = "0xC7F1D0", Offset = "0xC7DFD0", Length = "0xC")]
	public bool GetInventoryDropPressed()
	{
		return false;
	}

	[Token(Token = "0x60044EE")]
	[Address(RVA = "0xC7F1E0", Offset = "0xC7DFE0", Length = "0xC")]
	public bool GetInventoryDropHeldDown()
	{
		return false;
	}

	[Token(Token = "0x60044EF")]
	[Address(RVA = "0xC7F1F0", Offset = "0xC7DFF0", Length = "0xC")]
	public bool GetInventoryDropReleased()
	{
		return false;
	}

	[Token(Token = "0x60044F0")]
	[Address(RVA = "0xC7F200", Offset = "0xC7E000", Length = "0xC")]
	public bool GetInventoryFilterLeftPressed()
	{
		return false;
	}

	[Token(Token = "0x60044F1")]
	[Address(RVA = "0xC7F210", Offset = "0xC7E010", Length = "0xC")]
	public bool GetInventoryFilterRightPressed()
	{
		return false;
	}

	[Token(Token = "0x60044F2")]
	[Address(RVA = "0xC7F220", Offset = "0xC7E020", Length = "0xC")]
	public bool GetInventoryEquipPressed()
	{
		return false;
	}

	[Token(Token = "0x60044F3")]
	[Address(RVA = "0xC7F230", Offset = "0xC7E030", Length = "0xC")]
	public bool GetInventoryExaminePressed()
	{
		return false;
	}

	[Token(Token = "0x60044F4")]
	[Address(RVA = "0xC7F240", Offset = "0xC7E040", Length = "0xC")]
	public bool GetInventorySortPressed()
	{
		return false;
	}

	[Token(Token = "0x60044F5")]
	[Address(RVA = "0xC7F250", Offset = "0xC7E050", Length = "0xC")]
	public bool GetInventoryAddToSatchelPressed()
	{
		return false;
	}

	[Token(Token = "0x60044F6")]
	[Address(RVA = "0xC7F260", Offset = "0xC7E060", Length = "0xC")]
	public bool GetContainerSelectLeftTablePressed()
	{
		return false;
	}

	[Token(Token = "0x60044F7")]
	[Address(RVA = "0xC7F270", Offset = "0xC7E070", Length = "0xC")]
	public bool GetContainerSelectRightTablePressed()
	{
		return false;
	}

	[Token(Token = "0x60044F8")]
	[Address(RVA = "0xC7F280", Offset = "0xC7E080", Length = "0xC")]
	public bool GetOptionsConfirmPressed()
	{
		return false;
	}

	[Token(Token = "0x60044F9")]
	[Address(RVA = "0xC7F290", Offset = "0xC7E090", Length = "0x97")]
	public bool GetStruggleTapPressed()
	{
		return false;
	}

	[Token(Token = "0x60044FA")]
	[Address(RVA = "0xC7F330", Offset = "0xC7E130", Length = "0x97")]
	public bool GetStruggleTapHeldDown()
	{
		return false;
	}

	[Token(Token = "0x60044FB")]
	[Address(RVA = "0xC7F3D0", Offset = "0xC7E1D0", Length = "0xC")]
	public bool GetFeedFireTakeTorchePressed()
	{
		return false;
	}

	[Token(Token = "0x60044FC")]
	[Address(RVA = "0xC7F3E0", Offset = "0xC7E1E0", Length = "0xC")]
	public bool GetQuickSelect1Pressed()
	{
		return false;
	}

	[Token(Token = "0x60044FD")]
	[Address(RVA = "0xC7F3F0", Offset = "0xC7E1F0", Length = "0xC")]
	public bool GetQuickSelect2Pressed()
	{
		return false;
	}

	[Token(Token = "0x60044FE")]
	[Address(RVA = "0xC7F400", Offset = "0xC7E200", Length = "0xC")]
	public bool GetQuickSelect3Pressed()
	{
		return false;
	}

	[Token(Token = "0x60044FF")]
	[Address(RVA = "0xC7F410", Offset = "0xC7E210", Length = "0xC")]
	public bool GetQuickSelect4Pressed()
	{
		return false;
	}

	[Token(Token = "0x6004500")]
	[Address(RVA = "0xC7F420", Offset = "0xC7E220", Length = "0x97")]
	public bool GetTabLeftPressed()
	{
		return false;
	}

	[Token(Token = "0x6004501")]
	[Address(RVA = "0xC7F4C0", Offset = "0xC7E2C0", Length = "0x97")]
	public bool GetTabRightPressed()
	{
		return false;
	}

	[Token(Token = "0x6004502")]
	[Address(RVA = "0xC7F560", Offset = "0xC7E360", Length = "0x97")]
	public bool GetFirePressed()
	{
		return false;
	}

	[Token(Token = "0x6004503")]
	[Address(RVA = "0xC7F600", Offset = "0xC7E400", Length = "0x97")]
	public bool GetFireReleased()
	{
		return false;
	}

	[Token(Token = "0x6004504")]
	[Address(RVA = "0xC7F6A0", Offset = "0xC7E4A0", Length = "0xC")]
	public bool GetAltFirePressed()
	{
		return false;
	}

	[Token(Token = "0x6004505")]
	[Address(RVA = "0xC7F6B0", Offset = "0xC7E4B0", Length = "0xC")]
	public bool GetAltFire()
	{
		return false;
	}

	[Token(Token = "0x6004506")]
	[Address(RVA = "0xC7F6C0", Offset = "0xC7E4C0", Length = "0xC")]
	public bool GetAltFireReleased()
	{
		return false;
	}

	[Token(Token = "0x6004507")]
	[Address(RVA = "0xC7F6D0", Offset = "0xC7E4D0", Length = "0x48")]
	public float GetFlyModeMoveSlowMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x6004508")]
	[Address(RVA = "0xC7F720", Offset = "0xC7E520", Length = "0x48")]
	public float GetFlyModeMoveFastMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x6004509")]
	[Address(RVA = "0xC7F770", Offset = "0xC7E570", Length = "0xC")]
	public bool GetFlyModeMoveUpDown()
	{
		return false;
	}

	[Token(Token = "0x600450A")]
	[Address(RVA = "0xC7F780", Offset = "0xC7E580", Length = "0xC")]
	public bool GetFlyModeMoveDownDown()
	{
		return false;
	}

	[Token(Token = "0x600450B")]
	[Address(RVA = "0xC7F790", Offset = "0xC7E590", Length = "0xC")]
	public bool GetFlyModeLockOrientationDown()
	{
		return false;
	}

	[Token(Token = "0x600450C")]
	[Address(RVA = "0xC7F7A0", Offset = "0xC7E5A0", Length = "0xC")]
	public bool GetFlyModeAcceptPlacement()
	{
		return false;
	}

	[Token(Token = "0x600450D")]
	[Address(RVA = "0xC7F7B0", Offset = "0xC7E5B0", Length = "0xC")]
	public bool GetFlyModeCancelPlacement()
	{
		return false;
	}

	[Token(Token = "0x600450E")]
	[Address(RVA = "0xC7F7C0", Offset = "0xC7E5C0", Length = "0x61")]
	public bool GetFlyModeToggleEnabled()
	{
		return false;
	}

	[Token(Token = "0x600450F")]
	[Address(RVA = "0xC7F830", Offset = "0xC7E630", Length = "0x4F")]
	public bool GetThreeDaysOfNightToggle()
	{
		return false;
	}

	[Token(Token = "0x6004510")]
	[Address(RVA = "0xC7F880", Offset = "0xC7E680", Length = "0xC")]
	public bool GetFlyModeToggleCoords()
	{
		return false;
	}

	[Token(Token = "0x6004511")]
	[Address(RVA = "0xC7F890", Offset = "0xC7E690", Length = "0xC")]
	public bool GetSafeCrackingLeft()
	{
		return false;
	}

	[Token(Token = "0x6004512")]
	[Address(RVA = "0xC7F8A0", Offset = "0xC7E6A0", Length = "0xC")]
	public bool GetSafeCrackingRight()
	{
		return false;
	}

	[Token(Token = "0x6004513")]
	[Address(RVA = "0xC7F8B0", Offset = "0xC7E6B0", Length = "0x22")]
	public float GetSafeCrackingMovementDirection()
	{
		return 0f;
	}

	[Token(Token = "0x6004514")]
	[Address(RVA = "0xC7F8E0", Offset = "0xC7E6E0", Length = "0xE1")]
	public bool GetDebugMenuTogglePressed()
	{
		return false;
	}

	[Token(Token = "0x6004515")]
	[Address(RVA = "0xC7F9D0", Offset = "0xC7E7D0", Length = "0xC")]
	public bool GetLeftPressed()
	{
		return false;
	}

	[Token(Token = "0x6004516")]
	[Address(RVA = "0xC7F9E0", Offset = "0xC7E7E0", Length = "0xC")]
	public bool GetRightPressed()
	{
		return false;
	}

	[Token(Token = "0x6004517")]
	[Address(RVA = "0xC7F9F0", Offset = "0xC7E7F0", Length = "0xC")]
	public bool GetShowAccountPickerPressed()
	{
		return false;
	}

	[Token(Token = "0x6004518")]
	[Address(RVA = "0xC7FA00", Offset = "0xC7E800", Length = "0xC")]
	public bool GetShowStatsScreenPressed()
	{
		return false;
	}

	[Token(Token = "0x6004519")]
	[Address(RVA = "0xC7FA10", Offset = "0xC7E810", Length = "0xC")]
	public bool GetResetAllTimeStatsPressed()
	{
		return false;
	}

	[Token(Token = "0x600451A")]
	[Address(RVA = "0xC7FA20", Offset = "0xC7E820", Length = "0xC")]
	public bool GetRenamePressed()
	{
		return false;
	}

	[Token(Token = "0x600451B")]
	[Address(RVA = "0xC7FA30", Offset = "0xC7E830", Length = "0xC")]
	public bool GetDeletePressed()
	{
		return false;
	}

	[Token(Token = "0x600451C")]
	[Address(RVA = "0xC7FA40", Offset = "0xC7E840", Length = "0xC")]
	public bool GetOverwritePressed()
	{
		return false;
	}

	[Token(Token = "0x600451D")]
	[Address(RVA = "0xC7FA50", Offset = "0xC7E850", Length = "0xC")]
	public bool GetSaveJournalPressed()
	{
		return false;
	}

	[Token(Token = "0x600451E")]
	[Address(RVA = "0xC7FA60", Offset = "0xC7E860", Length = "0xC")]
	public bool GetRotateClockwiseHeld()
	{
		return false;
	}

	[Token(Token = "0x600451F")]
	[Address(RVA = "0xC7FA70", Offset = "0xC7E870", Length = "0xC")]
	public bool GetRotateCounterClockwiseHeld()
	{
		return false;
	}

	[Token(Token = "0x6004520")]
	[Address(RVA = "0xC7FA80", Offset = "0xC7E880", Length = "0xC")]
	public bool GetCraftingPressed()
	{
		return false;
	}

	[Token(Token = "0x6004521")]
	[Address(RVA = "0xC7FA90", Offset = "0xC7E890", Length = "0xC")]
	public bool GetCookingPressed()
	{
		return false;
	}

	[Token(Token = "0x6004522")]
	[Address(RVA = "0xC7FAA0", Offset = "0xC7E8A0", Length = "0xC")]
	public bool GetSafehouseCustomizePressed()
	{
		return false;
	}

	[Token(Token = "0x6004523")]
	[Address(RVA = "0xC7FAB0", Offset = "0xC7E8B0", Length = "0xC")]
	public bool GetShowSteamControllerBindingsPressed()
	{
		return false;
	}

	[Token(Token = "0x6004524")]
	[Address(RVA = "0xC7FAC0", Offset = "0xC7E8C0", Length = "0xEA")]
	public bool PoleForKeyRemap(string actionName, out string keyName)
	{
		keyName = null;
		return false;
	}

	[Token(Token = "0x6004525")]
	[Address(RVA = "0xC7FBB0", Offset = "0xC7E9B0", Length = "0x2B4")]
	public void UpdateKeyBindingTable()
	{
	}

	[Token(Token = "0x6004526")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ApplyRemapping()
	{
	}

	[Token(Token = "0x6004527")]
	[Address(RVA = "0xC7FE70", Offset = "0xC7EC70", Length = "0x197")]
	public void ResetKeybindingsToDefault()
	{
	}

	[Token(Token = "0x6004528")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void InitializeDefaultKeyBindings()
	{
	}

	[Token(Token = "0x6004529")]
	[Address(RVA = "0xC80010", Offset = "0xC7EE10", Length = "0x1AD")]
	public string GetButtonNameForAction(InputManager.ControllerType controllerType, string action, bool convertKeycodes = true)
	{
		return null;
	}

	[Token(Token = "0x600452A")]
	[Address(RVA = "0xC801C0", Offset = "0xC7EFC0", Length = "0xE5")]
	public void SetGamepadEnabled(bool enabled)
	{
	}

	[Token(Token = "0x600452B")]
	[Address(RVA = "0xC802B0", Offset = "0xC7F0B0", Length = "0x7")]
	public void OnPlayerControllerDisconnected()
	{
	}

	[Token(Token = "0x600452C")]
	[Address(RVA = "0xC802C0", Offset = "0xC7F0C0", Length = "0x69")]
	private KeyboardMap GetKeyboardMap()
	{
		return null;
	}

	[Token(Token = "0x600452D")]
	[Address(RVA = "0xC80330", Offset = "0xC7F130", Length = "0x69")]
	private MouseMap GetMouseMap()
	{
		return null;
	}

	[Token(Token = "0x600452E")]
	[Address(RVA = "0xC803A0", Offset = "0xC7F1A0", Length = "0x230")]
	private void MaybeSetGamepadActive()
	{
	}

	[Token(Token = "0x600452F")]
	[Address(RVA = "0xC805E0", Offset = "0xC7F3E0", Length = "0x219")]
	private void MaybeSetMouseOrKeyboardActive()
	{
	}

	[Token(Token = "0x6004530")]
	[Address(RVA = "0xC80800", Offset = "0xC7F600", Length = "0x25C")]
	private void JoystickConnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6004531")]
	[Address(RVA = "0xC80A60", Offset = "0xC7F860", Length = "0xF3")]
	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6004532")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void JoystickDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6004533")]
	[Address(RVA = "0xC80B60", Offset = "0xC7F960", Length = "0x4F2")]
	private void SetActiveController(Controller controller)
	{
	}

	[Token(Token = "0x6004534")]
	[Address(RVA = "0xC81060", Offset = "0xC7FE60", Length = "0x241")]
	private bool FindActiveGamepad(bool includeAxis)
	{
		return false;
	}

	[Token(Token = "0x6004535")]
	[Address(RVA = "0xC812B0", Offset = "0xC800B0", Length = "0x5D")]
	private void RemoveKeybinding(InputAction action)
	{
	}

	[Token(Token = "0x6004536")]
	[Address(RVA = "0xC81310", Offset = "0xC80110", Length = "0x16A")]
	private void CreateReassignment(ActionElementMap existingBinding, InputAction action)
	{
	}

	[Token(Token = "0x6004537")]
	[Address(RVA = "0xC81480", Offset = "0xC80280", Length = "0x362")]
	private void RebindKeybindingConflicts(ControllerMap controllerMap, ElementAssignment elementAssignment, ActionElementMap existingBinding)
	{
	}

	[Token(Token = "0x6004538")]
	[Address(RVA = "0xC817F0", Offset = "0xC805F0", Length = "0x94")]
	private ActionElementMap GetExistingBinding(InputAction action)
	{
		return null;
	}

	[Token(Token = "0x6004539")]
	[Address(RVA = "0xC81890", Offset = "0xC80690", Length = "0x488")]
	private bool MaybeCreateElementAssignmentFromKeyboardPolling(string actionName)
	{
		return false;
	}

	[Token(Token = "0x600453A")]
	[Address(RVA = "0xC81D50", Offset = "0xC80B50", Length = "0x23B")]
	private bool MaybeCreateElementAssignmentFromMousePolling(string actionName)
	{
		return false;
	}

	[Token(Token = "0x600453B")]
	[Address(RVA = "0xC81F90", Offset = "0xC80D90", Length = "0x8")]
	public bool GetInputActionPressed(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x600453C")]
	[Address(RVA = "0xC81FA0", Offset = "0xC80DA0", Length = "0x8")]
	public bool GetInputActionReleased(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x600453D")]
	[Address(RVA = "0xC81FB0", Offset = "0xC80DB0", Length = "0x8")]
	public bool GetInputActionHeld(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x600453E")]
	[Address(RVA = "0xC81FC0", Offset = "0xC80DC0", Length = "0x14F1")]
	private void DebugLogControllerConnected()
	{
	}

	[Token(Token = "0x600453F")]
	[Address(RVA = "0xC834C0", Offset = "0xC822C0", Length = "0x1F2")]
	public bool IsPS4Controller()
	{
		return false;
	}

	[Token(Token = "0x6004540")]
	[Address(RVA = "0xC836C0", Offset = "0xC824C0", Length = "0x1F2")]
	public bool IsPS5Controller()
	{
		return false;
	}

	[Token(Token = "0x6004541")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool IsSwitchController()
	{
		return false;
	}

	[Token(Token = "0x6004542")]
	[Address(RVA = "0x912A40", Offset = "0x911840", Length = "0x5")]
	public bool HasReconnectedPS4Controller()
	{
		return false;
	}

	[Token(Token = "0x6004543")]
	[Address(RVA = "0x5C6C80", Offset = "0x5C5A80", Length = "0x5")]
	public bool HasReconnectedJoystick()
	{
		return false;
	}

	[Token(Token = "0x6004544")]
	[Address(RVA = "0xC838C0", Offset = "0xC826C0", Length = "0x4A")]
	public bool IsXboxController()
	{
		return false;
	}

	[Token(Token = "0x6004545")]
	[Address(RVA = "0xC83910", Offset = "0xC82710", Length = "0x22C")]
	public void StopVibration()
	{
	}

	[Token(Token = "0x6004546")]
	[Address(RVA = "0xC83B40", Offset = "0xC82940", Length = "0x18B")]
	public void SetVibration(float motor0, float motor1)
	{
	}

	[Token(Token = "0x6004547")]
	[Address(RVA = "0xC83CD0", Offset = "0xC82AD0", Length = "0x53B")]
	private void InitializeSteamController()
	{
	}

	[Token(Token = "0x6004548")]
	[Address(RVA = "0xC84210", Offset = "0xC83010", Length = "0x1AE")]
	private bool InMenus()
	{
		return false;
	}

	[Token(Token = "0x6004549")]
	[Address(RVA = "0xC843C0", Offset = "0xC831C0", Length = "0x7")]
	public void SetInInteractiveDisplay(bool inInteractiveDisplay)
	{
	}

	[Token(Token = "0x600454A")]
	[Address(RVA = "0xC843D0", Offset = "0xC831D0", Length = "0x8")]
	public bool IsInInteractiveDisplay()
	{
		return false;
	}

	[Token(Token = "0x600454B")]
	[Address(RVA = "0xC843E0", Offset = "0xC831E0", Length = "0x9")]
	public static float GetSteamInputSensitivityFactor()
	{
		return 0f;
	}

	[Token(Token = "0x600454C")]
	[Address(RVA = "0xC843F0", Offset = "0xC831F0", Length = "0x33")]
	public void RefreshSteamControllerActionSet()
	{
	}

	[Token(Token = "0x600454D")]
	[Address(RVA = "0xC84430", Offset = "0xC83230", Length = "0x3A0")]
	public void UpdateSteamController()
	{
	}

	[Token(Token = "0x600454E")]
	[Address(RVA = "0xC847E0", Offset = "0xC835E0", Length = "0xA3")]
	public bool IsSteamControllerActive()
	{
		return false;
	}

	[Token(Token = "0x600454F")]
	[Address(RVA = "0xC84890", Offset = "0xC83690", Length = "0x125")]
	public ESteamInputType GetCurrentControllerSteamInputType()
	{
		return default(ESteamInputType);
	}

	[Token(Token = "0x6004550")]
	[Address(RVA = "0xC849C0", Offset = "0xC837C0", Length = "0x6F")]
	public bool IsSteamControllerDisconnected()
	{
		return false;
	}

	[Token(Token = "0x6004551")]
	[Address(RVA = "0xC84A30", Offset = "0xC83830", Length = "0x2C")]
	private bool IsSteamControllerPresent()
	{
		return false;
	}

	[Token(Token = "0x6004552")]
	[Address(RVA = "0xC84A60", Offset = "0xC83860", Length = "0x322")]
	private bool FindActiveSteamController()
	{
		return false;
	}

	[Token(Token = "0x6004553")]
	[Address(RVA = "0xC84D90", Offset = "0xC83B90", Length = "0x12C")]
	private bool AnySteamButtonPressed()
	{
		return false;
	}

	[Token(Token = "0x6004554")]
	[Address(RVA = "0xC84EC0", Offset = "0xC83CC0", Length = "0x168")]
	private bool AnySteamAxisPressed()
	{
		return false;
	}

	[Token(Token = "0x6004555")]
	[Address(RVA = "0xC85030", Offset = "0xC83E30", Length = "0x96")]
	private bool GetSteamButtonPressed(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x6004556")]
	[Address(RVA = "0xC850D0", Offset = "0xC83ED0", Length = "0x8D")]
	private bool GetSteamButtonUnpressed(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x6004557")]
	[Address(RVA = "0xC85160", Offset = "0xC83F60", Length = "0x85")]
	private bool GetSteamButton(InputManager.InputAction action)
	{
		return false;
	}

	[Token(Token = "0x6004558")]
	[Address(RVA = "0xC851F0", Offset = "0xC83FF0", Length = "0x714")]
	private string GetSteamButtonOrAxisNameForAction(string action)
	{
		return null;
	}

	[Token(Token = "0x6004559")]
	[Address(RVA = "0xC85910", Offset = "0xC84710", Length = "0x18B")]
	private void AddInactiveActionSets(InputActionSetHandle_t currentActionSet, List<InputActionSetHandle_t> actionSets)
	{
	}

	[Token(Token = "0x600455A")]
	[Address(RVA = "0xC85AA0", Offset = "0xC848A0", Length = "0x1A4")]
	private string GetFallbackDigitalActionOrigin(InputHandle_t controller, InputActionSetHandle_t currentActionSet, InputDigitalActionHandle_t actionHandle)
	{
		return null;
	}

	[Token(Token = "0x600455B")]
	[Address(RVA = "0xC85C50", Offset = "0xC84A50", Length = "0x1A4")]
	private string GetFallbackAnalogActionOrigin(InputHandle_t controller, InputActionSetHandle_t currentActionSet, InputAnalogActionHandle_t actionHandle)
	{
		return null;
	}

	[Token(Token = "0x600455C")]
	[Address(RVA = "0xC85E00", Offset = "0xC84C00", Length = "0x68")]
	private bool TryParseInputAction(string action, out InputManager.InputAction inputAction)
	{
		inputAction = default(InputManager.InputAction);
		return false;
	}

	[Token(Token = "0x600455D")]
	[Address(RVA = "0xC85E70", Offset = "0xC84C70", Length = "0x210")]
	private void ResetSteamControllerState()
	{
	}

	[Token(Token = "0x600455E")]
	[Address(RVA = "0xC86090", Offset = "0xC84E90", Length = "0x144")]
	public void ShowSteamControllerBindingPanel()
	{
	}

	[Token(Token = "0x600455F")]
	[Address(RVA = "0xC861E0", Offset = "0xC84FE0", Length = "0x32C")]
	private bool TryUpdateSteamControllerActionSet(int connectedSteamControllers)
	{
		return false;
	}

	[Token(Token = "0x6004560")]
	[Address(RVA = "0xC86510", Offset = "0xC85310", Length = "0x15D0")]
	public InputSystemRewired()
	{
	}
}
