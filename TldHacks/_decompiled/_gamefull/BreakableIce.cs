using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Terrain))]
[Token(Token = "0x20008DB")]
public class BreakableIce : MonoBehaviour
{
	[Token(Token = "0x20008DC")]
	private struct BrokenIce
	{
		[Token(Token = "0x4005CBB")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 m_Position;

		[Token(Token = "0x4005CBC")]
		[FieldOffset(Offset = "0x8")]
		public float m_Radius;

		[Token(Token = "0x4005CBD")]
		[FieldOffset(Offset = "0xC")]
		public float m_PlacementDay;
	}

	[Token(Token = "0x4005C9F")]
	private const int MAX_BROKEN_ICE_DATA = 100;

	[Token(Token = "0x4005CA0")]
	private const int MAX_VORONOI_POINT_SETS_X = 1;

	[Token(Token = "0x4005CA1")]
	private const int MAX_VORONOI_POINT_SETS_Y = 1;

	[Token(Token = "0x4005CA2")]
	private const int MAX_VORONOI_POINT_SETS = 1;

	[Header("Gameplay")]
	[Range(0f, 28f)]
	[Tooltip("How many days it takes for broken ice to freeze over.")]
	[SerializeField]
	[Token(Token = "0x4005CA3")]
	[FieldOffset(Offset = "0x20")]
	private float m_RefreezeDays;

	[Range(0f, 5f)]
	[Tooltip("How close to broken ice the player can go before falling in.")]
	[SerializeField]
	[Token(Token = "0x4005CA4")]
	[FieldOffset(Offset = "0x24")]
	private float m_FallInDistance;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4005CA5")]
	[FieldOffset(Offset = "0x28")]
	private string m_BrokenIceAudioId;

	[Range(1f, 100f)]
	[SerializeField]
	[Token(Token = "0x4005CA6")]
	[FieldOffset(Offset = "0x30")]
	private int m_EmitterCount;

	[Header("Navmesh Cuts")]
	[Range(1f, 10f)]
	[SerializeField]
	[Token(Token = "0x4005CA7")]
	[FieldOffset(Offset = "0x34")]
	private float m_NavmeshCutScale;

	[Header("Rendering")]
	[Range(1f, 10f)]
	[Tooltip("Dimensions of a tile.")]
	[SerializeField]
	[Token(Token = "0x4005CA8")]
	[FieldOffset(Offset = "0x38")]
	private int m_TileSize;

	[Range(0f, 5f)]
	[Tooltip("Scales the size of the holes created in broken ice")]
	[SerializeField]
	[Token(Token = "0x4005CA9")]
	[FieldOffset(Offset = "0x3C")]
	private float m_IceBreakScale;

	[SerializeField]
	[Token(Token = "0x4005CAA")]
	[FieldOffset(Offset = "0x40")]
	private VoronoiPointSet[] m_VoronoiPointSets;

	[Token(Token = "0x4005CAB")]
	[FieldOffset(Offset = "0x48")]
	private Terrain m_Terrain;

	[Token(Token = "0x4005CAC")]
	[FieldOffset(Offset = "0x50")]
	private int m_BrokenIceTextureId;

	[Token(Token = "0x4005CAD")]
	[FieldOffset(Offset = "0x54")]
	private int m_RenderTargetExtentsId;

	[Token(Token = "0x4005CAE")]
	[FieldOffset(Offset = "0x58")]
	private int m_TileSizeId;

	[Token(Token = "0x4005CAF")]
	[FieldOffset(Offset = "0x5C")]
	private int m_VoronoiPointSetsId;

	[Token(Token = "0x4005CB0")]
	[FieldOffset(Offset = "0x60")]
	private BrokenIce[] m_BrokenIceData;

	[Token(Token = "0x4005CB1")]
	[FieldOffset(Offset = "0x68")]
	private int m_BrokenIceDataWriteIndex;

	[Token(Token = "0x4005CB2")]
	[FieldOffset(Offset = "0x6C")]
	private int m_BrokenIceDataRemoveIndex;

	[Token(Token = "0x4005CB3")]
	[FieldOffset(Offset = "0x70")]
	private BitmaskTexture m_BrokenIceTexture;

	[Token(Token = "0x4005CB4")]
	[FieldOffset(Offset = "0x78")]
	private Vector4[] m_VoronoiPointsSetsForShader;

	[Token(Token = "0x4005CB5")]
	[FieldOffset(Offset = "0x80")]
	private GameObject[] m_AudioEmitters;

	[Token(Token = "0x4005CB6")]
	[FieldOffset(Offset = "0x88")]
	private float[] m_NearestEmitterDistances;

	[Token(Token = "0x4005CB7")]
	[FieldOffset(Offset = "0x90")]
	private NavMeshObstacle[] m_NavMeshObstacles;

	[Token(Token = "0x4005CB8")]
	private static BreakableIceComponentSaveDataProxy m_BreakableIceComponentSaveDataProxy;

	[Token(Token = "0x4005CB9")]
	private static BrokenIceSaveDataProxy m_BrokenIceSaveDataProxy;

	[Token(Token = "0x4005CBA")]
	private static List<BreakableIce> m_Instances;

	[Token(Token = "0x6005156")]
	[Address(RVA = "0xE23120", Offset = "0xE21F20", Length = "0x143")]
	private void Start()
	{
	}

