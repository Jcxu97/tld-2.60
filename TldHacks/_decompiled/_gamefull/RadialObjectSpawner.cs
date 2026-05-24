using System.Collections.Generic;
using Cpp2ILInjected;
using SuperSplines;
using UnityEngine;

[Token(Token = "0x20005A3")]
public class RadialObjectSpawner : MonoBehaviour
{
	[Token(Token = "0x20005A4")]
	private struct InvalidPositionTracker
	{
		[Token(Token = "0x4003426")]
		[FieldOffset(Offset = "0x0")]
		public int m_NoNavMesh;

		[Token(Token = "0x4003427")]
		[FieldOffset(Offset = "0x4")]
		public int m_MissedRayCast;

		[Token(Token = "0x6002BB5")]
		[Address(RVA = "0x922F00", Offset = "0x921D00", Length = "0xA")]
		public static implicit operator int(InvalidPositionTracker tracker)
		{
			return 0;
		}

		[Token(Token = "0x6002BB6")]
		[Address(RVA = "0x922F10", Offset = "0x921D10", Length = "0x12")]
		public static implicit operator InvalidPositionTracker(int value)
		{
			return default(InvalidPositionTracker);
		}
	}

	[Token(Token = "0x40033FE")]
	public const int MAX_INVALID_SPAWNS_BEFORE_DISABLE = 60;

	[Token(Token = "0x40033FF")]
	public static bool s_EnableVisChecks;

