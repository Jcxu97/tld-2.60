using Cpp2ILInjected;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.AI;

[Token(Token = "0x20014FA")]
public class AiTimberwolf : AiBaseWolf
{
	[Range(0.1f, 100f)]
	[Token(Token = "0x4009783")]
	[FieldOffset(Offset = "0xA58")]
	public float m_HoldGroundDistance;

	[Range(0.1f, 100f)]
	[Token(Token = "0x4009784")]
	[FieldOffset(Offset = "0xA5C")]
	public float m_MinFollowDistance;

	[Range(0.1f, 100f)]
	[Token(Token = "0x4009785")]
	[FieldOffset(Offset = "0xA60")]
	public float m_ComfortableFollowDistance;

	[Range(0.1f, 100f)]
	[Token(Token = "0x4009786")]
	[FieldOffset(Offset = "0xA64")]
	public float m_MaxFollowDistance;

	[Range(0.1f, 15f)]
	[Token(Token = "0x4009787")]
	[FieldOffset(Offset = "0xA68")]
	public float m_HideAndSeekStalkingSpeed;

	[Range(0.1f, 15f)]
	[Token(Token = "0x4009788")]
	[FieldOffset(Offset = "0xA6C")]
	public float m_HideAndSeekCirclingSpeed;

	[Range(0.1f, 15f)]
	[Token(Token = "0x4009789")]
	[FieldOffset(Offset = "0xA70")]
	public float m_HideAndSeekRetreatingSpeed;

	[Range(0f, 100f)]
	[Token(Token = "0x400978A")]
	[FieldOffset(Offset = "0xA74")]
	public float m_RetreatDistance;

	[Range(0f, 100f)]
	[Token(Token = "0x400978B")]
	[FieldOffset(Offset = "0xA78")]
	public float m_CirclingDistance;

	[Range(1f, 50f)]
	[Token(Token = "0x400978C")]
	[FieldOffset(Offset = "0xA7C")]
	public float m_RetreatPositionMinRadius;

	[Range(1f, 50f)]
	[Token(Token = "0x400978D")]
	[FieldOffset(Offset = "0xA80")]
	public float m_RetreatPositionMaxRadius;

	[Range(0.1f, 5f)]
	[Token(Token = "0x400978E")]
	[FieldOffset(Offset = "0xA84")]
	public float m_ChangeDistanceThreshold;

	[Range(1f, 50f)]
	[Token(Token = "0x400978F")]
	[FieldOffset(Offset = "0xA88")]
	public float m_HighGroundSearchRadius;

	[Range(0f, 10f)]
	[Token(Token = "0x4009790")]
	[FieldOffset(Offset = "0xA8C")]
	public float m_PackSeperationDistance;

	[Range(0f, 600f)]
	[Token(Token = "0x4009791")]
	[FieldOffset(Offset = "0xA90")]
	public float m_SneakAmbushTime;

	[Range(0f, 100f)]
	[Token(Token = "0x4009792")]
	[FieldOffset(Offset = "0xA94")]
	public float m_PassingAttackChance;

	[Range(0f, 100f)]
	[Token(Token = "0x4009793")]
	[FieldOffset(Offset = "0xA98")]
	public float m_PassingAttackCameraShakeForce;

	[Range(0f, 100f)]
	[Token(Token = "0x4009794")]
	[FieldOffset(Offset = "0xA9C")]
	public float m_PassingAttackCameraRollForce;

	[Range(0f, 100f)]
	[Token(Token = "0x4009795")]
	[FieldOffset(Offset = "0xAA0")]
	public float m_HideAndSeekCooldownTime;

	[Range(0f, 100f)]
	[Token(Token = "0x4009796")]
	[FieldOffset(Offset = "0xAA4")]
	public float m_MinNewPathCooldownTimeSeconds;

	[Range(0.1f, 100f)]
	[Token(Token = "0x4009797")]
	[FieldOffset(Offset = "0xAA8")]
	public float m_MaxNewPathCooldownTimeSeconds;

	[Range(0f, 100f)]
	[Token(Token = "0x4009798")]
	[FieldOffset(Offset = "0xAAC")]
	public float m_RepathApproachTimeSeconds;

	[Range(0f, 100f)]
	[Token(Token = "0x4009799")]
	[FieldOffset(Offset = "0xAB0")]
	public float m_HighGroundClosingDistancePercent;

	[Token(Token = "0x400979A")]
	[FieldOffset(Offset = "0xAB4")]
	public bool m_ShouldAlwaysPerformPassingAttack;

