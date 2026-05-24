using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

[Token(Token = "0x2000C2B")]
public abstract class RewiredPointerInputModule : BaseInputModule
{
	[Token(Token = "0x2000C2C")]
	protected class MouseState
	{
		[Token(Token = "0x4007C2D")]
		[FieldOffset(Offset = "0x10")]
		private List<ButtonState> m_TrackedButtons;

		[Token(Token = "0x6006248")]
		[Address(RVA = "0xFB7F50", Offset = "0xFB6D50", Length = "0xB3")]
		public bool AnyPressesThisFrame()
		{
			return false;
		}

		[Token(Token = "0x6006249")]
		[Address(RVA = "0xFB8010", Offset = "0xFB6E10", Length = "0xB4")]
		public bool AnyReleasesThisFrame()
		{
			return false;
		}

		[Token(Token = "0x600624A")]
		[Address(RVA = "0xFB80D0", Offset = "0xFB6ED0", Length = "0x1D8")]
		public ButtonState GetButtonState(int button)
		{
			return null;
		}

		[Token(Token = "0x600624B")]
		[Address(RVA = "0xFB82B0", Offset = "0xFB70B0", Length = "0x91")]
		public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
		{
		}

		[Token(Token = "0x600624C")]
		[Address(RVA = "0xFB8350", Offset = "0xFB7150", Length = "0xAD")]
		public MouseState()
		{
		}
	}

	[Token(Token = "0x2000C2D")]
	public class MouseButtonEventData
	{
		[Token(Token = "0x4007C2E")]
		[FieldOffset(Offset = "0x10")]
		public PointerEventData.FramePressState buttonState;

		[Token(Token = "0x4007C2F")]
		[FieldOffset(Offset = "0x18")]
		public PlayerPointerEventData buttonData;

		[Token(Token = "0x600624D")]
		[Address(RVA = "0xFB8400", Offset = "0xFB7200", Length = "0x11")]
		public bool PressedThisFrame()
		{
			return false;
		}

		[Token(Token = "0x600624E")]
		[Address(RVA = "0xFB8420", Offset = "0xFB7220", Length = "0x10")]
		public bool ReleasedThisFrame()
		{
			return false;
		}

		[Token(Token = "0x600624F")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public MouseButtonEventData()
		{
		}
	}

	[Token(Token = "0x2000C2E")]
	protected class ButtonState
	{
		[Token(Token = "0x4007C30")]
		[FieldOffset(Offset = "0x10")]
		private int m_Button;

		[Token(Token = "0x4007C31")]
		[FieldOffset(Offset = "0x18")]
		private MouseButtonEventData m_EventData;

