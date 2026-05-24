using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Font")]
[Token(Token = "0x200010C")]
public class UIFont : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x20")]
	private Material mMat;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x28")]
	private Rect mUVRect;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x38")]
	private BMFont mFont;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x40")]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x48")]
	private UIFont mReplacement;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x50")]
	private List<BMSymbol> mSymbols;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x58")]
	private Font mDynamicFont;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x60")]
	private int mDynamicFontSize;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x64")]
	private FontStyle mDynamicFontStyle;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x68")]
	public float mFontSizePercentModifier;

	[NonSerialized]
	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x70")]
	private UISpriteData mSprite;

	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x78")]
	private int mPMA;

	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x7C")]
	private int mPacked;

	[Token(Token = "0x17000116")]
	public BMFont bmFont
	{
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x12748E0", Offset = "0x12736E0", Length = "0xED")]
		get
		{
			return null;
		}
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x12749D0", Offset = "0x12737D0", Length = "0x14B")]
		set
		{
		}
	}

	[Token(Token = "0x17000117")]
	public int texWidth
	{
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x1274B20", Offset = "0x1273920", Length = "0x105")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1274C30", Offset = "0x1273A30", Length = "0x106")]
		set
		{
		}
	}

	[Token(Token = "0x17000118")]
	public int texHeight
	{
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1274D40", Offset = "0x1273B40", Length = "0x105")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1274E50", Offset = "0x1273C50", Length = "0x106")]
		set
		{
		}
	}

	[Token(Token = "0x17000119")]
	public bool hasSymbols
	{
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x1274F60", Offset = "0x1273D60", Length = "0x115")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700011A")]
	public List<BMSymbol> symbols
	{
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x1275080", Offset = "0x1273E80", Length = "0xED")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700011B")]
	public UIAtlas atlas
	{
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x1275170", Offset = "0x1273F70", Length = "0xED")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x1275260", Offset = "0x1274060", Length = "0x309")]
		set
		{
		}
	}

	[Token(Token = "0x1700011C")]
	public Material material
	{
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x1275570", Offset = "0x1274370", Length = "0x4E2")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x1275A60", Offset = "0x1274860", Length = "0x225")]
		set
		{
		}
	}

	[Obsolete("Use UIFont.premultipliedAlphaShader instead")]
	[Token(Token = "0x1700011D")]
	public bool premultipliedAlpha
	{
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x1275C90", Offset = "0x1274A90", Length = "0x7")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700011E")]
	public bool premultipliedAlphaShader
	{
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x1275CA0", Offset = "0x1274AA0", Length = "0x34E")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700011F")]
	public bool packedFontShader
	{
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x1275FF0", Offset = "0x1274DF0", Length = "0x33D")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000120")]
	public Texture2D texture
	{
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x1276330", Offset = "0x1275130", Length = "0x1C7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000121")]
	public Rect uvRect
	{
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x1276500", Offset = "0x1275300", Length = "0x1DF")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x12766E0", Offset = "0x12754E0", Length = "0x170")]
		set
		{
		}
	}

	[Token(Token = "0x17000122")]
	public string spriteName
	{
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x1276860", Offset = "0x1275660", Length = "0xF6")]
		get
		{
			return null;
		}
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x1276960", Offset = "0x1275760", Length = "0x14E")]
		set
		{
		}
	}

	[Token(Token = "0x17000123")]
	public bool isValid
	{
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x1276AB0", Offset = "0x12758B0", Length = "0x116")]
		get
		{
			return false;
		}
	}

	[Obsolete("Use UIFont.defaultSize instead")]
	[Token(Token = "0x17000124")]
	public int size
	{
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x1276BD0", Offset = "0x12759D0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x1276BE0", Offset = "0x12759E0", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x17000125")]
	public int defaultSize
	{
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x1276BF0", Offset = "0x12759F0", Length = "0x111")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x1276D10", Offset = "0x1275B10", Length = "0xFD")]
		set
		{
		}
	}

	[Token(Token = "0x17000126")]
	public UISpriteData sprite
	{
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x1276E10", Offset = "0x1275C10", Length = "0x2C5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000127")]
	public UIFont replacement
	{
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x12770E0", Offset = "0x1275EE0", Length = "0x5F2")]
		set
		{
		}
	}

	[Token(Token = "0x17000128")]
	public bool isDynamic
	{
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x12776E0", Offset = "0x12764E0", Length = "0x18D")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000129")]
	public Font dynamicFont
	{
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x1277870", Offset = "0x1276670", Length = "0xED")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x1277960", Offset = "0x1276760", Length = "0x2C5")]
		set
		{
		}
	}

	[Token(Token = "0x1700012A")]
	public FontStyle dynamicFontStyle
	{
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x1277C30", Offset = "0x1276A30", Length = "0xEC")]
		get
		{
			return default(FontStyle);
		}
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x1277D20", Offset = "0x1276B20", Length = "0x10C")]
		set
		{
		}
	}

	[Token(Token = "0x1700012B")]
	private Texture dynamicTexture
	{
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1278840", Offset = "0x1277640", Length = "0x122")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600096B")]
	[Address(RVA = "0x1277E30", Offset = "0x1276C30", Length = "0x114")]
	public float GetFontSizeModifierValue()
	{
		return 0f;
	}

	[Token(Token = "0x600096C")]
	[Address(RVA = "0x1277F50", Offset = "0x1276D50", Length = "0x39A")]
	private void Trim()
	{
	}

	[Token(Token = "0x600096D")]
	[Address(RVA = "0x12782F0", Offset = "0x12770F0", Length = "0x243")]
	private bool References(UIFont font)
	{
		return false;
	}

	[Token(Token = "0x600096E")]
	[Address(RVA = "0x1278540", Offset = "0x1277340", Length = "0x2F0")]
	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		return false;
	}

	[Token(Token = "0x6000970")]
	[Address(RVA = "0x1278970", Offset = "0x1277770", Length = "0x350")]
	public void MarkAsChanged()
	{
	}

	[Token(Token = "0x6000971")]
	[Address(RVA = "0x1278CD0", Offset = "0x1277AD0", Length = "0x312")]
	public void UpdateUVRect()
	{
	}

	[Token(Token = "0x6000972")]
	[Address(RVA = "0x1278FF0", Offset = "0x1277DF0", Length = "0x202")]
	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x6000973")]
	[Address(RVA = "0x1279200", Offset = "0x1278000", Length = "0x1CA")]
	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[Token(Token = "0x6000974")]
	[Address(RVA = "0x12793D0", Offset = "0x12781D0", Length = "0x8A")]
	public void AddSymbol(string sequence, string spriteName)
	{
	}

	[Token(Token = "0x6000975")]
	[Address(RVA = "0x1279460", Offset = "0x1278260", Length = "0x84")]
	public void RemoveSymbol(string sequence)
	{
	}

	[Token(Token = "0x6000976")]
	[Address(RVA = "0x12794F0", Offset = "0x12782F0", Length = "0x85")]
	public void RenameSymbol(string before, string after)
	{
	}

	[Token(Token = "0x6000977")]
	[Address(RVA = "0x1279580", Offset = "0x1278380", Length = "0x158")]
	public bool UsesSprite(string s)
	{
		return false;
	}

	[Token(Token = "0x6000978")]
	[Address(RVA = "0x12796E0", Offset = "0x12784E0", Length = "0x2D5")]
	public UIFont()
	{
	}
}
