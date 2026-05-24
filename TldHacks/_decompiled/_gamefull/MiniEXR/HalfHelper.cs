using Cpp2ILInjected;

namespace MiniEXR;

[Token(Token = "0x2000D40")]
internal static class HalfHelper
{
	[Token(Token = "0x40082BC")]
	private static uint[] mantissaTable;

	[Token(Token = "0x40082BD")]
	private static uint[] exponentTable;

	[Token(Token = "0x40082BE")]
	private static ushort[] offsetTable;

	[Token(Token = "0x40082BF")]
	private static ushort[] baseTable;

	[Token(Token = "0x40082C0")]
	private static sbyte[] shiftTable;

	[Token(Token = "0x60067F0")]
	[Address(RVA = "0x105BC70", Offset = "0x105AA70", Length = "0x29")]
	private static uint ConvertMantissa(int i)
	{
		return 0u;
	}

	[Token(Token = "0x60067F1")]
	[Address(RVA = "0x105BCA0", Offset = "0x105AAA0", Length = "0x10F")]
	private static uint[] GenerateMantissaTable()
	{
		return null;
	}

	[Token(Token = "0x60067F2")]
	[Address(RVA = "0x105BDB0", Offset = "0x105ABB0", Length = "0xDA")]
	private static uint[] GenerateExponentTable()
	{
		return null;
	}

	[Token(Token = "0x60067F3")]
	[Address(RVA = "0x105BE90", Offset = "0x105AC90", Length = "0xA8")]
	private static ushort[] GenerateOffsetTable()
	{
		return null;
	}

	[Token(Token = "0x60067F4")]
	[Address(RVA = "0x105BF40", Offset = "0x105AD40", Length = "0x1C9")]
	private static ushort[] GenerateBaseTable()
	{
		return null;
	}

	[Token(Token = "0x60067F5")]
	[Address(RVA = "0x105C110", Offset = "0x105AF10", Length = "0x110")]
	private static sbyte[] GenerateShiftTable()
	{
		return null;
	}

	[Token(Token = "0x60067F6")]
	[Address(RVA = "0x105C230", Offset = "0x105B030", Length = "0x142")]
	public static float HalfToSingle(ushort half)
	{
		return 0f;
	}

	[Token(Token = "0x60067F7")]
	[Address(RVA = "0x105C380", Offset = "0x105B180", Length = "0x12D")]
	public static ushort SingleToHalf(float single)
	{
		return 0;
	}

	[Token(Token = "0x60067F8")]
	[Address(RVA = "0x105C4B0", Offset = "0x105B2B0", Length = "0x9B")]
	public static ushort SingleToHalf(uint singleAsUint)
	{
		return 0;
	}
}
