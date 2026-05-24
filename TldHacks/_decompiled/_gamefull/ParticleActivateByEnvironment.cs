using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003E1")]
public class ParticleActivateByEnvironment : ParticleActivateBase
{
	[Tooltip("A particle system with this component will only activate when outdoors. If IsIndoorOnly is enabled, the inverse is true and will only activate indoors")]
	[SerializeField]
	[Token(Token = "0x40022EA")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsIndoorOnly;

	[Token(Token = "0x6001E16")]
	[Address(RVA = "0x7B3010", Offset = "0x7B1E10", Length = "0x69")]
	public override bool CanBeActive()
	{
		return false;
	}

	[Token(Token = "0x6001E17")]
	[Address(RVA = "0x7B2E60", Offset = "0x7B1C60", Length = "0x47")]
	public ParticleActivateByEnvironment()
	{
	}
}
