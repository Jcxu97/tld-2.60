using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using TLD.AI;
using TLD.GameplayTags;
using TLD.IntBackedUnit;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000145")]
public class BaseAi : MonoBehaviour
{
	[Token(Token = "0x2000146")]
	public delegate void OnAnimationEvent();

	[Token(Token = "0x2000147")]
	public enum AnimationCallbackEvent
	{
		[Token(Token = "0x4000C21")]
		DoNothing = 0,
		[Token(Token = "0x4000C22")]
		MooseButtHeadAttackComplete = 1,
		[Token(Token = "0x4000C23")]
		Play_MauledMuffle = 4,
		[Token(Token = "0x4000C24")]
		Stop_MauledMuffle = 5,
		[Token(Token = "0x4000C25")]
		SpearStruggleComplete = 6,
		[Token(Token = "0x4000C26")]
		SpearDisengageReady = 7,
		[Token(Token = "0x4000C27")]
		PassingAttackChomp = 8,
		[Token(Token = "0x4000C28")]
		HowlComplete = 9
	}

	[Token(Token = "0x2000148")]
	private class AnimationEventDictionary : Dictionary<AnimationCallbackEvent, OnAnimationEvent>
	{
		[Token(Token = "0x2000149")]
		private class EqualityComparer : IEqualityComparer<AnimationCallbackEvent>
		{
			[Token(Token = "0x4000C29")]
			public static readonly EqualityComparer Default;

			[Token(Token = "0x6000DB4")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			private EqualityComparer()
			{
			}

			[Token(Token = "0x6000DB5")]
			[Address(RVA = "0x5DC750", Offset = "0x5DB550", Length = "0x7")]
			public bool Equals(AnimationCallbackEvent x, AnimationCallbackEvent y)
			{
				return false;
			}

			[Token(Token = "0x6000DB6")]
			[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
			public int GetHashCode(AnimationCallbackEvent x)
			{
				return 0;
			}
		}

		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x5DC6D0", Offset = "0x5DB4D0", Length = "0x78")]
		public AnimationEventDictionary()
		{
		}
	}

	[Flags]
	[Token(Token = "0x200014A")]
	public enum SetupDamageParamsOptions
	{
		[Token(Token = "0x4000C2B")]
		None = 0,
		[Token(Token = "0x4000C2C")]
		PlayTrigger = 1
	}

	[Flags]
	[Token(Token = "0x200014B")]
	public enum Foot
	{
		[Token(Token = "0x4000C2E")]
		Front = 0,
		[Token(Token = "0x4000C2F")]
		Back = 2,
		[Token(Token = "0x4000C30")]
		Left = 1,
		[Token(Token = "0x4000C31")]
		Right = 0,
		[Token(Token = "0x4000C32")]
		FrontLeft = 1,
		[Token(Token = "0x4000C33")]
		FrontRight = 0,
		[Token(Token = "0x4000C34")]
		BackLeft = 3,
		[Token(Token = "0x4000C35")]
		BackRight = 2
	}

	[Token(Token = "0x200014C")]
	public struct FootstepInfo
	{
		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0x0")]
		public readonly Action<RaycastHit> m_OnRaycastComplete;

		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0x8")]
		public readonly string m_BoneName;

		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x10")]
		public Transform m_Bone;

		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x18")]
		public uint m_AudioId;

		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x1C")]
		public int m_Count;

		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x5DC810", Offset = "0x5DB610", Length = "0x113")]
		public FootstepInfo(string boneName, Action<RaycastHit> onRaycastComplete)
		{
			m_OnRaycastComplete = null;
			m_BoneName = null;
			m_Bone = null;
			m_AudioId = 0u;
			m_Count = 0;
		}
	}

	[Token(Token = "0x200014D")]
	private delegate bool HoldGroundCallback(float radius);

	[Token(Token = "0x200014E")]
	public enum DamageSide
	{
		[Token(Token = "0x4000C3C")]
		DamageSideNone = -1,
		[Token(Token = "0x4000C3D")]
		DamageSideLeft,
		[Token(Token = "0x4000C3E")]
		DamageSideRight
	}

	[Token(Token = "0x200014F")]
	public enum AiFleeReason
	{
		[Token(Token = "0x4000C40")]
		Default,
		[Token(Token = "0x4000C41")]
		ThrownStone,
		[Token(Token = "0x4000C42")]
		UnreachableTarget,
		[Token(Token = "0x4000C43")]
		Spear,
		[Token(Token = "0x4000C44")]
		SpearDespawn,
		[Token(Token = "0x4000C45")]
		AfterPassingAttack,
		[Token(Token = "0x4000C46")]
		PackMorale,
		[Token(Token = "0x4000C47")]
		WeaponAim,
		[Token(Token = "0x4000C48")]
		AfterHoldGround,
		[Token(Token = "0x4000C49")]
		PackDisband,
		[Token(Token = "0x4000C4A")]
		NoiseMaker,
		[Token(Token = "0x4000C4B")]
		FleeTriggerVolume
	}

	[Token(Token = "0x2000150")]
	public enum WaypointCompletionBehaviouir
	{
		[Token(Token = "0x4000C4D")]
		CheckSpawnRegion,
		[Token(Token = "0x4000C4E")]
		Restart,
		[Token(Token = "0x4000C4F")]
		ChangeState
	}

	[Token(Token = "0x2000151")]
	private enum State
	{
		[Token(Token = "0x4000C51")]
		Pathfinding,
		[Token(Token = "0x4000C52")]
		Blending,
		[Token(Token = "0x4000C53")]
		Finished
	}

	[Token(Token = "0x2000152")]
	private enum HoldGroundReason
	{
		[Token(Token = "0x4000C55")]
		None,
		[Token(Token = "0x4000C56")]
		RedFlare,
		[Token(Token = "0x4000C57")]
		Torch,
		[Token(Token = "0x4000C58")]
		SafeHaven,
		[Token(Token = "0x4000C59")]
		NearbyAuroraField,
		[Token(Token = "0x4000C5A")]
		InsideAuroraField,
		[Token(Token = "0x4000C5B")]
		Spear,
		[Token(Token = "0x4000C5C")]
		Fire,
		[Token(Token = "0x4000C5D")]
		BlueFlare,
		[Token(Token = "0x4000C5E")]
		BlueFlareOnGround,
		[Token(Token = "0x4000C5F")]
		RedFlareOnGround,
		[Token(Token = "0x4000C60")]
		TorchOnGround
	}

	[Token(Token = "0x2000153")]
	public enum FindGroundType
	{
		[Token(Token = "0x4000C62")]
		FirstTime,
		[Token(Token = "0x4000C63")]
		Pathing
	}

	[Token(Token = "0x2000154")]
	public class PointOfInterest
	{
		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 m_Location;

		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x1C")]
		public PointOfInterestAnim m_AnimToPlay;

		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PointOfInterest()
		{
		}
	}

	[Token(Token = "0x2000155")]
	public enum PointOfInterestAnim
	{
		[Token(Token = "0x4000C67")]
		Feed,
		[Token(Token = "0x4000C68")]
		SniffAir,
		[Token(Token = "0x4000C69")]
		SniffGround,
		[Token(Token = "0x4000C6A")]
		Random
	}

	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0x20")]
	public bool m_UseAiming;

	[Token(Token = "0x4000A10")]
	[FieldOffset(Offset = "0x24")]
	public float m_AimingWeight;

	[Token(Token = "0x4000A11")]
	[FieldOffset(Offset = "0x28")]
	public Transform m_LeftHandTarget;

	[Token(Token = "0x4000A12")]
	[FieldOffset(Offset = "0x30")]
	public Transform m_RightHandTarget;

	[Token(Token = "0x4000A13")]
	[FieldOffset(Offset = "0x38")]
	public bool m_UseAimingElboHints;

	[Token(Token = "0x4000A14")]
	[FieldOffset(Offset = "0x40")]
	public Transform m_LeftElboHint;

	[Token(Token = "0x4000A15")]
	[FieldOffset(Offset = "0x48")]
	public Transform m_RightElboHint;

	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_Weapon;

	[Token(Token = "0x4000A17")]
	[FieldOffset(Offset = "0x58")]
	public Transform m_AimJoint;

	[Token(Token = "0x4000A18")]
	[FieldOffset(Offset = "0x60")]
	public float m_WeaponDistanceFromHead;

	[Token(Token = "0x4000A19")]
	[FieldOffset(Offset = "0x64")]
	public float m_MaxYawAngle;

	[Token(Token = "0x4000A1A")]
	[FieldOffset(Offset = "0x68")]
	public RandomId[] m_RandomIds;

	[Token(Token = "0x4000A1B")]
	[FieldOffset(Offset = "0x70")]
	public string m_FrontLeftBone;

	[Token(Token = "0x4000A1C")]
	[FieldOffset(Offset = "0x78")]
	public string m_FrontRightBone;

	[Token(Token = "0x4000A1D")]
	[FieldOffset(Offset = "0x80")]
	public string m_BackLeftBone;

	[Token(Token = "0x4000A1E")]
	[FieldOffset(Offset = "0x88")]
	public string m_BackRightBone;

	[Token(Token = "0x4000A1F")]
	[FieldOffset(Offset = "0x90")]
	public SnowImprintType m_SnowImprintType;

