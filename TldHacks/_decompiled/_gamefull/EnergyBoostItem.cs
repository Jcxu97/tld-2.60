using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200047E")]
public class EnergyBoostItem : MonoBehaviour
{
	[Token(Token = "0x40028BB")]
	[FieldOffset(Offset = "0x20")]
	public float m_FatigueInitialDecrease;

	[Token(Token = "0x40028BC")]
	[FieldOffset(Offset = "0x24")]
	public float m_StaminaInitialIncrease;

	[Token(Token = "0x40028BD")]
	[FieldOffset(Offset = "0x28")]
	public float m_FatigueEndingIncrease;

	[Token(Token = "0x40028BE")]
	[FieldOffset(Offset = "0x2C")]
	public float m_StaminaEndingDecrease;

	[Token(Token = "0x40028BF")]
	[FieldOffset(Offset = "0x30")]
	public float m_BoostDurationHours;

	[Token(Token = "0x40028C0")]
	[FieldOffset(Offset = "0x34")]
	public float m_PulseFrequencyStart;

	[Token(Token = "0x40028C1")]
	[FieldOffset(Offset = "0x38")]
	public float m_PulseFrequencyEnd;

	[Token(Token = "0x40028C2")]
	[FieldOffset(Offset = "0x40")]
	private GearItem m_GearItem;

	[Token(Token = "0x60021EE")]
	[Address(RVA = "0x823B60", Offset = "0x822960", Length = "0x8C")]
	public void Awake()
	{
	}

	[Token(Token = "0x60021EF")]
	[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
	public GearItem GetGearItem()
	{
		return null;
	}

	[Token(Token = "0x60021F0")]
	[Address(RVA = "0x823BF0", Offset = "0x8229F0", Length = "0x61")]
	public void ApplyBoost()
	{
	}

	[Token(Token = "0x60021F1")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EnergyBoostItem()
	{
	}
}
