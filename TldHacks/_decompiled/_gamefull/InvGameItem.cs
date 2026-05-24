using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000046")]
public class InvGameItem
{
	[Token(Token = "0x2000047")]
	public enum Quality
	{
		[Token(Token = "0x4000330")]
		Broken,
		[Token(Token = "0x4000331")]
		Cursed,
		[Token(Token = "0x4000332")]
		Damaged,
		[Token(Token = "0x4000333")]
		Worn,
		[Token(Token = "0x4000334")]
		Sturdy,
		[Token(Token = "0x4000335")]
		Polished,
		[Token(Token = "0x4000336")]
		Improved,
		[Token(Token = "0x4000337")]
		Crafted,
		[Token(Token = "0x4000338")]
		Superior,
		[Token(Token = "0x4000339")]
		Enchanted,
		[Token(Token = "0x400033A")]
		Epic,
		[Token(Token = "0x400033B")]
		Legendary,
		[Token(Token = "0x400033C")]
		_LastDoNotUse
	}

	[SerializeField]
	[Token(Token = "0x400032B")]
	[FieldOffset(Offset = "0x10")]
	private int mBaseItemID;

	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x14")]
	public Quality quality;

	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x18")]
	public int itemLevel;

	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x20")]
	private InvBaseItem mBaseItem;

	[Token(Token = "0x1700002C")]
	public int baseItemID
	{
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x40E0A0", Offset = "0x40CEA0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700002D")]
	public InvBaseItem baseItem
	{
		[Token(Token = "0x600034D")]
		[Address(RVA = "0xA1BD30", Offset = "0xA1AB30", Length = "0xAF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002E")]
	public string name
	{
		[Token(Token = "0x600034E")]
		[Address(RVA = "0xA1BDE0", Offset = "0xA1ABE0", Length = "0xB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002F")]
	public float statMultiplier
	{
		[Token(Token = "0x600034F")]
		[Address(RVA = "0xA1BEA0", Offset = "0xA1ACA0", Length = "0xBC")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000030")]
	public Color color
	{
		[Token(Token = "0x6000350")]
		[Address(RVA = "0xA1BF90", Offset = "0xA1AD90", Length = "0x118")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xA1C0E0", Offset = "0xA1AEE0", Length = "0x12")]
	public InvGameItem(int id)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xA1C100", Offset = "0xA1AF00", Length = "0x62")]
	public InvGameItem(int id, InvBaseItem bi)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xA1C170", Offset = "0xA1AF70", Length = "0x3D8")]
	public List<InvStat> CalculateStats()
	{
		return null;
	}
}
