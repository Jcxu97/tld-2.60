using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000885")]
public class GenericSliderSpawner : MonoBehaviour
{
	[Token(Token = "0x40057F7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Prefab;

	[Token(Token = "0x40057F8")]
	[FieldOffset(Offset = "0x28")]
	public bool m_LabelWillBeOverridden;

	[Token(Token = "0x40057F9")]
	[FieldOffset(Offset = "0x30")]
	public List<EventDelegate> onChange;

	[HideInInspector]
	[Token(Token = "0x40057FA")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_SpawnedObject;

	[Token(Token = "0x6004DD5")]
	[Address(RVA = "0xD94E80", Offset = "0xD93C80", Length = "0xCA")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004DD6")]
	[Address(RVA = "0xD94F50", Offset = "0xD93D50", Length = "0x38A")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[Token(Token = "0x6004DD7")]
	[Address(RVA = "0xD952E0", Offset = "0xD940E0", Length = "0xE3")]
	public GenericSliderSpawner()
	{
	}
}
