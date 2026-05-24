using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003AE")]
public class HighlightFog : MonoBehaviour
{
	[Token(Token = "0x40020CE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_FogQuad;

	[Token(Token = "0x40020CF")]
	[FieldOffset(Offset = "0x28")]
	public float m_NearVanish;

	[Token(Token = "0x40020D0")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FadeDistance;

	[Token(Token = "0x40020D1")]
	[FieldOffset(Offset = "0x30")]
	public float m_CheatTowardPlayer;

	[Token(Token = "0x40020D2")]
	[FieldOffset(Offset = "0x34")]
	public Color m_BaseColor;

	[Range(0f, 3f)]
	[Token(Token = "0x40020D3")]
	[FieldOffset(Offset = "0x44")]
	public float m_SoftEdgeFactor;

	[Token(Token = "0x40020D4")]
	[FieldOffset(Offset = "0x48")]
	public bool m_FadeAtNight;

	[Token(Token = "0x40020D5")]
	[FieldOffset(Offset = "0x49")]
	public bool m_LinkToElectrostatic;

	[Token(Token = "0x40020D6")]
	[FieldOffset(Offset = "0x4A")]
	public bool m_FadeAtRightAngles;

	[Range(0f, 0.99f)]
	[Token(Token = "0x40020D7")]
	[FieldOffset(Offset = "0x4C")]
	public float m_AngleFadeThreshold;

	[Token(Token = "0x40020D8")]
	[FieldOffset(Offset = "0x50")]
	public bool m_LookAtPlayer;

	[Token(Token = "0x40020D9")]
	[FieldOffset(Offset = "0x58")]
	public Light m_LightDriver;

	[Token(Token = "0x40020DA")]
	[FieldOffset(Offset = "0x60")]
	public float m_LightDriverMax;

	[Token(Token = "0x40020DB")]
	[FieldOffset(Offset = "0x64")]
	public bool m_LinkLightColor;

	[Token(Token = "0x40020DC")]
	[FieldOffset(Offset = "0x68")]
	private float m_CurrentDistanceSqr;

	[Token(Token = "0x40020DD")]
	[FieldOffset(Offset = "0x70")]
	private Renderer m_Rend;

	[Token(Token = "0x40020DE")]
	[FieldOffset(Offset = "0x78")]
	private MaterialPropertyBlock m_PropertyBlock;

	[Token(Token = "0x40020DF")]
	[FieldOffset(Offset = "0x80")]
	private Color m_CurrentColor;

	[Token(Token = "0x40020E0")]
	[FieldOffset(Offset = "0x90")]
	private UniStormWeatherSystem m_UniStorm;

	[Token(Token = "0x40020E1")]
	[FieldOffset(Offset = "0x98")]
	private float m_TODMultiplier;

	[Token(Token = "0x40020E2")]
	[FieldOffset(Offset = "0x9C")]
	private float m_LightDriverMultiplier;

	[Token(Token = "0x40020E3")]
	[FieldOffset(Offset = "0xA0")]
	private float m_Angle;

	[Token(Token = "0x40020E4")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 m_Heading;

	[Token(Token = "0x40020E5")]
	[FieldOffset(Offset = "0xB0")]
	private float m_AngleCos;

	[Token(Token = "0x40020E6")]
	[FieldOffset(Offset = "0xB4")]
	private float m_DistanceMultiplier;

	[Token(Token = "0x40020E7")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_UseExternalDistanceMultiplier;

	[Token(Token = "0x40020E8")]
	[FieldOffset(Offset = "0xC0")]
	private Transform m_CachedTransform;

	[Token(Token = "0x40020E9")]
	[FieldOffset(Offset = "0xC8")]
	private Transform m_CachedCameraTransform;

	[Token(Token = "0x40020EA")]
	private static readonly int s_SoftEdgeFactorPropertyID;

	[Token(Token = "0x40020EB")]
	private static readonly int s_TintColorPropertyID;

	[Token(Token = "0x6001D0F")]
	[Address(RVA = "0x793430", Offset = "0x792230", Length = "0x28E")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D10")]
	[Address(RVA = "0x7936C0", Offset = "0x7924C0", Length = "0x248")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D11")]
	[Address(RVA = "0x793910", Offset = "0x792710", Length = "0x886")]
	private void UpdateAngleAndPosition()
	{
	}

	[Token(Token = "0x6001D12")]
	[Address(RVA = "0x7941A0", Offset = "0x792FA0", Length = "0x1E0")]
	private void UpdateTOD()
	{
	}

	[Token(Token = "0x6001D13")]
	[Address(RVA = "0x794390", Offset = "0x793190", Length = "0x139")]
	private void UpdateDrive()
	{
	}

	[Token(Token = "0x6001D14")]
	[Address(RVA = "0x7944D0", Offset = "0x7932D0", Length = "0x4C9")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x6001D15")]
	[Address(RVA = "0x7949A0", Offset = "0x7937A0", Length = "0x32")]
	private Vector3 Heading3D(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001D16")]
	[Address(RVA = "0x7949E0", Offset = "0x7937E0", Length = "0x8F")]
	public HighlightFog()
	{
	}
}
