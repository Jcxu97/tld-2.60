using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000048")]
public class InvStat
{
	[Token(Token = "0x2000049")]
	public enum Identifier
	{
		[Token(Token = "0x4000341")]
		Strength,
		[Token(Token = "0x4000342")]
		Constitution,
		[Token(Token = "0x4000343")]
		Agility,
		[Token(Token = "0x4000344")]
		Intelligence,
		[Token(Token = "0x4000345")]
		Damage,
		[Token(Token = "0x4000346")]
		Crit,
		[Token(Token = "0x4000347")]
		Armor,
		[Token(Token = "0x4000348")]
		Health,
		[Token(Token = "0x4000349")]
		Mana,
		[Token(Token = "0x400034A")]
		Other
	}

	[Token(Token = "0x200004A")]
	public enum Modifier
	{
		[Token(Token = "0x400034C")]
		Added,
		[Token(Token = "0x400034D")]
		Percent
	}

	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x10")]
	public Identifier id;

	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x14")]
	public Modifier modifier;

	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x18")]
	public int amount;

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xA1C580", Offset = "0xA1B380", Length = "0x54")]
	public static string GetName(Identifier i)
	{
		return null;
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xA1C5E0", Offset = "0xA1B3E0", Length = "0x150")]
	public static string GetDescription(Identifier i)
	{
		return null;
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xA1C760", Offset = "0xA1B560", Length = "0xB1")]
	public static int CompareArmor(InvStat a, InvStat b)
	{
		return 0;
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xA1C820", Offset = "0xA1B620", Length = "0xB1")]
	public static int CompareWeapon(InvStat a, InvStat b)
	{
		return 0;
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public InvStat()
	{
	}
}
