using Cpp2ILInjected;
using UnityEngine;

namespace TLD.BigCarry;

[Token(Token = "0x20014CE")]
public class BigCarryItemSaveData
{
	[Token(Token = "0x4009663")]
	[FieldOffset(Offset = "0x10")]
	public bool m_ActiveSelf;

	[Token(Token = "0x4009664")]
	[FieldOffset(Offset = "0x18")]
	public string m_Name;

	[Token(Token = "0x4009665")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_Position;

	[Token(Token = "0x4009666")]
	[FieldOffset(Offset = "0x2C")]
	public Quaternion m_Rotation;

	[Token(Token = "0x4009667")]
	[FieldOffset(Offset = "0x40")]
	public string m_ItemDataSerialized;

	[Token(Token = "0x6008347")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BigCarryItemSaveData()
	{
	}
}
