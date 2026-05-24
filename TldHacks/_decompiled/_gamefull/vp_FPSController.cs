using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[Token(Token = "0x200000F")]
public class vp_FPSController : vp_Component
{
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x48")]
	public CharacterController m_Controller;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x50")]
	public float MotorVelocityMin;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x54")]
	public float MotorVelocityMax;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x58")]
	public float MotorAcceleration;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x5C")]
	public float MotorDamping;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x60")]
	public float MotorJumpForce;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x64")]
	public float MotorAirSpeed;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x68")]
	public float MotorSlopeSpeedUp;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x6C")]
	public float MotorSlopeSpeedDown;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x70")]
	public bool MotorAnalogInput;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x74")]
	public float InputDeadzone;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x78")]
	protected Vector3 m_MotorThrottle;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x84")]
	protected bool m_MoveForward;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x85")]
	protected bool m_MoveLeft;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x86")]
	protected bool m_MoveRight;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x87")]
	protected bool m_MoveBack;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x88")]
	protected Vector2 m_MoveInput;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x90")]
	public float PhysicsForceDamping;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x94")]
	public float PhysicsPushForce;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x98")]
	public float PhysicsGravityModifier;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x9C")]
	public float PhysicsWallBounce;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0xA0")]
	protected Vector3 m_ExternalForce;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0xAC")]
	protected bool m_WasGroundedLastFrame;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0xB0")]
	protected float m_FallSpeed;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0xB4")]
	protected float m_LastFallSpeed;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0xB8")]
	protected float m_HighestFallSpeed;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0xBC")]
	protected float m_FallImpact;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0xC0")]
	protected float m_FallDistance;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0xC4")]
	protected bool m_Compact;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0xC8")]
	protected float m_NormalHeight;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0xCC")]
	protected Vector3 m_NormalCenter;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0xD8")]
	protected float m_CompactHeight;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0xDC")]
	protected Vector3 m_CompactCenter;

	[Token(Token = "0x40000E3")]
	public static bool s_SplitMoveOptimizationEnabled;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0xE8")]
	private bool m_IsOnUnpassableCapsule;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0xEC")]
	private Vector3 m_UnpassableCapsuleNormalHit;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0xF8")]
	private Vector3 m_LastMoveVelocity;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x104")]
	private bool m_ControllerStoppedMoving;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x105")]
	private bool m_CameraWasDetachedLastFrame;

	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x108")]
	private float m_TimeMoving;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x10C")]
	private float m_LastMotorAccel;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x110")]
	private bool m_SplitStepsEnabled;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x114")]
	private float m_EffectiveMovePercent;

	[Token(Token = "0x40000ED")]
	private const float SPLIT_OPTIMIZATION_REDUCE_MOVE_LOW_THRESHOLD = 0.2f;

	[Token(Token = "0x40000EE")]
	private const float SPLIT_OPTIMIZATION_REDUCED_MOVE_HIGH_THRESHOLD = 0.5f;

	[Token(Token = "0x40000EF")]
	private const float FREEFALL_THRESHOLD_SPEED = -0.2f;

	[Token(Token = "0x1700000D")]
	public float FallImpact
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x557960", Offset = "0x556760", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700000E")]
	public float FallDistance
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x557970", Offset = "0x556770", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700000F")]
	public Vector3 Velocity
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x557980", Offset = "0x556780", Length = "0x19")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000010")]
	public bool Compact
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x5579A0", Offset = "0x5567A0", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x5579B0", Offset = "0x5567B0", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public float NormalHeight
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x5579C0", Offset = "0x5567C0", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x5579D0", Offset = "0x5567D0", Length = "0x1AA")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x557B80", Offset = "0x556980", Length = "0x579")]
	private void DoPlayerStrafing(Vector3 moveDirection, Vector3 prevPos)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x558100", Offset = "0x556F00", Length = "0x17CE")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x5598D0", Offset = "0x5586D0", Length = "0x13")]
	public bool IsFreeFalling()
	{
		return false;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x5598F0", Offset = "0x5586F0", Length = "0x1E6")]
	public void SetCompactImmmediate(bool isCompact)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x559AE0", Offset = "0x5588E0", Length = "0xB5B")]
	protected void UpdateMoves()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x55A640", Offset = "0x559440", Length = "0x211")]
	protected float GetSlopeMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x55A860", Offset = "0x559660", Length = "0x64")]
	public void AddForce(Vector3 force)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x55A8D0", Offset = "0x5596D0", Length = "0x55")]
	public void AddForce(float x, float y, float z)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x55A930", Offset = "0x559730", Length = "0x10A")]
	public bool Jump()
	{
		return false;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x55AA40", Offset = "0x559840", Length = "0x7B0")]
	protected void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x55B200", Offset = "0x55A000", Length = "0x27B")]
	protected void AbsorbHorisontalForce(Vector3 impact)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x55B480", Offset = "0x55A280", Length = "0x122")]
	protected void AbsorbUpForce(float impact)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x55B5B0", Offset = "0x55A3B0", Length = "0xCC")]
	private float AbsorbForce(float current, float toAbsorb)
	{
		return 0f;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x55B680", Offset = "0x55A480", Length = "0x8")]
	public void MoveForward()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x55B690", Offset = "0x55A490", Length = "0x8")]
	public void MoveBack()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x55B6A0", Offset = "0x55A4A0", Length = "0x8")]
	public void MoveLeft()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x55B6B0", Offset = "0x55A4B0", Length = "0x8")]
	public void MoveRight()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x4C0250", Offset = "0x4BF050", Length = "0x8")]
	public void Move(Vector2 input)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x55B6C0", Offset = "0x55A4C0", Length = "0xB7")]
	public void SetPosition(Vector3 position)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x55B780", Offset = "0x55A580", Length = "0x1D8")]
	public void Stop()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x55B960", Offset = "0x55A760", Length = "0x11E")]
	public void TryGroundingCharacterController()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x55BA80", Offset = "0x55A880", Length = "0x7")]
	public void SetWasGroundedLastFrame(bool grounded)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x55BA90", Offset = "0x55A890", Length = "0x18B")]
	private bool ShouldFreezeMovement()
	{
		return false;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x55BC20", Offset = "0x55AA20", Length = "0xFC")]
	private Vector3 AdjustMovementForCapsule(Vector3 moveDirection)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	private bool CanDoStrafing()
	{
		return false;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x55BD20", Offset = "0x55AB20", Length = "0x8")]
	public bool IsUsingSplitSteps()
	{
		return false;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x55BD30", Offset = "0x55AB30", Length = "0x11")]
	public float GetEffectiveMovePercent()
	{
		return 0f;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x55BD50", Offset = "0x55AB50", Length = "0x18E")]
	public vp_FPSController()
	{
	}
}
