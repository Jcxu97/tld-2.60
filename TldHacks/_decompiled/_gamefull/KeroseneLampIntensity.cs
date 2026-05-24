using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003BD")]
public class KeroseneLampIntensity : MonoBehaviour
{
	[Range(0f, 1f)]
	[Token(Token = "0x4002197")]
	[FieldOffset(Offset = "0x20")]
	public float m_Intensity;

	[Token(Token = "0x4002198")]
	[FieldOffset(Offset = "0x24")]
	public bool m_DynamicIntensity;

	[Header("Flame particles")]
	[Token(Token = "0x4002199")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve m_FlameRateMin;

	[Token(Token = "0x400219A")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve m_FlameRateMax;

	[Token(Token = "0x400219B")]
	[FieldOffset(Offset = "0x38")]
	public Gradient m_FlameColor;

	[Header("Lights")]
	[Token(Token = "0x400219C")]
	[FieldOffset(Offset = "0x40")]
	public float m_IndoorIntensity;

	[Token(Token = "0x400219D")]
	[FieldOffset(Offset = "0x44")]
	public float m_OutdoorIntensity;

	[Token(Token = "0x400219E")]
	[FieldOffset(Offset = "0x48")]
	public float m_FillIntensity;

	[Token(Token = "0x400219F")]
	[FieldOffset(Offset = "0x4C")]
	public float m_RimIntensity;

	[Header("Glass")]
	[Token(Token = "0x40021A0")]
	[FieldOffset(Offset = "0x50")]
	public Gradient m_GlassColor;

	[Header("FX objects")]
	[Token(Token = "0x40021A1")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_FlameParticles;

	[SerializeField]
	[Token(Token = "0x40021A2")]
	[FieldOffset(Offset = "0x60")]
	private LightTracking m_IndoorLight;

	[SerializeField]
	[Token(Token = "0x40021A3")]
	[FieldOffset(Offset = "0x68")]
	private LightTracking m_IndoorLightCore;

	[SerializeField]
	[Token(Token = "0x40021A4")]
	[FieldOffset(Offset = "0x70")]
	private LightTracking m_SelfLightFill;

	[SerializeField]
	[Token(Token = "0x40021A5")]
	[FieldOffset(Offset = "0x78")]
	private LightTracking m_SelfLightRim;

	[SerializeField]
	[Token(Token = "0x40021A6")]
	[FieldOffset(Offset = "0x80")]
	private LightTracking m_OutdoorLight;

	[Token(Token = "0x40021A7")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_LitGlass;

	[Token(Token = "0x40021A8")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_Glass;

	[Token(Token = "0x40021A9")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_RadialGradient;

	[Token(Token = "0x40021AA")]
	[FieldOffset(Offset = "0xA0")]
	private float m_ParticleIntensity;

	[Token(Token = "0x40021AB")]
	[FieldOffset(Offset = "0xA8")]
	private ParticleSystem m_FlameParticles_ParticleSystem;

	[Token(Token = "0x40021AC")]
	[FieldOffset(Offset = "0xB0")]
	private ParticleRandomEmission m_FlameParticles_ParticleRandomEmission;

	[Token(Token = "0x40021AD")]
	[FieldOffset(Offset = "0xB8")]
	private Material m_LitGlassMaterial;

	[Token(Token = "0x40021AE")]
	[FieldOffset(Offset = "0xC0")]
	private float m_PreviousIntensity;

	[Token(Token = "0x40021AF")]
	[FieldOffset(Offset = "0xC4")]
	private float m_LastIntensitySentToWise;

	[Token(Token = "0x40021B0")]
	[FieldOffset(Offset = "0xC8")]
	private GearItem m_GearItem;

	[Token(Token = "0x40021B1")]
	[FieldOffset(Offset = "0xD0")]
	private float m_MaxFlameParticlesEmission;

	[Token(Token = "0x40021B2")]
	[FieldOffset(Offset = "0xD4")]
	private Color m_RadialGradientColor;

	[Token(Token = "0x40021B3")]
	[FieldOffset(Offset = "0xE4")]
	private float currentCameraAngle;

	[Token(Token = "0x6001D67")]
	[Address(RVA = "0x7A0260", Offset = "0x79F060", Length = "0x419")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D68")]
	[Address(RVA = "0x7A0680", Offset = "0x79F480", Length = "0xB0B")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D69")]
	[Address(RVA = "0x7A1190", Offset = "0x79FF90", Length = "0x1FA")]
	public void InstantFullEmission()
	{
	}

	[Token(Token = "0x6001D6A")]
	[Address(RVA = "0x7A1390", Offset = "0x7A0190", Length = "0x21")]
	public void SetIntensity(float intensity)
	{
	}

	[Token(Token = "0x6001D6B")]
	[Address(RVA = "0x7A13C0", Offset = "0x7A01C0", Length = "0x102")]
	private float GetEmissionRate(ParticleSystem ps)
	{
		return 0f;
	}

	[Token(Token = "0x6001D6C")]
	[Address(RVA = "0x785A60", Offset = "0x784860", Length = "0x138")]
	private void SetEmissionRate(ParticleSystem ps, float newRate)
	{
	}

	[Token(Token = "0x6001D6D")]
	[Address(RVA = "0x7A14D0", Offset = "0x7A02D0", Length = "0xDE")]
	private void MaybeUpdateIntensityRTPC()
	{
	}

	[Token(Token = "0x6001D6E")]
	[Address(RVA = "0x784250", Offset = "0x783050", Length = "0x4E")]
	public KeroseneLampIntensity()
	{
	}
}
