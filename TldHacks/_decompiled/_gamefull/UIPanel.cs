using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Panel")]
[Token(Token = "0x200011A")]
public class UIPanel : UIRect
{
	[Token(Token = "0x200011B")]
	public enum RenderQueue
	{
		[Token(Token = "0x40008E0")]
		Automatic,
		[Token(Token = "0x40008E1")]
		StartAt,
		[Token(Token = "0x40008E2")]
		Explicit
	}

	[Token(Token = "0x200011C")]
	public delegate void OnGeometryUpdated();

	[Token(Token = "0x200011D")]
	public delegate void OnClippingMoved(UIPanel panel);

	[Token(Token = "0x40008B3")]
	public static List<UIPanel> list;

	[Token(Token = "0x40008B4")]
	[FieldOffset(Offset = "0xA0")]
	public OnGeometryUpdated onGeometryUpdated;

	[Token(Token = "0x40008B5")]
	[FieldOffset(Offset = "0xA8")]
	public bool showInPanelTool;

	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0xA9")]
	public bool generateNormals;

	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0xAA")]
	public bool widgetsAreStatic;

	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0xAB")]
	public bool cullWhileDragging;

	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0xAC")]
	public bool alwaysOnScreen;

	[Token(Token = "0x40008BA")]
	[FieldOffset(Offset = "0xAD")]
	public bool anchorOffset;

	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0xAE")]
	public bool softBorderPadding;

	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0xB0")]
	public RenderQueue renderQueue;

	[Token(Token = "0x40008BD")]
	[FieldOffset(Offset = "0xB4")]
	public int startingRenderQueue;

	[NonSerialized]
	[Token(Token = "0x40008BE")]
	[FieldOffset(Offset = "0xB8")]
	public List<UIWidget> widgets;

	[NonSerialized]
	[Token(Token = "0x40008BF")]
	[FieldOffset(Offset = "0xC0")]
	public List<UIDrawCall> drawCalls;

	[NonSerialized]
	[Token(Token = "0x40008C0")]
	[FieldOffset(Offset = "0xC8")]
	public Matrix4x4 worldToLocal;

	[NonSerialized]
	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0x108")]
	public Vector4 drawCallClipRange;

	[Token(Token = "0x40008C2")]
	[FieldOffset(Offset = "0x118")]
	public OnClippingMoved onClipMove;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0x120")]
	private Texture2D mClipTexture;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008C4")]
	[FieldOffset(Offset = "0x128")]
	private float mAlpha;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008C5")]
	[FieldOffset(Offset = "0x12C")]
	private UIDrawCall.Clipping mClipping;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0x130")]
	private Vector4 mClipRange;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0x140")]
	private Vector2 mClipSoftness;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x148")]
	private int mDepth;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x14C")]
	private int mSortingOrder;

	[Token(Token = "0x40008CA")]
	[FieldOffset(Offset = "0x150")]
	private bool mRebuild;

	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x151")]
	private bool mResized;

	[SerializeField]
	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x154")]
	private Vector2 mClipOffset;

	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x15C")]
	private float mCullTime;

	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x160")]
	private float mUpdateTime;

	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x164")]
	private int mMatrixFrame;

	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x168")]
	private int mAlphaFrameID;

	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0x16C")]
	private int mLayer;

	[Token(Token = "0x40008D2")]
	private static float[] mTemp;

	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x170")]
	private Vector2 mMin;

	[Token(Token = "0x40008D4")]
	[FieldOffset(Offset = "0x178")]
	private Vector2 mMax;

	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x180")]
	private bool mHalfPixelOffset;

	[Token(Token = "0x40008D6")]
	[FieldOffset(Offset = "0x181")]
	private bool mSortWidgets;

	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x182")]
	private bool mUpdateScroll;

	[Min(0f)]
	[Token(Token = "0x40008D8")]
	[FieldOffset(Offset = "0x184")]
	public int m_MaxWidgetsPerUpdateSwitch;

	[Token(Token = "0x40008D9")]
	[FieldOffset(Offset = "0x188")]
	private int m_LastWidgetUpdateIndex;

	[Token(Token = "0x40008DA")]
	[FieldOffset(Offset = "0x190")]
	private UIPanel mParentPanel;

	[Token(Token = "0x40008DB")]
	private static Vector3[] mCorners;

	[Token(Token = "0x40008DC")]
	private static int mUpdateFrame;

	[Token(Token = "0x40008DD")]
	[FieldOffset(Offset = "0x198")]
	private UIDrawCall.OnRenderCallback mOnRender;

	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x1A0")]
	private bool mForced;

