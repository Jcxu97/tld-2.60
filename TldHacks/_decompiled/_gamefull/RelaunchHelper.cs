using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20006FF")]
public static class RelaunchHelper
{
	[Token(Token = "0x6003D60")]
	[Address(RVA = "0xB941F0", Offset = "0xB92FF0", Length = "0x2B")]
	private static bool IsValidPath(string path)
	{
		return false;
	}

	[Token(Token = "0x6003D61")]
	[Address(RVA = "0xB94220", Offset = "0xB93020", Length = "0x75")]
	public static void TryLaunch(string path)
	{
	}

	[Token(Token = "0x6003D62")]
	[Address(RVA = "0xB942A0", Offset = "0xB930A0", Length = "0x28C")]
	public static void TryLaunch(string path, List<string> arguments)
	{
	}
}
