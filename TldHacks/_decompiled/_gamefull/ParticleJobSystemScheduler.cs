using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A23")]
public class ParticleJobSystemScheduler : MonoBehaviour
{
	[Token(Token = "0x400664B")]
	[FieldOffset(Offset = "0x20")]
	public Action m_OnParticleUpdateJobScheduled;

	[Token(Token = "0x60058E8")]
	[Address(RVA = "0xE3CE50", Offset = "0xE3BC50", Length = "0x16")]
	private void OnParticleUpdateJobScheduled()
	{
	}

	[Token(Token = "0x60058E9")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ParticleJobSystemScheduler()
	{
	}
}
