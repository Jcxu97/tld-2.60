using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD;

[Serializable]
[Token(Token = "0x200133F")]
public class CartographyAchievement
{
	[Token(Token = "0x4008DF7")]
	[FieldOffset(Offset = "0x10")]
	public string m_LocId;

	[Token(Token = "0x4008DF8")]
	[FieldOffset(Offset = "0x18")]
	public string m_DisplayText;

	[Token(Token = "0x4008DF9")]
	[FieldOffset(Offset = "0x20")]
	public string m_Guid;

	[Token(Token = "0x4008DFA")]
	[FieldOffset(Offset = "0x28")]
	public string m_SceneName;

	[Token(Token = "0x4008DFB")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 m_WorldLocation;

	[Token(Token = "0x6007B57")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CartographyAchievement()
	{
	}
}
