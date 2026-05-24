using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200039D")]
public class FootstepGroupSaveDataProxy
{
	[Token(Token = "0x400205E")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Pos;

	[Token(Token = "0x400205F")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 m_BoundsSize;

	[Token(Token = "0x4002060")]
	[FieldOffset(Offset = "0x28")]
	public float m_BaseSnowDepth;

	[Token(Token = "0x4002061")]
	[FieldOffset(Offset = "0x2C")]
	public float m_ExpireSnowDepth;

	[Token(Token = "0x4002062")]
	[FieldOffset(Offset = "0x30")]
	public int m_BaseIndex;

	[Token(Token = "0x4002063")]
	[FieldOffset(Offset = "0x34")]
	public int m_Num;

	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FootstepGroupSaveDataProxy()
	{
	}
}
