using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C35")]
public class ControlRemappingDemo1 : MonoBehaviour
{
	[Token(Token = "0x2000C36")]
	private class ControllerSelection
	{
		[Token(Token = "0x4007C78")]
		[FieldOffset(Offset = "0x10")]
		private int _id;

		[Token(Token = "0x4007C79")]
		[FieldOffset(Offset = "0x14")]
		private int _idPrev;

		[Token(Token = "0x4007C7A")]
		[FieldOffset(Offset = "0x18")]
		private ControllerType _type;

		[Token(Token = "0x4007C7B")]
		[FieldOffset(Offset = "0x1C")]
		private ControllerType _typePrev;

		[Token(Token = "0x1700068F")]
		public int id
		{
			[Token(Token = "0x6006316")]
			[Address(RVA = "0x40E0A0", Offset = "0x40CEA0", Length = "0x4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006317")]
			[Address(RVA = "0xFCB7D0", Offset = "0xFCA5D0", Length = "0xA")]
			set
			{
			}
		}

		[Token(Token = "0x17000690")]
		public ControllerType type
		{
			[Token(Token = "0x6006318")]
			[Address(RVA = "0x40E0D0", Offset = "0x40CED0", Length = "0x4")]
			get
			{
				return default(ControllerType);
			}
			[Token(Token = "0x6006319")]
			[Address(RVA = "0xFCB7E0", Offset = "0xFCA5E0", Length = "0xA")]
			set
			{
			}
		}

