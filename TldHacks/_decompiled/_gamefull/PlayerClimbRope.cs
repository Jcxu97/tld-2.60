using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008B2")]
public class PlayerClimbRope : MonoBehaviour
{
	[Token(Token = "0x20008B3")]
	private class OnOffTransitionInfo
	{
		[Token(Token = "0x4005ACC")]
		[FieldOffset(Offset = "0x10")]
		private PlayerClimbRope m_PCR;

		[Token(Token = "0x4005ACD")]
		[FieldOffset(Offset = "0x18")]
		public bool m_IsGetOn;

		[Token(Token = "0x4005ACE")]
		[FieldOffset(Offset = "0x19")]
		public bool m_IsExitFromFall;

		[Token(Token = "0x4005ACF")]
		[FieldOffset(Offset = "0x1C")]
		public RopeTransitionPoint m_Type;

		[Token(Token = "0x4005AD0")]
		[FieldOffset(Offset = "0x20")]
		public float m_TimeFull;

		[Token(Token = "0x4005AD1")]
		[FieldOffset(Offset = "0x24")]
		public float m_TimePart;

		[Token(Token = "0x4005AD2")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 m_Pivot;

		[Token(Token = "0x4005AD3")]
		[FieldOffset(Offset = "0x34")]
		public Quaternion m_Rot;

		[Token(Token = "0x4005AD4")]
		[FieldOffset(Offset = "0x44")]
		public float m_ViewLen;

		[Token(Token = "0x4005AD5")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 m_ViewAngles;

		[Token(Token = "0x4005AD6")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 m_FromAngles;

		[Token(Token = "0x4005AD7")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 m_FromPos;

		[Token(Token = "0x17000364")]
		public float Frac
		{
			[Token(Token = "0x600500C")]
			[Address(RVA = "0xDFD9E0", Offset = "0xDFC7E0", Length = "0x35")]
			get
			{
				return 0f;
			}
		}

		[Token(Token = "0x600500B")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		public OnOffTransitionInfo(PlayerClimbRope pcr)
		{
		}

		[Token(Token = "0x600500D")]
		[Address(RVA = "0xDFDA20", Offset = "0xDFC820", Length = "0x74B")]
		public Vector3 Update(Vector3 camPos, Vector3 splinePos, Vector3 splineTan, Vector3 splineNorm, float yaw, ref float roll, ref Vector2 viewAngles)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600500E")]
		[Address(RVA = "0xDFE170", Offset = "0xDFCF70", Length = "0x69")]
		public bool IsComplete()
		{
			return false;
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x20008B4")]
	private sealed class _003CPutPlayerOnRopeAfterDeserialize_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005AD8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005AD9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005ADA")]
		[FieldOffset(Offset = "0x20")]
		public PlayerClimbRopeProxy saveProxy;

		[Token(Token = "0x4005ADB")]
		[FieldOffset(Offset = "0x28")]
		public PlayerClimbRope _003C_003E4__this;

		[Token(Token = "0x17000365")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005012")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000366")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005014")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x600500F")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CPutPlayerOnRopeAfterDeserialize_003Ed__125(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005010")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6005011")]
		[Address(RVA = "0xDFE1E0", Offset = "0xDFCFE0", Length = "0x22F")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x6005013")]
		[Address(RVA = "0xDFE410", Offset = "0xDFD210", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Speed")]
	[Range(0f, 10f)]
	[Token(Token = "0x4005A51")]
	[FieldOffset(Offset = "0x20")]
	public float m_ClimbSpeedUpFullyRested;

	[Range(0f, 10f)]
	[Token(Token = "0x4005A52")]
	[FieldOffset(Offset = "0x24")]
	public float m_ClimbSpeedUpExhausted;

	[Range(0f, 10f)]
	[Token(Token = "0x4005A53")]
	[FieldOffset(Offset = "0x28")]
	public float m_ClimbSpeedDownFullyRested;

	[Range(0f, 10f)]
	[Token(Token = "0x4005A54")]
	[FieldOffset(Offset = "0x2C")]
	public float m_ClimbSpeedDownExhausted;

	[Range(0f, 1f)]
	[Token(Token = "0x4005A55")]
	[FieldOffset(Offset = "0x30")]
	public float m_LowStaminaSpeedScaleThreshold;

	[Range(0f, 1f)]
	[Token(Token = "0x4005A56")]
	[FieldOffset(Offset = "0x34")]
	public float m_LowestStaminaSpeedScale;

	[Header("Stamina")]
	[Range(0f, 10f)]
	[Token(Token = "0x4005A57")]
	[FieldOffset(Offset = "0x38")]
	public float m_StaminaDrainPerSecondClimbingUp;

	[Range(0f, 10f)]
	[Token(Token = "0x4005A58")]
	[FieldOffset(Offset = "0x3C")]
	public float m_StaminaDrainPerSecondClimbingDown;

	[Range(0f, 10f)]
	[Token(Token = "0x4005A59")]
	[FieldOffset(Offset = "0x40")]
	public float m_StaminaDrainPerSecondClimbingHolding;

	[Header("Fatigue")]
	[Range(0f, 10f)]
	[Token(Token = "0x4005A5A")]
	[FieldOffset(Offset = "0x44")]
	public float m_FatigueDrainPerSecondClimbingUp;

	[Range(0f, 10f)]
	[Token(Token = "0x4005A5B")]
	[FieldOffset(Offset = "0x48")]
	public float m_FatigueDrainPerSecondClimbingDown;

	[Range(0f, 10f)]
	[Token(Token = "0x4005A5C")]
	[FieldOffset(Offset = "0x4C")]
	public float m_FatigueDrainPerSecondClimbingHolding;

	[Header("View")]
	[Token(Token = "0x4005A5D")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 m_PitchLimitDegrees;

	[Token(Token = "0x4005A5E")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 m_YawLimitDegrees;

	[Header("Slip")]
	[Range(0f, 60f)]
	[Token(Token = "0x4005A5F")]
	[FieldOffset(Offset = "0x60")]
	public float m_SlipRollMinSeconds;

	[Range(0f, 60f)]
	[Token(Token = "0x4005A60")]
	[FieldOffset(Offset = "0x64")]
	public float m_SlipRollMaxSeconds;

	[Range(0f, 100f)]
	[Token(Token = "0x4005A61")]
	[FieldOffset(Offset = "0x68")]
	public float m_SlipChanceInitial;

	[Range(0f, 100f)]
	[Token(Token = "0x4005A62")]
	[FieldOffset(Offset = "0x6C")]
	public float m_SlipChanceIncreasePerRoll;

	[Range(0f, 50f)]
	[Token(Token = "0x4005A63")]
	[FieldOffset(Offset = "0x70")]
	public float m_SlipDropDistanceMin;

	[Range(0f, 50f)]
	[Token(Token = "0x4005A64")]
	[FieldOffset(Offset = "0x74")]
	public float m_SlipDropDistanceMax;

	[Header("Fall")]
	[Range(0f, 100f)]
	[Token(Token = "0x4005A65")]
	[FieldOffset(Offset = "0x78")]
	public float m_FallChanceInitial;

	[Range(0f, 100f)]
	[Token(Token = "0x4005A66")]
	[FieldOffset(Offset = "0x7C")]
	public float m_FallChanceIncreasePerRoll;

	[Range(0f, 100f)]
	[Token(Token = "0x4005A67")]
	[FieldOffset(Offset = "0x80")]
	public float m_FallDeathThreshold;

	[Token(Token = "0x4005A68")]
	[FieldOffset(Offset = "0x84")]
	public float m_FallBelowGroundLiftedPositionOffset;

	[Header("Anim")]
	[Token(Token = "0x4005A69")]
	[FieldOffset(Offset = "0x88")]
	public bool m_Anim_ConstrainPitchDuringClimb;

	[Range(0f, 90f)]
	[Token(Token = "0x4005A6A")]
	[FieldOffset(Offset = "0x8C")]
	public float m_Anim_ConstrainedPitchAngle;

	[Range(0f, 5f)]
	[Token(Token = "0x4005A6B")]
	[FieldOffset(Offset = "0x90")]
	public float m_Anim_GetOnDuration;

	[Range(0f, 5f)]
	[Token(Token = "0x4005A6C")]
	[FieldOffset(Offset = "0x94")]
	public float m_Anim_GetOnTopTimePerMeter;

	[Range(0f, 5f)]
	[Token(Token = "0x4005A6D")]
	[FieldOffset(Offset = "0x98")]
	public float m_Anim_GetOffDuration;

	[Range(0f, 10f)]
	[Token(Token = "0x4005A6E")]
	[FieldOffset(Offset = "0x9C")]
	public float m_Anim_GetUpAfterFallDuration;

	[Range(0f, 10f)]
	[Token(Token = "0x4005A6F")]
	[FieldOffset(Offset = "0xA0")]
	public float m_Anim_ClimbSpeedToAnimScalar;

	[Range(0f, 2f)]
	[Token(Token = "0x4005A70")]
	[FieldOffset(Offset = "0xA4")]
	public float m_Anim_UnitMotion;

	[Range(0f, 2f)]
	[Token(Token = "0x4005A71")]
	[FieldOffset(Offset = "0xA8")]
	public float m_Anim_DirectionTransitionTime;

	[Range(0f, 2f)]
	[Token(Token = "0x4005A72")]
	[FieldOffset(Offset = "0xAC")]
	public float m_Anim_SplineBasisBlendTime;

	[Range(0f, 2f)]
	[Token(Token = "0x4005A73")]
	[FieldOffset(Offset = "0xB0")]
	public float m_Anim_SplineRollBlendTime;

	[Range(-180f, 180f)]
	[Token(Token = "0x4005A74")]
	[FieldOffset(Offset = "0xB4")]
	public float m_Anim_ProjectionSineOffset;

	[Token(Token = "0x4005A75")]
	[FieldOffset(Offset = "0xB8")]
	public Vector2 m_Anim_ProjectionDistances;

	[Token(Token = "0x4005A76")]
	[FieldOffset(Offset = "0xC0")]
	public Vector2 m_Anim_PitchRanges;

	[Range(-180f, 180f)]
	[Token(Token = "0x4005A77")]
	[FieldOffset(Offset = "0xC8")]
	public float m_Anim_SideSwaySineOffset;

	[Token(Token = "0x4005A78")]
	[FieldOffset(Offset = "0xCC")]
	public Vector2 m_Anim_SideSwayDistances;

	[Range(-180f, 180f)]
	[Token(Token = "0x4005A79")]
	[FieldOffset(Offset = "0xD4")]
	public float m_Anim_DropBackSineOffset;

	[Token(Token = "0x4005A7A")]
	[FieldOffset(Offset = "0xD8")]
	public Vector2 m_Anim_DropBackDistances;

	[Range(-180f, 180f)]
	[Token(Token = "0x4005A7B")]
	[FieldOffset(Offset = "0xE0")]
	public float m_Anim_OvershootSineOffset;

	[Token(Token = "0x4005A7C")]
	[FieldOffset(Offset = "0xE4")]
	public Vector2 m_Anim_OvershootDistances;

	[Range(0f, 2f)]
	[Token(Token = "0x4005A7D")]
	[FieldOffset(Offset = "0xEC")]
	public float m_Anim_FootOffset;

	[Range(0f, 5f)]
	[Token(Token = "0x4005A7E")]
	[FieldOffset(Offset = "0xF0")]
	public float m_Anim_ClimbUpLookaheadDistance;

	[Range(0f, 5f)]
	[Token(Token = "0x4005A7F")]
	[FieldOffset(Offset = "0xF4")]
	public float m_Anim_TopStepToSideDistance;

	[Header("Anim Springs")]
	[Token(Token = "0x4005A80")]
	[FieldOffset(Offset = "0xF8")]
	public Vector3 m_Anim_HeadPosSpringStiffness;

	[Token(Token = "0x4005A81")]
	[FieldOffset(Offset = "0x104")]
	public Vector3 m_Anim_HeadPosSpringDampening;

	[Range(0f, 200f)]
	[Token(Token = "0x4005A82")]
	[FieldOffset(Offset = "0x110")]
	public float m_Anim_PitchSpringStiffness;

	[Range(0f, 50f)]
	[Token(Token = "0x4005A83")]
	[FieldOffset(Offset = "0x114")]
	public float m_Anim_PitchSpringDampening;

	[Range(0f, 200f)]
	[Token(Token = "0x4005A84")]
	[FieldOffset(Offset = "0x118")]
	public float m_Anim_RollSpringStiffness;

	[Range(0f, 50f)]
	[Token(Token = "0x4005A85")]
	[FieldOffset(Offset = "0x11C")]
	public float m_Anim_RollSpringDampening;

	[Header("Audio")]
	[Token(Token = "0x4005A86")]
	[FieldOffset(Offset = "0x120")]
	public string m_Audio_GetOn;

	[Token(Token = "0x4005A87")]
	[FieldOffset(Offset = "0x128")]
	public string m_Audio_GetOff;

	[Token(Token = "0x4005A88")]
	[FieldOffset(Offset = "0x130")]
	public string m_Audio_AboutToSlip;

	[Token(Token = "0x4005A89")]
	[FieldOffset(Offset = "0x138")]
	public string m_Audio_FallStart;

	[Token(Token = "0x4005A8A")]
	[FieldOffset(Offset = "0x140")]
	public string m_Audio_FallStop;

	[Token(Token = "0x4005A8B")]
	[FieldOffset(Offset = "0x148")]
	public string m_Audio_SlipStart;

	[Token(Token = "0x4005A8C")]
	[FieldOffset(Offset = "0x150")]
	public string m_Audio_SlipStop;

	[Token(Token = "0x4005A8D")]
	[FieldOffset(Offset = "0x158")]
	public string m_Audio_AboutToSlip_VO;

	[Token(Token = "0x4005A8E")]
	[FieldOffset(Offset = "0x160")]
	public string m_Audio_FallStart_VO;

	[Token(Token = "0x4005A8F")]
	[FieldOffset(Offset = "0x168")]
	public string m_Audio_FallStop_VO;

	[Token(Token = "0x4005A90")]
	[FieldOffset(Offset = "0x170")]
	public string m_Audio_SlipStart_VO;

	[Token(Token = "0x4005A91")]
	[FieldOffset(Offset = "0x178")]
	public string m_Audio_SlipStop_VO;

	[Token(Token = "0x4005A92")]
	[FieldOffset(Offset = "0x180")]
	public string m_Audio_ClimbExertion_VO;

	[Token(Token = "0x4005A93")]
	[FieldOffset(Offset = "0x188")]
	public string m_Audio_RopeSnap;

	[HideInInspector]
	[Token(Token = "0x4005A94")]
	[FieldOffset(Offset = "0x190")]
	public bool m_BlockCameraPitch;

	[HideInInspector]
	[Token(Token = "0x4005A95")]
	[FieldOffset(Offset = "0x191")]
	public bool m_BlockCameraYaw;

	[HideInInspector]
	[Token(Token = "0x4005A96")]
	[FieldOffset(Offset = "0x192")]
	public bool m_IsFalling;

	[Token(Token = "0x4005A97")]
	[FieldOffset(Offset = "0x198")]
	private Rope m_Rope;

	[Token(Token = "0x4005A98")]
	[FieldOffset(Offset = "0x1A0")]
	private float m_ClimbSpeed;

	[Token(Token = "0x4005A99")]
	[FieldOffset(Offset = "0x1A4")]
	private float m_CurrentSplineParameter;

	[Token(Token = "0x4005A9A")]
	[FieldOffset(Offset = "0x1A8")]
	private ClimbingState m_ClimbingState;

	[Token(Token = "0x4005A9B")]
	[FieldOffset(Offset = "0x1AC")]
	private bool m_FallWillRecover;

	[Token(Token = "0x4005A9C")]
	[FieldOffset(Offset = "0x1B0")]
	private float m_FallHeight;

	[Token(Token = "0x4005A9D")]
	[FieldOffset(Offset = "0x1B4")]
	private float m_SpeedScaleByStamina;

	[Token(Token = "0x4005A9E")]
	[FieldOffset(Offset = "0x1B8")]
	private Vector2 m_StartPitchLimit;

	[Token(Token = "0x4005A9F")]
	[FieldOffset(Offset = "0x1C0")]
	private Vector2 m_StartYawLimit;

	[Token(Token = "0x4005AA0")]
	[FieldOffset(Offset = "0x1C8")]
	private float m_GroundOffset;

	[Token(Token = "0x4005AA1")]
	[FieldOffset(Offset = "0x1CC")]
	private float m_MinSplineTAtTop;

	[Token(Token = "0x4005AA2")]
	[FieldOffset(Offset = "0x1D0")]
	private float m_MaxSplineTAtBottom;

	[Token(Token = "0x4005AA3")]
	[FieldOffset(Offset = "0x1D4")]
	private int m_FindGroundCollisionLayer;

	[Token(Token = "0x4005AA4")]
	[FieldOffset(Offset = "0x1D8")]
	private float m_SplineTBeforeEdge;

	[Token(Token = "0x4005AA5")]
	[FieldOffset(Offset = "0x1DC")]
	private float m_Anim_Phase;

	[Token(Token = "0x4005AA6")]
	[FieldOffset(Offset = "0x1E0")]
	private float m_Anim_Direction;

	[Token(Token = "0x4005AA7")]
	[FieldOffset(Offset = "0x1E4")]
	private Vector3 m_Anim_SplineNormal;

	[Token(Token = "0x4005AA8")]
	[FieldOffset(Offset = "0x1F0")]
	private Vector3 m_Anim_SplineLat;

	[Token(Token = "0x4005AA9")]
	[FieldOffset(Offset = "0x1FC")]
	private float m_Anim_RequestSlip;

	[Token(Token = "0x4005AAA")]
	[FieldOffset(Offset = "0x200")]
	private float m_Anim_SlipTargetT;

	[Token(Token = "0x4005AAB")]
	[FieldOffset(Offset = "0x204")]
	private float m_Anim_SlipBaseT;

	[Token(Token = "0x4005AAC")]
	[FieldOffset(Offset = "0x208")]
	private float m_Anim_SlipTimer;

	[Token(Token = "0x4005AAD")]
	[FieldOffset(Offset = "0x210")]
	private Vector3[] m_Anim_SlipStageParams;

	[Token(Token = "0x4005AAE")]
	[FieldOffset(Offset = "0x218")]
	private int m_Anim_SlipStageIndex;

	[Token(Token = "0x4005AAF")]
	[FieldOffset(Offset = "0x21C")]
	private float m_Anim_SlipScalar;

	[Token(Token = "0x4005AB0")]
	[FieldOffset(Offset = "0x220")]
	private float m_Anim_LastSlipPitch;

	[Token(Token = "0x4005AB1")]
	[FieldOffset(Offset = "0x224")]
	private float m_Anim_LastSlipRoll;

	[Token(Token = "0x4005AB2")]
	[FieldOffset(Offset = "0x228")]
	private float m_Anim_LastSlipSwayOffset;

	[Token(Token = "0x4005AB3")]
	[FieldOffset(Offset = "0x22C")]
	private Vector3 m_Anim_FallRestPos;

	[Token(Token = "0x4005AB4")]
	[FieldOffset(Offset = "0x238")]
	private float m_Anim_CameraPitch;

	[Token(Token = "0x4005AB5")]
	[FieldOffset(Offset = "0x23C")]
	private float m_Anim_CameraRoll;

	[Token(Token = "0x4005AB6")]
	private const float ROPE_TOP_T = 0.2f;

	[Token(Token = "0x4005AB7")]
	private const float ROPE_BASE_T = 0.6f;

	[Token(Token = "0x4005AB8")]
	[FieldOffset(Offset = "0x240")]
	private float m_NoStaminaTimerSeconds;

	[Token(Token = "0x4005AB9")]
	[FieldOffset(Offset = "0x244")]
	private float m_NextSlipRollSeconds;

	[Token(Token = "0x4005ABA")]
	[FieldOffset(Offset = "0x248")]
	private float m_NextSlipChance;

	[Token(Token = "0x4005ABB")]
	[FieldOffset(Offset = "0x24C")]
	private float m_NextFallChance;

	[Token(Token = "0x4005ABC")]
	[FieldOffset(Offset = "0x250")]
	private Transform m_RopePhysicsHelper;

	[Token(Token = "0x4005ABD")]
	[FieldOffset(Offset = "0x258")]
	private Transform m_RopePhysicsHelper_Head;

	[Token(Token = "0x4005ABE")]
	[FieldOffset(Offset = "0x260")]
	private bool m_ForceBlendedValues;

	[Token(Token = "0x4005ABF")]
	[FieldOffset(Offset = "0x268")]
	private Spring3 m_HeadSpring;

	[Token(Token = "0x4005AC0")]
	[FieldOffset(Offset = "0x270")]
	private Spring m_PitchSpring;

	[Token(Token = "0x4005AC1")]
	[FieldOffset(Offset = "0x278")]
	private Spring m_RollSpring;

	[Token(Token = "0x4005AC2")]
	[FieldOffset(Offset = "0x280")]
	private uint m_SlipAudioId;

	[Token(Token = "0x4005AC3")]
	[FieldOffset(Offset = "0x284")]
	private uint m_SlipVOId;

	[Token(Token = "0x4005AC4")]
	[FieldOffset(Offset = "0x288")]
	private uint m_FallAudioId;

	[Token(Token = "0x4005AC5")]
	[FieldOffset(Offset = "0x28C")]
	private uint m_FallVOId;

	[Token(Token = "0x4005AC6")]
	[FieldOffset(Offset = "0x290")]
	private bool m_HasPlayedSnapAudio;

	[Token(Token = "0x4005AC7")]
	[FieldOffset(Offset = "0x298")]
	private OnOffTransitionInfo m_OnOffTransition;

	[Token(Token = "0x4005AC8")]
	[FieldOffset(Offset = "0x2A0")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4005AC9")]
	private static PlayerClimbRopeProxy m_PlayerClimbRopeProxy;

	[Token(Token = "0x4005ACA")]
	private const int NUM_SLIP_STAGES = 4;

	[Token(Token = "0x4005ACB")]
	private const int NUM_FALL_STAGES = 6;

	[Token(Token = "0x17000363")]
	public bool IsSlipping
	{
		[Token(Token = "0x6004FF6")]
		[Address(RVA = "0xDD99B0", Offset = "0xDD87B0", Length = "0x18")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6004FE6")]
	[Address(RVA = "0xDD4740", Offset = "0xDD3540", Length = "0x1B")]
	private void Start()
	{
	}

	[Token(Token = "0x6004FE7")]
	[Address(RVA = "0xDD4760", Offset = "0xDD3560", Length = "0x468")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004FE8")]
	[Address(RVA = "0xDD4BD0", Offset = "0xDD39D0", Length = "0x1B7")]
	public void Deserialize(string text)
	{
	}

	[IteratorStateMachine(typeof(_003CPutPlayerOnRopeAfterDeserialize_003Ed__125))]
	[Token(Token = "0x6004FE9")]
	[Address(RVA = "0xDD4D90", Offset = "0xDD3B90", Length = "0xF7")]
	private IEnumerator PutPlayerOnRopeAfterDeserialize(PlayerClimbRopeProxy saveProxy)
	{
		return null;
	}

	[Token(Token = "0x6004FEA")]
	[Address(RVA = "0xDD4E90", Offset = "0xDD3C90", Length = "0x2E1")]
	public void UpdateClimbing()
	{
	}

	[Token(Token = "0x6004FEB")]
	[Address(RVA = "0xDD5180", Offset = "0xDD3F80", Length = "0x1E94")]
	public void BeginClimbing(Rope r, float initialSplineT = -1f)
	{
	}

	[Token(Token = "0x6004FEC")]
	[Address(RVA = "0xDD7020", Offset = "0xDD5E20", Length = "0x638")]
	private float FindLowestValidTOnSpline()
	{
		return 0f;
	}

	[Token(Token = "0x6004FED")]
	[Address(RVA = "0xDD7660", Offset = "0xDD6460", Length = "0xAA")]
	private void RefreshSpringSettings()
	{
	}

	[Token(Token = "0x6004FEE")]
	[Address(RVA = "0xDD7710", Offset = "0xDD6510", Length = "0x8B5")]
	public void RequestExitToPoint(Rope r, RopeExitPoint rep)
	{
	}

	[Token(Token = "0x6004FEF")]
	[Address(RVA = "0xDD7FD0", Offset = "0xDD6DD0", Length = "0xAC1")]
	public void RequestExitTopOrBottom(Transform camT)
	{
	}

	[Token(Token = "0x6004FF0")]
	[Address(RVA = "0xDD8AA0", Offset = "0xDD78A0", Length = "0x8FC")]
	public void RequestExitAfterFall(Transform camT)
	{
	}

	[Token(Token = "0x6004FF1")]
	[Address(RVA = "0xDD93A0", Offset = "0xDD81A0", Length = "0x1E8")]
	public void EndClimbing(Vector3 endPos, Quaternion endRot)
	{
	}

	[Token(Token = "0x6004FF2")]
	[Address(RVA = "0xDD9590", Offset = "0xDD8390", Length = "0xC")]
	public bool IsInOnOffTransition()
	{
		return false;
	}

	[Token(Token = "0x6004FF3")]
	[Address(RVA = "0xDD95A0", Offset = "0xDD83A0", Length = "0x18")]
	public bool FallingWithoutRecovery()
	{
		return false;
	}

	[Token(Token = "0x6004FF4")]
	[Address(RVA = "0xDD95C0", Offset = "0xDD83C0", Length = "0x32F")]
	private void OnRopeTransition(bool onRope)
	{
	}

	[Token(Token = "0x6004FF5")]
	[Address(RVA = "0xDD98F0", Offset = "0xDD86F0", Length = "0xB5")]
	private void SetClimbingState()
	{
	}

	[Token(Token = "0x6004FF7")]
	[Address(RVA = "0xDD99D0", Offset = "0xDD87D0", Length = "0x145F")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x6004FF8")]
	[Address(RVA = "0xDDAE30", Offset = "0xDD9C30", Length = "0x1F8")]
	private Vector3 GetSlipStageParams(int i, float baseT, float limitT, float scalar, float splineLen)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6004FF9")]
	[Address(RVA = "0xDDB040", Offset = "0xDD9E40", Length = "0xFD8")]
	private void HandleSlipStage(out float swayOffset, out float pitchOffset, out float rollOffset)
	{
		swayOffset = default(float);
		pitchOffset = default(float);
		rollOffset = default(float);
	}

	[Token(Token = "0x6004FFA")]
	[Address(RVA = "0xDDC030", Offset = "0xDDAE30", Length = "0x6E")]
	private void StopSounds(ref uint voId, ref uint soundId)
	{
	}

	[Token(Token = "0x6004FFB")]
	[Address(RVA = "0xDDC0A0", Offset = "0xDDAEA0", Length = "0x93")]
	private void EndSlipHandling()
	{
	}

	[Token(Token = "0x6004FFC")]
	[Address(RVA = "0xDDC140", Offset = "0xDDAF40", Length = "0x2D")]
	private ClimbingState GetClimbingState()
	{
		return default(ClimbingState);
	}

	[Token(Token = "0x6004FFD")]
	[Address(RVA = "0xDDC170", Offset = "0xDDAF70", Length = "0x613")]
	private bool GetAdjustedViewAngles(ref Vector2 viewAngles, out float rollScalar)
	{
		rollScalar = default(float);
		return false;
	}

	[Token(Token = "0x6004FFE")]
	[Address(RVA = "0xDDC790", Offset = "0xDDB590", Length = "0x127C")]
	private Vector3 GetPositionOnRope(bool allowMotion, out Vector3 splinePos, out Vector3 splineTan, out Vector3 splineNorm, out Vector3 splineLat, out float splinePitch, out float splineRoll)
	{
		splinePos = default(Vector3);
		splineTan = default(Vector3);
		splineNorm = default(Vector3);
		splineLat = default(Vector3);
		splinePitch = default(float);
		splineRoll = default(float);
		return default(Vector3);
	}

	[Token(Token = "0x6004FFF")]
	[Address(RVA = "0xDDDA10", Offset = "0xDDC810", Length = "0x2B7")]
	private void MaybePlaceFootstep(float oldPhase, float newPhase, float splineT, Vector3 splinePos)
	{
	}

	[Token(Token = "0x6005000")]
	[Address(RVA = "0xDDDCD0", Offset = "0xDDCAD0", Length = "0x237")]
	private void UpdateStamina()
	{
	}

	[Token(Token = "0x6005001")]
	[Address(RVA = "0xDDDF10", Offset = "0xDDCD10", Length = "0x19E")]
	private void UpdateFatigue()
	{
	}

	[Token(Token = "0x6005002")]
	[Address(RVA = "0xDDE0B0", Offset = "0xDDCEB0", Length = "0xF7")]
	private void SetClimbSpeed()
	{
	}

	[Token(Token = "0x6005003")]
	[Address(RVA = "0xDDE1B0", Offset = "0xDDCFB0", Length = "0x179")]
	private void MaybeFallDueToRopeBreak()
	{
	}

	[Token(Token = "0x6005004")]
	[Address(RVA = "0xDDE330", Offset = "0xDDD130", Length = "0x2EF")]
	private void MaybeSlipOrFall()
	{
	}

	[Token(Token = "0x6005005")]
	[Address(RVA = "0xDDE620", Offset = "0xDDD420", Length = "0xB")]
	private void RequestFall()
	{
	}

	[Token(Token = "0x6005006")]
	[Address(RVA = "0x73EB40", Offset = "0x73D940", Length = "0x9")]
	private void RequestSlip(float slipDistance)
	{
	}

	[Token(Token = "0x6005007")]
	[Address(RVA = "0xDDE630", Offset = "0xDDD430", Length = "0x566")]
	private void SlipBegin(float slipDistance)
	{
	}

	[Token(Token = "0x6005008")]
	[Address(RVA = "0xDDEBA0", Offset = "0xDDD9A0", Length = "0x1C9")]
	private void EnablePhysicsHelper(bool isFalling)
	{
	}

	[Token(Token = "0x6005009")]
	[Address(RVA = "0xDDED70", Offset = "0xDDDB70", Length = "0x4D")]
	public PlayerClimbRope()
	{
	}
}
