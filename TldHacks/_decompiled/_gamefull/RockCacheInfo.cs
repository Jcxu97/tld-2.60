using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007CD")]
public class RockCacheInfo
{
	[Token(Token = "0x40053C0")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x40053C1")]
	[FieldOffset(Offset = "0x18")]
	public string m_CustomName;

	[Token(Token = "0x40053C2")]
	[FieldOffset(Offset = "0x20")]
	public string m_SceneName;

	[Token(Token = "0x40053C3")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_MapDetailPosition;

	[Token(Token = "0x40053C4")]
	[FieldOffset(Offset = "0x38")]
	public string m_UserText;

	[Token(Token = "0x60049AD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RockCacheInfo()
	{
	}
}
