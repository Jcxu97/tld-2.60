using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(ConstantForce))]
[Token(Token = "0x2000416")]
public class WindSway : MonoBehaviour
{
	[Tooltip("Maximum force applied to the ConstantForce component: (wind speed / max wind speed) * force multipler.")]
	[Token(Token = "0x40024DD")]
	[FieldOffset(Offset = "0x20")]
	public float m_ForceMultiplier;

	[Tooltip("Maximum expected windspeed, so that it can be somewhat normalized between 0 and 1.")]
	[Token(Token = "0x40024DE")]
	[FieldOffset(Offset = "0x24")]
	public float m_MaxWindSpeed;

	[Token(Token = "0x40024DF")]
	[FieldOffset(Offset = "0x28")]
	public MinMax m_RandomForceMultiplier;

	[Token(Token = "0x40024E0")]
	[FieldOffset(Offset = "0x30")]
	public MinMax m_RandomForceChangeTime;

	[Token(Token = "0x40024E1")]
	[FieldOffset(Offset = "0x38")]
	private float m_WindFactor;

	[Token(Token = "0x40024E2")]
	[FieldOffset(Offset = "0x3C")]
	private float m_SwayDirection;

	[Token(Token = "0x40024E3")]
	[FieldOffset(Offset = "0x40")]
	private float m_CurRandomForceMultiplier;

	[Token(Token = "0x40024E4")]
	[FieldOffset(Offset = "0x44")]
	private float m_CurRandomForceTimer;

	[Token(Token = "0x40024E5")]
	[FieldOffset(Offset = "0x48")]
	private ConstantForce m_ConstantForce;

	[Token(Token = "0x6001EDE")]
	[Address(RVA = "0x7CF040", Offset = "0x7CDE40", Length = "0x9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EDF")]
	[Address(RVA = "0x7CF0E0", Offset = "0x7CDEE0", Length = "0x109")]
	private void Update()
	{
	}

	[Token(Token = "0x6001EE0")]
	[Address(RVA = "0x7CF1F0", Offset = "0x7CDFF0", Length = "0x1B9")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001EE1")]
	[Address(RVA = "0x7CF3B0", Offset = "0x7CE1B0", Length = "0x51")]
	public WindSway()
	{
	}
}
