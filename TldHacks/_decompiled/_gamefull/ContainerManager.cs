using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x200071F")]
public class ContainerManager
{
	[Token(Token = "0x4004B84")]
	public static List<Container> m_Containers;

	[Token(Token = "0x4004B85")]
	public static List<Container> m_CorpseContainers;

	[Token(Token = "0x4004B86")]
	public static List<Container> s_ActiveContainers;

	[Token(Token = "0x60040A3")]
	[Address(RVA = "0xC0A7E0", Offset = "0xC095E0", Length = "0x491")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60040A4")]
	[Address(RVA = "0xC0AC80", Offset = "0xC09A80", Length = "0x51")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x60040A5")]
	[Address(RVA = "0xC0ACE0", Offset = "0xC09AE0", Length = "0x559")]
	public static void Deserialize(string text, List<GearItem> loadedItems)
	{
	}

	[Token(Token = "0x60040A6")]
	[Address(RVA = "0xC0B240", Offset = "0xC0A040", Length = "0x3E2")]
	public static void DeserializeAdditive(string text)
	{
	}

	[Token(Token = "0x60040A7")]
	[Address(RVA = "0xC0B630", Offset = "0xC0A430", Length = "0xA3")]
	private static void AddAllItemsToLostAndFound(List<GearItemObject> items)
	{
	}

	[Token(Token = "0x60040A8")]
	[Address(RVA = "0xC0B6E0", Offset = "0xC0A4E0", Length = "0xCB")]
	public static void Reset()
	{
	}

	[Token(Token = "0x60040A9")]
	[Address(RVA = "0xC0B7B0", Offset = "0xC0A5B0", Length = "0x2B6")]
	public static void DisableAll()
	{
	}

	[Token(Token = "0x60040AA")]
	[Address(RVA = "0xC0BA70", Offset = "0xC0A870", Length = "0xF7")]
	public static void UpdateAll()
	{
	}

	[Token(Token = "0x60040AB")]
	[Address(RVA = "0xC0BB70", Offset = "0xC0A970", Length = "0x37B")]
	private static Container FindContainerByPosition(ContainerSaveData csd)
	{
		return null;
	}

	[Token(Token = "0x60040AC")]
	[Address(RVA = "0xC0BEF0", Offset = "0xC0ACF0", Length = "0x117")]
	private static Container FindContainerByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x60040AD")]
	[Address(RVA = "0xC0C010", Offset = "0xC0AE10", Length = "0xAA")]
	private static bool ShouldUseSavedContainerPosition(Vector3 scenePos, Vector3 savedPos)
	{
		return false;
	}

	[Token(Token = "0x60040AE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ContainerManager()
	{
	}
}
