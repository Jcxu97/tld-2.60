using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000786")]
public class MapDetailManager : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4005095")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Map> m_Map;

	[Token(Token = "0x4005096")]
	[FieldOffset(Offset = "0x28")]
	public float m_ResourceRemovalDelay;

	[Token(Token = "0x4005097")]
	private static List<MapDetail> s_MapDetails;

	[Token(Token = "0x4005098")]
	private static MapDetailSaveData m_MapDetailSaveData;

	[Token(Token = "0x600467A")]
	[Address(RVA = "0xCA72A0", Offset = "0xCA60A0", Length = "0x14D")]
	public static void Register(MapDetail mapDetail)
	{
	}

	[Token(Token = "0x600467B")]
	[Address(RVA = "0xCA73F0", Offset = "0xCA61F0", Length = "0x82")]
	public static void Unregister(MapDetail mapDetail)
	{
	}

	[Token(Token = "0x600467C")]
	[Address(RVA = "0xCA7480", Offset = "0xCA6280", Length = "0x784")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600467D")]
	[Address(RVA = "0xCA7C10", Offset = "0xCA6A10", Length = "0x753")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600467E")]
	[Address(RVA = "0xCA8370", Offset = "0xCA7170", Length = "0xE2E")]
	public bool UnlockMapDetailObjectsNearPosition(MapDetailUnlockParameters parameters)
	{
		return false;
	}

	[Token(Token = "0x600467F")]
	[Address(RVA = "0xCA91A0", Offset = "0xCA7FA0", Length = "0x268")]
	public void MaybeUnlockFaithfulCartographer()
	{
	}

	[Token(Token = "0x6004680")]
	[Address(RVA = "0xCA9410", Offset = "0xCA8210", Length = "0x41E")]
	public void LogAllUnmappedLocations()
	{
	}

	[Token(Token = "0x6004681")]
	[Address(RVA = "0xCA9830", Offset = "0xCA8630", Length = "0x184")]
	public void LockAll()
	{
	}

	[Token(Token = "0x6004682")]
	[Address(RVA = "0xCA99C0", Offset = "0xCA87C0", Length = "0x27")]
	private bool HasBeenDiscovered(MapDetail md)
	{
		return false;
	}

	[Token(Token = "0x6004683")]
	[Address(RVA = "0xCA99F0", Offset = "0xCA87F0", Length = "0x4A")]
	public MapDetailManager()
	{
	}
}
