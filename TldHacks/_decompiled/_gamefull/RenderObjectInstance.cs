using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(RenderObjectInstanceSceneData))]
[Token(Token = "0x20008E5")]
public class RenderObjectInstance : MonoBehaviour
{
	[Token(Token = "0x20008E6")]
	public enum FrustrmType
	{
		[Token(Token = "0x4005D5B")]
		DotProduct,
		[Token(Token = "0x4005D5C")]
		Camera
	}

	[Token(Token = "0x20008E7")]
	public enum MultisceneSupport
	{
		[Token(Token = "0x4005D5E")]
		Individual,
		[Token(Token = "0x4005D5F")]
		Renderer,
		[Token(Token = "0x4005D60")]
		Collector
	}

	[Token(Token = "0x20008E8")]
	public enum Category
	{
		[Token(Token = "0x4005D62")]
		None,
		[Token(Token = "0x4005D63")]
		Tree,
		[Token(Token = "0x4005D64")]
		RockLarge,
		[Token(Token = "0x4005D65")]
		RockMedium,
		[Token(Token = "0x4005D66")]
		RockDebris,
		[Token(Token = "0x4005D67")]
		ArtObjects,
		[Token(Token = "0x4005D68")]
		Fences
	}

	[Flags]
	[Token(Token = "0x20008E9")]
	public enum EnableOptions
	{
		[Token(Token = "0x4005D6A")]
		None = 0,
		[Token(Token = "0x4005D6B")]
		ReEnableRenderersWhenDisabled = 1
	}

