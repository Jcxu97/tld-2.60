using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009BE")]
public class CameraShakeTrigger : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4006360")]
	[FieldOffset(Offset = "0x20")]
	private bool m_TriggeredByPlayer;

	[SerializeField]
	[Token(Token = "0x4006361")]
	[FieldOffset(Offset = "0x21")]
	private bool m_Repeatable;

	[SerializeField]
	[Token(Token = "0x4006362")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 m_ShakeMagnitude;

	[SerializeField]
	[Token(Token = "0x4006363")]
	[FieldOffset(Offset = "0x2C")]
	private float m_ShakeDurationSeconds;

	[SerializeField]
	[Token(Token = "0x4006364")]
	[FieldOffset(Offset = "0x30")]
	private float m_WeaponShakeFactor;

	[SerializeField]
	[Token(Token = "0x4006365")]
	[FieldOffset(Offset = "0x34")]
	private float m_CameraRollFactor;

	[Token(Token = "0x4006366")]
	[FieldOffset(Offset = "0x38")]
	private bool m_WasTriggered;

	[Token(Token = "0x6005651")]
	[Address(RVA = "0xEB69F0", Offset = "0xEB57F0", Length = "0x19E")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6005652")]
	[Address(RVA = "0xEB6B90", Offset = "0xEB5990", Length = "0x9F")]
	public CameraShakeTrigger()
	{
	}
}
