using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Label")]
[Token(Token = "0x2000114")]
public class UILabel : UIWidget
{
	[Token(Token = "0x2000115")]
	public enum Effect
	{
		[Token(Token = "0x40008A2")]
		None,
		[Token(Token = "0x40008A3")]
		Shadow,
		[Token(Token = "0x40008A4")]
		Outline,
		[Token(Token = "0x40008A5")]
		Outline8
	}

	[Token(Token = "0x2000116")]
	public enum Overflow
	{
		[Token(Token = "0x40008A7")]
		ShrinkContent,
		[Token(Token = "0x40008A8")]
		ClampContent,
		[Token(Token = "0x40008A9")]
		ResizeFreely,
		[Token(Token = "0x40008AA")]
		ResizeHeight
	}

	[Token(Token = "0x2000117")]
	public enum Crispness
	{
		[Token(Token = "0x40008AC")]
		Never,
		[Token(Token = "0x40008AD")]
		OnDesktop,
		[Token(Token = "0x40008AE")]
		Always
	}

	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x190")]
	public Crispness keepCrispWhenShrunk;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x198")]
	private Font mTrueTypeFont;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0x1A0")]
	private UIFont mFont;

	[Multiline(6)]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x1A8")]
	private string mText;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0x1B0")]
	private int mFontSize;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x1B4")]
	private int mFontSizeAsianOverride;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0x1B8")]
	private int mFontSizeCyrillicOverride;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0x1BC")]
	private int mFontSizeInuktitutOverride;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x1C0")]
	private FontStyle mFontStyle;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x1C4")]
	private NGUIText.Alignment mAlignment;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x1C8")]
	private bool mEncoding;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0x1CC")]
	private int mMaxLineCount;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x1D0")]
	private Effect mEffectStyle;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x1D4")]
	private Color mEffectColor;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x1E4")]
	private NGUIText.SymbolStyle mSymbols;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x1E8")]
	private Vector2 mEffectDistance;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x1F0")]
	private Overflow mOverflow;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x1F8")]
	private Material mMaterial;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0x200")]
	private bool mApplyGradient;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x204")]
	private Color mGradientTop;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0x214")]
	private Color mGradientBottom;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000884")]
	[FieldOffset(Offset = "0x224")]
	private int mSpacingX;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000885")]
	[FieldOffset(Offset = "0x228")]
	private int mSpacingY;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000886")]
	[FieldOffset(Offset = "0x22C")]
	private bool mUseFloatSpacing;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000887")]
	[FieldOffset(Offset = "0x230")]
	private float mFloatSpacingX;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000888")]
	[FieldOffset(Offset = "0x234")]
	private float mFloatSpacingY;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000889")]
	[FieldOffset(Offset = "0x238")]
	private bool mCapsLock;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400088A")]
	[FieldOffset(Offset = "0x239")]
	private bool m_Bulleted;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400088B")]
	[FieldOffset(Offset = "0x23C")]
	private int m_BulletSpacing;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400088C")]
	[FieldOffset(Offset = "0x240")]
	private bool mShrinkToFit;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400088D")]
	[FieldOffset(Offset = "0x244")]
	private int mMaxLineWidth;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400088E")]
	[FieldOffset(Offset = "0x248")]
	private int mMaxLineHeight;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400088F")]
	[FieldOffset(Offset = "0x24C")]
	private float mLineWidth;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000890")]
	[FieldOffset(Offset = "0x250")]
	private bool mMultiline;

	[NonSerialized]
	[Token(Token = "0x4000891")]
	[FieldOffset(Offset = "0x258")]
	private Font mActiveTTF;

	[Token(Token = "0x4000892")]
	[FieldOffset(Offset = "0x260")]
	private float mDensity;

	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x264")]
	private bool mShouldBeProcessed;

	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x268")]
	private string mProcessedText;

	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0x270")]
	private bool mPremultiply;

	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x274")]
	private Vector2 mCalculatedSize;

	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0x27C")]
	private float mScale;

	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0x280")]
	private int mPrintedSize;

	[Token(Token = "0x4000899")]
	[FieldOffset(Offset = "0x284")]
	private int mLastWidth;

