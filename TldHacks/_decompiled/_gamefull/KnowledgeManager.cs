using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000780")]
public class KnowledgeManager
{
	[Token(Token = "0x400506E")]
	public static Dictionary<string, string> m_TrustDict;

	[Token(Token = "0x400506F")]
	public static Dictionary<string, KnowledgeCateogry> m_KnowledgeDict;

	[Token(Token = "0x4005070")]
	public static Dictionary<string, string> m_NameRefDict;

	[Token(Token = "0x6004653")]
	[Address(RVA = "0xCA1270", Offset = "0xCA0070", Length = "0x11D")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004654")]
	[Address(RVA = "0xCA1390", Offset = "0xCA0190", Length = "0x9B")]
	public static bool KnowledgeIsUnlocked(string locID)
	{
		return false;
	}

	[Token(Token = "0x6004655")]
	[Address(RVA = "0xCA1430", Offset = "0xCA0230", Length = "0x232")]
	public static void AddKnowledge(KnowledgeCateogry category, string nameLocID, string descLocID, bool showNotificationFlag = true)
	{
	}

	[Token(Token = "0x6004656")]
	[Address(RVA = "0xCA1670", Offset = "0xCA0470", Length = "0x114")]
	public static void LinkTrustToKnowledge(string trustID, string locID)
	{
	}

	[Token(Token = "0x6004657")]
	[Address(RVA = "0xCA1790", Offset = "0xCA0590", Length = "0x129")]
	public static void RemoveKnowledge(string locID)
	{
	}

	[Token(Token = "0x6004658")]
	[Address(RVA = "0xCA18C0", Offset = "0xCA06C0", Length = "0x387")]
	public static List<string> GetListUnlockedKnowledgeOfType(KnowledgeCateogry knowledgeType)
	{
		return null;
	}

	[Token(Token = "0x6004659")]
	[Address(RVA = "0xCA1C50", Offset = "0xCA0A50", Length = "0x106")]
	public static string GetNameIDFromDescID(string descLocID)
	{
		return null;
	}

	[Token(Token = "0x600465A")]
	[Address(RVA = "0xCA1D60", Offset = "0xCA0B60", Length = "0x301")]
	public static string GetTrustIDFromDescID(string descLocID)
	{
		return null;
	}

	[Token(Token = "0x600465B")]
	[Address(RVA = "0xCA2070", Offset = "0xCA0E70", Length = "0x792")]
	public static void DumpKnowledgeToDebugLog()
	{
	}

	[Token(Token = "0x600465C")]
	[Address(RVA = "0xCA2810", Offset = "0xCA1610", Length = "0x30A")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600465D")]
	[Address(RVA = "0xCA2B20", Offset = "0xCA1920", Length = "0x296")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x600465E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public KnowledgeManager()
	{
	}
}
