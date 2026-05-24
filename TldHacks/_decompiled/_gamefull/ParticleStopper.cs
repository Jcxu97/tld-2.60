using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003F0")]
public class ParticleStopper : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002351")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem m_ParticleSystem;

	[SerializeField]
	[Token(Token = "0x4002352")]
	[FieldOffset(Offset = "0x28")]
	private bool m_StopChildren;

	[SerializeField]
	[Token(Token = "0x4002353")]
	[FieldOffset(Offset = "0x2C")]
	private ParticleSystemStopBehavior m_StopBehavior;

	[Token(Token = "0x4002354")]
	[FieldOffset(Offset = "0x30")]
	private Action m_OnStopCompletedAction;

	[Token(Token = "0x6001E48")]
	[Address(RVA = "0x7B8CA0", Offset = "0x7B7AA0", Length = "0x228")]
	public void StopWithCallback(Action onStopCompleted)
	{
	}

	[Token(Token = "0x6001E49")]
	[Address(RVA = "0x7B8ED0", Offset = "0x7B7CD0", Length = "0x67")]
	private void OnParticleSystemStopped()
	{
	}

	[Token(Token = "0x6001E4A")]
	[Address(RVA = "0x7B8F40", Offset = "0x7B7D40", Length = "0x4E")]
	public ParticleStopper()
	{
	}
}
