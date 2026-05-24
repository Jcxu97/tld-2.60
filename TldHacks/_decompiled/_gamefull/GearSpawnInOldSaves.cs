using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004A2")]
public class GearSpawnInOldSaves : MonoBehaviour
{
	[Token(Token = "0x4002AD7")]
	private static List<string> m_SceneGuids;

	[Token(Token = "0x4002AD8")]
	private static List<string> m_RestoredGuids;

	[Token(Token = "0x6002362")]
	[Address(RVA = "0x8565E0", Offset = "0x8553E0", Length = "0xBD")]
	public static void Add(string guid)
	{
	}

	[Token(Token = "0x6002363")]
	[Address(RVA = "0x8566A0", Offset = "0x8554A0", Length = "0xCB")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6002364")]
	[Address(RVA = "0x856770", Offset = "0x855570", Length = "0x10E")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002365")]
	[Address(RVA = "0x856880", Offset = "0x855680", Length = "0x107")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6002366")]
	[Address(RVA = "0x856990", Offset = "0x855790", Length = "0x148")]
	public static bool HasSpawned(string guid)
	{
		return false;
	}

	[Token(Token = "0x6002367")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GearSpawnInOldSaves()
	{
	}
}
