using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000719")]
public class CollectionManager
{
	[Token(Token = "0x4004B75")]
	public static Dictionary<int, string> m_UnlockedCairnsDict;

	[Token(Token = "0x4004B76")]
	public static HashSet<string> m_UnlockedAuroraSet;

	[Token(Token = "0x6003E50")]
	[Address(RVA = "0xC09B10", Offset = "0xC08910", Length = "0xEA")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6003E51")]
	[Address(RVA = "0xC09C00", Offset = "0xC08A00", Length = "0x112")]
	public static void UnlockCairn(Cairn cairn)
	{
	}

	[Token(Token = "0x6003E52")]
	[Address(RVA = "0xC09D20", Offset = "0xC08B20", Length = "0x229")]
	public static void UnlockAuroraScreen(AuroraScreenDisplay screen)
	{
	}

	[Token(Token = "0x6003E53")]
	[Address(RVA = "0xC09F50", Offset = "0xC08D50", Length = "0x22D")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003E54")]
	[Address(RVA = "0xC0A180", Offset = "0xC08F80", Length = "0x209")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003E55")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CollectionManager()
	{
	}
}
