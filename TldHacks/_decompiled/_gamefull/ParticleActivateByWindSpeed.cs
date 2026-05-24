using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003E5")]
public class ParticleActivateByWindSpeed : ParticleActivateBase
{
	[SerializeField]
	[Token(Token = "0x40022F0")]
	[FieldOffset(Offset = "0x30")]
	private WindStrength m_MinWindStrength;

	[SerializeField]
	[Token(Token = "0x40022F1")]
	[FieldOffset(Offset = "0x34")]
	private WindStrength m_MaxWindStrength;

	[Token(Token = "0x6001E20")]
	[Address(RVA = "0x7B3710", Offset = "0x7B2510", Length = "0x6D")]
	public override bool CanBeActive()
	{
		return false;
	}

	[Token(Token = "0x6001E21")]
	[Address(RVA = "0x7B2E60", Offset = "0x7B1C60", Length = "0x47")]
	public ParticleActivateByWindSpeed()
	{
	}
}
