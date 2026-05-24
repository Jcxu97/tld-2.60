using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003E8")]
public class ParticleDistanceCull : MonoBehaviour
{
	[Token(Token = "0x20003E9")]
	public enum ParticleGatherType
	{
		[Token(Token = "0x4002307")]
		Manual,
		[Token(Token = "0x4002308")]
		OnLoad,
		[Token(Token = "0x4002309")]
		Children
	}

	[Serializable]
	[Token(Token = "0x20003EA")]
	private struct ParticleDef
	{
		[Token(Token = "0x400230A")]
		[FieldOffset(Offset = "0x0")]
		public List<ParticleSystem> m_Particle;

		[Token(Token = "0x400230B")]
		[FieldOffset(Offset = "0x8")]
		public List<Vector3> m_Position;

		[Token(Token = "0x400230C")]
		[FieldOffset(Offset = "0x10")]
		public List<bool> m_PrevState;

		[Token(Token = "0x400230D")]
		[FieldOffset(Offset = "0x18")]
		public List<ParticleSystem.MinMaxGradient> m_StartColor;

		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x7B53F0", Offset = "0x7B41F0", Length = "0x5B0")]
		public void AddFX(ParticleSystem ps)
		{
		}

		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x7B59B0", Offset = "0x7B47B0", Length = "0x18A")]
		public void RemoveFX(ParticleSystem ps)
		{
		}

		[Token(Token = "0x6001E33")]
		[Address(RVA = "0x7B5B40", Offset = "0x7B4940", Length = "0x3BB")]
		public void UpdateFX(Vector3 camPos, float maxDistSqr, float fadeDistSqr)
		{
		}
	}

	[Header("PC values")]
	[Token(Token = "0x40022F9")]
	[FieldOffset(Offset = "0x20")]
	public float m_LowDistance;

	[Token(Token = "0x40022FA")]
	[FieldOffset(Offset = "0x24")]
	public float m_MediumDistance;

	[Token(Token = "0x40022FB")]
	[FieldOffset(Offset = "0x28")]
	public float m_HighDistance;

	[Token(Token = "0x40022FC")]
	[FieldOffset(Offset = "0x2C")]
	public float m_UltraDistance;

	[Header("Fade particles n% from maximum distance.")]
	[Token(Token = "0x40022FD")]
	[FieldOffset(Offset = "0x30")]
	public float m_FadePercentage;

	[Header("Timing, in seconds")]
	[Token(Token = "0x40022FE")]
	[FieldOffset(Offset = "0x34")]
	public float m_UpdateFrequency;

	[Header("Particle list")]
	[Token(Token = "0x40022FF")]
	[FieldOffset(Offset = "0x38")]
	public ParticleGatherType m_GatherType;

	[Token(Token = "0x4002300")]
	[FieldOffset(Offset = "0x40")]
	public List<ParticleSystem> m_ParticleList;

	[Token(Token = "0x4002301")]
	[FieldOffset(Offset = "0x48")]
	private ParticleDef m_AllParticles;

	[Token(Token = "0x4002302")]
	[FieldOffset(Offset = "0x68")]
	private float m_UpdateTime;

	[Token(Token = "0x4002303")]
	[FieldOffset(Offset = "0x6C")]
	private float m_MaxDistSqr;

	[Token(Token = "0x4002304")]
	[FieldOffset(Offset = "0x70")]
	private float m_FadeDistSqr;

	[Token(Token = "0x4002305")]
	[FieldOffset(Offset = "0x74")]
	private QualityLodBias m_CachedQuality;

	[Token(Token = "0x6001E2C")]
	[Address(RVA = "0x7B4A60", Offset = "0x7B3860", Length = "0x560")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E2D")]
	[Address(RVA = "0x7B4FD0", Offset = "0x7B3DD0", Length = "0x255")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001E2E")]
	[Address(RVA = "0x7A3CC0", Offset = "0x7A2AC0", Length = "0x5E")]
	private void UpdateQualityValues()
	{
	}

	[Token(Token = "0x6001E2F")]
	[Address(RVA = "0x7B5230", Offset = "0x7B4030", Length = "0x140")]
	private void UpdateParticle()
	{
	}

	[Token(Token = "0x6001E30")]
	[Address(RVA = "0x7B5380", Offset = "0x7B4180", Length = "0x6D")]
	public ParticleDistanceCull()
	{
	}
}
