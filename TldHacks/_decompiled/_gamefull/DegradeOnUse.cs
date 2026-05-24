using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200047B")]
public class DegradeOnUse : MonoBehaviour
{
	[Token(Token = "0x40028AD")]
	[FieldOffset(Offset = "0x20")]
	public float m_DegradeHP;

	[Token(Token = "0x60021E1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x60021E2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DegradeOnUse()
	{
	}
}
