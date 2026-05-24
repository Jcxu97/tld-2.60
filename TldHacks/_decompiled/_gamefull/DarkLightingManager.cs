using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002EE")]
public class DarkLightingManager : MonoBehaviour
{
	[Token(Token = "0x20002EF")]
	private readonly struct LightSoA
	{
		[Token(Token = "0x40019EF")]
		[FieldOffset(Offset = "0x0")]
		private readonly float[] m_TimeDelays;

		[Token(Token = "0x40019F0")]
		[FieldOffset(Offset = "0x8")]
		private readonly Vector3[] m_Positions;

		[Token(Token = "0x40019F1")]
		[FieldOffset(Offset = "0x10")]
		private readonly Light[] m_Lights;

		[Token(Token = "0x40019F2")]
		[FieldOffset(Offset = "0x18")]
		private readonly UpdatePhase[] m_LightUpdatePhases;

		[Token(Token = "0x40019F3")]
		[FieldOffset(Offset = "0x20")]
		private readonly float[] m_OriginalIntensities;

		[Token(Token = "0x40019F4")]
		[FieldOffset(Offset = "0x28")]
		private readonly float[] m_PrevIntensities;

		[Token(Token = "0x40019F5")]
		[FieldOffset(Offset = "0x30")]
		private readonly Color[] m_OriginalColours;

		[Token(Token = "0x40019F6")]
		[FieldOffset(Offset = "0x38")]
		private readonly bool[] m_PreviousStates;

		[Token(Token = "0x6001878")]
		[Address(RVA = "0x6EDBD0", Offset = "0x6EC9D0", Length = "0x3AE")]
		public LightSoA(int size)
		{
			m_TimeDelays = null;
			m_Positions = null;
			m_Lights = null;
			m_LightUpdatePhases = null;
			m_OriginalIntensities = null;
			m_PrevIntensities = null;
			m_OriginalColours = null;
			m_PreviousStates = null;
		}

		[Token(Token = "0x6001879")]
		[Address(RVA = "0x6EDF80", Offset = "0x6ECD80", Length = "0x388")]
		public void AddLight(Light l, int i, UpdatePhase type)
		{
		}

		[Token(Token = "0x600187A")]
		[Address(RVA = "0x6EE310", Offset = "0x6ED110", Length = "0x6A5")]
		public void UpdateLights(Vector3 camPos, float deltaTime, float maxDistSqr, float fadeDistSqr, float maxTimeDelay, Color sunColour, float sunIntensity, float sunAverage, float todIntensity, float auroraFade, float lightColourization)
		{
		}
	}

	[Token(Token = "0x20002F0")]
	private readonly struct ParticleSoA
	{
		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x0")]
		private readonly float[] m_TimeDelays;

		[Token(Token = "0x40019F8")]
		[FieldOffset(Offset = "0x8")]
		private readonly Vector3[] m_Positions;

		[Token(Token = "0x40019F9")]
		[FieldOffset(Offset = "0x10")]
		private readonly ParticleSystem[] m_Particles;

		[Token(Token = "0x40019FA")]
		[FieldOffset(Offset = "0x18")]
		private readonly float[] m_OriginalRate;

		[Token(Token = "0x40019FB")]
		[FieldOffset(Offset = "0x20")]
		private readonly bool[] m_PreviousStates;

		[Token(Token = "0x600187B")]
		[Address(RVA = "0x6EE9C0", Offset = "0x6ED7C0", Length = "0x26E")]
		public ParticleSoA(int size)
		{
			m_TimeDelays = null;
			m_Positions = null;
			m_Particles = null;
			m_OriginalRate = null;
			m_PreviousStates = null;
		}

		[Token(Token = "0x600187C")]
		[Address(RVA = "0x6EEC30", Offset = "0x6EDA30", Length = "0x2BA")]
		public void AddParticle(ParticleSystem ps, int i)
		{
		}

		[Token(Token = "0x600187D")]
		[Address(RVA = "0x6EEEF0", Offset = "0x6EDCF0", Length = "0x386")]
		public void UpdateParticles(Vector3 camPos, float deltaTime, float maxDistSqr, float fadeDistSqr, float maxTimeDelay, float todIntensity)
		{
		}
	}

