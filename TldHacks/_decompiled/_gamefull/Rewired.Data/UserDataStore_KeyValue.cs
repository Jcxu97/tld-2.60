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

[Token(Token = "0x2000C0F")]
public abstract class UserDataStore_KeyValue : UserDataStore
{
	[Token(Token = "0x2000C10")]
	private class ControllerAssignmentSaveInfo
	{
		[Token(Token = "0x2000C11")]
		public class PlayerInfo
		{
			[Token(Token = "0x4007BCD")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			[Token(Token = "0x4007BCE")]
			[FieldOffset(Offset = "0x14")]
			public bool hasKeyboard;

			[Token(Token = "0x4007BCF")]
			[FieldOffset(Offset = "0x15")]
			public bool hasMouse;

			[Token(Token = "0x4007BD0")]
			[FieldOffset(Offset = "0x18")]
			public JoystickInfo[] joysticks;

			[Token(Token = "0x17000644")]
			public int joystickCount
			{
				[Token(Token = "0x6006173")]
				[Address(RVA = "0xFA6F60", Offset = "0xFA5D60", Length = "0xE")]
				get
				{
					return 0;
				}
			}

			[Token(Token = "0x6006174")]
			[Address(RVA = "0xFA6F70", Offset = "0xFA5D70", Length = "0x58")]
			public int IndexOfJoystick(int joystickId)
			{
				return 0;
			}

			[Token(Token = "0x6006175")]
			[Address(RVA = "0xFA6FD0", Offset = "0xFA5DD0", Length = "0x5D")]
			public bool ContainsJoystick(int joystickId)
			{
				return false;
			}

			[Token(Token = "0x6006176")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			public PlayerInfo()
			{
			}
		}

		[Token(Token = "0x2000C12")]
		public class JoystickInfo
		{
			[Token(Token = "0x4007BD1")]
			[FieldOffset(Offset = "0x10")]
			public Guid instanceGuid;

			[Token(Token = "0x4007BD2")]
			[FieldOffset(Offset = "0x20")]
			public string hardwareIdentifier;

			[Token(Token = "0x4007BD3")]
			[FieldOffset(Offset = "0x28")]
			public int id;

			[Token(Token = "0x6006177")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			public JoystickInfo()
			{
			}
		}

		[Token(Token = "0x4007BCC")]
		[FieldOffset(Offset = "0x10")]
		public PlayerInfo[] players;

		[Token(Token = "0x17000643")]
		public int playerCount
		{
			[Token(Token = "0x600616E")]
			[Address(RVA = "0xFA6C70", Offset = "0xFA5A70", Length = "0xE")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x600616F")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ControllerAssignmentSaveInfo()
		{
		}

		[Token(Token = "0x6006170")]
		[Address(RVA = "0xFA6C80", Offset = "0xFA5A80", Length = "0x21B")]
		public ControllerAssignmentSaveInfo(int playerCount)
		{
		}

		[Token(Token = "0x6006171")]
		[Address(RVA = "0xFA6EA0", Offset = "0xFA5CA0", Length = "0x58")]
		public int IndexOfPlayer(int playerId)
		{
			return 0;
		}

		[Token(Token = "0x6006172")]
		[Address(RVA = "0xFA6F00", Offset = "0xFA5D00", Length = "0x5D")]
		public bool ContainsPlayer(int playerId)
		{
			return false;
		}
	}

	[Token(Token = "0x2000C13")]
	private class JoystickAssignmentHistoryInfo
	{
		[Token(Token = "0x4007BD4")]
		[FieldOffset(Offset = "0x10")]
		public readonly Joystick joystick;

		[Token(Token = "0x4007BD5")]
		[FieldOffset(Offset = "0x18")]
		public readonly int oldJoystickId;

		[Token(Token = "0x6006178")]
		[Address(RVA = "0xFA7030", Offset = "0xFA5E30", Length = "0xAC")]
		public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
		{
		}
	}

	[Token(Token = "0x2000C14")]
	protected interface IDataStore
	{
		[Token(Token = "0x6006179")]
		bool Save();

		[Token(Token = "0x600617A")]
		bool Load();

		[Token(Token = "0x600617B")]
		bool Clear();

		[Token(Token = "0x600617C")]
		bool TryGetValue(string key, out object result);

		[Token(Token = "0x600617D")]
		bool SetValue(string key, object value);
	}

	[Serializable]
	[Token(Token = "0x2000C15")]
	protected class ControllerElementByRoleMap
	{
		[Serializable]
		[Token(Token = "0x2000C16")]
		public struct Entry
		{
			[Token(Token = "0x4007BD8")]
			[FieldOffset(Offset = "0x0")]
			public int actionId;

			[Token(Token = "0x4007BD9")]
			[FieldOffset(Offset = "0x4")]
			public ControllerElementType elementType;

			[Token(Token = "0x4007BDA")]
			[FieldOffset(Offset = "0x8")]
			public AxisRange axisRange;

			[Token(Token = "0x4007BDB")]
			[FieldOffset(Offset = "0xC")]
			public bool invert;

			[Token(Token = "0x4007BDC")]
			[FieldOffset(Offset = "0x10")]
			public Pole axisContribution;

			[Token(Token = "0x6006183")]
			[Address(RVA = "0xFA75C0", Offset = "0xFA63C0", Length = "0x236")]
			public bool TryGetElementAssignment(ControllerType controllerType, Controller.Element targetElement, out ElementAssignment assignment)
			{
				assignment = default(ElementAssignment);
				return false;
			}

			[Token(Token = "0x6006184")]
			[Address(RVA = "0xFA7800", Offset = "0xFA6600", Length = "0x23E")]
			public override string ToString()
			{
				return null;
			}
		}

		[DoNotSerialize]
		[Token(Token = "0x4007BD6")]
		[FieldOffset(Offset = "0x10")]
		public string role;

		[Token(Token = "0x4007BD7")]
		[FieldOffset(Offset = "0x18")]
		public List<Entry> data;

		[Preserve]
		[Token(Token = "0x600617E")]
		[Address(RVA = "0xFA70E0", Offset = "0xFA5EE0", Length = "0xAD")]
		public ControllerElementByRoleMap()
		{
		}

		[Token(Token = "0x600617F")]
		[Address(RVA = "0xFA7190", Offset = "0xFA5F90", Length = "0xF5")]
		public void Add(ActionElementMap elementMap)
		{
		}

		[Token(Token = "0x6006180")]
		[Address(RVA = "0xFA7290", Offset = "0xFA6090", Length = "0x257")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6006181")]
		[Address(RVA = "0xFA74F0", Offset = "0xFA62F0", Length = "0x7")]
		public string ToJson()
		{
			return null;
		}

		[Token(Token = "0x6006182")]
		[Address(RVA = "0xFA7500", Offset = "0xFA6300", Length = "0xBF")]
		public static ControllerElementByRoleMap FromJson(string role, string json)
		{
			return null;
		}
	}

	[Token(Token = "0x2000C17")]
	public enum ActionMappingSaveMode
	{
		[Token(Token = "0x4007BDE")]
		ByController,
		[Token(Token = "0x4007BDF")]
		ByControllerElementRole
	}

	[CompilerGenerated]
	[Token(Token = "0x2000C1B")]
	private sealed class _003CLoadJoystickAssignmentsDeferred_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4007BE3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4007BE4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4007BE5")]
		[FieldOffset(Offset = "0x20")]
		public UserDataStore_KeyValue _003C_003E4__this;

		[Token(Token = "0x17000645")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600618E")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000646")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006190")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x600618B")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CLoadJoystickAssignmentsDeferred_003Ed__81(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x600618C")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600618D")]
		[Address(RVA = "0xFA7A90", Offset = "0xFA6890", Length = "0x121")]
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
		[Token(Token = "0x600618F")]
		[Address(RVA = "0xFA7BC0", Offset = "0xFA69C0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4007BB9")]
	private static readonly string thisScriptName;

	[Token(Token = "0x4007BBA")]
	private const string logPrefix = "Rewired: ";

	[Token(Token = "0x4007BBB")]
	private const string key_controllerAssignments = "ControllerAssignments";

	[Token(Token = "0x4007BBC")]
	private const int controllerMapKeyVersion = 0;

	[Token(Token = "0x4007BBD")]
	private const int controllerElementByRoleMapKeyVersion = 0;

	[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
	[SerializeField]
	[Token(Token = "0x4007BBE")]
	[FieldOffset(Offset = "0x20")]
	private bool _isEnabled;

	[Tooltip("Should saved data be loaded on start?")]
	[SerializeField]
	[Token(Token = "0x4007BBF")]
	[FieldOffset(Offset = "0x21")]
	private bool _loadDataOnStart;

	[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
	[SerializeField]
	[Token(Token = "0x4007BC0")]
	[FieldOffset(Offset = "0x22")]
	private bool _loadJoystickAssignments;

	[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
	[SerializeField]
	[Token(Token = "0x4007BC1")]
	[FieldOffset(Offset = "0x23")]
	private bool _loadKeyboardAssignments;

	[Tooltip("Should Player Mouse assignments be saved and loaded?")]
	[SerializeField]
	[Token(Token = "0x4007BC2")]
	[FieldOffset(Offset = "0x24")]
	private bool _loadMouseAssignments;

	[Tooltip("How should Action mapping data be saved?\n\nBy Controller: Data is stored per-controller. Action mappings apply only to the specific controller for which it was saved.\n\nBy Controller Element Role: Data is stored per-element on the controller if the controller element has a known role. Action mappings are mirrored on controller elements with the same role on all other controllers for the Player. Example: When saving Action mappings for a gamepad, element on all gamepads that have the same roles will inherit the mappings. This allows you to remap once for all compatible gamepads simultaneously, for example. This can extend beyond just gamepads, however. For example: On a console platform, a racing wheel with A, B, X, Y, D-Pad etc. elements will also reflect the same Action mappings if the gamepad is remapped. Action mappings for any controller elements that do not have known roles will be saved per-controller. Warning: Do not use this mode if you need to allow a Player to save different mappings for multiple controllers of the same type such as gamepads. (This option currently works best for gamepads and only miminally for other controller types.)")]
	[SerializeField]
	[Token(Token = "0x4007BC3")]
	[FieldOffset(Offset = "0x28")]
	private ActionMappingSaveMode _actionMappingSaveMode;

	[NonSerialized]
	[Token(Token = "0x4007BC4")]
	[FieldOffset(Offset = "0x2C")]
	private bool _allowImpreciseJoystickAssignmentMatching;

	[NonSerialized]
	[Token(Token = "0x4007BC5")]
	[FieldOffset(Offset = "0x2D")]
	private bool _deferredJoystickAssignmentLoadPending;

	[NonSerialized]
	[Token(Token = "0x4007BC6")]
	[FieldOffset(Offset = "0x2E")]
	private bool _wasJoystickEverDetected;

	[NonSerialized]
	[Token(Token = "0x4007BC7")]
	[FieldOffset(Offset = "0x30")]
	private List<int> __allActionIds;

	[NonSerialized]
	[Token(Token = "0x4007BC8")]
	[FieldOffset(Offset = "0x38")]
	private string __allActionIdsString;

	[NonSerialized]
	[Token(Token = "0x4007BC9")]
	[FieldOffset(Offset = "0x40")]
	private readonly StringBuilder _sb;

	[NonSerialized]
	[Token(Token = "0x4007BCA")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<string, ControllerElementByRoleMap> _tempElementByRoleMaps;

	[NonSerialized]
	[Token(Token = "0x4007BCB")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<string, bool> _tempElementByRoleMapsEnabled;

	[Token(Token = "0x17000639")]
	public bool isEnabled
	{
		[Token(Token = "0x6006111")]
		[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006112")]
		[Address(RVA = "0x4D3E50", Offset = "0x4D2C50", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700063A")]
	public bool loadDataOnStart
	{
		[Token(Token = "0x6006113")]
		[Address(RVA = "0x5327B0", Offset = "0x5315B0", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006114")]
		[Address(RVA = "0x5D13B0", Offset = "0x5D01B0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700063B")]
	public bool loadJoystickAssignments
	{
		[Token(Token = "0x6006115")]
		[Address(RVA = "0xF7E710", Offset = "0xF7D510", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006116")]
		[Address(RVA = "0xF7E720", Offset = "0xF7D520", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700063C")]
	public bool loadKeyboardAssignments
	{
		[Token(Token = "0x6006117")]
		[Address(RVA = "0xF7E730", Offset = "0xF7D530", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006118")]
		[Address(RVA = "0xF7E740", Offset = "0xF7D540", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700063D")]
	public bool loadMouseAssignments
	{
		[Token(Token = "0x6006119")]
		[Address(RVA = "0x621E50", Offset = "0x620C50", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x600611A")]
		[Address(RVA = "0x61D6C0", Offset = "0x61C4C0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700063E")]
	public ActionMappingSaveMode actionMappingSaveMode
	{
		[Token(Token = "0x600611B")]
		[Address(RVA = "0x4588A0", Offset = "0x4576A0", Length = "0x4")]
		get
		{
			return default(ActionMappingSaveMode);
		}
		[Token(Token = "0x600611C")]
		[Address(RVA = "0x92FF10", Offset = "0x92ED10", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700063F")]
	protected abstract IDataStore dataStore
	{
		[Token(Token = "0x600611D")]
		get;
	}

	[Token(Token = "0x17000640")]
	private bool loadControllerAssignments
	{
		[Token(Token = "0x600611E")]
		[Address(RVA = "0xF7E750", Offset = "0xF7D550", Length = "0x14")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000641")]
	private List<int> allActionIds
	{
		[Token(Token = "0x600611F")]
		[Address(RVA = "0xF7E770", Offset = "0xF7D570", Length = "0x2FB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000642")]
	private string allActionIdsString
	{
		[Token(Token = "0x6006120")]
		[Address(RVA = "0xF7EA70", Offset = "0xF7D870", Length = "0x18F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006121")]
	[Address(RVA = "0xF7EC00", Offset = "0xF7DA00", Length = "0xE6")]
	public override void Save()
	{
	}

	[Token(Token = "0x6006122")]
	[Address(RVA = "0xF7ECF0", Offset = "0xF7DAF0", Length = "0x126")]
	public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x6006123")]
	[Address(RVA = "0xF7EE20", Offset = "0xF7DC20", Length = "0x10B")]
	public override void SaveControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x6006124")]
	[Address(RVA = "0xF7EF30", Offset = "0xF7DD30", Length = "0x19F")]
	public override void SavePlayerData(int playerId)
	{
	}

	[Token(Token = "0x6006125")]
	[Address(RVA = "0xF7F0D0", Offset = "0xF7DED0", Length = "0x25C")]
	public override void SaveInputBehavior(int playerId, int behaviorId)
	{
	}

	[Token(Token = "0x6006126")]
	[Address(RVA = "0xF7F330", Offset = "0xF7E130", Length = "0xE6")]
	public override void Load()
	{
	}

	[Token(Token = "0x6006127")]
	[Address(RVA = "0xF7F420", Offset = "0xF7E220", Length = "0x12D")]
	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x6006128")]
	[Address(RVA = "0xF7F550", Offset = "0xF7E350", Length = "0x10B")]
	public override void LoadControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x6006129")]
	[Address(RVA = "0xF7F660", Offset = "0xF7E460", Length = "0x148")]
	public override void LoadPlayerData(int playerId)
	{
	}

	[Token(Token = "0x600612A")]
	[Address(RVA = "0xF7F7B0", Offset = "0xF7E5B0", Length = "0x1A5")]
	public override void LoadInputBehavior(int playerId, int behaviorId)
	{
	}

	[Token(Token = "0x600612B")]
	[Address(RVA = "0xF7F960", Offset = "0xF7E760", Length = "0xA2")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x600612C")]
	[Address(RVA = "0xF7FA10", Offset = "0xF7E810", Length = "0x104")]
	protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x600612D")]
	[Address(RVA = "0xF7FB20", Offset = "0xF7E920", Length = "0x2E")]
	protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x600612E")]
	[Address(RVA = "0xF7FB50", Offset = "0xF7E950", Length = "0x20")]
	protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x600612F")]
	[Address(RVA = "0xF7FB70", Offset = "0xF7E970", Length = "0xD3")]
	public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
	{
	}

	[Token(Token = "0x6006130")]
	[Address(RVA = "0xF7FC50", Offset = "0xF7EA50", Length = "0xD3")]
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Token(Token = "0x6006131")]
	[Address(RVA = "0xF7FD30", Offset = "0xF7EB30", Length = "0x63")]
	public virtual void ClearSaveData()
	{
	}

	[Token(Token = "0x6006132")]
	[Address(RVA = "0xF7FDA0", Offset = "0xF7EBA0", Length = "0x20E")]
	private int LoadAll()
	{
		return 0;
	}

	[Token(Token = "0x6006133")]
	[Address(RVA = "0xF7FFB0", Offset = "0xF7EDB0", Length = "0x7B")]
	private int LoadPlayerDataNow(int playerId)
	{
		return 0;
	}

	[Token(Token = "0x6006134")]
	[Address(RVA = "0xF80030", Offset = "0xF7EE30", Length = "0x2BB")]
	private int LoadPlayerDataNow(Player player)
	{
		return 0;
	}

	[Token(Token = "0x6006135")]
	[Address(RVA = "0xF802F0", Offset = "0xF7F0F0", Length = "0x1E5")]
	private int LoadAllJoystickCalibrationData()
	{
		return 0;
	}

	[Token(Token = "0x6006136")]
	[Address(RVA = "0xF804E0", Offset = "0xF7F2E0", Length = "0x14E")]
	private int LoadJoystickCalibrationData(Joystick joystick)
	{
		return 0;
	}

	[Token(Token = "0x6006137")]
	[Address(RVA = "0xF80630", Offset = "0xF7F430", Length = "0x7B")]
	private int LoadJoystickCalibrationData(int joystickId)
	{
		return 0;
	}

	[Token(Token = "0x6006138")]
	[Address(RVA = "0xF806B0", Offset = "0xF7F4B0", Length = "0x35B")]
	private int LoadJoystickData(int joystickId)
	{
		return 0;
	}

	[Token(Token = "0x6006139")]
	[Address(RVA = "0xF80A10", Offset = "0xF7F810", Length = "0x73")]
	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
		return 0;
	}

	[Token(Token = "0x600613A")]
	[Address(RVA = "0xF80A90", Offset = "0xF7F890", Length = "0x15")]
	private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
	{
		return 0;
	}

	[Token(Token = "0x600613B")]
	[Address(RVA = "0xF80AB0", Offset = "0xF7F8B0", Length = "0xD26")]
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		return 0;
	}

	[Token(Token = "0x600613C")]
	[Address(RVA = "0xF817E0", Offset = "0xF805E0", Length = "0x1D7")]
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Token(Token = "0x600613D")]
	[Address(RVA = "0xF819C0", Offset = "0xF807C0", Length = "0x2C1")]
	private bool LoadControllerElementMapByRole(Player player, Controller controller, string role, int mapCategoryId, int layoutId, Dictionary<string, ControllerElementByRoleMap> elementByRoleMaps)
	{
		return false;
	}

	[Token(Token = "0x600613E")]
	[Address(RVA = "0xF81C90", Offset = "0xF80A90", Length = "0x23F")]
	private int LoadInputBehaviors(int playerId)
	{
		return 0;
	}

	[Token(Token = "0x600613F")]
	[Address(RVA = "0xF81ED0", Offset = "0xF80CD0", Length = "0xD8")]
	private int LoadInputBehaviorNow(int playerId, int behaviorId)
	{
		return 0;
	}

	[Token(Token = "0x6006140")]
	[Address(RVA = "0xF81FB0", Offset = "0xF80DB0", Length = "0x139")]
	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
		return 0;
	}

	[Token(Token = "0x6006141")]
	[Address(RVA = "0xF820F0", Offset = "0xF80EF0", Length = "0x67")]
	private bool LoadControllerAssignmentsNow()
	{
		return false;
	}

	[Token(Token = "0x6006142")]
	[Address(RVA = "0xF82160", Offset = "0xF80F60", Length = "0x37E")]
	private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return false;
	}

	[Token(Token = "0x6006143")]
	[Address(RVA = "0xF824E0", Offset = "0xF812E0", Length = "0xF88")]
	private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return false;
	}

	[Token(Token = "0x6006144")]
	[Address(RVA = "0xF83470", Offset = "0xF82270", Length = "0x10D")]
	private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__81))]
	[Token(Token = "0x6006145")]
	[Address(RVA = "0xF83580", Offset = "0xF82380", Length = "0x9A")]
	private IEnumerator LoadJoystickAssignmentsDeferred()
	{
		return null;
	}

	[Token(Token = "0x6006146")]
	[Address(RVA = "0xF83620", Offset = "0xF82420", Length = "0x350")]
	private void SaveAll()
	{
	}

	[Token(Token = "0x6006147")]
	[Address(RVA = "0xF83980", Offset = "0xF82780", Length = "0xCA")]
	private void SavePlayerDataNow(int playerId)
	{
	}

	[Token(Token = "0x6006148")]
	[Address(RVA = "0xF83A50", Offset = "0xF82850", Length = "0x1B4")]
	private void SavePlayerDataNow(Player player)
	{
	}

	[Token(Token = "0x6006149")]
	[Address(RVA = "0xF83C10", Offset = "0xF82A10", Length = "0x276")]
	private void SaveAllJoystickCalibrationData()
	{
	}

	[Token(Token = "0x600614A")]
	[Address(RVA = "0xF83E90", Offset = "0xF82C90", Length = "0x7B")]
	private void SaveJoystickCalibrationData(int joystickId)
	{
	}

	[Token(Token = "0x600614B")]
	[Address(RVA = "0xF83F10", Offset = "0xF82D10", Length = "0xBC")]
	private void SaveJoystickCalibrationData(Joystick joystick)
	{
	}

	[Token(Token = "0x600614C")]
	[Address(RVA = "0xF83FD0", Offset = "0xF82DD0", Length = "0x3D2")]
	private void SaveJoystickData(int joystickId)
	{
	}

	[Token(Token = "0x600614D")]
	[Address(RVA = "0xF843B0", Offset = "0xF831B0", Length = "0x4E")]
	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x600614E")]
	[Address(RVA = "0xF84400", Offset = "0xF83200", Length = "0x13")]
	private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x600614F")]
	[Address(RVA = "0xF84420", Offset = "0xF83220", Length = "0x2A0")]
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
	{
	}

	[Token(Token = "0x6006150")]
	[Address(RVA = "0xF846D0", Offset = "0xF834D0", Length = "0x2A3")]
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Token(Token = "0x6006151")]
	[Address(RVA = "0xF84980", Offset = "0xF83780", Length = "0xB2")]
	private void SaveControllerMap(Player player, ControllerMap controllerMap)
	{
	}

	[Token(Token = "0x6006152")]
	[Address(RVA = "0xF84A40", Offset = "0xF83840", Length = "0x221")]
	private void SaveControllerMapByController(Player player, ControllerMap controllerMap)
	{
	}

	[Token(Token = "0x6006153")]
	[Address(RVA = "0xF84C70", Offset = "0xF83A70", Length = "0x96E")]
	private void SaveControllerMapByControllerElementRole(Player player, Controller controller, ControllerMap controllerMap)
	{
	}

	[Token(Token = "0x6006154")]
	[Address(RVA = "0xF855E0", Offset = "0xF843E0", Length = "0x2A4")]
	private bool AddControllerElementByRoleMapEntry(Player player, Controller controller, ActionElementMap elementMap, ref Dictionary<string, ControllerElementByRoleMap> maps)
	{
		return false;
	}

	[Token(Token = "0x6006155")]
	[Address(RVA = "0xF85890", Offset = "0xF84690", Length = "0x105")]
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
	{
	}

	[Token(Token = "0x6006156")]
	[Address(RVA = "0xF859A0", Offset = "0xF847A0", Length = "0x182")]
	private void SaveInputBehaviorNow(int playerId, int behaviorId)
	{
	}

	[Token(Token = "0x6006157")]
	[Address(RVA = "0xF85B30", Offset = "0xF84930", Length = "0xB0")]
	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
	}

	[Token(Token = "0x6006158")]
	[Address(RVA = "0xF85BF0", Offset = "0xF849F0", Length = "0x503")]
	private bool SaveControllerAssignments()
	{
		return false;
	}

	[Token(Token = "0x6006159")]
	[Address(RVA = "0xF86100", Offset = "0xF84F00", Length = "0x73")]
	private static void AppendPlayerKey(StringBuilder sb, Player player)
	{
	}

	[Token(Token = "0x600615A")]
	[Address(RVA = "0xF86180", Offset = "0xF84F80", Length = "0x191")]
	private string GetControllerMapKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Token(Token = "0x600615B")]
	[Address(RVA = "0xF86320", Offset = "0xF85120", Length = "0x191")]
	private string GetControllerMapKnownActionIdsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Token(Token = "0x600615C")]
	[Address(RVA = "0xF864C0", Offset = "0xF852C0", Length = "0x36A")]
	private static void AppendControllerMapKeyCommonSuffix(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int keyVersion)
	{
	}

	[Token(Token = "0x600615D")]
	[Address(RVA = "0xF86830", Offset = "0xF85630", Length = "0x138")]
	private static void AppendControllerElementByRoleMapKey(StringBuilder sb, string elementRole, int categoryId, int layoutId, int keyVersion)
	{
	}

	[Token(Token = "0x600615E")]
	[Address(RVA = "0xF86970", Offset = "0xF85770", Length = "0x1DA")]
	private string GetJoystickCalibrationMapKey(Joystick joystick)
	{
		return null;
	}

	[Token(Token = "0x600615F")]
	[Address(RVA = "0xF86B50", Offset = "0xF85950", Length = "0x165")]
	private string GetInputBehaviorKey(Player player, int inputBehaviorId)
	{
		return null;
	}

	[Token(Token = "0x6006160")]
	[Address(RVA = "0xF86CC0", Offset = "0xF85AC0", Length = "0x125")]
	private string GetControllerMapJson(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Token(Token = "0x6006161")]
	[Address(RVA = "0xF86DF0", Offset = "0xF85BF0", Length = "0x1F8")]
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Token(Token = "0x6006162")]
	[Address(RVA = "0xF86FF0", Offset = "0xF85DF0", Length = "0x9D")]
	private string GetJoystickCalibrationMapJson(Joystick joystick)
	{
		return null;
	}

	[Token(Token = "0x6006163")]
	[Address(RVA = "0xF87090", Offset = "0xF85E90", Length = "0xAD")]
	private string GetInputBehaviorJson(Player player, int id)
	{
		return null;
	}

	[Token(Token = "0x6006164")]
	[Address(RVA = "0xF87140", Offset = "0xF85F40", Length = "0x69A")]
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
	{
	}

	[Token(Token = "0x6006165")]
	[Address(RVA = "0xF877E0", Offset = "0xF865E0", Length = "0x1D3")]
	private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
	{
		return null;
	}

	[Token(Token = "0x6006166")]
	[Address(RVA = "0xF879C0", Offset = "0xF867C0", Length = "0x39F")]
	private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
	{
		matches = null;
		return false;
	}

	[Token(Token = "0x6006167")]
	[Address(RVA = "0xF87D60", Offset = "0xF86B60", Length = "0x8E")]
	private void RefreshLayoutManager(int playerId)
	{
	}

	[Token(Token = "0x6006168")]
	[Address(RVA = "0xF87DF0", Offset = "0xF86BF0", Length = "0x189")]
	private void OnControllerMapsSaved(Player player)
	{
	}

	[Token(Token = "0x6006169")]
	[Address(RVA = "0xF87F80", Offset = "0xF86D80", Length = "0x407")]
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
	{
		return 0;
	}

	[Token(Token = "0x600616A")]
	[Address(RVA = "0xF88390", Offset = "0xF87190", Length = "0x198")]
	private static bool TryGetString(IDataStore store, string key, out string result)
	{
		result = null;
		return false;
	}

	[Token(Token = "0x600616B")]
	[Address(RVA = "0xF88530", Offset = "0xF87330", Length = "0x166")]
	private static int SortOldestToNewest(ControllerMapSaveData a, ControllerMapSaveData b)
	{
		return 0;
	}

	[Token(Token = "0x600616C")]
	[Address(RVA = "0xF886A0", Offset = "0xF874A0", Length = "0xE2")]
	protected UserDataStore_KeyValue()
	{
	}
}
