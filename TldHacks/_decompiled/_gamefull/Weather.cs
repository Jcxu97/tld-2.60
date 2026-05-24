using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000321")]
public class Weather : MonoBehaviour
{
	[Token(Token = "0x2000322")]
	private enum IndoorState
	{
		[Token(Token = "0x4001C0E")]
		NotSet = -1,
		[Token(Token = "0x4001C0F")]
		Outdoors,
		[Token(Token = "0x4001C10")]
		Indoors
	}

	[Token(Token = "0x2000323")]
	public delegate void EnvironemntChangedEvent(bool isIndoor);

	[Token(Token = "0x4001BA7")]
	[FieldOffset(Offset = "0x20")]
	public float m_IndoorTemperatureCelsius;

	[Token(Token = "0x4001BA8")]
	[FieldOffset(Offset = "0x24")]
	public float m_HighTempMinCelsius;

	[Token(Token = "0x4001BA9")]
	[FieldOffset(Offset = "0x28")]
	public float m_HighTempMaxCelsius;

	[Token(Token = "0x4001BAA")]
	[FieldOffset(Offset = "0x2C")]
	public float m_LowTempMinCelsius;

	[Token(Token = "0x4001BAB")]
	[FieldOffset(Offset = "0x30")]
	public float m_LowTempMaxCelsius;

	[Token(Token = "0x4001BAC")]
	[FieldOffset(Offset = "0x34")]
	public float m_BlizzardDegreesDrop;

	[Token(Token = "0x4001BAD")]
	[FieldOffset(Offset = "0x38")]
	public float m_BlizzardDegreesChangePerSecond;

	[Token(Token = "0x4001BAE")]
	[FieldOffset(Offset = "0x3C")]
	public int m_HourWarmingBegins;

	[Token(Token = "0x4001BAF")]
	[FieldOffset(Offset = "0x40")]
	public int m_HourCoolingBegins;

	[Token(Token = "0x4001BB0")]
	[FieldOffset(Offset = "0x44")]
	public int m_MaxAirTemperature;

	[Token(Token = "0x4001BB1")]
	[FieldOffset(Offset = "0x48")]
	public int m_AuroraActivationWindowStart;

	[Token(Token = "0x4001BB2")]
	[FieldOffset(Offset = "0x4C")]
	public int m_AuroraActivationWindowEnd;

	[Token(Token = "0x4001BB3")]
	[FieldOffset(Offset = "0x50")]
	public int m_AuroraEarlyWindowProbability;

	[Token(Token = "0x4001BB4")]
	[FieldOffset(Offset = "0x54")]
	public int m_AuroraLateWindowProbability;

	[Token(Token = "0x4001BB5")]
	[FieldOffset(Offset = "0x58")]
	public float m_DegreesPerSecondChangeLow;

	[Token(Token = "0x4001BB6")]
	[FieldOffset(Offset = "0x5C")]
	public float m_DegreesPerSecondChangeMedium;

	[Token(Token = "0x4001BB7")]
	[FieldOffset(Offset = "0x60")]
	public float m_DegreesPerSecondChangeHigh;

	[Token(Token = "0x4001BB8")]
	[FieldOffset(Offset = "0x64")]
	public float m_TimeToDisplayTempWhenChanged;

	[Token(Token = "0x4001BB9")]
	[FieldOffset(Offset = "0x68")]
	public float m_MinWindSpeedForBlowingSnow;

	[Token(Token = "0x4001BBA")]
	[FieldOffset(Offset = "0x6C")]
	public float m_BlowingSnowTransitionSeconds;

