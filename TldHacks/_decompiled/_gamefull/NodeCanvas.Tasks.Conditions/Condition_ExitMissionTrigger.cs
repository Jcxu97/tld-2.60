using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Name("Exit Mission Trigger (EVENT)", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001127")]
public class Condition_ExitMissionTrigger : ConditionTask
{
	[Token(Token = "0x4008775")]
	[FieldOffset(Offset = "0x68")]
	public bool checkForPlayer;

	[Token(Token = "0x4008776")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> checkForMissionObjectId;

	[Token(Token = "0x4008777")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> checkForTriggerId;

	[Token(Token = "0x4008778")]
	[FieldOffset(Offset = "0x80")]
	public MissionTriggerType triggerType;

	[Token(Token = "0x4008779")]
	[FieldOffset(Offset = "0x88")]
	public string clearAssociatedDataVar;

	[Token(Token = "0x60073FB")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073FC")]
	[Address(RVA = "0x10F6640", Offset = "0x10F5440", Length = "0x2C0")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x60073FD")]
	[Address(RVA = "0x10F6910", Offset = "0x10F5710", Length = "0x1D5")]
	public Condition_ExitMissionTrigger()
	{
	}
}
