using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000D2")]
public abstract class UIRect : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000D3")]
	public class AnchorPoint
	{
		[Token(Token = "0x40006C1")]
		[FieldOffset(Offset = "0x10")]
		public Transform target;

		[Token(Token = "0x40006C2")]
		[FieldOffset(Offset = "0x18")]
		public float relative;

		[Token(Token = "0x40006C3")]
		[FieldOffset(Offset = "0x1C")]
		public int absolute;

		[NonSerialized]
		[Token(Token = "0x40006C4")]
		[FieldOffset(Offset = "0x20")]
		public UIRect rect;

		[NonSerialized]
		[Token(Token = "0x40006C5")]
		[FieldOffset(Offset = "0x28")]
		public Camera targetCam;

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public AnchorPoint()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x4A7A50", Offset = "0x4A6850", Length = "0x6")]
		public AnchorPoint(float relative)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x111B210", Offset = "0x111A010", Length = "0x27")]
		public void Set(float relative, float absolute)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x111B240", Offset = "0x111A040", Length = "0x71")]
		public void Set(Transform target, float relative, float absolute)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x111B2C0", Offset = "0x111A0C0", Length = "0xAB")]
		public void SetToNearest(float abs0, float abs1, float abs2)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x111B370", Offset = "0x111A170", Length = "0xC7")]
		public void SetToNearest(float rel0, float rel1, float rel2, float abs0, float abs1, float abs2)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x111B440", Offset = "0x111A240", Length = "0x3A7")]
		public void SetHorizontal(Transform parent, float localPos)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x111B7F0", Offset = "0x111A5F0", Length = "0x39D")]
		public void SetVertical(Transform parent, float localPos)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x111BB90", Offset = "0x111A990", Length = "0x426")]
		public Vector3[] GetSides(Transform relativeTo)
		{
			return null;
		}
	}

	[Token(Token = "0x20000D4")]
	public enum AnchorUpdate
	{
		[Token(Token = "0x40006C7")]
		OnEnable,
		[Token(Token = "0x40006C8")]
		OnUpdate,
		[Token(Token = "0x40006C9")]
		OnStart
	}

	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x20")]
	public AnchorPoint leftAnchor;

	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x28")]
	public AnchorPoint rightAnchor;

	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0x30")]
	public AnchorPoint bottomAnchor;

	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x38")]
	public AnchorPoint topAnchor;

	[Token(Token = "0x40006A9")]
	[FieldOffset(Offset = "0x40")]
	public AnchorUpdate updateAnchors;

	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0x48")]
	protected GameObject mGo;

	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0x50")]
	protected Transform mTrans;

	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0x58")]
	protected BetterList<UIRect> mChildren;

	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x60")]
	protected bool mChanged;

	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x61")]
	protected bool mStarted;

	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x62")]
	protected bool mParentFound;

	[NonSerialized]
	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x63")]
	private bool mUpdateAnchors;

	[NonSerialized]
	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x64")]
	private int mUpdateFrame;

	[NonSerialized]
	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x68")]
	private bool mAnchorsCached;

	[NonSerialized]
	[Token(Token = "0x40006B3")]
	[FieldOffset(Offset = "0x70")]
	private UIRoot mRoot;

	[NonSerialized]
	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x78")]
	private UIRect mParent;

	[NonSerialized]
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x80")]
	private bool mRootSet;

	[NonSerialized]
	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x88")]
	protected Camera mCam;

	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x90")]
	private bool m_HasLeftAnchor;

	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x91")]
	private bool m_HasRightAnchor;

	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x92")]
	private bool m_HasTopAnchor;

	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x93")]
	private bool m_HasBottomAnchor;

	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x94")]
	private bool m_HasLeftRect;

	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x95")]
	private bool m_HasRightRect;

	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x96")]
	private bool m_HasTopRect;

	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0x97")]
	private bool m_HasBottomRect;

	[NonSerialized]
	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x98")]
	public float finalAlpha;

	[Token(Token = "0x40006C0")]
	protected static Vector3[] mSides;

	[Token(Token = "0x170000AC")]
	public GameObject cachedGameObject
	{
		[Token(Token = "0x600076F")]
		[Address(RVA = "0xFA2D60", Offset = "0xFA1B60", Length = "0x135")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AD")]
	public Transform cachedTransform
	{
		[Token(Token = "0x6000770")]
		[Address(RVA = "0xFA2EA0", Offset = "0xFA1CA0", Length = "0x135")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AE")]
	public Camera anchorCamera
	{
		[Token(Token = "0x6000771")]
		[Address(RVA = "0xFA2FE0", Offset = "0xFA1DE0", Length = "0x30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AF")]
	public bool isFullyAnchored
	{
		[Token(Token = "0x6000772")]
		[Address(RVA = "0xFA3010", Offset = "0xFA1E10", Length = "0x1EF")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000B0")]
	public virtual bool isAnchoredHorizontally
	{
		[Token(Token = "0x6000773")]
		[Address(RVA = "0xFA3200", Offset = "0xFA2000", Length = "0x196")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000B1")]
	public virtual bool isAnchoredVertically
	{
		[Token(Token = "0x6000774")]
		[Address(RVA = "0xFA33A0", Offset = "0xFA21A0", Length = "0x196")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000B2")]
	public virtual bool canBeAnchored
	{
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000B3")]
	public UIRect parent
	{
		[Token(Token = "0x6000776")]
		[Address(RVA = "0xFA3540", Offset = "0xFA2340", Length = "0xF5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B4")]
	public UIRoot root
	{
		[Token(Token = "0x6000777")]
		[Address(RVA = "0xFA3640", Offset = "0xFA2440", Length = "0x1B5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B5")]
	public bool isAnchored
	{
		[Token(Token = "0x6000778")]
		[Address(RVA = "0xFA3800", Offset = "0xFA2600", Length = "0x204")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000B6")]
	public abstract float alpha
	{
		[Token(Token = "0x6000779")]
		get;
		[Token(Token = "0x600077A")]
		set;
	}

	[Token(Token = "0x170000B7")]
	public abstract Vector3[] localCorners
	{
		[Token(Token = "0x600077C")]
		get;
	}

	[Token(Token = "0x170000B8")]
	public abstract Vector3[] worldCorners
	{
		[Token(Token = "0x600077D")]
		get;
	}

	[Token(Token = "0x170000B9")]
	protected float cameraRayDistance
	{
		[Token(Token = "0x600077E")]
		[Address(RVA = "0xFA3A10", Offset = "0xFA2810", Length = "0x693")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x600077B")]
	public abstract float CalculateFinalAlpha(int frameID);

	[Token(Token = "0x600077F")]
	[Address(RVA = "0xFA40B0", Offset = "0xFA2EB0", Length = "0x83")]
	public virtual void Invalidate(bool includeChildren)
	{
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0xFA4140", Offset = "0xFA2F40", Length = "0x458")]
	public virtual Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0xFA45A0", Offset = "0xFA33A0", Length = "0x6EB")]
	protected Vector3 GetLocalPos(AnchorPoint ac, Transform trans)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0xFA4C90", Offset = "0xFA3A90", Length = "0x4E")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0xFA4CE0", Offset = "0xFA3AE0", Length = "0x119")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0xFA4E00", Offset = "0xFA3C00", Length = "0x1C9")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0xFA4FD0", Offset = "0xFA3DD0", Length = "0x36")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0xFA5010", Offset = "0xFA3E10", Length = "0x1B5")]
	public void Update()
	{
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0xFA51D0", Offset = "0xFA3FD0", Length = "0x39")]
	public void UpdateAnchors()
	{
	}

	[Token(Token = "0x6000788")]
	protected abstract void OnAnchor();

	[Token(Token = "0x6000789")]
	[Address(RVA = "0xFA5210", Offset = "0xFA4010", Length = "0x1CB")]
	public void SetAnchor(Transform t)
	{
	}

	[Token(Token = "0x600078A")]
	[Address(RVA = "0xFA53E0", Offset = "0xFA41E0", Length = "0x29A")]
	public void SetAnchor(GameObject go)
	{
	}

	[Token(Token = "0x600078B")]
	[Address(RVA = "0xFA5680", Offset = "0xFA4480", Length = "0x331")]
	public void SetAnchor(GameObject go, int left, int bottom, int right, int top)
	{
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0xFA59C0", Offset = "0xFA47C0", Length = "0x8D5")]
	public void ResetAnchors()
	{
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0xFA62A0", Offset = "0xFA50A0", Length = "0x43")]
	public void ResetAndUpdateAnchors()
	{
	}

	[Token(Token = "0x600078E")]
	public abstract void SetRect(float x, float y, float width, float height);

	[Token(Token = "0x600078F")]
	[Address(RVA = "0xFA62F0", Offset = "0xFA50F0", Length = "0x289")]
	private void FindCameraFor(AnchorPoint ap)
	{
	}

	[Token(Token = "0x6000790")]
	[Address(RVA = "0xFA6580", Offset = "0xFA5380", Length = "0x384")]
	public virtual void ParentHasChanged()
	{
	}

	[Token(Token = "0x6000791")]
	protected abstract void OnStart();

	[Token(Token = "0x6000792")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnUpdate()
	{
	}

	[Token(Token = "0x6000793")]
	[Address(RVA = "0xFA6910", Offset = "0xFA5710", Length = "0x29A")]
	protected UIRect()
	{
	}
}