	[Token(Token = "0x17000165")]
	public static int nextUnusedDepth
	{
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1289AC0", Offset = "0x12888C0", Length = "0x126")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000166")]
	public override bool canBeAnchored
	{
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x1289BF0", Offset = "0x12889F0", Length = "0xB")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000167")]
	public override float alpha
	{
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xC94D40", Offset = "0xC93B40", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1289C00", Offset = "0x1288A00", Length = "0x4D")]
		set
		{
		}
	}

	[Token(Token = "0x17000168")]
	public int depth
	{
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1289C50", Offset = "0x1288A50", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x1289C60", Offset = "0x1288A60", Length = "0xE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000169")]
	public int sortingOrder
	{
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1289D50", Offset = "0x1288B50", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x1289D60", Offset = "0x1288B60", Length = "0x16")]
		set
		{
		}
	}

	[Token(Token = "0x1700016A")]
	public float width
	{
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x128A010", Offset = "0x1288E10", Length = "0x1B")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700016B")]
	public float height
	{
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x128A030", Offset = "0x1288E30", Length = "0x1B")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700016C")]
	public bool halfPixelOffset
	{
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x128A050", Offset = "0x1288E50", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700016D")]
	public bool usedForUI
	{
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x128A060", Offset = "0x1288E60", Length = "0x101")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700016E")]
	public Vector3 drawCallOffset
	{
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x128A170", Offset = "0x1288F70", Length = "0x2B5")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700016F")]
	public UIDrawCall.Clipping clipping
	{
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x128A430", Offset = "0x1289230", Length = "0x7")]
		get
		{
			return default(UIDrawCall.Clipping);
		}
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x128A440", Offset = "0x1289240", Length = "0x20")]
		set
		{
		}
	}

	[Token(Token = "0x17000170")]
	public UIPanel parentPanel
	{
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xFB3330", Offset = "0xFB2130", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000171")]
	public int clipCount
	{
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x128A460", Offset = "0x1289260", Length = "0xE7")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000172")]
	public bool hasClipping
	{
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x128A550", Offset = "0x1289350", Length = "0x15")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000173")]
	public bool hasCumulativeClipping
	{
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x128A570", Offset = "0x1289370", Length = "0x15")]
		get
		{
			return false;
		}
	}

	[Obsolete("Use 'hasClipping' or 'hasCumulativeClipping' instead")]
	[Token(Token = "0x17000174")]
	public bool clipsChildren
	{
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x128A570", Offset = "0x1289370", Length = "0x15")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000175")]
	public Vector2 clipOffset
	{
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x128A590", Offset = "0x1289390", Length = "0x19")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x128A5B0", Offset = "0x12893B0", Length = "0x83")]
		set
		{
		}
	}

	[Token(Token = "0x17000176")]
	public Texture2D clipTexture
	{
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x128A960", Offset = "0x1289760", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x128A970", Offset = "0x1289770", Length = "0x166")]
		set
		{
		}
	}

	[Obsolete("Use 'finalClipRegion' or 'baseClipRegion' instead")]
	[Token(Token = "0x17000177")]
	public Vector4 clipRange
	{
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x128AAE0", Offset = "0x12898E0", Length = "0xE")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x128AAF0", Offset = "0x12898F0", Length = "0x1E")]
		set
		{
		}
	}

	[Token(Token = "0x17000178")]
	public Vector4 baseClipRegion
	{
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x128AAE0", Offset = "0x12898E0", Length = "0xE")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x128AB10", Offset = "0x1289910", Length = "0x1F7")]
		set
		{
		}
	}

	[Token(Token = "0x17000179")]
	public Vector4 finalClipRegion
	{
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x128AD10", Offset = "0x1289B10", Length = "0x7C")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x1700017A")]
	public Vector2 clipSoftness
	{
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x128AD90", Offset = "0x1289B90", Length = "0x19")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x128ADB0", Offset = "0x1289BB0", Length = "0x46")]
		set
		{
		}
	}

	[Token(Token = "0x1700017B")]
	public override Vector3[] localCorners
	{
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x128AE00", Offset = "0x1289C00", Length = "0x38F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700017C")]
	public override Vector3[] worldCorners
	{
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x128B190", Offset = "0x1289F90", Length = "0x892")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x1289D80", Offset = "0x1288B80", Length = "0x288")]
	public static int CompareFunc(UIPanel a, UIPanel b)
	{
		return 0;
	}

	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x128A640", Offset = "0x1289440", Length = "0x311")]
	private void InvalidateClipping()
	{
	}

	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x128BA30", Offset = "0x128A830", Length = "0x8BD")]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x6000A58")]
	[Address(RVA = "0x128C2F0", Offset = "0x128B0F0", Length = "0x12")]
	public override void Invalidate(bool includeChildren)
	{
	}

	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x128C310", Offset = "0x128B110", Length = "0x14C")]
	public override float CalculateFinalAlpha(int frameID)
	{
		return 0f;
	}

	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x128C460", Offset = "0x128B260", Length = "0x4F8")]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x128C960", Offset = "0x128B760", Length = "0x64E")]
	public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		return false;
	}

	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x128CFB0", Offset = "0x128BDB0", Length = "0xFF")]
	public bool IsVisible(Vector3 worldPos)
	{
		return false;
	}

	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x128D0B0", Offset = "0x128BEB0", Length = "0x1F4")]
	public bool IsVisible(UIWidget w)
	{
		return false;
	}

	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x128D2B0", Offset = "0x128C0B0", Length = "0x2AA")]
	public bool Affects(UIWidget w)
	{
		return false;
	}

	[ContextMenu("Force Refresh")]
	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x128D560", Offset = "0x128C360", Length = "0x8")]
	public void RebuildAllDrawCalls()
	{
	}

	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x128D570", Offset = "0x128C370", Length = "0x1AA")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x128D720", Offset = "0x128C520", Length = "0x240")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x128D970", Offset = "0x128C770", Length = "0x19C")]
	private void FindParent()
	{
	}

	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x128DB10", Offset = "0x128C910", Length = "0x1F")]
	public override void ParentHasChanged()
	{
	}

	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x128DB30", Offset = "0x128C930", Length = "0xAB")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x128DBE0", Offset = "0x128C9E0", Length = "0x70")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x128DC50", Offset = "0x128CA50", Length = "0x52A")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x128E180", Offset = "0x128CF80", Length = "0x3A5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000A68")]
	[Address(RVA = "0x128E530", Offset = "0x128D330", Length = "0x1E4")]
	private void UpdateTransformMatrix()
	{
	}

	[Token(Token = "0x6000A69")]
	[Address(RVA = "0x128E720", Offset = "0x128D520", Length = "0xC60")]
	protected override void OnAnchor()
	{
	}

	[Token(Token = "0x6000A6A")]
	[Address(RVA = "0x128F390", Offset = "0x128E190", Length = "0x325")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000A6B")]
	[Address(RVA = "0x128F6C0", Offset = "0x128E4C0", Length = "0x38B")]
	private void UpdateSelf()
	{
	}

	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x128FA50", Offset = "0x128E850", Length = "0xA7")]
	public void SortWidgets()
	{
	}

	[Token(Token = "0x6000A6D")]
	[Address(RVA = "0x128FB00", Offset = "0x128E900", Length = "0xE02")]
	private void FillAllDrawCalls()
	{
	}

	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0x1290910", Offset = "0x128F710", Length = "0x547")]
	private bool FillDrawCall(UIDrawCall dc)
	{
		return false;
	}

	[Token(Token = "0x6000A6F")]
	[Address(RVA = "0x1290E60", Offset = "0x128FC60", Length = "0xB37")]
	private void UpdateDrawCalls()
	{
	}

	[Token(Token = "0x6000A70")]
	[Address(RVA = "0x12919A0", Offset = "0x12907A0", Length = "0x45A")]
	private void UpdateLayers()
	{
	}

	[Token(Token = "0x6000A71")]
	[Address(RVA = "0x1291E00", Offset = "0x1290C00", Length = "0xA")]
	private void CalculateWidgetsToUpdate(out int start, out int end, int count)
	{
		start = default(int);
		end = default(int);
	}

	[Token(Token = "0x6000A72")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void StoreLastUpdatedIndex(int end, int count)
	{
	}

	[Token(Token = "0x6000A73")]
	[Address(RVA = "0x1291E10", Offset = "0x1290C10", Length = "0x3B9")]
	private void UpdateWidgets()
	{
	}

	[Token(Token = "0x6000A74")]
	[Address(RVA = "0x12921D0", Offset = "0x1290FD0", Length = "0x401")]
	public UIDrawCall FindDrawCall(UIWidget w)
	{
		return null;
	}

	[Token(Token = "0x6000A75")]
	[Address(RVA = "0x12925E0", Offset = "0x12913E0", Length = "0x1BF")]
	public void AddWidget(UIWidget w)
	{
	}

	[Token(Token = "0x6000A76")]
	[Address(RVA = "0x12927A0", Offset = "0x12915A0", Length = "0x1AB")]
	public void RemoveWidget(UIWidget w)
	{
	}

	[Token(Token = "0x6000A77")]
	[Address(RVA = "0x1292950", Offset = "0x1291750", Length = "0x103")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000A78")]
	[Address(RVA = "0x1292A60", Offset = "0x1291860", Length = "0x18B")]
	public virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000A79")]
	[Address(RVA = "0x1292BF0", Offset = "0x12919F0", Length = "0x6AA")]
	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		return false;
	}

	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x12932A0", Offset = "0x12920A0", Length = "0x81")]
	public bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		return false;
	}

	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x1293330", Offset = "0x1292130", Length = "0x55")]
	public static UIPanel Find(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0x1293390", Offset = "0x1292190", Length = "0x62")]
	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x6000A7D")]
	[Address(RVA = "0x1293400", Offset = "0x1292200", Length = "0x340")]
	public static UIPanel Find(Transform trans, bool createIfMissing, int layer)
	{
		return null;
	}

	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x1293750", Offset = "0x1292550", Length = "0x1E3")]
	public Vector2 GetWindowSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x1293940", Offset = "0x1292740", Length = "0x72")]
	public Vector2 GetViewSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x12939C0", Offset = "0x12927C0", Length = "0x336")]
	public UIPanel()
	{
	}
}
