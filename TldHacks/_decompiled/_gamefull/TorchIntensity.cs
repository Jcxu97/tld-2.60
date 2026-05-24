using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000405")]
public class TorchIntensity : MonoBehaviour
{
	[Range(0f, 1f)]
	[Token(Token = "0x4002444")]
	[FieldOffset(Offset = "0x20")]
	public float m_Intensity;

	[Token(Token = "0x4002445")]
	[FieldOffset(Offset = "0x24")]
	public bool m_DynamicIntensity;

	[Token(Token = "0x4002446")]
	[FieldOffset(Offset = "0x28")]
	public float m_IntensityLerpSpeed;

	[Header("Sparks")]
	[Token(Token = "0x4002447")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve m_SparkRate;

	[Header("Smoke")]
	[Token(Token = "0x4002448")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve m_SmokeRate;

	[Token(Token = "0x4002449")]
	[FieldOffset(Offset = "0x40")]
	public Gradient m_SmokeColor;

	[Token(Token = "0x400244A")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve m_SmokeAlpha;

	[Header("Flame sprites")]
	[Token(Token = "0x400244B")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve m_SpriteSize;

	[Token(Token = "0x400244C")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve m_SpriteRateMin;

	[Token(Token = "0x400244D")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve m_SpriteRateMax;

	[Header("Core particles")]
	[Token(Token = "0x400244E")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve m_CoreSize;

	[Token(Token = "0x400244F")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve m_CoreRateMin;

	[Token(Token = "0x4002450")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve m_CoreRateMax;

	[Header("Lights")]
	[Token(Token = "0x4002451")]
	[FieldOffset(Offset = "0x80")]
	public AnimationCurve m_IndoorIntensityMin;

	[Token(Token = "0x4002452")]
	[FieldOffset(Offset = "0x88")]
	public AnimationCurve m_IndoorIntensityMax;

	[Token(Token = "0x4002453")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve m_OutdoorIntensityMin;

	[Token(Token = "0x4002454")]
	[FieldOffset(Offset = "0x98")]
	public AnimationCurve m_OutdoorIntensityMax;

	[Header("FX objects")]
	[Token(Token = "0x4002455")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_CoreParticles;

	[Token(Token = "0x4002456")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_SparkParticles;

	[Token(Token = "0x4002457")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_SmokeParticles;

	[Token(Token = "0x4002458")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_SpriteParticles;

	[Token(Token = "0x4002459")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_IndoorLight;

	[Token(Token = "0x400245A")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_OutdoorLight;

	[Token(Token = "0x400245B")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_RadialGradient;

	[Token(Token = "0x400245C")]
	[FieldOffset(Offset = "0xD8")]
	private ParticleSystem m_SpriteParticles_ParticleSystem;

	[Token(Token = "0x400245D")]
	[FieldOffset(Offset = "0xE0")]
	private ParticleRandomEmission m_SpriteParticles_ParticleRandomEmission;

	[Token(Token = "0x400245E")]
	[FieldOffset(Offset = "0xE8")]
	private ParticleSystem m_CoreParticles_ParticleSystem;

	[Token(Token = "0x400245F")]
	[FieldOffset(Offset = "0xF0")]
	private ParticleRandomEmission m_CoreParticles_ParticleRandomEmission;

	[Token(Token = "0x4002460")]
	[FieldOffset(Offset = "0xF8")]
	private ParticleSystem m_SmokeParticles_ParticleSystem;

	[Token(Token = "0x4002461")]
	[FieldOffset(Offset = "0x100")]
	private ParticleSystem m_SparkParticles_ParticleSystem;

	[Token(Token = "0x4002462")]
	[FieldOffset(Offset = "0x108")]
	private LightRandomIntensity m_IndoorLight_LightRandomIntensity;

	[Token(Token = "0x4002463")]
	[FieldOffset(Offset = "0x110")]
	private LightRandomIntensity m_OutdoorLight_LightRandomIntensity;

	[Token(Token = "0x4002464")]
	[FieldOffset(Offset = "0x118")]
	private float m_TargetIntensity;

	[Token(Token = "0x4002465")]
	[FieldOffset(Offset = "0x11C")]
	private float m_PreviousIntensity;

	[Token(Token = "0x4002466")]
	[FieldOffset(Offset = "0x120")]
	private float m_LastIntensitySentToWise;

	[Token(Token = "0x4002467")]
	[FieldOffset(Offset = "0x128")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002468")]
	[FieldOffset(Offset = "0x130")]
	private float m_MaxIndoorLightIntensity;

	[Token(Token = "0x4002469")]
	[FieldOffset(Offset = "0x134")]
	private float m_MaxOutdoorLightIntensity;

	[Token(Token = "0x400246A")]
	[FieldOffset(Offset = "0x138")]
	private Color m_RadialGradientColor;

	[Token(Token = "0x6001EA4")]
	[Address(RVA = "0x7C74A0", Offset = "0x7C62A0", Length = "0x558")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EA5")]
	[Address(RVA = "0x7C7A00", Offset = "0x7C6800", Length = "0x92E")]
	private void Update()
	{
	}

	[Token(Token = "0x6001EA6")]
	[Address(RVA = "0x7C8330", Offset = "0x7C7130", Length = "0x27")]
	public void SetIntensity(float intensity)
	{
	}

	[Token(Token = "0x6001EA7")]
	[Address(RVA = "0x785A60", Offset = "0x784860", Length = "0x138")]
	private void SetEmissionRate(ParticleSystem ps, float newRate)
	{
	}

	[Token(Token = "0x6001EA8")]
	[Address(RVA = "0x7C8360", Offset = "0x7C7160", Length = "0x193")]
	private void MaybeUpdateIntensityRTPC()
	{
	}

	[Token(Token = "0x6001EA9")]
	[Address(RVA = "0x7C8500", Offset = "0x7C7300", Length = "0x4E")]
	public TorchIntensity()
	{
	}
}
