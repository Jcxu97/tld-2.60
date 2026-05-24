using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003CB")]
public class LightShaftGimble : MonoBehaviour
{
	[Header("Time of day controls")]
	[Token(Token = "0x4002238")]
	[FieldOffset(Offset = "0x20")]
	public bool m_FollowTod;

	[Token(Token = "0x4002239")]
	[FieldOffset(Offset = "0x28")]
	public ScaledCurve m_Horizontal;

	[Token(Token = "0x400223A")]
	[FieldOffset(Offset = "0x30")]
	public ScaledCurve m_Vertical;

	[Token(Token = "0x400223B")]
	[FieldOffset(Offset = "0x38")]
	public ScaledCurve m_MaximumRayIntensity;

	[Token(Token = "0x400223C")]
	[FieldOffset(Offset = "0x40")]
	public ScaledCurve m_MaximumLightIntensity;

	[Header("Object links")]
	[Token(Token = "0x400223D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject[] m_LightShaft;

	[Token(Token = "0x400223E")]
	[FieldOffset(Offset = "0x50")]
	public Light m_Light;

	[Token(Token = "0x400223F")]
	[FieldOffset(Offset = "0x58")]
	public ParticleSystem m_Particles;

	[Header("Rendering options")]
	[Token(Token = "0x4002240")]
	[FieldOffset(Offset = "0x60")]
	public bool m_UseLightColour;

	[Token(Token = "0x4002241")]
	[FieldOffset(Offset = "0x61")]
	public bool m_UseRayIntensityOnly;

	[Token(Token = "0x4002242")]
	[FieldOffset(Offset = "0x62")]
	public bool m_FadeWithViewAngle;

	[Header("Weather options")]
	[Token(Token = "0x4002243")]
	[FieldOffset(Offset = "0x63")]
	public bool m_AffectedByClouds;

	[Token(Token = "0x4002244")]
	[FieldOffset(Offset = "0x64")]
	public bool m_AffectedByFog;

	[Token(Token = "0x4002245")]
	[FieldOffset(Offset = "0x68")]
	public MinMax m_FogRange;

	[Header("Gimble assembly")]
	[Token(Token = "0x4002246")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_HorizontalGimble;

	[Token(Token = "0x4002247")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_VerticalGimble;

	[Token(Token = "0x4002248")]
	[FieldOffset(Offset = "0x80")]
	private float m_ExternalIntensity;

	[Token(Token = "0x4002249")]
	[FieldOffset(Offset = "0x84")]
	private float m_TodIntensity;

	[Token(Token = "0x400224A")]
	[FieldOffset(Offset = "0x88")]
	private float m_WeatherIntensity;

	[Token(Token = "0x400224B")]
	[FieldOffset(Offset = "0x8C")]
	private float m_GlobalTod;

	[Token(Token = "0x400224C")]
	[FieldOffset(Offset = "0x90")]
	private float m_Dot;

	[Token(Token = "0x400224D")]
	[FieldOffset(Offset = "0x94")]
	private float m_LightStartIntensity;

	[Token(Token = "0x400224E")]
	[FieldOffset(Offset = "0x98")]
	private Renderer[] m_LightShaftRenderer;

	[Token(Token = "0x400224F")]
	[FieldOffset(Offset = "0xA0")]
	private Color m_ParticleStartColour;

	[Token(Token = "0x4002250")]
	[FieldOffset(Offset = "0xB0")]
	private ParticleSystem.MainModule m_ParticleMainModule;

	[Token(Token = "0x4002251")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_UseManagerTOD;

	[Token(Token = "0x4002252")]
	[FieldOffset(Offset = "0xC0")]
	private MaterialPropertyBlock m_MatProp;

	[Token(Token = "0x4002253")]
	private static readonly int m_shaderGain;

	[Token(Token = "0x4002254")]
	private static readonly int m_shaderColor;

	[Token(Token = "0x6001D9D")]
	[Address(RVA = "0x7A73C0", Offset = "0x7A61C0", Length = "0x628")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D9E")]
	[Address(RVA = "0x7A79F0", Offset = "0x7A67F0", Length = "0x10E")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D9F")]
	[Address(RVA = "0x7A7B00", Offset = "0x7A6900", Length = "0x5A")]
	public void ManualUpdate(float externalTod)
	{
	}

	[Token(Token = "0x6001DA0")]
	[Address(RVA = "0x7A7B60", Offset = "0x7A6960", Length = "0x135")]
	private void UpdateWeather()
	{
	}

	[Token(Token = "0x6001DA1")]
	[Address(RVA = "0x7A7CA0", Offset = "0x7A6AA0", Length = "0x1AB")]
	private void UpdateRotation(float tod)
	{
	}

	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0x7A7E50", Offset = "0x7A6C50", Length = "0x3B3")]
	private void UpdateMaterial(float tod)
	{
	}

	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0x7A8210", Offset = "0x7A7010", Length = "0x1D4")]
	private void UpdateLight(float tod)
	{
	}

	[Token(Token = "0x6001DA4")]
	[Address(RVA = "0x7A83F0", Offset = "0x7A71F0", Length = "0x294")]
	private void UpdateFX(float tod)
	{
	}

	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0x7A8690", Offset = "0x7A7490", Length = "0x19")]
	private float GetCombinedIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0x7A86B0", Offset = "0x7A74B0", Length = "0x9")]
	public void SetTimeOfDayIntensity(float todIntensity)
	{
	}

	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0x7A86C0", Offset = "0x7A74C0", Length = "0x9")]
	public void SetExternalIntensity(float newIntensity)
	{
	}

	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0x7A86D0", Offset = "0x7A74D0", Length = "0x7")]
	public void UseExternalTod(bool externalTod)
	{
	}

	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0x4D3E50", Offset = "0x4D2C50", Length = "0x4")]
	public void SetFollowTimeOfDay(bool followTod)
	{
	}

	[Token(Token = "0x6001DAA")]
	[Address(RVA = "0x7A86E0", Offset = "0x7A74E0", Length = "0x16C")]
	private float CalculateDot()
	{
		return 0f;
	}

	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0x7A8850", Offset = "0x7A7650", Length = "0x55")]
	public LightShaftGimble()
	{
	}
}
