using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD;

[RequireComponent(typeof(BoxCollider))]
[Token(Token = "0x2001342")]
public class EnvironmentalEffectTrigger : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2001343")]
	private struct AmbientEffect
	{
		[Token(Token = "0x4008E11")]
		[FieldOffset(Offset = "0x0")]
		public ParticleSystem m_ParticleSystem;

		[NonSerialized]
		[Token(Token = "0x4008E12")]
		[FieldOffset(Offset = "0x8")]
		public ParticleActivateBase[] m_ParticleActivateBaseComponents;
	}

	[SerializeField]
	[Token(Token = "0x4008E0A")]
	[FieldOffset(Offset = "0x20")]
	private List<AmbientEffect> m_AmbientEffectList;

	[Header("Playing Effect")]
	[Tooltip("Odds a randomly selected ambient effect is played")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4008E0B")]
	[FieldOffset(Offset = "0x28")]
	private float m_PlayChance;

	[Tooltip("How often do we check in game time")]
	[SerializeField]
	[Token(Token = "0x4008E0C")]
	[FieldOffset(Offset = "0x2C")]
	private float m_PlayChanceOverGameMinutes;

	[Header("Cooldown Variance")]
	[Tooltip("The minimum amount of time to wait before attempting to play")]
	[SerializeField]
	[Token(Token = "0x4008E0D")]
	[FieldOffset(Offset = "0x30")]
	private float m_MinCooldownGameMinutes;

	[Tooltip("The maximum amount of time to wait before attempting to play")]
	[SerializeField]
	[Token(Token = "0x4008E0E")]
	[FieldOffset(Offset = "0x34")]
	private float m_MaxCooldownGameMinutes;

	[Token(Token = "0x4008E0F")]
	[FieldOffset(Offset = "0x38")]
	private float m_ElapsedTimer;

	[Token(Token = "0x4008E10")]
	[FieldOffset(Offset = "0x40")]
	private List<ParticleSystem> m_CurrentEffects;

	[Token(Token = "0x6007B5B")]
	[Address(RVA = "0x11A0970", Offset = "0x119F770", Length = "0x81")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6007B5C")]
	[Address(RVA = "0x11A0A00", Offset = "0x119F800", Length = "0xB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6007B5D")]
	[Address(RVA = "0x11A0AC0", Offset = "0x119F8C0", Length = "0x23D")]
	private void SetupParticleActivateBaseComponents()
	{
	}

	[Token(Token = "0x6007B5E")]
	[Address(RVA = "0x11A0D00", Offset = "0x119FB00", Length = "0x5A")]
	private bool CanUseTrigger(Collider c)
	{
		return false;
	}

	[Token(Token = "0x6007B5F")]
	[Address(RVA = "0x11A0D60", Offset = "0x119FB60", Length = "0x286")]
	private void OnTriggerStay(Collider c)
	{
	}

	[Token(Token = "0x6007B60")]
	[Address(RVA = "0x11A0FF0", Offset = "0x119FDF0", Length = "0x89")]
	private void Update()
	{
	}

	[Token(Token = "0x6007B61")]
	[Address(RVA = "0x11A1080", Offset = "0x119FE80", Length = "0x136")]
	private bool MaybePlayEffect(ParticleSystem particleSystem)
	{
		return false;
	}

	[Token(Token = "0x6007B62")]
	[Address(RVA = "0x11A11C0", Offset = "0x119FFC0", Length = "0x285")]
	private void MaybeExpireEffects()
	{
	}

	[Token(Token = "0x6007B63")]
	[Address(RVA = "0x11A1450", Offset = "0x11A0250", Length = "0x1D9")]
	private ParticleSystem TryPickRandomEffect()
	{
		return null;
	}

	[Token(Token = "0x6007B64")]
	[Address(RVA = "0x11A1630", Offset = "0x11A0430", Length = "0xAC")]
	private bool CanBeActivated(AmbientEffect ambientEffect)
	{
		return false;
	}

	[Token(Token = "0x6007B65")]
	[Address(RVA = "0x11A16E0", Offset = "0x11A04E0", Length = "0x23")]
	private float PickCooldownTimeHours()
	{
		return 0f;
	}

	[Token(Token = "0x6007B66")]
	[Address(RVA = "0x11A1710", Offset = "0x11A0510", Length = "0x104")]
	public EnvironmentalEffectTrigger()
	{
	}
}
