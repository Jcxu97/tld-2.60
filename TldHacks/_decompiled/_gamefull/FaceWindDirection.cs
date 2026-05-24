using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A08")]
public class FaceWindDirection : MonoBehaviour
{
	[Token(Token = "0x40065CB")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 targetAngle;

	[Token(Token = "0x6005836")]
	[Address(RVA = "0xEE1D50", Offset = "0xEE0B50", Length = "0x366")]
	private void Update()
	{
	}

	[Token(Token = "0x6005837")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FaceWindDirection()
	{
	}
}
