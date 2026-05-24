using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200071D")]
public class ContainerSaveData
{
	[Token(Token = "0x4004B7E")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x4004B7F")]
	[FieldOffset(Offset = "0x20")]
	public string m_PrefabName;

	[Token(Token = "0x4004B80")]
	[FieldOffset(Offset = "0x28")]
	public string m_SearializedContainer;

	[Token(Token = "0x4004B81")]
	[FieldOffset(Offset = "0x30")]
	public string m_Guid;

	[Token(Token = "0x4004B82")]
	[FieldOffset(Offset = "0x38")]
	public bool m_NotActive;

	[Token(Token = "0x60040A1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ContainerSaveData()
	{
	}
}
