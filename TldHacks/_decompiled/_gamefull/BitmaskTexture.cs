using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008D8")]
public class BitmaskTexture
{
	[Token(Token = "0x4005C92")]
	private const int BITS_PER_BYTE = 8;

	[Token(Token = "0x4005C93")]
	private const int BITS_PER_PIXEL = 32;

	[Token(Token = "0x4005C94")]
	private const int BYTES_PER_PIXEL = 4;

	[Token(Token = "0x4005C95")]
	[FieldOffset(Offset = "0x10")]
	private Texture2D m_Texture;

	[Token(Token = "0x4005C96")]
	[FieldOffset(Offset = "0x18")]
	private byte[] m_RawData;

	[Token(Token = "0x4005C97")]
	[FieldOffset(Offset = "0x20")]
	private int m_BytesPerEntry;

	[Token(Token = "0x4005C98")]
	[FieldOffset(Offset = "0x24")]
	private int m_ArrayStride;

	[Token(Token = "0x4005C99")]
	[FieldOffset(Offset = "0x28")]
	private bool m_Dirty;

	[Token(Token = "0x1700036B")]
	public Texture2D Texture
	{
		[Token(Token = "0x600514C")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600514D")]
	[Address(RVA = "0xE22C30", Offset = "0xE21A30", Length = "0x20F")]
	public BitmaskTexture(int width, int height, int bitCount)
	{
	}

	[Token(Token = "0x600514E")]
	[Address(RVA = "0xE22E40", Offset = "0xE21C40", Length = "0x49")]
	public void ApplyChanges()
	{
	}

	[Token(Token = "0x600514F")]
	[Address(RVA = "0xE22E90", Offset = "0xE21C90", Length = "0xA0")]
	public void ClearBit(int x, int y, int bit)
	{
	}

	[Token(Token = "0x6005150")]
	[Address(RVA = "0xE22F40", Offset = "0xE21D40", Length = "0xE")]
	public int IndexOf(int x, int y)
	{
		return 0;
	}

	[Token(Token = "0x6005151")]
	[Address(RVA = "0xE22F50", Offset = "0xE21D50", Length = "0x74")]
	public bool IsBitSet(int x, int y, int bit)
	{
		return false;
	}

	[Token(Token = "0x6005152")]
	[Address(RVA = "0xE22FD0", Offset = "0xE21DD0", Length = "0x9E")]
	public void SetBit(int x, int y, int bit)
	{
	}

	[Token(Token = "0x6005153")]
	[Address(RVA = "0x520A20", Offset = "0x51F820", Length = "0xD")]
	private static int RoundUpAndDivide(int x, int d)
	{
		return 0;
	}
}
