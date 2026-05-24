using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("SetBaseAiWaypointPath", 0)]
[Description("Sets the waypoint path on a baseai")]
[Category("TLD Actions/BaseAi")]
[Token(Token = "0x20011AD")]
public class Action_SetBaseAiWaypointPath : TLD_Action
{
	[Token(Token = "0x40088B1")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> path;

	[Token(Token = "0x40088B2")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> disableScanForTargets;

	[Token(Token = "0x60075E0")]
	[Address(RVA = "0x1112E00", Offset = "0x1111C00", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075E1")]
	[Address(RVA = "0x1112E30", Offset = "0x1111C30", Length = "0x322")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60075E2")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetBaseAiWaypointPath()
	{
	}
}
