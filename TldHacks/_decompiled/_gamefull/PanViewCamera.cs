using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200026E")]
public class PanViewCamera : MonoBehaviour
{
	[Token(Token = "0x4001626")]
	[FieldOffset(Offset = "0x20")]
	public float m_PanViewSeconds;

	[Range(1f, 5f)]
	[Token(Token = "0x4001627")]
	[FieldOffset(Offset = "0x24")]
	public int m_EasingLevel;

	[Token(Token = "0x4001628")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_TargetPos;

	[Token(Token = "0x4001629")]
	[FieldOffset(Offset = "0x34")]
	private Quaternion m_TargetRot;

	[Token(Token = "0x400162A")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 m_OriginalPos;

	[Token(Token = "0x400162B")]
	[FieldOffset(Offset = "0x50")]
	private Quaternion m_OriginalRot;

	[Token(Token = "0x400162C")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 m_LerpStartPos;

	[Token(Token = "0x400162D")]
	[FieldOffset(Offset = "0x6C")]
	private Quaternion m_LerpStartRot;

	[Token(Token = "0x400162E")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_IsDetachedFromPlayer;

	[Token(Token = "0x400162F")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_IsPanning;

	[Token(Token = "0x4001630")]
	[FieldOffset(Offset = "0x7E")]
	private bool m_IsPanningToPlayer;

	[Token(Token = "0x4001631")]
	[FieldOffset(Offset = "0x80")]
	private float m_PanStartTime;

	[Token(Token = "0x6001548")]
	[Address(RVA = "0x69C290", Offset = "0x69B090", Length = "0x4D5")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001549")]
	[Address(RVA = "0x69C770", Offset = "0x69B570", Length = "0x358")]
	public void PanToLocation(Vector3 location, Quaternion rotation)
	{
	}

	[Token(Token = "0x600154A")]
	[Address(RVA = "0x69CAD0", Offset = "0x69B8D0", Length = "0x273")]
	public void PanToTransform(Transform target)
	{
	}

	[Token(Token = "0x600154B")]
	[Address(RVA = "0x69CD50", Offset = "0x69BB50", Length = "0x1EF")]
	public void ReattachToPlayer()
	{
	}

	[Token(Token = "0x600154C")]
	[Address(RVA = "0x69CF40", Offset = "0x69BD40", Length = "0xD")]
	public void MaybeReattachToPlayer()
	{
	}

	[Token(Token = "0x600154D")]
	[Address(RVA = "0x69CF50", Offset = "0x69BD50", Length = "0x5")]
	public void DetachFromPlayer()
	{
	}

	[Token(Token = "0x600154E")]
	[Address(RVA = "0x634890", Offset = "0x633690", Length = "0x5")]
	public bool IsDetached()
	{
		return false;
	}

	[Token(Token = "0x600154F")]
	[Address(RVA = "0x69CF60", Offset = "0x69BD60", Length = "0x5")]
	public bool IsPanning()
	{
		return false;
	}

	[Token(Token = "0x6001550")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PanViewCamera()
	{
	}
}
