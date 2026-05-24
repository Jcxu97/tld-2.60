using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.Switch;

[AddComponentMenu("Rewired/Nintendo Switch Input Manager")]
[RequireComponent(typeof(InputManager))]
[Token(Token = "0x2000C02")]
public sealed class NintendoSwitchInputManager : MonoBehaviour, IExternalInputManager
{
	[Serializable]
	[Token(Token = "0x2000C03")]
	private class UserData : IKeyedData<int>
	{
		[SerializeField]
		[Token(Token = "0x4007B89")]
		[FieldOffset(Offset = "0x10")]
		private int _allowedNpadStyles;

		[SerializeField]
		[Token(Token = "0x4007B8A")]
		[FieldOffset(Offset = "0x14")]
		private int _joyConGripStyle;

		[SerializeField]
		[Token(Token = "0x4007B8B")]
		[FieldOffset(Offset = "0x18")]
		private bool _adjustIMUsForGripStyle;

		[SerializeField]
		[Token(Token = "0x4007B8C")]
		[FieldOffset(Offset = "0x1C")]
		private int _handheldActivationMode;

		[SerializeField]
		[Token(Token = "0x4007B8D")]
		[FieldOffset(Offset = "0x20")]
		private bool _assignJoysticksByNpadId;

		[SerializeField]
		[Token(Token = "0x4007B8E")]
		[FieldOffset(Offset = "0x21")]
		private bool _useVibrationThread;

		[SerializeField]
		[Token(Token = "0x4007B8F")]
		[FieldOffset(Offset = "0x28")]
		private NpadSettings_Internal _npadNo1;

		[SerializeField]
		[Token(Token = "0x4007B90")]
		[FieldOffset(Offset = "0x30")]
		private NpadSettings_Internal _npadNo2;

		[SerializeField]
		[Token(Token = "0x4007B91")]
		[FieldOffset(Offset = "0x38")]
		private NpadSettings_Internal _npadNo3;

		[SerializeField]
		[Token(Token = "0x4007B92")]
		[FieldOffset(Offset = "0x40")]
		private NpadSettings_Internal _npadNo4;

		[SerializeField]
		[Token(Token = "0x4007B93")]
		[FieldOffset(Offset = "0x48")]
		private NpadSettings_Internal _npadNo5;

		[SerializeField]
		[Token(Token = "0x4007B94")]
		[FieldOffset(Offset = "0x50")]
		private NpadSettings_Internal _npadNo6;

		[SerializeField]
		[Token(Token = "0x4007B95")]
		[FieldOffset(Offset = "0x58")]
		private NpadSettings_Internal _npadNo7;

		[SerializeField]
		[Token(Token = "0x4007B96")]
		[FieldOffset(Offset = "0x60")]
		private NpadSettings_Internal _npadNo8;

		[SerializeField]
		[Token(Token = "0x4007B97")]
		[FieldOffset(Offset = "0x68")]
		private NpadSettings_Internal _npadHandheld;

		[SerializeField]
		[Token(Token = "0x4007B98")]
		[FieldOffset(Offset = "0x70")]
		private DebugPadSettings_Internal _debugPad;

