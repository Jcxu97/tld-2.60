using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Timeline;

[Token(Token = "0x20003FC")]
public class Sparks : MonoBehaviour, ITimeControl
{
	[Header("Particles")]
	[Token(Token = "0x40023D2")]
	[FieldOffset(Offset = "0x20")]
	public float m_IntervalSeconds;

	[Range(0f, 1f)]
	[Token(Token = "0x40023D3")]
	[FieldOffset(Offset = "0x24")]
	public float m_SparkSize;

	[Range(0f, 10f)]
	[Token(Token = "0x40023D4")]
	[FieldOffset(Offset = "0x28")]
	public float m_SparkSpeed;

	[Range(0f, 2f)]
	[Token(Token = "0x40023D5")]
	[FieldOffset(Offset = "0x2C")]
	public float m_SparkGravity;

	[Range(0f, 1000f)]
	[Token(Token = "0x40023D6")]
	[FieldOffset(Offset = "0x30")]
	public float m_EmissionRate;

	[Range(0f, 1000f)]
	[Token(Token = "0x40023D7")]
	[FieldOffset(Offset = "0x34")]
	public float m_Fluxuations;

	[Range(0f, 10f)]
	[Token(Token = "0x40023D8")]
	[FieldOffset(Offset = "0x38")]
	public float m_Lifetime;

	[Header("FX objects")]
	[Token(Token = "0x40023D9")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_SparkParticles;

	[Token(Token = "0x40023DA")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_SmokeParticles;

	[Token(Token = "0x40023DB")]
	[FieldOffset(Offset = "0x50")]
	public bool m_ContinuousSmoke;

	[HideInInspector]
	[Token(Token = "0x40023DC")]
	[FieldOffset(Offset = "0x54")]
	public float m_CurrentEmissionRate;

	[Header("Fade")]
	[Token(Token = "0x40023DD")]
	[FieldOffset(Offset = "0x58")]
	public bool m_Fade;

	[Token(Token = "0x40023DE")]
	[FieldOffset(Offset = "0x5C")]
	public float m_FadeTime;

	[Token(Token = "0x40023DF")]
	[FieldOffset(Offset = "0x60")]
	private float m_CurrentFadeTime;

	[Token(Token = "0x40023E0")]
	[FieldOffset(Offset = "0x64")]
	private float m_FadeMultiplier;

	[Token(Token = "0x40023E1")]
	[FieldOffset(Offset = "0x68")]
	private float m_CurrentTime;

	[Token(Token = "0x40023E2")]
	[FieldOffset(Offset = "0x6C")]
	private float m_Destination;

	[Token(Token = "0x40023E3")]
	[FieldOffset(Offset = "0x70")]
	private float m_EmissionStart;

	[Token(Token = "0x40023E4")]
	[FieldOffset(Offset = "0x78")]
	private ParticleSystem m_SparkPS;

	[Token(Token = "0x40023E5")]
	[FieldOffset(Offset = "0x80")]
	private ParticleSystem.MainModule m_SparkPSMain;

	[Token(Token = "0x40023E6")]
	[FieldOffset(Offset = "0x88")]
	private ParticleSystem m_SmokePS;

	[Token(Token = "0x40023E7")]
	[FieldOffset(Offset = "0x90")]
	private bool m_IsTimeControlled;

	[Token(Token = "0x40023E8")]
	[FieldOffset(Offset = "0x94")]
	private float m_CurrentControlledTime;

	[Token(Token = "0x6001E81")]
	[Address(RVA = "0x7C0570", Offset = "0x7BF370", Length = "0x357")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E82")]
	[Address(RVA = "0x7C08D0", Offset = "0x7BF6D0", Length = "0x10")]
	public void SetTime(double t)
	{
	}

	[Token(Token = "0x6001E83")]
	[Address(RVA = "0x7C08E0", Offset = "0x7BF6E0", Length = "0x1D")]
	public void OnControlTimeStart()
	{
	}

	[Token(Token = "0x6001E84")]
	[Address(RVA = "0x7C0900", Offset = "0x7BF700", Length = "0x8")]
	public void OnControlTimeStop()
	{
	}

	[Token(Token = "0x6001E85")]
	[Address(RVA = "0x7C0910", Offset = "0x7BF710", Length = "0x284")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E86")]
	[Address(RVA = "0x785A60", Offset = "0x784860", Length = "0x138")]
	private void SetEmissonRate(ParticleSystem ps, float newRate)
	{
	}

	[Token(Token = "0x6001E87")]
	[Address(RVA = "0x7C0BA0", Offset = "0x7BF9A0", Length = "0x78")]
	public Sparks()
	{
	}
}
