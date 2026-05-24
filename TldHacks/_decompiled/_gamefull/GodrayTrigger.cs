using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003AA")]
public class GodrayTrigger : MonoBehaviour
{
	[Token(Token = "0x6001D00")]
	[Address(RVA = "0x791CA0", Offset = "0x790AA0", Length = "0xD5")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6001D01")]
	[Address(RVA = "0x791D80", Offset = "0x790B80", Length = "0xD5")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6001D02")]
	[Address(RVA = "0x791E60", Offset = "0x790C60", Length = "0xD5")]
	private void OnTriggerStay(Collider c)
	{
	}

	[Token(Token = "0x6001D03")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GodrayTrigger()
	{
	}
}
