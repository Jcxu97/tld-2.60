using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[HelpURL("http://saladgamer.com/vlb-doc/config/")]
[Token(Token = "0x2000BBB")]
public class ConfigOverride : Config
{
	[Token(Token = "0x400786E")]
	public const string kAssetName = "VLBConfigOverride";

	[Token(Token = "0x6005D3D")]
	[Address(RVA = "0xF60810", Offset = "0xF5F610", Length = "0x1A5")]
	public ConfigOverride()
	{
	}
}
