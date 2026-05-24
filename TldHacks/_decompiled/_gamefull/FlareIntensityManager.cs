using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000393")]
public class FlareIntensityManager : MonoBehaviour
{
	[Token(Token = "0x400200B")]
	private static readonly int s_TintColor;

	[SerializeField]
	[Token(Token = "0x400200C")]
	[FieldOffset(Offset = "0x20")]
	private float m_MinDist;

	[SerializeField]
	[Token(Token = "0x400200D")]
	[FieldOffset(Offset = "0x24")]
	private float m_MaxDist;

	[SerializeField]
	[Token(Token = "0x400200E")]
	[FieldOffset(Offset = "0x28")]
	private float m_MaxDelay;

	[Token(Token = "0x400200F")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_CamTransform;

	[Token(Token = "0x4002010")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<float> m_TimeDelays;

	[Token(Token = "0x4002011")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<float> m_PreviousIntensities;

	[Token(Token = "0x4002012")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<float> m_LastIntensitySentToWise;

	[Token(Token = "0x4002013")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<float> m_MaxIndoorLightIntensities;

	[Token(Token = "0x4002014")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<float> m_MaxOutdoorLightIntensities;

	[Token(Token = "0x4002015")]
	[FieldOffset(Offset = "0x60")]
	private readonly List<bool> m_ForceUpdates;

	[Token(Token = "0x4002016")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<bool> m_HasRadialGradiants;

	[Token(Token = "0x4002017")]
	[FieldOffset(Offset = "0x70")]
	private readonly List<FlareIntensity> m_Flares;

	[Token(Token = "0x4002018")]
	[FieldOffset(Offset = "0x78")]
	private readonly List<ParticleSystem> m_SmokeParticles_ParticleSystems;

	[Token(Token = "0x4002019")]
	[FieldOffset(Offset = "0x80")]
	private readonly List<ParticleSystem> m_CoreParticles_ParticleSystems;

	[Token(Token = "0x400201A")]
	[FieldOffset(Offset = "0x88")]
	private readonly List<ParticleSystem> m_SparkParticles_ParticleSystems;

	[Token(Token = "0x400201B")]
	[FieldOffset(Offset = "0x90")]
	private readonly List<LightRandomIntensity> m_IndoorLight_LightRandomIntensities;

	[Token(Token = "0x400201C")]
	[FieldOffset(Offset = "0x98")]
	private readonly List<LightRandomIntensity> m_OutdoorLight_LightRandomIntensities;

	[Token(Token = "0x400201D")]
	[FieldOffset(Offset = "0xA0")]
	private readonly List<GearItem> m_GearItems;

	[Token(Token = "0x400201E")]
	[FieldOffset(Offset = "0xA8")]
	private readonly List<MeshRenderer> m_RadialGradientMeshRenderers;

	[Token(Token = "0x6001C84")]
	[Address(RVA = "0x784300", Offset = "0x783100", Length = "0x80B")]
	private FlareIntensityManager()
	{
	}

	[Token(Token = "0x6001C85")]
	[Address(RVA = "0x784B10", Offset = "0x783910", Length = "0xAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C86")]
	[Address(RVA = "0x784BC0", Offset = "0x7839C0", Length = "0x1FF")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C87")]
	[Address(RVA = "0x784DC0", Offset = "0x783BC0", Length = "0x7B6")]
	public void UpdateIntensities(float deltaTime, bool isOutdoors, Vector3 camPos, float minDist, float maxDist, float maxDelay)
	{
	}

	[Token(Token = "0x6001C88")]
	[Address(RVA = "0x785580", Offset = "0x784380", Length = "0x4D1")]
	private void SetVisuals(int i, float intensity, FlareIntensity curFlare)
	{
	}

	[Token(Token = "0x6001C89")]
	[Address(RVA = "0x785A60", Offset = "0x784860", Length = "0x138")]
	private void SetEmissionRate(ParticleSystem ps, float newRate)
	{
	}

	[Token(Token = "0x6001C8A")]
	[Address(RVA = "0x785BA0", Offset = "0x7849A0", Length = "0x2DB")]
	private void MaybeUpdateIntensityRTPC(bool isOutdoors, int index)
	{
	}

	[Token(Token = "0x6001C8B")]
	[Address(RVA = "0x785E80", Offset = "0x784C80", Length = "0x984")]
	public void Register(FlareIntensity newFlare)
	{
	}

	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x786810", Offset = "0x785610", Length = "0x3C3")]
	public void UnRegister(FlareIntensity oldFlare)
	{
	}

	[Token(Token = "0x6001C8D")]
	[Address(RVA = "0x786BE0", Offset = "0x7859E0", Length = "0x23C")]
	public void ForceImmediateUpdate(FlareIntensity flare)
	{
	}
}
