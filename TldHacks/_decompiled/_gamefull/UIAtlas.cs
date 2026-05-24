using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Atlas")]
[Token(Token = "0x20000F3")]
public class UIAtlas : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000F4")]
	private class Sprite
	{
		[Token(Token = "0x4000799")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x18")]
		public Rect outer;

		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x28")]
		public Rect inner;

		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x38")]
		public bool rotated;

		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x3C")]
		public float paddingLeft;

		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0x40")]
		public float paddingRight;

		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x44")]
		public float paddingTop;

		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x48")]
		public float paddingBottom;

		[Token(Token = "0x17000104")]
		public bool hasPadding
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x1135790", Offset = "0x1134590", Length = "0x39")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x11357D0", Offset = "0x11345D0", Length = "0x8E")]
		public Sprite()
		{
		}
	}

	[Token(Token = "0x20000F5")]
	private enum Coordinates
	{
		[Token(Token = "0x40007A2")]
		Pixels,
		[Token(Token = "0x40007A3")]
		TexCoords
	}

	[HideInInspector]
	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x20")]
	public string missingTextureSpriteName;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x28")]
	private Material material;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x30")]
	private List<UISpriteData> mSprites;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x38")]
	private float mPixelSize;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x40")]
	private UIAtlas mReplacement;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0x48")]
	private Coordinates mCoordinates;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x50")]
	private List<Sprite> sprites;

	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x58")]
	private int mPMA;

	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<string, int> mSpriteIndices;

	[Token(Token = "0x170000FE")]
	public Material spriteMaterial
	{
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x11320D0", Offset = "0x1130ED0", Length = "0xED")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x11321C0", Offset = "0x1130FC0", Length = "0x253")]
		set
		{
		}
	}

	[Token(Token = "0x170000FF")]
	public bool premultipliedAlpha
	{
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x1132420", Offset = "0x1131220", Length = "0x29A")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000100")]
	public List<UISpriteData> spriteList
	{
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x11326C0", Offset = "0x11314C0", Length = "0x117")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x11327E0", Offset = "0x11315E0", Length = "0x14B")]
		set
		{
		}
	}

	[Token(Token = "0x17000101")]
	public Texture texture
	{
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1132930", Offset = "0x1131730", Length = "0x19A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000102")]
	public float pixelSize
	{
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x1132AD0", Offset = "0x11318D0", Length = "0xEE")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x1132BC0", Offset = "0x11319C0", Length = "0x132")]
		set
		{
		}
	}

	[Token(Token = "0x17000103")]
	public UIAtlas replacement
	{
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x1132D00", Offset = "0x1131B00", Length = "0x542")]
		set
		{
		}
	}

	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x1133250", Offset = "0x1132050", Length = "0x64A")]
	public UISpriteData GetSprite(string name)
	{
		return null;
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x11338A0", Offset = "0x11326A0", Length = "0x2ED")]
	public string GetRandomSprite(string startsWith)
	{
		return null;
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x1133B90", Offset = "0x1132990", Length = "0x11A")]
	public void MarkSpriteListAsChanged()
	{
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x1133CB0", Offset = "0x1132AB0", Length = "0x177")]
	public void SortAlphabetically()
	{
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x1133E30", Offset = "0x1132C30", Length = "0x1F2")]
	public BetterList<string> GetListOfSprites()
	{
		return null;
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x1134030", Offset = "0x1132E30", Length = "0x4E2")]
	public BetterList<string> GetListOfSprites(string match)
	{
		return null;
	}

	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x1134520", Offset = "0x1133320", Length = "0x243")]
	private bool References(UIAtlas atlas)
	{
		return false;
	}

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x1134770", Offset = "0x1133570", Length = "0x210")]
	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		return false;
	}

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x1134980", Offset = "0x1133780", Length = "0x51E")]
	public void MarkAsChanged()
	{
	}

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x1134EA0", Offset = "0x1133CA0", Length = "0x6BA")]
	private bool Upgrade()
	{
		return false;
	}

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x1135560", Offset = "0x1134360", Length = "0x221")]
	public UIAtlas()
	{
	}
}
