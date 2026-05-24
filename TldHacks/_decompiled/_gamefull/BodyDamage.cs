using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000166")]
public class BodyDamage : MonoBehaviour
{
	[Token(Token = "0x4000D25")]
	[FieldOffset(Offset = "0x20")]
	public List<DamageRegion> m_DamageRegions;

	[Token(Token = "0x6000DED")]
	[Address(RVA = "0x5E2300", Offset = "0x5E1100", Length = "0x2FB")]
	private void Start()
	{
	}

	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x5E2600", Offset = "0x5E1400", Length = "0x25B")]
	public float GetDamageScale(BodyPart bodyPart, WeaponSource w)
	{
		return 0f;
	}

	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x5E2860", Offset = "0x5E1660", Length = "0x1DC")]
	public float GetBleedOutMinutes(BodyPart bodyPart, WeaponSource w)
	{
		return 0f;
	}

	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x5E2A40", Offset = "0x5E1840", Length = "0x26D")]
	public int GetChanceKill(BodyPart bodyPart, WeaponSource w)
	{
		return 0;
	}

	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x5E2CB0", Offset = "0x5E1AB0", Length = "0x1D3")]
	private DamageRegion GetDamageById(BodyPart bodyPart)
	{
		return null;
	}

	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x5E2E90", Offset = "0x5E1C90", Length = "0xE3")]
	public BodyDamage()
	{
	}
}
