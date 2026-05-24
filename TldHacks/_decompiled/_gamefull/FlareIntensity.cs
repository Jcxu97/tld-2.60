using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000392")]
public class FlareIntensity : MonoBehaviour
{
	[Token(Token = "0x4001FEE")]
	private static readonly int s_TintColor;

	[Range(0f, 1f)]
	[Token(Token = "0x4001FEF")]
	[FieldOffset(Offset = "0x20")]
	public float m_Intensity;

	[Token(Token = "0x4001FF0")]
	[FieldOffset(Offset = "0x24")]
	public bool m_DynamicIntensity;

	[Header("Particles")]
	[Token(Token = "0x4001FF1")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve m_SmokeRate;

	[Token(Token = "0x4001FF2")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve m_CoreRate;

	[Token(Token = "0x4001FF3")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve m_SparkRate;

	[Header("Lights")]
	[Token(Token = "0x4001FF4")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve m_IndoorIntensityMin;

	[Token(Token = "0x4001FF5")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve m_IndoorIntensityMax;

	[Token(Token = "0x4001FF6")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve m_OutdoorIntensityMin;

	[Token(Token = "0x4001FF7")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve m_OutdoorIntensityMax;

	[Header("FX objects")]
	[Token(Token = "0x4001FF8")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_SmokeParticles;

	[Token(Token = "0x4001FF9")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_CoreParticles;

	[Token(Token = "0x4001FFA")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_SparkParticles;

	[Token(Token = "0x4001FFB")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_IndoorLight;

	[Token(Token = "0x4001FFC")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_OutdoorLight;

	[Token(Token = "0x4001FFD")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_RadialGradient;

	[Token(Token = "0x4001FFE")]
	[FieldOffset(Offset = "0x90")]
	private ParticleSystem m_SmokeParticles_ParticleSystem;

	[Token(Token = "0x4001FFF")]
	[FieldOffset(Offset = "0x98")]
	private ParticleSystem m_CoreParticles_ParticleSystem;

	[Token(Token = "0x4002000")]
	[FieldOffset(Offset = "0xA0")]
	private ParticleSystem m_SparkParticles_ParticleSystem;

	[Token(Token = "0x4002001")]
	[FieldOffset(Offset = "0xA8")]
	private LightRandomIntensity m_IndoorLight_LightRandomIntensity;

	[Token(Token = "0x4002002")]
	[FieldOffset(Offset = "0xB0")]
	private LightRandomIntensity m_OutdoorLight_LightRandomIntensity;

	[Token(Token = "0x4002003")]
	[FieldOffset(Offset = "0xB8")]
	private float m_PreviousIntensity;

	[Token(Token = "0x4002004")]
	[FieldOffset(Offset = "0xBC")]
	private float m_LastIntensitySentToWise;

	[Token(Token = "0x4002005")]
	[FieldOffset(Offset = "0xC0")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002006")]
	[FieldOffset(Offset = "0xC8")]
	private float m_MaxIndoorLightIntensity;

	[Token(Token = "0x4002007")]
	[FieldOffset(Offset = "0xCC")]
	private float m_MaxOutdoorLightIntensity;

	[Token(Token = "0x4002008")]
	[FieldOffset(Offset = "0xD0")]
	private Color m_RadialGradientColor;

	[Token(Token = "0x4002009")]
	[FieldOffset(Offset = "0xE0")]
	private MeshRenderer m_RadialGradientMeshRenderer;

	[Token(Token = "0x400200A")]
	[FieldOffset(Offset = "0xE8")]
	private FlareIntensityManager m_FlareIntensityManager;

	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x783FE0", Offset = "0x782DE0", Length = "0x171")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x784160", Offset = "0x782F60", Length = "0xE9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001C82")]
	[Address(RVA = "0x784250", Offset = "0x783050", Length = "0x4E")]
	public FlareIntensity()
	{
	}
}
