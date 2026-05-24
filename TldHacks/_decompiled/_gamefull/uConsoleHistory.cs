using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000A9B")]
public class uConsoleHistory
{
	[Token(Token = "0x4006852")]
	private static List<string> m_History;

	[Token(Token = "0x4006853")]
	private static int m_MaxNumberOfLines;

	[Token(Token = "0x4006854")]
	private static string m_Filename;

	[Token(Token = "0x6005C20")]
	[Address(RVA = "0xF38310", Offset = "0xF37110", Length = "0x93")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6005C21")]
	[Address(RVA = "0xF383B0", Offset = "0xF371B0", Length = "0x144")]
	public static void SetMaxNumberOfLines(int count)
	{
	}

	[Token(Token = "0x6005C22")]
	[Address(RVA = "0xF38500", Offset = "0xF37300", Length = "0xEF")]
	public static string GetLine(int index)
	{
		return null;
	}

	[Token(Token = "0x6005C23")]
	[Address(RVA = "0xF385F0", Offset = "0xF373F0", Length = "0x71")]
	public static int GetNumLines()
	{
		return 0;
	}

	[Token(Token = "0x6005C24")]
	[Address(RVA = "0xF38670", Offset = "0xF37470", Length = "0x1E1")]
	public static void Add(string text)
	{
	}

	[Token(Token = "0x6005C25")]
	[Address(RVA = "0xF38860", Offset = "0xF37660", Length = "0x1F0")]
	public static void Save()
	{
	}

	[Token(Token = "0x6005C26")]
	[Address(RVA = "0xF38A60", Offset = "0xF37860", Length = "0x1F2")]
	public static void Restore()
	{
	}

	[Token(Token = "0x6005C27")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public uConsoleHistory()
	{
	}
}
