using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD/AI")]
[Name("SetBaseAiStateFollowWaypoint", 0)]
[Description("Sets the baseai state on the agent")]
[Token(Token = "0x20011AB")]
public class Action_SetBaseAIStateFollowWaypoint : TLD_Action
{
	[Token(Token = "0x40088AA")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> path;

	[Token(Token = "0x40088AB")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> disableScanForTargets;

	[Token(Token = "0x40088AC")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<bool> doOverride;

	[Token(Token = "0x40088AD")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<float> overrideSpeed;

	[Token(Token = "0x40088AE")]
	[FieldOffset(Offset = "0x98")]
	public BBParameter<BaseAi.WaypointCompletionBehaviouir> waypointCompletionBehaviouir;

	[Token(Token = "0x40088AF")]
	[FieldOffset(Offset = "0xA0")]
	public BBParameter<AiMode> nextState;

	[Token(Token = "0x60075DB")]
	[Address(RVA = "0x1112700", Offset = "0x1111500", Length = "0x3D2")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075DC")]
	[Address(RVA = "0x1112AE0", Offset = "0x11118E0", Length = "0xA3")]
	public Action_SetBaseAIStateFollowWaypoint()
	{
	}
}
