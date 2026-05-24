using System;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Texture")]
[Token(Token = "0x200012B")]
public class UITexture : UIBasicSprite
{
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000943")]
	[FieldOffset(Offset = "0x1D8")]
	private Rect mRect;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000944")]
	[FieldOffset(Offset = "0x1E8")]
	private Texture mTexture;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000945")]
	[FieldOffset(Offset = "0x1F0")]
	private Material mMat;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000946")]
	[FieldOffset(Offset = "0x1F8")]
	private Shader mShader;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000947")]
	[FieldOffset(Offset = "0x200")]
	private Vector4 mBorder;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000948")]
	[FieldOffset(Offset = "0x210")]
	private bool mFixedAspect;

	[NonSerialized]
	[Token(Token = "0x4000949")]
	[FieldOffset(Offset = "0x214")]
	private int mPMA;

	[Token(Token = "0x17000197")]
	public override Texture mainTexture
	{
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x5CAF90", Offset = "0x5C9D90", Length = "0x197")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x5CB130", Offset = "0x5C9F30", Length = "0x318")]
		set
		{
		}
	}

	[Token(Token = "0x17000198")]
	public override Material material
	{
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x54A2C0", Offset = "0x5490C0", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x5CB450", Offset = "0x5CA250", Length = "0x212")]
		set
		{
		}
	}

	[Token(Token = "0x17000199")]
	public override Shader shader
	{
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x5CB670", Offset = "0x5CA470", Length = "0x1F9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x5CB870", Offset = "0x5CA670", Length = "0x376")]
		set
		{
		}
	}

	[Token(Token = "0x1700019A")]
	public override bool premultipliedAlpha
	{
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x5CBBF0", Offset = "0x5CA9F0", Length = "0x1F9")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700019B")]
	public override Vector4 border
	{
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x5CBDF0", Offset = "0x5CABF0", Length = "0xE")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x5CBE00", Offset = "0x5CAC00", Length = "0x86")]
		set
		{
		}
	}

	[Token(Token = "0x1700019C")]
	public Rect uvRect
	{
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x5CBE90", Offset = "0x5CAC90", Length = "0xE")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x5CBEA0", Offset = "0x5CACA0", Length = "0x68")]
		set
		{
		}
	}

	[Token(Token = "0x1700019D")]
	public override Vector4 drawingDimensions
	{
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x5CBF10", Offset = "0x5CAD10", Length = "0x3C7")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x1700019E")]
	public bool fixedAspect
	{
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x5CC2E0", Offset = "0x5CB0E0", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x5CC2F0", Offset = "0x5CB0F0", Length = "0x2E")]
		set
		{
		}
	}

	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x5CC320", Offset = "0x5CB120", Length = "0x20A")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x5CC530", Offset = "0x5CB330", Length = "0x20F")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x5CC740", Offset = "0x5CB540", Length = "0x480")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0x5CCBD0", Offset = "0x5CB9D0", Length = "0xEA")]
	public UITexture()
	{
	}
}
