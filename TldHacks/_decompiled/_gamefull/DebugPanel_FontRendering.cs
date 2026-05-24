using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x20005CF")]
public class DebugPanel_FontRendering : Panel_Base
{
	[Serializable]
	[Token(Token = "0x20005D0")]
	public class FontTest
	{
		[HideInInspector]
		[Token(Token = "0x40035BD")]
		[FieldOffset(Offset = "0x10")]
		public string m_TestName;

		[HideInInspector]
		[Token(Token = "0x40035BE")]
		[FieldOffset(Offset = "0x18")]
		public string m_UnicodeRangeInfo;

		[Token(Token = "0x40035BF")]
		[FieldOffset(Offset = "0x20")]
		public CharacterSet m_CharacterSet;

		[Token(Token = "0x40035C0")]
		[FieldOffset(Offset = "0x28")]
		public List<string> m_Languages;

		[TextArea]
		[Token(Token = "0x40035C1")]
		[FieldOffset(Offset = "0x30")]
		public string m_TestString;

		[Token(Token = "0x6002D26")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public FontTest()
		{
		}
	}

	[Token(Token = "0x40035AF")]
	private const string IGNORE_RANGE_CHARACTERS = "ªº";

	[Token(Token = "0x40035B0")]
	private const int CHARACTERS_PER_LINE = 30;

	[Token(Token = "0x40035B1")]
	private const int LINES_PER_PAGE = 10;

	[Token(Token = "0x40035B2")]
	private const int CHARACTERS_PER_PAGE = 300;

	[Token(Token = "0x40035B3")]
	[FieldOffset(Offset = "0x28")]
	public StringTable m_LocalizationStringTable;

	[Token(Token = "0x40035B4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_CharacterSetLabel;

	[Token(Token = "0x40035B5")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_FontLabel;

	[Token(Token = "0x40035B6")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_UnicodeRangeLabel;

	[Token(Token = "0x40035B7")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_FontRendering;

	[Token(Token = "0x40035B8")]
	[FieldOffset(Offset = "0x50")]
	public TMP_Text m_TMPFontRendering;

	[Token(Token = "0x40035B9")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_FontRendererInfo;

	[Token(Token = "0x40035BA")]
	[FieldOffset(Offset = "0x60")]
	public List<FontTest> m_FontTests;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x40035BB")]
	[FieldOffset(Offset = "0x68")]
	private List<FontTest> m_BakedFontTests;

	[Token(Token = "0x40035BC")]
	[FieldOffset(Offset = "0x70")]
	private int m_CurrentIndex;

	[Token(Token = "0x6002D17")]
	[Address(RVA = "0x93FFA0", Offset = "0x93EDA0", Length = "0x2D")]
	public override void Initialize()
	{
	}

	[ContextMenu("Bake Font Tests")]
	[Token(Token = "0x6002D18")]
	[Address(RVA = "0x93FFD0", Offset = "0x93EDD0", Length = "0x72E")]
	private void PrepareFontTests()
	{
	}

	[Token(Token = "0x6002D19")]
	[Address(RVA = "0x940700", Offset = "0x93F500", Length = "0x153")]
	private string GetTestName(FontTest fontTest)
	{
		return null;
	}

	[Token(Token = "0x6002D1A")]
	[Address(RVA = "0x940860", Offset = "0x93F660", Length = "0x144")]
	private string GetUnicodeRangeInfoString(List<char> chars, int start, int end)
	{
		return null;
	}

	[Token(Token = "0x6002D1B")]
	[Address(RVA = "0x9409B0", Offset = "0x93F7B0", Length = "0xE3")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002D1C")]
	[Address(RVA = "0x940AA0", Offset = "0x93F8A0", Length = "0x214")]
	private void Update()
	{
	}

	[Token(Token = "0x6002D1D")]
	[Address(RVA = "0x940CC0", Offset = "0x93FAC0", Length = "0x9B")]
	public void OnPrevPage()
	{
	}

	[Token(Token = "0x6002D1E")]
	[Address(RVA = "0x940D60", Offset = "0x93FB60", Length = "0xA2")]
	public void OnNextPage()
	{
	}

	[Token(Token = "0x6002D1F")]
	[Address(RVA = "0x940E10", Offset = "0x93FC10", Length = "0x290")]
	public void SwitchFontRenderer()
	{
	}

	[Token(Token = "0x6002D20")]
	[Address(RVA = "0x7F6DB0", Offset = "0x7F5BB0", Length = "0x13")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6002D21")]
	[Address(RVA = "0x9410B0", Offset = "0x93FEB0", Length = "0x335")]
	private void RenderFontTest(FontTest fontTest)
	{
	}

	[Token(Token = "0x6002D22")]
	[Address(RVA = "0x9413F0", Offset = "0x9401F0", Length = "0x423")]
	private List<char> GetAllCharactersForFontTest(FontTest fontTest)
	{
		return null;
	}

	[Token(Token = "0x6002D23")]
	[Address(RVA = "0x941820", Offset = "0x940620", Length = "0x25D")]
	private List<string> GetAllLanguagesWithCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[Token(Token = "0x6002D24")]
	[Address(RVA = "0x941A80", Offset = "0x940880", Length = "0x2E2")]
	private List<char> GetAllCharactersInLanguage(string lang)
	{
		return null;
	}

	[Token(Token = "0x6002D25")]
	[Address(RVA = "0x941D70", Offset = "0x940B70", Length = "0xE3")]
	public DebugPanel_FontRendering()
	{
	}
}
