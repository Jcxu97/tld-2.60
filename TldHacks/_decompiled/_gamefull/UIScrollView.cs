using System;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UIPanel))]
[AddComponentMenu("NGUI/Interaction/Scroll View")]
[Token(Token = "0x2000095")]
public class UIScrollView : MonoBehaviour
{
	[Token(Token = "0x2000096")]
	public enum Movement
	{
		[Token(Token = "0x4000545")]
		Horizontal,
		[Token(Token = "0x4000546")]
		Vertical,
		[Token(Token = "0x4000547")]
		Unrestricted,
		[Token(Token = "0x4000548")]
		Custom
	}

	[Token(Token = "0x2000097")]
	public enum DragEffect
	{
		[Token(Token = "0x400054A")]
		None,
		[Token(Token = "0x400054B")]
		Momentum,
		[Token(Token = "0x400054C")]
		MomentumAndSpring
	}

	[Token(Token = "0x2000098")]
	public enum ShowCondition
	{
		[Token(Token = "0x400054E")]
		Always,
		[Token(Token = "0x400054F")]
		OnlyIfNeeded,
		[Token(Token = "0x4000550")]
		WhenDragging
	}

	[Token(Token = "0x2000099")]
	public delegate void OnDragNotification();

	[Token(Token = "0x400051E")]
	public static BetterList<UIScrollView> list;

	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0x20")]
	public Movement movement;

	[Token(Token = "0x4000520")]
	[FieldOffset(Offset = "0x24")]
	public DragEffect dragEffect;

	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x28")]
	public bool restrictWithinPanel;

	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x29")]
	public bool disableDragIfFits;

	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x2A")]
	public bool smoothDragStart;

	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x2B")]
	public bool iOSDragEmulation;

	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0x2C")]
	public float scrollWheelFactor;

	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0x30")]
	public float momentumAmount;

	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x34")]
	public float dampenStrength;

	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x38")]
	public bool doNotChangeScrollbarAlpha;

	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0x40")]
	public UIProgressBar horizontalScrollBar;

	[Token(Token = "0x400052A")]
	[FieldOffset(Offset = "0x48")]
	public UIProgressBar verticalScrollBar;

	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x50")]
	public ShowCondition showScrollBars;

	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 customMovement;

	[Token(Token = "0x400052D")]
	[FieldOffset(Offset = "0x5C")]
	public UIWidget.Pivot contentPivot;

	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x60")]
	public OnDragNotification onDragStarted;

	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x68")]
	public OnDragNotification onDragFinished;

	[Token(Token = "0x4000530")]
	[FieldOffset(Offset = "0x70")]
	public OnDragNotification onMomentumMove;

