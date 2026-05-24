using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/Scene Weather Override / Create a weather override for a scene")]
[Token(Token = "0x200030E")]
public class SceneWeatherOverrideData : ScriptableObject
{
	[Token(Token = "0x4001AC9")]
	[FieldOffset(Offset = "0x18")]
	public float m_IndoorTemperatureCelsius;

	[Token(Token = "0x4001ACA")]
	[FieldOffset(Offset = "0x1C")]
	public float m_HighTempMinCelsius;

	[Token(Token = "0x4001ACB")]
	[FieldOffset(Offset = "0x20")]
	public float m_HighTempMaxCelsius;

	[Token(Token = "0x4001ACC")]
	[FieldOffset(Offset = "0x24")]
	public float m_LowTempMinCelsius;

	[Token(Token = "0x4001ACD")]
	[FieldOffset(Offset = "0x28")]
	public float m_LowTempMaxCelsius;

	[Token(Token = "0x4001ACE")]
	[FieldOffset(Offset = "0x2C")]
	public float m_BlizzardDegreesDrop;

	[Token(Token = "0x4001ACF")]
	[FieldOffset(Offset = "0x30")]
	public float m_BlizzardDegreesChangePerSecond;

	[Token(Token = "0x4001AD0")]
	[FieldOffset(Offset = "0x34")]
	public int m_HourWarmingBegins;

	[Token(Token = "0x4001AD1")]
	[FieldOffset(Offset = "0x38")]
	public int m_HourCoolingBegins;

	[Token(Token = "0x4001AD2")]
	[FieldOffset(Offset = "0x3C")]
	public int m_AuroraEarlyWindowProbability;

	[Token(Token = "0x4001AD3")]
	[FieldOffset(Offset = "0x40")]
	public int m_AuroraLateWindowProbability;

	[Token(Token = "0x4001AD4")]
	[FieldOffset(Offset = "0x44")]
	public float m_DegreesPerSecondChangeLow;

	[Token(Token = "0x4001AD5")]
	[FieldOffset(Offset = "0x48")]
	public float m_DegreesPerSecondChangeMedium;

	[Token(Token = "0x4001AD6")]
	[FieldOffset(Offset = "0x4C")]
	public float m_DegreesPerSecondChangeHigh;

	[Token(Token = "0x4001AD7")]
	[FieldOffset(Offset = "0x50")]
	public float m_TimeToDisplayTempWhenChanged;

	[Token(Token = "0x4001AD8")]
	[FieldOffset(Offset = "0x54")]
	public float m_MinWindSpeedForBlowingSnow;

	[Token(Token = "0x4001AD9")]
	[FieldOffset(Offset = "0x58")]
	public float m_BlowingSnowTransitionSeconds;

	[Token(Token = "0x4001ADA")]
	[FieldOffset(Offset = "0x5C")]
	public float m_MinimumFogDensityScale;

	[Token(Token = "0x4001ADB")]
	[FieldOffset(Offset = "0x60")]
	public Vector4 m_SkyboxHorizonAdjust;

	[Token(Token = "0x4001ADC")]
	[FieldOffset(Offset = "0x70")]
	public WeatherSetData[] m_WeatherSetOverrides;

	[Token(Token = "0x4001ADD")]
	[FieldOffset(Offset = "0x78")]
	public float m_OcclusionTestRange;

	[Token(Token = "0x4001ADE")]
	[FieldOffset(Offset = "0x7C")]
	public float m_OcclusionTestFOV;

	[Token(Token = "0x4001ADF")]
	[FieldOffset(Offset = "0x80")]
	public float m_OcclusionReduceWindchillPercent;

	[Token(Token = "0x4001AE0")]
	[FieldOffset(Offset = "0x84")]
	public AudioOcclusionLevel m_OcclusionAudioLevel;

	[Token(Token = "0x4001AE1")]
	[FieldOffset(Offset = "0x88")]
	public bool m_NeverCalmWind;

	[Token(Token = "0x4001AE2")]
	[FieldOffset(Offset = "0x8C")]
	public float m_HoursBetweenWindChangeMin;

	[Token(Token = "0x4001AE3")]
	[FieldOffset(Offset = "0x90")]
	public float m_HoursBetweenWindChangeMax;

	[Token(Token = "0x4001AE4")]
	[FieldOffset(Offset = "0x94")]
	public float m_SlightlyWindyMPHThreshold;

	[Token(Token = "0x4001AE5")]
	[FieldOffset(Offset = "0x98")]
	public float m_WindyMPHThreshold;

	[Token(Token = "0x4001AE6")]
	[FieldOffset(Offset = "0x9C")]
	public float m_VeryWindyMPHThreshold;

	[Token(Token = "0x4001AE7")]
	[FieldOffset(Offset = "0xA0")]
	public float m_MaxWindMPH;

	[Token(Token = "0x4001AE8")]
	[FieldOffset(Offset = "0xA4")]
	public float m_MinimumBlizzardWindSpeed;

	[Token(Token = "0x4001AE9")]
	[FieldOffset(Offset = "0xA8")]
	public float m_SilhouetteFogDistanceMultiplier;

	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x6F8BB0", Offset = "0x6F79B0", Length = "0x2B8")]
	public void DoWeatherOverride()
	{
	}

	[Token(Token = "0x60018EB")]
	[Address(RVA = "0x6F8E70", Offset = "0x6F7C70", Length = "0x51")]
	public bool HasElectrostaticFogWeatherSet()
	{
		return false;
	}

	[Token(Token = "0x60018EC")]
	[Address(RVA = "0x6F8ED0", Offset = "0x6F7CD0", Length = "0x18")]
	public SceneWeatherOverrideData()
	{
	}
}