	[Token(Token = "0x400089A")]
	[FieldOffset(Offset = "0x288")]
	private int mLastHeight;

	[Token(Token = "0x400089B")]
	[FieldOffset(Offset = "0x290")]
	private BetterList<UISprite> mDynamicSymbolSprites;

	[Token(Token = "0x400089C")]
	private static BetterList<UILabel> mList;

	[Token(Token = "0x400089D")]
	private static Dictionary<Font, int> mFontUsage;

	[Token(Token = "0x400089E")]
	private static bool mTexRebuildAdded;

	[Token(Token = "0x400089F")]
	private static BetterList<Vector3> mTempVerts;

	[Token(Token = "0x40008A0")]
	private static BetterList<int> mTempIndices;

	[Token(Token = "0x17000136")]
	private bool shouldBeProcessed
	{
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x127FA90", Offset = "0x127E890", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x127FAA0", Offset = "0x127E8A0", Length = "0x17")]
		set
		{
		}
	}

	[Token(Token = "0x17000137")]
	public bool capsLock
	{
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x127FAC0", Offset = "0x127E8C0", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x127FAD0", Offset = "0x127E8D0", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000138")]
	public override bool isAnchoredHorizontally
	{
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x127FAE0", Offset = "0x127E8E0", Length = "0x196")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000139")]
	public override bool isAnchoredVertically
	{
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x127FC80", Offset = "0x127EA80", Length = "0x19D")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700013A")]
	public override Material material
	{
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x127FE20", Offset = "0x127EC20", Length = "0x24C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x1280070", Offset = "0x127EE70", Length = "0x19F")]
		set
		{
		}
	}

	[Obsolete("Use UILabel.bitmapFont instead")]
	[Token(Token = "0x1700013B")]
	public UIFont font
	{
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x1280210", Offset = "0x127F010", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x1280220", Offset = "0x127F020", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x1700013C")]
	public UIFont bitmapFont
	{
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x1280210", Offset = "0x127F010", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x1280230", Offset = "0x127F030", Length = "0x1F9")]
		set
		{
		}
	}

	[Token(Token = "0x1700013D")]
	public Font trueTypeFont
	{
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x1280430", Offset = "0x127F230", Length = "0x197")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x12805D0", Offset = "0x127F3D0", Length = "0x2B9")]
		set
		{
		}
	}

	[Token(Token = "0x1700013E")]
	public UnityEngine.Object ambigiousFont
	{
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x1280890", Offset = "0x127F690", Length = "0xE6")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x1280980", Offset = "0x127F780", Length = "0x172")]
		set
		{
		}
	}

	[Token(Token = "0x1700013F")]
	public string text
	{
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x1280B00", Offset = "0x127F900", Length = "0x31")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x1280B40", Offset = "0x127F940", Length = "0x125")]
		set
		{
		}
	}

	[Token(Token = "0x17000140")]
	public int defaultFontSize
	{
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x1280C70", Offset = "0x127FA70", Length = "0x1A2")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000141")]
	public int fontSize
	{
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x1280E20", Offset = "0x127FC20", Length = "0x170")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x1280FA0", Offset = "0x127FDA0", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x17000142")]
	public int fontSizeAsianOverride
	{
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x1280FE0", Offset = "0x127FDE0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x1280FF0", Offset = "0x127FDF0", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x17000143")]
	public int fontSizeCyrillicOverride
	{
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x1281030", Offset = "0x127FE30", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x1281040", Offset = "0x127FE40", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x17000144")]
	public int fontSizeInuktitutOverride
	{
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x1281080", Offset = "0x127FE80", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x1281090", Offset = "0x127FE90", Length = "0x36")]
		set
		{
		}
	}

	[Token(Token = "0x17000145")]
	public FontStyle fontStyle
	{
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x9C55A0", Offset = "0x9C43A0", Length = "0x7")]
		get
		{
			return default(FontStyle);
		}
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x12810D0", Offset = "0x127FED0", Length = "0x21")]
		set
		{
		}
	}

	[Token(Token = "0x17000146")]
	public NGUIText.Alignment alignment
	{
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x1281100", Offset = "0x127FF00", Length = "0x7")]
		get
		{
			return default(NGUIText.Alignment);
		}
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x1281110", Offset = "0x127FF10", Length = "0x21")]
		set
		{
		}
	}

	[Token(Token = "0x17000147")]
	public bool applyGradient
	{
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x1281140", Offset = "0x127FF40", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x1281150", Offset = "0x127FF50", Length = "0x20")]
		set
		{
		}
	}

	[Token(Token = "0x17000148")]
	public Color gradientTop
	{
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x1281170", Offset = "0x127FF70", Length = "0xE")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x1281180", Offset = "0x127FF80", Length = "0x8F")]
		set
		{
		}
	}

	[Token(Token = "0x17000149")]
	public Color gradientBottom
	{
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x1281210", Offset = "0x1280010", Length = "0xE")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x1281220", Offset = "0x1280020", Length = "0x8F")]
		set
		{
		}
	}

	[Token(Token = "0x1700014A")]
	public int spacingX
	{
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x12812B0", Offset = "0x12800B0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x12812C0", Offset = "0x12800C0", Length = "0x20")]
		set
		{
		}
	}

	[Token(Token = "0x1700014B")]
	public int spacingY
	{
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x12812E0", Offset = "0x12800E0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x12812F0", Offset = "0x12800F0", Length = "0x20")]
		set
		{
		}
	}

	[Token(Token = "0x1700014C")]
	public bool useFloatSpacing
	{
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xCBA070", Offset = "0xCB8E70", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x1281310", Offset = "0x1280110", Length = "0x1A")]
		set
		{
		}
	}

	[Token(Token = "0x1700014D")]
	public float floatSpacingX
	{
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x1281330", Offset = "0x1280130", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x1281340", Offset = "0x1280140", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x1700014E")]
	public float floatSpacingY
	{
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x12813E0", Offset = "0x12801E0", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x12813F0", Offset = "0x12801F0", Length = "0x99")]
		set
		{
		}
	}

	[Token(Token = "0x1700014F")]
	public float effectiveSpacingY
	{
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x1281490", Offset = "0x1280290", Length = "0x1E")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000150")]
	public float effectiveSpacingX
	{
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x12814B0", Offset = "0x12802B0", Length = "0x1E")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000151")]
	private bool keepCrisp
	{
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x12814D0", Offset = "0x12802D0", Length = "0xEB")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000152")]
	public bool supportEncoding
	{
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x12815C0", Offset = "0x12803C0", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x12815D0", Offset = "0x12803D0", Length = "0x1A")]
		set
		{
		}
	}

	[Token(Token = "0x17000153")]
	public NGUIText.SymbolStyle symbolStyle
	{
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x12815F0", Offset = "0x12803F0", Length = "0x7")]
		get
		{
			return default(NGUIText.SymbolStyle);
		}
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x1281600", Offset = "0x1280400", Length = "0x1A")]
		set
		{
		}
	}

	[Token(Token = "0x17000154")]
	public Overflow overflowMethod
	{
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x1281620", Offset = "0x1280420", Length = "0x7")]
		get
		{
			return default(Overflow);
		}
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x1281630", Offset = "0x1280430", Length = "0x1A")]
		set
		{
		}
	}

	[Obsolete("Use 'width' instead")]
	[Token(Token = "0x17000155")]
	public int lineWidth
	{
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x5EFD20", Offset = "0x5EEB20", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x1281650", Offset = "0x1280450", Length = "0x8")]
		set
		{
		}
	}

	[Obsolete("Use 'height' instead")]
	[Token(Token = "0x17000156")]
	public int lineHeight
	{
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x5DD350", Offset = "0x5DC150", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1281660", Offset = "0x1280460", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x17000157")]
	public bool multiLine
	{
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x1281670", Offset = "0x1280470", Length = "0xB")]
		get
		{
			return false;
		}
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x1281680", Offset = "0x1280480", Length = "0x2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000158")]
	public override Vector3[] localCorners
	{
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x12816B0", Offset = "0x12804B0", Length = "0x179")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000159")]
	public override Vector3[] worldCorners
	{
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x1281830", Offset = "0x1280630", Length = "0x22D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700015A")]
	public override Vector4 drawingDimensions
	{
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x1281A60", Offset = "0x1280860", Length = "0x4D")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x1700015B")]
	public int maxLineCount
	{
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x1281AB0", Offset = "0x12808B0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x1281AC0", Offset = "0x12808C0", Length = "0x3A")]
		set
		{
		}
	}

	[Token(Token = "0x1700015C")]
	public Effect effectStyle
	{
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x1281B00", Offset = "0x1280900", Length = "0x7")]
		get
		{
			return default(Effect);
		}
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x1281B10", Offset = "0x1280910", Length = "0x1A")]
		set
		{
		}
	}

	[Token(Token = "0x1700015D")]
	public Color effectColor
	{
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x1281B30", Offset = "0x1280930", Length = "0xE")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x1281B40", Offset = "0x1280940", Length = "0x89")]
		set
		{
		}
	}

	[Token(Token = "0x1700015E")]
	public Vector2 effectDistance
	{
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x1281BD0", Offset = "0x12809D0", Length = "0x19")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x1281BF0", Offset = "0x12809F0", Length = "0x51")]
		set
		{
		}
	}

	[Obsolete("Use 'overflowMethod == UILabel.Overflow.ShrinkContent' instead")]
	[Token(Token = "0x1700015F")]
	public bool shrinkToFit
	{
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1281C50", Offset = "0x1280A50", Length = "0xB")]
		get
		{
			return false;
		}
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x1281C60", Offset = "0x1280A60", Length = "0x23")]
		set
		{
		}
	}

	[Token(Token = "0x17000160")]
	public string processedText
	{
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1281C90", Offset = "0x1280A90", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000161")]
	public Vector2 printedSize
	{
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1281D00", Offset = "0x1280B00", Length = "0x3D")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000162")]
	public override Vector2 localSize
	{
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1281D40", Offset = "0x1280B40", Length = "0x7A")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000163")]
	private bool isValid
	{
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x1281DC0", Offset = "0x1280BC0", Length = "0x17C")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x1281F40", Offset = "0x1280D40", Length = "0xA4")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x1281FF0", Offset = "0x1280DF0", Length = "0xA3")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x12820A0", Offset = "0x1280EA0", Length = "0x7")]
	protected void PreDisable()
	{
	}

	[Token(Token = "0x6000A03")]
	[Address(RVA = "0x12820B0", Offset = "0x1280EB0", Length = "0xD3")]
	public void ControlTypeChanged()
	{
	}

	[Token(Token = "0x6000A04")]
	[Address(RVA = "0x1282190", Offset = "0x1280F90", Length = "0x46A")]
	protected void SetActiveFont(Font fnt)
	{
	}

	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x1282600", Offset = "0x1281400", Length = "0x4C0")]
	private static void OnFontChanged(Font font)
	{
	}

	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x1282AD0", Offset = "0x12818D0", Length = "0x3E")]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x1282B10", Offset = "0x1281910", Length = "0x22E")]
	protected override void UpgradeFrom265()
	{
	}

	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x1282D40", Offset = "0x1281B40", Length = "0x1D2")]
	protected override void OnAnchor()
	{
	}

	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x1282F20", Offset = "0x1281D20", Length = "0xE3")]
	private void ProcessAndRequest()
	{
	}

	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x1283010", Offset = "0x1281E10", Length = "0x102")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x1283120", Offset = "0x1281F20", Length = "0x2A1")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x12833D0", Offset = "0x12821D0", Length = "0x12")]
	public override void MarkAsChanged()
	{
	}

	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x12833F0", Offset = "0x12821F0", Length = "0xD")]
	public void ProcessText()
	{
	}

	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x1283400", Offset = "0x1282200", Length = "0xC1B")]
	private void ProcessText(bool legacyMode, bool full)
	{
	}

	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x1284020", Offset = "0x1282E20", Length = "0x521")]
	public override void MakePixelPerfect()
	{
	}

	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x1284550", Offset = "0x1283350", Length = "0x1DC")]
	public void AssumeNaturalSize()
	{
	}

	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x1284730", Offset = "0x1283530", Length = "0x2A")]
	public int GetCharacterIndex(Vector3 worldPos)
	{
		return 0;
	}

	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x1284760", Offset = "0x1283560", Length = "0xB")]
	public int GetCharacterIndex(Vector2 localPos)
	{
		return 0;
	}

	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x1284770", Offset = "0x1283570", Length = "0x10C")]
	public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
	{
		return 0;
	}

	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x1284880", Offset = "0x1283680", Length = "0x4BC")]
	public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
	{
		return 0;
	}

	[Token(Token = "0x6000A15")]
	[Address(RVA = "0x1284D40", Offset = "0x1283B40", Length = "0x3C")]
	public string GetWordAtPosition(Vector3 worldPos)
	{
		return null;
	}

	[Token(Token = "0x6000A16")]
	[Address(RVA = "0x1284D80", Offset = "0x1283B80", Length = "0x26")]
	public string GetWordAtPosition(Vector2 localPos)
	{
		return null;
	}

	[Token(Token = "0x6000A17")]
	[Address(RVA = "0x1284DB0", Offset = "0x1283BB0", Length = "0x1B7")]
	public string GetWordAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x1284F70", Offset = "0x1283D70", Length = "0x3C")]
	public string GetUrlAtPosition(Vector3 worldPos)
	{
		return null;
	}

	[Token(Token = "0x6000A19")]
	[Address(RVA = "0x1284FB0", Offset = "0x1283DB0", Length = "0x26")]
	public string GetUrlAtPosition(Vector2 localPos)
	{
		return null;
	}

	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0x1284FE0", Offset = "0x1283DE0", Length = "0x1ED")]
	public string GetUrlAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0x12851D0", Offset = "0x1283FD0", Length = "0x586")]
	public int GetCharacterIndex(int currentIndex, KeyCode key)
	{
		return 0;
	}

	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0x1285760", Offset = "0x1284560", Length = "0x559")]
	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
	{
	}

	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0x1285CC0", Offset = "0x1284AC0", Length = "0x6B3")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0x1286380", Offset = "0x1285180", Length = "0x1B3")]
	public Vector2 ApplyOffset(BetterList<Vector3> verts, int start)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0x1286540", Offset = "0x1285340", Length = "0x716")]
	public void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	[Token(Token = "0x6000A20")]
	[Address(RVA = "0x1286C60", Offset = "0x1285A60", Length = "0x177")]
	public int CalculateOffsetToFit(string text)
	{
		return 0;
	}

	[Token(Token = "0x6000A21")]
	[Address(RVA = "0x1286DE0", Offset = "0x1285BE0", Length = "0x1CC")]
	public void SetCurrentProgress()
	{
	}

	[Token(Token = "0x6000A22")]
	[Address(RVA = "0x1286FB0", Offset = "0x1285DB0", Length = "0x245")]
	public void SetCurrentPercent()
	{
	}

	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x1287200", Offset = "0x1286000", Length = "0x15F")]
	public void SetCurrentSelection()
	{
	}

	[Token(Token = "0x6000A24")]
	[Address(RVA = "0x1287360", Offset = "0x1286160", Length = "0x18D")]
	public bool Wrap(string text, out string final)
	{
		final = null;
		return false;
	}

	[Token(Token = "0x6000A25")]
	[Address(RVA = "0x12874F0", Offset = "0x12862F0", Length = "0x192")]
	public bool Wrap(string text, out string final, int height)
	{
		final = null;
		return false;
	}

	[Token(Token = "0x6000A26")]
	[Address(RVA = "0x1287690", Offset = "0x1286490", Length = "0xE7C")]
	public void UpdateNGUIText()
	{
	}

	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x1288510", Offset = "0x1287310", Length = "0xEB")]
	public void AddDynamicSymbolSprite(UISprite uiSprite)
	{
	}

	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x1288600", Offset = "0x1287400", Length = "0xCC")]
	private void ClearDynamicSymbolSprites()
	{
	}

	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x12886D0", Offset = "0x12874D0", Length = "0x75")]
	public int DetermineProcessedLineCount()
	{
		return 0;
	}

	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x1288750", Offset = "0x1287550", Length = "0x1A3")]
	public UILabel()
	{
	}
}
