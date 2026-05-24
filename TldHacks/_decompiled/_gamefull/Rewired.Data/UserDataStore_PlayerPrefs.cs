using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Rewired.Utils.Attributes;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data;

[Token(Token = "0x2000C1C")]
public class UserDataStore_PlayerPrefs : UserDataStore
{
	[Token(Token = "0x2000C1D")]
	private class ControllerAssignmentSaveInfo
	{
		[Token(Token = "0x2000C1E")]
		public class PlayerInfo
		{
			[Token(Token = "0x4007BFF")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			[Token(Token = "0x4007C00")]
			[FieldOffset(Offset = "0x14")]
			public bool hasKeyboard;

			[Token(Token = "0x4007C01")]
			[FieldOffset(Offset = "0x15")]
			public bool hasMouse;

			[Token(Token = "0x4007C02")]
			[FieldOffset(Offset = "0x18")]
			public JoystickInfo[] joysticks;

			[Token(Token = "0x17000653")]
			public int joystickCount
			{
				[Token(Token = "0x60061FA")]
				[Address(RVA = "0xFA6F60", Offset = "0xFA5D60", Length = "0xE")]
				get
				{
					return 0;
				}
			}

			[Token(Token = "0x60061FB")]
			[Address(RVA = "0xFA6F70", Offset = "0xFA5D70", Length = "0x58")]
			public int IndexOfJoystick(int joystickId)
			{
				return 0;
			}

			[Token(Token = "0x60061FC")]
			[Address(RVA = "0xFA6FD0", Offset = "0xFA5DD0", Length = "0x5D")]
			public bool ContainsJoystick(int joystickId)
			{
				return false;
			}

			[Token(Token = "0x60061FD")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			public PlayerInfo()
			{
			}
		}

		[Token(Token = "0x2000C1F")]
		public class JoystickInfo
		{
			[Token(Token = "0x4007C03")]
			[FieldOffset(Offset = "0x10")]
			public Guid instanceGuid;

			[Token(Token = "0x4007C04")]
			[FieldOffset(Offset = "0x20")]
			public string hardwareIdentifier;

			[Token(Token = "0x4007C05")]
			[FieldOffset(Offset = "0x28")]
			public int id;

			[Token(Token = "0x60061FE")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			public JoystickInfo()
			{
			}
		}

		[Token(Token = "0x4007BFE")]
		[FieldOffset(Offset = "0x10")]
		public PlayerInfo[] players;

		[Token(Token = "0x17000652")]
		public int playerCount
		{
			[Token(Token = "0x60061F5")]
			[Address(RVA = "0xFA6C70", Offset = "0xFA5A70", Length = "0xE")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x60061F6")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ControllerAssignmentSaveInfo()
		{
		}

		[Token(Token = "0x60061F7")]
		[Address(RVA = "0xFB1870", Offset = "0xFB0670", Length = "0x21B")]
		public ControllerAssignmentSaveInfo(int playerCount)
		{
		}

		[Token(Token = "0x60061F8")]
		[Address(RVA = "0xFA6EA0", Offset = "0xFA5CA0", Length = "0x58")]
		public int IndexOfPlayer(int playerId)
		{
			return 0;
		}

		[Token(Token = "0x60061F9")]
		[Address(RVA = "0xFA6F00", Offset = "0xFA5D00", Length = "0x5D")]
		public bool ContainsPlayer(int playerId)
		{
			return false;
		}
	}

	[Token(Token = "0x2000C20")]
	private class JoystickAssignmentHistoryInfo
	{
		[Token(Token = "0x4007C06")]
		[FieldOffset(Offset = "0x10")]
		public readonly Joystick joystick;

		[Token(Token = "0x4007C07")]
		[FieldOffset(Offset = "0x18")]
		public readonly int oldJoystickId;

		[Token(Token = "0x60061FF")]
		[Address(RVA = "0xFB1A90", Offset = "0xFB0890", Length = "0xAC")]
		public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000C21")]
	private class ControllerElementByRoleMap
	{
		[Serializable]
		[Token(Token = "0x2000C22")]
		public struct Entry
		{
			[Token(Token = "0x4007C0A")]
			[FieldOffset(Offset = "0x0")]
			public int actionId;

			[Token(Token = "0x4007C0B")]
			[FieldOffset(Offset = "0x4")]
			public ControllerElementType elementType;

			[Token(Token = "0x4007C0C")]
			[FieldOffset(Offset = "0x8")]
			public AxisRange axisRange;

			[Token(Token = "0x4007C0D")]
			[FieldOffset(Offset = "0xC")]
			public bool invert;

			[Token(Token = "0x4007C0E")]
			[FieldOffset(Offset = "0x10")]
			public Pole axisContribution;

			[Token(Token = "0x6006205")]
			[Address(RVA = "0xFA75C0", Offset = "0xFA63C0", Length = "0x236")]
			public bool TryGetElementAssignment(ControllerType controllerType, Controller.Element targetElement, out ElementAssignment assignment)
			{
				assignment = default(ElementAssignment);
				return false;
			}

			[Token(Token = "0x6006206")]
			[Address(RVA = "0xFB2010", Offset = "0xFB0E10", Length = "0x23E")]
			public override string ToString()
			{
				return null;
			}
		}

		[DoNotSerialize]
		[Token(Token = "0x4007C08")]
		[FieldOffset(Offset = "0x10")]
		public string role;

		[Token(Token = "0x4007C09")]
		[FieldOffset(Offset = "0x18")]
		public List<Entry> data;

		[Preserve]
		[Token(Token = "0x6006200")]
		[Address(RVA = "0xFB1B40", Offset = "0xFB0940", Length = "0xAD")]
		public ControllerElementByRoleMap()
		{
		}

		[Token(Token = "0x6006201")]
		[Address(RVA = "0xFB1BF0", Offset = "0xFB09F0", Length = "0xF5")]
		public void Add(ActionElementMap elementMap)
		{
		}

		[Token(Token = "0x6006202")]
		[Address(RVA = "0xFB1CF0", Offset = "0xFB0AF0", Length = "0x257")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6006203")]
		[Address(RVA = "0xFA74F0", Offset = "0xFA62F0", Length = "0x7")]
		public string ToJson()
		{
			return null;
		}

		[Token(Token = "0x6006204")]
		[Address(RVA = "0xFB1F50", Offset = "0xFB0D50", Length = "0xBF")]
		public static ControllerElementByRoleMap FromJson(string role, string json)
		{
			return null;
		}
	}

	[Token(Token = "0x2000C23")]
	public enum ActionMappingSaveMode
	{
		[Token(Token = "0x4007C10")]
		ByController,
		[Token(Token = "0x4007C11")]
		ByControllerElementRole
	}

	[CompilerGenerated]
	[Token(Token = "0x2000C27")]
	private sealed class _003CLoadJoystickAssignmentsDeferred_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4007C15")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4007C16")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4007C17")]
		[FieldOffset(Offset = "0x20")]
		public UserDataStore_PlayerPrefs _003C_003E4__this;

		[Token(Token = "0x17000654")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006210")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000655")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006212")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x600620D")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CLoadJoystickAssignmentsDeferred_003Ed__88(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x600620E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600620F")]
		[Address(RVA = "0xFB2250", Offset = "0xFB1050", Length = "0x121")]
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
		[Token(Token = "0x6006211")]
		[Address(RVA = "0xFB2380", Offset = "0xFB1180", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4007BE6")]
	private const string thisScriptName = "UserDataStore_PlayerPrefs";

	[Token(Token = "0x4007BE7")]
	private const string logPrefix = "Rewired: ";

	[Token(Token = "0x4007BE8")]
	private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

	[Token(Token = "0x4007BE9")]
	private const int controllerMapPPKeyVersion_original = 0;

	[Token(Token = "0x4007BEA")]
	private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

	[Token(Token = "0x4007BEB")]
	private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

	[Token(Token = "0x4007BEC")]
	private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

	[Token(Token = "0x4007BED")]
	private const int controllerMapPPKeyVersion = 2;

	[Token(Token = "0x4007BEE")]
	private const int controllerElementByRoleMapPPKeyVersion = 0;

	[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
	[SerializeField]
	[Token(Token = "0x4007BEF")]
	[FieldOffset(Offset = "0x20")]
	private bool isEnabled;

	[Tooltip("Should saved data be loaded on start?")]
	[SerializeField]
	[Token(Token = "0x4007BF0")]
	[FieldOffset(Offset = "0x21")]
	private bool loadDataOnStart;

	[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
	[SerializeField]
	[Token(Token = "0x4007BF1")]
	[FieldOffset(Offset = "0x22")]
	private bool loadJoystickAssignments;

	[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
	[SerializeField]
	[Token(Token = "0x4007BF2")]
	[FieldOffset(Offset = "0x23")]
	private bool loadKeyboardAssignments;

	[Tooltip("Should Player Mouse assignments be saved and loaded?")]
	[SerializeField]
	[Token(Token = "0x4007BF3")]
	[FieldOffset(Offset = "0x24")]
	private bool loadMouseAssignments;

	[Tooltip("How should Action mapping data be saved?\n\nBy Controller: Data is stored per-controller. Action mappings apply only to the specific controller for which it was saved.\n\nBy Controller Element Role: Data is stored per-element on the controller if the controller element has a known role. Action mappings are mirrored on controller elements with the same role on all other controllers for the Player. Example: When saving Action mappings for a gamepad, element on all gamepads that have the same roles will inherit the mappings. This allows you to remap once for all compatible gamepads simultaneously, for example. This can extend beyond just gamepads, however. For example: On a console platform, a racing wheel with A, B, X, Y, D-Pad etc. elements will also reflect the same Action mappings if the gamepad is remapped. Action mappings for any controller elements that do not have known roles will be saved per-controller. Warning: Do not use this mode if you need to allow a Player to save different mappings for multiple controllers of the same type such as gamepads. (This option currently works best for gamepads and only miminally for other controller types.)")]
	[SerializeField]
	[Token(Token = "0x4007BF4")]
	[FieldOffset(Offset = "0x28")]
	private ActionMappingSaveMode _actionMappingSaveMode;

	[Tooltip("The PlayerPrefs key prefix. Change this to change how keys are stored in PlayerPrefs. Changing this will make saved data already stored with the old key no longer accessible.")]
	[SerializeField]
	[Token(Token = "0x4007BF5")]
	[FieldOffset(Offset = "0x30")]
	private string playerPrefsKeyPrefix;

	[NonSerialized]
	[Token(Token = "0x4007BF6")]
	[FieldOffset(Offset = "0x38")]
	private bool allowImpreciseJoystickAssignmentMatching;

	[NonSerialized]
	[Token(Token = "0x4007BF7")]
	[FieldOffset(Offset = "0x39")]
	private bool deferredJoystickAssignmentLoadPending;

	[NonSerialized]
	[Token(Token = "0x4007BF8")]
	[FieldOffset(Offset = "0x3A")]
	private bool wasJoystickEverDetected;

	[NonSerialized]
	[Token(Token = "0x4007BF9")]
	[FieldOffset(Offset = "0x40")]
	private List<int> __allActionIds;

	[NonSerialized]
	[Token(Token = "0x4007BFA")]
	[FieldOffset(Offset = "0x48")]
	private string __allActionIdsString;

	[NonSerialized]
	[Token(Token = "0x4007BFB")]
	[FieldOffset(Offset = "0x50")]
	private readonly StringBuilder _sb;

	[NonSerialized]
	[Token(Token = "0x4007BFC")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<string, ControllerElementByRoleMap> _tempElementByRoleMaps;

	[NonSerialized]
	[Token(Token = "0x4007BFD")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<string, bool> _tempElementByRoleMapsEnabled;

	[Token(Token = "0x17000647")]
	public bool IsEnabled
	{
		[Token(Token = "0x6006191")]
		[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006192")]
		[Address(RVA = "0x4D3E50", Offset = "0x4D2C50", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000648")]
	public bool LoadDataOnStart
	{
		[Token(Token = "0x6006193")]
		[Address(RVA = "0x5327B0", Offset = "0x5315B0", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006194")]
		[Address(RVA = "0x5D13B0", Offset = "0x5D01B0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000649")]
	public bool LoadJoystickAssignments
	{
		[Token(Token = "0x6006195")]
		[Address(RVA = "0xF7E710", Offset = "0xF7D510", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006196")]
		[Address(RVA = "0xF7E720", Offset = "0xF7D520", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700064A")]
	public bool LoadKeyboardAssignments
	{
		[Token(Token = "0x6006197")]
		[Address(RVA = "0xF7E730", Offset = "0xF7D530", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006198")]
		[Address(RVA = "0xF7E740", Offset = "0xF7D540", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700064B")]
	public bool LoadMouseAssignments
	{
		[Token(Token = "0x6006199")]
		[Address(RVA = "0x621E50", Offset = "0x620C50", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x600619A")]
		[Address(RVA = "0x61D6C0", Offset = "0x61C4C0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700064C")]
	public ActionMappingSaveMode actionMappingSaveMode
	{
		[Token(Token = "0x600619B")]
		[Address(RVA = "0x4588A0", Offset = "0x4576A0", Length = "0x4")]
		get
		{
			return default(ActionMappingSaveMode);
		}
		[Token(Token = "0x600619C")]
		[Address(RVA = "0x92FF10", Offset = "0x92ED10", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700064D")]
	public string PlayerPrefsKeyPrefix
	{
		[Token(Token = "0x600619D")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600619E")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700064E")]
	private string playerPrefsKey_controllerAssignments
	{
		[Token(Token = "0x600619F")]
		[Address(RVA = "0xFA7C00", Offset = "0xFA6A00", Length = "0x9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700064F")]
	private bool loadControllerAssignments
	{
		[Token(Token = "0x60061A0")]
		[Address(RVA = "0xF7E750", Offset = "0xF7D550", Length = "0x14")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000650")]
	private List<int> allActionIds
	{
		[Token(Token = "0x60061A1")]
		[Address(RVA = "0xFA7CA0", Offset = "0xFA6AA0", Length = "0x2FB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000651")]
	private string allActionIdsString
	{
		[Token(Token = "0x60061A2")]
		[Address(RVA = "0xFA7FA0", Offset = "0xFA6DA0", Length = "0x18F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60061A3")]
	[Address(RVA = "0xFA8130", Offset = "0xFA6F30", Length = "0x7C")]
	public override void Save()
	{
	}

	[Token(Token = "0x60061A4")]
	[Address(RVA = "0xFA81B0", Offset = "0xFA6FB0", Length = "0x139")]
	public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x60061A5")]
	[Address(RVA = "0xFA82F0", Offset = "0xFA70F0", Length = "0xE3")]
	public override void SaveControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x60061A6")]
	[Address(RVA = "0xFA83E0", Offset = "0xFA71E0", Length = "0x13A")]
	public override void SavePlayerData(int playerId)
	{
	}

	[Token(Token = "0x60061A7")]
	[Address(RVA = "0xFA8520", Offset = "0xFA7320", Length = "0x1AE")]
	public override void SaveInputBehavior(int playerId, int behaviorId)
	{
	}

	[Token(Token = "0x60061A8")]
	[Address(RVA = "0xFA86D0", Offset = "0xFA74D0", Length = "0x7C")]
	public override void Load()
	{
	}

	[Token(Token = "0x60061A9")]
	[Address(RVA = "0xFA8750", Offset = "0xFA7550", Length = "0xCD")]
	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x60061AA")]
	[Address(RVA = "0xFA8820", Offset = "0xFA7620", Length = "0xA7")]
	public override void LoadControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x60061AB")]
	[Address(RVA = "0xFA88D0", Offset = "0xFA76D0", Length = "0xE4")]
	public override void LoadPlayerData(int playerId)
	{
	}

	[Token(Token = "0x60061AC")]
	[Address(RVA = "0xFA89C0", Offset = "0xFA77C0", Length = "0x14A")]
	public override void LoadInputBehavior(int playerId, int behaviorId)
	{
	}

	[Token(Token = "0x60061AD")]
	[Address(RVA = "0xFA8B10", Offset = "0xFA7910", Length = "0xA2")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x60061AE")]
	[Address(RVA = "0xFA8BC0", Offset = "0xFA79C0", Length = "0x104")]
	protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x60061AF")]
	[Address(RVA = "0xFA8CD0", Offset = "0xFA7AD0", Length = "0x2E")]
	protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x60061B0")]
	[Address(RVA = "0xFA8D00", Offset = "0xFA7B00", Length = "0x20")]
	protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x60061B1")]
	[Address(RVA = "0xFA8D20", Offset = "0xFA7B20", Length = "0x96")]
	public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
	{
	}

	[Token(Token = "0x60061B2")]
	[Address(RVA = "0xFA8DC0", Offset = "0xFA7BC0", Length = "0xD3")]
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Token(Token = "0x60061B3")]
	[Address(RVA = "0xFA8EA0", Offset = "0xFA7CA0", Length = "0x20E")]
	private int LoadAll()
	{
		return 0;
	}

	[Token(Token = "0x60061B4")]
	[Address(RVA = "0xFA90B0", Offset = "0xFA7EB0", Length = "0x7B")]
	private int LoadPlayerDataNow(int playerId)
	{
		return 0;
	}

	[Token(Token = "0x60061B5")]
	[Address(RVA = "0xFA9130", Offset = "0xFA7F30", Length = "0x2BB")]
	private int LoadPlayerDataNow(Player player)
	{
		return 0;
	}

	[Token(Token = "0x60061B6")]
	[Address(RVA = "0xFA93F0", Offset = "0xFA81F0", Length = "0x1E5")]
	private int LoadAllJoystickCalibrationData()
	{
		return 0;
	}

	[Token(Token = "0x60061B7")]
	[Address(RVA = "0xFA95E0", Offset = "0xFA83E0", Length = "0x133")]
	private int LoadJoystickCalibrationData(Joystick joystick)
	{
		return 0;
	}

	[Token(Token = "0x60061B8")]
	[Address(RVA = "0xFA9720", Offset = "0xFA8520", Length = "0x7B")]
	private int LoadJoystickCalibrationData(int joystickId)
	{
		return 0;
	}

	[Token(Token = "0x60061B9")]
	[Address(RVA = "0xFA97A0", Offset = "0xFA85A0", Length = "0x35B")]
	private int LoadJoystickData(int joystickId)
	{
		return 0;
	}

	[Token(Token = "0x60061BA")]
	[Address(RVA = "0xFA9B00", Offset = "0xFA8900", Length = "0x73")]
	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
		return 0;
	}

	[Token(Token = "0x60061BB")]
	[Address(RVA = "0xFA9B80", Offset = "0xFA8980", Length = "0x15")]
	private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
	{
		return 0;
	}

	[Token(Token = "0x60061BC")]
	[Address(RVA = "0xFA9BA0", Offset = "0xFA89A0", Length = "0xD26")]
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		return 0;
	}

	[Token(Token = "0x60061BD")]
	[Address(RVA = "0xFAA8D0", Offset = "0xFA96D0", Length = "0x14D")]
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Token(Token = "0x60061BE")]
	[Address(RVA = "0xFAAA20", Offset = "0xFA9820", Length = "0x1DC")]
	private bool LoadControllerElementMapByRole(Player player, Controller controller, string role, int mapCategoryId, int layoutId, Dictionary<string, ControllerElementByRoleMap> elementByRoleMaps)
	{
		return false;
	}

	[Token(Token = "0x60061BF")]
	[Address(RVA = "0xFAAC00", Offset = "0xFA9A00", Length = "0x23F")]
	private int LoadInputBehaviors(int playerId)
	{
		return 0;
	}

	[Token(Token = "0x60061C0")]
	[Address(RVA = "0xFAAE40", Offset = "0xFA9C40", Length = "0xD8")]
	private int LoadInputBehaviorNow(int playerId, int behaviorId)
	{
		return 0;
	}

	[Token(Token = "0x60061C1")]
	[Address(RVA = "0xFAAF20", Offset = "0xFA9D20", Length = "0xF7")]
	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
		return 0;
	}

	[Token(Token = "0x60061C2")]
	[Address(RVA = "0xFAB020", Offset = "0xFA9E20", Length = "0x67")]
	private bool LoadControllerAssignmentsNow()
	{
		return false;
	}

	[Token(Token = "0x60061C3")]
	[Address(RVA = "0xFAB090", Offset = "0xFA9E90", Length = "0x37E")]
	private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return false;
	}

	[Token(Token = "0x60061C4")]
	[Address(RVA = "0xFAB410", Offset = "0xFAA210", Length = "0xF88")]
	private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return false;
	}

	[Token(Token = "0x60061C5")]
	[Address(RVA = "0xFAC3A0", Offset = "0xFAB1A0", Length = "0xF3")]
	private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__88))]
	[Token(Token = "0x60061C6")]
	[Address(RVA = "0xFAC4A0", Offset = "0xFAB2A0", Length = "0x9A")]
	private IEnumerator LoadJoystickAssignmentsDeferred()
	{
		return null;
	}

	[Token(Token = "0x60061C7")]
	[Address(RVA = "0xFAC540", Offset = "0xFAB340", Length = "0x366")]
	private void SaveAll()
	{
	}

	[Token(Token = "0x60061C8")]
	[Address(RVA = "0xFAC8B0", Offset = "0xFAB6B0", Length = "0xC9")]
	private void SavePlayerDataNow(int playerId)
	{
	}

	[Token(Token = "0x60061C9")]
	[Address(RVA = "0xFAC980", Offset = "0xFAB780", Length = "0x199")]
	private void SavePlayerDataNow(Player player)
	{
	}

	[Token(Token = "0x60061CA")]
	[Address(RVA = "0xFACB20", Offset = "0xFAB920", Length = "0x27C")]
	private void SaveAllJoystickCalibrationData()
	{
	}

	[Token(Token = "0x60061CB")]
	[Address(RVA = "0xFACDA0", Offset = "0xFABBA0", Length = "0xC1")]
	private void SaveJoystickCalibrationData(int joystickId)
	{
	}

	[Token(Token = "0x60061CC")]
	[Address(RVA = "0xFACE70", Offset = "0xFABC70", Length = "0x70")]
	private void SaveJoystickCalibrationData(Joystick joystick)
	{
	}

	[Token(Token = "0x60061CD")]
	[Address(RVA = "0xFACEF0", Offset = "0xFABCF0", Length = "0x2FE")]
	private void SaveJoystickData(int joystickId)
	{
	}

	[Token(Token = "0x60061CE")]
	[Address(RVA = "0xFAD1F0", Offset = "0xFABFF0", Length = "0xC1")]
	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x60061CF")]
	[Address(RVA = "0xFAD2C0", Offset = "0xFAC0C0", Length = "0x57")]
	private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x60061D0")]
	[Address(RVA = "0xFAD320", Offset = "0xFAC120", Length = "0x2A0")]
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
	{
	}

	[Token(Token = "0x60061D1")]
	[Address(RVA = "0xFAD5D0", Offset = "0xFAC3D0", Length = "0x2A3")]
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x60061D2")]
	[Address(RVA = "0xFAD880", Offset = "0xFAC680", Length = "0xB2")]
	private void SaveControllerMap(Player player, ControllerMap controllerMap)
	{
	}

	[Token(Token = "0x60061D3")]
	[Address(RVA = "0xFAD940", Offset = "0xFAC740", Length = "0x1A8")]
	private void SaveControllerMapByController(Player player, ControllerMap controllerMap)
	{
	}

	[Token(Token = "0x60061D4")]
	[Address(RVA = "0xFADAF0", Offset = "0xFAC8F0", Length = "0x865")]
	private void SaveControllerMapByControllerElementRole(Player player, Controller controller, ControllerMap controllerMap)
	{
	}

	[Token(Token = "0x60061D5")]
	[Address(RVA = "0xFAE360", Offset = "0xFAD160", Length = "0x2A4")]
	private bool AddControllerElementByRoleMapEntry(Player player, Controller controller, ActionElementMap elementMap, ref Dictionary<string, ControllerElementByRoleMap> maps)
	{
		return false;
	}

	[Token(Token = "0x60061D6")]
	[Address(RVA = "0xFAE610", Offset = "0xFAD410", Length = "0x103")]
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
	{
	}

	[Token(Token = "0x60061D7")]
	[Address(RVA = "0xFAE720", Offset = "0xFAD520", Length = "0x13C")]
	private void SaveInputBehaviorNow(int playerId, int behaviorId)
	{
	}

	[Token(Token = "0x60061D8")]
	[Address(RVA = "0xFAE860", Offset = "0xFAD660", Length = "0x49")]
	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
	}

	[Token(Token = "0x60061D9")]
	[Address(RVA = "0xFAE8B0", Offset = "0xFAD6B0", Length = "0x4C9")]
	private bool SaveControllerAssignments()
	{
		return false;
	}

	[Token(Token = "0x60061DA")]
	[Address(RVA = "0xFAED80", Offset = "0xFADB80", Length = "0x79")]
	private bool ControllerAssignmentSaveDataExists()
	{
		return false;
	}

	[Token(Token = "0x60061DB")]
	[Address(RVA = "0xFAEE00", Offset = "0xFADC00", Length = "0x180")]
	private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Token(Token = "0x60061DC")]
	[Address(RVA = "0xFAEF90", Offset = "0xFADD90", Length = "0x1F8")]
	private string GetControllerElementByRoleMapPlayerPrefsKey(Player player, string elementRole, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Token(Token = "0x60061DD")]
	[Address(RVA = "0xFAF190", Offset = "0xFADF90", Length = "0x1F2")]
	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
	{
		return null;
	}

	[Token(Token = "0x60061DE")]
	[Address(RVA = "0xFAF390", Offset = "0xFAE190", Length = "0x180")]
	private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Token(Token = "0x60061DF")]
	[Address(RVA = "0xFAF520", Offset = "0xFAE320", Length = "0x150")]
	private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
	{
		return null;
	}

	[Token(Token = "0x60061E0")]
	[Address(RVA = "0xFAF680", Offset = "0xFAE480", Length = "0x1A")]
	private static void AppendBaseKey(StringBuilder sb, string playerPrefsKeyPrefix)
	{
	}

	[Token(Token = "0x60061E1")]
	[Address(RVA = "0xFAF6A0", Offset = "0xFAE4A0", Length = "0x74")]
	private static void AppendPlayerKey(StringBuilder sb, Player player)
	{
	}

	[Token(Token = "0x60061E2")]
	[Address(RVA = "0xFAF720", Offset = "0xFAE520", Length = "0xBF")]
	private static void AppendControllerMapKey(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
	}

	[Token(Token = "0x60061E3")]
	[Address(RVA = "0xFAF7E0", Offset = "0xFAE5E0", Length = "0xBF")]
	private static void AppendControllerMapKnownActionIdsKey(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
	}

	[Token(Token = "0x60061E4")]
	[Address(RVA = "0xFAF8A0", Offset = "0xFAE6A0", Length = "0x352")]
	private static void AppendControllerMapKeyCommonSuffix(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
	}

	[Token(Token = "0x60061E5")]
	[Address(RVA = "0xFAFC00", Offset = "0xFAEA00", Length = "0x138")]
	private static void AppendControllerElementByRoleMapKey(StringBuilder sb, string elementRole, int categoryId, int layoutId, int ppKeyVersion)
	{
	}

	[Token(Token = "0x60061E6")]
	[Address(RVA = "0xFAFD40", Offset = "0xFAEB40", Length = "0x192")]
	private static void AppendJoystickCalibrationMapKey(StringBuilder sb, Joystick joystick)
	{
	}

	[Token(Token = "0x60061E7")]
	[Address(RVA = "0xFAFEE0", Offset = "0xFAECE0", Length = "0x86")]
	private static void AppendInputBehaviorKey(StringBuilder sb, int inputBehaviorId)
	{
	}

	[Token(Token = "0x60061E8")]
	[Address(RVA = "0xFAFF70", Offset = "0xFAED70", Length = "0xBD")]
	private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Token(Token = "0x60061E9")]
	[Address(RVA = "0xFB0030", Offset = "0xFAEE30", Length = "0x1D0")]
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Token(Token = "0x60061EA")]
	[Address(RVA = "0xFB0210", Offset = "0xFAF010", Length = "0x6E")]
	private string GetJoystickCalibrationMapXml(Joystick joystick)
	{
		return null;
	}

	[Token(Token = "0x60061EB")]
	[Address(RVA = "0xFB0280", Offset = "0xFAF080", Length = "0x6E")]
	private string GetInputBehaviorXml(Player player, int id)
	{
		return null;
	}

	[Token(Token = "0x60061EC")]
	[Address(RVA = "0xFB02F0", Offset = "0xFAF0F0", Length = "0x6C5")]
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
	{
	}

	[Token(Token = "0x60061ED")]
	[Address(RVA = "0xFB09C0", Offset = "0xFAF7C0", Length = "0x1D3")]
	private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
	{
		return null;
	}

	[Token(Token = "0x60061EE")]
	[Address(RVA = "0xFB0BA0", Offset = "0xFAF9A0", Length = "0x39F")]
	private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
	{
		matches = null;
		return false;
	}

	[Token(Token = "0x60061EF")]
	[Address(RVA = "0xFB0F40", Offset = "0xFAFD40", Length = "0x407")]
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
	{
		return 0;
	}

	[Token(Token = "0x60061F0")]
	[Address(RVA = "0xFB1350", Offset = "0xFB0150", Length = "0x8E")]
	private void RefreshLayoutManager(int playerId)
	{
	}

	[Token(Token = "0x60061F1")]
	[Address(RVA = "0xFB13E0", Offset = "0xFB01E0", Length = "0x189")]
	private void OnControllerMapsSaved(Player player)
	{
	}

	[Token(Token = "0x60061F2")]
	[Address(RVA = "0xFB1570", Offset = "0xFB0370", Length = "0x19C")]
	private static Type GetControllerMapType(ControllerType controllerType)
	{
		return null;
	}

	[Token(Token = "0x60061F3")]
	[Address(RVA = "0xF88530", Offset = "0xF87330", Length = "0x166")]
	private static int SortOldestToNewest(ControllerMapSaveData a, ControllerMapSaveData b)
	{
		return 0;
	}

	[Token(Token = "0x60061F4")]
	[Address(RVA = "0xFB1710", Offset = "0xFB0510", Length = "0x15F")]
	public UserDataStore_PlayerPrefs()
	{
	}
}
