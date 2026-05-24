using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using SWS;
using TLD.AI;
using TLD.Gameplay.Tunable;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x2000187")]
public class SpawnRegion : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000188")]
	public class DifficultyProperties
	{
		[Token(Token = "0x4000E55")]
		[FieldOffset(Offset = "0x10")]
		public int m_MaxSimultaneousSpawnsDay;

		[Token(Token = "0x4000E56")]
		[FieldOffset(Offset = "0x14")]
		public int m_MaxSimultaneousSpawnsNight;

		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x18")]
		public float m_MaxRespawnsPerDay;

		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public DifficultyProperties()
		{
		}
	}

	[Token(Token = "0x4000E12")]
	public const int DEFAULT_LEGACY_VALUE = -777;

	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_SpawnablePrefab;

	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_AuroraSpawnablePrefab;

	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0x30")]
	public SpawnRegionAnimalTableSO m_SpawnRegionAnimalTableSO;

	[Tooltip("Allows the prefab to spawn even when a blizzard is active.")]
	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0x38")]
	public bool m_CanSpawnInBlizzard;

	[Tooltip("Allows spawn regions to spawn wildlife, regardless of proximity to the player")]
	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0x39")]
	public bool m_OverrideDistanceToCamera;

	[Tooltip("Allows spawn regions to spawn wildlife, regardless if the player can see the spawn position")]
	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0x3A")]
	public bool m_OverrideCameraLineOfSight;

	[Tooltip("Force predators to spawn within the minimum time")]
	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0x3B")]
	public bool m_ForcePredatorOverride;

	[Tooltip("Register with manager during Awake() or manually registered by CougarTerritoryZoneTrigger")]
	[SerializeField]
	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_RegisterOnAwake;

	[Space(10f)]
	[Tooltip("Only give this SpawnRegion one chance to spawn on first encounter when set to true")]
	[SerializeField]
	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_OnlyOneChance;

	[Range(0f, 100f)]
	[Token(Token = "0x4000E1C")]
	[FieldOffset(Offset = "0x40")]
	public float m_ChanceActive;

	[Tooltip("Hour many game hours elapse before re-rolling if region is active.  Set to 0 to never re-roll")]
	[Range(0f, 24f)]
	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0x44")]
	public float m_HoursReRollActive;

	[Header("Dimensions")]
	[Token(Token = "0x4000E1E")]
	[FieldOffset(Offset = "0x48")]
	public float m_Radius;

	[NonSerialized]
	[Token(Token = "0x4000E1F")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 m_Center;

	[Tooltip("We need to look for spawn points from above mountain terrain. Make sure all terrain fits beneath Center.y + TopDownTerrainHeight")]
	[Token(Token = "0x4000E20")]
	[FieldOffset(Offset = "0x58")]
	public float m_TopDownTerrainHeight;

	[Tooltip("Only allow spawns lower than Center.y + SpawnHeightCap")]
	[Token(Token = "0x4000E21")]
	[FieldOffset(Offset = "0x5C")]
	public float m_SpawnHeightCap;

	[Header("WanderRegion")]
	[Token(Token = "0x4000E22")]
	[FieldOffset(Offset = "0x60")]
	public WanderRegion m_WanderRegion;

	[SerializeField]
	[Token(Token = "0x4000E23")]
	[FieldOffset(Offset = "0x68")]
	private DifficultyProperties[] m_DifficultySettings;

	[FormerlySerializedAs("m_MaxSimultaneousSpawnsDay")]
	[Obsolete]
	[Token(Token = "0x4000E24")]
	[FieldOffset(Offset = "0x70")]
	public int m_MaxSimultaneousSpawnsDayPilgrim;

	[FormerlySerializedAs("m_MaxSimultaneousSpawnsNight")]
	[Obsolete]
	[Token(Token = "0x4000E25")]
	[FieldOffset(Offset = "0x74")]
	public int m_MaxSimultaneousSpawnsNightPilgrim;

	[FormerlySerializedAs("m_MaxRespawnsPerDay")]
	[Obsolete]
	[Token(Token = "0x4000E26")]
	[FieldOffset(Offset = "0x78")]
	public float m_MaxRespawnsPerDayPilgrim;

	[FormerlySerializedAs("m_MaxSimultaneousSpawnsDay")]
	[Obsolete]
	[Token(Token = "0x4000E27")]
	[FieldOffset(Offset = "0x7C")]
	public int m_MaxSimultaneousSpawnsDayVoyageur;

	[FormerlySerializedAs("m_MaxSimultaneousSpawnsNight")]
	[Obsolete]
	[Token(Token = "0x4000E28")]
	[FieldOffset(Offset = "0x80")]
	public int m_MaxSimultaneousSpawnsNightVoyageur;

	[FormerlySerializedAs("m_MaxRespawnsPerDay")]
	[Obsolete]
	[Token(Token = "0x4000E29")]
	[FieldOffset(Offset = "0x84")]
	public float m_MaxRespawnsPerDayVoyageur;

	[FormerlySerializedAs("m_MaxSimultaneousSpawnsDay")]
	[Obsolete]
	[Token(Token = "0x4000E2A")]
	[FieldOffset(Offset = "0x88")]
	public int m_MaxSimultaneousSpawnsDayStalker;

	[FormerlySerializedAs("m_MaxSimultaneousSpawnsNight")]
	[Obsolete]
	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x8C")]
	public int m_MaxSimultaneousSpawnsNightStalker;

	[FormerlySerializedAs("m_MaxRespawnsPerDay")]
	[Obsolete]
	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x90")]
	public float m_MaxRespawnsPerDayStalker;

	[FormerlySerializedAs("m_MaxSimultaneousSpawnsDayNightmare")]
	[Obsolete]
	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x94")]
	public int m_MaxSimultaneousSpawnsDayInterloper;

	[FormerlySerializedAs("m_MaxSimultaneousSpawnsNightNightmare")]
	[Obsolete]
	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x98")]
	public int m_MaxSimultaneousSpawnsNightInterloper;

	[FormerlySerializedAs("m_MaxRespawnsPerDayNightmare")]
	[Obsolete]
	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0x9C")]
	public float m_MaxRespawnsPerDayInterloper;

	[Header("Difficulty")]
	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0xA0")]
	public AiDifficulty m_AiDifficulty;

	[Header("Pack")]
	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0xA8")]
	public string m_PackGroupId;

	[HideInInspector]
	[Token(Token = "0x4000E32")]
	[FieldOffset(Offset = "0xB0")]
	public AiType m_AiTypeSpawned;

	[HideInInspector]
	[Token(Token = "0x4000E33")]
	[FieldOffset(Offset = "0xB4")]
	public bool m_ControlledByRandomSpawner;

	[HideInInspector]
	[Token(Token = "0x4000E34")]
	[FieldOffset(Offset = "0xB5")]
	public bool m_WasEnabled;

	[HideInInspector]
	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0xB6")]
	public bool m_WasForceDisabled;

	[Token(Token = "0x4000E36")]
	[FieldOffset(Offset = "0xB8")]
	private WildlifeMode m_WildlifeMode;

	[Token(Token = "0x4000E37")]
	[FieldOffset(Offset = "0xC0")]
	private List<BaseAi> m_Spawns;

	[Token(Token = "0x4000E38")]
	[FieldOffset(Offset = "0xC8")]
	private List<AssetReferenceAnimalPrefab> m_SpawnsPrefabReferences;

	[Token(Token = "0x4000E39")]
	[FieldOffset(Offset = "0xD0")]
	private int m_NumRespawnsPending;

	[Token(Token = "0x4000E3A")]
	[FieldOffset(Offset = "0xD4")]
	private float m_ElapasedHoursNextRespawnAllowed;

	[Token(Token = "0x4000E3B")]
	[FieldOffset(Offset = "0xD8")]
	private float m_ElapsedHoursAtLastActiveReRoll;

	[Token(Token = "0x4000E3C")]
	[FieldOffset(Offset = "0xDC")]
	private float m_NumHoursBetweenRespawns;

	[Token(Token = "0x4000E3D")]
	[FieldOffset(Offset = "0xE0")]
	private int m_NumTrapped;

	[Token(Token = "0x4000E3E")]
	[FieldOffset(Offset = "0xE4")]
	private float m_HoursNextTrapReset;

	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0xE8")]
	private PathManager[] m_PathManagers;

	[Token(Token = "0x4000E40")]
	[FieldOffset(Offset = "0xF0")]
	private Den m_Den;

	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0xF8")]
	private int m_SpawnGuidCounter;

	[Token(Token = "0x4000E42")]
	[FieldOffset(Offset = "0xFC")]
	private int m_CurrentWaypointPathIndex;

	[Token(Token = "0x4000E43")]
	[FieldOffset(Offset = "0x100")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4000E44")]
	[FieldOffset(Offset = "0x104")]
	private float m_CooldownTimerHours;

	[Token(Token = "0x4000E45")]
	private static SpawnRegionDataProxy m_SpawnRegionDataProxy;

	[Token(Token = "0x4000E46")]
	private const int SPAWN_DATA_POOL_LEN = 128;

	[Token(Token = "0x4000E47")]
	private static SpawnDataProxy[] m_SpawnDataProxyPool;

	[Token(Token = "0x4000E48")]
	[FieldOffset(Offset = "0x108")]
	private List<SpawnDataProxy> m_DeferredSpawnsWithRandomPosition;

	[Token(Token = "0x4000E49")]
	[FieldOffset(Offset = "0x110")]
	private List<SpawnDataProxy> m_DeferredSpawnsWithSavedPosition;

	[Token(Token = "0x4000E4A")]
	[FieldOffset(Offset = "0x118")]
	private Queue<PendingSerializedRespawnInfo> m_PendingSerializedRespawnInfoQueue;

	[Token(Token = "0x4000E4B")]
	[FieldOffset(Offset = "0x120")]
	private WildlifeMode m_DeferredSpawnWildlifeMode;

	[Token(Token = "0x4000E4C")]
	[FieldOffset(Offset = "0x124")]
	private bool m_HasBeenDisabledByAurora;

	[Token(Token = "0x4000E4D")]
	[FieldOffset(Offset = "0x125")]
	private bool m_WasActiveBeforeAurora;

	[Token(Token = "0x4000E4E")]
	[FieldOffset(Offset = "0x128")]
	private AiSubType m_AiSubTypeSpawned;

	[Token(Token = "0x4000E4F")]
	[FieldOffset(Offset = "0x12C")]
	private WolfType m_WolfTypeSpawned;

	[Token(Token = "0x4000E50")]
	private const int MAX_SERIALIZED_RESPAWN_ATTEMPTS = 60;

	[Token(Token = "0x4000E51")]
	[FieldOffset(Offset = "0x130")]
	private CustomTunableNLMHV m_SpawnLevel;

	[Token(Token = "0x4000E52")]
	[FieldOffset(Offset = "0x134")]
	private int m_AutoCloneIndex;

	[Token(Token = "0x4000E53")]
	[FieldOffset(Offset = "0x138")]
	private string m_SpawnablePrefabName;

	[Token(Token = "0x4000E54")]
	[FieldOffset(Offset = "0x140")]
	private bool m_Registered;

	[Token(Token = "0x170001B6")]
	public AiSubType AiSubTypeSpawned
	{
		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x600BB0", Offset = "0x5FF9B0", Length = "0x7")]
		get
		{
			return default(AiSubType);
		}
	}

	[Token(Token = "0x6000ECC")]
	[Address(RVA = "0x600BC0", Offset = "0x5FF9C0", Length = "0x6F")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000ECD")]
	[Address(RVA = "0x600C30", Offset = "0x5FFA30", Length = "0x72")]
	public void MaybeRegisterWithManager()
	{
	}

	[Token(Token = "0x6000ECE")]
	[Address(RVA = "0x600CB0", Offset = "0x5FFAB0", Length = "0xB76")]
	public void Start()
	{
	}

	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0x601830", Offset = "0x600630", Length = "0x2CA")]
	public string GetSpawnablePrefabName()
	{
		return null;
	}

	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x601B00", Offset = "0x600900", Length = "0x68")]
	public void UpdateDeferredDeserializeFromManager()
	{
	}

	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x601B70", Offset = "0x600970", Length = "0x140")]
	public void UpdateFromManager()
	{
	}

	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0x601CC0", Offset = "0x600AC0", Length = "0x855")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x602520", Offset = "0x601320", Length = "0x282")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x6027B0", Offset = "0x6015B0", Length = "0x347")]
	public void RemoveFromSpawnRegion(BaseAi bai)
	{
	}

	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x602B00", Offset = "0x601900", Length = "0x89")]
	public void SetRespawnCooldownTimer(float cooldownHours)
	{
	}

	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x602B90", Offset = "0x601990", Length = "0xFE")]
	public bool CanTrap()
	{
		return false;
	}

	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x602C90", Offset = "0x601A90", Length = "0x7")]
	public void OnTrap()
	{
	}

	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x602CA0", Offset = "0x601AA0", Length = "0x1D4")]
	public void MaybeReRollActive()
	{
	}

	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x602E80", Offset = "0x601C80", Length = "0xD9")]
	public void OnAuroraEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x602F60", Offset = "0x601D60", Length = "0x146")]
	public Vector3[] GetWaypointCircuit()
	{
		return null;
	}

	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0x6030B0", Offset = "0x601EB0", Length = "0x177")]
	public bool ShouldSleepInDenAfterWaypointLoop()
	{
		return false;
	}

	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x603230", Offset = "0x602030", Length = "0x160")]
	public float GetDenSleepDurationInHours()
	{
		return 0f;
	}

	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0x6033A0", Offset = "0x6021A0", Length = "0x25E")]
	public WanderRegion GetWanderRegion(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x603600", Offset = "0x602400", Length = "0x28F")]
	public GameObject GetClosestActiveSpawn(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0x603890", Offset = "0x602690", Length = "0x88")]
	public void SetRandomWaypointCircuit()
	{
	}

	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x603920", Offset = "0x602720", Length = "0x332")]
	public void SetActive(bool active)
	{
	}

	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x603C60", Offset = "0x602A60", Length = "0x259")]
	public int GetNumActiveSpawns()
	{
		return 0;
	}

	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x603EC0", Offset = "0x602CC0", Length = "0x1EA")]
	private int GetCurrentActivePopulation(WildlifeMode wildlifeMode)
	{
		return 0;
	}

	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x6040B0", Offset = "0x602EB0", Length = "0x1B0")]
	private bool SpawnPositionOnScreenTooClose(Vector3 spawnPos)
	{
		return false;
	}

	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x604270", Offset = "0x603070", Length = "0x48")]
	private bool HasSerializedRespawnPending()
	{
		return false;
	}

	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0x6042C0", Offset = "0x6030C0", Length = "0x2B5")]
	private BaseAi MaybeSpawnPendingSerializedRespawn(WildlifeMode wildlifeMode)
	{
		return null;
	}

	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0x604580", Offset = "0x603380", Length = "0x3FB")]
	private bool Spawn(WildlifeMode wildlifeMode)
	{
		return false;
	}

	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0x604980", Offset = "0x603780", Length = "0x1D")]
	private bool HasSameWildlifeMode(BaseAi baseAi, WildlifeMode wildlifeMode)
	{
		return false;
	}

	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0x6049A0", Offset = "0x6037A0", Length = "0x4C")]
	private void AddActiveSpawns(int numToActivate, WildlifeMode wildlifeMode)
	{
	}

	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x6049F0", Offset = "0x6037F0", Length = "0x768")]
	private void RemoveActiveSpawns(int numToDeActivate, WildlifeMode wildlifeMode, bool isAdjustingOtherWildlifeMode)
	{
	}

	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x605160", Offset = "0x603F60", Length = "0x22F")]
	private bool SpawnRegionCloseEnoughForSpawning()
	{
		return false;
	}

	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x605390", Offset = "0x604190", Length = "0xCB")]
	private void Respawn(WildlifeMode wildlifeMode)
	{
	}

	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x605460", Offset = "0x604260", Length = "0x8B")]
	private bool RespawnAllowed()
	{
		return false;
	}

	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x6054F0", Offset = "0x6042F0", Length = "0x277")]
	private int CalculateTargetPopulation()
	{
		return 0;
	}

	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x605770", Offset = "0x604570", Length = "0x55")]
	private void AdjustOtherModePopulation()
	{
	}

	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x6057D0", Offset = "0x6045D0", Length = "0x24D")]
	private void AdjustActiveSpawnRegionPopulation()
	{
	}

	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0x605A20", Offset = "0x604820", Length = "0x105")]
	public static string GetPrefabNameFromInstanceName(string name)
	{
		return null;
	}

	[Token(Token = "0x6000EF1")]
	[Address(RVA = "0x605B30", Offset = "0x604930", Length = "0x401")]
	private BaseAi InstantiateSpawnInternal(GameObject spawnablePrefab, WildlifeMode wildlifetype, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0x605F40", Offset = "0x604D40", Length = "0x78B")]
	private BaseAi InstantiateSpawnFromSaveData(SpawnDataProxy spawnData, WildlifeMode wildlifeMode)
	{
		return null;
	}

	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0x6066D0", Offset = "0x6054D0", Length = "0x5DC")]
	private BaseAi InstantiateSpawn(GameObject spawnablePrefab, AssetReferenceAnimalPrefab animalReferencePrefab, Vector3 spawnPos, Quaternion spawnRotation, AiMode mode, WildlifeMode wildlifeMode)
	{
		return null;
	}

	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0x606CB0", Offset = "0x605AB0", Length = "0x113")]
	private bool PositionValidForSpawn(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0x606DD0", Offset = "0x605BD0", Length = "0x5FB")]
	private bool TryGetSpawnPositionAndRotation(ref Vector3 spawnPos, ref Quaternion spawnRotation)
	{
		return false;
	}

	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0x6073D0", Offset = "0x6061D0", Length = "0x46D")]
	private BaseAi InstantiateAndPlaceSpawn(WildlifeMode wildlifeMode)
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0x607840", Offset = "0x606640", Length = "0x64")]
	public static void LogWarning(string output, GameObject go = null)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000EF8")]
	[Address(RVA = "0x6078B0", Offset = "0x6066B0", Length = "0x64")]
	private static void Log(string output)
	{
	}

	[Token(Token = "0x6000EF9")]
	[Address(RVA = "0x607920", Offset = "0x606720", Length = "0x2DD")]
	private BaseAi AttemptInstantiateAndPlaceSpawnFromSave(WildlifeMode wildlifeMode, PendingSerializedRespawnInfo pendingSerializedRespawnInfo)
	{
		return null;
	}

	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0x607C00", Offset = "0x606A00", Length = "0x292")]
	private bool SpawnPositionTooCloseToCamera(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0x607EA0", Offset = "0x606CA0", Length = "0xD3")]
	private void QueueSerializedRespawnPending(SpawnDataProxy saveData)
	{
	}

	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0x607F80", Offset = "0x606D80", Length = "0xA5")]
	private void SpawnWithSavedPositions(List<SpawnDataProxy> spawns, WildlifeMode wildlifeMode)
	{
	}

	[Token(Token = "0x6000EFD")]
	[Address(RVA = "0x608030", Offset = "0x606E30", Length = "0x15B")]
	private void SpawnWithRandomPositions(List<SpawnDataProxy> spawns, WildlifeMode wildlifeMode)
	{
	}

	[Token(Token = "0x6000EFE")]
	[Address(RVA = "0x608190", Offset = "0x606F90", Length = "0x3A")]
	private bool CanDoReRoll()
	{
		return false;
	}

	[Token(Token = "0x6000EFF")]
	[Address(RVA = "0x6081D0", Offset = "0x606FD0", Length = "0xB8")]
	private void MaybeReduceNumTrapped()
	{
	}

	[Token(Token = "0x6000F00")]
	[Address(RVA = "0x608290", Offset = "0x607090", Length = "0x104")]
	private bool SpawningSupppressedByExperienceMode()
	{
		return false;
	}

	[Token(Token = "0x6000F01")]
	[Address(RVA = "0x6083A0", Offset = "0x6071A0", Length = "0x31C")]
	private void SetBoundingSphereBasedOnWaypoints(int waypointIndex)
	{
	}

	[Token(Token = "0x6000F02")]
	[Address(RVA = "0x6086C0", Offset = "0x6074C0", Length = "0x36")]
	private int GetMaxSimultaneousSpawnsDay()
	{
		return 0;
	}

	[Token(Token = "0x6000F03")]
	[Address(RVA = "0x608700", Offset = "0x607500", Length = "0x36")]
	private int GetMaxSimultaneousSpawnsNight()
	{
		return 0;
	}

	[Token(Token = "0x6000F04")]
	[Address(RVA = "0x608740", Offset = "0x607540", Length = "0xC2")]
	private float GetNumHoursBetweenRespawns()
	{
		return 0f;
	}

	[Token(Token = "0x6000F05")]
	[Address(RVA = "0x608810", Offset = "0x607610", Length = "0xBF")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000F06")]
	[Address(RVA = "0x6088D0", Offset = "0x6076D0", Length = "0x62")]
	private bool HasDeferredDeserializeCompleted()
	{
		return false;
	}

	[Token(Token = "0x6000F07")]
	[Address(RVA = "0x608940", Offset = "0x607740", Length = "0x171")]
	private void UpdateDeferredDeserialize()
	{
	}

	[Token(Token = "0x6000F08")]
	[Address(RVA = "0x608AC0", Offset = "0x6078C0", Length = "0xB")]
	private bool IsPredator()
	{
		return false;
	}

	[Token(Token = "0x6000F09")]
	[Address(RVA = "0x608AD0", Offset = "0x6078D0", Length = "0x61")]
	private void MaybeSuspendForAurora()
	{
	}

	[Token(Token = "0x6000F0A")]
	[Address(RVA = "0x608B40", Offset = "0x607940", Length = "0x3D")]
	private void MaybeResumeAfterAurora()
	{
	}

	[Token(Token = "0x6000F0B")]
	[Address(RVA = "0x608B80", Offset = "0x607980", Length = "0x537")]
	private float GetCustomSpawnRegionChanceActiveScale()
	{
		return 0f;
	}

	[Token(Token = "0x6000F0C")]
	[Address(RVA = "0x6090C0", Offset = "0x607EC0", Length = "0x3B1")]
	public SpawnRegion()
	{
	}
}
