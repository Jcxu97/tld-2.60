using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Electrostatic;
using TLD.Events;
using TLD.Scenes;
using TLD.Stats;
using TLD.UI.Generics;
using TLD.WeatherParticle;
using UnityEngine;

[Token(Token = "0x20009E8")]
public class UniStormWeatherSystem : MonoBehaviour, IElectrostaticSource
{
	[Token(Token = "0x20009E9")]
	private class RegionTimeAccumulator
	{
		[Token(Token = "0x4006515")]
		[FieldOffset(Offset = "0x10")]
		public SceneSet m_Region;

		[Token(Token = "0x4006516")]
		[FieldOffset(Offset = "0x18")]
		public StatID m_Stat;

		[Token(Token = "0x4006517")]
		[FieldOffset(Offset = "0x1C")]
		public float m_ElapsedHours;

		[Token(Token = "0x600576D")]
		[Address(RVA = "0xED4750", Offset = "0xED3550", Length = "0x15D")]
		public void AddTime(float deltaHours, float threshold)
		{
		}

		[Token(Token = "0x600576E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public RegionTimeAccumulator()
		{
		}
	}

	[Token(Token = "0x4006486")]
	[FieldOffset(Offset = "0x20")]
	public WeatherStageChangeEvent m_WeatherStageChangeEvent;

	[Token(Token = "0x4006487")]
	private const float SUN_SIZE = 0.1f;

	[Token(Token = "0x4006488")]
	[FieldOffset(Offset = "0x28")]
	private Texture2D m_SilhouetteGradientTexture;

	[Token(Token = "0x4006489")]
	private static readonly int s_DistanceFogGradient;

	[Token(Token = "0x400648A")]
	private static readonly int s_SilhouetteFog;

	[Token(Token = "0x400648B")]
	[FieldOffset(Offset = "0x30")]
	public WeatherStatesData[] m_WeatherStateConfigs;

	[Token(Token = "0x400648C")]
	[FieldOffset(Offset = "0x38")]
	public TODStateData[] m_SpecialTODStates;

	[Token(Token = "0x400648D")]
	[FieldOffset(Offset = "0x40")]
	public SpecialTODState m_SpecialTODState;

	[Token(Token = "0x400648E")]
	[FieldOffset(Offset = "0x48")]
	public float[] m_SpecialTODStateFixedTimes;

	[Token(Token = "0x400648F")]
	[FieldOffset(Offset = "0x50")]
	public bool m_StaticWeather;

	[Token(Token = "0x4006490")]
	[FieldOffset(Offset = "0x51")]
	public bool m_LiveEdit;

	[Token(Token = "0x4006491")]
	[FieldOffset(Offset = "0x54")]
	public float m_AnimScalar_Ambient;

	[Token(Token = "0x4006492")]
	[FieldOffset(Offset = "0x58")]
	public float m_AnimScalar_Directional;

	[Token(Token = "0x4006493")]
	[FieldOffset(Offset = "0x5C")]
	public float m_MasterTimeKeyOffset;

	[Token(Token = "0x4006494")]
	[FieldOffset(Offset = "0x60")]
	public float m_MasterAmbientIntensityScalar;

	[Token(Token = "0x4006495")]
	[FieldOffset(Offset = "0x64")]
	public float m_MasterSunLightIntensityScalar;

	[Token(Token = "0x4006496")]
	[FieldOffset(Offset = "0x68")]
	public float m_MasterMoonLightIntensityScalar;

	[Token(Token = "0x4006497")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve m_MasterSunShadowFadeCurve;

	[Token(Token = "0x4006498")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve m_MasterMoonShadowFadeCurve;

	[Token(Token = "0x4006499")]
	[FieldOffset(Offset = "0x80")]
	public float m_FarClipCheat;

	[Token(Token = "0x400649A")]
	[FieldOffset(Offset = "0x84")]
	public float m_FogColorMargin;

	[Token(Token = "0x400649B")]
	[FieldOffset(Offset = "0x88")]
	public int m_MinuteCounter;

	[Token(Token = "0x400649C")]
	[FieldOffset(Offset = "0x8C")]
	public int m_HourCounter;

	[Token(Token = "0x400649D")]
	[FieldOffset(Offset = "0x90")]
	public int m_DayCounter;

	[Token(Token = "0x400649E")]
	[FieldOffset(Offset = "0x94")]
	public int m_Temperature;

	[Token(Token = "0x400649F")]
	[FieldOffset(Offset = "0x98")]
	public float m_DayLength;

	[Token(Token = "0x40064A0")]
	[FieldOffset(Offset = "0x9C")]
	public float m_NormalizedTime;

	[SerializeField]
	[Token(Token = "0x40064A1")]
	[FieldOffset(Offset = "0xA0")]
	private float[] m_TODKeyframeTimes;

	[Token(Token = "0x40064A2")]
	[FieldOffset(Offset = "0xA8")]
	public int m_MoonCycleStartDay;

	[Token(Token = "0x40064A3")]
	[FieldOffset(Offset = "0xAC")]
	public float m_MoonPhaseIntensityControl;

	[Token(Token = "0x40064A4")]
	[FieldOffset(Offset = "0xB0")]
	public float m_SunAngle;

	[Token(Token = "0x40064A5")]
	[FieldOffset(Offset = "0xB4")]
	public Color m_MoonLightColor;

	[Token(Token = "0x40064A6")]
	[FieldOffset(Offset = "0xC4")]
	public Color m_MoonLightColorOverride;

	[Token(Token = "0x40064A7")]
	[FieldOffset(Offset = "0xD4")]
	public Color m_StarColor;

	[Token(Token = "0x40064A8")]
	[FieldOffset(Offset = "0xE4")]
	public float m_CloudSpeed;

	[Token(Token = "0x40064A9")]
	[FieldOffset(Offset = "0xE8")]
	public float m_BlizzardFogBlusterRange;

	[Token(Token = "0x40064AA")]
	[FieldOffset(Offset = "0xEC")]
	public float m_BlizzardFogBlusterSpeed;

	[Token(Token = "0x40064AB")]
	[FieldOffset(Offset = "0xF0")]
	public WeatherStage m_PreviousWeatherStage;

	[Token(Token = "0x40064AC")]
	[FieldOffset(Offset = "0xF4")]
	public WeatherStage m_CurrentWeatherStage;

	[Token(Token = "0x40064AD")]
	[FieldOffset(Offset = "0xF8")]
	private float m_NormalizedAuroraAlpha;

	[Token(Token = "0x40064AE")]
	[FieldOffset(Offset = "0xFC")]
	public float m_SkyboxFogSampleDistance;

	[Token(Token = "0x40064AF")]
	[FieldOffset(Offset = "0x100")]
	public float m_SkyboxFogPower;

	[Token(Token = "0x40064B0")]
	[FieldOffset(Offset = "0x108")]
	public Material m_SkyboxMaterial;

	[Token(Token = "0x40064B1")]
	[FieldOffset(Offset = "0x110")]
	public Renderer[] m_SkyGlowRenderers;

	[Token(Token = "0x40064B2")]
	[FieldOffset(Offset = "0x118")]
	public ColorGradingSettings m_DefaultColorGradingSettings;

	[Token(Token = "0x40064B3")]
	[FieldOffset(Offset = "0x120")]
	public HeightFogManager m_HeightFogManager;

	[Token(Token = "0x40064B4")]
	[FieldOffset(Offset = "0x128")]
	public GameObject m_SnowPlaneManager;

	[Token(Token = "0x40064B5")]
	[FieldOffset(Offset = "0x130")]
	public GameObject m_StarSphere;

	[Token(Token = "0x40064B6")]
	[FieldOffset(Offset = "0x138")]
	public Texture2D[] m_MoonPhases;

	[Token(Token = "0x40064B7")]
	[FieldOffset(Offset = "0x140")]
	public Light m_SunLight;

	[Token(Token = "0x40064B8")]
	[FieldOffset(Offset = "0x148")]
	public Light m_MoonLight;

	[Token(Token = "0x40064B9")]
	[FieldOffset(Offset = "0x150")]
	public GodrayManager m_GodrayManager;

	[Token(Token = "0x40064BA")]
	[FieldOffset(Offset = "0x158")]
	public float m_CloudCoverage;

	[Token(Token = "0x40064BB")]
	[FieldOffset(Offset = "0x15C")]
	public float m_FogDensity;

	[Token(Token = "0x40064BC")]
	[FieldOffset(Offset = "0x160")]
	public GameObject m_LightClouds1;

	[Token(Token = "0x40064BD")]
	[FieldOffset(Offset = "0x168")]
	public GameObject m_LightClouds2;

	[Token(Token = "0x40064BE")]
	[FieldOffset(Offset = "0x170")]
	public GameObject m_HighClouds1;

	[Token(Token = "0x40064BF")]
	[FieldOffset(Offset = "0x178")]
	public GameObject m_MostlyCloudyClouds;

	[Token(Token = "0x40064C0")]
	public static float m_MinimumFogDensityScale;

	[Token(Token = "0x40064C1")]
	public static float m_FogScale;

	[Token(Token = "0x40064C2")]
	[FieldOffset(Offset = "0x180")]
	private SnowPlaneManager m_SnowPlaneManagerComponent;

	[Token(Token = "0x40064C3")]
	[FieldOffset(Offset = "0x188")]
	private Renderer m_StarSphereRenderer;

	[Token(Token = "0x40064C4")]
	[FieldOffset(Offset = "0x190")]
	private Renderer m_LightClouds1_Renderer;

	[Token(Token = "0x40064C5")]
	[FieldOffset(Offset = "0x198")]
	private Renderer m_LightClouds2_Renderer;

	[Token(Token = "0x40064C6")]
	[FieldOffset(Offset = "0x1A0")]
	private Renderer m_HighClouds1_Renderer;

	[Token(Token = "0x40064C7")]
	[FieldOffset(Offset = "0x1A8")]
	private Renderer m_MostlyCloudyClouds_Renderer;

	[Token(Token = "0x40064C8")]
	[FieldOffset(Offset = "0x1B0")]
	private Renderer m_HorizonCloudsBand1_Renderer;

	[Token(Token = "0x40064C9")]
	[FieldOffset(Offset = "0x1B8")]
	private Renderer m_HorizonCloudsBand2_Renderer;

	[Token(Token = "0x40064CA")]
	[FieldOffset(Offset = "0x1C0")]
	private Renderer m_HorizonCloudsBand3_Renderer;

	[Token(Token = "0x40064CB")]
	[FieldOffset(Offset = "0x1C8")]
	private Renderer m_SkyCloudEdge1_Renderer;

	[Token(Token = "0x40064CC")]
	[FieldOffset(Offset = "0x1D0")]
	private Renderer m_SkyCloudEdge2_Renderer;

	[Token(Token = "0x40064CD")]
	[FieldOffset(Offset = "0x1D8")]
	private Renderer m_HorizonGrad_Renderer;

	[Token(Token = "0x40064CE")]
	[FieldOffset(Offset = "0x1E0")]
	private Material m_SkyboxMaterialCopy;

	[Token(Token = "0x40064CF")]
	[FieldOffset(Offset = "0x1E8")]
	public Camera m_MainCamera;

	[Token(Token = "0x40064D0")]
	[FieldOffset(Offset = "0x1F0")]
	public WeatherParticleManagerConfiguration m_WeatherParticleManagerConfig;

	[Token(Token = "0x40064D1")]
	[FieldOffset(Offset = "0x288")]
	private WeatherParticleManager m_WeatherParticleManager;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40064D2")]
	[FieldOffset(Offset = "0x290")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x40064D3")]
	[FieldOffset(Offset = "0x298")]
	private PanelReference<Panel_LifeAfterDeath> m_LifeAfterDeath;

	[Token(Token = "0x40064D4")]
	[FieldOffset(Offset = "0x2A0")]
	private float m_Hour;

	[Token(Token = "0x40064D5")]
	[FieldOffset(Offset = "0x2A4")]
	private float m_MinuteCounterCalculator;

	[Token(Token = "0x40064D6")]
	[FieldOffset(Offset = "0x2A8")]
	private float m_ActiveSunAngle;

	[Token(Token = "0x40064D7")]
	[FieldOffset(Offset = "0x2B0")]
	private GameObject m_WeatherSystemsGameObject;

	[Token(Token = "0x40064D8")]
	[FieldOffset(Offset = "0x2B8")]
	private GameObject m_CloudParentGameObject;

	[Token(Token = "0x40064D9")]
	[FieldOffset(Offset = "0x2C0")]
	public float m_DayLengthScale;

	[Token(Token = "0x40064DA")]
	[FieldOffset(Offset = "0x2C4")]
	public float m_CurrentWeatherBlend;

	[Token(Token = "0x40064DB")]
	[FieldOffset(Offset = "0x2C8")]
	private float m_DeltaTime;

	[Token(Token = "0x40064DC")]
	[FieldOffset(Offset = "0x2CC")]
	private bool m_WarmingWeatherState;

	[Token(Token = "0x40064DD")]
	[FieldOffset(Offset = "0x2D0")]
	private float m_SecondsSinceLastWeatherChange;

	[Token(Token = "0x40064DE")]
	[FieldOffset(Offset = "0x2D4")]
	private bool m_MoonPhaseSet;

	[Token(Token = "0x40064DF")]
	[FieldOffset(Offset = "0x2D8")]
	private int m_CurrentMoonPhaseIndex;

	[Token(Token = "0x40064E0")]
	[FieldOffset(Offset = "0x2DC")]
	private float m_MoonPhaseIntensityScalar;

	[Token(Token = "0x40064E1")]
	[FieldOffset(Offset = "0x2E0")]
	private Vector2 m_BlizzardFogNoiseVec;

	[Token(Token = "0x40064E2")]
	[FieldOffset(Offset = "0x2E8")]
	private float m_AmbientLightTransitionTimeSeconds;

	[Token(Token = "0x40064E3")]
	[FieldOffset(Offset = "0x2EC")]
	private float m_ElapsedHours;

	[Token(Token = "0x40064E4")]
	[FieldOffset(Offset = "0x2F0")]
	private float m_ElapsedHoursAccumulator;

	[Token(Token = "0x40064E5")]
	[FieldOffset(Offset = "0x2F4")]
	private float m_ElapsedHoursIndoorsAccumulator;

	[Token(Token = "0x40064E6")]
	[FieldOffset(Offset = "0x2F8")]
	private float m_ElapsedHoursOutdoorsAccumulator;

	[Token(Token = "0x40064E7")]
	[FieldOffset(Offset = "0x2FC")]
	private float m_ElapsedHoursAsleepAccumulator;

	[Token(Token = "0x40064E8")]
	[FieldOffset(Offset = "0x300")]
	private float m_ElapsedHoursAsleepOutdoorsAccumulator;

	[Token(Token = "0x40064E9")]
	[FieldOffset(Offset = "0x304")]
	private float m_ElapsedHoursAwakeAccumulator;

	[Token(Token = "0x40064EA")]
	[FieldOffset(Offset = "0x308")]
	private List<RegionTimeAccumulator> m_RegionTimes;

	[Token(Token = "0x40064EB")]
	[FieldOffset(Offset = "0x310")]
	private bool m_LastFrameWasOutside;

	[Token(Token = "0x40064EC")]
	[FieldOffset(Offset = "0x311")]
	private bool m_LastFrameWasNight;

	[Token(Token = "0x40064ED")]
	[FieldOffset(Offset = "0x312")]
	private bool m_OutsideSinceBeginningOfNight;

	[Token(Token = "0x40064EE")]
	[FieldOffset(Offset = "0x313")]
	private bool m_UseMoonColourColorOverride;

	[Token(Token = "0x40064EF")]
	[FieldOffset(Offset = "0x314")]
	private float m_WeatherTransitionTime;

	[Token(Token = "0x40064F0")]
	[FieldOffset(Offset = "0x318")]
	private ActiveEnvironment m_ActiveEnvironment;

	[HideInInspector]
	[Token(Token = "0x40064F1")]
	[FieldOffset(Offset = "0x320")]
	public SpecialTODState m_RequestedSpecialTODState;

	[Token(Token = "0x40064F2")]
	[FieldOffset(Offset = "0x324")]
	private SpecialTODState m_LastSpecialTODState;

	[Token(Token = "0x40064F3")]
	[FieldOffset(Offset = "0x328")]
	private SceneSet m_CurrentRegion;

	[Token(Token = "0x40064F4")]
	[FieldOffset(Offset = "0x330")]
	private Animator m_Animator;

	[Token(Token = "0x40064F5")]
	[FieldOffset(Offset = "0x338")]
	private Vector4 m_CloudTextureOffset_LightClouds1;

	[Token(Token = "0x40064F6")]
	[FieldOffset(Offset = "0x348")]
	private Vector4 m_CloudTextureOffset_LightClouds2;

	[Token(Token = "0x40064F7")]
	[FieldOffset(Offset = "0x358")]
	private Vector4 m_CloudTextureOffset_HighClouds1;

	[Token(Token = "0x40064F8")]
	[FieldOffset(Offset = "0x368")]
	private Vector4 m_CloudTextureOffset_MostlyCloudyClouds;

	[Token(Token = "0x40064F9")]
	[FieldOffset(Offset = "0x378")]
	private MaterialPropertyBlock m_OnUpdatePropertyBlock;

	[Token(Token = "0x40064FA")]
	[FieldOffset(Offset = "0x380")]
	private List<SunShadowOverrideVolume> m_SunShadowOverrideVolumes;

	[Token(Token = "0x40064FB")]
	private static float s_OriginalNightToxicFogDensity;

	[Token(Token = "0x40064FC")]
	private static readonly int s_ColorShaderID;

	[Token(Token = "0x40064FD")]
	private static readonly int s_MainTexOffsetShaderID;

	[Token(Token = "0x40064FE")]
	private static readonly int s_TintColorShaderID;

	[Token(Token = "0x40064FF")]
	private static readonly int s_MoonXShaderID;

	[Token(Token = "0x4006500")]
	private static readonly int s_MoonYShaderID;

	[Token(Token = "0x4006501")]
	private static readonly int s_MoonZShaderID;

	[Token(Token = "0x4006502")]
	private static readonly int s_MoonColorShaderID;

	[Token(Token = "0x4006503")]
	private static readonly int s_MoonTexShaderID;

	[Token(Token = "0x4006504")]
	private static readonly int s_MoonGlowShaderID;

	[Token(Token = "0x4006505")]
	private static readonly int s_AmbientLightColorShaderID;

	[Token(Token = "0x4006506")]
	private static readonly int s_FogColorShaderID;

	[Token(Token = "0x4006507")]
	private static readonly int s_AtmosphereThicknessShaderID;

	[Token(Token = "0x4006508")]
	private static readonly int s_ExposureShaderID;

	[Token(Token = "0x4006509")]
	private static readonly int s_SunSizeShaderID;

	[Token(Token = "0x400650A")]
	private static readonly int s_SunDiffusionShaderID;

	[Token(Token = "0x400650B")]
	private static readonly int s_SunDirShaderID;

	[Token(Token = "0x400650C")]
	private static readonly int s_SunColorShaderID;

	[Token(Token = "0x400650D")]
	private static readonly int s_HorizonAdjustShaderID;

	[Token(Token = "0x400650E")]
	private static readonly int s_GlobalSunDirShaderID;

	[Token(Token = "0x400650F")]
	private static readonly int s_GlobalSunLuminanceShaderID;

	[Token(Token = "0x4006510")]
	private static readonly int s_GlobalGrassTintScalarShaderID;

	[Token(Token = "0x4006511")]
	private static readonly int s_FresnelcolorShaderID;

	[Token(Token = "0x4006512")]
	private static readonly int s_GlobalShadowColorID;

	[Token(Token = "0x4006513")]
	private const float ENDLESSNIGHT_NORMALIZEDTIME = 0.2f;

	[Token(Token = "0x4006514")]
	private static float[] m_MoonIntensityByPhaseScalars;

	[Token(Token = "0x6005712")]
	[Address(RVA = "0xEC9C40", Offset = "0xEC8A40", Length = "0x1E")]
	public TODStateData GetActiveTODState()
	{
		return null;
	}

	[Token(Token = "0x6005713")]
	[Address(RVA = "0xEC9C60", Offset = "0xEC8A60", Length = "0x4F0")]
	public void Awake()
	{
	}

	[Token(Token = "0x6005714")]
	[Address(RVA = "0xECA160", Offset = "0xEC8F60", Length = "0xB6")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005715")]
	[Address(RVA = "0xECA220", Offset = "0xEC9020", Length = "0x453")]
	public void Start()
	{
	}

	[Token(Token = "0x6005716")]
	[Address(RVA = "0xECA680", Offset = "0xEC9480", Length = "0xAF3")]
	public void Init()
	{
	}

	[Token(Token = "0x6005717")]
	[Address(RVA = "0xECB180", Offset = "0xEC9F80", Length = "0x19E")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6005718")]
	[Address(RVA = "0xECB320", Offset = "0xECA120", Length = "0x233")]
	public void InitializeForScene()
	{
	}

	[Token(Token = "0x6005719")]
	[Address(RVA = "0xECB560", Offset = "0xECA360", Length = "0x20")]
	public void InitializeAfterSceneLoad()
	{
	}

	[Token(Token = "0x600571A")]
	[Address(RVA = "0xECB590", Offset = "0xECA390", Length = "0xD4")]
	private bool IsPaused()
	{
		return false;
	}

	[Token(Token = "0x600571B")]
	[Address(RVA = "0xECB670", Offset = "0xECA470", Length = "0x3D7C")]
	public void Update()
	{
	}

	[Token(Token = "0x600571C")]
	[Address(RVA = "0xECF410", Offset = "0xECE210", Length = "0x21E")]
	public float GetClearNightFogDensity()
	{
		return 0f;
	}

	[Token(Token = "0x600571D")]
	[Address(RVA = "0xECF630", Offset = "0xECE430", Length = "0x315")]
	public void SetToxicFogDensity(float fogDensity)
	{
	}

	[Token(Token = "0x600571E")]
	[Address(RVA = "0xECF950", Offset = "0xECE750", Length = "0x55")]
	public float GetOriginalNightToxicFogDensity()
	{
		return 0f;
	}

	[Token(Token = "0x600571F")]
	[Address(RVA = "0xECF9B0", Offset = "0xECE7B0", Length = "0x85")]
	public float GetElectroStaticActive()
	{
		return 0f;
	}

	[Token(Token = "0x6005720")]
	[Address(RVA = "0x4A2290", Offset = "0x4A1090", Length = "0x9")]
	public float GetElectrostaticStrength()
	{
		return 0f;
	}

	[Token(Token = "0x6005721")]
	[Address(RVA = "0xECFA40", Offset = "0xECE840", Length = "0x1AD")]
	public float GetClearAuroraIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6005722")]
	[Address(RVA = "0xECFBF0", Offset = "0xECE9F0", Length = "0x49")]
	private float GetElectrostaticFogIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6005723")]
	[Address(RVA = "0xECFC40", Offset = "0xECEA40", Length = "0x56")]
	private float CalculateWeatherChangeAuroraIntensity(WeatherStage auroraWeatherStage)
	{
		return 0f;
	}

	[Token(Token = "0x6005724")]
	[Address(RVA = "0xECFCA0", Offset = "0xECEAA0", Length = "0xE4")]
	public float GetNormalizedWeatherTransition()
	{
		return 0f;
	}

	[Token(Token = "0x6005725")]
	[Address(RVA = "0xECFD90", Offset = "0xECEB90", Length = "0x913")]
	private void UpdateTimeStats(float timeDeltaHours)
	{
	}

	[Token(Token = "0x6005726")]
	[Address(RVA = "0xED06B0", Offset = "0xECF4B0", Length = "0x20")]
	public void UpdateWeatherParticleManager()
	{
	}

	[Token(Token = "0x6005727")]
	[Address(RVA = "0xED06E0", Offset = "0xECF4E0", Length = "0x29")]
	public void ResetWeatherSystem()
	{
	}

	[Token(Token = "0x6005728")]
	[Address(RVA = "0xED0710", Offset = "0xECF510", Length = "0xA")]
	public void ClearSpecialTODState()
	{
	}

	[Token(Token = "0x6005729")]
	[Address(RVA = "0xED0720", Offset = "0xECF520", Length = "0xF")]
	public void RequestSpecialTODState(SpecialTODState state)
	{
	}

	[Token(Token = "0x600572A")]
	[Address(RVA = "0xED0730", Offset = "0xECF530", Length = "0x28")]
	public void SetNormalizedTime(float time)
	{
	}

	[Token(Token = "0x600572B")]
	[Address(RVA = "0xED0760", Offset = "0xECF560", Length = "0x49")]
	public void SetNormalizedTime(float time, bool forceUpdate)
	{
	}

	[Token(Token = "0x600572C")]
	[Address(RVA = "0xED07B0", Offset = "0xECF5B0", Length = "0x6DD")]
	public void UpdateSunTransform()
	{
	}

	[Token(Token = "0x600572D")]
	[Address(RVA = "0xED0E90", Offset = "0xECFC90", Length = "0x21E")]
	public void EnableWeatherSystems(bool enable)
	{
	}

	[Token(Token = "0x600572E")]
	[Address(RVA = "0xED10B0", Offset = "0xECFEB0", Length = "0x16D")]
	public void EnableCloudParent(bool enable)
	{
	}

	[Token(Token = "0x600572F")]
	[Address(RVA = "0x502780", Offset = "0x501580", Length = "0x7")]
	public WeatherStage GetWeatherStage()
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x6005730")]
	[Address(RVA = "0xED1220", Offset = "0xED0020", Length = "0x114")]
	private void ChangeWeatherState(WeatherStage current, WeatherStage previous)
	{
	}

	[Token(Token = "0x6005731")]
	[Address(RVA = "0xED1340", Offset = "0xED0140", Length = "0x115")]
	public void SetWeatherStage(WeatherStage ws, float transitionTime, bool force = false)
	{
	}

	[Token(Token = "0x6005732")]
	[Address(RVA = "0xED1460", Offset = "0xED0260", Length = "0x156")]
	public void SetWeatherStateAndBlendDirectly(WeatherStage ws, WeatherStage prevWS, float elapsedGameTimeInStage, float transitionGameTimeForStage)
	{
	}

	[Token(Token = "0x6005733")]
	[Address(RVA = "0xED15C0", Offset = "0xED03C0", Length = "0x267")]
	public void WarmWeatherState()
	{
	}

	[Token(Token = "0x6005734")]
	[Address(RVA = "0xED1830", Offset = "0xED0630", Length = "0x7")]
	public int GetMoonPhaseIndex()
	{
		return 0;
	}

	[Token(Token = "0x6005735")]
	[Address(RVA = "0xED1840", Offset = "0xED0640", Length = "0x97")]
	public void SetMoonPhaseIndex(int phase)
	{
	}

	[Token(Token = "0x6005736")]
	[Address(RVA = "0xED18E0", Offset = "0xED06E0", Length = "0x9")]
	public float GetMoonIntensityScalar()
	{
		return 0f;
	}

	[Token(Token = "0x6005737")]
	[Address(RVA = "0xED18F0", Offset = "0xED06F0", Length = "0x13F")]
	public void SetMoonPhase()
	{
	}

	[Token(Token = "0x6005738")]
	[Address(RVA = "0xED1A30", Offset = "0xED0830", Length = "0x86")]
	public bool IsFullMoon()
	{
		return false;
	}

	[Token(Token = "0x6005739")]
	[Address(RVA = "0xED1AC0", Offset = "0xED08C0", Length = "0x7")]
	public void SetMoonColourOverride(bool enableOverride)
	{
	}

	[Token(Token = "0x600573A")]
	[Address(RVA = "0xED1AD0", Offset = "0xED08D0", Length = "0xB")]
	public void SetMoonColourOverrideColour(Color newColor)
	{
	}

	[Token(Token = "0x600573B")]
	[Address(RVA = "0x507910", Offset = "0x506710", Length = "0x7")]
	public int GetDayNumber()
	{
		return 0;
	}

	[Token(Token = "0x600573C")]
	[Address(RVA = "0xED1AE0", Offset = "0xED08E0", Length = "0x7")]
	public void SetDayNumber(int day)
	{
	}

	[Token(Token = "0x600573D")]
	[Address(RVA = "0xED1AF0", Offset = "0xED08F0", Length = "0x9")]
	public void SetAuroraAlpha(float alpha)
	{
	}

	[Token(Token = "0x600573E")]
	[Address(RVA = "0xED1B00", Offset = "0xED0900", Length = "0x52")]
	public bool IsNightOrNightBlend()
	{
		return false;
	}

	[Token(Token = "0x600573F")]
	[Address(RVA = "0xED1B60", Offset = "0xED0960", Length = "0x52")]
	public bool IsNight()
	{
		return false;
	}

	[Token(Token = "0x6005740")]
	[Address(RVA = "0xED1BC0", Offset = "0xED09C0", Length = "0x5A")]
	public bool IsNightWithExtendedHours(float extendedHours)
	{
		return false;
	}

	[Token(Token = "0x6005741")]
	[Address(RVA = "0xED1C20", Offset = "0xED0A20", Length = "0x4F")]
	public bool IsMorning()
	{
		return false;
	}

	[Token(Token = "0x6005742")]
	[Address(RVA = "0xED1C70", Offset = "0xED0A70", Length = "0x4F")]
	public bool IsAfternoon()
	{
		return false;
	}

	[Token(Token = "0x6005743")]
	[Address(RVA = "0xED1CC0", Offset = "0xED0AC0", Length = "0x3A")]
	public bool IsNightPreMidnight()
	{
		return false;
	}

	[Token(Token = "0x6005744")]
	[Address(RVA = "0xED1D00", Offset = "0xED0B00", Length = "0x3E")]
	public bool IsNightPostMidnight()
	{
		return false;
	}

	[Token(Token = "0x6005745")]
	[Address(RVA = "0xED1D40", Offset = "0xED0B40", Length = "0x52")]
	public bool IsDusk()
	{
		return false;
	}

	[Token(Token = "0x6005746")]
	[Address(RVA = "0xED1DA0", Offset = "0xED0BA0", Length = "0x52")]
	public bool IsDawn()
	{
		return false;
	}

	[Token(Token = "0x6005747")]
	[Address(RVA = "0xED1E00", Offset = "0xED0C00", Length = "0x5A")]
	public bool IsDayWithExtendedHours(float extendedHours)
	{
		return false;
	}

	[Token(Token = "0x6005748")]
	[Address(RVA = "0xED1E60", Offset = "0xED0C60", Length = "0x2B")]
	public float GetDawnHourTime()
	{
		return 0f;
	}

	[Token(Token = "0x6005749")]
	[Address(RVA = "0xED1E90", Offset = "0xED0C90", Length = "0x6F")]
	public bool IsEarlyNightWindowForAuroraActivation()
	{
		return false;
	}

	[Token(Token = "0x600574A")]
	[Address(RVA = "0xED1F00", Offset = "0xED0D00", Length = "0x6F")]
	public bool IsLateNightWindowForAuroraActivation()
	{
		return false;
	}

	[Token(Token = "0x600574B")]
	[Address(RVA = "0xED1F70", Offset = "0xED0D70", Length = "0x8A")]
	public bool IsInsideElectrostaticFogSelectionWindow()
	{
		return false;
	}

	[Token(Token = "0x600574C")]
	[Address(RVA = "0xED2000", Offset = "0xED0E00", Length = "0x8A")]
	public bool IsInsideElectrostaticFogActivationWindow()
	{
		return false;
	}

	[Token(Token = "0x600574D")]
	[Address(RVA = "0xED2090", Offset = "0xED0E90", Length = "0x30")]
	public float GetDawnTime()
	{
		return 0f;
	}

	[Token(Token = "0x600574E")]
	[Address(RVA = "0xED20D0", Offset = "0xED0ED0", Length = "0x30")]
	public float GetNightStartTime()
	{
		return 0f;
	}

	[Token(Token = "0x600574F")]
	[Address(RVA = "0xED2110", Offset = "0xED0F10", Length = "0x9F")]
	public float GetProgressDusk()
	{
		return 0f;
	}

	[Token(Token = "0x6005750")]
	[Address(RVA = "0xED21B0", Offset = "0xED0FB0", Length = "0x9F")]
	public float GetProgressDawn()
	{
		return 0f;
	}

	[Token(Token = "0x6005751")]
	[Address(RVA = "0xED2250", Offset = "0xED1050", Length = "0xE6")]
	public float GetNightPercentage()
	{
		return 0f;
	}

	[Token(Token = "0x6005752")]
	[Address(RVA = "0xED2340", Offset = "0xED1140", Length = "0xF8")]
	public TODBlendState GetTODBlendState()
	{
		return default(TODBlendState);
	}

	[Token(Token = "0x6005753")]
	[Address(RVA = "0xED2440", Offset = "0xED1240", Length = "0x1EC")]
	public float GetTODBlendPercent(TODBlendState blendState)
	{
		return 0f;
	}

	[Token(Token = "0x6005754")]
	[Address(RVA = "0xED2650", Offset = "0xED1450", Length = "0x21")]
	private float GetBlendBiasWeightByWeather(WeatherStage stage)
	{
		return 0f;
	}

	[Token(Token = "0x6005755")]
	[Address(RVA = "0xED2680", Offset = "0xED1480", Length = "0xCC")]
	public float GetTODBlendBiased(TODBlendState blendState, float linearResult, float weatherBlend)
	{
		return 0f;
	}

	[Token(Token = "0x6005756")]
	[Address(RVA = "0xED2770", Offset = "0xED1570", Length = "0xD5")]
	public float GetSunShadowStrength()
	{
		return 0f;
	}

	[Token(Token = "0x6005757")]
	[Address(RVA = "0xED2850", Offset = "0xED1650", Length = "0x11")]
	public float GetElapsedHours()
	{
		return 0f;
	}

	[Token(Token = "0x6005758")]
	[Address(RVA = "0xED2870", Offset = "0xED1670", Length = "0x7C")]
	public void SetElapsedHours(float hours)
	{
	}

	[Token(Token = "0x6005759")]
	[Address(RVA = "0xED28F0", Offset = "0xED16F0", Length = "0x258")]
	public void RegisterSunShadowOverrideVolume(SunShadowOverrideVolume volume)
	{
	}

	[Token(Token = "0x600575A")]
	[Address(RVA = "0xED2B50", Offset = "0xED1950", Length = "0x85")]
	public void UnregisterSunShadowOverrideVolume(SunShadowOverrideVolume volume)
	{
	}

	[Token(Token = "0x600575B")]
	[Address(RVA = "0xED2BE0", Offset = "0xED19E0", Length = "0xB2E")]
	private void UpdateShadowStrength()
	{
	}

	[Token(Token = "0x600575C")]
	[Address(RVA = "0xED3710", Offset = "0xED2510", Length = "0xAC")]
	private float GetTimeOfDayIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x600575D")]
	[Address(RVA = "0xED37C0", Offset = "0xED25C0", Length = "0xAC")]
	public static void SendWeatherStateToWise(WeatherStage ws)
	{
	}

	[Token(Token = "0x600575E")]
	[Address(RVA = "0xED38A0", Offset = "0xED26A0", Length = "0x414")]
	public static WeatherStage WeatherNameToEnum(string weatherName)
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x600575F")]
	[Address(RVA = "0xED3CC0", Offset = "0xED2AC0", Length = "0x36")]
	public void TriggerAnimation(string triggerName)
	{
	}

	[Token(Token = "0x6005760")]
	[Address(RVA = "0x8F0890", Offset = "0x8EF690", Length = "0x52")]
	public void SetHorizonCloudsBand1Renderer(Renderer r)
	{
	}

	[Token(Token = "0x6005761")]
	[Address(RVA = "0xED3D00", Offset = "0xED2B00", Length = "0x52")]
	public void SetHorizonCloudsBand2Renderer(Renderer r)
	{
	}

	[Token(Token = "0x6005762")]
	[Address(RVA = "0xADC9A0", Offset = "0xADB7A0", Length = "0x52")]
	public void SetHorizonCloudsBand3Renderer(Renderer r)
	{
	}

	[Token(Token = "0x6005763")]
	[Address(RVA = "0x6CA000", Offset = "0x6C8E00", Length = "0x52")]
	public void SetHorizonGradRenderer(Renderer r)
	{
	}

	[Token(Token = "0x6005764")]
	[Address(RVA = "0xED3D60", Offset = "0xED2B60", Length = "0x52")]
	public void SetSkyCloudEdge1Renderer(Renderer r)
	{
	}

	[Token(Token = "0x6005765")]
	[Address(RVA = "0xED3DC0", Offset = "0xED2BC0", Length = "0x52")]
	public void SetSkyCloudEdge2Renderer(Renderer r)
	{
	}

	[Token(Token = "0x6005766")]
	[Address(RVA = "0x699260", Offset = "0x698060", Length = "0x8")]
	public ColorGradingSettings GetDefaultColorGradingSettings()
	{
		return null;
	}

	[Token(Token = "0x6005767")]
	[Address(RVA = "0xED3E20", Offset = "0xED2C20", Length = "0x8")]
	public GodrayManager GetGodrayManager()
	{
		return null;
	}

	[Token(Token = "0x6005768")]
	[Address(RVA = "0xED3E30", Offset = "0xED2C30", Length = "0x45")]
	public bool ApproximateColorMatch(Color a, Color b, float margin)
	{
		return false;
	}

	[Token(Token = "0x6005769")]
	[Address(RVA = "0xED3E80", Offset = "0xED2C80", Length = "0x54")]
	private int GetIndexOfWeatherStage(WeatherStage stage)
	{
		return 0;
	}

	[Token(Token = "0x600576A")]
	[Address(RVA = "0xED3EE0", Offset = "0xED2CE0", Length = "0x256")]
	public UniStormWeatherSystem()
	{
	}
}
