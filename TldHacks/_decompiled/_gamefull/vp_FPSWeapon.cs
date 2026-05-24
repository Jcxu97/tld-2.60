using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000014")]
public class vp_FPSWeapon : vp_Component
{
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x48")]
	protected CharacterController Controller;

	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x50")]
	public float RenderingZoomDamping;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x54")]
	private bool m_StartCalled;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x58")]
	protected float m_FinalZoomTime;

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x5C")]
	public float RenderingFieldOfView;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x60")]
	public FPSMeshID m_FPSMeshId;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x64")]
	private float m_UnzoomedFieldOfView;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x68")]
	private float m_ZoomedFieldOfView;

	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x6C")]
	private float m_Accumulator;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x70")]
	public Vector2 RenderingClippingPlanes;

	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 PositionOffset;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x84")]
	public float PositionSpringStiffness;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x88")]
	public float PositionSpringDamping;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x8C")]
	public float PositionKneeling;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x90")]
	public float PositionFallRetract;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x94")]
	public float PositionFallYCancel;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x98")]
	public float PositionPivotSpringStiffness;

	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x9C")]
	public float PositionPivotSpringDamping;

	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0xA0")]
	public float PositionSpring2Stiffness;

	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0xA4")]
	public float PositionSpring2Damping;

	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0xA8")]
	public Vector3 PositionWalkSlide;

	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0xB4")]
	public Vector3 PositionPivot;

	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0xC0")]
	public float PositionInputVelocityScale;

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0xC4")]
	public float PositionMaxInputVelocity;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0xC8")]
	protected vp_Spring m_PositionSpring;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0xD0")]
	protected vp_Spring m_PositionSpring2;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0xD8")]
	protected vp_Spring m_PositionPivotSpring;

	[SerializeField]
	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0xE0")]
	protected GameObject m_WeaponCamera;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0xE8")]
	protected GameObject m_WeaponGroup;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0xF0")]
	protected GameObject m_Pivot;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0xF8")]
	public Vector3 RotationOffset;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x104")]
	public float RotationSpringStiffness;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x108")]
	public float RotationSpringDamping;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x10C")]
	public float RotationSpring2Stiffness;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x110")]
	public float RotationSpring2Damping;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x114")]
	public Vector3 RotationLookSway;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x120")]
	public Vector3 RotationStrafeSway;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x12C")]
	public Vector3 RotationFallSway;

	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x138")]
	public float RotationSlopeSway;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x13C")]
	public float RotationInputVelocityScale;

	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x140")]
	public float RotationMaxInputVelocity;

	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x148")]
	protected vp_Spring m_RotationSpring;

	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x150")]
	protected vp_Spring m_RotationSpring2;

	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x158")]
	public float ShakeSpeed;

	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x15C")]
	public Vector3 ShakeAmplitude;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x168")]
	protected Vector3 m_Shake;

	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x174")]
	public Vector4 BobRate;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x184")]
	public Vector4 BobAmplitude;

	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x194")]
	public float BobInputVelocityScale;

	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x198")]
	public float BobMaxInputVelocity;

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x19C")]
	protected float m_LastBobSpeed;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x1A0")]
	public float SwayStartFatigue;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x1A4")]
	public float SwayMaxFatigue;

	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x1A8")]
	public float SwayMotionSpeed;

	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x1AC")]
	public Vector3 SwayLimits;

	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x1B8")]
	public float SwayCrouchScalar;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x1BC")]
	public Vector3 PositionExitOffset;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x1C8")]
	public Vector3 RotationExitOffset;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x1D8")]
	private GameObject m_FXGameObject;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x1E0")]
	private Light m_LightIndoor;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x1E8")]
	private Light m_LightOutdoor;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x1F0")]
	private Camera m_WeaponCameraComponent;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x1F8")]
	private Animator m_Animator;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x200")]
	private int m_BulletsToReload;

	[HideInInspector]
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x208")]
	public GearItem m_GearItem;

	[HideInInspector]
	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x210")]
	public GunItem m_GunItem;

