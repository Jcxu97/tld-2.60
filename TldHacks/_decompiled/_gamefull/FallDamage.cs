using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000513")]
public class FallDamage : MonoBehaviour
{
	[Token(Token = "0x4002E7F")]
	[FieldOffset(Offset = "0x20")]
	public float m_HeightStartDamage;

	[Token(Token = "0x4002E80")]
	[FieldOffset(Offset = "0x24")]
	public float m_DamagePerMeter;

	[Token(Token = "0x4002E81")]
	[FieldOffset(Offset = "0x28")]
	public float m_DamagePerMeterFromRope;

	[Range(0f, 100f)]
	[Token(Token = "0x4002E82")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MaxRopeDamagePercentage;

	[Range(0f, 100f)]
	[Token(Token = "0x4002E83")]
	[FieldOffset(Offset = "0x30")]
	public float m_FatalRopeFallHealthDropPercentage;

	[Token(Token = "0x4002E84")]
	[FieldOffset(Offset = "0x34")]
	public float m_ClothingDamagePerMeterFallen;

	[Header("Audio")]
	[Token(Token = "0x4002E85")]
	[FieldOffset(Offset = "0x38")]
	public string m_NoDamage;

	[Token(Token = "0x4002E86")]
	[FieldOffset(Offset = "0x40")]
	public string m_LightDamage;

	[Token(Token = "0x4002E87")]
	[FieldOffset(Offset = "0x48")]
	public string m_MediumDamage;

	[Token(Token = "0x4002E88")]
	[FieldOffset(Offset = "0x50")]
	public string m_HeavyDamage;

	[Token(Token = "0x4002E89")]
	[FieldOffset(Offset = "0x58")]
	public string m_AnkleSprain;

	[Token(Token = "0x4002E8A")]
	[FieldOffset(Offset = "0x60")]
	public string m_WristSprain;

	[Token(Token = "0x4002E8B")]
	[FieldOffset(Offset = "0x68")]
	public string m_BloodLoss;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002E8C")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_HUD> m_HUD;

	[HideInInspector]
	[Token(Token = "0x4002E8D")]
	[FieldOffset(Offset = "0x78")]
	public bool m_DieOnNextFall;

	[HideInInspector]
	[Token(Token = "0x4002E8E")]
	[FieldOffset(Offset = "0x79")]
	public bool m_FallFromRope;

	[Token(Token = "0x4002E8F")]
	[FieldOffset(Offset = "0x7A")]
	private bool m_IgnoreDamageReduction;

	[Token(Token = "0x600268B")]
	[Address(RVA = "0x8A2730", Offset = "0x8A1530", Length = "0xB3D")]
	public void ApplyFallDamage(float height, float damageOverride)
	{
	}

	[Token(Token = "0x600268C")]
	[Address(RVA = "0x8A3270", Offset = "0x8A2070", Length = "0x5")]
	public bool IgnoreDamageReduction()
	{
		return false;
	}

	[Token(Token = "0x600268D")]
	[Address(RVA = "0x8A3280", Offset = "0x8A2080", Length = "0x13C")]
	private bool MaybeSprainAnkle()
	{
		return false;
	}

	[Token(Token = "0x600268E")]
	[Address(RVA = "0x8A33C0", Offset = "0x8A21C0", Length = "0x161")]
	private bool MaybeSprainWrist()
	{
		return false;
	}

	[Token(Token = "0x600268F")]
	[Address(RVA = "0x8A3530", Offset = "0x8A2330", Length = "0x115")]
	private bool MaybeBloodLoss()
	{
		return false;
	}

	[Token(Token = "0x6002690")]
	[Address(RVA = "0x8A3650", Offset = "0x8A2450", Length = "0x1B1")]
	private void ApplyClothingDamage(float fallHeight)
	{
	}

	[Token(Token = "0x6002691")]
	[Address(RVA = "0x8A3810", Offset = "0x8A2610", Length = "0x110")]
	private void ApplyTravoisDamage(float fallHeight)
	{
	}

	[Token(Token = "0x6002692")]
	[Address(RVA = "0x8A3930", Offset = "0x8A2730", Length = "0x4ED")]
	private void ApplyInsulatedFlaskDamage(float absHeight)
	{
	}

	[Token(Token = "0x6002693")]
	[Address(RVA = "0x8A3E20", Offset = "0x8A2C20", Length = "0x5")]
	private void ResetIgnoreDamageReduction()
	{
	}

	[Token(Token = "0x6002694")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FallDamage()
	{
	}
}
