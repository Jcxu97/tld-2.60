using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000A8E")]
public static class XboxPlayerPrefs
{
	[Token(Token = "0x4006815")]
	private static Dictionary<string, string> m_StringsDict;

	[Token(Token = "0x4006816")]
	private static Dictionary<string, int> m_IntsDict;

	[Token(Token = "0x4006817")]
	private static Dictionary<string, float> m_FloatsDict;

	[Token(Token = "0x6005B9E")]
	[Address(RVA = "0xF2E280", Offset = "0xF2D080", Length = "0x179")]
	public static bool HasKey(string a_Key)
	{
		return false;
	}

	[Token(Token = "0x6005B9F")]
	[Address(RVA = "0xF2E400", Offset = "0xF2D200", Length = "0x268")]
	public static void DeleteKey(string a_Key)
	{
	}

	[Token(Token = "0x6005BA0")]
	[Address(RVA = "0xF2E670", Offset = "0xF2D470", Length = "0xE1")]
	public static void DeleteAll()
	{
	}

	[Token(Token = "0x6005BA1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void Save()
	{
	}

	[Token(Token = "0x6005BA2")]
	[Address(RVA = "0xF2E760", Offset = "0xF2D560", Length = "0xAC")]
	public static void SetString(string a_Key, string a_Value)
	{
	}

	[Token(Token = "0x6005BA3")]
	[Address(RVA = "0xF2E810", Offset = "0xF2D610", Length = "0x121")]
	public static string GetString(string a_Key)
	{
		return null;
	}

	[Token(Token = "0x6005BA4")]
	[Address(RVA = "0xF2E940", Offset = "0xF2D740", Length = "0x100")]
	public static string GetString(string a_Key, string a_DefaultValue)
	{
		return null;
	}

	[Token(Token = "0x6005BA5")]
	[Address(RVA = "0xF2EA50", Offset = "0xF2D850", Length = "0xAC")]
	public static void SetInt(string a_Key, int a_Value)
	{
	}

	[Token(Token = "0x6005BA6")]
	[Address(RVA = "0xF2EB00", Offset = "0xF2D900", Length = "0x123")]
	public static int GetInt(string a_Key)
	{
		return 0;
	}

	[Token(Token = "0x6005BA7")]
	[Address(RVA = "0xF2EC30", Offset = "0xF2DA30", Length = "0x100")]
	public static int GetInt(string a_Key, int a_DefaultValue)
	{
		return 0;
	}

	[Token(Token = "0x6005BA8")]
	[Address(RVA = "0xF2ED40", Offset = "0xF2DB40", Length = "0xAE")]
	public static void SetFloat(string a_Key, float a_Value)
	{
	}

	[Token(Token = "0x6005BA9")]
	[Address(RVA = "0xF2EDF0", Offset = "0xF2DBF0", Length = "0x124")]
	public static float GetFloat(string a_Key)
	{
		return 0f;
	}

	[Token(Token = "0x6005BAA")]
	[Address(RVA = "0xF2EF20", Offset = "0xF2DD20", Length = "0x103")]
	public static float GetFloat(string a_Key, float a_DefaultValue)
	{
		return 0f;
	}
}
