using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008BC")]
public class PlayerKnowledge : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x4005B25")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> m_KnowledgeObjects;

	[Token(Token = "0x600503F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6005040")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Update()
	{
	}

	[Token(Token = "0x6005041")]
	[Address(RVA = "0xE03580", Offset = "0xE02380", Length = "0x98")]
	public void AddKnowledge(GameObject go)
	{
	}

	[Token(Token = "0x6005042")]
	[Address(RVA = "0xE03620", Offset = "0xE02420", Length = "0x193")]
	public bool KnownByPlayer(string name)
	{
		return false;
	}

	[Token(Token = "0x6005043")]
	[Address(RVA = "0xE037C0", Offset = "0xE025C0", Length = "0x274")]
	public GameObject InstantiateRandomKnowledge(GameObject[] knowledgePrefabArray)
	{
		return null;
	}

	[Token(Token = "0x6005044")]
	[Address(RVA = "0xE03A40", Offset = "0xE02840", Length = "0x197")]
	public GameObject GetKnowledgeInstance(string name)
	{
		return null;
	}

	[Token(Token = "0x6005045")]
	[Address(RVA = "0xE03BE0", Offset = "0xE029E0", Length = "0xE3")]
	public PlayerKnowledge()
	{
	}
}
