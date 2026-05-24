using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20009B4")]
public struct HexSectorDef
{
	[Token(Token = "0x4006328")]
	[FieldOffset(Offset = "0x0")]
	public HexSector m_Sector;

	[Token(Token = "0x4006329")]
	[FieldOffset(Offset = "0x8")]
	public float m_Distance;
}
