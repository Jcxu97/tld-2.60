using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000007")]
public class vp_DamageHandler : MonoBehaviour
{
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x20")]
	public float Health;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DeathEffect;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x30")]
	public float MinDeathDelay;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x34")]
	public float MaxDeathDelay;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x38")]
	protected float m_CurrentHealth;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x3C")]
	public bool Respawns;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x40")]
	public float MinRespawnTime;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x44")]
	public float MaxRespawnTime;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x48")]
	public float RespawnCheckRadius;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip RespawnSound;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x58")]
	protected Vector3 m_StartPosition;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x64")]
	protected Quaternion m_StartRotation;

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x545440", Offset = "0x544240", Length = "0x17C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x5455C0", Offset = "0x5443C0", Length = "0x191")]
	public void Damage(float damage)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x545760", Offset = "0x544560", Length = "0x446")]
	public void Die()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x545BB0", Offset = "0x5449B0", Length = "0x6FB")]
	protected void Respawn()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x5462B0", Offset = "0x5450B0", Length = "0x3FF")]
	protected void RemoveBulletHoles()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x5466B0", Offset = "0x5454B0", Length = "0xDE")]
	public vp_DamageHandler()
	{
	}
}
