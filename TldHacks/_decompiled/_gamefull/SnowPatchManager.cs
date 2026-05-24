using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2000959")]
public class SnowPatchManager : MonoBehaviour
{
	[Token(Token = "0x40060DE")]
	public const int MAX_ACTIVE_PATCHES_LOW = 200;

	[Token(Token = "0x40060DF")]
	public const int MAX_ACTIVE_PATCHES_MEDIUM = 250;

	[Token(Token = "0x40060E0")]
	public const int MAX_ACTIVE_PATCHES_HIGH = 300;

	[Token(Token = "0x40060E1")]
	public const int MAX_ACTIVE_PATCHES_ULTRA = 400;

	[Token(Token = "0x40060E2")]
	public const int MAX_PATCHES_ADDED_PER_FRAME = 1;

	[Token(Token = "0x40060E3")]
	public const float SNOW_PATCH_BOUNDS_SIZE = 2f;

	[Token(Token = "0x40060E4")]
	public const float SNOW_PATCH_HM_POS_SCALE = 0.5f;

	[Token(Token = "0x40060E5")]
	public const float SNOW_PATCH_BOUNDS_SIZE_HALF = 1f;

	[Token(Token = "0x40060E6")]
	public const float SNOW_PATCH_BOUNDS_SCALE = 0.5f;

	[Token(Token = "0x40060E7")]
	public const int PATCH_HIGH_RES_SUBDIVS = 80;

	[Token(Token = "0x40060E8")]
	public const int PATCH_MEDIUM_RES_SUBDIVS = 50;

	[Token(Token = "0x40060E9")]
	public const int PATCH_LOW_RES_SUBDIVS = 30;

	[Token(Token = "0x40060EA")]
	public const float HIGH_RES_PATCH_STEP = 1f / 79f;

	[Token(Token = "0x40060EB")]
	public const float MED_RES_PATCH_STEP = 1f / 49f;

	[Token(Token = "0x40060EC")]
	public const float LOW_RES_PATCH_STEP = 1f / 29f;

	[Token(Token = "0x40060ED")]
	public static bool m_Active;

	[SerializeField]
	[Token(Token = "0x40060EE")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Header("Debug")]
	[Token(Token = "0x40060EF")]
	[FieldOffset(Offset = "0x28")]
	public bool m_DebugSkipHeightMapRendering;

	[Token(Token = "0x40060F0")]
	[FieldOffset(Offset = "0x29")]
	public bool m_DebugSkipBumppedDecalRendering;

	[Range(0f, 0.25f)]
	[Token(Token = "0x40060F1")]
	[FieldOffset(Offset = "0x2C")]
	public float m_DebugForcedImprintDepth;

	[Token(Token = "0x40060F2")]
	[FieldOffset(Offset = "0x30")]
	public bool m_DebugShowBounds;

	[Token(Token = "0x40060F3")]
	[FieldOffset(Offset = "0x31")]
	public bool m_DebugShowPatches;

	[Header("Settings - Shared")]
	[Range(0f, 0.4f)]
	[Token(Token = "0x40060F4")]
	[FieldOffset(Offset = "0x34")]
	public float m_MaxImprintDepth;

	[Range(1f, 5.9f)]
	[Token(Token = "0x40060F5")]
	[FieldOffset(Offset = "0x38")]
	public float m_BumpedDecalFillInRateScalar;

	[Range(0f, 100f)]
	[Token(Token = "0x40060F6")]
	[FieldOffset(Offset = "0x3C")]
	public float m_NormalPowLow;

	[Range(0f, 100f)]
	[Token(Token = "0x40060F7")]
	[FieldOffset(Offset = "0x40")]
	public float m_NormalPowHigh;

	[Range(0f, 30f)]
	[Token(Token = "0x40060F8")]
	[FieldOffset(Offset = "0x44")]
	public float m_TopBlendScalarLow;

	[Range(0f, 30f)]
	[Token(Token = "0x40060F9")]
	[FieldOffset(Offset = "0x48")]
	public float m_TopBlendScalarHigh;