	[HideInInspector]
	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x218")]
	public BowItem m_BowItem;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x220")]
	public FirstPersonWeapon m_FirstPersonWeaponRightHand;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x228")]
	public FirstPersonWeapon m_FirstPersonWeaponLeftHand;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x230")]
	public FirstPersonWeapon m_FirstPersonWeaponShoulder;

	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x238")]
	public GameObject m_FirstPersonWeaponRightHandPrefab;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x240")]
	public GameObject m_FirstPersonWeaponLeftHandPrefab;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x248")]
	public GameObject m_FirstPersonWeaponShoulderPrefab;

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x250")]
	public bool m_UseFirstPersonHands;

	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x254")]
	public float m_AimingMinYawStepDegrees;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x258")]
	public float m_AimingMaxYawStepDegrees;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x25C")]
	public float m_AimingMinYawDegrees;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x260")]
	public float m_AimingMaxYawDegrees;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x264")]
	public float m_BreathingCycleMinPitchDegrees;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x268")]
	public float m_BreathingCycleMaxPitchDegrees;

	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x26C")]
	public float m_KneelingBonusPitch;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x270")]
	public float m_KneelingBonusYaw;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x274")]
	public float m_ColdRandomShakingOscillationSpeed;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x278")]
	public float m_ColrRandomShakingNoiseSpeed;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x27C")]
	public float m_ColdTeethChatterRate;

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x280")]
	public Vector3 m_ColdShakingAngleLimits;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x28C")]
	public float m_ColdShakeAngle;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x290")]
	private float m_CurrentBreathTimePercentAsPitchDegrees;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x294")]
	private float m_CurrentBreathingPercent;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x298")]
	private float m_AimingCurrentYawDegrees;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x29C")]
	public float m_StaminaWeaponDropDegrees;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x2A0")]
	private float m_ShiverTeethChatteringTime;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x2A8")]
	private GameObject m_RightTemporaryParent;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x2B0")]
	private GameObject m_LeftTemporaryParent;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x2B8")]
	private GameObject m_ShoulderTemporaryParent;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x2C0")]
	private GameObject m_MovedChild;

	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x2C8")]
	private GameObject m_NewChild;

	[NonSerialized]
	[Token(Token = "0x40001A7")]
	private static bool m_DisableAimBreathing;

	[NonSerialized]
	[Token(Token = "0x40001A8")]
	private static bool m_DisableAimSway;

	[NonSerialized]
	[Token(Token = "0x40001A9")]
	private static bool m_DisableAimStamina;

	[NonSerialized]
	[Token(Token = "0x40001AA")]
	private static bool m_DisableAimShake;

	[NonSerialized]
	[Token(Token = "0x40001AB")]
	private static bool m_DisableDepthOfField;

	[Token(Token = "0x40001AC")]
	private const string TEMP_RIGHT_PARENT = "Right_Temp_Parent";

	[Token(Token = "0x40001AD")]
	private const string TEMP_LEFT_PARENT = "Left_Temp_Parent";

	[Token(Token = "0x40001AE")]
	private const string TEMP_SHOULDER_PARENT = "Shoulder_Temp_Parent";

	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x2D0")]
	private Vector3 m_RandomShakeAngle;

	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x2E0")]
	private Action<float, float> m_FixedUpdateCallback;

