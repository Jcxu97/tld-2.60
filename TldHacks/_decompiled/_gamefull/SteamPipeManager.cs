using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007EC")]
public class SteamPipeManager : MonoBehaviour
{
	[Token(Token = "0x400549D")]
	public static List<SteamPipe> s_SteamPipeList;

	[Token(Token = "0x6004AA0")]
	[Address(RVA = "0xD3F890", Offset = "0xD3E690", Length = "0x93")]
	public void Start()
	{
	}

	[Token(Token = "0x6004AA1")]
	[Address(RVA = "0xD3F930", Offset = "0xD3E730", Length = "0x14D")]
	public static void Add(SteamPipe pipe)
	{
	}

	[Token(Token = "0x6004AA2")]
	[Address(RVA = "0xD3FA80", Offset = "0xD3E880", Length = "0x82")]
	public static void Remove(SteamPipe pipe)
	{
	}

	[Token(Token = "0x6004AA3")]
	[Address(RVA = "0xD3FB10", Offset = "0xD3E910", Length = "0x5D4")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6004AA4")]
	[Address(RVA = "0xD400F0", Offset = "0xD3EEF0", Length = "0x305")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6004AA5")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SteamPipeManager()
	{
	}
}
