using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20004F1")]
public class AfflictionRemedy
{
	[Token(Token = "0x4002D56")]
	[FieldOffset(Offset = "0x10")]
	public int m_NumRequired;

	[Token(Token = "0x4002D57")]
	[FieldOffset(Offset = "0x18")]
	public RemedyDefinition m_RemedyDefinition;

	[Token(Token = "0x4002D58")]
	private const string GEAR_PREFIX = "GEAR_";

	[Token(Token = "0x6002574")]
	[Address(RVA = "0x87BBE0", Offset = "0x87A9E0", Length = "0x82")]
	public bool PlayerHasRequiredRemedy()
	{
		return false;
	}

	[Token(Token = "0x6002575")]
	[Address(RVA = "0x87BC70", Offset = "0x87AA70", Length = "0x1B0")]
	public string GetGearItemName()
	{
		return null;
	}

	[Token(Token = "0x6002576")]
	[Address(RVA = "0x87BE30", Offset = "0x87AC30", Length = "0x7")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6002577")]
	[Address(RVA = "0x87BE40", Offset = "0x87AC40", Length = "0x266")]
	public bool IsWaterSupply()
	{
		return false;
	}

	[Token(Token = "0x6002578")]
	[Address(RVA = "0x87C0B0", Offset = "0x87AEB0", Length = "0x295")]
	public string GetDisplayName()
	{
		return null;
	}

	[Token(Token = "0x6002579")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public AfflictionRemedy()
	{
	}
}