	[Token(Token = "0x4003400")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_ObjectToSpawn;

	[Token(Token = "0x4003401")]
	[FieldOffset(Offset = "0x28")]
	public float m_MinRadius;

	[Token(Token = "0x4003402")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MaxRadius;

	[Token(Token = "0x4003403")]
	[FieldOffset(Offset = "0x30")]
	public int m_MinToSpawn;

	[Token(Token = "0x4003404")]
	[FieldOffset(Offset = "0x34")]
	public int m_MaxToSpawn;

	[Tooltip("If set to zero, object will only spawn once")]
	[Token(Token = "0x4003405")]
	[FieldOffset(Offset = "0x38")]
	public float m_MinRespawnTimeGameHours;

	[Tooltip("If set to zero, object will only spawn once")]
	[Token(Token = "0x4003406")]
	[FieldOffset(Offset = "0x3C")]
	public float m_MaxRespawnTimeGameHours;

	[Token(Token = "0x4003407")]
	[FieldOffset(Offset = "0x40")]
	public bool m_AllowIndoorSpawn;

	[Token(Token = "0x4003408")]
	[FieldOffset(Offset = "0x44")]
	public float m_FloatHeight;

	[Token(Token = "0x4003409")]
	[FieldOffset(Offset = "0x48")]
	public bool m_AddRandomXRotation;

	[Tooltip("Offset the starting point of the raycast used to find a surface for the object to spawn on. Note that the raycast starts above ground and looks downward (-Y).")]
	[Token(Token = "0x400340A")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 m_RaycastOffset;

	[Header("Optional")]
	[Tooltip("If specified, loot table is used for selecting items to spawn")]
	[Token(Token = "0x400340B")]
	[FieldOffset(Offset = "0x58")]
	public LootTableData m_LootTableData;

	[Tooltip("If specified, spawns occur min/max randius from random point on spline")]
	[Token(Token = "0x400340C")]
	[FieldOffset(Offset = "0x60")]
	public Spline m_Spline;

	[Token(Token = "0x400340F")]
	[FieldOffset(Offset = "0x70")]
	private LootTableData m_OverrideLootTableData;

	[Token(Token = "0x4003410")]
	[FieldOffset(Offset = "0x78")]
	private float m_GameHourTimeToRespawn;

	[Token(Token = "0x4003411")]
	[FieldOffset(Offset = "0x7C")]
	private int m_NumToSpawn;

	[Token(Token = "0x4003412")]
	[FieldOffset(Offset = "0x80")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4003413")]
	[FieldOffset(Offset = "0x81")]
	private bool m_HasSpawned;

	[Token(Token = "0x4003414")]
	[FieldOffset(Offset = "0x88")]
	private GameObject m_NextPrefabToSpawn;

	[Token(Token = "0x4003415")]
	[FieldOffset(Offset = "0x90")]
	private float m_ObjectToSpawnBoundingRadius;

	[Token(Token = "0x4003416")]
	[FieldOffset(Offset = "0x94")]
	private InvalidPositionTracker m_NumSpawnAttemptsWithInvalidPositions;

	[Token(Token = "0x4003417")]
	[FieldOffset(Offset = "0xA0")]
	private readonly List<PendingSpawnData> m_PendingSpawns;

	[Token(Token = "0x4003418")]
	[FieldOffset(Offset = "0xA8")]
	private readonly List<GameObject> m_Spawns;

	[Token(Token = "0x4003419")]
	private static readonly RadialObjectSpawnerSaveData m_RadialObjectSpawnerSaveData;

	[Token(Token = "0x400341A")]
	private static readonly List<Vector3> m_PositionsList;

	[Token(Token = "0x400341B")]
	private static readonly List<Quaternion> m_RotationsList;

	[Token(Token = "0x400341C")]
	private static readonly List<string> m_PrefabNamesList;

	[Token(Token = "0x400341D")]
	private static readonly List<bool> m_UnlockedForDetailMapList;

	[Token(Token = "0x400341E")]
	private const float MAX_ACTIVATION_RANGE_FROM_OUTER_RADIUS = 120f;

	[Token(Token = "0x400341F")]
	private const float MIN_DIST_SPAWN_ONSCREEN = 100f;

	[Token(Token = "0x4003420")]
	private const float MIN_DIST_SPAWN_OFFSCREEN = 50f;

	[Token(Token = "0x4003421")]
	private const float MIN_DIST_SPAWN_ONSCREEN_SMALL_OBJECTS = 50f;

	[Token(Token = "0x4003422")]
	private const int NUM_SPLINE_POINTS_TO_COMPUTE_BOUNDING_RADIUS = 4;

	[Token(Token = "0x4003423")]
	[FieldOffset(Offset = "0xB0")]
	private readonly Vector3[] m_SplineSamplePoints;

	[Token(Token = "0x4003424")]
	[FieldOffset(Offset = "0xB8")]
	private float m_SplineBoundingRadius;

	[Token(Token = "0x4003425")]
	[FieldOffset(Offset = "0xBC")]
	private Vector3 m_SplineCenter;

	[Token(Token = "0x170002CB")]
	[field: Token(Token = "0x400340D")]
	[field: FieldOffset(Offset = "0x68")]
	public bool IsActive
	{
		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x4C3B90", Offset = "0x4C2990", Length = "0x5")]
		get;
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x91DC40", Offset = "0x91CA40", Length = "0x4")]
		set;
	}

	[Token(Token = "0x170002CC")]
	[field: Token(Token = "0x400340E")]
	[field: FieldOffset(Offset = "0x69")]
	public bool IsTidelineSpawner
	{
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x7AB110", Offset = "0x7A9F10", Length = "0x5")]
		get;
		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0x91DC50", Offset = "0x91CA50", Length = "0x4")]
		set;
	}

	[Token(Token = "0x170002CD")]
	private LootTableData ActiveLootTableData
	{
		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0x91DC60", Offset = "0x91CA60", Length = "0xDD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002B90")]
	[Address(RVA = "0x91DD40", Offset = "0x91CB40", Length = "0x265")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002B91")]
	[Address(RVA = "0x91DFB0", Offset = "0x91CDB0", Length = "0x4E")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002B92")]
	[Address(RVA = "0x644520", Offset = "0x643320", Length = "0x8")]
	public bool HasStartBeenCalled()
	{
		return false;
	}

	[Token(Token = "0x6002B93")]
	[Address(RVA = "0x91E000", Offset = "0x91CE00", Length = "0x395")]
	private void Start()
	{
	}

	[Token(Token = "0x6002B94")]
	[Address(RVA = "0x91E3A0", Offset = "0x91D1A0", Length = "0x3E")]
	public void SpawnAttemptAllNoVisChecks()
	{
	}

	[Token(Token = "0x6002B95")]
	[Address(RVA = "0x91E3E0", Offset = "0x91D1E0", Length = "0xA")]
	public bool SpawnAttemptOnceWithVisCheck()
	{
		return false;
	}

	[Token(Token = "0x6002B96")]
	[Address(RVA = "0x91E3F0", Offset = "0x91D1F0", Length = "0xC71")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002B97")]
	[Address(RVA = "0x91F070", Offset = "0x91DE70", Length = "0x2D9")]
	public bool Deserialize(string text)
	{
		return false;
	}

	[Token(Token = "0x6002B98")]
	[Address(RVA = "0x91F350", Offset = "0x91E150", Length = "0x85")]
	public void RemoveFromSpawns(GameObject go)
	{
	}

	[Token(Token = "0x6002B99")]
	[Address(RVA = "0x91F3E0", Offset = "0x91E1E0", Length = "0x23E")]
	public void ReleaseSpawnedObjectsToPool()
	{
	}

	[Token(Token = "0x6002B9A")]
	[Address(RVA = "0x91F620", Offset = "0x91E420", Length = "0x174")]
	public bool ShouldDisable()
	{
		return false;
	}

	[Token(Token = "0x6002B9B")]
	[Address(RVA = "0x91F7A0", Offset = "0x91E5A0", Length = "0x72")]
	public bool CanPotentiallySpawn()
	{
		return false;
	}

	[Token(Token = "0x6002B9C")]
	[Address(RVA = "0x91F820", Offset = "0x91E620", Length = "0x151")]
	public bool ShouldAttemptSpawning()
	{
		return false;
	}

	[Token(Token = "0x6002B9D")]
	[Address(RVA = "0x91F980", Offset = "0x91E780", Length = "0x48")]
	public bool HasChildren()
	{
		return false;
	}

	[Token(Token = "0x6002B9E")]
	[Address(RVA = "0x91F9D0", Offset = "0x91E7D0", Length = "0x17")]
	public bool ShouldDisableDueToInvalidPosition()
	{
		return false;
	}

	[Token(Token = "0x6002B9F")]
	[Address(RVA = "0x6E2390", Offset = "0x6E1190", Length = "0x8")]
	public bool HasSpawned()
	{
		return false;
	}

	[Token(Token = "0x6002BA0")]
	[Address(RVA = "0x658F10", Offset = "0x657D10", Length = "0x4")]
	public int NumToSpawn()
	{
		return 0;
	}

	[Token(Token = "0x6002BA1")]
	[Address(RVA = "0x91F9F0", Offset = "0x91E7F0", Length = "0xD4")]
	public void SetOverrideLootTableData(LootTableData overrideLootTableData)
	{
	}

	[Token(Token = "0x6002BA2")]
	[Address(RVA = "0x91FAD0", Offset = "0x91E8D0", Length = "0x36C")]
	public void ForceRefreshSpawnedItems(bool forceVisibilityCheck)
	{
	}

	[Token(Token = "0x6002BA3")]
	[Address(RVA = "0x91FE40", Offset = "0x91EC40", Length = "0x105")]
	public string PerformSceneValidationTest()
	{
		return null;
	}

	[Token(Token = "0x6002BA4")]
	[Address(RVA = "0x91FF50", Offset = "0x91ED50", Length = "0xE19")]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return false;
	}

	[Token(Token = "0x6002BA5")]
	[Address(RVA = "0x920D70", Offset = "0x91FB70", Length = "0x157")]
	private bool IsVisibleToPlayer(Vector3 position, float boundingRadius)
	{
		return false;
	}

	[Token(Token = "0x6002BA6")]
	[Address(RVA = "0x920ED0", Offset = "0x91FCD0", Length = "0x39C")]
	private GameObject SpawnPending(int index)
	{
		return null;
	}

	[Token(Token = "0x6002BA7")]
	[Address(RVA = "0x921270", Offset = "0x920070", Length = "0x222")]
	private GameObject GetNextPrefabToSpawn()
	{
		return null;
	}

	[Token(Token = "0x6002BA8")]
	[Address(RVA = "0x9214A0", Offset = "0x9202A0", Length = "0x2D0")]
	private GameObject SpawnAtPosition(GameObject prefabToSpawn, Vector3 posToSpawn, Quaternion orientToSpawn)
	{
		return null;
	}

	[Token(Token = "0x6002BA9")]
	[Address(RVA = "0x921780", Offset = "0x920580", Length = "0x132")]
	private void SetRepawnTime()
	{
	}

	[Token(Token = "0x6002BAA")]
	[Address(RVA = "0x9218C0", Offset = "0x9206C0", Length = "0x18C")]
	private void SetPendingSpawns(string[] prefabNames, Vector3[] positions, Quaternion[] rotations, bool[] detailMapUnlockStates)
	{
	}

	[Token(Token = "0x6002BAB")]
	[Address(RVA = "0x921A50", Offset = "0x920850", Length = "0x116")]
	private void CreatePendingSpawn(string prefabName, Vector3 pos, Quaternion rot, bool unlockedForDetailMap)
	{
	}

	[Token(Token = "0x6002BAC")]
	[Address(RVA = "0x921B70", Offset = "0x920970", Length = "0x265")]
	private void DisableSplineMeshUpdating()
	{
	}

	[Token(Token = "0x6002BAD")]
	[Address(RVA = "0x921DE0", Offset = "0x920BE0", Length = "0x260")]
	private void SetObjectToSpawnBoundingRadius()
	{
	}

	[Token(Token = "0x6002BAE")]
	[Address(RVA = "0x922050", Offset = "0x920E50", Length = "0x40B")]
	private void SetSplineBoundingRadius()
	{
	}

	[Token(Token = "0x6002BAF")]
	[Address(RVA = "0x922460", Offset = "0x921260", Length = "0x219")]
	private float GetDistanceFromOuterRadiusToCamera()
	{
		return 0f;
	}

	[Token(Token = "0x6002BB0")]
	[Address(RVA = "0x922680", Offset = "0x921480", Length = "0x18F")]
	private void RollRandomNumToSpawn()
	{
	}

	[Token(Token = "0x6002BB1")]
	[Address(RVA = "0x922810", Offset = "0x921610", Length = "0x74")]
	private bool GetUnlockedForDetailMap(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x6002BB2")]
	[Address(RVA = "0x922890", Offset = "0x921690", Length = "0x79")]
	private void SetUnlockedForDetailMap(GameObject go, bool unlocked)
	{
	}

	[Token(Token = "0x6002BB3")]
	[Address(RVA = "0x922910", Offset = "0x921710", Length = "0x23F")]
	public RadialObjectSpawner()
	{
	}
}
