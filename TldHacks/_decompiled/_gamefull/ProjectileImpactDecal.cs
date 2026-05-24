using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20003B8")]
public class ProjectileImpactDecal
{
	[Token(Token = "0x4002146")]
	[FieldOffset(Offset = "0x10")]
	public ProjectileType m_ProjectileType;

	[Token(Token = "0x4002147")]
	[FieldOffset(Offset = "0x18")]
	public List<ImpactDecal> m_ImpactDecals;

	[Token(Token = "0x6001D3D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ProjectileImpactDecal()
	{
	}
}