	[Token(Token = "0x4000A20")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_SpeedFromMecanimBone;

	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0xA0")]
	public bool m_SpeedForPathfindingOverride;

	[Token(Token = "0x4000A22")]
	[FieldOffset(Offset = "0xA4")]
	public float m_OverrideSpeed;

	[Token(Token = "0x4000A23")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_GameObject_Mouth;

	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_BreathEffectPrefab;

	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject m_BreathEffect;

	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0xC0")]
	public BoxCollider m_LeftFallingSideCollider;

	[Token(Token = "0x4000A27")]
	[FieldOffset(Offset = "0xC8")]
	public BoxCollider m_RightFallingSideCollider;

	[Token(Token = "0x4000A28")]
	[FieldOffset(Offset = "0xD0")]
	private int m_FallingSideLayerMask;

	[Token(Token = "0x4000A29")]
	[FieldOffset(Offset = "0xD8")]
	private Collider[] m_FallingSideHits;

	[Token(Token = "0x4000A2A")]
	[FieldOffset(Offset = "0xE0")]
	private FootstepTrail m_FootstepTrail;

	[Token(Token = "0x4000A2B")]
	[FieldOffset(Offset = "0xE8")]
	private bool m_LastFootstepResult;

	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0xEC")]
	private int m_NextRecentFootPrintIndex;

	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0xF0")]
	private Vector3[] m_RecentFootPrints;

	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0xF8")]
	private float m_NextRandomIdTime;

	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0x100")]
	private RandomId m_ActiveRandomId;

	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x108")]
	private Vector3 m_PreviousForward;

	[Token(Token = "0x4000A31")]
	[FieldOffset(Offset = "0x114")]
	private float m_turnSpeed;

	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x118")]
	private float m_NextUpdateStandingOnMaterialTag;

	[Token(Token = "0x4000A33")]
	[FieldOffset(Offset = "0x11C")]
	private bool m_CanPlayTurn;

	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x11D")]
	private bool m_CanPlayPitchRoll;

	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x11E")]
	private bool m_CanPlayTarget;

	[HideInInspector]
	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x120")]
	public Vector3 m_TurnHeading;

	[HideInInspector]
	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x12C")]
	public float m_TotalTurnAngle;

	[HideInInspector]
	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0x130")]
	public int m_AnimParameter_ActualSpeed;

	[HideInInspector]
	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x134")]
	public int m_AnimParameter_AiState;

	[HideInInspector]
	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x138")]
	public int m_AnimParameter_Attack_Trigger;

	[HideInInspector]
	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x13C")]
	public int m_AnimParameter_AttackId;

	[HideInInspector]
	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0x140")]
	public int m_AnimParameter_Corpse;

	[HideInInspector]
	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0x144")]
	public int m_AnimParameter_Dead;

	[HideInInspector]
	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0x148")]
	public int m_AnimParameter_ExitAttack;

	[HideInInspector]
	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0x14C")]
	public int m_AnimParameter_Flinch_Trigger;

	[HideInInspector]
	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0x150")]
	public int m_AnimParameter_Howl_Trigger;

	[HideInInspector]
	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x154")]
	public int m_AnimParameter_Pitch;

	[HideInInspector]
	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x158")]
	public int m_AnimParameter_RandomId;

	[HideInInspector]
	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0x15C")]
	public int m_AnimParameter_RandomId_Trigger;

	[HideInInspector]
	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x160")]
	public int m_AnimParameter_Roar_Trigger;

	[HideInInspector]
	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x164")]
	public int m_AnimParameter_Roll;

	[HideInInspector]
	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x168")]
	public int m_AnimParameter_Sleep;

	[HideInInspector]
	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0x16C")]
	public int m_AnimParameter_SniffAir;

	[HideInInspector]
	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x170")]
	public int m_AnimParameter_SniffGround;

	[HideInInspector]
	[Token(Token = "0x4000A49")]
	[FieldOffset(Offset = "0x174")]
	public int m_AnimParameter_Speed;

	[HideInInspector]
	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x178")]
	public int m_AnimParameter_StruggleStart;

	[HideInInspector]
	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x17C")]
	public int m_AnimParameter_Hunted2StruggleStart;

	[HideInInspector]
	[Token(Token = "0x4000A4C")]
	[FieldOffset(Offset = "0x180")]
	public int m_AnimParameter_StruggleEnd;

	[HideInInspector]
	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0x184")]
	public int m_AnimParameter_TargetHeading;

	[HideInInspector]
	[Token(Token = "0x4000A4E")]
	[FieldOffset(Offset = "0x188")]
	public int m_AnimParameter_TargetHeadingSmooth;

	[HideInInspector]
	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0x18C")]
	public int m_AnimParameter_TurnAngle;

	[HideInInspector]
	[Token(Token = "0x4000A50")]
	[FieldOffset(Offset = "0x190")]
	public int m_AnimParameter_TurnSpeed;

	[HideInInspector]
	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x194")]
	public int m_AnimParameter_WanderPauseId;

	[HideInInspector]
	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0x198")]
	public int m_AnimParameter_TapMeter;

	[HideInInspector]
	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x19C")]
	public int m_AnimParameter_StruggleHeight;

	[HideInInspector]
	[Token(Token = "0x4000A54")]
	[FieldOffset(Offset = "0x1A0")]
	public int m_AnimParameter_Wounded;

	[HideInInspector]
	[Token(Token = "0x4000A55")]
	[FieldOffset(Offset = "0x1A4")]
	public int m_AnimParameter_IsOnHindLegs;

	[HideInInspector]
	[Token(Token = "0x4000A56")]
	[FieldOffset(Offset = "0x1A8")]
	public int m_AnimParameter_PropIsRifleRack;

	[HideInInspector]
	[Token(Token = "0x4000A57")]
	[FieldOffset(Offset = "0x1AC")]
	public int m_AnimParameter_PropIsChair;

	[HideInInspector]
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x1B0")]
	public int m_AnimParameter_IsAiming;

	[HideInInspector]
	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0x1B4")]
	public int m_AnimParameter_Stunned;

	[HideInInspector]
	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0x1B8")]
	public int m_AnimParameter_Stunned_Trigger;

	[HideInInspector]
	[Token(Token = "0x4000A5B")]
	[FieldOffset(Offset = "0x1BC")]
	public int m_AnimParameter_MooseStomp_Trigger;

	[HideInInspector]
	[Token(Token = "0x4000A5C")]
	[FieldOffset(Offset = "0x1C0")]
	public int m_AnimParameter_IsInjured;

	[HideInInspector]
	[Token(Token = "0x4000A5D")]
	[FieldOffset(Offset = "0x1C4")]
	public int m_AnimParameter_DamageImpact_Trigger;

	[HideInInspector]
	[Token(Token = "0x4000A5E")]
	[FieldOffset(Offset = "0x1C8")]
	public int m_AnimParameter_DamageBodyPart;

	[HideInInspector]
	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x1CC")]
	public int m_AnimParameter_DamageSide;

	[HideInInspector]
	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x1D0")]
	public int m_AnimParameter_Trigger_Spear_Struggle_Entry;

	[HideInInspector]
	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0x1D4")]
	public int m_AnimParameter_Trigger_Spear_Exit_Success;

	[HideInInspector]
	[Token(Token = "0x4000A62")]
	[FieldOffset(Offset = "0x1D8")]
	public int m_AnimParameter_Trigger_Spear_Exit_Fail;

	[HideInInspector]
	[Token(Token = "0x4000A63")]
	[FieldOffset(Offset = "0x1DC")]
	public int m_AnimParameter_Trigger_Spear_Exit_Success_Death;

	[HideInInspector]
	[Token(Token = "0x4000A64")]
	[FieldOffset(Offset = "0x1E0")]
	public int m_AnimParameter_WeaponId;

	[HideInInspector]
	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x1E4")]
	public int m_AnimParameter_Trigger_PassingAttack;

	[HideInInspector]
	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x1E8")]
	public int m_AnimParameter_Trigger_PassingAttackNpc;

	[HideInInspector]
	[Token(Token = "0x4000A67")]
	[FieldOffset(Offset = "0x1EC")]
	public int m_AnimParameter_PassingAttackSide;

	[HideInInspector]
	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x1F0")]
	public int m_AnimParameter_MoveAgent_DeltaYawAnglePerFrame;

	[HideInInspector]
	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0x1F4")]
	public int m_AnimParameter_MoveAgent_DeltaHeadAnglePerFrame;

	[HideInInspector]
	[Token(Token = "0x4000A6A")]
	[FieldOffset(Offset = "0x1F8")]
	public int m_AnimParameter_Trigger_Timberwolf_Attack;

	[HideInInspector]
	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x1FC")]
	public int m_AnimState_Howl;

	[HideInInspector]
	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x200")]
	public bool m_AttachToPlayer;

	[HideInInspector]
	[Token(Token = "0x4000A6D")]
	[FieldOffset(Offset = "0x204")]
	public float m_AttachBlendInTime;

	[HideInInspector]
	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x208")]
	public float m_AttachBlendOutTime;

	[Token(Token = "0x4000A6F")]
	public static bool s_ManualFrustumCullingEnabled;

	[Token(Token = "0x4000A70")]
	[FieldOffset(Offset = "0x20C")]
	private float m_AnimParameter_Wounded_LastSent;

	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x210")]
	private AnimationEventDictionary m_AnimationEventDictionary;

	[Token(Token = "0x4000A72")]
	[FieldOffset(Offset = "0x218")]
	protected DamageSide m_LastDamageSide;

	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x21C")]
	private int m_LastDamageBodyPart;

	[HideInInspector]
	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0x220")]
	public int m_LastWanderPause;

	[Token(Token = "0x4000A75")]
	[FieldOffset(Offset = "0x224")]
	private bool m_ImposterAnimatorDisabled;

	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0x228")]
	private AnimatorCullingMode m_ImposterCullingMode;

	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0x22C")]
	private bool m_RenderersEnabled;

	[Token(Token = "0x4000A78")]
	[FieldOffset(Offset = "0x230")]
	private FootstepInfo[] m_FootstepInfo;

	[Token(Token = "0x4000A79")]
	[FieldOffset(Offset = "0x238")]
	public float m_RangeMeleeAttack;

	[Token(Token = "0x4000A7A")]
	[FieldOffset(Offset = "0x23C")]
	public float m_RangeMeleeAttackSmallAnimal;

	[Token(Token = "0x4000A7B")]
	[FieldOffset(Offset = "0x240")]
	public float m_RangeMeleeAttackLargeAnimal;

	[Token(Token = "0x4000A7C")]
	[FieldOffset(Offset = "0x244")]
	public float m_PassingAttackRange;

	[Token(Token = "0x4000A7D")]
	[FieldOffset(Offset = "0x248")]
	public float m_PassingAttackRangeNpc;

	[Token(Token = "0x4000A7E")]
	[FieldOffset(Offset = "0x24C")]
	public float m_MeleeAttackDamage;

	[Token(Token = "0x4000A7F")]
	[FieldOffset(Offset = "0x250")]
	public float m_AttackChanceAfterNearMissGunshot;

	[Token(Token = "0x4000A80")]
	[FieldOffset(Offset = "0x254")]
	public float m_AttackChanceAfterNearMissRevolverShot;

	[Token(Token = "0x4000A81")]
	[FieldOffset(Offset = "0x258")]
	public GameplayTag m_DamageEventTableTag;

	[Token(Token = "0x4000A82")]
	[FieldOffset(Offset = "0x268")]
	public float m_MinDistanceToKeepWithSafeHaven;

	[Token(Token = "0x4000A83")]
	[FieldOffset(Offset = "0x26C")]
	public float m_MinDistanceToHoldFromInnerRadius;

	[Token(Token = "0x4000A84")]
	[FieldOffset(Offset = "0x270")]
	public float m_ExtraMarginForStopInField;

	[Token(Token = "0x4000A85")]
	[FieldOffset(Offset = "0x274")]
	public float m_OuterDistanceFromField;

	[Token(Token = "0x4000A86")]
	[FieldOffset(Offset = "0x278")]
	public float m_SpeedLimitAtOuterRadius;

	[Token(Token = "0x4000A87")]
	[FieldOffset(Offset = "0x27C")]
	public bool m_UseSlowdownForHold;

	[Token(Token = "0x4000A88")]
	public static bool m_AllowSlowdownForHold;

	[Token(Token = "0x4000A89")]
	[FieldOffset(Offset = "0x280")]
	public float m_BearAttackAnimationTime;

	[Token(Token = "0x4000A8A")]
	[FieldOffset(Offset = "0x284")]
	public float m_TimberwolfAttackAnimationTime;

	[Token(Token = "0x4000A8B")]
	[FieldOffset(Offset = "0x288")]
	private bool m_PlayingAttackStartAnimation;

	[Token(Token = "0x4000A8C")]
	[FieldOffset(Offset = "0x289")]
	private bool m_PlayedAttackStartAnimation;

	[Token(Token = "0x4000A8D")]
	[FieldOffset(Offset = "0x28A")]
	private bool m_BearHuntDoneInitialAttack;

	[Token(Token = "0x4000A8E")]
	[FieldOffset(Offset = "0x28C")]
	private float m_NextAllowedAttackDamageTime;

	[Token(Token = "0x4000A8F")]
	[FieldOffset(Offset = "0x290")]
	private bool m_SuppressAttackStartAnimation;

	[Token(Token = "0x4000A90")]
	[FieldOffset(Offset = "0x291")]
	private bool m_IgnoreFlaresAndFireWhenAttacking;

	[Token(Token = "0x4000A91")]
	[FieldOffset(Offset = "0x294")]
	private uint m_AttackingLoopAudioID;

	[Token(Token = "0x4000A92")]
	[FieldOffset(Offset = "0x298")]
	private float m_SpeedWhileStopping;

	[Token(Token = "0x4000A93")]
	[FieldOffset(Offset = "0x29C")]
	private Vector3 m_AdjustedTargetPosition;

	[Token(Token = "0x4000A94")]
	[FieldOffset(Offset = "0x2A8")]
	private Vector3 m_DirectionToPlayerWhenSpearDetected;

	[Token(Token = "0x4000A95")]
	[FieldOffset(Offset = "0x2B4")]
	private float m_SpeedBeforeStopping;

	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0x2B8")]
	private float m_CurrentRadius;

	[Token(Token = "0x4000A97")]
	[FieldOffset(Offset = "0x2BC")]
	private bool m_HasBeenInsideField;

	[Token(Token = "0x4000A98")]
	[FieldOffset(Offset = "0x2BD")]
	private bool m_HasBeenInNearbyField;

	[Token(Token = "0x4000A99")]
	[FieldOffset(Offset = "0x2C0")]
	protected List<float> m_LastSlopeUnderPositionList;

	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0x2C8")]
	protected int m_LastPositionsSize;

	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x2CC")]
	private Vector3 m_EnterAttackPosition;

	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0x2D8")]
	private bool m_SpearRaisedTooLate;

	[Token(Token = "0x4000A9D")]
	[FieldOffset(Offset = "0x2DC")]
	private Vector3 m_LastKnownAttackTargetPosition;

	[Token(Token = "0x4000A9E")]
	[FieldOffset(Offset = "0x2E8")]
	private bool m_DoPassingAttack;

	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0x2EC")]
	private float m_AnimationTime;

	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0x2F0")]
	public GameObject m_CarcassPrefab;

	[Token(Token = "0x4000AA1")]
	[FieldOffset(Offset = "0x2F8")]
	public string m_DisplayName;

	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0x300")]
	public AiMode m_StartMode;

	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0x304")]
	public AiMode m_DefaultMode;

	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x308")]
	public GameplayTag m_AiTag;

	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x318")]
	public AiType m_AiType;

	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x31C")]
	public AiSubType m_AiSubType;

	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x320")]
	public AiDifficulty m_AiDifficulty;

	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x324")]
	public WildlifeMode m_WildlifeMode;

	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x328")]
	public float m_CurrentHP;

	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x32C")]
	public float m_MaxHP;

	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x330")]
	public bool m_Invulnerable;

	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x334")]
	public float m_WalkSpeed;

	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x338")]
	public float m_StalkSpeed;

	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x33C")]
	public float m_StalkCatchUpSpeed;

	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x340")]
	public float m_StalkSlowlySpeed;

	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x344")]
	public float m_ChasePlayerSpeed;

	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x348")]
	public float m_RunSpeed;

	[Token(Token = "0x4000AB2")]
	[FieldOffset(Offset = "0x34C")]
	public float m_RetreatSpeed;

	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x350")]
	public float m_TurnSpeedDegreesPerSecond;

	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x358")]
	public string m_EnterStalkingAudio;

	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x360")]
	public string m_EnterAttackModeAudio;

	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x368")]
	public string m_EnterFleeModeAudio;

	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x370")]
	public string m_HoldGroundAudio;

	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x378")]
	public string m_FeedingAudio;

	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x380")]
	public string m_SleepingAudio;

	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x388")]
	public string m_StalkingAudio;

	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x390")]
	public string m_StruggleAudio;

	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x398")]
	public string m_ChasingAudio;

	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x3A0")]
	public string m_IdleAudio;

	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x3A8")]
	public string m_WanderAudio;

	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x3B0")]
	public string m_HideAndSeekAudio;

	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x3B8")]
	public string m_JoinPackAudio;

	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x3C0")]
	public float m_ImposterDistanceOnScreen;

	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x3C4")]
	public float m_ImposterDistanceOffScreen;

	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x3C8")]
	public bool m_IgnoreCriticalHits;

	[Tooltip("Whether this AI should ignore the SetWildlifeNotAttackUnprovoked flag on the experience mode tunables. Intended for Story mode creatures that must attack.")]
	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x3C9")]
	public bool m_OverrideXPModeAttackRestrictions;

	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x3CA")]
	public bool m_ScriptedSequenceInterruptible;

	[Range(0f, 10f)]
	[Tooltip("If the AI loses path while stalking, investigating or attacking, if less than this distance from target, flee")]
	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x3CC")]
	public float m_LostPathFleeDistance;

	[Range(0.1f, 50f)]
	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x3D0")]
	public float m_CantReachTargetStandoffDistance;

	[Range(0f, 1f)]
	[Tooltip("When considering the slope the creature is standing on, only apply a fraction of the angle (0-1)")]
	[Token(Token = "0x4000AC8")]
	[FieldOffset(Offset = "0x3D4")]
	public float m_ModelRollScalePercent;

	[Range(0f, 30f)]
	[Tooltip("When considering the slope the creature is standing on, limit the angle after scaling the slope (0-30)")]
	[Token(Token = "0x4000AC9")]
	[FieldOffset(Offset = "0x3D8")]
	public float m_ModelRollLimitDegrees;

	[Range(0f, 1f)]
	[Tooltip("Only consider a fraction of the translation down distance calculated (0-1)")]
	[Token(Token = "0x4000ACA")]
	[FieldOffset(Offset = "0x3DC")]
	public float m_ModelRollFootPenetrationPercent;

	[Range(0f, 1f)]
	[Tooltip("Limit the translation down distance after being adjusted by the percentage (0-1)")]
	[Token(Token = "0x4000ACB")]
	[FieldOffset(Offset = "0x3E0")]
	public float m_ModelRollFootPenetrationLimitMeters;

	[Range(-10f, 10f)]
	[Token(Token = "0x4000ACC")]
	[FieldOffset(Offset = "0x3E4")]
	public float m_NavMeshToTerrainSlopeOffset;

	[Range(-10f, 10f)]
	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0x3E8")]
	public float m_NavMeshToTerrainOffsetFudgeFactor;

	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0x3EC")]
	public Vector3 m_HeadOffset;

	[HideInInspector]
	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0x3F8")]
	public AiTarget m_CurrentTarget;

	[HideInInspector]
	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x400")]
	public Transform m_CachedTransform;

	[HideInInspector]
	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x408")]
	public AiDifficultySetting m_AiDifficultySetting;

	[HideInInspector]
	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x410")]
	public Animator m_Animator;

	[HideInInspector]
	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x418")]
	public CharacterController m_CharacterController;

	[HideInInspector]
	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x420")]
	public BodyHarvest m_BodyHarvest;

	[HideInInspector]
	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0x428")]
	public PackAnimal m_PackAnimal;

	[HideInInspector]
	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x430")]
	public HuntedPart2WaypointController m_HuntedPart2WaypointController;

	[HideInInspector]
	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0x438")]
	public BearHuntAiRedux m_BearHuntAiRedux;

	[HideInInspector]
	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0x440")]
	public Vector3 m_SpawnPos;

	[HideInInspector]
	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0x450")]
	public string m_ScriptedSequenceAnimTrigger;

	[HideInInspector]
	[Token(Token = "0x4000ADA")]
	[FieldOffset(Offset = "0x458")]
	private bool m_Imposter;

	[HideInInspector]
	[Token(Token = "0x4000ADB")]
	[FieldOffset(Offset = "0x460")]
	public string m_MissionIdSerialized;

	[Token(Token = "0x4000ADC")]
	[FieldOffset(Offset = "0x468")]
	protected AiTarget m_PlayerTarget;

	[Token(Token = "0x4000ADD")]
	[FieldOffset(Offset = "0x470")]
	protected AiMode m_CurrentMode;

	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0x474")]
	private AiMode m_PreviousMode;

	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0x478")]
	protected float m_TimeInModeSeconds;

	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0x47C")]
	private float m_TimeInModeTODHours;

	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0x480")]
	protected SpawnRegion m_SpawnRegionParent;

	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0x488")]
	private AiTarget m_AiTarget;

	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0x490")]
	protected float m_AiGoalSpeed;

	[Token(Token = "0x4000AE4")]
	[FieldOffset(Offset = "0x494")]
	private bool m_FirstFrame;

	[Token(Token = "0x4000AE5")]
	[FieldOffset(Offset = "0x498")]
	private int m_StickToGroundCollisionLayerMask;

	[Token(Token = "0x4000AE6")]
	[FieldOffset(Offset = "0x49C")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4000AE7")]
	[FieldOffset(Offset = "0x4A0")]
	private AuroraObjectMaterials m_AuroraObjectMaterials;

	[Token(Token = "0x4000AE8")]
	private static BaseAiDataProxy m_BaseAiDataProxy;

	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x4A8")]
	private float m_TorsoHalfWidth;

	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0x4B0")]
	public NavMeshAgent m_NavMeshAgentPrefab;

	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x4B8")]
	protected NavMeshAgent m_NavMeshAgent;

	[Token(Token = "0x4000AEC")]
	[FieldOffset(Offset = "0x4C0")]
	protected MoveAgent m_MoveAgent;

	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0x4C8")]
	private BaseAiData m_DeferredDeserializeData;

	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0x4D0")]
	private bool m_RequiresDeferredDeserialize;

	[Token(Token = "0x4000AEF")]
	[FieldOffset(Offset = "0x4D8")]
	private EmitterProxy m_EmitterProxy;

	[Token(Token = "0x4000AF0")]
	[FieldOffset(Offset = "0x4E0")]
	private SkinnedMeshRenderer[] m_Renderers;

	[Token(Token = "0x4000AF1")]
	private const float VIEWPORT_SCALE_ADJUSTMENT = 0.02f;

	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x4EC")]
	public float m_NumSecondsToReachMaxWoundedLocomotion;

	[HideInInspector]
	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x4F0")]
	public float m_ElapsedBleedingOutMinutes;

	[HideInInspector]
	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x4F4")]
	public float m_ElapsedWoundedMinutes;

	[HideInInspector]
	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x4F8")]
	public bool m_Wounded;

	[Token(Token = "0x4000AF7")]
	[FieldOffset(Offset = "0x4FC")]
	public float m_BleedOutTimeMinutesForFleeFromTriggerVolume;

	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x500")]
	public float m_StruggleBleedOutCapTimeMinutes;

	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x504")]
	private bool m_BleedingOut;

	[Token(Token = "0x4000AFA")]
	[FieldOffset(Offset = "0x508")]
	private float m_DeathAfterBleeingOutMinutes;

	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x510")]
	private BloodTrail m_BloodTrail;

	[Token(Token = "0x4000AFC")]
	[FieldOffset(Offset = "0x518")]
	private DamageSource m_DamageSource;

	[Token(Token = "0x4000AFD")]
	private const float DEATH_ANIMATION_DURATION = 5f;

	[Token(Token = "0x4000AFE")]
	[FieldOffset(Offset = "0x51C")]
	public float m_DistanceToSpawnCarcassSite;

	[HideInInspector]
	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0x520")]
	public bool m_ForceToCorpse;

	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0x524")]
	private float m_EnableContainerTime;

	[Token(Token = "0x4000B01")]
	[FieldOffset(Offset = "0x528")]
	private float m_TimeInDeadMode;

	[Token(Token = "0x4000B02")]
	[FieldOffset(Offset = "0x52C")]
	private bool m_EnableColliderOnDeath;

	[Token(Token = "0x4000B03")]
	[FieldOffset(Offset = "0x530")]
	private GUIStyle style;

	[Token(Token = "0x4000B04")]
	[FieldOffset(Offset = "0x538")]
	public float m_DetectionRange;

	[Token(Token = "0x4000B05")]
	[FieldOffset(Offset = "0x53C")]
	public float m_DetectionFOV;

	[Token(Token = "0x4000B06")]
	[FieldOffset(Offset = "0x540")]
	public float m_HearFootstepsRange;

	[Token(Token = "0x4000B07")]
	[FieldOffset(Offset = "0x544")]
	public float m_HearRifleRange;

	[Token(Token = "0x4000B08")]
	[FieldOffset(Offset = "0x548")]
	public float m_HearCarAlarmRange;

	[Token(Token = "0x4000B09")]
	[FieldOffset(Offset = "0x54C")]
	public float m_SmellRange;

	[Token(Token = "0x4000B0A")]
	[FieldOffset(Offset = "0x550")]
	public float m_DetectionDelayAfterSpearHitSeconds;

	[Token(Token = "0x4000B0B")]
	[FieldOffset(Offset = "0x554")]
	public float m_RangeFromScentFactor;

	[Token(Token = "0x4000B0C")]
	[FieldOffset(Offset = "0x558")]
	public float m_RangeFromScentMax;

	[Token(Token = "0x4000B0D")]
	[FieldOffset(Offset = "0x55C")]
	public float m_MaxSurvivorDistanceToPlayerForTargetting;

	[Token(Token = "0x4000B0E")]
	[FieldOffset(Offset = "0x560")]
	private float m_SuppressFootStepDetectionAndSmellSecondsRemaining;

	[Token(Token = "0x4000B0F")]
	[FieldOffset(Offset = "0x564")]
	private float m_TimeLastFootstepHeard;

	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0x568")]
	private float m_TimeForNextTargetScan;

	[Token(Token = "0x4000B11")]
	[FieldOffset(Offset = "0x56C")]
	public bool m_DisableScanForTargets;

	[Token(Token = "0x4000B12")]
	[FieldOffset(Offset = "0x570")]
	private float m_RestoreTargetAfterSpearTimerSeconds;

	[Token(Token = "0x4000B13")]
	[FieldOffset(Offset = "0x574")]
	private bool m_WasHitBySpear;

	[Token(Token = "0x4000B14")]
	[FieldOffset(Offset = "0x575")]
	private bool m_WasHitBySpearFatal;

	[Token(Token = "0x4000B15")]
	[FieldOffset(Offset = "0x578")]
	private Action m_SpearStruggleEndAction;

	[Token(Token = "0x4000B16")]
	[FieldOffset(Offset = "0x580")]
	private bool m_RestoreTargetAfterSpearTimerStarted;

	[SerializeField]
	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0x588")]
	private NavMeshObstacle m_DodgeObstacle;

	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4000B18")]
	[FieldOffset(Offset = "0x590")]
	private float m_DodgeTimeoutSeconds;

	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0x594")]
	private float m_DodgeObstacleRadius;

	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0x598")]
	private float m_DodgeObstaclePlacementMinOffset;

	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x59C")]
	private float m_DodgeObstaclePlacementOffsetSeconds;

	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4000B1C")]
	[FieldOffset(Offset = "0x5A0")]
	private float m_DodgeObstacleMinDistanceFromPlayer;

	[SerializeField]
	[Range(0f, 90f)]
	[Token(Token = "0x4000B1D")]
	[FieldOffset(Offset = "0x5A4")]
	private float m_DodgePlayerFacingAngleThreshold;

	[SerializeField]
	[Range(0f, 500f)]
	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0x5A8")]
	private float m_DodgeMaxDistance;

	[Token(Token = "0x4000B1F")]
	[FieldOffset(Offset = "0x5AC")]
	private float m_DodgeTimeoutTime;

	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x5B0")]
	private float m_DodgePlayerFacingAngleCos;

	[Token(Token = "0x4000B21")]
	[FieldOffset(Offset = "0x5B4")]
	private float m_LastDodgePlayerFacingAngle;

	[Token(Token = "0x4000B22")]
	[FieldOffset(Offset = "0x5B8")]
	public float m_DetectionRangeWhileFeeding;

	[Token(Token = "0x4000B23")]
	[FieldOffset(Offset = "0x5BC")]
	public float m_HearFootstepsRangeWhileFeeding;

	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x5C0")]
	public float m_HearFootstepsRangeWhileSleeping;

	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x5C4")]
	public float m_FeedingHoursMin;

	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0x5C8")]
	public float m_FeedingHoursMax;

	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x5D0")]
	public ItemWeight m_MeatConsumedPerHour;

	[Token(Token = "0x4000B28")]
	[FieldOffset(Offset = "0x5D8")]
	public GameObject m_FeedingBone;

	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x5E0")]
	private uint m_FeedingAudioID;

	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x5E4")]
	private float m_FeedingDurationHours;

	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x5E8")]
	private BodyHarvest m_TargetBodyHarvest;

	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x5F0")]
	private BaseAi m_TargetBaseAi;

	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x5F8")]
	private float m_ElapsedFeedingHoursToApplyAfterLoad;

	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x5FC")]
	private bool m_FakeFeeding;

	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x600")]
	private Vector3 m_FakeFeedingPos;

	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0x60C")]
	private bool m_DidStopAudio;

	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x60D")]
	private bool m_MaybeTriggerStopAgent;

	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x60E")]
	private bool m_SyncToFeed;

	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x610")]
	private float m_SyncRate;

	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x614")]
	private float m_MinSyncDistanceToPrey;

	[HideInInspector]
	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x618")]
	public BaseAi m_GroupFleeLeader;

	[Tooltip("If taking damage from the player but the AI can't see them, chance to flee (vs. attacking). Currently only used by Bear and Moose AI.")]
	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x620")]
	public int m_ChanceToFleeFromUnseenAttack;

	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x624")]
	public int m_HardenedArrowChanceToFleeFromUnseenAttack;

	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x628")]
	public int m_ChanceToFleeAfterProjectileAttack;

	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x62C")]
	public int m_HardenedArrowChanceToFleeAfterProjectileAttack;

	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x630")]
	public int m_FleeChanceWhenTargetDetected;

	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x634")]
	public int m_FleeFromFlareBounceDistance;

	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x638")]
	public int m_FleeFromTorchBounceDistance;

	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x63C")]
	public int m_FleeFromStoneBounceDistance;

	[Token(Token = "0x4000B3E")]
	[FieldOffset(Offset = "0x640")]
	public int m_FleeFromArrowImpactDistance;

	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0x644")]
	public int m_FleeFromHardenedArrowImpactDistance;

	[Token(Token = "0x4000B40")]
	[FieldOffset(Offset = "0x648")]
	public int m_FleeFromFlareGunRoundImpactDistance;

	[Token(Token = "0x4000B41")]
	[FieldOffset(Offset = "0x64C")]
	public int m_ChanceFleeTorchSwing;

	[Token(Token = "0x4000B42")]
	[FieldOffset(Offset = "0x650")]
	public int m_ChanceFleeBrandSwing;

	[Token(Token = "0x4000B43")]
	[FieldOffset(Offset = "0x654")]
	public int m_ChanceFleeFlareSwing;

	[Token(Token = "0x4000B44")]
	[FieldOffset(Offset = "0x658")]
	public int m_ChanceToFleeFromThrownTorch;

	[Token(Token = "0x4000B45")]
	[FieldOffset(Offset = "0x65C")]
	public int m_ChanceToFleeFromThrownFlare;

	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x660")]
	public int m_ChanceToFleeFromThrownStone;

	[Token(Token = "0x4000B47")]
	[FieldOffset(Offset = "0x664")]
	public int m_ChanceToFleeWhenHitByStone;

	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0x668")]
	public int m_ChanceToFleeFromThrownNoiseMaker;

	[Token(Token = "0x4000B49")]
	[FieldOffset(Offset = "0x66C")]
	public int m_DistanceForDesperationAttack;

	[Token(Token = "0x4000B4A")]
	[FieldOffset(Offset = "0x670")]
	public float m_StopFleeAfterDistance;

	[Tooltip("If >0, overrides StopFleeAfterDistance when fleeing from a thrown Stone.")]
	[Token(Token = "0x4000B4B")]
	[FieldOffset(Offset = "0x674")]
	public float m_StopFleeAfterDistanceForStone;

	[Token(Token = "0x4000B4C")]
	[FieldOffset(Offset = "0x678")]
	public float m_StopFleeAfterDistanceForSpear;

	[Token(Token = "0x4000B4D")]
	[FieldOffset(Offset = "0x67C")]
	public float m_StopFleeAfterDistanceWhenBleedingOut;

	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0x680")]
	public float m_StopFleeAfterPassingAttackDistance;

	[Token(Token = "0x4000B4F")]
	[FieldOffset(Offset = "0x684")]
	public float m_StopFleeAfterPackMoraleDistance;

	[Token(Token = "0x4000B50")]
	[FieldOffset(Offset = "0x688")]
	public float m_StopFleeAfterWeaponAimDistance;

	[Token(Token = "0x4000B51")]
	[FieldOffset(Offset = "0x68C")]
	public float m_StopFleeAfterHoldGroundDistance;

	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0x690")]
	public float m_StopFleeAfterPackDisbandDistance;

	[Token(Token = "0x4000B53")]
	[FieldOffset(Offset = "0x694")]
	public float m_MinimumFleeTime;

	[Tooltip("If >0, overrides MinimumFleeTime when fleeing from a thrown Stone.")]
	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0x698")]
	public float m_MinimumFleeTimeForStone;

	[Token(Token = "0x4000B55")]
	[FieldOffset(Offset = "0x69C")]
	public bool m_SuppressFleeAudio;

	[Token(Token = "0x4000B56")]
	[FieldOffset(Offset = "0x69D")]
	public bool m_UseRetreatSpeedInFlee;

	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0x6A0")]
	public float m_GroupFleeDetectRange;

	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0x6A4")]
	public float m_GroupFleeRepeatDetectSeconds;

	[Token(Token = "0x4000B59")]
	[FieldOffset(Offset = "0x6A8")]
	public string m_PlayerKnockdownSFX;

	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0x6B0")]
	public Vector3 m_FleeFromPos;

	[Token(Token = "0x4000B5B")]
	protected const float KNOCKDOWN_RADIUS = 2f;

	[Token(Token = "0x4000B5C")]
	protected const float GROUP_FLEE_EXIT_SECONDS_MIN = 0.5f;

	[Token(Token = "0x4000B5D")]
	protected const float GROUP_FLEE_EXIT_SECONDS_MAX = 1.5f;

	[Token(Token = "0x4000B5E")]
	protected const float TIME_TO_START_FLEEING = 1f;

	[Token(Token = "0x4000B5F")]
	protected const float SECONDS_BEFORE_AUTO_FLEE_TO_SPAWN = 10f;

	[Token(Token = "0x4000B60")]
	protected const float AUTO_FLEE_TO_SPAWN_MAX_DISTANCE_FROM_FLEEPOS = 30f;

	[Token(Token = "0x4000B61")]
	protected const float AUTO_FLEE_TO_SPAWN_MIN_DISTANCE_FROM_SPAWN = 5f;

	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x6BC")]
	protected Vector3 m_FleeToPos;

	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0x6C8")]
	protected bool m_PickedFleeDestination;

	[Token(Token = "0x4000B64")]
	[FieldOffset(Offset = "0x6C9")]
	protected bool m_HasPickedForcedFleePos;

	[Token(Token = "0x4000B65")]
	[FieldOffset(Offset = "0x6CC")]
	protected float m_FleeingForSeconds;

	[Token(Token = "0x4000B66")]
	[FieldOffset(Offset = "0x6D0")]
	protected float m_FleeingForSecondsSinceLastFleeToSpawnPos;

	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0x6D4")]
	private float m_WarnOthersTimer;

	[Token(Token = "0x4000B68")]
	[FieldOffset(Offset = "0x6D8")]
	private List<BaseAi> m_GroupFleeFollowers;

	[Token(Token = "0x4000B69")]
	[FieldOffset(Offset = "0x6E0")]
	private bool m_HasFoundFirstFleePoint;

	[Token(Token = "0x4000B6A")]
	[FieldOffset(Offset = "0x6E8")]
	private float[] m_FleeAngleDegreesToTry;

	[Token(Token = "0x4000B6B")]
	[FieldOffset(Offset = "0x6F0")]
	private int m_FleeAngleIndexToTry;

	[Token(Token = "0x4000B6C")]
	[FieldOffset(Offset = "0x6F4")]
	private int m_NumAnglesToTryPerFrame;

	[Token(Token = "0x4000B6D")]
	[FieldOffset(Offset = "0x6F8")]
	private bool m_ExitGroupFleeTimerStarted;

	[Token(Token = "0x4000B6E")]
	[FieldOffset(Offset = "0x6FC")]
	private float m_ExitGroupFleeTimerSeconds;

	[Token(Token = "0x4000B6F")]
	[FieldOffset(Offset = "0x700")]
	protected bool m_UseForcedFleePos;

	[Token(Token = "0x4000B70")]
	[FieldOffset(Offset = "0x704")]
	private Vector3 m_ForcedFleePos;

	[Token(Token = "0x4000B71")]
	[FieldOffset(Offset = "0x710")]
	private AiFleeReason m_FleeReason;

	[Token(Token = "0x4000B72")]
	[FieldOffset(Offset = "0x718")]
	private AreaMarkup m_FleeMarkup;

	[Token(Token = "0x4000B73")]
	[FieldOffset(Offset = "0x720")]
	private uint m_FleeAudioId;

	[Token(Token = "0x4000B74")]
	[FieldOffset(Offset = "0x728")]
	public Vector3[] m_Waypoints;

	[Token(Token = "0x4000B75")]
	[FieldOffset(Offset = "0x730")]
	private int m_TargetWaypointIndex;

	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x734")]
	private bool m_HasEnteredFollowWaypoints;

	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0x738")]
	public WaypointCompletionBehaviouir m_WaypointCompletionBehaviour;

	[Token(Token = "0x4000B78")]
	[FieldOffset(Offset = "0x73C")]
	public AiMode m_WaypointCompleteNextState;

	[Token(Token = "0x4000B79")]
	[FieldOffset(Offset = "0x740")]
	private Vector3 m_GoToPoint;

	[Token(Token = "0x4000B7A")]
	[FieldOffset(Offset = "0x74C")]
	private AiMode m_TargetMode;

	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x750")]
	public AiMarker m_AiMarker;

	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x758")]
	private bool m_BlendToPoint;

	[Token(Token = "0x4000B7D")]
	[FieldOffset(Offset = "0x75C")]
	private float m_GotoPointMovementSpeed;

	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0x760")]
	private State m_State;

	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x764")]
	public bool m_UseHeadLookat;

	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x768")]
	public float m_LookWeightHead;

	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x76C")]
	public float m_LookWeightEyes;

	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0x770")]
	public float m_LookWeightBody;

	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x774")]
	public float m_LookWeightClamp;

	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x778")]
	public float m_LookAtDistance;

	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x77C")]
	private float m_LookWeightMaster;

	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0x780")]
	public float m_FightOrFlightRange;

	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x784")]
	public float m_ChanceAttackFightOrFlight;

	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x788")]
	public float m_InvestigateAfterHoldDelaySecondsForSafeHaven;

	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x78C")]
	public float m_HoldGroundMinimumDelaySeconds;

	[Range(0f, 5f)]
	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x790")]
	public float m_HoldGroundCooldownSeconds;

	[Header("Aurora Fields")]
	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x794")]
	public float m_HoldForFieldMinimumDelaySeconds;

	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x798")]
	public float m_FleeAfterHoldDelaySecondsForAuroraField;

	[Header("Bear Spear")]
	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x79C")]
	public float m_ChanceAttackOnSpearTimeout;

	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x7A0")]
	public float m_HoldGroundSpearTimeoutGametimeMins;

	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x7A4")]
	public float m_HoldGroundDistanceFromSpear;

	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x7A8")]
	public float m_HoldGroundOuterDistanceFromSpear;

	[Header("Blue Flares")]
	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x7AC")]
	public float m_ChanceAttackOnBlueFlareTimeout;

	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x7B0")]
	public float m_HoldGroundBlueFlareTimeoutGametimeMins;

	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x7B4")]
	public float m_HoldGroundDistanceFromBlueFlare;

	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x7B8")]
	public float m_HoldGroundOuterDistanceFromBlueFlare;

	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x7BC")]
	public float m_HoldGroundDistanceFromBlueFlareOnGround;

	[Token(Token = "0x4000B96")]
	[FieldOffset(Offset = "0x7C0")]
	public float m_HoldGroundOuterDistanceFromBlueFlareOnGround;

	[Header("Fires (Campfires, Stoves, etc)")]
	[Token(Token = "0x4000B97")]
	[FieldOffset(Offset = "0x7C4")]
	public float m_ChanceAttackOnFireTimeout;

	[Token(Token = "0x4000B98")]
	[FieldOffset(Offset = "0x7C8")]
	public float m_HoldGroundFireTimeoutGametimeMins;

	[Token(Token = "0x4000B99")]
	[FieldOffset(Offset = "0x7CC")]
	public float m_HoldGroundDistanceFromFire;

	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0x7D0")]
	public float m_HoldGroundOuterDistanceFromFire;

	[Header("Red Flares")]
	[Token(Token = "0x4000B9B")]
	[FieldOffset(Offset = "0x7D4")]
	public float m_ChanceAttackOnFlareTimeout;

	[Token(Token = "0x4000B9C")]
	[FieldOffset(Offset = "0x7D8")]
	public float m_HoldGroundFlareTimeoutGametimeMins;

	[Token(Token = "0x4000B9D")]
	[FieldOffset(Offset = "0x7DC")]
	public float m_HoldGroundDistanceFromFlare;

	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x7E0")]
	public float m_HoldGroundOuterDistanceFromFlare;

	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x7E4")]
	public float m_HoldGroundDistanceFromFlareOnGround;

	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x7E8")]
	public float m_HoldGroundOuterDistanceFromFlareOnGround;

	[Header("Torches")]
	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x7EC")]
	public float m_ChanceAttackOnTorchTimeout;

	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x7F0")]
	public float m_HoldGroundTorchTimeoutGametimeMins;

	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x7F4")]
	public float m_HoldGroundDistanceFromTorch;

	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x7F8")]
	public float m_HoldGroundOuterDistanceFromTorch;

	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x7FC")]
	public float m_HoldGroundDistanceFromTorchOnGround;

	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x800")]
	public float m_HoldGroundOuterDistanceFromTorchOnGround;

	[Header("Chemical Poison")]
	[Token(Token = "0x4000BA7")]
	[FieldOffset(Offset = "0x804")]
	public float m_HoldGroundChemicalHazardTimeoutGameTimeMins;

	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x808")]
	private uint m_HoldGroundAudioID;

	[Token(Token = "0x4000BA9")]
	[FieldOffset(Offset = "0x80C")]
	private float m_TimeToStopHoldingGroundDueToSpear;

	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0x810")]
	private float m_TimeToStopHoldingGroundDueToFire;

	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0x814")]
	private float m_TimeToStopHoldingGroundDueToFlare;

	[Token(Token = "0x4000BAC")]
	[FieldOffset(Offset = "0x818")]
	private float m_TimeToStopHoldingGroundDueToTorch;

	[Token(Token = "0x4000BAD")]
	[FieldOffset(Offset = "0x81C")]
	private float m_TimeToStopHoldingGroundDueToSafeHaven;

	[Token(Token = "0x4000BAE")]
	[FieldOffset(Offset = "0x820")]
	private float m_TimeToStopHoldingGroundDueToBlueFlare;

	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0x824")]
	private bool m_WasHoldingForField;

	[Token(Token = "0x4000BB0")]
	[FieldOffset(Offset = "0x828")]
	private AuroraField m_PlayerSafeHaven;

	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0x830")]
	private AuroraField m_ContainingAuroraField;

	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0x838")]
	private float m_TimeToStopHoldingGroundDueToAuroraField;

	[Token(Token = "0x4000BB3")]
	[FieldOffset(Offset = "0x83C")]
	private float m_LastTimeWasHoldingGround;

	[Token(Token = "0x4000BB4")]
	[FieldOffset(Offset = "0x840")]
	private bool m_HoldingGroundDueToPlayerInHazardZone;

	[Token(Token = "0x4000BB5")]
	[FieldOffset(Offset = "0x844")]
	private HoldGroundReason m_HoldGroundReason;

	[Token(Token = "0x4000BB6")]
	[FieldOffset(Offset = "0x848")]
	private bool m_DelayStopHoldGroundTimers;

	[Token(Token = "0x4000BB7")]
	[FieldOffset(Offset = "0x84C")]
	private uint m_IdleAudioId;

	[Token(Token = "0x4000BB8")]
	[FieldOffset(Offset = "0x850")]
	public Vector3 m_InvestigatePos;

	[Token(Token = "0x4000BB9")]
	[FieldOffset(Offset = "0x85C")]
	private bool m_InvestigatePathStarted;

	[Token(Token = "0x4000BBA")]
	private const float m_InvestigationRadiusAroundAuroraField = 15f;

	[Token(Token = "0x4000BBB")]
	[FieldOffset(Offset = "0x85D")]
	private bool m_ForceInvestigatePos;

	[Token(Token = "0x4000BBC")]
	[FieldOffset(Offset = "0x860")]
	public GameObject m_InvestigateFoodObject;

	[Token(Token = "0x4000BBD")]
	[FieldOffset(Offset = "0x868")]
	public float m_InvestigateFoodEatDistance;

	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0x86C")]
	public float m_InvestigateFoodAvoidFireDistance;

	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0x870")]
	public float m_InvestigateFoodAvoidTargetDistance;

	[Token(Token = "0x4000BC0")]
	[FieldOffset(Offset = "0x878")]
	public AiTarget m_SmellTarget;

	[Token(Token = "0x4000BC1")]
	[FieldOffset(Offset = "0x880")]
	public float m_MinSmellDistance;

	[Token(Token = "0x4000BC2")]
	[FieldOffset(Offset = "0x884")]
	private float m_TimeNextCheckForSmells;

	[Token(Token = "0x4000BC3")]
	[FieldOffset(Offset = "0x888")]
	private bool m_HasInvestigateSmellPath;

	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0x88C")]
	private Vector3 m_PathingToSmellTargetPos;

	[Token(Token = "0x4000BC5")]
	[FieldOffset(Offset = "0x898")]
	private GameObject m_PathTargetTransform;

	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0x8A0")]
	protected Vector3 m_CurrentGroundNormal;

	[Token(Token = "0x4000BC7")]
	[FieldOffset(Offset = "0x8AC")]
	private float m_LastPositionY;

	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x8B4")]
	private int m_JobGroundRaycastId;

	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0x8B8")]
	public float m_GroundTestRadius;

	[Token(Token = "0x4000BCB")]
	public const float RAYCASTGROUNDOFFSET = 2.75f;

	[Token(Token = "0x4000BCC")]
	public const float RAYCASTGROUNDOFFSETPATHING = 2f;

	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x8BC")]
	public float m_DurationAtPointOfInterestSeconds;

	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x8C0")]
	private List<PointOfInterest> m_ActivePointsOfInterest;

	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0x8C8")]
	private int m_TargetPointOfInterestIndex;

	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0x8CC")]
	private bool m_HasEnteredPatrolPointsOfInterest;

	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x8CD")]
	private bool m_RandomizePointsOfInterest;

	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x8CE")]
	private bool m_IsAnimatingAtPointOfInterest;

	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0x8D0")]
	private float m_ElapsedTimeAtPointOfInterestSeconds;

	[Token(Token = "0x4000BD4")]
	[FieldOffset(Offset = "0x8D4")]
	public float m_SleepTimeHours;

	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0x8D8")]
	private uint m_SleepingLoopAudioID;

	[Token(Token = "0x4000BD6")]
	[FieldOffset(Offset = "0x8DC")]
	private float m_ExitSleepModeTime;

	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0x8E0")]
	private bool m_Awake;

	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0x8E4")]
	public float m_CuriousFollowDistance;

	[Token(Token = "0x4000BD9")]
	[FieldOffset(Offset = "0x8E8")]
	public float m_CuriousClosestApproachDistance;

	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0x8EC")]
	public float m_CuriousLoseInterestChance;

	[Token(Token = "0x4000BDB")]
	[FieldOffset(Offset = "0x8F0")]
	public float m_CuriousEnterStalkingChance;

	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0x8F4")]
	public float m_CuriousRollChangeIntervalMinutes;

	[Token(Token = "0x4000BDD")]
	[FieldOffset(Offset = "0x8F8")]
	public float m_MaxPlayerApproachDistanceToInvestigateFood;

	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0x8FC")]
	public float m_StalkingFollowDistance;

	[Token(Token = "0x4000BDF")]
	[FieldOffset(Offset = "0x900")]
	public float m_StaklingFollowDistanceDecreasePerMinute;

	[Token(Token = "0x4000BE0")]
	[FieldOffset(Offset = "0x904")]
	public float m_StalkingBeginChasingDistance;

	[Token(Token = "0x4000BE1")]
	[FieldOffset(Offset = "0x908")]
	public float m_StalkingBeginChasingWeakTargetDistance;

	[Token(Token = "0x4000BE2")]
	[FieldOffset(Offset = "0x90C")]
	public float m_StalkingLoseInterestIntervalMinutes;

	[Token(Token = "0x4000BE3")]
	[FieldOffset(Offset = "0x910")]
	public float m_StalkingLoseInterestChance;

	[Token(Token = "0x4000BE4")]
	[FieldOffset(Offset = "0x914")]
	public float m_BreakSlalkingRange;

	[Token(Token = "0x4000BE5")]
	[FieldOffset(Offset = "0x918")]
	public float m_BreakStalkingTimeSeconds;

	[Token(Token = "0x4000BE6")]
	[FieldOffset(Offset = "0x91C")]
	public int m_StalkingChanceWhenTargetDetected;

	[HideInInspector]
	[Token(Token = "0x4000BE7")]
	[FieldOffset(Offset = "0x920")]
	public float m_ForceStalkPlayerDistance;

	[Token(Token = "0x4000BE8")]
	[FieldOffset(Offset = "0x924")]
	private uint m_StalkingAudioID;

	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0x928")]
	private uint m_StalkingLoopAudioID;

	[Token(Token = "0x4000BEA")]
	[FieldOffset(Offset = "0x92C")]
	private float m_LostScentTimeSeconds;

	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x930")]
	private float m_CurrentStalkingFollowDistance;

	[Token(Token = "0x4000BEC")]
	[FieldOffset(Offset = "0x934")]
	private float m_StalkingPausedUntilTime;

	[Token(Token = "0x4000BED")]
	[FieldOffset(Offset = "0x938")]
	private float m_TimeToRandomizeStalkingDestination;

	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x93C")]
	private Vector3 m_StalkingDestination;

	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x948")]
	private float m_NextLoseInterestCheckHoursPlayed;

	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x94C")]
	private bool m_ForceChasePlayerSpeed;

	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0x94D")]
	private bool m_Curious;

	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x950")]
	private float m_NextCuriousChangeStateCheckHoursPlayed;

	[Token(Token = "0x4000BF3")]
	public static bool s_ForceHuntedStruggleAnim;

	[Token(Token = "0x4000BF4")]
	public static bool s_ShouldForceHuntedStruggleDraggingRotation;

	[Token(Token = "0x4000BF5")]
	public static float s_ForceHuntedStruggleDraggingFacing;

	[Token(Token = "0x4000BF6")]
	public static float s_ForceHuntedStruggleDraggingRoll;

	[Token(Token = "0x4000BF7")]
	[FieldOffset(Offset = "0x954")]
	public float m_IgnoreFootStepsAndSmellsAfterStruggleSeconds;

	[Token(Token = "0x4000BF8")]
	[FieldOffset(Offset = "0x958")]
	public bool m_UseWanderDestinationAfterStruggle;

	[Token(Token = "0x4000BF9")]
	[FieldOffset(Offset = "0x95C")]
	public Vector3 m_WanderDestinationAfterStruggle;

	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x968")]
	public string m_PlayMauledMuffleAudioId;

	[Token(Token = "0x4000BFB")]
	[FieldOffset(Offset = "0x970")]
	public string m_StopMauledMuffleAudioId;

	[Token(Token = "0x4000BFC")]
	[FieldOffset(Offset = "0x978")]
	public float m_AfterStruggleTimePassStunnedSeconds;

	[Token(Token = "0x4000BFD")]
	[FieldOffset(Offset = "0x97C")]
	private uint m_StuggleAudioId;

	[Token(Token = "0x4000BFE")]
	[FieldOffset(Offset = "0x980")]
	private int m_SpearStruggleTapCount;

	[Token(Token = "0x4000BFF")]
	[FieldOffset(Offset = "0x984")]
	private bool m_HasEnteredStruggleOnLastAttack;

	[Token(Token = "0x4000C00")]
	[FieldOffset(Offset = "0x988")]
	public int m_ChanceStunFromThrownStone;

	[Token(Token = "0x4000C01")]
	[FieldOffset(Offset = "0x98C")]
	public float m_StunSeconds;

	[Token(Token = "0x4000C02")]
	[FieldOffset(Offset = "0x990")]
	private float m_StunStartTime;

	[Token(Token = "0x4000C03")]
	[FieldOffset(Offset = "0x994")]
	private Vector3 m_StunPosition;

	[Token(Token = "0x4000C04")]
	[FieldOffset(Offset = "0x9A0")]
	public float m_WanderPauseAfterSecondsMin;

	[Token(Token = "0x4000C05")]
	[FieldOffset(Offset = "0x9A4")]
	public float m_WanderPauseAfterSecondsMax;

	[Token(Token = "0x4000C06")]
	[FieldOffset(Offset = "0x9A8")]
	public bool m_WanderUseTurnRadius;

	[Token(Token = "0x4000C07")]
	[FieldOffset(Offset = "0x9AC")]
	public float m_WanderTurnRadius;

	[Token(Token = "0x4000C08")]
	[FieldOffset(Offset = "0x9B0")]
	public float m_WanderTurnSegmentAngle;

	[Token(Token = "0x4000C09")]
	[FieldOffset(Offset = "0x9B4")]
	public float m_WanderTurnSpeedDegreesPerSecond;

	[Token(Token = "0x4000C0A")]
	[FieldOffset(Offset = "0x9B8")]
	protected bool m_PickedWanderDestination;

	[Token(Token = "0x4000C0B")]
	[FieldOffset(Offset = "0x9BC")]
	private float m_ElapsedWanderHours;

	[Token(Token = "0x4000C0C")]
	[FieldOffset(Offset = "0x9C0")]
	private float m_WanderDurationHours;

	[Token(Token = "0x4000C0D")]
	[FieldOffset(Offset = "0x9C8")]
	protected WanderRegion m_WanderRegion;

	[Token(Token = "0x4000C0E")]
	[FieldOffset(Offset = "0x9D0")]
	private Vector3 m_WanderAroundPos;

	[Token(Token = "0x4000C0F")]
	[FieldOffset(Offset = "0x9DC")]
	private float m_WanderAroundPosRadius;

	[Token(Token = "0x4000C10")]
	[FieldOffset(Offset = "0x9E0")]
	private bool m_WanderingAroundPos;

	[Token(Token = "0x4000C11")]
	[FieldOffset(Offset = "0x9E4")]
	private float m_NextCheckMovedDistanceTime;

	[Token(Token = "0x4000C12")]
	[FieldOffset(Offset = "0x9E8")]
	private Vector3 m_PositionAtLastMoveCheck;

	[Token(Token = "0x4000C13")]
	[FieldOffset(Offset = "0x9F4")]
	private Vector3 m_CurrentWanderPos;

	[Token(Token = "0x4000C14")]
	[FieldOffset(Offset = "0xA00")]
	private int m_WanderCurrentTarget;

	[Token(Token = "0x4000C15")]
	[FieldOffset(Offset = "0xA08")]
	private Vector3[] m_WanderTurnTargets;

	[Token(Token = "0x4000C16")]
	[FieldOffset(Offset = "0xA10")]
	private bool m_UseWanderAwayFromPos;

	[Token(Token = "0x4000C17")]
	[FieldOffset(Offset = "0xA14")]
	private Vector3 m_WanderAwayFromPos;

	[Token(Token = "0x4000C18")]
	[FieldOffset(Offset = "0xA20")]
	private bool m_UseWanderToPos;

	[Token(Token = "0x4000C19")]
	[FieldOffset(Offset = "0xA24")]
	private Vector3 m_WanderToPos;

	[Token(Token = "0x4000C1A")]
	[FieldOffset(Offset = "0xA30")]
	private bool m_IsGettingAwayFromAuroraField;

	[Token(Token = "0x4000C1B")]
	[FieldOffset(Offset = "0xA34")]
	private uint m_WanderAudioId;

	[Token(Token = "0x4000C1C")]
	[FieldOffset(Offset = "0xA38")]
	public int m_NumWanderPauseAnims;

	[Token(Token = "0x4000C1D")]
	[FieldOffset(Offset = "0xA3C")]
	private float m_TimeNextWanderPause;

	[Token(Token = "0x4000C1E")]
	[FieldOffset(Offset = "0xA40")]
	private int m_ForceWanderPauseId;

	[Token(Token = "0x4000C1F")]
	[FieldOffset(Offset = "0xA44")]
	private float m_FailsafeExitTime;

	[Token(Token = "0x170001A7")]
	public AiRabbit Rabbit
	{
		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x58CFB0", Offset = "0x58BDB0", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001A8")]
	public AiBear Bear
	{
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x58D030", Offset = "0x58BE30", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001A9")]
	public AiBaseWolf BaseWolf
	{
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x58D0B0", Offset = "0x58BEB0", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AA")]
	public AiWolf NormalWolf
	{
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x58D130", Offset = "0x58BF30", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AB")]
	public AiTimberwolf Timberwolf
	{
		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x58D1B0", Offset = "0x58BFB0", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AC")]
	public AiWolfStarving StarvingWolf
	{
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x58D230", Offset = "0x58C030", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AD")]
	public AiMoose Moose
	{
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x58D2B0", Offset = "0x58C0B0", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AE")]
	public AiBaseDeer BaseDeer
	{
		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x58D330", Offset = "0x58C130", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001AF")]
	public AiStag Stag
	{
		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x58D3B0", Offset = "0x58C1B0", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B0")]
	public AiStagWhite StagWhite
	{
		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x58D430", Offset = "0x58C230", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B1")]
	public AiDoe Doe
	{
		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x58D4B0", Offset = "0x58C2B0", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B2")]
	public AiPtarmigan Ptarmigan
	{
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x58D530", Offset = "0x58C330", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B3")]
	public AiCougar Cougar
	{
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x58D5B0", Offset = "0x58C3B0", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B4")]
	[field: Token(Token = "0x4000AF2")]
	[field: FieldOffset(Offset = "0x4E8")]
	public bool FailedToWarp
	{
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x58D630", Offset = "0x58C430", Length = "0x8")]
		get;
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x58D640", Offset = "0x58C440", Length = "0x7")]
		set;
	}

	[Token(Token = "0x170001B5")]
	[field: Token(Token = "0x4000BC8")]
	[field: FieldOffset(Offset = "0x8B0")]
	public bool OrientOnDead
	{
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x5B3B50", Offset = "0x5B2950", Length = "0x8")]
		get;
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x5B3B60", Offset = "0x5B2960", Length = "0x7")]
		protected set;
	}

	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdateAiming()
	{
	}

	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0x57BE40", Offset = "0x57AC40", Length = "0x85A")]
	public void UpdateAimingIk()
	{
	}

	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0x57C6A0", Offset = "0x57B4A0", Length = "0xE6")]
	private AvatarIKHint GetHintForGoal(AvatarIKGoal avatarIKGoal)
	{
		return default(AvatarIKHint);
	}

	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0x57C790", Offset = "0x57B590", Length = "0x62D")]
	private void SetIkInfo(AvatarIKGoal avatarIKGoal, Transform target, Transform hint, float weight, bool useHint)
	{
	}

	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0x57CDC0", Offset = "0x57BBC0", Length = "0x125B")]
	public virtual void Start_Anim()
	{
	}

	[Token(Token = "0x6000BA5")]
	[Address(RVA = "0x57E020", Offset = "0x57CE20", Length = "0x1E4")]
	public void UpdateAnim()
	{
	}

	[Token(Token = "0x6000BA6")]
	[Address(RVA = "0x57E210", Offset = "0x57D010", Length = "0x9D")]
	private void UpdateImposterAnimatorCulling()
	{
	}

	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0x57E2B0", Offset = "0x57D0B0", Length = "0x8")]
	public void SetIsOnScreen(bool isOnScreen)
	{
	}

	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x57E2C0", Offset = "0x57D0C0", Length = "0x139")]
	private void EnableSkinnedMeshRenderers(bool isEnabled)
	{
	}

	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x57E400", Offset = "0x57D200", Length = "0x21")]
	public void AnimSetTrigger(int id)
	{
	}

	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0x57E430", Offset = "0x57D230", Length = "0x21")]
	public void AnimResetTrigger(int id)
	{
	}

	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0x57E460", Offset = "0x57D260", Length = "0x21")]
	public void AnimSetBool(int id, bool value)
	{
	}

	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x57E490", Offset = "0x57D290", Length = "0x21")]
	public void AnimSetFloat(int id, float value)
	{
	}

	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x57E4C0", Offset = "0x57D2C0", Length = "0xC9")]
	public void AnimSetFloat(int id, float value, float dampTime, float deltaTime)
	{
	}

	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x57E590", Offset = "0x57D390", Length = "0x21")]
	public void AnimSetInt(int id, int value)
	{
	}

	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x57E5C0", Offset = "0x57D3C0", Length = "0x6E")]
	public void AnimSetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyeWeigth, float clampWeight)
	{
	}

	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x57E630", Offset = "0x57D430", Length = "0xBE")]
	public void AnimSetLookAtPosition(Vector3 pos)
	{
	}

	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x57E6F0", Offset = "0x57D4F0", Length = "0x3D")]
	public bool AnimIsPlaying(int id, int layer)
	{
		return false;
	}

	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x57E730", Offset = "0x57D530", Length = "0x80")]
	public void AnimSetBearSpearTrigger(BearSpearStruggleOutcome outcome)
	{
	}

	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x57E7C0", Offset = "0x57D5C0", Length = "0x429")]
	public void SetAnimationParameters()
	{
	}

	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0x57EBF0", Offset = "0x57D9F0", Length = "0x2D")]
	public void SetDeltaYawAngleParameter(float deltaAngle)
	{
	}

	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0x57EC20", Offset = "0x57DA20", Length = "0x2D")]
	public void SetDeltaHeadAngleParameter(float deltaAngle)
	{
	}

	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x57EC50", Offset = "0x57DA50", Length = "0x1EF")]
	public void SetSpeedForPathfindingSystem()
	{
	}

	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void OnIgnoreGlowPitch(int value)
	{
	}

	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x57EE40", Offset = "0x57DC40", Length = "0x4C")]
	public void OnIsOnHindLegs(int value)
	{
	}

	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x57EE90", Offset = "0x57DC90", Length = "0x6B")]
	public void OnAudioEvent(string audioEventName)
	{
	}

	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x57EF00", Offset = "0x57DD00", Length = "0x6FA")]
	public void OnBreathEffect()
	{
	}

	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x57F600", Offset = "0x57E400", Length = "0x9F")]
	public void OnAudioStruggleEvent(string audioEventName)
	{
	}

	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0x57F6A0", Offset = "0x57E4A0", Length = "0x53")]
	public void OnFootStepFrontLeft(string audioEventName)
	{
	}

	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x57F700", Offset = "0x57E500", Length = "0x50")]
	public void OnFootStepFrontRight(string audioEventName)
	{
	}

	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x57F750", Offset = "0x57E550", Length = "0x53")]
	public void OnFootStepBackLeft(string audioEventName)
	{
	}

	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x57F7B0", Offset = "0x57E5B0", Length = "0x53")]
	public void OnFootStepBackRight(string audioEventName)
	{
	}

	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x57F810", Offset = "0x57E610", Length = "0x7")]
	public void OnGetRandomId()
	{
	}

	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x57F820", Offset = "0x57E620", Length = "0x10")]
	public void OnPlayerAttach(float blendTime)
	{
	}

	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0x57F830", Offset = "0x57E630", Length = "0x10")]
	public void OnPlayerDetach(float blendTime)
	{
	}

	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void AnimationEndSniff()
	{
	}

	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void AnimationEndWanderPause()
	{
	}

	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0x57F840", Offset = "0x57E640", Length = "0x90")]
	public bool TriggerCallback(AnimationCallbackEvent animationCallbackEvent)
	{
		return false;
	}

	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0x57F8E0", Offset = "0x57E6E0", Length = "0x59")]
	public void EnableWeapon(StruggleBonus.StruggleWeaponType weaponType)
	{
	}

	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x57F940", Offset = "0x57E740", Length = "0x50")]
	public void ResetWeapon()
	{
	}

	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0x57F9A0", Offset = "0x57E7A0", Length = "0x9C")]
	private void HandleFootprintsForDespawn()
	{
	}

	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0x57FA40", Offset = "0x57E840", Length = "0x5D")]
	private void HandleFootprint(string audioEvent, Foot foot)
	{
	}

	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x57FAA0", Offset = "0x57E8A0", Length = "0x6AB")]
	private void PlaceFootPrintDecal(Foot foot)
	{
	}

	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x580150", Offset = "0x57EF50", Length = "0x3D")]
	private void OnPlaceFootPrintDecalRaycastCompleted_FrontLeft(RaycastHit hitOut)
	{
	}

	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x580190", Offset = "0x57EF90", Length = "0x3C")]
	private void OnPlaceFootPrintDecalRaycastCompleted_FrontRight(RaycastHit hitOut)
	{
	}

	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x5801D0", Offset = "0x57EFD0", Length = "0x3D")]
	private void OnPlaceFootPrintDecalRaycastCompleted_BackLeft(RaycastHit hitOut)
	{
	}

	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x580210", Offset = "0x57F010", Length = "0x3D")]
	private void OnPlaceFootPrintDecalRaycastCompleted_BackRight(RaycastHit hitOut)
	{
	}

	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	protected virtual bool CanPlaceFootprints()
	{
		return false;
	}

	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x580250", Offset = "0x57F050", Length = "0x470")]
	private void OnPlaceFootPrintDecalRaycastCompleted(RaycastHit hitOut, Foot foot)
	{
	}

	[Token(Token = "0x6000BD1")]
	[Address(RVA = "0x5806D0", Offset = "0x57F4D0", Length = "0x75")]
	private bool ShouldPlaceFootPrintDecal()
	{
		return false;
	}

	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0x580750", Offset = "0x57F550", Length = "0x440")]
	private void PlayFootStepAudio(string audioEventName, Foot foot)
	{
	}

	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0x580BA0", Offset = "0x57F9A0", Length = "0x92")]
	private void SetNextRandomIdTime()
	{
	}

	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0x580C40", Offset = "0x57FA40", Length = "0x162")]
	private void UpdateActiveRandomId()
	{
	}

	[Token(Token = "0x6000BD5")]
	[Address(RVA = "0x580DB0", Offset = "0x57FBB0", Length = "0x28C")]
	private void GetRandomId()
	{
	}

	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0x581040", Offset = "0x57FE40", Length = "0x194")]
	private void SetSpeedAnimationParameter()
	{
	}

	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x5811E0", Offset = "0x57FFE0", Length = "0x20C")]
	private void SetTurnSpeedAnimationParameter()
	{
	}

	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x5813F0", Offset = "0x5801F0", Length = "0x200")]
	public static void SetTurnAngleParameters(Animator animator, float totalTurnAngle, float turnSpeed, Vector3 turnHeading, Vector3 forward, int turnAngleParam)
	{
	}

	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x581600", Offset = "0x580400", Length = "0x53B")]
	private void SetTargetHeadingParameter()
	{
	}

	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x581B40", Offset = "0x580940", Length = "0x80")]
	private float GetFlattenedAngle(Vector3 inVec)
	{
		return 0f;
	}

	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x581BC0", Offset = "0x5809C0", Length = "0x19E")]
	private void SetPitchRollParameters()
	{
	}

	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x581D60", Offset = "0x580B60", Length = "0x11F")]
	private void SetAnimStateForMoveAgent(MoveState moveState, int animState)
	{
	}

	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x581E80", Offset = "0x580C80", Length = "0x12C")]
	private void SetAiStateParameter()
	{
	}

	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0x582030", Offset = "0x580E30", Length = "0x1BC")]
	private void SetWoundedParameter()
	{
	}

	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x5821F0", Offset = "0x580FF0", Length = "0x17F")]
	private void MaybeUpdateStandingOnMaterialTag()
	{
	}

	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x582370", Offset = "0x581170", Length = "0x250")]
	private bool PositionOverlapsRecentFootprints(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x5825D0", Offset = "0x5813D0", Length = "0x9E")]
	private void SetCullModeAlways()
	{
	}

	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x582670", Offset = "0x581470", Length = "0xA1")]
	private void ResetDefaultCullmode()
	{
	}

	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x582720", Offset = "0x581520", Length = "0x3A2")]
	private void SetDamageImpactParameter(DamageSide side, int bodyPart, SetupDamageParamsOptions setupDamageParamsOptions)
	{
	}

	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x582AD0", Offset = "0x5818D0", Length = "0x458")]
	private bool CanFallToSide(DamageSide side)
	{
		return false;
	}

	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x582F30", Offset = "0x581D30", Length = "0x33E")]
	private float GetSpeedFromMecanimBone()
	{
		return 0f;
	}

	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x583270", Offset = "0x582070", Length = "0x611")]
	public void EnterAttack()
	{
	}

	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x583890", Offset = "0x582690", Length = "0x290")]
	public void ExitAttack()
	{
	}

	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x583B30", Offset = "0x582930", Length = "0x57")]
	public void StopAttackAudio()
	{
	}

	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x583B90", Offset = "0x582990", Length = "0x251")]
	protected static DamageEventTable GetDamageEventsForTag(GameplayTag tag)
	{
		return null;
	}

	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x583DF0", Offset = "0x582BF0", Length = "0x68")]
	private DamageEventTable GetAttackDamageEvents()
	{
		return null;
	}

	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x583E60", Offset = "0x582C60", Length = "0x32A")]
	private void MaybeAdjustTargetPosition(Vector3 targetPosition)
	{
	}

	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x584190", Offset = "0x582F90", Length = "0x1A6")]
	private Vector3 GetPositionForHold(Vector3 targetPosition, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x584340", Offset = "0x583140", Length = "0x9F")]
	protected float GetAverageSlope()
	{
		return 0f;
	}

	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0x5843E0", Offset = "0x5831E0", Length = "0x30A")]
	private void MaybeSpearAttackTooLate()
	{
	}

	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0x5846F0", Offset = "0x5834F0", Length = "0x1B5F")]
	public void ProcessAttack()
	{
	}

	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0x586250", Offset = "0x585050", Length = "0x2CD")]
	private Vector3 GetCurrentHoldGroundCausePosition(HoldGroundReason reason)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0x586520", Offset = "0x585320", Length = "0xEC2")]
	public void MaybeApplyAttack()
	{
	}

	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0x5873F0", Offset = "0x5861F0", Length = "0xB3")]
	protected virtual void MaybeWanderAroundPointForAttack(Vector3 attackPos)
	{
	}

	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0x5874B0", Offset = "0x5862B0", Length = "0x20F")]
	public float GetModifiedAttackChance(float baseAttackChance)
	{
		return 0f;
	}

	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0x5876C0", Offset = "0x5864C0", Length = "0x8")]
	public void AttackStartAnimationDone()
	{
	}

	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0x5876D0", Offset = "0x5864D0", Length = "0x8")]
	public void SuppressAttackStartAnimation()
	{
	}

	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x5876E0", Offset = "0x5864E0", Length = "0x888")]
	public bool AttackOrFleeAfterNearMissGunshot(GunType gt)
	{
		return false;
	}

	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x587F70", Offset = "0x586D70", Length = "0x157")]
	public bool EnterAttackModeIfPossible(Vector3 attackPos, bool suppressAttackStartAnimation)
	{
		return false;
	}

	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x5880D0", Offset = "0x586ED0", Length = "0x2FB")]
	public bool CanBeHitBySpear()
	{
		return false;
	}

	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x5883D0", Offset = "0x5871D0", Length = "0x3A6")]
	private bool ShouldPlayBearAttackStartAnimation()
	{
		return false;
	}

	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0x588780", Offset = "0x587580", Length = "0x18A")]
	private bool ShouldPlayTimberwolfAttackStartAnimation()
	{
		return false;
	}

	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x588910", Offset = "0x587710", Length = "0x168")]
	protected void PlayMeleeAttackAudio()
	{
	}

	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0x588A80", Offset = "0x587880", Length = "0x15F")]
	private void UpdateAttackingAudio()
	{
	}

	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0x588BE0", Offset = "0x5879E0", Length = "0x100")]
	private int GetAttackLineOfSightLayerMask()
	{
		return 0;
	}

	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0x588CF0", Offset = "0x587AF0", Length = "0x6C")]
	private float GetSpeedForCurrentRadius(float initialSpeed, float initialRadius, float currentRadius, float innerRadius)
	{
		return 0f;
	}

	[Token(Token = "0x6000BFF")]
	[Address(RVA = "0x588D60", Offset = "0x587B60", Length = "0x240")]
	private void UpdateSpeedForHoldWithSlowdown()
	{
	}

	[Token(Token = "0x6000C00")]
	[Address(RVA = "0x588FB0", Offset = "0x587DB0", Length = "0x29E")]
	private float GetOuterRadiusForHoldGroundCause(HoldGroundReason reason)
	{
		return 0f;
	}

	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x589250", Offset = "0x588050", Length = "0x295")]
	private float GetInnerRadiusForHoldGroundCause(HoldGroundReason reason)
	{
		return 0f;
	}

	[Token(Token = "0x6000C02")]
	[Address(RVA = "0x5894F0", Offset = "0x5882F0", Length = "0x299")]
	private bool UpdateForHoldWithSlowdown()
	{
		return false;
	}

	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x589790", Offset = "0x588590", Length = "0x7F")]
	private bool MaybeHoldGroundForSpearForAttack()
	{
		return false;
	}

	[Token(Token = "0x6000C04")]
	[Address(RVA = "0x589810", Offset = "0x588610", Length = "0x13E")]
	private bool MaybeHoldGroundForTorchForAttack()
	{
		return false;
	}

	[Token(Token = "0x6000C05")]
	[Address(RVA = "0x589950", Offset = "0x588750", Length = "0x13E")]
	private bool MaybeHoldGroundForRedFlareForAttack()
	{
		return false;
	}

	[Token(Token = "0x6000C06")]
	[Address(RVA = "0x589A90", Offset = "0x588890", Length = "0xD9")]
	private bool MaybeHoldGroundForFireForAttack()
	{
		return false;
	}

	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x589B70", Offset = "0x588970", Length = "0x13E")]
	private bool MaybeHoldGroundForBlueFlareForAttack()
	{
		return false;
	}

	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x589CB0", Offset = "0x588AB0", Length = "0x171")]
	private bool MaybeHoldGroundForAttack(HoldGroundReason reason, HoldGroundCallback holdGroundCallback)
	{
		return false;
	}

	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected virtual bool MaybeHoldGroundChemicalHazardForAttack()
	{
		return false;
	}

	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x589E30", Offset = "0x588C30", Length = "0x20F")]
	private bool MaybeFleeChemicalHazard()
	{
		return false;
	}

	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0x58A040", Offset = "0x588E40", Length = "0x491")]
	private bool MaybeHoldGroundAuroraFieldForAttack()
	{
		return false;
	}

	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x58A4E0", Offset = "0x5892E0", Length = "0x36B")]
	private bool MaybeHoldGroundDueToSafeHaven()
	{
		return false;
	}

	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0x58A850", Offset = "0x589650", Length = "0x3C4")]
	private bool ShouldHoldGround()
	{
		return false;
	}

	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x58AC20", Offset = "0x589A20", Length = "0x31")]
	public bool MaybeForceHoldGround()
	{
		return false;
	}

	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x58AC60", Offset = "0x589A60", Length = "0x1B1")]
	private float GetCurrentRadiusToHoldGroundCause(HoldGroundReason reason)
	{
		return 0f;
	}

	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x58AE20", Offset = "0x589C20", Length = "0x26C")]
	private AuroraField GetVisibleFieldNearby(float radius)
	{
		return null;
	}

	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x58B090", Offset = "0x589E90", Length = "0x33D")]
	private bool IsFieldVisible(AuroraField field, float radius)
	{
		return false;
	}

	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x58B3D0", Offset = "0x58A1D0", Length = "0x37")]
	private bool IsScaredReason(HoldGroundReason reason, HoldGroundCallback holdGroundCallback)
	{
		return false;
	}

	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x58B410", Offset = "0x58A210", Length = "0x62A")]
	public bool IsTooScaredToAttack()
	{
		return false;
	}

	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected virtual bool CanDoPassingAttack()
	{
		return false;
	}

	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected virtual bool WillDoPassingAttack()
	{
		return false;
	}

	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void EnterPassingAttack()
	{
	}

	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void ProcessPassingAttack()
	{
	}

	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x58BA40", Offset = "0x58A840", Length = "0x7")]
	public void OnCarcassPickedUp()
	{
	}

	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x58BA50", Offset = "0x58A850", Length = "0x4A4")]
	public GearItem SpawnCarcassPickup()
	{
		return null;
	}

	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x58BF00", Offset = "0x58AD00", Length = "0x238")]
	private void MaybeSpawnCarcassSiteIfFarEnough()
	{
	}

	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x58C140", Offset = "0x58AF40", Length = "0xCA")]
	public void Start_Common()
	{
	}

	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x58C210", Offset = "0x58B010", Length = "0x2CC")]
	private void ProcessCommonPre()
	{
	}

	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x58C4E0", Offset = "0x58B2E0", Length = "0x1FB")]
	private void MaybeCollideWithSpear()
	{
	}

	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0x58C6E0", Offset = "0x58B4E0", Length = "0x27B")]
	private void MaybeRestoreTargetAfterSpear()
	{
	}

	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x58C960", Offset = "0x58B760", Length = "0x4F")]
	private void ProcessCommonPost()
	{
	}

	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x58C9B0", Offset = "0x58B7B0", Length = "0x22C")]
	private void MaybeDestroyIfFellThroughWorld()
	{
	}

	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x58CBE0", Offset = "0x58B9E0", Length = "0x115")]
	public void MovedDistance(Vector3 delta)
	{
	}

	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x58CD00", Offset = "0x58BB00", Length = "0x293")]
	public void ClearTarget()
	{
	}

	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x58CFA0", Offset = "0x58BDA0", Length = "0xE")]
	public void ReturnToDefaultBehavior()
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x58D650", Offset = "0x58C450", Length = "0x175")]
	private void DebugAiStateTrace(AiMode mode, string locationTag)
	{
	}

	[Token(Token = "0x6000C34")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void ApplyBloodLossEvent(AfflictionOptions options)
	{
	}

	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void ApplySprainedWristEvent(AfflictionOptions options)
	{
	}

	[Token(Token = "0x6000C36")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void ApplySprainedAnkleEvent(AfflictionOptions options)
	{
	}

	[Token(Token = "0x6000C37")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void ApplyRiskOfInfectionEvent()
	{
	}

	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x58D7D0", Offset = "0x58C5D0", Length = "0x8")]
	public virtual bool IsImposter()
	{
		return false;
	}

	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x58D7E0", Offset = "0x58C5E0", Length = "0x8")]
	public bool HasUpdated()
	{
		return false;
	}

	[Token(Token = "0x6000C3A")]
	[Address(RVA = "0x58D7F0", Offset = "0x58C5F0", Length = "0xD12")]
	public bool CreateMoveAgent(Transform parent)
	{
		return false;
	}

	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x58E510", Offset = "0x58D310", Length = "0xA97")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x58EFB0", Offset = "0x58DDB0", Length = "0x284")]
	public void Start()
	{
	}

	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0x58F240", Offset = "0x58E040", Length = "0x49E")]
	public void Update()
	{
	}

	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x58F6E0", Offset = "0x58E4E0", Length = "0x11D")]
	public void ReparentBaseAi(Transform newParent, bool worldPositionStays = true)
	{
	}

	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x58F800", Offset = "0x58E600", Length = "0x7B")]
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x58F880", Offset = "0x58E680", Length = "0x51")]
	public void SetPosition(Vector3 position)
	{
	}

	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x58F8E0", Offset = "0x58E6E0", Length = "0xBA")]
	public void SetRotation(Quaternion rotation)
	{
	}

	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x58F9A0", Offset = "0x58E7A0", Length = "0x21F")]
	public void SetCollisionMode(CollisionDetectionMode mode)
	{
	}

	[Token(Token = "0x6000C43")]
	[Address(RVA = "0x58FBC0", Offset = "0x58E9C0", Length = "0xCD")]
	public bool IsMoveAgent()
	{
		return false;
	}

	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x58FC90", Offset = "0x58EA90", Length = "0x158")]
	public MoveAgent GetMoveAgent()
	{
		return null;
	}

	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x58FDF0", Offset = "0x58EBF0", Length = "0x50")]
	public bool IsMoveAgentEnabled()
	{
		return false;
	}

	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public virtual bool CanProjectileStick()
	{
		return false;
	}

	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x58FE50", Offset = "0x58EC50", Length = "0x2C9")]
	public bool IsPlayerFacingAi()
	{
		return false;
	}

	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x590120", Offset = "0x58EF20", Length = "0xDD")]
	public bool IsPlayerFacingAi(Vector3 aiToTarget, float dotProductThreshold)
	{
		return false;
	}

	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x590200", Offset = "0x58F000", Length = "0x34")]
	private void OnAnimatorIK()
	{
	}

	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x590240", Offset = "0x58F040", Length = "0xDB")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x590320", Offset = "0x58F120", Length = "0x4D")]
	public void DoLateUpdate()
	{
	}

	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x590370", Offset = "0x58F170", Length = "0x8")]
	public bool RequiresDeferredDeserialize()
	{
		return false;
	}

	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x590380", Offset = "0x58F180", Length = "0x8")]
	public BaseAiData GetDeferredDeserializeData()
	{
		return null;
	}

	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x590390", Offset = "0x58F190", Length = "0x209")]
	public void DeferredDeserialize(BaseAiData bad)
	{
	}

	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x5905A0", Offset = "0x58F3A0", Length = "0x117F")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x591720", Offset = "0x590520", Length = "0x77")]
	public static BaseAiDataProxy GetBaseAiDataProxyFromText(string text)
	{
		return null;
	}

	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x5917A0", Offset = "0x5905A0", Length = "0xD2")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x591880", Offset = "0x590680", Length = "0xAC3")]
	public void DeserializeUsingBaseAiDataProxy(BaseAiDataProxy proxy)
	{
	}

	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x592350", Offset = "0x591150", Length = "0x5C")]
	public virtual void ProcessCurrentAiMode()
	{
	}

	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x592AE0", Offset = "0x5918E0", Length = "0x22F")]
	public bool IsInFlashLight()
	{
		return false;
	}

	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x592D10", Offset = "0x591B10", Length = "0x1968")]
	public void SetAiMode(AiMode mode)
	{
	}

	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x594750", Offset = "0x593550", Length = "0x7")]
	public AiMode GetAiMode()
	{
		return default(AiMode);
	}

	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x594760", Offset = "0x593560", Length = "0x7")]
	public AiMode GetPreviousAiMode()
	{
		return default(AiMode);
	}

	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x594770", Offset = "0x593570", Length = "0x9")]
	public float GetTimeInModeSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x594780", Offset = "0x593580", Length = "0x52")]
	public void SetSpawnRegionParent(SpawnRegion sr)
	{
	}

	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x5947E0", Offset = "0x5935E0", Length = "0x8")]
	public SpawnRegion GetSpawnRegionParent()
	{
		return null;
	}

	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x5947F0", Offset = "0x5935F0", Length = "0x112")]
	public void EnableAuroraMaterials(bool enable)
	{
	}

	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x594910", Offset = "0x593710", Length = "0x2C6")]
	public void Despawn()
	{
	}

	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0x594BE0", Offset = "0x5939E0", Length = "0x9")]
	public float GetGoalSpeed()
	{
		return 0f;
	}

	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x594BF0", Offset = "0x5939F0", Length = "0x38")]
	public float GetTurnSpeedDegreesPerSecond()
	{
		return 0f;
	}

	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x594C30", Offset = "0x593A30", Length = "0x9")]
	public void SetGoalSpeed(float speed)
	{
	}

	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x594C40", Offset = "0x593A40", Length = "0x100")]
	public void SetSpeedOverride(float speedVal)
	{
	}

	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x594D50", Offset = "0x593B50", Length = "0x7")]
	public WildlifeMode GetWildlifeMode()
	{
		return default(WildlifeMode);
	}

	[Token(Token = "0x6000C62")]
	[Address(RVA = "0x594D60", Offset = "0x593B60", Length = "0x7")]
	public void SetLastDamageSide(DamageSide side)
	{
	}

	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x594D70", Offset = "0x593B70", Length = "0x7")]
	public DamageSide GetLastDamageSide()
	{
		return default(DamageSide);
	}

	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x594D80", Offset = "0x593B80", Length = "0xB9")]
	public void DebugKill()
	{
	}

	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x594E40", Offset = "0x593C40", Length = "0x424")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x595270", Offset = "0x594070", Length = "0x22E")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x5954A0", Offset = "0x5942A0", Length = "0x7")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x5954B0", Offset = "0x5942B0", Length = "0x1DE")]
	private void StopLoopingAudio()
	{
	}

	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x595690", Offset = "0x594490", Length = "0x490")]
	private void DoCustomModeModifiers()
	{
	}

	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x595B30", Offset = "0x594930", Length = "0x67C")]
	private void CantReachTarget()
	{
	}

	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x5961B0", Offset = "0x594FB0", Length = "0x8D")]
	public void Start_Damage()
	{
	}

	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0x596240", Offset = "0x595040", Length = "0x29")]
	public void ApplyDamage(float damage, DamageSource damageSource, string collider)
	{
	}

	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x596270", Offset = "0x595070", Length = "0x379")]
	public void SetupDamageForAnim(Vector3 hitPosition, Vector3 hitSource, LocalizedDamage localizedDamage)
	{
	}

	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x5965F0", Offset = "0x5953F0", Length = "0x11")]
	public float GetBleedingOutMinutesRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public virtual bool CanBleedOut()
	{
		return false;
	}

	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x596610", Offset = "0x595410", Length = "0x654")]
	public virtual void ApplyDamage(float damage, float bleedOutMintues, DamageSource damageSource, string collider)
	{
	}

	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x596C70", Offset = "0x595A70", Length = "0x1B2")]
	public bool IsDamageFatal(float damage, DamageSource damageSource)
	{
		return false;
	}

	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x596E30", Offset = "0x595C30", Length = "0x27A")]
	public void UpdateWounds(float realtimeSeconds)
	{
	}

	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x5970B0", Offset = "0x595EB0", Length = "0x11")]
	public float GetNormalizedCondition()
	{
		return 0f;
	}

	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x5970D0", Offset = "0x595ED0", Length = "0x8")]
	public bool IsBleedingOut()
	{
		return false;
	}

	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x5970E0", Offset = "0x595EE0", Length = "0x2CA")]
	public DamageSource GetDamageSource()
	{
		return default(DamageSource);
	}

	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x5973B0", Offset = "0x5961B0", Length = "0x220")]
	public float GetWoundedAnimParameter()
	{
		return 0f;
	}

	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x5975E0", Offset = "0x5963E0", Length = "0x180")]
	public float AdustMovementSpeedForInjury(float baseSpeed)
	{
		return 0f;
	}

	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x597760", Offset = "0x596560", Length = "0xCD")]
	public bool ForceApplyDamage()
	{
		return false;
	}

	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x597830", Offset = "0x596630", Length = "0x13")]
	public bool HasDeathAnimationFinished()
	{
		return false;
	}

	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x597850", Offset = "0x596650", Length = "0x1C4D")]
	public virtual void EnterDead()
	{
	}

	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x5994A0", Offset = "0x5982A0", Length = "0x187")]
	public virtual void ProcessDead()
	{
	}

	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x599630", Offset = "0x598430", Length = "0xCB")]
	private void HandleAuroraMaterials()
	{
	}

	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x599700", Offset = "0x598500", Length = "0x2B9")]
	public void ExitDead()
	{
	}

	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x5999C0", Offset = "0x5987C0", Length = "0x43E")]
	private void ChangeCollisionCapsulesLayer(int layer)
	{
	}

	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x599E00", Offset = "0x598C00", Length = "0xA6A")]
	private bool GetDeathPose(out Vector3 position, out Vector3 normal)
	{
		position = default(Vector3);
		normal = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x59A870", Offset = "0x599670", Length = "0x23")]
	public void Start_AiDebug()
	{
	}

	[Token(Token = "0x6000C81")]
	[Address(RVA = "0x59A8A0", Offset = "0x5996A0", Length = "0x274")]
	public void ProcessAudioEvent(GameObject sender, Vector3 pos, GameAudioAiEvent eventType)
	{
	}

	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x59AB20", Offset = "0x599920", Length = "0x61")]
	public bool CanSeeTarget()
	{
		return false;
	}

	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x59AB90", Offset = "0x599990", Length = "0x6AD")]
	protected virtual float ComputeDistanceForTarget(Vector3 eyePos, AiTarget potentialTarget)
	{
		return 0f;
	}

	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x59B240", Offset = "0x59A040", Length = "0xD8A")]
	public void ScanForNewTarget()
	{
	}

	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x59BFD0", Offset = "0x59ADD0", Length = "0x11A")]
	public void OnSpearHit(bool isFatal, Action onSpearStruggleEnd)
	{
	}

	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x59C0F0", Offset = "0x59AEF0", Length = "0x2E4")]
	public void ScanForSmells()
	{
	}

	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x59C3E0", Offset = "0x59B1E0", Length = "0x9")]
	public void IngoreFootStepsAndSmellsForSeconds(float realtimeSeconds)
	{
	}

	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x59C3F0", Offset = "0x59B1F0", Length = "0x103")]
	public Vector3 GetEyePos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected virtual bool WillOnlyTargetPlayer()
	{
		return false;
	}

	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void DoOnDetection()
	{
	}

	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x59C500", Offset = "0x59B300", Length = "0x6E3")]
	private void ChangeModeWhenTargetDetected()
	{
	}

	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0x59CBF0", Offset = "0x59B9F0", Length = "0x103")]
	private bool CanBearSeePlayerAfterSpearStruggle()
	{
		return false;
	}

	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x59CD00", Offset = "0x59BB00", Length = "0x589")]
	protected bool TargetCanBeIgnored(AiTarget target)
	{
		return false;
	}

	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x59D290", Offset = "0x59C090", Length = "0x27B")]
	private bool IgnoreAudioEvent(GameObject sender, Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x59D510", Offset = "0x59C310", Length = "0x520")]
	private void ProcessGenericAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x59DA40", Offset = "0x59C840", Length = "0xB5E")]
	private void ProcessFootstepAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x59E5A0", Offset = "0x59D3A0", Length = "0x530")]
	private void ProcessGunshotAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x59EAE0", Offset = "0x59D8E0", Length = "0x1D9")]
	private void ProcessCarAlarmAudioEvent(GameObject sender, Vector3 pos)
	{
	}

	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x59ECC0", Offset = "0x59DAC0", Length = "0x22")]
	private float GetDetectionRange()
	{
		return 0f;
	}

	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x59ECF0", Offset = "0x59DAF0", Length = "0x2B")]
	private float GetHearFootstepsRange()
	{
		return 0f;
	}

	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x59ED20", Offset = "0x59DB20", Length = "0x3C")]
	private float GetRangeFromScentIntensity(float scentIntensity)
	{
		return 0f;
	}

	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x59ED60", Offset = "0x59DB60", Length = "0x677")]
	private bool CanSmellSource(Vector3 sourcePos, AiTarget target)
	{
		return false;
	}

	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x59F3E0", Offset = "0x59E1E0", Length = "0xB1")]
	private void SetNextSmellCheckTime()
	{
	}

	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x59F4A0", Offset = "0x59E2A0", Length = "0x21B")]
	private void DoTargetDetectedWhileFeeding()
	{
	}

	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x59F6C0", Offset = "0x59E4C0", Length = "0x2A8")]
	private bool ShouldScanForSmells()
	{
		return false;
	}

	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x59F970", Offset = "0x59E770", Length = "0x16")]
	private bool AiModeAllowsForSmellDetection()
	{
		return false;
	}

	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x59F990", Offset = "0x59E790", Length = "0x1A9")]
	private bool CanDodge()
	{
		return false;
	}

	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x59FB40", Offset = "0x59E940", Length = "0x6CB")]
	private void MaybeAttemptDodge()
	{
	}

	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x5A0210", Offset = "0x59F010", Length = "0x55")]
	private bool HasDodgePlacementTimedOut()
	{
		return false;
	}

	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x5A0270", Offset = "0x59F070", Length = "0x2FE")]
	private bool IsPlayerAThreat()
	{
		return false;
	}

	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x5A0570", Offset = "0x59F370", Length = "0x5C")]
	private bool IsMovingTowardsOrAwayFromPlayer(Vector3 moveDirection, Vector3 playerDirection)
	{
		return false;
	}

	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x5A05D0", Offset = "0x59F3D0", Length = "0x3B6")]
	private bool DoesPositionIntefereWithAttacks(Vector3 pos, float radius, Vector3 playerPos)
	{
		return false;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void SetDebugSphere(bool enable)
	{
	}

	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x5A0990", Offset = "0x59F790", Length = "0xED")]
	private Vector3 ComputeDodgeObstaclePosition(Vector3 pos, Vector3 moveDirection)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x5A0A80", Offset = "0x59F880", Length = "0x132")]
	private void DisableDodgeObstacle()
	{
	}

	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x5A0BC0", Offset = "0x59F9C0", Length = "0x249")]
	private void EnableDodgeObstacle(Vector3 pos)
	{
	}

	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x5A0E10", Offset = "0x59FC10", Length = "0x646")]
	public void EnterFeeding()
	{
	}

	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0x5A1460", Offset = "0x5A0260", Length = "0x116")]
	private bool MaybeWaitForStopAgent()
	{
		return false;
	}

	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0x5A1580", Offset = "0x5A0380", Length = "0x425")]
	private bool MaybeSyncToFeeding()
	{
		return false;
	}

	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x5A19B0", Offset = "0x5A07B0", Length = "0x51")]
	public void ExitFeeding()
	{
	}

	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0x5A1A10", Offset = "0x5A0810", Length = "0x24")]
	public void ReturnToFeeding()
	{
	}

	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0x5A1A40", Offset = "0x5A0840", Length = "0x25")]
	public void SetFakeFeedingPos(Vector3 pos, float feedingDurationHours = -1f)
	{
	}

	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x5A1A70", Offset = "0x5A0870", Length = "0x207")]
	public void ProcessFeeding()
	{
	}

	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x5A1C80", Offset = "0x5A0A80", Length = "0x80")]
	public void SetRandomFeedingAnimation()
	{
	}

	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x5A1D10", Offset = "0x5A0B10", Length = "0x8")]
	public BodyHarvest GetTargetBodyHarvest()
	{
		return null;
	}

	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x5A1D20", Offset = "0x5A0B20", Length = "0x2D")]
	public float GetFeedingTimeRemainingHours()
	{
		return 0f;
	}

	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0x5A1D50", Offset = "0x5A0B50", Length = "0x68")]
	public void StopFeedingAudio()
	{
	}

	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0x5A1DC0", Offset = "0x5A0BC0", Length = "0x1C0")]
	private void DecimateCarcass(float hours)
	{
	}

	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x5A1F90", Offset = "0x5A0D90", Length = "0x141")]
	private bool ShouldStopFeeding()
	{
		return false;
	}

	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0x5A20E0", Offset = "0x5A0EE0", Length = "0x485")]
	private void SetBestFeedingTarget(Vector3 feederPos)
	{
	}

	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0x5A2570", Offset = "0x5A1370", Length = "0x11F")]
	private void ProcessFakeFeeding()
	{
	}

	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0x5A2690", Offset = "0x5A1490", Length = "0x5FE")]
	private void ProcessRealFeeding()
	{
	}

	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x5A2C90", Offset = "0x5A1A90", Length = "0x20C")]
	private void MaybeAttackOrHoldGround()
	{
	}

	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x5A2EA0", Offset = "0x5A1CA0", Length = "0x14D")]
	private void TurnTowardsFeedingPos()
	{
	}

	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x5A2FF0", Offset = "0x5A1DF0", Length = "0x2FE")]
	private Vector3 GetFeedingPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x5A32F0", Offset = "0x5A20F0", Length = "0x10")]
	public void SetFleeReason(AiFleeReason reason)
	{
	}

	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public virtual bool CanFleeFromFear()
	{
		return false;
	}

	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x5A3300", Offset = "0x5A2100", Length = "0x48D")]
	public virtual void EnterFlee()
	{
	}

	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x5A3790", Offset = "0x5A2590", Length = "0x109")]
	public virtual void ExitFlee()
	{
	}

	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x5A38A0", Offset = "0x5A26A0", Length = "0x57")]
	private void StopFleeAudio()
	{
	}

	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x5A3900", Offset = "0x5A2700", Length = "0x23A")]
	public bool MaybeHandleTimeoutFleeing()
	{
		return false;
	}

	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x5A3B40", Offset = "0x5A2940", Length = "0xF82")]
	public virtual void ProcessFlee()
	{
	}

	[Token(Token = "0x6000CBF")]
	[Address(RVA = "0x5A4AD0", Offset = "0x5A38D0", Length = "0x50")]
	public void MaybeFleeFromArrow(ArrowItem ai)
	{
	}

	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x5A4D70", Offset = "0x5A3B70", Length = "0x28")]
	public void SetForcedFleePos(Vector3 pos)
	{
	}

	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0x5A4DA0", Offset = "0x5A3BA0", Length = "0x572")]
	public static void MaybeFleeFromThrownItem(GearItem item, ContactPoint[] contacts)
	{
	}

	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x5A5320", Offset = "0x5A4120", Length = "0x26C")]
	public bool MaybeFleeFromFlareGunRound(FlareGunRoundItem fgri, float rangeScalar)
	{
		return false;
	}

	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x5A55C0", Offset = "0x5A43C0", Length = "0x1EE")]
	public virtual void MaybeFleeOrAttackFromProjectileHit(WeaponSource weapon)
	{
	}

	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0x5A57B0", Offset = "0x5A45B0", Length = "0x11C")]
	public void PlayEnterFleeAudio()
	{
	}

	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x5A58D0", Offset = "0x5A46D0", Length = "0x1B")]
	protected virtual float GetFleeSpeed()
	{
		return 0f;
	}

	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x5A58F0", Offset = "0x5A46F0", Length = "0x4BB")]
	private float GetChanceFleeFromHeldItem()
	{
		return 0f;
	}

	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x5A5DB0", Offset = "0x5A4BB0", Length = "0x3EF")]
	private float GetFleeProximityFromNearbyThrownItem(GearItem item)
	{
		return 0f;
	}

	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x5A61A0", Offset = "0x5A4FA0", Length = "0x43D")]
	private float GetChanceFleeFromNearbyThrownItem(GearItem item, bool wasHit)
	{
		return 0f;
	}

	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x5A65E0", Offset = "0x5A53E0", Length = "0xCC")]
	public void MaybeFleeDueToTorchSwing()
	{
	}

	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x5A66E0", Offset = "0x5A54E0", Length = "0x5D")]
	public bool OverrideXpModeAttackRestrictions()
	{
		return false;
	}

	[Token(Token = "0x6000CCB")]
	[Address(RVA = "0x5A6740", Offset = "0x5A5540", Length = "0xAD")]
	public bool IsMismatchWildlifeMode()
	{
		return false;
	}

	[Token(Token = "0x6000CCC")]
	[Address(RVA = "0x5A67F0", Offset = "0x5A55F0", Length = "0x465")]
	public bool ShouldAlwaysFleeFromCurrentTarget()
	{
		return false;
	}

	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0x5A6C60", Offset = "0x5A5A60", Length = "0x207")]
	public void BecomeGroupFleeLeader(List<BaseAi> followerList)
	{
	}

	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x5A6E70", Offset = "0x5A5C70", Length = "0x2D")]
	public bool ShouldIgnoreGroupFleeWarning()
	{
		return false;
	}

	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x5A6EA0", Offset = "0x5A5CA0", Length = "0x754")]
	protected virtual bool KeepFleeingFromTarget()
	{
		return false;
	}

	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0x5A7600", Offset = "0x5A6400", Length = "0x221")]
	private float GetStopFleeAfterDistanceForSpear()
	{
		return 0f;
	}

	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x5A7830", Offset = "0x5A6630", Length = "0x134")]
	protected virtual Vector3 GetFleeTargetPosition(Vector3 pathDirection)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x5A7970", Offset = "0x5A6770", Length = "0x739")]
	protected bool MaybePickFleeDestinationFromAreaMarkup(out Vector3 fleePos)
	{
		fleePos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x5A80B0", Offset = "0x5A6EB0", Length = "0x5A6")]
	protected bool PickFleeDesination(out Vector3 fleePos)
	{
		fleePos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x5A8660", Offset = "0x5A7460", Length = "0x646")]
	private bool CheckFleeAngleIsValid(out Vector3 fleePos, Vector3 fleeVec, Vector3 constraintPos, float angleDegreesToTry)
	{
		fleePos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x5A8CB0", Offset = "0x5A7AB0", Length = "0x34")]
	private bool CurrentAiModeAllowFleeFromArrow()
	{
		return false;
	}

	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x5A8D10", Offset = "0x5A7B10", Length = "0x24")]
	private bool CurrentAiModeAllowFleeFromFlareGunRound()
	{
		return false;
	}

	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x5A8D80", Offset = "0x5A7B80", Length = "0x1A8")]
	private bool CurrentAiModeAllowFleeFromThrownItem(GearItem item)
	{
		return false;
	}

	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0x5A9000", Offset = "0x5A7E00", Length = "0x24")]
	private bool CurrentAiModeAllowFleeFromTorchSwing()
	{
		return false;
	}

	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x5A9070", Offset = "0x5A7E70", Length = "0x28")]
	protected virtual bool CanAttackWhileFleeing()
	{
		return false;
	}

	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0x5A90A0", Offset = "0x5A7EA0", Length = "0x23C")]
	private void MaybeAttackPlayerWhenTryingToFlee()
	{
	}

	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x5A92E0", Offset = "0x5A80E0", Length = "0xA2")]
	private bool ShouldPlayEnterFleeAudio()
	{
		return false;
	}

	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x5A9390", Offset = "0x5A8190", Length = "0x9AC")]
	private void WarnOthersNearby()
	{
	}

	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0x5A9D40", Offset = "0x5A8B40", Length = "0xCB")]
	private void PickNewGroupFleeLeader()
	{
	}

	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x5A9E10", Offset = "0x5A8C10", Length = "0xCD")]
	private bool IsGroupFleeLeader()
	{
		return false;
	}

	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x5A9EE0", Offset = "0x5A8CE0", Length = "0x13")]
	private bool CanKnockdownPlayer(AiSubType ast)
	{
		return false;
	}

	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x5A9F00", Offset = "0x5A8D00", Length = "0xEC")]
	public void FleeFrom(Transform t)
	{
	}

	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x5A9FF0", Offset = "0x5A8DF0", Length = "0x45")]
	public void FleeFrom(Vector3 pos)
	{
	}

	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x5AA040", Offset = "0x5A8E40", Length = "0xE")]
	public void EnterFollowWaypoints()
	{
	}

	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ExitFollowWaypoints()
	{
	}

	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x5AA050", Offset = "0x5A8E50", Length = "0x52")]
	public void SetWaypoints(Vector3[] waypoints)
	{
	}

	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0x5AA0B0", Offset = "0x5A8EB0", Length = "0xC2")]
	public void ProcessFollowWaypoints()
	{
	}

	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x5AA180", Offset = "0x5A8F80", Length = "0xE")]
	public void PathfindToCurrentTargetWaypoint()
	{
	}

	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x5AA190", Offset = "0x5A8F90", Length = "0x2BF")]
	public void TeleportToRandomWaypointAndPathfind()
	{
	}

	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x5AA450", Offset = "0x5A9250", Length = "0x249")]
	private int GetClosestWaypointIndex()
	{
		return 0;
	}

	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x5AA6A0", Offset = "0x5A94A0", Length = "0x81")]
	private void PathfindToWaypoint(int waypointIndex)
	{
	}

	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0x5AA730", Offset = "0x5A9530", Length = "0x4B")]
	private void PathfindToNextWaypoint()
	{
	}

	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0x5AA780", Offset = "0x5A9580", Length = "0x461")]
	private void HandleLastWaypoint()
	{
	}

	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x5AABF0", Offset = "0x5A99F0", Length = "0x1D1")]
	private bool ReachedTargetWaypoint()
	{
		return false;
	}

	[Token(Token = "0x6000CED")]
	[Address(RVA = "0x5AADD0", Offset = "0x5A9BD0", Length = "0x20A")]
	private void MaybeWander()
	{
	}

	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x5AAFE0", Offset = "0x5A9DE0", Length = "0x3A")]
	private bool ProcessSafeFollowWaypoints()
	{
		return false;
	}

	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x5AB020", Offset = "0x5A9E20", Length = "0x1EA")]
	private void DoEnterFollowWaypoints()
	{
	}

	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x5AB210", Offset = "0x5AA010", Length = "0x6F")]
	private void DoReachedTargetWaypointBehavior()
	{
	}

	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0x5AB280", Offset = "0x5AA080", Length = "0x3A")]
	public void GoToPoint(Vector3 point, AiMode targetMode, float movementSpeed)
	{
	}

	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x5AB2C0", Offset = "0x5AA0C0", Length = "0x224")]
	public void GoToAiMarker(AiMarker aiMarker, AiMode targetMode, float movementSpeed)
	{
	}

	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x5AB4F0", Offset = "0x5AA2F0", Length = "0x7")]
	public void EnterGoToPoint()
	{
	}

	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ExitGoToPoint()
	{
	}

	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0x5AB500", Offset = "0x5AA300", Length = "0x98")]
	public void ProcessGoToPoint()
	{
	}

	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x5AB5A0", Offset = "0x5AA3A0", Length = "0x2A")]
	private void UpdateGoToPointPathfinding()
	{
	}

	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x5AB5D0", Offset = "0x5AA3D0", Length = "0x18")]
	private void UpdateGoToPointBlending()
	{
	}

	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x5AB5F0", Offset = "0x5AA3F0", Length = "0xE")]
	private void OnGotoPointReached()
	{
	}

	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdateHeadTracking()
	{
	}

	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x5AB600", Offset = "0x5AA400", Length = "0x47A")]
	public void UpdateHeadTrackingIk()
	{
	}

	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x5ABA80", Offset = "0x5AA880", Length = "0x164")]
	private void SetStopHoldGroundTimers()
	{
	}

	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x5ABBF0", Offset = "0x5AA9F0", Length = "0x1A7")]
	public void EnterHoldGround()
	{
	}

	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x5ABDA0", Offset = "0x5AABA0", Length = "0xA5")]
	public void ExitHoldGround()
	{
	}

	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0x5ABE50", Offset = "0x5AAC50", Length = "0x57")]
	public void StopHoldGroundAudio()
	{
	}

	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	protected virtual bool CanHoldGround()
	{
		return false;
	}

	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x5ABEB0", Offset = "0x5AACB0", Length = "0x61")]
	private bool WasHoldingGroundRecently()
	{
		return false;
	}

	[Token(Token = "0x6000D01")]
	[Address(RVA = "0x5ABF20", Offset = "0x5AAD20", Length = "0x16A")]
	private bool MaybeHoldGroundForField()
	{
		return false;
	}

	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x5AC090", Offset = "0x5AAE90", Length = "0x28D")]
	private bool MaybeAttackOrFleeForChemicalHazard()
	{
		return false;
	}

	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x5AC320", Offset = "0x5AB120", Length = "0x122")]
	private bool MaybeAttackOrFleeIfHoldGroundForFieldChanged(bool holdGroundForField)
	{
		return false;
	}

	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x5AC450", Offset = "0x5AB250", Length = "0x722")]
	public virtual void ProcessHoldGround()
	{
	}

	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x5ACB80", Offset = "0x5AB980", Length = "0x18A")]
	private bool MaybeHoldGroundDueToStruggle()
	{
		return false;
	}

	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x5ACD10", Offset = "0x5ABB10", Length = "0x423")]
	private bool MaybeHoldGroundForSpear(float radius)
	{
		return false;
	}

	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x5AD140", Offset = "0x5ABF40", Length = "0x341")]
	private bool MaybeHoldGroundForRedFlare(float radius)
	{
		return false;
	}

	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x5AD490", Offset = "0x5AC290", Length = "0x4E9")]
	private bool MaybeHoldGroundForRedFlareOnGround(float radius)
	{
		return false;
	}

	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x5AD980", Offset = "0x5AC780", Length = "0x343")]
	private bool MaybeHoldGroundForBlueFlare(float radius)
	{
		return false;
	}

	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x5ADCD0", Offset = "0x5ACAD0", Length = "0x4E9")]
	private bool MaybeHoldGroundForBlueFlareOnGround(float radius)
	{
		return false;
	}

	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x5AE1C0", Offset = "0x5ACFC0", Length = "0x33E")]
	private bool MaybeHoldGroundForTorch(float radius)
	{
		return false;
	}

	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x5AE500", Offset = "0x5AD300", Length = "0x4E3")]
	private bool MaybeHoldGroundForTorchOnGround(float radius)
	{
		return false;
	}

	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x5AE9F0", Offset = "0x5AD7F0", Length = "0x3AE")]
	private bool MaybeHoldGroundForFire(float radius)
	{
		return false;
	}

	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x5AEDA0", Offset = "0x5ADBA0", Length = "0x1CC")]
	private void MaybeHoldGround()
	{
	}

	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x5AEFA0", Offset = "0x5ADDA0", Length = "0x3BB")]
	private void HoldGroundFightOrFlight()
	{
	}

	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x5AF360", Offset = "0x5AE160", Length = "0x230")]
	private void HoldGroundCommon(float timeStopHoldingGround, float chanceAttackOnTimeout)
	{
	}

	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x5AF5A0", Offset = "0x5AE3A0", Length = "0x46E")]
	private void HoldGroundSafeHaven()
	{
	}

	[Token(Token = "0x6000D12")]
	[Address(RVA = "0x5AFA10", Offset = "0x5AE810", Length = "0x3B5")]
	private void HoldGroundInsideAuroraField()
	{
	}

	[Token(Token = "0x6000D13")]
	[Address(RVA = "0x5AFDD0", Offset = "0x5AEBD0", Length = "0x40")]
	private bool CurrentAiModeAllowsHoldGround()
	{
		return false;
	}

	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x5AFE40", Offset = "0x5AEC40", Length = "0x1E3")]
	protected bool IsTargetGoneOrOutOfRange()
	{
		return false;
	}

	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x5B0030", Offset = "0x5AEE30", Length = "0x52A")]
	private void MaybeFleeFromHoldGround()
	{
	}

	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x5B0560", Offset = "0x5AF360", Length = "0x35F")]
	private void MaybeEnterHoldGroundForAuroraField()
	{
	}

	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x5B08C0", Offset = "0x5AF6C0", Length = "0x139")]
	private void InitializeHoldForFieldTimers()
	{
	}

	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x5B0A00", Offset = "0x5AF800", Length = "0x9D")]
	public void EnterIdle()
	{
	}

	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x5B0AA0", Offset = "0x5AF8A0", Length = "0x57")]
	public void ExitIdle()
	{
	}

	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0x5B0B00", Offset = "0x5AF900", Length = "0x63")]
	public void ProcessIdle()
	{
	}

	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0x5B0B70", Offset = "0x5AF970", Length = "0x17A")]
	public void EnterInteractWithProp()
	{
	}

	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ExitInteractWithProp()
	{
	}

	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ProcessInteractWithProp()
	{
	}

	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0x5B0CF0", Offset = "0x5AFAF0", Length = "0xE")]
	public void OnInteractWithPropComplete()
	{
	}

	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x5B0D00", Offset = "0x5AFB00", Length = "0x28F")]
	public Transform FindTransform(string transformName)
	{
		return null;
	}

	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x5B0F90", Offset = "0x5AFD90", Length = "0x5E2")]
	public void OnAttachPropInMarker()
	{
	}

	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x5B1580", Offset = "0x5B0380", Length = "0x3C5")]
	public void EnterInvestigate()
	{
	}

	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x5B1950", Offset = "0x5B0750", Length = "0x8")]
	public void ExitInvestigate()
	{
	}

	[Token(Token = "0x6000D23")]
	[Address(RVA = "0x5B1960", Offset = "0x5B0760", Length = "0x58D")]
	public void ProcessInvestigate()
	{
	}

	[Token(Token = "0x6000D24")]
	[Address(RVA = "0x58CFA0", Offset = "0x58BDA0", Length = "0xE")]
	protected virtual void ChooseNewBehaviorForInvestigate()
	{
	}

	[Token(Token = "0x6000D25")]
	[Address(RVA = "0x5B1EF0", Offset = "0x5B0CF0", Length = "0x1D")]
	public void SetInvestigatePos(Vector3 pos)
	{
	}

	[Token(Token = "0x6000D26")]
	[Address(RVA = "0x5B1F10", Offset = "0x5B0D10", Length = "0x34")]
	public void ForceInvestigatePos(Vector3 pos)
	{
	}

	[Token(Token = "0x6000D27")]
	[Address(RVA = "0x5B1F50", Offset = "0x5B0D50", Length = "0x18F")]
	private void MaybeMoveInvestigationPositionOutsideOfField()
	{
	}

	[Token(Token = "0x6000D28")]
	[Address(RVA = "0x5B20E0", Offset = "0x5B0EE0", Length = "0x2D0")]
	public void EnterInvestigateFood()
	{
	}

	[Token(Token = "0x6000D29")]
	[Address(RVA = "0x5B23C0", Offset = "0x5B11C0", Length = "0xCE")]
	public void ExitInvestigateFood()
	{
	}

	[Token(Token = "0x6000D2A")]
	[Address(RVA = "0x5B2490", Offset = "0x5B1290", Length = "0x57")]
	public void StopInvestigateFoodAudio()
	{
	}

	[Token(Token = "0x6000D2B")]
	[Address(RVA = "0x5B24F0", Offset = "0x5B12F0", Length = "0x804")]
	public void ProcessInvestigateFood()
	{
	}

	[Token(Token = "0x6000D2C")]
	[Address(RVA = "0x5B2D00", Offset = "0x5B1B00", Length = "0x317")]
	private bool CloseEnoughToEatObject(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x6000D2D")]
	[Address(RVA = "0x5B3020", Offset = "0x5B1E20", Length = "0x1CE")]
	private void MaybeClearTarget()
	{
	}

	[Token(Token = "0x6000D2E")]
	[Address(RVA = "0x5B31F0", Offset = "0x5B1FF0", Length = "0xD4")]
	public void EnterInvestigateSmell()
	{
	}

	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0x5B32D0", Offset = "0x5B20D0", Length = "0x5B")]
	public void ExitInvestigateSmell()
	{
	}

	[Token(Token = "0x6000D30")]
	[Address(RVA = "0x5B3330", Offset = "0x5B2130", Length = "0x5C3")]
	public void ProcessInvestigateSmell()
	{
	}

	[Token(Token = "0x6000D31")]
	[Address(RVA = "0x5B3900", Offset = "0x5B2700", Length = "0x24E")]
	private bool SmellLost()
	{
		return false;
	}

	[Token(Token = "0x6000D34")]
	[Address(RVA = "0x5B3B70", Offset = "0x5B2970", Length = "0x141")]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000D35")]
	[Address(RVA = "0x5B3CC0", Offset = "0x5B2AC0", Length = "0x240")]
	public void Start_Pathfinding()
	{
	}

	[Token(Token = "0x6000D36")]
	[Address(RVA = "0x5B3F10", Offset = "0x5B2D10", Length = "0x270")]
	public bool TryGetClosestNavmeshPoint(Vector3 position, out Vector3 result)
	{
		result = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000D37")]
	[Address(RVA = "0x5B4190", Offset = "0x5B2F90", Length = "0xE3")]
	public bool CanPlayerBeReached(Vector3 pos, MoveAgent.PathRequirement pathRequirement = MoveAgent.PathRequirement.FullPath)
	{
		return false;
	}

	[Token(Token = "0x6000D38")]
	[Address(RVA = "0x5B4280", Offset = "0x5B3080", Length = "0x2A1")]
	public bool CanPathfindToPosition(Vector3 pos, MoveAgent.PathRequirement pathRequirement = MoveAgent.PathRequirement.FullPath)
	{
		return false;
	}

	[Token(Token = "0x6000D39")]
	[Address(RVA = "0x5B4530", Offset = "0x5B3330", Length = "0xE5")]
	public void MoveAgentStop()
	{
	}

	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0x5B4620", Offset = "0x5B3420", Length = "0x3D7")]
	public bool StartPath(Vector3 destPos, float movementSpeed, AiTarget overrideTurnTarget = null)
	{
		return false;
	}

	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0x5B4A00", Offset = "0x5B3800", Length = "0x345")]
	public void StickPivotToGround()
	{
	}

	[Token(Token = "0x6000D3C")]
	[Address(RVA = "0x5B4D50", Offset = "0x5B3B50", Length = "0x9F")]
	public void OrientPivotToGroundImmediate()
	{
	}

	[Token(Token = "0x6000D3D")]
	[Address(RVA = "0x5B4DF0", Offset = "0x5B3BF0", Length = "0x350")]
	public void StickCharacterControllerToGround()
	{
	}

	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0x5B5150", Offset = "0x5B3F50", Length = "0xA2")]
	public void OrientCharacterControllerToGroundImmediate()
	{
	}

	[Token(Token = "0x6000D3F")]
	[Address(RVA = "0x5B5200", Offset = "0x5B4000", Length = "0x275")]
	protected virtual void OrientCharacterControllerToGround()
	{
	}

	[Token(Token = "0x6000D40")]
	[Address(RVA = "0x5B5480", Offset = "0x5B4280", Length = "0x1F0")]
	protected bool GetHitInfoUnderCharacterControllerFromBatch(out RaycastHit hitInfo)
	{
		hitInfo = default(RaycastHit);
		return false;
	}

	[Token(Token = "0x6000D41")]
	[Address(RVA = "0x5B5670", Offset = "0x5B4470", Length = "0x1E")]
	private float GetLastSafeheight(float y)
	{
		return 0f;
	}

	[Token(Token = "0x6000D42")]
	[Address(RVA = "0x5B5690", Offset = "0x5B4490", Length = "0x272")]
	protected bool GetHitInfoUnderCharacterController(out RaycastHit hitInfo, FindGroundType findGroundType)
	{
		hitInfo = default(RaycastHit);
		return false;
	}

	[Token(Token = "0x6000D43")]
	[Address(RVA = "0x5B5910", Offset = "0x5B4710", Length = "0x223")]
	public SpherecastCommand GetCommandUnderCharacterController()
	{
		return default(SpherecastCommand);
	}

	[Token(Token = "0x6000D44")]
	[Address(RVA = "0x5B5B40", Offset = "0x5B4940", Length = "0x187")]
	private bool GetHitInfoUnderPosition(Vector3 position, out RaycastHit hitInfo)
	{
		hitInfo = default(RaycastHit);
		return false;
	}

	[Token(Token = "0x6000D45")]
	[Address(RVA = "0x5B5CD0", Offset = "0x5B4AD0", Length = "0xF7")]
	private bool GetHitInfoUnderPivot(out RaycastHit hitInfo)
	{
		hitInfo = default(RaycastHit);
		return false;
	}

	[Token(Token = "0x6000D46")]
	[Address(RVA = "0x5B5DD0", Offset = "0x5B4BD0", Length = "0x128E")]
	protected void AlignTransformWithNormal(Vector3 terrainPoint, Vector3 normal, bool isRollConstrained, bool isImmediate)
	{
	}

	[Token(Token = "0x6000D47")]
	[Address(RVA = "0x5B7060", Offset = "0x5B5E60", Length = "0x7")]
	public void SetJobGroundRaycastId(int id)
	{
	}

	[Token(Token = "0x6000D48")]
	[Address(RVA = "0x5B7070", Offset = "0x5B5E70", Length = "0x18")]
	public void EnterPatrolPointsOfInterest()
	{
	}

	[Token(Token = "0x6000D49")]
	[Address(RVA = "0x5B7090", Offset = "0x5B5E90", Length = "0x8")]
	public void ExitPatrolPointsOfInterest()
	{
	}

	[Token(Token = "0x6000D4A")]
	[Address(RVA = "0x5B70A0", Offset = "0x5B5EA0", Length = "0xC0")]
	public void SetPointsOfInterest(PointOfInterest[] pointsOfInterest)
	{
	}

	[Token(Token = "0x6000D4B")]
	[Address(RVA = "0x5B7170", Offset = "0x5B5F70", Length = "0x7")]
	public void DoRandomOrderPointOfInterest(bool doRandom)
	{
	}

	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0x5B7180", Offset = "0x5B5F80", Length = "0x3BA")]
	public void ProcessPatrolPointsOfInterest()
	{
	}

	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0x5B7540", Offset = "0x5B6340", Length = "0xD4")]
	private void PathfindToPointOfInterest(int index)
	{
	}

	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0x5B7620", Offset = "0x5B6420", Length = "0x1E3")]
	private void PathfindToNextPointOfInterest()
	{
	}

	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0x5B7810", Offset = "0x5B6610", Length = "0x219")]
	private bool ReachedTargetPointOfInterest()
	{
		return false;
	}

	[Token(Token = "0x6000D50")]
	[Address(RVA = "0x5B7A30", Offset = "0x5B6830", Length = "0xED")]
	private bool ProcessSafePatrolPointsOfInterest()
	{
		return false;
	}

	[Token(Token = "0x6000D51")]
	[Address(RVA = "0x5B7B20", Offset = "0x5B6920", Length = "0xD2")]
	private void DoEnterPatrolPointsOfInterest()
	{
	}

	[Token(Token = "0x6000D52")]
	[Address(RVA = "0x5B7C00", Offset = "0x5B6A00", Length = "0x16F")]
	private void DoReachedTargetPointOfInterestBehavior()
	{
	}

	[Token(Token = "0x6000D53")]
	[Address(RVA = "0x5B7D70", Offset = "0x5B6B70", Length = "0xD4")]
	private void RoarAndReturnToPatrol(Vector3 lastKnownPosition)
	{
	}

	[Token(Token = "0x6000D54")]
	[Address(RVA = "0x5B7E50", Offset = "0x5B6C50", Length = "0x1F")]
	public void EnterRooted()
	{
	}

	[Token(Token = "0x6000D55")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ProcessRooted()
	{
	}

	[Token(Token = "0x6000D56")]
	[Address(RVA = "0x5AB4F0", Offset = "0x5AA2F0", Length = "0x7")]
	public void EnterScriptedSequence()
	{
	}

	[Token(Token = "0x6000D57")]
	[Address(RVA = "0x5B7E70", Offset = "0x5B6C70", Length = "0x156")]
	public void ExitScriptedSequence()
	{
	}

	[Token(Token = "0x6000D58")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ProcessScriptedSequence()
	{
	}

	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x5B7FD0", Offset = "0x5B6DD0", Length = "0xC8")]
	public void EnterSleep()
	{
	}

	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0x5B80A0", Offset = "0x5B6EA0", Length = "0x79")]
	public void ExitSleep()
	{
	}

	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0x5B8120", Offset = "0x5B6F20", Length = "0x57")]
	public void StopSleepingAudio()
	{
	}

	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0x5B8180", Offset = "0x5B6F80", Length = "0x16B")]
	public void ProcessSleep()
	{
	}

	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0x5B82F0", Offset = "0x5B70F0", Length = "0x11A")]
	public void EnterStalking()
	{
	}

	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0x5B8410", Offset = "0x5B7210", Length = "0x13A")]
	public void ExitStalking()
	{
	}

	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x5B8550", Offset = "0x5B7350", Length = "0x73")]
	public void StopStalkingAudio()
	{
	}

	[Token(Token = "0x6000D60")]
	[Address(RVA = "0x5B85D0", Offset = "0x5B73D0", Length = "0x774")]
	public void ProcessStalking()
	{
	}

	[Token(Token = "0x6000D61")]
	[Address(RVA = "0x5B8D50", Offset = "0x5B7B50", Length = "0x177")]
	protected virtual void MaybeWanderAroundPointForStalking()
	{
	}

	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x58CFA0", Offset = "0x58BDA0", Length = "0xE")]
	protected virtual void ChooseNewBehaviorForStalking()
	{
	}

	[Token(Token = "0x6000D63")]
	[Address(RVA = "0x5B8ED0", Offset = "0x5B7CD0", Length = "0x3A8")]
	public void MaybeForceStalkPlayer()
	{
	}

	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x5B9280", Offset = "0x5B8080", Length = "0x288")]
	private void UpdateScent()
	{
	}

	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x5B9510", Offset = "0x5B8310", Length = "0x69D")]
	private void MaybeEnterAttackModeWhenStalking()
	{
	}

	[Token(Token = "0x6000D66")]
	[Address(RVA = "0x5B9BB0", Offset = "0x5B89B0", Length = "0x88F")]
	private void MaybeInvestigateMeatWhenStalking()
	{
	}

	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x5BA440", Offset = "0x5B9240", Length = "0x694")]
	private bool CanEnterStalking()
	{
		return false;
	}

	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x5BAAE0", Offset = "0x5B98E0", Length = "0x15F")]
	private void UpdateStalkingAudio()
	{
	}

	[Token(Token = "0x6000D69")]
	[Address(RVA = "0x5BAC40", Offset = "0x5B9A40", Length = "0x1FB")]
	private void UpdateStalkingFollowDistance()
	{
	}

	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0x5BAE40", Offset = "0x5B9C40", Length = "0x658")]
	private void UpdatePathfinding()
	{
	}

	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0x5BB4A0", Offset = "0x5BA2A0", Length = "0x2FD")]
	private float GetStalkSpeedWhenTrackingPlayer(AiTarget playerTarget)
	{
		return 0f;
	}

	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x5BB7A0", Offset = "0x5BA5A0", Length = "0x406")]
	private void MaybeChangeCuriousState()
	{
	}

	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x5BBBB0", Offset = "0x5BA9B0", Length = "0x2EC")]
	public bool EnterStalkingModeIfPossible(Vector3 targetPos)
	{
		return false;
	}

	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x5BBEA0", Offset = "0x5BACA0", Length = "0x1E2")]
	private void MaybeLoseInterestWhileStalking()
	{
	}

	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x5BC090", Offset = "0x5BAE90", Length = "0x8C")]
	private void SetNextChangeCuriousStateCheckTime()
	{
	}

	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x5BC120", Offset = "0x5BAF20", Length = "0x8C")]
	private void SetNextLoseInterestCheckTime()
	{
	}

	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x5BC1B0", Offset = "0x5BAFB0", Length = "0x2EF")]
	private Vector3 GetRandomNavmeshPos(Vector3 pos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x5BC4A0", Offset = "0x5BB2A0", Length = "0x24D")]
	private void MaybeForceFasterStalkingSpeed()
	{
	}

	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x5BC6F0", Offset = "0x5BB4F0", Length = "0x2A9")]
	private bool UseFixedStalkingSpeed()
	{
		return false;
	}

	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x5BC9A0", Offset = "0x5BB7A0", Length = "0x363")]
	public void EnterStruggle()
	{
	}

	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnStruggle()
	{
	}

	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ProcessStruggle()
	{
	}

	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x57F600", Offset = "0x57E400", Length = "0x9F")]
	public void PlayStruggleAudio(string audioEventName)
	{
	}

	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x5BCD10", Offset = "0x5BBB10", Length = "0x1DC")]
	public void ExitStruggle()
	{
	}

	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x5BCEF0", Offset = "0x5BBCF0", Length = "0x57")]
	public void StopStruggleAudio()
	{
	}

	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x5BCF50", Offset = "0x5BBD50", Length = "0x30F")]
	public bool CanEnterPlayerStruggle()
	{
		return false;
	}

	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x5BD260", Offset = "0x5BC060", Length = "0x125")]
	private void DoPostSpearStruggleBehavior()
	{
	}

	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x5BD390", Offset = "0x5BC190", Length = "0x172")]
	private float GetIgnoreFootStepsAndSmellsAfterStruggleSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x5BD510", Offset = "0x5BC310", Length = "0x149")]
	public void OnSpearStruggleEnd()
	{
	}

	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x5BD660", Offset = "0x5BC460", Length = "0xAB")]
	public void OnBearBreakStruggle()
	{
	}

	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0x5BD710", Offset = "0x5BC510", Length = "0x8")]
	public bool WasHitBySpear()
	{
		return false;
	}

	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x5BD720", Offset = "0x5BC520", Length = "0x8")]
	public bool WasHitBySpearFatal()
	{
		return false;
	}

	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x5BD730", Offset = "0x5BC530", Length = "0x8")]
	public bool HasEnteredStruggleOnLastAttack()
	{
		return false;
	}

	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x5BD740", Offset = "0x5BC540", Length = "0x2A")]
	public void OnMooseStartStompAttack()
	{
	}

	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x5BD770", Offset = "0x5BC570", Length = "0x7E")]
	public void OnAnimationEvent_MooseButtHeadAttackComplete()
	{
	}

	[Token(Token = "0x6000D84")]
	[Address(RVA = "0x5BD7F0", Offset = "0x5BC5F0", Length = "0x92")]
	public void OnAnimationEvent_PlayMauledMuffle()
	{
	}

	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x5BD890", Offset = "0x5BC690", Length = "0x92")]
	public void OnAnimationEvent_StopMauledMuffle()
	{
	}

	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x5BD510", Offset = "0x5BC310", Length = "0x149")]
	public void OnAnimationEvent_SpearStruggleComplete()
	{
	}

	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x5BD930", Offset = "0x5BC730", Length = "0x183")]
	public void OnAnimationEvent_SpearDisengageReady()
	{
	}

	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x5BDAC0", Offset = "0x5BC8C0", Length = "0xC")]
	public float GetSpearStruggleTapCount()
	{
		return 0f;
	}

	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x5BDAD0", Offset = "0x5BC8D0", Length = "0x7")]
	public void SetSpearStruggleTapCount(int tapCount)
	{
	}

	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x5BDAE0", Offset = "0x5BC8E0", Length = "0x5B")]
	public void EnterStunned()
	{
	}

	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x5BDB40", Offset = "0x5BC940", Length = "0xA9")]
	public void ProcessStunned()
	{
	}

	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x5BDBF0", Offset = "0x5BC9F0", Length = "0x3B")]
	public void ExitStunned()
	{
	}

	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x5BDC30", Offset = "0x5BCA30", Length = "0x33D")]
	public static void MaybeStunnedByStone(ContactPoint[] contacts)
	{
	}

	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x5BDF70", Offset = "0x5BCD70", Length = "0xB")]
	public void ResetStunTimer()
	{
	}

	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x5BDF80", Offset = "0x5BCD80", Length = "0x89")]
	private void Stun(Vector3 position)
	{
	}

	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x5BE010", Offset = "0x5BCE10", Length = "0x28")]
	private bool CurrentAIModeAllowStunFromThrownStone()
	{
		return false;
	}

	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x5BE080", Offset = "0x5BCE80", Length = "0xC")]
	private float GetChanceStunFromThrownStone()
	{
		return 0f;
	}

	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x5BE090", Offset = "0x5BCE90", Length = "0x61")]
	private bool IsStunTimerActive()
	{
		return false;
	}

	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x5BE100", Offset = "0x5BCF00", Length = "0x5FC")]
	public void EnterWander()
	{
	}

	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x5BE700", Offset = "0x5BD500", Length = "0xFE")]
	public void ExitWander()
	{
	}

	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x5BE800", Offset = "0x5BD600", Length = "0x1C9")]
	private bool MaybeHoldGroundAuroraField()
	{
		return false;
	}

	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x5BE9D0", Offset = "0x5BD7D0", Length = "0xC08")]
	public void ProcessWander()
	{
	}

	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x5BF5E0", Offset = "0x5BE3E0", Length = "0x57")]
	public void StopWanderAudio()
	{
	}

	[Token(Token = "0x6000D98")]
	[Address(RVA = "0x5BF640", Offset = "0x5BE440", Length = "0x61F")]
	private bool MaybeMoveWanderPosOutsideOfField(out Vector3 wanderToPos, Vector3 originalPosition)
	{
		wanderToPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000D99")]
	[Address(RVA = "0x5BFC60", Offset = "0x5BEA60", Length = "0x55")]
	public float GetRandomWanderDuration()
	{
		return 0f;
	}

	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x5BFCC0", Offset = "0x5BEAC0", Length = "0x80")]
	public void WanderAroundPoint(Vector3 pos, float radius, float wanderDuration, bool wanderForever = false)
	{
	}

	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x5BFD40", Offset = "0x5BEB40", Length = "0x28")]
	public void ForceWanderToPoint(Vector3 pos)
	{
	}

	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x5BFD70", Offset = "0x5BEB70", Length = "0x8")]
	public bool IsWanderingAroundPos()
	{
		return false;
	}

	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x5BFD80", Offset = "0x5BEB80", Length = "0x500")]
	private bool PickWanderDestinationAwayFromPoint(out Vector3 wanderPos, Vector3 awayPos)
	{
		wanderPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x5C0290", Offset = "0x5BF090", Length = "0x1D")]
	public void SetWanderPosAfterStruggle(Vector3 pos)
	{
	}

	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x5C02B0", Offset = "0x5BF0B0", Length = "0x22A")]
	private bool PickClosestWanderDestinationAtPoint(out Vector3 wanderPos, Vector3 toPos)
	{
		wanderPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x5C04E0", Offset = "0x5BF2E0", Length = "0x9FB")]
	private bool PickWanderDestination(out Vector3 wanderPos)
	{
		wanderPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0x5C0EE0", Offset = "0x5BFCE0", Length = "0x22A")]
	private bool PickEmergencyWanderDestination(out Vector3 wanderPos, Vector3 toPos)
	{
		wanderPos = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000DA2")]
	[Address(RVA = "0x5C1110", Offset = "0x5BFF10", Length = "0x9A")]
	private bool WanderTimedOut()
	{
		return false;
	}

	[Token(Token = "0x6000DA3")]
	[Address(RVA = "0x5C11B0", Offset = "0x5BFFB0", Length = "0x2B")]
	private bool WanderDoingGradualTurn()
	{
		return false;
	}

	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0x5C11E0", Offset = "0x5BFFE0", Length = "0x244")]
	protected void MaybeImposter()
	{
	}

	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x5C1430", Offset = "0x5C0230", Length = "0x11A")]
	public void EnterWanderPaused()
	{
	}

	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x5C1550", Offset = "0x5C0350", Length = "0x13F")]
	public void ProcessWanderPaused()
	{
	}

	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x5C1690", Offset = "0x5C0490", Length = "0x16A")]
	public void ExitWanderPaused()
	{
	}

	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x5C1800", Offset = "0x5C0600", Length = "0x11C")]
	public void SetNextWanderPauseTime()
	{
	}

	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x5C1920", Offset = "0x5C0720", Length = "0x21F")]
	public void MaybeEnterWanderPause()
	{
	}

	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x5C1B40", Offset = "0x5C0940", Length = "0x46")]
	public void ForceWanderPause(int wanderPauseId)
	{
	}

	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x5C1B90", Offset = "0x5C0990", Length = "0x61")]
	public void OnWanderPauseAnimStateExit()
	{
	}

	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x5C1C00", Offset = "0x5C0A00", Length = "0x7D")]
	public void OnWanderPauseComplete()
	{
	}

	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x5C1C80", Offset = "0x5C0A80", Length = "0xA3B")]
	public BaseAi()
	{
	}
}
