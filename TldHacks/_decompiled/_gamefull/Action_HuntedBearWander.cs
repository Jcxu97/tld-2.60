using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

[Name("Challenge Bear Wander", 0)]
[Description("Makes the Hunted bear wander toward target position")]
[Category("TLD Actions/Challenge/Hunted")]
[Token(Token = "0x2000853")]
public class Action_HuntedBearWander : ActionTask
{
	[Token(Token = "0x4005695")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 posToWanderTo;

	[Token(Token = "0x6004CD1")]
	[Address(RVA = "0xD78E90", Offset = "0xD77C90", Length = "0xB6")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6004CD2")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_HuntedBearWander()
	{
	}
}
