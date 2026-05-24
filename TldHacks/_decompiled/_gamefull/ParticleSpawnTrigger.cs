using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009CE")]
public class ParticleSpawnTrigger : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400639A")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem m_SpawnedParticleSystem;

	[SerializeField]
	[Token(Token = "0x400639B")]
	[FieldOffset(Offset = "0x28")]
	private bool m_ShouldSpawnOnEnter;

	[SerializeField]
	[Token(Token = "0x400639C")]
	[FieldOffset(Offset = "0x29")]
	private bool m_ShouldSpawnOnExit;

	[SerializeField]
	[Token(Token = "0x400639D")]
	[FieldOffset(Offset = "0x2C")]
	private LayerMask m_LayerMask;

	[SerializeField]
	[Token(Token = "0x400639E")]
	[FieldOffset(Offset = "0x30")]
	private bool m_AllowRetriggerFromSameObject;

	[SerializeField]
	[Range(1f, 10f)]
	[Token(Token = "0x400639F")]
	[FieldOffset(Offset = "0x34")]
	private int m_PooledParticleCount;

	[Token(Token = "0x40063A0")]
	[FieldOffset(Offset = "0x38")]
	private int m_CurrentPoolIndex;

	[Token(Token = "0x40063A1")]
	[FieldOffset(Offset = "0x40")]
	private List<ParticleSystem> m_ParticleSystemPool;

	[Token(Token = "0x40063A2")]
	[FieldOffset(Offset = "0x48")]
	private HashSet<Collider> m_TriggeredColliders;

	[Token(Token = "0x600569B")]
	[Address(RVA = "0xEBBC50", Offset = "0xEBAA50", Length = "0x4D6")]
	private void Start()
	{
	}

	[Token(Token = "0x600569C")]
	[Address(RVA = "0xEBC130", Offset = "0xEBAF30", Length = "0x10C")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x600569D")]
	[Address(RVA = "0xEBC240", Offset = "0xEBB040", Length = "0x10C")]
	private void OnTriggerExit(Collider collider)
	{
	}

	[Token(Token = "0x600569E")]
	[Address(RVA = "0xEBC350", Offset = "0xEBB150", Length = "0x17A")]
	private bool IsAllowedToTrigger(Collider collider)
	{
		return false;
	}

	[Token(Token = "0x600569F")]
	[Address(RVA = "0xEBC4D0", Offset = "0xEBB2D0", Length = "0x18")]
	private bool IsValidLayer(int layer)
	{
		return false;
	}

	[Token(Token = "0x60056A0")]
	[Address(RVA = "0xEBC4F0", Offset = "0xEBB2F0", Length = "0x92")]
	private ParticleSystem GetNextParticleSystemFromPool()
	{
		return null;
	}

	[Token(Token = "0x60056A1")]
	[Address(RVA = "0xEBC590", Offset = "0xEBB390", Length = "0x22F")]
	private void SpawnParticlesAtPosition(Vector3 worldPosition)
	{
	}

	[Token(Token = "0x60056A2")]
	[Address(RVA = "0xEBC7C0", Offset = "0xEBB5C0", Length = "0x55")]
	public ParticleSpawnTrigger()
	{
	}
}
