using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000577")]
public class ElevatorPrototypeController : MonoBehaviour
{
	[Token(Token = "0x2000578")]
	private enum State
	{
		[Token(Token = "0x400325A")]
		WaitingForPlayerEnter,
		[Token(Token = "0x400325B")]
		ClosingDoor,
		[Token(Token = "0x400325C")]
		OpeningDoor,
		[Token(Token = "0x400325D")]
		WaitAtFloor,
		[Token(Token = "0x400325E")]
		WaitForUpOrDown,
		[Token(Token = "0x400325F")]
		GoingUp,
		[Token(Token = "0x4003260")]
		GoingDown,
		[Token(Token = "0x4003261")]
		CrashingDown
	}

	[Header("Object References")]
	[Token(Token = "0x400323D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Door;

	[Token(Token = "0x400323E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_OptionalDoorSecond;

	[Token(Token = "0x400323F")]
	[FieldOffset(Offset = "0x30")]
	public BoxCollider m_PlayerTrigger;

	[Token(Token = "0x4003240")]
	[FieldOffset(Offset = "0x38")]
	public Transform m_DoorFrame;

	[Header("Movement Offset")]
	[Token(Token = "0x4003241")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_DoorOpenOffset;

	[Token(Token = "0x4003242")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 m_SecondDoorOpenOffset;

	[Token(Token = "0x4003243")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 m_MovementOffset;

	[Header("Travel")]
	[Token(Token = "0x4003244")]
	[FieldOffset(Offset = "0x64")]
	public float m_MovementDurationMin;

	[Token(Token = "0x4003245")]
	[FieldOffset(Offset = "0x68")]
	public float m_MovementDurationMax;

	[Token(Token = "0x4003246")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve m_MoveUpAndDownCurve;

	[Header("Stamina & Dropping")]
	[Token(Token = "0x4003247")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve m_CrashDownCurve;

	[Token(Token = "0x4003248")]
	[FieldOffset(Offset = "0x80")]
	public float m_MovingProgressBeforePotentialDrop;

	[Token(Token = "0x4003249")]
	[FieldOffset(Offset = "0x84")]
	public float m_FullSpeedStaminaCost;

	[Token(Token = "0x400324A")]
	[FieldOffset(Offset = "0x88")]
	public float m_PotentialDropBelowStamina;

	[Token(Token = "0x400324B")]
	[FieldOffset(Offset = "0x8C")]
	public float m_DropChance;

	[Token(Token = "0x400324C")]
	[FieldOffset(Offset = "0x90")]
	public float m_MinDamageHeightDrop;

	[Token(Token = "0x400324D")]
	[FieldOffset(Offset = "0x94")]
	public float m_MinDamageAmount;

	[Token(Token = "0x400324E")]
	[FieldOffset(Offset = "0x98")]
	public float m_MaxDamageHeightDrop;

	[Token(Token = "0x400324F")]
	[FieldOffset(Offset = "0x9C")]
	public float m_MaxDamageAmount;

	[Token(Token = "0x4003250")]
	[FieldOffset(Offset = "0xA0")]
	public float m_CrashDownDuration;

	[Header("Elevator Floors / Levels")]
	[Token(Token = "0x4003251")]
	[FieldOffset(Offset = "0xA8")]
	public List<float> m_Levels;

	[Token(Token = "0x4003252")]
	[FieldOffset(Offset = "0xB0")]
	private Vector3 m_InitialDoorPosition;

	[Token(Token = "0x4003253")]
	[FieldOffset(Offset = "0xBC")]
	private Vector3 m_InitialSecondDoorPosition;

	[Token(Token = "0x4003254")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 m_InitialElevatorPosition;

	[Token(Token = "0x4003255")]
	[FieldOffset(Offset = "0xD4")]
	private float m_DurationForThisMove;

	[Token(Token = "0x4003256")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_ElevatorDebug;

	[Token(Token = "0x4003257")]
	[FieldOffset(Offset = "0xDC")]
	private State m_StateInternal;

	[Token(Token = "0x4003258")]
	[FieldOffset(Offset = "0xE0")]
	private float m_TimeInCurrentState;

	[Token(Token = "0x170002BE")]
	private State m_State
	{
		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0x694DD0", Offset = "0x693BD0", Length = "0x7")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x8F80E0", Offset = "0x8F6EE0", Length = "0x5C")]
		set
		{
		}
	}

	[Token(Token = "0x6002A0F")]
	[Address(RVA = "0x8F85A0", Offset = "0x8F73A0", Length = "0x16")]
	public void OnPlayerEntered(GameObject playerObject)
	{
	}

	[Token(Token = "0x6002A10")]
	[Address(RVA = "0x8F85C0", Offset = "0x8F73C0", Length = "0x4CA")]
	private void CentrePlayerInElevator()
	{
	}

	[Token(Token = "0x6002A11")]
	[Address(RVA = "0x8F8A90", Offset = "0x8F7890", Length = "0x365")]
	private void Start()
	{
	}

	[Token(Token = "0x6002A12")]
	[Address(RVA = "0x8F8E00", Offset = "0x8F7C00", Length = "0xEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6002A13")]
	[Address(RVA = "0x8F8F10", Offset = "0x8F7D10", Length = "0x803")]
	private void OnDoorMoving()
	{
	}

	[Token(Token = "0x6002A14")]
	[Address(RVA = "0x8F9720", Offset = "0x8F8520", Length = "0x206")]
	private void OnWaitAtFloor()
	{
	}

	[Token(Token = "0x6002A15")]
	[Address(RVA = "0x8F9930", Offset = "0x8F8730", Length = "0x444")]
	private void OnWaitForUpOrDown()
	{
	}

	[Token(Token = "0x6002A16")]
	[Address(RVA = "0x8F9D80", Offset = "0x8F8B80", Length = "0x1B8")]
	public float GetMovementDuration()
	{
		return 0f;
	}

	[Token(Token = "0x6002A17")]
	[Address(RVA = "0x8F9F40", Offset = "0x8F8D40", Length = "0x89A")]
	private void OnElevatorMoving()
	{
	}

	[Token(Token = "0x6002A18")]
	[Address(RVA = "0x8FA7E0", Offset = "0x8F95E0", Length = "0x835")]
	private void OnCrashingDown()
	{
	}

	[Token(Token = "0x6002A19")]
	[Address(RVA = "0x8FB020", Offset = "0x8F9E20", Length = "0x1FD")]
	private float GetHighestFloorHeight()
	{
		return 0f;
	}

	[Token(Token = "0x6002A1A")]
	[Address(RVA = "0x8FB220", Offset = "0x8FA020", Length = "0x1FD")]
	private float GetLowestFloorHeight()
	{
		return 0f;
	}

	[Token(Token = "0x6002A1B")]
	[Address(RVA = "0x8FB420", Offset = "0x8FA220", Length = "0xEB")]
	private bool CanGoDown()
	{
		return false;
	}

	[Token(Token = "0x6002A1C")]
	[Address(RVA = "0x8FB510", Offset = "0x8FA310", Length = "0xEB")]
	private bool CanGoUp()
	{
		return false;
	}

	[Token(Token = "0x6002A1D")]
	[Address(RVA = "0x8FB600", Offset = "0x8FA400", Length = "0x110")]
	private float GetFallDamageToIssue()
	{
		return 0f;
	}

	[Token(Token = "0x6002A1E")]
	[Address(RVA = "0x8FB710", Offset = "0x8FA510", Length = "0x92")]
	private void EnterPlayer()
	{
	}

	[Token(Token = "0x6002A1F")]
	[Address(RVA = "0x8FB7B0", Offset = "0x8FA5B0", Length = "0x73")]
	private void ExitPlayer()
	{
	}

	[Token(Token = "0x6002A20")]
	[Address(RVA = "0x8FB830", Offset = "0x8FA630", Length = "0x15")]
	private bool IsMoving()
	{
		return false;
	}

	[Token(Token = "0x6002A21")]
	[Address(RVA = "0x8FB850", Offset = "0x8FA650", Length = "0xCB")]
	public ElevatorPrototypeController()
	{
	}
}
