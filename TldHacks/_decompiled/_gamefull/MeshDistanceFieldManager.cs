using System.Collections.Generic;
using Cpp2ILInjected;
using Hinterland.VFX.SDF;
using UnityEngine;

[Token(Token = "0x20008F7")]
public class MeshDistanceFieldManager : MonoBehaviour
{
	[Token(Token = "0x20008F8")]
	private struct SDFShaderIDs
	{
		[Token(Token = "0x4005E1D")]
		[FieldOffset(Offset = "0x0")]
		public int m_TextureID;

		[Token(Token = "0x4005E1E")]
		[FieldOffset(Offset = "0x4")]
		public int m_OriginID;

		[Token(Token = "0x4005E1F")]
		[FieldOffset(Offset = "0x8")]
		public int m_ScaleID;

		[Token(Token = "0x4005E20")]
		[FieldOffset(Offset = "0xC")]
		public int m_ScaleInverseID;

		[Token(Token = "0x4005E21")]
		[FieldOffset(Offset = "0x10")]
		public int m_AreaID;

		[Token(Token = "0x6005246")]
		[Address(RVA = "0xE463D0", Offset = "0xE451D0", Length = "0x6F")]
		public SDFShaderIDs(string texture, string origin, string scale, string scaleInverse, string area)
		{
			m_TextureID = 0;
			m_OriginID = 0;
			m_ScaleID = 0;
			m_ScaleInverseID = 0;
			m_AreaID = 0;
		}
	}

	[Token(Token = "0x20008F9")]
	private struct GlobalSDFInstance
	{
		[Token(Token = "0x4005E22")]
		[FieldOffset(Offset = "0x0")]
		public MeshDescriptor m_MeshDescriptor;

		[Token(Token = "0x4005E23")]
		[FieldOffset(Offset = "0x30")]
		public RenderTexture m_SDF;

		[Token(Token = "0x4005E24")]
		[FieldOffset(Offset = "0x38")]
		public Renderer m_Renderer;

		[Token(Token = "0x4005E25")]
		[FieldOffset(Offset = "0x40")]
		public Matrix4x4 m_Transform;

		[Token(Token = "0x4005E26")]
		[FieldOffset(Offset = "0x80")]
		public Vector3 m_BoxSize;

		[Token(Token = "0x4005E27")]
		[FieldOffset(Offset = "0x8C")]
		public Vector3 m_BoxCenterLocal;

		[Token(Token = "0x4005E28")]
		[FieldOffset(Offset = "0x98")]
		public Vector3 m_BoxCenterWorld;
	}

	[Token(Token = "0x20008FA")]
	private struct DistanceField
	{
		[Token(Token = "0x4005E29")]
		[FieldOffset(Offset = "0x0")]
		public RenderTexture m_SDF;

		[Token(Token = "0x4005E2A")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 m_BoxSize;
	}

	[Token(Token = "0x20008FB")]
	private struct MeshDescriptor
	{
		[Token(Token = "0x4005E2B")]
		[FieldOffset(Offset = "0x0")]
		public Mesh m_Mesh;

		[Token(Token = "0x4005E2C")]
		[FieldOffset(Offset = "0x8")]
		public int m_SubMeshIndex;

		[Token(Token = "0x4005E2D")]
		[FieldOffset(Offset = "0xC")]
		public Bounds m_Bounds;

		[Token(Token = "0x4005E2E")]
		[FieldOffset(Offset = "0x24")]
		public int m_SignPassesCount;

		[Token(Token = "0x4005E2F")]
		[FieldOffset(Offset = "0x28")]
		public float m_DistanceThreshold;

		[Token(Token = "0x4005E30")]
		[FieldOffset(Offset = "0x2C")]
		public float m_DistanceOffset;

		[Token(Token = "0x6005247")]
		[Address(RVA = "0xE46440", Offset = "0xE45240", Length = "0x1BF")]
		public override bool Equals(object obj)
		{
			return false;
		}

		[Token(Token = "0x6005248")]
		[Address(RVA = "0xE46600", Offset = "0xE45400", Length = "0x6E")]
		public override int GetHashCode()
		{
			return 0;
		}
	}

	[Token(Token = "0x20008FC")]
	public delegate void ProcessSDFMesh(Renderer renderer, Mesh mesh, MeshDistanceFieldSettings meshSettings);

	[Token(Token = "0x4005DFB")]
	[FieldOffset(Offset = "0x20")]
	public ComputeShader m_UpdateGlobalSDFShader;

