using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007F0")]
public class SwitchBoxManager
{
	[Token(Token = "0x40054A4")]
	public static List<SwitchBox> m_SwitchBoxes;

	[Token(Token = "0x6004AB2")]
	[Address(RVA = "0xD41C70", Offset = "0xD40A70", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004AB3")]
	[Address(RVA = "0xD41D10", Offset = "0xD40B10", Length = "0xBD")]
	public static void Add(SwitchBox oc)
	{
	}

	[Token(Token = "0x6004AB4")]
	[Address(RVA = "0xD41DD0", Offset = "0xD40BD0", Length = "0x11C")]
	public static void Remove(SwitchBox oc)
	{
	}

	[Token(Token = "0x6004AB5")]
	[Address(RVA = "0xD41EF0", Offset = "0xD40CF0", Length = "0x53B")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6004AB6")]
	[Address(RVA = "0xD42430", Offset = "0xD41230", Length = "0x26E")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6004AB7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SwitchBoxManager()
	{
	}
}