	[Token(Token = "0x20002F1")]
	private readonly struct GimbleSoA
	{
		[Token(Token = "0x40019FC")]
		[FieldOffset(Offset = "0x0")]
		private readonly float[] m_TimeDelays;

		[Token(Token = "0x40019FD")]
		[FieldOffset(Offset = "0x8")]
		private readonly Vector3[] m_Positions;

		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x10")]
		private readonly LightShaftGimble[] m_Gimbles;

		[Token(Token = "0x600187E")]
		[Address(RVA = "0x6EF280", Offset = "0x6EE080", Length = "0x19E")]
		public GimbleSoA(int size)
		{
			m_TimeDelays = null;
			m_Positions = null;
			m_Gimbles = null;
		}

		[Token(Token = "0x600187F")]
		[Address(RVA = "0x6EF420", Offset = "0x6EE220", Length = "0x208")]
		public void AddGimble(LightShaftGimble g, int i)
		{
		}

		[Token(Token = "0x6001880")]
		[Address(RVA = "0x6EF630", Offset = "0x6EE430", Length = "0x2AF")]
		public void UpdateGimbles(Vector3 camPos, float deltaTime, float maxDistSqr, float fadeDistSqr, float maxTimeDelay, float sunAverage, float todIntensity, float lightColourization, float normalizedTod)
		{
		}
	}

	[Token(Token = "0x20002F2")]
	private readonly struct GlowSoA
	{
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x0")]
		private readonly float[] m_TimeDelays;

		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x8")]
		private readonly Vector3[] m_Positions;

		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x10")]
		private readonly Renderer[] m_Renderers;

		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x18")]
		private readonly Color[] m_OriginalColours;

		[Token(Token = "0x6001881")]
		[Address(RVA = "0x6EF8E0", Offset = "0x6EE6E0", Length = "0x20E")]
		public GlowSoA(int size)
		{
			m_TimeDelays = null;
			m_Positions = null;
			m_Renderers = null;
			m_OriginalColours = null;
		}

		[Token(Token = "0x6001882")]
		[Address(RVA = "0x6EFAF0", Offset = "0x6EE8F0", Length = "0x27C")]
		public void AddGlow(Renderer r, int i)
		{
		}

		[Token(Token = "0x6001883")]
		[Address(RVA = "0x6EFD70", Offset = "0x6EEB70", Length = "0x4CE")]
		public void UpdateGlows(Vector3 camPos, float deltaTime, float maxDistSqr, float fadeDistSqr, float maxTimeDelay, Color sunColour, float sunIntensity, float todIntensity, float auroraFade, float glowColourization, MaterialPropertyBlock glowObjectPropertyBlock)
		{
		}
	}

	[Token(Token = "0x20002F3")]
	public enum UpdatePhase
	{
		[Token(Token = "0x4001A04")]
		Constant,
		[Token(Token = "0x4001A05")]
		Coloured,
		[Token(Token = "0x4001A06")]
		Night,
		[Token(Token = "0x4001A07")]
		NonTOD,
		[Token(Token = "0x4001A08")]
		Other
	}

	[Serializable]
	[Token(Token = "0x20002F4")]
	public struct LightDef
	{
		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x0")]
		public Light m_Light;

		[Token(Token = "0x4001A0A")]
		[FieldOffset(Offset = "0x8")]
		public float m_OrgIntensity;

		[Token(Token = "0x4001A0B")]
		[FieldOffset(Offset = "0xC")]
		public Color m_OrgColour;

		[Token(Token = "0x4001A0C")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 m_Position;
	}

	[Serializable]
	[Token(Token = "0x20002F5")]
	public struct ParticleDef
	{
		[Token(Token = "0x4001A0D")]
		[FieldOffset(Offset = "0x0")]
		public ParticleSystem m_Fx;

		[Token(Token = "0x4001A0E")]
		[FieldOffset(Offset = "0x8")]
		public float m_OrgRate;
	}

	[Serializable]
	[Token(Token = "0x20002F6")]
	public struct GlowObjectDef
	{
		[Token(Token = "0x4001A0F")]
		[FieldOffset(Offset = "0x0")]
		public Renderer m_Renderer;

