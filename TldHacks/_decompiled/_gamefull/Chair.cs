using Cpp2ILInjected;
using TLD.Interactions;
using UnityEngine;

[Token(Token = "0x200055C")]
public class Chair : MonoBehaviour
{
	[Token(Token = "0x400317B")]
	[FieldOffset(Offset = "0x20")]
	public float m_ApproachAngle;

	[Token(Token = "0x400317C")]
	[FieldOffset(Offset = "0x24")]
	public float m_ApproachAngleAcceptableOffset;

	[Token(Token = "0x400317D")]
	[FieldOffset(Offset = "0x28")]
	public PlayerInConstrainedCamera.ConstrainedCameraInfo m_ConstrainedCameraInfo;

	[Token(Token = "0x6002923")]
	[Address(RVA = "0x8DF620", Offset = "0x8DE420", Length = "0x36")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x6002924")]
	[Address(RVA = "0x8DF660", Offset = "0x8DE460", Length = "0x62")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002925")]
	[Address(RVA = "0x8DF6D0", Offset = "0x8DE4D0", Length = "0x2BA")]
	private bool CanInteract()
	{
		return false;
	}

	[Token(Token = "0x6002926")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Chair()
	{
	}
}
