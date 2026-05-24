using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using TLD.GameplayTags;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Timeline;

namespace TLD.AI;

[Token(Token = "0x20014F2")]
public class AiCougar : BaseAi
{
	[Token(Token = "0x20014F3")]
	private enum PassingAttackSide
	{
		[Token(Token = "0x4009766")]
		Left,
		[Token(Token = "0x4009767")]
		Right
	}

	[SerializeField]
	[Token(Token = "0x4009757")]
	[FieldOffset(Offset = "0xA48")]
	private GameplayTag m_PassingAttackDamageEventTableTag;

	[SerializeField]
	[Token(Token = "0x4009758")]
	[FieldOffset(Offset = "0xA58")]
	private float m_AiPassingAttackDamage;

	[SerializeField]
	[Token(Token = "0x4009759")]
	[FieldOffset(Offset = "0xA5C")]
	private float m_PlayerPassingAttackDamageMin;

	[SerializeField]
	[Token(Token = "0x400975A")]
	[FieldOffset(Offset = "0xA60")]
	private float m_PlayerPassingAttackDamageMax;

	[Tooltip("Should be slightly longer than the actual passing attack animation. Currently 0.667s")]
	[SerializeField]
	[Token(Token = "0x400975B")]
	[FieldOffset(Offset = "0xA64")]
	private float m_PassingAttackAnimTimeout;

	[Header("Passing attack timeline animations")]
	[SerializeField]
	[Token(Token = "0x400975C")]
	[FieldOffset(Offset = "0xA68")]
	private List<AssetReferenceTimeline> m_SwipeSideTimelineAssets;

	[SerializeField]
	[Token(Token = "0x400975D")]
	[FieldOffset(Offset = "0xA70")]
	private int m_MaxPassingAttackInjureCount;

	[SerializeField]
	[Token(Token = "0x400975E")]
	[FieldOffset(Offset = "0xA74")]
	private float m_PlayerStruggleFadeoutTime;

	[Token(Token = "0x400975F")]
	[FieldOffset(Offset = "0xA78")]
	private bool m_TriggeredPassingAttackAnim;

	[Token(Token = "0x4009760")]
	[FieldOffset(Offset = "0xA7C")]
	private float m_PassingAttackAnimTimer;

	[Token(Token = "0x4009761")]
	[FieldOffset(Offset = "0xA80")]
	private bool m_HasPassingAttackDamageFired;

	[HideInInspector]
	[Token(Token = "0x4009762")]
	[FieldOffset(Offset = "0xA84")]
	public int m_PassingAttackCount;

	[Token(Token = "0x4009763")]
	[FieldOffset(Offset = "0xA88")]
	private AsyncOperationHandle<TimelineAsset> m_TimelineHandle;

	[Token(Token = "0x4009764")]
	[FieldOffset(Offset = "0xAA0")]
	private PlayerAnimation.CameraBasedHandPositioningMode m_LastCameraBasedHandPositionMode;

	[Token(Token = "0x17000B77")]
	public float PlayerStruggleFadeoutTime
	{
		[Token(Token = "0x6008446")]
		[Address(RVA = "0x125B150", Offset = "0x1259F50", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6008447")]
	[Address(RVA = "0x125B160", Offset = "0x1259F60", Length = "0xB")]
	public override void OnStruggle()
	{
	}

	[Token(Token = "0x6008448")]
	[Address(RVA = "0x125B170", Offset = "0x1259F70", Length = "0xF5")]
	public void SetWillDoPassingAttack()
	{
	}

	[Token(Token = "0x6008449")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void MaybeFleeOrAttackFromProjectileHit(WeaponSource weapon)
	{
	}

	[Token(Token = "0x600844A")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool CanHoldGround()
	{
		return false;
	}

	[Token(Token = "0x600844B")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool CanFleeFromFear()
	{
		return false;
	}

	[Token(Token = "0x600844C")]
	[Address(RVA = "0x125B270", Offset = "0x125A070", Length = "0x17")]
	protected override bool WillDoPassingAttack()
	{
		return false;
	}

	[Token(Token = "0x600844D")]
	[Address(RVA = "0x125B290", Offset = "0x125A090", Length = "0x14")]
	protected override bool CanDoPassingAttack()
	{
		return false;
	}

	[Token(Token = "0x600844E")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	protected override bool WillOnlyTargetPlayer()
	{
		return false;
	}

	[Token(Token = "0x600844F")]
	[Address(RVA = "0x125B2B0", Offset = "0x125A0B0", Length = "0x6F")]
	public override void EnterDead()
	{
	}

	[Token(Token = "0x6008450")]
	[Address(RVA = "0x125B320", Offset = "0x125A120", Length = "0x68")]
	private DamageEventTable GetPassingAttackDamageEventTable()
	{
		return null;
	}

	[Token(Token = "0x6008451")]
	[Address(RVA = "0x125B390", Offset = "0x125A190", Length = "0x86")]
	private bool TriggerPassingAttackAnim()
	{
		return false;
	}

	[Token(Token = "0x6008452")]
	[Address(RVA = "0x125B420", Offset = "0x125A220", Length = "0x66A")]
	protected override void EnterPassingAttack()
	{
	}

	[Token(Token = "0x6008453")]
	[Address(RVA = "0x125BA90", Offset = "0x125A890", Length = "0x8D")]
	protected override void ProcessPassingAttack()
	{
	}

	[Token(Token = "0x6008454")]
	[Address(RVA = "0x125BB20", Offset = "0x125A920", Length = "0x290")]
	private void DoPassingAttackDamage()
	{
	}

	[Token(Token = "0x6008455")]
	[Address(RVA = "0x125BDC0", Offset = "0x125ABC0", Length = "0x11")]
	public void OnAnimationEvent_OnPassingAttackChomp()
	{
	}

	[Token(Token = "0x6008456")]
	[Address(RVA = "0x125BDE0", Offset = "0x125ABE0", Length = "0xD0")]
	protected override Vector3 GetFleeTargetPosition(Vector3 pathDirection)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6008457")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	protected override bool CanAttackWhileFleeing()
	{
		return false;
	}

	[Token(Token = "0x6008458")]
	[Address(RVA = "0x125BEC0", Offset = "0x125ACC0", Length = "0x34")]
	protected override bool KeepFleeingFromTarget()
	{
		return false;
	}

	[Token(Token = "0x6008459")]
	[Address(RVA = "0x125BF00", Offset = "0x125AD00", Length = "0x60")]
	private void DoFlee()
	{
	}

	[Token(Token = "0x600845A")]
	[Address(RVA = "0x125BF60", Offset = "0x125AD60", Length = "0x372")]
	private void MaybePlayerDropsWeapon()
	{
	}

	[Token(Token = "0x600845B")]
	[Address(RVA = "0x125C2E0", Offset = "0x125B0E0", Length = "0x3EB")]
	private void PlayTimelineAnimation(AssetReferenceTimeline timelineAssetReference, Action onStop)
	{
	}

	[Token(Token = "0x600845C")]
	[Address(RVA = "0x125C6D0", Offset = "0x125B4D0", Length = "0x147")]
	private void FinishGetupAnimation()
	{
	}

	[Token(Token = "0x600845D")]
	[Address(RVA = "0x125C820", Offset = "0x125B620", Length = "0x8A")]
	public AiCougar()
	{
	}
}
