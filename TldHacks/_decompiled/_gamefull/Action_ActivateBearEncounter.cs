using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

[Name("Activate Bear Encounter", 0)]
[Description("Activate Bear Hunt Encounter")]
[Category("TLD Actions/Code Missions")]
[Token(Token = "0x200084D")]
public class Action_ActivateBearEncounter : ActionTask
{
	[Token(Token = "0x4005682")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x4005683")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> activate;

	[Token(Token = "0x6004CBE")]
	[Address(RVA = "0xD76A00", Offset = "0xD75800", Length = "0xCB")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6004CBF")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ActivateBearEncounter()
	{
	}
}
