using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007CB")]
public class RockCacheSaveData
{
	[Token(Token = "0x40053BB")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x40053BC")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion m_Rotation;

	[Token(Token = "0x40053BD")]
	[FieldOffset(Offset = "0x30")]
	public string m_Guid;

	[Token(Token = "0x40053BE")]
	[FieldOffset(Offset = "0x38")]
	public string m_SearializedRockCache;

	[Token(Token = "0x60049AB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RockCacheSaveData()
	{
	}
}
