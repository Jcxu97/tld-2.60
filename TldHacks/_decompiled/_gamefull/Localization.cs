using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20000B3")]
public static class Localization
{
	[Token(Token = "0x40005DC")]
	public const string kDefaultLanguage = "English";

	[Token(Token = "0x40005DD")]
	private static StringTable s_SettingsTable;

	[Token(Token = "0x40005DE")]
	private static StringTable s_CurrentLanguageStringTable;

	[Token(Token = "0x40005DF")]
	private static StringTable s_WorkshopStringTable;

	[Token(Token = "0x40005E0")]
	private static StringTable s_FallbackStringTable;

	[Token(Token = "0x40005E1")]
	private static string s_Language;

	[Token(Token = "0x40005E2")]
	private static int s_LanguageIndex;

	[Token(Token = "0x40005E3")]
	private static List<string> s_Languages;

	[Token(Token = "0x40005E4")]
	private static CharacterSet s_CharacterSet;

	[Token(Token = "0x17000085")]
	public static string Language
	{
		[Token(Token = "0x6000600")]
		[Address(RVA = "0xDE85B0", Offset = "0xDE73B0", Length = "0x167")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000601")]
		[Address(RVA = "0xDE8720", Offset = "0xDE7520", Length = "0x136")]
		set
		{
		}
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0xDE8860", Offset = "0xDE7660", Length = "0x58")]
	public static List<string> GetLanguages()
	{
		return null;
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0xDE88C0", Offset = "0xDE76C0", Length = "0x5C0")]
	private static void MaybeLoadLanguageTables()
	{
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0xDE8E90", Offset = "0xDE7C90", Length = "0x14F")]
	private static void MaybeLoadStringTable(string language)
	{
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0xDE8FE0", Offset = "0xDE7DE0", Length = "0x615")]
	private static void LoadStringTableForLanguage(AssetBundleRef assetBundle, string language)
	{
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0xDE9600", Offset = "0xDE8400", Length = "0x314")]
	private static bool ShouldDestroyCurrentStringTable()
	{
		return false;
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0xDE9920", Offset = "0xDE8720", Length = "0x87")]
	private static void LoadAndSelectLanguage(string language)
	{
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0xDE99B0", Offset = "0xDE87B0", Length = "0x42D")]
	private static void LoadWorkshopLocalization()
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0xDE9DE0", Offset = "0xDE8BE0", Length = "0x441")]
	private static void SelectLanguage(string language)
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0xDEA230", Offset = "0xDE9030", Length = "0x1AA")]
	public static string Get(string key)
	{
		return null;
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0xDEA3E0", Offset = "0xDE91E0", Length = "0x4A6")]
	public static string GetForLang(string key, string lang)
	{
		return null;
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0xDEA890", Offset = "0xDE9690", Length = "0x160")]
	private static string GetForFallbackLanguage(string key)
	{
		return null;
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0xDEAA00", Offset = "0xDE9800", Length = "0x17B")]
	public static bool Exists(string key)
	{
		return false;
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0xDEAB80", Offset = "0xDE9980", Length = "0x53")]
	public static CharacterSet GetCharacterSet()
	{
		return default(CharacterSet);
	}
}
