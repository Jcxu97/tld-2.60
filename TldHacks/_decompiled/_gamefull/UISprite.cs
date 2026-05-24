using System;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Sprite")]
[Token(Token = "0x2000123")]
public class UISprite : UIBasicSprite
{
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0x1D8")]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0x1E0")]
	private string mSpriteName;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0x1E8")]
	private bool mFillCenter;

	[NonSerialized]
	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0x1F0")]
	protected UISpriteData mSprite;

	[NonSerialized]
	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0x1F8")]
	private bool mSpriteSet;

	[Token(Token = "0x17000181")]
	public override Material material
	{
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x5C4C50", Offset = "0x5C3A50", Length = "0xF1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000182")]
	public UIAtlas atlas
	{
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x5C4D50", Offset = "0x5C3B50", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x5C4D60", Offset = "0x5C3B60", Length = "0x3E6")]
		set
		{
		}
	}

	[Token(Token = "0x17000183")]
	public string spriteName
	{
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x5C5150", Offset = "0x5C3F50", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x5C5160", Offset = "0x5C3F60", Length = "0x226")]
		set
		{
		}
	}

	[Token(Token = "0x17000184")]
	public bool isValid
	{
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x5C5390", Offset = "0x5C4190", Length = "0x16")]
		get
		{
			return false;
		}
	}

	[Obsolete("Use 'centerType' instead")]
	[Token(Token = "0x17000185")]
	public bool fillCenter
	{
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x5C53B0", Offset = "0x5C41B0", Length = "0xB")]
		get
		{
			return false;
		}
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x5C53C0", Offset = "0x5C41C0", Length = "0x2D")]
		set
		{
		}
	}

	[Token(Token = "0x17000186")]
	public override Vector4 border
	{
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x5C53F0", Offset = "0x5C41F0", Length = "0x95")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x17000187")]
	public override float pixelSize
	{
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x5C5490", Offset = "0x5C4290", Length = "0xF7")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000188")]
	public override int minWidth
	{
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x5C5590", Offset = "0x5C4390", Length = "0x167")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000189")]
	public override int minHeight
	{
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x5C5700", Offset = "0x5C4500", Length = "0x132")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700018A")]
	public override Vector4 drawingDimensions
	{
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x5C5840", Offset = "0x5C4640", Length = "0x516")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x1700018B")]
	public override bool premultipliedAlpha
	{
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x5C5D60", Offset = "0x5C4B60", Length = "0xF1")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x5C5E60", Offset = "0x5C4C60", Length = "0x2B4")]
	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x5C6120", Offset = "0x5C4F20", Length = "0x1D9")]
	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x5C6300", Offset = "0x5C5100", Length = "0x274")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x5C6580", Offset = "0x5C5380", Length = "0x21")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x5C65B0", Offset = "0x5C53B0", Length = "0x7B")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x5C6630", Offset = "0x5C5430", Length = "0x4A0")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x5C6AE0", Offset = "0x5C58E0", Length = "0x9B")]
	public UISprite()
	{
	}
}