	[Token(Token = "0x6005157")]
	[Address(RVA = "0xE23270", Offset = "0xE22070", Length = "0x7FD")]
	private void Update()
	{
	}

	[Token(Token = "0x6005158")]
	[Address(RVA = "0xE23A70", Offset = "0xE22870", Length = "0x144")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005159")]
	[Address(RVA = "0xE23BC0", Offset = "0xE229C0", Length = "0x109")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600515A")]
	[Address(RVA = "0xE23CD0", Offset = "0xE22AD0", Length = "0x556")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600515B")]
	[Address(RVA = "0xE24230", Offset = "0xE23030", Length = "0x1FF")]
	public void Deserialize(BreakableIceComponentSaveDataProxy proxy)
	{
	}

	[Token(Token = "0x600515C")]
	[Address(RVA = "0xE24430", Offset = "0xE23230", Length = "0x32F")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x600515D")]
	[Address(RVA = "0xE24760", Offset = "0xE23560", Length = "0x26F")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x600515E")]
	[Address(RVA = "0xE249D0", Offset = "0xE237D0", Length = "0x824")]
	public void BreakIce(Vector3 pos, float radius)
	{
	}

	[Token(Token = "0x600515F")]
	[Address(RVA = "0xE25200", Offset = "0xE24000", Length = "0x2B8")]
	public bool IsIceBroken(Vector3 position)
	{
		return false;
	}

	[Token(Token = "0x6005160")]
	[Address(RVA = "0xE254C0", Offset = "0xE242C0", Length = "0x1B5")]
	public bool IsIceBroken(Vector3 position, float radius)
	{
		return false;
	}

	[Token(Token = "0x6005161")]
	[Address(RVA = "0xE25680", Offset = "0xE24480", Length = "0x9F")]
	public bool IsInDangerOfFallingIn(Vector3 position)
	{
		return false;
	}

	[Token(Token = "0x6005162")]
	[Address(RVA = "0xE25720", Offset = "0xE24520", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6005163")]
	[Address(RVA = "0xE257C0", Offset = "0xE245C0", Length = "0x2AA")]
	private void AddBrokenIceToNavmeshCuts(int index)
	{
	}

	[Token(Token = "0x6005164")]
	[Address(RVA = "0xE25A70", Offset = "0xE24870", Length = "0x29D")]
	private void AddBrokenIceToTexture(int index)
	{
	}

	[Token(Token = "0x6005165")]
	[Address(RVA = "0xE25D10", Offset = "0xE24B10", Length = "0x156")]
	private void AddBrokenIceToTexture(Vector2 position)
	{
	}

	[Token(Token = "0x6005166")]
	[Address(RVA = "0xE25E70", Offset = "0xE24C70", Length = "0x29D")]
	private void RemoveBrokenIceFromTexture(int index)
	{
	}

	[Token(Token = "0x6005167")]
	[Address(RVA = "0xE26110", Offset = "0xE24F10", Length = "0x158")]
	private void RemoveBrokenIceFromTexture(Vector2 position)
	{
	}

	[Token(Token = "0x6005168")]
	[Address(RVA = "0xE26270", Offset = "0xE25070", Length = "0x39")]
	private BrokenIce GetOldestBrokenIce()
	{
		return default(BrokenIce);
	}

	[Token(Token = "0x6005169")]
	[Address(RVA = "0xE262B0", Offset = "0xE250B0", Length = "0x7E")]
	private VoronoiPointSet GetVoronoiPointSet(Vector2 tile)
	{
		return null;
	}

	[Token(Token = "0x600516A")]
	[Address(RVA = "0xE26330", Offset = "0xE25130", Length = "0x430")]
	private void InitializeAudioEmitters()
	{
	}

	[Token(Token = "0x600516B")]
	[Address(RVA = "0xE26770", Offset = "0xE25570", Length = "0x426")]
	private void InitializeBrokenIceTexture()
	{
	}

	[Token(Token = "0x600516C")]
	[Address(RVA = "0xE26BA0", Offset = "0xE259A0", Length = "0x7BF")]
	private void InitializeNavmeshCuts()
	{
	}

	[Token(Token = "0x600516D")]
	[Address(RVA = "0xE27360", Offset = "0xE26160", Length = "0xA7")]
	private void InitializeShaderProperties()
	{
	}

	[Token(Token = "0x600516E")]
	[Address(RVA = "0xE27410", Offset = "0xE26210", Length = "0x226")]
	private void RemoveExpiredBrokenIce()
	{
	}

	[Token(Token = "0x600516F")]
	[Address(RVA = "0xE27640", Offset = "0xE26440", Length = "0x8C")]
	private void RemoveOldestBrokenIce()
	{
	}

	[Token(Token = "0x6005170")]
	[Address(RVA = "0xE276D0", Offset = "0xE264D0", Length = "0x509")]
	private void UpdateAudioEmitters(Vector3 listenerPosition)
	{
	}

	[Token(Token = "0x6005171")]
	[Address(RVA = "0xE27BE0", Offset = "0xE269E0", Length = "0x399")]
	private static BreakableIce FindBreakableIceByPosition(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6005172")]
	[Address(RVA = "0xE27F80", Offset = "0xE26D80", Length = "0x2C1")]
	public BreakableIce()
	{
	}
}