	[Header("Deprecated")]
	[Token(Token = "0x4005D19")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> m_ObjectParents;

	[Token(Token = "0x4005D1A")]
	[FieldOffset(Offset = "0x28")]
	public MultisceneSupport m_MultiSceneType;

	[Header("Objects")]
	[Token(Token = "0x4005D1B")]
	[FieldOffset(Offset = "0x30")]
	public Transform m_Camera;

	[Header("Render options")]
	[Token(Token = "0x4005D1C")]
	[FieldOffset(Offset = "0x38")]
	public RenderObjectInstanceDistanceSettings m_DistanceSettings;

	[Token(Token = "0x4005D1D")]
	[FieldOffset(Offset = "0x40")]
	public float m_Lod1Distances;

	[Token(Token = "0x4005D1E")]
	[FieldOffset(Offset = "0x44")]
	public float m_Lod2Distances;

	[Token(Token = "0x4005D1F")]
	[FieldOffset(Offset = "0x48")]
	public float m_Lod3Distances;

	[Range(0f, 30f)]
	[Token(Token = "0x4005D20")]
	[FieldOffset(Offset = "0x4C")]
	public float m_TransitionWidth;

	[Token(Token = "0x4005D21")]
	[FieldOffset(Offset = "0x50")]
	public MinMax m_CullMultiplier;

	[Token(Token = "0x4005D22")]
	[FieldOffset(Offset = "0x58")]
	public MinMax m_HeightAdjust;

	[Tooltip("Force only LOD0 to use shadows, as some objects may be setup for that all LODs have shadow casting on.The benefit is that it can save a LOT of shadow related drawcalls.")]
	[Token(Token = "0x4005D23")]
	[FieldOffset(Offset = "0x60")]
	public bool m_ForceOnlyLod0Shadow;

	[Tooltip("Prevent LOD0 objects from being frustum culled, at the expense of additional drawcalls.")]
	[Token(Token = "0x4005D24")]
	[FieldOffset(Offset = "0x61")]
	public bool m_ForceNoLod0Cull;

	[Header("Job system")]
	[SerializeField]
	[Token(Token = "0x4005D25")]
	[FieldOffset(Offset = "0x64")]
	private int m_InnerLoopBatchCount;

	[Token(Token = "0x4005D26")]
	[FieldOffset(Offset = "0x68")]
	public FrustrmType m_FrustumType;

	[Header("LOD Override Volumes")]
	[Token(Token = "0x4005D27")]
	[FieldOffset(Offset = "0x70")]
	public List<RenderObjectInstanceVolume> m_DistanceVolumes;

	[Token(Token = "0x4005D28")]
	[FieldOffset(Offset = "0x78")]
	public List<RenderObjectInstanceTriggerVolume> m_TriggerVolumes;

	[Token(Token = "0x4005D29")]
	[FieldOffset(Offset = "0x80")]
	public Category m_Category;

	[Token(Token = "0x4005D2A")]
	public const int _Lod0Mask_ = 1;

	[Token(Token = "0x4005D2B")]
	public const int _Lod1Mask_ = 2;

	[Token(Token = "0x4005D2C")]
	public const int _Lod2Mask_ = 4;

	[Token(Token = "0x4005D2D")]
	public static bool s_EnableLodVisualization;

	[Token(Token = "0x4005D2E")]
	public static bool s_EnableWarningLogs;

	[Token(Token = "0x4005D2F")]
	[FieldOffset(Offset = "0x88")]
	private Camera m_CameraComponent;

	[Token(Token = "0x4005D30")]
	[FieldOffset(Offset = "0x90")]
	private bool m_IsInitialized;

	[Token(Token = "0x4005D31")]
	[FieldOffset(Offset = "0x94")]
	private float4 m_CameraPosition;

	[Token(Token = "0x4005D32")]
	[FieldOffset(Offset = "0xA4")]
	private float4 m_CameraDirection;

	[Token(Token = "0x4005D33")]
	[FieldOffset(Offset = "0xB8")]
	private Plane[] m_CameraPlanes;

	[Token(Token = "0x4005D34")]
	[FieldOffset(Offset = "0xC0")]
	private float m_Lod0Start;

	[Token(Token = "0x4005D35")]
	[FieldOffset(Offset = "0xC4")]
	private float m_Lod1DistNearSqr;

	[Token(Token = "0x4005D36")]
	[FieldOffset(Offset = "0xC8")]
	private float m_Lod1DistMiddleSqr;

	[Token(Token = "0x4005D37")]
	[FieldOffset(Offset = "0xCC")]
	private float m_Lod1DistFarSqr;

	[Token(Token = "0x4005D38")]
	[FieldOffset(Offset = "0xD0")]
	private float m_Lod2DistNearSqr;

	[Token(Token = "0x4005D39")]
	[FieldOffset(Offset = "0xD4")]
	private float m_Lod2DistMiddleSqr;

	[Token(Token = "0x4005D3A")]
	[FieldOffset(Offset = "0xD8")]
	private float m_Lod2DistFarSqr;

	[Token(Token = "0x4005D3B")]
	[FieldOffset(Offset = "0xDC")]
	private float m_Lod3DistNearSqr;

	[Token(Token = "0x4005D3C")]
	[FieldOffset(Offset = "0xE0")]
	private float m_Lod3DistMiddleSqr;

	[Token(Token = "0x4005D3D")]
	[FieldOffset(Offset = "0xE8")]
	private List<RenderObjectInstanceTriggerVolume> m_TriggerVolumeList;

	[Token(Token = "0x4005D3E")]
	[FieldOffset(Offset = "0xF0")]
	private MaterialPropertyBlock m_Lod0DistanceBlock;

	[Token(Token = "0x4005D3F")]
	[FieldOffset(Offset = "0xF8")]
	private MaterialPropertyBlock m_Lod1DistanceBlock;

	[Token(Token = "0x4005D40")]
	[FieldOffset(Offset = "0x100")]
	private MaterialPropertyBlock m_Lod2DistanceBlock;

	[Token(Token = "0x4005D41")]
	private const int CAMERA_PLANES_LENGTH = 6;

	[Token(Token = "0x4005D42")]
	private const int LIGHT_PLANES_LENGTH = 13;

	[Token(Token = "0x4005D43")]
	private const int FRUSTUM_CORNERS_LENGTH = 8;

	[Token(Token = "0x4005D44")]
	[FieldOffset(Offset = "0x108")]
	private int m_ObjectCount;

	[Token(Token = "0x4005D45")]
	[FieldOffset(Offset = "0x10C")]
	private bool m_Allocated;

	[Token(Token = "0x4005D46")]
	[FieldOffset(Offset = "0x10D")]
	private bool m_HasBeenDisabled;

	[Token(Token = "0x4005D47")]
	[FieldOffset(Offset = "0x110")]
	private JobHandle m_JobHandle;

	[Token(Token = "0x4005D48")]
	[FieldOffset(Offset = "0x120")]
	private NativeArray<Plane> m_CameraPlanesNativeArray;

	[Token(Token = "0x4005D49")]
	[FieldOffset(Offset = "0x130")]
	private NativeArray<Plane> m_LightPlanesNativeArray;

	[Token(Token = "0x4005D4A")]
	private static Plane[] s_CameraPlanes;

	[Token(Token = "0x4005D4B")]
	private static Plane[] s_LightPlanes;

	[Token(Token = "0x4005D4C")]
	private static Vector3[] s_FrustumCorners;

	[Token(Token = "0x4005D4D")]
	private static List<RenderObjectInstance> s_RenderObjectInstanceList;

	[Token(Token = "0x4005D4E")]
	private static int s_LightPlanesCount;

	[Token(Token = "0x4005D4F")]
	private static bool s_FrustumUpdated;

	[Token(Token = "0x4005D50")]
	private static bool s_UseCameraFrustum;

	[Token(Token = "0x4005D51")]
	private const string CROSSFADE_SHADER_KEYWORD = "TLD_CROSSFADE";

	[Token(Token = "0x4005D52")]
	private static readonly int s_LodFadeDistanceId;

	[Token(Token = "0x4005D53")]
	private static readonly int s_LodColourId;

	[Token(Token = "0x4005D54")]
	private const float FOV_VISIBILITY_EXPAND = 0.05f;

	[Token(Token = "0x4005D55")]
	private static bool s_DebugDrawCullingPlanes;

	[Token(Token = "0x4005D56")]
	[FieldOffset(Offset = "0x140")]
	private RenderObjectInstanceSceneData[] m_SceneDataComponents;

	[Token(Token = "0x4005D57")]
	[FieldOffset(Offset = "0x148")]
	public RenderObjectInstanceBatches m_Batches;

	[Token(Token = "0x4005D58")]
	public static bool s_ShowDebugInfo;

	[Token(Token = "0x4005D59")]
	[FieldOffset(Offset = "0x150")]
	private string m_DebugText;

	[Token(Token = "0x60051AF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void OnValidate()
	{
	}

	[Token(Token = "0x60051B0")]
	[Address(RVA = "0xE305C0", Offset = "0xE2F3C0", Length = "0x231")]
	public static void EarlyUpdateAll()
	{
	}

	[Token(Token = "0x60051B1")]
	[Address(RVA = "0xE30800", Offset = "0xE2F600", Length = "0x246")]
	public static void EnableAll(bool enabled, EnableOptions options)
	{
	}

	[Token(Token = "0x60051B2")]
	[Address(RVA = "0xE30A50", Offset = "0xE2F850", Length = "0x217")]
	public static bool AllEnabled()
	{
		return false;
	}

	[Token(Token = "0x60051B3")]
	[Address(RVA = "0xE30C70", Offset = "0xE2FA70", Length = "0x1D3")]
	public static void EnableCategory(Category category, bool enabled, EnableOptions options)
	{
	}

	[Token(Token = "0x60051B4")]
	[Address(RVA = "0xE30E50", Offset = "0xE2FC50", Length = "0x18F")]
	public static bool IsCategoryEnabled(Category category)
	{
		return false;
	}

	[Token(Token = "0x60051B5")]
	[Address(RVA = "0xE30FE0", Offset = "0xE2FDE0", Length = "0x59")]
	public static void EnableFrustumTest(bool useCameraFrustum)
	{
	}

	[Token(Token = "0x60051B6")]
	[Address(RVA = "0xE31040", Offset = "0xE2FE40", Length = "0x54")]
	public static bool IsFrustumTestEnabled()
	{
		return false;
	}

	[Token(Token = "0x60051B7")]
	[Address(RVA = "0xE310A0", Offset = "0xE2FEA0", Length = "0x443")]
	public static bool IsRenderObjectInstanceChild(Transform t)
	{
		return false;
	}

	[Token(Token = "0x60051B8")]
	[Address(RVA = "0xE314F0", Offset = "0xE302F0", Length = "0x4EE")]
	private void Awake()
	{
	}

	[Token(Token = "0x60051B9")]
	[Address(RVA = "0xE319E0", Offset = "0xE307E0", Length = "0x3BD")]
	private void Setup()
	{
	}

	[Token(Token = "0x60051BA")]
	[Address(RVA = "0xE31DA0", Offset = "0xE30BA0", Length = "0x21F")]
	private void EnableRenderers(bool enabled)
	{
	}

	[Token(Token = "0x60051BB")]
	[Address(RVA = "0xE31FC0", Offset = "0xE30DC0", Length = "0x5CC")]
	private void EnableRenderersInChildren(Transform parent, bool enabled)
	{
	}

	[Token(Token = "0x60051BC")]
	[Address(RVA = "0xE32590", Offset = "0xE31390", Length = "0x259")]
	private void EnableRendererForLODGroup(LODGroup group, bool enabled)
	{
	}

	[Token(Token = "0x60051BD")]
	[Address(RVA = "0xE327F0", Offset = "0xE315F0", Length = "0x2BD")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60051BE")]
	[Address(RVA = "0xE32AB0", Offset = "0xE318B0", Length = "0x316")]
	private void CreateBatchList(RenderObjectInstanceSceneData[] sceneDataComponents)
	{
	}

	[Token(Token = "0x60051BF")]
	[Address(RVA = "0xE32DD0", Offset = "0xE31BD0", Length = "0x184")]
	private void PopulateBatchList(RenderObjectInstanceSceneData[] sceneDataComponents)
	{
	}

	[Token(Token = "0x60051C0")]
	[Address(RVA = "0xE32F60", Offset = "0xE31D60", Length = "0x45D")]
	private void GetObjectsFromLists(Dictionary<int, List<Renderer>> dictionary)
	{
	}

	[Token(Token = "0x60051C1")]
	[Address(RVA = "0xE333C0", Offset = "0xE321C0", Length = "0x53")]
	private MaterialPropertyBlock GetMaterialPropertiesForLod(int batchIndex)
	{
		return null;
	}

	[Token(Token = "0x60051C2")]
	[Address(RVA = "0xE33420", Offset = "0xE32220", Length = "0x8A")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60051C3")]
	[Address(RVA = "0xE334B0", Offset = "0xE322B0", Length = "0x24")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60051C4")]
	[Address(RVA = "0xE334E0", Offset = "0xE322E0", Length = "0x26")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60051C5")]
	[Address(RVA = "0xE33510", Offset = "0xE32310", Length = "0x112")]
	private void Cleanup()
	{
	}

	[Token(Token = "0x60051C6")]
	[Address(RVA = "0xE33630", Offset = "0xE32430", Length = "0x2EE")]
	private void EarlyUpdate()
	{
	}

	[Token(Token = "0x60051C7")]
	[Address(RVA = "0xE33920", Offset = "0xE32720", Length = "0x516")]
	private void ScheduleJobs()
	{
	}

	[Token(Token = "0x60051C8")]
	[Address(RVA = "0xE33E40", Offset = "0xE32C40", Length = "0x32D")]
	private void UpdateFrustumArrays()
	{
	}

	[Token(Token = "0x60051C9")]
	[Address(RVA = "0xE34170", Offset = "0xE32F70", Length = "0x5E")]
	private void WaitForJobs()
	{
	}

	[Token(Token = "0x60051CA")]
	[Address(RVA = "0xE341D0", Offset = "0xE32FD0", Length = "0x18C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60051CB")]
	[Address(RVA = "0xE34360", Offset = "0xE33160", Length = "0x225")]
	private void UpdateLODsFromSettings(float4 camPos)
	{
	}

	[Token(Token = "0x60051CC")]
	[Address(RVA = "0xE34590", Offset = "0xE33390", Length = "0xFB")]
	private void GetLodDistances(out float lod1Distance, out float lod2Distance, out float lod3Distance)
	{
		lod1Distance = default(float);
		lod2Distance = default(float);
		lod3Distance = default(float);
	}

	[Token(Token = "0x60051CD")]
	[Address(RVA = "0xE34690", Offset = "0xE33490", Length = "0x213")]
	private void TestClipPlaneDistance()
	{
	}

	[Token(Token = "0x60051CE")]
	[Address(RVA = "0xE348B0", Offset = "0xE336B0", Length = "0x787")]
	private void UpdateLodMaterialProperties()
	{
	}

	[Token(Token = "0x60051CF")]
	[Address(RVA = "0xE35040", Offset = "0xE33E40", Length = "0x34")]
	private float FastSqrDist3D(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	[Token(Token = "0x60051D0")]
	[Address(RVA = "0xE35080", Offset = "0xE33E80", Length = "0x51E")]
	private void UpdateLODsWithVolumes(Vector4 camPos)
	{
	}

	[Token(Token = "0x60051D1")]
	[Address(RVA = "0xE355A0", Offset = "0xE343A0", Length = "0xC5")]
	public void PushTriggerVolume(RenderObjectInstanceTriggerVolume curVolume)
	{
	}

	[Token(Token = "0x60051D2")]
	[Address(RVA = "0xE35670", Offset = "0xE34470", Length = "0x85")]
	public void PopTriggerVolume(RenderObjectInstanceTriggerVolume curVolume)
	{
	}

	[Token(Token = "0x60051D3")]
	[Address(RVA = "0xE35700", Offset = "0xE34500", Length = "0x281")]
	private void Register()
	{
	}

	[Token(Token = "0x60051D4")]
	[Address(RVA = "0xE35990", Offset = "0xE34790", Length = "0x83")]
	private void UnRegister()
	{
	}

	[Token(Token = "0x60051D5")]
	[Address(RVA = "0xE35A20", Offset = "0xE34820", Length = "0x1CF")]
	public string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x60051D6")]
	[Address(RVA = "0xE35BF0", Offset = "0xE349F0", Length = "0x19A")]
	public static MeshFilter MaybeGetMeshFilterForInstancedRendering(Renderer r)
	{
		return null;
	}

	[Token(Token = "0x60051D7")]
	[Address(RVA = "0xE35D90", Offset = "0xE34B90", Length = "0x101")]
	public static Mesh MaybeGetMeshForInstancedRendering(Renderer r)
	{
		return null;
	}

	[Token(Token = "0x60051D8")]
	[Address(RVA = "0xE35EA0", Offset = "0xE34CA0", Length = "0xA6")]
	public static void CopyNativeToManaged(NativeArray<Matrix4x4> src, int srcIndex, Matrix4x4[] dst, int dstIndex, int length)
	{
	}

	[Token(Token = "0x60051D9")]
	[Address(RVA = "0xE35F50", Offset = "0xE34D50", Length = "0xE5")]
	public static Dictionary<int, List<Renderer>> GetLodsAndRenderers(List<GameObject> gameObjects, bool ignoreDisabledObjects, bool allowNoLodGroup, bool removeLodGroup)
	{
		return null;
	}

	[Token(Token = "0x60051DA")]
	[Address(RVA = "0xE36040", Offset = "0xE34E40", Length = "0x406")]
	public static Dictionary<int, List<Renderer>> GetGlobalObjectLodsAndRenderers(List<GameObject> gameObjects, bool ignoreDisabledObjects, bool allowNoLodGroup, bool removeLodGroup, Scene currentScene)
	{
		return null;
	}

	[Token(Token = "0x60051DB")]
	[Address(RVA = "0xE36450", Offset = "0xE35250", Length = "0x5D1")]
	private static Dictionary<int, List<Renderer>> FindAllRenderers(List<GameObject> gameObjects, bool ignoreDisabledObjects, bool allowNoLodGroup, bool removeLodGroup, Dictionary<int, List<Renderer>> renderers)
	{
		return null;
	}

	[Token(Token = "0x60051DC")]
	[Address(RVA = "0xE36A30", Offset = "0xE35830", Length = "0x431")]
	private static bool IsSamePrefab(GameObject projectAsset, GameObject sceneObject)
	{
		return false;
	}

	[Token(Token = "0x60051DD")]
	[Address(RVA = "0xE36E70", Offset = "0xE35C70", Length = "0x17A")]
	public RenderObjectInstance()
	{
	}
}