	[Range(0f, 100f)]
	[Token(Token = "0x40060FA")]
	[FieldOffset(Offset = "0x4C")]
	public float m_FadeBandForHeightMap;

	[Range(0f, 50f)]
	[Token(Token = "0x40060FB")]
	[FieldOffset(Offset = "0x50")]
	public float m_FadeStartBumpDist;

	[Range(0f, 50f)]
	[Token(Token = "0x40060FC")]
	[FieldOffset(Offset = "0x54")]
	public float m_FadeEndBumpDist;

	[Range(0f, 5f)]
	[Token(Token = "0x40060FD")]
	[FieldOffset(Offset = "0x58")]
	public float m_DecalIntensity;

	[Range(0f, 1f)]
	[Token(Token = "0x40060FE")]
	[FieldOffset(Offset = "0x5C")]
	public float m_MaxImprintDistanceFromPatch;

	[Tooltip("Max snow accumulation per game-hour during heaviest snowfall")]
	[Range(0f, 1f)]
	[Token(Token = "0x40060FF")]
	[FieldOffset(Offset = "0x60")]
	public float m_SnowDepthPerHour;

	[Tooltip("Max snow accumulation per game-hour during strongest wind")]
	[Range(0f, 1f)]
	[Token(Token = "0x4006100")]
	[FieldOffset(Offset = "0x64")]
	public float m_WindDepthPerHour;

	[Range(0f, 1f)]
	[Token(Token = "0x4006101")]
	[FieldOffset(Offset = "0x68")]
	public float m_PatchDeviationForInvalidCheck;

	[Range(0f, 1f)]
	[Token(Token = "0x4006102")]
	[FieldOffset(Offset = "0x6C")]
	public float m_HeightMapInvalidThreshold;

	[Range(0f, 5f)]
	[Token(Token = "0x4006103")]
	[FieldOffset(Offset = "0x70")]
	public float m_HMTangentInvalidThreshold;

	[Range(0f, 1f)]
	[Token(Token = "0x4006104")]
	[FieldOffset(Offset = "0x74")]
	public float m_BumpDecalInvalidThreshold;

	[Range(0f, 1f)]
	[Token(Token = "0x4006105")]
	[FieldOffset(Offset = "0x78")]
	public float m_BumpDecalNormalThreshold;

	[Header("Settings - Low")]
	[Range(0f, 150f)]
	[Token(Token = "0x4006106")]
	[FieldOffset(Offset = "0x7C")]
	public float m_DrawDistanceLow;

	[Range(1f, 50f)]
	[Token(Token = "0x4006107")]
	[FieldOffset(Offset = "0x80")]
	public int m_ImprintsPerPatchLow;

	[Tooltip("Snow accumulation per game-hour when not snowing (just to make footsteps time-out)")]
	[Range(0f, 1f)]
	[Token(Token = "0x4006108")]
	[FieldOffset(Offset = "0x84")]
	public float m_PassiveDepthPerHourLow;

	[Header("Settings - Medium")]
	[Range(0f, 150f)]
	[Token(Token = "0x4006109")]
	[FieldOffset(Offset = "0x88")]
	public float m_DrawDistanceMedium;

	[Range(1f, 50f)]
	[Token(Token = "0x400610A")]
	[FieldOffset(Offset = "0x8C")]
	public int m_ImprintsPerPatchMedium;

	[Range(0f, 1f)]
	[Token(Token = "0x400610B")]
	[FieldOffset(Offset = "0x90")]
	public float m_PassiveDepthPerHourMedium;

	[Header("Settings - High")]
	[Range(0f, 150f)]
	[Token(Token = "0x400610C")]
	[FieldOffset(Offset = "0x94")]
	public float m_DrawDistanceHigh;

	[Range(1f, 50f)]
	[Token(Token = "0x400610D")]
	[FieldOffset(Offset = "0x98")]
	public int m_ImprintsPerPatchHigh;

	[Range(0f, 1f)]
	[Token(Token = "0x400610E")]
	[FieldOffset(Offset = "0x9C")]
	public float m_PassiveDepthPerHourHigh;

