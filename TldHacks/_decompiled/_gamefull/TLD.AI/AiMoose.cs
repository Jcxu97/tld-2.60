using Cpp2ILInjected;
using UnityEngine;

namespace TLD.AI;

[Token(Token = "0x20014F5")]
public class AiMoose : BaseAi
{
	[Token(Token = "0x4009768")]
	[FieldOffset(Offset = "0xA48")]
	public float m_StunnedDuration;

	[Token(Token = "0x4009769")]
	[FieldOffset(Offset = "0xA4C")]
	public float m_HoldBeforeAttackDelaySeconds;

	[Range(0f, 100f)]
	[Token(Token = "0x400976A")]
	[FieldOffset(Offset = "0xA50")]
	public float m_StompAttackChance;

	[Token(Token = "0x400976B")]
	[FieldOffset(Offset = "0xA54")]
	public float m_StumpDetectionRadius;

	[Token(Token = "0x400976C")]
	[FieldOffset(Offset = "0xA58")]
	public float m_StumpScratchingDelayHoursMin;

	[Token(Token = "0x400976D")]
	[FieldOffset(Offset = "0xA5C")]
	public float m_StumpScratchingDelayHoursMax;

	[Range(0f, 90f)]
	[Token(Token = "0x400976E")]
	[FieldOffset(Offset = "0xA60")]
	public float m_SteepSlopeFleeOnAttackThresholdDegrees;

	[Range(0f, 100f)]
	[Token(Token = "0x400976F")]
	[FieldOffset(Offset = "0xA64")]
	public float m_StumpScratchingChance;

	[HideInInspector]
	[Token(Token = "0x4009770")]
	[FieldOffset(Offset = "0xA68")]
	public float m_NextStumpVisitTimeHours;

	[Token(Token = "0x4009771")]
	[FieldOffset(Offset = "0xA70")]
	private ScratchingStump m_SelectedStump;

	[Token(Token = "0x4009772")]
	[FieldOffset(Offset = "0xA78")]
	private Vector3 m_ScratchingPos;

	[Token(Token = "0x4009773")]
	private const int m_AnimScratchingWanderPauseId = 10;

	[Token(Token = "0x4009774")]
	[FieldOffset(Offset = "0xA84")]
	private bool m_HasApproachedStump;

	[Token(Token = "0x600845F")]
	[Address(RVA = "0x125C8B0", Offset = "0x125B6B0", Length = "0x64")]
	public bool CanScratch()
	{
		return false;
	}

	[Token(Token = "0x6008460")]
	[Address(RVA = "0x125C920", Offset = "0x125B720", Length = "0x18")]
	public float GetRolledStumpScratchingDelay()
	{
		return 0f;
	}

	[Token(Token = "0x6008461")]
	[Address(RVA = "0x125C940", Offset = "0x125B740", Length = "0x2B0")]
	public override void ProcessHoldGround()
	{
	}

	[Token(Token = "0x6008462")]
	[Address(RVA = "0x125CC00", Offset = "0x125BA00", Length = "0x30B")]
	public bool MaybeFleeOnSlope()
	{
		return false;
	}

	[Token(Token = "0x6008463")]
	[Address(RVA = "0x125CF10", Offset = "0x125BD10", Length = "0x332")]
	public override void MaybeFleeOrAttackFromProjectileHit(WeaponSource weapon)
	{
	}

	[Token(Token = "0x6008464")]
	[Address(RVA = "0x125D250", Offset = "0x125C050", Length = "0x56")]
	public void EnterScratchingAntlers()
	{
	}

	[Token(Token = "0x6008465")]
	[Address(RVA = "0x125D2B0", Offset = "0x125C0B0", Length = "0x52")]
	public void ExitScratchingAntlers()
	{
	}

	[Token(Token = "0x6008466")]
	[Address(RVA = "0x125D310", Offset = "0x125C110", Length = "0x447")]
	public void ProcessScratchingAntlers()
	{
	}

	[Token(Token = "0x6008467")]
	[Address(RVA = "0x125D760", Offset = "0x125C560", Length = "0x19A")]
	public bool CanStickToGround(out Vector3 newPosition, Vector3 desiredPosition)
	{
		newPosition = default(Vector3);
		return false;
	}

	[Token(Token = "0x6008468")]
	[Address(RVA = "0x125D900", Offset = "0x125C700", Length = "0x356")]
	public bool IsOrientationValid(ScratchingStump stump)
	{
		return false;
	}

	[Token(Token = "0x6008469")]
	[Address(RVA = "0x125DC60", Offset = "0x125CA60", Length = "0x7C2")]
	public void OnStumpApproached(ScratchingStump stump)
	{
	}

	[Token(Token = "0x600846A")]
	[Address(RVA = "0x58CFA0", Offset = "0x58BDA0", Length = "0xE")]
	public void OnStumpMissed()
	{
	}

	[Token(Token = "0x600846B")]
	[Address(RVA = "0x125E430", Offset = "0x125D230", Length = "0xF3")]
	public void OnStumpReached()
	{
	}

	[Token(Token = "0x600846C")]
	[Address(RVA = "0x125E530", Offset = "0x125D330", Length = "0x43A")]
	public bool MaybeSelectScratchingStump(out Vector3 wanderPos)
	{
		wanderPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x600846D")]
	[Address(RVA = "0x125E970", Offset = "0x125D770", Length = "0x9E")]
	public AiMoose()
	{
	}
}
