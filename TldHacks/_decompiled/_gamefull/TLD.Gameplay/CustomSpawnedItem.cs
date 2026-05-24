using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Token(Token = "0x200146C")]
public class CustomSpawnedItem : MonoBehaviour
{
	[Token(Token = "0x4009451")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x4009454")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, CustomSpawnedItemChild> m_Children;

	[Token(Token = "0x17000B3F")]
	[field: Token(Token = "0x4009452")]
	[field: FieldOffset(Offset = "0x20")]
	public AssetReference Address
	{
		[Token(Token = "0x60081F7")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get;
		[Token(Token = "0x60081F8")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		set;
	}

	[Token(Token = "0x17000B40")]
	[field: Token(Token = "0x4009453")]
	[field: FieldOffset(Offset = "0x28")]
	public string Guid
	{
		[Token(Token = "0x60081F9")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get;
		[Token(Token = "0x60081FA")]
		[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x60081FB")]
	[Address(RVA = "0x1229C10", Offset = "0x1228A10", Length = "0x4DF")]
	private void Awake()
	{
	}

	[Token(Token = "0x60081FC")]
	[Address(RVA = "0x122A0F0", Offset = "0x1228EF0", Length = "0xB5")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60081FD")]
	[Address(RVA = "0x122A1B0", Offset = "0x1228FB0", Length = "0x1E1")]
	public void InitializeSpawnedItem()
	{
	}

	[Token(Token = "0x60081FE")]
	[Address(RVA = "0x122A3A0", Offset = "0x12291A0", Length = "0x74C")]
	public CustomSpawnedItemSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x60081FF")]
	[Address(RVA = "0x122AAF0", Offset = "0x12298F0", Length = "0x4B0")]
	public void Deserialize(CustomSpawnedItemSaveData saveData)
	{
	}

	[Token(Token = "0x6008200")]
	[Address(RVA = "0x122AFB0", Offset = "0x1229DB0", Length = "0xDE")]
	public void SetGuid(string guid)
	{
	}

	[Token(Token = "0x6008201")]
	[Address(RVA = "0x122B090", Offset = "0x1229E90", Length = "0x7E")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6008202")]
	[Address(RVA = "0x18AA410", Offset = "0x18A9210", Length = "0x43D")]
	private void ValidateChildren<T>() where T : Component
	{
	}

	[Token(Token = "0x6008203")]
	[Address(RVA = "0x122B110", Offset = "0x1229F10", Length = "0xE3")]
	public CustomSpawnedItem()
	{
	}
}
