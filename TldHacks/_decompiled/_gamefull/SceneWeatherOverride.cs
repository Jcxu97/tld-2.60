using System;
using Cpp2ILInjected;
using UnityEngine;

[Obsolete("SceneWeatherOverride components have been replaced with SceneWeatherOverrideData scriptable objects")]
[Token(Token = "0x200030D")]
public class SceneWeatherOverride : MonoBehaviour
{
	[Token(Token = "0x4001AA9")]
	[FieldOffset(Offset = "0x20")]
	public float m_IndoorTemperatureCelsius;

	[Token(Token = "0x4001AAA")]
	[FieldOffset(Offset = "0x24")]
	public float m_HighTempMinCelsius;

	[Token(Token = "0x4001AAB")]
	[FieldOffset(Offset = "0x28")]
	public float m_HighTempMaxCelsius;

	[Token(Token = "0x4001AAC")]
	[FieldOffset(Offset = "0x2C")]
	public float m_LowTempMinCelsius;

	[Token(Token = "0x4001AAD")]
	[FieldOffset(Offset = "0x30")]
	public float m_LowTempMaxCelsius;

	[Token(Token = "0x4001AAE")]
	[FieldOffset(Offset = "0x34")]
	public float m_BlizzardDegreesDrop;

	[Token(Token = "0x4001AAF")]
	[FieldOffset(Offset = "0x38")]
	public float m_BlizzardDegreesChangePerSecond;

	[Token(Token = "0x4001AB0")]
	[FieldOffset(Offset = "0x3C")]
	public int m_HourWarmingBegins;

	[Token(Token = "0x4001AB1")]
	[FieldOffset(Offset = "0x40")]
	public int m_HourCoolingBegins;

	[Token(Token = "0x4001AB2")]
	[FieldOffset(Offset = "0x44")]
	public int m_AuroraEarlyWindowProbability;

	[Token(Token = "0x4001AB3")]
	[FieldOffset(Offset = "0x48")]
	public int m_AuroraLateWindowProbability;

	[Token(Token = "0x4001AB4")]
	[FieldOffset(Offset = "0x4C")]
	public float m_DegreesPerSecondChangeLow;

	[Token(Token = "0x4001AB5")]
	[FieldOffset(Offset = "0x50")]
	public float m_DegreesPerSecondChangeMedium;

	[Token(Token = "0x4001AB6")]
	[FieldOffset(Offset = "0x54")]
	public float m_DegreesPerSecondChangeHigh;

	[Token(Token = "0x4001AB7")]
	[FieldOffset(Offset = "0x58")]
	public float m_TimeToDisplayTempWhenChanged;

	[Token(Token = "0x4001AB8")]
	[FieldOffset(Offset = "0x5C")]
	public float m_MinWindSpeedForBlowingSnow;

	[Token(Token = "0x4001AB9")]
	[FieldOffset(Offset = "0x60")]
	public float m_BlowingSnowTransitionSeconds;

	[Token(Token = "0x4001ABA")]
	[FieldOffset(Offset = "0x64")]
	public float m_MinimumFogDensityScale;

	[Token(Token = "0x4001ABB")]
	[FieldOffset(Offset = "0x68")]
	public Vector4 m_SkyboxHorizonAdjust;

	[Token(Token = "0x4001ABC")]
	[FieldOffset(Offset = "0x78")]
	public WeatherSetData[] m_WeatherSetOverrides;

	[Token(Token = "0x4001ABD")]
	[FieldOffset(Offset = "0x80")]
	public float m_OcclusionTestRange;

	[Token(Token = "0x4001ABE")]
	[FieldOffset(Offset = "0x84")]
	public float m_OcclusionTestFOV;

	[Token(Token = "0x4001ABF")]
	[FieldOffset(Offset = "0x88")]
	public float m_OcclusionReduceWindchillPercent;

	[Token(Token = "0x4001AC0")]
	[FieldOffset(Offset = "0x8C")]
	public AudioOcclusionLevel m_OcclusionAudioLevel;

	[Token(Token = "0x4001AC1")]
	[FieldOffset(Offset = "0x90")]
	public bool m_NeverCalmWind;

	[Token(Token = "0x4001AC2")]
	[FieldOffset(Offset = "0x94")]
	public float m_HoursBetweenWindChangeMin;

	[Token(Token = "0x4001AC3")]
	[FieldOffset(Offset = "0x98")]
	public float m_HoursBetweenWindChangeMax;

	[Token(Token = "0x4001AC4")]
	[FieldOffset(Offset = "0x9C")]
	public float m_SlightlyWindyMPHThreshold;

	[Token(Token = "0x4001AC5")]
	[FieldOffset(Offset = "0xA0")]
	public float m_WindyMPHThreshold;

	[Token(Token = "0x4001AC6")]
	[FieldOffset(Offset = "0xA4")]
	public float m_VeryWindyMPHThreshold;

	[Token(Token = "0x4001AC7")]
	[FieldOffset(Offset = "0xA8")]
	public float m_MaxWindMPH;

	[Token(Token = "0x4001AC8")]
	[FieldOffset(Offset = "0xAC")]
	public float m_MinimumBlizzardWindSpeed;

	[Token(Token = "0x60018E7")]
	[Address(RVA = "0x6F8940", Offset = "0x6F7740", Length = "0x9E")]
	private void Awake()
	{
	}

	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x6F89E0", Offset = "0x6F77E0", Length = "0x17C")]
	public void DoWeatherOverride()
	{
	}

	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x6F8B60", Offset = "0x6F7960", Length = "0x4A")]
	public SceneWeatherOverride()
	{
	}
}
