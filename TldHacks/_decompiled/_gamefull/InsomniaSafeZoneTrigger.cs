using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;

[Token(Token = "0x20009C9")]
public class InsomniaSafeZoneTrigger : MonoBehaviour
{
	[Token(Token = "0x4006395")]
	public static LogFilter s_LogFilter;

	[Token(Token = "0x600568A")]
	[Address(RVA = "0xEBB100", Offset = "0xEB9F00", Length = "0x10C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600568B")]
	[Address(RVA = "0xEBB210", Offset = "0xEBA010", Length = "0xC4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600568C")]
	[Address(RVA = "0xEBB2E0", Offset = "0xEBA0E0", Length = "0x8D")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600568D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InsomniaSafeZoneTrigger()
	{
	}
}
