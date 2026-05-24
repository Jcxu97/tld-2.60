using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003E2")]
public class ParticleActivateByTime : ParticleActivateBase
{
	[SerializeField]
	[Range(0f, 24f)]
	[Token(Token = "0x40022EB")]
	[FieldOffset(Offset = "0x30")]
	private int m_StartingHour;

	[SerializeField]
	[Range(0f, 24f)]
	[Token(Token = "0x40022EC")]
	[FieldOffset(Offset = "0x34")]
	private int m_EndingHour;

	[Token(Token = "0x6001E18")]
	[Address(RVA = "0x7B3080", Offset = "0x7B1E80", Length = "0x9B")]
	public override bool CanBeActive()
	{
		return false;
	}

	[Token(Token = "0x6001E19")]
	[Address(RVA = "0x7B2E60", Offset = "0x7B1C60", Length = "0x47")]
	public ParticleActivateByTime()
	{
	}
}
