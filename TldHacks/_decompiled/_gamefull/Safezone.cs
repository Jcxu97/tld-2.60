using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A36")]
public class Safezone : MonoBehaviour
{
	[Token(Token = "0x400668D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_SpriteSafezone;

	[Token(Token = "0x400668E")]
	public static bool m_ShowSafeZone;

	[Token(Token = "0x6005920")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Safezone()
	{
	}
}
