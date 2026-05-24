using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

[Name("Set Bear Encounter Last", 0)]
[Description("Set a Bear Hunt Encounter as a final one")]
[Category("TLD Actions/Code Missions")]
[Token(Token = "0x200084E")]
public class Action_SetBearEncounterLast : ActionTask
{
	[Token(Token = "0x4005684")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x4005685")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> isLast;

	[Token(Token = "0x6004CC0")]
	[Address(RVA = "0xD76AD0", Offset = "0xD758D0", Length = "0xCB")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6004CC1")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetBearEncounterLast()
	{
	}
}
