using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200017D")]
public class PackManagerDataProxy
{
	[Token(Token = "0x4000DC2")]
	[FieldOffset(Offset = "0x10")]
	public string m_LeaderGuid;

	[Token(Token = "0x4000DC3")]
	[FieldOffset(Offset = "0x18")]
	public float m_Time;

	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0x20")]
	public List<string> m_MemberGuids;

	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0x28")]
	public int m_FormationCount;

	[Token(Token = "0x4000DC6")]
	[FieldOffset(Offset = "0x2C")]
	public float m_PackMoraleModifier;

	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x5F1990", Offset = "0x5F0790", Length = "0xAD")]
	public PackManagerDataProxy()
	{
	}
}
