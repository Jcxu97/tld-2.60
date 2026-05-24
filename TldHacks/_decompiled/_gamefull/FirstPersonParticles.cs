using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000391")]
public class FirstPersonParticles : MonoBehaviour
{
	[Header("Player Movement")]
	[SerializeField]
	[Token(Token = "0x4001FE3")]
	[FieldOffset(Offset = "0x20")]
	private bool m_ApplyPlayerMovement;

	[Tooltip("Multiplier for how much the player's movement should affect the particles")]
	[SerializeField]
	[Token(Token = "0x4001FE4")]
	[FieldOffset(Offset = "0x24")]
	private float m_PlayerMovementScale;

	[Header("Wind")]
	[SerializeField]
	[Token(Token = "0x4001FE5")]
	[FieldOffset(Offset = "0x28")]
	private bool m_ApplyWindForce;

	[Tooltip("Inherit the full external force even if occluded from the wind")]
	[SerializeField]
	[Token(Token = "0x4001FE6")]
	[FieldOffset(Offset = "0x29")]
	private bool m_IgnoreOcclusion;

	[Tooltip("How long to wait before checking for wind occlusion")]
	[SerializeField]
	[Token(Token = "0x4001FE7")]
	[FieldOffset(Offset = "0x2C")]
	private float m_OcclusionPollIntervalSeconds;

	[Tooltip("Multiplier for how much the wind should affect the particles")]
	[SerializeField]
	[Token(Token = "0x4001FE8")]
	[FieldOffset(Offset = "0x30")]
	private float m_WindForceScale;

	[Token(Token = "0x4001FE9")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 m_LastFrameWorldPosition;

	[Token(Token = "0x4001FEA")]
	[FieldOffset(Offset = "0x40")]
	private bool m_AppliedLastFrame;

	[Token(Token = "0x4001FEB")]
	[FieldOffset(Offset = "0x44")]
	private float m_CurrentTime;

	[Token(Token = "0x4001FEC")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem m_System;

	[Token(Token = "0x4001FED")]
	[FieldOffset(Offset = "0x50")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0x782F80", Offset = "0x781D80", Length = "0x1D1")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0x783160", Offset = "0x781F60", Length = "0x235")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0x7833A0", Offset = "0x7821A0", Length = "0x34A")]
	private void InitializeIfNeeded()
	{
	}

	[Token(Token = "0x6001C7D")]
	[Address(RVA = "0x7836F0", Offset = "0x7824F0", Length = "0x3CB")]
	private Vector3 ComputeMovementInEmitterSpace(Transform worldSpace)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x783AC0", Offset = "0x7828C0", Length = "0x463")]
	private Vector3 ComputeWindInEmitterSpace()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x783F30", Offset = "0x782D30", Length = "0xA9")]
	public FirstPersonParticles()
	{
	}
}
