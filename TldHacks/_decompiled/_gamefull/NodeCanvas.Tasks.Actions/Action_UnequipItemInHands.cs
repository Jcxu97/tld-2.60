using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Move Item In Hands To HeldItemPlacementZone", 0)]
[Description("Moves current item in hands to the specified HeldItemPlacementZone")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011DF")]
public class Action_UnequipItemInHands : ActionTask
{
	[Token(Token = "0x400893B")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x6007675")]
	[Address(RVA = "0x1148430", Offset = "0x1147230", Length = "0x2DC")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007676")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_UnequipItemInHands()
	{
	}
}