	[Header("Settings - Ultra")]
	[Range(0f, 150f)]
	[Token(Token = "0x400610F")]
	[FieldOffset(Offset = "0xA0")]
	public float m_DrawDistanceUltra;

	[Range(1f, 50f)]
	[Token(Token = "0x4006110")]
	[FieldOffset(Offset = "0xA4")]
	public int m_ImprintsPerPatchUltra;

	[Range(0f, 1f)]
	[Token(Token = "0x4006111")]
	[FieldOffset(Offset = "0xA8")]
	public float m_PassiveDepthPerHourUltra;

	[Header("Materials")]
	[Token(Token = "0x4006112")]
	[FieldOffset(Offset = "0xB0")]
	public Material m_PatchHeightMaterial;

	[Token(Token = "0x4006113")]
	[FieldOffset(Offset = "0xB8")]
	public Material m_HeightMapImprintMaterial;

	[Token(Token = "0x4006114")]
	[FieldOffset(Offset = "0xC0")]
	public Material m_SnowPatchHoleCutterMaterial;

	[Token(Token = "0x4006115")]
	[FieldOffset(Offset = "0xC8")]
	public Material m_SnowPatchFinalMaterial;

	[Token(Token = "0x4006116")]
	[FieldOffset(Offset = "0xD0")]
	public Material m_NormalMapDecalMaterial;

	[Token(Token = "0x4006117")]
	[FieldOffset(Offset = "0xD8")]
	public UvList m_HeightMapUvInfo;

	[Token(Token = "0x4006118")]
	[FieldOffset(Offset = "0xE0")]
	public UvList m_NormalMapUvInfo;

	[Header("Other Resources")]
	[Token(Token = "0x4006119")]
	[FieldOffset(Offset = "0xE8")]
	public Mesh m_CubeMesh;

	[Token(Token = "0x400611A")]
	[FieldOffset(Offset = "0xF0")]
	public Mesh[] m_HeightMapGridMesh_High;

	[Token(Token = "0x400611B")]
	[FieldOffset(Offset = "0xF8")]
	public Mesh[] m_HeightMapGridMesh_Medium;

	[Token(Token = "0x400611C")]
	[FieldOffset(Offset = "0x100")]
	public Mesh[] m_HeightMapGridMesh_Low;

	[Token(Token = "0x400611D")]
	[FieldOffset(Offset = "0x108")]
	public Mesh[] m_PatchHeightMapGridMeshes;

	[Token(Token = "0x400611E")]
	[FieldOffset(Offset = "0x110")]
	public RenderTexture[] m_HeightMapRenderTextures;

	[Token(Token = "0x400611F")]
	[FieldOffset(Offset = "0x118")]
	private float m_RenderCaptureDistance;

	[Token(Token = "0x4006120")]
	[FieldOffset(Offset = "0x120")]
	private Stack<SnowPatch> m_AvailablePatches;

	[Token(Token = "0x4006121")]
	[FieldOffset(Offset = "0x128")]
	private List<SnowPatch> m_ActivePatches;

	[Token(Token = "0x4006122")]
	[FieldOffset(Offset = "0x130")]
	private OctreeBounds<SnowPatch> m_Octree;

	[Token(Token = "0x4006123")]
	[FieldOffset(Offset = "0x138")]
	private Dictionary<int, SnowPatch> m_PatchDict;

	[Token(Token = "0x4006124")]
	[FieldOffset(Offset = "0x140")]
	private List<SnowPatch>[] m_CaptureLists;

	[Token(Token = "0x4006125")]
	[FieldOffset(Offset = "0x148")]
	private int m_CaptureTick;

	[Token(Token = "0x4006126")]
	[FieldOffset(Offset = "0x150")]
	private List<SnowPatch> m_GetCollidingResults;

	[Token(Token = "0x4006127")]
	[FieldOffset(Offset = "0x158")]
	private Bounds[] m_ImprintBounds;

	[Token(Token = "0x4006128")]
	public static Mesh m_ImprintMesh;

