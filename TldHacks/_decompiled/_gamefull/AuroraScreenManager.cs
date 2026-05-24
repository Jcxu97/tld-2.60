using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20001C6")]
public static class AuroraScreenManager
{
	[Token(Token = "0x20001C7")]
	public class SaveProxy
	{
		[Token(Token = "0x4000F8A")]
		[FieldOffset(Offset = "0x10")]
		public string m_AssignedPrefabsSerialized;

		[Token(Token = "0x600105B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SaveProxy()
		{
		}
	}

	[Token(Token = "0x4000F88")]
	private static HashSet<string> s_PrefabsInUse;

	[Token(Token = "0x4000F89")]
	private static Dictionary<string, string> s_AssignedPrefabs;

	[Token(Token = "0x6001052")]
	[Address(RVA = "0x625B40", Offset = "0x624940", Length = "0x33E")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001053")]
	[Address(RVA = "0x625E80", Offset = "0x624C80", Length = "0x180")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001054")]
	[Address(RVA = "0x626010", Offset = "0x624E10", Length = "0x131")]
	public static void AssociatePrefabWithId(string guid, string prefabName)
	{
	}

	[Token(Token = "0x6001055")]
	[Address(RVA = "0x626150", Offset = "0x624F50", Length = "0xF0")]
	public static string GetPrefabForId(string id)
	{
		return null;
	}

	[Token(Token = "0x6001056")]
	[Address(RVA = "0x626250", Offset = "0x625050", Length = "0x82")]
	public static bool IsPrefabInUse(string prefabName)
	{
		return false;
	}

	[Token(Token = "0x6001057")]
	[Address(RVA = "0x6262E0", Offset = "0x6250E0", Length = "0x94")]
	public static void MarkPrefabAsInUse(string prefabName)
	{
	}

	[Token(Token = "0x6001058")]
	[Address(RVA = "0x626380", Offset = "0x625180", Length = "0x163")]
	public static void RemovePrefabAssociation(string id)
	{
	}

	[Token(Token = "0x6001059")]
	[Address(RVA = "0x6264F0", Offset = "0x6252F0", Length = "0xE2")]
	public static void Reset()
	{
	}
}
