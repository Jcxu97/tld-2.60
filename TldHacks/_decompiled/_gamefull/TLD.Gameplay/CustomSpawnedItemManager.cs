using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Token(Token = "0x200146F")]
public static class CustomSpawnedItemManager
{
	[Token(Token = "0x4009457")]
	private static readonly List<CustomSpawnedItem> s_Items;

	[Token(Token = "0x600820D")]
	[Address(RVA = "0x122B5D0", Offset = "0x122A3D0", Length = "0xBD")]
	public static void RegisterItem(CustomSpawnedItem item)
	{
	}

	[Token(Token = "0x600820E")]
	[Address(RVA = "0x122B690", Offset = "0x122A490", Length = "0x82")]
	public static void UnregisterItem(CustomSpawnedItem item)
	{
	}

	[Token(Token = "0x600820F")]
	[Address(RVA = "0x122B720", Offset = "0x122A520", Length = "0x16F")]
	public static CustomSpawnedItem SpawnBigItem(AssetReference assetReference)
	{
		return null;
	}

	[Token(Token = "0x6008210")]
	[Address(RVA = "0x18AA850", Offset = "0x18A9650", Length = "0x271")]
	public static void GetItemsOfType<T>(List<T> items) where T : CustomSpawnedItem
	{
	}

	[Token(Token = "0x6008211")]
	[Address(RVA = "0x122B890", Offset = "0x122A690", Length = "0x3EF")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6008212")]
	[Address(RVA = "0x122BC80", Offset = "0x122AA80", Length = "0x2C0")]
	public static void DeserializeAll(string text)
	{
	}
}
