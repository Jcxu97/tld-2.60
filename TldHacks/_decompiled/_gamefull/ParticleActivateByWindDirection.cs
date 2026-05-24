using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003E4")]
public class ParticleActivateByWindDirection : ParticleActivateBase
{
	[SerializeField]
	[Range(0f, 360f)]
	[Token(Token = "0x40022EE")]
	[FieldOffset(Offset = "0x30")]
	private float m_AimAngle;

	[SerializeField]
	[Range(0f, 180f)]
	[Token(Token = "0x40022EF")]
	[FieldOffset(Offset = "0x34")]
	private float m_SpreadDegrees;

	[Token(Token = "0x6001E1C")]
	[Address(RVA = "0x7B3200", Offset = "0x7B2000", Length = "0x2EC")]
	public override bool CanBeActive()
	{
		return false;
	}

	[Token(Token = "0x6001E1D")]
	[Address(RVA = "0x7B34F0", Offset = "0x7B22F0", Length = "0x21A")]
	public Vector3 GetAimDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E1E")]
	[Address(RVA = "0x509500", Offset = "0x508300", Length = "0x6")]
	public float GetSpreadDegrees()
	{
		return 0f;
	}

	[Token(Token = "0x6001E1F")]
	[Address(RVA = "0x7B2E60", Offset = "0x7B1C60", Length = "0x47")]
	public ParticleActivateByWindDirection()
	{
	}
}
