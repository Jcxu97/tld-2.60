using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20002E8")]
public class ElectrostaticEventListener : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400198C")]
	[FieldOffset(Offset = "0x20")]
	private UnityEvent<bool> m_ActiveChanged;

	[SerializeField]
	[Token(Token = "0x400198D")]
	[FieldOffset(Offset = "0x28")]
	private UnityEvent<bool> m_FullyActiveChanged;

	[SerializeField]
	[Token(Token = "0x400198E")]
	[FieldOffset(Offset = "0x30")]
	private UnityEvent<float> m_NormalizedActiveChanged;

	[SerializeField]
	[Token(Token = "0x400198F")]
	[FieldOffset(Offset = "0x38")]
	private UnityEvent<float> m_StrengthChanged;

	[Token(Token = "0x6001844")]
	[Address(RVA = "0x6E4630", Offset = "0x6E3430", Length = "0x23C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001845")]
	[Address(RVA = "0x6E4870", Offset = "0x6E3670", Length = "0x1AB")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001846")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ElectrostaticEventListener()
	{
	}
}
