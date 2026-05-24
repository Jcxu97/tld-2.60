using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Token(Token = "0x200146A")]
public class CustomSpawnedItemSaveData
{
	[Token(Token = "0x4009449")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x400944A")]
	[FieldOffset(Offset = "0x18")]
	public AssetReference m_Address;

	[Token(Token = "0x400944B")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_Position;

	[Token(Token = "0x400944C")]
	[FieldOffset(Offset = "0x2C")]
	public Quaternion m_Rotation;

	[Token(Token = "0x400944D")]
	[FieldOffset(Offset = "0x40")]
	public List<CustomSpawnedItemChildSaveData> m_Children;

	[Token(Token = "0x60081F5")]
	[Address(RVA = "0x1229B60", Offset = "0x1228960", Length = "0xAD")]
	public CustomSpawnedItemSaveData()
	{
	}
}
