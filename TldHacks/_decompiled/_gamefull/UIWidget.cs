using System;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Widget")]
[Token(Token = "0x20000D6")]
public class UIWidget : UIRect
{
	[Token(Token = "0x20000D7")]
	public enum Pivot
	{
		[Token(Token = "0x40006EF")]
		TopLeft,
		[Token(Token = "0x40006F0")]
		Top,
		[Token(Token = "0x40006F1")]
		TopRight,
		[Token(Token = "0x40006F2")]
		Left,
		[Token(Token = "0x40006F3")]
		Center,
		[Token(Token = "0x40006F4")]
		Right,
		[Token(Token = "0x40006F5")]
		BottomLeft,
		[Token(Token = "0x40006F6")]
		Bottom,
		[Token(Token = "0x40006F7")]
		BottomRight
	}

	[Token(Token = "0x20000D8")]
	public delegate void OnDimensionsChanged();

	[Token(Token = "0x20000D9")]
	public delegate void OnPostFillCallback(UIWidget widget, int bufferOffset, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols);

	[Token(Token = "0x20000DA")]
	public enum AspectRatioSource
	{
		[Token(Token = "0x40006F9")]
		Free,
		[Token(Token = "0x40006FA")]
		BasedOnWidth,
		[Token(Token = "0x40006FB")]
		BasedOnHeight
	}

	[Token(Token = "0x20000DB")]
	public delegate bool HitCheck(Vector3 worldPos);

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0xA0")]
	protected Color mColor;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0xB0")]
	protected Pivot mPivot;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0xB4")]
	protected int mWidth;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006D3")]
	[FieldOffset(Offset = "0xB8")]
	protected int mHeight;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40006D4")]
	[FieldOffset(Offset = "0xBC")]
	protected int mDepth;

	[Token(Token = "0x40006D5")]
	[FieldOffset(Offset = "0xC0")]
	public OnDimensionsChanged onChange;

	[Token(Token = "0x40006D6")]
	[FieldOffset(Offset = "0xC8")]
	public OnPostFillCallback onPostFill;

	[Token(Token = "0x40006D7")]
	[FieldOffset(Offset = "0xD0")]
	public UIDrawCall.OnRenderCallback mOnRender;

	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0xD8")]
	public bool autoResizeBoxCollider;

	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0xD9")]
	public bool hideIfOffScreen;

	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0xDC")]
	public AspectRatioSource keepAspectRatio;

	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0xE0")]
	public float aspectRatio;

	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0xE8")]
	public HitCheck hitCheck;

	[NonSerialized]
	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0xF0")]
	public UIPanel panel;

	[NonSerialized]
	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0xF8")]
	public UIGeometry geometry;

	[NonSerialized]
	[Token(Token = "0x40006DF")]
	[FieldOffset(Offset = "0x100")]
	public bool fillGeometry;

	[NonSerialized]
	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x101")]
	protected bool mPlayMode;

	[NonSerialized]
	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x104")]
	protected Vector4 mDrawRegion;

	[NonSerialized]
	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0x114")]
	private Matrix4x4 mLocalToPanel;

	[NonSerialized]
	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x154")]
	private bool mIsVisibleByAlpha;

	[NonSerialized]
	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x155")]
	private bool mIsVisibleByPanel;

	[NonSerialized]
	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x156")]
	private bool mIsInFront;

	[NonSerialized]
	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x158")]
	private float mLastAlpha;

	[NonSerialized]
	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x15C")]
	private bool mMoved;

	[NonSerialized]
	[Token(Token = "0x40006E8")]
	[FieldOffset(Offset = "0x160")]
	public UIDrawCall drawCall;

	[NonSerialized]
	[Token(Token = "0x40006E9")]
	[FieldOffset(Offset = "0x168")]
	protected Vector3[] mCorners;

	[NonSerialized]
	[Token(Token = "0x40006EA")]
	[FieldOffset(Offset = "0x170")]
	private int mAlphaFrameID;

	[Token(Token = "0x40006EB")]
	[FieldOffset(Offset = "0x174")]
	private int mMatrixFrame;

	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0x178")]
	private Vector3 mOldV0;

	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x184")]
	private Vector3 mOldV1;

