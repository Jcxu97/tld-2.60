using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200047D")]
public class EmergencyStimItem : MonoBehaviour
{
	[Token(Token = "0x40028B2")]
	[FieldOffset(Offset = "0x20")]
	public float m_HPIncrease;

	[Token(Token = "0x40028B3")]
	[FieldOffset(Offset = "0x24")]
	public float m_FatigueInitialDecrease;

	[Token(Token = "0x40028B4")]
	[FieldOffset(Offset = "0x28")]
	public float m_FatigueEndingIncrease;

	[Token(Token = "0x40028B5")]
	[FieldOffset(Offset = "0x2C")]
	public float m_StaminaEndingDecrease;

	[Token(Token = "0x40028B6")]
	[FieldOffset(Offset = "0x30")]
	public float m_HoursStimulatedWhenInjected;

	[Token(Token = "0x40028B7")]
	[FieldOffset(Offset = "0x34")]
	public float m_MinHoursBetweenUsage;

	[Token(Token = "0x40028B8")]
	[FieldOffset(Offset = "0x38")]
	public float m_PulseFrequencyStart;

	[Token(Token = "0x40028B9")]
	[FieldOffset(Offset = "0x3C")]
	public float m_PulseFrequencyEnd;

	[Token(Token = "0x40028BA")]
	[FieldOffset(Offset = "0x40")]
	private GearItem m_GearItem;

	[Token(Token = "0x60021E7")]
	[Address(RVA = "0x8235F0", Offset = "0x8223F0", Length = "0x8C")]
	public void Awake()
	{
	}

	[Token(Token = "0x60021E8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x60021E9")]
	[Address(RVA = "0x823680", Offset = "0x822480", Length = "0x295")]
	public void Use()
	{
	}

	[Token(Token = "0x60021EA")]
	[Address(RVA = "0x823920", Offset = "0x822720", Length = "0x1D5")]
	public void OnInject()
	{
	}

	[Token(Token = "0x60021EB")]
	[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
	public GearItem GetGearItem()
	{
		return null;
	}

	[Token(Token = "0x60021EC")]
	[Address(RVA = "0x823B00", Offset = "0x822900", Length = "0x57")]
	private void OnInjectComplete()
	{
	}

	[Token(Token = "0x60021ED")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EmergencyStimItem()
	{
	}
}
