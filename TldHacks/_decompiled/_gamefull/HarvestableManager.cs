using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000753")]
public class HarvestableManager
{
	[Token(Token = "0x4004E3F")]
	public static List<Harvestable> m_Harvestables;

	[Token(Token = "0x600436C")]
	[Address(RVA = "0xC570E0", Offset = "0xC55EE0", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x600436D")]
	[Address(RVA = "0xC57180", Offset = "0xC55F80", Length = "0x112")]
	public static void Add(Harvestable h)
	{
	}

	[Token(Token = "0x600436E")]
	[Address(RVA = "0xC572A0", Offset = "0xC560A0", Length = "0xD3")]
	public static void Remove(Harvestable h)
	{
	}

	[Token(Token = "0x600436F")]
	[Address(RVA = "0xC57380", Offset = "0xC56180", Length = "0x3B7")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6004370")]
	[Address(RVA = "0xC57740", Offset = "0xC56540", Length = "0x1F3")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6004371")]
	[Address(RVA = "0xC57940", Offset = "0xC56740", Length = "0x33E")]
	private static Harvestable FindHarvestableByPosition(HarvestableSaveDataProxy proxy)
	{
		return null;
	}

	[Token(Token = "0x6004372")]
	[Address(RVA = "0xC57C80", Offset = "0xC56A80", Length = "0x117")]
	private static Harvestable FindHarvestableByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6004373")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HarvestableManager()
	{
	}
}
