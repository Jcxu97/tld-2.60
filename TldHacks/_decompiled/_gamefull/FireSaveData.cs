using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200073A")]
public class FireSaveData
{
	[Token(Token = "0x4004C9A")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x4004C9B")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_InWoodStove;

	[Token(Token = "0x4004C9C")]
	[FieldOffset(Offset = "0x20")]
	public string m_PrefabName;

	[Token(Token = "0x4004C9D")]
	[FieldOffset(Offset = "0x28")]
	public string m_SearializedFire;

	[Token(Token = "0x4004C9E")]
	[FieldOffset(Offset = "0x30")]
	public string m_Guid;

	[Token(Token = "0x600416B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FireSaveData()
	{
	}
}
