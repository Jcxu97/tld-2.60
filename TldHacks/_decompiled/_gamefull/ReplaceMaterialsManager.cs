using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007C6")]
public class ReplaceMaterialsManager
{
	[Token(Token = "0x40053A4")]
	public static List<ReplaceMaterial> m_ReplaceMaterials;

	[Token(Token = "0x600497B")]
	[Address(RVA = "0xD1F990", Offset = "0xD1E790", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x600497C")]
	[Address(RVA = "0xD1FA30", Offset = "0xD1E830", Length = "0xBD")]
	public static void Add(ReplaceMaterial rm)
	{
	}

	[Token(Token = "0x600497D")]
	[Address(RVA = "0xD1FAF0", Offset = "0xD1E8F0", Length = "0x51B")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x600497E")]
	[Address(RVA = "0xD20010", Offset = "0xD1EE10", Length = "0x26E")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x600497F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ReplaceMaterialsManager()
	{
	}
}
