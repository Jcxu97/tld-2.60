using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200017F")]
public class PackGroup
{
	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0x10")]
	public int m_FormationCount;

	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0x18")]
	public List<PackAnimal> m_Members;

	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0x20")]
	public float m_TargetAwarenessTime;

	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0x24")]
	public float m_AttackCooldownTime;

	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0x28")]
	public float m_PackMoraleModifier;

	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_GroupEventProcessed;

	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0x5F1BA0", Offset = "0x5F09A0", Length = "0xA")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0x5F1BB0", Offset = "0x5F09B0", Length = "0xAD")]
	public PackGroup()
	{
	}
}