	[Token(Token = "0x400979B")]
	[FieldOffset(Offset = "0xAB8")]
	private uint m_HideAndSeekAudioId;

	[Token(Token = "0x400979C")]
	[FieldOffset(Offset = "0xABC")]
	private bool m_IsRetreating;

	[Token(Token = "0x400979D")]
	[FieldOffset(Offset = "0xAC0")]
	private float m_SneakAmbushTimer;

	[Token(Token = "0x400979E")]
	[FieldOffset(Offset = "0xAC4")]
	private float m_ClosingDistancePercent;

	[Token(Token = "0x400979F")]
	[FieldOffset(Offset = "0xAC8")]
	private float m_EnterHideAndSeekCooldownTime;

	[Token(Token = "0x40097A0")]
	[FieldOffset(Offset = "0xACC")]
	private float m_NewPathCooldownTimer;

	[Range(0f, 60f)]
	[Token(Token = "0x40097A1")]
	[FieldOffset(Offset = "0xAD0")]
	public float m_PackJoinTimeSeconds;

	[Range(0f, 100f)]
	[Token(Token = "0x40097A2")]
	[FieldOffset(Offset = "0xAD4")]
	public float m_PackSkipJoinStateWhenTargetNearbyDistance;

	[Token(Token = "0x40097A3")]
	[FieldOffset(Offset = "0xAD8")]
	private uint m_JoinPackAudioId;

	[Token(Token = "0x40097A4")]
	[FieldOffset(Offset = "0xADC")]
	private float m_JoinTimer;

	[Token(Token = "0x40097A5")]
	[FieldOffset(Offset = "0xAE0")]
	private bool m_RequestedHowl;

	[SerializeField]
	[Token(Token = "0x40097A6")]
	[FieldOffset(Offset = "0xAE8")]
	private GameplayTag m_PassingAttackDamageEventTableTag;

	[Tooltip("Should be slightly longer than the actual passing attack animation. Currently 0.667s")]
	[SerializeField]
	[Token(Token = "0x40097A7")]
	[FieldOffset(Offset = "0xAF8")]
	private float m_PassingAttackAnimTimeout;

	[SerializeField]
	[Token(Token = "0x40097A8")]
	[FieldOffset(Offset = "0xAFC")]
	private float m_AiPassingAttackDamage;

	[Token(Token = "0x40097A9")]
	[FieldOffset(Offset = "0xB00")]
	private bool m_TriggeredPassingAttackAnim;

	[Token(Token = "0x40097AA")]
	[FieldOffset(Offset = "0xB04")]
	private float m_PassingAttackAnimTimer;

	[Token(Token = "0x40097AB")]
	[FieldOffset(Offset = "0xB08")]
	private bool m_HasPassingAttackDamageFired;

	[Token(Token = "0x600847F")]
	[Address(RVA = "0x12603C0", Offset = "0x125F1C0", Length = "0x124")]
	public void ForceSetPlayerTarget()
	{
	}

	[Token(Token = "0x6008480")]
	[Address(RVA = "0x12604F0", Offset = "0x125F2F0", Length = "0x116")]
	public bool CanPerformPassingAttackChance()
	{
		return false;
	}

	[Token(Token = "0x6008481")]
	[Address(RVA = "0x1260610", Offset = "0x125F410", Length = "0xA1")]
	public bool CanPerformPassingAttack()
	{
		return false;
	}

	[Token(Token = "0x6008482")]
	[Address(RVA = "0x12606C0", Offset = "0x125F4C0", Length = "0x213")]
	public void EnterHideAndSeek()
	{
	}

