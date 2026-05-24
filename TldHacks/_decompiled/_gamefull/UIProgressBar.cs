using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/NGUI Progress Bar")]
[Token(Token = "0x200008F")]
public class UIProgressBar : UIWidgetContainer
{
	[Token(Token = "0x2000090")]
	public enum FillDirection
	{
		[Token(Token = "0x400050F")]
		LeftToRight,
		[Token(Token = "0x4000510")]
		RightToLeft,
		[Token(Token = "0x4000511")]
		BottomToTop,
		[Token(Token = "0x4000512")]
		TopToBottom
	}

	[Token(Token = "0x2000091")]
	public delegate void OnDragFinished();

	[Token(Token = "0x40004FF")]
	public static UIProgressBar current;

	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0x20")]
	public OnDragFinished onDragFinished;

	[Token(Token = "0x4000501")]
	[FieldOffset(Offset = "0x28")]
	public Transform thumb;

	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0x30")]
	public float thumbOffset;

	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 thumbLimits;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x40")]
	protected UIWidget mBG;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x48")]
	protected UIWidget mFG;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0x50")]
	protected float mValue;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x54")]
	protected FillDirection mFill;

	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x58")]
	protected Transform mTrans;

	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x60")]
	protected bool mIsDirty;

	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x68")]
	protected Camera mCam;

	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x70")]
	protected float mOffset;

	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x74")]
	public int numberOfSteps;

	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x78")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x1700004F")]
	public Transform cachedTransform
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xBE42D0", Offset = "0xBE30D0", Length = "0x135")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000050")]
	public Camera cachedCamera
	{
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xBE4410", Offset = "0xBE3210", Length = "0x17A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000051")]
	public UIWidget foregroundWidget
	{
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xBE4590", Offset = "0xBE3390", Length = "0x16F")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public UIWidget backgroundWidget
	{
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xBE4700", Offset = "0xBE3500", Length = "0x16F")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public FillDirection fillDirection
	{
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x667470", Offset = "0x666270", Length = "0x4")]
		get
		{
			return default(FillDirection);
		}
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xBE4870", Offset = "0xBE3670", Length = "0x1A")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public float value
	{
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xBE4890", Offset = "0xBE3690", Length = "0x47")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xBE48E0", Offset = "0xBE36E0", Length = "0x293")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public float alpha
	{
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xBE4B80", Offset = "0xBE3980", Length = "0x19C")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xBE4D20", Offset = "0xBE3B20", Length = "0x939")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	protected bool isHorizontal
	{
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xBE5660", Offset = "0xBE4460", Length = "0x11")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000057")]
	protected bool isInverted
	{
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xBE5680", Offset = "0xBE4480", Length = "0x10")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x4B4350", Offset = "0x4B3150", Length = "0x6")]
	public float GetRawValue()
	{
		return 0f;
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0xBE5690", Offset = "0xBE4490", Length = "0x2C2")]
	protected void Start()
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void Upgrade()
	{
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnStart()
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0xBE5960", Offset = "0xBE4760", Length = "0x18")]
	protected void Update()
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0xBE5980", Offset = "0xBE4780", Length = "0xF5")]
	protected void OnValidate()
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0xBE5A80", Offset = "0xBE4880", Length = "0x763")]
	protected float ScreenToValue(Vector2 screenPos)
	{
		return 0f;
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0xBE61F0", Offset = "0xBE4FF0", Length = "0x1D9")]
	protected virtual float LocalToValue(Vector2 localPos)
	{
		return 0f;
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0xBE63D0", Offset = "0xBE51D0", Length = "0xEEB")]
	public virtual void ForceUpdate()
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0xBE72C0", Offset = "0xBE60C0", Length = "0x5D1")]
	public void SetThumbPosition(Vector3 worldPos)
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x6A27D0", Offset = "0x6A15D0", Length = "0x91")]
	private Vector3 LerpWithoutClamp(Vector3 A, Vector3 B, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0xBE78A0", Offset = "0xBE66A0", Length = "0xF8")]
	public UIProgressBar()
	{
	}
}