		[Token(Token = "0x4001A10")]
		[FieldOffset(Offset = "0x8")]
		public Color m_OrgColour;
	}

	[Header("Editor tools")]
	[Token(Token = "0x40019A7")]
	[FieldOffset(Offset = "0x20")]
	public bool m_ForceClearWeather;

	[Token(Token = "0x40019A8")]
	[FieldOffset(Offset = "0x21")]
	public bool m_ManualLighting;

	[Range(0f, 24f)]
	[Token(Token = "0x40019A9")]
	[FieldOffset(Offset = "0x24")]
	public float m_TimeOfDay;

	[Header("Parent objects")]
	[Tooltip("Lights affected by time of day only.")]
	[Token(Token = "0x40019AA")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_ConstantLights;

	[Tooltip("Lights affected by time of day, or sun colour.")]
	[Token(Token = "0x40019AB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_ColourizedLights;

	[Tooltip("Lights that are only on during the night.")]
	[Token(Token = "0x40019AC")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_NightLights;

	[Token(Token = "0x40019AD")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_Particles;

	[Token(Token = "0x40019AE")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_Lightshafts;

	[Header("Individual objects")]
	[Token(Token = "0x40019AF")]
	[FieldOffset(Offset = "0x50")]
	public List<MeshRenderer> m_GlowObjects;

	[Token(Token = "0x40019B0")]
	[FieldOffset(Offset = "0x58")]
	public MeshRenderer m_FakeSky;

	[Token(Token = "0x40019B1")]
	[FieldOffset(Offset = "0x60")]
	public InteriorWeatherController m_InteriorWeatherController;

	[Header("Adjustments")]
	[Tooltip("Glow objects only: How much sun colour to apply")]
	[Range(0f, 1f)]
	[Token(Token = "0x40019B2")]
	[FieldOffset(Offset = "0x68")]
	public float m_GlowColorization;

	[Tooltip("Coloured light only: Controls how much of the sun and aurora colours are applied to the lights")]
	[Range(0f, 1f)]
	[Token(Token = "0x40019B3")]
	[FieldOffset(Offset = "0x6C")]
	public float m_LightColorization;

	[Tooltip("Lightmaps Only: How much aurora colours to apply")]
	[Range(0f, 1f)]
	[Token(Token = "0x40019B4")]
	[FieldOffset(Offset = "0x70")]
	public float m_AuroraColorization;

	[Token(Token = "0x40019B5")]
	[FieldOffset(Offset = "0x74")]
	public float m_AuroraRed;

	[Token(Token = "0x40019B6")]
	[FieldOffset(Offset = "0x78")]
	public float m_AuroraGreen;

	[Token(Token = "0x40019B7")]
	[FieldOffset(Offset = "0x7C")]
	public float m_AuroraBlue;

	[Token(Token = "0x40019B8")]
	[FieldOffset(Offset = "0x80")]
	public float m_SunIntensityCorrection;

	[Token(Token = "0x40019B9")]
	[FieldOffset(Offset = "0x84")]
	public bool m_CorrectSunIntensity;

	[Header("Lightmap controls")]
	[ColorUsage(false, true)]
	[Token(Token = "0x40019BA")]
	[FieldOffset(Offset = "0x88")]
	public Color m_LightmapDayColorMultiplier;

	[ColorUsage(false, true)]
	[Token(Token = "0x40019BB")]
	[FieldOffset(Offset = "0x98")]
	public Color m_LightmapNightColorMultiplier;

	[Tooltip("Components listed here will override the lightmap color regardless of time of day, if they are active/enabled. Prioritized from first to last array entry")]
	[SerializeField]
	[Token(Token = "0x40019BC")]
	[FieldOffset(Offset = "0xA8")]
	private LightmapColorOverride[] m_LightmapColorOverrides;

	[Header("Performance tunables")]
	[Tooltip("Use time delay logic for large scenes and update everything every frame based on distance to the player, otherwise use legacy frame staggered updated")]
	[SerializeField]
	[Token(Token = "0x40019BD")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_UseTimeDelay;

	[SerializeField]
	[Token(Token = "0x40019BE")]
	[FieldOffset(Offset = "0xB4")]
	private float m_MaxTimeDelay;

	[Tooltip("Fade intensities out to the maximum distance. Time delay updates always forces fading")]
	[Token(Token = "0x40019BF")]
	[FieldOffset(Offset = "0xB8")]
	public bool m_UseDistanceFade;

	[Tooltip("Lights not needing Time Of Day, but still need tracking for performance")]
	[Token(Token = "0x40019C0")]
	[FieldOffset(Offset = "0xC0")]
	public List<Light> m_NonTodLights;

	[Token(Token = "0x40019C1")]
	[FieldOffset(Offset = "0xC8")]
	public float m_UltraDistance;

	[Token(Token = "0x40019C2")]
	[FieldOffset(Offset = "0xCC")]
	public float m_HighDistance;

	[Token(Token = "0x40019C3")]
	[FieldOffset(Offset = "0xD0")]
	public float m_MediumDistance;

	[Token(Token = "0x40019C4")]
	[FieldOffset(Offset = "0xD4")]
	public float m_LowDistance;

	[Header("Fade lights n% from maximum distance.")]
	[Token(Token = "0x40019C5")]
	[FieldOffset(Offset = "0xD8")]
	public float m_FadePercentage;

	[Token(Token = "0x40019C6")]
	[FieldOffset(Offset = "0xE0")]
	private TodAmbientLight m_AmbientLight;

	[Token(Token = "0x40019C7")]
	[FieldOffset(Offset = "0xE8")]
	private List<LightDef> m_ConstantLightList;

	[Token(Token = "0x40019C8")]
	[FieldOffset(Offset = "0xF0")]
	private List<LightDef> m_ColouredLightList;

	[Token(Token = "0x40019C9")]
	[FieldOffset(Offset = "0xF8")]
	private List<LightDef> m_NightLightList;

	[Token(Token = "0x40019CA")]
	[FieldOffset(Offset = "0x100")]
	private List<LightDef> m_NonTodLightList;

	[Token(Token = "0x40019CB")]
	[FieldOffset(Offset = "0x108")]
	private List<ParticleDef> m_ParticleList;

	[Token(Token = "0x40019CC")]
	[FieldOffset(Offset = "0x110")]
	private List<GlowObjectDef> m_GlowObjectList;

	[Token(Token = "0x40019CD")]
	[FieldOffset(Offset = "0x118")]
	private List<LightShaftGimble> m_LightShaftList;

	[Token(Token = "0x40019CE")]
	[FieldOffset(Offset = "0x120")]
	private GlowObjectDef m_FakeSkyMat;

	[Token(Token = "0x40019CF")]
	[FieldOffset(Offset = "0x138")]
	private LightSoA m_LightTimeDelayed;

	[Token(Token = "0x40019D0")]
	[FieldOffset(Offset = "0x178")]
	private ParticleSoA m_ParticlesTimeDelayed;

	[Token(Token = "0x40019D1")]
	[FieldOffset(Offset = "0x1A0")]
	private GimbleSoA m_GimbleTimeDelayed;

	[Token(Token = "0x40019D2")]
	[FieldOffset(Offset = "0x1B8")]
	private GlowSoA m_GlowTimeDelayed;

	[Token(Token = "0x40019D3")]
	[FieldOffset(Offset = "0x1D8")]
	private MaterialPropertyBlock m_GlowObjectPropertyBlock;

	[Token(Token = "0x40019D4")]
	[FieldOffset(Offset = "0x1E0")]
	private MaterialPropertyBlock m_FakeSkyPropertyBlock;

	[Token(Token = "0x40019D5")]
	[FieldOffset(Offset = "0x1E8")]
	private WeatherStage m_PrevWeatherStage;

	[Token(Token = "0x40019D6")]
	[FieldOffset(Offset = "0x1EC")]
	private Color m_SunColour;

	[Token(Token = "0x40019D7")]
	[FieldOffset(Offset = "0x1FC")]
	private float m_SunIntensity;

	[Token(Token = "0x40019D8")]
	[FieldOffset(Offset = "0x200")]
	private float m_SunAverage;

	[Token(Token = "0x40019D9")]
	[FieldOffset(Offset = "0x204")]
	private float m_TodIntensity;

	[Token(Token = "0x40019DA")]
	[FieldOffset(Offset = "0x208")]
	private float m_AuroraFade;

	[Token(Token = "0x40019DB")]
	[FieldOffset(Offset = "0x20C")]
	private float m_StarAlpha;

	[Token(Token = "0x40019DC")]
	[FieldOffset(Offset = "0x210")]
	private float m_MaxDistSqr;

	[Token(Token = "0x40019DD")]
	[FieldOffset(Offset = "0x214")]
	private float m_FadeDistSqr;

	[Token(Token = "0x40019DE")]
	[FieldOffset(Offset = "0x218")]
	private ScaledCurve m_DawnMorning;

	[Token(Token = "0x40019DF")]
	[FieldOffset(Offset = "0x220")]
	private ScaledCurve m_MorningMidday;

	[Token(Token = "0x40019E0")]
	[FieldOffset(Offset = "0x228")]
	private ScaledCurve m_MiddayAfternoon;

	[Token(Token = "0x40019E1")]
	[FieldOffset(Offset = "0x230")]
	private ScaledCurve m_AfternoonDusk;

	[Token(Token = "0x40019E2")]
	[FieldOffset(Offset = "0x238")]
	private UpdatePhase m_CurPhase;

	[Token(Token = "0x40019E3")]
	[FieldOffset(Offset = "0x23C")]
	private QualityLodBias m_CachedQuality;

	[Token(Token = "0x40019E4")]
	[FieldOffset(Offset = "0x240")]
	private bool m_Initialized;

	[Token(Token = "0x40019E5")]
	[FieldOffset(Offset = "0x241")]
	private bool m_HasLights;

	[Token(Token = "0x40019E6")]
	[FieldOffset(Offset = "0x242")]
	private bool m_HasParticles;

	[Token(Token = "0x40019E7")]
	[FieldOffset(Offset = "0x243")]
	private bool m_HasGlowObjects;

	[Token(Token = "0x40019E8")]
	[FieldOffset(Offset = "0x244")]
	private bool m_HasLightShafts;

	[Token(Token = "0x40019E9")]
	private static readonly int s_ColorPropertyID;

	[Token(Token = "0x40019EA")]
	private static readonly int s_EmissiveStrengthPropertyID;

	[Token(Token = "0x40019EB")]
	private static readonly int s_SkyEmissivePropertyID;

	[Token(Token = "0x40019EC")]
	private static readonly int s_StarsEmissivePropertyID;

	[Token(Token = "0x40019ED")]
	private static readonly int s_TodBlendPropertyID;

	[Token(Token = "0x40019EE")]
	private static readonly float oneThird;

	[Token(Token = "0x6001859")]
	[Address(RVA = "0x6E6230", Offset = "0x6E5030", Length = "0x2AF")]
	private void Start()
	{
	}

	[Token(Token = "0x600185A")]
	[Address(RVA = "0x6E64E0", Offset = "0x6E52E0", Length = "0x45")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600185B")]
	[Address(RVA = "0x6E6530", Offset = "0x6E5330", Length = "0x1BC")]
	private void FindAmbientLighting()
	{
	}

	[Token(Token = "0x600185C")]
	[Address(RVA = "0x6E66F0", Offset = "0x6E54F0", Length = "0x6F2")]
	private void FindAllLights()
	{
	}

	[Token(Token = "0x600185D")]
	[Address(RVA = "0x6E6DF0", Offset = "0x6E5BF0", Length = "0x6C1")]
	private void FindConstantLights()
	{
	}

	[Token(Token = "0x600185E")]
	[Address(RVA = "0x6E74C0", Offset = "0x6E62C0", Length = "0x54B")]
	private void FindColourizedLights()
	{
	}

	[Token(Token = "0x600185F")]
	[Address(RVA = "0x6E7A10", Offset = "0x6E6810", Length = "0x54B")]
	private void FindNightLights()
	{
	}

	[Token(Token = "0x6001860")]
	[Address(RVA = "0x6E7F60", Offset = "0x6E6D60", Length = "0x4EA")]
	private void FindOtherLights()
	{
	}

	[Token(Token = "0x6001861")]
	[Address(RVA = "0x6E8450", Offset = "0x6E7250", Length = "0x5AE")]
	private void FindParticles()
	{
	}

	[Token(Token = "0x6001862")]
	[Address(RVA = "0x6E8A00", Offset = "0x6E7800", Length = "0x9A3")]
	private void FindGlowObjects()
	{
	}

	[Token(Token = "0x6001863")]
	[Address(RVA = "0x6E93B0", Offset = "0x6E81B0", Length = "0x43F")]
	private void FindGimbleObjects()
	{
	}

	[Token(Token = "0x6001864")]
	[Address(RVA = "0x6E97F0", Offset = "0x6E85F0", Length = "0x7C")]
	private void UpdateQualityValues()
	{
	}

	[Token(Token = "0x6001865")]
	[Address(RVA = "0x6E9870", Offset = "0x6E8670", Length = "0x62D")]
	private void Update()
	{
	}

	[Token(Token = "0x6001866")]
	[Address(RVA = "0x6E9EA0", Offset = "0x6E8CA0", Length = "0x52D")]
	private void UpdateIntensities()
	{
	}

	[Token(Token = "0x6001867")]
	[Address(RVA = "0x6EA3D0", Offset = "0x6E91D0", Length = "0xF6")]
	private void UpdateAmbient()
	{
	}

	[Token(Token = "0x6001868")]
	[Address(RVA = "0x6EA4D0", Offset = "0x6E92D0", Length = "0x672")]
	private void UpdateConstantLights()
	{
	}

	[Token(Token = "0x6001869")]
	[Address(RVA = "0x6EAB50", Offset = "0x6E9950", Length = "0x374")]
	private void UpdateLightmaps()
	{
	}

	[Token(Token = "0x600186A")]
	[Address(RVA = "0x6EAED0", Offset = "0x6E9CD0", Length = "0xBBB")]
	private void UpdateColouredLights()
	{
	}

	[Token(Token = "0x600186B")]
	[Address(RVA = "0x6EBA90", Offset = "0x6EA890", Length = "0x64A")]
	private void UpdateNightLights()
	{
	}

	[Token(Token = "0x600186C")]
	[Address(RVA = "0x6EC0E0", Offset = "0x6EAEE0", Length = "0x50E")]
	private void UpdateNonTodLights()
	{
	}

	[Token(Token = "0x600186D")]
	[Address(RVA = "0x6EC5F0", Offset = "0x6EB3F0", Length = "0x8DE")]
	private void UpdateGlowObjects()
	{
	}

	[Token(Token = "0x600186E")]
	[Address(RVA = "0x6ECED0", Offset = "0x6EBCD0", Length = "0x1ED")]
	private void UpdateGimbles()
	{
	}

	[Token(Token = "0x600186F")]
	[Address(RVA = "0x6ED0C0", Offset = "0x6EBEC0", Length = "0x1DF")]
	private void UpdateParticles()
	{
	}

	[Token(Token = "0x6001870")]
	[Address(RVA = "0x6ED2A0", Offset = "0x6EC0A0", Length = "0xBA")]
	private Color GetAuroraColours()
	{
		return default(Color);
	}

	[Token(Token = "0x6001871")]
	[Address(RVA = "0x6ED360", Offset = "0x6EC160", Length = "0x87")]
	private float GetSunAverage(Color col, float lum)
	{
		return 0f;
	}

	[Token(Token = "0x6001872")]
	[Address(RVA = "0x6ED3F0", Offset = "0x6EC1F0", Length = "0x101")]
	private float GetTimeOfDayIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6001873")]
	[Address(RVA = "0x6ED500", Offset = "0x6EC300", Length = "0xE")]
	private float NormalizedTod()
	{
		return 0f;
	}

	[Token(Token = "0x6001874")]
	[Address(RVA = "0x6ED510", Offset = "0x6EC310", Length = "0x1F")]
	private static float DistanceToPlayer(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	[Token(Token = "0x6001875")]
	[Address(RVA = "0x6ED530", Offset = "0x6EC330", Length = "0x137")]
	private void MaybeSetInteriorWeather()
	{
	}

	[Token(Token = "0x6001876")]
	[Address(RVA = "0x6ED670", Offset = "0x6EC470", Length = "0x42C")]
	public DarkLightingManager()
	{
	}
}
