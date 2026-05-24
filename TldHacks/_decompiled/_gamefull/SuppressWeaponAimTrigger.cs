using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009D6")]
public class SuppressWeaponAimTrigger : MonoBehaviour
{
	[Token(Token = "0x60056CC")]
	[Address(RVA = "0xEC0E80", Offset = "0xEBFC80", Length = "0x54")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x60056CD")]
	[Address(RVA = "0xEC0EE0", Offset = "0xEBFCE0", Length = "0x54")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x60056CE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SuppressWeaponAimTrigger()
	{
	}
}
