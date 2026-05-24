using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007EF")]
public class SteamPipeValveManager : MonoBehaviour
{
	[Token(Token = "0x40054A2")]
	public static List<SteamPipeValve> s_SteamPipeValveList;

	[Token(Token = "0x40054A3")]
	public static List<SteamPipeValveSocket> s_SteamPipeValveSocketList;

	[Token(Token = "0x6004AA9")]
	[Address(RVA = "0xD40620", Offset = "0xD3F420", Length = "0xDC")]
	public void Start()
	{
	}

	[Token(Token = "0x6004AAA")]
	[Address(RVA = "0xD40700", Offset = "0xD3F500", Length = "0x14D")]
	public static void Add(SteamPipeValve valve)
	{
	}

	[Token(Token = "0x6004AAB")]
	[Address(RVA = "0xD40850", Offset = "0xD3F650", Length = "0x82")]
	public static void Remove(SteamPipeValve valve)
	{
	}

	[Token(Token = "0x6004AAC")]
	[Address(RVA = "0xD408E0", Offset = "0xD3F6E0", Length = "0x14F")]
	public static void Add(SteamPipeValveSocket socket)
	{
	}

	[Token(Token = "0x6004AAD")]
	[Address(RVA = "0xD40A30", Offset = "0xD3F830", Length = "0x83")]
	public static void Remove(SteamPipeValveSocket socket)
	{
	}

	[Token(Token = "0x6004AAE")]
	[Address(RVA = "0xD40AC0", Offset = "0xD3F8C0", Length = "0xA93")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6004AAF")]
	[Address(RVA = "0xD41560", Offset = "0xD40360", Length = "0x562")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6004AB0")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SteamPipeValveManager()
	{
	}
}
