using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000AF")]
public class ByteReader
{
	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x10")]
	private byte[] mBuffer;

	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0x18")]
	private int mOffset;

	[Token(Token = "0x40005C9")]
	private static BetterList<string> mTemp;

	[Token(Token = "0x1700007D")]
	public bool canRead
	{
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xDE4360", Offset = "0xDE3160", Length = "0x14")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public ByteReader(byte[] bytes)
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0xDE4130", Offset = "0xDE2F30", Length = "0xF8")]
	public ByteReader(TextAsset asset)
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0xDE4230", Offset = "0xDE3030", Length = "0x12D")]
	public static ByteReader Open(string path)
	{
		return null;
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0xDE4380", Offset = "0xDE3180", Length = "0x5D")]
	private static string ReadLine(byte[] buffer, int start, int count)
	{
		return null;
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0xDE43E0", Offset = "0xDE31E0", Length = "0xA")]
	public string ReadLine()
	{
		return null;
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0xDE43F0", Offset = "0xDE31F0", Length = "0x121")]
	public string ReadLine(bool skipEmptyLines)
	{
		return null;
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0xDE4520", Offset = "0xDE3320", Length = "0x203")]
	public Dictionary<string, string> ReadDictionary()
	{
		return null;
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0xDE4730", Offset = "0xDE3530", Length = "0x51C")]
	public BetterList<string> ReadCSV(bool ignoreSpaceNewLine = false)
	{
		return null;
	}
}
