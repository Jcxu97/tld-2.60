using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x200035F")]
public class AuroraObjectMaterialInfo
{
	[Token(Token = "0x4001DCD")]
	[FieldOffset(Offset = "0x10")]
	public Renderer m_Renderer;

	[Token(Token = "0x4001DCE")]
	[FieldOffset(Offset = "0x18")]
	public Material m_AuroraMaterial;

	[Token(Token = "0x4001DCF")]
	[FieldOffset(Offset = "0x20")]
	public Material m_NormalMaterial;

	[Token(Token = "0x4001DD0")]
	[FieldOffset(Offset = "0x28")]
	private Material m_OriginalMaterial;

	[Token(Token = "0x6001B7D")]
	[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
	public void SetOriginalMaterial(Material mat)
	{
	}

	[Token(Token = "0x6001B7E")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public Material GetOriginalMaterial()
	{
		return null;
	}

	[Token(Token = "0x6001B7F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public AuroraObjectMaterialInfo()
	{
	}
}
