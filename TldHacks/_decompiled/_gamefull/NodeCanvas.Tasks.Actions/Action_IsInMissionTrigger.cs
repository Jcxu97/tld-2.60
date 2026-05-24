using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Is In Mission Trigger", 0)]
[Category("TLD Actions")]
[Token(Token = "0x20011E9")]
public class Action_IsInMissionTrigger : ActionTask<GraphOwner>
{
	[Token(Token = "0x400894B")]
	[FieldOffset(Offset = "0x68")]
	public bool checkForPlayer;

	[Token(Token = "0x400894C")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> checkForMissionObjectId;

	[Token(Token = "0x400894D")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> checkForTriggerId;

	[Token(Token = "0x400894E")]
	[FieldOffset(Offset = "0x80")]
	public MissionTriggerType triggerType;

	[Token(Token = "0x400894F")]
	[FieldOffset(Offset = "0x88")]
	public string storeAssociatedDataVar;

	[Token(Token = "0x4008950")]
	[FieldOffset(Offset = "0x90")]
	public string successEvent;

	[Token(Token = "0x4008951")]
	[FieldOffset(Offset = "0x98")]
	public string failureEvent;

	[Token(Token = "0x6007696")]
	[Address(RVA = "0x114AAA0", Offset = "0x11498A0", Length = "0x452")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007697")]
	[Address(RVA = "0x114AF00", Offset = "0x1149D00", Length = "0x2D5")]
	public Action_IsInMissionTrigger()
	{
	}
}
