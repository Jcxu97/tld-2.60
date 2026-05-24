using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005B0")]
public class RopeLedge : MonoBehaviour
{
	[Token(Token = "0x400348E")]
	[FieldOffset(Offset = "0x20")]
	public Rope m_Rope;

	[Token(Token = "0x400348F")]
	[FieldOffset(Offset = "0x28")]
	public Transform m_DismountPoint;

	[Token(Token = "0x4003490")]
	[FieldOffset(Offset = "0x30")]
	public RopeExitPoint m_LedgeAccess;

	[Token(Token = "0x4003491")]
	[FieldOffset(Offset = "0x38")]
	public RopeClimbPoint m_RopeAccess;

	[Token(Token = "0x4003492")]
	[FieldOffset(Offset = "0x40")]
	public float m_LedgeAccessOffsetFromRope;

	[Token(Token = "0x4003493")]
	[FieldOffset(Offset = "0x44")]
	public float m_LedgeAccessForwardOffset;

	[Token(Token = "0x4003494")]
	[FieldOffset(Offset = "0x48")]
	public float m_LedgeAccessLiftUp;

	[Token(Token = "0x4003495")]
	[FieldOffset(Offset = "0x4C")]
	public float m_DismountPointOffsetFromRope;

	[Token(Token = "0x4003496")]
	[FieldOffset(Offset = "0x50")]
	public float m_DismountPointForwardOffset;

	[Token(Token = "0x4003497")]
	[FieldOffset(Offset = "0x54")]
	public float m_DismountPointYaw;

	[Token(Token = "0x4003498")]
	[FieldOffset(Offset = "0x58")]
	public float m_DismountPointPitch;

	[Token(Token = "0x4003499")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsLeftSide;

	[Token(Token = "0x400349A")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 m_Forward;

	[Token(Token = "0x400349B")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 m_FromRope;

	[Token(Token = "0x400349C")]
	[FieldOffset(Offset = "0x78")]
	private float m_ClosestRopeT;

	[Token(Token = "0x6002C0B")]
	[Address(RVA = "0x92BA70", Offset = "0x92A870", Length = "0x110E")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C0C")]
	[Address(RVA = "0x92CB80", Offset = "0x92B980", Length = "0x6A")]
	public void SetActiveInitial(bool state)
	{
	}

	[Token(Token = "0x6002C0D")]
	[Address(RVA = "0x92CBF0", Offset = "0x92B9F0", Length = "0x68")]
	public void OnRopeTransition(bool playerOnRope)
	{
	}

	[Token(Token = "0x6002C0E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RopeLedge()
	{
	}
}
