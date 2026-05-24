using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003F1")]
public class ParticleWindForce : MonoBehaviour
{
	[Tooltip("Start system with external forces enabled")]
	[Token(Token = "0x4002355")]
	[FieldOffset(Offset = "0x20")]
	public bool m_EnableForcesByDefault;

	[Tooltip("Inherit the full external force even if occluded from the wind")]
	[Token(Token = "0x4002356")]
	[FieldOffset(Offset = "0x21")]
	public bool m_IgnoreOcculsion;

	[Token(Token = "0x4002357")]
	[FieldOffset(Offset = "0x22")]
	public bool m_ExternalOcclusionTest;

	[Tooltip("How long to wait before checking for wind occlusion")]
	[Token(Token = "0x4002358")]
	[FieldOffset(Offset = "0x24")]
	public float m_OcclusionPollIntervalSeconds;

	[Token(Token = "0x4002359")]
	[FieldOffset(Offset = "0x28")]
	public OcclusionTest m_OcclusionTest;

	[Token(Token = "0x400235A")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem m_myPS;

	[Token(Token = "0x400235B")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem.ExternalForcesModule m_externalForces;

	[Token(Token = "0x400235C")]
	[FieldOffset(Offset = "0x40")]
	private float m_CurrentTime;

	[Token(Token = "0x6001E4B")]
	[Address(RVA = "0x7B8F90", Offset = "0x7B7D90", Length = "0x1B1")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E4C")]
	[Address(RVA = "0x7B9150", Offset = "0x7B7F50", Length = "0x2EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E4D")]
	[Address(RVA = "0x7B9440", Offset = "0x7B8240", Length = "0x4E")]
	public ParticleWindForce()
	{
	}
}
