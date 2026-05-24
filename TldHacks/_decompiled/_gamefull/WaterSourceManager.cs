using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007F6")]
public class WaterSourceManager
{
	[Token(Token = "0x40054C2")]
	public static List<WaterSource> m_WaterSources;

	[Token(Token = "0x6004AE4")]
	[Address(RVA = "0xD472E0", Offset = "0xD460E0", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004AE5")]
	[Address(RVA = "0xD47380", Offset = "0xD46180", Length = "0x1FC")]
	public static void DisableAll()
	{
	}

	[Token(Token = "0x6004AE6")]
	[Address(RVA = "0xD47580", Offset = "0xD46380", Length = "0x5CF")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004AE7")]
	[Address(RVA = "0xD47B50", Offset = "0xD46950", Length = "0x41E")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004AE8")]
	[Address(RVA = "0xD47F70", Offset = "0xD46D70", Length = "0x2FB")]
	private static WaterSource FindWaterSourceByPosition(WaterSourceSaveData wsd)
	{
		return null;
	}

	[Token(Token = "0x6004AE9")]
	[Address(RVA = "0xD48270", Offset = "0xD47070", Length = "0x117")]
	private static WaterSource FindWaterSourceByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6004AEA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WaterSourceManager()
	{
	}
}
