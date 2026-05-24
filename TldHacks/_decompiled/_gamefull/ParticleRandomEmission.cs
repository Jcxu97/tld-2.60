using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003EF")]
public class ParticleRandomEmission : MonoBehaviour
{
	[Token(Token = "0x4002349")]
	[FieldOffset(Offset = "0x20")]
	public float m_IntervalSeconds;

	[Token(Token = "0x400234A")]
	[FieldOffset(Offset = "0x24")]
	public float m_Min;

	[Token(Token = "0x400234B")]
	[FieldOffset(Offset = "0x28")]
	public float m_Max;

	[HideInInspector]
	[Token(Token = "0x400234C")]
	[FieldOffset(Offset = "0x2C")]
	public float m_CurrentEmissionRate;

	[Token(Token = "0x400234D")]
	[FieldOffset(Offset = "0x30")]
	private float m_CurrentTime;

	[Token(Token = "0x400234E")]
	[FieldOffset(Offset = "0x34")]
	private float m_Destination;

	[Token(Token = "0x400234F")]
	[FieldOffset(Offset = "0x38")]
	private float m_EmissionStart;

	[Token(Token = "0x4002350")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem m_ParticleSystem;

	[Token(Token = "0x6001E43")]
	[Address(RVA = "0x7B8960", Offset = "0x7B7760", Length = "0xB6")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E44")]
	[Address(RVA = "0x785A60", Offset = "0x784860", Length = "0x138")]
	private void SetEmissonRate(ParticleSystem ps, float newRate)
	{
	}

	[Token(Token = "0x6001E45")]
	[Address(RVA = "0x7B8A20", Offset = "0x7B7820", Length = "0x144")]
	public void ForceEmissionRate(ParticleSystem ps, float newRate)
	{
	}

	[Token(Token = "0x6001E46")]
	[Address(RVA = "0x7B8B70", Offset = "0x7B7970", Length = "0x123")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E47")]
	[Address(RVA = "0x787050", Offset = "0x785E50", Length = "0x51")]
	public ParticleRandomEmission()
	{
	}
}
