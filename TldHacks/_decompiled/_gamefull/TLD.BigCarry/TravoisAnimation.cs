using Cpp2ILInjected;
using UnityEngine;

namespace TLD.BigCarry;

[Token(Token = "0x20014DC")]
public class TravoisAnimation : MonoBehaviour
{
	[Range(0f, 1f)]
	[SerializeField]
	[Token(Token = "0x40096B9")]
	[FieldOffset(Offset = "0x20")]
	private float m_TurnUpdateIntervalSeconds;

	[Range(0f, 3f)]
	[SerializeField]
	[Token(Token = "0x40096BA")]
	[FieldOffset(Offset = "0x24")]
	private float m_TurnDampeningSeconds;

	[Token(Token = "0x40096BB")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_LastForwardDirection;

	[Token(Token = "0x40096BC")]
	[FieldOffset(Offset = "0x34")]
	private float m_TurnUpdateTimer;

	[Token(Token = "0x40096BD")]
	[FieldOffset(Offset = "0x38")]
	private float m_TargetTurnAngleVelocity;

	[Token(Token = "0x40096BE")]
	[FieldOffset(Offset = "0x3C")]
	private float m_CurrentTurnAngleVelocity;

	[Token(Token = "0x40096BF")]
	[FieldOffset(Offset = "0x40")]
	private float m_CurrentTurnDampVelocity;

	[Token(Token = "0x60083B7")]
	[Address(RVA = "0x124E840", Offset = "0x124D640", Length = "0x98")]
	public void InitializeAnimation(Vector3 forwardDirection)
	{
	}

	[Token(Token = "0x60083B8")]
	[Address(RVA = "0x124E8E0", Offset = "0x124D6E0", Length = "0xB8")]
	public void ResetAnimation()
	{
	}

	[Token(Token = "0x60083B9")]
	[Address(RVA = "0x124E9A0", Offset = "0x124D7A0", Length = "0x45D")]
	public void UpdateAnimation(Vector3 forwardDirection)
	{
	}

	[Token(Token = "0x60083BA")]
	[Address(RVA = "0x124EE00", Offset = "0x124DC00", Length = "0x86")]
	private Vector3 GetLookDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60083BB")]
	[Address(RVA = "0x124EE90", Offset = "0x124DC90", Length = "0x51")]
	public TravoisAnimation()
	{
	}
}
