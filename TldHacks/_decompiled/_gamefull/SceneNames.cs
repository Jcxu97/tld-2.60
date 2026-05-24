using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000700")]
public class SceneNames
{
	[Token(Token = "0x4004A3E")]
	public static Dictionary<int, string> m_Dict;

	[Token(Token = "0x4004A3F")]
	private static string[] m_Names;

	[Token(Token = "0x6003D63")]
	[Address(RVA = "0xB94530", Offset = "0xB93330", Length = "0x144")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6003D64")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SceneNames()
	{
	}
}
