using System;
using Cpp2ILInjected;

namespace TLD.Gameplay.Tunable;

[Token(Token = "0x20014B5")]
public abstract class CustomTunableLookup<TKey, TElement> where TKey : Enum
{
	[Token(Token = "0x40095CB")]
	private static readonly TKey[] s_enumValues;

	[Token(Token = "0x40095CC")]
	private static readonly string[] s_enumNames;

	[Token(Token = "0x40095CD")]
	[FieldOffset(Offset = "0x0")]
	public TElement[] m_values;

	[Token(Token = "0x60082EA")]
	[Address(RVA = "0x241A2B0", Offset = "0x24190B0", Length = "0x43E")]
	static CustomTunableLookup()
	{
	}

	[Token(Token = "0x60082EB")]
	[Address(RVA = "0x241A6F0", Offset = "0x24194F0", Length = "0x99")]
	public static TKey[] GetValues()
	{
		return null;
	}

	[Token(Token = "0x60082EC")]
	[Address(RVA = "0x241A790", Offset = "0x2419590", Length = "0x9B")]
	public static string[] GetNames()
	{
		return null;
	}

	[Token(Token = "0x60082ED")]
	[Address(RVA = "0x241A830", Offset = "0x2419630", Length = "0x101")]
	public CustomTunableLookup()
	{
	}

	[Token(Token = "0x60082EE")]
	[Address(RVA = "0x241A940", Offset = "0x2419740", Length = "0x1D1")]
	public TElement GetValue(TKey index)
	{
		return default(TElement);
	}
}
