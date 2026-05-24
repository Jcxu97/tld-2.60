using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20009BF")]
public class DamageTrigger : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4006367")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Header("Damage")]
	[Token(Token = "0x4006368")]
	[FieldOffset(Offset = "0x28")]
	public DamageSource m_DamageSource;

	[Token(Token = "0x4006369")]
	[FieldOffset(Offset = "0x2C")]
	public float m_OneTimeDamage;

	[Token(Token = "0x400636A")]
	[FieldOffset(Offset = "0x30")]
	public float m_DamagePerSecond;

	[Header("Pulse Screen Effects")]
	[Token(Token = "0x400636B")]
	[FieldOffset(Offset = "0x34")]
	public float m_PulseEffectIntensity;

	[Token(Token = "0x400636C")]
	[FieldOffset(Offset = "0x38")]
	public float m_PulseEffectIntervalSeconds;

	[Header("Misc")]
	[Token(Token = "0x400636D")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_Active;

	[Token(Token = "0x400636E")]
	[FieldOffset(Offset = "0x3D")]
	public bool m_ApplyBurns;

	[Token(Token = "0x6005653")]
	[Address(RVA = "0xEB6C30", Offset = "0xEB5A30", Length = "0x7C")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6005654")]
	[Address(RVA = "0xEB6CB0", Offset = "0xEB5AB0", Length = "0x57")]
	private void OnTriggerExit()
	{
	}

	[Token(Token = "0x6005655")]
	[Address(RVA = "0xEB6D10", Offset = "0xEB5B10", Length = "0xF6")]
	private void OnTriggerStay(Collider c)
	{
	}

	[Token(Token = "0x6005656")]
	[Address(RVA = "0xEB6E10", Offset = "0xEB5C10", Length = "0x2E2")]
	private void ApplyOneTimeDamage(GameObject go, float damage)
	{
	}

	[Token(Token = "0x6005657")]
	[Address(RVA = "0xEB7100", Offset = "0xEB5F00", Length = "0x5F6")]
	private void ApplyContinuousDamage(GameObject go, float damage)
	{
	}

	[Token(Token = "0x6005658")]
	[Address(RVA = "0xEB7700", Offset = "0xEB6500", Length = "0x51")]
	public DamageTrigger()
	{
	}
}
