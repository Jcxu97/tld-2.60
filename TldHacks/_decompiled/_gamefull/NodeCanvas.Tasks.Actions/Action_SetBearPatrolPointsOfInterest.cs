using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("SetPatrolPointsOfInterest", 0)]
[Description("Starts patrolling points of interest, which means they move from location to location, performing the action specified for the duration")]
[Category("TLD/AI")]
[Token(Token = "0x20011B2")]
public class Action_SetBearPatrolPointsOfInterest : TLD_Action
{
	[Token(Token = "0x40088BB")]
	[FieldOffset(Offset = "0x78")]
	public List<BaseAi.PointOfInterest> pointsOfInterest;

	[Token(Token = "0x40088BC")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> randomizeOrder;

	[Token(Token = "0x60075EE")]
	[Address(RVA = "0x1114C00", Offset = "0x1113A00", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075EF")]
	[Address(RVA = "0x1114C30", Offset = "0x1113A30", Length = "0x23E")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60075F0")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetBearPatrolPointsOfInterest()
	{
	}
}
