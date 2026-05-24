using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000712")]
public class BaseAiData
{
	[Token(Token = "0x4004B49")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x4004B4A")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion m_Rotation;

	[Token(Token = "0x4004B4B")]
	[FieldOffset(Offset = "0x30")]
	public string m_PrefabName;

	[Token(Token = "0x4004B4C")]
	[FieldOffset(Offset = "0x38")]
	public string m_BaseAiSerialized;

	[Token(Token = "0x4004B4D")]
	[FieldOffset(Offset = "0x40")]
	public string m_Guid;

	[Token(Token = "0x6003E19")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BaseAiData()
	{
	}
}
