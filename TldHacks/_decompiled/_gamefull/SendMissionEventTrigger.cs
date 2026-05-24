using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000846")]
public class SendMissionEventTrigger : MonoBehaviour
{
	[Header("Fields can be left empty if trigger is being used by an object")]
	[Token(Token = "0x4005678")]
	[FieldOffset(Offset = "0x20")]
	public string m_EventName;

	[Token(Token = "0x4005679")]
	[FieldOffset(Offset = "0x28")]
	public bool m_SendEventOnEnterTrigger;

	[Token(Token = "0x400567A")]
	[FieldOffset(Offset = "0x29")]
	private bool m_PlayerIsInsideTrigger;

	[Token(Token = "0x6004CA7")]
	[Address(RVA = "0xD754C0", Offset = "0xD742C0", Length = "0x5")]
	public bool PlayerIsInsideTrigger()
	{
		return false;
	}

	[Token(Token = "0x6004CA8")]
	[Address(RVA = "0xD754D0", Offset = "0xD742D0", Length = "0x64")]
	public void SendMissionEvent()
	{
	}

	[Token(Token = "0x6004CA9")]
	[Address(RVA = "0xD75540", Offset = "0xD74340", Length = "0xCA")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6004CAA")]
	[Address(RVA = "0xD75610", Offset = "0xD74410", Length = "0x6F")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6004CAB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SendMissionEventTrigger()
	{
	}
}
