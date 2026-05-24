using System;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Unity2D Sprite")]
[Token(Token = "0x20000EF")]
public class UI2DSprite : UIBasicSprite
{
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000763")]
	[FieldOffset(Offset = "0x1D8")]
	private Sprite mSprite;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0x1E0")]
	private Material mMat;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000765")]
	[FieldOffset(Offset = "0x1E8")]
	private Shader mShader;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000766")]
	[FieldOffset(Offset = "0x1F0")]
	private Vector4 mBorder;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000767")]
	[FieldOffset(Offset = "0x200")]
	private bool mFixedAspect;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0x204")]
	private float mPixelSize;

	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x208")]
	public Sprite nextSprite;

	[NonSerialized]
	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x210")]
	private int mPMA;

	[Token(Token = "0x170000F4")]
	public Sprite sprite2D
	{
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x5C4D50", Offset = "0x5C3B50", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x112CD80", Offset = "0x112BB80", Length = "0x1EF")]
		set
		{
		}
	}

	[Token(Token = "0x170000F5")]
	public override Material material
	{
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x5C5150", Offset = "0x5C3F50", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x112CF70", Offset = "0x112BD70", Length = "0x1AA")]
		set
		{
		}
	}

	[Token(Token = "0x170000F6")]
	public override Shader shader
	{
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x112D120", Offset = "0x112BF20", Length = "0x1F9")]
		get
		{
			return null;
		}
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x112D320", Offset = "0x112C120", Length = "0x23E")]
		set
		{
		}
	}

	[Token(Token = "0x170000F7")]
	public override Texture mainTexture
	{
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x112D560", Offset = "0x112C360", Length = "0x1A6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F8")]
	public override bool premultipliedAlpha
	{
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x112D710", Offset = "0x112C510", Length = "0x13E")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000F9")]
	public override float pixelSize
	{
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x112D850", Offset = "0x112C650", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x170000FA")]
	public override Vector4 drawingDimensions
	{
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x112D860", Offset = "0x112C660", Length = "0x8FB")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x170000FB")]
	public override Vector4 border
	{
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x112E160", Offset = "0x112CF60", Length = "0xE")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x112E170", Offset = "0x112CF70", Length = "0x86")]
		set
		{
		}
	}

	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x112E200", Offset = "0x112D000", Length = "0x835")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x112EA40", Offset = "0x112D840", Length = "0x292")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x112ECE0", Offset = "0x112DAE0", Length = "0x591")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x112F280", Offset = "0x112E080", Length = "0xE1")]
	public UI2DSprite()
	{
	}
}
