using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003F8")]
public class SetChildOnOff : MonoBehaviour
{
	[Token(Token = "0x400238D")]
	[FieldOffset(Offset = "0x20")]
	public Activation[] m_Activations;

	[Token(Token = "0x400238E")]
	[FieldOffset(Offset = "0x28")]
	private float m_ActivationTimer;

	[Token(Token = "0x400238F")]
	[FieldOffset(Offset = "0x2C")]
	private int m_CurrentActivation;

	[Token(Token = "0x4002390")]
	[FieldOffset(Offset = "0x30")]
	private bool m_ActivationEnabled;

	[Token(Token = "0x4002391")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_Child;

	[Token(Token = "0x6001E67")]
	[Address(RVA = "0x7BD7F0", Offset = "0x7BC5F0", Length = "0x128")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001E68")]
	[Address(RVA = "0x7BD920", Offset = "0x7BC720", Length = "0x1D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E69")]
	[Address(RVA = "0x7BDB00", Offset = "0x7BC900", Length = "0xCD")]
	public void StartOnOffCycle()
	{
	}

	[Token(Token = "0x6001E6A")]
	[Address(RVA = "0x7BDBD0", Offset = "0x7BC9D0", Length = "0x9E")]
	public void CancelOnOffCycle()
	{
	}

	[Token(Token = "0x6001E6B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SetChildOnOff()
	{
	}
}
