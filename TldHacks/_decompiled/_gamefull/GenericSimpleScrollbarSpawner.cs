using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000884")]
public class GenericSimpleScrollbarSpawner : MonoBehaviour
{
	[Token(Token = "0x40057F3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Prefab;

	[Token(Token = "0x40057F4")]
	[FieldOffset(Offset = "0x28")]
	public int m_Depth;

	[Token(Token = "0x40057F5")]
	[FieldOffset(Offset = "0x30")]
	public List<EventDelegate> onChange;

	[HideInInspector]
	[Token(Token = "0x40057F6")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_SpawnedObject;

	[Token(Token = "0x6004DD0")]
	[Address(RVA = "0xD947C0", Offset = "0xD935C0", Length = "0x7")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004DD1")]
	[Address(RVA = "0xD947D0", Offset = "0xD935D0", Length = "0x15B")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6004DD2")]
	[Address(RVA = "0xD94930", Offset = "0xD93730", Length = "0x40B")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[Token(Token = "0x6004DD3")]
	[Address(RVA = "0xD94D40", Offset = "0xD93B40", Length = "0x45")]
	private void OnDragFinished()
	{
	}

	[Token(Token = "0x6004DD4")]
	[Address(RVA = "0xD94D90", Offset = "0xD93B90", Length = "0xE3")]
	public GenericSimpleScrollbarSpawner()
	{
	}
}
