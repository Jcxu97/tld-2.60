using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[Token(Token = "0x2000BE0")]
public class PlatformHelper
{
	[Token(Token = "0x6005DA8")]
	[Address(RVA = "0xF68F80", Offset = "0xF67D80", Length = "0xCD")]
	public static string GetCurrentPlatformSuffix()
	{
		return null;
	}

	[Token(Token = "0x6005DA9")]
	[Address(RVA = "0xF69050", Offset = "0xF67E50", Length = "0x54")]
	private static string GetPlatformSuffix(RuntimePlatform platform)
	{
		return null;
	}

	[Token(Token = "0x6005DAA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlatformHelper()
	{
	}
}
