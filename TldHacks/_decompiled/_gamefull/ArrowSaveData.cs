using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000451")]
public class ArrowSaveData
{
	[Token(Token = "0x400270E")]
	[FieldOffset(Offset = "0x10")]
	public int m_InstanceID;

	[Token(Token = "0x400270F")]
	[FieldOffset(Offset = "0x18")]
	public string m_HostGuid;

	[Token(Token = "0x4002710")]
	[FieldOffset(Offset = "0x20")]
	public string m_LocalName;

	[Token(Token = "0x4002711")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_LocalPosition;

	[Token(Token = "0x4002712")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_LocalAngles;

	[Token(Token = "0x4002713")]
	[FieldOffset(Offset = "0x40")]
	public float m_EmbeddedDepth;

	[Token(Token = "0x6002083")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ArrowSaveData()
	{
	}
}
