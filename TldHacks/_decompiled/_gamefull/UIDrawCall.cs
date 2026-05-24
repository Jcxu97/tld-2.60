using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Internal/Draw Call")]
[Token(Token = "0x20000C7")]
public class UIDrawCall : MonoBehaviour
{
	[Token(Token = "0x20000C8")]
	public enum Clipping
	{
		[Token(Token = "0x400068B")]
		None = 0,
		[Token(Token = "0x400068C")]
		TextureMask = 1,
		[Token(Token = "0x400068D")]
		SoftClip = 3,
		[Token(Token = "0x400068E")]
		ConstrainButDontClip = 4
	}

	[Token(Token = "0x20000C9")]
	public delegate void OnRenderCallback(Material mat);

	[Token(Token = "0x4000666")]
	public static Action<UIDrawCall> s_OnPostCreate;

	[Token(Token = "0x4000667")]
	private static BetterList<UIDrawCall> mActiveList;

	[Token(Token = "0x4000668")]
	private static BetterList<UIDrawCall> mInactiveList;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0x20")]
	public int widgetCount;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x400066A")]
	[FieldOffset(Offset = "0x24")]
	public int depthStart;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x400066B")]
	[FieldOffset(Offset = "0x28")]
	public int depthEnd;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x400066C")]
	[FieldOffset(Offset = "0x30")]
	public UIPanel manager;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x400066D")]
	[FieldOffset(Offset = "0x38")]
	public UIPanel panel;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x400066E")]
	[FieldOffset(Offset = "0x40")]
	public Texture2D clipTexture;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x400066F")]
	[FieldOffset(Offset = "0x48")]
	public bool alwaysOnScreen;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x4000670")]
	[FieldOffset(Offset = "0x50")]
	public BetterList<Vector3> verts;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x4000671")]
	[FieldOffset(Offset = "0x58")]
	public BetterList<Vector3> norms;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x4000672")]
	[FieldOffset(Offset = "0x60")]
	public BetterList<Vector4> tans;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0x68")]
	public BetterList<Vector2> uvs;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x4000674")]
	[FieldOffset(Offset = "0x70")]
	public BetterList<Color32> cols;

	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x78")]
	private Material mMaterial;

	[Token(Token = "0x4000676")]
	[FieldOffset(Offset = "0x80")]
	private Texture mTexture;

	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0x88")]
	private Shader mShader;

	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0x90")]
	private int mClipCount;

	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0x98")]
	private Transform mTrans;

	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0xA0")]
	private Mesh mMesh;

	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0xA8")]
	private MeshFilter mFilter;

	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0xB0")]
	private MeshRenderer mRenderer;

	[Token(Token = "0x400067D")]
	[FieldOffset(Offset = "0xB8")]
	private Material mDynamicMat;

	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0xC0")]
	private int[] mIndices;

	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0xC8")]
	private bool mRebuildMat;

	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0xC9")]
	private bool mLegacyShader;

	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0xCC")]
	private int mRenderQueue;

	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0xD0")]
	private int mTriangles;

	[NonSerialized]
	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0xD4")]
	public bool isDirty;

	[NonSerialized]
	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0xD5")]
	private bool mTextureClip;

	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0xD8")]
	public OnRenderCallback onRender;

	[Token(Token = "0x4000686")]
	private const int maxIndexBufferCache = 10;

	[Token(Token = "0x4000687")]
	private static List<int[]> mCache;

	[Token(Token = "0x4000688")]
	private static int[] ClipRange;

	[Token(Token = "0x4000689")]
	private static int[] ClipArgs;