	[Token(Token = "0x4000531")]
	[FieldOffset(Offset = "0x78")]
	public OnDragNotification onStoppedMoving;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000532")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 scale;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x4000533")]
	[FieldOffset(Offset = "0x8C")]
	private Vector2 relativePositionOnReset;

	[Token(Token = "0x4000534")]
	[FieldOffset(Offset = "0x98")]
	protected Transform mTrans;

	[Token(Token = "0x4000535")]
	[FieldOffset(Offset = "0xA0")]
	protected UIPanel mPanel;

	[Token(Token = "0x4000536")]
	[FieldOffset(Offset = "0xA8")]
	protected Plane mPlane;

	[Token(Token = "0x4000537")]
	[FieldOffset(Offset = "0xB8")]
	protected Vector3 mLastPos;

	[Token(Token = "0x4000538")]
	[FieldOffset(Offset = "0xC4")]
	protected bool mPressed;

	[Token(Token = "0x4000539")]
	[FieldOffset(Offset = "0xC8")]
	protected Vector3 mMomentum;

	[Token(Token = "0x400053A")]
	[FieldOffset(Offset = "0xD4")]
	protected float mScroll;

	[Token(Token = "0x400053B")]
	[FieldOffset(Offset = "0xD8")]
	protected Bounds mBounds;

	[Token(Token = "0x400053C")]
	[FieldOffset(Offset = "0xF0")]
	protected bool mCalculatedBounds;

	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0xF1")]
	protected bool mShouldMove;

	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0xF2")]
	protected bool mIgnoreCallbacks;

	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0xF4")]
	protected int mDragID;

	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0xF8")]
	protected Vector2 mDragStartOffset;

	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0x100")]
	protected bool mDragStarted;

	[NonSerialized]
	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x101")]
	private bool mStarted;

	[HideInInspector]
	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x108")]
	public UICenterOnChild centerOnChild;

	[Token(Token = "0x1700005B")]
	public UIPanel panel
	{
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x40DAB0", Offset = "0x40C8B0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005C")]
	public bool isDragging
	{
		[Token(Token = "0x600051A")]
		[Address(RVA = "0xBE9860", Offset = "0xBE8660", Length = "0x14")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700005D")]
	public virtual Bounds bounds
	{
		[Token(Token = "0x600051B")]
		[Address(RVA = "0xBE9880", Offset = "0xBE8680", Length = "0xE9")]
		get
		{
			return default(Bounds);
		}
	}

	[Token(Token = "0x1700005E")]
	public bool canMoveHorizontally
	{
		[Token(Token = "0x600051C")]
		[Address(RVA = "0xBE9970", Offset = "0xBE8770", Length = "0x24")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700005F")]
	public bool canMoveVertically
	{
		[Token(Token = "0x600051D")]
		[Address(RVA = "0xBE99A0", Offset = "0xBE87A0", Length = "0x25")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000060")]
	public virtual bool shouldMoveHorizontally
	{
		[Token(Token = "0x600051E")]
		[Address(RVA = "0xBE99D0", Offset = "0xBE87D0", Length = "0xEA")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000061")]
	public virtual bool shouldMoveVertically
	{
		[Token(Token = "0x600051F")]
		[Address(RVA = "0xBE9AC0", Offset = "0xBE88C0", Length = "0xE6")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000062")]
	protected virtual bool shouldMove
	{
		[Token(Token = "0x6000520")]
		[Address(RVA = "0xBE9BB0", Offset = "0xBE89B0", Length = "0x380")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000063")]
	public Vector3 currentMomentum
	{
		[Token(Token = "0x6000521")]
		[Address(RVA = "0xBE9F40", Offset = "0xBE8D40", Length = "0x19")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000522")]
		[Address(RVA = "0xBE9F60", Offset = "0xBE8D60", Length = "0x1D")]
		set
		{
		}
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0xBE9F80", Offset = "0xBE8D80", Length = "0x34F")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0xBEA2D0", Offset = "0xBE90D0", Length = "0x102")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0xBEA3E0", Offset = "0xBE91E0", Length = "0x9B")]
	private void Start()
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0xBEA480", Offset = "0xBE9280", Length = "0x2FA")]
	private void CheckScrollbars()
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0xBEA780", Offset = "0xBE9580", Length = "0x82")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0xBEA810", Offset = "0xBE9610", Length = "0x1E")]
	public bool RestrictWithinBounds(bool instant)
	{
		return false;
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0xBEA830", Offset = "0xBE9630", Length = "0x36F")]
	public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
	{
		return false;
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0xBEABA0", Offset = "0xBE99A0", Length = "0xF2")]
	public void DisableSpring()
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0xBEACA0", Offset = "0xBE9AA0", Length = "0x13")]
	public void UpdateScrollbars()
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0xBEACC0", Offset = "0xBE9AC0", Length = "0x6C0")]
	public virtual void UpdateScrollbars(bool recalculateBounds)
	{
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0xBEB390", Offset = "0xBEA190", Length = "0x3B4")]
	protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
	{
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0xBEB750", Offset = "0xBEA550", Length = "0x618")]
	public virtual void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0xBEBD70", Offset = "0xBEAB70", Length = "0x8")]
	public void InvalidateBounds()
	{
	}

	[ContextMenu("Reset Clipping Position")]
	[Token(Token = "0x6000530")]
	[Address(RVA = "0xBEBD80", Offset = "0xBEAB80", Length = "0xC9")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0xBEBE50", Offset = "0xBEAC50", Length = "0x393")]
	public void UpdatePosition()
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0xBEC1F0", Offset = "0xBEAFF0", Length = "0x233")]
	public void OnScrollBar()
	{
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0xBEC430", Offset = "0xBEB230", Length = "0x1F4")]
	public virtual void MoveRelative(Vector3 relative)
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0xBEC630", Offset = "0xBEB430", Length = "0x21B")]
	public void MoveAbsolute(Vector3 absolute)
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0xBEC850", Offset = "0xBEB650", Length = "0x5C4")]
	public void Press(bool pressed)
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0xBECE20", Offset = "0xBEBC20", Length = "0x9CB")]
	public void Drag()
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0xBED7F0", Offset = "0xBEC5F0", Length = "0x1B0")]
	public void Scroll(float delta)
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0xBED9B0", Offset = "0xBEC7B0", Length = "0xB71")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0xBEE530", Offset = "0xBED330", Length = "0x196")]
	public UIScrollView()
	{
	}
}
