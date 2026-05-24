using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000845")]
public class SendMissionEventObject : MonoBehaviour
{
	[Header("Trigger field can be left empty if not required")]
	[Token(Token = "0x4005676")]
	[FieldOffset(Offset = "0x20")]
	public string m_EventName;

	[Token(Token = "0x4005677")]
	[FieldOffset(Offset = "0x28")]
	public SendMissionEventTrigger m_TriggerRequiredForEvent;

	[Token(Token = "0x6004CA4")]
	[Address(RVA = "0xD75320", Offset = "0xD74120", Length = "0x12F")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6004CA5")]
	[Address(RVA = "0xD75450", Offset = "0xD74250", Length = "0x64")]
	public void SendMissionEvent()
	{
	}

	[Token(Token = "0x6004CA6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SendMissionEventObject()
	{
	}
}
