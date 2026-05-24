using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004CF")]
public class Scent : MonoBehaviour
{
	[Token(Token = "0x4002C1D")]
	[FieldOffset(Offset = "0x20")]
	public ScentRangeCategory m_ScentCategory;

	[Token(Token = "0x60024BD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x60024BE")]
	[Address(RVA = "0x86DC60", Offset = "0x86CA60", Length = "0x198")]
	public float GetRange()
	{
		return 0f;
	}

	[Token(Token = "0x60024BF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Scent()
	{
	}
}