	[Token(Token = "0x4005DFC")]
	[FieldOffset(Offset = "0x28")]
	public ComputeShader m_SDFRayMapComputeShader;

	[Token(Token = "0x4005DFD")]
	[FieldOffset(Offset = "0x30")]
	public Shader m_SDFRayMapShader;

	[Token(Token = "0x4005DFE")]
	[FieldOffset(Offset = "0x38")]
	public Shader[] m_ShaderExclusionList;

	[Token(Token = "0x4005DFF")]
	[FieldOffset(Offset = "0x40")]
	public string[] m_NameExclusions;

	[Token(Token = "0x4005E00")]
	[FieldOffset(Offset = "0x48")]
	public int m_MaxMeshesToUpdateEachFrame;

	[Token(Token = "0x4005E01")]
	[FieldOffset(Offset = "0x4C")]
	public int m_SignPassesCount;

	[Token(Token = "0x4005E02")]
	[FieldOffset(Offset = "0x50")]
	public float m_DistanceThreshold;

	[Token(Token = "0x4005E03")]
	[FieldOffset(Offset = "0x54")]
	public float m_DistanceOffset;

	[Token(Token = "0x4005E04")]
	[FieldOffset(Offset = "0x58")]
	private readonly SDFShaderIDs m_GlobalSDFShaderIDs;

	[Token(Token = "0x4005E05")]
	[FieldOffset(Offset = "0x6C")]
	private readonly SDFShaderIDs m_NearSDFShaderIDs;

	[Token(Token = "0x4005E06")]
	[FieldOffset(Offset = "0x80")]
	private readonly int m_TerrainHeightmapTextureID;

	[Token(Token = "0x4005E07")]
	[FieldOffset(Offset = "0x84")]
	private readonly int m_TerrainWorldPositionID;

	[Token(Token = "0x4005E08")]
	[FieldOffset(Offset = "0x88")]
	private readonly int m_TerrainWorldSizeID;

	[Token(Token = "0x4005E09")]
	[FieldOffset(Offset = "0x8C")]
	private readonly int m_TerrainVerticalSizeID;

	[Token(Token = "0x4005E0A")]
	[FieldOffset(Offset = "0x90")]
	private readonly int m_TerrainResolutionMinusOneID;

	[Token(Token = "0x4005E0B")]
	[FieldOffset(Offset = "0x94")]
	private readonly int m_InstanceSDFID;

	[Token(Token = "0x4005E0C")]
	[FieldOffset(Offset = "0x98")]
	private readonly int m_InstanceTransformID;

	[Token(Token = "0x4005E0D")]
	[FieldOffset(Offset = "0x9C")]
	private readonly int m_InstanceBoxSizeID;

	[Token(Token = "0x4005E0E")]
	[FieldOffset(Offset = "0xA0")]
	private readonly int m_InstanceBoxCenterID;

	[Token(Token = "0x4005E0F")]
	[FieldOffset(Offset = "0xA4")]
	private int m_ClearGlobalSDFKernel;

	[Token(Token = "0x4005E10")]
	[FieldOffset(Offset = "0xA8")]
	private int m_MergeTerrainToGlobalSDFKernel;

	[Token(Token = "0x4005E11")]
	[FieldOffset(Offset = "0xAC")]
	private int m_MergeInstanceToGlobalSDFKernel;

	[Token(Token = "0x4005E12")]
	private static bool s_DidWarnStaticBatchingUse;

