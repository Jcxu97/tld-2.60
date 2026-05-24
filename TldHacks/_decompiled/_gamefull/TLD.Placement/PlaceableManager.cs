using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Placement;

[Token(Token = "0x2001379")]
public static class PlaceableManager
{
	[Token(Token = "0x200137A")]
	private struct PlaceableInfo
	{
		[Token(Token = "0x4008F3A")]
		[FieldOffset(Offset = "0x0")]
		public Placeable m_Handle;

		[Token(Token = "0x4008F3B")]
		[FieldOffset(Offset = "0x8")]
		public PlacementState m_State;
	}

	[Token(Token = "0x4008F35")]
	public static bool s_Verbose;

	[Token(Token = "0x4008F36")]
	private const string CATEGORY_NAME = "DesignPlaceable";

	[Token(Token = "0x4008F37")]
	public static bool s_IsDeserializing;

	[Token(Token = "0x4008F38")]
	private static Dictionary<string, PlaceableInfo> s_Placeables;

	[Token(Token = "0x4008F39")]
	private static GameObject s_Category;

	[Token(Token = "0x6007C5C")]
	[Address(RVA = "0x11B46F0", Offset = "0x11B34F0", Length = "0x6F2")]
	public static void Add(Placeable placeable)
	{
	}

	[Token(Token = "0x6007C5D")]
	[Address(RVA = "0x11B4DF0", Offset = "0x11B3BF0", Length = "0x14B")]
	public static PlacementState GetPlacementState(Placeable placeable)
	{
		return default(PlacementState);
	}

	[Token(Token = "0x6007C5E")]
	[Address(RVA = "0x11B4F40", Offset = "0x11B3D40", Length = "0x8F")]
	public static void DeserializeGlobalPlacements(List<PlaceableInfoSaveData> plList)
	{
	}

	[Token(Token = "0x6007C5F")]
	[Address(RVA = "0x11B4FD0", Offset = "0x11B3DD0", Length = "0x73")]
	public static void DeserializeScenePlacements(List<PlaceableInfoSaveData> plList)
	{
	}

	[Token(Token = "0x6007C60")]
	[Address(RVA = "0x11B5050", Offset = "0x11B3E50", Length = "0x8D0")]
	private static void Deserialize(List<PlaceableInfoSaveData> plList, bool isGlobal)
	{
	}

	[Token(Token = "0x6007C61")]
	[Address(RVA = "0x11B5930", Offset = "0x11B4730", Length = "0x47")]
	public static List<PlaceableInfoSaveData> SerializeGlobalPlacements()
	{
		return null;
	}

	[Token(Token = "0x6007C62")]
	[Address(RVA = "0x11B5980", Offset = "0x11B4780", Length = "0x47")]
	public static List<PlaceableInfoSaveData> SerializeScenePlacements()
	{
		return null;
	}

	[Token(Token = "0x6007C63")]
	[Address(RVA = "0x11B59D0", Offset = "0x11B47D0", Length = "0x3AC")]
	private static List<PlaceableInfoSaveData> Serialize(bool isGlobal)
	{
		return null;
	}

	[Token(Token = "0x6007C64")]
	[Address(RVA = "0x11B5D80", Offset = "0x11B4B80", Length = "0x3AF")]
	public static List<PlaceableInfoSaveData> SerializeInventory()
	{
		return null;
	}

	[Token(Token = "0x6007C65")]
	[Address(RVA = "0x11B6130", Offset = "0x11B4F30", Length = "0x520")]
	public static void DeserializeInventory(List<PlaceableInfoSaveData> placeableInventory)
	{
	}

	[Token(Token = "0x6007C66")]
	[Address(RVA = "0x11B6660", Offset = "0x11B5460", Length = "0x386")]
	public static GameObject FindOrCreateCategoryRoot()
	{
		return null;
	}

	[Token(Token = "0x6007C67")]
	[Address(RVA = "0x11B69F0", Offset = "0x11B57F0", Length = "0x124")]
	public static void MoveToPlayer(GameObject go)
	{
	}

	[Token(Token = "0x6007C68")]
	[Address(RVA = "0x11B6B20", Offset = "0x11B5920", Length = "0x239")]
	public static void MoveToPlayer(Placeable placeable)
	{
	}

	[Token(Token = "0x6007C69")]
	[Address(RVA = "0x11B6D60", Offset = "0x11B5B60", Length = "0x2D6")]
	public static void SetActive(Placeable placeable, bool active)
	{
	}

	[Token(Token = "0x6007C6A")]
	[Address(RVA = "0x11B7040", Offset = "0x11B5E40", Length = "0x37E")]
	public static void Remove(Placeable placeable)
	{
	}

	[Token(Token = "0x6007C6B")]
	[Address(RVA = "0x11B73C0", Offset = "0x11B61C0", Length = "0x124")]
	public static void ReturnFromPlayer(GameObject go)
	{
	}

	[Token(Token = "0x6007C6C")]
	[Address(RVA = "0x11B74F0", Offset = "0x11B62F0", Length = "0x239")]
	public static void ReturnFromPlayer(Placeable placeable)
	{
	}

	[Token(Token = "0x6007C6D")]
	[Address(RVA = "0x11B7730", Offset = "0x11B6530", Length = "0x131")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6007C6E")]
	[Address(RVA = "0x11B7870", Offset = "0x11B6670", Length = "0x577")]
	private static void RestoreExistingPlacements()
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6007C6F")]
	[Address(RVA = "0x11B7DF0", Offset = "0x11B6BF0", Length = "0x43")]
	public static void DebugLog(string message)
	{
	}
}
