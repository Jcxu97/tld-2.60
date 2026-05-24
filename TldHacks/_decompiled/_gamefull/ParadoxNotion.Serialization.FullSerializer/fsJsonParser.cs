using System.Text;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D99")]
public class fsJsonParser
{
	[Token(Token = "0x4008447")]
	[FieldOffset(Offset = "0x10")]
	private int _start;

	[Token(Token = "0x4008448")]
	[FieldOffset(Offset = "0x18")]
	private string _input;

	[Token(Token = "0x4008449")]
	[FieldOffset(Offset = "0x20")]
	private readonly StringBuilder _cachedStringBuilder;

	[Token(Token = "0x60069ED")]
	[Address(RVA = "0x107A800", Offset = "0x1079600", Length = "0x1BD")]
	private fsResult MakeFailure(string message)
	{
		return default(fsResult);
	}

	[Token(Token = "0x60069EE")]
	[Address(RVA = "0x107A9C0", Offset = "0x10797C0", Length = "0x2D")]
	private bool TryMoveNext()
	{
		return false;
	}

	[Token(Token = "0x60069EF")]
	[Address(RVA = "0x107A9F0", Offset = "0x10797F0", Length = "0x2B")]
	private bool HasValue()
	{
		return false;
	}

	[Token(Token = "0x60069F0")]
	[Address(RVA = "0x107AA20", Offset = "0x1079820", Length = "0x2E")]
	private bool HasValue(int offset)
	{
		return false;
	}

	[Token(Token = "0x60069F1")]
	[Address(RVA = "0x107AA50", Offset = "0x1079850", Length = "0x34")]
	private char Character()
	{
		return '\0';
	}

	[Token(Token = "0x60069F2")]
	[Address(RVA = "0x107AA90", Offset = "0x1079890", Length = "0x37")]
	private char Character(int offset)
	{
		return '\0';
	}

	[Token(Token = "0x60069F3")]
	[Address(RVA = "0x107AAD0", Offset = "0x10798D0", Length = "0x2A3")]
	private void SkipSpace()
	{
	}

	[Token(Token = "0x60069F4")]
	[Address(RVA = "0x107AD80", Offset = "0x1079B80", Length = "0x26")]
	private bool IsHex(char c)
	{
		return false;
	}

	[Token(Token = "0x60069F5")]
	[Address(RVA = "0x107ADB0", Offset = "0x1079BB0", Length = "0x3F")]
	private uint ParseSingleChar(char c1, uint multipliyer)
	{
		return 0u;
	}

	[Token(Token = "0x60069F6")]
	[Address(RVA = "0x107ADF0", Offset = "0x1079BF0", Length = "0x138")]
	private uint ParseUnicode(char c1, char c2, char c3, char c4)
	{
		return 0u;
	}

	[Token(Token = "0x60069F7")]
	[Address(RVA = "0x107AF30", Offset = "0x1079D30", Length = "0x877")]
	private fsResult TryUnescapeChar(out char escaped)
	{
		escaped = default(char);
		return default(fsResult);
	}

	[Token(Token = "0x60069F8")]
	[Address(RVA = "0x107B7B0", Offset = "0x107A5B0", Length = "0x1A7")]
	private fsResult TryParseExact(string content)
	{
		return default(fsResult);
	}

	[Token(Token = "0x60069F9")]
	[Address(RVA = "0x107B960", Offset = "0x107A760", Length = "0x1A9")]
	private fsResult TryParseTrue(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Token(Token = "0x60069FA")]
	[Address(RVA = "0x107BB10", Offset = "0x107A910", Length = "0x1A9")]
	private fsResult TryParseFalse(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Token(Token = "0x60069FB")]
	[Address(RVA = "0x107BCC0", Offset = "0x107AAC0", Length = "0x1F9")]
	private fsResult TryParseNull(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Token(Token = "0x60069FC")]
	[Address(RVA = "0x107BEC0", Offset = "0x107ACC0", Length = "0x4D")]
	private bool IsSeparator(char c)
	{
		return false;
	}

	[Token(Token = "0x60069FD")]
	[Address(RVA = "0x107BF10", Offset = "0x107AD10", Length = "0x5C5")]
	private fsResult TryParseNumber(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Token(Token = "0x60069FE")]
	[Address(RVA = "0x107C4E0", Offset = "0x107B2E0", Length = "0x34D")]
	private fsResult TryParseString(out string str)
	{
		str = null;
		return default(fsResult);
	}

	[Token(Token = "0x60069FF")]
	[Address(RVA = "0x107C830", Offset = "0x107B630", Length = "0x420")]
	private fsResult TryParseArray(out fsData arr)
	{
		arr = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A00")]
	[Address(RVA = "0x107CC60", Offset = "0x107BA60", Length = "0xA1B")]
	private fsResult TryParseObject(out fsData obj)
	{
		obj = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A01")]
	[Address(RVA = "0x107D680", Offset = "0x107C480", Length = "0x670")]
	private fsResult RunParse(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A02")]
	[Address(RVA = "0x107DD20", Offset = "0x107CB20", Length = "0x265")]
	public static fsResult Parse(string input, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A03")]
	[Address(RVA = "0x107DF90", Offset = "0x107CD90", Length = "0xE7")]
	public static fsData Parse(string input)
	{
		return null;
	}

	[Token(Token = "0x6006A04")]
	[Address(RVA = "0x107E080", Offset = "0x107CE80", Length = "0x165")]
	private fsJsonParser(string input)
	{
	}
}