	[Token(Token = "0x4005E13")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_Initialized;

	[Token(Token = "0x4005E14")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<MeshDescriptor, DistanceField> m_DistanceFields;

	[Token(Token = "0x4005E15")]
	[FieldOffset(Offset = "0xC0")]
	private Stack<MeshDescriptor> m_MeshesToUpdate;

	[Token(Token = "0x4005E16")]
	[FieldOffset(Offset = "0xC8")]
	private List<GlobalSDFInstance> m_GlobalSDFInstances;

	[Token(Token = "0x4005E17")]
	[FieldOffset(Offset = "0xD0")]
	private List<Terrain> m_ActiveTerrains;

	[Token(Token = "0x4005E18")]
	[FieldOffset(Offset = "0xD8")]
	private MeshToSDFBaker m_MeshToSDFBaker;

	[Token(Token = "0x4005E19")]
	[FieldOffset(Offset = "0xE0")]
	private RenderTexture m_GlobalSDF;

	[Token(Token = "0x4005E1A")]
	[FieldOffset(Offset = "0xE8")]
	private RenderTexture m_NearSDF;

	[Token(Token = "0x4005E1B")]
	[FieldOffset(Offset = "0xF0")]
	private SceneDistanceFieldSettings m_SceneSettings;

	[Token(Token = "0x4005E1C")]
	[FieldOffset(Offset = "0xF8")]
	private DistanceFieldShadows m_ShadowRenderer;

	[Token(Token = "0x6005235")]
	[Address(RVA = "0xE3FDD0", Offset = "0xE3EBD0", Length = "0x219")]
	public void UpdateGlobalSDF(Camera camera)
	{
	}

	[Token(Token = "0x6005236")]
	[Address(RVA = "0xE3FFF0", Offset = "0xE3EDF0", Length = "0x1A61")]
	private void UpdateSDF(Camera camera, RenderTexture sdfTexture, Vector3Int resolution, Vector3 area, SDFShaderIDs shaderIDs, bool skipTerrain)
	{
	}

	[Token(Token = "0x6005237")]
	[Address(RVA = "0xE41A60", Offset = "0xE40860", Length = "0x619")]
	public static void FindSDFMeshesFromCurrentScene(SceneDistanceFieldSettings settings, Shader[] shaderExclusions, string[] nameExclusions, ProcessSDFMesh processFunc)
	{
	}

	[Token(Token = "0x6005238")]
	[Address(RVA = "0xE42080", Offset = "0xE40E80", Length = "0x6E4")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6005239")]
	[Address(RVA = "0xE42770", Offset = "0xE41570", Length = "0xA4")]
	private bool CheckIfTerrainIsExcluded(Terrain terrain)
	{
		return false;
	}

	[Token(Token = "0x600523A")]
	[Address(RVA = "0xE42820", Offset = "0xE41620", Length = "0x8A4")]
	private static bool TryGetValidMesh(Renderer renderer, Shader[] shaderExclusions, string[] nameExclusions, out Mesh mesh, out MeshDistanceFieldSettings meshSettings)
	{
		mesh = null;
		meshSettings = null;
		return false;
	}

	[Token(Token = "0x600523B")]
	[Address(RVA = "0xE430D0", Offset = "0xE41ED0", Length = "0xEA7")]
	private void AddMeshToInstances(Renderer renderer, Mesh mesh, MeshDistanceFieldSettings meshSettings)
	{
	}

	[Token(Token = "0x600523C")]
	[Address(RVA = "0xE43F80", Offset = "0xE42D80", Length = "0x191")]
	private void Start()
	{
	}

	[Token(Token = "0x600523D")]
	[Address(RVA = "0xE44120", Offset = "0xE42F20", Length = "0x22")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600523E")]
	[Address(RVA = "0xE44150", Offset = "0xE42F50", Length = "0x58C")]
	private void Cleanup()
	{
	}

	[Token(Token = "0x600523F")]
	[Address(RVA = "0xE446E0", Offset = "0xE434E0", Length = "0x3C5")]
	private void EnableDistanceFieldShadowRenderer(bool isUsingSDFs)
	{
	}

	[Token(Token = "0x6005240")]
	[Address(RVA = "0x7696D0", Offset = "0x7684D0", Length = "0x45")]
	public bool IsSupported()
	{
		return false;
	}

	[Token(Token = "0x6005241")]
	[Address(RVA = "0xE44AB0", Offset = "0xE438B0", Length = "0x134")]
	public bool CanUseInCurrentScene()
	{
		return false;
	}

	[Token(Token = "0x6005242")]
	[Address(RVA = "0xE44BF0", Offset = "0xE439F0", Length = "0x8F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6005243")]
	[Address(RVA = "0xE454F0", Offset = "0xE442F0", Length = "0x284")]
	private bool ComputeMeshVolumeSize(MeshDescriptor meshDescriptor, out Vector3Int volumeResolution)
	{
		volumeResolution = default(Vector3Int);
		return false;
	}

	[Token(Token = "0x6005244")]
	[Address(RVA = "0xE45780", Offset = "0xE44580", Length = "0x53B")]
	private Mesh CopyMesh(Mesh source)
	{
		return null;
	}

	[Token(Token = "0x6005245")]
	[Address(RVA = "0xE45CC0", Offset = "0xE44AC0", Length = "0x70C")]
	public MeshDistanceFieldManager()
	{
	}
}
