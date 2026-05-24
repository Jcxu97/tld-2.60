using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200012E")]
public class TriggerNoticeAstridsPack : MonoBehaviour
{
	[Token(Token = "0x400095C")]
	[FieldOffset(Offset = "0x20")]
	private bool hasBeenPlayed;

	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x5CF230", Offset = "0x5CE030", Length = "0x91")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TriggerNoticeAstridsPack()
	{
	}
}