	[Token(Token = "0x4001BBB")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_FallingSnowPrefab;

	[Header("Blowing snow")]
	[Token(Token = "0x4001BBC")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_BlowingSnowPrefabLowQuality;

	[Token(Token = "0x4001BBD")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_BlowingSnowPrefabMediumQuality;

	[Token(Token = "0x4001BBE")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_BlowingSnowPrefabHighQuality;

	[Token(Token = "0x4001BBF")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_BlowingSnowPrefabUltraQuality;

	[Token(Token = "0x4001BC0")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_BlowingSnowPrefabXboxOneQuality;

	[Token(Token = "0x4001BC1")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_BlowingSnowPrefabPS4Quality;

	[Token(Token = "0x4001BC2")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_BlowingSnowPrefab;

	[Header("Electrostatic Fog Settings")]
	[Token(Token = "0x4001BC3")]
	[FieldOffset(Offset = "0xB0")]
	public int m_ChancesOfPickingElectrostaticFogInActivationWindow;

	[Token(Token = "0x4001BC4")]
	[FieldOffset(Offset = "0xB4")]
	public int m_ElectrostaticFogSelectionWindowStart;

	[Token(Token = "0x4001BC5")]
	[FieldOffset(Offset = "0xB8")]
	public int m_ElectrostaticFogSelectionWindowEnd;

	[Token(Token = "0x4001BC6")]
	[FieldOffset(Offset = "0xBC")]
	public int m_ElectrostaticFogActivationWindowStart;

	[Token(Token = "0x4001BC7")]
	[FieldOffset(Offset = "0xC0")]
	public int m_ElectrostaticFogActivationWindowEnd;

	[Header("Toxic fog spores")]
	[Token(Token = "0x4001BC8")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_ToxicFogSporeFxPrefab;

	[Token(Token = "0x4001BC9")]
	[FieldOffset(Offset = "0xD0")]
	public MinMax m_MinForceX;

	[Token(Token = "0x4001BCA")]
	[FieldOffset(Offset = "0xD8")]
	public MinMax m_MinForceY;

	[Token(Token = "0x4001BCB")]
	[FieldOffset(Offset = "0xE0")]
	public MinMax m_MinForceZ;

	[Token(Token = "0x4001BCC")]
	[FieldOffset(Offset = "0xE8")]
	public MinMax m_MaxForceX;

	[Token(Token = "0x4001BCD")]
	[FieldOffset(Offset = "0xF0")]
	public MinMax m_MaxForceY;

	[Token(Token = "0x4001BCE")]
	[FieldOffset(Offset = "0xF8")]
	public MinMax m_MaxForceZ;

	[Token(Token = "0x4001BCF")]
	[FieldOffset(Offset = "0x100")]
	public float m_SporeFxLowQuality;

	[Token(Token = "0x4001BD0")]
	[FieldOffset(Offset = "0x104")]
	public float m_SporeFxMediumQuality;

	[Token(Token = "0x4001BD1")]
	[FieldOffset(Offset = "0x108")]
	public float m_SporeFxHighQuality;

	[Token(Token = "0x4001BD2")]
	[FieldOffset(Offset = "0x10C")]
	public float m_SporeFxUltraQuality;

	[Token(Token = "0x4001BD3")]
	[FieldOffset(Offset = "0x110")]
	public float m_SporeFxXboxQuality;

	[Token(Token = "0x4001BD4")]
	[FieldOffset(Offset = "0x114")]
	public float m_SporeFxPs4Quality;

	[Token(Token = "0x4001BD5")]
	[FieldOffset(Offset = "0x118")]
	public float m_SporeFxSwitchQuality;

	[Token(Token = "0x4001BD6")]
	[FieldOffset(Offset = "0x11C")]
	private float m_SporeFxQuality;

	[Token(Token = "0x4001BD7")]
	[FieldOffset(Offset = "0x120")]
	private GameObject m_ToxicFogSporeFxGO;

	[Token(Token = "0x4001BD8")]
	[FieldOffset(Offset = "0x128")]
	private ParticleSystem m_ToxicFogSporeFxComponent;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001BD9")]
	[FieldOffset(Offset = "0x130")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4001BDA")]
	[FieldOffset(Offset = "0x138")]
	public float m_ClothingDamagePerHourInBlizzard;

	[Token(Token = "0x4001BDC")]
	[FieldOffset(Offset = "0x140")]
	public WeatherSetData[] m_DefaultWeatherSets;

	[HideInInspector]
	[Token(Token = "0x4001BDD")]
	[FieldOffset(Offset = "0x148")]
	public List<WeatherSetData> m_WeatherSetsForScene;

	[HideInInspector]
	[Token(Token = "0x4001BDE")]
	[FieldOffset(Offset = "0x150")]
	public FallingSnowPreset m_FallingSnowCurrentPreset;

	[HideInInspector]
	[Token(Token = "0x4001BDF")]
	[FieldOffset(Offset = "0x158")]
	public GameObject m_FallingSnow;

	[HideInInspector]
	[Token(Token = "0x4001BE0")]
	[FieldOffset(Offset = "0x160")]
	public GameObject m_BlowingSnow;

	[HideInInspector]
	[Token(Token = "0x4001BE1")]
	[FieldOffset(Offset = "0x168")]
	public float m_FallingSnowEnforceLifetimeLimit;

	[HideInInspector]
	[Token(Token = "0x4001BE2")]
	[FieldOffset(Offset = "0x170")]
	public ParticleSystem m_FallingSnowParticleSystem;

	[HideInInspector]
	[Token(Token = "0x4001BE3")]
	[FieldOffset(Offset = "0x178")]
	public ParticleSystemRenderer m_FallingSnowParticleSystemRenderer;

	[HideInInspector]
	[Token(Token = "0x4001BE4")]
	[FieldOffset(Offset = "0x180")]
	public ParticleSystem m_BlowingSnowParticleSystem;

	[Token(Token = "0x4001BE5")]
	[FieldOffset(Offset = "0x188")]
	public float m_TimeShelteredToDisplayMessage;

	[HideInInspector]
	[Token(Token = "0x4001BE6")]
	[FieldOffset(Offset = "0x18C")]
	public Vector4 m_SkyboxHorizonAdjust;

	[HideInInspector]
	[Token(Token = "0x4001BE7")]
	[FieldOffset(Offset = "0x19C")]
	public int m_MinAirTemperature;

	[HideInInspector]
	[Token(Token = "0x4001BE8")]
	[FieldOffset(Offset = "0x1A0")]
	public float m_SilhouetteFogDistanceMultiplier;

	[Token(Token = "0x4001BE9")]
	[FieldOffset(Offset = "0x1A8")]
	public RegionOrientation[] m_RegionOrientationValues;

	[Token(Token = "0x4001BEA")]
	public static EnvironemntChangedEvent OnEnvironmentChanged;

	[Token(Token = "0x4001BEB")]
	public static string m_RegionFromSaveSlot;

	[Token(Token = "0x4001BEC")]
	public static bool m_DebugWeather;

	[Token(Token = "0x4001BED")]
	[FieldOffset(Offset = "0x1B0")]
	private FallingSnowPreset[] m_FallingSnowPresets;

	[Token(Token = "0x4001BEE")]
	[FieldOffset(Offset = "0x1B8")]
	private WeatherStage[] m_FallingSnowStages;

	[Token(Token = "0x4001BEF")]
	[FieldOffset(Offset = "0x1C0")]
	private WeatherStage[] m_FallingSnowStagesTmp;

	[Token(Token = "0x4001BF0")]
	[FieldOffset(Offset = "0x1C8")]
	private float m_FallingSnowPresetBlend;

	[Token(Token = "0x4001BF1")]
	[FieldOffset(Offset = "0x1CC")]
	private Quaternion m_BlowingSnowRotation;

	[Token(Token = "0x4001BF2")]
	[FieldOffset(Offset = "0x1DC")]
	private float m_BlowingSnowAlphaMultiplier;

	[Token(Token = "0x4001BF3")]
	[FieldOffset(Offset = "0x1E0")]
	private bool m_WarmedWeatherState;

	[Token(Token = "0x4001BF4")]
	[FieldOffset(Offset = "0x1E4")]
	private WeatherStage m_CurrentWeatherStage;

	[Token(Token = "0x4001BF5")]
	[FieldOffset(Offset = "0x1E8")]
	private IndoorState m_IsIndoors;

	[Token(Token = "0x4001BF6")]
	[FieldOffset(Offset = "0x1EC")]
	private float m_BaseTemperature;

	[Token(Token = "0x4001BF7")]
	[FieldOffset(Offset = "0x1F0")]
	private float m_CurrentTemperature;

	[Token(Token = "0x4001BF8")]
	[FieldOffset(Offset = "0x1F4")]
	private float m_CurrentTemperatureWithoutHeatSources;

	[Token(Token = "0x4001BF9")]
	[FieldOffset(Offset = "0x1F8")]
	private float m_CurrentWindChill;

	[Token(Token = "0x4001BFA")]
	[FieldOffset(Offset = "0x1FC")]
	private float m_TempHigh;

	[Token(Token = "0x4001BFB")]
	[FieldOffset(Offset = "0x200")]
	private float m_TempLow;

	[Token(Token = "0x4001BFC")]
	[FieldOffset(Offset = "0x204")]
	private bool m_GenerateNewTempHigh;

	[Token(Token = "0x4001BFD")]
	[FieldOffset(Offset = "0x205")]
	private bool m_GenerateNewTempLow;

	[Token(Token = "0x4001BFE")]
	[FieldOffset(Offset = "0x208")]
	private float m_ArtificalTempIncrease;

	[Token(Token = "0x4001BFF")]
	[FieldOffset(Offset = "0x20C")]
	private float m_PrevBodyTemp;

	[Token(Token = "0x4001C00")]
	[FieldOffset(Offset = "0x210")]
	private float m_NextTempCheckTime;

	[Token(Token = "0x4001C01")]
	[FieldOffset(Offset = "0x214")]
	private float m_LastDegreeChangePerSecondCausingMessage;

	[Token(Token = "0x4001C02")]
	[FieldOffset(Offset = "0x218")]
	private float m_CurrentBlizzardDegreesDrop;

	[Token(Token = "0x4001C03")]
	[FieldOffset(Offset = "0x21C")]
	private int m_UpdateCount;

	[Token(Token = "0x4001C04")]
	[FieldOffset(Offset = "0x220")]
	private bool m_WarmWeatherParticleEmittersInLateUpdate;

	[Token(Token = "0x4001C05")]
	[FieldOffset(Offset = "0x224")]
	private float m_LastTemperatureSentToWise;

	[Token(Token = "0x4001C06")]
	[FieldOffset(Offset = "0x228")]
	private float m_TimeSheltered;

	[Token(Token = "0x4001C07")]
	[FieldOffset(Offset = "0x22C")]
	private bool m_PlayedWindClothingLoop;

	[Token(Token = "0x4001C08")]
	[FieldOffset(Offset = "0x230")]
	private float m_LockedAirTemperature;

	[Token(Token = "0x4001C09")]
	[FieldOffset(Offset = "0x234")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4001C0A")]
	[FieldOffset(Offset = "0x238")]
	private QualityPostFx m_CachedQuality;

	[Token(Token = "0x4001C0B")]
	private static WeatherSaveDataProxy m_WeatherSaveDataProxy;

	[Token(Token = "0x4001C0C")]
	private const string STORY_MODE_OVERRIDE = "_STORY";

	[Token(Token = "0x170001FC")]
	[field: Token(Token = "0x4001BDB")]
	[field: FieldOffset(Offset = "0x13C")]
	public bool m_HasCalculatedTemperature
	{
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x736150", Offset = "0x734F50", Length = "0x8")]
		get;
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x736160", Offset = "0x734F60", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x600196F")]
	[Address(RVA = "0x736170", Offset = "0x734F70", Length = "0x124C")]
	public void Start()
	{
	}

	[Token(Token = "0x6001970")]
	[Address(RVA = "0x7373E0", Offset = "0x7361E0", Length = "0x17C")]
	private void UpdateSporeFxQuality()
	{
	}

	[Token(Token = "0x6001971")]
	[Address(RVA = "0x737580", Offset = "0x736380", Length = "0x384")]
	private void InitializeWeatherSetsForScene()
	{
	}

	[Token(Token = "0x6001972")]
	[Address(RVA = "0x737910", Offset = "0x736710", Length = "0x271")]
	public void RegisterSceneWeatherSets(WeatherSetData[] sets)
	{
	}

	[Token(Token = "0x6001973")]
	[Address(RVA = "0x737B90", Offset = "0x736990", Length = "0x24D")]
	public WeatherSetData ChooseWeatherSetOfType(WeatherStage reqType)
	{
		return null;
	}

	[Token(Token = "0x6001974")]
	[Address(RVA = "0x737DE0", Offset = "0x736BE0", Length = "0xCAE")]
	public WeatherSetData GetCustomWeatherSet(string customTypeName)
	{
		return null;
	}

	[Token(Token = "0x6001975")]
	[Address(RVA = "0x738A90", Offset = "0x737890", Length = "0x1F0")]
	public WeatherSetData GetWeatherSetByName(string name)
	{
		return null;
	}

	[Token(Token = "0x6001976")]
	[Address(RVA = "0x738C90", Offset = "0x737A90", Length = "0x3C7")]
	public void Update()
	{
	}

	[Token(Token = "0x6001977")]
	[Address(RVA = "0x739060", Offset = "0x737E60", Length = "0x7E")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6001978")]
	[Address(RVA = "0x7390E0", Offset = "0x737EE0", Length = "0x24A")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001979")]
	[Address(RVA = "0x739330", Offset = "0x738130", Length = "0x13B")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600197A")]
	[Address(RVA = "0x739470", Offset = "0x738270", Length = "0x8")]
	public GameObject GetFallingSnowGameObject()
	{
		return null;
	}

	[Token(Token = "0x600197B")]
	[Address(RVA = "0x739480", Offset = "0x738280", Length = "0x356")]
	public void SetSnowPresetBlend(WeatherStage a, WeatherStage b, float blend, float blendTimeRemaining)
	{
	}

	[Token(Token = "0x600197C")]
	[Address(RVA = "0x7397E0", Offset = "0x7385E0", Length = "0x7F")]
	private void UpdateFallingSnowPreset()
	{
	}

	[Token(Token = "0x600197D")]
	[Address(RVA = "0x739860", Offset = "0x738660", Length = "0x104")]
	public float GetFallingSnowIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x600197E")]
	[Address(RVA = "0x739970", Offset = "0x738770", Length = "0x75")]
	public void RampBlowingSnow()
	{
	}

	[Token(Token = "0x600197F")]
	[Address(RVA = "0x7399F0", Offset = "0x7387F0", Length = "0x2B1")]
	public void KillWeatherParticles()
	{
	}

	[Token(Token = "0x6001980")]
	[Address(RVA = "0x739CB0", Offset = "0x738AB0", Length = "0x11F")]
	public void WarmWeather()
	{
	}

	[Token(Token = "0x6001981")]
	[Address(RVA = "0x739DD0", Offset = "0x738BD0", Length = "0x165")]
	public void WarmBlowingSnow()
	{
	}

	[Token(Token = "0x6001982")]
	[Address(RVA = "0x739F40", Offset = "0x738D40", Length = "0xD5")]
	public void SetSnowColor(Color c)
	{
	}

	[Token(Token = "0x6001983")]
	[Address(RVA = "0x73A020", Offset = "0x738E20", Length = "0x107")]
	public void SetBlowingSnowColor(Color c)
	{
	}

	[Token(Token = "0x6001984")]
	[Address(RVA = "0x73A130", Offset = "0x738F30", Length = "0xC2")]
	public void SetSnowDirection(float heading)
	{
	}

	[Token(Token = "0x6001985")]
	[Address(RVA = "0x73A200", Offset = "0x739000", Length = "0x5A")]
	public bool IsBlizzard()
	{
		return false;
	}

	[Token(Token = "0x6001986")]
	[Address(RVA = "0x73A260", Offset = "0x739060", Length = "0x5A")]
	public bool IsDenseFog()
	{
		return false;
	}

	[Token(Token = "0x6001987")]
	[Address(RVA = "0x73A2C0", Offset = "0x7390C0", Length = "0x8C")]
	public bool IsFoggy()
	{
		return false;
	}

	[Token(Token = "0x6001988")]
	[Address(RVA = "0x73A350", Offset = "0x739150", Length = "0xB6")]
	public bool IsSnowing()
	{
		return false;
	}

	[Token(Token = "0x6001989")]
	[Address(RVA = "0x73A410", Offset = "0x739210", Length = "0x8C")]
	public bool IsClear()
	{
		return false;
	}

	[Token(Token = "0x600198A")]
	[Address(RVA = "0x73A4A0", Offset = "0x7392A0", Length = "0x5A")]
	public bool IsLightSnow()
	{
		return false;
	}

	[Token(Token = "0x600198B")]
	[Address(RVA = "0x73A500", Offset = "0x739300", Length = "0x5A")]
	public bool IsHeavySnow()
	{
		return false;
	}

	[Token(Token = "0x600198C")]
	[Address(RVA = "0x73A560", Offset = "0x739360", Length = "0x5A")]
	public bool IsElectrostaticFog()
	{
		return false;
	}

	[Token(Token = "0x600198D")]
	[Address(RVA = "0x73A5C0", Offset = "0x7393C0", Length = "0x56")]
	public WeatherStage GetWeatherStage()
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x600198E")]
	[Address(RVA = "0x73A620", Offset = "0x739420", Length = "0x54")]
	public bool IsWeatherStatic()
	{
		return false;
	}

	[Token(Token = "0x600198F")]
	[Address(RVA = "0x73A680", Offset = "0x739480", Length = "0x9")]
	public float GetBaseTemperature()
	{
		return 0f;
	}

	[Token(Token = "0x6001990")]
	[Address(RVA = "0x73A690", Offset = "0x739490", Length = "0x9")]
	public float GetCurrentTemperature()
	{
		return 0f;
	}

	[Token(Token = "0x6001991")]
	[Address(RVA = "0x73A6A0", Offset = "0x7394A0", Length = "0x9")]
	public float GetCurrentTemperatureWithoutHeatSources()
	{
		return 0f;
	}

	[Token(Token = "0x6001992")]
	[Address(RVA = "0x73A6B0", Offset = "0x7394B0", Length = "0x56")]
	public float GetCurrentWindchill()
	{
		return 0f;
	}

	[Token(Token = "0x6001993")]
	[Address(RVA = "0x73A710", Offset = "0x739510", Length = "0x71")]
	public float GetCurrentTemperatureWithWindchill()
	{
		return 0f;
	}

	[Token(Token = "0x6001994")]
	[Address(RVA = "0x73A790", Offset = "0x739590", Length = "0x11")]
	public void AddArtificalTempIncrease(float increase)
	{
	}

	[Token(Token = "0x6001995")]
	[Address(RVA = "0x73A7B0", Offset = "0x7395B0", Length = "0x532")]
	public void ForceIndoorEnvironment()
	{
	}

	[Token(Token = "0x6001996")]
	[Address(RVA = "0x73ACF0", Offset = "0x739AF0", Length = "0x495")]
	public void ForceOutdoorEnvironment()
	{
	}

	[Token(Token = "0x6001997")]
	[Address(RVA = "0x73B190", Offset = "0x739F90", Length = "0xE3")]
	public float GetRotationDegreesForRegion(string regionName)
	{
		return 0f;
	}

	[Token(Token = "0x6001998")]
	[Address(RVA = "0x73B280", Offset = "0x73A080", Length = "0x13D")]
	public bool IsIndoorEnvironment()
	{
		return false;
	}

	[Token(Token = "0x6001999")]
	[Address(RVA = "0x73B3C0", Offset = "0x73A1C0", Length = "0x146")]
	public bool CanSurveyEnvironment()
	{
		return false;
	}

	[Token(Token = "0x600199A")]
	[Address(RVA = "0x73B510", Offset = "0x73A310", Length = "0xF9")]
	public bool IsIndoorScene()
	{
		return false;
	}

	[Token(Token = "0x600199B")]
	[Address(RVA = "0x73B610", Offset = "0x73A410", Length = "0x147")]
	public bool UseOutdoorLightingForLightSources()
	{
		return false;
	}

	[Token(Token = "0x600199C")]
	[Address(RVA = "0x73B760", Offset = "0x73A560", Length = "0x9")]
	public void LockAirTemperature(float celsius)
	{
	}

	[Token(Token = "0x600199D")]
	[Address(RVA = "0x73B770", Offset = "0x73A570", Length = "0xB65")]
	public bool IsTooDarkForAction(ActionsToBlock actionBeingChecked)
	{
		return false;
	}

	[Token(Token = "0x600199E")]
	[Address(RVA = "0x73C2E0", Offset = "0x73B0E0", Length = "0xC8")]
	public bool IsFullMoon()
	{
		return false;
	}

	[Token(Token = "0x600199F")]
	[Address(RVA = "0x73C3B0", Offset = "0x73B1B0", Length = "0x2EC")]
	public static string GetDebugWeatherText()
	{
		return null;
	}

	[Token(Token = "0x60019A0")]
	[Address(RVA = "0x73D510", Offset = "0x73C310", Length = "0x63")]
	private bool IsWindyEnoughForBlowingSnow()
	{
		return false;
	}

	[Token(Token = "0x60019A1")]
	[Address(RVA = "0x73D580", Offset = "0x73C380", Length = "0xB9")]
	private void RampDownAllSnow()
	{
	}

	[Token(Token = "0x60019A2")]
	[Address(RVA = "0x73D640", Offset = "0x73C440", Length = "0x1B3")]
	private void RampUpBlowingSnow()
	{
	}

	[Token(Token = "0x60019A3")]
	[Address(RVA = "0x73D800", Offset = "0x73C600", Length = "0x1E9")]
	private void RampDownBlowingSnow()
	{
	}

	[Token(Token = "0x60019A4")]
	[Address(RVA = "0x73D9F0", Offset = "0x73C7F0", Length = "0x6A")]
	private void UpdateWeatherSwitchStats()
	{
	}

	[Token(Token = "0x60019A5")]
	[Address(RVA = "0x73DA60", Offset = "0x73C860", Length = "0x24C")]
	public string GetWeatherStageDisplayName(WeatherStage ws)
	{
		return null;
	}

	[Token(Token = "0x60019A6")]
	[Address(RVA = "0x73DCD0", Offset = "0x73CAD0", Length = "0x461")]
	private void UpdateTemperatureOnHUD(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60019A7")]
	[Address(RVA = "0x73E140", Offset = "0x73CF40", Length = "0x91B")]
	private void CalculateCurrentTemperature()
	{
	}

	[Token(Token = "0x60019A8")]
	[Address(RVA = "0x73EA60", Offset = "0x73D860", Length = "0x64")]
	private void UpdateUniStormTemperature()
	{
	}

	[Token(Token = "0x60019A9")]
	[Address(RVA = "0x73EAD0", Offset = "0x73D8D0", Length = "0x29")]
	private void GenerateTempHigh()
	{
	}

	[Token(Token = "0x60019AA")]
	[Address(RVA = "0x73EB00", Offset = "0x73D900", Length = "0x29")]
	private void GenerateTempLow()
	{
	}

	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x73EB30", Offset = "0x73D930", Length = "0x9")]
	private float GetTempHigh()
	{
		return 0f;
	}

	[Token(Token = "0x60019AC")]
	[Address(RVA = "0x73EB40", Offset = "0x73D940", Length = "0x9")]
	private void SetTempHigh(float highTemp)
	{
	}

	[Token(Token = "0x60019AD")]
	[Address(RVA = "0x73EB50", Offset = "0x73D950", Length = "0x9")]
	private float GetTempLow()
	{
		return 0f;
	}

	[Token(Token = "0x60019AE")]
	[Address(RVA = "0x73EB60", Offset = "0x73D960", Length = "0x9")]
	private void SetTempLow(float lowTemp)
	{
	}

	[Token(Token = "0x60019AF")]
	[Address(RVA = "0x73EB70", Offset = "0x73D970", Length = "0x143")]
	private void UpdateBlizzardTemperatureDelta()
	{
	}

	[Token(Token = "0x60019B0")]
	[Address(RVA = "0x73ECC0", Offset = "0x73DAC0", Length = "0x234")]
	private void WarmWeatherParticleEmitters()
	{
	}

	[Token(Token = "0x60019B1")]
	[Address(RVA = "0x73EF00", Offset = "0x73DD00", Length = "0x100")]
	public void WarmWeatherState()
	{
	}

	[Token(Token = "0x60019B2")]
	[Address(RVA = "0x73F010", Offset = "0x73DE10", Length = "0x1C6")]
	private void ApplyClothingDamage()
	{
	}

	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x73F1E0", Offset = "0x73DFE0", Length = "0x454")]
	private void UpdateSnowEffectTransforms()
	{
	}

	[Token(Token = "0x60019B4")]
	[Address(RVA = "0x73F640", Offset = "0x73E440", Length = "0x420")]
	private void UpdateToxicFogSporeTransforms()
	{
	}

	[Token(Token = "0x60019B5")]
	[Address(RVA = "0x73FA70", Offset = "0x73E870", Length = "0x43")]
	public bool IsMainMenu()
	{
		return false;
	}

	[Token(Token = "0x60019B6")]
	[Address(RVA = "0x73FAC0", Offset = "0x73E8C0", Length = "0x30E")]
	public void MaybeCreateToxicFogSporeFx()
	{
	}

	[Token(Token = "0x60019B7")]
	[Address(RVA = "0x73FDD0", Offset = "0x73EBD0", Length = "0x6D9")]
	public void SetToxicFogParameters(float minFogThreshhold, float maxFogThreshhold, float fogValue)
	{
	}

	[Token(Token = "0x60019B8")]
	[Address(RVA = "0x7404B0", Offset = "0x73F2B0", Length = "0x92")]
	private void MaybeUpdateWiseWithCurrentTemperature()
	{
	}

	[Token(Token = "0x60019B9")]
	[Address(RVA = "0x740550", Offset = "0x73F350", Length = "0x41C")]
	private float GetMinAirTemp()
	{
		return 0f;
	}

	[Token(Token = "0x60019BA")]
	[Address(RVA = "0x740970", Offset = "0x73F770", Length = "0x10")]
	public static bool IsClear(WeatherStage ws)
	{
		return false;
	}

	[Token(Token = "0x60019BB")]
	[Address(RVA = "0x740980", Offset = "0x73F780", Length = "0x111")]
	public void ToggleDownsampleWindEffect()
	{
	}

	[Token(Token = "0x60019BC")]
	[Address(RVA = "0x740AA0", Offset = "0x73F8A0", Length = "0x23")]
	public void DisableWindEffect()
	{
	}

	[Token(Token = "0x60019BD")]
	[Address(RVA = "0x740AD0", Offset = "0x73F8D0", Length = "0x23")]
	public void EnableWindEffect()
	{
	}

	[Token(Token = "0x60019BE")]
	[Address(RVA = "0x740B00", Offset = "0x73F900", Length = "0xBC")]
	private WeatherSetData LoadAddressableCustomWeatherSet(string name)
	{
		return null;
	}

	[Token(Token = "0x60019BF")]
	[Address(RVA = "0x740BC0", Offset = "0x73F9C0", Length = "0x370")]
	public Weather()
	{
	}
}
