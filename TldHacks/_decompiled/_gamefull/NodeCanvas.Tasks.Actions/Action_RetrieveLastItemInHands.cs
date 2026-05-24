using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Retrieve Item From HeldItemPlacementZone", 0)]
[Description("Retrives stored item from the specified HeldItemPlacementZone")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011E0")]
public class Action_RetrieveLastItemInHands : ActionTask
{
	[Token(Token = "0x400893C")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x6007677")]
	[Address(RVA = "0x1148710", Offset = "0x1147510", Length = "0x2DE")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007678")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_RetrieveLastItemInHands()
	{
	}
}
