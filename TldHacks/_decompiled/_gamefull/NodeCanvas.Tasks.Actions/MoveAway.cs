using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Movement/Direct")]
[Description("Moves the agent away from target per frame without pathfinding")]
[Token(Token = "0x20012DD")]
public class MoveAway : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008C2A")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x4008C2B")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> speed;

	[Token(Token = "0x4008C2C")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> stopDistance;

	[Token(Token = "0x4008C2D")]
	[FieldOffset(Offset = "0x80")]
	public bool waitActionFinish;

	[Token(Token = "0x600795B")]
	[Address(RVA = "0x117AFD0", Offset = "0x1179DD0", Length = "0x5CF")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600795C")]
	[Address(RVA = "0x117B5A0", Offset = "0x117A3A0", Length = "0x122")]
	public MoveAway()
	{
	}
}