		[Token(Token = "0x17000691")]
		public int idPrev
		{
			[Token(Token = "0x600631A")]
			[Address(RVA = "0x40E0B0", Offset = "0x40CEB0", Length = "0x4")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x17000692")]
		public ControllerType typePrev
		{
			[Token(Token = "0x600631B")]
			[Address(RVA = "0x40E0F0", Offset = "0x40CEF0", Length = "0x4")]
			get
			{
				return default(ControllerType);
			}
		}

		[Token(Token = "0x17000693")]
		public bool hasSelection
		{
			[Token(Token = "0x600631C")]
			[Address(RVA = "0xFCB7F0", Offset = "0xFCA5F0", Length = "0x9")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x6006315")]
		[Address(RVA = "0xFCB7B0", Offset = "0xFCA5B0", Length = "0x17")]
		public ControllerSelection()
		{
		}

		[Token(Token = "0x600631D")]
		[Address(RVA = "0xFCB800", Offset = "0xFCA600", Length = "0x14")]
		public void Set(int id, ControllerType type)
		{
		}

		[Token(Token = "0x600631E")]
		[Address(RVA = "0xFCB7B0", Offset = "0xFCA5B0", Length = "0x17")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x2000C37")]
	private class DialogHelper
	{
		[Token(Token = "0x2000C38")]
		public enum DialogType
		{
			[Token(Token = "0x4007C88")]
			None = 0,
			[Token(Token = "0x4007C89")]
			JoystickConflict = 1,
			[Token(Token = "0x4007C8A")]
			ElementConflict = 2,
			[Token(Token = "0x4007C8B")]
			KeyConflict = 3,
			[Token(Token = "0x4007C8C")]
			DeleteAssignmentConfirmation = 10,
			[Token(Token = "0x4007C8D")]
			AssignElement = 11
		}

		[Token(Token = "0x4007C7C")]
		private const float openBusyDelay = 0.25f;

		[Token(Token = "0x4007C7D")]
		private const float closeBusyDelay = 0.1f;

		[Token(Token = "0x4007C7E")]
		[FieldOffset(Offset = "0x10")]
		private DialogType _type;

		[Token(Token = "0x4007C7F")]
		[FieldOffset(Offset = "0x14")]
		private bool _enabled;

		[Token(Token = "0x4007C80")]
		[FieldOffset(Offset = "0x18")]
		private float _busyTime;

		[Token(Token = "0x4007C81")]
		[FieldOffset(Offset = "0x1C")]
		private bool _busyTimerRunning;

		[Token(Token = "0x4007C82")]
		[FieldOffset(Offset = "0x20")]
		private Action<int> drawWindowDelegate;

		[Token(Token = "0x4007C83")]
		[FieldOffset(Offset = "0x28")]
		private GUI.WindowFunction drawWindowFunction;

		[Token(Token = "0x4007C84")]
		[FieldOffset(Offset = "0x30")]
		private WindowProperties windowProperties;

		[Token(Token = "0x4007C85")]
		[FieldOffset(Offset = "0x60")]
		private int currentActionId;

		[Token(Token = "0x4007C86")]
		[FieldOffset(Offset = "0x68")]
		private Action<int, UserResponse> resultCallback;

		[Token(Token = "0x17000694")]
		private float busyTimer
		{
			[Token(Token = "0x600631F")]
			[Address(RVA = "0xFCB820", Offset = "0xFCA620", Length = "0x69")]
			get
			{
				return 0f;
			}
		}

		[Token(Token = "0x17000695")]
		public bool enabled
		{
			[Token(Token = "0x6006320")]
			[Address(RVA = "0x4D1070", Offset = "0x4CFE70", Length = "0x5")]
			get
			{
				return false;
			}
			[Token(Token = "0x6006321")]
			[Address(RVA = "0xFCB890", Offset = "0xFCA690", Length = "0x8B")]
			set
			{
			}
		}

		[Token(Token = "0x17000696")]
		public DialogType type
		{
			[Token(Token = "0x6006322")]
			[Address(RVA = "0xFCB920", Offset = "0xFCA720", Length = "0xD")]
			get
			{
				return default(DialogType);
			}
			[Token(Token = "0x6006323")]
			[Address(RVA = "0xFCB930", Offset = "0xFCA730", Length = "0xB6")]
			set
			{
			}
		}

		[Token(Token = "0x17000697")]
		public bool busy
		{
			[Token(Token = "0x6006324")]
			[Address(RVA = "0x5092F0", Offset = "0x5080F0", Length = "0x5")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x6006325")]
		[Address(RVA = "0xFCB9F0", Offset = "0xFCA7F0", Length = "0x17E")]
		public DialogHelper()
		{
		}

		[Token(Token = "0x6006326")]
		[Address(RVA = "0xFCBB70", Offset = "0xFCA970", Length = "0x54")]
		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback)
		{
		}

		[Token(Token = "0x6006327")]
		[Address(RVA = "0xFCBBD0", Offset = "0xFCA9D0", Length = "0x1B1")]
		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback, float openBusyDelay)
		{
		}

		[Token(Token = "0x6006328")]
		[Address(RVA = "0xFCBD90", Offset = "0xFCAB90", Length = "0x77")]
		public void Update()
		{
		}

		[Token(Token = "0x6006329")]
		[Address(RVA = "0xFCBE10", Offset = "0xFCAC10", Length = "0x25B")]
		public void Draw()
		{
		}

		[Token(Token = "0x600632A")]
		[Address(RVA = "0xFCC070", Offset = "0xFCAE70", Length = "0x41")]
		public void DrawConfirmButton()
		{
		}

		[Token(Token = "0x600632B")]
		[Address(RVA = "0xFCC0C0", Offset = "0xFCAEC0", Length = "0x20A")]
		public void DrawConfirmButton(string title)
		{
		}

		[Token(Token = "0x600632C")]
		[Address(RVA = "0xFCC2D0", Offset = "0xFCB0D0", Length = "0x4E")]
		public void DrawConfirmButton(UserResponse response)
		{
		}

		[Token(Token = "0x600632D")]
		[Address(RVA = "0xFCC320", Offset = "0xFCB120", Length = "0x216")]
		public void DrawConfirmButton(UserResponse response, string title)
		{
		}

		[Token(Token = "0x600632E")]
		[Address(RVA = "0xFCC540", Offset = "0xFCB340", Length = "0x41")]
		public void DrawCancelButton()
		{
		}

		[Token(Token = "0x600632F")]
		[Address(RVA = "0xFCC590", Offset = "0xFCB390", Length = "0x20D")]
		public void DrawCancelButton(string title)
		{
		}

		[Token(Token = "0x6006330")]
		[Address(RVA = "0xFCC7A0", Offset = "0xFCB5A0", Length = "0x37")]
		public void Confirm()
		{
		}

		[Token(Token = "0x6006331")]
		[Address(RVA = "0xFCC7E0", Offset = "0xFCB5E0", Length = "0x37")]
		public void Confirm(UserResponse response)
		{
		}

		[Token(Token = "0x6006332")]
		[Address(RVA = "0xFCC820", Offset = "0xFCB620", Length = "0x3A")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6006333")]
		[Address(RVA = "0xFCC860", Offset = "0xFCB660", Length = "0x2A")]
		private void DrawWindow(int windowId)
		{
		}

		[Token(Token = "0x6006334")]
		[Address(RVA = "0xFCC890", Offset = "0xFCB690", Length = "0x70")]
		private void UpdateTimers()
		{
		}

		[Token(Token = "0x6006335")]
		[Address(RVA = "0xFCC910", Offset = "0xFCB710", Length = "0x65")]
		private void StartBusyTimer(float time)
		{
		}

		[Token(Token = "0x6006336")]
		[Address(RVA = "0xFCC980", Offset = "0xFCB780", Length = "0xB6")]
		private void Close()
		{
		}

		[Token(Token = "0x6006337")]
		[Address(RVA = "0xFCC910", Offset = "0xFCB710", Length = "0x65")]
		private void StateChanged(float delay)
		{
		}

		[Token(Token = "0x6006338")]
		[Address(RVA = "0xFCCA40", Offset = "0xFCB840", Length = "0x62")]
		private void Reset()
		{
		}

		[Token(Token = "0x6006339")]
		[Address(RVA = "0xFCCAB0", Offset = "0xFCB8B0", Length = "0x5")]
		private void ResetTimers()
		{
		}

		[Token(Token = "0x600633A")]
		[Address(RVA = "0xFCCAC0", Offset = "0xFCB8C0", Length = "0x6B")]
		public void FullReset()
		{
		}
	}

	[Token(Token = "0x2000C39")]
	private abstract class QueueEntry
	{
		[Token(Token = "0x2000C3A")]
		public enum State
		{
			[Token(Token = "0x4007C94")]
			Waiting,
			[Token(Token = "0x4007C95")]
			Confirmed,
			[Token(Token = "0x4007C96")]
			Canceled
		}

		[Token(Token = "0x4007C92")]
		private static int uidCounter;

		[Token(Token = "0x17000698")]
		[field: Token(Token = "0x4007C8E")]
		[field: FieldOffset(Offset = "0x10")]
		public int id
		{
			[Token(Token = "0x600633B")]
			[Address(RVA = "0x40E0A0", Offset = "0x40CEA0", Length = "0x4")]
			get;
			[Token(Token = "0x600633C")]
			[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
			protected set;
		}

		[Token(Token = "0x17000699")]
		[field: Token(Token = "0x4007C8F")]
		[field: FieldOffset(Offset = "0x14")]
		public QueueActionType queueActionType
		{
			[Token(Token = "0x600633D")]
			[Address(RVA = "0x40E0B0", Offset = "0x40CEB0", Length = "0x4")]
			get;
			[Token(Token = "0x600633E")]
			[Address(RVA = "0x40E0C0", Offset = "0x40CEC0", Length = "0x4")]
			protected set;
		}

		[Token(Token = "0x1700069A")]
		[field: Token(Token = "0x4007C90")]
		[field: FieldOffset(Offset = "0x18")]
		public State state
		{
			[Token(Token = "0x600633F")]
			[Address(RVA = "0x40E0D0", Offset = "0x40CED0", Length = "0x4")]
			get;
			[Token(Token = "0x6006340")]
			[Address(RVA = "0x40E0E0", Offset = "0x40CEE0", Length = "0x4")]
			protected set;
		}

		[Token(Token = "0x1700069B")]
		[field: Token(Token = "0x4007C91")]
		[field: FieldOffset(Offset = "0x1C")]
		public UserResponse response
		{
			[Token(Token = "0x6006341")]
			[Address(RVA = "0x40E0F0", Offset = "0x40CEF0", Length = "0x4")]
			get;
			[Token(Token = "0x6006342")]
			[Address(RVA = "0x40E100", Offset = "0x40CF00", Length = "0x4")]
			protected set;
		}

		[Token(Token = "0x1700069C")]
		protected static int nextId
		{
			[Token(Token = "0x6006343")]
			[Address(RVA = "0xFCCB30", Offset = "0xFCB930", Length = "0x3F")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x6006344")]
		[Address(RVA = "0xFCCB70", Offset = "0xFCB970", Length = "0x5A")]
		public QueueEntry(QueueActionType queueActionType)
		{
		}

		[Token(Token = "0x6006345")]
		[Address(RVA = "0xFCCBD0", Offset = "0xFCB9D0", Length = "0xB")]
		public void Confirm(UserResponse response)
		{
		}

		[Token(Token = "0x6006346")]
		[Address(RVA = "0xFCCBE0", Offset = "0xFCB9E0", Length = "0x8")]
		public void Cancel()
		{
		}
	}

	[Token(Token = "0x2000C3B")]
	private class JoystickAssignmentChange : QueueEntry
	{
		[Token(Token = "0x1700069D")]
		[field: Token(Token = "0x4007C97")]
		[field: FieldOffset(Offset = "0x20")]
		public int playerId
		{
			[Token(Token = "0x6006347")]
			[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
			get;
			[Token(Token = "0x6006348")]
			[Address(RVA = "0x509350", Offset = "0x508150", Length = "0x4")]
			private set;
		}

		[Token(Token = "0x1700069E")]
		[field: Token(Token = "0x4007C98")]
		[field: FieldOffset(Offset = "0x24")]
		public int joystickId
		{
			[Token(Token = "0x6006349")]
			[Address(RVA = "0x4AA8A0", Offset = "0x4A96A0", Length = "0x4")]
			get;
			[Token(Token = "0x600634A")]
			[Address(RVA = "0x4AA8B0", Offset = "0x4A96B0", Length = "0x4")]
			private set;
		}

		[Token(Token = "0x1700069F")]
		[field: Token(Token = "0x4007C99")]
		[field: FieldOffset(Offset = "0x28")]
		public bool assign
		{
			[Token(Token = "0x600634B")]
			[Address(RVA = "0xB97C80", Offset = "0xB96A80", Length = "0x5")]
			get;
			[Token(Token = "0x600634C")]
			[Address(RVA = "0xE3CD40", Offset = "0xE3BB40", Length = "0x4")]
			private set;
		}

		[Token(Token = "0x600634D")]
		[Address(RVA = "0xFCCBF0", Offset = "0xFCB9F0", Length = "0x83")]
		public JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign)
		{
		}
	}

	[Token(Token = "0x2000C3C")]
	private class ElementAssignmentChange : QueueEntry
	{
		[Token(Token = "0x170006A0")]
		[field: Token(Token = "0x4007C9A")]
		[field: FieldOffset(Offset = "0x20")]
		public ElementAssignmentChangeType changeType
		{
			[Token(Token = "0x600634E")]
			[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
			get;
			[Token(Token = "0x600634F")]
			[Address(RVA = "0x509350", Offset = "0x508150", Length = "0x4")]
			set;
		}

		[Token(Token = "0x170006A1")]
		[field: Token(Token = "0x4007C9B")]
		[field: FieldOffset(Offset = "0x28")]
		public InputMapper.Context context
		{
			[Token(Token = "0x6006350")]
			[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
			get;
			[Token(Token = "0x6006351")]
			[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
			private set;
		}

		[Token(Token = "0x6006352")]
		[Address(RVA = "0xFCCC80", Offset = "0xFCBA80", Length = "0xC1")]
		public ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context)
		{
		}

		[Token(Token = "0x6006353")]
		[Address(RVA = "0xFCCD50", Offset = "0xFCBB50", Length = "0x44")]
		public ElementAssignmentChange(ElementAssignmentChange other)
		{
		}
	}

	[Token(Token = "0x2000C3D")]
	private class FallbackJoystickIdentification : QueueEntry
	{
		[Token(Token = "0x170006A2")]
		[field: Token(Token = "0x4007C9C")]
		[field: FieldOffset(Offset = "0x20")]
		public int joystickId
		{
			[Token(Token = "0x6006354")]
			[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
			get;
			[Token(Token = "0x6006355")]
			[Address(RVA = "0x509350", Offset = "0x508150", Length = "0x4")]
			private set;
		}

		[Token(Token = "0x170006A3")]
		[field: Token(Token = "0x4007C9D")]
		[field: FieldOffset(Offset = "0x28")]
		public string joystickName
		{
			[Token(Token = "0x6006356")]
			[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
			get;
			[Token(Token = "0x6006357")]
			[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
			private set;
		}

		[Token(Token = "0x6006358")]
		[Address(RVA = "0xFCCDA0", Offset = "0xFCBBA0", Length = "0xC1")]
		public FallbackJoystickIdentification(int joystickId, string joystickName)
		{
		}
	}

	[Token(Token = "0x2000C3E")]
	private class Calibration : QueueEntry
	{
		[Token(Token = "0x4007CA2")]
		[FieldOffset(Offset = "0x40")]
		public int selectedElementIdentifierId;

		[Token(Token = "0x4007CA3")]
		[FieldOffset(Offset = "0x44")]
		public bool recording;

		[Token(Token = "0x170006A4")]
		[field: Token(Token = "0x4007C9E")]
		[field: FieldOffset(Offset = "0x20")]
		public Player player
		{
			[Token(Token = "0x6006359")]
			[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
			get;
			[Token(Token = "0x600635A")]
			[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
			private set;
		}

		[Token(Token = "0x170006A5")]
		[field: Token(Token = "0x4007C9F")]
		[field: FieldOffset(Offset = "0x28")]
		public ControllerType controllerType
		{
			[Token(Token = "0x600635B")]
			[Address(RVA = "0x4588A0", Offset = "0x4576A0", Length = "0x4")]
			get;
			[Token(Token = "0x600635C")]
			[Address(RVA = "0x92FF10", Offset = "0x92ED10", Length = "0x4")]
			private set;
		}

		[Token(Token = "0x170006A6")]
		[field: Token(Token = "0x4007CA0")]
		[field: FieldOffset(Offset = "0x30")]
		public Joystick joystick
		{
			[Token(Token = "0x600635D")]
			[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
			get;
			[Token(Token = "0x600635E")]
			[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
			private set;
		}

		[Token(Token = "0x170006A7")]
		[field: Token(Token = "0x4007CA1")]
		[field: FieldOffset(Offset = "0x38")]
		public CalibrationMap calibrationMap
		{
			[Token(Token = "0x600635F")]
			[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
			get;
			[Token(Token = "0x6006360")]
			[Address(RVA = "0x509400", Offset = "0x508200", Length = "0x52")]
			private set;
		}

		[Token(Token = "0x6006361")]
		[Address(RVA = "0xFCCE70", Offset = "0xFCBC70", Length = "0x175")]
		public Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap)
		{
		}
	}

	[Token(Token = "0x2000C3F")]
	private struct WindowProperties
	{
		[Token(Token = "0x4007CA4")]
		[FieldOffset(Offset = "0x0")]
		public int windowId;

		[Token(Token = "0x4007CA5")]
		[FieldOffset(Offset = "0x4")]
		public Rect rect;

		[Token(Token = "0x4007CA6")]
		[FieldOffset(Offset = "0x18")]
		public Action<string, string> windowDrawDelegate;

		[Token(Token = "0x4007CA7")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x4007CA8")]
		[FieldOffset(Offset = "0x28")]
		public string message;
	}

	[Token(Token = "0x2000C40")]
	private enum QueueActionType
	{
		[Token(Token = "0x4007CAA")]
		None,
		[Token(Token = "0x4007CAB")]
		JoystickAssignment,
		[Token(Token = "0x4007CAC")]
		ElementAssignment,
		[Token(Token = "0x4007CAD")]
		FallbackJoystickIdentification,
		[Token(Token = "0x4007CAE")]
		Calibrate
	}

	[Token(Token = "0x2000C41")]
	private enum ElementAssignmentChangeType
	{
		[Token(Token = "0x4007CB0")]
		Add,
		[Token(Token = "0x4007CB1")]
		Replace,
		[Token(Token = "0x4007CB2")]
		Remove,
		[Token(Token = "0x4007CB3")]
		ReassignOrRemove,
		[Token(Token = "0x4007CB4")]
		ConflictCheck
	}

	[Token(Token = "0x2000C42")]
	public enum UserResponse
	{
		[Token(Token = "0x4007CB6")]
		Confirm,
		[Token(Token = "0x4007CB7")]
		Cancel,
		[Token(Token = "0x4007CB8")]
		Custom1,
		[Token(Token = "0x4007CB9")]
		Custom2
	}

	[Token(Token = "0x4007C61")]
	private const float defaultModalWidth = 250f;

	[Token(Token = "0x4007C62")]
	private const float defaultModalHeight = 200f;

	[Token(Token = "0x4007C63")]
	private const float assignmentTimeout = 5f;

	[Token(Token = "0x4007C64")]
	[FieldOffset(Offset = "0x20")]
	private DialogHelper dialog;

	[Token(Token = "0x4007C65")]
	[FieldOffset(Offset = "0x28")]
	private InputMapper inputMapper;

	[Token(Token = "0x4007C66")]
	[FieldOffset(Offset = "0x30")]
	private InputMapper.ConflictFoundEventData conflictFoundEventData;

	[Token(Token = "0x4007C67")]
	[FieldOffset(Offset = "0x38")]
	private bool guiState;

	[Token(Token = "0x4007C68")]
	[FieldOffset(Offset = "0x39")]
	private bool busy;

	[Token(Token = "0x4007C69")]
	[FieldOffset(Offset = "0x3A")]
	private bool pageGUIState;

	[Token(Token = "0x4007C6A")]
	[FieldOffset(Offset = "0x40")]
	private Player selectedPlayer;

	[Token(Token = "0x4007C6B")]
	[FieldOffset(Offset = "0x48")]
	private int selectedMapCategoryId;

	[Token(Token = "0x4007C6C")]
	[FieldOffset(Offset = "0x50")]
	private ControllerSelection selectedController;

	[Token(Token = "0x4007C6D")]
	[FieldOffset(Offset = "0x58")]
	private ControllerMap selectedMap;

	[Token(Token = "0x4007C6E")]
	[FieldOffset(Offset = "0x60")]
	private bool showMenu;

	[Token(Token = "0x4007C6F")]
	[FieldOffset(Offset = "0x61")]
	private bool startListening;

	[Token(Token = "0x4007C70")]
	[FieldOffset(Offset = "0x64")]
	private Vector2 actionScrollPos;

	[Token(Token = "0x4007C71")]
	[FieldOffset(Offset = "0x6C")]
	private Vector2 calibrateScrollPos;

	[Token(Token = "0x4007C72")]
	[FieldOffset(Offset = "0x78")]
	private Queue<QueueEntry> actionQueue;

	[Token(Token = "0x4007C73")]
	[FieldOffset(Offset = "0x80")]
	private bool setupFinished;

	[NonSerialized]
	[Token(Token = "0x4007C74")]
	[FieldOffset(Offset = "0x81")]
	private bool initialized;

	[Token(Token = "0x4007C75")]
	[FieldOffset(Offset = "0x82")]
	private bool isCompiling;

	[Token(Token = "0x4007C76")]
	[FieldOffset(Offset = "0x88")]
	private GUIStyle style_wordWrap;

	[Token(Token = "0x4007C77")]
	[FieldOffset(Offset = "0x90")]
	private GUIStyle style_centeredBox;

	[Token(Token = "0x60062D8")]
	[Address(RVA = "0xFC0190", Offset = "0xFBEF90", Length = "0x6B")]
	private void Awake()
	{
	}

	[Token(Token = "0x60062D9")]
	[Address(RVA = "0xFC0200", Offset = "0xFBF000", Length = "0x105")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60062DA")]
	[Address(RVA = "0xFC0310", Offset = "0xFBF110", Length = "0x1D")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60062DB")]
	[Address(RVA = "0xFC0330", Offset = "0xFBF130", Length = "0x472")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60062DC")]
	[Address(RVA = "0xFC07B0", Offset = "0xFBF5B0", Length = "0x1F2")]
	private void Setup()
	{
	}

	[Token(Token = "0x60062DD")]
	[Address(RVA = "0xFC0200", Offset = "0xFBF000", Length = "0x105")]
	private void Subscribe()
	{
	}

	[Token(Token = "0x60062DE")]
	[Address(RVA = "0xFC0310", Offset = "0xFBF110", Length = "0x1D")]
	private void Unsubscribe()
	{
	}

	[Token(Token = "0x60062DF")]
	[Address(RVA = "0xFC09B0", Offset = "0xFBF7B0", Length = "0x2DA")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x60062E0")]
	[Address(RVA = "0xFC0C90", Offset = "0xFBFA90", Length = "0x1B1")]
	private void HandleMenuControl()
	{
	}

	[Token(Token = "0x60062E1")]
	[Address(RVA = "0xFC0E50", Offset = "0xFBFC50", Length = "0x1A")]
	private void Close()
	{
	}

	[Token(Token = "0x60062E2")]
	[Address(RVA = "0x7DF760", Offset = "0x7DE560", Length = "0x5")]
	private void Open()
	{
	}

	[Token(Token = "0x60062E3")]
	[Address(RVA = "0xFC0E70", Offset = "0xFBFC70", Length = "0x391")]
	private void DrawInitialScreen()
	{
	}

	[Token(Token = "0x60062E4")]
	[Address(RVA = "0xFC1210", Offset = "0xFC0010", Length = "0x42B")]
	private void DrawPage()
	{
	}

	[Token(Token = "0x60062E5")]
	[Address(RVA = "0xFC1640", Offset = "0xFC0440", Length = "0x551")]
	private void DrawPlayerSelector()
	{
	}

	[Token(Token = "0x60062E6")]
	[Address(RVA = "0xFC1BA0", Offset = "0xFC09A0", Length = "0x5B7")]
	private void DrawMouseAssignment()
	{
	}

	[Token(Token = "0x60062E7")]
	[Address(RVA = "0xFC2160", Offset = "0xFC0F60", Length = "0x7E1")]
	private void DrawJoystickSelector()
	{
	}

	[Token(Token = "0x60062E8")]
	[Address(RVA = "0xFC2950", Offset = "0xFC1750", Length = "0x870")]
	private void DrawControllerSelector()
	{
	}

	[Token(Token = "0x60062E9")]
	[Address(RVA = "0xFC31D0", Offset = "0xFC1FD0", Length = "0x568")]
	private void DrawCalibrateButton()
	{
	}

	[Token(Token = "0x60062EA")]
	[Address(RVA = "0xFC3740", Offset = "0xFC2540", Length = "0x96A")]
	private void DrawMapCategories()
	{
	}

	[Token(Token = "0x60062EB")]
	[Address(RVA = "0xFC40B0", Offset = "0xFC2EB0", Length = "0xFD3")]
	private void DrawCategoryActions()
	{
	}

	[Token(Token = "0x60062EC")]
	[Address(RVA = "0xFC5090", Offset = "0xFC3E90", Length = "0x243")]
	private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
	}

	[Token(Token = "0x60062ED")]
	[Address(RVA = "0xFC52E0", Offset = "0xFC40E0", Length = "0x15E")]
	private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
	}

	[Token(Token = "0x60062EE")]
	[Address(RVA = "0xFC5440", Offset = "0xFC4240", Length = "0x175")]
	private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap)
	{
	}

	[Token(Token = "0x60062EF")]
	[Address(RVA = "0xFC55C0", Offset = "0xFC43C0", Length = "0x86")]
	private void ShowDialog()
	{
	}

	[Token(Token = "0x60062F0")]
	[Address(RVA = "0xFC5650", Offset = "0xFC4450", Length = "0x163")]
	private void DrawModalWindow(string title, string message)
	{
	}

	[Token(Token = "0x60062F1")]
	[Address(RVA = "0xFC57C0", Offset = "0xFC45C0", Length = "0x118")]
	private void DrawModalWindow_OkayOnly(string title, string message)
	{
	}

	[Token(Token = "0x60062F2")]
	[Address(RVA = "0xFC58E0", Offset = "0xFC46E0", Length = "0x2AD")]
	private void DrawElementAssignmentWindow(string title, string message)
	{
	}

	[Token(Token = "0x60062F3")]
	[Address(RVA = "0xFC5B90", Offset = "0xFC4990", Length = "0x212")]
	private void DrawElementAssignmentProtectedConflictWindow(string title, string message)
	{
	}

	[Token(Token = "0x60062F4")]
	[Address(RVA = "0xFC5DB0", Offset = "0xFC4BB0", Length = "0x248")]
	private void DrawElementAssignmentNormalConflictWindow(string title, string message)
	{
	}

	[Token(Token = "0x60062F5")]
	[Address(RVA = "0xFC6000", Offset = "0xFC4E00", Length = "0x148")]
	private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message)
	{
	}

	[Token(Token = "0x60062F6")]
	[Address(RVA = "0xFC6150", Offset = "0xFC4F50", Length = "0x25F")]
	private void DrawFallbackJoystickIdentificationWindow(string title, string message)
	{
	}

	[Token(Token = "0x60062F7")]
	[Address(RVA = "0xFC63B0", Offset = "0xFC51B0", Length = "0x16BA")]
	private void DrawCalibrationWindow(string title, string message)
	{
	}

	[Token(Token = "0x60062F8")]
	[Address(RVA = "0xFC7A70", Offset = "0xFC6870", Length = "0x1F0")]
	private void DialogResultCallback(int queueActionId, UserResponse response)
	{
	}

	[Token(Token = "0x60062F9")]
	[Address(RVA = "0xFC7C70", Offset = "0xFC6A70", Length = "0x110")]
	private Rect GetScreenCenteredRect(float width, float height)
	{
		return default(Rect);
	}

	[Token(Token = "0x60062FA")]
	[Address(RVA = "0xFC7D90", Offset = "0xFC6B90", Length = "0xC7")]
	private void EnqueueAction(QueueEntry entry)
	{
	}

	[Token(Token = "0x60062FB")]
	[Address(RVA = "0xFC7E60", Offset = "0xFC6C60", Length = "0x26D")]
	private void ProcessQueue()
	{
	}

	[Token(Token = "0x60062FC")]
	[Address(RVA = "0xFC80D0", Offset = "0xFC6ED0", Length = "0x4D4")]
	private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry)
	{
		return false;
	}

	[Token(Token = "0x60062FD")]
	[Address(RVA = "0xFC85B0", Offset = "0xFC73B0", Length = "0xA2")]
	private bool ProcessElementAssignmentChange(ElementAssignmentChange entry)
	{
		return false;
	}

	[Token(Token = "0x60062FE")]
	[Address(RVA = "0xFC8660", Offset = "0xFC7460", Length = "0x40A")]
	private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry)
	{
		return false;
	}

	[Token(Token = "0x60062FF")]
	[Address(RVA = "0xFC8A70", Offset = "0xFC7870", Length = "0x36A")]
	private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry)
	{
		return false;
	}

	[Token(Token = "0x6006300")]
	[Address(RVA = "0xFC8DE0", Offset = "0xFC7BE0", Length = "0x5C3")]
	private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry)
	{
		return false;
	}

	[Token(Token = "0x6006301")]
	[Address(RVA = "0xFC93B0", Offset = "0xFC81B0", Length = "0x5AA")]
	private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry)
	{
		return false;
	}

	[Token(Token = "0x6006302")]
	[Address(RVA = "0xFC9960", Offset = "0xFC8760", Length = "0x325")]
	private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry)
	{
		return false;
	}

	[Token(Token = "0x6006303")]
	[Address(RVA = "0xFC9C90", Offset = "0xFC8A90", Length = "0x355")]
	private bool ProcessCalibration(Calibration entry)
	{
		return false;
	}

	[Token(Token = "0x6006304")]
	[Address(RVA = "0xFC9FF0", Offset = "0xFC8DF0", Length = "0x7")]
	private void PlayerSelectionChanged()
	{
	}

	[Token(Token = "0x6006305")]
	[Address(RVA = "0xFCA000", Offset = "0xFC8E00", Length = "0x52")]
	private void ControllerSelectionChanged()
	{
	}

	[Token(Token = "0x6006306")]
	[Address(RVA = "0xFCA060", Offset = "0xFC8E60", Length = "0x8B")]
	private void ClearControllerSelection()
	{
	}

	[Token(Token = "0x6006307")]
	[Address(RVA = "0xFCA000", Offset = "0xFC8E00", Length = "0x52")]
	private void ClearMapSelection()
	{
	}

	[Token(Token = "0x6006308")]
	[Address(RVA = "0xFCA0F0", Offset = "0xFC8EF0", Length = "0x21")]
	private void ResetAll()
	{
	}

	[Token(Token = "0x6006309")]
	[Address(RVA = "0xFCA120", Offset = "0xFC8F20", Length = "0x244")]
	private void ClearWorkingVars()
	{
	}

	[Token(Token = "0x600630A")]
	[Address(RVA = "0xFCA370", Offset = "0xFC9170", Length = "0x123")]
	private void SetGUIStateStart()
	{
	}

	[Token(Token = "0x600630B")]
	[Address(RVA = "0xFCA4A0", Offset = "0xFC92A0", Length = "0xE8")]
	private void SetGUIStateEnd()
	{
	}

	[Token(Token = "0x600630C")]
	[Address(RVA = "0xFCA590", Offset = "0xFC9390", Length = "0x387")]
	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x600630D")]
	[Address(RVA = "0xFCA920", Offset = "0xFC9720", Length = "0x385")]
	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x600630E")]
	[Address(RVA = "0xFCACB0", Offset = "0xFC9AB0", Length = "0x6F")]
	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x600630F")]
	[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
	private void OnConflictFound(InputMapper.ConflictFoundEventData data)
	{
	}

	[Token(Token = "0x6006310")]
	[Address(RVA = "0xFCAD20", Offset = "0xFC9B20", Length = "0x52")]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[Token(Token = "0x6006311")]
	[Address(RVA = "0xFCAD80", Offset = "0xFC9B80", Length = "0x35A")]
	public void IdentifyAllJoysticks()
	{
	}

	[Token(Token = "0x6006312")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected void CheckRecompile()
	{
	}

	[Token(Token = "0x6006313")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void RecompileWindow(int windowId)
	{
	}

	[Token(Token = "0x6006314")]
	[Address(RVA = "0xFCB0E0", Offset = "0xFC9EE0", Length = "0x6C4")]
	public ControlRemappingDemo1()
	{
	}
}
