using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.BigCarry;

[Token(Token = "0x20014E2")]
public class TravoisMovement : MonoBehaviour
{
	[Token(Token = "0x40096FD")]
	public const float TEST_CAPSULE_RADIUS = 0.5f;

	[Header("Look")]
	[SerializeField]
	[Token(Token = "0x40096FE")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 m_PitchLimit;

	[SerializeField]
	[Token(Token = "0x40096FF")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 m_YawLimit;

	[Header("Move")]
	[SerializeField]
	[Token(Token = "0x4009700")]
	[FieldOffset(Offset = "0x30")]
	private float m_TurnSpeed;

	[Header("Restriction")]
	[SerializeField]
	[Token(Token = "0x4009701")]
	[FieldOffset(Offset = "0x34")]
	private float m_DropDistanceFudge;

	[SerializeField]
	[Token(Token = "0x4009702")]
	[FieldOffset(Offset = "0x38")]
	private float m_TestCapsuleWidth;

	[SerializeField]
	[Token(Token = "0x4009703")]
	[FieldOffset(Offset = "0x3C")]
	private float m_LookAheadDistance;

	[SerializeField]
	[Token(Token = "0x4009704")]
	[FieldOffset(Offset = "0x40")]
	private float m_LookBehindDistance;

	[SerializeField]
	[Token(Token = "0x4009705")]
	[FieldOffset(Offset = "0x44")]
	private float m_MaxDropDistance;

	[SerializeField]
	[Token(Token = "0x4009706")]
	[FieldOffset(Offset = "0x48")]
	private float m_MaxSlopeClimbAngle;

	[SerializeField]
	[Token(Token = "0x4009707")]
	[FieldOffset(Offset = "0x4C")]
	private float m_MaxSlopeDownhillAngle;

	[Header("UI")]
	[SerializeField]
	[Token(Token = "0x4009708")]
	[FieldOffset(Offset = "0x50")]
	private float m_MinTimeBetweenErrors;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4009709")]
	[FieldOffset(Offset = "0x58")]
	private TravoisAudio m_TravoisAudio;

	[Header("Animation")]
	[SerializeField]
	[Token(Token = "0x400970A")]
	[FieldOffset(Offset = "0x60")]
	private TravoisAnimation m_TravoisAnimation;

	[Token(Token = "0x400970C")]
	[FieldOffset(Offset = "0x74")]
	private Vector2 m_StartPitchLimit;

	[Token(Token = "0x400970D")]
	[FieldOffset(Offset = "0x7C")]
	private Vector2 m_StartYawLimit;

	[Token(Token = "0x400970E")]
	[FieldOffset(Offset = "0x88")]
	private readonly Collider[] m_BlockingColliders;

	[Token(Token = "0x400970F")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 m_LastGroundTestPosition;

	[Token(Token = "0x4009710")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 m_LastCapsuleTestPoint1;

	[Token(Token = "0x4009711")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 m_LastCapsuleTestPoint2;

	[Token(Token = "0x4009712")]
	[FieldOffset(Offset = "0xB4")]
	private CarryDisplayError m_LastErrorShown;

	[Token(Token = "0x4009713")]
	[FieldOffset(Offset = "0xB8")]
	private float m_LastErrorTime;

	[Token(Token = "0x17000B75")]
	[field: Token(Token = "0x400970B")]
	[field: FieldOffset(Offset = "0x68")]
	public Vector3 ForwardDirection
	{
		[Token(Token = "0x60083FB")]
		[Address(RVA = "0x1255760", Offset = "0x1254560", Length = "0x13")]
		get;
		[Token(Token = "0x60083FC")]
		[Address(RVA = "0x1255780", Offset = "0x1254580", Length = "0x10")]
		private set;
	}

	[Token(Token = "0x60083FD")]
	[Address(RVA = "0x1255790", Offset = "0x1254590", Length = "0x25F")]
	public void BeginMovement()
	{
	}

	[Token(Token = "0x60083FE")]
	[Address(RVA = "0x12559F0", Offset = "0x12547F0", Length = "0xE7")]
	public void EndMovement()
	{
	}

	[Token(Token = "0x60083FF")]
	[Address(RVA = "0x1255AE0", Offset = "0x12548E0", Length = "0x1BB")]
	public void UpdateTravoisMovement()
	{
	}

	[Token(Token = "0x6008400")]
	[Address(RVA = "0x1255CA0", Offset = "0x1254AA0", Length = "0x180")]
	private void UpdateCameraRestriction()
	{
	}

	[Token(Token = "0x6008401")]
	[Address(RVA = "0x1255E30", Offset = "0x1254C30", Length = "0x5C1")]
	public Vector2 ModifyMove(Vector2 move)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6008402")]
	[Address(RVA = "0x1256400", Offset = "0x1255200", Length = "0x163")]
	private float GetMoveAngle(Vector3 lookDirection)
	{
		return 0f;
	}

	[Token(Token = "0x6008403")]
	[Address(RVA = "0x1256570", Offset = "0x1255370", Length = "0x1BC")]
	private Vector2 GetMoveDirection(Vector3 lookDirection)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6008404")]
	[Address(RVA = "0x1256730", Offset = "0x1255530", Length = "0x94")]
	private Vector3 GetLookDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6008405")]
	[Address(RVA = "0x12567D0", Offset = "0x12555D0", Length = "0xB36")]
	private CarryDisplayError CheckMovementRestriction(float magnitude)
	{
		return default(CarryDisplayError);
	}

	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6008406")]
	[Address(RVA = "0x1257310", Offset = "0x1256110", Length = "0xDF")]
	private void DrawDebug()
	{
	}

	[Token(Token = "0x6008407")]
	[Address(RVA = "0x12573F0", Offset = "0x12561F0", Length = "0xDE")]
	public TravoisMovement()
	{
	}
}
