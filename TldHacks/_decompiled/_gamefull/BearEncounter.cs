using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200015F")]
public class BearEncounter : MonoBehaviour
{
	[Token(Token = "0x2000160")]
	public enum BearSpawnState
	{
		[Token(Token = "0x4000D04")]
		None,
		[Token(Token = "0x4000D05")]
		RequestBearSpawn,
		[Token(Token = "0x4000D06")]
		BearSpawned,
		[Token(Token = "0x4000D07")]
		BearDespawned
	}

	[Token(Token = "0x2000161")]
	public enum BearSpawnEncounterResult
	{
		[Token(Token = "0x4000D09")]
		None,
		[Token(Token = "0x4000D0A")]
		Won,
		[Token(Token = "0x4000D0B")]
		Failed,
		[Token(Token = "0x4000D0C")]
		Abandoned
	}

	[Token(Token = "0x2000162")]
	public enum PostStruggleBehavior
	{
		[Token(Token = "0x4000D0E")]
		FleeToMaxRangeThenDespawn,
		[Token(Token = "0x4000D0F")]
		FleeToDistanceWanderAround
	}

	[SerializeField]
	[Token(Token = "0x4000CDE")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Header("Bear")]
	[Token(Token = "0x4000CDF")]
	[FieldOffset(Offset = "0x28")]
	public float m_DelaySpawnSeconds;

