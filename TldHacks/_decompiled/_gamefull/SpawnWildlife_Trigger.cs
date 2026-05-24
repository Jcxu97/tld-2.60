using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000443")]
public class SpawnWildlife_Trigger : MonoBehaviour
{
	[Token(Token = "0x400264F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_wildlifePrefabToSpawn;

	[Token(Token = "0x4002650")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_wildlifePrefabToSpawnAurora;

	[Token(Token = "0x4002651")]
	[FieldOffset(Offset = "0x30")]
	private bool m_PlayerHasEnteredTrigger;

	[Token(Token = "0x4002652")]
	[FieldOffset(Offset = "0x38")]
	private string m_Guid;

	[Token(Token = "0x4002653")]
	private static List<SpawnWildlife_Trigger> s_SpawnWildlife_Triggers;

	[Token(Token = "0x4002654")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ResumeRequested;

	[Token(Token = "0x4002655")]
	[FieldOffset(Offset = "0x48")]
	private List<BaseAi> m_SpawnedAnimals;

	[Token(Token = "0x4002656")]
	[FieldOffset(Offset = "0x50")]
	private List<BaseAi> m_RemoveAnimals;

	[Token(Token = "0x6002002")]
	[Address(RVA = "0x7E8110", Offset = "0x7E6F10", Length = "0x11C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002003")]
	[Address(RVA = "0x7E8230", Offset = "0x7E7030", Length = "0x82")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6002004")]
	[Address(RVA = "0x7E82C0", Offset = "0x7E70C0", Length = "0x79")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x6002005")]
	[Address(RVA = "0x7E8340", Offset = "0x7E7140", Length = "0x76")]
	private void Update()
	{
	}

	[Token(Token = "0x6002006")]
	[Address(RVA = "0x7E83C0", Offset = "0x7E71C0", Length = "0x1E8")]
	public static void OnDespawn(BaseAi bai)
	{
	}

	[Token(Token = "0x6002007")]
	[Address(RVA = "0x7E85B0", Offset = "0x7E73B0", Length = "0x3BC")]
	private void EnableSpawnGroups()
	{
	}

	[Token(Token = "0x6002008")]
	[Address(RVA = "0x7E8970", Offset = "0x7E7770", Length = "0x705")]
	private SpawnWildlife_TriggerSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002009")]
	[Address(RVA = "0x7E9080", Offset = "0x7E7E80", Length = "0x477")]
	private void Deserialize(SpawnWildlife_TriggerSaveData data)
	{
	}

	[Token(Token = "0x600200A")]
	[Address(RVA = "0x7E9500", Offset = "0x7E8300", Length = "0x39B")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x600200B")]
	[Address(RVA = "0x7E98A0", Offset = "0x7E86A0", Length = "0x2F4")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x600200C")]
	[Address(RVA = "0x7E9BA0", Offset = "0x7E89A0", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x600200D")]
	[Address(RVA = "0x7E9C40", Offset = "0x7E8A40", Length = "0x2ED")]
	public static void RegisterAnySpawnWildlifeGuid()
	{
	}

	[Token(Token = "0x600200E")]
	[Address(RVA = "0x7E9F30", Offset = "0x7E8D30", Length = "0x1D2")]
	public static bool IsChildOf(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x600200F")]
	[Address(RVA = "0x7EA110", Offset = "0x7E8F10", Length = "0x16F")]
	public SpawnWildlife_Trigger()
	{
	}
}