	[Token(Token = "0x4006129")]
	[FieldOffset(Offset = "0x160")]
	private int[] m_HeightMapRenderTextureTypes;

	[Token(Token = "0x400612A")]
	[FieldOffset(Offset = "0x168")]
	private CommandBuffer m_HeightMapCommandBuffer;

	[Token(Token = "0x400612B")]
	[FieldOffset(Offset = "0x170")]
	private CommandBuffer m_MainCamCommandBuffer1;

	[Token(Token = "0x400612C")]
	[FieldOffset(Offset = "0x178")]
	private CommandBuffer m_MainCamCommandBuffer2;

	[Token(Token = "0x400612D")]
	[FieldOffset(Offset = "0x180")]
	private CommandBuffer m_MainCamCommandBuffer3;

	[Token(Token = "0x400612E")]
	[FieldOffset(Offset = "0x188")]
	private int[] m_CoeffIds;

	[Token(Token = "0x400612F")]
	[FieldOffset(Offset = "0x190")]
	private int m_ImprintInfoId;

	[Token(Token = "0x4006130")]
	[FieldOffset(Offset = "0x194")]
	private int m_HeightMapUvInfoId;

	[Token(Token = "0x4006131")]
	[FieldOffset(Offset = "0x198")]
	private int m_ConfigId;

	[Token(Token = "0x4006132")]
	[FieldOffset(Offset = "0x19C")]
	private int m_CamZId;

	[Token(Token = "0x4006133")]
	[FieldOffset(Offset = "0x1A0")]
	private int m_LimitsId;

	[Token(Token = "0x4006134")]
	[FieldOffset(Offset = "0x1A4")]
	private int m_PatchFadeId;

	[Token(Token = "0x4006135")]
	[FieldOffset(Offset = "0x1A8")]
	private int m_HeightMapId;

	[Token(Token = "0x4006136")]
	[FieldOffset(Offset = "0x1AC")]
	private int m_NormalsId;

	[Token(Token = "0x4006137")]
	[FieldOffset(Offset = "0x1B0")]
	private int m_MainTexUvId;

	[Token(Token = "0x4006138")]
	[FieldOffset(Offset = "0x1B4")]
	private int m_BumpMapUvId;

	[Token(Token = "0x4006139")]
	[FieldOffset(Offset = "0x1B8")]
	private int m_LocalNormalId;

	[Token(Token = "0x400613A")]
	[FieldOffset(Offset = "0x1BC")]
	private int m_DeviationWeightId;

	[Token(Token = "0x400613B")]
	[FieldOffset(Offset = "0x1C0")]
	private int m_DecalParamsId;

	[Token(Token = "0x400613C")]
	[FieldOffset(Offset = "0x1C8")]
	private SnowfallManager m_SnowfallManager;

	[Token(Token = "0x400613D")]
	[FieldOffset(Offset = "0x1D0")]
	private float m_PassiveDepthPerHour;

