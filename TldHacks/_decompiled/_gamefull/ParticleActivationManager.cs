using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003E7")]
public class ParticleActivationManager : MonoBehaviour
{
	[Tooltip("How far away can the player be to activate effect")]
	[SerializeField]
	[Token(Token = "0x40022F3")]
	[FieldOffset(Offset = "0x20")]
	private float m_DefaultActivationRange;

	[Tooltip("Stagger activations to reduce load and improve performance")]
	[SerializeField]
	[Token(Token = "0x40022F4")]
	[FieldOffset(Offset = "0x24")]
	private int m_MaxActivationsPerFrame;

	[Token(Token = "0x40022F5")]
	[FieldOffset(Offset = "0x28")]
	private List<ParticleSystem> m_ParticleSystems;

	[Token(Token = "0x40022F6")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ParticleSystem, List<ParticleActivateBase>> m_ActivationComponentsByParticleSystem;

	[Token(Token = "0x40022F7")]
	[FieldOffset(Offset = "0x38")]
	private List<ParticleSystem> m_HasActivationRangeOverride;

	[Token(Token = "0x40022F8")]
	[FieldOffset(Offset = "0x40")]
	private int m_CurrentActivationIndex;

	[Token(Token = "0x6001E24")]
	[Address(RVA = "0x7B3AE0", Offset = "0x7B28E0", Length = "0x304")]
	public void Register(ParticleActivateBase activationComponent)
	{
	}

	[Token(Token = "0x6001E25")]
	[Address(RVA = "0x7B3DF0", Offset = "0x7B2BF0", Length = "0x229")]
	public void Unregister(ParticleActivateBase activationComponent)
	{
	}

	[Token(Token = "0x6001E26")]
	[Address(RVA = "0x7B4020", Offset = "0x7B2E20", Length = "0xEB")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E27")]
	[Address(RVA = "0x7B4110", Offset = "0x7B2F10", Length = "0x16A")]
	private bool CanBeActive(ParticleSystem ps, out bool isVisible)
	{
		isVisible = default(bool);
		return false;
	}

	[Token(Token = "0x6001E28")]
	[Address(RVA = "0x7B4280", Offset = "0x7B3080", Length = "0x325")]
	private bool IsWithinDefaultRange(ParticleSystem ps)
	{
		return false;
	}

	[Token(Token = "0x6001E29")]
	[Address(RVA = "0x7B45B0", Offset = "0x7B33B0", Length = "0x16D")]
	private void MaybeStartPlaying(ParticleSystem ps)
	{
	}

	[Token(Token = "0x6001E2A")]
	[Address(RVA = "0x7B4720", Offset = "0x7B3520", Length = "0x11B")]
	private void MaybeStopPlaying(ParticleSystem ps, bool isVisible)
	{
	}

	[Token(Token = "0x6001E2B")]
	[Address(RVA = "0x7B4840", Offset = "0x7B3640", Length = "0x211")]
	public ParticleActivationManager()
	{
	}
}
