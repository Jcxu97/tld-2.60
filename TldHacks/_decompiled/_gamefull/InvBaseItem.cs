using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000042")]
public class InvBaseItem
{
	[Token(Token = "0x2000043")]
	public enum Slot
	{
		[Token(Token = "0x400031B")]
		None,
		[Token(Token = "0x400031C")]
		Weapon,
		[Token(Token = "0x400031D")]
		Shield,
		[Token(Token = "0x400031E")]
		Body,
		[Token(Token = "0x400031F")]
		Shoulders,
		[Token(Token = "0x4000320")]
		Bracers,
		[Token(Token = "0x4000321")]
		Boots,
		[Token(Token = "0x4000322")]
		Trinket,
		[Token(Token = "0x4000323")]
		_LastDoNotUse
	}

	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x10")]
	public int id16;

	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x20")]
	public string description;

	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0x28")]
	public Slot slot;

	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x2C")]
	public int minItemLevel;

	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x30")]
	public int maxItemLevel;

	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x38")]
	public List<InvStat> stats;

	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x40")]
	public GameObject attachment;

	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x48")]
	public Color color;

	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x58")]
	public UIAtlas iconAtlas;

	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x60")]
	public string iconName;

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xA1AAB0", Offset = "0xA198B0", Length = "0x156")]
	public InvBaseItem()
	{
	}
}
