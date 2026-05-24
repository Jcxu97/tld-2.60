using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x200072B")]
public class DynamicDecalsManager : MonoBehaviour
{
	[Token(Token = "0x200072C")]
	private struct PlacedSprayPaintDecalInfo
	{
		[Token(Token = "0x4004C34")]
		[FieldOffset(Offset = "0x0")]
		public DecalProjectorInstance m_ProjectorInstance;

		[Token(Token = "0x4004C35")]
		[FieldOffset(Offset = "0x8")]
		public Bounds m_Bounds;
	}

	[Token(Token = "0x200072D")]
	private struct RenderDecalParameters
	{
		[Token(Token = "0x4004C36")]
		[FieldOffset(Offset = "0x0")]
		public float m_TanFov;

		[Token(Token = "0x4004C37")]
		[FieldOffset(Offset = "0x4")]
		public float m_InvScreenSizeFadeRange;

		[Token(Token = "0x4004C38")]
		[FieldOffset(Offset = "0x8")]
		public float m_InvDistanceFadeRange;

		[Token(Token = "0x4004C39")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 m_CameraPos;

		[Token(Token = "0x4004C3A")]
		[FieldOffset(Offset = "0x18")]
		public Matrix4x4 m_TransformMatrix;
	}

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004BDE")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Map> m_Map;

