using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "The Long Dark/Weather State/ Create a single TOD state data")]
[Token(Token = "0x200031D")]
public class TODStateData : ScriptableObject
{
	[Token(Token = "0x4001B6A")]
	[FieldOffset(Offset = "0x18")]
	public SpecialTODState m_SpecialTODState;

	[Token(Token = "0x4001B6B")]
	[FieldOffset(Offset = "0x1C")]
	public Color m_AmbientLight;

	[Token(Token = "0x4001B6C")]
	[FieldOffset(Offset = "0x2C")]
	public Color m_SunLight;

	[Token(Token = "0x4001B6D")]
	[FieldOffset(Offset = "0x3C")]
	public Color m_SunLightInterior;

	[Token(Token = "0x4001B6E")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_UseSilhouetteFog;

	[Token(Token = "0x4001B6F")]
	[FieldOffset(Offset = "0x50")]
	public float m_SilhouetteFogIntensity;

	[Token(Token = "0x4001B70")]
	[FieldOffset(Offset = "0x58")]
	public Gradient m_SilhouetteFogColor;

	[Token(Token = "0x4001B71")]
	[FieldOffset(Offset = "0x60")]
	public float m_StartSilhouetteFog;

	[Token(Token = "0x4001B72")]
	[FieldOffset(Offset = "0x64")]
	public float m_EndSilhouetteFog;

	[Token(Token = "0x4001B73")]
	[FieldOffset(Offset = "0x68")]
	public Color m_FogColor;

	[Token(Token = "0x4001B74")]
	[FieldOffset(Offset = "0x78")]
	public Color m_SkyFogColor;

	[Token(Token = "0x4001B75")]
	[FieldOffset(Offset = "0x88")]
	public Color m_SkyGlowColor;

	[Token(Token = "0x4001B76")]
	[FieldOffset(Offset = "0x98")]
	public Color m_HorizonCloudsColor1;

	[Token(Token = "0x4001B77")]
	[FieldOffset(Offset = "0xA8")]
	public Color m_HorizonCloudsColor2;

	[Token(Token = "0x4001B78")]
	[FieldOffset(Offset = "0xB8")]
	public Color m_HorizonCloudsColor3;

	[Token(Token = "0x4001B79")]
	[FieldOffset(Offset = "0xC8")]
	public Color m_HorizonGradColor;

	[Token(Token = "0x4001B7A")]
	[FieldOffset(Offset = "0xD8")]
	public Color m_GodrayColor;

	[Token(Token = "0x4001B7B")]
	[FieldOffset(Offset = "0xE8")]
	public Color m_TerrainFresnelColor;

	[Token(Token = "0x4001B7C")]
	[FieldOffset(Offset = "0xF8")]
	public float m_SunLightIntensity;

	[Token(Token = "0x4001B7D")]
	[FieldOffset(Offset = "0xFC")]
	public float m_SunLightIntensityInterior;

	[Token(Token = "0x4001B7E")]
	[FieldOffset(Offset = "0x100")]
	public float m_MoonLightIntensity;

	[Token(Token = "0x4001B7F")]
	[FieldOffset(Offset = "0x104")]
	public float m_MoonLightIntensityInterior;

	[Token(Token = "0x4001B80")]
	[FieldOffset(Offset = "0x108")]
	public float m_FogDensity;

	[Token(Token = "0x4001B81")]
	[FieldOffset(Offset = "0x10C")]
	public float m_FogDirectionalTint;

	[Token(Token = "0x4001B82")]
	[FieldOffset(Offset = "0x110")]
	public float m_MoonAlpha;

	[Token(Token = "0x4001B83")]
	[FieldOffset(Offset = "0x114")]
	public float m_StarsAlpha;

	[Token(Token = "0x4001B84")]
	[FieldOffset(Offset = "0x118")]
	public float m_SkyboxAtmosphere;

	[Token(Token = "0x4001B85")]
	[FieldOffset(Offset = "0x11C")]
	public float m_SkyboxExposure;

	[Token(Token = "0x4001B86")]
	[FieldOffset(Offset = "0x120")]
	public float m_SkyboxSunDiffusion;

	[Token(Token = "0x4001B87")]
	[FieldOffset(Offset = "0x124")]
	public Vector4 m_CloudAlphas;

	[Token(Token = "0x4001B88")]
	[FieldOffset(Offset = "0x134")]
	public float m_SkyFogBias;

	[Token(Token = "0x4001B89")]
	[FieldOffset(Offset = "0x138")]
	public float m_SnowPatchBlendMax;

	[Token(Token = "0x4001B8A")]
	[FieldOffset(Offset = "0x140")]
	public Texture2D m_LUT;

	[Token(Token = "0x4001B8B")]
	[FieldOffset(Offset = "0x148")]
	public ColorGradingSettings m_ColorGradingSettings;

	[Token(Token = "0x4001B8C")]
	[FieldOffset(Offset = "0x150")]
	public float m_LightmapIntensity;

	[Token(Token = "0x4001B8D")]
	[FieldOffset(Offset = "0x154")]
	public Color m_SnowColor;

	[Token(Token = "0x4001B8E")]
	[FieldOffset(Offset = "0x164")]
	public Color m_BlowingSnowColor;

	[Token(Token = "0x4001B8F")]
	[FieldOffset(Offset = "0x174")]
	public Color m_ShadowColor;

	[Token(Token = "0x4001B90")]
	[FieldOffset(Offset = "0x184")]
	public float m_BloomIntensity;

	[Token(Token = "0x4001B91")]
	[FieldOffset(Offset = "0x188")]
	public float m_BloomThreshold;

	[Token(Token = "0x4001B92")]
	[FieldOffset(Offset = "0x18C")]
	public float m_BloomSampleDistance;

	[Token(Token = "0x4001B93")]
	[FieldOffset(Offset = "0x190")]
	public float m_BloomSoftKnee;

	[Token(Token = "0x4001B94")]
	[FieldOffset(Offset = "0x194")]
	public float m_ContrastEnhanceIntensity;

	[Token(Token = "0x4001B95")]
	[FieldOffset(Offset = "0x198")]
	public float m_ContrastEnhanceBlurSpread;

	[Token(Token = "0x4001B96")]
	[FieldOffset(Offset = "0x19C")]
	public float m_ImageSaturation;

	[Token(Token = "0x4001B97")]
	[FieldOffset(Offset = "0x1A0")]
	public float m_VignettingIntensity;

	[Token(Token = "0x4001B98")]
	[FieldOffset(Offset = "0x1A4")]
	public float m_VignettingChromaticAberration;

	[Token(Token = "0x6001964")]
	[Address(RVA = "0x733480", Offset = "0x732280", Length = "0x1E54")]
	public void SetBlended(TODStateData a, TODStateData b, float blend, float blendBiased, int nightStates)
	{
	}

	[Token(Token = "0x6001965")]
	[Address(RVA = "0x7352E0", Offset = "0x7340E0", Length = "0x1D")]
	public void SetIndoors()
	{
	}

	[Token(Token = "0x6001966")]
	[Address(RVA = "0x735300", Offset = "0x734100", Length = "0xDB")]
	public TODStateData()
	{
	}
}
