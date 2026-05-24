using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.Components;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Rewired.Integration.UnityUI;

[AddComponentMenu("Rewired/Rewired Standalone Input Module")]
[Token(Token = "0x2000C31")]
public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
{
	[Serializable]
	[Token(Token = "0x2000C32")]
	public class PlayerSetting
	{
		[Token(Token = "0x4007C5B")]
		[FieldOffset(Offset = "0x10")]
		public int playerId;

		[Token(Token = "0x4007C5C")]
		[FieldOffset(Offset = "0x18")]
		public List<Rewired.Components.PlayerMouse> playerMice;

		[Token(Token = "0x60062C0")]
		[Address(RVA = "0xFBF0A0", Offset = "0xFBDEA0", Length = "0xAD")]
		public PlayerSetting()
		{
		}

		[Token(Token = "0x60062C1")]
		[Address(RVA = "0xFBF150", Offset = "0xFBDF50", Length = "0x334")]
		private PlayerSetting(PlayerSetting other)
		{
		}

		[Token(Token = "0x60062C2")]
		[Address(RVA = "0xFBF490", Offset = "0xFBE290", Length = "0x59")]
		public PlayerSetting Clone()
		{
			return null;
		}
	}

	[Token(Token = "0x4007C38")]
	private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

	[Token(Token = "0x4007C39")]
	private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

	[Token(Token = "0x4007C3A")]
	private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

	[Token(Token = "0x4007C3B")]
	private const string DEFAULT_ACTION_CANCEL = "UICancel";

	[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Player ids, etc.")]
	[SerializeField]
	[Token(Token = "0x4007C3C")]
	[FieldOffset(Offset = "0x80")]
	private InputManager_Base rewiredInputManager;

	[SerializeField]
	[Tooltip("Use all Rewired game Players to control the UI. This does not include the System Player. If enabled, this setting overrides individual Player Ids set in Rewired Player Ids.")]
	[Token(Token = "0x4007C3D")]
	[FieldOffset(Offset = "0x88")]
	private bool useAllRewiredGamePlayers;

	[SerializeField]
	[Tooltip("Allow the Rewired System Player to control the UI.")]
	[Token(Token = "0x4007C3E")]
	[FieldOffset(Offset = "0x89")]
	private bool useRewiredSystemPlayer;

	[SerializeField]
	[Tooltip("A list of Player Ids that are allowed to control the UI. If Use All Rewired Game Players = True, this list will be ignored.")]
	[Token(Token = "0x4007C3F")]
	[FieldOffset(Offset = "0x90")]
	private int[] rewiredPlayerIds;

	[SerializeField]
	[Tooltip("Allow only Players with Player.isPlaying = true to control the UI.")]
	[Token(Token = "0x4007C40")]
	[FieldOffset(Offset = "0x98")]
	private bool usePlayingPlayersOnly;

	[SerializeField]
	[Tooltip("Player Mice allowed to interact with the UI. Each Player that owns a Player Mouse must also be allowed to control the UI or the Player Mouse will not function.")]
	[Token(Token = "0x4007C41")]
	[FieldOffset(Offset = "0xA0")]
	private List<Rewired.Components.PlayerMouse> playerMice;

	[SerializeField]
	[Tooltip("Makes an axis press always move only one UI selection. Enable if you do not want to allow scrolling through UI elements by holding an axis direction.")]
	[Token(Token = "0x4007C42")]
	[FieldOffset(Offset = "0xA8")]
	private bool moveOneElementPerAxisPress;

	[SerializeField]
	[Tooltip("If enabled, Action Ids will be used to set the Actions. If disabled, string names will be used to set the Actions.")]
	[Token(Token = "0x4007C43")]
	[FieldOffset(Offset = "0xA9")]
	private bool setActionsById;

	[SerializeField]
	[Tooltip("Id of the horizontal Action for movement (if axis events are used).")]
	[Token(Token = "0x4007C44")]
	[FieldOffset(Offset = "0xAC")]
	private int horizontalActionId;

	[SerializeField]
	[Tooltip("Id of the vertical Action for movement (if axis events are used).")]
	[Token(Token = "0x4007C45")]
	[FieldOffset(Offset = "0xB0")]
	private int verticalActionId;

	[SerializeField]
	[Tooltip("Id of the Action used to submit.")]
	[Token(Token = "0x4007C46")]
	[FieldOffset(Offset = "0xB4")]
	private int submitActionId;

	[SerializeField]
	[Tooltip("Id of the Action used to cancel.")]
	[Token(Token = "0x4007C47")]
	[FieldOffset(Offset = "0xB8")]
	private int cancelActionId;

	[SerializeField]
	[Tooltip("Name of the horizontal axis for movement (if axis events are used).")]
	[Token(Token = "0x4007C48")]
	[FieldOffset(Offset = "0xC0")]
	private string m_HorizontalAxis;

	[SerializeField]
	[Tooltip("Name of the vertical axis for movement (if axis events are used).")]
	[Token(Token = "0x4007C49")]
	[FieldOffset(Offset = "0xC8")]
	private string m_VerticalAxis;

	[SerializeField]
	[Tooltip("Name of the action used to submit.")]
	[Token(Token = "0x4007C4A")]
	[FieldOffset(Offset = "0xD0")]
	private string m_SubmitButton;

	[SerializeField]
	[Tooltip("Name of the action used to cancel.")]
	[Token(Token = "0x4007C4B")]
	[FieldOffset(Offset = "0xD8")]
	private string m_CancelButton;

	[SerializeField]
	[Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction.")]
	[Token(Token = "0x4007C4C")]
	[FieldOffset(Offset = "0xE0")]
	private float m_InputActionsPerSecond;

	[SerializeField]
	[Tooltip("Delay in seconds before vertical/horizontal movement starts repeating continouously when a movement direction is held.")]
	[Token(Token = "0x4007C4D")]
	[FieldOffset(Offset = "0xE4")]
	private float m_RepeatDelay;

	[SerializeField]
	[Tooltip("Allows the mouse to be used to select elements.")]
	[Token(Token = "0x4007C4E")]
	[FieldOffset(Offset = "0xE8")]
	private bool m_allowMouseInput;

	[SerializeField]
	[Tooltip("Allows the mouse to be used to select elements if the device also supports touch control.")]
	[Token(Token = "0x4007C4F")]
	[FieldOffset(Offset = "0xE9")]
	private bool m_allowMouseInputIfTouchSupported;

	[SerializeField]
	[Tooltip("Allows touch input to be used to select elements.")]
	[Token(Token = "0x4007C50")]
	[FieldOffset(Offset = "0xEA")]
	private bool m_allowTouchInput;

	[SerializeField]
	[Tooltip("Deselects the current selection on mouse/touch click when the pointer is not over a selectable object.")]
	[Token(Token = "0x4007C51")]
	[FieldOffset(Offset = "0xEB")]
	private bool m_deselectIfBackgroundClicked;

	[SerializeField]
	[Tooltip("Deselects the current selection on mouse/touch click before selecting the next object.")]
	[Token(Token = "0x4007C52")]
	[FieldOffset(Offset = "0xEC")]
	private bool m_deselectBeforeSelecting;

	[SerializeField]
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	[Tooltip("Forces the module to always be active.")]
	[Token(Token = "0x4007C53")]
	[FieldOffset(Offset = "0xED")]
	private bool m_ForceModuleActive;

	[NonSerialized]
	[Token(Token = "0x4007C54")]
	[FieldOffset(Offset = "0xF0")]
	private int[] playerIds;

	[Token(Token = "0x4007C55")]
	[FieldOffset(Offset = "0xF8")]
	private bool recompiling;

	[NonSerialized]
	[Token(Token = "0x4007C56")]
	[FieldOffset(Offset = "0xF9")]
	private bool isTouchSupported;

	[NonSerialized]
	[Token(Token = "0x4007C57")]
	[FieldOffset(Offset = "0x100")]
	private double m_PrevActionTime;

	[NonSerialized]
	[Token(Token = "0x4007C58")]
	[FieldOffset(Offset = "0x108")]
	private Vector2 m_LastMoveVector;

	[NonSerialized]
	[Token(Token = "0x4007C59")]
	[FieldOffset(Offset = "0x110")]
	private int m_ConsecutiveMoveCount;

	[NonSerialized]
	[Token(Token = "0x4007C5A")]
	[FieldOffset(Offset = "0x114")]
	private bool m_HasFocus;

	[Token(Token = "0x1700066F")]
	public InputManager_Base RewiredInputManager
	{
		[Token(Token = "0x6006265")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006266")]
		[Address(RVA = "0xB51E90", Offset = "0xB50C90", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000670")]
	public bool UseAllRewiredGamePlayers
	{
		[Token(Token = "0x6006267")]
		[Address(RVA = "0x502340", Offset = "0x501140", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006268")]
		[Address(RVA = "0xFB8990", Offset = "0xFB7790", Length = "0x19")]
		set
		{
		}
	}

	[Token(Token = "0x17000671")]
	public bool UseRewiredSystemPlayer
	{
		[Token(Token = "0x6006269")]
		[Address(RVA = "0xFB89B0", Offset = "0xFB77B0", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x600626A")]
		[Address(RVA = "0xFB89C0", Offset = "0xFB77C0", Length = "0x19")]
		set
		{
		}
	}

	[Token(Token = "0x17000672")]
	public int[] RewiredPlayerIds
	{
		[Token(Token = "0x600626B")]
		[Address(RVA = "0xFB89E0", Offset = "0xFB77E0", Length = "0x7D")]
		get
		{
			return null;
		}
		[Token(Token = "0x600626C")]
		[Address(RVA = "0xFB8A60", Offset = "0xFB7860", Length = "0xEB")]
		set
		{
		}
	}

	[Token(Token = "0x17000673")]
	public bool UsePlayingPlayersOnly
	{
		[Token(Token = "0x600626D")]
		[Address(RVA = "0x5023A0", Offset = "0x5011A0", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x600626E")]
		[Address(RVA = "0x5023B0", Offset = "0x5011B0", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000674")]
	public List<Rewired.Components.PlayerMouse> PlayerMice
	{
		[Token(Token = "0x600626F")]
		[Address(RVA = "0xFB8B50", Offset = "0xFB7950", Length = "0x75")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006270")]
		[Address(RVA = "0xFB8BD0", Offset = "0xFB79D0", Length = "0x157")]
		set
		{
		}
	}

	[Token(Token = "0x17000675")]
	public bool MoveOneElementPerAxisPress
	{
		[Token(Token = "0x6006271")]
		[Address(RVA = "0x835870", Offset = "0x834670", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006272")]
		[Address(RVA = "0x99BB70", Offset = "0x99A970", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000676")]
	public bool allowMouseInput
	{
		[Token(Token = "0x6006273")]
		[Address(RVA = "0xA10E20", Offset = "0xA0FC20", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006274")]
		[Address(RVA = "0xDB7E30", Offset = "0xDB6C30", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000677")]
	public bool allowMouseInputIfTouchSupported
	{
		[Token(Token = "0x6006275")]
		[Address(RVA = "0xFB8D30", Offset = "0xFB7B30", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006276")]
		[Address(RVA = "0xFB8D40", Offset = "0xFB7B40", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000678")]
	public bool allowTouchInput
	{
		[Token(Token = "0x6006277")]
		[Address(RVA = "0xFB8D50", Offset = "0xFB7B50", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006278")]
		[Address(RVA = "0xFB8D60", Offset = "0xFB7B60", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000679")]
	public bool deselectIfBackgroundClicked
	{
		[Token(Token = "0x6006279")]
		[Address(RVA = "0xFB8D70", Offset = "0xFB7B70", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x600627A")]
		[Address(RVA = "0xFB8D80", Offset = "0xFB7B80", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x1700067A")]
	private bool deselectBeforeSelecting
	{
		[Token(Token = "0x600627B")]
		[Address(RVA = "0xFB8D90", Offset = "0xFB7B90", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x600627C")]
		[Address(RVA = "0xFB8DA0", Offset = "0xFB7BA0", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x1700067B")]
	public bool SetActionsById
	{
		[Token(Token = "0x600627D")]
		[Address(RVA = "0xFB8DB0", Offset = "0xFB7BB0", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x600627E")]
		[Address(RVA = "0xFB8DC0", Offset = "0xFB7BC0", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x1700067C")]
	public int HorizontalActionId
	{
		[Token(Token = "0x600627F")]
		[Address(RVA = "0x6A2BE0", Offset = "0x6A19E0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6006280")]
		[Address(RVA = "0xFB8DE0", Offset = "0xFB7BE0", Length = "0x141")]
		set
		{
		}
	}

	[Token(Token = "0x1700067D")]
	public int VerticalActionId
	{
		[Token(Token = "0x6006281")]
		[Address(RVA = "0x5DEE90", Offset = "0x5DDC90", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6006282")]
		[Address(RVA = "0xFB8F30", Offset = "0xFB7D30", Length = "0x141")]
		set
		{
		}
	}

	[Token(Token = "0x1700067E")]
	public int SubmitActionId
	{
		[Token(Token = "0x6006283")]
		[Address(RVA = "0x5EFD20", Offset = "0x5EEB20", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6006284")]
		[Address(RVA = "0xFB9080", Offset = "0xFB7E80", Length = "0x141")]
		set
		{
		}
	}

	[Token(Token = "0x1700067F")]
	public int CancelActionId
	{
		[Token(Token = "0x6006285")]
		[Address(RVA = "0x5DD350", Offset = "0x5DC150", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6006286")]
		[Address(RVA = "0xFB91D0", Offset = "0xFB7FD0", Length = "0x141")]
		set
		{
		}
	}

	[Token(Token = "0x17000680")]
	protected override bool isMouseSupported
	{
		[Token(Token = "0x6006287")]
		[Address(RVA = "0xFB9320", Offset = "0xFB8120", Length = "0x14F")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000681")]
	private bool isTouchAllowed
	{
		[Token(Token = "0x6006288")]
		[Address(RVA = "0xFB8D50", Offset = "0xFB7B50", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead")]
	[Token(Token = "0x17000682")]
	public bool allowActivationOnMobileDevice
	{
		[Token(Token = "0x6006289")]
		[Address(RVA = "0xFB9470", Offset = "0xFB8270", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x600628A")]
		[Address(RVA = "0xFB9480", Offset = "0xFB8280", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000683")]
	public bool forceModuleActive
	{
		[Token(Token = "0x600628B")]
		[Address(RVA = "0xFB9470", Offset = "0xFB8270", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x600628C")]
		[Address(RVA = "0xFB9480", Offset = "0xFB8280", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000684")]
	public float inputActionsPerSecond
	{
		[Token(Token = "0x600628D")]
		[Address(RVA = "0xFB9490", Offset = "0xFB8290", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600628E")]
		[Address(RVA = "0xFB94A0", Offset = "0xFB82A0", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x17000685")]
	public float repeatDelay
	{
		[Token(Token = "0x600628F")]
		[Address(RVA = "0x74C090", Offset = "0x74AE90", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6006290")]
		[Address(RVA = "0xFB94B0", Offset = "0xFB82B0", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x17000686")]
	public string horizontalAxis
	{
		[Token(Token = "0x6006291")]
		[Address(RVA = "0x502640", Offset = "0x501440", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006292")]
		[Address(RVA = "0xFB94C0", Offset = "0xFB82C0", Length = "0x129")]
		set
		{
		}
	}

	[Token(Token = "0x17000687")]
	public string verticalAxis
	{
		[Token(Token = "0x6006293")]
		[Address(RVA = "0x502670", Offset = "0x501470", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006294")]
		[Address(RVA = "0xFB95F0", Offset = "0xFB83F0", Length = "0x129")]
		set
		{
		}
	}

	[Token(Token = "0x17000688")]
	public string submitButton
	{
		[Token(Token = "0x6006295")]
		[Address(RVA = "0x502680", Offset = "0x501480", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006296")]
		[Address(RVA = "0xFB9720", Offset = "0xFB8520", Length = "0x129")]
		set
		{
		}
	}

	[Token(Token = "0x17000689")]
	public string cancelButton
	{
		[Token(Token = "0x6006297")]
		[Address(RVA = "0x502650", Offset = "0x501450", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006298")]
		[Address(RVA = "0xFB9850", Offset = "0xFB8650", Length = "0x129")]
		set
		{
		}
	}

	[Token(Token = "0x6006299")]
	[Address(RVA = "0xFB9980", Offset = "0xFB8780", Length = "0x336")]
	private RewiredStandaloneInputModule()
	{
	}

	[Token(Token = "0x600629A")]
	[Address(RVA = "0xFB9CC0", Offset = "0xFB8AC0", Length = "0xE7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600629B")]
	[Address(RVA = "0xFB9DB0", Offset = "0xFB8BB0", Length = "0xC8")]
	public override void UpdateModule()
	{
	}

	[Token(Token = "0x600629C")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public override bool IsModuleSupported()
	{
		return false;
	}

	[Token(Token = "0x600629D")]
	[Address(RVA = "0xFB9E80", Offset = "0xFB8C80", Length = "0x774")]
	public override bool ShouldActivateModule()
	{
		return false;
	}

	[Token(Token = "0x600629E")]
	[Address(RVA = "0xFBA600", Offset = "0xFB9400", Length = "0x13F")]
	public override void ActivateModule()
	{
	}

	[Token(Token = "0x600629F")]
	[Address(RVA = "0xFBA740", Offset = "0xFB9540", Length = "0x7")]
	public override void DeactivateModule()
	{
	}

	[Token(Token = "0x60062A0")]
	[Address(RVA = "0xFBA750", Offset = "0xFB9550", Length = "0x403")]
	public override void Process()
	{
	}

	[Token(Token = "0x60062A1")]
	[Address(RVA = "0xFBAB60", Offset = "0xFB9960", Length = "0x315")]
	private bool ProcessTouchEvents()
	{
		return false;
	}

	[Token(Token = "0x60062A2")]
	[Address(RVA = "0xFBAE80", Offset = "0xFB9C80", Length = "0x7BB")]
	private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
	{
	}

	[Token(Token = "0x60062A3")]
	[Address(RVA = "0xFBB640", Offset = "0xFBA440", Length = "0x2D6")]
	private bool SendSubmitEventToSelectedObject()
	{
		return false;
	}

	[Token(Token = "0x60062A4")]
	[Address(RVA = "0xFBB920", Offset = "0xFBA720", Length = "0x37E")]
	private Vector2 GetRawMoveVector()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60062A5")]
	[Address(RVA = "0xFBBCA0", Offset = "0xFBAAA0", Length = "0x363")]
	private bool SendMoveEventToSelectedObject()
	{
		return false;
	}

	[Token(Token = "0x60062A6")]
	[Address(RVA = "0xFBC010", Offset = "0xFBAE10", Length = "0x199")]
	private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
	{
		downHorizontal = default(bool);
		downVertical = default(bool);
	}

	[Token(Token = "0x60062A7")]
	[Address(RVA = "0xFBC1B0", Offset = "0xFBAFB0", Length = "0x163")]
	private void ProcessMouseEvents()
	{
	}

	[Token(Token = "0x60062A8")]
	[Address(RVA = "0xFBC320", Offset = "0xFBB120", Length = "0x416")]
	private void ProcessMouseEvent(int playerId, int pointerIndex)
	{
	}

	[Token(Token = "0x60062A9")]
	[Address(RVA = "0xFBC740", Offset = "0xFBB540", Length = "0x180")]
	private bool SendUpdateEventToSelectedObject()
	{
		return false;
	}

	[Token(Token = "0x60062AA")]
	[Address(RVA = "0xFBC8D0", Offset = "0xFBB6D0", Length = "0xA58")]
	private void ProcessMousePress(MouseButtonEventData data)
	{
	}

	[Token(Token = "0x60062AB")]
	[Address(RVA = "0xFBD330", Offset = "0xFBC130", Length = "0x3E9")]
	private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
	}

	[Token(Token = "0x60062AC")]
	[Address(RVA = "0xFBD720", Offset = "0xFBC520", Length = "0x7")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x60062AD")]
	[Address(RVA = "0xFBD730", Offset = "0xFBC530", Length = "0xBF")]
	private bool ShouldIgnoreEventsOnNoFocus()
	{
		return false;
	}

	[Token(Token = "0x60062AE")]
	[Address(RVA = "0xFBD7F0", Offset = "0xFBC5F0", Length = "0x11B")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60062AF")]
	[Address(RVA = "0xFBD910", Offset = "0xFBC710", Length = "0x17E")]
	protected override bool IsDefaultPlayer(int playerId)
	{
		return false;
	}

	[Token(Token = "0x60062B0")]
	[Address(RVA = "0xFBDA90", Offset = "0xFBC890", Length = "0x347")]
	private void InitializeRewired()
	{
	}

	[Token(Token = "0x60062B1")]
	[Address(RVA = "0xFBDDE0", Offset = "0xFBCBE0", Length = "0x765")]
	private void SetupRewiredVars()
	{
	}

	[Token(Token = "0x60062B2")]
	[Address(RVA = "0xFBE550", Offset = "0xFBD350", Length = "0x193")]
	private void SetUpRewiredPlayerMice()
	{
	}

	[Token(Token = "0x60062B3")]
	[Address(RVA = "0xFBE6F0", Offset = "0xFBD4F0", Length = "0x435")]
	private void SetUpRewiredActions()
	{
	}

	[Token(Token = "0x60062B4")]
	[Address(RVA = "0xFBEB30", Offset = "0xFBD930", Length = "0x32")]
	private bool GetButton(Player player, int actionId)
	{
		return false;
	}

	[Token(Token = "0x60062B5")]
	[Address(RVA = "0xFBEB70", Offset = "0xFBD970", Length = "0x32")]
	private bool GetButtonDown(Player player, int actionId)
	{
		return false;
	}

	[Token(Token = "0x60062B6")]
	[Address(RVA = "0xFBEBB0", Offset = "0xFBD9B0", Length = "0x32")]
	private bool GetNegativeButton(Player player, int actionId)
	{
		return false;
	}

	[Token(Token = "0x60062B7")]
	[Address(RVA = "0xFBEBF0", Offset = "0xFBD9F0", Length = "0x32")]
	private bool GetNegativeButtonDown(Player player, int actionId)
	{
		return false;
	}

	[Token(Token = "0x60062B8")]
	[Address(RVA = "0xFBEC30", Offset = "0xFBDA30", Length = "0x33")]
	private float GetAxis(Player player, int actionId)
	{
		return 0f;
	}

	[Token(Token = "0x60062B9")]
	[Address(RVA = "0xFBEC70", Offset = "0xFBDA70", Length = "0x6D")]
	private void CheckEditorRecompile()
	{
	}

	[Token(Token = "0x60062BA")]
	[Address(RVA = "0xFBECE0", Offset = "0xFBDAE0", Length = "0xE")]
	private void OnEditorRecompile()
	{
	}

	[Token(Token = "0x60062BB")]
	[Address(RVA = "0xFBECF0", Offset = "0xFBDAF0", Length = "0x7E")]
	private void ClearRewiredVars()
	{
	}

	[Token(Token = "0x60062BC")]
	[Address(RVA = "0xFBED70", Offset = "0xFBDB70", Length = "0x198")]
	private bool DidAnyMouseMove()
	{
		return false;
	}

	[Token(Token = "0x60062BD")]
	[Address(RVA = "0xFBEF10", Offset = "0xFBDD10", Length = "0x168")]
	private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
	{
		return false;
	}

	[Token(Token = "0x60062BE")]
	[Address(RVA = "0xFBF080", Offset = "0xFBDE80", Length = "0x7")]
	private void OnRewiredInitialized()
	{
	}

	[Token(Token = "0x60062BF")]
	[Address(RVA = "0xFBF090", Offset = "0xFBDE90", Length = "0x7")]
	private void OnRewiredShutDown()
	{
	}
}