	[Token(Token = "0x400613E")]
	[FieldOffset(Offset = "0x1D4")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x400613F")]
	[FieldOffset(Offset = "0x1D8")]
	private int m_LastSeenFrame;

	[Token(Token = "0x4006140")]
	[FieldOffset(Offset = "0x1DC")]
	private int m_NumPatchesAddedThisFrame;

	[Token(Token = "0x4006141")]
	[FieldOffset(Offset = "0x1E0")]
	private bool m_HasShownPatchStarvationWarning;

	[Token(Token = "0x4006142")]
	public static SnowPatchManager m_Instance;

	[Token(Token = "0x4006143")]
	private const CameraEvent HEIGHT_MAP_COMMAND_BUFFER_EVENT = CameraEvent.BeforeLighting;

	[Token(Token = "0x4006144")]
	private const CameraEvent HOLE_CUTTER_CAMERA_EVENT = CameraEvent.BeforeLighting;

	[Token(Token = "0x4006145")]
	private const CameraEvent SNOW_PATCH_CAMERA_EVENT = CameraEvent.BeforeLighting;

	[Token(Token = "0x4006146")]
	private const CameraEvent BUMPED_DECAL_CAMERA_EVENT = CameraEvent.BeforeLighting;

	[Token(Token = "0x4006147")]
	[FieldOffset(Offset = "0x1E8")]
	private RenderTargetIdentifier[] m_RenderTargetIdentifiers;

	[Token(Token = "0x4006148")]
	private static Matrix4x4 m_WorkMat;

	[Token(Token = "0x6005487")]
	[Address(RVA = "0xE83FE0", Offset = "0xE82DE0", Length = "0x3B")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6005488")]
	[Address(RVA = "0xE84020", Offset = "0xE82E20", Length = "0xE62")]
	private void Start()
	{
	}

	[Token(Token = "0x6005489")]
	[Address(RVA = "0xE84E90", Offset = "0xE83C90", Length = "0x2AC")]
	private void AllocatePatches(int num)
	{
	}

	[Token(Token = "0x600548A")]
	[Address(RVA = "0xE85140", Offset = "0xE83F40", Length = "0x2D1")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600548B")]
	[Address(RVA = "0xE85420", Offset = "0xE84220", Length = "0xF8")]
	private void AllocateResources(QualityFootprints quality)
	{
	}

	[Token(Token = "0x600548C")]
	[Address(RVA = "0xE86560", Offset = "0xE85360", Length = "0x20")]
	public string SerializeGlobal()
	{
		return null;
	}

	[Token(Token = "0x600548D")]
	[Address(RVA = "0xE86590", Offset = "0xE85390", Length = "0x3D")]
	public void DeserializeGlobal(string text)
	{
	}

	[Token(Token = "0x600548E")]
	[Address(RVA = "0xE865D0", Offset = "0xE853D0", Length = "0x3B")]
	public void AdjustSnowDepthRecord(float baseDepth)
	{
	}

	[Token(Token = "0x600548F")]
	[Address(RVA = "0xE86610", Offset = "0xE85410", Length = "0x8")]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[Token(Token = "0x6005490")]
	[Address(RVA = "0xE86620", Offset = "0xE85420", Length = "0x148")]
	public void RemovePatchRef(int id)
	{
	}

	[Token(Token = "0x6005491")]
	[Address(RVA = "0xE86770", Offset = "0xE85570", Length = "0x57F")]
	public bool AddImprint(SnowImprint imprint, float imprintSize, ref HashSet<int> referencedPatches)
	{
		return false;
	}

	[Token(Token = "0x6005492")]
	[Address(RVA = "0xE86CF0", Offset = "0xE85AF0", Length = "0x603")]
	private int GetOverlappedBoundsForImprint(Bounds imprintBounds)
	{
		return 0;
	}

	[Token(Token = "0x6005493")]
	[Address(RVA = "0xE87300", Offset = "0xE86100", Length = "0xB5")]
	public bool CanAddPatch()
	{
		return false;
	}

	[Token(Token = "0x6005494")]
	[Address(RVA = "0xE873C0", Offset = "0xE861C0", Length = "0x81F")]
	public bool AddPatch(Vector3 centre, out SnowPatch sp)
	{
		sp = null;
		return false;
	}

	[Token(Token = "0x6005495")]
	[Address(RVA = "0xE87BE0", Offset = "0xE869E0", Length = "0xF0")]
	private void RemovePatch(SnowPatch sp)
	{
	}

	[Token(Token = "0x6005496")]
	[Address(RVA = "0xE87CE0", Offset = "0xE86AE0", Length = "0x30")]
	public float GetLocalSnowDepth()
	{
		return 0f;
	}

	[Token(Token = "0x6005497")]
	[Address(RVA = "0xE87D20", Offset = "0xE86B20", Length = "0x36C")]
	private void Update()
	{
	}

	[Token(Token = "0x6005498")]
	[Address(RVA = "0xE88090", Offset = "0xE86E90", Length = "0x25BC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6005499")]
	[Address(RVA = "0xE8AE40", Offset = "0xE89C40", Length = "0x182")]
	public SnowPatchManager()
	{
	}
}