	[Obsolete("Use UIDrawCall.activeList")]
	[Token(Token = "0x1700009D")]
	public static BetterList<UIDrawCall> list
	{
		[Token(Token = "0x6000715")]
		[Address(RVA = "0xF9B890", Offset = "0xF9A690", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009E")]
	public static BetterList<UIDrawCall> activeList
	{
		[Token(Token = "0x6000716")]
		[Address(RVA = "0xF9B8F0", Offset = "0xF9A6F0", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009F")]
	public static BetterList<UIDrawCall> inactiveList
	{
		[Token(Token = "0x6000717")]
		[Address(RVA = "0xF9B950", Offset = "0xF9A750", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A0")]
	public int renderQueue
	{
		[Token(Token = "0x6000718")]
		[Address(RVA = "0xF9B9B0", Offset = "0xF9A7B0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000719")]
		[Address(RVA = "0xF9B9C0", Offset = "0xF9A7C0", Length = "0x106")]
		set
		{
		}
	}

	[Token(Token = "0x170000A1")]
	public int sortingOrder
	{
		[Token(Token = "0x600071A")]
		[Address(RVA = "0xF9BAD0", Offset = "0xF9A8D0", Length = "0xF1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600071B")]
		[Address(RVA = "0xF9BBD0", Offset = "0xF9A9D0", Length = "0x10B")]
		set
		{
		}
	}

	[Token(Token = "0x170000A2")]
	public int finalRenderQueue
	{
		[Token(Token = "0x600071C")]
		[Address(RVA = "0xF9BCE0", Offset = "0xF9AAE0", Length = "0xF5")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170000A3")]
	public Transform cachedTransform
	{
		[Token(Token = "0x600071D")]
		[Address(RVA = "0xF9BDE0", Offset = "0xF9ABE0", Length = "0x138")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A4")]
	public Material baseMaterial
	{
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600071F")]
		[Address(RVA = "0xF9BF20", Offset = "0xF9AD20", Length = "0x172")]
		set
		{
		}
	}

	[Token(Token = "0x170000A5")]
	public Material dynamicMaterial
	{
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x502320", Offset = "0x501120", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A6")]
	public Texture mainTexture
	{
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000722")]
		[Address(RVA = "0xF9C0A0", Offset = "0xF9AEA0", Length = "0x141")]
		set
		{
		}
	}

	[Token(Token = "0x170000A7")]
	public Shader shader
	{
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000724")]
		[Address(RVA = "0xF9C1F0", Offset = "0xF9AFF0", Length = "0x182")]
		set
		{
		}
	}

	[Token(Token = "0x170000A8")]
	public int triangles
	{
		[Token(Token = "0x6000725")]
		[Address(RVA = "0xF9C380", Offset = "0xF9B180", Length = "0xE0")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170000A9")]
	public bool isClipped
	{
		[Token(Token = "0x6000726")]
		[Address(RVA = "0xF9C460", Offset = "0xF9B260", Length = "0xB")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0xF9C470", Offset = "0xF9B270", Length = "0xA80")]
	private void CreateMaterial()
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0xF9CF00", Offset = "0xF9BD00", Length = "0x320")]
	private Material RebuildMaterial()
	{
		return null;
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0xF9D230", Offset = "0xF9C030", Length = "0x36E")]
	private void UpdateMaterials()
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0xF9D5A0", Offset = "0xF9C3A0", Length = "0x10B1")]
	public void UpdateGeometry(int widgetCount)
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0xF9E660", Offset = "0xF9D460", Length = "0x337")]
	private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
	{
		return null;
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0xF9E9A0", Offset = "0xF9D7A0", Length = "0x8AB")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0xF9F250", Offset = "0xF9E050", Length = "0x22D")]
	private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
	{
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0xF9F480", Offset = "0xF9E280", Length = "0x35F")]
	private void Awake()
	{
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0x6A9270", Offset = "0x6A8070", Length = "0x8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0xF9F7E0", Offset = "0xF9E5E0", Length = "0x410")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0xF9FC00", Offset = "0xF9EA00", Length = "0xAC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0xF9FCB0", Offset = "0xF9EAB0", Length = "0x89")]
	public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0xF9FD40", Offset = "0xF9EB40", Length = "0x341")]
	private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0xFA0090", Offset = "0xF9EE90", Length = "0x2D8")]
	private static UIDrawCall Create(string name)
	{
		return null;
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0xFA0370", Offset = "0xF9F170", Length = "0x2AB")]
	public static void ClearAll()
	{
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0xFA0620", Offset = "0xF9F420", Length = "0x4C")]
	public static void ReleaseAll()
	{
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0xFA0670", Offset = "0xF9F470", Length = "0x20D")]
	public static void ReleaseInactive()
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0xFA0880", Offset = "0xF9F680", Length = "0x224")]
	public static int Count(UIPanel panel)
	{
		return 0;
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0xFA0AB0", Offset = "0xF9F8B0", Length = "0x2F4")]
	public static void Destroy(UIDrawCall dc)
	{
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0xFA0DB0", Offset = "0xF9FBB0", Length = "0x2F0")]
	public UIDrawCall()
	{
	}
}
