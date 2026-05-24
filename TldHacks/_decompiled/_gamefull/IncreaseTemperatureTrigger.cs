using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009C5")]
public class IncreaseTemperatureTrigger : MonoBehaviour
{
	[Token(Token = "0x4006381")]
	[FieldOffset(Offset = "0x20")]
	public float m_TempIncrease;

	[Token(Token = "0x4006382")]
	[FieldOffset(Offset = "0x24")]
	private bool m_PlayerIsInside;

	[Token(Token = "0x6005676")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6005677")]
	[Address(RVA = "0xEB9B10", Offset = "0xEB8910", Length = "0xBA")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6005678")]
	[Address(RVA = "0xEB9BD0", Offset = "0xEB89D0", Length = "0xC1")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6005679")]
	[Address(RVA = "0xEB9CA0", Offset = "0xEB8AA0", Length = "0x7A")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600567A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public IncreaseTemperatureTrigger()
	{
	}
}
