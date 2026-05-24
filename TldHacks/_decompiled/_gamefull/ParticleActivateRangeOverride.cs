using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003E6")]
public class ParticleActivateRangeOverride : ParticleActivateBase
{
	[SerializeField]
	[Token(Token = "0x40022F2")]
	[FieldOffset(Offset = "0x30")]
	private float m_ActivationRange;

	[Token(Token = "0x6001E22")]
	[Address(RVA = "0x7B3780", Offset = "0x7B2580", Length = "0x304")]
	public override bool CanBeActive()
	{
		return false;
	}

	[Token(Token = "0x6001E23")]
	[Address(RVA = "0x7B3A90", Offset = "0x7B2890", Length = "0x4E")]
	public ParticleActivateRangeOverride()
	{
	}
}
