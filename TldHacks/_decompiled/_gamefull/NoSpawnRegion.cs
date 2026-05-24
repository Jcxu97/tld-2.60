using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000178")]
public class NoSpawnRegion : MonoBehaviour
{
	[Token(Token = "0x4000DAB")]
	[FieldOffset(Offset = "0x20")]
	public float m_Radius;

	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x5F11F0", Offset = "0x5EFFF0", Length = "0xDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public NoSpawnRegion()
	{
	}
}