	[SerializeField]
	[Token(Token = "0x4004BDF")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	[Space]
	[Range(1f, 2000f)]
	[Token(Token = "0x4004BE0")]
	[FieldOffset(Offset = "0x30")]
	public int m_MaxNonPlacedDynamicDecals;

	[Range(1f, 100f)]
	[Token(Token = "0x4004BE1")]
	[FieldOffset(Offset = "0x34")]
	public int m_PoolSizeIncrement;

	[Range(1f, 2000f)]
	[Token(Token = "0x4004BE2")]
	[FieldOffset(Offset = "0x38")]
	public int m_MaxPlacedDynamicDecals;

	[Range(0f, 10f)]
	[Token(Token = "0x4004BE3")]
	[FieldOffset(Offset = "0x3C")]
	public float m_FadeTimeSeconds;

	[Header("Player Decals Lifetime")]
	[Range(0f, 48f)]
	[Token(Token = "0x4004BE4")]
	[FieldOffset(Offset = "0x40")]
	public float m_PlayerDecalsLifeTimeHours;

	[Range(0f, 48f)]
	[Token(Token = "0x4004BE5")]
	[FieldOffset(Offset = "0x44")]
	public float m_PlayerDecalsLifeTimeInHighWindsHours;

	[Range(0f, 48f)]
	[Token(Token = "0x4004BE6")]
	[FieldOffset(Offset = "0x48")]
	public float m_PlayerDecalsLifeTimeInHeavySnowHours;

	[Range(0f, 48f)]
	[Token(Token = "0x4004BE7")]
	[FieldOffset(Offset = "0x4C")]
	public float m_PlayerDecalsLifeTimeInBlizzardHours;

	[Header("NPC Decals Lifetime")]
	[Range(0f, 48f)]
	[Token(Token = "0x4004BE8")]
	[FieldOffset(Offset = "0x50")]
	public float m_NPCDecalsLifeTimeHours;

	[Range(0f, 48f)]
	[Token(Token = "0x4004BE9")]
	[FieldOffset(Offset = "0x54")]
	public float m_NPCDecalsLifeTimeInHighWindsHours;

	[Range(0f, 48f)]
	[Token(Token = "0x4004BEA")]
	[FieldOffset(Offset = "0x58")]
	public float m_NPCDecalsLifeTimeInHeavySnowHours;

	[Range(0f, 48f)]
	[Token(Token = "0x4004BEB")]
	[FieldOffset(Offset = "0x5C")]
	public float m_NPCDecalsLifeTimeInBlizzardHours;

	[Header("Spray Paint Decals Lifetime")]
	[Token(Token = "0x4004BEC")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve m_SprayPaintLifetimeCurve;

	[Range(0f, 1000f)]
	[Token(Token = "0x4004BED")]
	[FieldOffset(Offset = "0x68")]
	public int m_SprayPaintDecalsLifeTimeDays;

	[Range(0f, 1000f)]
	[Token(Token = "0x4004BEE")]
	[FieldOffset(Offset = "0x6C")]
	public int m_SprayPaintDecalsLifeTimeInHighWindsDays;

	[Range(0f, 1000f)]
	[Token(Token = "0x4004BEF")]
	[FieldOffset(Offset = "0x70")]
	public int m_SprayPaintDecalsLifeTimeInHeavySnowDays;

	[Range(0f, 1000f)]
	[Token(Token = "0x4004BF0")]
	[FieldOffset(Offset = "0x74")]
	public int m_SprayPaintDecalsLifeTimeInBlizzardDays;

	[Header("Nowhere to Hide Glyph Lifetimes")]
	[Range(0f, 1000f)]
	[Token(Token = "0x4004BF1")]
	[FieldOffset(Offset = "0x78")]
	public float m_LureDecalLifeTimeMinutes;

	[Range(0f, 1000f)]
	[Token(Token = "0x4004BF2")]
	[FieldOffset(Offset = "0x7C")]
	public float m_WardDecalLifeTimeMinutes;

	[Range(0f, 1000f)]
	[Token(Token = "0x4004BF3")]
	[FieldOffset(Offset = "0x80")]
	public float m_DispelFogLifeTimeMinutes;

	[Range(0f, 1000f)]
	[Token(Token = "0x4004BF4")]
	[FieldOffset(Offset = "0x84")]
	public float m_DarkwalkerLifeTimeMinutes;

	[Header("Spray Paint Decals")]
	[SerializeField]
	[Token(Token = "0x4004BF5")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 m_DecalMapRevealRaycastOffset;

	[Token(Token = "0x4004BF6")]
	[FieldOffset(Offset = "0x94")]
	public Vector3 m_BaseSprayDecalScale;

	[Token(Token = "0x4004BF7")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 m_TreeSprayDecalScale;

	[Range(0f, 1f)]
	[SerializeField]
	[Token(Token = "0x4004BF8")]
	[FieldOffset(Offset = "0xAC")]
	private float m_DecalOverlapLeniencyPercent;

	[Token(Token = "0x4004BF9")]
	[FieldOffset(Offset = "0xB0")]
	public float m_LineOfSightDistanceThreshold;

	[Space]
	[Token(Token = "0x4004BFA")]
	[FieldOffset(Offset = "0xB8")]
	public List<UvList> m_StaticDecalAtlasUvList;

	[SerializeField]
	[Token(Token = "0x4004BFB")]
	[FieldOffset(Offset = "0xC0")]
	private Mesh m_CubeMesh;

	[SerializeField]
	[Token(Token = "0x4004BFC")]
	[FieldOffset(Offset = "0xC8")]
	private Material m_StandardMaterial;

	[SerializeField]
	[Token(Token = "0x4004BFD")]
	[FieldOffset(Offset = "0xD0")]
	private Material m_GlowMaterial;

	[SerializeField]
	[Token(Token = "0x4004BFE")]
	[FieldOffset(Offset = "0xD8")]
	private Material m_AnimatedRevealMaterial;

	[Token(Token = "0x4004BFF")]
	[FieldOffset(Offset = "0xE0")]
	public ImpactDecals m_ImpactDecals;

	[Token(Token = "0x4004C00")]
	[FieldOffset(Offset = "0xE8")]
	public DecalSpawnedObject[] m_DecalSpawnedObjects;

	[Tooltip("Order matters as indexes to these entries are stored with the user's save data")]
	[SerializeField]
	[Token(Token = "0x4004C01")]
	[FieldOffset(Offset = "0xF0")]
	private DecalVariant[] m_DecalVariants;

	[SerializeField]
	[Token(Token = "0x4004C02")]
	[FieldOffset(Offset = "0xF8")]
	private DecalQualitySettings m_LowQualitySettings;

	[SerializeField]
	[Token(Token = "0x4004C03")]
	[FieldOffset(Offset = "0x100")]
	private DecalQualitySettings m_MediumQualitySettings;

	[SerializeField]
	[Token(Token = "0x4004C04")]
	[FieldOffset(Offset = "0x108")]
	private DecalQualitySettings m_HighQualitySettings;

	[SerializeField]
	[Token(Token = "0x4004C05")]
	[FieldOffset(Offset = "0x110")]
	private DecalQualitySettings m_UltraQualitySettings;

	[SerializeField]
	[Token(Token = "0x4004C06")]
	[FieldOffset(Offset = "0x118")]
	private DecalQualitySettings m_XboxQualitySettings;

	[SerializeField]
	[Token(Token = "0x4004C07")]
	[FieldOffset(Offset = "0x120")]
	private DecalQualitySettings m_PS4QualitySettings;

	[Header("DecalProjector uv info")]
	[SerializeField]
	[Token(Token = "0x4004C08")]
	[FieldOffset(Offset = "0x128")]
	private UvList m_AtlasUvInfo;

	[NonSerialized]
	[Token(Token = "0x4004C09")]
	[FieldOffset(Offset = "0x130")]
	public bool m_ShowDecalDebugBounds;

	[Token(Token = "0x4004C0A")]
	[FieldOffset(Offset = "0x131")]
	private bool m_EnableInstancedRendering;

	[Token(Token = "0x4004C0B")]
	[FieldOffset(Offset = "0x138")]
	private Camera m_CommandBufferCamera;

	[Token(Token = "0x4004C0C")]
	[FieldOffset(Offset = "0x140")]
	private CommandBuffer m_MainCamCommandBuffer;

	[Token(Token = "0x4004C0D")]
	[FieldOffset(Offset = "0x148")]
	private CommandBuffer m_MaskCommandBuffer;

	[Token(Token = "0x4004C0E")]
	[FieldOffset(Offset = "0x150")]
	private Material m_MaskRenderMaterial;

	[Token(Token = "0x4004C0F")]
	[FieldOffset(Offset = "0x158")]
	private Material m_MaskCopyMaterial;

	[Token(Token = "0x4004C10")]
	[FieldOffset(Offset = "0x160")]
	private int m_CurrentMaskTextureIndex;

	[Token(Token = "0x4004C11")]
	[FieldOffset(Offset = "0x168")]
	private RenderTexture[] m_MaskRenderTextures;

	[Token(Token = "0x4004C12")]
	[FieldOffset(Offset = "0x170")]
	private Queue<DecalProjectorInstance> m_MaskRenderQueue;

	[Token(Token = "0x4004C13")]
	[FieldOffset(Offset = "0x178")]
	private Collider[] m_MaskOverlapColliders;

	[Token(Token = "0x4004C14")]
	[FieldOffset(Offset = "0x180")]
	private List<Renderer> m_MaskIgnoredRenderers;

	[Token(Token = "0x4004C15")]
	[FieldOffset(Offset = "0x188")]
	private List<int> m_UsedMaskTextureIndices;

	[Token(Token = "0x4004C16")]
	[FieldOffset(Offset = "0x190")]
	private List<DecalProjectorMaskData> m_StaticMasks;

	[Token(Token = "0x4004C17")]
	public const float DEFAULT_DECAL_CLIP_ANGLE_DEGREES = 72.5f;

	[Token(Token = "0x4004C18")]
	private static readonly float s_DefaultClipAngleCos;

	[Token(Token = "0x4004C19")]
	private const int MASK_TEXTURE_SIZE = 128;

	[Token(Token = "0x4004C1A")]
	private const int MAX_MASK_COUNT = 128;

	[Token(Token = "0x4004C1B")]
	private const int MAX_MASK_OVERLAP_COLLIDERS = 16;

	[Token(Token = "0x4004C1C")]
	[FieldOffset(Offset = "0x198")]
	private int m_NormalsId;

	[Token(Token = "0x4004C1D")]
	[FieldOffset(Offset = "0x19C")]
	private int m_MainTexUvId;

	[Token(Token = "0x4004C1E")]
	[FieldOffset(Offset = "0x1A0")]
	private int m_FadeId;

	[Token(Token = "0x4004C1F")]
	[FieldOffset(Offset = "0x1A4")]
	private int m_TintId;

	[Token(Token = "0x4004C20")]
	[FieldOffset(Offset = "0x1A8")]
	private int m_TintGlowId;

	[Token(Token = "0x4004C21")]
	[FieldOffset(Offset = "0x1AC")]
	private int m_RevealAmountId;

	[Token(Token = "0x4004C22")]
	[FieldOffset(Offset = "0x1B0")]
	private int m_EraseAmountId;

	[Token(Token = "0x4004C23")]
	[FieldOffset(Offset = "0x1B4")]
	private int m_UseLightProbesId;

	[Token(Token = "0x4004C24")]
	[FieldOffset(Offset = "0x1B8")]
	private int m_MaskModeId;

	[Token(Token = "0x4004C25")]
	[FieldOffset(Offset = "0x1BC")]
	private int m_MaskTexId;

	[Token(Token = "0x4004C26")]
	[FieldOffset(Offset = "0x1C0")]
	private int m_ClipAngleId;

	[Token(Token = "0x4004C27")]
	[FieldOffset(Offset = "0x1C8")]
	private RenderTargetIdentifier[] m_RenderTargetIdentifiers;

	[Token(Token = "0x4004C28")]
	[FieldOffset(Offset = "0x1D0")]
	private List<DecalProjectorInstance> m_DynamicDecalProjectors;

	[Token(Token = "0x4004C29")]
	[FieldOffset(Offset = "0x1D8")]
	private List<DecalProjectorInstance> m_FadingDecalProjectors;

	[Token(Token = "0x4004C2A")]
	[FieldOffset(Offset = "0x1E0")]
	private List<DecalProjectorInstance> m_CullList;

	[Token(Token = "0x4004C2B")]
	[FieldOffset(Offset = "0x1E8")]
	private List<DecalProjectorInstance> m_Pool_DecalProjectorInstances;

	[Token(Token = "0x4004C2C")]
	[FieldOffset(Offset = "0x1F0")]
	private int m_NumNonPlacedDynamicDecals;

	[Token(Token = "0x4004C2D")]
	[FieldOffset(Offset = "0x1F4")]
	private int m_NumPlacedDynamicDecals;

	[Token(Token = "0x4004C2E")]
	[FieldOffset(Offset = "0x1F8")]
	private List<StaticDecal> m_StaticDecals;

	[Token(Token = "0x4004C2F")]
	[FieldOffset(Offset = "0x200")]
	private List<DecalRenderBatch> m_StaticDecalPropertyBlocks;

	[Token(Token = "0x4004C30")]
	[FieldOffset(Offset = "0x208")]
	private List<PlacedSprayPaintDecalInfo> m_PlacedSprayPaintDecals;

	[Token(Token = "0x4004C31")]
	[FieldOffset(Offset = "0x210")]
	private bool m_IsStaticDecalsListDirty;

	[Token(Token = "0x4004C32")]
	[FieldOffset(Offset = "0x218")]
	private DecalQualitySettings m_CurrentQualitySettings;

	[Token(Token = "0x4004C33")]
	[FieldOffset(Offset = "0x220")]
	private int m_RenderedDecalCount;

	[Token(Token = "0x60040BA")]
	[Address(RVA = "0xC0C680", Offset = "0xC0B480", Length = "0x2F5")]
	public void Start()
	{
	}

	[Token(Token = "0x60040BB")]
	[Address(RVA = "0xC0C980", Offset = "0xC0B780", Length = "0xBAA")]
	public void PrepareCommandBuffer(Camera camera)
	{
	}

	[Token(Token = "0x60040BC")]
	[Address(RVA = "0xC0D530", Offset = "0xC0C330", Length = "0xE2")]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[Token(Token = "0x60040BD")]
	[Address(RVA = "0xC0D620", Offset = "0xC0C420", Length = "0x17F")]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, DecalProjectorType projectorType, Vector3 postion, Vector3 forward, float yaw)
	{
		return null;
	}

	[Token(Token = "0x60040BE")]
	[Address(RVA = "0xC0D7A0", Offset = "0xC0C5A0", Length = "0x25B")]
	public DecalProjectorInstance AddSprayPaintDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[Token(Token = "0x60040BF")]
	[Address(RVA = "0xC0DA00", Offset = "0xC0C800", Length = "0xC6")]
	public void PlaceDownSprayPaintDecal(DecalProjectorInstance instance)
	{
	}

	[Token(Token = "0x60040C0")]
	[Address(RVA = "0xC0DAD0", Offset = "0xC0C8D0", Length = "0x14")]
	public void RemoveDynamicDecalFadeout(DecalProjectorInstance decalInstance)
	{
	}

	[Token(Token = "0x60040C1")]
	[Address(RVA = "0xC0DAF0", Offset = "0xC0C8F0", Length = "0x26B")]
	public void RemoveDynamicDecal(DecalProjectorInstance decalInstance)
	{
	}

	[Token(Token = "0x60040C2")]
	[Address(RVA = "0xC0DD60", Offset = "0xC0CB60", Length = "0x2E3")]
	private void TrySpawnDecalObject(DecalProjectorInstance decalInstance)
	{
	}

	[Token(Token = "0x60040C3")]
	[Address(RVA = "0xC0E050", Offset = "0xC0CE50", Length = "0xC7")]
	private void AddDynamicDecalProjector(DecalProjectorInstance decalInstance)
	{
	}

	[Token(Token = "0x60040C4")]
	[Address(RVA = "0xC0E120", Offset = "0xC0CF20", Length = "0x1D3")]
	private void RemoveDynamicDecalProjector(DecalProjectorInstance decalInstance)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x60040C5")]
	[Address(RVA = "0xC0E300", Offset = "0xC0D100", Length = "0x324")]
	private void CheckDynamicDecalNumbers()
	{
	}

	[Token(Token = "0x60040C6")]
	[Address(RVA = "0xC0E630", Offset = "0xC0D430", Length = "0x158")]
	public void RemoveDynamicDecal(string guid)
	{
	}

	[Token(Token = "0x60040C7")]
	[Address(RVA = "0xC0E790", Offset = "0xC0D590", Length = "0x17A")]
	public bool AreAnyPlacedDecalsOfType(ProjectileType projectileType)
	{
		return false;
	}

	[Token(Token = "0x60040C8")]
	[Address(RVA = "0xC0E910", Offset = "0xC0D710", Length = "0x178")]
	public DecalProjectorInstance FindFirstDecalOfType(ProjectileType projectileType)
	{
		return null;
	}

	[Token(Token = "0x60040C9")]
	[Address(RVA = "0xC0EA90", Offset = "0xC0D890", Length = "0x15E")]
	private void RemoveDecalFromMap(DecalProjectorInstance decalInstance)
	{
	}

	[Token(Token = "0x60040CA")]
	[Address(RVA = "0xC0EBF0", Offset = "0xC0D9F0", Length = "0x153")]
	private void AddProjectorInstanceBoundsInfo(DecalProjectorInstance instance)
	{
	}

	[Token(Token = "0x60040CB")]
	[Address(RVA = "0xC0ED50", Offset = "0xC0DB50", Length = "0x66")]
	public void Update()
	{
	}

	[Token(Token = "0x60040CC")]
	[Address(RVA = "0xC0EDC0", Offset = "0xC0DBC0", Length = "0x5E1")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60040CD")]
	[Address(RVA = "0xC0F3B0", Offset = "0xC0E1B0", Length = "0x3D1")]
	public void UnlockDecalMapMarkersNearPosition(MapDetailUnlockParameters parameters)
	{
	}

	[Token(Token = "0x60040CE")]
	[Address(RVA = "0xC0F790", Offset = "0xC0E590", Length = "0x4B1")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60040CF")]
	[Address(RVA = "0xC0FC50", Offset = "0xC0EA50", Length = "0x200")]
	public bool TryGetStaticDecalUvs(string textureName, out Vector4 coordinates)
	{
		coordinates = default(Vector4);
		return false;
	}

	[Token(Token = "0x60040D0")]
	[Address(RVA = "0xC0FE60", Offset = "0xC0EC60", Length = "0x5D0")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x60040D1")]
	[Address(RVA = "0xC10440", Offset = "0xC0F240", Length = "0x9A")]
	public void ClearAllDecals()
	{
	}

	[Token(Token = "0x60040D2")]
	[Address(RVA = "0xC104E0", Offset = "0xC0F2E0", Length = "0xA")]
	public int GetNumberOfRemainingPlaceableDecals()
	{
		return 0;
	}

	[Token(Token = "0x60040D3")]
	[Address(RVA = "0xC104F0", Offset = "0xC0F2F0", Length = "0x2C8")]
	public DecalProjectorInstance CreateCustomDecal(string decalName, Vector3 pos, float yaw, Vector3 normal, Vector3 scale, DecalProjectorType projectorType, bool indoors, ProjectileType projectileType)
	{
		return null;
	}

	[Token(Token = "0x60040D4")]
	[Address(RVA = "0xC107C0", Offset = "0xC0F5C0", Length = "0x30B")]
	public DecalProjectorInstance CreateDecal(Vector3 pos, float yaw, Vector3 normal, int uvRectangleIndex, Vector3 scale, DecalProjectorType projectorType, bool indoors)
	{
		return null;
	}

	[Token(Token = "0x60040D5")]
	[Address(RVA = "0xC10AD0", Offset = "0xC0F8D0", Length = "0xD8")]
	public void AddStaticDecal(StaticDecal decal)
	{
	}

	[Token(Token = "0x60040D6")]
	[Address(RVA = "0xC10BB0", Offset = "0xC0F9B0", Length = "0x8C")]
	public void RemoveStaticDecal(StaticDecal decal)
	{
	}

	[Token(Token = "0x60040D7")]
	[Address(RVA = "0xC10C40", Offset = "0xC0FA40", Length = "0xC8")]
	public int LookupUVRectangleIndex(string name)
	{
		return 0;
	}

	[Token(Token = "0x60040D8")]
	[Address(RVA = "0xC10D10", Offset = "0xC0FB10", Length = "0xE7")]
	public bool CanCreateFootPrintsOnMaterial(GameObject materialGameObject)
	{
		return false;
	}

	[Token(Token = "0x60040D9")]
	[Address(RVA = "0xC10E00", Offset = "0xC0FC00", Length = "0xF0")]
	public void UpdateDecalProjectorLifeTimes()
	{
	}

	[Token(Token = "0x60040DA")]
	[Address(RVA = "0xC10F00", Offset = "0xC0FD00", Length = "0x70")]
	private float ComputeDecalProjectorLifeTime(DecalProjectorType projectorType, bool indoors, ProjectileType decalShape = ProjectileType.Bullet)
	{
		return 0f;
	}

	[Token(Token = "0x60040DB")]
	[Address(RVA = "0xC11190", Offset = "0xC0FF90", Length = "0x1C8")]
	private void RemoveOldestNonPlacedDecal()
	{
	}

	[Token(Token = "0x60040DC")]
	[Address(RVA = "0xC11360", Offset = "0xC10160", Length = "0xC3")]
	private void FadeDecal(int decalIdx)
	{
	}

	[Token(Token = "0x60040DD")]
	[Address(RVA = "0xC11430", Offset = "0xC10230", Length = "0x90")]
	private void InstantiateDecalProjectorInstances(int n)
	{
	}

	[Token(Token = "0x60040DE")]
	[Address(RVA = "0xC114D0", Offset = "0xC102D0", Length = "0x84")]
	public DecalProjectorInstance GetIntersectedSprayPaintDecal(DecalProjectorInstance decalToTestAgainst)
	{
		return null;
	}

	[Token(Token = "0x60040DF")]
	[Address(RVA = "0xC11560", Offset = "0xC10360", Length = "0x332")]
	public DecalProjectorInstance GetIntersectedSprayPaintDecal(Ray ray, float maxDistance)
	{
		return null;
	}

	[Token(Token = "0x60040E0")]
	[Address(RVA = "0xC118A0", Offset = "0xC106A0", Length = "0x265")]
	private DecalProjectorInstance GetIntersectedSprayPaintDecal(Bounds boundsToTestAgainst)
	{
		return null;
	}

	[Token(Token = "0x60040E1")]
	[Address(RVA = "0xC11B10", Offset = "0xC10910", Length = "0x62")]
	private int GetDecalCount()
	{
		return 0;
	}

	[Token(Token = "0x60040E2")]
	[Address(RVA = "0xC11B80", Offset = "0xC10980", Length = "0x23C")]
	private DecalProjectorInstance GetDecalProjectorInstanceFromPool()
	{
		return null;
	}

	[Token(Token = "0x60040E3")]
	[Address(RVA = "0xC11DC0", Offset = "0xC10BC0", Length = "0x1EC")]
	private void ReturnDecalProjectorInstanceToPool(DecalProjectorInstance dpi)
	{
	}

	[Token(Token = "0x60040E4")]
	[Address(RVA = "0xC11FB0", Offset = "0xC10DB0", Length = "0x3B")]
	private static bool ShouldSaveDynamicDecal(DecalProjectorInstance dpi)
	{
		return false;
	}

	[Token(Token = "0x60040E5")]
	[Address(RVA = "0xC11FF0", Offset = "0xC10DF0", Length = "0x1BA")]
	private void InitializeScreenSpaceDecals()
	{
	}

	[Token(Token = "0x60040E6")]
	[Address(RVA = "0xC121B0", Offset = "0xC10FB0", Length = "0x3AA")]
	private void InitializeMaskRendering()
	{
	}

	[Token(Token = "0x60040E7")]
	[Address(RVA = "0xC12560", Offset = "0xC11360", Length = "0x7A0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60040E8")]
	[Address(RVA = "0xC12D10", Offset = "0xC11B10", Length = "0x606")]
	private void CalculateDecalTransform(DecalProjectorInstance decal, DecalProjectorMaskData mask, out Vector3 position, out Quaternion rotation, out Vector3 scale)
	{
		position = default(Vector3);
		rotation = default(Quaternion);
		scale = default(Vector3);
	}

	[Token(Token = "0x60040E9")]
	[Address(RVA = "0xC13320", Offset = "0xC12120", Length = "0x71D")]
	private int RenderDynamicScreenSpaceDecals(Camera camera, List<DecalProjectorInstance> instances, int renderedDecalCount)
	{
		return 0;
	}

	[Token(Token = "0x60040EA")]
	[Address(RVA = "0xC13A40", Offset = "0xC12840", Length = "0xB57")]
	private void RenderDynamicDecal(DecalProjectorInstance decal, DecalProjectorMaskData maskData, RenderDecalParameters parameters, ref int renderedDecalCount)
	{
	}

	[Token(Token = "0x60040EB")]
	[Address(RVA = "0xC145A0", Offset = "0xC133A0", Length = "0x1670")]
	private int RenderStaticScreenSpaceDecals(Camera camera, List<StaticDecal> instances, int renderedDecalCount)
	{
		return 0;
	}

	[Token(Token = "0x60040EC")]
	[Address(RVA = "0xC15C20", Offset = "0xC14A20", Length = "0x204")]
	private void UpdateCommandBufferLightProbeSettings(CommandBuffer commandBuffer, Bounds decalBounds)
	{
	}

	[Token(Token = "0x60040ED")]
	[Address(RVA = "0xC15E30", Offset = "0xC14C30", Length = "0x8C")]
	private void RenderMasks()
	{
	}

	[Token(Token = "0x60040EE")]
	[Address(RVA = "0xC15EC0", Offset = "0xC14CC0", Length = "0x18A0")]
	private void RenderMaskForDecal(DecalProjectorInstance decal)
	{
	}

	[Token(Token = "0x60040EF")]
	[Address(RVA = "0xC17770", Offset = "0xC16570", Length = "0x35")]
	private void IncrementMaskTextureIndex()
	{
	}

	[Token(Token = "0x60040F0")]
	[Address(RVA = "0xC177B0", Offset = "0xC165B0", Length = "0x821")]
	private void CollectMasks(DecalProjectorInstance decal)
	{
	}

	[Token(Token = "0x60040F1")]
	[Address(RVA = "0xC17FE0", Offset = "0xC16DE0", Length = "0xA8")]
	public void OnQualityChange(QualityPostFx quality)
	{
	}

	[Token(Token = "0x60040F2")]
	[Address(RVA = "0xC180A0", Offset = "0xC16EA0", Length = "0x4D3")]
	public void InitializeCommandBuffers()
	{
	}

	[Token(Token = "0x60040F3")]
	[Address(RVA = "0xC18580", Offset = "0xC17380", Length = "0x9D5")]
	public DynamicDecalsManager()
	{
	}
}
