using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000320")]
public class RegionOrientation
{
	[Token(Token = "0x4001BA5")]
	[FieldOffset(Offset = "0x10")]
	public string m_RegionName;

	[Token(Token = "0x4001BA6")]
	[FieldOffset(Offset = "0x18")]
	public float m_RotationDegrees;

	[Token(Token = "0x600196C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RegionOrientation()
	{
	}
}
