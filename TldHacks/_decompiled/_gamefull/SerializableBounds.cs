using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20007AE")]
public class SerializableBounds
{
	[Token(Token = "0x40052B5")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Center;

	[Token(Token = "0x40052B6")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 m_Size;

	[Token(Token = "0x600492D")]
	[Address(RVA = "0xD16050", Offset = "0xD14E50", Length = "0xC2")]
	public bool Contains(Vector3 point)
	{
		return false;
	}

	[Token(Token = "0x600492E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SerializableBounds()
	{
	}
}