	[Token(Token = "0x170000BA")]
	public UIDrawCall.OnRenderCallback onRender
	{
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x502680", Offset = "0x501480", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x111C0E0", Offset = "0x111AEE0", Length = "0x377")]
		set
		{
		}
	}

	[Token(Token = "0x170000BB")]
	public Vector4 drawRegion
	{
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x111C460", Offset = "0x111B260", Length = "0xE")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x111C470", Offset = "0x111B270", Length = "0xAC")]
		set
		{
		}
	}

	[Token(Token = "0x170000BC")]
	public Vector2 pivotOffset
	{
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x111C520", Offset = "0x111B320", Length = "0xD")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170000BD")]
	public int width
	{
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x5EFD20", Offset = "0x5EEB20", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x111C530", Offset = "0x111B330", Length = "0x3CA")]
		set
		{
		}
	}

	[Token(Token = "0x170000BE")]
	public int height
	{
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x5DD350", Offset = "0x5DC150", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x111C900", Offset = "0x111B700", Length = "0x3BA")]
		set
		{
		}
	}

	[Token(Token = "0x170000BF")]
	public Color color
	{
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x111CCC0", Offset = "0x111BAC0", Length = "0xE")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x111CCD0", Offset = "0x111BAD0", Length = "0x9F")]
		set
		{
		}
	}

	[Token(Token = "0x170000C0")]
	public override float alpha
	{
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x111CD70", Offset = "0x111BB70", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x111CD80", Offset = "0x111BB80", Length = "0x2B")]
		set
		{
		}
	}

	[Token(Token = "0x170000C1")]
	public bool isVisible
	{
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x111CDB0", Offset = "0x111BBB0", Length = "0x82")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000C2")]
	public bool hasVertices
	{
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x111CE40", Offset = "0x111BC40", Length = "0x2F")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000C3")]
	public Pivot rawPivot
	{
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x5DEE90", Offset = "0x5DDC90", Length = "0x7")]
		get
		{
			return default(Pivot);
		}
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x111CE70", Offset = "0x111BC70", Length = "0x46")]
		set
		{
		}
	}

	[Token(Token = "0x170000C4")]
	public Pivot pivot
	{
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x5DEE90", Offset = "0x5DDC90", Length = "0x7")]
		get
		{
			return default(Pivot);
		}
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x111CEC0", Offset = "0x111BCC0", Length = "0x45B")]
		set
		{
		}
	}

	[Token(Token = "0x170000C5")]
	public int depth
	{
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xA73F80", Offset = "0xA72D80", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x111D320", Offset = "0x111C120", Length = "0x24F")]
		set
		{
		}
	}

	[Token(Token = "0x170000C6")]
	public int raycastDepth
	{
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x111D570", Offset = "0x111C370", Length = "0x19D")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170000C7")]
	public override Vector3[] localCorners
	{
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x111D710", Offset = "0x111C510", Length = "0x163")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C8")]
	public virtual Vector2 localSize
	{
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x111D880", Offset = "0x111C680", Length = "0x5B")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170000C9")]
	public Vector3 localCenter
	{
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x111D8E0", Offset = "0x111C6E0", Length = "0xC9")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170000CA")]
	public override Vector3[] worldCorners
	{
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x111D9B0", Offset = "0x111C7B0", Length = "0x20E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CB")]
	public Vector3 worldCenter
	{
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x111DBC0", Offset = "0x111C9C0", Length = "0x1A6")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170000CC")]
	public virtual Vector4 drawingDimensions
	{
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x111DD70", Offset = "0x111CB70", Length = "0x17B")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x170000CD")]
	public virtual Material material
	{
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x111DEF0", Offset = "0x111CCF0", Length = "0x8E")]
		set
		{
		}
	}

	[Token(Token = "0x170000CE")]
	public virtual Texture mainTexture
	{
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x111DF80", Offset = "0x111CD80", Length = "0xE4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x111E070", Offset = "0x111CE70", Length = "0x8E")]
		set
		{
		}
	}

	[Token(Token = "0x170000CF")]
	public virtual Shader shader
	{
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x111E100", Offset = "0x111CF00", Length = "0xE4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x111E1F0", Offset = "0x111CFF0", Length = "0x8E")]
		set
		{
		}
	}

	[Obsolete("There is no relative scale anymore. Widgets now have width and height instead")]
	[Token(Token = "0x170000D0")]
	public Vector2 relativeSize
	{
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x4F3490", Offset = "0x4F2290", Length = "0x4A")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170000D1")]
	public bool hasBoxCollider
	{
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x111E280", Offset = "0x111D080", Length = "0x217")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000D2")]
	public virtual int minWidth
	{
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170000D3")]
	public virtual int minHeight
	{
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170000D4")]
	public virtual Vector4 border
	{
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1123120", Offset = "0x1121F20", Length = "0x47")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		set
		{
		}
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x111E4A0", Offset = "0x111D2A0", Length = "0xCC")]
	public void SetDimensions(int w, int h)
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x111E570", Offset = "0x111D370", Length = "0x41B")]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x111E990", Offset = "0x111D790", Length = "0x3B")]
	public override float CalculateFinalAlpha(int frameID)
	{
		return 0f;
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x111E9D0", Offset = "0x111D7D0", Length = "0x157")]
	protected void UpdateFinalAlpha(int frameID)
	{
	}

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x111EB30", Offset = "0x111D930", Length = "0x273")]
	public override void Invalidate(bool includeChildren)
	{
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x111EDB0", Offset = "0x111DBB0", Length = "0x117")]
	public float CalculateCumulativeAlpha(int frameID)
	{
		return 0f;
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x111EED0", Offset = "0x111DCD0", Length = "0x6C3")]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x111F5A0", Offset = "0x111E3A0", Length = "0xBD")]
	public void ResizeCollider()
	{
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x111F660", Offset = "0x111E460", Length = "0xA2")]
	public static int FullCompareFunc(UIWidget left, UIWidget right)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x111F710", Offset = "0x111E510", Length = "0x2DB")]
	public static int PanelCompareFunc(UIWidget left, UIWidget right)
	{
		return 0;
	}

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x111F9F0", Offset = "0x111E7F0", Length = "0x32")]
	public Bounds CalculateBounds()
	{
		return default(Bounds);
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x111FA30", Offset = "0x111E830", Length = "0x7DF")]
	public Bounds CalculateBounds(Transform relativeParent)
	{
		return default(Bounds);
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x1120210", Offset = "0x111F010", Length = "0x122")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x1120340", Offset = "0x111F140", Length = "0x1A5")]
	public void RemoveFromPanel()
	{
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x11204F0", Offset = "0x111F2F0", Length = "0x271")]
	public virtual void MarkAsChanged()
	{
	}

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x1120770", Offset = "0x111F570", Length = "0x296")]
	public UIPanel CreatePanel()
	{
		return null;
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x1120A10", Offset = "0x111F810", Length = "0x1B1")]
	public void CheckLayer()
	{
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x1120BD0", Offset = "0x111F9D0", Length = "0x23F")]
	public override void ParentHasChanged()
	{
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x1120E10", Offset = "0x111FC10", Length = "0xE3")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x1120F00", Offset = "0x111FD00", Length = "0x214")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x1121120", Offset = "0x111FF20", Length = "0x22F")]
	protected virtual void UpgradeFrom265()
	{
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x1121350", Offset = "0x1120150", Length = "0x7")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x1121360", Offset = "0x1120160", Length = "0xEC1")]
	protected override void OnAnchor()
	{
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x1122230", Offset = "0x1121030", Length = "0xD7")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x1122310", Offset = "0x1121110", Length = "0x16")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x1122330", Offset = "0x1121130", Length = "0x1F")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x1122350", Offset = "0x1121150", Length = "0x7")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x1122360", Offset = "0x1121160", Length = "0x28")]
	public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel)
	{
		return false;
	}

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x1122390", Offset = "0x1121190", Length = "0x4F1")]
	public bool UpdateTransform(int frame)
	{
		return false;
	}

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x1122890", Offset = "0x1121690", Length = "0x506")]
	public bool UpdateGeometry(int frame)
	{
		return false;
	}

	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x1122DA0", Offset = "0x1121BA0", Length = "0x2A")]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x1122DD0", Offset = "0x1121BD0", Length = "0x34C")]
	public virtual void MakePixelPerfect()
	{
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x1123170", Offset = "0x1121F70", Length = "0x1C4")]
	public UIWidget()
	{
	}
}
