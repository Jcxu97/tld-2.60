using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace TLD.Boot;

[Token(Token = "0x2001380")]
public class InterruptablePause : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4008F53")]
	[FieldOffset(Offset = "0x20")]
	private float m_MinPause;

	[SerializeField]
	[Token(Token = "0x4008F54")]
	[FieldOffset(Offset = "0x24")]
	private float m_MaxPause;

	[SerializeField]
	[Token(Token = "0x4008F55")]
	[FieldOffset(Offset = "0x28")]
	private UnityEvent m_OnInterruptable;

	[SerializeField]
	[Token(Token = "0x4008F56")]
	[FieldOffset(Offset = "0x30")]
	private UnityEvent m_OnFinished;

	[Token(Token = "0x4008F57")]
	[FieldOffset(Offset = "0x38")]
	private float m_Elapsed;

	[Token(Token = "0x6007C9D")]
	[Address(RVA = "0x11BC6E0", Offset = "0x11BB4E0", Length = "0xA")]
	public void Begin()
	{
	}

	[Token(Token = "0x6007C9E")]
	[Address(RVA = "0x11BC6F0", Offset = "0x11BB4F0", Length = "0x8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007C9F")]
	[Address(RVA = "0x11BC700", Offset = "0x11BB500", Length = "0x108")]
	private void Update()
	{
	}

	[Token(Token = "0x6007CA0")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InterruptablePause()
	{
	}
}