	[Token(Token = "0x4000CE0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_BearPrefab;

	[Tooltip("Fallback start point for the bear. Set BearForceStartLocation to always use.")]
	[Token(Token = "0x4000CE1")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_BearStart;

	[Tooltip("If true, will force the use of the BearStart position rather than trying to calculate a start position in MaxRadius-MinRadius")]
	[Token(Token = "0x4000CE2")]
	[FieldOffset(Offset = "0x40")]
	public bool m_BearStartForceLocation;

	[Tooltip("If specified, if the player _successfully_ spears the bear, will flee toward the specified object's position")]
	[Token(Token = "0x4000CE3")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_BearFleeDestination;

	[Token(Token = "0x4000CE4")]
	[FieldOffset(Offset = "0x50")]
	public float m_MinRadius;

	[Token(Token = "0x4000CE5")]
	[FieldOffset(Offset = "0x54")]
	public float m_MaxRadius;

	[Token(Token = "0x4000CE6")]
	[FieldOffset(Offset = "0x58")]
	public float m_FloatHeight;

	[Token(Token = "0x4000CE7")]
	[FieldOffset(Offset = "0x60")]
	public BearHuntReduxSettings m_BearHuntReduxSettings;

	[Token(Token = "0x4000CE8")]
	[FieldOffset(Offset = "0x68")]
	private GearItem m_HangingItem;

	[Token(Token = "0x4000CE9")]
	[FieldOffset(Offset = "0x70")]
	private float m_CurrentTimerSpawnSeconds;

	[Token(Token = "0x4000CEA")]
	[FieldOffset(Offset = "0x74")]
	private BearSpawnState m_BearSpawnState;

	[Token(Token = "0x4000CEB")]
	[FieldOffset(Offset = "0x78")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4000CEC")]
	[FieldOffset(Offset = "0x80")]
	private BaseAi m_BearBaseAi;

	[Token(Token = "0x4000CED")]
	[FieldOffset(Offset = "0x88")]
	private int m_NumSpawnAttemptsWithInvalidPositions;

	[Token(Token = "0x4000CEE")]
	[FieldOffset(Offset = "0x8C")]
	private float m_ObjectToSpawnBoundingRadius;

	[Token(Token = "0x4000CEF")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 m_InvestigatePosition;

	[Token(Token = "0x4000CF0")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_IsEncounterEnabled;

	[Token(Token = "0x4000CF1")]
	[FieldOffset(Offset = "0x9D")]
	private bool m_HasSelectedInvestigatePosition;

	[Token(Token = "0x4000CF2")]
	[FieldOffset(Offset = "0xA0")]
	private float m_RandomAngleStart;

	[Token(Token = "0x4000CF3")]
	[FieldOffset(Offset = "0xA4")]
	private int m_CurrentAttemptFindLocationIndex;

	[Token(Token = "0x4000CF4")]
	public static List<BearEncounter> s_BearEncounters;

	[Token(Token = "0x4000CF5")]
	private static bool s_FindBearRequested;

	[Token(Token = "0x4000CF6")]
	private static BearEncounterSaveData s_BearEncounterSaveData;

	[Token(Token = "0x4000CF7")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_RefreshSpawnedBearAiAfterLoadRequested;

	[Token(Token = "0x4000CF8")]
	[FieldOffset(Offset = "0xAC")]
	private PlayerControlMode m_RestoreControlMode;

	[Token(Token = "0x4000CF9")]
	[FieldOffset(Offset = "0xB0")]
	private BearSpawnEncounterResult m_LatestEncounterResult;

	[Token(Token = "0x4000CFA")]
	[FieldOffset(Offset = "0xB4")]
	private bool m_LastEncounter;

	[Token(Token = "0x4000CFB")]
	[FieldOffset(Offset = "0xB8")]
	private PostStruggleBehavior m_PostStruggleBehavior;

	[Token(Token = "0x4000CFC")]
	[FieldOffset(Offset = "0xC0")]
	private MissionObjectIdentifier m_MissionObjectIdentifier;

	[Token(Token = "0x4000CFD")]
	private const float MIN_DIST_SPAWN_ONSCREEN = 90f;

	[Token(Token = "0x4000CFE")]
	private const float MIN_DIST_SPAWN_OFFSCREEN = 30f;

	[Token(Token = "0x4000CFF")]
	private const int MAX_INVALID_SPAWNS = 100;

	[Token(Token = "0x4000D00")]
	private const float MIN_SPAWN_RADIUS = 2f;

	[Token(Token = "0x4000D01")]
	private const float RADIUS_FOR_ENCOUNTER_INVESTIGATE = 5f;

	[Token(Token = "0x4000D02")]
	private const int MAX_STEPS_AROUND_PLACEPOINT = 5;

	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x5DCA70", Offset = "0x5DB870", Length = "0x5B6")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x5DD030", Offset = "0x5DBE30", Length = "0xCD")]
	public void Start()
	{
	}

	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x5DD100", Offset = "0x5DBF00", Length = "0x82")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x5DD190", Offset = "0x5DBF90", Length = "0x7")]
	public void SetLastEncounter(bool isLastEncounter)
	{
	}

	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x5DD1A0", Offset = "0x5DBFA0", Length = "0x1AB")]
	public void SetPostStruggleBehavior(PostStruggleBehavior postStruggleBehavior)
	{
	}

	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x5DD350", Offset = "0x5DC150", Length = "0x7")]
	public PostStruggleBehavior GetPostStruggleBehavior()
	{
		return default(PostStruggleBehavior);
	}

	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x5DD360", Offset = "0x5DC160", Length = "0x8")]
	public bool IsLastEncounter()
	{
		return false;
	}

	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x5DD370", Offset = "0x5DC170", Length = "0x18C")]
	public void EncounterWon()
	{
	}

	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x5DD500", Offset = "0x5DC300", Length = "0x18A")]
	public void EncounterFailed(BearSpawnEncounterResult result)
	{
	}

	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x5DD690", Offset = "0x5DC490", Length = "0x1A6")]
	private void SelectInvestigatePosition()
	{
	}

	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x5DD840", Offset = "0x5DC640", Length = "0x1CF")]
	private void MaybeRefreshSpawnedBearAiAfterLoad()
	{
	}

	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x5DDA10", Offset = "0x5DC810", Length = "0x118")]
	private void UpdateBearSpawn()
	{
	}

	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x5DDB30", Offset = "0x5DC930", Length = "0x599")]
	private void UpdateBearDespawn()
	{
	}

	[Token(Token = "0x6000DCE")]
	[Address(RVA = "0x5DE0D0", Offset = "0x5DCED0", Length = "0x361")]
	public void Update()
	{
	}

	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0x5DE440", Offset = "0x5DD240", Length = "0x8")]
	public void ResetSpawnBearTimer()
	{
	}

	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0x5DE450", Offset = "0x5DD250", Length = "0x1EC")]
	public void Activate(bool enableInteraction)
	{
	}

	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0x5DE640", Offset = "0x5DD440", Length = "0x4BF")]
	private void InstantiateBear(Vector3 position)
	{
	}

	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0x5DEB00", Offset = "0x5DD900", Length = "0x360")]
	public void SpawnBear()
	{
	}

	[Token(Token = "0x6000DD3")]
	[Address(RVA = "0x5DEE70", Offset = "0x5DDC70", Length = "0x8")]
	public bool IsEncounterActivated()
	{
		return false;
	}

	[Token(Token = "0x6000DD4")]
	[Address(RVA = "0x5DEE80", Offset = "0x5DDC80", Length = "0xB")]
	public bool HasWonLatestEncounter()
	{
		return false;
	}

	[Token(Token = "0x6000DD5")]
	[Address(RVA = "0x5DEE90", Offset = "0x5DDC90", Length = "0x7")]
	public BearSpawnEncounterResult GetLatestEncounterResult()
	{
		return default(BearSpawnEncounterResult);
	}

	[Token(Token = "0x6000DD6")]
	[Address(RVA = "0x5DEEA0", Offset = "0x5DDCA0", Length = "0x34A")]
	private void RefreshSpawnedBearSettings(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[Token(Token = "0x6000DD7")]
	[Address(RVA = "0x5DF1F0", Offset = "0x5DDFF0", Length = "0x121")]
	private void UpdateSpawnedBear(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[Token(Token = "0x6000DD8")]
	[Address(RVA = "0x5DF320", Offset = "0x5DE120", Length = "0x2FB")]
	private void InitializeSpawnedBearData(GameObject go)
	{
	}

	[Token(Token = "0x6000DD9")]
	[Address(RVA = "0x5DF620", Offset = "0x5DE420", Length = "0x289")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6000DDA")]
	[Address(RVA = "0x5DF8B0", Offset = "0x5DE6B0", Length = "0x216")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0x5DFAD0", Offset = "0x5DE8D0", Length = "0xEF")]
	public string GetMissionObjectId()
	{
		return null;
	}

	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x5DFBC0", Offset = "0x5DE9C0", Length = "0x3B7")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0x5DFF80", Offset = "0x5DED80", Length = "0x1F4")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0x5E0180", Offset = "0x5DEF80", Length = "0x840")]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return false;
	}

	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0x5E09D0", Offset = "0x5DF7D0", Length = "0x2E0")]
	private bool AttemptFindingValidInvestigateLocation()
	{
		return false;
	}

	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x5E0CC0", Offset = "0x5DFAC0", Length = "0x117")]
	public static BearEncounter FindByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x5E0DE0", Offset = "0x5DFBE0", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x5E0E80", Offset = "0x5DFC80", Length = "0x19F")]
	public static int GetCurrentActiveBearEncounterCountInScene()
	{
		return 0;
	}

	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x5E1020", Offset = "0x5DFE20", Length = "0x181")]
	public static BearEncounter GetCurrentActiveBearEncounter()
	{
		return null;
	}

	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BearEncounter()
	{
	}
}
