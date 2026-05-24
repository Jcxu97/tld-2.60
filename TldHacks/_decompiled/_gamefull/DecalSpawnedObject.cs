using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x200072A")]
public class DecalSpawnedObject
{
	[Token(Token = "0x4004BDB")]
	[FieldOffset(Offset = "0x10")]
	public DecalProjectorType m_DecalProjectorType;

	[Token(Token = "0x4004BDC")]
	[FieldOffset(Offset = "0x14")]
	public ProjectileType m_ProjectileType;

	[Token(Token = "0x4004BDD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_SpawnedPrefab;

	[Token(Token = "0x60040B9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DecalSpawnedObject()
	{
	}
}
