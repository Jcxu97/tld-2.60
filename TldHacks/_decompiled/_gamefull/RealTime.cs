using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000BF")]
public class RealTime : MonoBehaviour
{
	[Token(Token = "0x1700008F")]
	public static float time
	{
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xF95680", Offset = "0xF94480", Length = "0x45")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000090")]
	public static float deltaTime
	{
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xF956D0", Offset = "0xF944D0", Length = "0x45")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RealTime()
	{
	}
}
