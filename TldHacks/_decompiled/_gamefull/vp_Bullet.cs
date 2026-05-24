using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000002")]
public class vp_Bullet : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	public float Range;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x24")]
	public float Force;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public float Damage;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x2C")]
	public float Accuracy;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	public float MinDistanceForAimAssist;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	public string DamageMethodName;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	public float DamageFalloffPerMeterBeyondEffectiveRange;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x44")]
	public float MinimumDamageFalloffBeyondEffectiveRange;

	[HideInInspector]
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x48")]
	public string m_ImpactAudio;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x50")]
	public GunType m_GunType;

	[Header("Gear Impact Forces")]
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x54")]
	public float m_GearImpactForce;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x58")]
	public float m_GearImpactUpwardForce;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x5C")]
	public float m_GearImpactTorqueForce;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x53B5A0", Offset = "0x53A3A0", Length = "0x18BD")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x53CE60", Offset = "0x53BC60", Length = "0x75")]
	private void MaybeCheckWithCougar(Vector3 forward)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x53CEE0", Offset = "0x53BCE0", Length = "0x445")]
	private static BulletImpactEffectType GetImpactEffectTypeBasedOnMaterial(string tag)
	{
		return default(BulletImpactEffectType);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x53D330", Offset = "0x53C130", Length = "0x2A8")]
	private void SpawnImpactEffects(RaycastHit hit)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x53DB80", Offset = "0x53C980", Length = "0xF7")]
	public vp_Bullet()
	{
	}
}
