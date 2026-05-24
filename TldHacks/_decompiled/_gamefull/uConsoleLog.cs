using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A9D")]
public class uConsoleLog
{
	[Token(Token = "0x4006862")]
	private static List<string> m_Log;

	[Token(Token = "0x4006863")]
	private static string m_Filename;

	[Token(Token = "0x4006864")]
	private static int m_MaxNumberOfLines;

	[Token(Token = "0x6005C36")]
	[Address(RVA = "0xF3AE30", Offset = "0xF39C30", Length = "0x93")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6005C37")]
	[Address(RVA = "0xF3AED0", Offset = "0xF39CD0", Length = "0x295")]
	public static void Add(string text)
	{
	}

	[Token(Token = "0x6005C38")]
	[Address(RVA = "0xF3B170", Offset = "0xF39F70", Length = "0x140")]
	public static void SetMaxNumberOfLines(int count)
	{
	}

	[Token(Token = "0x6005C39")]
	[Address(RVA = "0xF3B2C0", Offset = "0xF3A0C0", Length = "0x71")]
	public static int GetNumLines()
	{
		return 0;
	}

	[Token(Token = "0x6005C3A")]
	[Address(RVA = "0xF3B340", Offset = "0xF3A140", Length = "0xEF")]
	public static string GetLine(int index)
	{
		return null;
	}

	[Token(Token = "0x6005C3B")]
	[Address(RVA = "0xF3B430", Offset = "0xF3A230", Length = "0x1F0")]
	public static void Save()
	{
	}

	[Token(Token = "0x6005C3C")]
	[Address(RVA = "0xF3B630", Offset = "0xF3A430", Length = "0x1F9")]
	public static void Restore()
	{
	}

	[Token(Token = "0x6005C3D")]
	[Address(RVA = "0xF3B830", Offset = "0xF3A630", Length = "0xCB")]
	public static void HandleLogMessagesFromUnity(string logString, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x6005C3E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public uConsoleLog()
	{
	}
}
