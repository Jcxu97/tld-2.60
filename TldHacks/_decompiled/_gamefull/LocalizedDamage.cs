using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000173")]
public class LocalizedDamage : MonoBehaviour
{
	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x20")]
	public BodyPart m_BodyPart;

	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x28")]
	private BodyDamage m_BodyDamage;

	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
	public void SetBodyDamage(BodyDamage bodyDamage)
	{
	}

	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x5EC960", Offset = "0x5EB760", Length = "0x4E")]
	public float GetDamageScale(WeaponSource weapon)
	{
		return 0f;
	}

	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x5EC9B0", Offset = "0x5EB7B0", Length = "0x4E")]
	public float GetBleedOutMinutes(WeaponSource weapon)
	{
		return 0f;
	}

	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x5ECA00", Offset = "0x5EB800", Length = "0x4D")]
	public int GetChanceKill(WeaponSource weapon)
	{
		return 0;
	}

	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x5ECA50", Offset = "0x5EB850", Length = "0x8D")]
	public bool RollChanceToKill(WeaponSource weapon)
	{
		return false;
	}

	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x5ECAE0", Offset = "0x5EB8E0", Length = "0x110")]
	private bool HasBodyDamage()
	{
		return false;
	}

	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LocalizedDamage()
	{
	}
}
