using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using SuperSplines;
using UnityEngine;

[RequireComponent(typeof(SpotlightAimer))]
[Token(Token = "0x2000445")]
public class SpotLightController : MonoBehaviour
{
	[Token(Token = "0x2000446")]
	private enum DetectionStageState
	{
		[Token(Token = "0x40026A1")]
		Stage0,
		[Token(Token = "0x40026A2")]
		Stage1,
		[Token(Token = "0x40026A3")]
		Stage2,
		[Token(Token = "0x40026A4")]
		Stage3,
		[Token(Token = "0x40026A5")]
		Stage4,
		[Token(Token = "0x40026A6")]
		StageDead
	}

	[Token(Token = "0x400265D")]
	[FieldOffset(Offset = "0x20")]
	public SpotlightAimer m_Aimer;

	[Token(Token = "0x400265E")]
	[FieldOffset(Offset = "0x28")]
	public Transform m_SpotLight;

	[Header("Target Path Controller")]
	[Tooltip("Each spotlight needs its own spline path to follow")]
	[Token(Token = "0x400265F")]
	[FieldOffset(Offset = "0x30")]
	public Spline m_PathSpline;

	[Range(1f, 1000f)]
	[Token(Token = "0x4002660")]
	[FieldOffset(Offset = "0x38")]
	public float m_PathPeriodSeconds;

	[Range(0f, 100f)]
	[Token(Token = "0x4002661")]
	[FieldOffset(Offset = "0x3C")]
	public float m_PathOffsetPercent;

	[Token(Token = "0x4002662")]
	[FieldOffset(Offset = "0x40")]
	public bool m_StartReversed;

	[Tooltip("How far is the spotlight to the player")]
	[Range(0f, 30f)]
	[Token(Token = "0x4002663")]
	[FieldOffset(Offset = "0x44")]
	public float m_DetectionDistance;

	[Header("Detection Stage Settings")]
	[Tooltip("How long before switching to Stage1")]
	[Range(0f, 90f)]
	[Token(Token = "0x4002664")]
	[FieldOffset(Offset = "0x48")]
	public float m_DetectionTimer_Stage0;

	[Tooltip("How long before switching to Stage2")]
	[Range(0f, 90f)]
	[Token(Token = "0x4002665")]
	[FieldOffset(Offset = "0x4C")]
	public float m_DetectionTimer_Stage1;

	[Tooltip("How long before switching to Stage3")]
	[Range(0f, 90f)]
	[Token(Token = "0x4002666")]
	[FieldOffset(Offset = "0x50")]
	public float m_DetectionTimer_Stage2;

	[Tooltip("How long before switching to Stage4")]
	[Range(0f, 90f)]
	[Token(Token = "0x4002667")]
	[FieldOffset(Offset = "0x54")]
	public float m_DetectionTimer_Stage3;

	[Tooltip("After detection and spotlight reset, do not react to player")]
	[Range(0f, 90f)]
	[Token(Token = "0x4002668")]
	[FieldOffset(Offset = "0x58")]
	public float m_ResetDetectionTimer;

	[Token(Token = "0x4002669")]
	[FieldOffset(Offset = "0x60")]
	public string m_Sound_EnterStage0;

	[Token(Token = "0x400266A")]
	[FieldOffset(Offset = "0x68")]
	public string m_Sound_EnterStage1;

	[Token(Token = "0x400266B")]
	[FieldOffset(Offset = "0x70")]
	public string m_Sound_EnterStage2;

	[Token(Token = "0x400266C")]
	[FieldOffset(Offset = "0x78")]
	public string m_Sound_EnterStage3;

	[Token(Token = "0x400266D")]
	[FieldOffset(Offset = "0x80")]
	public string m_Sound_EnterStage4;

	[Header("Voice")]
	[Token(Token = "0x400266E")]
	[FieldOffset(Offset = "0x88")]
	public NPCVoice m_Voice;

	[Token(Token = "0x400266F")]
	[FieldOffset(Offset = "0x90")]
	public string m_VO_OnDetection;

