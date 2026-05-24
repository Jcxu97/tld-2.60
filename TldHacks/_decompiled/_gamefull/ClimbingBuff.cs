using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200045F")]
public class ClimbingBuff : MonoBehaviour
{
	[Tooltip("Reduce the odds of sprains on slopes by this percentage")]
	[Range(0f, 100f)]
	[Token(Token = "0x40027AB")]
	[FieldOffset(Offset = "0x20")]
	public float m_SprainRollOddsModifier;

	[Tooltip("Reduce the amount of stamina drain per second by this percentage")]
	[Range(0f, 100f)]
	[Token(Token = "0x40027AC")]
	[FieldOffset(Offset = "0x24")]
	public float m_StaminaPerSecondModifier;

	[Tooltip("Extend the amount of time on weak ice by this time in seconds")]
	[Range(0f, 240f)]
	[Token(Token = "0x40027AD")]
	[FieldOffset(Offset = "0x28")]
	public float m_WeakIceTimeSecondsModifier;

	[Token(Token = "0x40027AE")]
	[FieldOffset(Offset = "0x2C")]
	private float m_SprainModifier;

	[Token(Token = "0x40027AF")]
	[FieldOffset(Offset = "0x30")]
	private float m_StaminaModifier;

	[Token(Token = "0x6002114")]
	[Address(RVA = "0x80BC50", Offset = "0x80AA50", Length = "0xE6")]
	public bool IsActive(PlayerManager playerManager)
	{
		return false;
	}

	[Token(Token = "0x6002115")]
	[Address(RVA = "0x5093C0", Offset = "0x5081C0", Length = "0x6")]
	public float GetSprainRollOddsModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6002116")]
	[Address(RVA = "0x5093E0", Offset = "0x5081E0", Length = "0x6")]
	public float GetStaminaModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6002117")]
	[Address(RVA = "0x504290", Offset = "0x503090", Length = "0x6")]
	public float GetWeakIceTimeSecondsModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6002118")]
	[Address(RVA = "0x80BD40", Offset = "0x80AB40", Length = "0x25")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002119")]
	[Address(RVA = "0x80BD70", Offset = "0x80AB70", Length = "0x51")]
	public ClimbingBuff()
	{
	}
}
