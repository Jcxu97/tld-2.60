using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001487")]
public class RecoveryCamp : MonoBehaviour
{
	[Token(Token = "0x4009501")]
	private const int MIN_SCATTER_ANGLE = 0;

	[Token(Token = "0x4009502")]
	private const int MAX_SCATTER_ANGLE = 360;

	[Token(Token = "0x4009503")]
	private const float SCATTER_DROP_CHECK_DISTANCE = 0.01f;

	[Token(Token = "0x4009504")]
	private const float RUINED_TRAVOIS_DISTANCE_CHECK = 0.01f;

	[SerializeField]
	[Token(Token = "0x4009505")]
	[FieldOffset(Offset = "0x20")]
	private Container m_Container;

	[SerializeField]
	[Token(Token = "0x4009506")]
	[FieldOffset(Offset = "0x28")]
	private float m_GroundScatterMinRadius;

	[SerializeField]
	[Token(Token = "0x4009507")]
	[FieldOffset(Offset = "0x2C")]
	private float m_GroundScatterMaxRadius;

	[Header("Signal Smoke")]
	[SerializeField]
	[Token(Token = "0x4009508")]
	[FieldOffset(Offset = "0x30")]
	private float m_SignalSmokeTurnOffRange;

	[SerializeField]
	[Token(Token = "0x4009509")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_SignalSmokeParent;

	[Header("Ruined Travois")]
	[SerializeField]
	[Token(Token = "0x400950A")]
	[FieldOffset(Offset = "0x40")]
	private AssetReferenceCustomSpawnedItem m_RuinedTravoisReference;

	[SerializeField]
	[Token(Token = "0x400950B")]
	[FieldOffset(Offset = "0x48")]
	private Transform[] m_RuinedTravoisPositions;

	[Token(Token = "0x400950C")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<GearItem> m_RecoveryItems;

	[Token(Token = "0x400950D")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<DecorationItem> m_DecorationRecoveryItems;

	[Token(Token = "0x17000B52")]
	[field: Token(Token = "0x400950E")]
	[field: FieldOffset(Offset = "0x60")]
	public string Guid
	{
		[Token(Token = "0x6008262")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get;
		[Token(Token = "0x6008263")]
		[Address(RVA = "0x8F4D50", Offset = "0x8F3B50", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000B53")]
	[field: Token(Token = "0x400950F")]
	[field: FieldOffset(Offset = "0x68")]
	public bool IsShowingSignalFire
	{
		[Token(Token = "0x6008264")]
		[Address(RVA = "0x4C3B90", Offset = "0x4C2990", Length = "0x5")]
		get;
		[Token(Token = "0x6008265")]
		[Address(RVA = "0x91DC40", Offset = "0x91CA40", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x6008266")]
	[Address(RVA = "0x12357E0", Offset = "0x12345E0", Length = "0x9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008267")]
	[Address(RVA = "0x1235880", Offset = "0x1234680", Length = "0xAF")]
	public void RemoveRecoveryItem(GearItem recoveryItem)
	{
	}

	[Token(Token = "0x6008268")]
	[Address(RVA = "0x1235930", Offset = "0x1234730", Length = "0xA8")]
	public void RemoveDecorationRecoveryItem(DecorationItem decorationItem)
	{
	}

	[Token(Token = "0x6008269")]
	[Address(RVA = "0x12359E0", Offset = "0x12347E0", Length = "0x10BD")]
	public void ActivateRecoveryCamp(List<RecoveryCampState.RecoveryItem> recoveryItems, List<RecoveryCampState.RecoveryDecorationItem> decorationRecoveryItems, bool signalFireActive, bool isDeserialized)
	{
	}

	[Token(Token = "0x600826A")]
	[Address(RVA = "0x1236AA0", Offset = "0x12358A0", Length = "0x8D7")]
	public void PlaceRuinedTravois(List<RecoveryCampState.RecoveryItem> ruinedTravoisItems, List<RecoveryCampState.RecoveryDecorationItem> ruinedTravoisDecorationItems)
	{
	}

	[Token(Token = "0x600826B")]
	[Address(RVA = "0x1237380", Offset = "0x1236180", Length = "0xCE8")]
	private Container FindOrInstantiateRuinedTravoisContainer()
	{
		return null;
	}

	[Token(Token = "0x600826C")]
	[Address(RVA = "0x1238070", Offset = "0x1236E70", Length = "0x612")]
	public void SerializeRecoveryItems(List<RecoveryCampState.RecoveryItem> serializedRecoveryItems, List<RecoveryCampState.RecoveryDecorationItem> serializedDecorationItems)
	{
	}

	[Token(Token = "0x600826D")]
	[Address(RVA = "0x1238690", Offset = "0x1237490", Length = "0x438")]
	private void Update()
	{
	}

	[Token(Token = "0x600826E")]
	[Address(RVA = "0x1238AD0", Offset = "0x12378D0", Length = "0x40E")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600826F")]
	[Address(RVA = "0x1238EE0", Offset = "0x1237CE0", Length = "0x18F")]
	public RecoveryCamp()
	{
	}
}
