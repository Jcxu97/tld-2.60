using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200045C")]
public class BreakDownItem : MonoBehaviour
{
	[Range(0f, 1f)]
	[Token(Token = "0x40027A5")]
	[FieldOffset(Offset = "0x20")]
	public float m_BreakDownTimeModifier;

	[Token(Token = "0x600210F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BreakDownItem()
	{
	}
}
