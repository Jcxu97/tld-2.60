using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20006FA")]
public class LoadSceneParent : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x4004A1F")]
	[FieldOffset(Offset = "0x20")]
	public string m_GUID;

	[Token(Token = "0x4004A20")]
	[FieldOffset(Offset = "0x28")]
	private List<LoadScene> m_ChildLoadScenes;

	[Token(Token = "0x4004A21")]
	[FieldOffset(Offset = "0x30")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4004A22")]
	private static LoadSceneParentSaveDataProxy m_LoadSceneParentSaveDataProxy;

	[Token(Token = "0x4004A23")]
	private static List<LoadSceneParent> m_LoadSceneParentList;

	[Token(Token = "0x4004A24")]
	private static List<LoadSceneParentSaveDataProxy> m_MissingGuids;

	[Token(Token = "0x6003D36")]
	[Address(RVA = "0xB8FC60", Offset = "0xB8EA60", Length = "0x14F")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003D37")]
	[Address(RVA = "0xB8FDB0", Offset = "0xB8EBB0", Length = "0x98")]
	public void Start()
	{
	}

	[Token(Token = "0x6003D38")]
	[Address(RVA = "0xB8FE50", Offset = "0xB8EC50", Length = "0x98")]
	public void Register(LoadScene child)
	{
	}

	[Token(Token = "0x6003D39")]
	[Address(RVA = "0xB8FEF0", Offset = "0xB8ECF0", Length = "0x14B")]
	public void MarkChildrenExplored()
	{
	}

	[Token(Token = "0x6003D3A")]
	[Address(RVA = "0xB90040", Offset = "0xB8EE40", Length = "0x212")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003D3B")]
	[Address(RVA = "0xB90260", Offset = "0xB8F060", Length = "0xE1")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003D3C")]
	[Address(RVA = "0xB90350", Offset = "0xB8F150", Length = "0x45D")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6003D3D")]
	[Address(RVA = "0xB907B0", Offset = "0xB8F5B0", Length = "0x139")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6003D3E")]
	[Address(RVA = "0xB908F0", Offset = "0xB8F6F0", Length = "0x4BC")]
	private static LoadSceneParent FindLoadSceneParentByPosition(LoadSceneParentSaveDataProxy proxy)
	{
		return null;
	}

	[Token(Token = "0x6003D3F")]
	[Address(RVA = "0xB90DB0", Offset = "0xB8FBB0", Length = "0x3BA")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6003D40")]
	[Address(RVA = "0xB91170", Offset = "0xB8FF70", Length = "0xE3")]
	public LoadSceneParent()
	{
	}
}
