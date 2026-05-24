using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x20002F9")]
public class ExteriorLightingManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20002FA")]
	public struct LightmapRendererDefinition
	{
		[Token(Token = "0x4001A42")]
		[FieldOffset(Offset = "0x0")]
		public Renderer m_Renderer;

		[Token(Token = "0x4001A43")]
		[FieldOffset(Offset = "0x8")]
		public Texture2D m_Lightmap;
	}

	[Serializable]
	[Token(Token = "0x20002FB")]
	public class LightGroup
	{
		[HideInInspector]
		[Token(Token = "0x4001A44")]
		[FieldOffset(Offset = "0x10")]
		public string m_Name;

		[Token(Token = "0x4001A45")]
		[FieldOffset(Offset = "0x18")]
		public Transform m_GroupParent;

		[Token(Token = "0x4001A46")]
		[FieldOffset(Offset = "0x20")]
		public bool m_UseIntensityFromTODState;

		[Token(Token = "0x4001A47")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve m_TODIntensityCurve;

		[Range(0f, 1f)]
		[Token(Token = "0x4001A48")]
		[FieldOffset(Offset = "0x30")]
		public float m_AmbientColorBlend;

		[Range(0f, 1f)]
		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x34")]
		public float m_AmbientColorAdd;

		[Header("Lightmapping")]
		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x38")]
		public Transform m_LightmappedMeshParent;

		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x40")]
		public bool m_UseBakedAmbientColor;

		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x44")]
		public Color m_BakedAmbientColor;

		[ColorUsage(false, true)]
		[Token(Token = "0x4001A4D")]
		[FieldOffset(Offset = "0x54")]
		public Color m_LightmapColor;

		[ColorUsage(false, true)]
		[Token(Token = "0x4001A4E")]
		[FieldOffset(Offset = "0x64")]
		public Color m_MinLightmapColor;

		[Header("Auto-populated lists from children of Group Parent")]
		[Token(Token = "0x4001A4F")]
		[FieldOffset(Offset = "0x78")]
		public DarkLightingManager.LightDef[] m_Lights;

		[Token(Token = "0x4001A50")]
		[FieldOffset(Offset = "0x80")]
		public DarkLightingManager.ParticleDef[] m_Particles;

		[Token(Token = "0x4001A51")]
		[FieldOffset(Offset = "0x88")]
		public DarkLightingManager.GlowObjectDef[] m_GlowCards;

		[Token(Token = "0x4001A52")]
		[FieldOffset(Offset = "0x90")]
		public LightmapRendererDefinition[] m_LightmappedRenderers;

		[Token(Token = "0x4001A53")]
		[FieldOffset(Offset = "0x98")]
		public Texture2D[] m_Lightmaps;

		[Token(Token = "0x4001A54")]
		[FieldOffset(Offset = "0xA0")]
		public float[] m_ProbeData;

		[NonSerialized]
		[Token(Token = "0x4001A55")]
		[FieldOffset(Offset = "0xA8")]
		public Dictionary<Texture2D, HashSet<Renderer>> m_LightmapToRenderers;

		[Token(Token = "0x600189A")]
		[Address(RVA = "0x6F47C0", Offset = "0x6F35C0", Length = "0xB8")]
		public LightGroup()
		{
		}
	}

	[Token(Token = "0x4001A27")]
	[FieldOffset(Offset = "0x20")]
	public bool m_IsInLightmapMode;

	[SerializeField]
	[Token(Token = "0x4001A28")]
	[FieldOffset(Offset = "0x28")]
	private LightGroup[] m_LightGroups;

	[Header("Probes in these groups will be forced to take on ambient light and not the baked values")]
	[SerializeField]
	[Token(Token = "0x4001A29")]
	[FieldOffset(Offset = "0x30")]
	private LightProbeGroup[] m_ExteriorProbeGroups;

	[Header("Anchor point for referencing ambient light for all non-lightmapped static geo")]
	[SerializeField]
	[Token(Token = "0x4001A2A")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_AmbientProbeAnchor;

	[Header("Top level transforms for non-lightmapped static geo")]
	[SerializeField]
	[Token(Token = "0x4001A2B")]
	[FieldOffset(Offset = "0x40")]
	private Transform[] m_UnlitStaticGeoRoots;

	[Header("The following components will be auto-populated with:", order = 0)]
	[Header("Lights from the light groups", order = 1)]
	[SerializeField]
	[Token(Token = "0x4001A2C")]
	[FieldOffset(Offset = "0x48")]
	private LightDistanceCull m_LightCullComponent;

	[Header("Particles from the light groups")]
	[SerializeField]
	[Token(Token = "0x4001A2D")]
	[FieldOffset(Offset = "0x50")]
	private ParticleDistanceCull m_ParticleCullComponent;

	[Token(Token = "0x4001A2E")]
	public static bool s_DebugProbeUpdatesDisabled;

	[Token(Token = "0x4001A2F")]
	private const int SH_BANDS = 3;

	[Token(Token = "0x4001A30")]
	private const int SH_COEFFICIENTS = 9;

	[Token(Token = "0x4001A31")]
	private const float PROBE_UPDATE_PER_FRAME_MS = 0.2f;

	[Token(Token = "0x4001A32")]
	private const float LIGHTMAP_INTENSITY_UPDATE_THRESHOLD = 0.005f;

	[Token(Token = "0x4001A33")]
	private const string BAKE_DIALOG_TITLE = "Baking Lightmaps";

	[Token(Token = "0x4001A34")]
	private static readonly int s_LightingStrengthPropertyID;

	[Token(Token = "0x4001A35")]
	private static readonly int s_TintColorPropertyID;

	[Token(Token = "0x4001A36")]
	[FieldOffset(Offset = "0x58")]
	private MaterialPropertyBlock m_PropertyBlock;

	[Token(Token = "0x4001A37")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<Texture2D, int> m_LightmapIndices;

	[Token(Token = "0x4001A38")]
	[FieldOffset(Offset = "0x68")]
	private LightGroup m_LastLightmapGroup;

	[Token(Token = "0x4001A39")]
	[FieldOffset(Offset = "0x70")]
	private float m_LastLightmapIntensity;

	[Token(Token = "0x4001A3A")]
	private static ExteriorLightingManager s_ProbeManager;

	[Token(Token = "0x4001A3B")]
	[FieldOffset(Offset = "0x78")]
	private LightGroup m_ProbeGroup;

	[Token(Token = "0x4001A3C")]
	[FieldOffset(Offset = "0x80")]
	private float m_ProbeIntensity;

	[Token(Token = "0x4001A3D")]
	[FieldOffset(Offset = "0x88")]
	private SphericalHarmonicsL2[] m_Probes;

	[Token(Token = "0x4001A3E")]
	[FieldOffset(Offset = "0x90")]
	private bool m_ShouldAssignAmbientProbeAnchor;

	[Token(Token = "0x4001A3F")]
	[FieldOffset(Offset = "0x94")]
	private int m_LastProbeUpdateIndex;

	[Token(Token = "0x4001A40")]
	[FieldOffset(Offset = "0x98")]
	private Stopwatch m_ProbeUpdateStopWatch;

	[Token(Token = "0x4001A41")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_UpdateAllProbes;

	[Token(Token = "0x600188D")]
	[Address(RVA = "0x6F0FE0", Offset = "0x6EFDE0", Length = "0xE")]
	public int GetLightGroupCount()
	{
		return 0;
	}

	[Token(Token = "0x600188E")]
	[Address(RVA = "0x6F0FF0", Offset = "0x6EFDF0", Length = "0x14B")]
	public static void MarkProbesDirty()
	{
	}

	[Token(Token = "0x600188F")]
	[Address(RVA = "0x6F1140", Offset = "0x6EFF40", Length = "0xD01")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001890")]
	[Address(RVA = "0x6F1E50", Offset = "0x6F0C50", Length = "0x1C2")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001891")]
	[Address(RVA = "0x6F2020", Offset = "0x6F0E20", Length = "0x79F")]
	private void Update()
	{
	}

	[Token(Token = "0x6001892")]
	[Address(RVA = "0x6F27C0", Offset = "0x6F15C0", Length = "0x2BF")]
	private void MaybeAssignAmbientProbeAnchor()
	{
	}

	[Token(Token = "0x6001893")]
	[Address(RVA = "0x6F2A80", Offset = "0x6F1880", Length = "0x6C6")]
	private void UpdateLightProbes()
	{
	}

	[Token(Token = "0x6001894")]
	[Address(RVA = "0x6F3150", Offset = "0x6F1F50", Length = "0x922")]
	private void BlendLightmaps(Dictionary<Texture2D, HashSet<Renderer>> lightmapsToRenderers, float intensity, Color lightmapColor, Color minLightmapColor)
	{
	}

	[Token(Token = "0x6001895")]
	[Address(RVA = "0x6F3A80", Offset = "0x6F2880", Length = "0x4AC")]
	private void BlendLightProperties(DarkLightingManager.LightDef[] lightDefinitions, float intensity, Color ambientColor, float ambientColorBlend, float ambientColorAdd)
	{
	}

	[Token(Token = "0x6001896")]
	[Address(RVA = "0x6F3F30", Offset = "0x6F2D30", Length = "0x26B")]
	private void BlendParticleProperties(DarkLightingManager.ParticleDef[] particleDefinitions, float intensity)
	{
	}

	[Token(Token = "0x6001897")]
	[Address(RVA = "0x6F41A0", Offset = "0x6F2FA0", Length = "0x492")]
	private void BlendGlowCardProperties(DarkLightingManager.GlowObjectDef[] glowCardDefinitions, float intensity, Color ambientColor, float ambientColorBlend, float ambientColorAdd)
	{
	}

	[Token(Token = "0x6001898")]
	[Address(RVA = "0x6F4640", Offset = "0x6F3440", Length = "0xE3")]
	public ExteriorLightingManager()
	{
	}
}
