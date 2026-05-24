using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000728")]
public class DecalVariant
{
	[Token(Token = "0x4004BD5")]
	[FieldOffset(Offset = "0x10")]
	public string m_Name;

	[Token(Token = "0x4004BD6")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_RenderScale;

	[Token(Token = "0x60040B7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DecalVariant()
	{
	}
}
