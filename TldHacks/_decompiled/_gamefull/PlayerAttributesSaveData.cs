using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20008AB")]
public class PlayerAttributesSaveData
{
	[Token(Token = "0x4005A28")]
	[FieldOffset(Offset = "0x10")]
	public float m_Strength;

	[Token(Token = "0x4005A29")]
	[FieldOffset(Offset = "0x14")]
	public float m_MaxStrength;

	[Token(Token = "0x6004FD7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayerAttributesSaveData()
	{
	}
}
