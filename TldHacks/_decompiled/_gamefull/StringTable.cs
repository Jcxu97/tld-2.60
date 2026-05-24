using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(order = 100)]
[Token(Token = "0x2000702")]
public class StringTable : StringTableData
{
	[Token(Token = "0x4004A45")]
	private const string LEGACY_CYRILLIC_OVERRIDE_KEY = "UseCyrillicFont";

	[Token(Token = "0x4004A46")]
	public const string CHARACTER_SET_KEY = "CharacterSet";

	[Token(Token = "0x4004A47")]
	private const string CHARACTER_SET_LATIN = "Latin";

	[Token(Token = "0x4004A48")]
	private const string CHARACTER_SET_CYRILLIC = "Cyrillic";

	[Token(Token = "0x4004A49")]
	private const string CHARACTER_SET_CJK = "CJK";

	[Token(Token = "0x4004A4A")]
	private const string CHARACTER_SET_INUKTITUT = "Inuktitut";

	[Token(Token = "0x4004A4B")]
	public const string NOTES_LANGUAGE = "NOTES";

	[SerializeField]
	[Token(Token = "0x4004A4C")]
	[FieldOffset(Offset = "0x20")]
	private List<string> m_Languages;

	[SerializeField]
	[Token(Token = "0x4004A4D")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsGeneratedByCode;

	[SerializeField]
	[Token(Token = "0x4004A4E")]
	[FieldOffset(Offset = "0x30")]
	private List<StringTableData> m_OverflowDataFiles;

	[SerializeField]
	[Token(Token = "0x4004A4F")]
	[FieldOffset(Offset = "0x38")]
	private string m_OverflowDataFolder;

	[Token(Token = "0x4004A50")]
	private const int ENTRY_LIMIT = 5000;

	[Token(Token = "0x4004A51")]
	private const string OVERFLOW_FILENAME_FORMAT = "{0}_OverflowData_{1}.asset";

	[Token(Token = "0x4004A52")]
	[FieldOffset(Offset = "0x40")]
	private List<StringTableData> m_DataFiles;

	[Token(Token = "0x4004A53")]
	[FieldOffset(Offset = "0x48")]
	private List<Entry> m_AllEntries;

	[Token(Token = "0x4004A54")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<string, Entry> m_EntriesMap;

	[Token(Token = "0x4004A55")]
	[FieldOffset(Offset = "0x58")]
	private StringTableData m_CurrentDataFile;

	[Token(Token = "0x4004A56")]
	private const int INVALID_LANGUAGE = -1;

	[Token(Token = "0x6003D66")]
	[Address(RVA = "0xB97850", Offset = "0xB96650", Length = "0x125")]
	private bool IsUsingLegacyCyrillicOverride(string language)
	{
		return false;
	}

	[Token(Token = "0x6003D67")]
	[Address(RVA = "0xB97980", Offset = "0xB96780", Length = "0x7A")]
	public CharacterSet GetCharacterSetForLanguage(int languageIndex)
	{
		return default(CharacterSet);
	}

	[Token(Token = "0x6003D68")]
	[Address(RVA = "0xB97A00", Offset = "0xB96800", Length = "0x265")]
	public CharacterSet GetCharacterSetForLanguage(string language)
	{
		return default(CharacterSet);
	}

	[Token(Token = "0x6003D69")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public List<string> GetLanguages()
	{
		return null;
	}

	[Token(Token = "0x6003D6A")]
	[Address(RVA = "0xB97C70", Offset = "0xB96A70", Length = "0x9")]
	public bool IsInitialized()
	{
		return false;
	}

	[Token(Token = "0x6003D6B")]
	[Address(RVA = "0xB97C80", Offset = "0xB96A80", Length = "0x5")]
	public bool IsGeneratedByCode()
	{
		return false;
	}

	[Token(Token = "0x6003D6C")]
	[Address(RVA = "0xB97C90", Offset = "0xB96A90", Length = "0x5")]
	public void SetGeneratedByCode()
	{
	}

	[Token(Token = "0x6003D6D")]
	[Address(RVA = "0xB97CA0", Offset = "0xB96AA0", Length = "0xF1")]
	public string GetStringForKeyAndLanguage(string key, string language)
	{
		return null;
	}

	[Token(Token = "0x6003D6E")]
	[Address(RVA = "0xB97DA0", Offset = "0xB96BA0", Length = "0xA0")]
	public string GetStringForKeyAndLanguage(string key, int languageIndex)
	{
		return null;
	}

	[Token(Token = "0x6003D6F")]
	[Address(RVA = "0xB97E50", Offset = "0xB96C50", Length = "0x2A9")]
	public void AddNewLanguage(string language)
	{
	}

	[Token(Token = "0x6003D70")]
	[Address(RVA = "0xB98100", Offset = "0xB96F00", Length = "0x17")]
	public bool HasLanguage(string language)
	{
		return false;
	}

	[Token(Token = "0x6003D71")]
	[Address(RVA = "0xB98120", Offset = "0xB96F20", Length = "0x196")]
	public int IndexOfLanguage(string language)
	{
		return 0;
	}

	[Token(Token = "0x6003D72")]
	[Address(RVA = "0xB982C0", Offset = "0xB970C0", Length = "0x64B")]
	private void InitializeData(bool forceInit = false)
	{
	}

	[Token(Token = "0x6003D73")]
	[Address(RVA = "0xB98910", Offset = "0xB97710", Length = "0x4E")]
	public int GetNumEntries()
	{
		return 0;
	}

	[Token(Token = "0x6003D74")]
	[Address(RVA = "0xB98960", Offset = "0xB97760", Length = "0x7D")]
	public bool DoesKeyExist(string key)
	{
		return false;
	}

	[Token(Token = "0x6003D75")]
	[Address(RVA = "0xB989E0", Offset = "0xB977E0", Length = "0x46D")]
	private Entry AddEntryForKey(string key)
	{
		return null;
	}

	[Token(Token = "0x6003D76")]
	[Address(RVA = "0xB98E50", Offset = "0xB97C50", Length = "0x8A")]
	private Entry GetEntryFromKey(string key)
	{
		return null;
	}

	[Token(Token = "0x6003D77")]
	[Address(RVA = "0xB98EE0", Offset = "0xB97CE0", Length = "0xD9")]
	public string GetKeyForEntry(int index)
	{
		return null;
	}

	[Token(Token = "0x6003D78")]
	[Address(RVA = "0xB98FC0", Offset = "0xB97DC0", Length = "0x2B7")]
	private void RemoveEntryForKey(string key)
	{
	}

	[Token(Token = "0x6003D79")]
	[Address(RVA = "0xB99280", Offset = "0xB98080", Length = "0x6F")]
	private bool ShouldImportLanguage(string language, List<string> importLanguages)
	{
		return false;
	}

	[Token(Token = "0x6003D7A")]
	[Address(RVA = "0xB992F0", Offset = "0xB980F0", Length = "0x440")]
	public List<string> ImportCsv(string path, List<string> filterLanguages)
	{
		return null;
	}

	[Token(Token = "0x6003D7B")]
	[Address(RVA = "0xB99740", Offset = "0xB98540", Length = "0x337")]
	private int[] ParseLanguages(BetterList<string> languages, List<string> filterLanguages)
	{
		return null;
	}

	[Token(Token = "0x6003D7C")]
	[Address(RVA = "0xB99A80", Offset = "0xB98880", Length = "0x11C")]
	private void AddOrUpdateTableEntry(string key, BetterList<string> importEntryLanguages, int[] languageIndexes)
	{
	}

	[Token(Token = "0x6003D7D")]
	[Address(RVA = "0xB99BA0", Offset = "0xB989A0", Length = "0x262")]
	public StringTable()
	{
	}
}