	[Token(Token = "0x4002670")]
	[FieldOffset(Offset = "0x98")]
	public string m_VO_FirstSearch;

	[Token(Token = "0x4002671")]
	[FieldOffset(Offset = "0xA0")]
	public string m_VO_SubsequentSearch;

	[Token(Token = "0x4002672")]
	[FieldOffset(Offset = "0xA8")]
	public float m_VO_PlaySearchMinTime;

	[Token(Token = "0x4002673")]
	[FieldOffset(Offset = "0xAC")]
	public float m_VO_PlaySearchMaxTime;

	[Token(Token = "0x4002674")]
	[FieldOffset(Offset = "0xB0")]
	public float m_VO_TriggerRange;

	[Token(Token = "0x4002675")]
	[FieldOffset(Offset = "0xB8")]
	public string m_RifleFireSound;

	[Range(0f, 30f)]
	[Token(Token = "0x4002676")]
	[FieldOffset(Offset = "0xC0")]
	public float m_Stage2BulletDistanceMin;

	[Range(0f, 30f)]
	[Token(Token = "0x4002677")]
	[FieldOffset(Offset = "0xC4")]
	public float m_Stage2BulletDistanceMax;

	[Range(0f, 30f)]
	[Token(Token = "0x4002678")]
	[FieldOffset(Offset = "0xC8")]
	public float m_Stage2BulletSideDistance;

	[Range(0f, 5f)]
	[Token(Token = "0x4002679")]
	[FieldOffset(Offset = "0xCC")]
	public int m_Stage2ShotsMin;

	[Range(0f, 5f)]
	[Token(Token = "0x400267A")]
	[FieldOffset(Offset = "0xD0")]
	public int m_Stage2ShotsMax;

	[Range(0f, 90f)]
	[Token(Token = "0x400267B")]
	[FieldOffset(Offset = "0xD4")]
	public float m_Stage2BulletShotDelayTimer;

