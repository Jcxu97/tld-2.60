using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000790")]
public class OpenCloseManager
{
	[Token(Token = "0x40050ED")]
	public static List<OpenClose> m_OpenClosers;

	[Token(Token = "0x40050EE")]
	public static List<OpenClose> s_ActiveOpenClosers;

	[Token(Token = "0x60046AA")]
	[Address(RVA = "0xCAEB70", Offset = "0xCAD970", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x60046AB")]
	[Address(RVA = "0xCAEC10", Offset = "0xCADA10", Length = "0xBD")]
	public static void Add(OpenClose oc)
	{
	}

	[Token(Token = "0x60046AC")]
	[Address(RVA = "0xCAECD0", Offset = "0xCADAD0", Length = "0x11C")]
	public static void Remove(OpenClose oc)
	{
	}

	[Token(Token = "0x60046AD")]
	[Address(RVA = "0xCAEDF0", Offset = "0xCADBF0", Length = "0x321")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x60046AE")]
	[Address(RVA = "0xCAF120", Offset = "0xCADF20", Length = "0x26E")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x60046AF")]
	[Address(RVA = "0xCAF390", Offset = "0xCAE190", Length = "0x2A3")]
	public static void UpdateAll()
	{
	}

	[Token(Token = "0x60046B0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public OpenCloseManager()
	{
	}
}
