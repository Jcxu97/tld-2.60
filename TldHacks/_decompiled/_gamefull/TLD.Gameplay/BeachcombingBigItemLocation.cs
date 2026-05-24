using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Token(Token = "0x2001456")]
public class BeachcombingBigItemLocation : MonoBehaviour
{
	[Header("Spawn Thresholds")]
	[SerializeField]
	[Token(Token = "0x40093BF")]
	[FieldOffset(Offset = "0x20")]
	private float m_SpawnThresholdRadius;

	[SerializeField]
	[Token(Token = "0x40093C0")]
	[FieldOffset(Offset = "0x24")]
	private float m_SpawnOnScreenThresholdRadius;

	[Header("Spawn Settings")]
	[SerializeField]
	[Token(Token = "0x40093C1")]
	[FieldOffset(Offset = "0x28")]
	private List<AssetReferenceCustomSpawnedItem> m_AllowedObjects;

	[Token(Token = "0x17000B30")]
	[field: Token(Token = "0x40093C2")]
	[field: FieldOffset(Offset = "0x30")]
	public string Guid
	{
		[Token(Token = "0x6008172")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get;
		[Token(Token = "0x6008173")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000B31")]
	[field: Token(Token = "0x40093C3")]
	[field: FieldOffset(Offset = "0x38")]
	public CustomSpawnedItem Child
	{
		[Token(Token = "0x6008174")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get;
		[Token(Token = "0x6008175")]
		[Address(RVA = "0x509400", Offset = "0x508200", Length = "0x52")]
		set;
	}

	[Token(Token = "0x6008176")]
	[Address(RVA = "0x121D170", Offset = "0x121BF70", Length = "0x69")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008177")]
	[Address(RVA = "0x121D1E0", Offset = "0x121BFE0", Length = "0x305")]
	public bool IsReferenceAllowed(AssetReference assetReference)
	{
		return false;
	}

	[Token(Token = "0x6008178")]
	[Address(RVA = "0x121D4F0", Offset = "0x121C2F0", Length = "0x308")]
	public bool IsPlayerCloseToLocation(Vector3 playerPosition)
	{
		return false;
	}

	[Token(Token = "0x6008179")]
	[Address(RVA = "0x121D800", Offset = "0x121C600", Length = "0x51")]
	public BeachcombingBigItemLocation()
	{
	}
}
