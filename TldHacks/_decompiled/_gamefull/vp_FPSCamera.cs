using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;
using UnityEngine.AddressableAssets;

[RequireComponent(typeof(Camera))]
[Token(Token = "0x200000A")]
public class vp_FPSCamera : vp_Component
{
	[Token(Token = "0x200000B")]
	public delegate void BobStepDelegate();

	[Token(Token = "0x200000C")]
	public delegate void WeaponSwitchDelegate();

	[Token(Token = "0x200000D")]
	public struct RecoilSpring
	{
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 m_Current;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x8")]
		private Vector2 m_Target;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 m_Velocity;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x557690", Offset = "0x556490", Length = "0x7D")]
		public void SetTarget(float pitch, float yaw)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x557710", Offset = "0x556510", Length = "0x131")]
		public void Update(vp_FPSCamera cam)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x557850", Offset = "0x556650", Length = "0xD4")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400003C")]
	private const float ZOOMED_FOV_MULTIPLIER = 0.7f;

	[Token(Token = "0x400003D")]
	private const float MIN_TIME_STEP = 0.02f;

	[Token(Token = "0x400003E")]
	public static bool s_EnabledCustomFixedStep;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x48")]
	protected CharacterController Controller;

	[HideInInspector]
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x50")]
	public PanViewCamera m_PanViewCamera;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 TouchSensitivity;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x60")]
	public float GamepadDeadzone;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x64")]
	public float GamepadDeadZonePower;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x68")]
	public float GamepadSensitivity;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x6C")]
	public float GamepadTimeToMaxVelocity;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x70")]
	public float GamepadTimeActiveResetAfterTimeInactive;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x74")]
	public Vector2 GamepadMinVelocity;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x7C")]
	public Vector2 GamepadMaxVelocity;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x84")]
	public int GamepadHistorySize;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x88")]
	private Vector2[] GamepadHistory;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x90")]
	private int GamepadHistoryCount;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x94")]
	public float GamepadTimeActiveResetOnAngleDifferenceDegrees;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x98")]
	public float m_MaxAmbientSwayAngleDegreesA;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x9C")]
	public float m_AmbientSwaySpeedA;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0xA0")]
	public float m_MaxAmbientAimingSwayAngleDegreesA;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0xA4")]
	public float m_AmbientAimingSwaySpeedA;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0xA8")]
	public float m_SwayVarianceTime;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0xAC")]
	private float GamepadTimeActive;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0xB0")]
	private float GamepadTimeInactive;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0xB4")]
	private float m_Accumulator;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0xB8")]
	private float m_MouseSensitivity;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0xBC")]
	private float m_UnzoomedMouseSensitivity;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0xC0")]
	private float m_ZoomedMouseSensitivity;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0xC4")]
	public int MouseSmoothSteps;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0xC8")]
	public float MouseSmoothWeight;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0xCC")]
	public bool MouseAcceleration;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0xD0")]
	public float MouseAccelerationThreshold;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0xD4")]
	protected Vector2 m_MouseMove;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0xE0")]
	protected List<Vector2> m_MouseSmoothBuffer;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0xE8")]
	private float m_RenderingFieldOfView;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0xEC")]
	private float m_UnzoomedFieldOfView;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0xF0")]
	public float RenderingFieldOfViewTest;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0xF4")]
	public float RenderingZoomDamping;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0xF8")]
	protected float m_FinalZoomTime;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0xFC")]
	public Vector3 PositionOffset;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x108")]
	public float PositionGroundLimit;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x10C")]
	public float PositionSpringStiffness;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x110")]
	public float PositionSpringDamping;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x114")]
	public float PositionSpring2Stiffness;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x118")]
	public float PositionSpring2Damping;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x11C")]
	public float PositionKneeling;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x120")]
	protected vp_Spring m_PositionSpring;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x128")]
	protected vp_Spring m_PositionSpring2;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x130")]
	public Vector2 RotationPitchLimit;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x138")]
	public Vector2 RotationYawLimit;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x140")]
	protected float m_Pitch;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x144")]
	protected float m_Yaw;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x148")]
	public float RotationSpringStiffness;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x14C")]
	public float RotationSpringDamping;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x150")]
	public float RotationKneeling;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x154")]
	public float RotationStrafeRoll;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x158")]
	protected vp_Spring m_RotationSpring;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x160")]
	protected Vector2 m_InitialRotation;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x168")]
	public float m_BasePitch;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x16C")]
	public float m_BaseRoll;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x170")]
	public float ShakeSpeed;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x174")]
	public Vector3 ShakeAmplitude;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x180")]
	protected Vector3 m_Shake;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x18C")]
	public Vector4 BobRate;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x19C")]
	public Vector4 BobAmplitude;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x1AC")]
	public float BobInputVelocityScale;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x1B0")]
	public float BobMaxInputVelocity;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x1B8")]
	public BobStepDelegate BobStepCallback;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x1C0")]
	public float BobStepThreshold;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x1C4")]
	public float RecoilMinVelocity;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x1C8")]
	public float RecoilPitchDamping;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x1CC")]
	public float RecoilPitchStiffness;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x1D0")]
	public float RecoilYawDamping;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x1D4")]
	public float RecoilYawStiffness;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x1D8")]
	public float m_OffsetY;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x1E0")]
	public Camera m_WeaponCamera;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x1E8")]
	public AssetLabelReference m_WeaponAssetLabel;

	[Token(Token = "0x4000089")]
	public static bool m_DebugCamera;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x1F0")]
	protected Camera m_Camera;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x1F8")]
	protected float m_LastUpBob;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x1FC")]
	protected bool m_BobWasElevating;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x200")]
	protected float m_HighestFallSpeed;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x204")]
	protected bool m_WasGroundedLastFrame;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x208")]
	protected float m_EarthQuakeTime;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x20C")]
	protected Vector2 m_EarthQuakeMagnitude;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x214")]
	protected float m_EarthQuakeWeaponShakeFactor;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x218")]
	protected float m_EarthQuakeCameraRollFactor;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x220")]
	private Transform m_WeaponParent;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x228")]
	private readonly Dictionary<FPSItem, vp_FPSWeapon> m_Weapons;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x230")]
	protected vp_FPSWeapon m_CurrentWeapon;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x238")]
	protected vp_FPSShooter m_CurrentShooter;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x240")]
	private GearItem m_PendingGearItem;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x248")]
	protected float m_SwitchWeaponTimer;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x24C")]
	protected float m_ShowWeaponTimer;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x250")]
	protected AudioListener m_AudioListener;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x258")]
	private bool m_OverlayWasActive;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x260")]
	private CameraPathAnimator[] m_CameraPathAnimators;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x268")]
	private Vector2 DefaultRotationPitchLimit;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x270")]
	private Vector2 DefaultRotationYawLimit;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x278")]
	private float m_NearClipPlane;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x27D")]
	private bool m_FirstFrame;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x280")]
	private int m_NumUpdates;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x284")]
	private bool m_UseRootOrientation;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x285")]
	private bool m_LockRotationLimit;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x288")]
	public Vector2 m_LockedRotationPitchLimit;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x290")]
	public Vector2 m_LockedRotationYawLimit;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x298")]
	private Vector2 m_AmbientSwayAngles;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x2A0")]
	public float m_DeadZoneDampenScale;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x2A4")]
	private float m_DeadZoneTime;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x2A8")]
	private bool m_UpdateForcesAndSprings;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x2A9")]
	private bool m_FreeCameraLookEnabled;

	[NonSerialized]
	[Token(Token = "0x40000AC")]
	private static bool m_DisableAmbientSway;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x2AC")]
	private float m_CurrentAmbientSwaySpeed;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x2B0")]
	private float m_CurrentMaxAmbientSwayAngle;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x2B4")]
	private Vector3 m_RandomSwayOScillationAngles;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x2C0")]
	private Vector3 m_RandomSwaySpeeds;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x2CC")]
	private Vector3 m_CurrentRandomSwaySpeeds;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x2D8")]
	private float m_RandomSwayCountdown;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x2E0")]
	private Action<float, float> m_FixedUpdateCallback;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x2E8")]
	private bool m_ForceIndoorFovAllowed;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x2EC")]
	private float m_TargetPitch;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x2F0")]
	private float m_CurrentPitch;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x2F4")]
	private float m_TargetYaw;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x2F8")]
	private float m_CurrentYaw;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x2FC")]
	private float m_YawPitchDampingFactor;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x300")]
	private bool m_UseUnscaledTime;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x304")]
	public RecoilSpring m_RecoilSpring;

	[Token(Token = "0x17000007")]
	public float MouseSensitivity
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x549430", Offset = "0x548230", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x549440", Offset = "0x548240", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public vp_FPSWeapon CurrentWeapon
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x549450", Offset = "0x548250", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	public vp_FPSShooter CurrentShooter
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x549460", Offset = "0x548260", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	public Vector3 PositionSpring
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x549470", Offset = "0x548270", Length = "0x2C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700000B")]
	public Vector2 Angle
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x5494A0", Offset = "0x5482A0", Length = "0x19")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x5494C0", Offset = "0x5482C0", Length = "0xC6")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	[field: Token(Token = "0x40000A0")]
	[field: FieldOffset(Offset = "0x27C")]
	public bool IsZoomed
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x549590", Offset = "0x548390", Length = "0x8")]
		get;
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x5495A0", Offset = "0x5483A0", Length = "0x7")]
		set;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x5495B0", Offset = "0x5483B0", Length = "0xB1")]
	public static bool IsAmbientSwayDisabled()
	{
		return false;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x549670", Offset = "0x548470", Length = "0x59")]
	public static void SetDisableAmbientSway(bool enable)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x5496D0", Offset = "0x5484D0", Length = "0x7")]
	public void SetUseRootOrientation(bool useRootOrientation)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x5496E0", Offset = "0x5484E0", Length = "0x901")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x549FF0", Offset = "0x548DF0", Length = "0x13D")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x54A130", Offset = "0x548F30", Length = "0x154")]
	public void SetFOVFromOptions(float newFOV)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x54A290", Offset = "0x549090", Length = "0x11")]
	public void SetMouseSensitivityFromOptions(float newMouseSensitivity)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x54A2B0", Offset = "0x5490B0", Length = "0x9")]
	public void SetZoomSensitivityFromOptions(float newMouseSensitivity)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x54A2C0", Offset = "0x5490C0", Length = "0x8")]
	public Camera GetCameraComponent()
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x54A2D0", Offset = "0x5490D0", Length = "0xEC")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x54A3C0", Offset = "0x5491C0", Length = "0xB47")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x54AF10", Offset = "0x549D10", Length = "0x7")]
	public void SetUpdateForcesAndStrings(bool update)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x54AF20", Offset = "0x549D20", Length = "0x91F")]
	public void UpdateCameraRotation()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x54B840", Offset = "0x54A640", Length = "0x3BD")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x54BC00", Offset = "0x54AA00", Length = "0x606")]
	private void DoLateUpdate()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x54C210", Offset = "0x54B010", Length = "0x168")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x54C380", Offset = "0x54B180", Length = "0x8E7")]
	protected void FixedUpdateInternal(float fixedTime, float fixedDeltaTime)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x54CC70", Offset = "0x54BA70", Length = "0x322")]
	protected void UpdateForces(float time, float smoothDeltaTime)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x54CFA0", Offset = "0x54BDA0", Length = "0xE5")]
	public void RefreshCameraTransform()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x54D090", Offset = "0x54BE90", Length = "0x7")]
	public void SetWasGroundedLastFrame(bool wasGroundedLastFrame)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x54D0A0", Offset = "0x54BEA0", Length = "0x275")]
	protected void DetectFallingImpact(float smoothDeltaTime)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x54D320", Offset = "0x54C120", Length = "0xA11")]
	protected void DoCameraCollision()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x54DD40", Offset = "0x54CB40", Length = "0x36C")]
	public void ApplyFallImpact(float impact, bool weaponOnly)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x54E0B0", Offset = "0x54CEB0", Length = "0x38")]
	public void AddForce(Vector3 force)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x54E0F0", Offset = "0x54CEF0", Length = "0x4D")]
	public void AddForce(float x, float y, float z)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x54E140", Offset = "0x54CF40", Length = "0x38")]
	public void AddForce2(Vector3 force)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x54E180", Offset = "0x54CF80", Length = "0x4D")]
	public void AddForce2(float x, float y, float z)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x54E1D0", Offset = "0x54CFD0", Length = "0x4A")]
	public void AddRollForce(float force)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x54E220", Offset = "0x54D020", Length = "0x38")]
	public void AddRotationForce(Vector3 force)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x54E260", Offset = "0x54D060", Length = "0x4D")]
	public void AddRotationForce(float x, float y, float z)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x54E2B0", Offset = "0x54D0B0", Length = "0x8")]
	public void SetPitchLimit(Vector2 limit)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x54E2C0", Offset = "0x54D0C0", Length = "0xE5")]
	public void SetYawLimit(Quaternion baseRotation, Vector2 limit)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x54E3B0", Offset = "0x54D1B0", Length = "0x160")]
	public void SetPitchLimitFromBase(Quaternion baseRotation, Vector2 limit)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x54E510", Offset = "0x54D310", Length = "0x8")]
	public bool IsRotationLimitLocked()
	{
		return false;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x54E520", Offset = "0x54D320", Length = "0x8")]
	public bool IsFreeCameraLookEnabled()
	{
		return false;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x54E530", Offset = "0x54D330", Length = "0x108")]
	public void EnableFreeCameraLook(Vector2 pitchLimit, Vector2 yawLimit)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x54E640", Offset = "0x54D440", Length = "0x15B")]
	public void DisableFreeCameraLook()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x54E7A0", Offset = "0x54D5A0", Length = "0x16")]
	public void LockRotationLimit()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x54E7C0", Offset = "0x54D5C0", Length = "0xB1")]
	public void UnlockRotationLimit()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x54E880", Offset = "0x54D680", Length = "0x8E8")]
	private Vector2 GetMouseDelta()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x54F170", Offset = "0x54DF70", Length = "0x275")]
	private float CalculateClampedYaw(float delta, float orginalYaw, float yaw)
	{
		return 0f;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x54F3F0", Offset = "0x54E1F0", Length = "0x11D")]
	public void UpdateMouseLook(Vector2 input)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x54F510", Offset = "0x54E310", Length = "0x61")]
	public void AddToYaw(float angle)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x54F580", Offset = "0x54E380", Length = "0x28F")]
	protected void UpdateZoom(float time)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x54F810", Offset = "0x54E610", Length = "0x1F8")]
	public void ToggleZoom(bool enabled)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x54FA10", Offset = "0x54E810", Length = "0x9")]
	public float GetUnzoomedFieldOfView()
	{
		return 0f;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x54FA20", Offset = "0x54E820", Length = "0x259")]
	public void Zoom()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x54FC80", Offset = "0x54EA80", Length = "0x74")]
	public void SnapZoom()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x54FD00", Offset = "0x54EB00", Length = "0x190")]
	protected void UpdateShakes(float fixedTime)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x54FEA0", Offset = "0x54ECA0", Length = "0x3D1")]
	private Vector2 RandomSway(float deltaTime, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x550280", Offset = "0x54F080", Length = "0x1F0")]
	protected void UpdateAmbientSway(float fixedDeltaTime)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x550480", Offset = "0x54F280", Length = "0x4F7")]
	protected void DoBob(float speed, float time)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x550980", Offset = "0x54F780", Length = "0xE3")]
	protected void DetectBobStep(float speed, float upBob)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x550A70", Offset = "0x54F870", Length = "0x170")]
	protected void DoSwaying(Vector3 velocity)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x550BF0", Offset = "0x54F9F0", Length = "0x3FB")]
	protected void UpdateEarthQuake(float time)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x550FF0", Offset = "0x54FDF0", Length = "0x35")]
	public void DoEarthQuake(float x, float y, float duration, float weaponShakeFactor = 1f, float cameraRollFactor = 0f)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x551030", Offset = "0x54FE30", Length = "0xB")]
	public void StopEarthQuake()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x551040", Offset = "0x54FE40", Length = "0x225")]
	public void DoBomb(float force)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x551270", Offset = "0x550070", Length = "0x1C3")]
	public void DoBomb(Vector3 positionForce, float minRollForce, float maxRollForce, Vector2 earthQuakeForce, float earthQuakeTime, float earthQuakeWeaponShakeFactor, float earthQuakeCameraRollFactor, Vector3 weaponPositionForce, Vector3 weaponRotationForce)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x551440", Offset = "0x550240", Length = "0x129")]
	public void DoStomp(float force)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x551570", Offset = "0x550370", Length = "0x29B")]
	public void DoAttackHit(float shakeForce, float rollForce)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x551810", Offset = "0x550610", Length = "0x52B")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x551D40", Offset = "0x550B40", Length = "0x13")]
	public void SetAngle(float yaw, float pitch)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x551D60", Offset = "0x550B60", Length = "0x1DD")]
	public void SnapSprings()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x551F40", Offset = "0x550D40", Length = "0xF8")]
	public void StopSprings()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x552040", Offset = "0x550E40", Length = "0xA")]
	public void UnWieldCurrentWeapon()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x552050", Offset = "0x550E50", Length = "0x6D8")]
	public void SwitchWeapon(GearItem gearItem)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x552730", Offset = "0x551530", Length = "0x148")]
	private void DoSwitchWeapon()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x552880", Offset = "0x551680", Length = "0x5A2")]
	private void HidePrevious()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x552E30", Offset = "0x551C30", Length = "0x41A")]
	private void ShowNext()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x553250", Offset = "0x552050", Length = "0x7")]
	private void OnWeaponUnequipped()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x553260", Offset = "0x552060", Length = "0x52")]
	private void OnWeaponEquipped()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x5532C0", Offset = "0x5520C0", Length = "0x15")]
	public void CancelWeaponSwitch()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x5532E0", Offset = "0x5520E0", Length = "0x106")]
	public bool WeaponSwitchInProgress()
	{
		return false;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x5533F0", Offset = "0x5521F0", Length = "0x8")]
	public bool UseUnscaledTime()
	{
		return false;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x553400", Offset = "0x552200", Length = "0x7")]
	public void ForceUnscaledTime(bool useUnscaleTime)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x553410", Offset = "0x552210", Length = "0xF0")]
	public GameObject GetFPSItemGameObject(FPSItem item)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x553500", Offset = "0x552300", Length = "0x51E")]
	public void DeactivateAllWeapons()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x553A20", Offset = "0x552820", Length = "0x1258")]
	public void SetWeapon(GearItem gearItem)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x554C80", Offset = "0x553A80", Length = "0x805")]
	protected void DeactivateWhenSilent(Transform t)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x555490", Offset = "0x554290", Length = "0x112")]
	public void SetWeaponLayer(int layer)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x5555B0", Offset = "0x5543B0", Length = "0x2AB")]
	public void EnableEffectsForWeapon(FPSItem itemData, bool enable, bool hardStop)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x555860", Offset = "0x554660", Length = "0x13E")]
	public vp_FPSWeapon GetWeaponFromItemData(FPSItem itemData)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x5559A0", Offset = "0x5547A0", Length = "0x1BF")]
	private void RegisterWeaponItem(FPSItem itemData)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x555B60", Offset = "0x554960", Length = "0xED")]
	public bool PanViewCameraIsDetached()
	{
		return false;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x555C50", Offset = "0x554A50", Length = "0x116")]
	public Camera GetWeaponCamera()
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x555D70", Offset = "0x554B70", Length = "0x9")]
	public void SetNearPlaneOverride(float nearPlane)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x555D80", Offset = "0x554B80", Length = "0x9")]
	public float GetNearPlaneOverride()
	{
		return 0f;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x555D90", Offset = "0x554B90", Length = "0xB1")]
	public void StopNearPlaneOverride()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x555E50", Offset = "0x554C50", Length = "0x165")]
	private bool AnimatedCameraPathIsPlaying()
	{
		return false;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x555FC0", Offset = "0x554DC0", Length = "0x767")]
	private Vector2 ComputeJoystickInput(float deltaTime)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x556730", Offset = "0x555530", Length = "0xE5")]
	public void MaybeResetCurrentWeapon()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x556820", Offset = "0x555620", Length = "0x3E6")]
	private void LoadAllFPSWeapons()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x556C10", Offset = "0x555A10", Length = "0x38A")]
	public void DumpWeaponIds()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x556FA0", Offset = "0x555DA0", Length = "0x12D")]
	public static void DoCustomFixedUpdate(Action<float, float> fixedUpdateAction, ref float accumulator)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x5570D0", Offset = "0x555ED0", Length = "0x571")]
	public vp_FPSCamera()
	{
	}
}