	[Token(Token = "0x17000016")]
	public float RenderingFieldOfViewVertical
	{
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x566E90", Offset = "0x565C90", Length = "0x10D")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000017")]
	public GameObject WeaponCamera
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x502660", Offset = "0x501460", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	public Vector3 DefaultPosition
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x566FA0", Offset = "0x565DA0", Length = "0xAA")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000019")]
	public Vector3 DefaultRotation
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x567050", Offset = "0x565E50", Length = "0xAA")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x4B4490", Offset = "0x4B3290", Length = "0x5")]
	public bool GetStartCalled()
	{
		return false;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x567100", Offset = "0x565F00", Length = "0x39A")]
	private Vector3 RandomShake(float deltaTime, float speed, float noiseSpeed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x5674A0", Offset = "0x5662A0", Length = "0xCE")]
	public Vector3 ComputeAimShakeForFreezing(float fixedDeltaTime)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x567570", Offset = "0x566370", Length = "0x3B")]
	public static bool IsAimBreathingDisabled()
	{
		return false;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x5675B0", Offset = "0x5663B0", Length = "0x99")]
	public static bool IsAimSwayDisabled()
	{
		return false;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x567650", Offset = "0x566450", Length = "0x3C")]
	public static bool IsAimStaminaDisabled()
	{
		return false;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x567690", Offset = "0x566490", Length = "0x3C")]
	public static bool IsAimShakeDisabled()
	{
		return false;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x5676D0", Offset = "0x5664D0", Length = "0x3C")]
	public static bool GetDisableDepthOfField()
	{
		return false;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x567710", Offset = "0x566510", Length = "0x40")]
	public static void SetDisableAimBreathing(bool enable)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x567750", Offset = "0x566550", Length = "0x41")]
	public static void SetDisableAimSway(bool enable)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x5677A0", Offset = "0x5665A0", Length = "0x41")]
	public static void SetDisableAimStamina(bool enable)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x5677F0", Offset = "0x5665F0", Length = "0x41")]
	public static void SetDisableAimShake(bool enable)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x567840", Offset = "0x566640", Length = "0x41")]
	public static void SetDisableDepthOfField(bool enable)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x567890", Offset = "0x566690", Length = "0x197")]
	public bool HasFirstPersonWeapon()
	{
		return false;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x567A30", Offset = "0x566830", Length = "0x26B")]
	public bool CanStartAiming()
	{
		return false;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x567CA0", Offset = "0x566AA0", Length = "0x1D2")]
	public bool ShouldStopAiming()
	{
		return false;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x567E80", Offset = "0x566C80", Length = "0x7E4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x568670", Offset = "0x567470", Length = "0xACC")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x569140", Offset = "0x567F40", Length = "0x45A")]
	public void MaybeBuildRuntimeHierarchy()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x5695A0", Offset = "0x5683A0", Length = "0xEA")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x569690", Offset = "0x568490", Length = "0x1D3")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x569870", Offset = "0x568670", Length = "0x101")]
	protected void FixedUpdateInternal(float fixedTime, float fixedDeltaTime)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x569980", Offset = "0x568780", Length = "0x1FB")]
	protected void UpdateForces(float time, float deltaTime)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x569B80", Offset = "0x568980", Length = "0x50")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x569BE0", Offset = "0x5689E0", Length = "0x6F")]
	public void AddForce(Vector3 positional, Vector3 angular)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x569C50", Offset = "0x568A50", Length = "0xA1")]
	public void AddForce(float xPos, float yPos, float zPos, float xRot, float yRot, float zRot)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x569D00", Offset = "0x568B00", Length = "0x74")]
	public void AddForce2(Vector3 positional, Vector3 angular)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x569D80", Offset = "0x568B80", Length = "0xA6")]
	public void AddForce2(float xPos, float yPos, float zPos, float xRot, float yRot, float zRot)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x569E30", Offset = "0x568C30", Length = "0x67")]
	public void ApplyFallImpact(float impact)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x569EA0", Offset = "0x568CA0", Length = "0x38")]
	public void AddForce(Vector3 force)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x569EE0", Offset = "0x568CE0", Length = "0x4D")]
	public void AddForce(float x, float y, float z)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x569F30", Offset = "0x568D30", Length = "0x211")]
	protected void UpdateZoom(float time)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x56A150", Offset = "0x568F50", Length = "0x55")]
	public void Zoom()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x56A1B0", Offset = "0x568FB0", Length = "0xA4")]
	public void SnapZoom()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x56A260", Offset = "0x569060", Length = "0x33D")]
	protected void DoWeaponBob(float speed, float time)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x56A5A0", Offset = "0x5693A0", Length = "0xB9E")]
	protected void DoWeaponSwaying(Vector3 velocity, float time, float deltaTime)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x56B140", Offset = "0x569F40", Length = "0xB3F")]
	public void DoAiming(float fixedTime, float fixedDeltaTime)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x56BC80", Offset = "0x56AA80", Length = "0x1AE")]
	public void ResetSprings(float positionReset, float rotationReset, float positionPauseTime = 0f, float rotationPauseTime = 0f)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x56BE30", Offset = "0x56AC30", Length = "0x714")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x56C550", Offset = "0x56B350", Length = "0x3CD")]
	public void SnapPivot()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x56C920", Offset = "0x56B720", Length = "0xF7")]
	public void SetPivotVisible(bool visible)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x56CA20", Offset = "0x56B820", Length = "0x6D5")]
	public void SnapSprings()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x56D100", Offset = "0x56BF00", Length = "0x18A")]
	public void StopSprings()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x56D290", Offset = "0x56C090", Length = "0x57C")]
	public void TurnOnEffects()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x56D810", Offset = "0x56C610", Length = "0xE8")]
	public void DisableEffectsObject()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x56D900", Offset = "0x56C700", Length = "0x4E8")]
	public void TurnOffEffects(bool hardStop)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x56DDF0", Offset = "0x56CBF0", Length = "0x46")]
	public void AnimateToExitOffset()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x56DE40", Offset = "0x56CC40", Length = "0x69")]
	public void AnimateToDefaultPosition()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x56DEB0", Offset = "0x56CCB0", Length = "0x5D")]
	private void NoWeaponCameraError()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x56DF10", Offset = "0x56CD10", Length = "0x11B")]
	public int GetAmmoCount()
	{
		return 0;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x56E030", Offset = "0x56CE30", Length = "0x11D")]
	public bool AnimIsPlaying(int id, int layer)
	{
		return false;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x56E150", Offset = "0x56CF50", Length = "0x509")]
	public void PlayFireAnimation()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x56E660", Offset = "0x56D460", Length = "0x16F")]
	private void OnFireAnimationComplete()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x56E7D0", Offset = "0x56D5D0", Length = "0x8C")]
	public void ToggleZoom(bool zoomed)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x56E860", Offset = "0x56D660", Length = "0x2B4")]
	public void UnJam()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x56EB20", Offset = "0x56D920", Length = "0x2D5")]
	private void OnUnJamComplete()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x56EE00", Offset = "0x56DC00", Length = "0x3E0")]
	public void SetBulletsToReload(int count)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x56F1F0", Offset = "0x56DFF0", Length = "0xB")]
	public bool ReloadInProgress()
	{
		return false;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x56F200", Offset = "0x56E000", Length = "0x22A")]
	public void OnReloadComplete()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x56F430", Offset = "0x56E230", Length = "0x43")]
	public void MaybeSpawnFirstPersonWeapon()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x56F480", Offset = "0x56E280", Length = "0x1C2")]
	private GameObject GetOrCreateTempParent(string objectName, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x56F650", Offset = "0x56E450", Length = "0x62B")]
	private void MaybeSpawnRightHandProp()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x56FC80", Offset = "0x56EA80", Length = "0x62B")]
	private void MaybeSpawnLeftHandProp()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x5702B0", Offset = "0x56F0B0", Length = "0x62B")]
	private void MaybeSpawnShoulderProp()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x5708E0", Offset = "0x56F6E0", Length = "0x293")]
	public bool DecrementBulletsToReload(int n)
	{
		return false;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x570B80", Offset = "0x56F980", Length = "0x8B")]
	public void CancelReload()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x570C10", Offset = "0x56FA10", Length = "0x2C9")]
	public void Reset()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x570EE0", Offset = "0x56FCE0", Length = "0x250")]
	public void UpdateBulletsForReload(int numToShow)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x571140", Offset = "0x56FF40", Length = "0x247")]
	public void ShowNextLoadedBullet()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x571390", Offset = "0x570190", Length = "0x257")]
	public void EnableReloadBulletInstance(bool enable)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x5715F0", Offset = "0x5703F0", Length = "0x193")]
	public void AttachObjectChildCopy(GameObject parentObject)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x571790", Offset = "0x570590", Length = "0x40B")]
	public void RestoreChildObject()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x571BA0", Offset = "0x5709A0", Length = "0x1E1")]
	public bool IsAnimationPlayingOnAnyLayer(int hash)
	{
		return false;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x571D90", Offset = "0x570B90", Length = "0x4AA")]
	public void PlayAnimation(int hash)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x572240", Offset = "0x571040", Length = "0x4B7")]
	private void MoveToTempParent()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x572700", Offset = "0x571500", Length = "0x459")]
	private void CopyChildObject(GameObject newProp)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x572B60", Offset = "0x571960", Length = "0x67")]
	private void OnUnJamRoundsUnloaded()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x572BD0", Offset = "0x5719D0", Length = "0x47F")]
	private void OnRoundsUnloaded()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x573050", Offset = "0x571E50", Length = "0x438")]
	public vp_FPSWeapon()
	{
	}
}
