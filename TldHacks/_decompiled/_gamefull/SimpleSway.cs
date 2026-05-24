using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003F9")]
public class SimpleSway : MonoBehaviour
{
	[Tooltip("How long does one swing last? Time in seconds.")]
	[Token(Token = "0x4002392")]
	[FieldOffset(Offset = "0x20")]
	public float m_SwayPeriod;

	[Tooltip("The half angle of the swing, degrees.")]
	[Token(Token = "0x4002393")]
	[FieldOffset(Offset = "0x24")]
	public float m_SwayHalfAngle;

	[Tooltip("The direction of the sway, 0/180 = z axis, -90/90 = x axis.")]
	[Range(-180f, 180f)]
	[Token(Token = "0x4002394")]
	[FieldOffset(Offset = "0x28")]
	public float m_SwayDirection;

	[Tooltip("Swing distance multiplier.")]
	[Token(Token = "0x4002395")]
	[FieldOffset(Offset = "0x2C")]
	public float m_SwayMultiplier;

	[Tooltip("The lower and upper bounds for a time offset.")]
	[Token(Token = "0x4002396")]
	[FieldOffset(Offset = "0x30")]
	public MinMax m_RandomTimeOffset;

	[Token(Token = "0x4002397")]
	[FieldOffset(Offset = "0x38")]
	private float m_SwayRate;

	[Token(Token = "0x4002398")]
	[FieldOffset(Offset = "0x3C")]
	private float m_SwayTimer;

	[Token(Token = "0x4002399")]
	[FieldOffset(Offset = "0x40")]
	private float m_CurDegrees;

	[Token(Token = "0x400239A")]
	[FieldOffset(Offset = "0x44")]
	private float m_CurTimeOffset;

	[Token(Token = "0x400239B")]
	[FieldOffset(Offset = "0x48")]
	private float m_RadDirection;

	[Token(Token = "0x400239C")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_Direction;

	[Token(Token = "0x6001E6C")]
	[Address(RVA = "0x7BDC70", Offset = "0x7BCA70", Length = "0x71")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E6D")]
	[Address(RVA = "0x7BDCF0", Offset = "0x7BCAF0", Length = "0x1B9")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E6E")]
	[Address(RVA = "0x5093D0", Offset = "0x5081D0", Length = "0x6")]
	public void SetSwingMultiplier(float newMultiplier = 1f)
	{
	}

	[Token(Token = "0x6001E6F")]
	[Address(RVA = "0x7BDEB0", Offset = "0x7BCCB0", Length = "0x4A")]
	public SimpleSway()
	{
	}
}
