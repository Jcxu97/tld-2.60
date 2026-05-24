using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[Token(Token = "0x2000757")]
public class HeightFogManager : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4004E57")]
	[FieldOffset(Offset = "0x20")]
	private MeshRenderer m_Renderer;

	[SerializeField]
	[Token(Token = "0x4004E58")]
	[FieldOffset(Offset = "0x28")]
	private Material m_NoNoiseMaterial;

	[SerializeField]
	[Token(Token = "0x4004E59")]
	[FieldOffset(Offset = "0x30")]
	private Material m_WithNoiseMaterial;

	[Token(Token = "0x4004E5A")]
	[FieldOffset(Offset = "0x38")]
	private HeightFogVolume m_GlobalVolume;

	[Token(Token = "0x4004E5B")]
	[FieldOffset(Offset = "0x40")]
	private List<HeightFogVolume> m_ActiveVolumes;

	[Token(Token = "0x4004E5C")]
	[FieldOffset(Offset = "0x48")]
	private HeightFogSettings m_CurrentSettings;

	[Token(Token = "0x4004E5D")]
	[FieldOffset(Offset = "0x98")]
	private MaterialPropertyBlock m_PropertyBlock;

	[Token(Token = "0x4004E5E")]
	private static readonly int s_FogColorID;

	[Token(Token = "0x4004E5F")]
	private static readonly int s_FogDensityID;

	[Token(Token = "0x4004E60")]
	private static readonly int s_FogPowerID;

	[Token(Token = "0x4004E61")]
	private static readonly int s_FogDistanceStartID;

	[Token(Token = "0x4004E62")]
	private static readonly int s_FogDistanceEndID;

	[Token(Token = "0x4004E63")]
	private static readonly int s_FogDistanceFalloffID;

	[Token(Token = "0x4004E64")]
	private static readonly int s_FogHeightStartID;

	[Token(Token = "0x4004E65")]
	private static readonly int s_FogHeightEndID;

	[Token(Token = "0x4004E66")]
	private static readonly int s_FogHeightFalloffID;

	[Token(Token = "0x4004E67")]
	private static readonly int s_NoiseStrengthID;

	[Token(Token = "0x4004E68")]
	private static readonly int s_NoiseScaleID;

	[Token(Token = "0x4004E69")]
	private static readonly int s_NoiseSpeedID;

	[Token(Token = "0x600438B")]
	[Address(RVA = "0xC59320", Offset = "0xC58120", Length = "0x1F")]
	public void OnQualityChange(QualityPostFx quality)
	{
	}

	[Token(Token = "0x600438C")]
	[Address(RVA = "0x509400", Offset = "0x508200", Length = "0x52")]
	public void SetGlobalVolume(HeightFogVolume volume)
	{
	}

	[Token(Token = "0x600438D")]
	[Address(RVA = "0xC59340", Offset = "0xC58140", Length = "0x137")]
	public void EnterVolume(HeightFogVolume volume)
	{
	}

	[Token(Token = "0x600438E")]
	[Address(RVA = "0xC59480", Offset = "0xC58280", Length = "0x162")]
	public void ExitVolume(HeightFogVolume volume)
	{
	}

	[Token(Token = "0x600438F")]
	[Address(RVA = "0xC595F0", Offset = "0xC583F0", Length = "0x18F")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004390")]
	[Address(RVA = "0xC59780", Offset = "0xC58580", Length = "0x20")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004391")]
	[Address(RVA = "0xC597B0", Offset = "0xC585B0", Length = "0x20")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004392")]
	[Address(RVA = "0xC597E0", Offset = "0xC585E0", Length = "0x939")]
	public void Update()
	{
	}

	[Token(Token = "0x6004393")]
	[Address(RVA = "0xC5A120", Offset = "0xC58F20", Length = "0xB3F")]
	private void ApplySettings(HeightFogSettings settings)
	{
	}

	[Token(Token = "0x6004394")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HeightFogManager()
	{
	}
}
