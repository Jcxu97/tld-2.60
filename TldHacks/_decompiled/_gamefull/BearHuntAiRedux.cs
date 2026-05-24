using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001CD")]
public class BearHuntAiRedux : MonoBehaviour
{
	[Token(Token = "0x20001CE")]
	public delegate void OnBearSpearOutcomeAction(bool success);

	[Token(Token = "0x4000FA5")]
	[FieldOffset(Offset = "0x20")]
	private bool m_BearEarGiven;

	[Token(Token = "0x4000FA6")]
	private static BearHuntAiReduxSaveData m_BearHuntAiReduxSaveData;

	[Token(Token = "0x4000FA7")]
	[FieldOffset(Offset = "0x24")]
	private float m_InitialCheckHasMovedDelaySeconds;

	[Token(Token = "0x4000FA8")]
	[FieldOffset(Offset = "0x28")]
	private BaseAi m_BearBaseAi;

	[Token(Token = "0x4000FA9")]
	[FieldOffset(Offset = "0x30")]
	public bool m_UseForceBearFleePosition;

	[Token(Token = "0x4000FAA")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 m_ForceBearFleePosition;

	[Token(Token = "0x4000FAB")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_BearEarPrefab;

	[Token(Token = "0x4000FAC")]
	[FieldOffset(Offset = "0x48")]
	private BearEncounter m_CurrentBearEncounter;

	[Token(Token = "0x4000FAD")]
	[FieldOffset(Offset = "0x50")]
	private BearEncounter.PostStruggleBehavior m_PostStruggleBehavior;

	[Token(Token = "0x600106B")]
	[Address(RVA = "0x627DD0", Offset = "0x626BD0", Length = "0x8C")]
	public void Awake()
	{
	}

	[Token(Token = "0x600106C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x600106D")]
	[Address(RVA = "0x627E60", Offset = "0x626C60", Length = "0x14B")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600106E")]
	[Address(RVA = "0x627FB0", Offset = "0x626DB0", Length = "0xAD")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600106F")]
	[Address(RVA = "0x504310", Offset = "0x503110", Length = "0x6")]
	public float GetInitialCheckHasMovedDelaySeconds()
	{
		return 0f;
	}

	[Token(Token = "0x6001070")]
	[Address(RVA = "0x628060", Offset = "0x626E60", Length = "0x356")]
	public bool CanDespawn(float radius)
	{
		return false;
	}

	[Token(Token = "0x6001071")]
	[Address(RVA = "0x6283C0", Offset = "0x6271C0", Length = "0x8")]
	public bool CanTakeBearEar()
	{
		return false;
	}

	[Token(Token = "0x6001072")]
	[Address(RVA = "0x6283D0", Offset = "0x6271D0", Length = "0x1D6")]
	public GearItem TakeBearEar()
	{
		return null;
	}

	[Token(Token = "0x6001073")]
	[Address(RVA = "0x6285B0", Offset = "0x6273B0", Length = "0x4")]
	public void SetPostStruggleBehavior(BearEncounter.PostStruggleBehavior postStruggleBehavior)
	{
	}

	[Token(Token = "0x6001074")]
	[Address(RVA = "0x6285C0", Offset = "0x6273C0", Length = "0x4")]
	public BearEncounter.PostStruggleBehavior GetPostStruggleBehavior()
	{
		return default(BearEncounter.PostStruggleBehavior);
	}

	[Token(Token = "0x6001075")]
	[Address(RVA = "0x6285D0", Offset = "0x6273D0", Length = "0xEC")]
	public bool IsLastEncounter()
	{
		return false;
	}

	[Token(Token = "0x6001076")]
	[Address(RVA = "0x6286C0", Offset = "0x6274C0", Length = "0x14")]
	public void ForceBearFleePosition(Vector3 position)
	{
	}

	[Token(Token = "0x6001077")]
	[Address(RVA = "0x6286E0", Offset = "0x6274E0", Length = "0x51")]
	public void ClearForceBearFleePosition()
	{
	}

	[Token(Token = "0x6001078")]
	[Address(RVA = "0x628740", Offset = "0x627540", Length = "0x14")]
	public bool TryGetForcedBearFleePosition(out Vector3 position)
	{
		position = default(Vector3);
		return false;
	}

	[Token(Token = "0x6001079")]
	[Address(RVA = "0x4D0B00", Offset = "0x4CF900", Length = "0x52")]
	public void SetBearEarPrefab(GameObject bearEarPrefab)
	{
	}

	[Token(Token = "0x600107A")]
	[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
	public void SetCurrentEncounterOwner(BearEncounter bearEncounter)
	{
	}

	[Token(Token = "0x600107B")]
	[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
	public BearEncounter GetCurrentBearEncounterOwner()
	{
		return null;
	}

	[Token(Token = "0x600107C")]
	[Address(RVA = "0x628760", Offset = "0x627560", Length = "0x8F")]
	public BearHuntAiRedux()
	{
	}
}
