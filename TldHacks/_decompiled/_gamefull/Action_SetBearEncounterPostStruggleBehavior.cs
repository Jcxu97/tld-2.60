using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

[Name("Set Bear Encounter Post Struggle Behavior", 0)]
[Description("Set a Bear Hunt Encounter post struggle behavior")]
[Category("TLD Actions/Code Missions")]
[Token(Token = "0x200084F")]
public class Action_SetBearEncounterPostStruggleBehavior : ActionTask
{
	[Token(Token = "0x4005686")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x4005687")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<BearEncounter.PostStruggleBehavior> postStruggleBehavior;

	[Token(Token = "0x6004CC2")]
	[Address(RVA = "0xD76BA0", Offset = "0xD759A0", Length = "0x220")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6004CC3")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetBearEncounterPostStruggleBehavior()
	{
	}
}
