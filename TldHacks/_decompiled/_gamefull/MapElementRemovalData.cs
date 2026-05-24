using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000698")]
public class MapElementRemovalData
{
	[Token(Token = "0x40044B6")]
	[FieldOffset(Offset = "0x10")]
	public string m_RegionName;

	[Token(Token = "0x40044B7")]
	[FieldOffset(Offset = "0x18")]
	public string m_LocationLocID;

	[Token(Token = "0x40044B8")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_WorldPos;

	[Token(Token = "0x40044B9")]
	[FieldOffset(Offset = "0x2C")]
	public float m_RemovalTime;

	[Token(Token = "0x6003827")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public MapElementRemovalData()
	{
	}
}
