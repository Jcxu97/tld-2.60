using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Name("Inside Mission Trigger", 0)]
[Token(Token = "0x2001128")]
public class Condition_InsideMissionTrigger : ConditionTask
{
	[Token(Token = "0x400877A")]
	[FieldOffset(Offset = "0x68")]
	public bool checkForPlayer;

	[Token(Token = "0x400877B")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> checkForMissionObjectId;

	[Token(Token = "0x400877C")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> checkForTriggerId;

	[Token(Token = "0x400877D")]
	[FieldOffset(Offset = "0x80")]
	public MissionTriggerType triggerType;

	[Token(Token = "0x60073FE")]
	[Address(RVA = "0x10F6AF0", Offset = "0x10F58F0", Length = "0x2EE")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073FF")]
	[Address(RVA = "0x10F6DE0", Offset = "0x10F5BE0", Length = "0x1D5")]
	public Condition_InsideMissionTrigger()
	{
	}
}
