using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000C2")]
public abstract class UIBasicSprite : UIWidget
{
	[Token(Token = "0x20000C3")]
	public enum Type
	{
		[Token(Token = "0x4000652")]
		Simple,
		[Token(Token = "0x4000653")]
		Sliced,
		[Token(Token = "0x4000654")]
		Tiled,
		[Token(Token = "0x4000655")]
		Filled,
		[Token(Token = "0x4000656")]
		Advanced
	}

	[Token(Token = "0x20000C4")]
	public enum FillDirection
	{
		[Token(Token = "0x4000658")]
		Horizontal,
		[Token(Token = "0x4000659")]
		Vertical,
		[Token(Token = "0x400065A")]
		Radial90,
		[Token(Token = "0x400065B")]
		Radial180,
		[Token(Token = "0x400065C")]
		Radial360
	}

	[Token(Token = "0x20000C5")]
	public enum AdvancedType
	{
		[Token(Token = "0x400065E")]
		Invisible,
		[Token(Token = "0x400065F")]
		Sliced,
		[Token(Token = "0x4000660")]
		Tiled
	}

	[Token(Token = "0x20000C6")]
	public enum Flip
	{
		[Token(Token = "0x4000662")]
		Nothing,
		[Token(Token = "0x4000663")]
		Horizontally,
		[Token(Token = "0x4000664")]
		Vertically,
		[Token(Token = "0x4000665")]
		Both
	}

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0x190")]
	protected Type mType;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x194")]
	protected FillDirection mFillDirection;

	[Range(0f, 1f)]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x198")]
	protected float mFillAmount;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x19C")]
	protected bool mInvert;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x1A0")]
	protected Flip mFlip;

	[NonSerialized]
	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x1A4")]
	private Rect mInnerUV;

	[NonSerialized]
	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x1B4")]
	private Rect mOuterUV;

	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0x1C4")]
	public AdvancedType centerType;

	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x1C8")]
	public AdvancedType leftType;

	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x1CC")]
	public AdvancedType rightType;

	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x1D0")]
	public AdvancedType bottomType;

	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x1D4")]
	public AdvancedType topType;

	[Token(Token = "0x400064F")]
	protected static Vector2[] mTempPos;

	[Token(Token = "0x4000650")]
	protected static Vector2[] mTempUVs;

	[Token(Token = "0x17000091")]
	public virtual Type type
	{
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x8FB9C0", Offset = "0x8FA7C0", Length = "0x7")]
		get
		{
			return default(Type);
		}
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xF96070", Offset = "0xF94E70", Length = "0x20")]
		set
		{
		}
	}

	[Token(Token = "0x17000092")]
	public Flip flip
	{
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xF96090", Offset = "0xF94E90", Length = "0x7")]
		get
		{
			return default(Flip);
		}
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xF960A0", Offset = "0xF94EA0", Length = "0x20")]
		set
		{
		}
	}

	[Token(Token = "0x17000093")]
	public FillDirection fillDirection
	{
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x9BB1A0", Offset = "0x9B9FA0", Length = "0x7")]
		get
		{
			return default(FillDirection);
		}
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xF960C0", Offset = "0xF94EC0", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x17000094")]
	public float fillAmount
	{
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xF960E0", Offset = "0xF94EE0", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000700")]
		[Address(RVA = "0xF960F0", Offset = "0xF94EF0", Length = "0x39")]
		set
		{
		}
	}

	[Token(Token = "0x17000095")]
	public override int minWidth
	{
		[Token(Token = "0x6000701")]
		[Address(RVA = "0xF96130", Offset = "0xF94F30", Length = "0x101")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000096")]
	public override int minHeight
	{
		[Token(Token = "0x6000702")]
		[Address(RVA = "0xF96240", Offset = "0xF95040", Length = "0x105")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000097")]
	public bool invert
	{
		[Token(Token = "0x6000703")]
		[Address(RVA = "0xF96350", Offset = "0xF95150", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6000704")]
		[Address(RVA = "0xF96360", Offset = "0xF95160", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x17000098")]
	public bool hasBorder
	{
		[Token(Token = "0x6000705")]
		[Address(RVA = "0xF96380", Offset = "0xF95180", Length = "0x66")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000099")]
	public virtual bool premultipliedAlpha
	{
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700009A")]
	public virtual float pixelSize
	{
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x4A2290", Offset = "0x4A1090", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700009B")]
	private Vector4 drawingUVs
	{
		[Token(Token = "0x6000708")]
		[Address(RVA = "0xF963F0", Offset = "0xF951F0", Length = "0xED")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x1700009C")]
	private Color32 drawingColor
	{
		[Token(Token = "0x6000709")]
		[Address(RVA = "0xF964E0", Offset = "0xF952E0", Length = "0x210")]
		get
		{
			return default(Color32);
		}
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0xF96700", Offset = "0xF95500", Length = "0x110")]
	protected void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, Rect outer, Rect inner)
	{
	}

	[Token(Token = "0x600070B")]
	[Address(RVA = "0xF96810", Offset = "0xF95610", Length = "0x3BA")]
	private void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0xF96BD0", Offset = "0xF959D0", Length = "0xC60")]
	private void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0xF97840", Offset = "0xF96640", Length = "0x6D1")]
	private void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0xF97F20", Offset = "0xF96D20", Length = "0x15CB")]
	private void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0xF994F0", Offset = "0xF982F0", Length = "0x187A")]
	private void AdvancedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0xF9AD70", Offset = "0xF99B70", Length = "0x150")]
	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		return false;
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0xF9AEC0", Offset = "0xF99CC0", Length = "0x476")]
	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0xF9B340", Offset = "0xF9A140", Length = "0x3B9")]
	private static void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0xF9B700", Offset = "0xF9A500", Length = "0x4D")]
	protected UIBasicSprite()
	{
	}
}