		[Token(Token = "0x17000663")]
		public MouseButtonEventData eventData
		{
			[Token(Token = "0x6006250")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006251")]
			[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
			set
			{
			}
		}

		[Token(Token = "0x17000664")]
		public int button
		{
			[Token(Token = "0x6006252")]
			[Address(RVA = "0x40E0A0", Offset = "0x40CEA0", Length = "0x4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006253")]
			[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
			set
			{
			}
		}

		[Token(Token = "0x6006254")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ButtonState()
		{
		}
	}

	[Token(Token = "0x2000C2F")]
	private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
	{
		[Token(Token = "0x4007C32")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 m_MousePosition;

		[Token(Token = "0x4007C33")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 m_MousePositionPrev;

		[Token(Token = "0x4007C34")]
		[FieldOffset(Offset = "0x20")]
		private int m_LastUpdatedFrame;

		[Token(Token = "0x17000665")]
		int IMouseInputSource.playerId
		{
			[Token(Token = "0x6006255")]
			[Address(RVA = "0xFB8430", Offset = "0xFB7230", Length = "0x12")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x17000666")]
		int ITouchInputSource.playerId
		{
			[Token(Token = "0x6006256")]
			[Address(RVA = "0xFB8430", Offset = "0xFB7230", Length = "0x12")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x17000667")]
		bool IMouseInputSource.enabled
		{
			[Token(Token = "0x6006257")]
			[Address(RVA = "0xFB8450", Offset = "0xFB7250", Length = "0x16")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x17000668")]
		bool IMouseInputSource.locked
		{
			[Token(Token = "0x6006258")]
			[Address(RVA = "0xFB8470", Offset = "0xFB7270", Length = "0x52")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x17000669")]
		int IMouseInputSource.buttonCount
		{
			[Token(Token = "0x6006259")]
			[Address(RVA = "0xFB84D0", Offset = "0xFB72D0", Length = "0x15")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x1700066A")]
		Vector2 IMouseInputSource.screenPosition
		{
			[Token(Token = "0x600625D")]
			[Address(RVA = "0xFB8610", Offset = "0xFB7410", Length = "0x70")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x1700066B")]
		Vector2 IMouseInputSource.screenPositionDelta
		{
			[Token(Token = "0x600625E")]
			[Address(RVA = "0xFB8690", Offset = "0xFB7490", Length = "0x32")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x1700066C")]
		Vector2 IMouseInputSource.wheelDelta
		{
			[Token(Token = "0x600625F")]
			[Address(RVA = "0xFB86D0", Offset = "0xFB74D0", Length = "0x5F")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x1700066D")]
		bool ITouchInputSource.touchSupported
		{
			[Token(Token = "0x6006260")]
			[Address(RVA = "0xFB8730", Offset = "0xFB7530", Length = "0x16")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x1700066E")]
		int ITouchInputSource.touchCount
		{
			[Token(Token = "0x6006261")]
			[Address(RVA = "0xFB8750", Offset = "0xFB7550", Length = "0x4C")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x600625A")]
		[Address(RVA = "0xFB84F0", Offset = "0xFB72F0", Length = "0x53")]
		bool IMouseInputSource.GetButtonDown(int button)
		{
			return false;
		}

		[Token(Token = "0x600625B")]
		[Address(RVA = "0xFB8550", Offset = "0xFB7350", Length = "0x53")]
		bool IMouseInputSource.GetButtonUp(int button)
		{
			return false;
		}

		[Token(Token = "0x600625C")]
		[Address(RVA = "0xFB85B0", Offset = "0xFB73B0", Length = "0x53")]
		bool IMouseInputSource.GetButton(int button)
		{
			return false;
		}

		[Token(Token = "0x6006262")]
		[Address(RVA = "0xFB87A0", Offset = "0xFB75A0", Length = "0xB8")]
		Touch ITouchInputSource.GetTouch(int index)
		{
			return default(Touch);
		}

		[Token(Token = "0x6006263")]
		[Address(RVA = "0xFB8860", Offset = "0xFB7660", Length = "0x113")]
		private void TryUpdate()
		{
		}

		[Token(Token = "0x6006264")]
		[Address(RVA = "0xFB8980", Offset = "0xFB7780", Length = "0x8")]
		public UnityInputSource()
		{
		}
	}

	[Token(Token = "0x4007C21")]
	public const int kMouseLeftId = -1;

	[Token(Token = "0x4007C22")]
	public const int kMouseRightId = -2;

	[Token(Token = "0x4007C23")]
	public const int kMouseMiddleId = -3;

	[Token(Token = "0x4007C24")]
	public const int kFakeTouchesId = -4;

	[Token(Token = "0x4007C25")]
	private const int customButtonsStartingId = -2147483520;

	[Token(Token = "0x4007C26")]
	private const int customButtonsMaxCount = 128;

	[Token(Token = "0x4007C27")]
	private const int customButtonsLastId = -2147483392;

	[Token(Token = "0x4007C28")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<IMouseInputSource> m_MouseInputSourcesList;

	[Token(Token = "0x4007C29")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;

	[Token(Token = "0x4007C2A")]
	[FieldOffset(Offset = "0x68")]
	private ITouchInputSource m_UserDefaultTouchInputSource;

	[Token(Token = "0x4007C2B")]
	[FieldOffset(Offset = "0x70")]
	private UnityInputSource __m_DefaultInputSource;

	[Token(Token = "0x4007C2C")]
	[FieldOffset(Offset = "0x78")]
	private readonly MouseState m_MouseState;

	[Token(Token = "0x1700065F")]
	private UnityInputSource defaultInputSource
	{
		[Token(Token = "0x6006229")]
		[Address(RVA = "0xFB3D00", Offset = "0xFB2B00", Length = "0x9A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000660")]
	private IMouseInputSource defaultMouseInputSource
	{
		[Token(Token = "0x600622A")]
		[Address(RVA = "0xFB3DA0", Offset = "0xFB2BA0", Length = "0x7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000661")]
	protected ITouchInputSource defaultTouchInputSource
	{
		[Token(Token = "0x600622B")]
		[Address(RVA = "0xFB3DA0", Offset = "0xFB2BA0", Length = "0x7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000662")]
	protected virtual bool isMouseSupported
	{
		[Token(Token = "0x6006236")]
		[Address(RVA = "0xFB4650", Offset = "0xFB3450", Length = "0x12D")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600622C")]
	[Address(RVA = "0xFB3DB0", Offset = "0xFB2BB0", Length = "0x1C")]
	protected bool IsDefaultMouse(IMouseInputSource mouse)
	{
		return false;
	}

	[Token(Token = "0x600622D")]
	[Address(RVA = "0xFB3DD0", Offset = "0xFB2BD0", Length = "0x207")]
	public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
	{
		return null;
	}

	[Token(Token = "0x600622E")]
	[Address(RVA = "0xFB3FE0", Offset = "0xFB2DE0", Length = "0xA6")]
	public void RemoveMouseInputSource(IMouseInputSource source)
	{
	}

	[Token(Token = "0x600622F")]
	[Address(RVA = "0xFB4090", Offset = "0xFB2E90", Length = "0x133")]
	public void AddMouseInputSource(IMouseInputSource source)
	{
	}

	[Token(Token = "0x6006230")]
	[Address(RVA = "0xFB41D0", Offset = "0xFB2FD0", Length = "0x17A")]
	public int GetMouseInputSourceCount(int playerId)
	{
		return 0;
	}

	[Token(Token = "0x6006231")]
	[Address(RVA = "0xFB4350", Offset = "0xFB3150", Length = "0x8E")]
	public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
	{
		return null;
	}

	[Token(Token = "0x6006232")]
	[Address(RVA = "0xFB43E0", Offset = "0xFB31E0", Length = "0xB8")]
	public void RemoveTouchInputSource(ITouchInputSource source)
	{
	}

	[Token(Token = "0x6006233")]
	[Address(RVA = "0xFB44A0", Offset = "0xFB32A0", Length = "0x104")]
	public void AddTouchInputSource(ITouchInputSource source)
	{
	}

	[Token(Token = "0x6006234")]
	[Address(RVA = "0xFB45B0", Offset = "0xFB33B0", Length = "0x25")]
	public int GetTouchInputSourceCount(int playerId)
	{
		return 0;
	}

	[Token(Token = "0x6006235")]
	[Address(RVA = "0xFB45E0", Offset = "0xFB33E0", Length = "0x64")]
	protected void ClearMouseInputSources()
	{
	}

	[Token(Token = "0x6006237")]
	protected abstract bool IsDefaultPlayer(int playerId);

	[Token(Token = "0x6006238")]
	[Address(RVA = "0xFB4780", Offset = "0xFB3580", Length = "0x9CC")]
	protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
	{
		data = null;
		return false;
	}

	[Token(Token = "0x6006239")]
	[Address(RVA = "0xFB5150", Offset = "0xFB3F50", Length = "0x177")]
	private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
	{
		return null;
	}

	[Token(Token = "0x600623A")]
	[Address(RVA = "0xFB52D0", Offset = "0xFB40D0", Length = "0xB6")]
	protected void RemovePointerData(PlayerPointerEventData data)
	{
	}

	[Token(Token = "0x600623B")]
	[Address(RVA = "0xFB5390", Offset = "0xFB4190", Length = "0x2F4")]
	protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
	{
		pressed = default(bool);
		released = default(bool);
		return null;
	}

	[Token(Token = "0x600623C")]
	[Address(RVA = "0xFB5690", Offset = "0xFB4490", Length = "0xCDB")]
	protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
	{
		return null;
	}

	[Token(Token = "0x600623D")]
	[Address(RVA = "0xFB6370", Offset = "0xFB5170", Length = "0x244")]
	protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
	{
		return null;
	}

	[Token(Token = "0x600623E")]
	[Address(RVA = "0xFB65C0", Offset = "0xFB53C0", Length = "0x4B")]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		return false;
	}

	[Token(Token = "0x600623F")]
	[Address(RVA = "0xFB6610", Offset = "0xFB5410", Length = "0x115")]
	protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
	{
	}

	[Token(Token = "0x6006240")]
	[Address(RVA = "0xFB6730", Offset = "0xFB5530", Length = "0x3DC")]
	protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
	{
	}

	[Token(Token = "0x6006241")]
	[Address(RVA = "0xFB6B10", Offset = "0xFB5910", Length = "0x2CB")]
	public override bool IsPointerOverGameObject(int pointerTypeId)
	{
		return false;
	}

	[Token(Token = "0x6006242")]
	[Address(RVA = "0xFB6DE0", Offset = "0xFB5BE0", Length = "0x41F")]
	protected void ClearSelection()
	{
	}

	[Token(Token = "0x6006243")]
	[Address(RVA = "0xFB7200", Offset = "0xFB6000", Length = "0x6C1")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006244")]
	[Address(RVA = "0xFB78D0", Offset = "0xFB66D0", Length = "0x194")]
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
	}

	[Token(Token = "0x6006245")]
	[Address(RVA = "0xFB7A70", Offset = "0xFB6870", Length = "0x165")]
	protected void CopyFromTo(PointerEventData from, PointerEventData to)
	{
	}

	[Token(Token = "0x6006246")]
	[Address(RVA = "0xFB7BE0", Offset = "0xFB69E0", Length = "0xCC")]
	protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
	{
		return default(PointerEventData.FramePressState);
	}

	[Token(Token = "0x6006247")]
	[Address(RVA = "0xFB7CB0", Offset = "0xFB6AB0", Length = "0x297")]
	protected RewiredPointerInputModule()
	{
	}
}