	[Token(Token = "0x400267C")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject m_Stage2BulletImpactFX;

	[Range(0f, 90f)]
	[Token(Token = "0x400267D")]
	[FieldOffset(Offset = "0xE0")]
	public float m_Stage2BulletFirstShotDelayTimer;

	[Range(0f, 90f)]
	[Token(Token = "0x400267E")]
	[FieldOffset(Offset = "0xE4")]
	public float m_Stage2BulletShotMinTimer;

	[Range(0f, 90f)]
	[Token(Token = "0x400267F")]
	[FieldOffset(Offset = "0xE8")]
	public float m_Stage2BulletShotMaxTimer;

	[Token(Token = "0x4002680")]
	[FieldOffset(Offset = "0xEC")]
	public bool m_Stage3AllowMultipleShots;

	[Range(0f, 1000f)]
	[Token(Token = "0x4002681")]
	[FieldOffset(Offset = "0xF0")]
	public float m_Stage3BulletDamage;

	[Token(Token = "0x4002682")]
	[FieldOffset(Offset = "0xF8")]
	public LocalizedString m_Stage3BloodLossFromBullet;

	[Range(0f, 90f)]
	[Token(Token = "0x4002683")]
	[FieldOffset(Offset = "0x100")]
	public float m_Stage3BulletShotMinTimer;

	[Range(0f, 90f)]
	[Token(Token = "0x4002684")]
	[FieldOffset(Offset = "0x104")]
	public float m_Stage3BulletShotMaxTimer;

	[Range(0f, 90f)]
	[Token(Token = "0x4002685")]
	[FieldOffset(Offset = "0x108")]
	public float m_Stage4BulletSoundThreshold;

	[Token(Token = "0x4002686")]
	[FieldOffset(Offset = "0x110")]
	public LocalizedString m_FailureMessage;

	[Header("Return To Normal Settings")]
	[Tooltip("After detecting the player, how long does it take before the spotlight starts to return to its normal movement path")]
	[Range(0f, 90f)]
	[Token(Token = "0x4002687")]
	[FieldOffset(Offset = "0x118")]
	public float m_NoDetectionTimer;

	[Tooltip("After detecting the player, how fast does the spotlight move back to its normal path")]
	[Range(0.001f, 100f)]
	[Token(Token = "0x4002688")]
	[FieldOffset(Offset = "0x11C")]
	public float m_BlendBackTimeSeconds;

	[Header("Tracking Player Settings")]
	[Tooltip("If the player is moving faster than this, the spotlight will not track")]
	[Range(0f, 50f)]
	[Token(Token = "0x4002689")]
	[FieldOffset(Offset = "0x120")]
	public float m_MaxTrackingSpeed;

	[Tooltip("How much time does it take the spotlight to keep up to player movement")]
	[Range(0f, 30f)]
	[Token(Token = "0x400268A")]
	[FieldOffset(Offset = "0x124")]
	public float m_TrackingBlendTimeSeconds;

	[Tooltip("Keep the spotlight within the Max Path Distance along the path defined by these points")]
	[Token(Token = "0x400268B")]
	[FieldOffset(Offset = "0x128")]
	public List<Transform> m_PathConstraintPoints;

	[Tooltip("Keep the spotlight within this distance along the path defined by Path Constraint Points")]
	[Range(0f, 30f)]
	[Token(Token = "0x400268C")]
	[FieldOffset(Offset = "0x130")]
	public float m_MaxPathDistance;

	[Tooltip("Linked spotlights stop when any one detects the player")]
	[Token(Token = "0x400268D")]
	[FieldOffset(Offset = "0x138")]
	public List<SpotLightController> m_LinkedSpotlights;

	[Tooltip("If the player has already been detected previously, jump immediately to stage 2")]
	[Token(Token = "0x400268E")]
	[FieldOffset(Offset = "0x140")]
	public bool m_RedetectionJumpToStage3;

	[Token(Token = "0x400268F")]
	[FieldOffset(Offset = "0x144")]
	private Vector3 m_MovingTargetPosition;

	[Token(Token = "0x4002690")]
	[FieldOffset(Offset = "0x150")]
	private float m_CurrentMoveBlend;

	[Token(Token = "0x4002691")]
	[FieldOffset(Offset = "0x154")]
	private float m_CurrentTrackBlend;

	[Token(Token = "0x4002692")]
	[FieldOffset(Offset = "0x158")]
	private float m_StageTime;

	[Token(Token = "0x4002693")]
	[FieldOffset(Offset = "0x15C")]
	private float m_ReturnTime;

	[Token(Token = "0x4002694")]
	[FieldOffset(Offset = "0x160")]
	private float m_ResetDetectionTime;

	[Token(Token = "0x4002695")]
	[FieldOffset(Offset = "0x164")]
	private float m_BulletShotTime;

	[Token(Token = "0x4002696")]
	[FieldOffset(Offset = "0x168")]
	private float m_MasterTimer;

	[Token(Token = "0x4002697")]
	[FieldOffset(Offset = "0x16C")]
	private bool m_IsDetected;

	[Token(Token = "0x4002698")]
	[FieldOffset(Offset = "0x16D")]
	private bool m_WasEverDetected;

	[Token(Token = "0x4002699")]
	[FieldOffset(Offset = "0x170")]
	private float m_PlayLostSightSoundTimer;

	[Token(Token = "0x400269A")]
	[FieldOffset(Offset = "0x174")]
	private int m_ShotCounter;

	[Token(Token = "0x400269B")]
	private static List<GameObject> s_BulletImpactList;

	[Token(Token = "0x400269C")]
	private static int s_BulletImpactIndex;

	[Token(Token = "0x400269D")]
	private static int s_MaxBulletImpactFX;

	[Token(Token = "0x400269E")]
	public static bool s_Debug;

	[Token(Token = "0x400269F")]
	[FieldOffset(Offset = "0x178")]
	private DetectionStageState m_CurrentDetectionStage;

	[Token(Token = "0x6002016")]
	[Address(RVA = "0x7EAF20", Offset = "0x7E9D20", Length = "0x203")]
	private void Start()
	{
	}

	[Token(Token = "0x6002017")]
	[Address(RVA = "0x7EB130", Offset = "0x7E9F30", Length = "0x271")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002018")]
	[Address(RVA = "0x7EB3B0", Offset = "0x7EA1B0", Length = "0x16")]
	private void SetDetectionStage(DetectionStageState newStage)
	{
	}

	[Token(Token = "0x6002019")]
	[Address(RVA = "0x7EB3D0", Offset = "0x7EA1D0", Length = "0xB1")]
	private void PlayEnterStageSound()
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x600201A")]
	[Address(RVA = "0x7EB490", Offset = "0x7EA290", Length = "0x2F3")]
	private void DRAW_TEMP_SPHERE_INDICATOR(Vector3 position)
	{
	}

	[Token(Token = "0x600201B")]
	[Address(RVA = "0x7EB790", Offset = "0x7EA590", Length = "0xA51")]
	private void MaybeRandomBulletShots()
	{
	}

	[Token(Token = "0x600201C")]
	[Address(RVA = "0x7EC1F0", Offset = "0x7EAFF0", Length = "0x212")]
	private void MaybeBulletDamage()
	{
	}

	[Token(Token = "0x600201D")]
	[Address(RVA = "0x7EC410", Offset = "0x7EB210", Length = "0x6A")]
	private void MissionFailure()
	{
	}

	[Token(Token = "0x600201E")]
	[Address(RVA = "0x7EC480", Offset = "0x7EB280", Length = "0x3AF")]
	private void UpdateDetectionStage()
	{
	}

	[Token(Token = "0x600201F")]
	[Address(RVA = "0x7EC830", Offset = "0x7EB630", Length = "0x1E")]
	private bool WasDetected()
	{
		return false;
	}

	[Token(Token = "0x6002020")]
	[Address(RVA = "0x7EC850", Offset = "0x7EB650", Length = "0x1E5")]
	private void UpdateSpotLight()
	{
	}

	[Token(Token = "0x6002021")]
	[Address(RVA = "0x7ECA40", Offset = "0x7EB840", Length = "0xD7F")]
	private bool IsWithinPathConstraints()
	{
		return false;
	}

	[Token(Token = "0x6002022")]
	[Address(RVA = "0x7ED7C0", Offset = "0x7EC5C0", Length = "0x316")]
	private void MaybeTrackPlayer()
	{
	}

	[Token(Token = "0x6002023")]
	[Address(RVA = "0x7EDAE0", Offset = "0x7EC8E0", Length = "0x1B7")]
	private void UpdateTarget()
	{
	}

	[Token(Token = "0x6002024")]
	[Address(RVA = "0x7EDCA0", Offset = "0x7ECAA0", Length = "0x1B0")]
	private bool IsPlayerInLight()
	{
		return false;
	}

	[Token(Token = "0x6002025")]
	[Address(RVA = "0x7EDE60", Offset = "0x7ECC60", Length = "0x16F")]
	private bool IsPlayerInLinkedSpotlight()
	{
		return false;
	}

	[Token(Token = "0x6002026")]
	[Address(RVA = "0x7EDFD0", Offset = "0x7ECDD0", Length = "0x77")]
	private void MaybePlaySound(string soundName)
	{
	}

	[Token(Token = "0x6002027")]
	[Address(RVA = "0x7EE050", Offset = "0x7ECE50", Length = "0x15F")]
	private void MaybePlayVO(string voName)
	{
	}

	[Token(Token = "0x6002028")]
	[Address(RVA = "0x7EE1B0", Offset = "0x7ECFB0", Length = "0x4BE")]
	private void Update()
	{
	}

	[Token(Token = "0x6002029")]
	[Address(RVA = "0x7EE670", Offset = "0x7ED470", Length = "0x2EE")]
	private void MaybePlaySearchSound()
	{
	}

	[Token(Token = "0x600202A")]
	[Address(RVA = "0x7EE960", Offset = "0x7ED760", Length = "0x1B3")]
	public SpotLightController()
	{
	}
}
