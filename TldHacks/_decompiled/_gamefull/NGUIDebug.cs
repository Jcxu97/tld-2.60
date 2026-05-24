using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Internal/Debug")]
[Token(Token = "0x20000B4")]
public class NGUIDebug : MonoBehaviour
{
	[Token(Token = "0x40005E5")]
	private static bool mRayDebug;

	[Token(Token = "0x40005E6")]
	private static List<string> mLines;

	[Token(Token = "0x40005E7")]
	private static NGUIDebug mInstance;

	[Token(Token = "0x17000086")]
	public static bool debugRaycast
	{
		[Token(Token = "0x6000610")]
		[Address(RVA = "0xDEAF30", Offset = "0xDE9D30", Length = "0x53")]
		get
		{
			return false;
		}
		[Token(Token = "0x6000611")]
		[Address(RVA = "0xDEAF90", Offset = "0xDE9D90", Length = "0xE3")]
		set
		{
		}
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0xDEB080", Offset = "0xDE9E80", Length = "0x250")]
	public static void CreateInstance()
	{
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0xDEB2E0", Offset = "0xDEA0E0", Length = "0x255")]
	private static void LogString(string text)
	{
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0xDEB540", Offset = "0xDEA340", Length = "0x13C")]
	public static void Log(params object[] objs)
	{
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0xDEB680", Offset = "0xDEA480", Length = "0x94")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0xDEB720", Offset = "0xDEA520", Length = "0x545")]
	public static void DrawBounds(Bounds b)
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0xDEBC70", Offset = "0xDEAA70", Length = "0x385")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public NGUIDebug()
	{
	}
}