	[Token(Token = "0x6008483")]
	[Address(RVA = "0x12608E0", Offset = "0x125F6E0", Length = "0x312")]
	private Vector3 FindHighGround(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6008484")]
	[Address(RVA = "0x1260C00", Offset = "0x125FA00", Length = "0x2C3")]
	private Vector3 FindRandomLocation(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6008485")]
	[Address(RVA = "0x1260ED0", Offset = "0x125FCD0", Length = "0x3B")]
	private float GetClosingDistancePercent()
	{
		return 0f;
	}

	[Token(Token = "0x6008486")]
	[Address(RVA = "0x1260F10", Offset = "0x125FD10", Length = "0x4D")]
	private float GetMinFollowDistance()
	{
		return 0f;
	}

	[Token(Token = "0x6008487")]
	[Address(RVA = "0x1260F60", Offset = "0x125FD60", Length = "0x4D")]
	private float GetMaxFollowDistance()
	{
		return 0f;
	}

	[Token(Token = "0x6008488")]
	[Address(RVA = "0x1260FB0", Offset = "0x125FDB0", Length = "0x4D")]
	private float GetComfortableFollowDistance()
	{
		return 0f;
	}

	[Token(Token = "0x6008489")]
	[Address(RVA = "0x125B390", Offset = "0x125A190", Length = "0x86")]
	public bool TriggerPassingAttackAnim()
	{
		return false;
	}

	[Token(Token = "0x600848A")]
	[Address(RVA = "0x1261000", Offset = "0x125FE00", Length = "0x57")]
	public void StopHideAndSeekAudio()
	{
	}

	[Token(Token = "0x600848B")]
	[Address(RVA = "0x1261060", Offset = "0x125FE60", Length = "0x52D")]
	private Vector3 FindShortestDistanceToPlayerSide()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600848C")]
	[Address(RVA = "0x1261590", Offset = "0x1260390", Length = "0x835")]
	private Vector3 FindTacticalPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600848D")]
	[Address(RVA = "0x1261DD0", Offset = "0x1260BD0", Length = "0x15")]
	private void ResetApproachDistance()
	{
	}

	[Token(Token = "0x600848E")]
	[Address(RVA = "0x1261DF0", Offset = "0x1260BF0", Length = "0xAFA")]
	public void ProcessHideAndSeek()
	{
	}

	[Token(Token = "0x600848F")]
	[Address(RVA = "0x12628F0", Offset = "0x12616F0", Length = "0x5B")]
	private void SetEnterCooldownTime()
	{
	}

	[Token(Token = "0x6008490")]
	[Address(RVA = "0x1262950", Offset = "0x1261750", Length = "0xAA")]
	public void ExitHideAndSeek()
	{
	}

	[Token(Token = "0x6008491")]
	[Address(RVA = "0x1262A00", Offset = "0x1261800", Length = "0x1A0")]
	private bool CanEnterHideAndSeekInternal()
	{
		return false;
	}

	[Token(Token = "0x6008492")]
	[Address(RVA = "0x1262C60", Offset = "0x1261A60", Length = "0xFA")]
	public bool CanEnterHideAndSeek()
	{
		return false;
	}

	[Token(Token = "0x6008493")]
	[Address(RVA = "0x1262D60", Offset = "0x1261B60", Length = "0x321")]
	public bool MaybeForceHideAndSeek()
	{
		return false;
	}

	[Token(Token = "0x6008494")]
	[Address(RVA = "0x1263090", Offset = "0x1261E90", Length = "0x3C9")]
	public bool MaybeStartOrJoinPackHowl()
	{
		return false;
	}

	[Token(Token = "0x6008495")]
	[Address(RVA = "0x1263460", Offset = "0x1262260", Length = "0x24C")]
	public void EnterJoinPack()
	{
	}

	[Token(Token = "0x6008496")]
	[Address(RVA = "0x12636B0", Offset = "0x12624B0", Length = "0x485")]
	public void ProcessJoinPack()
	{
	}

	[Token(Token = "0x6008497")]
	[Address(RVA = "0x1263B40", Offset = "0x1262940", Length = "0x57")]
	public void ExitJoinPack()
	{
	}

	[Token(Token = "0x6008498")]
	[Address(RVA = "0x1263BA0", Offset = "0x12629A0", Length = "0x68")]
	private DamageEventTable GetPassingAttackDamageEventTable()
	{
		return null;
	}

	[Token(Token = "0x6008499")]
	[Address(RVA = "0x1263C10", Offset = "0x1262A10", Length = "0x7")]
	protected override bool CanDoPassingAttack()
	{
		return false;
	}

	[Token(Token = "0x600849A")]
	[Address(RVA = "0x1263C20", Offset = "0x1262A20", Length = "0x53A")]
	protected override void EnterPassingAttack()
	{
	}

	[Token(Token = "0x600849B")]
	[Address(RVA = "0x1264160", Offset = "0x1262F60", Length = "0x8D")]
	protected override void ProcessPassingAttack()
	{
	}

	[Token(Token = "0x600849C")]
	[Address(RVA = "0x12641F0", Offset = "0x1262FF0", Length = "0x2C2")]
	private void DoPassingAttackDamage()
	{
	}

	[Token(Token = "0x600849D")]
	[Address(RVA = "0x12644C0", Offset = "0x12632C0", Length = "0x11")]
	public void OnAnimationEvent_OnPassingAttackChomp()
	{
	}

	[Token(Token = "0x600849E")]
	[Address(RVA = "0x12644E0", Offset = "0x12632E0", Length = "0x170")]
	public AiTimberwolf()
	{
	}
}
