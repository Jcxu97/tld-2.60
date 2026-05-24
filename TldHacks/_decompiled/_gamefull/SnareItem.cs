using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004D6")]
public class SnareItem : MonoBehaviour
{
	[Token(Token = "0x4002C3A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_TrapDefaultMesh;

	[Token(Token = "0x4002C3B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_TrapSetMesh;

	[Token(Token = "0x4002C3C")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_TrapBrokenMesh;

	[Token(Token = "0x4002C3D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_TrapWithRabbitMesh;

	[Token(Token = "0x4002C3E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_RabbitPrefab;

	[Token(Token = "0x4002C3F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_RabbitSpawnPoint;

	[Token(Token = "0x4002C40")]
	[FieldOffset(Offset = "0x50")]
	public SnareState m_State;

	[Range(1f, 24f)]
	[Token(Token = "0x4002C41")]
	[FieldOffset(Offset = "0x54")]
	public float m_HoursBeforeRoll;

	[Range(0f, 100f)]
	[Token(Token = "0x4002C42")]
	[FieldOffset(Offset = "0x58")]
	public float m_ChanceSpawnCarcassOnRoll;

	[Range(0f, 100f)]
	[Token(Token = "0x4002C43")]
	[FieldOffset(Offset = "0x5C")]
	public float m_ChanceBreakOnRoll;

	[Token(Token = "0x4002C44")]
	[FieldOffset(Offset = "0x60")]
	private float m_HoursAtLastRoll;

	[Token(Token = "0x4002C45")]
	[FieldOffset(Offset = "0x64")]
	private SnareState m_RestoreStateWhenLeaveInspection;

	[Token(Token = "0x4002C46")]
	[FieldOffset(Offset = "0x68")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002C47")]
	private static SnareItemSaveDataProxy m_SnareItemSaveDataProxy;

	[Token(Token = "0x60024CB")]
	[Address(RVA = "0x86E470", Offset = "0x86D270", Length = "0x8")]
	public void Awake()
	{
	}

	[Token(Token = "0x60024CC")]
	[Address(RVA = "0x86E480", Offset = "0x86D280", Length = "0x8C")]
	public void Start()
	{
	}

	[Token(Token = "0x60024CD")]
	[Address(RVA = "0x86E510", Offset = "0x86D310", Length = "0x1BF")]
	public void Update()
	{
	}

	[Token(Token = "0x60024CE")]
	[Address(RVA = "0x86E6D0", Offset = "0x86D4D0", Length = "0x17B")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60024CF")]
	[Address(RVA = "0x86E850", Offset = "0x86D650", Length = "0x12C")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60024D0")]
	[Address(RVA = "0x86E980", Offset = "0x86D780", Length = "0x102")]
	public void OnSnarePlaced()
	{
	}

	[Token(Token = "0x60024D1")]
	[Address(RVA = "0x86EA90", Offset = "0x86D890", Length = "0x5F")]
	public void EnableAllMeshes()
	{
	}

	[Token(Token = "0x60024D2")]
	[Address(RVA = "0x86EAF0", Offset = "0x86D8F0", Length = "0xB")]
	public void RefreshMeshes()
	{
	}

	[Token(Token = "0x60024D3")]
	[Address(RVA = "0x6285C0", Offset = "0x6273C0", Length = "0x4")]
	public SnareState GetState()
	{
		return default(SnareState);
	}

	[Token(Token = "0x60024D4")]
	[Address(RVA = "0x86EB00", Offset = "0x86D900", Length = "0x26B")]
	public void SetState(SnareState state)
	{
	}

	[Token(Token = "0x60024D5")]
	[Address(RVA = "0x86ED70", Offset = "0x86DB70", Length = "0x7")]
	public void EnterInspectMode()
	{
	}

	[Token(Token = "0x60024D6")]
	[Address(RVA = "0x86ED80", Offset = "0x86DB80", Length = "0xB")]
	public void LeaveInspectMode()
	{
	}

	[Token(Token = "0x60024D7")]
	[Address(RVA = "0x86ED90", Offset = "0x86DB90", Length = "0x548")]
	private bool SkipCheckDueToPlayerProximity()
	{
		return false;
	}

	[Token(Token = "0x60024D8")]
	[Address(RVA = "0x86F2E0", Offset = "0x86E0E0", Length = "0xAB")]
	private void CheckForCatch()
	{
	}

	[Token(Token = "0x60024D9")]
	[Address(RVA = "0x86F390", Offset = "0x86E190", Length = "0x490")]
	private void DoRoll()
	{
	}

	[Token(Token = "0x60024DA")]
	[Address(RVA = "0x86F830", Offset = "0x86E630", Length = "0x490")]
	private void SpawnDeadRabbitOnSnare(GameObject rabbitPrefab)
	{
	}

	[Token(Token = "0x60024DB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SnareItem()
	{
	}
}
