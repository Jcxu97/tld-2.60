using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20006FB")]
public class PrefabInstantiateData
{
	[Token(Token = "0x4004A25")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_Prefab;

	[Token(Token = "0x4004A26")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_Position;

	[Token(Token = "0x4004A27")]
	[FieldOffset(Offset = "0x24")]
	public Quaternion m_Rotation;

	[Token(Token = "0x4004A28")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_LocalScale;

	[Token(Token = "0x6003D42")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PrefabInstantiateData()
	{
	}
}
