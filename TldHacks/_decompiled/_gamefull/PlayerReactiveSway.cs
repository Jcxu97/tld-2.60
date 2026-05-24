using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001A5")]
public class PlayerReactiveSway : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000EF3")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_AffectedTransform;

	[SerializeField]
	[Token(Token = "0x4000EF4")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_AmbientSwayDistance;

	[SerializeField]
	[Token(Token = "0x4000EF5")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 m_AmbientSwaySpeed;

	[SerializeField]
	[Token(Token = "0x4000EF6")]
	[FieldOffset(Offset = "0x40")]
	private float m_AmbientTwistDegrees;

	[SerializeField]
	[Token(Token = "0x4000EF7")]
	[FieldOffset(Offset = "0x44")]
	private float m_AmbientTwistSpeed;

	[SerializeField]
	[Token(Token = "0x4000EF8")]
	[FieldOffset(Offset = "0x48")]
	private float m_AmplitudeBoostFromPlayer;

	[SerializeField]
	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0x4C")]
	private float m_AmplitudeBoostSmoothingTime;

	[SerializeField]
	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0x50")]
	private float m_AmplitudeBoostDecayTime;

	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x54")]
	private float m_AmplitudeBoostTarget;

	[Token(Token = "0x4000EFC")]
	[FieldOffset(Offset = "0x58")]
	private float m_AmplitudeBoost;

	[Token(Token = "0x4000EFD")]
	[FieldOffset(Offset = "0x5C")]
	private float m_AmplitudeSmoothingVelocity;

	[Token(Token = "0x4000EFE")]
	[FieldOffset(Offset = "0x60")]
	private float m_AmplitudeDecayVelocity;

	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x616E10", Offset = "0x615C10", Length = "0x516")]
	private void Update()
	{
	}

	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x617330", Offset = "0x616130", Length = "0x105")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PlayerReactiveSway()
	{
	}
}
