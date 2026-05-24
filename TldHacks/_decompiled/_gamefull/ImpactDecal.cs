using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20003B5")]
public class ImpactDecal
{
	[Token(Token = "0x4002120")]
	[FieldOffset(Offset = "0x10")]
	public MaterialEffectType m_EffectType;

	[Token(Token = "0x4002121")]
	[FieldOffset(Offset = "0x18")]
	public List<string> m_ImpactDecalName;

	[Token(Token = "0x4002122")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_Scale;

	[Token(Token = "0x6001D3B")]
	[Address(RVA = "0x798000", Offset = "0x796E00", Length = "0x108")]
	public string GetImpactDecalVariationName()
	{
		return null;
	}

	[Token(Token = "0x6001D3C")]
	[Address(RVA = "0x798110", Offset = "0x796F10", Length = "0x4E")]
	public ImpactDecal()
	{
	}
}
