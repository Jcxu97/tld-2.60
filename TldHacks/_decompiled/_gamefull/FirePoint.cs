using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x200038E")]
public class FirePoint : MonoBehaviour
{
	[Header("Particles")]
	[Tooltip("Smoothly transition from nothing to embers to a full-on inferno")]
	[Range(0f, 100f)]
	[Token(Token = "0x4001FC3")]
	[FieldOffset(Offset = "0x20")]
	public float m_Intensity;

	[Header("Lighting")]
	[Token(Token = "0x4001FC4")]
	[FieldOffset(Offset = "0x24")]
	public bool m_LightSelf;

	[Range(0f, 100f)]
	[Token(Token = "0x4001FC5")]
	[FieldOffset(Offset = "0x28")]
	public float m_LightRange;

	[Range(0f, 10f)]
	[Token(Token = "0x4001FC6")]
	[FieldOffset(Offset = "0x2C")]
	public float m_LightMinimum;

	[Range(0f, 10f)]
	[Token(Token = "0x4001FC7")]
	[FieldOffset(Offset = "0x30")]
	public float m_LightMaximum;

	[Range(0f, 1f)]
	[Token(Token = "0x4001FC8")]
	[FieldOffset(Offset = "0x34")]
	public float m_LightIntervalSeconds;

	[Header("FX objects")]
	[Token(Token = "0x4001FC9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_SmokeParticles;

	[Token(Token = "0x4001FCA")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_SparkParticles;

	[Token(Token = "0x4001FCB")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_SpriteParticles;

	[Token(Token = "0x4001FCC")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_Lights;

	[Token(Token = "0x4001FCD")]
	[FieldOffset(Offset = "0x58")]
	private List<LightRandomIntensity> m_ChildLightRandomIntensityList;

	[Token(Token = "0x4001FCE")]
	[FieldOffset(Offset = "0x60")]
	private List<Light> m_ChildLightList;

	[Token(Token = "0x4001FCF")]
	[FieldOffset(Offset = "0x68")]
	private ParticleSystem m_SpriteParticlesPS;

	[Token(Token = "0x6001C6C")]
	[Address(RVA = "0x7807F0", Offset = "0x77F5F0", Length = "0x716")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C6D")]
	[Address(RVA = "0x780F10", Offset = "0x77FD10", Length = "0xCC")]
	private void StartFire()
	{
	}

	[Token(Token = "0x6001C6E")]
	[Address(RVA = "0x780FE0", Offset = "0x77FDE0", Length = "0x17D")]
	private void SetEmissionRate(GameObject ps, float newRate)
	{
	}

	[Token(Token = "0x6001C6F")]
	[Address(RVA = "0x781160", Offset = "0x77FF60", Length = "0x107")]
	private void SetSize(GameObject ps, float newSize)
	{
	}

	[Token(Token = "0x6001C70")]
	[Address(RVA = "0x781270", Offset = "0x780070", Length = "0x429")]
	private void UpdateRatesAndSizes()
	{
	}

	[Token(Token = "0x6001C71")]
	[Address(RVA = "0x7816A0", Offset = "0x7804A0", Length = "0x6B")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C72")]
	[Address(RVA = "0x781710", Offset = "0x780510", Length = "0x18F")]
	public FirePoint()
	{
	}
}
