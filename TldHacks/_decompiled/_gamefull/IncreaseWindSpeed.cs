using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009C6")]
public class IncreaseWindSpeed : MonoBehaviour
{
	[Tooltip("The wind speed will never exceed the maximum wind speed set on the Wind component in SCRIPT_EnvironmentSystems")]
	[SerializeField]
	[Range(-65f, 65f)]
	[Token(Token = "0x4006383")]
	[FieldOffset(Offset = "0x20")]
	private float m_WindSpeedIncrease;

	[Tooltip("How long it takes for the wind speed to change when entering or exiting the trigger.")]
	[SerializeField]
	[Range(0f, 30f)]
	[Token(Token = "0x4006384")]
	[FieldOffset(Offset = "0x24")]
	private float m_SpeedIncreaseSeconds;

	[Token(Token = "0x4006385")]
	[FieldOffset(Offset = "0x28")]
	private bool m_PlayerIsInside;

	[Token(Token = "0x4006386")]
	[FieldOffset(Offset = "0x2C")]
	private float m_CurrentWindSpeedIncrease;

	[Token(Token = "0x600567B")]
	[Address(RVA = "0xEB9D20", Offset = "0xEB8B20", Length = "0x1A2")]
	public void Update()
	{
	}

	[Token(Token = "0x600567C")]
	[Address(RVA = "0xEB9ED0", Offset = "0xEB8CD0", Length = "0x75")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x600567D")]
	[Address(RVA = "0xEB9F50", Offset = "0xEB8D50", Length = "0x75")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x600567E")]
	[Address(RVA = "0xEB9FD0", Offset = "0xEB8DD0", Length = "0x81")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600567F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public IncreaseWindSpeed()
	{
	}
}
