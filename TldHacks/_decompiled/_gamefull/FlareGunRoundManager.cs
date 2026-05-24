using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000740")]
public class FlareGunRoundManager : MonoBehaviour
{
	[Token(Token = "0x4004CC2")]
	public static List<FlareGunRoundItem> m_FlareGunRoundItems;

	[Token(Token = "0x6004197")]
	[Address(RVA = "0xC285A0", Offset = "0xC273A0", Length = "0xBD")]
	public static void AddFlareGunRoundItem(FlareGunRoundItem fgri)
	{
	}

	[Token(Token = "0x6004198")]
	[Address(RVA = "0xC28660", Offset = "0xC27460", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004199")]
	[Address(RVA = "0xC28700", Offset = "0xC27500", Length = "0x404")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600419A")]
	[Address(RVA = "0xC28B10", Offset = "0xC27910", Length = "0x57D")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x600419B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FlareGunRoundManager()
	{
	}
}