		[Token(Token = "0x4007B99")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<int, object[]> __delegates;

		[Token(Token = "0x17000619")]
		public int allowedNpadStyles
		{
			[Token(Token = "0x6006080")]
			[Address(RVA = "0x40E0A0", Offset = "0x40CEA0", Length = "0x4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006081")]
			[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x1700061A")]
		public int joyConGripStyle
		{
			[Token(Token = "0x6006082")]
			[Address(RVA = "0x40E0B0", Offset = "0x40CEB0", Length = "0x4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006083")]
			[Address(RVA = "0x40E0C0", Offset = "0x40CEC0", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x1700061B")]
		public bool adjustIMUsForGripStyle
		{
			[Token(Token = "0x6006084")]
			[Address(RVA = "0xC880B0", Offset = "0xC86EB0", Length = "0x5")]
			get
			{
				return false;
			}
			[Token(Token = "0x6006085")]
			[Address(RVA = "0xF79F70", Offset = "0xF78D70", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x1700061C")]
		public int handheldActivationMode
		{
			[Token(Token = "0x6006086")]
			[Address(RVA = "0x40E0F0", Offset = "0x40CEF0", Length = "0x4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006087")]
			[Address(RVA = "0x40E100", Offset = "0x40CF00", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x1700061D")]
		public bool assignJoysticksByNpadId
		{
			[Token(Token = "0x6006088")]
			[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
			get
			{
				return false;
			}
			[Token(Token = "0x6006089")]
			[Address(RVA = "0x4D3E50", Offset = "0x4D2C50", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x1700061E")]
		public bool useVibrationThread
		{
			[Token(Token = "0x600608A")]
			[Address(RVA = "0x5327B0", Offset = "0x5315B0", Length = "0x5")]
			get
			{
				return false;
			}
			[Token(Token = "0x600608B")]
			[Address(RVA = "0x5D13B0", Offset = "0x5D01B0", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x1700061F")]
		private NpadSettings_Internal npadNo1
		{
			[Token(Token = "0x600608C")]
			[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000620")]
		private NpadSettings_Internal npadNo2
		{
			[Token(Token = "0x600608D")]
			[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000621")]
		private NpadSettings_Internal npadNo3
		{
			[Token(Token = "0x600608E")]
			[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000622")]
		private NpadSettings_Internal npadNo4
		{
			[Token(Token = "0x600608F")]
			[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000623")]
		private NpadSettings_Internal npadNo5
		{
			[Token(Token = "0x6006090")]
			[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000624")]
		private NpadSettings_Internal npadNo6
		{
			[Token(Token = "0x6006091")]
			[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000625")]
		private NpadSettings_Internal npadNo7
		{
			[Token(Token = "0x6006092")]
			[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000626")]
		private NpadSettings_Internal npadNo8
		{
			[Token(Token = "0x6006093")]
			[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000627")]
		private NpadSettings_Internal npadHandheld
		{
			[Token(Token = "0x6006094")]
			[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000628")]
		public DebugPadSettings_Internal debugPad
		{
			[Token(Token = "0x6006095")]
			[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000629")]
		private Dictionary<int, object[]> delegates
		{
			[Token(Token = "0x6006096")]
			[Address(RVA = "0xF79F80", Offset = "0xF78D80", Length = "0xFC3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006097")]
		[Address(RVA = "0x1A6A740", Offset = "0x1A69540", Length = "0x1B4")]
		bool IKeyedData<int>.TryGetValue<T>(int key, out T value)
		{
			value = default(T);
			return false;
		}

		[Token(Token = "0x6006098")]
		[Address(RVA = "0x1A6A900", Offset = "0x1A69700", Length = "0x180")]
		bool IKeyedData<int>.TrySetValue<T>(int key, T value)
		{
			return false;
		}

		[Token(Token = "0x6006099")]
		[Address(RVA = "0xF7AF50", Offset = "0xF79D50", Length = "0x4B4")]
		public UserData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000C04")]
	private sealed class NpadSettings_Internal : IKeyedData<int>
	{
		[Tooltip("Determines whether this Npad id is allowed to be used by the system.")]
		[SerializeField]
		[Token(Token = "0x4007B9A")]
		[FieldOffset(Offset = "0x10")]
		private bool _isAllowed;

		[Tooltip("The Rewired Player Id assigned to this Npad id.")]
		[SerializeField]
		[Token(Token = "0x4007B9B")]
		[FieldOffset(Offset = "0x14")]
		private int _rewiredPlayerId;

		[Tooltip("Determines how Joy-Cons should be handled.\n\nUnmodified: Joy-Con assignment mode will be left at the system default.\nDual: Joy-Cons pairs are handled as a single controller.\nSingle: Joy-Cons are handled as individual controllers.")]
		[SerializeField]
		[Token(Token = "0x4007B9C")]
		[FieldOffset(Offset = "0x18")]
		private int _joyConAssignmentMode;

		[Token(Token = "0x4007B9D")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, object[]> __delegates;

		[Token(Token = "0x1700062A")]
		private bool isAllowed
		{
			[Token(Token = "0x60060B0")]
			[Address(RVA = "0x504260", Offset = "0x503060", Length = "0x5")]
			get
			{
				return false;
			}
			[Token(Token = "0x60060B1")]
			[Address(RVA = "0x4B7B30", Offset = "0x4B6930", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x1700062B")]
		private int rewiredPlayerId
		{
			[Token(Token = "0x60060B2")]
			[Address(RVA = "0x40E0B0", Offset = "0x40CEB0", Length = "0x4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60060B3")]
			[Address(RVA = "0x40E0C0", Offset = "0x40CEC0", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x1700062C")]
		private int joyConAssignmentMode
		{
			[Token(Token = "0x60060B4")]
			[Address(RVA = "0x40E0D0", Offset = "0x40CED0", Length = "0x4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60060B5")]
			[Address(RVA = "0x40E0E0", Offset = "0x40CEE0", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x1700062D")]
		private Dictionary<int, object[]> delegates
		{
			[Token(Token = "0x60060B7")]
			[Address(RVA = "0xF7B420", Offset = "0xF7A220", Length = "0x4D3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60060B6")]
		[Address(RVA = "0xF7B410", Offset = "0xF7A210", Length = "0xF")]
		internal NpadSettings_Internal(int playerId)
		{
		}

		[Token(Token = "0x60060B8")]
		[Address(RVA = "0x1A6A3F0", Offset = "0x1A691F0", Length = "0x1B4")]
		bool IKeyedData<int>.TryGetValue<T>(int key, out T value)
		{
			value = default(T);
			return false;
		}

		[Token(Token = "0x60060B9")]
		[Address(RVA = "0x1A6A5B0", Offset = "0x1A693B0", Length = "0x180")]
		bool IKeyedData<int>.TrySetValue<T>(int key, T value)
		{
			return false;
		}
	}

	[Serializable]
	[Token(Token = "0x2000C05")]
	private sealed class DebugPadSettings_Internal : IKeyedData<int>
	{
		[Tooltip("Determines whether the Debug Pad will be enabled.")]
		[SerializeField]
		[Token(Token = "0x4007B9E")]
		[FieldOffset(Offset = "0x10")]
		private bool _enabled;

		[Tooltip("The Rewired Player Id to which the Debug Pad will be assigned.")]
		[SerializeField]
		[Token(Token = "0x4007B9F")]
		[FieldOffset(Offset = "0x14")]
		private int _rewiredPlayerId;

		[Token(Token = "0x4007BA0")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, object[]> __delegates;

		[Token(Token = "0x1700062E")]
		private int rewiredPlayerId
		{
			[Token(Token = "0x60060C0")]
			[Address(RVA = "0x40E0B0", Offset = "0x40CEB0", Length = "0x4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60060C1")]
			[Address(RVA = "0x40E0C0", Offset = "0x40CEC0", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x1700062F")]
		private bool enabled
		{
			[Token(Token = "0x60060C2")]
			[Address(RVA = "0x504260", Offset = "0x503060", Length = "0x5")]
			get
			{
				return false;
			}
			[Token(Token = "0x60060C3")]
			[Address(RVA = "0x4B7B30", Offset = "0x4B6930", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x17000630")]
		private Dictionary<int, object[]> delegates
		{
			[Token(Token = "0x60060C5")]
			[Address(RVA = "0xF7B900", Offset = "0xF7A700", Length = "0x3A3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60060C4")]
		[Address(RVA = "0x40E0C0", Offset = "0x40CEC0", Length = "0x4")]
		internal DebugPadSettings_Internal(int playerId)
		{
		}

		[Token(Token = "0x60060C6")]
		[Address(RVA = "0x1A6A0A0", Offset = "0x1A68EA0", Length = "0x1B4")]
		bool IKeyedData<int>.TryGetValue<T>(int key, out T value)
		{
			value = default(T);
			return false;
		}

		[Token(Token = "0x60060C7")]
		[Address(RVA = "0x1A6A260", Offset = "0x1A69060", Length = "0x180")]
		bool IKeyedData<int>.TrySetValue<T>(int key, T value)
		{
			return false;
		}
	}

	[SerializeField]
	[Token(Token = "0x4007B88")]
	[FieldOffset(Offset = "0x20")]
	private UserData _userData;

	[Token(Token = "0x600607D")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	object IExternalInputManager.Initialize(Platform platform, object configVars)
	{
		return null;
	}

	[Token(Token = "0x600607E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	void IExternalInputManager.Deinitialize()
	{
	}

	[Token(Token = "0x600607F")]
	[Address(RVA = "0xF79E90", Offset = "0xF78C90", Length = "0xD2")]
	public NintendoSwitchInputManager()
	{
	}
}
