using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200070B")]
public class ArrowManager : MonoBehaviour
{
	[Token(Token = "0x4004AF8")]
	private static List<ArrowItem> m_ArrowItems;

	[Token(Token = "0x6003DC9")]
	[Address(RVA = "0xBF9090", Offset = "0xBF7E90", Length = "0xBD")]
	public static void RegisterArrow(ArrowItem arrowItem)
	{
	}

	[Token(Token = "0x6003DCA")]
	[Address(RVA = "0xBF9150", Offset = "0xBF7F50", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6003DCB")]
	[Address(RVA = "0xBF91F0", Offset = "0xBF7FF0", Length = "0x39D")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003DCC")]
	[Address(RVA = "0xBF9590", Offset = "0xBF8390", Length = "0x486")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003DCD")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ArrowManager()
	{
	}
}
