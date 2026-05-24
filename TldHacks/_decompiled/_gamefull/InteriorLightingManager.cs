using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x20003BC")]
public class InteriorLightingManager : MonoBehaviour
{
	[Tooltip("Force weather conditions to always use a minimum and maximum value of 1, instead of what's defined in the curves.")]
	[Token(Token = "0x4002156")]
	[FieldOffset(Offset = "0x20")]
	public bool m_ForceClearWeather;

	[Tooltip("How much to brighten up lights during clear weather at noon.")]
	[Range(1f, 5f)]
	[Token(Token = "0x4002157")]
	[FieldOffset(Offset = "0x24")]
	public float m_MiddayMultiplier;

	[Tooltip("How much to brighten up ambient lighting during clear weather at noon.")]
	[Range(1f, 5f)]
	[Token(Token = "0x4002158")]
	[FieldOffset(Offset = "0x28")]
	public float m_MiddayAmbientMultiplier;

	[Tooltip("Additional brightness to apply to any sandbox interior.")]
	[Range(1f, 5f)]
	[Token(Token = "0x4002159")]
	[FieldOffset(Offset = "0x2C")]
	public float m_SandboxAmbientMultiplier;

	[Tooltip("The gameobject containing all LightGroups, affected by wind and weather.")]
	[Token(Token = "0x400215A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_LightGroupParent;

	[Token(Token = "0x400215B")]
	[FieldOffset(Offset = "0x38")]
	private List<InteriorLightingGroup> m_LightGroupList;

	[Tooltip("The gameobject containing loose lights that don't belong to any LightGroups. These are affected only by time of day.")]
	[Token(Token = "0x400215C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_LooseLightParent;

	[Token(Token = "0x400215D")]
	[FieldOffset(Offset = "0x48")]
	private List<Light> m_LooseLightList;

	[Token(Token = "0x400215E")]
	[FieldOffset(Offset = "0x50")]
	private List<float> m_LooseLightsOriginal;

	[Tooltip("The gameobject containing loose lights that don't belong to any LightGroups. These are the mid day lights.")]
	[Token(Token = "0x400215F")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_LooseLightMiddayParent;

	[Token(Token = "0x4002160")]
	[FieldOffset(Offset = "0x60")]
	private List<Light> m_LooseLightsMiddayList;

	[Token(Token = "0x4002161")]
	[FieldOffset(Offset = "0x68")]
	private List<float> m_LooseLightsMiddayOriginal;

	[Tooltip("The gameobject containing daytime FX.")]
	[Token(Token = "0x4002162")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_FxParent;

	[Token(Token = "0x4002163")]
	[FieldOffset(Offset = "0x78")]
	private List<ParticleSystem> m_ParticleList;

	[Token(Token = "0x4002164")]
	[FieldOffset(Offset = "0x80")]
	private List<float> m_FXOriginalRate;

	[Tooltip("The gameobject containing light shafts.")]
	[Token(Token = "0x4002165")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_LightShaftParent;

	[Token(Token = "0x4002166")]
	[FieldOffset(Offset = "0x90")]
	private List<LightShaftGimble> m_LightShaftGimbleList;

	[Token(Token = "0x4002167")]
	[FieldOffset(Offset = "0x98")]
	private List<LightShaftTod> m_LightShaftTodList;

	[Tooltip("Autogenerate random weather curves on scene load based on the intensity Min / Max values. Otherwise use user defined values.")]
	[Token(Token = "0x4002168")]
	[FieldOffset(Offset = "0xA0")]
	public bool m_AutoGenerateCurves;

	[Tooltip("The number of control points to use when generating the noise curve.")]
	[Token(Token = "0x4002169")]
	[FieldOffset(Offset = "0xA4")]
	public int m_CurveControlPoints;

	[Token(Token = "0x400216A")]
	[FieldOffset(Offset = "0xA8")]
	public ScaledCurve m_ClearWeatherCurve;

	[Token(Token = "0x400216B")]
	[FieldOffset(Offset = "0xB0")]
	public ScaledCurve m_PartlyCloudyWeatherCurve;

	[Token(Token = "0x400216C")]
	[FieldOffset(Offset = "0xB8")]
	public ScaledCurve m_CloudyWeatherCurve;

	[Token(Token = "0x400216D")]
	[FieldOffset(Offset = "0xC0")]
	public ScaledCurve m_LightSnowWeatherCurve;

	[Token(Token = "0x400216E")]
	[FieldOffset(Offset = "0xC8")]
	public ScaledCurve m_HeavySnowWeatherCurve;

	[Token(Token = "0x400216F")]
	[FieldOffset(Offset = "0xD0")]
	public ScaledCurve m_LightFogWeatherCurve;

	[Token(Token = "0x4002170")]
	[FieldOffset(Offset = "0xD8")]
	public ScaledCurve m_DenseFogWeatherCurve;

	[Token(Token = "0x4002171")]
	[FieldOffset(Offset = "0xE0")]
	public ScaledCurve m_BlizzardWeatherCurve;

	[Token(Token = "0x4002172")]
	[FieldOffset(Offset = "0xE8")]
	public ScaledCurve m_AuroraCurve;

	[Token(Token = "0x4002173")]
	[FieldOffset(Offset = "0xF0")]
	public MinMax m_ClearWeatherIntensity;

	[Token(Token = "0x4002174")]
	[FieldOffset(Offset = "0xF8")]
	public MinMax m_PartlyCloudyWeatherIntensity;

	[Token(Token = "0x4002175")]
	[FieldOffset(Offset = "0x100")]
	public MinMax m_CloudyWeatherIntensity;

	[Token(Token = "0x4002176")]
	[FieldOffset(Offset = "0x108")]
	public MinMax m_LightSnowWeatherIntensity;

	[Token(Token = "0x4002177")]
	[FieldOffset(Offset = "0x110")]
	public MinMax m_HeavySnowWeatherIntensity;

	[Token(Token = "0x4002178")]
	[FieldOffset(Offset = "0x118")]
	public MinMax m_LightFogWeatherIntensity;

	[Token(Token = "0x4002179")]
	[FieldOffset(Offset = "0x120")]
	public MinMax m_DenseFogWeatherIntensity;

	[Token(Token = "0x400217A")]
	[FieldOffset(Offset = "0x128")]
	public MinMax m_BlizzardWeatherIntensity;

	[Token(Token = "0x400217B")]
	[FieldOffset(Offset = "0x130")]
	public MinMax m_AuroraIntensity;

	[Tooltip("The random rate at which one intensity changes into the next one. Wind speed makes it cycle faster.")]
	[Token(Token = "0x400217C")]
	[FieldOffset(Offset = "0x138")]
	public MinMax m_CycleRate;

	[Tooltip("The rate at which intensity values cycle between groups. 0 = All groups cycle uniformly, 1 = one control point delay between each group, etc. Wind speed makes it cycle faster.")]
	[Token(Token = "0x400217D")]
	[FieldOffset(Offset = "0x140")]
	public MinMax m_GroupCycleRate;

	[Tooltip("The minimum and maximum effects of the wind on the cycle rates. 1 or greater.")]
	[Token(Token = "0x400217E")]
	[FieldOffset(Offset = "0x148")]
	public MinMax m_WindRateMultiplier;

	[Tooltip("The minimum and maximum wind speeds in the game.")]
	[Token(Token = "0x400217F")]
	[FieldOffset(Offset = "0x150")]
	public MinMax m_NormalizedWindSpeed;

	[Header("Adjustments")]
	[Token(Token = "0x4002180")]
	[FieldOffset(Offset = "0x158")]
	public float m_AuroraRed;

	[Token(Token = "0x4002181")]
	[FieldOffset(Offset = "0x15C")]
	public float m_AuroraGreen;

	[Token(Token = "0x4002182")]
	[FieldOffset(Offset = "0x160")]
	public float m_AuroraBlue;

	[Range(0f, 1f)]
	[Token(Token = "0x4002183")]
	[FieldOffset(Offset = "0x164")]
	public float m_AuroraColorization;

	[Token(Token = "0x4002184")]
	[FieldOffset(Offset = "0x168")]
	private float m_RandomRate;

	[Token(Token = "0x4002185")]
	[FieldOffset(Offset = "0x16C")]
	private float m_KeyStep;

	[Token(Token = "0x4002186")]
	[FieldOffset(Offset = "0x170")]
	private float m_ScrubTimer;

	[Token(Token = "0x4002187")]
	[FieldOffset(Offset = "0x174")]
	private float m_CurWeatherVal;

	[Token(Token = "0x4002188")]
	[FieldOffset(Offset = "0x178")]
	private float m_LitGrpIntensity;

	[Token(Token = "0x4002189")]
	[FieldOffset(Offset = "0x17C")]
	private float m_TodIntensitySun;

	[Token(Token = "0x400218A")]
	[FieldOffset(Offset = "0x180")]
	private float m_TodIntensityCalc;

	[Token(Token = "0x400218B")]
	[FieldOffset(Offset = "0x184")]
	private float m_CurMiddayVal;

	[Token(Token = "0x400218C")]
	[FieldOffset(Offset = "0x188")]
	private float m_CurMiddayAmb;

	[Token(Token = "0x400218D")]
	[FieldOffset(Offset = "0x18C")]
	private float m_AuroraFade;

	[Token(Token = "0x400218E")]
	[FieldOffset(Offset = "0x190")]
	private Color m_SunColour;

	[Token(Token = "0x400218F")]
	[FieldOffset(Offset = "0x1A0")]
	private float m_SunBright;

	[Token(Token = "0x4002190")]
	[FieldOffset(Offset = "0x1A8")]
	private TodAmbientLight m_AmbientLight;

	[Token(Token = "0x4002191")]
	[FieldOffset(Offset = "0x1B0")]
	private WeatherStage m_WeatherCur;

	[Token(Token = "0x4002192")]
	[FieldOffset(Offset = "0x1B4")]
	private WeatherStage m_WeatherPrv;

	[Token(Token = "0x4002193")]
	[FieldOffset(Offset = "0x1B8")]
	private float m_WeatherBlend;

	[Token(Token = "0x4002194")]
	[FieldOffset(Offset = "0x1BC")]
	private TODBlendState curTodBS;

	[Token(Token = "0x4002195")]
	[FieldOffset(Offset = "0x1C0")]
	private float curTodPercent;

	[Token(Token = "0x4002196")]
	[FieldOffset(Offset = "0x1C4")]
	private bool m_Initialized;

	[Token(Token = "0x6001D51")]
	[Address(RVA = "0x79B0A0", Offset = "0x799EA0", Length = "0x21E")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6001D52")]
	[Address(RVA = "0x79B2C0", Offset = "0x79A0C0", Length = "0x7F2")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D53")]
	[Address(RVA = "0x79BAC0", Offset = "0x79A8C0", Length = "0x9A4")]
	private void UpdateLights(float scrubTime, float todSun, float todCalc, float auroraIntensity)
	{
	}

	[Token(Token = "0x6001D54")]
	[Address(RVA = "0x79C470", Offset = "0x79B270", Length = "0xC3")]
	private Color GetAuroraColours()
	{
		return default(Color);
	}

	[Token(Token = "0x6001D55")]
	[Address(RVA = "0x79C540", Offset = "0x79B340", Length = "0x4F9")]
	private void UpdateParticles(float timeOfDayIntensity)
	{
	}

	[Token(Token = "0x6001D56")]
	[Address(RVA = "0x79CA40", Offset = "0x79B840", Length = "0x1EB")]
	private void UpdateLightShaft(float timeOfDayIntensity, bool followTod)
	{
	}

	[Token(Token = "0x6001D57")]
	[Address(RVA = "0x79CC30", Offset = "0x79BA30", Length = "0x222")]
	private void SetEmissionRate(ParticleSystem ps, float er)
	{
	}

	[Token(Token = "0x6001D58")]
	[Address(RVA = "0x79CE60", Offset = "0x79BC60", Length = "0x935")]
	private void InitializeCurves()
	{
	}

	[Token(Token = "0x6001D59")]
	[Address(RVA = "0x79D7A0", Offset = "0x79C5A0", Length = "0x160")]
	private float EvaluateCurve(WeatherStage curWeather, float curTime)
	{
		return 0f;
	}

	[Token(Token = "0x6001D5A")]
	[Address(RVA = "0x79D910", Offset = "0x79C710", Length = "0xD6")]
	private float GetBlendedCurve(WeatherStage weather1, WeatherStage weather2, float curTime, float weatherBlend)
	{
		return 0f;
	}

	[Token(Token = "0x6001D5B")]
	[Address(RVA = "0x79D9F0", Offset = "0x79C7F0", Length = "0xBE")]
	private float GetWindMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x6001D5C")]
	[Address(RVA = "0x79DAB0", Offset = "0x79C8B0", Length = "0xBE")]
	private float GetGroupSpreadOffset()
	{
		return 0f;
	}

	[Token(Token = "0x6001D5D")]
	[Address(RVA = "0x79DB70", Offset = "0x79C970", Length = "0x102")]
	private float GetTimeOfDayIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6001D5E")]
	[Address(RVA = "0x79DC80", Offset = "0x79CA80", Length = "0xB3")]
	private float MiddayIntensities()
	{
		return 0f;
	}

	[Token(Token = "0x6001D5F")]
	[Address(RVA = "0x79DD40", Offset = "0x79CB40", Length = "0x96")]
	private float GetSunlightIntensity(float sunlight, Color sunColor)
	{
		return 0f;
	}

	[Token(Token = "0x6001D60")]
	[Address(RVA = "0x79DDE0", Offset = "0x79CBE0", Length = "0x34C")]
	private void FindLightShaftControllers()
	{
	}

	[Token(Token = "0x6001D61")]
	[Address(RVA = "0x79E130", Offset = "0x79CF30", Length = "0x28B")]
	private void FindLightGroups()
	{
	}

	[Token(Token = "0x6001D62")]
	[Address(RVA = "0x79E3C0", Offset = "0x79D1C0", Length = "0x5DD")]
	private void FindLooseLights()
	{
	}

	[Token(Token = "0x6001D63")]
	[Address(RVA = "0x79E9A0", Offset = "0x79D7A0", Length = "0x20D")]
	private void FindParticleSystems()
	{
	}

	[Token(Token = "0x6001D64")]
	[Address(RVA = "0x79EBB0", Offset = "0x79D9B0", Length = "0x8CE")]
	private void GetStartingValues()
	{
	}

	[Token(Token = "0x6001D65")]
	[Address(RVA = "0x79F480", Offset = "0x79E280", Length = "0x75D")]
	private void FilterGroupedObjects()
	{
	}

	[Token(Token = "0x6001D66")]
	[Address(RVA = "0x79FBE0", Offset = "0x79E9E0", Length = "0x674")]
	public InteriorLightingManager()
	{
	}
}
