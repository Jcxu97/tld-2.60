using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Description("Check if an mission trigger event has been recieved and allow additional trigger data tests.")]
[Name("Enter Mission Trigger (EVENT)", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001126")]
public class Condition_EnterMissionTrigger : ConditionTask
{
	[Token(Token = "0x4008770")]
	[FieldOffset(Offset = "0x68")]
	public bool checkForPlayer;

	[Token(Token = "0x4008771")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> checkForMissionObjectId;

	[Token(Token = "0x4008772")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> checkForTriggerId;

	[Token(Token = "0x4008773")]
	[FieldOffset(Offset = "0x80")]
	public MissionTriggerType triggerType;

	[Token(Token = "0x4008774")]
	[FieldOffset(Offset = "0x88")]
	public string storeAssociatedDataVar;

	[Token(Token = "0x60073F8")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073F9")]
	[Address(RVA = "0x10F6140", Offset = "0x10F4F40", Length = "0x318")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x60073FA")]
	[Address(RVA = "0x10F6460", Offset = "0x10F5260", Length = "0x1D5")]
	public Condition_EnterMissionTrigger()
	{
	}
}
